using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000709")]
	public class ShopTabButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002876")]
		[SerializeField]
		public Sprite _texSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002877")]
		[SerializeField]
		public Sprite _texNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002878")]
		[SerializeField]
		public Color _labelColorSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002879")]
		[SerializeField]
		public Color _labelColorNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400287A")]
		[SerializeField]
		public Color _iconColorSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400287B")]
		[SerializeField]
		public Color _iconColorNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400287C")]
		[SerializeField]
		public SpriteAtlasImage McIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400287D")]
		[SerializeField]
		public TextBase TfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400287E")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400287F")]
		public ShopMenu.ShopMenuTabs Tab;

		[Cpp2IlInjected.Token(Token = "0x1700067B")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6002CCE")]
			[Cpp2IlInjected.Address(RVA = "0xAE8610", Offset = "0xAE7010", VA = "0x180AE8610")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CCF")]
			[Cpp2IlInjected.Address(RVA = "0x143C870", Offset = "0x143B270", VA = "0x18143C870")]
			set
			{
				//Discarded unreachable code: IL_009e
				SpriteAtlasImage mcIcon = McIcon;
				_isSelected = value;
				if (!value)
				{
					string text2 = (mcIcon.ImageAddress = _texNormal.name);
					Image image = McIcon.Image;
					Color color = (image.color = _iconColorNormal);
					TextMeshProUGUI textComponent = TfTitle.TextComponent;
				}
				string text4 = (mcIcon.ImageAddress = _texSelected.name);
				Image image2 = McIcon.Image;
				Color color2 = (image2.color = _iconColorSelected);
				TextMeshProUGUI textComponent2 = TfTitle.TextComponent;
				Color color3 = (textComponent2.color = _labelColorSelected);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD0")]
		[Cpp2IlInjected.Address(RVA = "0x143C7E0", Offset = "0x143B1E0", VA = "0x18143C7E0")]
		public ShopTabButton()
		{
			Color white = Color.white;
			int num = 0;
			Color white2 = Color.white;
			Color white3 = Color.white;
			base._002Ector();
		}
	}
}
