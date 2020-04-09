using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller_Wrapper {
	public struct Vibration {

		public ushort Left;
		public ushort Right;

		public Vibration(ushort Both) : this(Both, Both) {

		}

		public Vibration(ushort Left, ushort Right) {
			this.Left = Left;
			this.Right = Right;
		}

	}
}
