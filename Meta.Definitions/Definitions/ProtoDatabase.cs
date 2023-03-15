using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Serilog;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	public class ProtoDatabase : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000125")]
		public enum ProtoObjectInvalidityReason
		{
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			IsValid,
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			BasePathInvalidCharacters,
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			BasePathInvalidPattern,
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			SourceIsEmpty,
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			SourceInvalidCharacters,
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			NameIsEmpty,
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			NameInvalidCharacters,
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			NameAlreadyUsed,
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			NotChanged,
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			OnlyCasingChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000126")]
		public class ProtoDesc
		{
			[Cpp2IlInjected.Token(Token = "0x170002ED")]
			public string BasePath
			{
				[Cpp2IlInjected.Token(Token = "0x6000BFF")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CBasePath_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C00")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CBasePath_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002EE")]
			public string Source
			{
				[Cpp2IlInjected.Token(Token = "0x6000C01")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CSource_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C02")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CSource_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002EF")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000C03")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C04")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F0")]
			public string Path
			{
				[Cpp2IlInjected.Token(Token = "0x6000C05")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CPath_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C06")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CPath_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F1")]
			public MessageParser Parser
			{
				[Cpp2IlInjected.Token(Token = "0x6000C07")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CParser_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C08")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CParser_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F2")]
			public Type Type
			{
				[Cpp2IlInjected.Token(Token = "0x6000C09")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				[CompilerGenerated]
				get
				{
					return _003CType_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C0A")]
				[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
				[CompilerGenerated]
				set
				{
					_003CType_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F3")]
			public IMessage Message
			{
				[Cpp2IlInjected.Token(Token = "0x6000C0B")]
				[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
				[CompilerGenerated]
				get
				{
					return _003CMessage_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C0C")]
				[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
				[CompilerGenerated]
				set
				{
					_003CMessage_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F4")]
			public bool GeneratedByExcel
			{
				[Cpp2IlInjected.Token(Token = "0x6000C0E")]
				[Cpp2IlInjected.Address(RVA = "0x9D3A90", Offset = "0x9D2490", VA = "0x1809D3A90")]
				get
				{
					//Discarded unreachable code: IL_0011
					return Path.StartsWith("Excel/");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F5")]
			public string DebugName
			{
				[Cpp2IlInjected.Token(Token = "0x6000C0F")]
				[Cpp2IlInjected.Address(RVA = "0x9D39E0", Offset = "0x9D23E0", VA = "0x1809D39E0")]
				get
				{
					string value = BasePath;
					string empty = string.Empty;
					if (!string.IsNullOrEmpty(value))
					{
						string text = BasePath;
						string text2 = empty + text + "/";
					}
					string text4 = default(string);
					if (!string.IsNullOrEmpty(Source))
					{
						string text3 = Source;
						text4 = empty + text3 + "/";
					}
					string text5 = Name;
					return text4 + text5;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x9D3910", Offset = "0x9D2310", VA = "0x1809D3910")]
			internal void Save(IFileSystem fs)
			{
				//IL_001f: Expected I4, but got I8
				string path = Path;
				IMessage message = Message;
				int formatEnumAsIntegers = 0;
				int formatDefaultValues = 0;
				ulong num = default(ulong);
				string text = message.ToJSONString((byte)formatDefaultValues != 0, indented: true, (byte)formatEnumAsIntegers != 0, (int)num);
				fs.WriteAllText(path, text);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ProtoDesc()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public const string InvalidBasePathCharacters = ":*?\"<>| ";

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const string InvalidSourceCharacters = "\\/:*?\"<>| .";

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private static string ValidPath = "([^\\\\/:*?\"<>| .]+(\\.+[^\\\\/:*?\"<>| .]+)*)";

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public const string ValidNameCharacters = "a-zA-Z0-9_";

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly List<Assembly> assemblies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly bool isEditor;

		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public const string BinaryProtoDbPath = "protoDb.bin";

		[Cpp2IlInjected.Token(Token = "0x170002E5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400053F")]
		private Regex ReBasePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000540")]
		private Regex ReProtoName
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E7")]
		public static ProtoDatabase Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0x288EC90", Offset = "0x288D690", VA = "0x18288EC90")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0x288ED90", Offset = "0x288D790", VA = "0x18288ED90")]
			[CompilerGenerated]
			private set
			{
				ValidPath = (string)(object)value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000543")]
		private Dictionary<string, MessageParser> Parsers
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000544")]
		private Dictionary<string, ProtoDesc> ProtoObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002EA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000546")]
		private Regex ReProtoFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002EB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4000547")]
		private IReadOnlyFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE8")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002EC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4000548")]
		private ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE9")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EventHandler OnReloadEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE3")]
			[Cpp2IlInjected.Address(RVA = "0x288EBF0", Offset = "0x288D5F0", VA = "0x18288EBF0")]
			[CompilerGenerated]
			add
			{
				EventHandler onReloadEvent = this.OnReloadEvent;
				Delegate @delegate = Delegate.Combine(onReloadEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onReloadEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x288ECF0", Offset = "0x288D6F0", VA = "0x18288ECF0")]
			[CompilerGenerated]
			remove
			{
				EventHandler onReloadEvent = this.OnReloadEvent;
				Delegate @delegate = Delegate.Remove(onReloadEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onReloadEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x288B650", Offset = "0x288A050", VA = "0x18288B650")]
		[IteratorStateMachine(typeof(_003CEnumerateNames_003Ed__9))]
		public IEnumerable<string> EnumerateNames(string typeName)
		{
			_003CEnumerateNames_003Ed__9 _003CEnumerateNames_003Ed__ = new _003CEnumerateNames_003Ed__9(-2);
			_003CEnumerateNames_003Ed__._003C_003E4__this = this;
			_003CEnumerateNames_003Ed__._003C_003E3__typeName = typeName;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x288B6E0", Offset = "0x288A0E0", VA = "0x18288B6E0")]
		[IteratorStateMachine(typeof(_003CEnumerateTypeNames_003Ed__10))]
		public IEnumerable<string> EnumerateTypeNames()
		{
			new _003CEnumerateTypeNames_003Ed__10(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x288B420", Offset = "0x2889E20", VA = "0x18288B420")]
		[IteratorStateMachine(typeof(_003CEnumerateAll_003Ed__11))]
		public IEnumerable<ProtoDesc> EnumerateAll()
		{
			new _003CEnumerateAll_003Ed__11(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x288E500", Offset = "0x288CF00", VA = "0x18288E500")]
		public bool TrySet(string name, IMessage newMessage)
		{
			//IL_000a: Expected I4, but got I8
			ulong num = default(ulong);
			return TrySet(name, newMessage, overrideIfExists: true, (byte)num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x288B870", Offset = "0x288A270", VA = "0x18288B870")]
		public void ExportForBuild(IFileSystem outputFileSystem, HashSet<string> handledFiles)
		{
			//Discarded unreachable code: IL_0020, IL_0026, IL_002c, IL_0032
			//IL_0019: Expected O, but got I4
			int num;
			bool flag = default(bool);
			bool flag2 = default(bool);
			do
			{
				num = 0;
				Dictionary<string, ProtoDesc> dictionary = ProtoObjects;
				if (flag)
				{
					if (!flag2)
					{
					}
					bool flag3 = ((HashSet<T>)(object)handledFiles).Add((T)num);
				}
			}
			while (num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x288BC70", Offset = "0x288A670", VA = "0x18288BC70")]
		private string GetProtoFileName(string basePath, string source, string name, string typeName)
		{
			//Discarded unreachable code: IL_0096
			string[] array;
			while (true)
			{
				array = new string[6];
				if (source != null && array == null)
				{
					continue;
				}
				array[0] = source;
				if ("." != null && "." == null)
				{
					continue;
				}
				array[1] = ".";
				if (name != null && "." == null)
				{
					continue;
				}
				array[2] = name;
				if ("[" == null || "[" != null)
				{
					array[3] = "[";
					if ("[" != null && ("].proto.json" == null || "].proto.json" != null))
					{
						break;
					}
				}
			}
			array[5] = "].proto.json";
			string path = string.Concat(array);
			return Path.Combine(basePath, path);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x288E520", Offset = "0x288CF20", VA = "0x18288E520")]
		public unsafe bool Validate(string previousName, string basePath, string source, string name, string typeName, out ProtoObjectInvalidityReason invalidityReason)
		{
			//IL_00e3: Expected O, but got I4
			int num = 0;
			bool flag = num == 0;
			Func<char, bool> _003C_003E9__16_ = _003C_003Ec._003C_003E9__16_0;
			if (_003C_003E9__16_ == null)
			{
				bool result2 = default(bool);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((char chr) => result2);
			}
			if (!((IEnumerable<>)(object)basePath).Any<char>((Func<, >)(object)_003C_003E9__16_))
			{
				Match match = ReBasePath.Match(basePath);
				if (match.Success)
				{
					bool flag2 = match.Value != basePath;
					if (!flag2 && !flag2)
					{
						Func<char, bool> cpp2il__autoParamName__idx_ = default(Func<char, bool>);
						if (_003C_003Ec._003C_003E9__16_1 == null)
						{
							bool result = default(bool);
							cpp2il__autoParamName__idx_ = (Func<char, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((char chr) => result));
						}
						bool flag3 = ((IEnumerable<>)(object)source).Any<char>((Func<, >)(object)cpp2il__autoParamName__idx_);
						if (!flag3 && !flag3)
						{
							Regex regex = ReProtoName;
							Match match2 = default(Match);
							if (match2.Success)
							{
								string value = match2.Value;
								bool flag4 = default(bool);
								bool flag5 = default(bool);
								bool flag6 = default(bool);
								if (!flag4 && (!flag5 || !flag6))
								{
									int num2 = 0;
									bool flag7 = default(bool);
									if (flag && TryGet(previousName, out *(ProtoDesc*)num))
									{
										string a = default(string);
										flag7 = string.Equals(a, (string)num);
										if (flag7)
										{
											goto IL_00f7;
										}
									}
									IReadOnlyFileSystem readOnlyFileSystem = FileSystem;
									if (flag7)
									{
									}
								}
							}
						}
					}
				}
			}
			goto IL_00f7;
			IL_00f7:
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x288AD70", Offset = "0x2889770", VA = "0x18288AD70")]
		public bool Create(string basePath, string source, string name, string typeName, string copyFromName)
		{
			//Discarded unreachable code: IL_008d, IL_00ae, IL_00ba, IL_00c0
			//IL_0040: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if ((flag || CreateFolder(basePath)) && flag2)
				{
					ProtoDesc protoDesc = new ProtoDesc();
					protoDesc.BasePath = basePath;
					protoDesc.Source = source;
					protoDesc.Name = (string)0;
					string _003CPath_003Ek__BackingField = default(string);
					protoDesc.Path = _003CPath_003Ek__BackingField;
					protoDesc.Parser = (MessageParser)num;
					Type type = default(Type);
					protoDesc.Type = type;
					bool flag3 = default(bool);
					if ((object)type != null || !flag3)
					{
						IMessage message = default(IMessage);
						protoDesc.Message = message;
						if (message != null)
						{
						}
						if (FileSystem == null || message != null)
						{
							Dictionary<string, ProtoDesc> dictionary = ProtoObjects;
							throw new NullReferenceException();
						}
						throw new InvalidCastException();
					}
					IMessage message2 = (protoDesc.Message = ((IMessage)num).Clone(useCloneDefaultData: true));
				}
				if (num == 0)
				{
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x288B170", Offset = "0x2889B70", VA = "0x18288B170")]
		public unsafe bool Edit(string previousName, string basePath, string source, string name, string typeName)
		{
			//Discarded unreachable code: IL_0092, IL_0098, IL_009e, IL_00a4, IL_00aa, IL_00b0, IL_00b6, IL_00bc
			//IL_004f: Expected I4, but got O
			//IL_005b: Expected I4, but got O
			//IL_0073: Expected I4, but got O
			int num = 0;
			bool flag = default(bool);
			if (flag && TryGet(previousName, out *(ProtoDesc*)num))
			{
				IReadOnlyFileSystem readOnlyFileSystem = FileSystem;
				string text = default(string);
				string text2 = Path.Combine(text, previousName);
				IReadOnlyFileSystem readOnlyFileSystem2 = FileSystem;
				string dstFileName = Path.Combine(text2, text);
				if (MoveFile(text2, dstFileName))
				{
					num += 16;
					((int*)num)->m_value = (int)basePath;
					num += 24;
					((int*)num)->m_value = (int)source;
					num += 32;
					((int*)num)->m_value = 0;
					num += 40;
					((int*)num)->m_value = (int)text;
					Dictionary<string, ProtoDesc> dictionary = ProtoObjects;
					Dictionary<string, ProtoDesc> dictionary2 = ProtoObjects;
					throw new NullReferenceException();
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x288D730", Offset = "0x288C130", VA = "0x18288D730")]
		public bool Remove(string name)
		{
			//Discarded unreachable code: IL_002c, IL_0032
			bool flag = default(bool);
			if (flag)
			{
				IReadOnlyFileSystem readOnlyFileSystem = FileSystem;
				string path = default(string);
				if (RemoveFile(path))
				{
					bool flag2 = ((Dictionary<TKey, TValue>)(object)ProtoObjects).Remove((TKey)name);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x288ABC0", Offset = "0x28895C0", VA = "0x18288ABC0")]
		private bool CreateFolder(string path)
		{
			//Discarded unreachable code: IL_0050
			IReadOnlyFileSystem readOnlyFileSystem = FileSystem;
			if ((object)typeof(Path).TypeHandle == null)
			{
				string directoryName = Path.GetDirectoryName(path);
				bool flag = CreateFolder(directoryName);
				if (flag)
				{
					IReadOnlyFileSystem readOnlyFileSystem2 = FileSystem;
					if (!flag)
					{
						throw new InvalidCastException();
					}
					if (!flag)
					{
						throw new InvalidCastException();
					}
					int num = 0;
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
				}
				int num3 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x288C550", Offset = "0x288AF50", VA = "0x18288C550")]
		private bool MoveFile(string srcFileName, string dstFileName)
		{
			//Discarded unreachable code: IL_0078, IL_007e, IL_0090
			string directoryName = Path.GetDirectoryName(dstFileName);
			bool flag = CreateFolder(directoryName);
			if (flag)
			{
				IReadOnlyFileSystem readOnlyFileSystem = FileSystem;
				if (!flag)
				{
					throw new InvalidCastException();
				}
				if (!flag)
				{
					throw new InvalidCastException();
				}
				string text = srcFileName + ".meta";
				IReadOnlyFileSystem readOnlyFileSystem2 = FileSystem;
				if (text != null)
				{
					IReadOnlyFileSystem readOnlyFileSystem3 = FileSystem;
					string text2 = dstFileName + ".meta";
					if (text2 == null)
					{
						throw new InvalidCastException();
					}
					if (text2 == null)
					{
						goto IL_006c;
					}
				}
				string directoryName2 = Path.GetDirectoryName(srcFileName);
				RemoveEmptyFolder(directoryName2);
			}
			int num = 0;
			goto IL_006c;
			IL_006c:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x288D390", Offset = "0x288BD90", VA = "0x18288D390")]
		private void RemoveEmptyFolder(string path)
		{
			//Discarded unreachable code: IL_0057
			IReadOnlyFileSystem self = FileSystem;
			int num = 0;
			int searchOption = 0;
			string[] files = self.GetFiles(path, "*", (SearchOption)searchOption);
			if (files.Length == num)
			{
				IReadOnlyFileSystem readOnlyFileSystem = FileSystem;
				if (files == null || files == null)
				{
					throw new InvalidCastException();
				}
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				string path2 = path + ".meta";
				bool flag = RemoveFile(path2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x288D550", Offset = "0x288BF50", VA = "0x18288D550")]
		private bool RemoveFile(string path)
		{
			//Discarded unreachable code: IL_005b, IL_0061, IL_0073
			IReadOnlyFileSystem readOnlyFileSystem = FileSystem;
			if (".meta" != null)
			{
				if (".meta" != null)
				{
					string text = path + ".meta";
					IReadOnlyFileSystem readOnlyFileSystem2 = FileSystem;
					if (text != null)
					{
						IReadOnlyFileSystem readOnlyFileSystem3 = FileSystem;
						if (text == null)
						{
							throw new InvalidCastException();
						}
						if (text == null)
						{
							throw new InvalidCastException();
						}
					}
					string directoryName = Path.GetDirectoryName(path);
					RemoveEmptyFolder(directoryName);
					return true;
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x288E980", Offset = "0x288D380", VA = "0x18288E980")]
		private ProtoDatabase(IReadOnlyFileSystem fs, ILogger logger, IEnumerable<Assembly> assemblies, bool isEditor)
		{
			//IL_007d: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			string validPath = ValidPath;
			Regex regex = (ReBasePath = new Regex(validPath + "?([\\\\/]" + validPath + ")*"));
			Regex regex2 = (ReProtoName = new Regex("[a-zA-Z0-9_]+"));
			Dictionary<string, MessageParser> dictionary = (Parsers = (Dictionary<string, MessageParser>)(object)new Dictionary<TKey, TValue>());
			Dictionary<string, ProtoDesc> dictionary2 = (ProtoObjects = (Dictionary<string, ProtoDesc>)(object)new Dictionary<TKey, TValue>());
			Regex regex3 = new Regex("(?<basepath>.+[\\\\|/])?(?<source>.+)\\.(?<name>[a-zA-Z0-9_]+)\\[(?<type>[a-zA-Z0-9_\\.+]+)\\].proto.json");
			int num = 0;
			ReProtoFileName = regex3;
			int num2 = 0;
			base.FieldSetter((string)num2, (string)num, (object)")*");
			FileSystem = fs;
			Logger = logger;
			List<Assembly> list = (this.assemblies = (List<Assembly>)(object)Enumerable.ToList<Assembly>((IEnumerable<>)assemblies));
			this.isEditor = false;
			Refresh();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x288BAB0", Offset = "0x288A4B0", VA = "0x18288BAB0")]
		private Type FindType(string typeName)
		{
			//Discarded unreachable code: IL_002d
			int num;
			bool flag = default(bool);
			while (true)
			{
				num = 0;
				List<Assembly> list = assemblies;
				if (!flag)
				{
					break;
				}
				int num2 = 0;
				if ((IntPtr)(flag ? 1 : 0) != (IntPtr)num2)
				{
					num++;
					break;
				}
			}
			if (num + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x288D860", Offset = "0x288C260", VA = "0x18288D860")]
		public void SaveBinary(IFileSystem fs)
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076, IL_007c, IL_0082, IL_0088, IL_008e
			//IL_0034: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			int num = 0;
			ProtoDb protoDb = new ProtoDb();
			Dictionary<string, ProtoDesc> dictionary = ProtoObjects;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
				MapField<string, ProtoEntry> entries_ = protoDb.entries_;
				ProtoEntry protoEntry = new ProtoEntry();
				int num2 = 0;
				protoEntry.BasePath = (string)num2;
				protoEntry.Name = (string)num2;
				protoEntry.Path = (string)num2;
				protoEntry.Source = (string)num2;
				ByteString byteString2 = (protoEntry.Content = protoEntry.ToByteString());
			}
			byte[] array = protoDb.ToByteArray();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x288C190", Offset = "0x288AB90", VA = "0x18288C190")]
		public void LoadBinary()
		{
			//Discarded unreachable code: IL_0099, IL_009f, IL_00a5, IL_00ab
			//IL_0053: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			int num = 0;
			((Dictionary<TKey, TValue>)(object)ProtoObjects).Clear();
			byte[] data = Definitions.Util.FileSystem.Data.ReadAllBytes("protoDb.bin");
			MapField<string, ProtoEntry> entries_ = ((ProtoDb)((MessageParser<T>)(object)ProtoDb._parser).ParseFrom(data)).entries_;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				Dictionary<string, ProtoDesc> dictionary = ProtoObjects;
				ProtoDesc protoDesc = new ProtoDesc();
				int num2 = 0;
				protoDesc.BasePath = (string)num2;
				protoDesc.Name = (string)num2;
				protoDesc.Path = (string)num2;
				protoDesc.Source = (string)num2;
				Type type = (protoDesc.Type = FindType((string)num2));
				protoDesc.Parser = (MessageParser)num;
				IMessage _003CMessage_003Ek__BackingField = default(IMessage);
				protoDesc.Message = _003CMessage_003Ek__BackingField;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x288CAA0", Offset = "0x288B4A0", VA = "0x18288CAA0")]
		public void Refresh()
		{
			//Discarded unreachable code: IL_01f8, IL_01fe, IL_0204, IL_020a, IL_0210, IL_023a, IL_0240, IL_0246, IL_024c, IL_0252, IL_0258, IL_025e, IL_0264, IL_026a, IL_0270, IL_0276, IL_027c, IL_0282, IL_0288, IL_028e, IL_0294
			//IL_011c: Expected O, but got I4
			//IL_01a5: Expected O, but got I4
			uint num2 = default(uint);
			string text = default(string);
			MatchCollection matchCollection = default(MatchCollection);
			string _003CBasePath_003Ek__BackingField = default(string);
			bool flag = default(bool);
			bool flag2 = default(bool);
			Type _003CType_003Ek__BackingField = default(Type);
			while (true)
			{
				int num = 0;
				if ((isEditor ? 1 : 0) != num)
				{
					IReadOnlyFileSystem readOnlyFileSystem = FileSystem;
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					num += 408;
					if (num != 0)
					{
						char[] array = new char[1];
						char c = (array[0] = Path.DirectorySeparatorChar);
						string text2 = text.TrimStart(array);
						if (matchCollection.Count <= 0)
						{
							continue;
						}
						int i = 0;
						GroupCollection groups = matchCollection[i].Groups;
						string value = groups["basepath"].Value;
						if (!string.IsNullOrEmpty(value))
						{
							int stringLength = value.m_stringLength;
							int startIndex = 0;
							_003CBasePath_003Ek__BackingField = value.Substring(startIndex, stringLength);
						}
						string value2 = groups["source"].Value;
						string value3 = groups["name"].Value;
						string value4 = groups["type"].Value;
						while (!flag)
						{
						}
						if (!flag2)
						{
							ProtoDesc protoDesc = new ProtoDesc();
							protoDesc.BasePath = _003CBasePath_003Ek__BackingField;
							protoDesc.Source = value2;
							protoDesc.Name = value3;
							protoDesc.Path = text2;
							protoDesc.Parser = (MessageParser)num;
							protoDesc.Type = _003CType_003Ek__BackingField;
							throw new NullReferenceException();
						}
						string[] array2 = new string[6];
						if ("trying to add 2 table with the same name " != null && "trying to add 2 table with the same name " == null)
						{
							throw new IndexOutOfRangeException();
						}
						array2[0] = "trying to add 2 table with the same name ";
						if (value3 != null && "trying to add 2 table with the same name " == null)
						{
							throw new IndexOutOfRangeException();
						}
						array2[1] = value3;
						if (". from " != null && ". from " == null)
						{
							throw new IndexOutOfRangeException();
						}
						array2[2] = ". from ";
						if (num != 0 && ". from " == null)
						{
							throw new IndexOutOfRangeException();
						}
						array2[3] = (string)num;
						if (" and " != null && " and " == null)
						{
							throw new IndexOutOfRangeException();
						}
						array2[4] = " and ";
						if (text2 != null && " and " == null)
						{
							break;
						}
						array2[5] = text2;
						string text3 = string.Concat(array2);
					}
					num++;
					if (num != 0)
					{
					}
					if (num == 0)
					{
					}
				}
				LoadBinary();
				return;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x288DBA0", Offset = "0x288C5A0", VA = "0x18288DBA0")]
		private bool TryGetParser(string typeName, out MessageParser parser)
		{
			//Discarded unreachable code: IL_0057
			Dictionary<string, MessageParser> dictionary = Parsers;
			bool flag = default(bool);
			if (!flag)
			{
				Type type = FindType(typeName);
				int num = 0;
				if ((object)type != null)
				{
					PropertyInfo property = type.GetProperty("Parser");
				}
				if ((object)type != null)
				{
					int num2 = 0;
					object obj = default(object);
					if (obj == null)
					{
					}
					int num3 = 0;
					if (obj != null)
					{
						if (obj != null)
						{
							int num4 = 0;
							if (obj == null)
							{
								goto IL_005d;
							}
						}
						Dictionary<string, MessageParser> dictionary2 = Parsers;
						throw new NullReferenceException();
					}
					goto IL_005d;
				}
			}
			return flag;
			IL_005d:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x288DD70", Offset = "0x288C770", VA = "0x18288DD70")]
		public bool TryGet(string name, out IMessage message)
		{
			//Discarded unreachable code: IL_0008
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x288DDE0", Offset = "0x288C7E0", VA = "0x18288DDE0")]
		public unsafe bool TryGet(string name, out ProtoDesc protoDesc)
		{
			//Discarded unreachable code: IL_0030, IL_0036
			//IL_0027: Expected I4, but got O
			//IL_0022: Expected native int or pointer, but got O
			if ((object)typeof(ProtoParser).TypeHandle == null)
			{
				Dictionary<string, ProtoDesc> dictionary = ProtoObjects;
				bool flag = default(bool);
				if (flag)
				{
					IReadOnlyFileSystem readOnlyFileSystem = FileSystem;
					IMessage message = default(IMessage);
					((byte*)(IntPtr)readOnlyFileSystem.ReadAllBytes(name))->m_value = (byte)(int)message;
					if (readOnlyFileSystem == null)
					{
					}
				}
			}
			int num = 0;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x288DFA0", Offset = "0x288C9A0", VA = "0x18288DFA0")]
		public unsafe bool TrySet(string name, IMessage message, bool overrideIfExists, bool save = false)
		{
			Type type = default(Type);
			NullReferenceException ex = default(NullReferenceException);
			ProtoDesc protoDesc = default(ProtoDesc);
			Type _003CType_003Ek__BackingField = default(Type);
			while (true)
			{
				ILogger logger = Logger;
				int num = 0;
				if (logger != null)
				{
					string[] array = new string[0];
					if ("Trying to set new data in the database for '" != null && "Trying to set new data in the database for '" == null)
					{
						break;
					}
					array[0] = "Trying to set new data in the database for '";
					if (name != null && "Trying to set new data in the database for '" == null)
					{
						break;
					}
					array[1] = name;
					if ("' and " != null && "' and " == null)
					{
						break;
					}
					array[2] = "' and ";
					string text = "NOT overriding if exists";
					if (overrideIfExists)
					{
						text = "overriding if exists";
					}
					if (text != null && "' and " == null)
					{
						break;
					}
					array[3] = text;
					if ("." != null && "." == null)
					{
						break;
					}
					array[4] = ".";
					string text2 = string.Concat(array);
				}
				if (message == null)
				{
					continue;
				}
				if (TryGet(name, out *(ProtoDesc*)num) && !overrideIfExists)
				{
					if (Logger == null)
					{
						goto IL_0159;
					}
					string text3 = "Proto message already exists in the database for '" + name + "'. Skipping proto object set/override.";
				}
				if (num == 0)
				{
					goto IL_0105;
				}
				if ((object)type == null || Logger != null)
				{
					if (num == 0)
					{
						goto IL_0105;
					}
					protoDesc.Message = message;
					if (FileSystem != null && ex == null)
					{
						break;
					}
					if (0 == 0)
					{
					}
				}
				goto IL_0159;
				IL_0105:
				protoDesc = new ProtoDesc();
				protoDesc.Name = name;
				protoDesc.Parser = (MessageParser)typeof(IMessage).TypeHandle;
				protoDesc.Message = message;
				protoDesc.Type = _003CType_003Ek__BackingField;
				Dictionary<string, ProtoDesc> dictionary = ProtoObjects;
				throw new NullReferenceException();
				IL_0159:
				int num2 = 0;
				break;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x1B13330", Offset = "0x1B11D30", VA = "0x181B13330")]
		public IEnumerable<> Enumerate<T>()
		{
			Type typeFromHandle = typeof(Type);
			int num = 0;
			IEnumerator<IMessage> enumerator = (IEnumerator<IMessage>)((IEnumerable<T>)this.Enumerate(typeFromHandle)).GetEnumerator();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x288B7E0", Offset = "0x288A1E0", VA = "0x18288B7E0")]
		[IteratorStateMachine(typeof(_003CEnumerate_003Ed__61))]
		public IEnumerable<IMessage> Enumerate(Type type)
		{
			_003CEnumerate_003Ed__61 _003CEnumerate_003Ed__ = new _003CEnumerate_003Ed__61(-2);
			_003CEnumerate_003Ed__._003C_003E4__this = this;
			_003CEnumerate_003Ed__._003C_003E3__type = type;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x1B130F0", Offset = "0x1B11AF0", VA = "0x181B130F0")]
		public IEnumerable<KeyValuePair<string, T>> EnumerateWithId<T>()
		{
			Type typeFromHandle = typeof(Type);
			int num = 0;
			IEnumerator<KeyValuePair<string, IMessage>> enumerator = (IEnumerator<KeyValuePair<string, IMessage>>)((IEnumerable<T>)this.EnumerateWithId(typeFromHandle)).GetEnumerator();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x288B750", Offset = "0x288A150", VA = "0x18288B750")]
		[IteratorStateMachine(typeof(_003CEnumerateWithId_003Ed__63))]
		public IEnumerable<KeyValuePair<string, IMessage>> EnumerateWithId(Type type)
		{
			_003CEnumerateWithId_003Ed__63 _003CEnumerateWithId_003Ed__ = new _003CEnumerateWithId_003Ed__63(-2);
			_003CEnumerateWithId_003Ed__._003C_003E4__this = this;
			_003CEnumerateWithId_003Ed__._003C_003E3__type = type;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x288B520", Offset = "0x2889F20", VA = "0x18288B520")]
		public IEnumerable<(IMessage, string, string)> EnumerateFiles(string dirPath)
		{
			Func<string, bool> _003C_003E3__predicate = (Func<string, bool>)(object)(Func<T, TResult>)delegate(string x)
			{
				//Discarded unreachable code: IL_0016
				string directoryName = Path.GetDirectoryName(x);
				string value = dirPath;
				return directoryName.Contains(value);
			};
			_003CEnumerateFiles_003Ed__65 _003CEnumerateFiles_003Ed__ = new _003CEnumerateFiles_003Ed__65(-2);
			_003CEnumerateFiles_003Ed__._003C_003E4__this = this;
			_003CEnumerateFiles_003Ed__._003C_003E3__predicate = _003C_003E3__predicate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x288B490", Offset = "0x2889E90", VA = "0x18288B490")]
		[IteratorStateMachine(typeof(_003CEnumerateFiles_003Ed__65))]
		public IEnumerable<(IMessage, string, string)> EnumerateFiles(Func<string, bool> predicate)
		{
			_003CEnumerateFiles_003Ed__65 _003CEnumerateFiles_003Ed__ = new _003CEnumerateFiles_003Ed__65(-2);
			_003CEnumerateFiles_003Ed__._003C_003E4__this = this;
			_003CEnumerateFiles_003Ed__._003C_003E3__predicate = predicate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x1B13570", Offset = "0x1B11F70", VA = "0x181B13570")]
		public T Get<T>(string P_0) where T : class, IMessage, new()
		{
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x1B135B0", Offset = "0x1B11FB0", VA = "0x181B135B0")]
		public unsafe bool TryGet<T>(string P_0, out T value) where T : IMessage, new()
		{
			int num = 0;
			bool flag = TryGet(P_0, out *(IMessage*)num);
			if (flag && flag)
			{
				if (num == 0 || flag)
				{
					return true;
				}
				throw new InvalidCastException();
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x288BF80", Offset = "0x288A980", VA = "0x18288BF80")]
		public static ProtoDatabase Init(IReadOnlyFileSystem fs, IEnumerable<Assembly> assemblies, bool isEditor = true, [Optional] ILogger logger)
		{
			//Discarded unreachable code: IL_0014
			ValidPath = (string)(object)new ProtoDatabase(fs, logger, (IEnumerable<>)assemblies, isEditor);
			return Instance;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x288C790", Offset = "0x288B190", VA = "0x18288C790")]
		public static ProtoDatabase ReInit(IReadOnlyFileSystem fs, IEnumerable<Assembly> assemblies, bool isEditor = true, [Optional] ILogger logger)
		{
			ProtoDatabase protoDatabase = Instance;
			if (protoDatabase == null || protoDatabase.OnReloadEvent != null)
			{
			}
			ProtoDatabase protoDatabase2 = Instance;
			if (protoDatabase2 == null || protoDatabase2.FileSystem != null)
			{
			}
			ValidPath = (string)(object)new ProtoDatabase(fs, logger, (IEnumerable<>)assemblies, isEditor);
			return Instance;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x288B120", Offset = "0x2889B20", VA = "0x18288B120", Slot = "4")]
		public void Dispose()
		{
			if (FileSystem == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x288E930", Offset = "0x288D330", VA = "0x18288E930")]
		static ProtoDatabase()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
