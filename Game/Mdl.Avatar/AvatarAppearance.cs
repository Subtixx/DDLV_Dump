using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Decals;
using Mdl.Navigation;
using Meta;
using Meta.Customization;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x20009F6")]
	public class AvatarAppearance : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20009F7")]
		private struct LoadedMakeup
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400372A")]
			public MakeupItem item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400372B")]
			public AsyncOperationHandle<Texture2D> handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400372C")]
			public Color32 color1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400372D")]
			public Color32 color2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400372E")]
			public Color32 color3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400372F")]
			public float opacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4003730")]
			public float glossiness;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4003731")]
			public bool isMale;
		}

		[Cpp2IlInjected.Token(Token = "0x20009F8")]
		public enum AnimControllerType
		{
			[Cpp2IlInjected.Token(Token = "0x4003733")]
			Navigation,
			[Cpp2IlInjected.Token(Token = "0x4003734")]
			Customization
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20009F9")]
		public class BodyType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003735")]
			public string blendShape;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003736")]
			public int intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003737")]
			public AssetReferenceAtlasedSprite iconReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4003738")]
			public string animationLayer;

			[Cpp2IlInjected.Token(Token = "0x6002F05")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public BodyType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20009FA")]
		public delegate void AvatarChanged(AvatarAppearance avatar);

		[Cpp2IlInjected.Token(Token = "0x20009FB")]
		private struct LoadedClothes
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003739")]
			public Item item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400373A")]
			public int designId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400373B")]
			public AsyncOperationHandle<GameObject> handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400373C")]
			public bool isMale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400373D")]
			public ClothingItemScript clothingItemScript;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400373E")]
			public SkinnedMeshRenderer smr;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400373F")]
			public AssetReferenceMaterial materialAssetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4003740")]
			public AssetReferenceTexture socksAssetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4003741")]
			public AssetReferenceTexture socksGlossAssetReference;
		}

		[Cpp2IlInjected.Token(Token = "0x20009FC")]
		public delegate void AnimControllerTypeChanged(AnimControllerType animControllerType);

		[Cpp2IlInjected.Token(Token = "0x20009FD")]
		public struct LoadingScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003742")]
			private AvatarAppearance owner;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003743")]
			public CancellationToken token;

			[Cpp2IlInjected.Token(Token = "0x6002F0E")]
			[Cpp2IlInjected.Address(RVA = "0x1BC7D70", Offset = "0x1BC6770", VA = "0x181BC7D70")]
			public unsafe LoadingScope(AvatarAppearance avatarAppearance)
			{
				//Discarded unreachable code: IL_0019
				owner = avatarAppearance;
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
				{
				}
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
				CancellationToken cancellationToken = default(CancellationToken);
				token = cancellationToken;
			}

			[Cpp2IlInjected.Token(Token = "0x6002F0F")]
			[Cpp2IlInjected.Address(RVA = "0x1BC7CF0", Offset = "0x1BC66F0", VA = "0x181BC7CF0", Slot = "4")]
			public unsafe void Dispose()
			{
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
				{
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20009FE")]
		private struct SavedAnimationScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003744")]
			private AnimatorStateInfo animatorState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4003745")]
			private AnimatorStateInfo animatorStateNext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4003746")]
			private AnimatorTransitionInfo animatorTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4003747")]
			private Animator animator;

			[Cpp2IlInjected.Token(Token = "0x6002F10")]
			[Cpp2IlInjected.Address(RVA = "0x1BC8030", Offset = "0x1BC6A30", VA = "0x181BC8030")]
			public unsafe SavedAnimationScope(Animator animator)
			{
				//Discarded unreachable code: IL_0056
				//IL_0025: Expected native int or pointer, but got O
				//IL_003a: Expected native int or pointer, but got O
				//IL_0050: Expected native int or pointer, but got O
				this.animator = animator;
				AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
				int loop = animatorStateInfo.m_Loop;
				float length = animatorStateInfo.m_Length;
				AnimatorStateInfo animatorStateInfo2 = default(AnimatorStateInfo);
				float length2 = animatorStateInfo2.m_Length;
				((AnimatorStateInfo*)(IntPtr)animatorStateNext)->m_Length = length2;
				int loop2 = animatorStateInfo2.m_Loop;
				((AnimatorStateInfo*)(IntPtr)animatorStateNext)->m_Loop = loop2;
				AnimatorTransitionInfo animatorTransitionInfo = default(AnimatorTransitionInfo);
				float duration = animatorTransitionInfo.m_Duration;
				((AnimatorTransitionInfo*)(IntPtr)animatorTransition)->m_Duration = duration;
			}

			[Cpp2IlInjected.Token(Token = "0x6002F11")]
			[Cpp2IlInjected.Address(RVA = "0x1BC7F50", Offset = "0x1BC6950", VA = "0x181BC7F50", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_0023
				//IL_001a: Expected F4, but got I4
				Animator animator = this.animator;
				Animator animator2 = this.animator;
				int num = 0;
				int num2 = 0;
				animator2.Update(num);
				Animator animator3 = this.animator;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40036D4")]
		public DecalRenderingTool decalRenderingTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40036D5")]
		public List<ClothingItemType> allowDecals = (List<ClothingItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40036D6")]
		public List<(ClothingItemType type, RenderTexture texture)> decalTextures = (List<(ClothingItemType type, RenderTexture texture)>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40036D7")]
		private Dictionary<MakeupItemType, LoadedMakeup> _loadedMakeup = (Dictionary<MakeupItemType, LoadedMakeup>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40036D8")]
		private Texture2D _makeupTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40036D9")]
		private Texture2D _makeupGlossTexture;

		[Cpp2IlInjected.Token(Token = "0x40036DA")]
		private static MakeupItemType[] makeupOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40036DC")]
		public AssetReference femaleBodyMeshReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40036DD")]
		public AssetReference maleBodyMeshReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40036DE")]
		public AssetReference femaleHeadMeshReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40036DF")]
		public AssetReference maleHeadMeshReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40036E0")]
		public AssetReferenceT<AnimatorOverrideController> femaleNavigationController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40036E1")]
		public AssetReferenceT<AnimatorOverrideController> maleNavigationController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40036E2")]
		public AssetReferenceT<AnimatorOverrideController> femaleGownNavigationController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40036E3")]
		public AssetReferenceT<AnimatorOverrideController> maleGownNavigationController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40036E4")]
		public AssetReferenceT<RuntimeAnimatorController> femaleCustomizationController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40036E5")]
		public AssetReferenceT<RuntimeAnimatorController> maleCustomizationController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40036E6")]
		private AssetReference loadedController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40036E7")]
		private readonly List<AssetReference> previouslyLoadedControllers = (List<AssetReference>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40036E8")]
		private CancellationTokenSource loadedControllerCTS = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40036E9")]
		public OrbitCameraTarget orbitCameraTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40036EA")]
		public OrbitCameraTarget selfieCameraTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40036EB")]
		public OrbitCameraTarget unlockSelfieCameraTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40036EC")]
		public float maleHeadYOffset = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40036ED")]
		public Transform rootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40036EE")]
		public AvatarHeadSkinnedMesh head;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40036EF")]
		public SkinnedMeshRenderer combinedHead;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40036F0")]
		public SkinnedMeshRenderer combinedBody;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40036F1")]
		public Material faceNormalBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40036F2")]
		public Material bakeMakeup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40036F3")]
		public Material eyeMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40036F4")]
		public Material maleEyeMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40036F5")]
		public Material eyelashMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40036F6")]
		public Material teethMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40036F7")]
		public Camera femalePortraitCam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40036F8")]
		public Camera malePortraitCam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40036F9")]
		[HideInInspector]
		public OrbitCameraTarget[] decalTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40036FA")]
		[HideInInspector]
		public OrbitCameraTarget[] maleDecalTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40036FB")]
		public List<BodyType> femaleBodyTypes = (List<BodyType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40036FC")]
		public List<BodyType> maleBodyTypes = (List<BodyType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40036FD")]
		public AvatarHeadConfig headConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40036FE")]
		public AvatarSkinConfig skinConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40036FF")]
		public AvatarHairColorConfig hairColorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003700")]
		public AvatarEyeColorConfig eyeColorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003701")]
		public AvatarMakeupColorConfig makeupColorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4003702")]
		[HideInInspector]
		public AvatarFaceConfig[] faceOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4003706")]
		private MaterialPropertyBlock headMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4003707")]
		private MaterialPropertyBlock bodyMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4003708")]
		private AvatarWorkingCopy _femaleAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4003709")]
		private AvatarWorkingCopy _maleAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400370A")]
		private Material faceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400370B")]
		private Material bodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400370C")]
		private RenderTexture normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400370E")]
		private HashSet<ClothingItemType> _hiddenClothing = (HashSet<ClothingItemType>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400370F")]
		private List<AssetReference> toCleanup = (List<AssetReference>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4003710")]
		private Dictionary<ClothingItemType, LoadedClothes> _loadedClothes = (Dictionary<ClothingItemType, LoadedClothes>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4003711")]
		private SkinnedMeshRenderer _BodySkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4003712")]
		private bool isLoading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4003713")]
		private CancellationTokenSource _loadingCtSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4003714")]
		private Toolbox _toolbox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4003715")]
		private byte[] avatarTransferByteData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4003716")]
		private AvatarTransferData avatarTransferData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4003717")]
		private Dictionary<ClothingItemType, Item> avatarTransferOriginalClothes;

		[Cpp2IlInjected.Token(Token = "0x4003719")]
		public static ClothingItemType[] notCombined;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400371A")]
		private bool _isInSelfieMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x400371B")]
		private int _SmileSmallHash = Animator.StringToHash("smile_small");

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400371C")]
		private int _SmileMediumHash = Animator.StringToHash("smile_medium");

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x400371D")]
		private int _SmileLargeHash = Animator.StringToHash("smile_big");

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400371E")]
		private int _WinkLeftHash = Animator.StringToHash("wink_left");

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x400371F")]
		private int _WinkRightHash = Animator.StringToHash("wink_right");

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4003720")]
		private int _SmileSmallIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4003721")]
		private int _SmileMediumIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4003722")]
		private int _SmileLargeIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4003723")]
		private int _WinkLeftIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4003724")]
		private int _WinkRightIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4003725")]
		private AsyncOperationHandle<GameObject> headHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4003726")]
		private AsyncOperationHandle<GameObject> bodyHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4003727")]
		private AsyncOperationHandle<Material> faceMaterialHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4003728")]
		private AsyncOperationHandle<Material> bodyMaterialHandle;

		[Cpp2IlInjected.Token(Token = "0x4003729")]
		private static readonly ClothingItemType[] hairTypes;

		[Cpp2IlInjected.Token(Token = "0x170006A3")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB0")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CAnimator_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EB1")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CAnimator_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A4")]
		public Camera PortraitCam
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB2")]
			[Cpp2IlInjected.Address(RVA = "0x15157A0", Offset = "0x15141A0", VA = "0x1815157A0")]
			get
			{
				if (IsMale)
				{
					return malePortraitCam;
				}
				return femalePortraitCam;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A5")]
		public Dictionary<string, Transform> SkeletonDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB3")]
			[Cpp2IlInjected.Address(RVA = "0x976350", Offset = "0x974D50", VA = "0x180976350")]
			[CompilerGenerated]
			get
			{
				return _003CSkeletonDefinition_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EB4")]
			[Cpp2IlInjected.Address(RVA = "0xE2EB70", Offset = "0xE2D570", VA = "0x180E2EB70")]
			[CompilerGenerated]
			private set
			{
				_003CSkeletonDefinition_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<string, Transform>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x170006A6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x190"), Cpp2IlInjected.Token(Token = "0x4003704")]
		public bool IsMale
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB5")]
			[Cpp2IlInjected.Address(RVA = "0xF2CB80", Offset = "0xF2B580", VA = "0x180F2CB80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002EB6")]
			[Cpp2IlInjected.Address(RVA = "0xF2CC50", Offset = "0xF2B650", VA = "0x180F2CC50")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006A7")]
		public AvatarWorkingCopy CurrentAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB9")]
			[Cpp2IlInjected.Address(RVA = "0x1515760", Offset = "0x1514160", VA = "0x181515760")]
			get
			{
				if (IsMale)
				{
					return _maleAvatar;
				}
				return _femaleAvatar;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A8")]
		public Profile CurrentProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBA")]
			[Cpp2IlInjected.Address(RVA = "0x129F690", Offset = "0x129E090", VA = "0x18129F690")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002EBB")]
			[Cpp2IlInjected.Address(RVA = "0xA76740", Offset = "0xA75140", VA = "0x180A76740")]
			[CompilerGenerated]
			private set
			{
				_003CCurrentProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A9")]
		public bool IsLoading
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBC")]
			[Cpp2IlInjected.Address(RVA = "0x1515790", Offset = "0x1514190", VA = "0x181515790")]
			get
			{
				return isLoading;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006AA")]
		public bool HasPendingAvatarTransfer
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBD")]
			[Cpp2IlInjected.Address(RVA = "0x1515780", Offset = "0x1514180", VA = "0x181515780")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000073")]
		public event AvatarChanged OnAvatarChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6002EB7")]
			[Cpp2IlInjected.Address(RVA = "0x15156C0", Offset = "0x15140C0", VA = "0x1815156C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002EB8")]
			[Cpp2IlInjected.Address(RVA = "0x1515860", Offset = "0x1514260", VA = "0x181515860")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000074")]
		public event AnimControllerTypeChanged AnimControllerTypeChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002EBE")]
			[Cpp2IlInjected.Address(RVA = "0x1515620", Offset = "0x1514020", VA = "0x181515620")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002EBF")]
			[Cpp2IlInjected.Address(RVA = "0x15157C0", Offset = "0x15141C0", VA = "0x1815157C0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E95")]
		[Cpp2IlInjected.Address(RVA = "0x150F330", Offset = "0x150DD30", VA = "0x18150F330")]
		public bool IsCustomizable(ClothingItemType clothingType, bool force)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar = _femaleAvatar;
			ClothingItemData clothingItemData = default(ClothingItemData);
			if (clothingItemData != null)
			{
				if (IsMale)
				{
				}
				AvatarWorkingCopy femaleAvatar2 = _femaleAvatar;
				bool flag = default(bool);
				if (flag)
				{
					return true;
				}
			}
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			ClothingItemData clothingItemData2 = default(ClothingItemData);
			if (clothingItemData2 == null || clothingItemData2 != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E96")]
		[Cpp2IlInjected.Address(RVA = "0x150C740", Offset = "0x150B140", VA = "0x18150C740")]
		public bool CanEditColor(ClothingItemType clothingType, bool force)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar = _femaleAvatar;
			ClothingItemData clothingItemData = default(ClothingItemData);
			if (clothingItemData == null)
			{
				int num = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E97")]
		[Cpp2IlInjected.Address(RVA = "0x150C890", Offset = "0x150B290", VA = "0x18150C890")]
		public bool CanEditDecals(ClothingItemType clothingType, bool force)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar = _femaleAvatar;
			ClothingItemData clothingItemData = default(ClothingItemData);
			if (clothingItemData != null)
			{
				if (IsMale)
				{
				}
				AvatarWorkingCopy femaleAvatar2 = _femaleAvatar;
				bool flag = default(bool);
				if (flag)
				{
					List<ClothingItemType> list = allowDecals;
					bool result = default(bool);
					return result;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E98")]
		[Cpp2IlInjected.Address(RVA = "0x150EF30", Offset = "0x150D930", VA = "0x18150EF30")]
		public MapField<int, DesignMap> GetDesignMaps()
		{
			//Discarded unreachable code: IL_003a
			AvatarTransferData avatarTransferData = this.avatarTransferData;
			if (avatarTransferData == null)
			{
				ProfilePlayer player_ = CurrentProfile.player_;
				bool flag = IsMale;
				return (MapField<int, DesignMap>)(object)player_.GetDesignMaps(flag);
			}
			if (IsMale)
			{
				return avatarTransferData.maleClothingDesigns_;
			}
			MapField<int, DesignMap> result = default(MapField<int, DesignMap>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E99")]
		[Cpp2IlInjected.Address(RVA = "0x150DE40", Offset = "0x150C840", VA = "0x18150DE40")]
		public List<KeyValuePair<int, Design>> GetAllDesigns(Item item)
		{
			//Discarded unreachable code: IL_0046
			AvatarTransferData avatarTransferData = this.avatarTransferData;
			if (avatarTransferData == null)
			{
				ProfilePlayer player_ = CurrentProfile.player_;
				bool flag = IsMale;
				MapField<int, DesignMap> designMaps = (MapField<int, DesignMap>)(object)player_.GetDesignMaps(flag);
			}
			if (IsMale)
			{
			}
			MapField<int, DesignMap> femaleClothingDesigns_ = avatarTransferData.femaleClothingDesigns_;
			bool flag2 = default(bool);
			if (!flag2)
			{
				return (List<KeyValuePair<int, Design>>)(object)new List<T>();
			}
			List<KeyValuePair<int, Design>> result = default(List<KeyValuePair<int, Design>>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9A")]
		[Cpp2IlInjected.Address(RVA = "0x150E6C0", Offset = "0x150D0C0", VA = "0x18150E6C0")]
		public unsafe IDesign GetCurrentDesign(ClothingItemType type)
		{
			//IL_006a: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			int num = 0;
			if ((IsMale ? 1 : 0) != num)
			{
			}
			AvatarWorkingCopy femaleAvatar = _femaleAvatar;
			Item item = default(Item);
			int itemID = item.ItemID;
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar2 = _femaleAvatar;
			int num2 = default(int);
			if (num2 != -1)
			{
				MapField<int, DesignMap> designMaps = default(MapField<int, DesignMap>);
				if (avatarTransferData == null)
				{
					ProfilePlayer player_ = CurrentProfile.player_;
					bool flag = IsMale;
					designMaps = (MapField<int, DesignMap>)(object)player_.GetDesignMaps(flag);
				}
				if (IsMale)
				{
				}
				if (((MapField<TKey, TValue>)(object)designMaps).TryGetValue((TKey)itemID, out *(TValue*)num))
				{
					itemID = num2;
					if (!((MapField<TKey, TValue>)(object)designMaps).TryGetValue((TKey)itemID, out *(TValue*)num))
					{
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9B")]
		[Cpp2IlInjected.Address(RVA = "0x150EBD0", Offset = "0x150D5D0", VA = "0x18150EBD0")]
		public RenderTexture GetDecalTexture(ClothingItemType type)
		{
			//Discarded unreachable code: IL_00c6
			//IL_0056: Expected I4, but got I8
			//IL_005f: Expected I4, but got I8
			//IL_00a6: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			List<(ClothingItemType, RenderTexture)> list = decalTextures;
			Predicate<(ClothingItemType, RenderTexture)> predicate = (Predicate<(ClothingItemType, RenderTexture)>)(object)(Predicate<T>)delegate
			{
				ClothingItemType clothingItemType3 = type;
				bool result = default(bool);
				return result;
			};
			int num = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
			uint num2 = default(uint);
			int format = default(int);
			int depth = default(int);
			RenderTexture renderTexture = new RenderTexture((int)num2, (int)num2, depth, (RenderTextureFormat)format);
			format = 0;
			depth = 0;
			renderTexture.name = "DecalTexture";
			ulong num3 = default(ulong);
			renderTexture.useMipMap = (byte)num3 != 0;
			ulong num4 = default(ulong);
			renderTexture.autoGenerateMips = (byte)num4 != 0;
			renderTexture.wrapMode = TextureWrapMode.Clamp;
			bool flag = renderTexture.Create();
			List<(ClothingItemType, RenderTexture)> list2 = decalTextures;
			if (num != -1)
			{
				int num5 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num5 += num5;
				ClothingItemType clothingItemType = type;
				int num6 = 0;
				((List<T>)(object)decalTextures)[num] = (T)num6;
			}
			ClothingItemType clothingItemType2 = type;
			int num7 = 0;
			((List<T>)(object)list2).Add((T)num7);
			bool flag2 = renderTexture.Create();
			return renderTexture;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9C")]
		[Cpp2IlInjected.Address(RVA = "0x1510960", Offset = "0x150F360", VA = "0x181510960")]
		public void ReleaseDecalTexture(ClothingItemType type)
		{
			//Discarded unreachable code: IL_0056
			List<(ClothingItemType, RenderTexture)> list = decalTextures;
			Predicate<(ClothingItemType, RenderTexture)> predicate = (Predicate<(ClothingItemType, RenderTexture)>)(object)(Predicate<T>)delegate
			{
				ClothingItemType clothingItemType = type;
				bool result = default(bool);
				return result;
			};
			int num = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
			if (num != -1)
			{
				List<(ClothingItemType, RenderTexture)> list2 = decalTextures;
				int num2 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num2 += num2;
				((List<T>)(object)decalTextures).RemoveAt(num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9D")]
		[Cpp2IlInjected.Address(RVA = "0x150E4E0", Offset = "0x150CEE0", VA = "0x18150E4E0")]
		public unsafe DesignWorkingCopy GetCurrentDesignWorkingCopy(ClothingItemType type)
		{
			//Discarded unreachable code: IL_008d
			//IL_006a: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			int num = 0;
			if ((IsMale ? 1 : 0) != num)
			{
			}
			AvatarWorkingCopy femaleAvatar = _femaleAvatar;
			Item item = default(Item);
			int itemID = item.ItemID;
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar2 = _femaleAvatar;
			int num2 = default(int);
			if (num2 != -1)
			{
				MapField<int, DesignMap> designMaps = default(MapField<int, DesignMap>);
				if (avatarTransferData == null)
				{
					ProfilePlayer player_ = CurrentProfile.player_;
					bool flag = IsMale;
					designMaps = (MapField<int, DesignMap>)(object)player_.GetDesignMaps(flag);
				}
				if (IsMale)
				{
				}
				if (((MapField<TKey, TValue>)(object)designMaps).TryGetValue((TKey)itemID, out *(TValue*)num))
				{
					itemID = num2;
					if (((MapField<TKey, TValue>)(object)designMaps).TryGetValue((TKey)itemID, out *(TValue*)num) && num != 0)
					{
						return new DesignWorkingCopy((IDesign)num);
					}
				}
			}
			return new DesignWorkingCopy();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9E")]
		[Cpp2IlInjected.Address(RVA = "0x150BDD0", Offset = "0x150A7D0", VA = "0x18150BDD0")]
		[AsyncStateMachine(typeof(_003CApplyBaseColor_003Ed__12))]
		public Task ApplyBaseColor(ClothingItemType clothingType, Color color)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E9F")]
		[Cpp2IlInjected.Address(RVA = "0x1513A30", Offset = "0x1512430", VA = "0x181513A30")]
		[AsyncStateMachine(typeof(_003CUpdateDesigns_003Ed__13))]
		public Task UpdateDesigns()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA0")]
		[Cpp2IlInjected.Address(RVA = "0x1513930", Offset = "0x1512330", VA = "0x181513930")]
		[AsyncStateMachine(typeof(_003CUpdateDesign_003Ed__14))]
		private Task UpdateDesign(ClothingItemType type)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA1")]
		[Cpp2IlInjected.Address(RVA = "0x1511200", Offset = "0x150FC00", VA = "0x181511200")]
		[AsyncStateMachine(typeof(_003CSaveClothingDesign_003Ed__15))]
		public Task<SaveClothingDesign.Types.Response> SaveClothingDesign(Item item, DesignWorkingCopy Design, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SaveClothingDesign.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA2")]
		[Cpp2IlInjected.Address(RVA = "0x150DAE0", Offset = "0x150C4E0", VA = "0x18150DAE0")]
		[AsyncStateMachine(typeof(_003CDeleteClothingDesign_003Ed__16))]
		public Task<DeleteClothingDesign.Types.Response> DeleteClothingDesign(Item item, int designId, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<DeleteClothingDesign.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA3")]
		[Cpp2IlInjected.Address(RVA = "0x150F980", Offset = "0x150E380", VA = "0x18150F980")]
		public bool IsWearing(MakeupItem makeupItem)
		{
			//Discarded unreachable code: IL_0012
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar = _femaleAvatar;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA4")]
		[Cpp2IlInjected.Address(RVA = "0x1510F60", Offset = "0x150F960", VA = "0x181510F60")]
		public bool RemoveMakeup(MakeupItemType makeupType, bool loadCurrent = true)
		{
			//Discarded unreachable code: IL_0037
			int num = 0;
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar = _femaleAvatar;
			bool flag = default(bool);
			if (loadCurrent != flag)
			{
				Dictionary<MakeupItemType, LoadedMakeup> loadedMakeup = _loadedMakeup;
				bool flag2 = default(bool);
				if (flag2)
				{
					bool flag3 = default(bool);
					if (flag3)
					{
					}
					Dictionary<MakeupItemType, LoadedMakeup> loadedMakeup2 = _loadedMakeup;
				}
				UpdateMakeup();
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA5")]
		[Cpp2IlInjected.Address(RVA = "0x1511600", Offset = "0x1510000", VA = "0x181511600")]
		[AsyncStateMachine(typeof(_003CSelectMakeup_003Ed__24))]
		public Task<bool> SelectMakeup(MakeupItem makeupItem, bool loadCurrent = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA6")]
		[Cpp2IlInjected.Address(RVA = "0x15120F0", Offset = "0x1510AF0", VA = "0x1815120F0")]
		public bool SetMakeupColor1(MakeupItemType type, int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA7")]
		[Cpp2IlInjected.Address(RVA = "0x1512260", Offset = "0x1510C60", VA = "0x181512260")]
		public bool SetMakeupColor2(MakeupItemType type, int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA8")]
		[Cpp2IlInjected.Address(RVA = "0x15123D0", Offset = "0x1510DD0", VA = "0x1815123D0")]
		public bool SetMakeupColor3(MakeupItemType type, int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EA9")]
		[Cpp2IlInjected.Address(RVA = "0x1512540", Offset = "0x1510F40", VA = "0x181512540")]
		public bool SetMakeupOpacity(MakeupItemType type, float opacity)
		{
			int num = 0;
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar = _femaleAvatar;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAA")]
		[Cpp2IlInjected.Address(RVA = "0x1510190", Offset = "0x150EB90", VA = "0x181510190")]
		[AsyncStateMachine(typeof(_003CLoadMakeup_003Ed__29))]
		public Task LoadMakeup(CancellationToken cancellationToken)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAB")]
		[Cpp2IlInjected.Address(RVA = "0x15141D0", Offset = "0x1512BD0", VA = "0x1815141D0")]
		private unsafe void UpdateMakeup()
		{
			//IL_008b: Expected O, but got I4
			//IL_00fb: Expected O, but got I4
			//IL_015f: Expected O, but got I4
			//IL_0174: Expected O, but got I4
			//IL_0188: Expected O, but got I4
			//IL_01a0: Expected O, but got I4
			RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier2 = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier3 = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier4 = default(RenderTargetIdentifier);
			int num4;
			RenderTargetIdentifier renderTargetIdentifier5 = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier6 = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier7 = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier8 = default(RenderTargetIdentifier);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				num4 = 0;
				if (((Dictionary<TKey, TValue>)(object)_loadedMakeup).Count != 0)
				{
					int num5 = Shader.PropertyToID("MakeupTex");
					int num6 = Shader.PropertyToID("GlossTex");
					AcquireMakeupTextures();
					int num7 = 0;
					CommandBuffer buffer = CommandBufferPool.Get();
					IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
					IntPtr bufferPointer2 = renderTargetIdentifier2.m_BufferPointer;
					List<Material> list = (List<Material>)(object)new List<T>();
					MakeupItemType[] array = makeupOrder;
					int length = array.Length;
					if (num4 < length)
					{
						Dictionary<MakeupItemType, LoadedMakeup> loadedMakeup = _loadedMakeup;
						MakeupItemType makeupItemType = array[num4];
						if (((Dictionary<TKey, TValue>)(object)loadedMakeup).TryGetValue((TKey)makeupItemType, out *(TValue*)num))
						{
							int num8 = 0;
							if (Application.isPlaying)
							{
							}
							Material item = new Material(bakeMakeup);
							((List<T>)(object)list).Add((T)item);
							IntPtr bufferPointer3 = renderTargetIdentifier3.m_BufferPointer;
							IntPtr bufferPointer4 = renderTargetIdentifier4.m_BufferPointer;
						}
						num4++;
					}
					IntPtr bufferPointer5 = renderTargetIdentifier5.m_BufferPointer;
					IntPtr bufferPointer6 = renderTargetIdentifier6.m_BufferPointer;
					IntPtr bufferPointer7 = renderTargetIdentifier7.m_BufferPointer;
					IntPtr bufferPointer8 = renderTargetIdentifier8.m_BufferPointer;
					Graphics.ExecuteCommandBuffer(buffer);
					if (flag)
					{
						UnityEngine.Object.Destroy((UnityEngine.Object)num3);
					}
					if (num5 == 0)
					{
						return;
					}
				}
				else
				{
					MaterialPropertyBlock materialPropertyBlock = (headMPB = new MaterialPropertyBlock());
					int num9 = 0;
					Texture2D blackTexture = Texture2D.blackTexture;
					materialPropertyBlock.SetTexture("_MakeupTex", blackTexture);
					int num10 = 0;
					Texture2D blackTexture2 = Texture2D.blackTexture;
					materialPropertyBlock.SetTexture("_MakeupGlossTex", blackTexture2);
					SkinnedMeshRenderer skinnedMeshRenderer = combinedHead;
					Texture2D makeupTexture = _makeupTexture;
					int num11 = 0;
					if (makeupTexture != (UnityEngine.Object)num11)
					{
						UnityEngine.Object.Destroy(_makeupTexture);
						_makeupTexture = (Texture2D)num4;
					}
					Texture2D makeupGlossTexture = _makeupGlossTexture;
					int num12 = 0;
					if (makeupGlossTexture != (UnityEngine.Object)num12)
					{
						break;
					}
				}
			}
			UnityEngine.Object.Destroy(_makeupGlossTexture);
			_makeupGlossTexture = (Texture2D)num4;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAC")]
		[Cpp2IlInjected.Address(RVA = "0x150BBA0", Offset = "0x150A5A0", VA = "0x18150BBA0")]
		private void AcquireMakeupTextures()
		{
			//IL_0010: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			Texture2D makeupTexture = _makeupTexture;
			int num = 0;
			if (!(makeupTexture == (UnityEngine.Object)num))
			{
				Texture2D makeupTexture2 = _makeupTexture;
				int hasMipMap = 0;
				bool flag = makeupTexture2.Resize(1024, 1024, GraphicsFormat.R8G8B8A8_SRGB, (byte)hasMipMap != 0);
				_makeupTexture.Apply();
			}
			int flags = default(int);
			Texture2D texture2D = new Texture2D(1024, 1024, GraphicsFormat.R8G8B8A8_SRGB, (TextureCreationFlags)flags);
			flags = 0;
			texture2D.name = "MakeupTexture";
			texture2D.wrapMode = TextureWrapMode.Clamp;
			_makeupTexture = texture2D;
			Texture2D makeupGlossTexture = _makeupGlossTexture;
			int num2 = 0;
			bool flag2 = makeupGlossTexture == (UnityEngine.Object)num2;
			if (!flag2)
			{
				bool flag3 = _makeupGlossTexture.Resize(1024, 1024, GraphicsFormat.R8_UNorm, flag2);
				_makeupGlossTexture.Apply();
				return;
			}
			Texture2D texture2D2 = default(Texture2D);
			texture2D2.name = "MakeupGlossTexture";
			texture2D2.wrapMode = TextureWrapMode.Clamp;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAD")]
		[Cpp2IlInjected.Address(RVA = "0x150D540", Offset = "0x150BF40", VA = "0x18150D540")]
		private void CompressMakeup()
		{
			//Discarded unreachable code: IL_0105
			//IL_005b: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			int num = 0;
			Texture2D makeupTexture = _makeupTexture;
			int num2 = 0;
			if ((object)makeupTexture != null && makeupTexture.graphicsFormat == GraphicsFormat.R8G8B8A8_SRGB)
			{
				int depthBuffer = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(1024, 1024, depthBuffer, GraphicsFormat.R8G8B8A8_SRGB);
				Graphics.Blit(_makeupTexture, temporary);
				Texture2D makeupTexture2 = _makeupTexture;
				int num3 = 0;
				int destY = 0;
				int destX = 0;
				makeupTexture2.ReadPixels((Rect)num3, destX, destY);
				Texture2D makeupTexture3 = _makeupTexture;
				int highQuality = 0;
				makeupTexture3.Compress((byte)highQuality != 0);
				_makeupTexture.Apply();
				RenderTexture.ReleaseTemporary(temporary);
			}
			Texture2D makeupGlossTexture = _makeupGlossTexture;
			if ((object)makeupGlossTexture != null && makeupGlossTexture.graphicsFormat == GraphicsFormat.R8_UNorm)
			{
				int depthBuffer2 = 0;
				RenderTexture temporary2 = RenderTexture.GetTemporary(1024, 1024, depthBuffer2, GraphicsFormat.R8_UNorm);
				Graphics.Blit(_makeupGlossTexture, temporary2);
				Texture2D makeupGlossTexture2 = _makeupGlossTexture;
				int num4 = 0;
				int destY2 = 0;
				int destX2 = 0;
				makeupGlossTexture2.ReadPixels((Rect)num4, destX2, destY2);
				Texture2D makeupGlossTexture3 = _makeupGlossTexture;
				int highQuality2 = 0;
				makeupGlossTexture3.Compress((byte)highQuality2 != 0);
				_makeupGlossTexture.Apply();
				RenderTexture.ReleaseTemporary(temporary2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAE")]
		[Cpp2IlInjected.Address(RVA = "0x1510AC0", Offset = "0x150F4C0", VA = "0x181510AC0")]
		private void ReleaseMakeupTexture()
		{
			//IL_0010: Expected O, but got I4
			//IL_0027: Expected O, but got I8
			//IL_0037: Expected O, but got I4
			Texture2D makeupTexture = _makeupTexture;
			int num = 0;
			if (makeupTexture != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(_makeupTexture);
				_makeupTexture = (Texture2D)0;
			}
			Texture2D makeupGlossTexture = _makeupGlossTexture;
			int num2 = 0;
			if (makeupGlossTexture != (UnityEngine.Object)num2)
			{
				UnityEngine.Object.Destroy(makeupGlossTexture);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EAF")]
		[Cpp2IlInjected.Address(RVA = "0x150DC40", Offset = "0x150C640", VA = "0x18150DC40")]
		private void DisableMakeup()
		{
			//Discarded unreachable code: IL_0027
			MaterialPropertyBlock materialPropertyBlock = (headMPB = new MaterialPropertyBlock());
			int num = 0;
			Texture2D blackTexture = Texture2D.blackTexture;
			int num2 = 0;
			Texture2D blackTexture2 = Texture2D.blackTexture;
			SkinnedMeshRenderer skinnedMeshRenderer = combinedHead;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC0")]
		[Cpp2IlInjected.Address(RVA = "0x150C3F0", Offset = "0x150ADF0", VA = "0x18150C3F0")]
		private void Awake()
		{
			Animator animator = (Animator = GetComponent<Animator>());
			Toolbox toolbox = (_toolbox = GetComponent<Toolbox>());
			Transform[] componentsInChildren = rootBone.GetComponentsInChildren<Transform>();
			int num = LayerMask.NameToLayer("VFX");
			int num2 = 0;
			int num3 = 0;
			int length = componentsInChildren.Length;
			if (num2 < length)
			{
				Transform transform = componentsInChildren[num3];
				if (transform.gameObject.layer != num)
				{
					Dictionary<string, Transform> dictionary = SkeletonDefinition;
					string text = transform.name;
					throw new NullReferenceException();
				}
				num3++;
			}
			MaterialPropertyBlock materialPropertyBlock = (headMPB = new MaterialPropertyBlock());
			MaterialPropertyBlock materialPropertyBlock2 = (bodyMPB = new MaterialPropertyBlock());
			RenderTexture renderTexture = default(RenderTexture);
			normal = renderTexture;
			normal.name = "_AvatarNormalTex";
			int isMale = default(int);
			AvatarWorkingCopy femaleAvatar = new AvatarWorkingCopy(AvatarRules.Instance.DefaultFemale, (byte)isMale != 0);
			isMale = 0;
			_femaleAvatar = femaleAvatar;
			AvatarWorkingCopy avatarWorkingCopy = (_maleAvatar = new AvatarWorkingCopy(AvatarRules.Instance.DefaultMale, isMale: true));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC1")]
		[Cpp2IlInjected.Address(RVA = "0x1514D00", Offset = "0x1513700", VA = "0x181514D00")]
		private void Update()
		{
			//Discarded unreachable code: IL_0119
			int smileSmallIndex = _SmileSmallIndex;
			SkinnedMeshRenderer skinnedMeshRenderer = combinedHead;
			Animator animator = Animator;
			int smileSmallHash = _SmileSmallHash;
			float @float = animator.GetFloat(smileSmallHash);
			smileSmallHash = smileSmallIndex;
			skinnedMeshRenderer.SetBlendShapeWeight(smileSmallHash, @float);
			int smileMediumIndex = _SmileMediumIndex;
			Animator animator2 = Animator;
			SkinnedMeshRenderer skinnedMeshRenderer2 = combinedHead;
			int smileMediumHash = _SmileMediumHash;
			@float = animator2.GetFloat(smileMediumHash);
			smileMediumHash = smileMediumIndex;
			skinnedMeshRenderer2.SetBlendShapeWeight(smileMediumHash, @float);
			int smileLargeIndex = _SmileLargeIndex;
			Animator animator3 = Animator;
			SkinnedMeshRenderer skinnedMeshRenderer3 = combinedHead;
			int smileLargeHash = _SmileLargeHash;
			@float = animator3.GetFloat(smileLargeHash);
			smileLargeHash = smileLargeIndex;
			skinnedMeshRenderer3.SetBlendShapeWeight(smileLargeHash, @float);
			int winkLeftIndex = _WinkLeftIndex;
			Animator animator4 = Animator;
			SkinnedMeshRenderer skinnedMeshRenderer4 = combinedHead;
			int winkLeftHash = _WinkLeftHash;
			@float = animator4.GetFloat(winkLeftHash);
			winkLeftHash = winkLeftIndex;
			skinnedMeshRenderer4.SetBlendShapeWeight(winkLeftHash, @float);
			int winkRightIndex = _WinkRightIndex;
			Animator animator5 = Animator;
			SkinnedMeshRenderer skinnedMeshRenderer5 = combinedHead;
			int winkRightHash = _WinkRightHash;
			@float = animator5.GetFloat(winkRightHash);
			winkRightHash = winkRightIndex;
			skinnedMeshRenderer5.SetBlendShapeWeight(winkRightHash, @float);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC2")]
		[Cpp2IlInjected.Address(RVA = "0x15102A0", Offset = "0x150ECA0", VA = "0x1815102A0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0045
			int num = 0;
			int num2 = 0;
			RenderTexture.ReleaseTemporary(normal);
			bool flag = default(bool);
			if (flag)
			{
				Addressables.Release<GameObject>((AsyncOperationHandle<>)bodyHandle);
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				Addressables.Release<GameObject>((AsyncOperationHandle<>)headHandle);
			}
			Dictionary<ClothingItemType, LoadedClothes>.ValueCollection values = (Dictionary<ClothingItemType, LoadedClothes>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)_loadedClothes).get_Values();
			bool flag3 = default(bool);
			if (flag3)
			{
			}
			bool flag4 = default(bool);
			if (!flag4)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC3")]
		[Cpp2IlInjected.Address(RVA = "0x150E030", Offset = "0x150CA30", VA = "0x18150E030")]
		public AnimControllerType GetAnimControllerType()
		{
			AssetReference assetReference = loadedController;
			if (!IsMale)
			{
				if (assetReference == femaleCustomizationController)
				{
					return AnimControllerType.Customization;
				}
			}
			else if (assetReference == maleCustomizationController)
			{
				return AnimControllerType.Customization;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC4")]
		[Cpp2IlInjected.Address(RVA = "0x1511750", Offset = "0x1510150", VA = "0x181511750")]
		public Task SetAnimController(AnimControllerType type)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC5")]
		[Cpp2IlInjected.Address(RVA = "0x1511860", Offset = "0x1510260", VA = "0x181511860")]
		[AsyncStateMachine(typeof(_003CSetAnimController_003Ed__143))]
		private Task SetAnimController(AnimControllerType type, bool unloadPrevious)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC6")]
		[Cpp2IlInjected.Address(RVA = "0x15128D0", Offset = "0x15112D0", VA = "0x1815128D0")]
		internal void UnloadAfterCloseAvatarCustomization()
		{
			//Discarded unreachable code: IL_0018, IL_001e
			int num = 0;
			List<AssetReference> list = previouslyLoadedControllers;
			bool flag = default(bool);
			if (flag)
			{
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC7")]
		[Cpp2IlInjected.Address(RVA = "0x150DF60", Offset = "0x150C960", VA = "0x18150DF60")]
		private AssetReference GetAnimControllerReferenceForType(AnimControllerType type)
		{
			if (type == AnimControllerType.Navigation)
			{
				bool flag = IsWearingGown();
				bool flag2 = IsMale;
				if (!flag)
				{
					if (flag2)
					{
						AssetReferenceT<AnimatorOverrideController> assetReferenceT = maleNavigationController;
					}
					AssetReferenceT<AnimatorOverrideController> assetReferenceT2 = femaleNavigationController;
				}
				if (flag2)
				{
					AssetReferenceT<AnimatorOverrideController> assetReferenceT3 = maleGownNavigationController;
				}
				AssetReferenceT<AnimatorOverrideController> assetReferenceT4 = femaleGownNavigationController;
			}
			if (type == AnimControllerType.Customization)
			{
				if (IsMale)
				{
					AssetReferenceT<RuntimeAnimatorController> assetReferenceT5 = maleCustomizationController;
				}
				AssetReferenceT<RuntimeAnimatorController> assetReferenceT6 = femaleCustomizationController;
			}
			Exception ex = new Exception("Missing case");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC8")]
		[Cpp2IlInjected.Address(RVA = "0x150F2E0", Offset = "0x150DCE0", VA = "0x18150F2E0")]
		public bool IsAnimControllerTypeLoaded()
		{
			//Discarded unreachable code: IL_001e
			bool flag = loadedController.IsValid();
			if (!flag)
			{
				return flag;
			}
			return loadedController.IsDone;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EC9")]
		[Cpp2IlInjected.Address(RVA = "0x1512C80", Offset = "0x1511680", VA = "0x181512C80")]
		public void UpdateAnimLayerWeights()
		{
			//Discarded unreachable code: IL_014b, IL_0151, IL_0157, IL_015d
			//IL_0030: Expected F4, but got I4
			//IL_0058: Expected F4, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_0137: Expected O, but got I4
			//IL_0137: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int layerIndex = Animator.GetLayerIndex("Tools");
			if (layerIndex != -1)
			{
				Animator animator = Animator;
				int num4 = 0;
				animator.SetLayerWeight(layerIndex, num4);
			}
			int num5 = 0;
			bool flag = default(bool);
			if (flag)
			{
				Animator animator2 = Animator;
				Animator animator3 = Animator;
				int num6 = default(int);
				if (num6 != -1)
				{
					animator3.SetLayerWeight(num6, num5);
				}
				RuntimeAnimatorController runtimeAnimatorController = animator3.runtimeAnimatorController;
				GameObject context = Animator.gameObject;
				string message = default(string);
				Debug.LogWarning(message, context);
			}
			Array values = Enum.GetValues(typeof(ClothingItemType));
			if (values != null)
			{
				int num7 = 0;
				if (0L < (long)(IntPtr)values)
				{
					bool flag2 = default(bool);
					if (num7 != 0 && flag2)
					{
						int num8 = 0;
						if ((UnityEngine.Object)num != (UnityEngine.Object)num8)
						{
							int num9 = 0;
							int num10 = 0;
							bool flag3 = default(bool);
							if (flag3)
							{
							}
							num9++;
						}
					}
					num7++;
				}
				int num11 = 0;
				int num12 = default(int);
				if (0 < num12)
				{
					string text = default(string);
					string name = text;
					Predicate<BodyType> predicate = (Predicate<BodyType>)(object)(Predicate<T>)delegate(BodyType b)
					{
						//Discarded unreachable code: IL_0014
						string b3 = name;
						return string.Equals(b.animationLayer, b3);
					};
					Predicate<BodyType> predicate2 = (Predicate<BodyType>)(object)(Predicate<T>)delegate(BodyType b)
					{
						//Discarded unreachable code: IL_0014
						string b2 = name;
						return string.Equals(b.animationLayer, b2);
					};
					BodyType bodyType = default(BodyType);
					if (bodyType != null)
					{
					}
					int num13 = 0;
					int num14 = default(int);
					if (num14 != -1)
					{
						Animator animator4 = Animator;
						int num15 = default(int);
						if (num15 == 0)
						{
						}
						animator4.SetLayerWeight(num11, 1f);
					}
					num11++;
				}
				int num16 = 0;
				Tool tool = default(Tool);
				if ((UnityEngine.Object)num11 != (UnityEngine.Object)num16 && !tool._useToolLayer)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECA")]
		[Cpp2IlInjected.Address(RVA = "0x150F5E0", Offset = "0x150DFE0", VA = "0x18150F5E0")]
		public bool IsWearingGown()
		{
			//IL_006b: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (_003C_003Ec._003C_003E9__148_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((string l) => string.Equals(l, "Gown"));
			}
			Array values = Enum.GetValues(typeof(ClothingItemType));
			if (values != null)
			{
				int num3 = 0;
				if ((long)num3 < (long)(IntPtr)values)
				{
					if (IsMale)
					{
					}
					AvatarWorkingCopy femaleAvatar = _femaleAvatar;
					bool flag = default(bool);
					if (flag)
					{
						Dictionary<ClothingItemType, LoadedClothes> loadedClothes = _loadedClothes;
						bool flag2 = default(bool);
						if (flag2)
						{
							int num4 = 0;
							bool flag3 = default(bool);
							if ((UnityEngine.Object)num != (UnityEngine.Object)num4 && flag3)
							{
								goto IL_0079;
							}
						}
					}
					num3++;
				}
				goto IL_0079;
			}
			throw new InvalidCastException();
			IL_0079:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECB")]
		[Cpp2IlInjected.Address(RVA = "0x15126D0", Offset = "0x15110D0", VA = "0x1815126D0")]
		public void SetSelfieMode(bool selfie)
		{
			//Discarded unreachable code: IL_0023
			if (_isInSelfieMode != selfie)
			{
				Animator animator = Animator;
				_isInSelfieMode = selfie;
				animator.SetTrigger("selfieEnter");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECC")]
		[Cpp2IlInjected.Address(RVA = "0x1512670", Offset = "0x1511070", VA = "0x181512670")]
		public void SetSelfieAngle(float pitch)
		{
			//Discarded unreachable code: IL_0012
			Animator.SetFloat("Y", pitch);
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECD")]
		[Cpp2IlInjected.Address(RVA = "0x150F280", Offset = "0x150DC80", VA = "0x18150F280")]
		public void HideClothing(ClothingItemType type)
		{
			//Discarded unreachable code: IL_0008
			HashSet<ClothingItemType> hiddenClothing = _hiddenClothing;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECE")]
		[Cpp2IlInjected.Address(RVA = "0x1512880", Offset = "0x1511280", VA = "0x181512880")]
		public void ShowAllClothing()
		{
			//Discarded unreachable code: IL_000c
			((HashSet<T>)(object)_hiddenClothing).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6002ECF")]
		[Cpp2IlInjected.Address(RVA = "0x150E150", Offset = "0x150CB50", VA = "0x18150E150")]
		public OrbitCameraTarget GetClothingDecalTarget(ClothingItemType type)
		{
			//Discarded unreachable code: IL_002d
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			int num;
			int num2;
			do
			{
				num = 0;
				if ((IsMale ? 1 : 0) != num)
				{
					OrbitCameraTarget[] array = maleDecalTargets;
				}
				num2 = 0;
			}
			while (!((UnityEngine.Object)num == (UnityEngine.Object)num2));
			return decalTargets[(int)type];
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED0")]
		[Cpp2IlInjected.Address(RVA = "0x150E070", Offset = "0x150CA70", VA = "0x18150E070")]
		public GameObject GetClothingAsset(ClothingItemType type)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED1")]
		[Cpp2IlInjected.Address(RVA = "0x150E220", Offset = "0x150CC20", VA = "0x18150E220")]
		public ClothingItemScript GetClothingItemScript(ClothingItemType type)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED2")]
		[Cpp2IlInjected.Address(RVA = "0x150E290", Offset = "0x150CC90", VA = "0x18150E290")]
		[AsyncStateMachine(typeof(_003CGetClothingMaterial_003Ed__156))]
		public Task<Material> GetClothingMaterial(ClothingItemType type)
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Material>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED3")]
		[Cpp2IlInjected.Address(RVA = "0x150DD30", Offset = "0x150C730", VA = "0x18150DD30")]
		[AsyncStateMachine(typeof(_003CDrawPortrait_003Ed__157))]
		public Task<RenderTexture> DrawPortrait()
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<RenderTexture>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED4")]
		[Cpp2IlInjected.Address(RVA = "0x150FF20", Offset = "0x150E920", VA = "0x18150FF20")]
		[AsyncStateMachine(typeof(_003CLoadFromProfile_003Ed__158))]
		public Task LoadFromProfile(Profile profile, bool cleanup)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED5")]
		[Cpp2IlInjected.Address(RVA = "0x1514E80", Offset = "0x1513880", VA = "0x181514E80")]
		private void ValidateClothes(AvatarWorkingCopy avatar)
		{
			//Discarded unreachable code: IL_001b
			MapField<uint, int> clothes_ = avatar.Data.clothes_;
			bool flag = default(bool);
			if (flag)
			{
				IItemData itemData = default(IItemData);
				while (itemData != null)
				{
				}
				avatar.RevertToDefault();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED6")]
		[Cpp2IlInjected.Address(RVA = "0x1510060", Offset = "0x150EA60", VA = "0x181510060")]
		[AsyncStateMachine(typeof(_003CLoadFromState_003Ed__160))]
		public Task LoadFromState(AvatarWorkingCopy avatar)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED7")]
		[Cpp2IlInjected.Address(RVA = "0x150FE10", Offset = "0x150E810", VA = "0x18150FE10")]
		[AsyncStateMachine(typeof(_003CLoadClothes_003Ed__161))]
		public Task LoadClothes(CancellationToken cancellationToken)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED8")]
		[Cpp2IlInjected.Address(RVA = "0x150FCE0", Offset = "0x150E6E0", VA = "0x18150FCE0")]
		[AsyncStateMachine(typeof(_003CLoadAvatar_003Ed__164))]
		public Task LoadAvatar(CancellationToken cancellationToken)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002ED9")]
		[Cpp2IlInjected.Address(RVA = "0x1515020", Offset = "0x1513A20", VA = "0x181515020")]
		[AsyncStateMachine(typeof(_003CWaitForLoading_003Ed__165))]
		public Task WaitForLoading()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDA")]
		[Cpp2IlInjected.Address(RVA = "0x150C2A0", Offset = "0x150ACA0", VA = "0x18150C2A0")]
		[AsyncStateMachine(typeof(_003CAvatarTransfer_003Ed__166))]
		public Task<(AvatarTransfer.Types.Result, AvatarTransferData)> AvatarTransfer(string avatarCode, bool saveClothes, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(AvatarTransfer.Types.Result, AvatarTransferData)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDB")]
		[Cpp2IlInjected.Address(RVA = "0x150D400", Offset = "0x150BE00", VA = "0x18150D400")]
		[AsyncStateMachine(typeof(_003CCompleteAvatarTransfer_003Ed__167))]
		public Task<AvatarTransfer.Types.Result> CompleteAvatarTransfer(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<AvatarTransfer.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDC")]
		[Cpp2IlInjected.Address(RVA = "0x1510BF0", Offset = "0x150F5F0", VA = "0x181510BF0")]
		public void RemoveAvatarTransfer()
		{
			//Discarded unreachable code: IL_0074
			//IL_0058: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_0073: Expected O, but got I4
			int num = 0;
			if ((IntPtr)avatarTransferData == (IntPtr)num)
			{
				return;
			}
			Array values = Enum.GetValues(typeof(ClothingItemType));
			if (values != null)
			{
				if ((long)num < (long)(IntPtr)values)
				{
					Dictionary<ClothingItemType, Item> dictionary = avatarTransferOriginalClothes;
					bool flag = IsMale;
					bool flag2 = default(bool);
					if (!flag2)
					{
						if (flag)
						{
						}
						AvatarWorkingCopy femaleAvatar = _femaleAvatar;
						num++;
					}
					if (flag)
					{
					}
					bool flag3 = _femaleAvatar.SetClothes((Item)num);
					num++;
				}
				avatarTransferByteData = (byte[])num;
				avatarTransferData = (AvatarTransferData)num;
				avatarTransferOriginalClothes = (Dictionary<ClothingItemType, Item>)num;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDD")]
		[Cpp2IlInjected.Address(RVA = "0x1511370", Offset = "0x150FD70", VA = "0x181511370")]
		[AsyncStateMachine(typeof(_003CSave_003Ed__169))]
		public Task<Meta.AvatarCustomization.Types.Result> Save(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Meta.AvatarCustomization.Types.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDE")]
		[Cpp2IlInjected.Address(RVA = "0x150CC50", Offset = "0x150B650", VA = "0x18150CC50")]
		public void CombineHead()
		{
			//Discarded unreachable code: IL_0209
			//IL_0097: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			//IL_00dd: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			//IL_015d: Expected I4, but got I8
			int num = 0;
			Dictionary<string, float> dictionary = (Dictionary<string, float>)(object)new Dictionary<TKey, TValue>();
			AvatarFaceConfig[] array = faceOptions;
			if (num < array.Length)
			{
				AvatarFaceConfig avatarFaceConfig = array[num];
				if ((IsMale ? 1 : 0) != num)
				{
				}
				MapField<uint, int> faceType_ = _femaleAvatar.Data.faceType_;
				List<AvatarFaceConfig.FacePartOption> facePartOptions = avatarFaceConfig.facePartOptions;
				bool flag = default(bool);
				if (!flag)
				{
					if ((IsMale ? 1 : 0) != num)
					{
					}
					throw new NullReferenceException();
				}
				num++;
				AvatarFaceConfig[] array2 = faceOptions;
				num++;
			}
			Debug.Log(dictionary);
			List<CombineMesh> list = (List<CombineMesh>)(object)new List<T>();
			SkinnedMeshRenderer smr = head.TaggedSmr.GetSmr("skull");
			int num2 = 0;
			((List<T>)(object)list).Add((T)num2);
			SkinnedMeshRenderer smr2 = head.TaggedSmr.GetSmr("teeth_up");
			int num3 = 0;
			((List<T>)(object)list).Add((T)num3);
			SkinnedMeshRenderer smr3 = head.TaggedSmr.GetSmr("teeth_down");
			int num4 = 0;
			((List<T>)(object)list).Add((T)num4);
			SkinnedMeshRenderer smr4 = head.TaggedSmr.GetSmr("eyes");
			if ((IsMale ? 1 : 0) != num)
			{
			}
			int num5 = 0;
			((List<T>)(object)list).Add((T)num5);
			SkinnedMeshRenderer smr5 = head.TaggedSmr.GetSmr("eyes_shadow");
			if ((IsMale ? 1 : 0) != num)
			{
			}
			SkinnedMeshRenderer smr6 = head.TaggedSmr.GetSmr("eyelashes");
			int num6 = 0;
			Dictionary<string, Transform> dictionary2 = SkeletonDefinition;
			ulong num7 = default(ulong);
			SkinnedMeshCombiner.Combine(combinedHead, (List<>)(object)list, (Dictionary<, >)(object)dictionary2, (Dictionary<, >)(object)dictionary, (byte)num7 != 0);
			int blendShapeIndex = combinedHead.sharedMesh.GetBlendShapeIndex("Smile_01");
			SkinnedMeshRenderer skinnedMeshRenderer = combinedHead;
			_SmileSmallIndex = blendShapeIndex;
			int blendShapeIndex2 = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex("Smile_02");
			SkinnedMeshRenderer skinnedMeshRenderer2 = combinedHead;
			_SmileMediumIndex = blendShapeIndex2;
			int blendShapeIndex3 = skinnedMeshRenderer2.sharedMesh.GetBlendShapeIndex("Smile_03");
			SkinnedMeshRenderer skinnedMeshRenderer3 = combinedHead;
			_SmileLargeIndex = blendShapeIndex3;
			int blendShapeIndex4 = skinnedMeshRenderer3.sharedMesh.GetBlendShapeIndex("Wink_Left");
			SkinnedMeshRenderer skinnedMeshRenderer4 = combinedHead;
			_WinkLeftIndex = blendShapeIndex4;
			int num8 = (_WinkRightIndex = skinnedMeshRenderer4.sharedMesh.GetBlendShapeIndex("Wink_Right"));
		}

		[Cpp2IlInjected.Token(Token = "0x6002EDF")]
		[Cpp2IlInjected.Address(RVA = "0x150CB60", Offset = "0x150B560", VA = "0x18150CB60")]
		[AsyncStateMachine(typeof(_003CCombineBody_003Ed__171))]
		public Task CombineBody()
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE0")]
		[Cpp2IlInjected.Address(RVA = "0x1511100", Offset = "0x150FB00", VA = "0x181511100")]
		[AsyncStateMachine(typeof(_003CRevert_003Ed__172))]
		public Task Revert()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE1")]
		[Cpp2IlInjected.Address(RVA = "0x150EB90", Offset = "0x150D590", VA = "0x18150EB90")]
		public int GetCurrentSkinColorIndex()
		{
			//Discarded unreachable code: IL_001a
			if (IsMale)
			{
			}
			return _femaleAvatar.Data.skinColorIndex_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE2")]
		[Cpp2IlInjected.Address(RVA = "0x1512750", Offset = "0x1511150", VA = "0x181512750")]
		[AsyncStateMachine(typeof(_003CSetSkinColor_003Ed__176))]
		public Task<bool> SetSkinColor(int skinColorIndex)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE3")]
		[Cpp2IlInjected.Address(RVA = "0x1511C00", Offset = "0x1510600", VA = "0x181511C00")]
		public bool SetEyeColor(int color)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE4")]
		[Cpp2IlInjected.Address(RVA = "0x150E830", Offset = "0x150D230", VA = "0x18150E830")]
		public int GetCurrentEyeColor()
		{
			//Discarded unreachable code: IL_001a
			if (IsMale)
			{
			}
			return _femaleAvatar.Data.eyeColor_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE5")]
		[Cpp2IlInjected.Address(RVA = "0x1511FF0", Offset = "0x15109F0", VA = "0x181511FF0")]
		public bool SetHairColor(int hairColorIndex)
		{
			bool flag = IsMale;
			if (flag)
			{
			}
			if (_femaleAvatar.Data.hairColorIndex_ != hairColorIndex)
			{
				if (flag)
				{
				}
				_femaleAvatar.Data.hairColorIndex_ = hairColorIndex;
				ApplyHairColor();
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE6")]
		[Cpp2IlInjected.Address(RVA = "0x150E9A0", Offset = "0x150D3A0", VA = "0x18150E9A0")]
		public int GetCurrentHairColorIndex()
		{
			//Discarded unreachable code: IL_001a
			if (IsMale)
			{
			}
			return _femaleAvatar.Data.hairColorIndex_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE7")]
		[Cpp2IlInjected.Address(RVA = "0x1512070", Offset = "0x1510A70", VA = "0x181512070")]
		public bool SetHairHighlightColor(int highlightColorIndex)
		{
			bool flag = IsMale;
			if (flag)
			{
			}
			if (_femaleAvatar.Data.hairHighlightColor_ != highlightColorIndex)
			{
				if (flag)
				{
				}
				_femaleAvatar.Data.hairHighlightColor_ = highlightColorIndex;
				ApplyHairColor();
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE8")]
		[Cpp2IlInjected.Address(RVA = "0x150E9E0", Offset = "0x150D3E0", VA = "0x18150E9E0")]
		public int GetCurrentHairHighlightColor()
		{
			//Discarded unreachable code: IL_001a
			if (IsMale)
			{
			}
			return _femaleAvatar.Data.hairHighlightColor_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EE9")]
		[Cpp2IlInjected.Address(RVA = "0x150FCA0", Offset = "0x150E6A0", VA = "0x18150FCA0")]
		public bool IsWearing(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_0016
			if (IsMale)
			{
			}
			return _femaleAvatar.IsWearing(clothingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEA")]
		[Cpp2IlInjected.Address(RVA = "0x150F9F0", Offset = "0x150E3F0", VA = "0x18150F9F0")]
		public bool IsWearing(ClothingItemType clothingType, out Item item, out int designId)
		{
			//Discarded unreachable code: IL_0073
			//IL_0017: Expected I4, but got O
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar = _femaleAvatar;
			Item item2 = default(Item);
			item.ItemID = (int)item2;
			if (IsMale)
			{
			}
			AvatarWorkingCopy femaleAvatar2 = _femaleAvatar;
			int num = default(int);
			designId.m_value = num;
			if (num != -1)
			{
				if (avatarTransferData == null)
				{
					ProfilePlayer player_ = CurrentProfile.player_;
					bool flag = IsMale;
					MapField<int, DesignMap> designMaps = (MapField<int, DesignMap>)(object)player_.GetDesignMaps(flag);
				}
				if (IsMale)
				{
				}
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				if (flag2 && flag3)
				{
				}
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEB")]
		[Cpp2IlInjected.Address(RVA = "0x150FBB0", Offset = "0x150E5B0", VA = "0x18150FBB0")]
		public bool IsWearing(Item item, int designId = -1)
		{
			int num = 0;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool result = default(bool);
			if (flag && flag2 && flag2)
			{
				return result;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEC")]
		[Cpp2IlInjected.Address(RVA = "0x1510E20", Offset = "0x150F820", VA = "0x181510E20")]
		[AsyncStateMachine(typeof(_003CRemoveClothes_003Ed__186))]
		public Task<bool> RemoveClothes(ClothingItemType clothingType, bool loadCurrent = true)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EED")]
		[Cpp2IlInjected.Address(RVA = "0x15114C0", Offset = "0x150FEC0", VA = "0x1815114C0")]
		[AsyncStateMachine(typeof(_003CSelectClothes_003Ed__187))]
		public Task<bool> SelectClothes(Item item, bool loadCurrent = true)
		{
			int itemID = item.ItemID;
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEE")]
		[Cpp2IlInjected.Address(RVA = "0x1511AB0", Offset = "0x15104B0", VA = "0x181511AB0")]
		[AsyncStateMachine(typeof(_003CSetClothingDesign_003Ed__188))]
		public Task<bool> SetClothingDesign(Item item, int designId, bool loadCurrent = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EEF")]
		[Cpp2IlInjected.Address(RVA = "0x1513810", Offset = "0x1512210", VA = "0x181513810")]
		public void UpdateClothingDesignId(ClothingItemType clothingType, int designId)
		{
			//Discarded unreachable code: IL_0018
			Dictionary<ClothingItemType, LoadedClothes> loadedClothes = _loadedClothes;
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<ClothingItemType, LoadedClothes> loadedClothes2 = _loadedClothes;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF0")]
		[Cpp2IlInjected.Address(RVA = "0x1510860", Offset = "0x150F260", VA = "0x181510860")]
		[AsyncStateMachine(typeof(_003CRefreshAsync_003Ed__190))]
		private Task RefreshAsync()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF1")]
		[Cpp2IlInjected.Address(RVA = "0x1511EA0", Offset = "0x15108A0", VA = "0x181511EA0")]
		[AsyncStateMachine(typeof(_003CSetGender_003Ed__191))]
		public Task<bool> SetGender(bool isMale, bool loadCurrent = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF2")]
		[Cpp2IlInjected.Address(RVA = "0x150E3E0", Offset = "0x150CDE0", VA = "0x18150E3E0")]
		public int GetCurrentBodyTypeIndex()
		{
			//Discarded unreachable code: IL_001a
			if (IsMale)
			{
			}
			return _femaleAvatar.Data.bodyType_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF3")]
		[Cpp2IlInjected.Address(RVA = "0x1511980", Offset = "0x1510380", VA = "0x181511980")]
		[AsyncStateMachine(typeof(_003CSetBodyType_003Ed__193))]
		public Task<bool> SetBodyType(int bodyTypeIndex)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF4")]
		[Cpp2IlInjected.Address(RVA = "0x1511D50", Offset = "0x1510750", VA = "0x181511D50")]
		[AsyncStateMachine(typeof(_003CSetFaceType_003Ed__194))]
		public Task<bool> SetFaceType(FacePartType facePartType, int index, bool loadCurrent = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF5")]
		[Cpp2IlInjected.Address(RVA = "0x150E870", Offset = "0x150D270", VA = "0x18150E870")]
		private AvatarFaceConfig.FacePartOption GetCurrentFaceType(FacePartType facePartType)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF6")]
		[Cpp2IlInjected.Address(RVA = "0x150EA20", Offset = "0x150D420", VA = "0x18150EA20")]
		private AssetReference GetCurrentHead()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF7")]
		[Cpp2IlInjected.Address(RVA = "0x150F130", Offset = "0x150DB30", VA = "0x18150F130")]
		private AssetReference GetHead(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF8")]
		[Cpp2IlInjected.Address(RVA = "0x1513E60", Offset = "0x1512860", VA = "0x181513E60")]
		public void UpdateFaceNormalMap()
		{
			//Discarded unreachable code: IL_0143
			bool flag = default(bool);
			if (flag)
			{
				RenderTexture renderTexture = default(RenderTexture);
				normal = renderTexture;
			}
			Material material = faceNormalBlend;
			int num = 0;
			Material material4 = default(Material);
			if ((IsMale ? 1 : 0) == num)
			{
				Texture2D femaleNormalMap = GetCurrentFaceType((FacePartType)num).femaleNormalMap;
				material.SetTexture("_NormalEyes", femaleNormalMap);
				Material material2 = faceNormalBlend;
				Texture2D femaleNormalMap2 = GetCurrentFaceType(FacePartType.Nose).femaleNormalMap;
				material2.SetTexture("_NormalNose", femaleNormalMap2);
				Material material3 = faceNormalBlend;
				Texture2D femaleNormalMap3 = GetCurrentFaceType(FacePartType.Mouth).femaleNormalMap;
				material3.SetTexture("_NormalMouth", femaleNormalMap3);
				material4 = faceNormalBlend;
				AvatarFaceConfig.FacePartOption currentFaceType = GetCurrentFaceType(FacePartType.Jaw);
			}
			Texture2D maleNormalMap = GetCurrentFaceType(FacePartType.Jaw).maleNormalMap;
			material4.SetTexture("_NormalEyes", maleNormalMap);
			Material material5 = faceNormalBlend;
			Texture2D maleNormalMap2 = GetCurrentFaceType(FacePartType.Nose).maleNormalMap;
			material5.SetTexture("_NormalNose", maleNormalMap2);
			Material material6 = faceNormalBlend;
			Texture2D maleNormalMap3 = GetCurrentFaceType(FacePartType.Mouth).maleNormalMap;
			material6.SetTexture("_NormalMouth", maleNormalMap3);
			Material material7 = faceNormalBlend;
			Texture2D maleNormalMap4 = GetCurrentFaceType(FacePartType.Jaw).maleNormalMap;
			material7.SetTexture("_AvatarNormalTex", maleNormalMap4);
			int num2 = 0;
			MaterialPropertyBlock materialPropertyBlock = headMPB;
			SkinnedMeshRenderer skinnedMeshRenderer = combinedHead;
			MaterialPropertyBlock properties = headMPB;
			((Renderer)skinnedMeshRenderer).Internal_SetPropertyBlock(properties);
		}

		[Cpp2IlInjected.Token(Token = "0x6002EF9")]
		[Cpp2IlInjected.Address(RVA = "0x150EF90", Offset = "0x150D990", VA = "0x18150EF90")]
		public List<AvatarFaceConfig.FacePartOption> GetFaceTypeOptions(FacePartType facePartType)
		{
			//Discarded unreachable code: IL_0028
			//IL_0018: Expected O, but got I4
			AvatarFaceConfig avatarFaceConfig = faceOptions[(int)facePartType];
			int num = 0;
			if (!(avatarFaceConfig != (UnityEngine.Object)num))
			{
				return (List<AvatarFaceConfig.FacePartOption>)(object)new List<T>();
			}
			return avatarFaceConfig.facePartOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EFA")]
		[Cpp2IlInjected.Address(RVA = "0x1513B40", Offset = "0x1512540", VA = "0x181513B40")]
		public void UpdateFaceBlendShapes(SkinnedMeshRenderer skinnedMesh)
		{
			//Discarded unreachable code: IL_00f4
			//IL_002a: Expected F4, but got I4
			//IL_0071: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int blendShapeCount = skinnedMesh.sharedMesh.blendShapeCount;
			if (num2 >= blendShapeCount)
			{
				return;
			}
			int num3 = 0;
			skinnedMesh.SetBlendShapeWeight(num, num3);
			string name = skinnedMesh.sharedMesh.GetBlendShapeName(num);
			int num4 = 0;
			AvatarFaceConfig[] array = faceOptions;
			if (num4 < array.Length)
			{
				AvatarFaceConfig avatarFaceConfig = array[num4];
				int num5 = 0;
				bool flag = avatarFaceConfig == (UnityEngine.Object)num5;
				if (!flag)
				{
					if (IsMale != flag)
					{
					}
					MapField<uint, int> faceType_ = _femaleAvatar.Data.faceType_;
					bool flag2 = default(bool);
					if (flag2)
					{
						Predicate<AvatarFaceConfig.FacePartOption> predicate = default(Predicate<AvatarFaceConfig.FacePartOption>);
						Predicate<AvatarFaceConfig.FacePartOption> predicate2 = predicate;
						List<AvatarFaceConfig.FacePartOption> facePartOptions = avatarFaceConfig.facePartOptions;
						Predicate<AvatarFaceConfig.FacePartOption> predicate3 = default(Predicate<AvatarFaceConfig.FacePartOption>);
						if (predicate2 == null)
						{
							predicate3 = (predicate = (Predicate<AvatarFaceConfig.FacePartOption>)(object)(Predicate<T>)delegate(AvatarFaceConfig.FacePartOption option)
							{
								//Discarded unreachable code: IL_0014
								string b = name;
								return string.Equals(option.blendShape, b);
							});
						}
						int num6 = ((List<T>)(object)facePartOptions).FindIndex((Predicate<>)(object)predicate3);
					}
				}
				num4++;
				List<AvatarFaceConfig.FacePartOption> facePartOptions2 = avatarFaceConfig.facePartOptions;
				if (IsMale)
				{
				}
				num++;
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6002EFB")]
		[Cpp2IlInjected.Address(RVA = "0x150BF00", Offset = "0x150A900", VA = "0x18150BF00")]
		private void ApplyHairColor()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002EFC")]
		[Cpp2IlInjected.Address(RVA = "0x150F070", Offset = "0x150DA70", VA = "0x18150F070")]
		private static Color GetHairHighlightColorFromConfig(AvatarHairColorConfig hairColorConfig, int hairColorIndex, int highlightColorIndex)
		{
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EFD")]
		[Cpp2IlInjected.Address(RVA = "0x150CA10", Offset = "0x150B410", VA = "0x18150CA10")]
		public void CleanupUnusedMaterials()
		{
			//Discarded unreachable code: IL_0010
			List<AssetReference> list = toCleanup;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002EFE")]
		[Cpp2IlInjected.Address(RVA = "0x150D9B0", Offset = "0x150C3B0", VA = "0x18150D9B0")]
		private unsafe bool ConditionsAreTrue(ConditionalBlendShape blendShape)
		{
			//IL_0050: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			bool flag = IsMale;
			if (flag)
			{
			}
			if (blendShape.avatarIsFemale)
			{
				if (flag)
				{
				}
				AvatarWorkingCopy femaleAvatar = _femaleAvatar;
				ClothingItemType clothingType = blendShape.clothingType;
				if (femaleAvatar.IsWearing(clothingType))
				{
					Dictionary<ClothingItemType, LoadedClothes> loadedClothes = _loadedClothes;
					ClothingItemType clothingType2 = blendShape.clothingType;
					if (((Dictionary<TKey, TValue>)(object)loadedClothes).TryGetValue((TKey)clothingType2, out *(TValue*)num))
					{
						int num3 = 0;
						List<BlendShapeCondition> conditions = blendShape.conditions;
						if ((blendShape.whenWearing ? 1 : 0) == num3)
						{
							return !this.ConditionsAreTrue((List<>)(object)conditions, (ClothingItemScript)num);
						}
						return this.ConditionsAreTrue((List<>)(object)conditions, (ClothingItemScript)num);
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002EFF")]
		[Cpp2IlInjected.Address(RVA = "0x150D7E0", Offset = "0x150C1E0", VA = "0x18150D7E0")]
		private bool ConditionsAreTrue(List<BlendShapeCondition> conditions, ClothingItemScript clothing)
		{
			//Discarded unreachable code: IL_0025, IL_002b, IL_0031
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				List<int> options = clothing.options;
				int num3 = 0;
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F00")]
		[Cpp2IlInjected.Address(RVA = "0x1513440", Offset = "0x1511E40", VA = "0x181513440")]
		public void UpdateBodyTypeBlendShapes(SkinnedMeshRenderer skinnedMesh)
		{
			//Discarded unreachable code: IL_015a
			//IL_009d: Expected F4, but got I4
			BodyType currentBodyType = GetCurrentBodyType();
			int num = 0;
			int num2 = 0;
			int blendShapeCount = skinnedMesh.sharedMesh.blendShapeCount;
			if (num2 < blendShapeCount)
			{
				string name2 = skinnedMesh.sharedMesh.GetBlendShapeName(num);
				List<BodyType> list = femaleBodyTypes;
				Predicate<BodyType> predicate = (Predicate<BodyType>)(object)(Predicate<T>)delegate(BodyType b)
				{
					//IL_002a: Expected O, but got I4
					if (b != null)
					{
						string blendShape2 = b.blendShape;
						string b6 = name2;
						return string.Equals(blendShape2, b6);
					}
					int num13 = 0;
					string b7 = name2;
					return string.Equals((string)num13, b7);
				};
				int num3 = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
				List<BodyType> list2 = maleBodyTypes;
				Predicate<BodyType> predicate2 = (Predicate<BodyType>)(object)(Predicate<T>)delegate(BodyType b)
				{
					//IL_002a: Expected O, but got I4
					if (b != null)
					{
						string blendShape = b.blendShape;
						string b4 = name2;
						return string.Equals(blendShape, b4);
					}
					int num12 = 0;
					string b5 = name2;
					return string.Equals((string)num12, b5);
				};
				int num4 = ((List<T>)(object)list2).FindIndex((Predicate<>)(object)predicate2);
				if (currentBodyType != null)
				{
				}
				int num5 = 0;
				if (num3 != -1)
				{
					int num6 = default(int);
					if (num4 == 0)
					{
						num6 = 0;
					}
					skinnedMesh.SetBlendShapeWeight(num, num6);
				}
				num++;
			}
			Animator animator = Animator;
			int num7 = 0;
			int num8 = 0;
			int layerCount = animator.layerCount;
			if (num8 >= layerCount)
			{
				return;
			}
			string name = Animator.GetLayerName(num7);
			List<BodyType> list3 = femaleBodyTypes;
			Predicate<BodyType> predicate3 = (Predicate<BodyType>)(object)(Predicate<T>)delegate(BodyType b)
			{
				//Discarded unreachable code: IL_0014
				string b3 = name;
				return string.Equals(b.animationLayer, b3);
			};
			int num9 = ((List<T>)(object)list3).FindIndex((Predicate<>)(object)predicate3);
			List<BodyType> list4 = maleBodyTypes;
			Predicate<BodyType> predicate4 = (Predicate<BodyType>)(object)(Predicate<T>)delegate(BodyType b)
			{
				//Discarded unreachable code: IL_0014
				string b2 = name;
				return string.Equals(b.animationLayer, b2);
			};
			int num10 = ((List<T>)(object)list4).FindIndex((Predicate<>)(object)predicate4);
			if (currentBodyType != null)
			{
			}
			int num11 = 0;
			if (num9 != -1)
			{
				Animator animator2 = Animator;
				if (num10 == 0)
				{
				}
				animator2.SetLayerWeight(num7, 1f);
			}
			Animator animator3 = Animator;
			num7++;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F01")]
		[Cpp2IlInjected.Address(RVA = "0x150EE90", Offset = "0x150D890", VA = "0x18150EE90")]
		public BodyType GetDefaultBodyType(bool isMale)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F02")]
		[Cpp2IlInjected.Address(RVA = "0x150E420", Offset = "0x150CE20", VA = "0x18150E420")]
		public BodyType GetCurrentBodyType()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F03")]
		[Cpp2IlInjected.Address(RVA = "0x1515250", Offset = "0x1513C50", VA = "0x181515250")]
		public AvatarAppearance()
		{
		}//IL_0115: Expected I4, but got I8
		//IL_011e: Expected I4, but got I8
		//IL_012e: Expected I4, but got I8


		[Cpp2IlInjected.Token(Token = "0x6002F04")]
		[Cpp2IlInjected.Address(RVA = "0x1515120", Offset = "0x1513B20", VA = "0x181515120")]
		static AvatarAppearance()
		{
			MakeupItemType[] array = new MakeupItemType[13];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			makeupOrder = array;
			ClothingItemType[] array2 = new ClothingItemType[10];
			RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			makeupOrder = (MakeupItemType[])(object)array2;
			ClothingItemType[] array3 = new ClothingItemType[3];
			RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			makeupOrder = (MakeupItemType[])(object)array3;
			/*Error: Unexpected end of block*/;
		}
	}
}
