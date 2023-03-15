using System;
using Cpp2IlInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007E2")]
	internal class TestDirection : EnvironmentQuery.Test
	{
		[Cpp2IlInjected.Token(Token = "0x4002C2D")]
		private static readonly ProfilerMarker s_Test_Direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C2E")]
		public Vector3 DesiredDirection;

		[Cpp2IlInjected.Token(Token = "0x170004DC")]
		public override float Cost
		{
			[Cpp2IlInjected.Token(Token = "0x60022EE")]
			[Cpp2IlInjected.Address(RVA = "0x1072370", Offset = "0x1070D70", VA = "0x181072370", Slot = "4")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022EF")]
		[Cpp2IlInjected.Address(RVA = "0x1072090", Offset = "0x1070A90", VA = "0x181072090", Slot = "6")]
		protected override (bool, float) FilterAndScore(GameObject queryObject, Vector3 queryPosition, Vector3 position)
		{
			float z = DesiredDirection.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022F0")]
		[Cpp2IlInjected.Address(RVA = "0x1072330", Offset = "0x1070D30", VA = "0x181072330")]
		public unsafe TestDirection()
		{
			//IL_0012: Expected native int or pointer, but got O
			float z = Vector3.forward.z;
			((Vector3*)(IntPtr)DesiredDirection)->z = z;
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60022F1")]
		[Cpp2IlInjected.Address(RVA = "0x10722B0", Offset = "0x1070CB0", VA = "0x1810722B0")]
		static TestDirection()
		{
			//IL_001a: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			s_Test_Direction = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("FilterAndScore.Direction", categoryId, (MarkerFlags)flags, metadataCount);
		}
	}
}
