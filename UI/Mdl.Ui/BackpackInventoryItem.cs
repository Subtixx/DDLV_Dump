using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200034A")]
	public class BackpackInventoryItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000F76")]
		[SerializeField]
		private AsyncAtlassedIcon mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000F77")]
		public RedDot PresentNotificationAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000F78")]
		public TextBase LabelAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000F79")]
		[SerializeField]
		public TextBase tf_inventoryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000F7A")]
		[SerializeField]
		protected RectTransform _mcInventoryCounterContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000F7B")]
		[SerializeField]
		private float _inventoryCountSize = 80f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000F7C")]
		[SerializeField]
		private float _inventoryCountPadding = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000F82")]
		[SerializeField]
		private StarComponent StarAsset;

		[Cpp2IlInjected.Token(Token = "0x1700038D")]
		internal string IconTexture
		{
			[Cpp2IlInjected.Token(Token = "0x60014B1")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			[CompilerGenerated]
			get
			{
				return _003CIconTexture_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60014B2")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			[CompilerGenerated]
			set
			{
				_003CIconTexture_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038E")]
		internal AsyncAtlassedIcon IconAsset
		{
			[Cpp2IlInjected.Token(Token = "0x60014B3")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return mc_icon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA0"), Cpp2IlInjected.Token(Token = "0x4000F7E")]
		internal int InventoryCount
		{
			[Cpp2IlInjected.Token(Token = "0x60014B4")]
			[Cpp2IlInjected.Address(RVA = "0x975DB0", Offset = "0x9747B0", VA = "0x180975DB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014B5")]
			[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x974F80", VA = "0x180976580")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000390")]
		internal string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60014B6")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			[CompilerGenerated]
			get
			{
				return _003CItemName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60014B7")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACE0", Offset = "0xA596E0", VA = "0x180A5ACE0")]
			[CompilerGenerated]
			set
			{
				_003CItemName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000391")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB0"), Cpp2IlInjected.Token(Token = "0x4000F80")]
		internal int ItemIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60014B8")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACB0", Offset = "0xA596B0", VA = "0x180A5ACB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014B9")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACD0", Offset = "0xA596D0", VA = "0x180A5ACD0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000392")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xB4"), Cpp2IlInjected.Token(Token = "0x4000F81")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60014BA")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACC0", Offset = "0xA596C0", VA = "0x180A5ACC0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014BB")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACF0", Offset = "0xA596F0", VA = "0x180A5ACF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60014BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A960", Offset = "0xA59360", VA = "0x180A5A960", Slot = "9")]
		internal virtual void Refresh()
		{
			//Discarded unreachable code: IL_00dc
			//IL_0012: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_00bc: Expected O, but got I4
			int num = 0;
			TextBase labelAsset = LabelAsset;
			int num2 = 0;
			if (labelAsset != (Object)num2)
			{
				TextBase labelAsset2 = LabelAsset;
				string text2 = (labelAsset2.StringID = ItemName);
			}
			TextBase textBase = tf_inventoryCount;
			int num3 = 0;
			if (textBase != (Object)num3)
			{
				GameObject gameObject = _mcInventoryCounterContent.gameObject;
				bool active = InventoryCount > num;
				gameObject.SetActive(active);
				int num4 = InventoryCount;
				string text3 = default(string);
				tf_inventoryCount.Text = text3;
				if ((object)tf_inventoryCount.transform != null)
				{
				}
				TextBase textBase2 = tf_inventoryCount;
				RectTransform mcInventoryCounterContent = _mcInventoryCounterContent;
				Transform transform = textBase2.transform;
				float inventoryCountSize = _inventoryCountSize;
			}
			AsyncAtlassedIcon asyncAtlassedIcon = mc_icon;
			int num5 = 0;
			if (asyncAtlassedIcon != (Object)num5)
			{
				string text4 = IconTexture;
				if (text4 != null)
				{
					bool flag = mc_icon.SetIcon(text4);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC30", Offset = "0xA59630", VA = "0x180A5AC30", Slot = "10")]
		public virtual void SetStarCount(int count)
		{
			//Discarded unreachable code: IL_0025
			GameObject gameObject = StarAsset.gameObject;
			bool active = count > 0;
			gameObject.SetActive(active);
			StarAsset.Star = count;
		}

		[Cpp2IlInjected.Token(Token = "0x60014BE")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC90", Offset = "0xA59690", VA = "0x180A5AC90")]
		public BackpackInventoryItem()
		{
			ShowSelected = true;
			((MonoBehaviour)this)._002Ector();
		}
	}
}
