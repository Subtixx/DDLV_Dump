using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000770")]
	public sealed class FileChoiceOptions : IMessage<FileChoiceOptions>, IMessage, IEquatable<FileChoiceOptions>, IDeepCloneable<FileChoiceOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002503")]
		private static readonly MessageParser<FileChoiceOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002504")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002505")]
		public const int DirectoryFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002506")]
		private string directory_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002507")]
		public const int RecursiveFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002508")]
		private bool recursive_;

		[Cpp2IlInjected.Token(Token = "0x4002509")]
		public const int SearchPatternFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400250A")]
		private string searchPattern_ = "";

		[Cpp2IlInjected.Token(Token = "0x170014CE")]
		[DebuggerNonUserCode]
		public static MessageParser<FileChoiceOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005211")]
			[Cpp2IlInjected.Address(RVA = "0x2CB2BE0", Offset = "0x2CB15E0", VA = "0x182CB2BE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014CF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005212")]
			[Cpp2IlInjected.Address(RVA = "0x2CB2B10", Offset = "0x2CB1510", VA = "0x182CB2B10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005213")]
			[Cpp2IlInjected.Address(RVA = "0x2CB2C40", Offset = "0x2CB1640", VA = "0x182CB2C40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D1")]
		[DebuggerNonUserCode]
		public string Directory
		{
			[Cpp2IlInjected.Token(Token = "0x6005217")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return directory_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005218")]
			[Cpp2IlInjected.Address(RVA = "0x2CB2D50", Offset = "0x2CB1750", VA = "0x182CB2D50")]
			set
			{
				string text = (directory_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D2")]
		[DebuggerNonUserCode]
		public bool Recursive
		{
			[Cpp2IlInjected.Token(Token = "0x6005219")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return recursive_;
			}
			[Cpp2IlInjected.Token(Token = "0x600521A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				recursive_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D3")]
		[DebuggerNonUserCode]
		public string SearchPattern
		{
			[Cpp2IlInjected.Token(Token = "0x600521B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return searchPattern_;
			}
			[Cpp2IlInjected.Token(Token = "0x600521C")]
			[Cpp2IlInjected.Address(RVA = "0x2CB2DC0", Offset = "0x2CB17C0", VA = "0x182CB2DC0")]
			set
			{
				string text = (searchPattern_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005210")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2140", Offset = "0x2CB0B40", VA = "0x182CB2140")]
		public List<string> GetFileChoices(bool isAndroid, [Optional] IReadOnlyFileSystem fileSystem)
		{
			//Discarded unreachable code: IL_006a, IL_0070
			//IL_004c: Expected O, but got I4
			int num = 0;
			if (fileSystem == null)
			{
			}
			List<string> list = (List<string>)(object)new List<T>();
			((List<T>)(object)list).Add((T)"");
			string text = default(string);
			if (list != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (num != 0)
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_005d;
						}
						num++;
					}
					text = directory_ + "/" + (string)num;
					((List<T>)(object)list).Add((T)text);
					text += text;
					goto IL_005d;
				}
				goto IL_0064;
			}
			goto IL_0068;
			IL_0064:
			if (num == 0)
			{
			}
			goto IL_0068;
			IL_005d:
			text += text;
			goto IL_0064;
			IL_0068:
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6005214")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2AB0", Offset = "0x2CB14B0", VA = "0x182CB2AB0")]
		[DebuggerNonUserCode]
		public FileChoiceOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005215")]
		[Cpp2IlInjected.Address(RVA = "0x2CB29E0", Offset = "0x2CB13E0", VA = "0x182CB29E0")]
		[DebuggerNonUserCode]
		public FileChoiceOptions(FileChoiceOptions other)
		{
			string text = (directory_ = other.directory_);
			bool flag = (recursive_ = other.recursive_);
			string text2 = (searchPattern_ = other.searchPattern_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005216")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1E10", Offset = "0x2CB0810", VA = "0x182CB1E10", Slot = "10")]
		[DebuggerNonUserCode]
		public FileChoiceOptions Clone()
		{
			//Discarded unreachable code: IL_005d
			FileChoiceOptions fileChoiceOptions = new FileChoiceOptions();
			fileChoiceOptions.directory_ = "";
			fileChoiceOptions.searchPattern_ = "";
			string text = (fileChoiceOptions.directory_ = directory_);
			bool flag = (fileChoiceOptions.recursive_ = recursive_);
			string text2 = (fileChoiceOptions.searchPattern_ = searchPattern_);
			UnknownFieldSet unknownFieldSet = (fileChoiceOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return fileChoiceOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x600521D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1F10", Offset = "0x2CB0910", VA = "0x182CB1F10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = directory_;
				bool flag = default(bool);
				if (!flag && recursive_ == flag)
				{
					string text2 = searchPattern_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600521E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1FE0", Offset = "0x2CB09E0", VA = "0x182CB1FE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FileChoiceOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.directory_;
				if (!(directory_ != text))
				{
					bool flag = other.recursive_;
					if (recursive_ == flag)
					{
						string text2 = other.searchPattern_;
						if (!(searchPattern_ != text2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600521F")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2480", Offset = "0x2CB0E80", VA = "0x182CB2480", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0053
			string text = directory_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (recursive_)
			{
			}
			string text2 = searchPattern_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005220")]
		[Cpp2IlInjected.Address(RVA = "0x2CB27A0", Offset = "0x2CB11A0", VA = "0x182CB27A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005221")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2800", Offset = "0x2CB1200", VA = "0x182CB2800", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0062
			if (directory_.m_stringLength != 0)
			{
				string value = directory_;
				output.WriteString(value);
			}
			if (recursive_)
			{
				bool value2 = recursive_;
				output.WriteBool(value2);
			}
			if (searchPattern_.m_stringLength != 0)
			{
				string value3 = searchPattern_;
				output.WriteString(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005222")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1CA0", Offset = "0x2CB06A0", VA = "0x182CB1CA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_005d
			string text = directory_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
			}
			string text2 = searchPattern_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005223")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2530", Offset = "0x2CB0F30", VA = "0x182CB2530", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FileChoiceOptions other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				string text = other.directory_;
				if (text.m_stringLength != 0)
				{
					Directory = text;
				}
				bool flag = other.recursive_;
				if (flag)
				{
					recursive_ = flag;
				}
				string text2 = other.searchPattern_;
				if (text2.m_stringLength != 0)
				{
					SearchPattern = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005224")]
		[Cpp2IlInjected.Address(RVA = "0x2CB25C0", Offset = "0x2CB0FC0", VA = "0x182CB25C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Directory = input.ReadString());
				}
				bool flag = default(bool);
				if (num == 16)
				{
					flag = (recursive_ = input.ReadBool());
				}
				if (flag)
				{
					string text4 = (SearchPattern = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005225")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2060", Offset = "0x2CB0A60", VA = "0x182CB2060", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					string text = searchPattern_;
				}
				bool flag = recursive_;
			}
			string text2 = directory_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005226")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2680", Offset = "0x2CB1080", VA = "0x182CB2680", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						SearchPattern = (string)num2;
						break;
					}
					throw new InvalidCastException();
				}
				case 0:
				{
					object obj = default(object);
					recursive_ = (byte)(int)obj != 0;
					break;
				}
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005227")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1D80", Offset = "0x2CB0780", VA = "0x182CB1D80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					SearchPattern = "";
					break;
				case 0:
					recursive_ = false;
					break;
				}
			}
			else
			{
				Directory = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005228")]
		[Cpp2IlInjected.Address(RVA = "0x2CB28D0", Offset = "0x2CB12D0", VA = "0x182CB28D0")]
		static FileChoiceOptions()
		{
			Func<FileChoiceOptions> func = default(Func<FileChoiceOptions>);
			_parser = (MessageParser<FileChoiceOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
