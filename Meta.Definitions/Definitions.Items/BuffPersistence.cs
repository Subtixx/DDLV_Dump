using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200060A")]
	public enum BuffPersistence
	{
		[Cpp2IlInjected.Token(Token = "0x4002122")]
		[OriginalName("BuffPersistence_Persisted")]
		Persisted,
		[Cpp2IlInjected.Token(Token = "0x4002123")]
		[OriginalName("BuffPersistence_Transient")]
		Transient
	}
}
