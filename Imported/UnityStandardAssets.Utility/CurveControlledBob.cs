using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class CurveControlledBob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public float HorizontalBobRange = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public float VerticalBobRange = 0.33f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AnimationCurve Bobcurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public float VerticaltoHorizontalRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float m_CyclePositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float m_CyclePositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private float m_BobBaseInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Vector3 m_OriginalCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float m_Time;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2F094D0", Offset = "0x2F07ED0", VA = "0x182F094D0")]
		public unsafe void Setup(Camera camera, float bobBaseInterval)
		{
			//Discarded unreachable code: IL_003a
			//IL_0023: Expected native int or pointer, but got O
			m_BobBaseInterval = bobBaseInterval;
			Transform transform = camera.transform;
			AnimationCurve bobcurve = Bobcurve;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)m_OriginalCameraPosition)->z = z;
			int length = bobcurve.length;
			Keyframe keyframe = default(Keyframe);
			float outWeight = keyframe.m_OutWeight;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2F09380", Offset = "0x2F07D80", VA = "0x182F09380")]
		public Vector3 DoHeadBob(float speed)
		{
			int num = 0;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			if (!(Time.deltaTime <= speed))
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2F09590", Offset = "0x2F07F90", VA = "0x182F09590")]
		public CurveControlledBob()
		{
			//Discarded unreachable code: IL_00c3
			//IL_002e: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			Keyframe[] array = new Keyframe[5];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			array[0] = (Keyframe)num2;
			int num5 = 0;
			array[3] = (Keyframe)num;
			int num6 = 0;
			array[3] = (Keyframe)num5;
			int num7 = 0;
			int num8 = 0;
			array[6] = (Keyframe)num6;
			int num9 = 0;
			array[7] = (Keyframe)num7;
			int num10 = 0;
			array[10] = (Keyframe)num9;
			int num11 = 0;
			int num12 = 0;
			array[10] = (Keyframe)num10;
			int num13 = 0;
			array[13] = (Keyframe)num11;
			int num14 = 0;
			array[14] = (Keyframe)num13;
			array[17] = (Keyframe)num14;
			Bobcurve = new AnimationCurve(array);
			VerticaltoHorizontalRatio = 1f;
			base._002Ector();
		}
	}
}
