using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class LoadAndInitProfileResult : IMessage<LoadAndInitProfileResult>, IMessage, IEquatable<LoadAndInitProfileResult>, IDeepCloneable<LoadAndInitProfileResult>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private static readonly MessageParser<LoadAndInitProfileResult> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public const int LoadResultFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private LoadProfileResult loadResult_;

		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public const int InitResultFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private InitProfileResult initResult_;

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		[DebuggerNonUserCode]
		public static MessageParser<LoadAndInitProfileResult> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x18AC010", Offset = "0x18AAA10", VA = "0x1818AC010")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x18ABF40", Offset = "0x18AA940", VA = "0x1818ABF40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x18AC070", Offset = "0x18AAA70", VA = "0x1818AC070", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		[DebuggerNonUserCode]
		public LoadProfileResult LoadResult
		{
			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return loadResult_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				loadResult_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		[DebuggerNonUserCode]
		public InitProfileResult InitResult
		{
			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return initResult_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				initResult_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LoadAndInitProfileResult()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x18ABDD0", Offset = "0x18AA7D0", VA = "0x1818ABDD0")]
		[DebuggerNonUserCode]
		public LoadAndInitProfileResult(LoadAndInitProfileResult other)
		{
			//IL_003e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			LoadProfileResult loadProfileResult = other.loadResult_;
			if (loadProfileResult != null)
			{
				LoadProfileResult loadProfileResult2 = new LoadProfileResult
				{
					message_ = ""
				};
				Profile profile_ = loadProfileResult.profile_;
				int num = 0;
				if (profile_ != null)
				{
					Profile profile = profile_.Clone();
				}
				loadProfileResult2.profile_ = (Profile)num;
				LoadProfileResult.Types.ErrorCode errorCode = (loadProfileResult2.result_ = loadProfileResult.result_);
				string text = (loadProfileResult2.message_ = loadProfileResult.message_);
				UnknownFieldSet unknownFieldSet = (loadProfileResult2._unknownFields = UnknownFieldSet.Clone(loadProfileResult._unknownFields));
			}
			int num2 = 0;
			loadResult_ = (LoadProfileResult)num2;
			InitProfileResult initProfileResult = other.initResult_;
			InitProfileResult initProfileResult2 = default(InitProfileResult);
			if (initProfileResult != null)
			{
				initProfileResult2 = initProfileResult.Clone();
			}
			initResult_ = initProfileResult2;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x18AB3B0", Offset = "0x18A9DB0", VA = "0x1818AB3B0", Slot = "10")]
		[DebuggerNonUserCode]
		public LoadAndInitProfileResult Clone()
		{
			//Discarded unreachable code: IL_00b5
			//IL_0040: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			LoadAndInitProfileResult loadAndInitProfileResult = new LoadAndInitProfileResult();
			LoadProfileResult loadProfileResult = loadResult_;
			if (loadProfileResult != null)
			{
				LoadProfileResult loadProfileResult2 = new LoadProfileResult();
				loadProfileResult2.message_ = "";
				Profile profile_ = loadProfileResult.profile_;
				int num = 0;
				if (profile_ != null)
				{
					Profile profile = profile_.Clone();
				}
				loadProfileResult2.profile_ = (Profile)num;
				LoadProfileResult.Types.ErrorCode errorCode = (loadProfileResult2.result_ = loadProfileResult.result_);
				string text = (loadProfileResult2.message_ = loadProfileResult.message_);
				UnknownFieldSet unknownFieldSet = (loadProfileResult2._unknownFields = UnknownFieldSet.Clone(loadProfileResult._unknownFields));
			}
			int num2 = 0;
			loadAndInitProfileResult.loadResult_ = (LoadProfileResult)num2;
			InitProfileResult initProfileResult = initResult_;
			InitProfileResult initProfileResult2 = default(InitProfileResult);
			if (initProfileResult != null)
			{
				initProfileResult2 = initProfileResult.Clone();
			}
			loadAndInitProfileResult.initResult_ = initProfileResult2;
			UnknownFieldSet unknownFieldSet2 = (loadAndInitProfileResult._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return loadAndInitProfileResult;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x18AB5D0", Offset = "0x18A9FD0", VA = "0x1818AB5D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(loadResult_, other) && object.Equals(initResult_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LoadAndInitProfileResult other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				LoadProfileResult objB = other.loadResult_;
				if (object.Equals(loadResult_, objB))
				{
					InitProfileResult objB2 = other.initResult_;
					if (object.Equals(initResult_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				LoadProfileResult loadProfileResult = loadResult_;
				if (loadProfileResult != null)
				{
					int hashCode = loadProfileResult.GetHashCode();
				}
				InitProfileResult initProfileResult = initResult_;
				if (initProfileResult != null)
				{
					int hashCode2 = initProfileResult.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x18ABBD0", Offset = "0x18AA5D0", VA = "0x1818ABBD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)loadResult_ != 0)
			{
				LoadProfileResult value = loadResult_;
				output.WriteMessage(value);
			}
			if ((long)initResult_ != 0)
			{
				InitProfileResult value2 = initResult_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x18AB2B0", Offset = "0x18A9CB0", VA = "0x1818AB2B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				LoadProfileResult loadProfileResult = loadResult_;
				num = 0;
				if (loadProfileResult != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(loadProfileResult);
				}
				InitProfileResult initProfileResult = initResult_;
				if (initProfileResult != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(initProfileResult);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x18AB7A0", Offset = "0x18AA1A0", VA = "0x1818AB7A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LoadAndInitProfileResult other)
		{
			//Discarded unreachable code: IL_012c
			if (other == null)
			{
				return;
			}
			LoadProfileResult loadProfileResult = other.loadResult_;
			if (loadProfileResult != null)
			{
				LoadProfileResult loadProfileResult2 = loadResult_;
				if (loadProfileResult2 == null)
				{
					LoadProfileResult loadProfileResult3 = new LoadProfileResult();
					loadProfileResult3.message_ = "";
					loadResult_ = loadProfileResult3;
					LoadProfileResult loadProfileResult4 = loadResult_;
				}
				if (loadProfileResult != null)
				{
					if ((long)loadProfileResult.profile_ != 0)
					{
						Profile profile_ = default(Profile);
						if (loadProfileResult2.profile_ == null)
						{
							Profile profile = (loadProfileResult2.profile_ = new Profile());
							profile_ = loadProfileResult2.profile_;
						}
						Profile profile_2 = loadProfileResult.profile_;
						profile_.MergeFrom(profile_2);
					}
					LoadProfileResult.Types.ErrorCode result_ = loadProfileResult.result_;
					if (result_ != 0)
					{
						loadProfileResult2.result_ = result_;
					}
					string message_ = loadProfileResult.message_;
					if (message_.m_stringLength != 0)
					{
						loadProfileResult2.Message = message_;
					}
					UnknownFieldSet unknownFields = loadProfileResult._unknownFields;
					UnknownFieldSet unknownFieldSet = (loadProfileResult2._unknownFields = UnknownFieldSet.MergeFrom(loadProfileResult2._unknownFields, unknownFields));
				}
			}
			if ((long)other.initResult_ != 0)
			{
				InitProfileResult initProfileResult2 = default(InitProfileResult);
				if (initResult_ == null)
				{
					InitProfileResult initProfileResult = (initResult_ = new InitProfileResult());
					initProfileResult2 = initResult_;
				}
				InitProfileResult other2 = other.initResult_;
				initProfileResult2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x18AB9D0", Offset = "0x18AA3D0", VA = "0x1818AB9D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				LoadProfileResult loadProfileResult = loadResult_;
				if (loadProfileResult == null)
				{
					LoadProfileResult loadProfileResult2 = (loadResult_ = new LoadProfileResult());
				}
				input.ReadMessage(loadProfileResult);
			}
			if (num == 18)
			{
				InitProfileResult builder = default(InitProfileResult);
				if (initResult_ == null)
				{
					InitProfileResult initProfileResult = (initResult_ = new InitProfileResult());
					builder = initResult_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x18AB690", Offset = "0x18AA090", VA = "0x1818AB690", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				LoadProfileResult loadProfileResult = loadResult_;
			}
			if (fieldNumber == 2)
			{
				InitProfileResult initProfileResult = initResult_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x18ABB10", Offset = "0x18AA510", VA = "0x1818ABB10", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					loadResult_ = (LoadProfileResult)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x18ABCC0", Offset = "0x18AA6C0", VA = "0x1818ABCC0")]
		static LoadAndInitProfileResult()
		{
			Func<LoadAndInitProfileResult> func = default(Func<LoadAndInitProfileResult>);
			_parser = (MessageParser<LoadAndInitProfileResult>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
