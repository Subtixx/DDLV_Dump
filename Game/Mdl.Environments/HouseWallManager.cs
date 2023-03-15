using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Mdl.Grid;
using Meta;
using Meta.Grids;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000650")]
	[ExecuteAlways]
	public class HouseWallManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4002598")]
		private static float wallThickness;

		[Cpp2IlInjected.Token(Token = "0x4002599")]
		private static float wallHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400259A")]
		public int width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400259B")]
		public int height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400259C")]
		public Material frontMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400259D")]
		public Material backMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400259E")]
		private MeshRenderer[] wallRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400259F")]
		private List<GridObjectScript>[] gridObjectScripts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40025A0")]
		private Item[] wallpapers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40025A1")]
		private AsyncOperationHandle<Material>[] materialHandles;

		[Cpp2IlInjected.Token(Token = "0x6001C25")]
		[Cpp2IlInjected.Address(RVA = "0x11AE560", Offset = "0x11ACF60", VA = "0x1811AE560")]
		private void Awake()
		{
			//Discarded unreachable code: IL_042b
			//IL_0036: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			//IL_0073: Expected F4, but got I4
			//IL_0142: Expected O, but got I4
			//IL_015a: Expected O, but got I4
			//IL_017e: Expected F4, but got I4
			//IL_024e: Expected O, but got I4
			//IL_026a: Expected O, but got I4
			//IL_028e: Expected F4, but got I4
			//IL_035e: Expected O, but got I4
			//IL_0376: Expected O, but got I4
			//IL_039a: Expected F4, but got I4
			MeshRenderer meshRenderer8;
			Material[] array8;
			Material material8;
			while (true)
			{
				GameObject gameObject = new GameObject("Up Wall");
				gameObject.hideFlags = HideFlags.DontSave;
				Transform transform = gameObject.transform;
				Transform transform3 = (transform.parentInternal = base.transform);
				int num = 0;
				gameObject.transform.localPosition = (Vector3)num;
				int num2 = 0;
				Transform transform4 = gameObject.transform;
				int num3 = 0;
				transform4.localRotation = (Quaternion)num2;
				MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
				int num4 = width;
				List<(int, int)> list = (List<(int, int)>)(object)new List<T>();
				int num5 = 0;
				Mesh mesh2 = (meshFilter.sharedMesh = this.UpdateWallMesh(num4, (List<>)(object)list, (float)num5));
				MeshRenderer[] array = wallRenderers;
				MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
				if ((object)meshRenderer != null && (object)meshRenderer == null)
				{
					continue;
				}
				array[0] = meshRenderer;
				MeshRenderer meshRenderer2 = wallRenderers[0];
				Material[] array2 = new Material[2];
				Material material = frontMaterial;
				if ((object)material != null && array2 == null)
				{
					continue;
				}
				array2[0] = material;
				Material material2 = backMaterial;
				if ((object)material2 != null && array2 == null)
				{
					continue;
				}
				array2[1] = material2;
				((Renderer)meshRenderer2).SetMaterialArray(array2);
				GameObject gameObject2 = new GameObject("Right Wall");
				gameObject2.hideFlags = HideFlags.DontSave;
				Transform transform5 = gameObject2.transform;
				Transform transform7 = (transform5.parentInternal = base.transform);
				int num6 = 0;
				gameObject2.transform.localPosition = (Vector3)num6;
				int num7 = 0;
				Transform transform8 = gameObject2.transform;
				int num8 = 0;
				transform8.localRotation = (Quaternion)num7;
				MeshFilter meshFilter2 = gameObject2.AddComponent<MeshFilter>();
				int num9 = height;
				List<(int, int)> list2 = (List<(int, int)>)(object)new List<T>();
				Mesh mesh4 = (meshFilter2.sharedMesh = this.UpdateWallMesh(num9, (List<>)(object)list2, (float)num8));
				MeshRenderer[] array3 = wallRenderers;
				MeshRenderer meshRenderer3 = gameObject2.AddComponent<MeshRenderer>();
				if ((object)meshRenderer3 != null && (object)meshRenderer3 == null)
				{
					continue;
				}
				array3[1] = meshRenderer3;
				MeshRenderer meshRenderer4 = wallRenderers[1];
				Material[] array4 = new Material[2];
				Material material3 = frontMaterial;
				if ((object)material3 != null && array4 == null)
				{
					continue;
				}
				array4[0] = material3;
				Material material4 = backMaterial;
				if ((object)material4 != null && array4 == null)
				{
					continue;
				}
				array4[1] = material4;
				((Renderer)meshRenderer4).SetMaterialArray(array4);
				GameObject gameObject3 = new GameObject("Down Wall");
				gameObject3.hideFlags = HideFlags.DontSave;
				Transform transform9 = gameObject3.transform;
				Transform transform11 = (transform9.parentInternal = base.transform);
				int num10 = 0;
				gameObject3.transform.localPosition = (Vector3)num10;
				Transform transform12 = gameObject3.transform;
				int num11 = 0;
				Quaternion identity = Quaternion.identity;
				transform12.localRotation = (Quaternion)num11;
				MeshFilter meshFilter3 = gameObject3.AddComponent<MeshFilter>();
				int num12 = width;
				List<(int, int)> list3 = (List<(int, int)>)(object)new List<T>();
				Mesh mesh6 = (meshFilter3.sharedMesh = this.UpdateWallMesh(num12, (List<>)(object)list3, (float)num8));
				MeshRenderer[] array5 = wallRenderers;
				MeshRenderer meshRenderer5 = gameObject3.AddComponent<MeshRenderer>();
				if ((object)meshRenderer5 != null && (object)meshRenderer5 == null)
				{
					continue;
				}
				array5[2] = meshRenderer5;
				MeshRenderer meshRenderer6 = wallRenderers[2];
				Material[] array6 = new Material[2];
				Material material5 = frontMaterial;
				if ((object)material5 != null && array6 == null)
				{
					continue;
				}
				array6[0] = material5;
				Material material6 = backMaterial;
				if ((object)material6 != null && array6 == null)
				{
					continue;
				}
				array6[1] = material6;
				((Renderer)meshRenderer6).SetMaterialArray(array6);
				GameObject gameObject4 = new GameObject("Left Wall");
				gameObject4.hideFlags = HideFlags.DontSave;
				Transform transform13 = gameObject4.transform;
				Transform transform15 = (transform13.parentInternal = base.transform);
				int num13 = 0;
				gameObject4.transform.localPosition = (Vector3)num13;
				int num14 = 0;
				Transform transform16 = gameObject4.transform;
				int num15 = 0;
				transform16.localRotation = (Quaternion)num14;
				MeshFilter meshFilter4 = gameObject4.AddComponent<MeshFilter>();
				int num16 = height;
				List<(int, int)> list4 = (List<(int, int)>)(object)new List<T>();
				Mesh mesh8 = (meshFilter4.sharedMesh = this.UpdateWallMesh(num16, (List<>)(object)list4, (float)num15));
				MeshRenderer[] array7 = wallRenderers;
				MeshRenderer meshRenderer7 = gameObject4.AddComponent<MeshRenderer>();
				if ((object)meshRenderer7 != null && (object)meshRenderer7 == null)
				{
					continue;
				}
				array7[3] = meshRenderer7;
				meshRenderer8 = wallRenderers[3];
				array8 = new Material[2];
				Material material7 = frontMaterial;
				if ((object)material7 == null || array8 != null)
				{
					array8[0] = material7;
					material8 = backMaterial;
					if ((object)material8 == null || array8 != null)
					{
						break;
					}
				}
			}
			array8[1] = material8;
			((Renderer)meshRenderer8).SetMaterialArray(array8);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C26")]
		[Cpp2IlInjected.Address(RVA = "0x11AF2A0", Offset = "0x11ADCA0", VA = "0x1811AF2A0")]
		private unsafe void OnDestroy()
		{
			//Discarded unreachable code: IL_0039
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			AsyncOperationHandle<Material>[] array = materialHandles;
			int num = 0;
			if (num < array.Length)
			{
				array = (AsyncOperationHandle<Material>[])(array + num);
				if (((AsyncOperationHandle<TObject>*)array)->IsValid())
				{
					AsyncOperationHandle<Material>[] array2 = materialHandles;
					AsyncOperationHandle<> asyncOperationHandle = default(AsyncOperationHandle<>);
					Addressables.Release<Material>(asyncOperationHandle);
				}
				AsyncOperationHandle<Material>[] array3 = materialHandles;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C27")]
		[Cpp2IlInjected.Address(RVA = "0x11AF260", Offset = "0x11ADC60", VA = "0x1811AF260")]
		public Item GetWallpaper(House.Types.WallPosition orientation)
		{
			//Discarded unreachable code: IL_0011
			Item[] array = wallpapers;
			return array[(int)orientation];
		}

		[Cpp2IlInjected.Token(Token = "0x6001C28")]
		[Cpp2IlInjected.Address(RVA = "0x11AF4B0", Offset = "0x11ADEB0", VA = "0x1811AF4B0")]
		[AsyncStateMachine(typeof(_003CSetWallpaper_003Ed__13))]
		public Task SetWallpaper(House.Types.WallPosition orientation, Item wallpaper)
		{
			int itemID = wallpaper.ItemID;
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C29")]
		[Cpp2IlInjected.Address(RVA = "0x11AF5E0", Offset = "0x11ADFE0", VA = "0x1811AF5E0")]
		public Task SetWallpaper(Item wallpaper)
		{
			//Discarded unreachable code: IL_0051
			Task[] array;
			Task task = default(Task);
			Task task2 = default(Task);
			Task task3 = default(Task);
			Task task4 = default(Task);
			while (true)
			{
				array = new Task[4];
				if (task != null && task == null)
				{
					continue;
				}
				array[0] = task;
				if (task2 != null && task2 == null)
				{
					continue;
				}
				array[1] = task2;
				if (task3 == null || task3 != null)
				{
					array[2] = task3;
					if (task4 == null || task4 != null)
					{
						break;
					}
				}
			}
			array[3] = task4;
			return Task.WhenAll(array);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C2A")]
		[Cpp2IlInjected.Address(RVA = "0x11AF220", Offset = "0x11ADC20", VA = "0x1811AF220")]
		internal Renderer GetMainWallRenderer(House.Types.WallPosition wallPosition)
		{
			MeshRenderer[] array = wallRenderers;
			MeshRenderer meshRenderer = array[(int)wallPosition];
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C2B")]
		[Cpp2IlInjected.Address(RVA = "0x11AF1A0", Offset = "0x11ADBA0", VA = "0x1811AF1A0")]
		[IteratorStateMachine(typeof(_003CGetAllWallRenderers_003Ed__16))]
		internal IEnumerable<Renderer> GetAllWallRenderers(House.Types.WallPosition wallPosition)
		{
			_003CGetAllWallRenderers_003Ed__16 _003CGetAllWallRenderers_003Ed__ = new _003CGetAllWallRenderers_003Ed__16(-2);
			_003CGetAllWallRenderers_003Ed__._003C_003E4__this = this;
			_003CGetAllWallRenderers_003Ed__._003C_003E3__wallPosition = wallPosition;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C2C")]
		[Cpp2IlInjected.Address(RVA = "0x11B18B0", Offset = "0x11B02B0", VA = "0x1811B18B0")]
		internal Vector2 UpdateWallObject(GridObjectScript wallObject, out Material wallPaperMaterial)
		{
			//IL_005f: Expected O, but got I4
			int wall;
			int num2;
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				wall = 0;
				num2 = 0;
				GridObject _003CGridObject_003Ek__BackingField = wallObject.GridObject;
				if (!flag)
				{
					GridObject _003CGridObject_003Ek__BackingField2 = wallObject.GridObject;
				}
				GridScript _003CGridScript_003Ek__BackingField = wallObject.GridScript;
				int num3 = 0;
				if ((object)_003CGridScript_003Ek__BackingField != null)
				{
					int num4 = 0;
					if ((object)_003CGridScript_003Ek__BackingField != null)
					{
						break;
					}
				}
			}
			List<int> list = (List<int>)(object)new List<T>();
			if ((long)(IntPtr)list < 0L)
			{
				num2++;
			}
			if (((List<T>)(object)gridObjectScripts[num2]).Remove((T)wallObject))
			{
				((List<T>)(object)list).Add((T)num2);
			}
			uint num5 = num5 + 1;
			if (!((List<T>)(object)gridObjectScripts[num2]).Contains((T)wallObject))
			{
				((List<T>)(object)gridObjectScripts[num2]).Add((T)wallObject);
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				UpdateWallMesh(wall);
			}
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			if (!flag3 || flag4)
			{
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C2D")]
		[Cpp2IlInjected.Address(RVA = "0x11AF400", Offset = "0x11ADE00", VA = "0x1811AF400")]
		internal bool RemoveWallObject(GridObjectScript wallObject)
		{
			//Discarded unreachable code: IL_0028
			int num = 0;
			bool flag = ((List<T>)(object)gridObjectScripts[num]).Remove((T)wallObject);
			if (!flag)
			{
				num++;
				return flag;
			}
			UpdateWallMesh(num);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C2E")]
		[Cpp2IlInjected.Address(RVA = "0x11AFE40", Offset = "0x11AE840", VA = "0x1811AFE40")]
		private void UpdateWallMesh(int wall)
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected I4, but got Unknown
			//IL_008a: Expected O, but got I4
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected I4, but got Unknown
			//IL_00c9: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			GridPosition gridPosition = default(GridPosition);
			int num5 = default(int);
			Mesh sharedMesh = default(Mesh);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			GridPosition gridPosition2 = default(GridPosition);
			while (true)
			{
				int num = 0;
				MeshFilter component = wallRenderers[wall].GetComponent<MeshFilter>();
				int num2 = 0;
				if (!Application.isPlaying)
				{
					UnityEngine.Object.DestroyImmediate(component.sharedMesh);
				}
				UnityEngine.Object.Destroy(component.sharedMesh);
				int num3 = height * wall;
				num3 += wall;
				if (wall != 0 && wall != 2)
				{
					List<(int, int)> list = (List<(int, int)>)(object)new List<T>();
					List<GridObjectScript> list2 = gridObjectScripts[wall];
					if (flag)
					{
						if (!flag2 && wall == 1)
						{
							int num4 = height;
							num4 += num4;
							num4 = (int)(num4 - gridPosition);
						}
						((List<T>)(object)list).Add((T)num);
					}
					num5 = 0;
					if (num == 0)
					{
						component.sharedMesh = sharedMesh;
						return;
					}
					continue;
				}
				List<(int, int)> list3 = (List<(int, int)>)(object)new List<T>();
				if (flag3)
				{
					if (!flag4 && wall == 2)
					{
						flag4 = (byte)((flag4 ? 1u : 0u) + (flag4 ? 1u : 0u)) != 0;
						flag4 = (byte)(int)(flag4 - gridPosition2) != 0;
					}
					((List<T>)(object)list3).Add((T)num5);
				}
				int num6 = 0;
				if (num5 == 0)
				{
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C2F")]
		[Cpp2IlInjected.Address(RVA = "0x11B0450", Offset = "0x11AEE50", VA = "0x1811B0450")]
		private Mesh UpdateWallMesh(int sideLength, List<(int offset, int size)> partsToRemove, float startU)
		{
			//Discarded unreachable code: IL_027f
			//IL_00d0: Expected O, but got I4
			//IL_00d9: Expected O, but got I4
			Mesh mesh;
			List<Vector3> vertices;
			List<Vector3> normals;
			List<Vector2> list;
			List<int>[] array;
			bool flag = default(bool);
			ulong num17 = default(ulong);
			float num5;
			int num4;
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				num4 = 0;
				mesh = new Mesh();
				vertices = (List<Vector3>)(object)new List<T>();
				normals = (List<Vector3>)(object)new List<T>();
				list = (List<Vector2>)(object)new List<T>();
				array = new List<int>[0];
				List<int> list2 = (List<int>)(object)new List<T>();
				if (list2 != null && list2 == null)
				{
					continue;
				}
				array[0] = list2;
				List<int> list3 = (List<int>)(object)new List<T>();
				if (list3 != null && list3 == null)
				{
					continue;
				}
				array[1] = list3;
				num5 = wallHeight;
				float num6 = wallThickness;
				float num7 = wallThickness;
				float num8 = wallThickness;
				float num9 = wallHeight;
				float num10 = wallHeight;
				float num11 = wallThickness;
				float num12 = wallHeight;
				float z = Vector3.up.z;
				float z2 = Vector3.up.z;
				float z3 = Vector3.up.z;
				float num13 = wallThickness;
				((List<T>)(object)list).Add((T)num4);
				((List<T>)(object)list).Add((T)num4);
				List<int> list4 = array[1];
				int[] array2 = new int[3];
				int length = array2.Length;
				array2[0] = num4;
				num4 = (array2[1] = (array2[0] = num4 + 1) + 2);
				((List<T>)(object)list4).AddRange((IEnumerable<>)(object)array2);
				if (num4 >= num4)
				{
					break;
				}
				int num14 = 0;
				if (flag)
				{
					num3 += num3;
					while (num4 >= num3)
					{
					}
				}
				int num15 = 0;
				int num16 = 0;
				if (num7 == 0f)
				{
					if (num17 == 0)
					{
						float num18 = wallHeight;
						num9 = wallThickness;
						float num19 = wallThickness;
					}
					num4++;
					break;
				}
			}
			float num20 = wallThickness;
			float num21 = wallThickness;
			num5 = num21;
			num21 = num5;
			float num22 = wallHeight;
			float num23 = wallThickness;
			float num24 = wallThickness;
			float num25 = wallHeight;
			float num26 = wallHeight;
			float z4 = Vector3.up.z;
			float z5 = Vector3.up.z;
			float z6 = Vector3.up.z;
			List<int> list5 = array[1];
			int[] array3 = new int[3];
			int length2 = array3.Length;
			array3[0] = num4;
			num4 = (array3[1] = (array3[0] = num4 + 1) + 2);
			((List<T>)(object)list5).AddRange((IEnumerable<>)(object)array3);
			mesh.SetVertices((List<>)(object)vertices);
			int num27 = 0;
			mesh.SetUVs(num27, (List<>)(object)list);
			mesh.subMeshCount = 2;
			int num28 = 0;
			List<int> list6 = array[0];
			mesh.SetTriangles((List<>)(object)list6, num28);
			List<int> list7 = array[1];
			mesh.SetTriangles((List<>)(object)list7, 1);
			mesh.SetNormals((List<>)(object)normals);
			mesh.RecalculateTangents();
			return mesh;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C30")]
		[Cpp2IlInjected.Address(RVA = "0x11B1F20", Offset = "0x11B0920", VA = "0x1811B1F20")]
		public HouseWallManager()
		{
			//Discarded unreachable code: IL_00b8
			//IL_0009: Expected I4, but got I8
			//IL_0012: Expected I4, but got I8
			List<GridObjectScript>[] array;
			List<GridObjectScript> list4;
			while (true)
			{
				width = 6;
				height = 6;
				wallRenderers = new MeshRenderer[4];
				array = new List<GridObjectScript>[4];
				List<GridObjectScript> list = (List<GridObjectScript>)(object)new List<T>();
				if (list != null && list == null)
				{
					continue;
				}
				array[0] = list;
				List<GridObjectScript> list2 = (List<GridObjectScript>)(object)new List<T>();
				if (list2 != null && list2 == null)
				{
					continue;
				}
				array[1] = list2;
				List<GridObjectScript> list3 = (List<GridObjectScript>)(object)new List<T>();
				if (list3 == null || list3 != null)
				{
					array[2] = list3;
					list4 = (List<GridObjectScript>)(object)new List<T>();
					if (list4 == null || list4 != null)
					{
						break;
					}
				}
			}
			array[3] = list4;
			gridObjectScripts = array;
			wallpapers = new Item[4];
			materialHandles = new AsyncOperationHandle<Material>[4];
			base._002Ector();
		}
	}
}
