using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller_Wrapper {
	public class Controller {

		private SharpDX.XInput.Controller controller;
		private Gamepad gamepad;

		public bool Connected { get; private set; } = false;
		public ushort Deadzone { get; set; } = 2500;

		public BatteryInformation Battery { get; set; }
		public Vibration Vibration { get; set; }

		public bool A { get => (gamepad.Buttons & GamepadButtonFlags.A) > 0; }
		public bool B { get => (gamepad.Buttons & GamepadButtonFlags.B) > 0; }
		public bool X { get => (gamepad.Buttons & GamepadButtonFlags.X) > 0; }
		public bool Y { get => (gamepad.Buttons & GamepadButtonFlags.Y) > 0; }
		public bool Start { get => (gamepad.Buttons & GamepadButtonFlags.Start) > 0; }
		public bool Back { get => (gamepad.Buttons & GamepadButtonFlags.Back) > 0; }
		public bool LeftShoulder { get => (gamepad.Buttons & GamepadButtonFlags.LeftShoulder) > 0; }
		public bool RightShoulder { get => (gamepad.Buttons & GamepadButtonFlags.RightShoulder) > 0; }
		public bool DPadUp { get => (gamepad.Buttons & GamepadButtonFlags.DPadUp) > 0; }
		public bool DPadRight { get => (gamepad.Buttons & GamepadButtonFlags.DPadRight) > 0; }
		public bool DPadDown { get => (gamepad.Buttons & GamepadButtonFlags.DPadDown) > 0; }
		public bool DPadLeft { get => (gamepad.Buttons & GamepadButtonFlags.DPadLeft) > 0; }

		public Thumbstick LeftThumbstick { get; set; }
		public Thumbstick RightThumbstick { get; set; }

		public float LeftTrigger { get; set; }
		public float RightTrigger { get; set; }

		public Controller(PlayerIndex index = PlayerIndex.Any) {
			controller = new SharpDX.XInput.Controller((UserIndex)index);
			Connected = controller.IsConnected;
		}

		public bool Update() {
			Connected = controller.IsConnected;
			if (!Connected) return false;
			Battery = new BatteryInformation(controller.GetBatteryInformation(BatteryDeviceType.Gamepad));
			controller.SetVibration(new SharpDX.XInput.Vibration() { LeftMotorSpeed = Vibration.Left, RightMotorSpeed = Vibration.Right });
			gamepad = controller.GetState().Gamepad;

			LeftThumbstick = new Thumbstick(gamepad.LeftThumbX, gamepad.LeftThumbY, (gamepad.Buttons & GamepadButtonFlags.LeftThumb) > 0, Deadzone);
			RightThumbstick = new Thumbstick(gamepad.RightThumbX, gamepad.RightThumbY, (gamepad.Buttons & GamepadButtonFlags.RightThumb) > 0, Deadzone);

			LeftTrigger = (float)gamepad.LeftTrigger / byte.MaxValue;
			RightTrigger = (float)gamepad.RightTrigger / byte.MaxValue;

			return true;
		}

		private float Map(short value, short range) {
			if (((value < 0) && (value > Deadzone)) || ((value >= 0) && (value < Deadzone))) return 0;
			else return (float)value / range;
		}

		public static Controller[] GetAllControllers() {
			return new Controller[] { new Controller(PlayerIndex.One), new Controller(PlayerIndex.Two), new Controller(PlayerIndex.Three), new Controller(PlayerIndex.Four) };
		}

		public static Controller[] GetConnectedControllers() {
			List<Controller> controllers = new List<Controller>();
			Controller controller;

			controller = new Controller(PlayerIndex.One);
			if (controller.Connected) controllers.Add(controller);

			controller = new Controller(PlayerIndex.Two);
			if (controller.Connected) controllers.Add(controller);

			controller = new Controller(PlayerIndex.Three);
			if (controller.Connected) controllers.Add(controller);

			controller = new Controller(PlayerIndex.Four);
			if (controller.Connected) controllers.Add(controller);

			return controllers.ToArray();
		}
	}
}
