using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller_Wrapper {
	public struct Thumbstick {

		public float X;
		public float Y;
		public bool Button;

		internal Thumbstick(short x, short y, bool btn, ushort deadzone) {
			X = Map(x, deadzone);
			Y = Map(y, deadzone);
			Button = btn;
		}

		private static float Map(short value, ushort deadzone) {
			if (((value < 0) && (value > deadzone)) || ((value >= 0) && (value < deadzone))) return 0;
			else return (float)value / short.MaxValue;
		}

	}
}
