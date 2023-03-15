using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	public class SubmenuNotificationButton : NotificationButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		[SerializeField]
		private SpriteAtlasImage _iconSpriteAtlas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		[SerializeField]
		private TextMeshProUGUI _label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		[SerializeField]
		private Color _activeTextColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		[SerializeField]
		private Color _inactiveTextColor;

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public override SpriteAtlas SpriteAtlas
		{
			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x17E3CF0", Offset = "0x17E26F0", VA = "0x1817E3CF0", Slot = "9")]
			get
			{
				SpriteAtlasImage iconSpriteAtlas;
				do
				{
					iconSpriteAtlas = _iconSpriteAtlas;
				}
				while ((object)iconSpriteAtlas == null);
				return iconSpriteAtlas.SpriteAtlas;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x17E3AC0", Offset = "0x17E24C0", VA = "0x1817E3AC0", Slot = "16")]
		public override void RefreshActive()
		{
			//Discarded unreachable code: IL_00cf
			//IL_0016: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00b2: Expected O, but got I4
			base.RefreshActive();
			Image iconAsset = _iconAsset;
			int num = 0;
			if (iconAsset != (Object)num)
			{
				Image iconAsset2 = _iconAsset;
				int num2 = 0;
				iconAsset2.material = (Material)num2;
			}
			Image background = Background;
			int num3 = 0;
			if (background != (Object)num3)
			{
				bool active = default(bool);
				Background.gameObject.SetActive(active);
			}
			Sprite disableSprite = DisableSprite;
			int num4 = 0;
			if (disableSprite != (Object)num4)
			{
				Sprite enableSprite = EnableSprite;
				int num5 = 0;
				if (enableSprite != (Object)num5)
				{
					SpriteAtlasImage iconSpriteAtlas = _iconSpriteAtlas;
					string text2 = (iconSpriteAtlas.ImageAddress = DisableSprite.name);
				}
			}
			TextMeshProUGUI label = _label;
			int num6 = 0;
			if (label != (Object)num6)
			{
				TextMeshProUGUI label2 = _label;
				Color color = (label2.color = _inactiveTextColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0x9BD9F0", Offset = "0x9BC3F0", VA = "0x1809BD9F0")]
		public SubmenuNotificationButton()
		{
		}
	}
}
