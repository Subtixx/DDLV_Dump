using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Grid;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x20004BD")]
	[ExecuteInEditMode]
	public class GridTilesetManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20004BE")]
		public class Tileset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001DCA")]
			public NativeList<float3> positions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001DCB")]
			public NativeList<int> alphaIndexes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001DCC")]
			public List<GridTilesetObject> gtos;

			[Cpp2IlInjected.Token(Token = "0x6001509")]
			[Cpp2IlInjected.Address(RVA = "0xE60750", Offset = "0xE5F150", VA = "0x180E60750")]
			public Tileset(Vector3 position, int alphaIndex, GridTilesetObject gto)
			{
				//Discarded unreachable code: IL_0046
				//IL_001f: Expected O, but got I4
				//IL_002e: Expected O, but got I4
				int num = 0;
				int num2 = 0;
				base._002Ector();
				AllocatorManager.AllocatorHandle allocatorHandle = Allocator.Persistent;
				float z = position.z;
				positions = (NativeList<float3>)num;
				AllocatorManager.AllocatorHandle allocatorHandle2 = Allocator.Persistent;
				alphaIndexes = (NativeList<int>)num2;
				gtos = (List<GridTilesetObject>)(object)new List<T> { (T)gto };
			}

			[Cpp2IlInjected.Token(Token = "0x600150A")]
			[Cpp2IlInjected.Address(RVA = "0xE606F0", Offset = "0xE5F0F0", VA = "0x180E606F0")]
			public void Destroy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20004BF")]
		private struct vertexData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001DCD")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4001DCE")]
			public float3 normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001DCF")]
			public float3 tangent;
		}

		[Cpp2IlInjected.Token(Token = "0x20004C0")]
		[BurstCompile]
		private struct MergeTiles : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001DD0")]
			[Unity.Collections.ReadOnly]
			public NativeArray<ushort> inIndexData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001DD1")]
			[Unity.Collections.ReadOnly]
			public NativeArray<vertexData> inVertexData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001DD2")]
			[Unity.Collections.ReadOnly]
			public NativeArray<float2> inUVData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001DD3")]
			[Unity.Collections.ReadOnly]
			public NativeList<float3> positions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001DD4")]
			[Unity.Collections.ReadOnly]
			public NativeList<int> alphaIndexes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4001DD5")]
			[WriteOnly]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<ushort> outIndexData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4001DD6")]
			[NativeDisableContainerSafetyRestriction]
			[WriteOnly]
			public NativeArray<vertexData> outVertexData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4001DD7")]
			[NativeDisableContainerSafetyRestriction]
			[WriteOnly]
			public NativeArray<float2> outUVData;

			[Cpp2IlInjected.Token(Token = "0x600150B")]
			[Cpp2IlInjected.Address(RVA = "0xE60010", Offset = "0xE5EA10", VA = "0x180E60010", Slot = "4")]
			public void Execute(int i)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DC3")]
		public List<Material> dirty = (List<Material>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x4001DC4")]
		private static List<GridTilesetManager> GridTilesetManagers = (List<GridTilesetManager>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x4001DC5")]
		public static bool IsActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DC6")]
		private Dictionary<Material, Tileset> tilesets = (Dictionary<Material, Tileset>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DC7")]
		private List<(Mesh mesh, Material material, Material opaqueMaterial, Material transparentMaterial)> tilesets2 = (List<(Mesh mesh, Material material, Material opaqueMaterial, Material transparentMaterial)>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DC8")]
		public bool isQuitting;

		[Cpp2IlInjected.Token(Token = "0x4001DC9")]
		private static Mesh quad;

		[Cpp2IlInjected.Token(Token = "0x60014FB")]
		[Cpp2IlInjected.Address(RVA = "0x1543FE0", Offset = "0x15429E0", VA = "0x181543FE0")]
		public void Awake()
		{
			//Discarded unreachable code: IL_0055, IL_005b, IL_0090
			//IL_000f: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			Mesh mesh = quad;
			int num = 0;
			if (mesh == (UnityEngine.Object)num)
			{
				int num2 = 0;
				int num3 = 0;
				VertexAttributeDescriptor[] array = new VertexAttributeDescriptor[num2];
				int num4 = 0;
				int num5 = 0;
				array[0] = (VertexAttributeDescriptor)num5;
				array[2] = (VertexAttributeDescriptor)num5;
				array[4] = (VertexAttributeDescriptor)num5;
				array[6] = (VertexAttributeDescriptor)num5;
				throw new MissingMethodException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014FC")]
		[Cpp2IlInjected.Address(RVA = "0x15447D0", Offset = "0x15431D0", VA = "0x1815447D0")]
		private void Draw(ScriptableRenderContext context, Camera camera)
		{
			int num = 0;
			List<(Mesh, Material, Material, Material)> list = tilesets2;
			bool flag = default(bool);
			if (flag)
			{
				if (flag)
				{
					Matrix4x4 identity = Matrix4x4.identity;
					float m = identity.m01;
					float m2 = identity.m02;
					float m3 = identity.m03;
				}
				Matrix4x4 identity2 = Matrix4x4.identity;
				float m4 = identity2.m01;
				float m5 = identity2.m02;
				float m6 = identity2.m03;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014FD")]
		[Cpp2IlInjected.Address(RVA = "0x1545130", Offset = "0x1543B30", VA = "0x181545130")]
		public unsafe void Update()
		{
			//Discarded unreachable code: IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_011b, IL_0126, IL_01de, IL_01e4, IL_01ea, IL_01f0, IL_01f6, IL_01fc, IL_0202, IL_0208, IL_020e, IL_0214, IL_021a, IL_0220, IL_0226, IL_022c, IL_0232, IL_0238, IL_023e, IL_0244, IL_024a, IL_0250
			//IL_0038: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			//IL_0156: Expected F4, but got I4
			SubMeshDescriptor subMeshDescriptor = default(SubMeshDescriptor);
			bool flag = default(bool);
			int num6 = default(int);
			uint num16 = default(uint);
			int num20 = default(int);
			int num21 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				List<Material> list = dirty;
				int num4 = 0;
				int _003CindexCount_003Ek__BackingField = subMeshDescriptor.indexCount;
				List<Material> list2 = dirty;
				if (flag)
				{
					Material material = (Material)0;
					Dictionary<Material, Tileset> dictionary = tilesets;
					Material key = material;
					if (((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)key, out *(TValue*)num))
					{
						int num5 = 0;
						num += 16;
						int num7 = num6 * _003CindexCount_003Ek__BackingField;
						int num8 = 0;
						num += 16;
						VertexAttributeDescriptor[] array = new VertexAttributeDescriptor[4];
						int num9 = 0;
						int num10 = 0;
						int num11 = 0;
						array[0] = (VertexAttributeDescriptor)num9;
						int num12 = 0;
						int num13 = 0;
						array[2] = (VertexAttributeDescriptor)num12;
						int num14 = 0;
						int num15 = 0;
						uint num17 = num16 - 1;
						array[4] = (VertexAttributeDescriptor)num14;
						int num18 = 0;
						int num19 = 0;
						array[6] = (VertexAttributeDescriptor)num18;
						int num22 = num20 * num21;
						Mesh mesh = new Mesh();
						throw new MissingMethodException();
					}
				}
				else if (_003CindexCount_003Ek__BackingField == 0)
				{
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014FE")]
		[Cpp2IlInjected.Address(RVA = "0x1544CE0", Offset = "0x15436E0", VA = "0x181544CE0")]
		public void OnEnable()
		{
			//Discarded unreachable code: IL_002e
			((List<T>)(object)GridTilesetManagers).Add((T)this);
			RenderPipelineManager.remove_beginCameraRendering((Action<, >)(object)new Action<T1, T2>(Draw));
			RenderPipelineManager.add_beginCameraRendering((Action<, >)(object)new Action<T1, T2>(Draw));
		}

		[Cpp2IlInjected.Token(Token = "0x60014FF")]
		[Cpp2IlInjected.Address(RVA = "0x1544BD0", Offset = "0x15435D0", VA = "0x181544BD0")]
		public void OnDisable()
		{
			//Discarded unreachable code: IL_001e
			bool flag = ((List<T>)(object)GridTilesetManagers).Remove((T)this);
			RenderPipelineManager.remove_beginCameraRendering((Action<, >)(object)new Action<T1, T2>(Draw));
		}

		[Cpp2IlInjected.Token(Token = "0x6001500")]
		[Cpp2IlInjected.Address(RVA = "0x1544A90", Offset = "0x1543490", VA = "0x181544A90")]
		public void OnDestroy()
		{
			//Discarded unreachable code: IL_000c, IL_0012
			Dictionary<Material, Tileset> dictionary = tilesets;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001501")]
		[Cpp2IlInjected.Address(RVA = "0xA63A00", Offset = "0xA62400", VA = "0x180A63A00")]
		private void OnApplicationQuit()
		{
			isQuitting = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001502")]
		[Cpp2IlInjected.Address(RVA = "0x1543D70", Offset = "0x1542770", VA = "0x181543D70")]
		public int AddTile(Material mat, Vector3 position, int alphaIndex, GridTilesetObject gto)
		{
			//Discarded unreachable code: IL_003b
			if (!((List<T>)(object)dirty).Contains((T)mat))
			{
				((List<T>)(object)dirty).Add((T)mat);
			}
			Dictionary<Material, Tileset> dictionary = tilesets;
			bool flag = default(bool);
			if (!flag)
			{
				Dictionary<Material, Tileset> dictionary2 = tilesets;
				float z = position.z;
				throw new NullReferenceException();
			}
			float z2 = position.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001503")]
		[Cpp2IlInjected.Address(RVA = "0x1544E30", Offset = "0x1543830", VA = "0x181544E30")]
		public void RemoveTile(Material mat, GridTilesetObject gto)
		{
			//Discarded unreachable code: IL_0059
			if (!((List<T>)(object)dirty).Contains((T)mat))
			{
				((List<T>)(object)dirty).Add((T)mat);
			}
			List<GridTilesetObject> gtos = ((Tileset)((Dictionary<TKey, TValue>)(object)tilesets)[(TKey)mat]).gtos;
			GridTilesetObject gridTilesetObject = ((IEnumerable<>)gtos).Last<GridTilesetObject>();
			((List<T>)(object)gtos)[gridTilesetObject.tileIndex = gto.tileIndex] = (T)gridTilesetObject;
			int size = ((List<>)(object)gtos)._size;
			((List<T>)(object)gtos).RemoveAt(size);
		}

		[Cpp2IlInjected.Token(Token = "0x6001504")]
		[Cpp2IlInjected.Address(RVA = "0x1544FE0", Offset = "0x15439E0", VA = "0x181544FE0")]
		public void UpdateTile(Material mat, int index, Vector3 position, int alphaIndex)
		{
			//Discarded unreachable code: IL_0030
			if (!((List<T>)(object)dirty).Contains((T)mat))
			{
				((List<T>)(object)dirty).Add((T)mat);
			}
			Tileset tileset = (Tileset)((Dictionary<TKey, TValue>)(object)tilesets)[(TKey)mat];
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6001505")]
		[Cpp2IlInjected.Address(RVA = "0x1544650", Offset = "0x1543050", VA = "0x181544650")]
		public void DrawGrassMask(CommandBuffer cmd, Material maskMaterial)
		{
			//Discarded unreachable code: IL_0030
			int num = 0;
			List<(Mesh, Material, Material, Material)> list = tilesets2;
			bool flag = default(bool);
			if (flag)
			{
				Matrix4x4 identity = Matrix4x4.identity;
				float m = identity.m01;
				float m2 = identity.m02;
				float m3 = identity.m03;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001506")]
		[Cpp2IlInjected.Address(RVA = "0x15444E0", Offset = "0x1542EE0", VA = "0x1815444E0")]
		public static void DrawAllGrassMask(CommandBuffer cmd, Material m, Camera camera)
		{
			//Discarded unreachable code: IL_000d
			int num = 0;
			List<GridTilesetManager> gridTilesetManagers = GridTilesetManagers;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001507")]
		[Cpp2IlInjected.Address(RVA = "0x1545E10", Offset = "0x1544810", VA = "0x181545E10")]
		public GridTilesetManager()
		{
		}
	}
}
