using Cpp2IlInjected;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;

namespace Meta.Duties
{
	[Cpp2IlInjected.Token(Token = "0x20010BA")]
	public sealed class RoyalDutySlotStringResolver : IResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40044E1")]
		private DutySlot _dutySlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40044E2")]
		private Localizator _localizator;

		[Cpp2IlInjected.Token(Token = "0x60087A2")]
		[Cpp2IlInjected.Address(RVA = "0x539250", Offset = "0x537C50", VA = "0x180539250")]
		public RoyalDutySlotStringResolver(DutySlot dutySlot, Localizator localizator)
		{
			_dutySlot = dutySlot;
			_localizator = localizator;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60087A3")]
		[Cpp2IlInjected.Address(RVA = "0x1768920", Offset = "0x1767320", VA = "0x181768920", Slot = "4")]
		public object Resolve(string key)
		{
			//Discarded unreachable code: IL_0017
			DutySlot dutySlot = _dutySlot;
			Localizator localizator = _localizator;
			return dutySlot.ResolveKey(localizator, key);
		}
	}
}
