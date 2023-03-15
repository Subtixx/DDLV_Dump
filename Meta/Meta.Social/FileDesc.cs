using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B59")]
	public sealed class FileDesc : IMessage<FileDesc>, IMessage, IEquatable<FileDesc>, IDeepCloneable<FileDesc>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002BF3")]
		private static readonly MessageParser<FileDesc> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BF4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002BF5")]
		public const int PathFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BF6")]
		private string path_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002BF7")]
		public const int SizeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002BF8")]
		private int size_;

		[Cpp2IlInjected.Token(Token = "0x4002BF9")]
		public const int Crc32FieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002BFA")]
		private uint crc32_;

		[Cpp2IlInjected.Token(Token = "0x17001077")]
		[DebuggerNonUserCode]
		public static MessageParser<FileDesc> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006024")]
			[Cpp2IlInjected.Address(RVA = "0x17FC0D0", Offset = "0x17FAAD0", VA = "0x1817FC0D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001078")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006025")]
			[Cpp2IlInjected.Address(RVA = "0x17FC000", Offset = "0x17FAA00", VA = "0x1817FC000")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001079")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006026")]
			[Cpp2IlInjected.Address(RVA = "0x17FC130", Offset = "0x17FAB30", VA = "0x1817FC130", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107A")]
		[DebuggerNonUserCode]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600602A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return path_;
			}
			[Cpp2IlInjected.Token(Token = "0x600602B")]
			[Cpp2IlInjected.Address(RVA = "0x17FC240", Offset = "0x17FAC40", VA = "0x1817FC240")]
			set
			{
				string text = (path_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107B")]
		[DebuggerNonUserCode]
		public int Size
		{
			[Cpp2IlInjected.Token(Token = "0x600602C")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return size_;
			}
			[Cpp2IlInjected.Token(Token = "0x600602D")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				size_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700107C")]
		[DebuggerNonUserCode]
		public uint Crc32
		{
			[Cpp2IlInjected.Token(Token = "0x600602E")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return crc32_;
			}
			[Cpp2IlInjected.Token(Token = "0x600602F")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				crc32_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006027")]
		[Cpp2IlInjected.Address(RVA = "0x17FBFB0", Offset = "0x17FA9B0", VA = "0x1817FBFB0")]
		[DebuggerNonUserCode]
		public FileDesc()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6006028")]
		[Cpp2IlInjected.Address(RVA = "0x17FBF10", Offset = "0x17FA910", VA = "0x1817FBF10")]
		[DebuggerNonUserCode]
		public FileDesc(FileDesc other)
		{
			string text = (path_ = other.path_);
			int num = (size_ = other.size_);
			uint num2 = (crc32_ = other.crc32_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006029")]
		[Cpp2IlInjected.Address(RVA = "0x17FB6D0", Offset = "0x17FA0D0", VA = "0x1817FB6D0", Slot = "10")]
		[DebuggerNonUserCode]
		public FileDesc Clone()
		{
			//Discarded unreachable code: IL_0052
			FileDesc fileDesc = new FileDesc();
			fileDesc.path_ = "";
			string text = (fileDesc.path_ = path_);
			int num = (fileDesc.size_ = size_);
			uint num2 = (fileDesc.crc32_ = crc32_);
			UnknownFieldSet unknownFieldSet = (fileDesc._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return fileDesc;
		}

		[Cpp2IlInjected.Token(Token = "0x6006030")]
		[Cpp2IlInjected.Address(RVA = "0x17FB7A0", Offset = "0x17FA1A0", VA = "0x1817FB7A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = path_;
				bool flag = default(bool);
				if (!flag && size_ == (flag ? 1 : 0) && crc32_ == (flag ? 1u : 0u))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006031")]
		[Cpp2IlInjected.Address(RVA = "0x17FB860", Offset = "0x17FA260", VA = "0x1817FB860", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FileDesc other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.path_;
				if (!(path_ != text))
				{
					int num = other.size_;
					if (size_ == num)
					{
						uint num2 = other.crc32_;
						if (crc32_ == num2)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006032")]
		[Cpp2IlInjected.Address(RVA = "0x17FB9E0", Offset = "0x17FA3E0", VA = "0x1817FB9E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0041
			int num = 0;
			string text = path_;
			if (text.m_stringLength != num)
			{
				int hashCode = text.GetHashCode();
			}
			if (size_ != 0)
			{
			}
			if (crc32_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006033")]
		[Cpp2IlInjected.Address(RVA = "0x17FBCE0", Offset = "0x17FA6E0", VA = "0x1817FBCE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006034")]
		[Cpp2IlInjected.Address(RVA = "0x17FBD40", Offset = "0x17FA740", VA = "0x1817FBD40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			if (path_.m_stringLength != 0)
			{
				string value = path_;
				output.WriteString(value);
			}
			if (size_ != 0)
			{
				int value2 = size_;
				output.WriteInt32(value2);
			}
			if (crc32_ != 0)
			{
				uint value3 = crc32_;
				output.WriteUInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006035")]
		[Cpp2IlInjected.Address(RVA = "0x17FB550", Offset = "0x17F9F50", VA = "0x1817FB550", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0076
			string text = path_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			int num3 = size_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			uint num5 = crc32_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeUInt32Size(num5);
				num6++;
				num += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006036")]
		[Cpp2IlInjected.Address(RVA = "0x17FBB30", Offset = "0x17FA530", VA = "0x1817FBB30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FileDesc other)
		{
			//Discarded unreachable code: IL_005e
			if (other != null)
			{
				string text = other.path_;
				if (text.m_stringLength != 0)
				{
					Path = text;
				}
				int num = other.size_;
				if (num != 0)
				{
					size_ = num;
				}
				uint num2 = other.crc32_;
				if (num2 != 0)
				{
					crc32_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006037")]
		[Cpp2IlInjected.Address(RVA = "0x17FBA80", Offset = "0x17FA480", VA = "0x1817FBA80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005e
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Path = input.ReadString());
				}
				int num2 = default(int);
				if (num == 16)
				{
					num2 = (size_ = input.ReadInt32());
				}
				if (num2 == 24)
				{
					int num3 = (int)(crc32_ = (uint)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006038")]
		[Cpp2IlInjected.Address(RVA = "0x17FB8E0", Offset = "0x17FA2E0", VA = "0x1817FB8E0", Slot = "11")]
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
					uint num2 = crc32_;
				}
				int num3 = size_;
			}
			string text = path_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006039")]
		[Cpp2IlInjected.Address(RVA = "0x17FBBB0", Offset = "0x17FA5B0", VA = "0x1817FBBB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					crc32_ = (uint)(int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					size_ = (int)obj;
					break;
				}
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600603A")]
		[Cpp2IlInjected.Address(RVA = "0x17FB650", Offset = "0x17FA050", VA = "0x1817FB650", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					crc32_ = 0u;
					break;
				case 0:
					size_ = 0;
					break;
				}
			}
			else
			{
				Path = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600603B")]
		[Cpp2IlInjected.Address(RVA = "0x17FBE00", Offset = "0x17FA800", VA = "0x1817FBE00")]
		static FileDesc()
		{
			Func<FileDesc> func = default(Func<FileDesc>);
			_parser = (MessageParser<FileDesc>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
