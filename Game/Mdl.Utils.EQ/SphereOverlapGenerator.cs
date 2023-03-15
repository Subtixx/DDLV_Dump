using System;
using Cpp2IlInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007DD")]
	internal class SphereOverlapGenerator : EnvironmentQuery.Generator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C1B")]
		public float Radius = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002C1C")]
		public int LayerMask = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002C1D")]
		private int MaxColliderResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002C1E")]
		private Collider[] ColliderResults;

		[Cpp2IlInjected.Token(Token = "0x4002C1F")]
		private static readonly ProfilerMarker s_ProfileMarker;

		[Cpp2IlInjected.Token(Token = "0x4002C20")]
		private static readonly ProfilerMarker s_CopyColliders;

		[Cpp2IlInjected.Token(Token = "0x60022E0")]
		[Cpp2IlInjected.Address(RVA = "0xF581B0", Offset = "0xF56BB0", VA = "0x180F581B0")]
		public SphereOverlapGenerator(int maxColliderResults = 20)
		{
			//IL_001b: Expected I4, but got I8
			MaxColliderResults = maxColliderResults;
			Collider[] array = (ColliderResults = new Collider[maxColliderResults]);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022E1")]
		[Cpp2IlInjected.Address(RVA = "0xF57F60", Offset = "0xF56960", VA = "0x180F57F60", Slot = "4")]
		protected override int Generate(EnvironmentQuery.QueryPositionList positionList, GameObject queryObject, Vector3 queryPosition)
		{
			//Discarded unreachable code: IL_0026
			float z = queryPosition.z;
			if (_003C_003Ec._003C_003E9__7_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Collider c) => c.gameObject);
			}
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60022E2")]
		[Cpp2IlInjected.Address(RVA = "0xF580F0", Offset = "0xF56AF0", VA = "0x180F580F0")]
		static SphereOverlapGenerator()
		{
			//IL_0021: Expected O, but got I
			//IL_003c: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("Generate.SphereOverlap", categoryId, (MarkerFlags)flags, metadataCount);
			int num2 = 0;
			s_ProfileMarker = (ProfilerMarker)(long)intPtr;
			int flags2 = 0;
			int metadataCount2 = 0;
			ushort categoryId2 = default(ushort);
			s_CopyColliders = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("Generate.SphereOverlap.CopyColliders", categoryId2, (MarkerFlags)flags2, metadataCount2);
		}
	}
}
