using System.IO;
using Cpp2IlInjected;

namespace Gameloft.Localization.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class DefaultFileSystem : IFileSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x408B3E0", Offset = "0x4089DE0", VA = "0x18408B3E0", Slot = "4")]
		public bool FileExists(string path)
		{
			return File.Exists(path);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2E7AC90", Offset = "0x2E79690", VA = "0x182E7AC90", Slot = "5")]
		public string ReadAllText(string path)
		{
			return File.ReadAllText(path);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x408B3F0", Offset = "0x4089DF0", VA = "0x18408B3F0", Slot = "7")]
		public string[] GetFiles(string path, string searchPath, SearchOption searchOption)
		{
			string[] result = default(string[]);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x408B410", Offset = "0x4089E10", VA = "0x18408B410", Slot = "6")]
		public void WriteAllText(string path, string text)
		{
			//Discarded unreachable code: IL_0018
			new FileInfo(path).Directory.Create();
			File.WriteAllText(path, text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x408B3D0", Offset = "0x4089DD0", VA = "0x18408B3D0", Slot = "8")]
		public void Delete(string path)
		{
			File.Delete(path);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public DefaultFileSystem()
		{
		}
	}
}
