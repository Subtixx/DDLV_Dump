using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000660")]
	public class PhoneProfileToggleButton : ToggleButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40023B2")]
		[SerializeField]
		private Sprite _onIconSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40023B3")]
		[SerializeField]
		private Sprite _offIconSprite;

		[Cpp2IlInjected.Token(Token = "0x600295C")]
		[Cpp2IlInjected.Address(RVA = "0x9BD980", Offset = "0x9BC380", VA = "0x1809BD980", Slot = "18")]
		public override void RefreshSeleced()
		{
			//Discarded unreachable code: IL_0022
			bool isActive = default(bool);
			base.IsActive = isActive;
			SpriteAtlasImage mcIcon = _mcIcon;
			string text2 = (mcIcon.ImageAddress = _offIconSprite.name);
		}

		[Cpp2IlInjected.Token(Token = "0x600295D")]
		[Cpp2IlInjected.Address(RVA = "0x9BD9F0", Offset = "0x9BC3F0", VA = "0x1809BD9F0")]
		public PhoneProfileToggleButton()
		{
		}
	}
}
