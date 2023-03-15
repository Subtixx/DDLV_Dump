using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class Inbox : IMessage<Inbox>, IMessage, IEquatable<Inbox>, IDeepCloneable<Inbox>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private static readonly MessageParser<Inbox> _parser = (MessageParser<Inbox>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new Inbox()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public const int UniqueMessageIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private ulong uniqueMessageId_;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public const int InboxMessagesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private static readonly FieldCodec<InboxMessage> _repeated_inboxMessages_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private readonly RepeatedField<InboxMessage> inboxMessages_ = (RepeatedField<InboxMessage>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		[JsonIgnore]
		public static readonly int RefreshIntervalInSeconds;

		[Cpp2IlInjected.Token(Token = "0x17000293")]
		[DebuggerNonUserCode]
		public static MessageParser<Inbox> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x27BB720", Offset = "0x27BA120", VA = "0x1827BB720")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000294")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8A")]
			[Cpp2IlInjected.Address(RVA = "0x27BB3B0", Offset = "0x27B9DB0", VA = "0x1827BB3B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000295")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8B")]
			[Cpp2IlInjected.Address(RVA = "0x27BB780", Offset = "0x27BA180", VA = "0x1827BB780", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000296")]
		[DebuggerNonUserCode]
		public ulong UniqueMessageId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return uniqueMessageId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A90")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			set
			{
				uniqueMessageId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000297")]
		[DebuggerNonUserCode]
		public RepeatedField<InboxMessage> InboxMessages
		{
			[Cpp2IlInjected.Token(Token = "0x6000A91")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return inboxMessages_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public bool HasAnyUnreadMessages
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9D")]
			[Cpp2IlInjected.Address(RVA = "0x27BB5D0", Offset = "0x27B9FD0", VA = "0x1827BB5D0")]
			get
			{
				RepeatedField<InboxMessage> repeatedField = inboxMessages_;
				Predicate<InboxMessage> _003C_003E9__35_ = _003C_003Ec._003C_003E9__35_0;
				if (_003C_003E9__35_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((InboxMessage x) => x.IsUnread);
				}
				return ((RepeatedField<>)(object)repeatedField).Any<InboxMessage>((Predicate<>)(object)_003C_003E9__35_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public bool HasAnyUnclaimedMessages
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9E")]
			[Cpp2IlInjected.Address(RVA = "0x27BB480", Offset = "0x27B9E80", VA = "0x1827BB480")]
			get
			{
				RepeatedField<InboxMessage> repeatedField = inboxMessages_;
				Predicate<InboxMessage> _003C_003E9__37_ = _003C_003Ec._003C_003E9__37_0;
				if (_003C_003E9__37_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((InboxMessage x) => x.IsClaimable);
				}
				return ((RepeatedField<>)(object)repeatedField).Any<InboxMessage>((Predicate<>)(object)_003C_003E9__37_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x27BB230", Offset = "0x27B9C30", VA = "0x1827BB230")]
		[DebuggerNonUserCode]
		public Inbox()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x27BB2B0", Offset = "0x27B9CB0", VA = "0x1827BB2B0")]
		[DebuggerNonUserCode]
		public Inbox(Inbox other)
		{
			ulong num = (uniqueMessageId_ = other.uniqueMessageId_);
			RepeatedField<InboxMessage> repeatedField = (inboxMessages_ = (RepeatedField<InboxMessage>)(object)((RepeatedField<T>)(object)other.inboxMessages_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x27BA1B0", Offset = "0x27B8BB0", VA = "0x1827BA1B0", Slot = "10")]
		[DebuggerNonUserCode]
		public Inbox Clone()
		{
			//Discarded unreachable code: IL_004b
			Inbox inbox = new Inbox();
			RepeatedField<InboxMessage> repeatedField = (inbox.inboxMessages_ = (RepeatedField<InboxMessage>)(object)new RepeatedField<T>());
			ulong num = (inbox.uniqueMessageId_ = uniqueMessageId_);
			RepeatedField<InboxMessage> repeatedField2 = (inbox.inboxMessages_ = (RepeatedField<InboxMessage>)(object)((RepeatedField<T>)(object)inboxMessages_).Clone());
			UnknownFieldSet unknownFieldSet = (inbox._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return inbox;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x27BA2E0", Offset = "0x27B8CE0", VA = "0x1827BA2E0", Slot = "0")]
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
				if (uniqueMessageId_ == (ulong)(long)typeof(Inbox).TypeHandle)
				{
					RepeatedField<InboxMessage> repeatedField = inboxMessages_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x27BA3C0", Offset = "0x27B8DC0", VA = "0x1827BA3C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Inbox other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ulong num = other.uniqueMessageId_;
				if (uniqueMessageId_ == num)
				{
					RepeatedField<InboxMessage> repeatedField = inboxMessages_;
					RepeatedField<InboxMessage> repeatedField2 = other.inboxMessages_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x27BA770", Offset = "0x27B9170", VA = "0x1827BA770", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002c
			if (uniqueMessageId_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)inboxMessages_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A95")]
		[Cpp2IlInjected.Address(RVA = "0x27BAF00", Offset = "0x27B9900", VA = "0x1827BAF00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A96")]
		[Cpp2IlInjected.Address(RVA = "0x27BAF60", Offset = "0x27B9960", VA = "0x1827BAF60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (uniqueMessageId_ != 0)
			{
				ulong value = uniqueMessageId_;
				output.WriteUInt64(value);
			}
			RepeatedField<InboxMessage> repeatedField = inboxMessages_;
			FieldCodec<InboxMessage> repeated_inboxMessages_codec = _repeated_inboxMessages_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_inboxMessages_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A97")]
		[Cpp2IlInjected.Address(RVA = "0x27BA040", Offset = "0x27B8A40", VA = "0x1827BA040", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0056
			ulong num = uniqueMessageId_;
			int num2 = 0;
			int num3 = default(int);
			if (num != 0)
			{
				num3 = CodedOutputStream.ComputeUInt64Size(num) + 1;
			}
			RepeatedField<InboxMessage> repeatedField = inboxMessages_;
			FieldCodec<InboxMessage> repeated_inboxMessages_codec = _repeated_inboxMessages_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_inboxMessages_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num3 += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num3 += num5;
			}
			return num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x27BAC30", Offset = "0x27B9630", VA = "0x1827BAC30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Inbox other)
		{
			//Discarded unreachable code: IL_004b
			if (other != null)
			{
				ulong num = other.uniqueMessageId_;
				if (num != 0)
				{
					uniqueMessageId_ = num;
				}
				RepeatedField<InboxMessage> repeatedField = inboxMessages_;
				RepeatedField<InboxMessage> repeatedField2 = other.inboxMessages_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x27BACC0", Offset = "0x27B96C0", VA = "0x1827BACC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					ulong num2 = (uniqueMessageId_ = input.ReadUInt64());
				}
				if (num == 18)
				{
					RepeatedField<InboxMessage> repeatedField = inboxMessages_;
					FieldCodec<InboxMessage> repeated_inboxMessages_codec = _repeated_inboxMessages_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_inboxMessages_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x27BA6A0", Offset = "0x27B90A0", VA = "0x1827BA6A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ulong num = uniqueMessageId_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<InboxMessage> repeatedField = inboxMessages_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x27BAE30", Offset = "0x27B9830", VA = "0x1827BAE30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I8, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				uniqueMessageId_ = (ulong)(long)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x27BA140", Offset = "0x27B8B40", VA = "0x1827BA140", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				uniqueMessageId_ = 0uL;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<InboxMessage> repeatedField = inboxMessages_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x27BA910", Offset = "0x27B9310", VA = "0x1827BA910")]
		public InboxMessage GetMessage(string id, [Optional] string onlineInstanceId)
		{
			//Discarded unreachable code: IL_004e
			InboxMessageKey inboxMessageKey = new InboxMessageKey();
			inboxMessageKey.id_ = "";
			inboxMessageKey.onlineInstanceId_ = "";
			string text = (inboxMessageKey.id_ = ProtoPreconditions.CheckNotNull(id, "value"));
			string text2 = (inboxMessageKey.onlineInstanceId_ = ProtoPreconditions.CheckNotNull("", "value"));
			return GetMessage(inboxMessageKey);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x27BA800", Offset = "0x27B9200", VA = "0x1827BA800")]
		public InboxMessage GetMessage(InboxMessageKey msgKey)
		{
			//Discarded unreachable code: IL_0029
			RepeatedField<InboxMessage> repeatedField = inboxMessages_;
			Predicate<InboxMessage> predicate = (Predicate<InboxMessage>)(object)(Predicate<T>)delegate(InboxMessage x)
			{
				//Discarded unreachable code: IL_0016
				InboxMessageKey key_ = x.key_;
				InboxMessageKey other = msgKey;
				return key_.Equals(other);
			};
			return ((RepeatedField<>)(object)repeatedField).Find<InboxMessage>((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x27BAAA0", Offset = "0x27B94A0", VA = "0x1827BAAA0")]
		public bool HasMessage(string id, [Optional] string onlineInstanceId)
		{
			//Discarded unreachable code: IL_0054
			InboxMessageKey inboxMessageKey = new InboxMessageKey();
			inboxMessageKey.id_ = "";
			inboxMessageKey.onlineInstanceId_ = "";
			string text = (inboxMessageKey.id_ = ProtoPreconditions.CheckNotNull(id, "value"));
			string text2 = (inboxMessageKey.onlineInstanceId_ = ProtoPreconditions.CheckNotNull("", "value"));
			return GetMessage(inboxMessageKey) != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x27BADC0", Offset = "0x27B97C0", VA = "0x1827BADC0")]
		public bool RemoveMessage(InboxMessageKey msgKey)
		{
			//Discarded unreachable code: IL_0017
			RepeatedField<InboxMessage> repeatedField = inboxMessages_;
			InboxMessage message = GetMessage(msgKey);
			return ((RepeatedField<T>)(object)repeatedField).Remove((T)message);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0x27B9C20", Offset = "0x27B8620", VA = "0x1827B9C20")]
		public bool AddMessages(IEnumerable<InboxMessage> messages)
		{
			//Discarded unreachable code: IL_002f
			bool success = true;
			Action<InboxMessage> action = (Action<InboxMessage>)(object)(Action<T>)delegate(InboxMessage x)
			{
				//Discarded unreachable code: IL_0028
				if (!success)
				{
					success = false;
				}
				else
				{
					success = AddMessage(x);
				}
			};
			MoreLinq.ForEach<InboxMessage>((IEnumerable<>)messages, (Action<>)(object)action);
			return success;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x27B98C0", Offset = "0x27B82C0", VA = "0x1827B98C0")]
		public bool AddMessage(InboxMessage inboxMsg)
		{
			//IL_008f: Expected O, but got I8
			InboxMessage inboxMessage = inboxMsg;
			InboxMessageKey inboxMessageKey = default(InboxMessageKey);
			string onlineInstanceId_ = inboxMessageKey.onlineInstanceId_;
			InboxMessage inboxMessage2 = inboxMsg;
			string id_ = inboxMessage2.key_.id_;
			if (inboxMessage2 == null)
			{
				RepeatedField<InboxMessage> repeatedField = inboxMessages_;
				Predicate<InboxMessage> predicate = (Predicate<InboxMessage>)(object)(Predicate<T>)delegate(InboxMessage x)
				{
					//Discarded unreachable code: IL_0025
					InboxMessageKey key_3 = inboxMsg.key_;
					string id_2 = x.key_.id_;
					return string.Equals(key_3.id_, id_2);
				};
				if (!((RepeatedField<>)(object)repeatedField).Any<InboxMessage>((Predicate<>)(object)predicate))
				{
					goto IL_010f;
				}
			}
			InboxMessage inboxMessage3 = inboxMsg;
			ulong num = uniqueMessageId_;
			InboxMessageKey key_ = inboxMessage3.key_;
			string text = (key_.id_ = ProtoPreconditions.CheckNotNull($"{uniqueMessageId_ = num + 1}", "value"));
			InboxMessage inboxMessage4 = inboxMsg;
			Timestamp expirationDate_ = inboxMessage4.expirationDate_;
			int num2 = 0;
			DateTime dateTime = expirationDate_.ToDateTime();
			DateTime dateTime2 = default(DateTime);
			Timestamp timestamp = (inboxMessage4.expirationDate_ = dateTime2.ToProto());
			InboxMessage inboxMessage5 = inboxMsg;
			Timestamp timestamp2 = (inboxMessage5.deletionDate_ = inboxMessage5.expirationDate_);
			RepeatedField<InboxMessage> repeatedField2 = inboxMessages_;
			Predicate<InboxMessage> predicate2 = (Predicate<InboxMessage>)(object)(Predicate<T>)delegate(InboxMessage x)
			{
				//Discarded unreachable code: IL_0018
				InboxMessage inboxMessage6 = inboxMsg;
				InboxMessageKey key_2 = x.key_;
				return inboxMessage6.key_ == key_2;
			};
			if (!((RepeatedField<>)(object)repeatedField2).Any<InboxMessage>((Predicate<>)(object)predicate2))
			{
				goto IL_010f;
			}
			goto IL_0128;
			IL_0128:
			throw new NullReferenceException();
			IL_010f:
			RepeatedField<InboxMessage> repeatedField3 = inboxMessages_;
			InboxMessage item = inboxMsg;
			((RepeatedField<T>)(object)repeatedField3).Add((T)item);
			goto IL_0128;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x27B9D10", Offset = "0x27B8710", VA = "0x1827B9D10")]
		public InboxMessage AddRewardMessage(InboxMessage baseData, Dictionary<int, int> items, Dictionary<string, int> currencies)
		{
			//Discarded unreachable code: IL_006b
			//IL_005e: Expected O, but got I4
			if (currencies != null)
			{
				Func<KeyValuePair<string, int>, int> _003C_003E9__44_ = _003C_003Ec._003C_003E9__44_0;
				if (_003C_003E9__44_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				Func<KeyValuePair<string, int>, int> func = default(Func<KeyValuePair<string, int>, int>);
				if (_003C_003Ec._003C_003E9__44_1 == null)
				{
					func = (Func<KeyValuePair<string, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				Dictionary<string, KeyValuePair<string, int>> dictionary = (Dictionary<string, KeyValuePair<string, int>>)(object)Enumerable.ToDictionary<KeyValuePair<string, int>, int, int>((IEnumerable<>)currencies, (Func<, >)(object)_003C_003E9__44_, (Func<, >)(object)func);
			}
			int num = 0;
			InboxMessage inboxMessage = new InboxMessage(baseData);
			inboxMessage.AddRewardAttachment((Dictionary<, >)(object)items, (Dictionary<, >)num);
			bool flag = AddMessage(inboxMessage);
			return inboxMessage;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x27B9F90", Offset = "0x27B8990", VA = "0x1827B9F90")]
		public InboxMessage AddRewardMessage(InboxMessage baseData, Dictionary<int, int> items, Dictionary<int, int> currencies)
		{
			//Discarded unreachable code: IL_0019
			InboxMessage inboxMessage = new InboxMessage(baseData);
			inboxMessage.AddRewardAttachment((Dictionary<, >)(object)items, (Dictionary<, >)(object)currencies);
			bool flag = AddMessage(inboxMessage);
			return inboxMessage;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x27BA460", Offset = "0x27B8E60", VA = "0x1827BA460")]
		public IEnumerable<InboxMessage> GetClaimableRewardMessages(InboxMessageType msgType = InboxMessageType.Unset)
		{
			//Discarded unreachable code: IL_003a
			RepeatedField<InboxMessageKey> repeatedField = (RepeatedField<InboxMessageKey>)(object)new RepeatedField<T>();
			RepeatedField<InboxMessageKey> msgKeys = repeatedField;
			RepeatedField<InboxMessage> repeatedField2 = inboxMessages_;
			Func<InboxMessage, bool> func = (Func<InboxMessage, bool>)(object)(Func<T, TResult>)delegate(InboxMessage x)
			{
				if (((RepeatedField<T>)(object)msgKeys).Count > 0)
				{
					RepeatedField<InboxMessageKey> repeatedField3 = msgKeys;
					Predicate<InboxMessageKey> predicate = (Predicate<InboxMessageKey>)(object)(Predicate<T>)delegate(InboxMessageKey y)
					{
						//Discarded unreachable code: IL_0014
						InboxMessageKey key_ = x.key_;
						return y.Equals(key_);
					};
					if (!((RepeatedField<>)(object)repeatedField3).Any<InboxMessageKey>((Predicate<>)(object)predicate))
					{
						goto IL_0049;
					}
				}
				InboxMessage inboxMessage = x;
				if (!inboxMessage.IsClaimable)
				{
					goto IL_0049;
				}
				goto IL_004c;
				IL_004c:
				if (inboxMessage == null)
				{
				}
				InboxMessage inboxMessage2 = x;
				throw new NullReferenceException();
				IL_0049:
				int num = 0;
				goto IL_004c;
			};
			return (IEnumerable<InboxMessage>)Enumerable.Where<InboxMessage>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x27BA5A0", Offset = "0x27B8FA0", VA = "0x1827BA5A0")]
		public IEnumerable<InboxMessage> GetClaimableRewardMessages(RepeatedField<InboxMessageKey> msgKeys, InboxMessageType msgType = InboxMessageType.Unset)
		{
			//Discarded unreachable code: IL_0032
			RepeatedField<InboxMessage> repeatedField = inboxMessages_;
			Func<InboxMessage, bool> func = (Func<InboxMessage, bool>)(object)(Func<T, TResult>)delegate(InboxMessage x)
			{
				if (((RepeatedField<T>)(object)msgKeys).Count > 0)
				{
					RepeatedField<InboxMessageKey> repeatedField2 = msgKeys;
					Predicate<InboxMessageKey> predicate = (Predicate<InboxMessageKey>)(object)(Predicate<T>)delegate(InboxMessageKey y)
					{
						//Discarded unreachable code: IL_0014
						InboxMessageKey key_ = x.key_;
						return y.Equals(key_);
					};
					if (!((RepeatedField<>)(object)repeatedField2).Any<InboxMessageKey>((Predicate<>)(object)predicate))
					{
						goto IL_0049;
					}
				}
				InboxMessage inboxMessage = x;
				if (!inboxMessage.IsClaimable)
				{
					goto IL_0049;
				}
				goto IL_004c;
				IL_004c:
				if (inboxMessage == null)
				{
				}
				InboxMessage inboxMessage2 = x;
				throw new NullReferenceException();
				IL_0049:
				int num = 0;
				goto IL_004c;
			};
			return (IEnumerable<InboxMessage>)Enumerable.Where<InboxMessage>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x27BB050", Offset = "0x27B9A50", VA = "0x1827BB050")]
		static Inbox()
		{
			MessageParser<InboxMessage> parser = InboxMessage._parser;
			uint num = default(uint);
			_parser = (MessageParser<Inbox>)(object)FieldCodec.ForMessage<InboxMessage>(num, (MessageParser<>)(object)parser);
		}
	}
}
