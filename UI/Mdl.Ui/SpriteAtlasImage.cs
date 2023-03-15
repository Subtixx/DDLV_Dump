using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001F0")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Image))]
	public class SpriteAtlasImage : SpriteAtlasLoader
	{
		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public Image Image
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7D")]
			[Cpp2IlInjected.Address(RVA = "0x15FF1C0", Offset = "0x15FDBC0", VA = "0x1815FF1C0")]
			get
			{
				return GetComponent<Image>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x15FF120", Offset = "0x15FDB20", VA = "0x1815FF120", Slot = "5")]
		public override void SetTarget(Sprite targetSprite)
		{
			//Discarded unreachable code: IL_001b
			//IL_0010: Expected O, but got I4
			Image component = GetComponent<Image>();
			int num = 0;
			if (!(component == (Object)num))
			{
				component.sprite = targetSprite;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x15FF0C0", Offset = "0x15FDAC0", VA = "0x1815FF0C0", Slot = "4")]
		internal override void RemoveImageReference()
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected O, but got I4
			Image component = GetComponent<Image>();
			int num = 0;
			component.sprite = (Sprite)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SpriteAtlasImage()
		{
		}
	}
}
