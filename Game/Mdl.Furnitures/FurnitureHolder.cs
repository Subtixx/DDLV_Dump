using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Decals;
using Mdl.Graphic;
using Mdl.Navigation;
using Meta.Customization;
using UnityEngine;

namespace Mdl.Furnitures
{
	[Cpp2IlInjected.Token(Token = "0x2000558")]
	public class FurnitureHolder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002145")]
		public int texturePoolMaxCount = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002146")]
		public OrbitCameraTarget decalTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002147")]
		public Collider defaultCollider;

		[Cpp2IlInjected.Token(Token = "0x1700032D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4002148")]
		public int FurnitureItem
		{
			[Cpp2IlInjected.Token(Token = "0x60017E7")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60017E8")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032E")]
		public List<MeshRenderer> Renderers
		{
			[Cpp2IlInjected.Token(Token = "0x60017E9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CRenderers_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60017EA")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CRenderers_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<MeshRenderer>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x1700032F")]
		public GameObject Asset
		{
			[Cpp2IlInjected.Token(Token = "0x60017EB")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CAsset_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60017EC")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CAsset_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000330")]
		public Color DefaultTint
		{
			[Cpp2IlInjected.Token(Token = "0x60017ED")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8C0", Offset = "0x8BA2C0", VA = "0x1808BB8C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60017EE")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8D0", Offset = "0x8BA2D0", VA = "0x1808BB8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000331")]
		public IList<IDecal> StaticDecals
		{
			[Cpp2IlInjected.Token(Token = "0x60017EF")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CStaticDecals_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60017F0")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CStaticDecals_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (IList<IDecal>)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x17000332")]
		public TexturePool DecalsTextures
		{
			[Cpp2IlInjected.Token(Token = "0x60017F1")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CDecalsTextures_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60017F2")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			private set
			{
				_003CDecalsTextures_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017F3")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD00", Offset = "0x8B9700", VA = "0x1808BAD00")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0011
			Collider collider = defaultCollider;
			int num = ((collider.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60017F4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB320", Offset = "0x8B9D20", VA = "0x1808BB320")]
		public void Init(int textureResolution)
		{
			int maxCount = texturePoolMaxCount;
			int format = default(int);
			TexturePool texturePool = new TexturePool(textureResolution, maxCount, (RenderTextureFormat)format);
			format = 0;
			DecalsTextures = texturePool;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60017F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3B0", Offset = "0x8B9DB0", VA = "0x1808BB3B0")]
		public void SetAsset(GameObject asset, int furnitureItem, bool parent)
		{
			//Discarded unreachable code: IL_00e3
			//IL_002b: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			Asset = asset;
			List<MeshRenderer> list = Renderers;
			FurnitureItem = furnitureItem;
			((List<T>)(object)list).Clear();
			IList<IDecal> list2 = StaticDecals;
			int num = 0;
			if (!(asset == (Object)num))
			{
				if (parent)
				{
					Transform transform = asset.transform;
					Transform transform3 = (transform.parentInternal = base.transform);
					Transform transform4 = asset.transform;
					float z = UnityEngine.Vector3.zero.z;
					Transform transform5 = asset.transform;
					Quaternion identity = Quaternion.identity;
				}
				FurnitureItemScript component = asset.GetComponent<FurnitureItemScript>();
				int num2 = 0;
				if (!(component != (Object)num2))
				{
					Color white = Color.white;
				}
				List<IDecal> list3 = (List<IDecal>)(StaticDecals = (IList<IDecal>)DecalUtil.ParseDecals(component.staticDecals));
				List<MeshRenderer> list4 = (Renderers = component.decalRenderers);
				Color color = (DefaultTint = component.defaultTint);
				List<MeshRenderer> list5 = Renderers;
				List<MeshRenderer> list6 = (Renderers = (List<MeshRenderer>)(object)Enumerable.ToList<MeshRenderer>((IEnumerable<>)(object)asset.GetComponentsInChildren<MeshRenderer>()));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017F6")]
		[Cpp2IlInjected.Address(RVA = "0x8BB670", Offset = "0x8BA070", VA = "0x1808BB670")]
		public void SetTint(Color color)
		{
			//Discarded unreachable code: IL_0012, IL_0018, IL_001e, IL_0024
			int num = 0;
			List<MeshRenderer> list = Renderers;
			bool flag = default(bool);
			if (flag)
			{
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2A0", Offset = "0x8B9CA0", VA = "0x1808BB2A0")]
		public bool HasDecalTexture()
		{
			//Discarded unreachable code: IL_0020
			//IL_001f: Expected O, but got I4
			TexturePool texturePool = DecalsTextures;
			int id = FurnitureItem;
			RenderTexture texture = texturePool.GetTexture(id);
			int num = 0;
			return texture != (Object)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60017F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9C20", VA = "0x1808BB220")]
		public bool HasDecalTexture(int furnitureItem)
		{
			//Discarded unreachable code: IL_0017
			//IL_0016: Expected O, but got I4
			RenderTexture texture = DecalsTextures.GetTexture(furnitureItem);
			int num = 0;
			return texture != (Object)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60017F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BACD0", Offset = "0x8B96D0", VA = "0x1808BACD0")]
		public RenderTexture AcquireDecalTexture()
		{
			//Discarded unreachable code: IL_0016
			TexturePool texturePool = DecalsTextures;
			int id = FurnitureItem;
			return texturePool.AcquireTexture(id);
		}

		[Cpp2IlInjected.Token(Token = "0x60017FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEC0", Offset = "0x8B98C0", VA = "0x1808BAEC0")]
		public void EnableDecals()
		{
			//Discarded unreachable code: IL_0062, IL_0068, IL_006e, IL_0074, IL_007a, IL_0080, IL_0086, IL_008c
			//IL_0034: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			List<MeshRenderer> list = Renderers;
			TexturePool texturePool = DecalsTextures;
			int id = FurnitureItem;
			RenderTexture renderTexture = texturePool.AcquireTexture(id);
			int num4 = 0;
			if (renderTexture == (Object)num4)
			{
				List<MeshRenderer> list2 = Renderers;
				bool flag = default(bool);
				if (flag)
				{
					num3++;
				}
				num3++;
				if (num3 == 0)
				{
				}
			}
			List<MeshRenderer> list3 = Renderers;
			bool flag2 = default(bool);
			if (flag2)
			{
				num3++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD30", Offset = "0x8B9730", VA = "0x1808BAD30")]
		public void DisableDecals()
		{
			//Discarded unreachable code: IL_0030, IL_0036, IL_003c, IL_0042
			int num = 0;
			List<MeshRenderer> list = Renderers;
			TexturePool texturePool = DecalsTextures;
			int id = FurnitureItem;
			texturePool.ReleaseTexture(id);
			List<MeshRenderer> list2 = Renderers;
			bool flag = default(bool);
			if (flag)
			{
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7F0", Offset = "0x8BA1F0", VA = "0x1808BB7F0")]
		public FurnitureHolder()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
