using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller_Wrapper {
	public struct BatteryInformation {

		BatteryLevel Level;
		BatteryType Type;

		public BatteryInformation(SharpDX.XInput.BatteryInformation info) {
			Level = (BatteryLevel)info.BatteryLevel;
			Type = (BatteryType)info.BatteryType;
		}

	}

	public enum BatteryType {
		Disconnected = SharpDX.XInput.BatteryType.Disconnected,
		Unknown = SharpDX.XInput.BatteryType.Unknown,
		Wired = SharpDX.XInput.BatteryType.Wired,
		Alkaline = SharpDX.XInput.BatteryType.Alkaline,
		Nimh = SharpDX.XInput.BatteryType.Nimh
	}

	public enum BatteryLevel {
		Empty = SharpDX.XInput.BatteryLevel.Empty,
		Low = SharpDX.XInput.BatteryLevel.Low,
		Medium = SharpDX.XInput.BatteryLevel.Medium,
		Full = SharpDX.XInput.BatteryLevel.Full
	}
}
