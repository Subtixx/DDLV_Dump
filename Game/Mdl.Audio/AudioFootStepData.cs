using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000AEC")]
	public class AudioFootStepData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C8D")]
		public Switch footStepEvent;

		[Cpp2IlInjected.Token(Token = "0x6003239")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AudioFootStepData()
		{
		}
	}
}
