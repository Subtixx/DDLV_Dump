using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004BC")]
	public class HasTutorialBubble : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018EF")]
		[Header("Tutorial")]
		public string highlightableID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018F0")]
		public TutorialBubble bubblePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40018F1")]
		public TutorialBubbleConfig bubbleConfig;

		[Cpp2IlInjected.Token(Token = "0x6001EE8")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HasTutorialBubble()
		{
		}
	}
}
