using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.ImageRendering.Editor
{
	[Cpp2IlInjected.Token(Token = "0x2000402")]
	public class AssetRenderingObject : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019EF")]
		public bool showToolSettings;

		[Cpp2IlInjected.Token(Token = "0x60010FD")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public AssetRenderingObject()
		{
		}
	}
}
