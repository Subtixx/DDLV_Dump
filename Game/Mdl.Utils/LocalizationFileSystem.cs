using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Gameloft.Localization.Core;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000772")]
	public class LocalizationFileSystem : Gameloft.Localization.Core.IFileSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6002109")]
		[Cpp2IlInjected.Address(RVA = "0xBB5560", Offset = "0xBB3F60", VA = "0x180BB5560", Slot = "4")]
		public bool FileExists(string path)
		{
			//Discarded unreachable code: IL_0022
			//IL_0022: Expected I4, but got O
			Gameloft.FileSystem.Abstraction.IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			uint recursive = default(uint);
			_003CData_003Ek__BackingField.DeleteDirectory(path, (byte)recursive != 0);
			return (byte)(int)typeof(FileSystem).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600210A")]
		[Cpp2IlInjected.Address(RVA = "0xBB5640", Offset = "0xBB4040", VA = "0x180BB5640", Slot = "7")]
		public string[] GetFiles(string path, string searchPath, SearchOption searchOption)
		{
			//Discarded unreachable code: IL_001b
			//IL_001a: Expected O, but got I4
			Gameloft.FileSystem.Abstraction.IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return ((IEnumerable<>)num).ToArray<string>();
		}

		[Cpp2IlInjected.Token(Token = "0x600210B")]
		[Cpp2IlInjected.Address(RVA = "0xBB5760", Offset = "0xBB4160", VA = "0x180BB5760", Slot = "5")]
		public string ReadAllText(string path)
		{
			return FileSystem.Data.ReadAllText(path);
		}

		[Cpp2IlInjected.Token(Token = "0x600210C")]
		[Cpp2IlInjected.Address(RVA = "0xBB57F0", Offset = "0xBB41F0", VA = "0x180BB57F0", Slot = "6")]
		public void WriteAllText(string path, string text)
		{
			//Discarded unreachable code: IL_0030
			if ((object)typeof(Path).TypeHandle == null)
			{
				Gameloft.FileSystem.Abstraction.IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				string directoryName = Path.GetDirectoryName(path);
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
			FileSystem.Data.WriteAllText(path, text);
		}

		[Cpp2IlInjected.Token(Token = "0x600210D")]
		[Cpp2IlInjected.Address(RVA = "0xBB5480", Offset = "0xBB3E80", VA = "0x180BB5480", Slot = "8")]
		public void Delete(string path)
		{
			//Discarded unreachable code: IL_001d
			Gameloft.FileSystem.Abstraction.IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			uint recursive = default(uint);
			_003CData_003Ek__BackingField.DeleteDirectory(path, (byte)recursive != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600210E")]
		[Cpp2IlInjected.Address(RVA = "0xBB5350", Offset = "0xBB3D50", VA = "0x180BB5350")]
		private void CreateDirectory(string path)
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			if ((object)typeof(Path).TypeHandle == null)
			{
				Gameloft.FileSystem.Abstraction.IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				string directoryName = Path.GetDirectoryName(path);
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600210F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LocalizationFileSystem()
		{
		}
	}
}
