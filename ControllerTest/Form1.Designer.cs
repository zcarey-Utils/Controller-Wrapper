namespace ControllerTest {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.LeftPointer = new Meters.DoubleAxisPointer();
			this.RightPointer = new Meters.DoubleAxisPointer();
			this.LeftTrigger = new Meters.LinearMeter();
			this.RightTrigger = new Meters.LinearMeter();
			this.HatMeter = new Meters.DirectionalMeter();
			this.ABtn = new Meters.IOMeter();
			this.BBtn = new Meters.IOMeter();
			this.XBtn = new Meters.IOMeter();
			this.YBtn = new Meters.IOMeter();
			this.ConnectBtn = new System.Windows.Forms.Button();
			this.ConnectLabel = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.LBtn = new Meters.IOMeter();
			this.RBtn = new Meters.IOMeter();
			this.LStick = new Meters.IOMeter();
			this.RStick = new Meters.IOMeter();
			this.BackBtn = new Meters.IOMeter();
			this.StartBtn = new Meters.IOMeter();
			this.VibrateBar = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.VibrateBar)).BeginInit();
			this.SuspendLayout();
			// 
			// LeftPointer
			// 
			this.LeftPointer.BackColor = System.Drawing.Color.White;
			this.LeftPointer.BorderColor = System.Drawing.Color.Black;
			this.LeftPointer.Location = new System.Drawing.Point(38, 12);
			this.LeftPointer.MeterColor = System.Drawing.Color.Red;
			this.LeftPointer.MeterRadius = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.LeftPointer.Name = "LeftPointer";
			this.LeftPointer.Size = new System.Drawing.Size(200, 200);
			this.LeftPointer.TabIndex = 0;
			this.LeftPointer.XInverse = false;
			this.LeftPointer.XMaximum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.LeftPointer.XMinimum = new decimal(new int[] {
			1,
			0,
			0,
			-2147483648});
			this.LeftPointer.XValue = new decimal(new int[] {
			0,
			0,
			0,
			0});
			this.LeftPointer.YInverse = false;
			this.LeftPointer.YMaximum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.LeftPointer.YMinimum = new decimal(new int[] {
			1,
			0,
			0,
			-2147483648});
			this.LeftPointer.YValue = new decimal(new int[] {
			0,
			0,
			0,
			0});
			// 
			// RightPointer
			// 
			this.RightPointer.BackColor = System.Drawing.Color.White;
			this.RightPointer.BorderColor = System.Drawing.Color.Black;
			this.RightPointer.Location = new System.Drawing.Point(244, 12);
			this.RightPointer.MeterColor = System.Drawing.Color.Red;
			this.RightPointer.MeterRadius = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.RightPointer.Name = "RightPointer";
			this.RightPointer.Size = new System.Drawing.Size(200, 200);
			this.RightPointer.TabIndex = 1;
			this.RightPointer.XInverse = false;
			this.RightPointer.XMaximum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.RightPointer.XMinimum = new decimal(new int[] {
			1,
			0,
			0,
			-2147483648});
			this.RightPointer.XValue = new decimal(new int[] {
			0,
			0,
			0,
			0});
			this.RightPointer.YInverse = false;
			this.RightPointer.YMaximum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.RightPointer.YMinimum = new decimal(new int[] {
			1,
			0,
			0,
			-2147483648});
			this.RightPointer.YValue = new decimal(new int[] {
			0,
			0,
			0,
			0});
			// 
			// LeftTrigger
			// 
			this.LeftTrigger.BackColor = System.Drawing.Color.White;
			this.LeftTrigger.BorderColor = System.Drawing.Color.Black;
			this.LeftTrigger.Horizontal = false;
			this.LeftTrigger.Inverse = false;
			this.LeftTrigger.Location = new System.Drawing.Point(12, 12);
			this.LeftTrigger.Maximum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.LeftTrigger.MeterColor = System.Drawing.Color.Red;
			this.LeftTrigger.Minimum = new decimal(new int[] {
			0,
			0,
			0,
			0});
			this.LeftTrigger.Name = "LeftTrigger";
			this.LeftTrigger.Size = new System.Drawing.Size(20, 200);
			this.LeftTrigger.TabIndex = 2;
			this.LeftTrigger.Value = new decimal(new int[] {
			0,
			0,
			0,
			0});
			this.LeftTrigger.ZeroValue = new decimal(new int[] {
			0,
			0,
			0,
			0});
			// 
			// RightTrigger
			// 
			this.RightTrigger.BackColor = System.Drawing.Color.White;
			this.RightTrigger.BorderColor = System.Drawing.Color.Black;
			this.RightTrigger.Horizontal = false;
			this.RightTrigger.Inverse = false;
			this.RightTrigger.Location = new System.Drawing.Point(450, 12);
			this.RightTrigger.Maximum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.RightTrigger.MeterColor = System.Drawing.Color.Red;
			this.RightTrigger.Minimum = new decimal(new int[] {
			0,
			0,
			0,
			0});
			this.RightTrigger.Name = "RightTrigger";
			this.RightTrigger.Size = new System.Drawing.Size(20, 200);
			this.RightTrigger.TabIndex = 3;
			this.RightTrigger.Value = new decimal(new int[] {
			0,
			0,
			0,
			0});
			this.RightTrigger.ZeroValue = new decimal(new int[] {
			0,
			0,
			0,
			0});
			// 
			// HatMeter
			// 
			this.HatMeter.Location = new System.Drawing.Point(476, 12);
			this.HatMeter.Name = "HatMeter";
			this.HatMeter.OffColor = System.Drawing.Color.Blue;
			this.HatMeter.OnColor = System.Drawing.Color.OrangeRed;
			this.HatMeter.Size = new System.Drawing.Size(241, 200);
			this.HatMeter.TabIndex = 4;
			this.HatMeter.Value = Meters.POVDirection.Center;
			// 
			// ABtn
			// 
			this.ABtn.BorderColor = System.Drawing.Color.Black;
			this.ABtn.Location = new System.Drawing.Point(224, 309);
			this.ABtn.Name = "ABtn";
			this.ABtn.OffColor = System.Drawing.Color.Firebrick;
			this.ABtn.OnColor = System.Drawing.Color.Red;
			this.ABtn.Size = new System.Drawing.Size(35, 35);
			this.ABtn.Style = Meters.ButtonStyle.Round;
			this.ABtn.TabIndex = 5;
			this.ABtn.Text = "A";
			this.ABtn.UseVisualStyleBackColor = true;
			this.ABtn.Value = false;
			// 
			// BBtn
			// 
			this.BBtn.BorderColor = System.Drawing.Color.Black;
			this.BBtn.Location = new System.Drawing.Point(264, 273);
			this.BBtn.Name = "BBtn";
			this.BBtn.OffColor = System.Drawing.Color.Firebrick;
			this.BBtn.OnColor = System.Drawing.Color.Red;
			this.BBtn.Size = new System.Drawing.Size(35, 35);
			this.BBtn.Style = Meters.ButtonStyle.Round;
			this.BBtn.TabIndex = 6;
			this.BBtn.Text = "B";
			this.BBtn.UseVisualStyleBackColor = true;
			this.BBtn.Value = false;
			// 
			// XBtn
			// 
			this.XBtn.BorderColor = System.Drawing.Color.Black;
			this.XBtn.Location = new System.Drawing.Point(183, 273);
			this.XBtn.Name = "XBtn";
			this.XBtn.OffColor = System.Drawing.Color.Firebrick;
			this.XBtn.OnColor = System.Drawing.Color.Red;
			this.XBtn.Size = new System.Drawing.Size(35, 35);
			this.XBtn.Style = Meters.ButtonStyle.Round;
			this.XBtn.TabIndex = 7;
			this.XBtn.Text = "X";
			this.XBtn.UseVisualStyleBackColor = true;
			this.XBtn.Value = false;
			// 
			// YBtn
			// 
			this.YBtn.BorderColor = System.Drawing.Color.Black;
			this.YBtn.Location = new System.Drawing.Point(224, 233);
			this.YBtn.Name = "YBtn";
			this.YBtn.OffColor = System.Drawing.Color.Firebrick;
			this.YBtn.OnColor = System.Drawing.Color.Red;
			this.YBtn.Size = new System.Drawing.Size(35, 35);
			this.YBtn.Style = Meters.ButtonStyle.Round;
			this.YBtn.TabIndex = 8;
			this.YBtn.Text = "Y";
			this.YBtn.UseVisualStyleBackColor = true;
			this.YBtn.Value = false;
			// 
			// ConnectBtn
			// 
			this.ConnectBtn.Location = new System.Drawing.Point(629, 222);
			this.ConnectBtn.Name = "ConnectBtn";
			this.ConnectBtn.Size = new System.Drawing.Size(88, 31);
			this.ConnectBtn.TabIndex = 9;
			this.ConnectBtn.Text = "Connect";
			this.ConnectBtn.UseVisualStyleBackColor = true;
			this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
			// 
			// ConnectLabel
			// 
			this.ConnectLabel.AutoSize = true;
			this.ConnectLabel.Location = new System.Drawing.Point(626, 259);
			this.ConnectLabel.Name = "ConnectLabel";
			this.ConnectLabel.Size = new System.Drawing.Size(102, 17);
			this.ConnectLabel.TabIndex = 10;
			this.ConnectLabel.Text = "Not Connected";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 33;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// LBtn
			// 
			this.LBtn.BorderColor = System.Drawing.Color.Black;
			this.LBtn.Location = new System.Drawing.Point(12, 218);
			this.LBtn.Name = "LBtn";
			this.LBtn.OffColor = System.Drawing.Color.Firebrick;
			this.LBtn.OnColor = System.Drawing.Color.Red;
			this.LBtn.Size = new System.Drawing.Size(35, 35);
			this.LBtn.Style = Meters.ButtonStyle.Round;
			this.LBtn.TabIndex = 11;
			this.LBtn.Text = "L";
			this.LBtn.UseVisualStyleBackColor = true;
			this.LBtn.Value = false;
			// 
			// RBtn
			// 
			this.RBtn.BorderColor = System.Drawing.Color.Black;
			this.RBtn.Location = new System.Drawing.Point(435, 218);
			this.RBtn.Name = "RBtn";
			this.RBtn.OffColor = System.Drawing.Color.Firebrick;
			this.RBtn.OnColor = System.Drawing.Color.Red;
			this.RBtn.Size = new System.Drawing.Size(35, 35);
			this.RBtn.Style = Meters.ButtonStyle.Round;
			this.RBtn.TabIndex = 12;
			this.RBtn.Text = "R";
			this.RBtn.UseVisualStyleBackColor = true;
			this.RBtn.Value = false;
			// 
			// LStick
			// 
			this.LStick.BorderColor = System.Drawing.Color.Black;
			this.LStick.Location = new System.Drawing.Point(127, 218);
			this.LStick.Name = "LStick";
			this.LStick.OffColor = System.Drawing.Color.Firebrick;
			this.LStick.OnColor = System.Drawing.Color.Red;
			this.LStick.Size = new System.Drawing.Size(35, 35);
			this.LStick.Style = Meters.ButtonStyle.Round;
			this.LStick.TabIndex = 13;
			this.LStick.Text = "L";
			this.LStick.UseVisualStyleBackColor = true;
			this.LStick.Value = false;
			// 
			// RStick
			// 
			this.RStick.BorderColor = System.Drawing.Color.Black;
			this.RStick.Location = new System.Drawing.Point(342, 218);
			this.RStick.Name = "RStick";
			this.RStick.OffColor = System.Drawing.Color.Firebrick;
			this.RStick.OnColor = System.Drawing.Color.Red;
			this.RStick.Size = new System.Drawing.Size(35, 35);
			this.RStick.Style = Meters.ButtonStyle.Round;
			this.RStick.TabIndex = 14;
			this.RStick.Text = "R";
			this.RStick.UseVisualStyleBackColor = true;
			this.RStick.Value = false;
			// 
			// BackBtn
			// 
			this.BackBtn.BorderColor = System.Drawing.Color.Black;
			this.BackBtn.Location = new System.Drawing.Point(342, 308);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.OffColor = System.Drawing.Color.Firebrick;
			this.BackBtn.OnColor = System.Drawing.Color.Red;
			this.BackBtn.Size = new System.Drawing.Size(35, 35);
			this.BackBtn.Style = Meters.ButtonStyle.Round;
			this.BackBtn.TabIndex = 15;
			this.BackBtn.Text = "B";
			this.BackBtn.UseVisualStyleBackColor = true;
			this.BackBtn.Value = false;
			// 
			// StartBtn
			// 
			this.StartBtn.BorderColor = System.Drawing.Color.Black;
			this.StartBtn.Location = new System.Drawing.Point(383, 308);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.OffColor = System.Drawing.Color.Firebrick;
			this.StartBtn.OnColor = System.Drawing.Color.Red;
			this.StartBtn.Size = new System.Drawing.Size(35, 35);
			this.StartBtn.Style = Meters.ButtonStyle.Round;
			this.StartBtn.TabIndex = 16;
			this.StartBtn.Text = "S";
			this.StartBtn.UseVisualStyleBackColor = true;
			this.StartBtn.Value = false;
			// 
			// VibrateBar
			// 
			this.VibrateBar.Location = new System.Drawing.Point(435, 299);
			this.VibrateBar.Maximum = 65535;
			this.VibrateBar.Name = "VibrateBar";
			this.VibrateBar.Size = new System.Drawing.Size(282, 56);
			this.VibrateBar.TabIndex = 17;
			this.VibrateBar.Scroll += new System.EventHandler(this.VibrateBar_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(435, 273);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "Vibration";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 355);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.VibrateBar);
			this.Controls.Add(this.StartBtn);
			this.Controls.Add(this.BackBtn);
			this.Controls.Add(this.RStick);
			this.Controls.Add(this.LStick);
			this.Controls.Add(this.RBtn);
			this.Controls.Add(this.LBtn);
			this.Controls.Add(this.ConnectLabel);
			this.Controls.Add(this.ConnectBtn);
			this.Controls.Add(this.YBtn);
			this.Controls.Add(this.XBtn);
			this.Controls.Add(this.BBtn);
			this.Controls.Add(this.ABtn);
			this.Controls.Add(this.HatMeter);
			this.Controls.Add(this.RightTrigger);
			this.Controls.Add(this.LeftTrigger);
			this.Controls.Add(this.RightPointer);
			this.Controls.Add(this.LeftPointer);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.VibrateBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Meters.DoubleAxisPointer LeftPointer;
		private Meters.DoubleAxisPointer RightPointer;
		private Meters.LinearMeter LeftTrigger;
		private Meters.LinearMeter RightTrigger;
		private Meters.DirectionalMeter HatMeter;
		private Meters.IOMeter ABtn;
		private Meters.IOMeter BBtn;
		private Meters.IOMeter XBtn;
		private Meters.IOMeter YBtn;
		private System.Windows.Forms.Button ConnectBtn;
		private System.Windows.Forms.Label ConnectLabel;
		private System.Windows.Forms.Timer timer1;
		private Meters.IOMeter LBtn;
		private Meters.IOMeter RBtn;
		private Meters.IOMeter LStick;
		private Meters.IOMeter RStick;
		private Meters.IOMeter BackBtn;
		private Meters.IOMeter StartBtn;
		private System.Windows.Forms.TrackBar VibrateBar;
		private System.Windows.Forms.Label label1;
	}
}

