using Controller_Wrapper;
using Meters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerTest {
	public partial class Form1 : Form {

		private Controller controller;

		public Form1() {
			InitializeComponent();
		}

		private void ConnectBtn_Click(object sender, EventArgs e) {
			controller = new Controller(PlayerIndex.One);
			VibrateBar_Scroll(null, null);
		}

		private float constrain(float value) {
			return Math.Max(-1f, Math.Min(1f, value));
		}

		private void timer1_Tick(object sender, EventArgs e) {
			if (controller?.Connected ?? false) {
				ConnectLabel.Text = "Connected";
				controller.Update();

				LeftPointer.XValue = (decimal)constrain(controller.LeftThumbstick.X);
				LeftPointer.YValue = (decimal)constrain(controller.LeftThumbstick.Y);
				RightPointer.XValue = (decimal)constrain(controller.RightThumbstick.X);
				RightPointer.YValue = (decimal)constrain(controller.RightThumbstick.Y);
				LeftTrigger.Value = (decimal)Math.Max(0f, constrain(controller.LeftTrigger));
				RightTrigger.Value = (decimal)Math.Max(0f, constrain(controller.RightTrigger));
				LBtn.Value = controller.LeftShoulder;
				RBtn.Value = controller.RightShoulder;
				ABtn.Value = controller.A;
				BBtn.Value = controller.B;
				XBtn.Value = controller.X;
				YBtn.Value = controller.Y;
				LStick.Value = controller.LeftThumbstick.Button;
				RStick.Value = controller.RightThumbstick.Button;
				BackBtn.Value = controller.Back;
				StartBtn.Value = controller.Start;
				HatMeter.Value = getHatDirection();
			} else {
				ConnectLabel.Text = "Not Connected";

				LeftPointer.XValue = 0;
				LeftPointer.YValue = 0;
				RightPointer.XValue = 0;
				RightPointer.YValue = 0;
				LeftTrigger.Value = 0;
				RightTrigger.Value = 0;
				LBtn.Value = false;
				RBtn.Value = false;
				ABtn.Value = false;
				BBtn.Value = false;
				XBtn.Value = false;
				YBtn.Value = false;
				LStick.Value = false;
				RStick.Value = false;
				BackBtn.Value = false;
				StartBtn.Value = false;
				HatMeter.Value = POVDirection.Center;
			}
		}

		private POVDirection getHatDirection() {
			if (controller.DPadUp) {
				if (controller.DPadRight) return POVDirection.NorthEast;
				else if (controller.DPadLeft) return POVDirection.NorthWest;
				else return POVDirection.North;
			} else if (controller.DPadDown) {
				if (controller.DPadRight) return POVDirection.SouthEast;
				else if (controller.DPadLeft) return POVDirection.SouthWest;
				else return POVDirection.South;
			} else if (controller.DPadLeft) {
				return POVDirection.West;
			} else if (controller.DPadRight) {
				return POVDirection.East;
			} else {
				return POVDirection.Center;
			}
		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void VibrateBar_Scroll(object sender, EventArgs e) {
			if (controller != null) controller.Vibration = new Vibration((ushort)VibrateBar.Value);
		}
	}
}
