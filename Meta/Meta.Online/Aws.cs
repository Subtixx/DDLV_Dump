using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E35")]
	public sealed class Aws : IMessage<Aws>, IMessage, IEquatable<Aws>, IDeepCloneable<Aws>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4003973")]
		private static readonly MessageParser<Aws> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003974")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003975")]
		public const int ApiKeyFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003976")]
		private string apiKey_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003977")]
		public const int SecretFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003978")]
		private string secret_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003979")]
		public const int BucketNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400397A")]
		private string bucketName_ = "";

		[Cpp2IlInjected.Token(Token = "0x400397B")]
		public const int BucketRegionFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400397C")]
		private string bucketRegion_ = "";

		[Cpp2IlInjected.Token(Token = "0x170014D6")]
		[DebuggerNonUserCode]
		public static MessageParser<Aws> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60077A2")]
			[Cpp2IlInjected.Address(RVA = "0x1AB7F60", Offset = "0x1AB6960", VA = "0x181AB7F60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60077A3")]
			[Cpp2IlInjected.Address(RVA = "0x1AB7E90", Offset = "0x1AB6890", VA = "0x181AB7E90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60077A4")]
			[Cpp2IlInjected.Address(RVA = "0x1AB7FC0", Offset = "0x1AB69C0", VA = "0x181AB7FC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014D9")]
		[DebuggerNonUserCode]
		public string ApiKey
		{
			[Cpp2IlInjected.Token(Token = "0x60077A8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return apiKey_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077A9")]
			[Cpp2IlInjected.Address(RVA = "0x1AB80D0", Offset = "0x1AB6AD0", VA = "0x181AB80D0")]
			set
			{
				string text = (apiKey_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DA")]
		[DebuggerNonUserCode]
		public string Secret
		{
			[Cpp2IlInjected.Token(Token = "0x60077AA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return secret_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077AB")]
			[Cpp2IlInjected.Address(RVA = "0x1AB8220", Offset = "0x1AB6C20", VA = "0x181AB8220")]
			set
			{
				string text = (secret_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DB")]
		[DebuggerNonUserCode]
		public string BucketName
		{
			[Cpp2IlInjected.Token(Token = "0x60077AC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return bucketName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077AD")]
			[Cpp2IlInjected.Address(RVA = "0x1AB8140", Offset = "0x1AB6B40", VA = "0x181AB8140")]
			set
			{
				string text = (bucketName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DC")]
		[DebuggerNonUserCode]
		public string BucketRegion
		{
			[Cpp2IlInjected.Token(Token = "0x60077AE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return bucketRegion_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077AF")]
			[Cpp2IlInjected.Address(RVA = "0x1AB81B0", Offset = "0x1AB6BB0", VA = "0x181AB81B0")]
			set
			{
				string text = (bucketRegion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077A5")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7E10", Offset = "0x1AB6810", VA = "0x181AB7E10")]
		[DebuggerNonUserCode]
		public Aws()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60077A6")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7CF0", Offset = "0x1AB66F0", VA = "0x181AB7CF0")]
		[DebuggerNonUserCode]
		public Aws(Aws other)
		{
			string text = (apiKey_ = other.apiKey_);
			string text2 = (secret_ = other.secret_);
			string text3 = (bucketName_ = other.bucketName_);
			string text4 = (bucketRegion_ = other.bucketRegion_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60077A7")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7300", Offset = "0x1AB5D00", VA = "0x181AB7300", Slot = "10")]
		[DebuggerNonUserCode]
		public Aws Clone()
		{
			//Discarded unreachable code: IL_0083
			Aws aws = new Aws();
			aws.apiKey_ = "";
			aws.secret_ = "";
			aws.bucketName_ = "";
			aws.bucketRegion_ = "";
			string text = (aws.apiKey_ = apiKey_);
			string text2 = (aws.secret_ = secret_);
			string text3 = (aws.bucketName_ = bucketName_);
			string text4 = (aws.bucketRegion_ = bucketRegion_);
			UnknownFieldSet unknownFieldSet = (aws._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return aws;
		}

		[Cpp2IlInjected.Token(Token = "0x60077B0")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7450", Offset = "0x1AB5E50", VA = "0x181AB7450", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = apiKey_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = secret_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = bucketName_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							string text4 = bucketRegion_;
							bool flag4 = default(bool);
							if (!flag4)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60077B1")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7540", Offset = "0x1AB5F40", VA = "0x181AB7540", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Aws other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.apiKey_;
				if (!(apiKey_ != text))
				{
					string text2 = other.secret_;
					if (!(secret_ != text2))
					{
						string text3 = other.bucketName_;
						if (!(bucketName_ != text3))
						{
							string text4 = other.bucketRegion_;
							if (!(bucketRegion_ != text4))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60077B2")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7690", Offset = "0x1AB6090", VA = "0x181AB7690", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_007c
			string text = apiKey_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = secret_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = bucketName_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = bucketRegion_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60077B3")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7A70", Offset = "0x1AB6470", VA = "0x181AB7A70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60077B4")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7AD0", Offset = "0x1AB64D0", VA = "0x181AB7AD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0086
			if (apiKey_.m_stringLength != 0)
			{
				string value = apiKey_;
				output.WriteString(value);
			}
			if (secret_.m_stringLength != 0)
			{
				string value2 = secret_;
				output.WriteString(value2);
			}
			if (bucketName_.m_stringLength != 0)
			{
				string value3 = bucketName_;
				output.WriteString(value3);
			}
			if (bucketRegion_.m_stringLength != 0)
			{
				string value4 = bucketRegion_;
				output.WriteString(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60077B5")]
		[Cpp2IlInjected.Address(RVA = "0x1AB70F0", Offset = "0x1AB5AF0", VA = "0x181AB70F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00a5
			string text = apiKey_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = secret_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = bucketName_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			string text4 = bucketRegion_;
			if (text4.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text4);
				num5++;
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60077B6")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7850", Offset = "0x1AB6250", VA = "0x181AB7850", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Aws other)
		{
			//Discarded unreachable code: IL_0083
			if (other != null)
			{
				string text = other.apiKey_;
				if (text.m_stringLength != 0)
				{
					ApiKey = text;
				}
				string text2 = other.secret_;
				if (text2.m_stringLength != 0)
				{
					Secret = text2;
				}
				string text3 = other.bucketName_;
				if (text3.m_stringLength != 0)
				{
					BucketName = text3;
				}
				string text4 = other.bucketRegion_;
				if (text4.m_stringLength != 0)
				{
					BucketRegion = text4;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077B7")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7760", Offset = "0x1AB6160", VA = "0x181AB7760", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_007c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (BucketName = input.ReadString());
				}
				if (num != 34)
				{
					goto IL_0065;
				}
				string text4 = (BucketRegion = input.ReadString());
			}
			string text6 = default(string);
			if (num == 10)
			{
				text6 = (ApiKey = input.ReadString());
			}
			if ((long)text6 == 18)
			{
				string text8 = (Secret = input.ReadString());
			}
			goto IL_0065;
			IL_0065:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60077B8")]
		[Cpp2IlInjected.Address(RVA = "0x1AB75E0", Offset = "0x1AB5FE0", VA = "0x181AB75E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = bucketRegion_;
				string text2 = bucketName_;
				string text3 = secret_;
				string text4 = apiKey_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60077B9")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7910", Offset = "0x1AB6310", VA = "0x181AB7910", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0025: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							BucketRegion = (string)num2;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
						if (value == null || value != null)
						{
							break;
						}
						throw new InvalidCastException();
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077BA")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7240", Offset = "0x1AB5C40", VA = "0x181AB7240", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
						BucketRegion = "";
						break;
					case 0:
						BucketName = "";
						break;
					}
				}
				else
				{
					Secret = "";
				}
			}
			else
			{
				ApiKey = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077BB")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7BE0", Offset = "0x1AB65E0", VA = "0x181AB7BE0")]
		static Aws()
		{
			Func<Aws> func = default(Func<Aws>);
			_parser = (MessageParser<Aws>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
