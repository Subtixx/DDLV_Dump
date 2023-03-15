using System;
using Cpp2IlInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007DB")]
	internal class SphereCastGenerator : EnvironmentQuery.Generator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C12")]
		public Vector3? OverrideDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002C13")]
		public float Distance = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002C14")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002C15")]
		public int LayerMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002C16")]
		private RaycastHitBuffer HitResults;

		[Cpp2IlInjected.Token(Token = "0x4002C17")]
		private static readonly ProfilerMarker s_ProfileMarker;

		[Cpp2IlInjected.Token(Token = "0x4002C18")]
		private static readonly ProfilerMarker s_CopyHits;

		[Cpp2IlInjected.Token(Token = "0x60022DA")]
		[Cpp2IlInjected.Address(RVA = "0xF57B80", Offset = "0xF56580", VA = "0x180F57B80", Slot = "4")]
		protected override int Generate(EnvironmentQuery.QueryPositionList positionList, GameObject queryObject, Vector3 queryPosition)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022DB")]
		[Cpp2IlInjected.Address(RVA = "0xF57EC0", Offset = "0xF568C0", VA = "0x180F57EC0")]
		public SphereCastGenerator()
		{
			//IL_0028: Expected I4, but got I8
			//IL_002f: Expected O, but got I4
			int num = 0;
			Radius = 1f;
			LayerMask = -1;
			HitResults = (RaycastHitBuffer)num;
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60022DC")]
		[Cpp2IlInjected.Address(RVA = "0xF57E00", Offset = "0xF56800", VA = "0x180F57E00")]
		static SphereCastGenerator()
		{
			//IL_0021: Expected O, but got I
			//IL_003c: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("Generate.SphereCast", categoryId, (MarkerFlags)flags, metadataCount);
			int num2 = 0;
			s_ProfileMarker = (ProfilerMarker)(long)intPtr;
			int flags2 = 0;
			int metadataCount2 = 0;
			ushort categoryId2 = default(ushort);
			s_CopyHits = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("Generate.SphereCast.CopyHits", categoryId2, (MarkerFlags)flags2, metadataCount2);
		}
	}
}
