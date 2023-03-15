using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B2C")]
	public class CameraRelativeRewardPosition : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E27")]
		public Transform RewardTransform;

		[Cpp2IlInjected.Token(Token = "0x600338A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraRelativeRewardPosition()
		{
		}
	}
}
