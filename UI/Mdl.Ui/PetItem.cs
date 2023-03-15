using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000362")]
	[RequiredAllNotNull]
	public class PetItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400105B")]
		private new bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400105C")]
		[SerializeField]
		private GameObject mc_selectedBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400105D")]
		[SerializeField]
		protected AsyncAtlassedIcon mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400105E")]
		[SerializeField]
		protected TextBase _tfItemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400105F")]
		[SerializeField]
		protected StarComponent _mcStar;

		[Cpp2IlInjected.Token(Token = "0x170003BA")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600159C")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600159D")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			[CompilerGenerated]
			internal set
			{
				_003CItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BB")]
		public new bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x600159E")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x600159F")]
			[Cpp2IlInjected.Address(RVA = "0x9B5B60", Offset = "0x9B4560", VA = "0x1809B5B60")]
			set
			{
				//Discarded unreachable code: IL_0022
				_isSelected = value;
				GameObject gameObject = mc_selectedBackground.gameObject;
				bool isSelected = _isSelected;
				gameObject.SetActive(isSelected);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B5910", Offset = "0x9B4310", VA = "0x1809B5910", Slot = "9")]
		internal virtual void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0086
			//IL_0015: Expected O, but got I4
			//IL_0057: Expected I4, but got I8
			RawImage rawImage = mc_icon.RawImage;
			int num = 0;
			rawImage.texture = (Texture)num;
			IItemData itemData = ItemData;
			AsyncAtlassedIcon asyncAtlassedIcon = mc_icon;
			StarComponent mcStar = _mcStar;
			bool flag = default(bool);
			if (!flag)
			{
				GameObject gameObject = mcStar.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			GameObject gameObject2 = mcStar.gameObject;
			ulong num2 = default(ulong);
			gameObject2.SetActive((byte)num2 != 0);
			StarComponent mcStar2 = _mcStar;
			int num3 = 0;
			uint num4 = default(uint);
			if (num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
			IItemData itemData2 = ItemData;
			TextBase tfItemName = _tfItemName;
		}

		[Cpp2IlInjected.Token(Token = "0x60015A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B5B20", Offset = "0x9B4520", VA = "0x1809B5B20")]
		private void refreshSelected()
		{
			//Discarded unreachable code: IL_001b
			GameObject gameObject = mc_selectedBackground.gameObject;
			bool isSelected = _isSelected;
			gameObject.SetActive(isSelected);
		}

		[Cpp2IlInjected.Token(Token = "0x60015A2")]
		[Cpp2IlInjected.Address(RVA = "0x88CCA0", Offset = "0x88B6A0", VA = "0x18088CCA0")]
		public PetItem()
		{
		}
	}
}
