using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ScreamCollectorSimonBot
{
	public partial class MainForm : Form
	{
		private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
		private const int MOUSEEVENTF_LEFTUP = 0x0004;
		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		#pragma warning disable IDE1006 // Naming Styles
		private static extern void mouse_event(int dwflags, int dx, int dy, int cbuttons, int dwExtraInfo);
		#pragma warning restore IDE1006 // Naming Styles
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern bool GetCursorPos(out Point lpPoint);
		[DllImport("user32.dll")]
		private static extern int GetAsyncKeyState(Keys vkeys);
		[DllImport("user32.dll")]
		private static extern IntPtr GetDC(IntPtr hwnd);
		[DllImport("user32.dll")]
		private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);
		[DllImport("gdi32.dll")]
		private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

		/// <summary>
		/// Positions of the house windows that glows red. Counting from the top left corner of the screen.
		/// </summary>
		private List<int[]> screenPositionList = new List<int[]> {
			new int[] { 728, 279 },
			new int[] { 625, 349 },
			new int[] { 690, 496 },
			new int[] { 807, 530 },
			new int[] { 733, 620 },
			new int[] { 672, 620 },
			new int[] { 533, 687 },
			new int[] { 844, 755 }
		};

		/// <summary>
		/// Maximum level to play. When the bot reach this level will stop.
		/// </summary>
		private int maxLevel = 25;

		private List<int> simonPositions = new List<int>();

		private int lastLevelPlayed;

		private bool isPlaying = false;

		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Starts the bot.
		/// </summary>
		private void StartBot()
		{
			//Reset variables
			lastLevelPlayed = (int) (levelToStartNumericUpDown.Value - 1);
			simonPositions.Clear();

			//Update UI
			levelToStartNumericUpDown.Enabled = false;
			startButton.Text = "STOP";
			statusLabel.Text = "Playing...";
			levelLabel.Text = "Level: " + levelToStartNumericUpDown.Value;

			isPlaying = true;

			loopTimer.Start();
		}

		/// <summary>
		/// Stops the bot.
		/// </summary>
		private void StopBot()
		{
			isPlaying = false;
			loopTimer.Stop();

			//Update UI
			levelToStartNumericUpDown.Enabled = true;
			startButton.Text = "PLAY";
			statusLabel.Text = "Stopped!";
		}

		/// <summary>
		/// Click each position stored in simonPositions list.
		/// </summary>
		private void DoTheSimon()
		{
			foreach (int i in simonPositions)
			{
				Thread.Sleep(500);
				MoveMouse(screenPositionList[i][0], screenPositionList[i][1]);
				ClickMouse();
			}

			Thread.Sleep(30);
			if (isPlaying)
			{
				if (lastLevelPlayed < maxLevel)
				{
					loopTimer.Start();
					levelLabel.Text = "Level: " + (lastLevelPlayed + 1);
				}
				else
				{
					isPlaying = false;

					//Update UI
					levelToStartNumericUpDown.Enabled = true;
					statusLabel.Text = "Completed!";
					startButton.Text = "PLAY";
				}
			}
			simonPositions.Clear();
		}

		/// <summary>
		/// Return the color of the pixel on the given coordinates.
		/// </summary>
		/// <param name="x">X coordinate</param>
		/// <param name="y">Y coordinate</param>
		/// <returns>The color of the pixel</returns>
		private Color GetPixelColor(int x, int y)
		{
			IntPtr hdc = GetDC(IntPtr.Zero);
			uint pixel = GetPixel(hdc, x, y);
			ReleaseDC(IntPtr.Zero, hdc);
			Color color = Color.FromArgb((int)(pixel & 0x000000FF),
						 (int)(pixel & 0x0000FF00) >> 8,
						 (int)(pixel & 0x00FF0000) >> 16);
			return color;
		}

		#region MouseEvents
		/// <summary>
		/// Move the mouse pointer to the given coordinates.
		/// </summary>
		/// <param name="x">X coordinate</param>
		/// <param name="y">Y coordinate</param>
		private void MoveMouse(int x, int y)
		{
			Cursor.Position = new Point(x, y);
		}

		/// <summary>
		/// Perform a mouse click.
		/// </summary>
		private void ClickMouse()
		{
			mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
			mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
		}
		#endregion

		#region Timers
		/// <summary>
		/// Timer Tick to read the keys input.
		/// </summary>
		private void KeysTimer_Tick(object sender, EventArgs e)
		{
			if (GetAsyncKeyState(Keys.F7) != 0)
			{
				StartBot();
			}

			if (GetAsyncKeyState(Keys.F8) != 0)
			{
				StopBot();
			}
		}

		private void LoopTimer_Tick(object sender, EventArgs e)
		{
			bool foundColor = false;

			for (int i = 0; i < screenPositionList.Count; i++)
			{
				Color pixelColor = GetPixelColor(screenPositionList[i][0], screenPositionList[i][1]);

				if (pixelColor.R > 90 && pixelColor.G < 100 && pixelColor.B < 100)
				{
					simonPositions.Add(i);
					foundColor = true;
					break;
				}
			}

			if (foundColor)
			{
				if (simonPositions.Count >= lastLevelPlayed + 1)
				{
					loopTimer.Stop();
					lastLevelPlayed++;
					DoTheSimon();
				}
				else
				{
					Thread.Sleep(300);
				}
			}
		}
		#endregion

		#region UiEvents
		/// <summary>
		/// Start/Stop button click event.
		/// </summary>
		private void StartButton_Click(object sender, EventArgs e)
		{
			if (!isPlaying)
			{
				StartBot();
			}
			else
			{
				StopBot();
			}
		}
		#endregion
	}
}
