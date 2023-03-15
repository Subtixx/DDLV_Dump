using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A7C")]
	public static class SkinnedMeshCombiner
	{
		[Cpp2IlInjected.Token(Token = "0x2000A7D")]
		private struct stream0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039D0")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40039D1")]
			public float3 normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40039D2")]
			public float3 tangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40039D3")]
			public float bitangentSign;
		}

		[Cpp2IlInjected.Token(Token = "0x2000A7E")]
		private struct triangle
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039D4")]
			public ushort index1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x40039D5")]
			public ushort index2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40039D6")]
			public ushort index3;
		}

		[Cpp2IlInjected.Token(Token = "0x2000A7F")]
		[BurstCompile]
		private struct BakeTrianglesJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039D7")]
			[Unity.Collections.ReadOnly]
			[DeallocateOnJobCompletion]
			public NativeArray<bool> visibleParts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40039D8")]
			[Unity.Collections.ReadOnly]
			public Mesh.MeshData meshData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40039D9")]
			[Unity.Collections.ReadOnly]
			public bool splitSkin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40039DA")]
			[Unity.Collections.ReadOnly]
			public int indexOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40039DB")]
			public NativeArray<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40039DC")]
			public NativeArray<ushort> packedVertexCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40039DD")]
			[WriteOnly]
			public NativeList<triangle> triangles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40039DE")]
			[WriteOnly]
			public NativeList<triangle> skinTriangles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40039DF")]
			[WriteOnly]
			public NativeList<int> submeshIndexCount;

			[Cpp2IlInjected.Token(Token = "0x60030B2")]
			[Cpp2IlInjected.Address(RVA = "0x143FB80", Offset = "0x143E580", VA = "0x18143FB80", Slot = "4")]
			public void Execute()
			{
				//Discarded unreachable code: IL_000b, IL_0010, IL_0025, IL_002e, IL_0040
				int num = 0;
				int num2 = 0;
				throw new MissingMethodException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A80")]
		[BurstCompile]
		private struct PackStream0 : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039E0")]
			[Unity.Collections.ReadOnly]
			public NativeArray<stream0> stream0Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40039E1")]
			[Unity.Collections.ReadOnly]
			public float3x4 skinningMatrix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40039E2")]
			[Unity.Collections.ReadOnly]
			public NativeSlice<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40039E3")]
			[Unity.Collections.ReadOnly]
			public NativeArray<stream0> blendShapeVertices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40039E4")]
			[NativeDisableContainerSafetyRestriction]
			[WriteOnly]
			public NativeArray<stream0> outStream0Data;

			[Cpp2IlInjected.Token(Token = "0x60030B3")]
			[Cpp2IlInjected.Address(RVA = "0x14407B0", Offset = "0x143F1B0", VA = "0x1814407B0", Slot = "4")]
			public void Execute(int index)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A81")]
		private struct Color_UV0_UV1
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039E5")]
			public Color32 color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40039E6")]
			public float2 uv0;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40039E7")]
			public float2 uv1;
		}

		[Cpp2IlInjected.Token(Token = "0x2000A82")]
		private struct Color_UV0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039E8")]
			public Color32 color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40039E9")]
			public float2 uv0;
		}

		[Cpp2IlInjected.Token(Token = "0x2000A83")]
		[BurstCompile]
		private struct PackStream1_Color_UV1 : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039EA")]
			[Unity.Collections.ReadOnly]
			public NativeArray<Color_UV0_UV1> stream1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40039EB")]
			[Unity.Collections.ReadOnly]
			public bool useVertexColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40039EC")]
			[Unity.Collections.ReadOnly]
			public NativeSlice<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40039ED")]
			[WriteOnly]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> outStream1Data;

			[Cpp2IlInjected.Token(Token = "0x60030B4")]
			[Cpp2IlInjected.Address(RVA = "0x1440E50", Offset = "0x143F850", VA = "0x181440E50", Slot = "4")]
			public unsafe void Execute(int index)
			{
				//IL_001c: Expected I, but got F4
				//IL_0017: Expected native int or pointer, but got O
				NativeArray<float4> nativeArray = outStream1Data;
				ushort num = (ushort)(num + num);
				if (useVertexColor)
				{
					float num2 = default(float);
					((NativeArray<>*)(IntPtr)nativeArray)->m_Buffer = (void*)(IntPtr)num2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A84")]
		[BurstCompile]
		private struct PackStream1_Color : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039EE")]
			[Unity.Collections.ReadOnly]
			public NativeArray<Color_UV0> stream1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40039EF")]
			[Unity.Collections.ReadOnly]
			public bool useVertexColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40039F0")]
			[Unity.Collections.ReadOnly]
			public NativeSlice<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40039F1")]
			[NativeDisableContainerSafetyRestriction]
			[WriteOnly]
			public NativeArray<float4> outStream1Data;

			[Cpp2IlInjected.Token(Token = "0x60030B5")]
			[Cpp2IlInjected.Address(RVA = "0x1440D30", Offset = "0x143F730", VA = "0x181440D30", Slot = "4")]
			public unsafe void Execute(int index)
			{
				//IL_001c: Expected I, but got F4
				//IL_0017: Expected native int or pointer, but got O
				NativeArray<float4> nativeArray = outStream1Data;
				ushort num = (ushort)(num + num);
				if (useVertexColor)
				{
					float num2 = default(float);
					((NativeArray<>*)(IntPtr)nativeArray)->m_Buffer = (void*)(IntPtr)num2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A85")]
		[BurstCompile]
		private struct PackStream1_UV1 : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039F2")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float4> stream1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40039F3")]
			[Unity.Collections.ReadOnly]
			public bool useVertexColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40039F4")]
			[Unity.Collections.ReadOnly]
			public NativeSlice<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40039F5")]
			[NativeDisableContainerSafetyRestriction]
			[WriteOnly]
			public NativeArray<float4> outStream1Data;

			[Cpp2IlInjected.Token(Token = "0x60030B6")]
			[Cpp2IlInjected.Address(RVA = "0x1441010", Offset = "0x143FA10", VA = "0x181441010", Slot = "4")]
			public void Execute(int index)
			{
				NativeArray<float4> nativeArray = outStream1Data;
				ushort num = (ushort)(num + num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A86")]
		[BurstCompile]
		private struct PackStream1 : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039F6")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float2> stream1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40039F7")]
			[Unity.Collections.ReadOnly]
			public bool useVertexColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40039F8")]
			[Unity.Collections.ReadOnly]
			public NativeSlice<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40039F9")]
			[NativeDisableContainerSafetyRestriction]
			[WriteOnly]
			public NativeArray<float4> outStream1Data;

			[Cpp2IlInjected.Token(Token = "0x60030B7")]
			[Cpp2IlInjected.Address(RVA = "0x1440F80", Offset = "0x143F980", VA = "0x181440F80", Slot = "4")]
			public void Execute(int index)
			{
				NativeArray<float4> nativeArray = outStream1Data;
				ushort num = (ushort)(num + num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A87")]
		private struct bone2
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039FA")]
			public float2 weights;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40039FB")]
			public int2 indices;
		}

		[Cpp2IlInjected.Token(Token = "0x2000A88")]
		private struct bone3
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039FC")]
			public float3 weights;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40039FD")]
			public int3 indices;
		}

		[Cpp2IlInjected.Token(Token = "0x2000A89")]
		private struct bone4
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40039FE")]
			public float4 weights;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40039FF")]
			public int4 indices;
		}

		[Cpp2IlInjected.Token(Token = "0x2000A8A")]
		private struct bone4Out
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003A00")]
			public float4 weights;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A01")]
			public byte x;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x4003A02")]
			public byte y;

			[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
			[Cpp2IlInjected.Token(Token = "0x4003A03")]
			public byte z;

			[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
			[Cpp2IlInjected.Token(Token = "0x4003A04")]
			public byte w;
		}

		[Cpp2IlInjected.Token(Token = "0x2000A8B")]
		[BurstCompile]
		private struct PackStream2_1Bone : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003A05")]
			[Unity.Collections.ReadOnly]
			public NativeArray<int> stream2Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A06")]
			[Unity.Collections.ReadOnly]
			public NativeSlice<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003A07")]
			[Unity.Collections.ReadOnly]
			public NativeArray<byte> boneMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4003A08")]
			[NativeDisableContainerSafetyRestriction]
			[WriteOnly]
			public NativeArray<bone4Out> outStream2Data;

			[Cpp2IlInjected.Token(Token = "0x60030B8")]
			[Cpp2IlInjected.Address(RVA = "0x1441080", Offset = "0x143FA80", VA = "0x181441080", Slot = "4")]
			public void Execute(int index)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A8C")]
		[BurstCompile]
		private struct PackStream2_2Bones : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003A09")]
			[Unity.Collections.ReadOnly]
			public NativeArray<bone2> stream2Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A0A")]
			[Unity.Collections.ReadOnly]
			public NativeSlice<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003A0B")]
			[Unity.Collections.ReadOnly]
			public NativeArray<byte> boneMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4003A0C")]
			[WriteOnly]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<bone4Out> outStream2Data;

			[Cpp2IlInjected.Token(Token = "0x60030B9")]
			[Cpp2IlInjected.Address(RVA = "0x1441110", Offset = "0x143FB10", VA = "0x181441110", Slot = "4")]
			public void Execute(int index)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A8D")]
		[BurstCompile]
		private struct PackStream2_3Bones : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003A0D")]
			[Unity.Collections.ReadOnly]
			public NativeArray<bone3> stream2Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A0E")]
			[Unity.Collections.ReadOnly]
			public NativeSlice<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003A0F")]
			[Unity.Collections.ReadOnly]
			public NativeArray<byte> boneMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4003A10")]
			[NativeDisableContainerSafetyRestriction]
			[WriteOnly]
			public NativeArray<bone4Out> outStream2Data;

			[Cpp2IlInjected.Token(Token = "0x60030BA")]
			[Cpp2IlInjected.Address(RVA = "0x14411F0", Offset = "0x143FBF0", VA = "0x1814411F0", Slot = "4")]
			public void Execute(int index)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A8E")]
		[BurstCompile]
		private struct PackStream2_4Bones : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003A11")]
			[Unity.Collections.ReadOnly]
			public NativeArray<bone4> stream2Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A12")]
			[Unity.Collections.ReadOnly]
			public NativeSlice<ushort> indexMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003A13")]
			[Unity.Collections.ReadOnly]
			public NativeArray<byte> boneMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4003A14")]
			[NativeDisableContainerSafetyRestriction]
			[WriteOnly]
			public NativeArray<bone4Out> outStream2Data;

			[Cpp2IlInjected.Token(Token = "0x60030BB")]
			[Cpp2IlInjected.Address(RVA = "0x1441300", Offset = "0x143FD00", VA = "0x181441300", Slot = "4")]
			public void Execute(int index)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030B0")]
		[Cpp2IlInjected.Address(RVA = "0xF545D0", Offset = "0xF52FD0", VA = "0x180F545D0")]
		public static void Combine(SkinnedMeshRenderer outSkinnedMesh, List<CombineMesh> toBake, Dictionary<string, Transform> skeletonDefinition, Dictionary<string, float> bakedBlendShapes, bool destroyPrevious = true)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60030B1")]
		[Cpp2IlInjected.Address(RVA = "0xF51490", Offset = "0xF4FE90", VA = "0x180F51490")]
		private static Mesh Bake(List<CombineMesh> toBake, List<Transform> outBones, List<Material> materials, Dictionary<string, float> bakedBlendShapes)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
