using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.FileSystem;
using Gameloft.FileSystem.Abstraction;
using Gameloft.Localization.Core;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000773")]
	public class LocalizationProtoBufTableProvider : ITableProvider
	{
		[Cpp2IlInjected.Token(Token = "0x2000774")]
		public class FluxBinaryTableExport
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002ADE")]
			private ITableProvider provider;

			[Cpp2IlInjected.Token(Token = "0x600211F")]
			[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
			public FluxBinaryTableExport(ITableProvider provider)
			{
				this.provider = provider;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6002120")]
			[Cpp2IlInjected.Address(RVA = "0xF65410", Offset = "0xF63E10", VA = "0x180F65410")]
			public void ExportAllToBinary(Gameloft.FileSystem.Abstraction.IFileSystem fs, CultureInfo culture)
			{
				//Discarded unreachable code: IL_00aa, IL_00b0, IL_00b6, IL_00bc
				//IL_008a: Expected O, but got I4
				int num = 0;
				_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
				CS_0024_003C_003E8__locals0.culture = culture;
				CS_0024_003C_003E8__locals0.fs = fs;
				Dictionary<string, ProtoFluxStringTable> dictionary = (CS_0024_003C_003E8__locals0.mergedFolderTables = (Dictionary<string, ProtoFluxStringTable>)(object)new Dictionary<TKey, TValue>());
				ITableProvider tableProvider = provider;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				dictionary = (Dictionary<string, ProtoFluxStringTable>)(object)((object)dictionary + (object)dictionary);
				bool flag = default(bool);
				if (flag)
				{
					_003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass2_1();
					ITableProvider tableProvider2 = provider;
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					ProtoFluxStringTable protoTable = default(ProtoFluxStringTable);
					CS_0024_003C_003E8__locals1.protoTable = protoTable;
					uint num4 = default(uint);
					if (num < (int)num4)
					{
						num += num;
						num++;
					}
					Action<KeyValuePair<string, string>> action = (Action<KeyValuePair<string, string>>)(object)(Action<T>)delegate
					{
					};
					MoreLinq.ForEach<KeyValuePair<string, string>>((IEnumerable<>)num, (Action<>)(object)action);
				}
				Dictionary<string, ProtoFluxStringTable> mergedFolderTables = CS_0024_003C_003E8__locals0.mergedFolderTables;
				Action<KeyValuePair<string, ProtoFluxStringTable>> action2 = (Action<KeyValuePair<string, ProtoFluxStringTable>>)(object)(Action<T>)delegate
				{
				};
				MoreLinq.ForEach<KeyValuePair<string, ProtoFluxStringTable>>((IEnumerable<>)mergedFolderTables, (Action<>)(object)action2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000778")]
		internal class StringTable : IStringTable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002AE6")]
			internal ProtoFluxStringTable protoStringTable = new ProtoFluxStringTable();

			[Cpp2IlInjected.Token(Token = "0x170004A0")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002AE5")]
			internal string Name
			{
				[Cpp2IlInjected.Token(Token = "0x600212A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170004A1")]
			string IStringTable.Name
			{
				[Cpp2IlInjected.Token(Token = "0x600212B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
				get
				{
					return Name;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170004A2")]
			IEnumerable<KeyValuePair<string, string>> IStringTable.Strings
			{
				[Cpp2IlInjected.Token(Token = "0x600212C")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "5")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600212D")]
			[Cpp2IlInjected.Address(RVA = "0xF66370", Offset = "0xF64D70", VA = "0x180F66370", Slot = "6")]
			bool IStringTable.TryGetValue(string key, out string value)
			{
				//Discarded unreachable code: IL_00a2
				bool flag = default(bool);
				while (true)
				{
					MapField<string, string> strings_ = protoStringTable.strings_;
					if (flag)
					{
						break;
					}
					string[] array = new string[5];
					if ("LocError : Asked for key='" != null && array == null)
					{
						continue;
					}
					array[0] = "LocError : Asked for key='";
					if (key != null && array == null)
					{
						continue;
					}
					array[1] = key;
					if ("' in table='" != null && "' in table='" == null)
					{
						continue;
					}
					array[2] = "' in table='";
					string text = Name;
					if (text == null || "' in table='" != null)
					{
						array[3] = text;
						if ("' but it was not found" == null || "' but it was not found" != null)
						{
							array[4] = "' but it was not found";
							string text2 = string.Concat(array);
							break;
						}
					}
				}
				return flag;
			}

			[Cpp2IlInjected.Token(Token = "0x600212E")]
			[Cpp2IlInjected.Address(RVA = "0xF66770", Offset = "0xF65170", VA = "0x180F66770")]
			public StringTable(string name)
			{
				Name = name;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600212F")]
			[Cpp2IlInjected.Address(RVA = "0xF66680", Offset = "0xF65080", VA = "0x180F66680")]
			public void LoadFromBinary(byte[] bytes)
			{
				ProtoFluxStringTable protoFluxStringTable = (protoStringTable = (ProtoFluxStringTable)((MessageParser<T>)(object)ProtoFluxStringTable._parser).ParseFrom(bytes));
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002ADA")]
		private const string LOC_PATH = "Localization/";

		[Cpp2IlInjected.Token(Token = "0x4002ADB")]
		private const string FILE_EXT = "locbin";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002ADC")]
		private bool IsArchive;

		[Cpp2IlInjected.Token(Token = "0x1700049F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002ADD")]
		internal IReadOnlyFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6002116")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6002110")]
		[Cpp2IlInjected.Address(RVA = "0xBB83C0", Offset = "0xBB6DC0", VA = "0x180BB83C0")]
		public static string GetBaseLocPath(CultureInfo culture)
		{
			//Discarded unreachable code: IL_0013
			string name = culture.Name;
			return "Localization//" + name;
		}

		[Cpp2IlInjected.Token(Token = "0x6002111")]
		[Cpp2IlInjected.Address(RVA = "0xBB8420", Offset = "0xBB6E20", VA = "0x180BB8420")]
		public static string GetBinFilename(string tableName, CultureInfo culture, bool isArchive)
		{
			//Discarded unreachable code: IL_0033
			if (!isArchive)
			{
				string name = culture.Name;
				return string.Concat("Localization//" + name, "/", tableName, ".locbin");
			}
			return tableName + ".locbin";
		}

		[Cpp2IlInjected.Token(Token = "0x6002112")]
		[Cpp2IlInjected.Address(RVA = "0xBB8BD0", Offset = "0xBB75D0", VA = "0x180BB8BD0")]
		public static string GetZipFilename(CultureInfo culture)
		{
			//Discarded unreachable code: IL_0018
			string name = culture.Name;
			return "Localization//LocDB_" + name + ".zip";
		}

		[Cpp2IlInjected.Token(Token = "0x6002113")]
		[Cpp2IlInjected.Address(RVA = "0xBB8510", Offset = "0xBB6F10", VA = "0x180BB8510")]
		public static string GetGameCompiledDataFolder()
		{
			int num = 0;
			return Path.Combine(Directory.GetCurrentDirectory(), "Library", "MDLCompiledData");
		}

		[Cpp2IlInjected.Token(Token = "0x6002114")]
		[Cpp2IlInjected.Address(RVA = "0xBB8290", Offset = "0xBB6C90", VA = "0x180BB8290")]
		public static Gameloft.FileSystem.Abstraction.IFileSystem GetArchiveOrBinaryLocalizationFs(CultureInfo culture)
		{
			//IL_0038: Expected O, but got I4
			int num = 0;
			RuntimePlatform platform = Application.platform;
			Gameloft.FileSystem.Abstraction.IFileSystem _003CData_003Ek__BackingField = Definitions.Util.FileSystem.Data;
			string name = culture.Name;
			string text = "Localization//LocDB_" + name + ".zip";
			int num2 = 0;
			string path = default(string);
			SharpZipFileSystem sharpZipFileSystem = SharpZipFileSystem.FromArchive(path, "", (Gameloft.FileSystem.ILogger)num2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002115")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7B0", Offset = "0x7AC1B0", VA = "0x1807AD7B0")]
		public static Gameloft.FileSystem.Abstraction.IFileSystem GetBinaryLocalizationFs(CultureInfo culture)
		{
			return Definitions.Util.FileSystem.Data;
		}

		[Cpp2IlInjected.Token(Token = "0x6002117")]
		[Cpp2IlInjected.Address(RVA = "0xBB8C40", Offset = "0xBB7640", VA = "0x180BB8C40")]
		public LocalizationProtoBufTableProvider(IReadOnlyFileSystem fileSystem, bool isArchive)
		{
			FileSystem = fileSystem;
			IsArchive = isArchive;
		}

		[Cpp2IlInjected.Token(Token = "0x6002118")]
		[Cpp2IlInjected.Address(RVA = "0xBB8590", Offset = "0xBB6F90", VA = "0x180BB8590")]
		internal StringTable GetTable(string tableName, CultureInfo culture)
		{
			//Discarded unreachable code: IL_0174, IL_017a
			StringTable stringTable;
			string[] array2;
			while (true)
			{
				stringTable = new StringTable(tableName);
				if (!IsArchive)
				{
					string name = culture.Name;
					string text = "Localization//" + name;
					int num = 0;
					string text2 = text + "/" + tableName + ".locbin";
				}
				string text3 = tableName + ".locbin";
				byte[] bytes = FileSystem.ReadAllBytes(text3);
				stringTable.LoadFromBinary(bytes);
				int num2 = 0;
				string[] array = new string[0];
				if ("LocError : Asked to load table '" != null && "LocError : Asked to load table '" == null)
				{
					continue;
				}
				array[0] = "LocError : Asked to load table '";
				if ("LocError : Asked to load table '" == null || ("' but file='" != null && "' but file='" == null))
				{
					continue;
				}
				array[2] = "' but file='";
				if (text3 != null && "' but file='" == null)
				{
					continue;
				}
				array[3] = text3;
				if ("' was not deserializable" != null && "' was not deserializable" == null)
				{
					continue;
				}
				array2 = new string[5];
				if ("LocError : Asked to load table '" != null && "LocError : Asked to load table '" == null)
				{
					continue;
				}
				array2[0] = "LocError : Asked to load table '";
				if ("LocError : Asked to load table '" == null || ("' but file='" != null && "' but file='" == null))
				{
					continue;
				}
				array2[2] = "' but file='";
				if (text3 == null || "' but file='" != null)
				{
					array2[3] = text3;
					if ("' was not found" == null || "' was not found" != null)
					{
						break;
					}
				}
			}
			array2[4] = "' was not found";
			string text4 = string.Concat(array2);
			return stringTable;
		}

		[Cpp2IlInjected.Token(Token = "0x6002119")]
		[Cpp2IlInjected.Address(RVA = "0xBB8280", Offset = "0xBB6C80", VA = "0x180BB8280", Slot = "4")]
		IStringTable ITableProvider.GetTable(string tableName, CultureInfo culture)
		{
			StringTable table = GetTable(tableName, culture);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600211A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		void ITableProvider.SetJsonValue(LocId locId, CultureInfo culture, string newValue, string comment, string dId, string category, bool forceChangeDate)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600211B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		void ITableProvider.AddJsonValue(LocId locId, CultureInfo culture, string newValue, string comment, string dId, string category)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600211C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		void ITableProvider.RemoveJsonValue(LocId locId, CultureInfo culture)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600211D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "8")]
		List<string> ITableProvider.GetJsonFileNames()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600211E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
		List<string> ITableProvider.GetJsonLocIds(string tableName, CultureInfo culture)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
