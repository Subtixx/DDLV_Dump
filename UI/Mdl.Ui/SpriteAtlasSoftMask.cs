using Cpp2IlInjected;
using SoftMasking;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001F2")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(SoftMask))]
	public class SpriteAtlasSoftMask : SpriteAtlasLoader
	{
		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x15FF710", Offset = "0x15FE110", VA = "0x1815FF710", Slot = "5")]
		public override void SetTarget(Sprite targetSprite)
		{
			//Discarded unreachable code: IL_0023
			//IL_0010: Expected O, but got I4
			SoftMask component = GetComponent<SoftMask>();
			int num = 0;
			if (!(component == (Object)num) && !(component._sprite != targetSprite))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SpriteAtlasSoftMask()
		{
		}
	}
}
