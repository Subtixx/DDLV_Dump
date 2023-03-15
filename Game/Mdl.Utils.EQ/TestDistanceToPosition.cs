using System;
using Cpp2IlInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007E4")]
	internal class TestDistanceToPosition : EnvironmentQuery.Test
	{
		[Cpp2IlInjected.Token(Token = "0x4002C2F")]
		private static readonly ProfilerMarker s_Test_Distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C30")]
		public float MaxDistance = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002C31")]
		public Vector3 targetPosition;

		[Cpp2IlInjected.Token(Token = "0x170004DD")]
		public override float Cost
		{
			[Cpp2IlInjected.Token(Token = "0x60022F4")]
			[Cpp2IlInjected.Address(RVA = "0xF3BDA0", Offset = "0xF3A7A0", VA = "0x180F3BDA0", Slot = "4")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022F5")]
		[Cpp2IlInjected.Address(RVA = "0x10724B0", Offset = "0x1070EB0", VA = "0x1810724B0")]
		public unsafe TestDistanceToPosition(Vector3 position)
		{
			//IL_001d: Expected native int or pointer, but got O
			//IL_0036: Expected native int or pointer, but got O
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)targetPosition)->z = z;
			base._002Ector();
			float z2 = position.z;
			((Vector3*)(IntPtr)targetPosition)->z = z2;
		}

		[Cpp2IlInjected.Token(Token = "0x60022F6")]
		[Cpp2IlInjected.Address(RVA = "0x1072380", Offset = "0x1070D80", VA = "0x181072380", Slot = "6")]
		protected override (bool, float) FilterAndScore(GameObject queryObject, Vector3 _, Vector3 position)
		{
			//IL_0026: Expected F4, but got I4
			float z = position.z;
			float z2 = targetPosition.z;
			float maxDistance = MaxDistance;
			int num = 0;
			float value = default(float);
			maxDistance = Mathf.Clamp(value, num, maxDistance);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022F7")]
		[Cpp2IlInjected.Address(RVA = "0x1072430", Offset = "0x1070E30", VA = "0x181072430")]
		static TestDistanceToPosition()
		{
			//IL_001a: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			s_Test_Distance = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("FilterAndScore.DistanceToPosition", categoryId, (MarkerFlags)flags, metadataCount);
		}
	}
}
