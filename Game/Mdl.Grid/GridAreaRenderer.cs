using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000405")]
	public class GridAreaRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019F9")]
		[SerializeField]
		private Material _opaqueMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019FA")]
		[SerializeField]
		private Material _transparentMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40019FB")]
		[SerializeField]
		private Material _gridMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40019FF")]
		private GameObject gridMeshGizmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001A00")]
		private MeshRenderer gridRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001A01")]
		private int gridTextureSizeX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001A02")]
		private int gridTextureSizeY;

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public Texture2D GridTextureGizmo
		{
			[Cpp2IlInjected.Token(Token = "0x6001107")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CGridTextureGizmo_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001108")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CGridTextureGizmo_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public MeshRenderer MeshRenderer
		{
			[Cpp2IlInjected.Token(Token = "0x6001109")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CMeshRenderer_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600110A")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CMeshRenderer_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x600110B")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CCollider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600110C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CCollider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600110D")]
		[Cpp2IlInjected.Address(RVA = "0xCEBAD0", Offset = "0xCEA4D0", VA = "0x180CEBAD0")]
		private void Awake()
		{
			base.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}

		[Cpp2IlInjected.Token(Token = "0x600110E")]
		[Cpp2IlInjected.Address(RVA = "0xCEBAE0", Offset = "0xCEA4E0", VA = "0x180CEBAE0")]
		private void OnDestroy()
		{
			//IL_0010: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			GameObject gameObject = gridMeshGizmo;
			int num = 0;
			if (gameObject != (Object)num)
			{
				Object.DestroyImmediate(gridMeshGizmo);
				int num2 = 0;
				gridMeshGizmo = (GameObject)num2;
				GridTextureGizmo = (Texture2D)num2;
				MeshRenderer = (MeshRenderer)num2;
				Collider = (Collider)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600110F")]
		[Cpp2IlInjected.Address(RVA = "0xCEBBC0", Offset = "0xCEA5C0", VA = "0x180CEBBC0")]
		public void Init(int sizeX, int sizeY, bool transparency = false)
		{
			//Discarded unreachable code: IL_0263
			//IL_0010: Expected O, but got I4
			//IL_003a: Expected I4, but got I8
			//IL_00b3: Expected O, but got I4
			//IL_00db: Expected F4, but got I4
			//IL_00e6: Expected O, but got I4
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected F4, but got Unknown
			//IL_010d: Expected O, but got I4
			//IL_019f: Expected O, but got I4
			//IL_01e6: Expected O, but got I4
			//IL_0202: Expected O, but got I4
			//IL_021e: Expected O, but got I4
			//IL_0244: Expected O, but got I4
			GameObject gameObject = gridMeshGizmo;
			int num = 0;
			if (gameObject == (Object)num)
			{
				int layer = LayerMask.NameToLayer("GridGizmo");
				gridTextureSizeX = sizeX;
				gridTextureSizeY = sizeY;
				ulong num2 = default(ulong);
				Texture2D texture2D = new Texture2D(sizeX, sizeY, TextureFormat.RGBA32, (byte)num2 != 0);
				int num3 = (int)(texture2D.filterMode = FilterMode.Point);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.name = "GridTextureGizmo";
				GridTextureGizmo = texture2D;
				GameObject gameObject2 = (gridMeshGizmo = GameObject.CreatePrimitive(PrimitiveType.Quad));
				gridMeshGizmo.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
				Transform transform = gridMeshGizmo.transform;
				Transform transform3 = (transform.parent = base.transform);
				GameObject gameObject3 = gridMeshGizmo;
				int num4 = 0;
				gameObject3.transform.localPosition = (Vector3)num4;
				GameObject gameObject4 = gridMeshGizmo;
				int num5 = 0;
				Transform transform4 = gameObject4.transform;
				int num6 = 0;
				Quaternion quaternion = Quaternion.Euler(0.0001f, 90f, num6);
				transform4.localRotation = (Quaternion)num5;
				GameObject gameObject5 = gridMeshGizmo;
				int num7 = 0;
				Transform transform5 = gameObject5.transform;
				float num8 = num6 * 0.5f;
				transform5.localScale = (Vector3)num7;
				gridMeshGizmo.layer = layer;
				Collider collider = (Collider = gridMeshGizmo.GetComponent<Collider>());
				if (transparency)
				{
				}
				Material material = Object.Instantiate(_opaqueMaterial);
				Texture2D value = GridTextureGizmo;
				material.SetTexture("_MainTex", value);
				MeshRenderer meshRenderer = (MeshRenderer = gridMeshGizmo.GetComponent<MeshRenderer>());
				((Renderer)MeshRenderer).SetMaterial(material);
				MeshRenderer meshRenderer2 = MeshRenderer;
				int num9 = (int)(meshRenderer2.shadowCastingMode = ShadowCastingMode.Off);
				Material gridMaterial = _gridMaterial;
				int num10 = 0;
				if (gridMaterial != (Object)num10)
				{
					GameObject gameObject6 = GameObject.CreatePrimitive(PrimitiveType.Quad);
					gameObject6.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
					Transform transform6 = gameObject6.transform;
					Transform transform8 = (transform6.parent = gridMeshGizmo.transform);
					int num11 = 0;
					gameObject6.transform.localPosition = (Vector3)num11;
					Transform transform9 = gameObject6.transform;
					int num12 = 0;
					Quaternion identity = Quaternion.identity;
					transform9.localRotation = (Quaternion)num12;
					Transform transform10 = gameObject6.transform;
					int num13 = 0;
					Vector3 one = Vector3.one;
					transform10.localScale = (Vector3)num13;
					int num14 = 0;
					gameObject6.layer = layer;
					Material material2 = Object.Instantiate(_gridMaterial);
					material2.SetVector("_GridSize", (Vector4)num14);
					MeshRenderer meshRenderer3 = (gridRenderer = gameObject6.GetComponent<MeshRenderer>());
					((Renderer)gridRenderer).SetMaterial(material2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001110")]
		[Cpp2IlInjected.Address(RVA = "0xCEC280", Offset = "0xCEAC80", VA = "0x180CEC280")]
		public void UpdateGizmo(int sizeX, int sizeY, Color[] colorArray)
		{
			//Discarded unreachable code: IL_00d6
			//IL_0010: Expected O, but got I4
			//IL_0038: Expected I4, but got I8
			//IL_00a1: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			GameObject gameObject = gridMeshGizmo;
			int num = 0;
			if (!(gameObject == (Object)num))
			{
				if (gridTextureSizeX == sizeX)
				{
				}
				gridTextureSizeX = sizeX;
				gridTextureSizeY = sizeY;
				ulong num2 = default(ulong);
				Texture2D texture2D = new Texture2D(sizeX, sizeY, TextureFormat.RGBA32, (byte)num2 != 0);
				int num3 = (int)(texture2D.filterMode = FilterMode.Point);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.name = "GridTextureGizmo";
				GridTextureGizmo = texture2D;
				Material sharedMaterial = ((Renderer)MeshRenderer).GetSharedMaterial();
				Texture2D value = GridTextureGizmo;
				sharedMaterial.SetTexture("_MainTex", value);
				Transform transform = gridMeshGizmo.transform;
				MeshRenderer meshRenderer = gridRenderer;
				int num4 = 0;
				if (meshRenderer != (Object)num4)
				{
					Material sharedMaterial2 = ((Renderer)gridRenderer).GetSharedMaterial();
					int num5 = 0;
					sharedMaterial2.SetVector("_GridSize", (Vector4)num5);
				}
				Texture2D texture2D2 = GridTextureGizmo;
				GridTextureGizmo.Apply();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001111")]
		[Cpp2IlInjected.Address(RVA = "0xCEBAE0", Offset = "0xCEA4E0", VA = "0x180CEBAE0")]
		public void Cleanup()
		{
			//IL_0010: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			GameObject gameObject = gridMeshGizmo;
			int num = 0;
			if (gameObject != (Object)num)
			{
				Object.DestroyImmediate(gridMeshGizmo);
				int num2 = 0;
				gridMeshGizmo = (GameObject)num2;
				GridTextureGizmo = (Texture2D)num2;
				MeshRenderer = (MeshRenderer)num2;
				Collider = (Collider)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001112")]
		[Cpp2IlInjected.Address(RVA = "0xCEC1B0", Offset = "0xCEABB0", VA = "0x180CEC1B0")]
		public void SetActive(bool visual, bool collider)
		{
			//Discarded unreachable code: IL_0038
			//IL_001c: Expected O, but got I4
			MeshRenderer.enabled = visual;
			MeshRenderer meshRenderer = gridRenderer;
			int num = 0;
			if (meshRenderer != (Object)num)
			{
				gridRenderer.enabled = visual;
			}
			Collider.enabled = collider;
		}

		[Cpp2IlInjected.Token(Token = "0x6001113")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GridAreaRenderer()
		{
		}
	}
}
