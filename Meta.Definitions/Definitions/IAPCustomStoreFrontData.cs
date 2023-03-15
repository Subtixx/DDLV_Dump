using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class IAPCustomStoreFrontData : IMessage<IAPCustomStoreFrontData>, IMessage, IEquatable<IAPCustomStoreFrontData>, IDeepCloneable<IAPCustomStoreFrontData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private static readonly MessageParser<IAPCustomStoreFrontData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public const int ProductIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private string productID_ = "";

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public const int CatalogIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private string catalogID_ = "";

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public const int StoreURLFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private string storeURL_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		[DebuggerNonUserCode]
		public static MessageParser<IAPCustomStoreFrontData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0x27ABEB0", Offset = "0x27AA8B0", VA = "0x1827ABEB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000229")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0x27ABDB0", Offset = "0x27AA7B0", VA = "0x1827ABDB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0x27ABF10", Offset = "0x27AA910", VA = "0x1827ABF10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		[DebuggerNonUserCode]
		public string ProductID
		{
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return productID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E0")]
			[Cpp2IlInjected.Address(RVA = "0x27AC090", Offset = "0x27AAA90", VA = "0x1827AC090")]
			set
			{
				string text = (productID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		[DebuggerNonUserCode]
		public string CatalogID
		{
			[Cpp2IlInjected.Token(Token = "0x60008E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return catalogID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E2")]
			[Cpp2IlInjected.Address(RVA = "0x27AC020", Offset = "0x27AAA20", VA = "0x1827AC020")]
			set
			{
				string text = (catalogID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		[DebuggerNonUserCode]
		public string StoreURL
		{
			[Cpp2IlInjected.Token(Token = "0x60008E3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return storeURL_;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0x27AC100", Offset = "0x27AAB00", VA = "0x1827AC100")]
			set
			{
				string text = (storeURL_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public string NativeItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
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

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x27ABC40", Offset = "0x27AA640", VA = "0x1827ABC40")]
		[DebuggerNonUserCode]
		public IAPCustomStoreFrontData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x27ABCB0", Offset = "0x27AA6B0", VA = "0x1827ABCB0")]
		[DebuggerNonUserCode]
		public IAPCustomStoreFrontData(IAPCustomStoreFrontData other)
		{
			string text = (productID_ = other.productID_);
			string text2 = (catalogID_ = other.catalogID_);
			string text3 = (storeURL_ = other.storeURL_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x27AB5B0", Offset = "0x27A9FB0", VA = "0x1827AB5B0", Slot = "10")]
		[DebuggerNonUserCode]
		public IAPCustomStoreFrontData Clone()
		{
			//Discarded unreachable code: IL_0068
			IAPCustomStoreFrontData iAPCustomStoreFrontData = new IAPCustomStoreFrontData();
			iAPCustomStoreFrontData.productID_ = "";
			iAPCustomStoreFrontData.catalogID_ = "";
			iAPCustomStoreFrontData.storeURL_ = "";
			string text = (iAPCustomStoreFrontData.productID_ = productID_);
			string text2 = (iAPCustomStoreFrontData.catalogID_ = catalogID_);
			string text3 = (iAPCustomStoreFrontData.storeURL_ = storeURL_);
			UnknownFieldSet unknownFieldSet = (iAPCustomStoreFrontData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return iAPCustomStoreFrontData;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x27AB6D0", Offset = "0x27AA0D0", VA = "0x1827AB6D0", Slot = "0")]
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
						string text3 = storeURL_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x1BF9E30", Offset = "0x1BF8830", VA = "0x181BF9E30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(IAPCustomStoreFrontData other)
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
						string text3 = other.storeURL_;
						if (!(storeURL_ != text3))
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

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x1BFA590", Offset = "0x1BF8F90", VA = "0x181BFA590", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0061
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
			string text3 = storeURL_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x27ABAD0", Offset = "0x27AA4D0", VA = "0x1827ABAD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x1BFD120", Offset = "0x1BFBB20", VA = "0x181BFD120", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0067
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
			if (storeURL_.m_stringLength != 0)
			{
				string value3 = storeURL_;
				output.WriteString(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x27AB400", Offset = "0x27A9E00", VA = "0x1827AB400", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_007f
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
			string text3 = storeURL_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x27AB850", Offset = "0x27AA250", VA = "0x1827AB850", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(IAPCustomStoreFrontData other)
		{
			//Discarded unreachable code: IL_0067
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
				string text3 = other.storeURL_;
				if (text3.m_stringLength != 0)
				{
					StoreURL = text3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x27AB8F0", Offset = "0x27AA2F0", VA = "0x1827AB8F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0060
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (ProductID = input.ReadString());
				}
				string text4 = default(string);
				if (num == 18)
				{
					text4 = (CatalogID = input.ReadString());
				}
				if ((long)text4 == 26)
				{
					string text6 = (StoreURL = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x27AB7B0", Offset = "0x27AA1B0", VA = "0x1827AB7B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = storeURL_;
				string text2 = catalogID_;
				string text3 = productID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x27AB9C0", Offset = "0x27AA3C0", VA = "0x1827AB9C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
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
						StoreURL = (string)num2;
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

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x27AB510", Offset = "0x27A9F10", VA = "0x1827AB510", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					StoreURL = "";
					break;
				case 0:
					CatalogID = "";
					break;
				}
			}
			else
			{
				ProductID = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x27ABB30", Offset = "0x27AA530", VA = "0x1827ABB30")]
		static IAPCustomStoreFrontData()
		{
			Func<IAPCustomStoreFrontData> func = default(Func<IAPCustomStoreFrontData>);
			_parser = (MessageParser<IAPCustomStoreFrontData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
