using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000644")]
	public class PhoneCategoryItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400231D")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400231E")]
		[SerializeField]
		private SpriteAtlasImage _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400231F")]
		[SerializeField]
		private Material _greyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002320")]
		private PhoneMenu.PhoneCategoryData _categoryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002321")]
		[SerializeField]
		private RedDot _notificationAsset;

		[Cpp2IlInjected.Token(Token = "0x17000621")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400231C")]
		public bool IsUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60028C5")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60028C6")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000622")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60028C7")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x60028C8")]
			[Cpp2IlInjected.Address(RVA = "0x9B6E10", Offset = "0x9B5810", VA = "0x1809B6E10")]
			set
			{
				//Discarded unreachable code: IL_002d
				SpriteAtlasImage icon = _icon;
				_isSelected = value;
				PhoneMenu.PhoneCategoryData categoryData = _categoryData;
				if (value)
				{
				}
				string text2 = (icon.ImageAddress = categoryData.icon.name);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000623")]
		public PhoneMenu.PhoneCategoryData CategoryData
		{
			[Cpp2IlInjected.Token(Token = "0x60028C9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _categoryData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000624")]
		public RedDot NotificationAsset
		{
			[Cpp2IlInjected.Token(Token = "0x60028CA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _notificationAsset;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028CB")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C10", Offset = "0x9B5610", VA = "0x1809B6C10")]
		public void RefreshDisplay(PhoneMenu.PhoneCategoryData phoneCategoryData)
		{
			//Discarded unreachable code: IL_00a0
			//IL_0049: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			_categoryData = phoneCategoryData;
			PhoneMenu.PhoneCategoryData categoryData = _categoryData;
			SpriteAtlasImage icon = _icon;
			string text2 = (icon.ImageAddress = categoryData.icon.name);
			Image image = _icon.Image;
			int num = 0;
			if ((IsUnlocked ? 1 : 0) == num)
			{
			}
			image.material = (Material)num;
			Image image2 = _icon.Image;
			int num2 = 0;
			if ((IsUnlocked ? 1 : 0) != num)
			{
			}
			image2.color = (Color)num2;
			BaseButton component = GetComponent<BaseButton>();
			bool flag2 = (component.IsActive = IsUnlocked);
			Button buttonComponent = component.ButtonComponent;
			bool flag4 = (buttonComponent.interactable = IsUnlocked);
		}

		[Cpp2IlInjected.Token(Token = "0x60028CC")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB0", Offset = "0x9B57B0", VA = "0x1809B6DB0")]
		private void RefreshSelected()
		{
			//Discarded unreachable code: IL_002b
			SpriteAtlasImage icon = _icon;
			PhoneMenu.PhoneCategoryData categoryData = _categoryData;
			if (_isSelected)
			{
			}
			string text2 = (icon.ImageAddress = categoryData.icon.name);
		}

		[Cpp2IlInjected.Token(Token = "0x60028CD")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PhoneCategoryItem()
		{
		}
	}
}
