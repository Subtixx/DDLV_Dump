using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class InboxMessage : IMessage<InboxMessage>, IMessage, IEquatable<InboxMessage>, IDeepCloneable<InboxMessage>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private static readonly MessageParser<InboxMessage> _parser = (MessageParser<InboxMessage>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new InboxMessage()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public const int KeyFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private InboxMessageKey key_;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public const int TitleFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private string title_ = "";

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public const int SubtitleFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private string subtitle_ = "";

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public const int MessageFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private string message_ = "";

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public const int FriendlyNameFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private string friendlyName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public const int TypeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private InboxMessageType type_;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public const int StatusFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private InboxMessageStatus status_;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public const int AccessRestrictionFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private int accessRestriction_;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public const int OriginIdFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private string originId_ = "";

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public const int CreationDateFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private Timestamp creationDate_;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public const int StartDateFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private Timestamp startDate_;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public const int ExpirationDateFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private Timestamp expirationDate_;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public const int DeletionDateFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private Timestamp deletionDate_;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public const int AttachmentsFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private static readonly FieldCodec<InboxAttachment> _repeated_attachments_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private readonly RepeatedField<InboxAttachment> attachments_ = (RepeatedField<InboxAttachment>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		[JsonIgnore]
		public const int NumberOfDaysAvailable = 30;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		[JsonIgnore]
		public const int NumberOfDaysAvailableWithRewards = 60;

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		[DebuggerNonUserCode]
		public static MessageParser<InboxMessage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x27B9520", Offset = "0x27B7F20", VA = "0x1827B9520")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0x27B9130", Offset = "0x27B7B30", VA = "0x1827B9130")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0x27B9580", Offset = "0x27B7F80", VA = "0x1827B9580", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		[DebuggerNonUserCode]
		public InboxMessageKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return key_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				key_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		[DebuggerNonUserCode]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return title_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x27B9850", Offset = "0x27B8250", VA = "0x1827B9850")]
			set
			{
				string text = (title_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		[DebuggerNonUserCode]
		public string Subtitle
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return subtitle_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x27B97E0", Offset = "0x27B81E0", VA = "0x1827B97E0")]
			set
			{
				string text = (subtitle_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000281")]
		[DebuggerNonUserCode]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return message_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x27B9700", Offset = "0x27B8100", VA = "0x1827B9700")]
			set
			{
				string text = (message_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		[DebuggerNonUserCode]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return friendlyName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A52")]
			[Cpp2IlInjected.Address(RVA = "0x27B9690", Offset = "0x27B8090", VA = "0x1827B9690")]
			set
			{
				string text = (friendlyName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		[DebuggerNonUserCode]
		public InboxMessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000A53")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A54")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		[DebuggerNonUserCode]
		public InboxMessageStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return status_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set
			{
				status_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		[DebuggerNonUserCode]
		public int AccessRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6000A57")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return accessRestriction_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A58")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				accessRestriction_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		[DebuggerNonUserCode]
		public string OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A59")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return originId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5A")]
			[Cpp2IlInjected.Address(RVA = "0x27B9770", Offset = "0x27B8170", VA = "0x1827B9770")]
			set
			{
				string text = (originId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		[DebuggerNonUserCode]
		public Timestamp CreationDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5B")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return creationDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				creationDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		[DebuggerNonUserCode]
		public Timestamp StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return startDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				startDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000289")]
		[DebuggerNonUserCode]
		public Timestamp ExpirationDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return expirationDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A60")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				expirationDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028A")]
		[DebuggerNonUserCode]
		public Timestamp DeletionDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000A61")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return deletionDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A62")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				deletionDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		[DebuggerNonUserCode]
		public RepeatedField<InboxAttachment> Attachments
		{
			[Cpp2IlInjected.Token(Token = "0x6000A63")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return attachments_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		[JsonIgnore]
		public bool IsUnread
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6F")]
			[Cpp2IlInjected.Address(RVA = "0x27B9510", Offset = "0x27B7F10", VA = "0x1827B9510")]
			get
			{
				return status_ == InboxMessageStatus.Unread;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		[JsonIgnore]
		public bool IsRead
		{
			[Cpp2IlInjected.Token(Token = "0x6000A70")]
			[Cpp2IlInjected.Address(RVA = "0x27B9500", Offset = "0x27B7F00", VA = "0x1827B9500")]
			get
			{
				return status_ != InboxMessageStatus.Unread;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		[JsonIgnore]
		public bool IsClaimed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A71")]
			[Cpp2IlInjected.Address(RVA = "0x27B94B0", Offset = "0x27B7EB0", VA = "0x1827B94B0")]
			get
			{
				return status_ == InboxMessageStatus.Claimed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		[JsonIgnore]
		public bool IsClaimable
		{
			[Cpp2IlInjected.Token(Token = "0x6000A72")]
			[Cpp2IlInjected.Address(RVA = "0x27B92B0", Offset = "0x27B7CB0", VA = "0x1827B92B0")]
			get
			{
				if (status_ != InboxMessageStatus.Claimed)
				{
					long num = expirationDate_.ToEpoch();
					int num2 = 0;
					long num3 = DateTime.UtcNow.ToProto().ToEpoch();
					RepeatedField<InboxAttachment> repeatedField = attachments_;
					Predicate<InboxAttachment> _003C_003E9__102_ = _003C_003Ec._003C_003E9__102_0;
					if (_003C_003E9__102_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((InboxAttachment x) => x.RewardAttachment != null);
					}
					return ((RepeatedField<>)(object)repeatedField).Any<InboxAttachment>((Predicate<>)(object)_003C_003E9__102_);
				}
				int num4 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		[JsonIgnore]
		public bool IsOnline
		{
			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x27B94D0", Offset = "0x27B7ED0", VA = "0x1827B94D0")]
			get
			{
				//Discarded unreachable code: IL_0014
				return !string.IsNullOrEmpty(key_.onlineInstanceId_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000291")]
		[JsonIgnore]
		public bool HasExpired
		{
			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0x27B9200", Offset = "0x27B7C00", VA = "0x1827B9200")]
			get
			{
				long num = expirationDate_.ToEpoch();
				int num2 = 0;
				long num3 = DateTime.UtcNow.ToProto().ToEpoch();
				return num < num3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		[JsonIgnore]
		public bool IsMarkerPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A75")]
			[Cpp2IlInjected.Address(RVA = "0x27B94C0", Offset = "0x27B7EC0", VA = "0x1827B94C0")]
			get
			{
				return type_ == InboxMessageType.GameCommunication;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x27B9040", Offset = "0x27B7A40", VA = "0x1827B9040")]
		[DebuggerNonUserCode]
		public InboxMessage()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x27B81B0", Offset = "0x27B6BB0", VA = "0x1827B81B0")]
		private void OnConstruction()
		{
			InboxMessageKey inboxMessageKey = new InboxMessageKey();
			inboxMessageKey.id_ = "";
			inboxMessageKey.onlineInstanceId_ = "";
			key_ = inboxMessageKey;
			int num = (int)(type_ = InboxMessageType.Unset);
			int num2 = 0;
			Timestamp timestamp = (creationDate_ = DateTime.UtcNow.ToProto());
			int num3 = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			Timestamp timestamp2 = (expirationDate_ = dateTime.ToProto());
			int num4 = 0;
			DateTime utcNow2 = DateTime.UtcNow;
			DateTime dateTime2 = default(DateTime);
			Timestamp timestamp3 = (deletionDate_ = dateTime2.ToProto());
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x27B8CF0", Offset = "0x27B76F0", VA = "0x1827B8CF0")]
		[DebuggerNonUserCode]
		public InboxMessage(InboxMessage other)
		{
			//IL_00b5: Expected O, but got I4
			//IL_0152: Expected O, but got I4
			//IL_016f: Expected O, but got I4
			//IL_018c: Expected O, but got I4
			OnConstruction();
			int num = 0;
			InboxMessageKey inboxMessageKey = other.key_;
			if (inboxMessageKey != null)
			{
				InboxMessageKey inboxMessageKey2 = new InboxMessageKey
				{
					id_ = "",
					onlineInstanceId_ = ""
				};
				string text = (inboxMessageKey2.id_ = inboxMessageKey.id_);
				string text2 = (inboxMessageKey2.onlineInstanceId_ = inboxMessageKey.onlineInstanceId_);
				UnknownFieldSet unknownFieldSet = (inboxMessageKey2._unknownFields = UnknownFieldSet.Clone(inboxMessageKey._unknownFields));
			}
			key_ = (InboxMessageKey)num;
			string text3 = (title_ = other.title_);
			string text4 = (subtitle_ = other.subtitle_);
			string text5 = (message_ = other.message_);
			string text6 = (friendlyName_ = other.friendlyName_);
			InboxMessageType inboxMessageType = (type_ = other.type_);
			InboxMessageStatus inboxMessageStatus = (status_ = other.status_);
			int num2 = (accessRestriction_ = other.accessRestriction_);
			string text7 = (originId_ = other.originId_);
			Timestamp timestamp = other.creationDate_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			creationDate_ = (Timestamp)num;
			Timestamp timestamp3 = other.startDate_;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			startDate_ = (Timestamp)num;
			Timestamp timestamp5 = other.expirationDate_;
			if (timestamp5 != null)
			{
				Timestamp timestamp6 = timestamp5.Clone();
			}
			expirationDate_ = (Timestamp)num;
			Timestamp timestamp7 = other.deletionDate_;
			Timestamp timestamp8 = default(Timestamp);
			if (timestamp7 != null)
			{
				timestamp8 = timestamp7.Clone();
			}
			deletionDate_ = timestamp8;
			RepeatedField<InboxAttachment> repeatedField = (attachments_ = (RepeatedField<InboxAttachment>)(object)((RepeatedField<T>)(object)other.attachments_).Clone());
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x27B7060", Offset = "0x27B5A60", VA = "0x1827B7060", Slot = "10")]
		[DebuggerNonUserCode]
		public InboxMessage Clone()
		{
			return new InboxMessage(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x27B7260", Offset = "0x27B5C60", VA = "0x1827B7260", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((InboxMessage)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x27B70C0", Offset = "0x27B5AC0", VA = "0x1827B70C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(InboxMessage other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				InboxMessageKey objB = other.key_;
				if (object.Equals(key_, objB))
				{
					string text = other.title_;
					if (!(title_ != text))
					{
						string text2 = other.subtitle_;
						if (!(subtitle_ != text2))
						{
							string text3 = other.message_;
							if (!(message_ != text3))
							{
								string text4 = other.friendlyName_;
								if (!(friendlyName_ != text4))
								{
									InboxMessageType inboxMessageType = other.type_;
									if (type_ == inboxMessageType)
									{
										InboxMessageStatus inboxMessageStatus = other.status_;
										if (status_ == inboxMessageStatus)
										{
											int num = other.accessRestriction_;
											if (accessRestriction_ == num)
											{
												string text5 = other.originId_;
												if (!(originId_ != text5))
												{
													Timestamp objB2 = other.creationDate_;
													if (object.Equals(creationDate_, objB2))
													{
														Timestamp objB3 = other.startDate_;
														if (object.Equals(startDate_, objB3))
														{
															Timestamp objB4 = other.expirationDate_;
															if (object.Equals(expirationDate_, objB4))
															{
																Timestamp objB5 = other.deletionDate_;
																if (object.Equals(deletionDate_, objB5))
																{
																	RepeatedField<InboxAttachment> repeatedField = attachments_;
																	RepeatedField<InboxAttachment> repeatedField2 = other.attachments_;
																	if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																	{
																		UnknownFieldSet unknownFields = other._unknownFields;
																		return object.Equals(_unknownFields, unknownFields);
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0x27B74D0", Offset = "0x27B5ED0", VA = "0x1827B74D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0130
			int num = 0;
			InboxMessageKey inboxMessageKey = key_;
			if (inboxMessageKey != null)
			{
				int hashCode = inboxMessageKey.GetHashCode();
			}
			string text = title_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			string text2 = subtitle_;
			if (text2.m_stringLength != 0)
			{
				int hashCode3 = text2.GetHashCode();
			}
			string text3 = message_;
			if (text3.m_stringLength != 0)
			{
				int hashCode4 = text3.GetHashCode();
			}
			string text4 = friendlyName_;
			if (text4.m_stringLength != 0)
			{
				int hashCode5 = text4.GetHashCode();
			}
			if (type_ != 0)
			{
			}
			if (status_ != 0)
			{
			}
			if (accessRestriction_ != 0)
			{
			}
			string text5 = originId_;
			if (text5.m_stringLength != 0)
			{
				int hashCode6 = text5.GetHashCode();
			}
			Timestamp timestamp = creationDate_;
			if (timestamp != null)
			{
				int hashCode7 = timestamp.GetHashCode();
			}
			Timestamp timestamp2 = startDate_;
			if (timestamp2 != null)
			{
				int hashCode8 = timestamp2.GetHashCode();
			}
			Timestamp timestamp3 = expirationDate_;
			if (timestamp3 != null)
			{
				int hashCode9 = timestamp3.GetHashCode();
			}
			Timestamp timestamp4 = deletionDate_;
			if (timestamp4 != null)
			{
				int hashCode10 = timestamp4.GetHashCode();
			}
			int hashCode11 = ((RepeatedField<T>)(object)attachments_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode12 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x27B8790", Offset = "0x27B7190", VA = "0x1827B8790", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0x27B87F0", Offset = "0x27B71F0", VA = "0x1827B87F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_016f
			if ((long)key_ != 0)
			{
				InboxMessageKey value = key_;
				output.WriteMessage(value);
			}
			if (title_.m_stringLength != 0)
			{
				string value2 = title_;
				output.WriteString(value2);
			}
			if (subtitle_.m_stringLength != 0)
			{
				string value3 = subtitle_;
				output.WriteString(value3);
			}
			if (message_.m_stringLength != 0)
			{
				string value4 = message_;
				output.WriteString(value4);
			}
			if (friendlyName_.m_stringLength != 0)
			{
				string value5 = friendlyName_;
				output.WriteString(value5);
			}
			if (type_ != 0)
			{
			}
			if (status_ != 0)
			{
			}
			if (accessRestriction_ != 0)
			{
				int value6 = accessRestriction_;
				output.WriteInt32(value6);
			}
			if (originId_.m_stringLength != 0)
			{
				string value7 = originId_;
				output.WriteString(value7);
			}
			if ((long)creationDate_ != 0)
			{
				Timestamp value8 = creationDate_;
				output.WriteMessage(value8);
			}
			if ((long)startDate_ != 0)
			{
				Timestamp value9 = startDate_;
				output.WriteMessage(value9);
			}
			if ((long)expirationDate_ != 0)
			{
				Timestamp value10 = expirationDate_;
				output.WriteMessage(value10);
			}
			if ((long)deletionDate_ != 0)
			{
				Timestamp value11 = deletionDate_;
				output.WriteMessage(value11);
			}
			RepeatedField<InboxAttachment> repeatedField = attachments_;
			FieldCodec<InboxAttachment> repeated_attachments_codec = _repeated_attachments_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_attachments_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x27B6B00", Offset = "0x27B5500", VA = "0x1827B6B00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01f2
			InboxMessageKey inboxMessageKey = key_;
			int num = 0;
			if (inboxMessageKey != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(inboxMessageKey);
			}
			string text = title_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			string text2 = subtitle_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				num += num4;
			}
			string text3 = message_;
			if (text3.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text3);
				num5++;
				num += num5;
			}
			string text4 = friendlyName_;
			if (text4.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text4);
				num6++;
				num += num6;
			}
			InboxMessageType inboxMessageType = type_;
			if (inboxMessageType != 0)
			{
				int num7 = CodedOutputStream.ComputeEnumSize((int)inboxMessageType);
				num7++;
				num += num7;
			}
			InboxMessageStatus inboxMessageStatus = status_;
			if (inboxMessageStatus != 0)
			{
				int num8 = CodedOutputStream.ComputeEnumSize((int)inboxMessageStatus);
				num8++;
				num += num8;
			}
			int num9 = accessRestriction_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num += num10;
			}
			string text5 = originId_;
			if (text5.m_stringLength != 0)
			{
				int num11 = CodedOutputStream.ComputeStringSize(text5);
				num11++;
				num += num11;
			}
			Timestamp timestamp = creationDate_;
			if (timestamp != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(timestamp);
				num12++;
				num += num12;
			}
			Timestamp timestamp2 = startDate_;
			if (timestamp2 != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(timestamp2);
				num13++;
				num += num13;
			}
			Timestamp timestamp3 = expirationDate_;
			if (timestamp3 != null)
			{
				int num14 = CodedOutputStream.ComputeMessageSize(timestamp3);
				num14++;
				num += num14;
			}
			Timestamp timestamp4 = deletionDate_;
			if (timestamp4 != null)
			{
				int num15 = CodedOutputStream.ComputeMessageSize(timestamp4);
				num15++;
				num += num15;
			}
			RepeatedField<InboxAttachment> repeatedField = attachments_;
			FieldCodec<InboxAttachment> repeated_attachments_codec = _repeated_attachments_codec;
			int num16 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_attachments_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num16;
			if (unknownFields != null)
			{
				int num17 = unknownFields.CalculateSize();
				num += num17;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x27B7AA0", Offset = "0x27B64A0", VA = "0x1827B7AA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(InboxMessage other)
		{
			//Discarded unreachable code: IL_0275
			if (other == null)
			{
				return;
			}
			InboxMessageKey inboxMessageKey = other.key_;
			if (inboxMessageKey != null)
			{
				InboxMessageKey inboxMessageKey2 = key_;
				if (inboxMessageKey2 == null)
				{
					InboxMessageKey inboxMessageKey3 = (key_ = new InboxMessageKey());
					InboxMessageKey inboxMessageKey4 = key_;
				}
				if (inboxMessageKey != null)
				{
					string id_ = inboxMessageKey.id_;
					if (id_.m_stringLength != 0)
					{
						inboxMessageKey2.Id = id_;
					}
					string onlineInstanceId_ = inboxMessageKey.onlineInstanceId_;
					if (onlineInstanceId_.m_stringLength != 0)
					{
						inboxMessageKey2.OnlineInstanceId = onlineInstanceId_;
					}
					UnknownFieldSet unknownFields = inboxMessageKey._unknownFields;
					UnknownFieldSet unknownFieldSet = (inboxMessageKey2._unknownFields = UnknownFieldSet.MergeFrom(inboxMessageKey2._unknownFields, unknownFields));
				}
			}
			string text = other.title_;
			if (text.m_stringLength != 0)
			{
				Title = text;
			}
			string text2 = other.subtitle_;
			if (text2.m_stringLength != 0)
			{
				Subtitle = text2;
			}
			string text3 = other.message_;
			if (text3.m_stringLength != 0)
			{
				Message = text3;
			}
			string text4 = other.friendlyName_;
			if (text4.m_stringLength != 0)
			{
				FriendlyName = text4;
			}
			InboxMessageType inboxMessageType = other.type_;
			if (inboxMessageType != 0)
			{
				type_ = inboxMessageType;
			}
			InboxMessageStatus inboxMessageStatus = other.status_;
			if (inboxMessageStatus != 0)
			{
				status_ = inboxMessageStatus;
			}
			int num = other.accessRestriction_;
			if (num != 0)
			{
				accessRestriction_ = num;
			}
			string text5 = other.originId_;
			if (text5.m_stringLength != 0)
			{
				OriginId = text5;
			}
			if ((long)other.creationDate_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (creationDate_ == null)
				{
					Timestamp timestamp = (creationDate_ = new Timestamp());
					timestamp2 = creationDate_;
				}
				Timestamp other2 = other.creationDate_;
				timestamp2.MergeFrom(other2);
			}
			if ((long)other.startDate_ != 0)
			{
				Timestamp timestamp4 = default(Timestamp);
				if (startDate_ == null)
				{
					Timestamp timestamp3 = (startDate_ = new Timestamp());
					timestamp4 = startDate_;
				}
				Timestamp other3 = other.startDate_;
				timestamp4.MergeFrom(other3);
			}
			if ((long)other.expirationDate_ != 0)
			{
				Timestamp timestamp6 = default(Timestamp);
				if (expirationDate_ == null)
				{
					Timestamp timestamp5 = (expirationDate_ = new Timestamp());
					timestamp6 = expirationDate_;
				}
				Timestamp other4 = other.expirationDate_;
				timestamp6.MergeFrom(other4);
			}
			if ((long)other.deletionDate_ != 0)
			{
				Timestamp timestamp8 = default(Timestamp);
				if (deletionDate_ == null)
				{
					Timestamp timestamp7 = (deletionDate_ = new Timestamp());
					timestamp8 = deletionDate_;
				}
				Timestamp other5 = other.deletionDate_;
				timestamp8.MergeFrom(other5);
			}
			RepeatedField<InboxAttachment> repeatedField = attachments_;
			RepeatedField<InboxAttachment> repeatedField2 = other.attachments_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x27B7E00", Offset = "0x27B6800", VA = "0x1827B7E00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_020c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 56)
			{
				if ((int)num > 82)
				{
					if ((int)num > 98)
					{
						if (num == 106)
						{
							Timestamp timestamp = deletionDate_;
							if (timestamp == null)
							{
								Timestamp timestamp2 = (deletionDate_ = new Timestamp());
							}
							input.ReadMessage(timestamp);
						}
						if (num != 114)
						{
							goto IL_01f5;
						}
						RepeatedField<InboxAttachment> repeatedField = attachments_;
						FieldCodec<InboxAttachment> repeated_attachments_codec = _repeated_attachments_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_attachments_codec);
					}
					Timestamp timestamp3 = default(Timestamp);
					if (num == 90)
					{
						Timestamp builder = default(Timestamp);
						if (startDate_ == null)
						{
							timestamp3 = (startDate_ = new Timestamp());
							builder = startDate_;
						}
						input.ReadMessage(builder);
					}
					if ((long)timestamp3 != 98)
					{
						goto IL_01f5;
					}
					Timestamp builder2 = default(Timestamp);
					if (expirationDate_ == null)
					{
						Timestamp timestamp4 = (expirationDate_ = new Timestamp());
						builder2 = expirationDate_;
					}
					input.ReadMessage(builder2);
				}
				int num2 = default(int);
				if (num == 64)
				{
					num2 = (accessRestriction_ = input.ReadInt32());
				}
				string text2 = default(string);
				if (num2 == 74)
				{
					text2 = (OriginId = input.ReadString());
				}
				if ((long)text2 != 82)
				{
					goto IL_01f5;
				}
				Timestamp builder3 = default(Timestamp);
				if (creationDate_ == null)
				{
					Timestamp timestamp5 = (creationDate_ = new Timestamp());
					builder3 = creationDate_;
				}
				input.ReadMessage(builder3);
			}
			string text6 = default(string);
			if ((int)num > 26)
			{
				int num4 = default(int);
				if ((int)num > 42)
				{
					int num3 = default(int);
					if (num == 48)
					{
						num3 = (int)(type_ = (InboxMessageType)input.ReadInt32());
					}
					if (num3 != 56)
					{
						goto IL_01f5;
					}
					num4 = (int)(status_ = (InboxMessageStatus)input.ReadInt32());
				}
				string text4 = default(string);
				if (num4 == 34)
				{
					text4 = (Message = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_01f5;
				}
				text6 = (FriendlyName = input.ReadString());
			}
			InboxMessageKey inboxMessageKey = default(InboxMessageKey);
			if ((long)text6 == 10)
			{
				InboxMessageKey builder4 = default(InboxMessageKey);
				if (key_ == null)
				{
					inboxMessageKey = (key_ = new InboxMessageKey());
					builder4 = key_;
				}
				input.ReadMessage(builder4);
			}
			string text8 = default(string);
			if ((long)inboxMessageKey == 18)
			{
				text8 = (Title = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (Subtitle = input.ReadString());
			}
			goto IL_01f5;
			IL_01f5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x27B72C0", Offset = "0x27B5CC0", VA = "0x1827B72C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 13)
			{
				InboxMessageKey inboxMessageKey = key_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x27B8340", Offset = "0x27B6D40", VA = "0x1827B8340", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_002a, IL_0032, IL_003a, IL_0042, IL_0043, IL_0054, IL_005a, IL_0060, IL_0066, IL_006c, IL_0072, IL_0078, IL_007e, IL_0084, IL_008a
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 13)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				key_ = (InboxMessageKey)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x27B6EA0", Offset = "0x27B58A0", VA = "0x1827B6EA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0008, IL_0009, IL_000a, IL_000b, IL_000c, IL_000d, IL_000e, IL_000f, IL_0012
			if (fieldNumber - 1 > 13)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x27B68E0", Offset = "0x27B52E0", VA = "0x1827B68E0")]
		public void AddRewardAttachment(Dictionary<int, int> items, Dictionary<string, int> currencies)
		{
			//Discarded unreachable code: IL_0056
			//IL_0055: Expected O, but got I4
			if (currencies != null)
			{
				Func<KeyValuePair<string, int>, int> _003C_003E9__109_ = _003C_003Ec._003C_003E9__109_0;
				if (_003C_003E9__109_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				Func<KeyValuePair<string, int>, int> func = default(Func<KeyValuePair<string, int>, int>);
				if (_003C_003Ec._003C_003E9__109_1 == null)
				{
					func = (Func<KeyValuePair<string, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				Dictionary<string, KeyValuePair<string, int>> dictionary = (Dictionary<string, KeyValuePair<string, int>>)(object)Enumerable.ToDictionary<KeyValuePair<string, int>, int, int>((IEnumerable<>)currencies, (Func<, >)(object)_003C_003E9__109_, (Func<, >)(object)func);
			}
			int num = 0;
			this.AddRewardAttachment((Dictionary<, >)(object)items, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0x27B64B0", Offset = "0x27B4EB0", VA = "0x1827B64B0")]
		public void AddRewardAttachment(Dictionary<int, int> items, Dictionary<int, int> currencies)
		{
			//Discarded unreachable code: IL_00cf
			//IL_00c5: Expected I4, but got I8
			List<InboxItemReward> list = (List<InboxItemReward>)(object)new List<T>();
			if (items != null)
			{
				Func<KeyValuePair<int, int>, InboxItemReward> _003C_003E9__110_ = _003C_003Ec._003C_003E9__110_0;
				if (_003C_003E9__110_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, int> x) => new InboxItemReward
					{
						id_ = (int)x,
						amount_ = 0
					});
				}
				IEnumerable<KeyValuePair<int, int>> enumerable = (IEnumerable<KeyValuePair<int, int>>)Enumerable.Select<KeyValuePair<int, int>, InboxItemReward>((IEnumerable<>)items, (Func<, >)(object)_003C_003E9__110_);
				((List<T>)(object)list).AddRange((IEnumerable<>)enumerable);
			}
			if (currencies != null)
			{
				Func<KeyValuePair<int, int>, InboxItemReward> func = default(Func<KeyValuePair<int, int>, InboxItemReward>);
				if (_003C_003Ec._003C_003E9__110_1 == null)
				{
					func = (Func<KeyValuePair<int, int>, InboxItemReward>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, int> x) => new InboxItemReward
					{
						id_ = (int)x,
						amount_ = 0
					}));
				}
				IEnumerable<KeyValuePair<int, int>> enumerable2 = (IEnumerable<KeyValuePair<int, int>>)Enumerable.Select<KeyValuePair<int, int>, InboxItemReward>((IEnumerable<>)currencies, (Func<, >)(object)func);
				((List<T>)(object)list).AddRange((IEnumerable<>)enumerable2);
			}
			RewardAttachment rewardAttachment = new RewardAttachment();
			((RepeatedField<T>)(object)rewardAttachment.rewards_).AddRange((IEnumerable<>)list);
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			deletionDate_ = (expirationDate_ = dateTime.ToProto());
			RepeatedField<InboxAttachment> repeatedField = attachments_;
			InboxAttachment inboxAttachment = new InboxAttachment();
			inboxAttachment.attachment_ = rewardAttachment;
			inboxAttachment.attachmentCase_ = InboxAttachment.AttachmentOneofCase.RewardAttachment;
			((RepeatedField<T>)(object)repeatedField).Add((T)inboxAttachment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x27B62F0", Offset = "0x27B4CF0", VA = "0x1827B62F0")]
		public void AddRewardAttachment(List<InboxItemReward> items)
		{
			//Discarded unreachable code: IL_005d
			//IL_0053: Expected I4, but got I8
			RewardAttachment rewardAttachment = new RewardAttachment();
			((RepeatedField<T>)(object)rewardAttachment.rewards_).AddRange((IEnumerable<>)items);
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			deletionDate_ = (expirationDate_ = dateTime.ToProto());
			RepeatedField<InboxAttachment> repeatedField = attachments_;
			InboxAttachment inboxAttachment = new InboxAttachment();
			inboxAttachment.attachment_ = rewardAttachment;
			inboxAttachment.attachmentCase_ = InboxAttachment.AttachmentOneofCase.RewardAttachment;
			((RepeatedField<T>)(object)repeatedField).Add((T)inboxAttachment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x27B61A0", Offset = "0x27B4BA0", VA = "0x1827B61A0")]
		public void AddRewardAttachment(RewardAttachment rewardAttachment)
		{
			//Discarded unreachable code: IL_0050
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			deletionDate_ = (expirationDate_ = dateTime.ToProto());
			RepeatedField<InboxAttachment> repeatedField = attachments_;
			InboxAttachment inboxAttachment = new InboxAttachment();
			inboxAttachment.attachment_ = rewardAttachment;
			bool flag = (byte)(inboxAttachment.attachmentCase_ = ((rewardAttachment != null) ? InboxAttachment.AttachmentOneofCase.RewardAttachment : InboxAttachment.AttachmentOneofCase.None)) != 0;
			((RepeatedField<T>)(object)repeatedField).Add((T)inboxAttachment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x27B76D0", Offset = "0x27B60D0", VA = "0x1827B76D0")]
		public List<InboxItemReward> GetRewards()
		{
			//Discarded unreachable code: IL_0089, IL_008f, IL_0095, IL_009b
			int num = 0;
			List<InboxItemReward> result = (List<InboxItemReward>)(object)new List<T>();
			RepeatedField<InboxAttachment> repeatedField = attachments_;
			Func<InboxAttachment, bool> _003C_003E9__113_ = _003C_003Ec._003C_003E9__113_0;
			if (_003C_003E9__113_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((InboxAttachment x) => x.RewardAttachment != null);
			}
			IEnumerable<InboxAttachment> enumerable = (IEnumerable<InboxAttachment>)Enumerable.Where<InboxAttachment>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__113_);
			Func<InboxAttachment, RewardAttachment> func = default(Func<InboxAttachment, RewardAttachment>);
			if (_003C_003Ec._003C_003E9__113_1 == null)
			{
				func = (Func<InboxAttachment, RewardAttachment>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((InboxAttachment x) => x.RewardAttachment));
			}
			IEnumerable<InboxAttachment> enumerable2 = (IEnumerable<InboxAttachment>)Enumerable.Select<InboxAttachment, RewardAttachment>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			if (enumerable2 != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num != (int)num2)
					{
						num++;
					}
				}
				num += 312;
			}
			if (enumerable2 != null)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x27B7A90", Offset = "0x27B6490", VA = "0x1827B7A90")]
		public void JustRead()
		{
			//IL_0009: Expected I4, but got I8
			status_ = InboxMessageStatus.Read;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x27B7A80", Offset = "0x27B6480", VA = "0x1827B7A80")]
		public void JustClaimed()
		{
			//IL_0009: Expected I4, but got I8
			status_ = InboxMessageStatus.Claimed;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x27B7A80", Offset = "0x27B6480", VA = "0x1827B7A80")]
		public void SyncClaimedOnline()
		{
			//IL_0009: Expected I4, but got I8
			status_ = InboxMessageStatus.Claimed;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x27B8B20", Offset = "0x27B7520", VA = "0x1827B8B20")]
		static InboxMessage()
		{
			MessageParser<InboxAttachment> parser = InboxAttachment._parser;
			uint num = default(uint);
			_parser = (MessageParser<InboxMessage>)(object)FieldCodec.ForMessage<InboxAttachment>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
