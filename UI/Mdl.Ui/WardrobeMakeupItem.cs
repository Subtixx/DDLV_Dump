using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200078D")]
	public class WardrobeMakeupItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002BF2")]
		public MakeupItemData ItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002BF3")]
		[HideInInspector]
		public MakeupColor AssociatedMakeupColor;

		[Cpp2IlInjected.Token(Token = "0x170006CF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x68"), Cpp2IlInjected.Token(Token = "0x4002BF1")]
		public bool IsOwned
		{
			[Cpp2IlInjected.Token(Token = "0x600303F")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003040")]
			[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x6003041")]
		[Cpp2IlInjected.Address(RVA = "0x14E5970", Offset = "0x14E4370", VA = "0x1814E5970")]
		internal void RefreshDisplay(MakeupItemData data, bool isMale)
		{
			//Discarded unreachable code: IL_0022
			ItemData = data;
			AsyncAtlassedIcon mcIcon = _mcIcon;
			if (isMale)
			{
			}
			string iconAddress_ = data.iconAddress_;
			bool flag = mcIcon.SetIcon(iconAddress_);
		}

		[Cpp2IlInjected.Token(Token = "0x6003042")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void SetWardrobeMode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003043")]
		[Cpp2IlInjected.Address(RVA = "0x88CCA0", Offset = "0x88B6A0", VA = "0x18088CCA0")]
		public WardrobeMakeupItem()
		{
		}
	}
}
