using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C42")]
	[CreateAssetMenu]
	public class CameraOverrideZoneConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004477")]
		public float hookedPitchForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4004478")]
		public float hookedPitchBackward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004479")]
		public float freePitchForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400447A")]
		public float freePitchBackward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400447B")]
		[Range(0f, 1f)]
		public float strengthForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400447C")]
		[Range(0f, 1f)]
		public float strengthBackward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400447D")]
		public AnimationCurve strengthCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400447E")]
		public float offsetXRadiusAtMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400447F")]
		public float offsetZRadiusAtMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004480")]
		public float offsetRightOffsetAtMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4004481")]
		public float offsetForwardOffsetAtMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004482")]
		public float offsetXRadiusAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4004483")]
		public float offsetZRadiusAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004484")]
		public float offsetRightOffsetAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4004485")]
		public float offsetForwardOffsetAtMax;

		[Cpp2IlInjected.Token(Token = "0x6003841")]
		[Cpp2IlInjected.Address(RVA = "0x12D6770", Offset = "0x12D5170", VA = "0x1812D6770")]
		public CameraOverrideZoneConfig()
		{
			//IL_001e: Expected F4, but got I4
			//IL_001e: Expected F4, but got I4
			int num = 0;
			strengthForward = 1f;
			strengthCurve = AnimationCurve.Linear(0f, num, 1f, 1f);
			offsetXRadiusAtMin = 1f;
			offsetZRadiusAtMin = 1f;
			offsetForwardOffsetAtMin = 1f;
			offsetXRadiusAtMax = 1f;
			offsetZRadiusAtMax = 1f;
			offsetForwardOffsetAtMax = 1f;
			base._002Ector();
		}
	}
}
