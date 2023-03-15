using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A77")]
	public class AvatarHeadSkinnedMesh : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40039C3")]
		public OrbitCameraTarget femaleDecalTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40039C4")]
		public OrbitCameraTarget maleDecalTarget;

		[Cpp2IlInjected.Token(Token = "0x170006CD")]
		public GameObject Asset
		{
			[Cpp2IlInjected.Token(Token = "0x60030A3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CAsset_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60030A4")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CAsset_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CE")]
		public SkinnedMeshRenderer Smr
		{
			[Cpp2IlInjected.Token(Token = "0x60030A5")]
			[Cpp2IlInjected.Address(RVA = "0x151DE20", Offset = "0x151C820", VA = "0x18151DE20")]
			get
			{
				//Discarded unreachable code: IL_0011
				return TaggedSmr.GetSmr("skull");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CF")]
		public TaggedSkinnedMeshes TaggedSmr
		{
			[Cpp2IlInjected.Token(Token = "0x60030A6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CTaggedSmr_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60030A7")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CTaggedSmr_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030A8")]
		[Cpp2IlInjected.Address(RVA = "0x151DD70", Offset = "0x151C770", VA = "0x18151DD70")]
		public void SetAsset(GameObject asset)
		{
			//Discarded unreachable code: IL_0022
			//IL_0010: Expected O, but got I4
			Asset = asset;
			int num = 0;
			if (!(asset == (Object)num))
			{
				TaggedSkinnedMeshes taggedSkinnedMeshes = (TaggedSmr = asset.GetComponentInChildren<TaggedSkinnedMeshes>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030A9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AvatarHeadSkinnedMesh()
		{
		}
	}
}
