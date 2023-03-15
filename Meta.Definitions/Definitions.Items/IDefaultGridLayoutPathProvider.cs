using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000656")]
	public interface IDefaultGridLayoutPathProvider
	{
		[Cpp2IlInjected.Token(Token = "0x1700131D")]
		string DefaultGridLayoutTypeName
		{
			[Cpp2IlInjected.Token(Token = "0x6004A4A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700131E")]
		string DefaultGridLayoutPath
		{
			[Cpp2IlInjected.Token(Token = "0x6004A4B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
