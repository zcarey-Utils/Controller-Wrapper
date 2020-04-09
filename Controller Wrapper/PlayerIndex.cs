using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller_Wrapper {
	public enum PlayerIndex {
		One = UserIndex.One,
		Two = UserIndex.Two,
		Three = UserIndex.Three,
		Four = UserIndex.Four,
		Any = UserIndex.Any
	}

	public static class PlayerIndexExtensions {

		public static int ToNumber(this PlayerIndex index) {
			switch (index) {
				case PlayerIndex.One: return 1;
				case PlayerIndex.Two: return 2;
				case PlayerIndex.Three: return 3;
				case PlayerIndex.Four: return 4;
				default: return 0;
			}
		}

	}
}
