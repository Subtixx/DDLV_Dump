using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000786")]
	[RequiredAllNotNull]
	public class WardrobeColorPickerItem : ColorItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002BCF")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002BD0")]
		private ClothingItemData _clothingItemData;

		[Cpp2IlInjected.Token(Token = "0x170006C9")]
		public override bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003015")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0", Slot = "4")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6003016")]
			[Cpp2IlInjected.Address(RVA = "0x14E3F50", Offset = "0x14E2950", VA = "0x1814E3F50", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_0077
				//IL_005e: Expected O, but got I8
				//IL_005e: Expected O, but got I4
				//IL_005e: Expected O, but got I4
				Image image = mc_colorIconSelected;
				_isSelected = value;
				Transform transform = image.gameObject.transform;
				int num = 0;
				GameObject gameObject = mc_colorIconSelected.gameObject;
				bool isSelected = _isSelected;
				int num2 = 0;
				gameObject.SetActive(isSelected);
				Image image2 = mc_colorIconSelected;
				int num3 = 0;
				GameObject target = image2.gameObject;
				var vars = (_003C_003Ef__AnonymousType44<float, float, eEaseType>)(object)new
				{
					ScaleX = (_003CScaleX_003Ej__TPar)num3,
					ScaleY = (_003CScaleY_003Ej__TPar)num2,
					Ease = (_003CEase_003Ej__TPar)38
				};
				TweenMax tweenMax = TweenMax.To(target, 0.25f, vars, int.MinValue, this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CA")]
		public ClothingItemData ClothingItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6003017")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return _clothingItemData;
			}
			[Cpp2IlInjected.Token(Token = "0x6003018")]
			[Cpp2IlInjected.Address(RVA = "0x14E3DF0", Offset = "0x14E27F0", VA = "0x1814E3DF0")]
			set
			{
				//Discarded unreachable code: IL_0039
				_clothingItemData = value;
				ListInventory wardrobe = SystemRoot.Instance.Client.Profile.Wardrobe;
				int iD = _clothingItemData.ID;
				ListInventory.Types.Data data = default(ListInventory.Types.Data);
				if (data != null)
				{
				}
				string text = default(string);
				_tfAmount.Text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CB")]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6003019")]
			[Cpp2IlInjected.Address(RVA = "0x14E3DB0", Offset = "0x14E27B0", VA = "0x1814E3DB0")]
			set
			{
				//Discarded unreachable code: IL_000d
				string text = default(string);
				_tfAmount.Text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600301A")]
		[Cpp2IlInjected.Address(RVA = "0x14E3D50", Offset = "0x14E2750", VA = "0x1814E3D50")]
		private void OnDestroy()
		{
			TweenMax.KillAllByCancelationToken(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600301B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public WardrobeColorPickerItem()
		{
		}
	}
}
