using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	public class ButtonTmPro : BaseButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public bool ControlTextColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public Color EnableTextColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public Color DisableTextColor;

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0xA6C550", Offset = "0xA6AF50", VA = "0x180A6C550", Slot = "16")]
		public override void RefreshActive()
		{
			//Discarded unreachable code: IL_00b8
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			Sprite disableSprite = DisableSprite;
			int num = 0;
			if (disableSprite != (Object)num)
			{
				Sprite enableSprite = EnableSprite;
				int num2 = 0;
				if (enableSprite != (Object)num2)
				{
					SpriteAtlasImage backgroundSpriteAtlas = BackgroundSpriteAtlas;
					int num3 = 0;
					if (backgroundSpriteAtlas != (Object)num3)
					{
						SpriteAtlasImage backgroundSpriteAtlas2 = BackgroundSpriteAtlas;
						string text2 = (backgroundSpriteAtlas2.ImageAddress = DisableSprite.name);
						Image image = BackgroundSpriteAtlas.Image;
						Color color = (image.color = DisableSpriteColor);
					}
				}
			}
			if (ControlTextColor)
			{
				TextBase label = Label;
				int num4 = 0;
				if (label != (Object)num4)
				{
					TextMeshProUGUI textComponent = Label.TextComponent;
					Color color2 = (textComponent.color = DisableTextColor);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6C790", Offset = "0xA6B190", VA = "0x180A6C790")]
		public void SetGreyedOut(bool value)
		{
			//Discarded unreachable code: IL_0023
			//IL_0010: Expected O, but got I4
			CanvasGroup component = GetComponent<CanvasGroup>();
			int num = 0;
			if (component != (Object)num)
			{
				if (value)
				{
				}
				component.alpha = 1f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0xA6C850", Offset = "0xA6B250", VA = "0x180A6C850")]
		public ButtonTmPro()
		{
			Color white = Color.white;
			Color white2 = Color.white;
			base._002Ector();
		}
	}
}
