using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x2000861")]
	public sealed class GiftCategory : IMessage<GiftCategory>, IMessage, IEquatable<GiftCategory>, IDeepCloneable<GiftCategory>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002965")]
		private static readonly MessageParser<GiftCategory> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002966")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002967")]
		public const int ConditionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002968")]
		private ItemConditionsList condition_;

		[Cpp2IlInjected.Token(Token = "0x4002969")]
		public const int FriendshipGivenFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400296A")]
		private int friendshipGiven_;

		[Cpp2IlInjected.Token(Token = "0x17001794")]
		[DebuggerNonUserCode]
		public static MessageParser<GiftCategory> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005D9F")]
			[Cpp2IlInjected.Address(RVA = "0x2F872B0", Offset = "0x2F85CB0", VA = "0x182F872B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001795")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005DA0")]
			[Cpp2IlInjected.Address(RVA = "0x2F871E0", Offset = "0x2F85BE0", VA = "0x182F871E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001796")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005DA1")]
			[Cpp2IlInjected.Address(RVA = "0x2F87310", Offset = "0x2F85D10", VA = "0x182F87310", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001797")]
		[DebuggerNonUserCode]
		public ItemConditionsList Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6005DA6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return condition_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005DA7")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				condition_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001798")]
		[DebuggerNonUserCode]
		public int FriendshipGiven
		{
			[Cpp2IlInjected.Token(Token = "0x6005DA8")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return friendshipGiven_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005DA9")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				friendshipGiven_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DA2")]
		[Cpp2IlInjected.Address(RVA = "0x2F87170", Offset = "0x2F85B70", VA = "0x182F87170")]
		[DebuggerNonUserCode]
		public GiftCategory()
		{
			ItemConditionsList itemConditionsList = (condition_ = new ItemConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DA3")]
		[Cpp2IlInjected.Address(RVA = "0x2F86E00", Offset = "0x2F85800", VA = "0x182F86E00")]
		private void OnConstruction()
		{
			ItemConditionsList itemConditionsList = (condition_ = new ItemConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DA4")]
		[Cpp2IlInjected.Address(RVA = "0x2F870A0", Offset = "0x2F85AA0", VA = "0x182F870A0")]
		[DebuggerNonUserCode]
		public GiftCategory(GiftCategory other)
		{
			//IL_002e: Expected O, but got I4
			ItemConditionsList itemConditionsList = (condition_ = new ItemConditionsList());
			ItemConditionsList itemConditionsList2 = other.condition_;
			if (itemConditionsList2 != null)
			{
				ItemConditionsList itemConditionsList3 = itemConditionsList2.Clone();
			}
			int num = 0;
			condition_ = (ItemConditionsList)num;
			int num2 = (friendshipGiven_ = other.friendshipGiven_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DA5")]
		[Cpp2IlInjected.Address(RVA = "0x2F869B0", Offset = "0x2F853B0", VA = "0x182F869B0", Slot = "10")]
		[DebuggerNonUserCode]
		public GiftCategory Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0030: Expected O, but got I4
			GiftCategory giftCategory = new GiftCategory();
			ItemConditionsList itemConditionsList = (giftCategory.condition_ = new ItemConditionsList());
			ItemConditionsList itemConditionsList2 = condition_;
			if (itemConditionsList2 != null)
			{
				ItemConditionsList itemConditionsList3 = itemConditionsList2.Clone();
			}
			int num = 0;
			giftCategory.condition_ = (ItemConditionsList)num;
			int num2 = (giftCategory.friendshipGiven_ = friendshipGiven_);
			UnknownFieldSet unknownFieldSet = (giftCategory._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return giftCategory;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DAA")]
		[Cpp2IlInjected.Address(RVA = "0x2F86AB0", Offset = "0x2F854B0", VA = "0x182F86AB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(condition_, other);
				if (flag && friendshipGiven_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DAB")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GiftCategory other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemConditionsList objB = other.condition_;
				if (object.Equals(condition_, objB))
				{
					int num = other.friendshipGiven_;
					if (friendshipGiven_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DAC")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemConditionsList itemConditionsList = condition_;
				if (itemConditionsList != null)
				{
					int hashCode = itemConditionsList.GetHashCode();
				}
				if (friendshipGiven_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DAD")]
		[Cpp2IlInjected.Address(RVA = "0x2F86F30", Offset = "0x2F85930", VA = "0x182F86F30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DAE")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)condition_ != 0)
			{
				ItemConditionsList value = condition_;
				output.WriteMessage(value);
			}
			if (friendshipGiven_ != 0)
			{
				int value2 = friendshipGiven_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DAF")]
		[Cpp2IlInjected.Address(RVA = "0x2F868E0", Offset = "0x2F852E0", VA = "0x182F868E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemConditionsList itemConditionsList = condition_;
				num = 0;
				if (itemConditionsList != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemConditionsList);
				}
				int num3 = friendshipGiven_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DB0")]
		[Cpp2IlInjected.Address(RVA = "0x2F86C30", Offset = "0x2F85630", VA = "0x182F86C30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GiftCategory other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.condition_ != 0)
			{
				ItemConditionsList itemConditionsList = condition_;
				if (itemConditionsList == null)
				{
					ItemConditionsList itemConditionsList2 = (condition_ = new ItemConditionsList());
				}
				ItemConditionsList other2 = other.condition_;
				itemConditionsList.MergeFrom(other2);
			}
			int num = other.friendshipGiven_;
			if (num != 0)
			{
				friendshipGiven_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6005DB1")]
		[Cpp2IlInjected.Address(RVA = "0x2F86D10", Offset = "0x2F85710", VA = "0x182F86D10", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ItemConditionsList itemConditionsList = condition_;
				if (itemConditionsList == null)
				{
					ItemConditionsList itemConditionsList2 = (condition_ = new ItemConditionsList());
				}
				input.ReadMessage(itemConditionsList);
			}
			if (num == 16)
			{
				int num2 = (friendshipGiven_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005DB2")]
		[Cpp2IlInjected.Address(RVA = "0x2F86B60", Offset = "0x2F85560", VA = "0x182F86B60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemConditionsList itemConditionsList = condition_;
			}
			if (fieldNumber == 2)
			{
				int num = friendshipGiven_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DB3")]
		[Cpp2IlInjected.Address(RVA = "0x2F86E60", Offset = "0x2F85860", VA = "0x182F86E60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				condition_ = (ItemConditionsList)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				friendshipGiven_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DB4")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				friendshipGiven_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DB5")]
		[Cpp2IlInjected.Address(RVA = "0x2F86F90", Offset = "0x2F85990", VA = "0x182F86F90")]
		static GiftCategory()
		{
			Func<GiftCategory> func = default(Func<GiftCategory>);
			_parser = (MessageParser<GiftCategory>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
