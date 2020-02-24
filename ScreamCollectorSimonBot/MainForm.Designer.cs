namespace ScreamCollectorSimonBot
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label label1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.infoLabel = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.loopTimer = new System.Windows.Forms.Timer(this.components);
			this.levelLabel = new System.Windows.Forms.Label();
			this.statusLabel = new System.Windows.Forms.Label();
			this.keysTimer = new System.Windows.Forms.Timer(this.components);
			this.levelToStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
			label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.levelToStartNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// infoLabel
			// 
			this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infoLabel.Location = new System.Drawing.Point(12, 210);
			this.infoLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(228, 16);
			this.infoLabel.TabIndex = 7;
			this.infoLabel.Text = "F7 = Start / F8 = Stop";
			this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(12, 98);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(228, 101);
			this.startButton.TabIndex = 4;
			this.startButton.Text = "START";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// loopTimer
			// 
			this.loopTimer.Interval = 50;
			this.loopTimer.Tick += new System.EventHandler(this.LoopTimer_Tick);
			// 
			// levelLabel
			// 
			this.levelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.levelLabel.Location = new System.Drawing.Point(12, 39);
			this.levelLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.levelLabel.Name = "levelLabel";
			this.levelLabel.Size = new System.Drawing.Size(228, 25);
			this.levelLabel.TabIndex = 5;
			this.levelLabel.Text = "Level";
			this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// statusLabel
			// 
			this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLabel.Location = new System.Drawing.Point(12, 14);
			this.statusLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(228, 25);
			this.statusLabel.TabIndex = 6;
			this.statusLabel.Text = "Ready!";
			this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// keysTimer
			// 
			this.keysTimer.Enabled = true;
			this.keysTimer.Interval = 1;
			this.keysTimer.Tick += new System.EventHandler(this.KeysTimer_Tick);
			// 
			// levelToStartNumericUpDown
			// 
			this.levelToStartNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.levelToStartNumericUpDown.Location = new System.Drawing.Point(101, 72);
			this.levelToStartNumericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.levelToStartNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.levelToStartNumericUpDown.Name = "levelToStartNumericUpDown";
			this.levelToStartNumericUpDown.Size = new System.Drawing.Size(139, 21);
			this.levelToStartNumericUpDown.TabIndex = 8;
			this.levelToStartNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.levelToStartNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label1.Location = new System.Drawing.Point(10, 74);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(84, 16);
			label1.TabIndex = 9;
			label1.Text = "Start at level:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(252, 237);
			this.Controls.Add(label1);
			this.Controls.Add(this.levelToStartNumericUpDown);
			this.Controls.Add(this.infoLabel);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.levelLabel);
			this.Controls.Add(this.startButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Scream Collector Simon Bot";
			((System.ComponentModel.ISupportInitialize)(this.levelToStartNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Timer loopTimer;
		private System.Windows.Forms.Label levelLabel;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Timer keysTimer;
		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.NumericUpDown levelToStartNumericUpDown;
	}
}

