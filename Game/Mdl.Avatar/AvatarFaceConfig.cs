using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A5D")]
	[CreateAssetMenu]
	public class AvatarFaceConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A5E")]
		public class FacePartOption
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003942")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4003943")]
			public float maleIntensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003944")]
			public string blendShape;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003945")]
			public AssetReferenceAtlasedSprite iconReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4003946")]
			public AssetReferenceAtlasedSprite maleIconReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4003947")]
			public Texture2D femaleNormalMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4003948")]
			public Texture2D maleNormalMap;

			[Cpp2IlInjected.Token(Token = "0x600302E")]
			[Cpp2IlInjected.Address(RVA = "0x1BC7BA0", Offset = "0x1BC65A0", VA = "0x181BC7BA0")]
			[AsyncStateMachine(typeof(_003CGetIcon_003Ed__7))]
			public Task<Sprite> GetIcon(bool isMale)
			{
				int num = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> result = default(Task<>);
				return (Task<Sprite>)(object)result;
			}

			[Cpp2IlInjected.Token(Token = "0x600302F")]
			[Cpp2IlInjected.Address(RVA = "0x1BC7B60", Offset = "0x1BC6560", VA = "0x181BC7B60")]
			private AssetReferenceAtlasedSprite GetIconReference(bool isMale)
			{
				if (isMale)
				{
					AssetReferenceAtlasedSprite assetReferenceAtlasedSprite = maleIconReference;
					if (assetReferenceAtlasedSprite != null && assetReferenceAtlasedSprite.RuntimeKeyIsValid())
					{
						return maleIconReference;
					}
				}
				return iconReference;
			}

			[Cpp2IlInjected.Token(Token = "0x6003030")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public FacePartOption()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003941")]
		public List<FacePartOption> facePartOptions = (List<FacePartOption>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x600302D")]
		[Cpp2IlInjected.Address(RVA = "0x151DBB0", Offset = "0x151C5B0", VA = "0x18151DBB0")]
		public AvatarFaceConfig()
		{
		}
	}
}
