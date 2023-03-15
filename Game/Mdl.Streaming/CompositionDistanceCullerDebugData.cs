using Cpp2IlInjected;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x20007F6")]
	public struct CompositionDistanceCullerDebugData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002C79")]
		public int NumMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4002C7A")]
		public int NumLODGroup;

		[Cpp2IlInjected.Token(Token = "0x6002377")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA00", Offset = "0xA8A400", VA = "0x180A8BA00")]
		public void Clear()
		{
			int num = (NumMesh = 0);
		}
	}
}
