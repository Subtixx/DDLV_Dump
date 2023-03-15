using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions;
using Definitions.Character;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200022B")]
	public sealed class FriendshipChoice : IMessage<FriendshipChoice>, IMessage, IEquatable<FriendshipChoice>, IDeepCloneable<FriendshipChoice>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private static readonly MessageParser<FriendshipChoice> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public const int XpIndexFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private int xpIndex_;

		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public const int IDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private string iD_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700040C")]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipChoice> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600168F")]
			[Cpp2IlInjected.Address(RVA = "0x1808E90", Offset = "0x1807890", VA = "0x181808E90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001690")]
			[Cpp2IlInjected.Address(RVA = "0x1808DC0", Offset = "0x18077C0", VA = "0x181808DC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001691")]
			[Cpp2IlInjected.Address(RVA = "0x1808EF0", Offset = "0x18078F0", VA = "0x181808EF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040F")]
		[DebuggerNonUserCode]
		public int XpIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6001695")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return xpIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001696")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				xpIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000410")]
		[DebuggerNonUserCode]
		public string ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001697")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001698")]
			[Cpp2IlInjected.Address(RVA = "0x1809000", Offset = "0x1807A00", VA = "0x181809000")]
			set
			{
				string text = (iD_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001692")]
		[Cpp2IlInjected.Address(RVA = "0x1808D70", Offset = "0x1807770", VA = "0x181808D70")]
		[DebuggerNonUserCode]
		public FriendshipChoice()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001693")]
		[Cpp2IlInjected.Address(RVA = "0x1808CD0", Offset = "0x18076D0", VA = "0x181808CD0")]
		[DebuggerNonUserCode]
		public FriendshipChoice(FriendshipChoice other)
		{
			int num = (xpIndex_ = other.xpIndex_);
			string text = (iD_ = other.iD_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001694")]
		[Cpp2IlInjected.Address(RVA = "0x1808550", Offset = "0x1806F50", VA = "0x181808550", Slot = "10")]
		[DebuggerNonUserCode]
		public FriendshipChoice Clone()
		{
			//Discarded unreachable code: IL_0042
			FriendshipChoice friendshipChoice = new FriendshipChoice();
			friendshipChoice.iD_ = "";
			int num = (friendshipChoice.xpIndex_ = xpIndex_);
			string text = (friendshipChoice.iD_ = iD_);
			UnknownFieldSet unknownFieldSet = (friendshipChoice._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return friendshipChoice;
		}

		[Cpp2IlInjected.Token(Token = "0x6001699")]
		[Cpp2IlInjected.Address(RVA = "0x1808620", Offset = "0x1807020", VA = "0x181808620", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)xpIndex_ == (IntPtr)typeof(FriendshipChoice).TypeHandle)
				{
					string text = iD_;
					bool flag = default(bool);
					if (!flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600169A")]
		[Cpp2IlInjected.Address(RVA = "0x1708900", Offset = "0x1707300", VA = "0x181708900", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FriendshipChoice other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.xpIndex_;
				if (xpIndex_ == num)
				{
					string text = other.iD_;
					if (!(iD_ != text))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600169B")]
		[Cpp2IlInjected.Address(RVA = "0x1708AF0", Offset = "0x17074F0", VA = "0x181708AF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0035
			if (xpIndex_ != 0)
			{
			}
			string text = iD_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600169C")]
		[Cpp2IlInjected.Address(RVA = "0x1808B60", Offset = "0x1807560", VA = "0x181808B60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600169D")]
		[Cpp2IlInjected.Address(RVA = "0x1708DC0", Offset = "0x17077C0", VA = "0x181708DC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0046
			if (xpIndex_ != 0)
			{
				int value = xpIndex_;
				output.WriteInt32(value);
			}
			if (iD_.m_stringLength != 0)
			{
				string value2 = iD_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600169E")]
		[Cpp2IlInjected.Address(RVA = "0x1808410", Offset = "0x1806E10", VA = "0x181808410", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			int num = xpIndex_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = iD_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num2 += num5;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600169F")]
		[Cpp2IlInjected.Address(RVA = "0x1808A20", Offset = "0x1807420", VA = "0x181808A20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FriendshipChoice other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				int num = other.xpIndex_;
				if (num != 0)
				{
					xpIndex_ = num;
				}
				string text = other.iD_;
				if (text.m_stringLength != 0)
				{
					ID = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016A0")]
		[Cpp2IlInjected.Address(RVA = "0x1808980", Offset = "0x1807380", VA = "0x181808980", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (xpIndex_ = input.ReadInt32());
				}
				if (num == 18)
				{
					string text2 = (ID = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016A1")]
		[Cpp2IlInjected.Address(RVA = "0x18086D0", Offset = "0x18070D0", VA = "0x1818086D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = xpIndex_;
			}
			if (fieldNumber == 2)
			{
				string text = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016A2")]
		[Cpp2IlInjected.Address(RVA = "0x1808A90", Offset = "0x1807490", VA = "0x181808A90", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				xpIndex_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016A3")]
		[Cpp2IlInjected.Address(RVA = "0x18084E0", Offset = "0x1806EE0", VA = "0x1818084E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				xpIndex_ = 0;
				break;
			case 2:
				ID = "";
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016A4")]
		[Cpp2IlInjected.Address(RVA = "0x18087A0", Offset = "0x18071A0", VA = "0x1818087A0")]
		public static int GetTotalXP(IEnumerable<FriendshipChoice> list)
		{
			//Discarded unreachable code: IL_0046
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				return 0;
			}
			Friendship friendship = default(Friendship);
			int offset = ((RepeatedField<T>)(object)friendship.friendshipBonus_.dialogueXP_).Count;
			Func<FriendshipChoice, int> func = (Func<FriendshipChoice, int>)(object)(Func<T, TResult>)delegate(FriendshipChoice x)
			{
				//Discarded unreachable code: IL_0029
				//IL_0029: Expected I4, but got O
				int num = offset;
				int num2 = x.xpIndex_;
				num += num2;
				return (int)((RepeatedField<T>)(object)friendship.friendshipBonus_.dialogueXP_)[num];
			};
			return Enumerable.Sum<FriendshipChoice>((IEnumerable<>)list, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60016A5")]
		[Cpp2IlInjected.Address(RVA = "0x1808BC0", Offset = "0x18075C0", VA = "0x181808BC0")]
		static FriendshipChoice()
		{
			Func<FriendshipChoice> func = default(Func<FriendshipChoice>);
			_parser = (MessageParser<FriendshipChoice>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
