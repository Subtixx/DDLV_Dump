using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class DebugScaleHitZone : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public Transform TargetTransform;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1552D50", Offset = "0x1551750", VA = "0x181552D50")]
		public void Scale(float scale)
		{
			//Discarded unreachable code: IL_0008
			Transform targetTransform = TargetTransform;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugScaleHitZone()
		{
		}
	}
}
