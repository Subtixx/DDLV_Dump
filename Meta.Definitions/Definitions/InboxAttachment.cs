using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class InboxAttachment : IMessage<InboxAttachment>, IMessage, IEquatable<InboxAttachment>, IDeepCloneable<InboxAttachment>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		public enum AttachmentOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			RewardAttachment,
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			PromotionalAttachment,
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			GameCommunicationAttachment,
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			CustomerCareAttachment
		}

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private static readonly MessageParser<InboxAttachment> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public const int RewardAttachmentFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public const int PromotionalAttachmentFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public const int GameCommunicationAttachmentFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public const int CustomerCareAttachmentFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private object attachment_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private AttachmentOneofCase attachmentCase_;

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		[DebuggerNonUserCode]
		public static MessageParser<InboxAttachment> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000A08")]
			[Cpp2IlInjected.Address(RVA = "0x27B4970", Offset = "0x27B3370", VA = "0x1827B4970")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A09")]
			[Cpp2IlInjected.Address(RVA = "0x27B4840", Offset = "0x27B3240", VA = "0x1827B4840")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0A")]
			[Cpp2IlInjected.Address(RVA = "0x27B4A90", Offset = "0x27B3490", VA = "0x1827B4A90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		[DebuggerNonUserCode]
		public RewardAttachment RewardAttachment
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x27B4A30", Offset = "0x27B3430", VA = "0x1827B4A30")]
			get
			{
				int num = 0;
				if (attachmentCase_ == AttachmentOneofCase.RewardAttachment)
				{
					object obj = attachment_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				attachment_ = value;
				bool flag = (byte)(attachmentCase_ = ((value != null) ? AttachmentOneofCase.RewardAttachment : AttachmentOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		[DebuggerNonUserCode]
		public PromotionalAttachment PromotionalAttachment
		{
			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x27B49D0", Offset = "0x27B33D0", VA = "0x1827B49D0")]
			get
			{
				int num = 0;
				if (attachmentCase_ == AttachmentOneofCase.PromotionalAttachment)
				{
					object obj = attachment_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				attachment_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		[DebuggerNonUserCode]
		public GameCommunicationAttachment GameCommunicationAttachment
		{
			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x27B4910", Offset = "0x27B3310", VA = "0x1827B4910")]
			get
			{
				int num = 0;
				if (attachmentCase_ == AttachmentOneofCase.GameCommunicationAttachment)
				{
					object obj = attachment_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				attachment_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		[DebuggerNonUserCode]
		public CustomerCareAttachment CustomerCareAttachment
		{
			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x27B47E0", Offset = "0x27B31E0", VA = "0x1827B47E0")]
			get
			{
				int num = 0;
				if (attachmentCase_ == AttachmentOneofCase.CustomerCareAttachment)
				{
					object obj = attachment_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				attachment_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		[DebuggerNonUserCode]
		public AttachmentOneofCase AttachmentCase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return attachmentCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public InboxAttachment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x27B4670", Offset = "0x27B3070", VA = "0x1827B4670")]
		[DebuggerNonUserCode]
		public InboxAttachment(InboxAttachment other)
		{
			//IL_0037: Expected I4, but got O
			//IL_0051: Expected I4, but got O
			//IL_006b: Expected I4, but got O
			AttachmentOneofCase attachmentOneofCase = other.attachmentCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (attachmentOneofCase != AttachmentOneofCase.RewardAttachment)
						{
							goto IL_0092;
						}
						attachmentCase_ = (AttachmentOneofCase)(attachment_ = other.CustomerCareAttachment.Clone());
					}
					attachmentCase_ = (AttachmentOneofCase)(attachment_ = other.GameCommunicationAttachment.Clone());
				}
				attachmentCase_ = (AttachmentOneofCase)(attachment_ = other.PromotionalAttachment.Clone());
			}
			bool flag = (byte)(attachmentCase_ = (((attachment_ = other.RewardAttachment.Clone()) != null) ? AttachmentOneofCase.RewardAttachment : AttachmentOneofCase.None)) != 0;
			goto IL_0092;
			IL_0092:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x27B33F0", Offset = "0x27B1DF0", VA = "0x1827B33F0", Slot = "10")]
		[DebuggerNonUserCode]
		public InboxAttachment Clone()
		{
			//Discarded unreachable code: IL_00ac
			//IL_0037: Expected I4, but got O
			//IL_0051: Expected I4, but got O
			//IL_006e: Expected I4, but got O
			InboxAttachment inboxAttachment = new InboxAttachment();
			AttachmentOneofCase attachmentOneofCase = attachmentCase_;
			if (this != null)
			{
				if (this != null)
				{
					if (this != null)
					{
						if (attachmentOneofCase != AttachmentOneofCase.RewardAttachment)
						{
							goto IL_0095;
						}
						inboxAttachment.attachmentCase_ = (AttachmentOneofCase)(inboxAttachment.attachment_ = CustomerCareAttachment.Clone());
					}
					inboxAttachment.attachmentCase_ = (AttachmentOneofCase)(inboxAttachment.attachment_ = GameCommunicationAttachment.Clone());
				}
				inboxAttachment.attachmentCase_ = (AttachmentOneofCase)(inboxAttachment.attachment_ = PromotionalAttachment.Clone());
			}
			bool flag = (byte)(inboxAttachment.attachmentCase_ = (((inboxAttachment.attachment_ = RewardAttachment.Clone()) != null) ? AttachmentOneofCase.RewardAttachment : AttachmentOneofCase.None)) != 0;
			goto IL_0095;
			IL_0095:
			UnknownFieldSet unknownFieldSet = (inboxAttachment._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return inboxAttachment;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearAttachment()
		{
			//IL_0010: Expected O, but got I4
			attachment_ = (attachmentCase_ = AttachmentOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x27B3590", Offset = "0x27B1F90", VA = "0x1827B3590", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((InboxAttachment)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x27B35F0", Offset = "0x27B1FF0", VA = "0x1827B35F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(InboxAttachment other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (attachmentCase_ == AttachmentOneofCase.RewardAttachment)
				{
					object obj = attachment_;
					if (obj != null && obj == null)
					{
						goto IL_00d7;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.attachmentCase_ == AttachmentOneofCase.RewardAttachment)
				{
					obj2 = other.attachment_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					PromotionalAttachment promotionalAttachment = PromotionalAttachment;
					PromotionalAttachment promotionalAttachment2 = other.PromotionalAttachment;
					if (object.Equals(promotionalAttachment, promotionalAttachment2))
					{
						GameCommunicationAttachment gameCommunicationAttachment = GameCommunicationAttachment;
						GameCommunicationAttachment gameCommunicationAttachment2 = other.GameCommunicationAttachment;
						if (object.Equals(gameCommunicationAttachment, gameCommunicationAttachment2))
						{
							CustomerCareAttachment customerCareAttachment = CustomerCareAttachment;
							CustomerCareAttachment customerCareAttachment2 = other.CustomerCareAttachment;
							if (object.Equals(customerCareAttachment, customerCareAttachment2))
							{
								AttachmentOneofCase attachmentOneofCase = other.attachmentCase_;
								if (attachmentCase_ == attachmentOneofCase)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									bool flag = object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00d7;
			IL_00d7:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x27B3840", Offset = "0x27B2240", VA = "0x1827B3840", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0092
			while (true)
			{
				AttachmentOneofCase attachmentOneofCase = attachmentCase_;
				int num = 0;
				if (attachmentOneofCase == AttachmentOneofCase.RewardAttachment)
				{
					object obj = attachment_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (attachmentOneofCase != AttachmentOneofCase.PromotionalAttachment)
				{
					continue;
				}
				object obj2 = attachment_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (attachmentCase_ != AttachmentOneofCase.GameCommunicationAttachment)
					{
						continue;
					}
					object obj3 = attachment_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (attachmentCase_ == AttachmentOneofCase.CustomerCareAttachment)
						{
							object obj4 = attachment_;
							if (obj4 == null)
							{
								break;
							}
							int hashCode4 = obj4.GetHashCode();
						}
						UnknownFieldSet unknownFields = _unknownFields;
						if (unknownFields != null)
						{
							int hashCode5 = unknownFields.GetHashCode();
						}
						return 1;
					}
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x27B42F0", Offset = "0x27B2CF0", VA = "0x1827B42F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x27B4350", Offset = "0x27B2D50", VA = "0x1827B4350", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ac
			//IL_002f: Expected O, but got I4
			while (true)
			{
				AttachmentOneofCase attachmentOneofCase = attachmentCase_;
				int num = 0;
				if (attachmentOneofCase == AttachmentOneofCase.RewardAttachment)
				{
					if (attachmentCase_ == AttachmentOneofCase.RewardAttachment)
					{
						object obj = attachment_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (attachmentOneofCase != AttachmentOneofCase.PromotionalAttachment)
				{
					continue;
				}
				if (attachmentCase_ == AttachmentOneofCase.PromotionalAttachment)
				{
					object obj2 = attachment_;
					if (obj2 != null && obj2 == null)
					{
						break;
					}
				}
				if (attachmentCase_ != AttachmentOneofCase.GameCommunicationAttachment)
				{
					continue;
				}
				if (attachmentCase_ == AttachmentOneofCase.GameCommunicationAttachment)
				{
					object obj3 = attachment_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (attachmentCase_ == AttachmentOneofCase.CustomerCareAttachment && attachmentCase_ == AttachmentOneofCase.CustomerCareAttachment)
				{
					object obj4 = attachment_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x27B30F0", Offset = "0x27B1AF0", VA = "0x1827B30F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (attachmentCase_ == AttachmentOneofCase.RewardAttachment)
			{
				if (attachmentCase_ == AttachmentOneofCase.RewardAttachment)
				{
					object obj = attachment_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (attachmentCase_ == AttachmentOneofCase.PromotionalAttachment)
			{
				if (attachmentCase_ != AttachmentOneofCase.PromotionalAttachment)
				{
				}
				object obj2 = attachment_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (attachmentCase_ == AttachmentOneofCase.GameCommunicationAttachment)
			{
				if (attachmentCase_ != AttachmentOneofCase.GameCommunicationAttachment)
				{
				}
				object obj3 = attachment_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (attachmentCase_ == AttachmentOneofCase.CustomerCareAttachment)
			{
				if (attachmentCase_ == AttachmentOneofCase.CustomerCareAttachment)
				{
					object obj4 = attachment_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x27B3B00", Offset = "0x27B2500", VA = "0x1827B3B00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(InboxAttachment other)
		{
			//Discarded unreachable code: IL_012b
			//IL_0041: Expected I4, but got O
			//IL_0076: Expected I4, but got O
			//IL_00af: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			AttachmentOneofCase attachmentOneofCase = other.attachmentCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (attachmentOneofCase != AttachmentOneofCase.RewardAttachment)
						{
							goto IL_010b;
						}
						if (CustomerCareAttachment == null)
						{
							attachmentCase_ = (AttachmentOneofCase)(attachment_ = new CustomerCareAttachment());
						}
						CustomerCareAttachment customerCareAttachment = CustomerCareAttachment;
						CustomerCareAttachment customerCareAttachment2 = other.CustomerCareAttachment;
						customerCareAttachment.MergeFrom(customerCareAttachment2);
					}
					if (GameCommunicationAttachment == null)
					{
						attachmentCase_ = (AttachmentOneofCase)(attachment_ = new GameCommunicationAttachment());
					}
					GameCommunicationAttachment gameCommunicationAttachment = GameCommunicationAttachment;
					GameCommunicationAttachment gameCommunicationAttachment2 = other.GameCommunicationAttachment;
					gameCommunicationAttachment.MergeFrom(gameCommunicationAttachment2);
				}
				if (PromotionalAttachment == null)
				{
					attachmentCase_ = (AttachmentOneofCase)(attachment_ = new PromotionalAttachment());
				}
				PromotionalAttachment promotionalAttachment = PromotionalAttachment;
				PromotionalAttachment promotionalAttachment2 = other.PromotionalAttachment;
				promotionalAttachment.MergeFrom(promotionalAttachment2);
			}
			if (RewardAttachment == null)
			{
				bool flag = (byte)(attachmentCase_ = (((attachment_ = new RewardAttachment()) != null) ? AttachmentOneofCase.RewardAttachment : AttachmentOneofCase.None)) != 0;
			}
			RewardAttachment rewardAttachment = RewardAttachment;
			RewardAttachment rewardAttachment2 = other.RewardAttachment;
			rewardAttachment.MergeFrom(rewardAttachment2);
			goto IL_010b;
			IL_010b:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x27B3D80", Offset = "0x27B2780", VA = "0x1827B3D80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00ac: Expected I4, but got O
			//IL_014d: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					GameCommunicationAttachment gameCommunicationAttachment = new GameCommunicationAttachment();
					if (attachmentCase_ == AttachmentOneofCase.GameCommunicationAttachment)
					{
						if (attachmentCase_ != AttachmentOneofCase.GameCommunicationAttachment)
						{
						}
						object obj = attachment_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(gameCommunicationAttachment);
					attachment_ = gameCommunicationAttachment;
					attachmentCase_ = (AttachmentOneofCase)gameCommunicationAttachment;
				}
				if (num != 34)
				{
					goto IL_014d;
				}
				CustomerCareAttachment builder = new CustomerCareAttachment();
				if (attachmentCase_ == AttachmentOneofCase.CustomerCareAttachment)
				{
					if (attachmentCase_ != AttachmentOneofCase.CustomerCareAttachment)
					{
					}
					object obj2 = attachment_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				attachment_ = builder;
				attachmentCase_ = (AttachmentOneofCase)typeof(CustomerCareAttachment).TypeHandle;
			}
			bool flag = default(bool);
			if (num == 10)
			{
				RewardAttachment rewardAttachment = new RewardAttachment();
				if (attachmentCase_ == AttachmentOneofCase.RewardAttachment)
				{
					if (attachmentCase_ != AttachmentOneofCase.RewardAttachment)
					{
					}
					object obj3 = attachment_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(rewardAttachment);
				attachment_ = rewardAttachment;
				flag = (byte)(attachmentCase_ = ((rewardAttachment != null) ? AttachmentOneofCase.RewardAttachment : AttachmentOneofCase.None)) != 0;
			}
			if (flag)
			{
				PromotionalAttachment builder2 = new PromotionalAttachment();
				if (attachmentCase_ == AttachmentOneofCase.PromotionalAttachment)
				{
					if (attachmentCase_ != AttachmentOneofCase.PromotionalAttachment)
					{
					}
					object obj4 = attachment_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				attachment_ = builder2;
				attachmentCase_ = (AttachmentOneofCase)typeof(PromotionalAttachment).TypeHandle;
			}
			goto IL_014d;
			IL_014d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x27B3780", Offset = "0x27B2180", VA = "0x1827B3780", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				CustomerCareAttachment customerCareAttachment = CustomerCareAttachment;
				GameCommunicationAttachment gameCommunicationAttachment = GameCommunicationAttachment;
				PromotionalAttachment promotionalAttachment = PromotionalAttachment;
				RewardAttachment rewardAttachment = RewardAttachment;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x27B4120", Offset = "0x27B2B20", VA = "0x1827B4120", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_002b: Expected O, but got I4
			//IL_0036: Expected I4, but got O
			//IL_0051: Expected I4, but got O
			//IL_006c: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							attachment_ = num2;
							attachmentCase_ = (AttachmentOneofCase)typeof(RewardAttachment).TypeHandle;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
						if (value == null || value != null)
						{
							attachment_ = value;
							attachmentCase_ = (AttachmentOneofCase)typeof(RewardAttachment).TypeHandle;
							break;
						}
						throw new InvalidCastException();
					}
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					attachment_ = value;
					attachmentCase_ = (AttachmentOneofCase)typeof(RewardAttachment).TypeHandle;
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				attachment_ = value;
				bool flag = (byte)(attachmentCase_ = ((value != null) ? AttachmentOneofCase.RewardAttachment : AttachmentOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x27B3340", Offset = "0x27B1D40", VA = "0x1827B3340", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				attachment_ = num;
				attachmentCase_ = (AttachmentOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x27B3A50", Offset = "0x27B2450", VA = "0x1827B3A50", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Attachment"))
			{
				AttachmentOneofCase attachmentOneofCase = attachmentCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x27B3380", Offset = "0x27B1D80", VA = "0x1827B3380", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Attachment"))
			{
				attachment_ = (attachmentCase_ = AttachmentOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x27B4560", Offset = "0x27B2F60", VA = "0x1827B4560")]
		static InboxAttachment()
		{
			Func<InboxAttachment> func = default(Func<InboxAttachment>);
			_parser = (MessageParser<InboxAttachment>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
