using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007B5")]
	public class InteractionInfoGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D39")]
		public RectTransform InteractionIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D3A")]
		public TextBase InteractionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D3B")]
		public List<ShortcutIndicator> InteractionShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002D3C")]
		public List<GameObject> HoldIndicators;

		[Cpp2IlInjected.Token(Token = "0x6003144")]
		[Cpp2IlInjected.Address(RVA = "0xD24D60", Offset = "0xD23760", VA = "0x180D24D60")]
		public void Init(string interactionText, bool isHold)
		{
			//Discarded unreachable code: IL_002c, IL_0032, IL_0038
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			do
			{
				int num = 0;
				int num2 = 0;
				InteractionText.StringID = interactionText;
				List<ShortcutIndicator> interactionShortcuts = InteractionShortcuts;
			}
			while (flag && !gameObject.activeInHierarchy);
			bool flag2 = default(bool);
			if (!flag2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003145")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InteractionInfoGroup()
		{
		}
	}
}
