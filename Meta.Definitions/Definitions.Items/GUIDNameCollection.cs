using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200045B")]
	public sealed class GUIDNameCollection : IMessage<GUIDNameCollection>, IMessage, IEquatable<GUIDNameCollection>, IDeepCloneable<GUIDNameCollection>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200045C")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200045D")]
			public sealed class GUIDName : IMessage<GUIDName>, IMessage, IEquatable<GUIDName>, IDeepCloneable<GUIDName>, IMessageFieldAccessor, IDataValidation
			{
				[Cpp2IlInjected.Token(Token = "0x40017A6")]
				private static readonly MessageParser<GUIDName> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40017A7")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40017A8")]
				public const int GUIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40017A9")]
				private string gUID_;

				[Cpp2IlInjected.Token(Token = "0x40017AA")]
				public const int NameFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40017AB")]
				private string name_;

				[Cpp2IlInjected.Token(Token = "0x17000DAA")]
				[DebuggerNonUserCode]
				public static MessageParser<GUIDName> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003598")]
					[Cpp2IlInjected.Address(RVA = "0x29401D0", Offset = "0x293EBD0", VA = "0x1829401D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000DAB")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003599")]
					[Cpp2IlInjected.Address(RVA = "0x2940150", Offset = "0x293EB50", VA = "0x182940150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000DAC")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600359A")]
					[Cpp2IlInjected.Address(RVA = "0x2940230", Offset = "0x293EC30", VA = "0x182940230", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000DAD")]
				[DebuggerNonUserCode]
				public string GUID
				{
					[Cpp2IlInjected.Token(Token = "0x600359F")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60035A0")]
					[Cpp2IlInjected.Address(RVA = "0x29402F0", Offset = "0x293ECF0", VA = "0x1829402F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000DAE")]
				[DebuggerNonUserCode]
				public string Name
				{
					[Cpp2IlInjected.Token(Token = "0x60035A1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60035A2")]
					[Cpp2IlInjected.Address(RVA = "0x2940360", Offset = "0x293ED60", VA = "0x182940360")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600359B")]
				[Cpp2IlInjected.Address(RVA = "0x2940040", Offset = "0x293EA40", VA = "0x182940040")]
				[DebuggerNonUserCode]
				public GUIDName()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600359C")]
				[Cpp2IlInjected.Address(RVA = "0x293FB70", Offset = "0x293E570", VA = "0x18293FB70")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600359D")]
				[Cpp2IlInjected.Address(RVA = "0x293FEC0", Offset = "0x293E8C0", VA = "0x18293FEC0")]
				[DebuggerNonUserCode]
				public GUIDName(GUIDName other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600359E")]
				[Cpp2IlInjected.Address(RVA = "0x293F680", Offset = "0x293E080", VA = "0x18293F680", Slot = "10")]
				[DebuggerNonUserCode]
				public GUIDName Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60035A3")]
				[Cpp2IlInjected.Address(RVA = "0x293F8F0", Offset = "0x293E2F0", VA = "0x18293F8F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60035A4")]
				[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(GUIDName other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60035A5")]
				[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60035A6")]
				[Cpp2IlInjected.Address(RVA = "0x293FD50", Offset = "0x293E750", VA = "0x18293FD50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60035A7")]
				[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60035A8")]
				[Cpp2IlInjected.Address(RVA = "0x293F4F0", Offset = "0x293DEF0", VA = "0x18293F4F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60035A9")]
				[Cpp2IlInjected.Address(RVA = "0x293FA40", Offset = "0x293E440", VA = "0x18293FA40", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(GUIDName other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60035AA")]
				[Cpp2IlInjected.Address(RVA = "0x293FAC0", Offset = "0x293E4C0", VA = "0x18293FAC0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60035AB")]
				[Cpp2IlInjected.Address(RVA = "0x293F9B0", Offset = "0x293E3B0", VA = "0x18293F9B0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60035AC")]
				[Cpp2IlInjected.Address(RVA = "0x293FC40", Offset = "0x293E640", VA = "0x18293FC40", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60035AD")]
				[Cpp2IlInjected.Address(RVA = "0x293F5D0", Offset = "0x293DFD0", VA = "0x18293F5D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60035AE")]
				[Cpp2IlInjected.Address(RVA = "0x293F830", Offset = "0x293E230", VA = "0x18293F830", Slot = "14")]
				public void DataValidation(DataValidation.Context context)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40017A1")]
		private static readonly MessageParser<GUIDNameCollection> _parser = (MessageParser<GUIDNameCollection>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new GUIDNameCollection()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40017A2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40017A3")]
		public const int GUIDNamesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40017A4")]
		private static readonly FieldCodec<Types.GUIDName> _repeated_gUIDNames_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40017A5")]
		private readonly RepeatedField<Types.GUIDName> gUIDNames_ = (RepeatedField<Types.GUIDName>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000DA6")]
		[DebuggerNonUserCode]
		public static MessageParser<GUIDNameCollection> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003584")]
			[Cpp2IlInjected.Address(RVA = "0x2188650", Offset = "0x2187050", VA = "0x182188650")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003585")]
			[Cpp2IlInjected.Address(RVA = "0x2188580", Offset = "0x2186F80", VA = "0x182188580")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003586")]
			[Cpp2IlInjected.Address(RVA = "0x21886B0", Offset = "0x21870B0", VA = "0x1821886B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA9")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.GUIDName> GUIDNames
		{
			[Cpp2IlInjected.Token(Token = "0x600358A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gUIDNames_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003587")]
		[Cpp2IlInjected.Address(RVA = "0x2188500", Offset = "0x2186F00", VA = "0x182188500")]
		[DebuggerNonUserCode]
		public GUIDNameCollection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003588")]
		[Cpp2IlInjected.Address(RVA = "0x2188400", Offset = "0x2186E00", VA = "0x182188400")]
		[DebuggerNonUserCode]
		public GUIDNameCollection(GUIDNameCollection other)
		{
			RepeatedField<Types.GUIDName> repeatedField = (gUIDNames_ = (RepeatedField<Types.GUIDName>)(object)((RepeatedField<T>)(object)other.gUIDNames_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003589")]
		[Cpp2IlInjected.Address(RVA = "0x2187920", Offset = "0x2186320", VA = "0x182187920", Slot = "10")]
		[DebuggerNonUserCode]
		public GUIDNameCollection Clone()
		{
			//Discarded unreachable code: IL_003b
			GUIDNameCollection gUIDNameCollection = new GUIDNameCollection();
			RepeatedField<Types.GUIDName> repeatedField = (gUIDNameCollection.gUIDNames_ = (RepeatedField<Types.GUIDName>)(object)new RepeatedField<T>());
			RepeatedField<Types.GUIDName> repeatedField2 = (gUIDNameCollection.gUIDNames_ = (RepeatedField<Types.GUIDName>)(object)((RepeatedField<T>)(object)gUIDNames_).Clone());
			UnknownFieldSet unknownFieldSet = (gUIDNameCollection._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gUIDNameCollection;
		}

		[Cpp2IlInjected.Token(Token = "0x600358B")]
		[Cpp2IlInjected.Address(RVA = "0x2187D50", Offset = "0x2186750", VA = "0x182187D50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				RepeatedField<Types.GUIDName> repeatedField = gUIDNames_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600358C")]
		[Cpp2IlInjected.Address(RVA = "0x2187E30", Offset = "0x2186830", VA = "0x182187E30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GUIDNameCollection other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.GUIDName> repeatedField = gUIDNames_;
				RepeatedField<Types.GUIDName> repeatedField2 = other.gUIDNames_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600358D")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)gUIDNames_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600358E")]
		[Cpp2IlInjected.Address(RVA = "0x2188110", Offset = "0x2186B10", VA = "0x182188110", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600358F")]
		[Cpp2IlInjected.Address(RVA = "0x2188170", Offset = "0x2186B70", VA = "0x182188170", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Types.GUIDName> repeatedField = gUIDNames_;
			FieldCodec<Types.GUIDName> repeated_gUIDNames_codec = _repeated_gUIDNames_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_gUIDNames_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003590")]
		[Cpp2IlInjected.Address(RVA = "0x2187810", Offset = "0x2186210", VA = "0x182187810", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Types.GUIDName> repeatedField = gUIDNames_;
			FieldCodec<Types.GUIDName> repeated_gUIDNames_codec = _repeated_gUIDNames_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_gUIDNames_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003591")]
		[Cpp2IlInjected.Address(RVA = "0x2187F40", Offset = "0x2186940", VA = "0x182187F40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GUIDNameCollection other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Types.GUIDName> repeatedField = gUIDNames_;
				RepeatedField<Types.GUIDName> repeatedField2 = other.gUIDNames_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003592")]
		[Cpp2IlInjected.Address(RVA = "0x2187FC0", Offset = "0x21869C0", VA = "0x182187FC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.GUIDName> repeatedField = gUIDNames_;
					FieldCodec<Types.GUIDName> repeated_gUIDNames_codec = _repeated_gUIDNames_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_gUIDNames_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003593")]
		[Cpp2IlInjected.Address(RVA = "0x2187EC0", Offset = "0x21868C0", VA = "0x182187EC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.GUIDName> repeatedField = gUIDNames_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003594")]
		[Cpp2IlInjected.Address(RVA = "0x21880B0", Offset = "0x2186AB0", VA = "0x1821880B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003595")]
		[Cpp2IlInjected.Address(RVA = "0x21878C0", Offset = "0x21862C0", VA = "0x1821878C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Types.GUIDName> repeatedField = gUIDNames_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003596")]
		[Cpp2IlInjected.Address(RVA = "0x2187A50", Offset = "0x2186450", VA = "0x182187A50", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00b0
			int count = ((RepeatedField<T>)(object)gUIDNames_).Count;
			RepeatedField<Types.GUIDName> repeatedField = gUIDNames_;
			Func<Types.GUIDName, string> _003C_003E9__29_ = _003C_003Ec._003C_003E9__29_0;
			if (_003C_003E9__29_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.GUIDName x) => x.name_);
			}
			int num = Enumerable.Count<string>(Enumerable.Distinct<string>(Enumerable.Select<Types.GUIDName, string>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__29_)));
			if (count != num)
			{
				context.AddError("[CustomLocation] ProtoDatabase.CustomLocationList contains duplicate NAME");
			}
			int count2 = ((RepeatedField<T>)(object)gUIDNames_).Count;
			RepeatedField<Types.GUIDName> repeatedField2 = gUIDNames_;
			Func<Types.GUIDName, string> func = default(Func<Types.GUIDName, string>);
			if (_003C_003Ec._003C_003E9__29_1 == null)
			{
				func = (Func<Types.GUIDName, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.GUIDName x) => x.gUID_));
			}
			int num2 = Enumerable.Count<string>(Enumerable.Distinct<string>(Enumerable.Select<Types.GUIDName, string>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func)));
			if (count2 != num2)
			{
				context.AddError("[CustomLocation] ProtoDatabase.CustomLocationList contains duplicate GUID (Did you edit the file manually?)");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003597")]
		[Cpp2IlInjected.Address(RVA = "0x2188230", Offset = "0x2186C30", VA = "0x182188230")]
		static GUIDNameCollection()
		{
			MessageParser<Types.GUIDName> parser = Types.GUIDName._parser;
			uint num = default(uint);
			_parser = (MessageParser<GUIDNameCollection>)(object)FieldCodec.ForMessage<Types.GUIDName>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
