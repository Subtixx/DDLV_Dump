using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Meta.Missions;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000563")]
	public class HudQuestTrackerModel : CustomeElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700056F")]
		public MissionSlot MissionSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600232D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CMissionSlot_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600232E")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CMissionSlot_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000570")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4001D55")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x600232F")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002330")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6002331")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public override void UpdateDisplay(CustomElement element)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002332")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public HudQuestTrackerModel()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
