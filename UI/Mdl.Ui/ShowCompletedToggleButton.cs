using System.ComponentModel;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000691")]
	public class ShowCompletedToggleButton : ToggleButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40024E9")]
		[SerializeField]
		private SpriteAtlasImage _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40024EA")]
		[SerializeField]
		private Sprite _selectedBackgroundSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40024EB")]
		[SerializeField]
		private Sprite _deselectedBackgroundSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40024EC")]
		[SerializeField]
		private Sprite _selectedIconSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40024ED")]
		[SerializeField]
		private Sprite _deselectedIconSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40024EE")]
		[SerializeField]
		private CanvasGroup _group;

		[Cpp2IlInjected.Token(Token = "0x6002A61")]
		[Cpp2IlInjected.Address(RVA = "0x15F27B0", Offset = "0x15F11B0", VA = "0x1815F27B0")]
		public void Init()
		{
			((ISupportInitialize)this).BeginInit();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A62")]
		[Cpp2IlInjected.Address(RVA = "0x15F27D0", Offset = "0x15F11D0", VA = "0x1815F27D0", Slot = "18")]
		public override void RefreshSeleced()
		{
			//Discarded unreachable code: IL_0045
			SpriteAtlasImage mcBackground = _mcBackground;
			string text2 = (mcBackground.ImageAddress = _deselectedBackgroundSprite.name);
			SpriteAtlasImage mcIcon = _mcIcon;
			string text4 = (mcIcon.ImageAddress = _deselectedIconSprite.name);
			_group.alpha = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A63")]
		[Cpp2IlInjected.Address(RVA = "0x9BD9F0", Offset = "0x9BC3F0", VA = "0x1809BD9F0")]
		public ShowCompletedToggleButton()
		{
		}
	}
}
