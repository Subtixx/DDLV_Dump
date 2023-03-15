using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Mdl.Utils;
using Meta.Social;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AB7")]
	public static class FileSync
	{
		[Cpp2IlInjected.Token(Token = "0x6005D0A")]
		[Cpp2IlInjected.Address(RVA = "0x17FCA00", Offset = "0x17FB400", VA = "0x1817FCA00")]
		public static List<FileDesc> GatherClientFiles()
		{
			//Discarded unreachable code: IL_0078, IL_007e, IL_0084, IL_008a, IL_0090, IL_0096
			//IL_0026: Expected O, but got I4
			int num = 0;
			List<FileDesc> list = (List<FileDesc>)(object)new List<T>();
			IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			if ("*" != null)
			{
				bool flag = default(bool);
				while (flag)
				{
				}
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				byte[] array = LocalizationProtoBufTableProvider.GetBinaryLocalizationFs((CultureInfo)0).ReadAllBytes("*");
				FileDesc fileDesc = new FileDesc();
				fileDesc.Path = "*";
				uint num2 = (fileDesc.crc32_ = Crc32.ComputeChecksum(array));
				int num3 = (fileDesc.size_ = array.Length);
				((List<T>)(object)list).Add((T)fileDesc);
			}
			string text = default(string);
			if (text != null)
			{
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D0B")]
		[Cpp2IlInjected.Address(RVA = "0x17FCD20", Offset = "0x17FB720", VA = "0x1817FCD20")]
		private static string MakeRelative(string root, string f)
		{
			//Discarded unreachable code: IL_0022
			return f.Replace(root, "").Substring(1).Replace("\\", "/");
		}

		[Cpp2IlInjected.Token(Token = "0x6005D0C")]
		[Cpp2IlInjected.Address(RVA = "0x17FC3B0", Offset = "0x17FADB0", VA = "0x1817FC3B0")]
		public static List<FileDesc> CompareWithServerFiles(List<FileDesc> clientFileDescriptors)
		{
			//Discarded unreachable code: IL_00fa, IL_0100, IL_0106, IL_010c, IL_0112, IL_0118, IL_011e, IL_0124, IL_012a, IL_0130, IL_013c
			//IL_004f: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_00e9: Expected I4, but got I8
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			byte[] array = default(byte[]);
			FileDesc fileDesc = default(FileDesc);
			string text = default(string);
			bool flag4 = default(bool);
			FileDesc fileDesc3 = default(FileDesc);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				List<FileDesc> list = (List<FileDesc>)(object)new List<T>();
				IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				if ("*.json" != null)
				{
					_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
					CS_0024_003C_003E8__locals0.f = (string)(object)CS_0024_003C_003E8__locals0;
					while (flag)
					{
					}
					while (flag2)
					{
					}
					while (flag3)
					{
					}
					Func<FileDesc, bool> func = (Func<FileDesc, bool>)(object)(Func<T, TResult>)delegate(FileDesc x)
					{
						//Discarded unreachable code: IL_0014
						string f = CS_0024_003C_003E8__locals0.f;
						return string.Equals(x.path_, f);
					};
					IFileSystem binaryLocalizationFs = LocalizationProtoBufTableProvider.GetBinaryLocalizationFs((CultureInfo)0);
					uint num3 = Crc32.ComputeChecksum(array);
					if (fileDesc != null)
					{
						while (num3 == fileDesc.crc32_)
						{
						}
					}
					FileDesc fileDesc2 = new FileDesc();
					int num4 = 0;
					fileDesc2.Path = (string)num4;
					fileDesc2.crc32_ = num3;
					int num5 = (fileDesc2.size_ = array.Length);
					((List<T>)(object)list).Add((T)fileDesc2);
					while (fileDesc == null)
					{
					}
				}
				if (text != null)
				{
				}
				if (num2 != 0)
				{
					break;
				}
				if (flag4)
				{
					fileDesc3.path_ = "";
					string text2 = (fileDesc3.path_ = ProtoPreconditions.CheckNotNull((string)num2, "value"));
					fileDesc3.size_ = -1;
					((List<T>)(object)list).Add((T)fileDesc3);
				}
				if (num2 == 0)
				{
					return list;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D0D")]
		[Cpp2IlInjected.Address(RVA = "0x17FC2B0", Offset = "0x17FACB0", VA = "0x1817FC2B0")]
		[AsyncStateMachine(typeof(_003CApplyFileDiffAsync_003Ed__3))]
		public static Task ApplyFileDiffAsync(IEnumerable<FileDesc> diff)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
