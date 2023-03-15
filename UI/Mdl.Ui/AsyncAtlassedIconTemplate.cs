using System;
using Cpp2IlInjected;
using PlayFab.AuthenticationModels;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000897")]
	public class AsyncAtlassedIconTemplate : BehaviourTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032D0")]
		public AssetReferenceTexture AssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032D1")]
		public uint Color = uint.MaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40032D2")]
		public UIGameColors.GameColorName ColorToApply;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032D3")]
		public AsyncAtlassedIcon.IconType SizeType;

		[Cpp2IlInjected.Token(Token = "0x6003623")]
		[Cpp2IlInjected.Address(RVA = "0x8809F0", Offset = "0x87F3F0", VA = "0x1808809F0")]
		public void Load(AsyncAtlassedIcon icon)
		{
			//Discarded unreachable code: IL_0080
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (icon != (UnityEngine.Object)num)
			{
				Load((Behaviour)icon);
				UIGameColors.GameColorName colorToApply = ColorToApply;
				if (colorToApply != 0)
				{
					icon.ColorToApply = colorToApply;
				}
				AsyncAtlassedIcon.IconType iconType = (icon.SizeType = SizeType);
				AssetReferenceTexture assetReferenceTexture = (icon.AssetReference = AssetReference);
				uint color = Color;
				int num2 = 0;
				uint color2 = Color;
				if (icon.gameObject.activeSelf && icon.gameObject.activeInHierarchy && icon.enabled)
				{
					icon.Acquire();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003624")]
		[Cpp2IlInjected.Address(RVA = "0x880B50", Offset = "0x87F550", VA = "0x180880B50")]
		public void Save(AsyncAtlassedIcon icon)
		{
			//Discarded unreachable code: IL_0048
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (icon != (UnityEngine.Object)num)
			{
				Save((Behaviour)icon);
				AsyncAtlassedIcon.IconType iconType = (SizeType = icon.SizeType);
				AssetReferenceTexture assetReferenceTexture = (AssetReference = icon.AssetReference);
				int num2 = (int)(Color = (uint)((Color32)icon.loadedColor).rgba);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003625")]
		[Cpp2IlInjected.Address(RVA = "0x880C30", Offset = "0x87F630", VA = "0x180880C30")]
		public AsyncAtlassedIconTemplate()
		{
			//IL_0010: Expected I4, but got I8
			((GetAPIKeysResponse)(object)this)._002Ector();
		}
	}
}
