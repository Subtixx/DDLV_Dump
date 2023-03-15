using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Sky
{
	[Cpp2IlInjected.Token(Token = "0x20004C5")]
	[CreateAssetMenu]
	public class CloudInfos : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DF5")]
		public Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DF6")]
		public Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DF7")]
		public float minSize = 100f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001DF8")]
		public float maxSize = 200f;

		[Cpp2IlInjected.Token(Token = "0x6001512")]
		[Cpp2IlInjected.Address(RVA = "0xA888B0", Offset = "0xA872B0", VA = "0x180A888B0")]
		public CloudInfos()
		{
		}
	}
}
