using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200104F")]
	public sealed class MissionSlotStringResolver : IResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004341")]
		private MissionSlot _missionSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004342")]
		private Localizator _localizator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004343")]
		private string _stepName;

		[Cpp2IlInjected.Token(Token = "0x6008481")]
		[Cpp2IlInjected.Address(RVA = "0x79F770", Offset = "0x79E170", VA = "0x18079F770")]
		public MissionSlotStringResolver(MissionSlot missionSlot, Localizator localizator, [Optional] string stepName)
		{
			_missionSlot = missionSlot;
			_localizator = localizator;
			_stepName = stepName;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008482")]
		[Cpp2IlInjected.Address(RVA = "0x1A556F0", Offset = "0x1A540F0", VA = "0x181A556F0", Slot = "4")]
		public object Resolve(string key)
		{
			//Discarded unreachable code: IL_001f
			MissionSlot missionSlot = _missionSlot;
			string stepName = _stepName;
			Localizator localizator = _localizator;
			return missionSlot.ResolveKey(localizator, key, stepName);
		}
	}
}
