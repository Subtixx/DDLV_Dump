using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000717")]
	[CreateAssetMenu]
	internal class AttentionVFXData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002942")]
		public GameObject attentionVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002943")]
		public string endClipBool = "out";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002944")]
		public float distanceToTrigger = 6f;

		[Cpp2IlInjected.Token(Token = "0x6001F77")]
		[Cpp2IlInjected.Address(RVA = "0xA45FB0", Offset = "0xA449B0", VA = "0x180A45FB0")]
		public AttentionVFXData()
		{
		}
	}
}
