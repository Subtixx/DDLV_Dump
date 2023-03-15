using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004B9")]
	public class FtueClothingItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40018DD")]
		public ClothingItemData ClothingItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40018DE")]
		public Button Button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40018DF")]
		public TextBase Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40018E0")]
		public bool IsMale;

		[Cpp2IlInjected.Token(Token = "0x6001ED6")]
		[Cpp2IlInjected.Address(RVA = "0x166E430", Offset = "0x166CE30", VA = "0x18166E430")]
		public void Refresh()
		{
			//Discarded unreachable code: IL_007a
			//IL_0010: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			AsyncAtlassedIcon mcIcon = _mcIcon;
			int num = 0;
			if (mcIcon != (Object)num)
			{
				ClothingItemData clothingItem = ClothingItem;
				if (clothingItem != null)
				{
					AsyncAtlassedIcon mcIcon2 = _mcIcon;
					if (IsMale)
					{
					}
					string iconAddress_ = clothingItem.iconAddress_;
					bool flag = mcIcon2.SetIcon(iconAddress_);
				}
			}
			TextBase textBase = Name;
			int num2 = 0;
			if (textBase != (Object)num2)
			{
				ClothingItemData clothingItem2 = ClothingItem;
				TextBase textBase2 = Name;
				string text = (textBase2.StringID = clothingItem2.displayName_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ED7")]
		[Cpp2IlInjected.Address(RVA = "0x166E400", Offset = "0x166CE00", VA = "0x18166E400")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0011
			Button.m_OnClick.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ED8")]
		[Cpp2IlInjected.Address(RVA = "0x88CCA0", Offset = "0x88B6A0", VA = "0x18088CCA0")]
		public FtueClothingItem()
		{
		}
	}
}
