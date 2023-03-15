using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200044C")]
	public sealed class LocationItem : IMessage<LocationItem>, IMessage, IEquatable<LocationItem>, IDeepCloneable<LocationItem>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400177B")]
		private static readonly MessageParser<LocationItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400177C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400177D")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400177E")]
		private AnyItemSelector item_;

		[Cpp2IlInjected.Token(Token = "0x17000D87")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60034D7")]
			[Cpp2IlInjected.Address(RVA = "0x2755DE0", Offset = "0x27547E0", VA = "0x182755DE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D88")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60034D8")]
			[Cpp2IlInjected.Address(RVA = "0x2755D10", Offset = "0x2754710", VA = "0x182755D10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D89")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60034D9")]
			[Cpp2IlInjected.Address(RVA = "0x2755E40", Offset = "0x2754840", VA = "0x182755E40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D8A")]
		[DebuggerNonUserCode]
		public AnyItemSelector Item
		{
			[Cpp2IlInjected.Token(Token = "0x60034DE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x60034DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				item_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034DA")]
		[Cpp2IlInjected.Address(RVA = "0x2755BD0", Offset = "0x27545D0", VA = "0x182755BD0")]
		[DebuggerNonUserCode]
		public LocationItem()
		{
			AnyItemSelector anyItemSelector = (item_ = new AnyItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034DB")]
		[Cpp2IlInjected.Address(RVA = "0x2755980", Offset = "0x2754380", VA = "0x182755980")]
		private void OnConstruction()
		{
			AnyItemSelector anyItemSelector = (item_ = new AnyItemSelector());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034DC")]
		[Cpp2IlInjected.Address(RVA = "0x2755C40", Offset = "0x2754640", VA = "0x182755C40")]
		[DebuggerNonUserCode]
		public LocationItem(LocationItem other)
		{
			//IL_002e: Expected O, but got I4
			AnyItemSelector anyItemSelector = (item_ = new AnyItemSelector());
			AnyItemSelector anyItemSelector2 = other.item_;
			if (anyItemSelector2 != null)
			{
				AnyItemSelector anyItemSelector3 = anyItemSelector2.Clone();
			}
			int num = 0;
			item_ = (AnyItemSelector)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034DD")]
		[Cpp2IlInjected.Address(RVA = "0x27555A0", Offset = "0x2753FA0", VA = "0x1827555A0", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationItem Clone()
		{
			//Discarded unreachable code: IL_0047
			//IL_0030: Expected O, but got I4
			LocationItem locationItem = new LocationItem();
			AnyItemSelector anyItemSelector = (locationItem.item_ = new AnyItemSelector());
			AnyItemSelector anyItemSelector2 = item_;
			if (anyItemSelector2 != null)
			{
				AnyItemSelector anyItemSelector3 = anyItemSelector2.Clone();
			}
			int num = 0;
			locationItem.item_ = (AnyItemSelector)num;
			UnknownFieldSet unknownFieldSet = (locationItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60034E0")]
		[Cpp2IlInjected.Address(RVA = "0x27556A0", Offset = "0x27540A0", VA = "0x1827556A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(item_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034E1")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				AnyItemSelector objB = other.item_;
				if (object.Equals(item_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034E2")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				AnyItemSelector anyItemSelector = item_;
				if (anyItemSelector != null)
				{
					int hashCode = anyItemSelector.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60034E3")]
		[Cpp2IlInjected.Address(RVA = "0x2755A60", Offset = "0x2754460", VA = "0x182755A60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60034E4")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)item_ != 0)
			{
				AnyItemSelector value = item_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60034E5")]
		[Cpp2IlInjected.Address(RVA = "0x2755500", Offset = "0x2753F00", VA = "0x182755500", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				AnyItemSelector anyItemSelector = item_;
				num = 0;
				if (anyItemSelector != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(anyItemSelector);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60034E6")]
		[Cpp2IlInjected.Address(RVA = "0x27557D0", Offset = "0x27541D0", VA = "0x1827557D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationItem other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.item_ != 0)
			{
				AnyItemSelector anyItemSelector = item_;
				if (anyItemSelector == null)
				{
					AnyItemSelector anyItemSelector2 = (item_ = new AnyItemSelector());
				}
				AnyItemSelector other2 = other.item_;
				anyItemSelector.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60034E7")]
		[Cpp2IlInjected.Address(RVA = "0x27558A0", Offset = "0x27542A0", VA = "0x1827558A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				AnyItemSelector anyItemSelector = item_;
				if (anyItemSelector == null)
				{
					AnyItemSelector anyItemSelector2 = (item_ = new AnyItemSelector());
				}
				input.ReadMessage(anyItemSelector);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60034E8")]
		[Cpp2IlInjected.Address(RVA = "0x2755750", Offset = "0x2754150", VA = "0x182755750", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				AnyItemSelector anyItemSelector = item_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034E9")]
		[Cpp2IlInjected.Address(RVA = "0x27559E0", Offset = "0x27543E0", VA = "0x1827559E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				item_ = (AnyItemSelector)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034EA")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034EB")]
		[Cpp2IlInjected.Address(RVA = "0x2755AC0", Offset = "0x27544C0", VA = "0x182755AC0")]
		static LocationItem()
		{
			Func<LocationItem> func = default(Func<LocationItem>);
			_parser = (MessageParser<LocationItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
