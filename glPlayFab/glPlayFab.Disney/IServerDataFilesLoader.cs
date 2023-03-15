using System.Collections.Generic;
using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	public interface IServerDataFilesLoader
	{
		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		bool IsDebug
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ServerDataResult Load();

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(Slot = "1")]
		List<IServerDataConfig> GetConfigsByType(ServerDataType dataType);
	}
}
