using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A5B")]
	[CreateAssetMenu]
	public class AvatarEyeColorConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A5C")]
		public class EyeColorOption
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003940")]
			public Color baseColor;

			[Cpp2IlInjected.Token(Token = "0x600302C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public EyeColorOption()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400393F")]
		public List<EyeColorOption> eyeColorOptions = (List<EyeColorOption>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x600302B")]
		[Cpp2IlInjected.Address(RVA = "0x151DB30", Offset = "0x151C530", VA = "0x18151DB30")]
		public AvatarEyeColorConfig()
		{
		}
	}
}
