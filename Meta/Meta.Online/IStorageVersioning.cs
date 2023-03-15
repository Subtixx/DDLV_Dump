using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E85")]
	public interface IStorageVersioning
	{
		[Cpp2IlInjected.Token(Token = "0x17001519")]
		int CurrentVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6007905")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700151A")]
		int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6007906")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007907")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}
	}
}
