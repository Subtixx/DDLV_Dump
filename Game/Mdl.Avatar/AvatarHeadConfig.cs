using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A63")]
	[CreateAssetMenu]
	public class AvatarHeadConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A64")]
		public class HeadOption
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003958")]
			public AssetReference femaleHead;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003959")]
			public AssetReference maleHead;

			[Cpp2IlInjected.Token(Token = "0x6003035")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public HeadOption()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003957")]
		public List<HeadOption> headOptions = (List<HeadOption>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003034")]
		[Cpp2IlInjected.Address(RVA = "0x151DCF0", Offset = "0x151C6F0", VA = "0x18151DCF0")]
		public AvatarHeadConfig()
		{
		}
	}
}
