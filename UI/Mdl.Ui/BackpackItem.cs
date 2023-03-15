using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003DE")]
	internal class BackpackItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001307")]
		[SerializeField]
		private AsyncImage mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001308")]
		[SerializeField]
		private TextBase tf_itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001309")]
		[SerializeField]
		private TextBase tf_inventoryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400130A")]
		[SerializeField]
		private Image _mcSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400130B")]
		[SerializeField]
		private StarComponent _mcStar;

		[Cpp2IlInjected.Token(Token = "0x1700040E")]
		internal string IconTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6001896")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CIconTexture_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001897")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CIconTexture_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040F")]
		internal AsyncImage IconAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6001898")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return mc_icon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000410")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x400130D")]
		internal int InventoryCount
		{
			[Cpp2IlInjected.Token(Token = "0x6001899")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600189A")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000411")]
		internal string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x600189B")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CItemName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600189C")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			set
			{
				_003CItemName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000412")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x58"), Cpp2IlInjected.Token(Token = "0x400130F")]
		internal int ItemIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600189D")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600189E")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000413")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x5C"), Cpp2IlInjected.Token(Token = "0x4001310")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600189F")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60018A0")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000414")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60018A1")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6F0", Offset = "0xA5A0F0", VA = "0x180A5B6F0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return _mcSelected.gameObject.activeSelf;
			}
			[Cpp2IlInjected.Token(Token = "0x60018A2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B760", Offset = "0xA5A160", VA = "0x180A5B760")]
			set
			{
				//Discarded unreachable code: IL_0012
				_mcSelected.gameObject.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000415")]
		public bool ShowStar
		{
			[Cpp2IlInjected.Token(Token = "0x60018A3")]
			[Cpp2IlInjected.Address(RVA = "0xA5B720", Offset = "0xA5A120", VA = "0x180A5B720")]
			get
			{
				//Discarded unreachable code: IL_0011
				return _mcStar.gameObject.activeSelf;
			}
			[Cpp2IlInjected.Token(Token = "0x60018A4")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7A0", Offset = "0xA5A1A0", VA = "0x180A5B7A0")]
			set
			{
				//Discarded unreachable code: IL_0012
				_mcStar.gameObject.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000416")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x4001311")]
		public int Star
		{
			[Cpp2IlInjected.Token(Token = "0x60018A5")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60018A6")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60018A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B550", Offset = "0xA59F50", VA = "0x180A5B550")]
		internal void Refresh()
		{
			//Discarded unreachable code: IL_00cd
			//IL_0015: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			Image image = mc_icon.Image;
			int num = 0;
			image.sprite = (Sprite)num;
			TextBase textBase = tf_itemName;
			int num2 = 0;
			if (textBase != (Object)num2)
			{
				TextBase textBase2 = tf_itemName;
				string text2 = (textBase2.StringID = ItemName);
			}
			TextBase textBase3 = tf_inventoryCount;
			int num3 = 0;
			if (textBase3 != (Object)num3)
			{
				int num4 = InventoryCount;
				string text3 = default(string);
				tf_inventoryCount.Text = text3;
			}
			AsyncImage asyncImage = mc_icon;
			int num5 = 0;
			if (asyncImage != (Object)num5)
			{
				string text4 = IconTexture;
				if (text4 != null)
				{
					mc_icon.SetSpriteKey(text4);
				}
			}
			if (_mcStar.gameObject.activeSelf)
			{
				StarComponent mcStar = _mcStar;
				int num7 = (mcStar.Star = Star);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018A8")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public BackpackItem()
		{
		}
	}
}
