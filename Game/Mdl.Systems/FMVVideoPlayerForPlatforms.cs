using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Video;

namespace Mdl.Systems
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000951")]
	public class FMVVideoPlayerForPlatforms
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40033BC")]
		[SerializeField]
		public List<RuntimePlatform> platforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40033BD")]
		[SerializeField]
		public VideoPlayer video;

		[Cpp2IlInjected.Token(Token = "0x6002B19")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FMVVideoPlayerForPlatforms()
		{
		}
	}
}
