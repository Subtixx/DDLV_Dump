using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006F1")]
	public sealed class GridObjectAddressList : IMessage<GridObjectAddressList>, IMessage, IEquatable<GridObjectAddressList>, IDeepCloneable<GridObjectAddressList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002342")]
		private static readonly MessageParser<GridObjectAddressList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002343")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002344")]
		public const int GridObjectAddressesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002345")]
		private static readonly FieldCodec<GridObjectAddress> _repeated_gridObjectAddresses_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002346")]
		private readonly RepeatedField<GridObjectAddress> gridObjectAddresses_ = (RepeatedField<GridObjectAddress>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170013D4")]
		[DebuggerNonUserCode]
		public static MessageParser<GridObjectAddressList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D45")]
			[Cpp2IlInjected.Address(RVA = "0x2F92890", Offset = "0x2F91290", VA = "0x182F92890")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D46")]
			[Cpp2IlInjected.Address(RVA = "0x2F927C0", Offset = "0x2F911C0", VA = "0x182F927C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D47")]
			[Cpp2IlInjected.Address(RVA = "0x2F928F0", Offset = "0x2F912F0", VA = "0x182F928F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D7")]
		[DebuggerNonUserCode]
		public RepeatedField<GridObjectAddress> GridObjectAddresses
		{
			[Cpp2IlInjected.Token(Token = "0x6004D4B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gridObjectAddresses_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D48")]
		[Cpp2IlInjected.Address(RVA = "0x2F92740", Offset = "0x2F91140", VA = "0x182F92740")]
		[DebuggerNonUserCode]
		public GridObjectAddressList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D49")]
		[Cpp2IlInjected.Address(RVA = "0x2F92640", Offset = "0x2F91040", VA = "0x182F92640")]
		[DebuggerNonUserCode]
		public GridObjectAddressList(GridObjectAddressList other)
		{
			RepeatedField<GridObjectAddress> repeatedField = (gridObjectAddresses_ = (RepeatedField<GridObjectAddress>)(object)((RepeatedField<T>)(object)other.gridObjectAddresses_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D4A")]
		[Cpp2IlInjected.Address(RVA = "0x2F91E60", Offset = "0x2F90860", VA = "0x182F91E60", Slot = "10")]
		[DebuggerNonUserCode]
		public GridObjectAddressList Clone()
		{
			//Discarded unreachable code: IL_003b
			GridObjectAddressList gridObjectAddressList = new GridObjectAddressList();
			RepeatedField<GridObjectAddress> repeatedField = (gridObjectAddressList.gridObjectAddresses_ = (RepeatedField<GridObjectAddress>)(object)new RepeatedField<T>());
			RepeatedField<GridObjectAddress> repeatedField2 = (gridObjectAddressList.gridObjectAddresses_ = (RepeatedField<GridObjectAddress>)(object)((RepeatedField<T>)(object)gridObjectAddresses_).Clone());
			UnknownFieldSet unknownFieldSet = (gridObjectAddressList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gridObjectAddressList;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D4C")]
		[Cpp2IlInjected.Address(RVA = "0x2F91F90", Offset = "0x2F90990", VA = "0x182F91F90", Slot = "0")]
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
				RepeatedField<GridObjectAddress> repeatedField = gridObjectAddresses_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D4D")]
		[Cpp2IlInjected.Address(RVA = "0x2F92070", Offset = "0x2F90A70", VA = "0x182F92070", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridObjectAddressList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<GridObjectAddress> repeatedField = gridObjectAddresses_;
				RepeatedField<GridObjectAddress> repeatedField2 = other.gridObjectAddresses_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D4E")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)gridObjectAddresses_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D4F")]
		[Cpp2IlInjected.Address(RVA = "0x2F92350", Offset = "0x2F90D50", VA = "0x182F92350", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D50")]
		[Cpp2IlInjected.Address(RVA = "0x2F923B0", Offset = "0x2F90DB0", VA = "0x182F923B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<GridObjectAddress> repeatedField = gridObjectAddresses_;
			FieldCodec<GridObjectAddress> repeated_gridObjectAddresses_codec = _repeated_gridObjectAddresses_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_gridObjectAddresses_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D51")]
		[Cpp2IlInjected.Address(RVA = "0x2F91D50", Offset = "0x2F90750", VA = "0x182F91D50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<GridObjectAddress> repeatedField = gridObjectAddresses_;
			FieldCodec<GridObjectAddress> repeated_gridObjectAddresses_codec = _repeated_gridObjectAddresses_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_gridObjectAddresses_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D52")]
		[Cpp2IlInjected.Address(RVA = "0x2F92180", Offset = "0x2F90B80", VA = "0x182F92180", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridObjectAddressList other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<GridObjectAddress> repeatedField = gridObjectAddresses_;
				RepeatedField<GridObjectAddress> repeatedField2 = other.gridObjectAddresses_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D53")]
		[Cpp2IlInjected.Address(RVA = "0x2F92200", Offset = "0x2F90C00", VA = "0x182F92200", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<GridObjectAddress> repeatedField = gridObjectAddresses_;
					FieldCodec<GridObjectAddress> repeated_gridObjectAddresses_codec = _repeated_gridObjectAddresses_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_gridObjectAddresses_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D54")]
		[Cpp2IlInjected.Address(RVA = "0x2F92100", Offset = "0x2F90B00", VA = "0x182F92100", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<GridObjectAddress> repeatedField = gridObjectAddresses_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D55")]
		[Cpp2IlInjected.Address(RVA = "0x2F922F0", Offset = "0x2F90CF0", VA = "0x182F922F0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004D56")]
		[Cpp2IlInjected.Address(RVA = "0x2F91E00", Offset = "0x2F90800", VA = "0x182F91E00", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<GridObjectAddress> repeatedField = gridObjectAddresses_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D57")]
		[Cpp2IlInjected.Address(RVA = "0x2F92470", Offset = "0x2F90E70", VA = "0x182F92470")]
		static GridObjectAddressList()
		{
			Func<GridObjectAddressList> func = default(Func<GridObjectAddressList>);
			_parser = (MessageParser<GridObjectAddressList>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<GridObjectAddress> parser = GridObjectAddress._parser;
			uint num = default(uint);
			_parser = (MessageParser<GridObjectAddressList>)(object)FieldCodec.ForMessage<GridObjectAddress>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
