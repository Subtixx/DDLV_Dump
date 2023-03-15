using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Display
{
	[Cpp2IlInjected.Token(Token = "0x2000817")]
	public class AvatarMannequin : BaseMannequin
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000818")]
		public class ClothingInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002D35")]
			public GameObject defaultBarePart;

			[Cpp2IlInjected.Token(Token = "0x6002453")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ClothingInfo()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002D29")]
		public AssetReference HeadMeshReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002D2A")]
		public AssetReference BodyMeshReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002D2B")]
		private Material loadedHeadMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002D2C")]
		private Material loadedBodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002D2D")]
		private Material loadedClothingMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002D2E")]
		private RenderTexture decalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002D2F")]
		public AssetReferenceMaterial HeadMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002D30")]
		public AssetReferenceMaterial HeadMaterialDark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002D31")]
		public AssetReferenceMaterial BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002D32")]
		public AssetReferenceMaterial BodyMaterialDark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002D33")]
		[HideInInspector]
		public ClothingInfo[] clothingInfos;

		[Cpp2IlInjected.Token(Token = "0x17000529")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x600244B")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			[CompilerGenerated]
			get
			{
				return _003CAnimator_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600244C")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			[CompilerGenerated]
			private set
			{
				_003CAnimator_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600244D")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "6")]
		public override bool HasOffsetFromRoot(Item attachedItem)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600244E")]
		[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "7")]
		public override Renderer GetVisualRenderer()
		{
			SkinnedMeshRenderer skinnedMeshRenderer = combinedMannequin;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600244F")]
		[Cpp2IlInjected.Address(RVA = "0x151DEF0", Offset = "0x151C8F0", VA = "0x18151DEF0", Slot = "8")]
		protected override void Awake()
		{
			//IL_0016: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			base.Awake();
			SkinnedMeshRenderer skinnedMeshRenderer = combinedMannequin;
			int num = 0;
			if (skinnedMeshRenderer != (UnityEngine.Object)num)
			{
				Mesh sharedMesh = combinedMannequin.sharedMesh;
				int num2 = 0;
				if (sharedMesh != (UnityEngine.Object)num2)
				{
					SkinnedMeshRenderer skinnedMeshRenderer2 = combinedMannequin;
					Mesh mesh2 = (skinnedMeshRenderer2.sharedMesh = UnityEngine.Object.Instantiate(skinnedMeshRenderer2.sharedMesh));
				}
			}
			Animator animator = (Animator = GetComponent<Animator>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002450")]
		[Cpp2IlInjected.Address(RVA = "0x151E160", Offset = "0x151CB60", VA = "0x18151E160", Slot = "4")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_00d5
			//IL_0010: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			//IL_007a: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			SkinnedMeshRenderer skinnedMeshRenderer = combinedMannequin;
			int num = 0;
			if (skinnedMeshRenderer != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(combinedMannequin.sharedMesh);
			}
			Material material = loadedHeadMaterial;
			int num2 = 0;
			bool flag = material != (UnityEngine.Object)num2;
			int num3 = 0;
			if (flag)
			{
				Addressables.Release(loadedHeadMaterial);
				loadedHeadMaterial = (Material)num3;
			}
			Material material2 = loadedClothingMaterial;
			int num4 = 0;
			if (material2 != (UnityEngine.Object)num4)
			{
				Addressables.Release(loadedClothingMaterial);
				loadedClothingMaterial = (Material)num3;
			}
			Material material3 = loadedBodyMaterial;
			int num5 = 0;
			if (material3 != (UnityEngine.Object)num5)
			{
				Addressables.Release(loadedBodyMaterial);
				loadedBodyMaterial = (Material)num3;
			}
			RenderTexture renderTexture = decalTexture;
			int num6 = 0;
			if (renderTexture != (UnityEngine.Object)num6)
			{
				decalTexture.Release();
				decalTexture = (RenderTexture)num3;
			}
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6002451")]
		[Cpp2IlInjected.Address(RVA = "0x151E050", Offset = "0x151CA50", VA = "0x18151E050", Slot = "5")]
		[AsyncStateMachine(typeof(_003CDoAttachObject_003Ed__20))]
		protected override Task DoAttachObject(GameObject objToAttach)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002452")]
		[Cpp2IlInjected.Address(RVA = "0xA86EA0", Offset = "0xA858A0", VA = "0x180A86EA0")]
		public AvatarMannequin()
		{
		}
	}
}
