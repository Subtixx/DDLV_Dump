using System;
using Cpp2IlInjected;
using PlayFab.AuthenticationModels;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000896")]
	public class SpriteAtlasImageTemplate : BehaviourTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032CF")]
		public Sprite Sprite;

		[Cpp2IlInjected.Token(Token = "0x6003620")]
		[Cpp2IlInjected.Address(RVA = "0x15FEF40", Offset = "0x15FD940", VA = "0x1815FEF40")]
		public void Load(SpriteAtlasLoader spriteAtlasImage)
		{
			//Discarded unreachable code: IL_004a
			//IL_0009: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			int num = 0;
			if (spriteAtlasImage != (UnityEngine.Object)num)
			{
				Load((Behaviour)spriteAtlasImage);
				Sprite sprite = (spriteAtlasImage.Sprite = Sprite);
				Sprite sprite2 = Sprite;
				int num2 = 0;
				if (sprite2 != (UnityEngine.Object)num2)
				{
					string name = Sprite.name;
					spriteAtlasImage.SetTarget(name);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003621")]
		[Cpp2IlInjected.Address(RVA = "0x15FF030", Offset = "0x15FDA30", VA = "0x1815FF030")]
		public void Save(SpriteAtlasLoader spriteAtlasImage)
		{
			//Discarded unreachable code: IL_0022
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (spriteAtlasImage != (UnityEngine.Object)num)
			{
				Save((Behaviour)spriteAtlasImage);
				Sprite sprite = (Sprite = spriteAtlasImage.Sprite);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003622")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8E0", Offset = "0x8BA2E0", VA = "0x1808BB8E0")]
		public SpriteAtlasImageTemplate()
		{
			((GetAPIKeysResponse)(object)this)._002Ector();
		}
	}
}
