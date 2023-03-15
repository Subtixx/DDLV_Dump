using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A66")]
	[CreateAssetMenu]
	public class AvatarSkinConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A67")]
		public class SkinParameters
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400395C")]
			public AssetReferenceMaterial faceMaterial;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400395D")]
			public AssetReferenceMaterial bodyMaterial;

			[Cpp2IlInjected.Token(Token = "0x6003038")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SkinParameters()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A68")]
		public class SkinOption
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400395E")]
			public Color iconColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400395F")]
			public SkinParameters femaleSkin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4003960")]
			public SkinParameters maleSkin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4003961")]
			public bool IsVitiligo;

			[Cpp2IlInjected.Token(Token = "0x6003039")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SkinOption()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400395B")]
		public List<SkinOption> skinOptions = (List<SkinOption>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003037")]
		[Cpp2IlInjected.Address(RVA = "0x151F8E0", Offset = "0x151E2E0", VA = "0x18151F8E0")]
		public AvatarSkinConfig()
		{
		}
	}
}
