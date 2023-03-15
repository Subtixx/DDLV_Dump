using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001D9")]
	public sealed class ItemAvailableInStall : BaseItemFilter, IMessage<ItemAvailableInStall>, IMessage, IEquatable<ItemAvailableInStall>, IDeepCloneable<ItemAvailableInStall>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		private static readonly MessageParser<ItemAvailableInStall> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public const int InStallFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private bool inStall_;

		[Cpp2IlInjected.Token(Token = "0x170003F6")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemAvailableInStall> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60011A3")]
			[Cpp2IlInjected.Address(RVA = "0x22C0CC0", Offset = "0x22BF6C0", VA = "0x1822C0CC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60011A4")]
			[Cpp2IlInjected.Address(RVA = "0x22C0BF0", Offset = "0x22BF5F0", VA = "0x1822C0BF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60011A5")]
			[Cpp2IlInjected.Address(RVA = "0x22C0D20", Offset = "0x22BF720", VA = "0x1822C0D20", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F9")]
		[DebuggerNonUserCode]
		public bool InStall
		{
			[Cpp2IlInjected.Token(Token = "0x60011A9")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return inStall_;
			}
			[Cpp2IlInjected.Token(Token = "0x60011AA")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				inStall_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011A6")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		[DebuggerNonUserCode]
		public ItemAvailableInStall()
		{
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60011A7")]
		[Cpp2IlInjected.Address(RVA = "0x22C0BA0", Offset = "0x22BF5A0", VA = "0x1822C0BA0")]
		[DebuggerNonUserCode]
		public ItemAvailableInStall(ItemAvailableInStall other)
		{
			((ServiceContainer)(object)this)._002Ector();
			bool flag = (inStall_ = other.inStall_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011A8")]
		[Cpp2IlInjected.Address(RVA = "0x22C05F0", Offset = "0x22BEFF0", VA = "0x1822C05F0", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemAvailableInStall Clone()
		{
			//Discarded unreachable code: IL_0029
			ItemAvailableInStall itemAvailableInStall = new ItemAvailableInStall();
			bool flag = (itemAvailableInStall.inStall_ = inStall_);
			UnknownFieldSet unknownFieldSet = (itemAvailableInStall._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemAvailableInStall;
		}

		[Cpp2IlInjected.Token(Token = "0x60011AB")]
		[Cpp2IlInjected.Address(RVA = "0x22C0870", Offset = "0x22BF270", VA = "0x1822C0870", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(inStall_ ? 1 : 0) == (IntPtr)typeof(ItemAvailableInStall).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60011AC")]
		[Cpp2IlInjected.Address(RVA = "0x13AA400", Offset = "0x13A8E00", VA = "0x1813AA400", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemAvailableInStall other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.inStall_;
				if (inStall_ == flag)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60011AD")]
		[Cpp2IlInjected.Address(RVA = "0x13AA570", Offset = "0x13A8F70", VA = "0x1813AA570", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (inStall_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60011AE")]
		[Cpp2IlInjected.Address(RVA = "0x22C0A30", Offset = "0x22BF430", VA = "0x1822C0A30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60011AF")]
		[Cpp2IlInjected.Address(RVA = "0x13AA790", Offset = "0x13A9190", VA = "0x1813AA790", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (inStall_)
			{
				bool value = inStall_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60011B0")]
		[Cpp2IlInjected.Address(RVA = "0x13AA330", Offset = "0x13A8D30", VA = "0x1813AA330", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				bool flag = inStall_;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x60011B1")]
		[Cpp2IlInjected.Address(RVA = "0x13AA660", Offset = "0x13A9060", VA = "0x1813AA660", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemAvailableInStall other)
		{
			if (other != null)
			{
				bool flag = other.inStall_;
				if (flag)
				{
					inStall_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011B2")]
		[Cpp2IlInjected.Address(RVA = "0x13AA5E0", Offset = "0x13A8FE0", VA = "0x1813AA5E0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (inStall_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011B3")]
		[Cpp2IlInjected.Address(RVA = "0x22C0900", Offset = "0x22BF300", VA = "0x1822C0900", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = inStall_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60011B4")]
		[Cpp2IlInjected.Address(RVA = "0x22C09B0", Offset = "0x22BF3B0", VA = "0x1822C09B0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				inStall_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011B5")]
		[Cpp2IlInjected.Address(RVA = "0x13AA370", Offset = "0x13A8D70", VA = "0x1813AA370", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				inStall_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011B6")]
		[Cpp2IlInjected.Address(RVA = "0x22C0770", Offset = "0x22BF170", VA = "0x1822C0770", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0028
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData == null)
				{
					return true;
				}
				ItemAvailableInStall itemAvailableInStall = this;
				return (IntPtr)itemData != (IntPtr)(itemAvailableInStall.inStall_ ? 1 : 0);
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60011B7")]
		[Cpp2IlInjected.Address(RVA = "0x22C0670", Offset = "0x22BF070", VA = "0x1822C0670", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0023
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData == null)
				{
				}
				ItemAvailableInStall itemAvailableInStall = this;
				return (IntPtr)itemData == (IntPtr)(itemAvailableInStall.inStall_ ? 1 : 0);
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60011B8")]
		[Cpp2IlInjected.Address(RVA = "0x22C0A90", Offset = "0x22BF490", VA = "0x1822C0A90")]
		static ItemAvailableInStall()
		{
			Func<ItemAvailableInStall> func = default(Func<ItemAvailableInStall>);
			_parser = (MessageParser<ItemAvailableInStall>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
