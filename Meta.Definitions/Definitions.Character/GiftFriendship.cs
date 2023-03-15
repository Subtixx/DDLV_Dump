using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Character
{
	[Cpp2IlInjected.Token(Token = "0x2000863")]
	public sealed class GiftFriendship : IMessage<GiftFriendship>, IMessage, IEquatable<GiftFriendship>, IDeepCloneable<GiftFriendship>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400296C")]
		private static readonly MessageParser<GiftFriendship> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400296D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400296E")]
		public const int CategoriesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400296F")]
		private static readonly FieldCodec<GiftCategory> _repeated_categories_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002970")]
		private readonly RepeatedField<GiftCategory> categories_ = (RepeatedField<GiftCategory>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001799")]
		[DebuggerNonUserCode]
		public static MessageParser<GiftFriendship> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005DBA")]
			[Cpp2IlInjected.Address(RVA = "0x2F88310", Offset = "0x2F86D10", VA = "0x182F88310")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700179A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005DBB")]
			[Cpp2IlInjected.Address(RVA = "0x2F88240", Offset = "0x2F86C40", VA = "0x182F88240")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700179B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005DBC")]
			[Cpp2IlInjected.Address(RVA = "0x2F88370", Offset = "0x2F86D70", VA = "0x182F88370", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700179C")]
		[DebuggerNonUserCode]
		public RepeatedField<GiftCategory> Categories
		{
			[Cpp2IlInjected.Token(Token = "0x6005DC0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return categories_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DB9")]
		[Cpp2IlInjected.Address(RVA = "0x2F87A80", Offset = "0x2F86480", VA = "0x182F87A80")]
		public unsafe static bool TryGetGiftFriendship(Item giftItem, ItemState giftState, out int friendshipGiven)
		{
			//Discarded unreachable code: IL_005b, IL_0061, IL_0067
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected I4, but got Unknown
			int num = 0;
			int num2 = 0;
			ItemType itemType = default(ItemType);
			ActivityItemType activityItemType = default(ActivityItemType);
			if (itemType == ItemType.ActivityItem && activityItemType == ActivityItemType.Meal)
			{
				num -= giftState;
				int num3 = default(int);
				num += num3;
				friendshipGiven.m_value = 0;
			}
			friendshipGiven.m_value = num;
			if (ProtoDatabase.Instance.TryGet("GiftFriendship", out *(GiftFriendship*)num))
			{
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
					friendshipGiven.m_value = (flag2 ? 1 : 0);
					num++;
				}
				if (num + 1 == 0)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DBD")]
		[Cpp2IlInjected.Address(RVA = "0x2F881C0", Offset = "0x2F86BC0", VA = "0x182F881C0")]
		[DebuggerNonUserCode]
		public GiftFriendship()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005DBE")]
		[Cpp2IlInjected.Address(RVA = "0x2F880C0", Offset = "0x2F86AC0", VA = "0x182F880C0")]
		[DebuggerNonUserCode]
		public GiftFriendship(GiftFriendship other)
		{
			RepeatedField<GiftCategory> repeatedField = (categories_ = (RepeatedField<GiftCategory>)(object)((RepeatedField<T>)(object)other.categories_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DBF")]
		[Cpp2IlInjected.Address(RVA = "0x2F87530", Offset = "0x2F85F30", VA = "0x182F87530", Slot = "10")]
		[DebuggerNonUserCode]
		public GiftFriendship Clone()
		{
			//Discarded unreachable code: IL_003b
			GiftFriendship giftFriendship = new GiftFriendship();
			RepeatedField<GiftCategory> repeatedField = (giftFriendship.categories_ = (RepeatedField<GiftCategory>)(object)new RepeatedField<T>());
			RepeatedField<GiftCategory> repeatedField2 = (giftFriendship.categories_ = (RepeatedField<GiftCategory>)(object)((RepeatedField<T>)(object)categories_).Clone());
			UnknownFieldSet unknownFieldSet = (giftFriendship._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return giftFriendship;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC1")]
		[Cpp2IlInjected.Address(RVA = "0x2F876F0", Offset = "0x2F860F0", VA = "0x182F876F0", Slot = "0")]
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
				RepeatedField<GiftCategory> repeatedField = categories_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC2")]
		[Cpp2IlInjected.Address(RVA = "0x2F87660", Offset = "0x2F86060", VA = "0x182F87660", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GiftFriendship other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<GiftCategory> repeatedField = categories_;
				RepeatedField<GiftCategory> repeatedField2 = other.categories_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC3")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)categories_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC4")]
		[Cpp2IlInjected.Address(RVA = "0x2F87A20", Offset = "0x2F86420", VA = "0x182F87A20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC5")]
		[Cpp2IlInjected.Address(RVA = "0x2F87E30", Offset = "0x2F86830", VA = "0x182F87E30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<GiftCategory> repeatedField = categories_;
			FieldCodec<GiftCategory> repeated_categories_codec = _repeated_categories_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_categories_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC6")]
		[Cpp2IlInjected.Address(RVA = "0x2F87420", Offset = "0x2F85E20", VA = "0x182F87420", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<GiftCategory> repeatedField = categories_;
			FieldCodec<GiftCategory> repeated_categories_codec = _repeated_categories_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_categories_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC7")]
		[Cpp2IlInjected.Address(RVA = "0x2F87940", Offset = "0x2F86340", VA = "0x182F87940", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GiftFriendship other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<GiftCategory> repeatedField = categories_;
				RepeatedField<GiftCategory> repeatedField2 = other.categories_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC8")]
		[Cpp2IlInjected.Address(RVA = "0x2F87850", Offset = "0x2F86250", VA = "0x182F87850", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<GiftCategory> repeatedField = categories_;
					FieldCodec<GiftCategory> repeated_categories_codec = _repeated_categories_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_categories_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC9")]
		[Cpp2IlInjected.Address(RVA = "0x2F877D0", Offset = "0x2F861D0", VA = "0x182F877D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<GiftCategory> repeatedField = categories_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005DCA")]
		[Cpp2IlInjected.Address(RVA = "0x2F879C0", Offset = "0x2F863C0", VA = "0x182F879C0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6005DCB")]
		[Cpp2IlInjected.Address(RVA = "0x2F874D0", Offset = "0x2F85ED0", VA = "0x182F874D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<GiftCategory> repeatedField = categories_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DCC")]
		[Cpp2IlInjected.Address(RVA = "0x2F87EF0", Offset = "0x2F868F0", VA = "0x182F87EF0")]
		static GiftFriendship()
		{
			Func<GiftFriendship> func = default(Func<GiftFriendship>);
			_parser = (MessageParser<GiftFriendship>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<GiftCategory> parser = GiftCategory._parser;
			uint num = default(uint);
			_parser = (MessageParser<GiftFriendship>)(object)FieldCodec.ForMessage<GiftCategory>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
