using System;
using Cpp2IlInjected;
using PlayFab.AuthenticationModels;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000898")]
	public class FishingReelTemplate : BehaviourTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032D4")]
		public Sprite ReleaseSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032D5")]
		public Sprite HoldSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032D6")]
		public Sprite WaitSprite;

		[Cpp2IlInjected.Token(Token = "0x6003626")]
		[Cpp2IlInjected.Address(RVA = "0x165FCE0", Offset = "0x165E6E0", VA = "0x18165FCE0")]
		public void Load(FishingReelHandler fishingReelHandler)
		{
			//Discarded unreachable code: IL_003e
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (fishingReelHandler != (UnityEngine.Object)num)
			{
				Load((Behaviour)fishingReelHandler);
				Sprite sprite = (fishingReelHandler._releaseSprite = ReleaseSprite);
				Sprite sprite2 = (fishingReelHandler._holdSprite = HoldSprite);
				Sprite sprite3 = (fishingReelHandler._waitSprite = WaitSprite);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003627")]
		[Cpp2IlInjected.Address(RVA = "0x165FDA0", Offset = "0x165E7A0", VA = "0x18165FDA0")]
		public void Save(FishingReelHandler fishingReelHandler)
		{
			//Discarded unreachable code: IL_003e
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (fishingReelHandler != (UnityEngine.Object)num)
			{
				Save((Behaviour)fishingReelHandler);
				Sprite sprite = (ReleaseSprite = fishingReelHandler._releaseSprite);
				Sprite sprite2 = (HoldSprite = fishingReelHandler._holdSprite);
				Sprite sprite3 = (WaitSprite = fishingReelHandler._waitSprite);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003628")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8E0", Offset = "0x8BA2E0", VA = "0x1808BB8E0")]
		public FishingReelTemplate()
		{
			((GetAPIKeysResponse)(object)this)._002Ector();
		}
	}
}
