using System.IO;
using Cpp2IlInjected;

namespace Gameloft.Localization.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface IFileSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FileExists(string path);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string ReadAllText(string path);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WriteAllText(string path, string text);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string[] GetFiles(string path, string searchPath, SearchOption searchOption);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Delete(string path);
	}
}
