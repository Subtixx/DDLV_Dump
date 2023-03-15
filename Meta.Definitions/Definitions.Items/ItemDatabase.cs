using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web;
using Cpp2IlInjected;
using Definitions.Options;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.FileSystem.Abstraction;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mdl.Log;
using Mdl.Utils;
using Serilog;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006AD")]
	public class ItemDatabase
	{
		[Cpp2IlInjected.Token(Token = "0x20006AE")]
		public enum ItemNameInvalidityReason
		{
			[Cpp2IlInjected.Token(Token = "0x4002262")]
			Empty,
			[Cpp2IlInjected.Token(Token = "0x4002263")]
			InvalidCharacters,
			[Cpp2IlInjected.Token(Token = "0x4002264")]
			ContainsSpaces,
			[Cpp2IlInjected.Token(Token = "0x4002265")]
			OnlyCasingChanged,
			[Cpp2IlInjected.Token(Token = "0x4002266")]
			AlreadyUsed,
			[Cpp2IlInjected.Token(Token = "0x4002267")]
			IsCategory,
			[Cpp2IlInjected.Token(Token = "0x4002268")]
			ItemListError
		}

		[Cpp2IlInjected.Token(Token = "0x20006AF")]
		private delegate(bool, string) ItemListOperationDelegate();

		[Cpp2IlInjected.Token(Token = "0x20006B0")]
		private static class GitController
		{
			[Cpp2IlInjected.Token(Token = "0x4002269")]
			public const string RemoteRepoAddressHTTPS = "https://git.gameloft.org/mtl_studio/games/my_disney_life/itemlist.git";

			[Cpp2IlInjected.Token(Token = "0x400226A")]
			public const string RemoteRepoAddressSSH = "git@git.gameloft.org:mtl_studio/games/my_disney_life/itemlist.git";

			[Cpp2IlInjected.Token(Token = "0x6004B57")]
			[Cpp2IlInjected.Address(RVA = "0x8EE130", Offset = "0x8ECB30", VA = "0x1808EE130")]
			public unsafe static bool Clone(string folderPath)
			{
				//Discarded unreachable code: IL_002c
				int num = 0;
				string itemListRepoAddress = GetItemListRepoAddress();
				int num2 = 0;
				string arguments = "clone " + itemListRepoAddress + " " + folderPath;
				int noTraceOnError = 0;
				return Git(arguments, out *(string*)num2, (byte)noTraceOnError != 0) == 0;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B58")]
			[Cpp2IlInjected.Address(RVA = "0x8F0130", Offset = "0x8EEB30", VA = "0x1808F0130")]
			public static bool Update(string folderPath, [System.Runtime.InteropServices.Optional] string sha1)
			{
				int num = default(int);
				int num2 = default(int);
				while (true)
				{
					string text = Path.Combine(folderPath, ".git");
					string[] array = new string[5];
					if ("--git-dir=" != null && array == null)
					{
						continue;
					}
					array[0] = "--git-dir=";
					if (text != null && array == null)
					{
						continue;
					}
					array[1] = text;
					if (" --work-tree=" != null && " --work-tree=" == null)
					{
						continue;
					}
					array[2] = " --work-tree=";
					if (folderPath != null && " --work-tree=" == null)
					{
						continue;
					}
					array[3] = folderPath;
					if (" fetch" != null && " fetch" == null)
					{
						continue;
					}
					array[4] = " fetch";
					string text2 = string.Concat(array);
					if (num != 0)
					{
						break;
					}
					string[] array2 = new string[0];
					if ("--git-dir=" != null && "--git-dir=" == null)
					{
						continue;
					}
					array2[0] = "--git-dir=";
					if (text != null && "--git-dir=" == null)
					{
						continue;
					}
					array2[1] = text;
					if (" --work-tree=" != null && " --work-tree=" == null)
					{
						continue;
					}
					array2[2] = " --work-tree=";
					if (folderPath != null && " --work-tree=" == null)
					{
						continue;
					}
					array2[3] = folderPath;
					if (" reset --hard " == null || " reset --hard " != null)
					{
						array2[4] = " reset --hard ";
						if (sha1 == null || " reset --hard " != null)
						{
							array2[5] = sha1;
							string text3 = string.Concat(array2);
							return num2 == 0;
						}
					}
				}
				return true;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B59")]
			[Cpp2IlInjected.Address(RVA = "0x8EE200", Offset = "0x8ECC00", VA = "0x1808EE200")]
			public unsafe static bool CommitAndPush(string folderPath, string commitMessage)
			{
				while (true)
				{
					string text = Path.Combine(folderPath, ".git");
					string[] array = new string[7];
					if ("--git-dir=" != null && array == null)
					{
						continue;
					}
					array[0] = "--git-dir=";
					if (text != null && array == null)
					{
						continue;
					}
					array[1] = text;
					if (" --work-tree=" != null && " --work-tree=" == null)
					{
						continue;
					}
					array[2] = " --work-tree=";
					if (folderPath != null && " --work-tree=" == null)
					{
						continue;
					}
					array[3] = folderPath;
					if (" commit -a -m \"" != null && " commit -a -m \"" == null)
					{
						continue;
					}
					array[4] = " commit -a -m \"";
					if (commitMessage != null && " commit -a -m \"" == null)
					{
						continue;
					}
					array[5] = commitMessage;
					if ("\"" != null && "\"" == null)
					{
						continue;
					}
					array[6] = "\"";
					int num = 0;
					string arguments = string.Concat(array);
					int noTraceOnError = 0;
					if (Git(arguments, out *(string*)num, (byte)noTraceOnError != 0) != 0)
					{
						break;
					}
					string[] array2 = new string[0];
					if ("--git-dir=" != null && "--git-dir=" == null)
					{
						continue;
					}
					array2[0] = "--git-dir=";
					if (text != null && "--git-dir=" == null)
					{
						continue;
					}
					array2[1] = text;
					if (" --work-tree=" != null && " --work-tree=" == null)
					{
						continue;
					}
					array2[2] = " --work-tree=";
					if (folderPath == null || " --work-tree=" != null)
					{
						array2[3] = folderPath;
						if (" push" == null || " push" != null)
						{
							array2[4] = " push";
							string arguments2 = string.Concat(array2);
							int noTraceOnError2 = 0;
							return Git(arguments2, out *(string*)num, (byte)noTraceOnError2 != 0) == 0;
						}
					}
				}
				return true;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B5A")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDF0", Offset = "0x8EC7F0", VA = "0x1808EDDF0")]
			public static bool CheckConnectionMethod(string folderPath)
			{
				//Discarded unreachable code: IL_00b7
				string itemListRepoAddress;
				string[] array;
				while (true)
				{
					int num = 0;
					itemListRepoAddress = GetItemListRepoAddress();
					string text = Path.Combine(folderPath, ".git");
					array = new string[6];
					if ("--git-dir=" != null && array == null)
					{
						continue;
					}
					array[0] = "--git-dir=";
					if (text != null && array == null)
					{
						continue;
					}
					array[1] = text;
					if (" --work-tree=" != null && " --work-tree=" == null)
					{
						continue;
					}
					array[2] = " --work-tree=";
					if (folderPath != null && " --work-tree=" == null)
					{
						continue;
					}
					array[3] = folderPath;
					if (" remote set-url origin " == null || " remote set-url origin " != null)
					{
						array[4] = " remote set-url origin ";
						if (itemListRepoAddress == null || " remote set-url origin " != null)
						{
							break;
						}
					}
				}
				array[5] = itemListRepoAddress;
				string text2 = string.Concat(array);
				int num2 = default(int);
				return num2 == 0;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B5B")]
			[Cpp2IlInjected.Address(RVA = "0x8EEB70", Offset = "0x8ED570", VA = "0x1808EEB70")]
			public static string GetCurrentCommitSHA(string folderPath)
			{
				string[] array;
				while (true)
				{
					string text = Path.Combine(folderPath, ".git");
					array = new string[5];
					if ("--git-dir=" != null && array == null)
					{
						continue;
					}
					array[0] = "--git-dir=";
					if (text != null && array == null)
					{
						continue;
					}
					array[1] = text;
					if (" --work-tree=" != null && " --work-tree=" == null)
					{
						continue;
					}
					array[2] = " --work-tree=";
					if (folderPath == null || " --work-tree=" != null)
					{
						array[3] = folderPath;
						if (" rev-parse HEAD" == null || " rev-parse HEAD" != null)
						{
							break;
						}
					}
				}
				array[4] = " rev-parse HEAD";
				string text2 = string.Concat(array);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6004B5C")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAF0", Offset = "0x8EE4F0", VA = "0x1808EFAF0")]
			public unsafe static string Log(string folderPath, string parameters)
			{
				int num;
				string[] array;
				while (true)
				{
					num = 0;
					string text = Path.Combine(folderPath, ".git");
					array = new string[6];
					if ("--git-dir=" != null && array == null)
					{
						continue;
					}
					array[0] = "--git-dir=";
					if (text != null && array == null)
					{
						continue;
					}
					array[1] = text;
					if (" --work-tree=" != null && " --work-tree=" == null)
					{
						continue;
					}
					array[2] = " --work-tree=";
					if (folderPath != null && " --work-tree=" == null)
					{
						continue;
					}
					array[3] = folderPath;
					if (" log " == null || " log " != null)
					{
						array[4] = " log ";
						if (parameters == null || " log " != null)
						{
							break;
						}
					}
				}
				array[5] = parameters;
				string arguments = string.Concat(array);
				int noTraceOnError = 0;
				int num2 = Git(arguments, out *(string*)num, (byte)noTraceOnError != 0);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6004B5D")]
			[Cpp2IlInjected.Address(RVA = "0x8EE830", Offset = "0x8ED230", VA = "0x1808EE830")]
			public unsafe static string Config(string folderPath, string parameters)
			{
				int num;
				string[] array;
				while (true)
				{
					num = 0;
					string text = Path.Combine(folderPath, ".git");
					array = new string[6];
					if ("--git-dir=" != null && array == null)
					{
						continue;
					}
					array[0] = "--git-dir=";
					if (text != null && array == null)
					{
						continue;
					}
					array[1] = text;
					if (" --work-tree=" != null && " --work-tree=" == null)
					{
						continue;
					}
					array[2] = " --work-tree=";
					if (folderPath != null && " --work-tree=" == null)
					{
						continue;
					}
					array[3] = folderPath;
					if (" config " == null || " config " != null)
					{
						array[4] = " config ";
						if (parameters == null || " config " != null)
						{
							break;
						}
					}
				}
				array[5] = parameters;
				string arguments = string.Concat(array);
				int noTraceOnError = 0;
				int num2 = Git(arguments, out *(string*)num, (byte)noTraceOnError != 0);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6004B5E")]
			[Cpp2IlInjected.Address(RVA = "0x8EFA60", Offset = "0x8EE460", VA = "0x1808EFA60")]
			private static int Git(string arguments)
			{
				int result = default(int);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B5F")]
			[Cpp2IlInjected.Address(RVA = "0x8EF240", Offset = "0x8EDC40", VA = "0x1808EF240")]
			private static int Git(string arguments, out string output, bool noTraceOnError = false)
			{
				//Discarded unreachable code: IL_020b, IL_0211, IL_0217, IL_021d, IL_0223, IL_0229, IL_022f, IL_0235, IL_023b, IL_0241, IL_0247, IL_024d
				int useShellExecute = 0;
				Process process = new Process();
				_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
				process.StartInfo.fileName = "git";
				process.StartInfo.arguments = arguments;
				process.StartInfo.useShellExecute = (byte)useShellExecute != 0;
				process.StartInfo.redirectStandardOutput = true;
				process.StartInfo.redirectStandardError = true;
				process.StartInfo.createNoWindow = true;
				string text = (CS_0024_003C_003E8__locals0.stdOut = string.Empty);
				string text2 = (CS_0024_003C_003E8__locals0.stdErr = string.Empty);
				DataReceivedEventHandler value = delegate
				{
				};
				process.OutputDataReceived += value;
				DataReceivedEventHandler value2 = delegate
				{
				};
				process.ErrorDataReceived += value2;
				bool flag = process.Start();
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();
				process.WaitForExit();
				int exitCode = process.ExitCode;
				if (exitCode != 0 && !noTraceOnError && (exitCode == 0 || !string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.stdErr)))
				{
					string[] array = new string[6];
					if ("ItemList Git : Error with command git " != null && "ItemList Git : Error with command git " == null)
					{
						throw new IndexOutOfRangeException();
					}
					array[0] = "ItemList Git : Error with command git ";
					string arguments2 = process.StartInfo.Arguments;
					if (arguments2 != null && arguments2 == null)
					{
						throw new IndexOutOfRangeException();
					}
					array[1] = arguments2;
					if (" : \nOutput:" != null && " : \nOutput:" == null)
					{
						throw new IndexOutOfRangeException();
					}
					array[2] = " : \nOutput:";
					if (arguments2 != null && " : \nOutput:" == null)
					{
						throw new IndexOutOfRangeException();
					}
					array[3] = arguments2;
					if ("\nError:" != null && "\nError:" == null)
					{
						throw new IndexOutOfRangeException();
					}
					array[4] = "\nError:";
					string text3 = string.Concat(array);
				}
				int num = 0;
				if (process != null)
				{
				}
				uint num2 = default(uint);
				if (num2 != 0)
				{
				}
				int num3 = 0;
				ILogger _003CLog_003Ek__BackingField = Log;
				string text4 = default(string);
				string text5 = "Exception while calling Git:\n" + text4 + "\n";
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					num3++;
				}
				text5 += text5;
				uint num5 = num5 + 744;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6004B60")]
			[Cpp2IlInjected.Address(RVA = "0x8EFE30", Offset = "0x8EE830", VA = "0x1808EFE30")]
			private static bool TryGetUserNamePassword(out string userName, out string password)
			{
				int num = 0;
				string[] commandLineArgs = Environment.GetCommandLineArgs();
				if (_003C_003Ec._003C_003E9__11_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((string x) => default(bool));
				}
				if (_003C_003Ec._003C_003E9__11_1 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((string x) => default(bool));
				}
				int num2 = default(int);
				int num3 = default(int);
				if (num2 != -1 && num3 != -1)
				{
					num3 = num2 + 1;
					string text = commandLineArgs[num3];
					bool flag = default(bool);
					if (!flag)
					{
					}
					int num4 = num3 + 1;
					string text2 = commandLineArgs[num4];
				}
				int num5 = 0;
				int num6 = 0;
				throw new IndexOutOfRangeException();
			}

			[Cpp2IlInjected.Token(Token = "0x6004B61")]
			[Cpp2IlInjected.Address(RVA = "0x8EFA90", Offset = "0x8EE490", VA = "0x1808EFA90")]
			private static bool HasSSHCredentials(string remoteUrl)
			{
				string text = "ls-remote " + remoteUrl;
				int num = default(int);
				return num == 0;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B62")]
			[Cpp2IlInjected.Address(RVA = "0x8EEE50", Offset = "0x8ED850", VA = "0x1808EEE50")]
			private unsafe static string GetItemListRepoAddress()
			{
				//IL_0054: Expected O, but got I4
				//IL_0098: Expected O, but got I4
				while (true)
				{
					int num = 0;
					if (Git("ls-remote " + "git@git.gameloft.org:mtl_studio/games/my_disney_life/itemlist.git", out *(string*)num, noTraceOnError: true) == 0)
					{
						break;
					}
					if (TryGetUserNamePassword(out *(string*)num, out *(string*)num))
					{
						string[] array = new string[5];
						if ("https://" != null && "https://" == null)
						{
							continue;
						}
						array[0] = "https://";
						string text = HttpUtility.UrlEncode((string)num);
						if (text != null && text == null)
						{
							continue;
						}
						array[1] = text;
						if (":" != null && ":" == null)
						{
							continue;
						}
						array[2] = ":";
						if (num != 0 && ":" == null)
						{
							continue;
						}
						array[3] = (string)num;
						if ("@" != null && "@" == null)
						{
							continue;
						}
						array[4] = "@";
						string text2 = string.Concat(array);
					}
					if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
					{
						return "'" + "https://git.gameloft.org/mtl_studio/games/my_disney_life/itemlist.git" + "'";
					}
				}
				return "git@git.gameloft.org:mtl_studio/games/my_disney_life/itemlist.git";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20006B3")]
		public abstract class ItemTypeMetaInfo
		{
			[Cpp2IlInjected.Token(Token = "0x20006B4")]
			public delegate GenericEnum GetSubTypeDelegate(Item item);

			[Cpp2IlInjected.Token(Token = "0x4002274")]
			private static Dictionary<(ItemType, GenericEnum), ItemTypeMetaInfo> itemTypeMetaInfos;

			[Cpp2IlInjected.Token(Token = "0x1700138F")]
			public abstract Type ProtobufClassType
			{
				[Cpp2IlInjected.Token(Token = "0x6004B6A")]
				[Cpp2IlInjected.Address(Slot = "4")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17001390")]
			public abstract MessageDescriptor ProtobufClassMessageDescriptor
			{
				[Cpp2IlInjected.Token(Token = "0x6004B6B")]
				[Cpp2IlInjected.Address(Slot = "5")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17001391")]
			public MessageParser ProtobufClassMessageParser
			{
				[Cpp2IlInjected.Token(Token = "0x6004B6C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CProtobufClassMessageParser_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6004B6D")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				private set
				{
					_003CProtobufClassMessageParser_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001392")]
			public Type SubItemType
			{
				[Cpp2IlInjected.Token(Token = "0x6004B6E")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CSubItemType_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6004B6F")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				private set
				{
					_003CSubItemType_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001393")]
			public Type SubTypeEnumType
			{
				[Cpp2IlInjected.Token(Token = "0x6004B70")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CSubTypeEnumType_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6004B71")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				private set
				{
					_003CSubTypeEnumType_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001394")]
			public GetSubTypeDelegate GetSubType
			{
				[Cpp2IlInjected.Token(Token = "0x6004B72")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CGetSubType_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6004B73")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				private set
				{
					_003CGetSubType_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001395")]
			public static IEnumerable<KeyValuePair<(ItemType, GenericEnum), ItemTypeMetaInfo>> MetaInfos
			{
				[Cpp2IlInjected.Token(Token = "0x6004B79")]
				[Cpp2IlInjected.Address(RVA = "0x8FB310", Offset = "0x8F9D10", VA = "0x1808FB310")]
				get
				{
					Dictionary<(ItemType, GenericEnum), ItemTypeMetaInfo> dictionary = itemTypeMetaInfos;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6004B74")]
			[Cpp2IlInjected.Address(RVA = "0x8F0C90", Offset = "0x8EF690", VA = "0x1808F0C90")]
			public static ItemTypeMetaInfo GetItemTypeMetaInfo(ItemType itemType, [System.Runtime.InteropServices.Optional] Enum subType)
			{
				if (subType != null)
				{
				}
				int num = 0;
				ItemTypeMetaInfo result = default(ItemTypeMetaInfo);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B75")]
			[Cpp2IlInjected.Address(RVA = "0x8F0AF0", Offset = "0x8EF4F0", VA = "0x1808F0AF0")]
			public static ItemTypeMetaInfo GetItemTypeMetaInfo(ItemType itemType, GenericEnum subType)
			{
				Dictionary<(ItemType, GenericEnum), ItemTypeMetaInfo> dictionary = itemTypeMetaInfos;
				bool flag = default(bool);
				if (!flag)
				{
					Dictionary<(ItemType, GenericEnum), ItemTypeMetaInfo> dictionary2 = itemTypeMetaInfos;
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6004B76")]
			[Cpp2IlInjected.Address(RVA = "0x8F0D20", Offset = "0x8EF720", VA = "0x1808F0D20")]
			public static bool TryGetItemTypeMetaInfo(ItemType type, out ItemTypeMetaInfo info)
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B77")]
			[Cpp2IlInjected.Address(RVA = "0x8F0EF0", Offset = "0x8EF8F0", VA = "0x1808F0EF0")]
			public static bool TryGetItemTypeMetaInfo(ItemType type, GenericEnum subType, out ItemTypeMetaInfo info)
			{
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B78")]
			[Cpp2IlInjected.Address(RVA = "0x8F0DF0", Offset = "0x8EF7F0", VA = "0x1808F0DF0")]
			public static bool TryGetItemTypeMetaInfo(ItemType type, Enum subType, out ItemTypeMetaInfo info)
			{
				if (subType != null)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B7A")]
			[Cpp2IlInjected.Address(RVA = "0x8F1010", Offset = "0x8EFA10", VA = "0x1808F1010")]
			static ItemTypeMetaInfo()
			{
				ItemTypeComparer itemTypeComparer = new ItemTypeComparer();
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6004B7B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected ItemTypeMetaInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20006B6")]
		private class ItemTypeMetaInfo<T> : ItemTypeMetaInfo where T : IItemData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002276")]
			private MessageDescriptor _protobufClassMessageDescriptor;

			[Cpp2IlInjected.Token(Token = "0x17001396")]
			public override Type ProtobufClassType
			{
				[Cpp2IlInjected.Token(Token = "0x6004BD4")]
				[Cpp2IlInjected.Address(RVA = "0x265BE80", Offset = "0x265A880", VA = "0x18265BE80", Slot = "4")]
				get
				{
					Type result = default(Type);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17001397")]
			public override MessageDescriptor ProtobufClassMessageDescriptor
			{
				[Cpp2IlInjected.Token(Token = "0x6004BD5")]
				[Cpp2IlInjected.Address(RVA = "0x265BD20", Offset = "0x265A720", VA = "0x18265BD20", Slot = "5")]
				get
				{
					//Discarded unreachable code: IL_0015
					if ((object)typeof(Type).TypeHandle == null)
					{
						Type type = default(Type);
						string name = type.Name;
					}
					return (MessageDescriptor)typeof(Type).TypeHandle;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6004BD6")]
			[Cpp2IlInjected.Address(RVA = "0x265BCC0", Offset = "0x265A6C0", VA = "0x18265BCC0")]
			public ItemTypeMetaInfo()
			{
				//Discarded unreachable code: IL_0007
				((glPlayFab.Disney.BattlePassReward)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20006B7")]
		private class ItemTypeComparer : IEqualityComparer<(ItemType, GenericEnum)>
		{
			[Cpp2IlInjected.Token(Token = "0x6004BD7")]
			[Cpp2IlInjected.Address(RVA = "0x8F0A40", Offset = "0x8EF440", VA = "0x1808F0A40", Slot = "4")]
			public bool Equals((ItemType itemType, GenericEnum subType) x, (ItemType itemType, GenericEnum subType) y)
			{
				int num = 0;
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6004BD8")]
			[Cpp2IlInjected.Address(RVA = "0x8F0AB0", Offset = "0x8EF4B0", VA = "0x1808F0AB0", Slot = "5")]
			public int GetHashCode((ItemType itemType, GenericEnum subType) obj)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6004BD9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ItemTypeComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002253")]
		public static bool DisableGit = (byte)(int)Serilogger.Create<ItemDatabase>() != 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002259")]
		private readonly ConcurrentDictionary<Item, IItemData> allItems = (ConcurrentDictionary<Item, IItemData>)(object)new ConcurrentDictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400225A")]
		private readonly ConcurrentDictionary<string, Item> allItemsByName = (ConcurrentDictionary<string, Item>)(object)new ConcurrentDictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400225B")]
		private readonly Dictionary<ItemType, ItemList> itemLists = (Dictionary<ItemType, ItemList>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400225C")]
		public readonly ItemType[] OnlineItemTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400225D")]
		private readonly bool isEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400225E")]
		private readonly Dictionary<(ItemType, Enum, Type), Array> cachedSearchs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002260")]
		private Dictionary<Item, int> RequiredLevelCache;

		[Cpp2IlInjected.Token(Token = "0x1700138B")]
		[field: Cpp2IlInjected.Token(Token = "0x4002258")]
		private static ILogger Log
		{
			[Cpp2IlInjected.Token(Token = "0x6004B31")]
			[Cpp2IlInjected.Address(RVA = "0x22D6E20", Offset = "0x22D5820", VA = "0x1822D6E20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700138C")]
		public IEnumerable<IItemData> AllItemsData
		{
			[Cpp2IlInjected.Token(Token = "0x6004B39")]
			[Cpp2IlInjected.Address(RVA = "0x22D6B20", Offset = "0x22D5520", VA = "0x1822D6B20")]
			get
			{
				//Discarded unreachable code: IL_0033
				ICollection<IItemData> values = (ICollection<IItemData>)((ConcurrentDictionary<TKey, TValue>)(object)allItems).get_Values();
				Func<IItemData, bool> _003C_003E9__69_ = _003C_003Ec._003C_003E9__69_0;
				if (_003C_003E9__69_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IItemData x) => x != null);
				}
				return (IEnumerable<IItemData>)Enumerable.Where<IItemData>((IEnumerable<>)values, (Func<, >)(object)_003C_003E9__69_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700138D")]
		public IEnumerable<ITagData> AllTagsData
		{
			[Cpp2IlInjected.Token(Token = "0x6004B3A")]
			[Cpp2IlInjected.Address(RVA = "0x22D6C80", Offset = "0x22D5680", VA = "0x1822D6C80")]
			get
			{
				Func<IItemData, ITagData> _003C_003E9__71_ = _003C_003Ec._003C_003E9__71_0;
				if (_003C_003E9__71_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				IEnumerable<IItemData> enumerable = default(IEnumerable<IItemData>);
				return (IEnumerable<ITagData>)Enumerable.Select<IItemData, ITagData>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__71_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700138E")]
		public static ItemDatabase Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6004B48")]
			[Cpp2IlInjected.Address(RVA = "0x22D6DC0", Offset = "0x22D57C0", VA = "0x1822D6DC0")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004B49")]
			[Cpp2IlInjected.Address(RVA = "0x22D7100", Offset = "0x22D5B00", VA = "0x1822D7100")]
			[CompilerGenerated]
			private set
			{
				//IL_0006: Expected I4, but got O
				DisableGit = (byte)(int)value != 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EventHandler<Item> ItemAddedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6004B09")]
			[Cpp2IlInjected.Address(RVA = "0x22D68A0", Offset = "0x22D52A0", VA = "0x1822D68A0")]
			[CompilerGenerated]
			add
			{
				EventHandler<Item> itemAddedEvent = this.ItemAddedEvent;
				Delegate @delegate = Delegate.Combine(itemAddedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != itemAddedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004B0A")]
			[Cpp2IlInjected.Address(RVA = "0x22D6E80", Offset = "0x22D5880", VA = "0x1822D6E80")]
			[CompilerGenerated]
			remove
			{
				EventHandler<Item> itemAddedEvent = this.ItemAddedEvent;
				Delegate @delegate = Delegate.Remove(itemAddedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != itemAddedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EventHandler<Item> ItemEditedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6004B0B")]
			[Cpp2IlInjected.Address(RVA = "0x22D6940", Offset = "0x22D5340", VA = "0x1822D6940")]
			[CompilerGenerated]
			add
			{
				EventHandler<Item> itemEditedEvent = this.ItemEditedEvent;
				Delegate @delegate = Delegate.Combine(itemEditedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != itemEditedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004B0C")]
			[Cpp2IlInjected.Address(RVA = "0x22D6F20", Offset = "0x22D5920", VA = "0x1822D6F20")]
			[CompilerGenerated]
			remove
			{
				EventHandler<Item> itemEditedEvent = this.ItemEditedEvent;
				Delegate @delegate = Delegate.Remove(itemEditedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != itemEditedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EventHandler<Item> ItemRemovedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6004B0D")]
			[Cpp2IlInjected.Address(RVA = "0x22D69E0", Offset = "0x22D53E0", VA = "0x1822D69E0")]
			[CompilerGenerated]
			add
			{
				EventHandler<Item> itemRemovedEvent = this.ItemRemovedEvent;
				Delegate @delegate = Delegate.Combine(itemRemovedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != itemRemovedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004B0E")]
			[Cpp2IlInjected.Address(RVA = "0x22D6FC0", Offset = "0x22D59C0", VA = "0x1822D6FC0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<Item> itemRemovedEvent = this.ItemRemovedEvent;
				Delegate @delegate = Delegate.Remove(itemRemovedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != itemRemovedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event EventHandler<Item> ItemSavedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6004B0F")]
			[Cpp2IlInjected.Address(RVA = "0x22D6A80", Offset = "0x22D5480", VA = "0x1822D6A80")]
			[CompilerGenerated]
			add
			{
				EventHandler<Item> itemSavedEvent = this.ItemSavedEvent;
				Delegate @delegate = Delegate.Combine(itemSavedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != itemSavedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004B10")]
			[Cpp2IlInjected.Address(RVA = "0x22D7060", Offset = "0x22D5A60", VA = "0x1822D7060")]
			[CompilerGenerated]
			remove
			{
				EventHandler<Item> itemSavedEvent = this.ItemSavedEvent;
				Delegate @delegate = Delegate.Remove(itemSavedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != itemSavedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B08")]
		[Cpp2IlInjected.Address(RVA = "0x22D0A20", Offset = "0x22CF420", VA = "0x1822D0A20")]
		public unsafe void ExportForBuild(IFileSystem outputFileSystem, HashSet<string> handledFiles, SemVer version)
		{
			//Discarded unreachable code: IL_0091, IL_0097, IL_009d, IL_00a9, IL_00af, IL_00b5, IL_00bb, IL_00c1, IL_00c7, IL_00cd, IL_00d3, IL_00d9, IL_00df
			//IL_007d: Expected O, but got I4
			bool flag = default(bool);
			ICollection<> cpp2il__autoParamName__idx_ = default(ICollection<>);
			IItemData itemData = default(IItemData);
			bool flag2 = default(bool);
			string item = default(string);
			string item2 = default(string);
			EnumValueDescriptor enumValueDescriptor = default(EnumValueDescriptor);
			EnumDescriptor enumDescriptor = default(EnumDescriptor);
			while (true)
			{
				int num = 0;
				Dictionary<ItemType, ItemList> dictionary = itemLists;
				if (flag)
				{
					int[] array = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<int>();
					if (num < array.Length)
					{
						int num2 = array[num];
						if (itemData == null)
						{
							num++;
						}
						if (!flag2)
						{
							break;
						}
						bool flag3 = ((HashSet<T>)(object)handledFiles).Add((T)item);
						num++;
					}
					int num3 = 0;
					bool flag4 = ((HashSet<T>)(object)handledFiles).Add((T)item2);
					if (!enumValueDescriptor.CustomOptions.TryGetString(AllEnumValueOptions.ItemTypePreviousValue, ref *(string*)num))
					{
						continue;
					}
					string item3 = "itemlist/" + (string)num + ".json";
					bool flag5 = ((HashSet<T>)(object)handledFiles).Add((T)item3);
				}
				if (enumDescriptor == null)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B11")]
		[Cpp2IlInjected.Address(RVA = "0x22D4A00", Offset = "0x22D3400", VA = "0x1822D4A00")]
		public void SaveItem(Item item, IItemData itemData, bool binary = false, [System.Runtime.InteropServices.Optional] IFileSystem fileSystem)
		{
			//Discarded unreachable code: IL_0075
			//IL_005f: Expected I4, but got I8
			//IL_005f: Expected O, but got I4
			ConcurrentDictionary<Item, IItemData> concurrentDictionary = allItems;
			Func<Item, IItemData, IItemData> func = (Func<Item, IItemData, IItemData>)(object)(Func<T1, T2, TResult>)((Item x, IItemData y) => itemData);
			((Dictionary<TKey, TValue>)(object)cachedSearchs).Clear();
			string path = default(string);
			string directoryName = Path.GetDirectoryName(path);
			if (directoryName == null)
			{
			}
			string text = default(string);
			if (!binary)
			{
				int num = 0;
				if (directoryName == null)
				{
				}
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				int formatEnumAsIntegers = 0;
				int formatDefaultValues = 0;
				ulong num2 = default(ulong);
				text = ((IMessage)num).ToJSONString((byte)formatDefaultValues != 0, indented: true, (byte)formatEnumAsIntegers != 0, (int)num2);
			}
			if (text == null)
			{
			}
			if (text != null)
			{
				if (this.ItemSavedEvent == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B12")]
		[Cpp2IlInjected.Address(RVA = "0x22D0230", Offset = "0x22CEC30", VA = "0x1822D0230")]
		public Item CreateItem(ItemType itemType, string name, [System.Runtime.InteropServices.Optional] Enum subType, [System.Runtime.InteropServices.Optional] Item copyFrom)
		{
			ItemType itemType2 = itemType;
			bool flag = default(bool);
			if (flag)
			{
				Item item = Item.Invalid;
				string text = name;
				ILogger logger = Log;
				string text2 = "Item list operation : Creating item " + text;
				ItemType itemType3 = itemType;
				ItemListOperationDelegate itemListOperationDelegate = delegate
				{
					//IL_0021: Expected O, but got I4
					int num3 = 0;
					bool flag4 = default(bool);
					bool flag5 = default(bool);
					if (flag4 && flag5)
					{
						if (!flag5)
						{
						}
						ItemListDefinition itemListDefinition = new ItemListDefinition();
						int num4 = 0;
						itemListDefinition.Name = (string)num4;
						string name_ = itemListDefinition.name_;
						if (itemListDefinition == null)
						{
						}
						object[] array = new object[2];
						if (array != null && (array == null || array != null))
						{
							array[1] = array;
							object obj = default(object);
							if (obj != null)
							{
								int num5 = 0;
								goto IL_0058;
							}
						}
						throw new InvalidCastException();
					}
					goto IL_0058;
					IL_0058:
					int num6 = 0;
					int num7 = 0;
					int num8 = 0;
					throw new NullReferenceException();
				};
				bool flag2 = default(bool);
				if (flag2)
				{
					int num = 0;
					ItemTypeMetaInfo info = default(ItemTypeMetaInfo);
					Type protobufClassType = info.ProtobufClassType;
					Type type = default(Type);
					bool flag3 = ((object)type).Equals((object)protobufClassType);
					IMessage message = default(IMessage);
					if (!flag3 || !flag3)
					{
						message = info.ProtobufClassMessageParser.CreateTemplate();
						if (message == null)
						{
						}
						if (message == null)
						{
							throw new InvalidCastException();
						}
					}
					if (num != 0 || message != null)
					{
					}
					int num2 = 0;
					EventHandler<Item> itemAddedEvent = this.ItemAddedEvent;
					if (itemAddedEvent != null)
					{
						Item e = item;
						itemAddedEvent(this, (TEventArgs)e);
					}
					return item;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B13")]
		[Cpp2IlInjected.Address(RVA = "0x22D06D0", Offset = "0x22CF0D0", VA = "0x1822D06D0")]
		public bool EditItemDefinition(Item item, string name)
		{
			//Discarded unreachable code: IL_00d5
			//IL_001b: Expected O, but got I4
			//IL_002d: Expected O, but got I8
			//IL_0034: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			int num = 0;
			string previousName = (string)0;
			IItemData itemData = GetItemData((Item)num);
			string text = name;
			ILogger logger = Log;
			string text2 = "Item list operation : Editing item " + text;
			ItemListOperationDelegate itemListOperationDelegate = delegate
			{
				//IL_0011: Expected O, but got I4
				//IL_0029: Expected O, but got I4
				//IL_0029: Expected O, but got I4
				//IL_0039: Expected O, but got I4
				//IL_0039: Expected O, but got I4
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				int num7 = default(int);
				ItemType itemType = default(ItemType);
				bool flag4 = default(bool);
				while (true)
				{
					int num4 = 0;
					if (!flag2 || ("Edited item (Item Type : {0} / Name : {1})" != (string)num4 && !flag3))
					{
						int num5 = 0;
						int num6 = 0;
						num7 = 0;
					}
					if ((string)num4 != (string)num7)
					{
					}
					string text5 = $"Edited item (Item Type : {itemType} / Name : {num4})";
					if (!flag4)
					{
						break;
					}
					string[] array = new string[5];
					if (text5 == null || array != null)
					{
						array[0] = text5;
						if ("\nName : " == null || "\nName : " != null)
						{
							array[1] = "\nName : ";
							if (text5 == null || "\nName : " != null)
							{
								array[2] = text5;
								if (" -> " == null || " -> " != null)
								{
									array[3] = " -> ";
									if (" -> " != null)
									{
										string text6 = string.Concat(array);
										break;
									}
								}
							}
						}
					}
				}
				int num8 = 0;
				throw new NullReferenceException();
			};
			bool flag = default(bool);
			if (flag)
			{
				string text3 = name;
				if (previousName != text3)
				{
					string name2 = name;
					IItemDataEditorHelper.SetName(itemData, name2);
					int num2 = 0;
					IItemDataEditorHelper.SetDefaultDisplayName(itemData);
					string name3 = previousName;
					string itemDataPath = GetItemDataPath((Item)num2, name3);
					IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
					IFileSystem _003CData_003Ek__BackingField2 = FileSystem.Data;
					string text4 = itemDataPath + ".meta";
					int num3 = 0;
					if (this.ItemEditedEvent == null)
					{
					}
				}
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B14")]
		[Cpp2IlInjected.Address(RVA = "0x22D4460", Offset = "0x22D2E60", VA = "0x1822D4460")]
		public bool RemoveItem(Item item)
		{
			//Discarded unreachable code: IL_008d
			//IL_001b: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			string text = default(string);
			string itemName = text;
			string text2 = itemName;
			ILogger logger = Log;
			string text3 = "Item list operation : Removing item " + text2;
			ItemListOperationDelegate itemListOperationDelegate = delegate
			{
				//IL_001a: Expected O, but got I4
				//IL_001a: Expected O, but got I4
				int num = 0;
				bool flag2 = default(bool);
				if (!flag2)
				{
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
				}
				ItemType itemType = default(ItemType);
				string text6 = $"Deleted item (Item Type : {itemType} / Name : {num})";
				int num5 = 0;
				throw new NullReferenceException();
			};
			bool flag = default(bool);
			if (flag)
			{
				ConcurrentDictionary<Item, IItemData> concurrentDictionary = allItems;
				((Dictionary<TKey, TValue>)(object)cachedSearchs).Clear();
				IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				IFileSystem _003CData_003Ek__BackingField2 = FileSystem.Data;
				string text4 = default(string);
				string text5 = text4 + ".meta";
				if (this.ItemRemovedEvent == null)
				{
				}
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B15")]
		[Cpp2IlInjected.Address(RVA = "0x22D5EE0", Offset = "0x22D48E0", VA = "0x1822D5EE0")]
		public bool UnRemoveItem(Item item)
		{
			//IL_001b: Expected O, but got I4
			//IL_008b: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			IItemData itemData = default(IItemData);
			if (itemData != null)
			{
				Item item3 = item2;
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
					Item item4 = item2;
					string itemName = GetItemName(item4);
					bool flag2 = default(bool);
					if (flag2)
					{
						string text = itemName;
						string text2 = "Item list operation : UnRemoving item " + text;
						ItemListOperationDelegate itemListOperationDelegate = delegate
						{
							//IL_001a: Expected O, but got I4
							//IL_001a: Expected O, but got I4
							int num2 = 0;
							bool flag3 = default(bool);
							if (!flag3)
							{
								int num3 = 0;
								int num4 = 0;
								int num5 = 0;
							}
							ItemType itemType = default(ItemType);
							string text6 = $"Undeleted item (Item Type : {itemType} / Name : {num2})";
							int num6 = 0;
							throw new NullReferenceException();
						};
						bool result = default(bool);
						return result;
					}
					Item item5 = item2;
					string text3 = $"Item list operation : UnRemoveItem failed because an item already have that name, {flag2}";
				}
				Item item6 = item2;
				string text4 = $"Item list operation : UnRemoveItem item must be flaged deleted, {flag}";
			}
			ILogger logger = Log;
			Item arg = item2;
			string text5 = $"Item list operation : UnRemoveItem item must already exists in database, {arg}";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B16")]
		[Cpp2IlInjected.Address(RVA = "0x22D3720", Offset = "0x22D2120", VA = "0x1822D3720")]
		public unsafe bool IsNewItemNameValid(ItemType itemType, string newName, [System.Runtime.InteropServices.Optional] string previousName)
		{
			int num = 0;
			return IsNewItemNameValid(itemType, newName, out *(ItemNameInvalidityReason*)num, previousName);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B17")]
		[Cpp2IlInjected.Address(RVA = "0x22D3340", Offset = "0x22D1D40", VA = "0x1822D3340")]
		public bool IsNewItemNameValid(ItemType itemType, string newName, out ItemNameInvalidityReason invalidityReason, [System.Runtime.InteropServices.Optional] string previousName)
		{
			//IL_00ad: Expected O, but got I4
			int value__ = 0;
			_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
			CS_0024_003C_003E8__locals0.newName = newName;
			invalidityReason.value__ = value__;
			string newName2 = CS_0024_003C_003E8__locals0.newName;
			if (CS_0024_003C_003E8__locals0 != null)
			{
				goto IL_0039;
			}
			if (CS_0024_003C_003E8__locals0 == null)
			{
				string newName3 = CS_0024_003C_003E8__locals0.newName;
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag && flag2)
				{
					goto IL_0039;
				}
			}
			goto IL_003c;
			IL_003c:
			int num = 0;
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			Func<char, bool> cpp2il__autoParamName__idx_ = (Func<char, bool>)(object)(Func<T, TResult>)((char x) => Enumerable.Contains<char>((IEnumerable<>)(object)CS_0024_003C_003E8__locals0.newName, x));
			if (!((IEnumerable<>)(object)invalidFileNameChars).Any<char>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				string newName4 = CS_0024_003C_003E8__locals0.newName;
				bool flag3 = default(bool);
				if (!flag3)
				{
					string newName5 = CS_0024_003C_003E8__locals0.newName;
					bool flag4 = default(bool);
					if (!flag4)
					{
						string newName6 = CS_0024_003C_003E8__locals0.newName;
						bool flag5 = default(bool);
						if (!flag5)
						{
							char c = ((IEnumerable<>)(object)CS_0024_003C_003E8__locals0.newName).Last<char>();
							Dictionary<ItemType, ItemList> dictionary = itemLists;
							bool flag6 = default(bool);
							if (!flag6)
							{
								string text = $"Please create (or fix) a default json file on GIT for this new ItemType & restart Unity: itemlist\\{flag6}.json";
							}
							Func<ItemListDefinition, bool> func = (Func<ItemListDefinition, bool>)(object)(Func<T, TResult>)delegate(ItemListDefinition x)
							{
								//Discarded unreachable code: IL_0020
								if (x.deleted_)
								{
									int num3 = 0;
								}
								string newName7 = CS_0024_003C_003E8__locals0.newName;
								return string.Equals(x.name_, newName7, StringComparison.OrdinalIgnoreCase);
							};
							ICollection<> collection = default(ICollection<>);
							if (Enumerable.FirstOrDefault<ItemListDefinition>((IEnumerable<>)collection, (Func<, >)(object)func) != null)
							{
							}
						}
					}
				}
			}
			throw new NullReferenceException();
			IL_0039:
			int num2 = 0;
			goto IL_003c;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B18")]
		[Cpp2IlInjected.Address(RVA = "0x22D1F20", Offset = "0x22D0920", VA = "0x1822D1F20")]
		private ItemListDefinition GetItemListDefinition(Item item)
		{
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<ItemType, ItemList> dictionary = itemLists;
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				if (flag2 && flag3)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B19")]
		[Cpp2IlInjected.Address(RVA = "0x22D5130", Offset = "0x22D3B30", VA = "0x1822D5130")]
		private unsafe bool TryGetItemListDefinition(Item item, out ItemListDefinition definition)
		{
			int num = 0;
			return TryGetItemListDefinition(item, out definition, out *(ItemList*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B1A")]
		[Cpp2IlInjected.Address(RVA = "0x22D4FF0", Offset = "0x22D39F0", VA = "0x1822D4FF0")]
		private bool TryGetItemListDefinition(Item item, out ItemListDefinition definition, out ItemList itemList)
		{
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<ItemType, ItemList> dictionary = itemLists;
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				if (flag2 && flag3)
				{
					return true;
				}
			}
			int num = 0;
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B1B")]
		[Cpp2IlInjected.Address(RVA = "0x22D4DE0", Offset = "0x22D37E0", VA = "0x1822D4DE0")]
		public bool TryGetItemFromName(ItemType itemType, string name, out Item item)
		{
			//IL_0040: Expected I4, but got O
			int itemID = 0;
			Dictionary<ItemType, ItemList> dictionary = itemLists;
			bool flag = default(bool);
			if (flag)
			{
				Func<KeyValuePair<int, ItemListDefinition>, bool> func = (Func<KeyValuePair<int, ItemListDefinition>, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0004
					int num = 0;
					bool result = default(bool);
					return result;
				};
				item.ItemID = itemID;
				return true;
			}
			Item invalid = Item.Invalid;
			item.ItemID = (int)invalid;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B1C")]
		[Cpp2IlInjected.Address(RVA = "0x22D3250", Offset = "0x22D1C50", VA = "0x1822D3250")]
		public bool IsItemFileExists(ItemType itemType, string name)
		{
			IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			string text = string.Format("{0}/{1}.json", "{0}/{1}.json", name);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B1D")]
		[Cpp2IlInjected.Address(RVA = "0x22D3750", Offset = "0x22D2150", VA = "0x1822D3750")]
		public unsafe bool ItemHasDeleteFlag(Item item)
		{
			int num = 0;
			bool flag = TryGetItemListDefinition(item, out *(ItemListDefinition*)num, out *(ItemList*)num);
			if (!flag)
			{
				return flag;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B1E")]
		[Cpp2IlInjected.Address(RVA = "0x22D1E30", Offset = "0x22D0830", VA = "0x1822D1E30")]
		public ItemEditStatus GetItemEditStatus(Item item)
		{
			int itemID = item.ItemID;
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				return ItemEditStatus.Invalid;
			}
			IItemData itemData = default(IItemData);
			bool flag2 = default(bool);
			if (itemData == null || !flag2)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B1F")]
		[Cpp2IlInjected.Address(RVA = "0x22D22C0", Offset = "0x22D0CC0", VA = "0x1822D22C0")]
		public List<string> GetItemPreviousNames(Item item)
		{
			//Discarded unreachable code: IL_0031
			//IL_0028: Expected O, but got I4
			int num;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			do
			{
				int itemID = item.ItemID;
				num = 0;
				if (flag)
				{
					Dictionary<ItemType, ItemList> dictionary = itemLists;
					if (flag2 && flag3)
					{
					}
				}
			}
			while (num != 0 && Enumerable.ToList<string>((IEnumerable<>)num) != null);
			return (List<string>)(object)new List<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B20")]
		[Cpp2IlInjected.Address(RVA = "0x22D1670", Offset = "0x22D0070", VA = "0x1822D1670")]
		public List<string> GetDeprecatedItemNames(ItemType itemtype, bool includePreviousName = false)
		{
			//Discarded unreachable code: IL_00c4, IL_00ca, IL_00d0, IL_00d6
			//IL_0087: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			List<string> result = (List<string>)(object)new List<T>();
			Dictionary<ItemType, ItemList> dictionary = itemLists;
			bool flag = default(bool);
			ItemList itemList = default(ItemList);
			IEnumerable<KeyValuePair<int, ItemListDefinition>> enumerable;
			if (flag)
			{
				MapField<int, ItemListDefinition> ids_ = itemList.ids_;
				Func<KeyValuePair<int, ItemListDefinition>, bool> _003C_003E9__30_ = _003C_003Ec._003C_003E9__30_2;
				if (_003C_003E9__30_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				enumerable = (IEnumerable<KeyValuePair<int, ItemListDefinition>>)Enumerable.Where<KeyValuePair<int, ItemListDefinition>>((IEnumerable<>)(object)ids_, (Func<, >)(object)_003C_003E9__30_);
				if (enumerable != null)
				{
					uint num4 = default(uint);
					if (num < (int)num4)
					{
						num += num;
						if (num == (int)num4)
						{
							goto IL_0093;
						}
						num++;
					}
					IItemData itemData = default(IItemData);
					while (itemData != null)
					{
					}
					AddName((string)num);
					bool flag2 = default(bool);
					if (flag2)
					{
						AddName((string)num3);
						goto IL_0093;
					}
				}
				goto IL_0097;
			}
			goto IL_009c;
			IL_0097:
			if (enumerable == null)
			{
			}
			goto IL_009c;
			IL_0093:
			num3 += num3;
			goto IL_0097;
			IL_009c:
			List<string> list = result;
			Predicate<string> predicate = (Predicate<string>)(object)(Predicate<T>)delegate(string x)
			{
				//Discarded unreachable code: IL_002e
				MapField<int, ItemListDefinition> ids_2 = itemList.ids_;
				Func<KeyValuePair<int, ItemListDefinition>, bool> cpp2il__autoParamName__idx_ = (Func<KeyValuePair<int, ItemListDefinition>, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_001f
					int num6 = 0;
					string text = x;
					string a = text.ToLower();
					string b = text.ToLower();
					return string.Equals(a, b);
				};
				return ((IEnumerable<>)(object)ids_2).Any<KeyValuePair<int, ItemListDefinition>>((Func<, >)(object)cpp2il__autoParamName__idx_);
			};
			int num5 = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
			return result;
			[Cpp2IlInjected.Token(Token = "0x6004BEB")]
			[Cpp2IlInjected.Address(RVA = "0x90A800", Offset = "0x909200", VA = "0x18090A800")]
			void AddName(string name)
			{
				//Discarded unreachable code: IL_001c
				if (!((List<T>)(object)result).Contains((T)name))
				{
					((List<T>)(object)result).Add((T)name);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B21")]
		[Cpp2IlInjected.Address(RVA = "0x22D0060", Offset = "0x22CEA60", VA = "0x1822D0060")]
		public bool CanUnRemoveItem(Item deletedItem)
		{
			//IL_001d: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				string text = GitController.Config(GetItemListRepoPath(), "user.name");
				(string, DateTime) tuple = Enumerable.FirstOrDefault<(string, DateTime)>((IEnumerable<>)num);
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B22")]
		[Cpp2IlInjected.Address(RVA = "0x22CFD20", Offset = "0x22CE720", VA = "0x1822CFD20")]
		public bool CanRemoveHiddenItem(ItemType itemtype, string name, out string author)
		{
			//IL_0041: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				string name2 = name;
				Dictionary<ItemType, ItemList> dictionary = itemLists;
				bool flag2 = default(bool);
				if (flag2)
				{
					Func<KeyValuePair<int, ItemListDefinition>, bool> func = (Func<KeyValuePair<int, ItemListDefinition>, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0004
						int num5 = 0;
						bool result = default(bool);
						return result;
					};
					int num2 = 0;
					IEnumerable<(string, DateTime)> logItemInfo = (IEnumerable<(string, DateTime)>)this.GetLogItemInfo(name, (byte)num2 != 0);
					(string, DateTime) tuple = Enumerable.FirstOrDefault<(string, DateTime)>((IEnumerable<>)num);
					if (GitController.Config(GetItemListRepoPath(), "user.name") != null)
					{
					}
					int num3 = 0;
					DateTime now = DateTime.Now;
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B23")]
		[Cpp2IlInjected.Address(RVA = "0x22D1530", Offset = "0x22CFF30", VA = "0x1822D1530")]
		public IEnumerable<(string, DateTime)> GetDeletedItemInfo(Item item)
		{
			ItemType itemType = default(ItemType);
			int num = (int)itemType;
			string arg = default(string);
			string text = string.Format("Deleted item (Item Type : {0} / Name : {1})", "Deleted item (Item Type : {0} / Name : {1})", arg);
			return (IEnumerable<(string, DateTime)>)this.GetLogItemInfo(text, true);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B24")]
		[Cpp2IlInjected.Address(RVA = "0x22D15E0", Offset = "0x22CFFE0", VA = "0x1822D15E0")]
		public IEnumerable<(string, DateTime)> GetDeletedItemInfo(ItemType itemType, string itemName)
		{
			string text = string.Format("Deleted item (Item Type : {0} / Name : {1})", "Deleted item (Item Type : {0} / Name : {1})", itemName);
			return (IEnumerable<(string, DateTime)>)this.GetLogItemInfo(text, true);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B25")]
		[Cpp2IlInjected.Address(RVA = "0x22D13F0", Offset = "0x22CFDF0", VA = "0x1822D13F0")]
		public IEnumerable<(string, DateTime)> GetCreatedItemInfo(Item item)
		{
			ItemType itemType = default(ItemType);
			int num = (int)itemType;
			string arg = default(string);
			string text = string.Format("Added new Item (Item Type : {0} / Name : {1})", "Added new Item (Item Type : {0} / Name : {1})", arg);
			return (IEnumerable<(string, DateTime)>)this.GetLogItemInfo(text, true);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B26")]
		[Cpp2IlInjected.Address(RVA = "0x22D14A0", Offset = "0x22CFEA0", VA = "0x1822D14A0")]
		public IEnumerable<(string, DateTime)> GetCreatedItemInfo(ItemType itemType, string itemName)
		{
			string text = string.Format("Added new Item (Item Type : {0} / Name : {1})", "Added new Item (Item Type : {0} / Name : {1})", itemName);
			return (IEnumerable<(string, DateTime)>)this.GetLogItemInfo(text, true);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B27")]
		[Cpp2IlInjected.Address(RVA = "0x22D1C20", Offset = "0x22D0620", VA = "0x1822D1C20")]
		public IEnumerable<(string, DateTime)> GetEditedItemInfo(Item item)
		{
			string text = default(string);
			string text2 = " -> " + text;
			int num = 0;
			return (IEnumerable<(string, DateTime)>)this.GetLogItemInfo(text2, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B28")]
		[Cpp2IlInjected.Address(RVA = "0x22D1BC0", Offset = "0x22D05C0", VA = "0x1822D1BC0")]
		public IEnumerable<(string, DateTime)> GetEditedItemInfo(ItemType itemType, string itemName)
		{
			string text = " -> " + itemName;
			int num = 0;
			return (IEnumerable<(string, DateTime)>)this.GetLogItemInfo(text, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B29")]
		[Cpp2IlInjected.Address(RVA = "0x22D1370", Offset = "0x22CFD70", VA = "0x1822D1370")]
		public IEnumerable<(string, DateTime)> GetAllItemInfo(Item item)
		{
			int num = 0;
			string text = default(string);
			return (IEnumerable<(string, DateTime)>)this.GetLogItemInfo(text, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B2A")]
		[Cpp2IlInjected.Address(RVA = "0x22D1310", Offset = "0x22CFD10", VA = "0x1822D1310")]
		public IEnumerable<(string, DateTime)> GetAllItemInfo(ItemType itemType, string itemName)
		{
			int num = 0;
			return (IEnumerable<(string, DateTime)>)this.GetLogItemInfo(itemName, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B2B")]
		[Cpp2IlInjected.Address(RVA = "0x22D2ED0", Offset = "0x22D18D0", VA = "0x1822D2ED0")]
		[IteratorStateMachine(typeof(_003CGetLogItemInfo_003Ed__41))]
		private IEnumerable<(string, DateTime)> GetLogItemInfo(string msg, bool startWith = true)
		{
			_003CGetLogItemInfo_003Ed__41 _003CGetLogItemInfo_003Ed__ = new _003CGetLogItemInfo_003Ed__41(-2);
			_003CGetLogItemInfo_003Ed__._003C_003E4__this = this;
			_003CGetLogItemInfo_003Ed__._003C_003E3__msg = msg;
			_003CGetLogItemInfo_003Ed__._003C_003E3__startWith = startWith;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B2C")]
		[Cpp2IlInjected.Address(RVA = "0x22D62B0", Offset = "0x22D4CB0", VA = "0x1822D62B0")]
		public List<string> VerifyItemListIssues(ItemType itemType, [System.Runtime.InteropServices.Optional] Action<float> onProgress)
		{
			//Discarded unreachable code: IL_0032, IL_0038, IL_003e, IL_0044
			int num = 0;
			List<string> result = (List<string>)(object)new List<T>();
			Dictionary<ItemType, ItemList> dictionary = itemLists;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				if (onProgress != null)
				{
					num++;
				}
				bool flag3 = default(bool);
				if (!flag3)
				{
				}
				bool flag4 = default(bool);
				while (num != (flag4 ? 1 : 0))
				{
				}
				int num2 = 0;
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B2D")]
		[Cpp2IlInjected.Address(RVA = "0x22D2FE0", Offset = "0x22D19E0", VA = "0x1822D2FE0")]
		private void InitItemListRepo()
		{
			//IL_0031: Expected O, but got I4
			string itemListRepoPath = GetItemListRepoPath();
			if (!Directory.Exists(Path.Combine(itemListRepoPath, ".git")))
			{
				bool flag = GitController.Clone(itemListRepoPath);
			}
			bool flag2 = GitController.CheckConnectionMethod(itemListRepoPath);
			int num = 0;
			bool flag3 = GitController.Update(itemListRepoPath, (string)num);
			IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			if ((object)typeof(FileSystem).TypeHandle != null)
			{
				string sha = FileSystem.Data.ReadAllText("itemList.sha1");
				bool flag4 = GitController.Update(itemListRepoPath, sha);
			}
			ILogger logger = Log;
			string currentCommitSHA = GitController.GetCurrentCommitSHA(itemListRepoPath);
			string text = "Item list operation : Currently at commit " + currentCommitSHA;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B2E")]
		[Cpp2IlInjected.Address(RVA = "0x22D47A0", Offset = "0x22D31A0", VA = "0x1822D47A0")]
		private void SaveItemList(ItemType itemType, ItemList itemList, bool binary = false, [System.Runtime.InteropServices.Optional] IFileSystem fileSystem)
		{
			//IL_0025: Expected I4, but got I8
			IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			if ("itemlist" == null)
			{
			}
			if (!binary)
			{
				int formatEnumAsIntegers = 0;
				int formatDefaultValues = 0;
				ulong num = default(ulong);
				string text = itemList.ToJSONString((byte)formatDefaultValues != 0, indented: true, (byte)formatEnumAsIntegers != 0, (int)num);
				string text2 = string.Format("itemlist/{0}.json", "itemlist/{0}.json");
				return;
			}
			string text3 = string.Format("itemlist/{0}.json", "itemlist/{0}.json");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B2F")]
		[Cpp2IlInjected.Address(RVA = "0x22D43C0", Offset = "0x22D2DC0", VA = "0x1822D43C0")]
		private void ReloadItemLists()
		{
			//Discarded unreachable code: IL_0028
			((Dictionary<TKey, TValue>)(object)itemLists).Clear();
			((ConcurrentDictionary<TKey, TValue>)(object)allItems).Clear();
			((Dictionary<TKey, TValue>)(object)cachedSearchs).Clear();
			LoadItemLists();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B30")]
		[Cpp2IlInjected.Address(RVA = "0x22CF630", Offset = "0x22CE030", VA = "0x1822CF630")]
		private bool AtomicItemListOperation(ItemType itemType, ItemListOperationDelegate itemListOperation)
		{
			//Discarded unreachable code: IL_0018, IL_001f, IL_004e, IL_005b, IL_0086, IL_0093, IL_00de, IL_00eb, IL_00f0, IL_0111, IL_011e, IL_012a
			//IL_0067: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			if (itemListOperation != null)
			{
				Dictionary<ItemType, ItemList> dictionary = itemLists;
				int num = 0;
				throw new NullReferenceException();
			}
			ArgumentNullException ex = new ArgumentNullException("itemListOperation", "AtomicItemListOperation method requires a valid delegate to call.");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B32")]
		[Cpp2IlInjected.Address(RVA = "0x22D20C0", Offset = "0x22D0AC0", VA = "0x1822D20C0")]
		private string GetItemListRepoPath()
		{
			//Discarded unreachable code: IL_0008
			IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B33")]
		[Cpp2IlInjected.Address(RVA = "0x22D2060", Offset = "0x22D0A60", VA = "0x1822D2060")]
		private string GetItemListPath(ItemType itemType)
		{
			return string.Format("itemlist/{0}.json", "itemlist/{0}.json");
		}

		[Cpp2IlInjected.Token(Token = "0x6004B34")]
		[Cpp2IlInjected.Address(RVA = "0x22D1D10", Offset = "0x22D0710", VA = "0x1822D1D10")]
		private string GetItemDataPath(Item item, string name)
		{
			ItemType itemType = default(ItemType);
			int num = (int)itemType;
			return string.Format("{0}/{1}.json", "{0}/{1}.json", name);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B35")]
		[Cpp2IlInjected.Address(RVA = "0x22D1CA0", Offset = "0x22D06A0", VA = "0x1822D1CA0")]
		private string GetItemDataPath(ItemType itemType, string name)
		{
			return string.Format("{0}/{1}.json", "{0}/{1}.json", name);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B36")]
		[Cpp2IlInjected.Address(RVA = "0x22D0FA0", Offset = "0x22CF9A0", VA = "0x1822D0FA0")]
		public unsafe IEnumerable<IItemData> GetAllByType(ItemType itemType)
		{
			//IL_002d: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			int num = 0;
			Dictionary<(ItemType, Enum, Type), Array> dictionary = cachedSearchs;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			bool flag = ((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)num3, out *(TValue*)num);
			if (!flag)
			{
				ConcurrentDictionary<Item, IItemData> concurrentDictionary = allItems;
				Func<KeyValuePair<Item, IItemData>, bool> func = (Func<KeyValuePair<Item, IItemData>, bool>)(object)(Func<T, TResult>)delegate
				{
					ItemType itemType3 = default(ItemType);
					while (itemType3 == itemType)
					{
					}
					int num10 = 0;
					/*Error: Unexpected end of block*/;
				};
				IEnumerable<KeyValuePair<Item, IItemData>> enumerable = (IEnumerable<KeyValuePair<Item, IItemData>>)Enumerable.Where<KeyValuePair<Item, IItemData>>((IEnumerable<>)concurrentDictionary, (Func<, >)(object)func);
				Func<KeyValuePair<Item, IItemData>, IItemData> _003C_003E9__65_ = _003C_003Ec._003C_003E9__65_1;
				if (_003C_003E9__65_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				IItemData[] value = Enumerable.Select<KeyValuePair<Item, IItemData>, IItemData>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__65_).ToArray<IItemData>();
				Dictionary<(ItemType, Enum, Type), Array> dictionary2 = cachedSearchs;
				int num6 = 0;
				ItemType itemType2 = itemType;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				((Dictionary<TKey, TValue>)(object)dictionary2).Add((TKey)num6, (TValue)value);
			}
			if (num == 0 || flag)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B37")]
		[Cpp2IlInjected.Address(RVA = "0x19AE6B0", Offset = "0x19AD0B0", VA = "0x1819AE6B0")]
		public unsafe IEnumerable<> GetAllByType<ItemDataType>(ItemType P_0)
		{
			//IL_0028: Expected O, but got I4
			int num = 0;
			Dictionary<(ItemType, Enum, Type), Array> dictionary = cachedSearchs;
			Type typeFromHandle = typeof(Type);
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			IEnumerable<KeyValuePair<Item, IItemData>> enumerable = default(IEnumerable<KeyValuePair<Item, IItemData>>);
			if (!((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)num3, out *(TValue*)num))
			{
				ConcurrentDictionary<Item, IItemData> concurrentDictionary = allItems;
				Func<KeyValuePair<Item, IItemData>, bool> func = default(Func<KeyValuePair<Item, IItemData>, bool>);
				enumerable = (IEnumerable<KeyValuePair<Item, IItemData>>)Enumerable.Where<KeyValuePair<Item, IItemData>>((IEnumerable<>)concurrentDictionary, (Func<, >)(object)func);
				if (!((ConcurrentDictionary<, >)(object)concurrentDictionary)._growLockArray)
				{
				}
				Dictionary<(ItemType, Enum, Type), Array> dictionary2 = cachedSearchs;
				int num5 = 0;
				int num6 = 0;
			}
			Type type = default(Type);
			if (enumerable == null || (object)type != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B38")]
		[Cpp2IlInjected.Address(RVA = "0x19AE150", Offset = "0x19ACB50", VA = "0x1819AE150")]
		public IEnumerable<> GetAllByType<ItemDataType, SubItemEnumType>(ItemType P_0, SubItemEnumType subItemEnumType) where SubItemEnumType : struct, Enum
		{
			int num = 0;
			Dictionary<(ItemType, Enum, Type), Array> dictionary = cachedSearchs;
			ItemTypeMetaInfo itemTypeMetaInfo = default(ItemTypeMetaInfo);
			MessageParser _003CProtobufClassMessageParser_003Ek__BackingField = itemTypeMetaInfo.ProtobufClassMessageParser;
			bool flag = default(bool);
			if (!flag)
			{
				int num2 = 0;
				IEnumerable<IItemData> enumerable = default(IEnumerable<IItemData>);
				Func<IItemData, bool> func = default(Func<IItemData, bool>);
				IEnumerable<IItemData> enumerable2 = (IEnumerable<IItemData>)Enumerable.Where<IItemData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
				if (func != null)
				{
				}
			}
			Type type = default(Type);
			if ((object)type != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B3B")]
		[Cpp2IlInjected.Address(RVA = "0x22D6690", Offset = "0x22D5090", VA = "0x1822D6690")]
		public ItemDatabase(bool isEditor)
		{
			ItemType[] array = new ItemType[13];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			OnlineItemTypes = array;
			cachedSearchs = (Dictionary<(ItemType, Enum, Type), Array>)(object)new Dictionary<TKey, TValue>();
			RequiredLevelCache = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
			this.isEditor = isEditor;
			if (isEditor)
			{
				InitItemListRepo();
			}
			LoadItemLists();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B3C")]
		[Cpp2IlInjected.Address(RVA = "0x22D1D90", Offset = "0x22D0790", VA = "0x1822D1D90")]
		public IItemData GetItemData(Item item)
		{
			if ((object)typeof(Item).TypeHandle == null)
			{
				ConcurrentDictionary<Item, IItemData> concurrentDictionary = allItems;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B3D")]
		[Cpp2IlInjected.Address(RVA = "0x19AEB70", Offset = "0x19AD570", VA = "0x1819AEB70")]
		public T GetItemData<T>(Item item) where T : class
		{
			IItemData itemData = GetItemData(item);
			if (itemData == null)
			{
			}
			if (itemData != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B3E")]
		[Cpp2IlInjected.Address(RVA = "0x22D4DB0", Offset = "0x22D37B0", VA = "0x1822D4DB0")]
		public bool TryGetItemData(Item item, out IItemData value)
		{
			IItemData itemData = GetItemData(item);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B3F")]
		[Cpp2IlInjected.Address(RVA = "0x19AEC20", Offset = "0x19AD620", VA = "0x1819AEC20")]
		public bool TryGetItemData<T>(Item item, out T value) where T : class
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B40")]
		public T GetItemData<T, SubItemType>(SubItemType item) where T : class where SubItemType : struct, ISubItem
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B41")]
		[Cpp2IlInjected.Address(RVA = "0x19AEB30", Offset = "0x19AD530", VA = "0x1819AEB30")]
		public T GetItemData<T>(ItemType itemType, string itemName) where T : class
		{
			//Discarded unreachable code: IL_0016
			//IL_0015: Expected O, but got I4
			int itemID = GetItem(itemType, itemName).ItemID;
			return (T)(object)this.GetItemData<T, SubItemType>((SubItemType)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B42")]
		[Cpp2IlInjected.Address(RVA = "0x22D2F70", Offset = "0x22D1970", VA = "0x1822D2F70")]
		public ITagData GetTagData(Item item)
		{
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Tag)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B43")]
		[Cpp2IlInjected.Address(RVA = "0x22D2D70", Offset = "0x22D1770", VA = "0x1822D2D70")]
		public Item GetItem(ItemType itemType, string name)
		{
			//Discarded unreachable code: IL_004c
			ItemType itemType2 = itemType;
			ConcurrentDictionary<string, Item> concurrentDictionary = allItemsByName;
			string text = name;
			Func<string, Item> func = (Func<string, Item>)(object)new Func<T, TResult>(GetItemForName);
			string text2 = default(string);
			return (Item)((ConcurrentDictionary<TKey, TValue>)(object)concurrentDictionary).GetOrAdd((TKey)text2, (Func<, >)(object)func);
			[Cpp2IlInjected.Token(Token = "0x6004C0E")]
			[Cpp2IlInjected.Address(RVA = "0x90BCF0", Offset = "0x90A6F0", VA = "0x18090BCF0")]
			Item GetItemForName(string arg)
			{
				//Discarded unreachable code: IL_0059, IL_005f
				//IL_0040: Expected O, but got I4
				IEnumerator<> enumerator;
				uint num2 = default(uint);
				ItemType itemType3 = default(ItemType);
				int num;
				while (true)
				{
					num = 0;
					enumerator = ((ConcurrentDictionary<TKey, TValue>)(object)allItems).GetEnumerator();
					if (enumerator == null)
					{
						break;
					}
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_0030;
						}
						num++;
					}
					while (itemType3 != itemType)
					{
					}
					goto IL_0030;
					IL_0030:
					string b = name;
					if (string.Equals((string)num, b))
					{
						num++;
						break;
					}
				}
				num++;
				if (enumerator != null)
				{
				}
				if (num != 0)
				{
				}
				return Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B44")]
		[Cpp2IlInjected.Address(RVA = "0x22D2180", Offset = "0x22D0B80", VA = "0x1822D2180")]
		public string GetItemName(Item item)
		{
			//IL_000c: Expected O, but got I4
			int num = 0;
			IItemData itemData = default(IItemData);
			if (itemData != null)
			{
			}
			if (string.IsNullOrEmpty((string)num))
			{
				Dictionary<ItemType, ItemList> dictionary = itemLists;
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (!flag || flag2)
				{
				}
				int num2 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B45")]
		[Cpp2IlInjected.Address(RVA = "0x22D40F0", Offset = "0x22D2AF0", VA = "0x1822D40F0")]
		private IItemData LoadItem(Item newItem)
		{
			ItemType itemType = default(ItemType);
			int num = (int)itemType;
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
				if ((IntPtr)num != (IntPtr)num2)
				{
					ItemType itemType2 = default(ItemType);
					int num3 = (int)itemType2;
					bool flag2 = default(bool);
					if (!flag2)
					{
					}
				}
			}
			Dictionary<ItemType, ItemList> dictionary = itemLists;
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			if (flag3 && flag4)
			{
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					goto IL_0046;
				}
				if (this != null)
				{
					EventHandler<Item> itemRemovedEvent = this.ItemRemovedEvent;
					IItemData itemData2 = default(IItemData);
					if (itemData2 != null)
					{
						goto IL_0046;
					}
				}
			}
			int num4 = 0;
			goto IL_0046;
			IL_0046:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B46")]
		[Cpp2IlInjected.Address(RVA = "0x22D37A0", Offset = "0x22D21A0", VA = "0x1822D37A0")]
		private void LoadItemLists()
		{
			//Discarded unreachable code: IL_0064, IL_0067, IL_006c, IL_007d, IL_009a, IL_00a7, IL_00ac, IL_00bb, IL_00c0, IL_00c9, IL_00d0, IL_00d9, IL_00dd, IL_00e2, IL_00e7, IL_00f8, IL_00fe, IL_0104, IL_010a, IL_0110, IL_0116, IL_011c, IL_0122, IL_0128, IL_012e, IL_0134, IL_013a, IL_0140, IL_0146, IL_014c, IL_0152, IL_0158, IL_015e
			//IL_0048: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00a0: Expected O, but got I4
			int num2;
			bool flag = default(bool);
			do
			{
				int num = 0;
				num2 = 0;
				IEnumerator enumerator = Enum.GetValues(typeof(ItemType)).GetEnumerator();
				if (enumerator != null)
				{
					IEnumerator enumerator2 = enumerator;
					string path = string.Format("itemlist/{0}.json", "itemlist/{0}.json");
					IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
					while ((object)typeof(FileSystem).TypeHandle == null)
					{
					}
					ItemList itemList = ProtoParser.Parse<ItemList>(LocalizationProtoBufTableProvider.GetBinaryLocalizationFs((CultureInfo)0).ReadAllBytes(path));
					Dictionary<ItemType, ItemList> dictionary = itemLists;
					throw new NullReferenceException();
				}
				if (flag)
				{
				}
			}
			while (num2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B47")]
		[Cpp2IlInjected.Address(RVA = "0x22D0150", Offset = "0x22CEB50", VA = "0x1822D0150")]
		public static void CreateInstance(bool isEditor)
		{
			//IL_000b: Expected I4, but got O
			DisableGit = (byte)(int)new ItemDatabase(isEditor) != 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4A")]
		[Cpp2IlInjected.Address(RVA = "0x22D24F0", Offset = "0x22D0EF0", VA = "0x1822D24F0")]
		public int GetItemRequiredLevel(Item item)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			return GetItemRequiredLevel(item, (IItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4B")]
		[Cpp2IlInjected.Address(RVA = "0x22D2480", Offset = "0x22D0E80", VA = "0x1822D2480")]
		public int GetItemRequiredLevel(IItemData itemdata)
		{
			//IL_000a: Expected I4, but got O
			if (itemdata == null)
			{
				return (int)typeof(IItemData).TypeHandle;
			}
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4C")]
		[Cpp2IlInjected.Address(RVA = "0x22D2500", Offset = "0x22D0F00", VA = "0x1822D2500")]
		private unsafe int GetItemRequiredLevel(Item item, IItemData itemdata)
		{
			//Discarded unreachable code: IL_014a, IL_0156, IL_015c
			bool flag = default(bool);
			IEnumerable<RecipeItemData> enumerable = default(IEnumerable<RecipeItemData>);
			uint num5 = default(uint);
			bool flag2 = default(bool);
			Func<Item, int> func2 = default(Func<Item, int>);
			int num6 = default(int);
			Item[] array = default(Item[]);
			uint num7 = default(uint);
			int num8 = default(int);
			int num9 = default(int);
			IEnumerable<SeedItemData> enumerable3 = default(IEnumerable<SeedItemData>);
			int num10 = default(int);
			bool flag3 = default(bool);
			SetItemData setItemData = default(SetItemData);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				_003C_003Ec__DisplayClass92_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass92_0();
				CS_0024_003C_003E8__locals0.itemdata = itemdata;
				IEnumerable<RecipeItemData> enumerable2;
				if (CS_0024_003C_003E8__locals0 == null)
				{
					Dictionary<Item, int> requiredLevelCache = RequiredLevelCache;
					if (!flag)
					{
						IItemData itemdata2 = CS_0024_003C_003E8__locals0.itemdata;
						IItemData itemdata3 = CS_0024_003C_003E8__locals0.itemdata;
						if (itemdata3 != null)
						{
							if (itemdata3 != null)
							{
								Func<RecipeItemData, bool> func = (Func<RecipeItemData, bool>)(object)(Func<T, TResult>)delegate(RecipeItemData x)
								{
									//Discarded unreachable code: IL_0015
									IItemData itemdata6 = CS_0024_003C_003E8__locals0.itemdata;
									return (IntPtr)x.resultItemID_ == (IntPtr)typeof(IItemData).TypeHandle;
								};
								enumerable2 = (IEnumerable<RecipeItemData>)Enumerable.Where<RecipeItemData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
								int num4 = 0;
								if (enumerable2 != null)
								{
									if (num4 < (int)num5)
									{
										num4 += num4;
										if (num4 == (int)num5)
										{
											goto IL_00b8;
										}
										num4++;
									}
									if (flag2)
									{
										if (num3 != 0)
										{
											while (num3 == 0)
											{
											}
											while (!flag2)
											{
											}
											func2 = (Func<Item, int>)(object)new Func<T, TResult>(GetItemRequiredLevel);
											num6 = Enumerable.Min<Item>((IEnumerable<>)(object)array, (Func<, >)(object)func2);
											while ((int)num7 >= num6)
											{
											}
											goto IL_00b8;
										}
										goto IL_00c9;
									}
									goto IL_00d3;
								}
								goto IL_00e2;
							}
							goto IL_00f9;
						}
					}
				}
				throw new NullReferenceException();
				IL_00b8:
				func2 += func2;
				num6 += 312;
				goto IL_00c9;
				IL_00e2:
				num8++;
				if (enumerable2 != null)
				{
				}
				if (num != 0)
				{
					continue;
				}
				if (num8 == 0)
				{
				}
				goto IL_00f9;
				IL_00c9:
				while (num6 >= num9)
				{
				}
				num6 = num9;
				goto IL_00d3;
				IL_00f9:
				IItemData itemdata4 = CS_0024_003C_003E8__locals0.itemdata;
				if (itemdata4 != null && itemdata4 != null)
				{
					Func<SeedItemData, bool> func3 = (Func<SeedItemData, bool>)(object)(Func<T, TResult>)delegate(SeedItemData x)
					{
						//Discarded unreachable code: IL_0016
						Item producedItem = x.ProducedItem;
						IItemData itemdata5 = CS_0024_003C_003E8__locals0.itemdata;
						return *(Item*)producedItem == *(Item*)producedItem;
					};
					if (Enumerable.FirstOrDefault<SeedItemData>((IEnumerable<>)enumerable3, (Func<, >)(object)func3) != null)
					{
					}
				}
				if (num10 != 0)
				{
					if (num10 == 0 || flag3)
					{
					}
					if (flag3 && setItemData != null)
					{
					}
				}
				throw new NullReferenceException();
				IL_00d3:
				num++;
				if (num != 0)
				{
					break;
				}
				while (num == 0)
				{
				}
				goto IL_00e2;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4D")]
		[Cpp2IlInjected.Address(RVA = "0x22D6600", Offset = "0x22D5000", VA = "0x1822D6600")]
		static ItemDatabase()
		{
			//IL_000a: Expected I4, but got O
			/*Error: Unexpected end of block*/;
		}
	}
}
