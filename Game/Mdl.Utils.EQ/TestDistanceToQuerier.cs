using Cpp2IlInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007E5")]
	internal class TestDistanceToQuerier : EnvironmentQuery.Test
	{
		[Cpp2IlInjected.Token(Token = "0x4002C32")]
		private static readonly ProfilerMarker s_Test_Distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C33")]
		public float MaxDistance = 1f;

		[Cpp2IlInjected.Token(Token = "0x170004DE")]
		public override float Cost
		{
			[Cpp2IlInjected.Token(Token = "0x60022F8")]
			[Cpp2IlInjected.Address(RVA = "0xF3BDA0", Offset = "0xF3A7A0", VA = "0x180F3BDA0", Slot = "4")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022F9")]
		[Cpp2IlInjected.Address(RVA = "0x1072510", Offset = "0x1070F10", VA = "0x181072510", Slot = "6")]
		protected override (bool, float) FilterAndScore(GameObject queryObject, Vector3 queryPosition, Vector3 position)
		{
			//IL_0021: Expected F4, but got I4
			float z = position.z;
			float z2 = queryPosition.z;
			float maxDistance = MaxDistance;
			int num = 0;
			float value = default(float);
			maxDistance = Mathf.Clamp(value, num, maxDistance);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022FA")]
		[Cpp2IlInjected.Address(RVA = "0x1071DB0", Offset = "0x10707B0", VA = "0x181071DB0")]
		public TestDistanceToQuerier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60022FB")]
		[Cpp2IlInjected.Address(RVA = "0x10725D0", Offset = "0x1070FD0", VA = "0x1810725D0")]
		static TestDistanceToQuerier()
		{
			//IL_001a: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			s_Test_Distance = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("FilterAndScore.Distance", categoryId, (MarkerFlags)flags, metadataCount);
		}
	}
}
