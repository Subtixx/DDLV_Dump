using System;
using Cpp2IlInjected;
using Mdl.Avatar;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public struct ToolIconReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public Toolbox.ToolType Key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public UnityEngine.AddressableAssets.AssetReferenceTexture AssetReferenceTexture;
	}
}
