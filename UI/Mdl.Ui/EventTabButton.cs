using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000472")]
	public class EventTabButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400168E")]
		[SerializeField]
		public Sprite _texSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400168F")]
		[SerializeField]
		public Sprite _texNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001690")]
		[SerializeField]
		public SpriteAtlasImage McIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001691")]
		[SerializeField]
		public TextBase TfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001692")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001693")]
		public EventMenu.EventMenuTabs Tab;

		[Cpp2IlInjected.Token(Token = "0x170004B2")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6001CA9")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CAA")]
			[Cpp2IlInjected.Address(RVA = "0x140AC40", Offset = "0x1409640", VA = "0x18140AC40")]
			set
			{
				//Discarded unreachable code: IL_005d
				SpriteAtlasImage mcIcon = McIcon;
				_isSelected = value;
				if (!value)
				{
					string text2 = (mcIcon.ImageAddress = _texNormal.name);
					TextMeshProUGUI textComponent = TfTitle.TextComponent;
					int num = 0;
				}
				string text4 = (mcIcon.ImageAddress = _texSelected.name);
				TextMeshProUGUI textComponent2 = TfTitle.TextComponent;
				Color white = Color.white;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventTabButton()
		{
		}
	}
}
