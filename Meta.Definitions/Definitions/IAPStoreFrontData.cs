using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class IAPStoreFrontData : IMessage<IAPStoreFrontData>, IMessage, IEquatable<IAPStoreFrontData>, IDeepCloneable<IAPStoreFrontData>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private static readonly MessageParser<IAPStoreFrontData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public const int ProductIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private string productID_ = "";

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public const int CatalogIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private string catalogID_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		[DebuggerNonUserCode]
		public static MessageParser<IAPStoreFrontData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0x27B1190", Offset = "0x27AFB90", VA = "0x1827B1190")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60008BF")]
			[Cpp2IlInjected.Address(RVA = "0x27B10C0", Offset = "0x27AFAC0", VA = "0x1827B10C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0x27B11F0", Offset = "0x27AFBF0", VA = "0x1827B11F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		[DebuggerNonUserCode]
		public string ProductID
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return productID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C5")]
			[Cpp2IlInjected.Address(RVA = "0x27B1370", Offset = "0x27AFD70", VA = "0x1827B1370")]
			set
			{
				string text = (productID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		[DebuggerNonUserCode]
		public string CatalogID
		{
			[Cpp2IlInjected.Token(Token = "0x60008C6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return catalogID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C7")]
			[Cpp2IlInjected.Address(RVA = "0x27B1300", Offset = "0x27AFD00", VA = "0x1827B1300")]
			set
			{
				string text = (catalogID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		public string NativeItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x27ABE80", Offset = "0x27AA880", VA = "0x1827ABE80")]
			get
			{
				if (string.IsNullOrEmpty(catalogID_))
				{
					return productID_;
				}
				return catalogID_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x27B1060", Offset = "0x27AFA60", VA = "0x1827B1060")]
		[DebuggerNonUserCode]
		public IAPStoreFrontData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x27B0F90", Offset = "0x27AF990", VA = "0x1827B0F90")]
		[DebuggerNonUserCode]
		public IAPStoreFrontData(IAPStoreFrontData other)
		{
			string text = (productID_ = other.productID_);
			string text2 = (catalogID_ = other.catalogID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x27B0890", Offset = "0x27AF290", VA = "0x1827B0890", Slot = "10")]
		[DebuggerNonUserCode]
		public IAPStoreFrontData Clone()
		{
			//Discarded unreachable code: IL_004d
			IAPStoreFrontData iAPStoreFrontData = new IAPStoreFrontData();
			iAPStoreFrontData.productID_ = "";
			iAPStoreFrontData.catalogID_ = "";
			string text = (iAPStoreFrontData.productID_ = productID_);
			string text2 = (iAPStoreFrontData.catalogID_ = catalogID_);
			UnknownFieldSet unknownFieldSet = (iAPStoreFrontData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return iAPStoreFrontData;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x27B0A90", Offset = "0x27AF490", VA = "0x1827B0A90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = productID_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = catalogID_;
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

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(IAPStoreFrontData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.productID_;
				if (!(productID_ != text))
				{
					string text2 = other.catalogID_;
					if (!(catalogID_ != text2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			string text = productID_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = catalogID_;
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

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x27B0E20", Offset = "0x27AF820", VA = "0x1827B0E20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004b
			if (productID_.m_stringLength != 0)
			{
				string value = productID_;
				output.WriteString(value);
			}
			if (catalogID_.m_stringLength != 0)
			{
				string value2 = catalogID_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x27B0700", Offset = "0x27AF100", VA = "0x1827B0700", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0059
			string text = productID_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = catalogID_;
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

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x27B0C90", Offset = "0x27AF690", VA = "0x1827B0C90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(IAPStoreFrontData other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.productID_;
				if (text.m_stringLength != 0)
				{
					ProductID = text;
				}
				string text2 = other.catalogID_;
				if (text2.m_stringLength != 0)
				{
					CatalogID = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x27B0BE0", Offset = "0x27AF5E0", VA = "0x1827B0BE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (ProductID = input.ReadString());
				}
				if (num == 18)
				{
					string text4 = (CatalogID = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x27B0B50", Offset = "0x27AF550", VA = "0x1827B0B50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = productID_;
			}
			if (fieldNumber == 2)
			{
				string text2 = catalogID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x27B0D10", Offset = "0x27AF710", VA = "0x1827B0D10", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (productID_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x27B07E0", Offset = "0x27AF1E0", VA = "0x1827B07E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (productID_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				CatalogID = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x27B0990", Offset = "0x27AF390", VA = "0x1827B0990", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_003b
			//IL_002b: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			string text = productID_;
			if ("ProductID" == null)
			{
				string text2 = productID_;
				int stringLength = text2.m_stringLength;
				int num = default(int);
				string message = $"Product id '{text2}' has a length of {stringLength}, but the limit is {num}.";
				context.AddInvalidMemberError(message, "ProductID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x27B0E80", Offset = "0x27AF880", VA = "0x1827B0E80")]
		static IAPStoreFrontData()
		{
			Func<IAPStoreFrontData> func = default(Func<IAPStoreFrontData>);
			_parser = (MessageParser<IAPStoreFrontData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
