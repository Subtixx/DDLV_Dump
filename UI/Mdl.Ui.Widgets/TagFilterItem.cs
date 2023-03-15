using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009AB")]
	public class TagFilterItem : FilterItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40038EF")]
		[SerializeField]
		private SpriteAtlasImage mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40038F0")]
		[SerializeField]
		private AsyncAtlassedIcon mc_asyncIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40038F1")]
		public bool UseAlternateIcon = true;

		[Cpp2IlInjected.Token(Token = "0x6003CAB")]
		[Cpp2IlInjected.Address(RVA = "0x17E6100", Offset = "0x17E4B00", VA = "0x1817E6100")]
		public void SetData(SettingsGameGuideConfig.SlideCategory slideCatagory)
		{
			//Discarded unreachable code: IL_007e
			GameObject gameObject = mc_icon.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			mc_asyncIcon.gameObject.SetActive(value: true);
			AsyncAtlassedIcon asyncAtlassedIcon = mc_asyncIcon;
			AssetReferenceTexture icon = slideCatagory.Icon;
			asyncAtlassedIcon.SetIconRef(icon);
			TextBase textBase = text;
			string displayName = slideCatagory.DisplayName;
			if (!string.Equals(textBase._stringID, displayName))
			{
				textBase._stringID = displayName;
				textBase.RefreshText();
			}
			text.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CAC")]
		[Cpp2IlInjected.Address(RVA = "0x17E5D80", Offset = "0x17E4780", VA = "0x1817E5D80", Slot = "4")]
		public override void Init(Filter filter, bool showText)
		{
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_009a: Expected O, but got I4
			int num = 0;
			base.Init(filter, showText);
			if ((object)filter != null)
			{
				int num2 = 0;
				int num3 = 0;
				if ((object)filter == null)
				{
					int num4 = 0;
				}
				GameObject gameObject = mc_asyncIcon.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				int num5 = 0;
				bool flag = (UnityEngine.Object)num3 != (UnityEngine.Object)num5;
				SpriteAtlasImage spriteAtlasImage = mc_icon;
				if (!flag)
				{
					GameObject gameObject2 = spriteAtlasImage.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
				}
				GameObject gameObject3 = spriteAtlasImage.gameObject;
				gameObject3.SetActive(value: true);
				SpriteAtlasImage spriteAtlasImage2 = mc_icon;
				string text2 = (spriteAtlasImage2.ImageAddress = gameObject3.name);
				int num6 = 0;
				bool flag2 = spriteAtlasImage2 != (UnityEngine.Object)num6;
				SpriteAtlasImage alternateBg = AlternateBg;
				if (!flag2)
				{
					GameObject gameObject4 = alternateBg.gameObject;
					int active3 = 0;
					gameObject4.SetActive((byte)active3 != 0);
				}
				GameObject gameObject5 = default(GameObject);
				gameObject5.SetActive(value: true);
				SpriteAtlasImage alternateBg2 = AlternateBg;
				string text4 = (alternateBg2.ImageAddress = gameObject5.name);
			}
			int num7 = 0;
			GameObject gameObject6 = mc_icon.gameObject;
			int active4 = 0;
			gameObject6.SetActive((byte)active4 != 0);
			GameObject gameObject7 = mc_asyncIcon.gameObject;
			int num8 = 0;
			gameObject7.SetActive(value: true);
			AsyncAtlassedIcon asyncAtlassedIcon = mc_asyncIcon;
			if (!UseAlternateIcon)
			{
				int num9 = 0;
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CAD")]
		[Cpp2IlInjected.Address(RVA = "0x17E6210", Offset = "0x17E4C10", VA = "0x1817E6210")]
		public TagFilterItem()
		{
		}
	}
}
