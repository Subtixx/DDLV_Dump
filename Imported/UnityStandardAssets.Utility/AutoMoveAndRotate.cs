using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public class Vector3andSpace
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public Vector3 value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public Space space = Space.Self;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7450", Offset = "0x3DC5E50", VA = "0x183DC7450")]
			public Vector3andSpace()
			{
			}//IL_0009: Expected I4, but got I8

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Vector3andSpace moveUnitsPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public bool ignoreTimescale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private float m_LastRealTime;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2F07900", Offset = "0x2F06300", VA = "0x182F07900")]
		private void Start()
		{
			int num = 0;
			float num2 = (m_LastRealTime = Time.realtimeSinceStartup);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2F07920", Offset = "0x2F06320", VA = "0x182F07920")]
		private void Update()
		{
			//Discarded unreachable code: IL_0053
			int num = 0;
			float deltaTime = Time.deltaTime;
			if (ignoreTimescale)
			{
				int num2 = 0;
				deltaTime = Time.realtimeSinceStartup;
				int num3 = 0;
				float num4 = (m_LastRealTime = Time.realtimeSinceStartup);
			}
			Transform transform = base.transform;
			Vector3andSpace vector3andSpace = moveUnitsPerSecond;
			Transform transform2 = base.transform;
			Vector3andSpace vector3andSpace2 = rotateDegreesPerSecond;
			Vector3andSpace vector3andSpace3 = moveUnitsPerSecond;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AutoMoveAndRotate()
		{
		}
	}
}
