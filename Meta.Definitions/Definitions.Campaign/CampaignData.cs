using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Campaign
{
	[Cpp2IlInjected.Token(Token = "0x200025E")]
	public sealed class CampaignData : IMessage<CampaignData>, IMessage, IEquatable<CampaignData>, IDeepCloneable<CampaignData>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200025F")]
		public enum CampaignTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000977")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000978")]
			MegaEvent = 5,
			[Cpp2IlInjected.Token(Token = "0x4000979")]
			MiniEvent = 6,
			[Cpp2IlInjected.Token(Token = "0x400097A")]
			MicroEvent = 7,
			[Cpp2IlInjected.Token(Token = "0x400097B")]
			PhonePromptEvent = 8
		}

		[Cpp2IlInjected.Token(Token = "0x4000967")]
		private static readonly MessageParser<CampaignData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000968")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000969")]
		public const int MetadataFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400096A")]
		private LiveopsMetadata metadata_;

		[Cpp2IlInjected.Token(Token = "0x400096B")]
		public const int ConditionsFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400096C")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x400096D")]
		public const int CanReenterFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400096E")]
		private bool canReenter_;

		[Cpp2IlInjected.Token(Token = "0x400096F")]
		public const int MegaEventFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4000970")]
		public const int MiniEventFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4000971")]
		public const int MicroEventFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4000972")]
		public const int PhonePromptEventFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000973")]
		private object campaignType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000974")]
		private CampaignTypeOneofCase campaignTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x170004F9")]
		[DebuggerNonUserCode]
		public static MessageParser<CampaignData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001671")]
			[Cpp2IlInjected.Address(RVA = "0x32F2D80", Offset = "0x32F1780", VA = "0x1832F2D80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001672")]
			[Cpp2IlInjected.Address(RVA = "0x32F2B30", Offset = "0x32F1530", VA = "0x1832F2B30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001673")]
			[Cpp2IlInjected.Address(RVA = "0x32F2E40", Offset = "0x32F1840", VA = "0x1832F2E40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FC")]
		[DebuggerNonUserCode]
		public LiveopsMetadata Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x6001677")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return metadata_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001678")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				metadata_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FD")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6001679")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x600167A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FE")]
		[DebuggerNonUserCode]
		public bool CanReenter
		{
			[Cpp2IlInjected.Token(Token = "0x600167B")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return canReenter_;
			}
			[Cpp2IlInjected.Token(Token = "0x600167C")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				canReenter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FF")]
		[DebuggerNonUserCode]
		public CampaignMegaEvent MegaEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600167D")]
			[Cpp2IlInjected.Address(RVA = "0x32F2C60", Offset = "0x32F1660", VA = "0x1832F2C60")]
			get
			{
				int num = 0;
				if (campaignTypeCase_ == CampaignTypeOneofCase.MegaEvent)
				{
					object obj = campaignType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600167E")]
			[Cpp2IlInjected.Address(RVA = "0x18AA410", Offset = "0x18A8E10", VA = "0x1818AA410")]
			set
			{
				campaignType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000500")]
		[DebuggerNonUserCode]
		public CampaignMiniEvent MiniEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600167F")]
			[Cpp2IlInjected.Address(RVA = "0x32F2D20", Offset = "0x32F1720", VA = "0x1832F2D20")]
			get
			{
				int num = 0;
				if (campaignTypeCase_ == CampaignTypeOneofCase.MiniEvent)
				{
					object obj = campaignType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001680")]
			[Cpp2IlInjected.Address(RVA = "0x26F6C00", Offset = "0x26F5600", VA = "0x1826F6C00")]
			set
			{
				campaignType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000501")]
		[DebuggerNonUserCode]
		public CampaignMicroEvent MicroEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001681")]
			[Cpp2IlInjected.Address(RVA = "0x32F2CC0", Offset = "0x32F16C0", VA = "0x1832F2CC0")]
			get
			{
				int num = 0;
				if (campaignTypeCase_ == CampaignTypeOneofCase.MicroEvent)
				{
					object obj = campaignType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001682")]
			[Cpp2IlInjected.Address(RVA = "0x32F2F50", Offset = "0x32F1950", VA = "0x1832F2F50")]
			set
			{
				campaignType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000502")]
		[DebuggerNonUserCode]
		public CampaignPhonePromptEvent PhonePromptEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001683")]
			[Cpp2IlInjected.Address(RVA = "0x32F2DE0", Offset = "0x32F17E0", VA = "0x1832F2DE0")]
			get
			{
				int num = 0;
				if (campaignTypeCase_ == CampaignTypeOneofCase.PhonePromptEvent)
				{
					object obj = campaignType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001684")]
			[Cpp2IlInjected.Address(RVA = "0x32F2F90", Offset = "0x32F1990", VA = "0x1832F2F90")]
			set
			{
				campaignType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000503")]
		[DebuggerNonUserCode]
		public CampaignTypeOneofCase CampaignTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001685")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return campaignTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000504")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001694")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001695")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000505")]
		public ICampaignType ICampaignType
		{
			[Cpp2IlInjected.Token(Token = "0x6001697")]
			[Cpp2IlInjected.Address(RVA = "0x32F2C00", Offset = "0x32F1600", VA = "0x1832F2C00")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000506")]
		public ConditionListener Listeners
		{
			[Cpp2IlInjected.Token(Token = "0x600169B")]
			[Cpp2IlInjected.Address(RVA = "0x32F2C40", Offset = "0x32F1640", VA = "0x1832F2C40")]
			get
			{
				//Discarded unreachable code: IL_000c
				return conditions_.Listener;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001674")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CampaignData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001675")]
		[Cpp2IlInjected.Address(RVA = "0x32F28D0", Offset = "0x32F12D0", VA = "0x1832F28D0")]
		[DebuggerNonUserCode]
		public CampaignData(CampaignData other)
		{
			//IL_0021: Expected O, but got I4
			//IL_0085: Expected I4, but got O
			//IL_00a2: Expected I4, but got O
			//IL_00bf: Expected I4, but got O
			//IL_0114: Expected I4, but got I8
			LiveopsMetadata liveopsMetadata = other.metadata_;
			int num = 0;
			if (liveopsMetadata != null)
			{
				LiveopsMetadata liveopsMetadata2 = liveopsMetadata.Clone();
			}
			metadata_ = (LiveopsMetadata)num;
			ConditionsList conditionsList = other.conditions_;
			ConditionsList conditionsList2 = default(ConditionsList);
			if (conditionsList != null)
			{
				conditionsList2 = conditionsList.Clone();
			}
			conditions_ = conditionsList2;
			bool flag = (canReenter_ = other.canReenter_);
			CampaignTypeOneofCase campaignTypeOneofCase = other.campaignTypeCase_;
			if (conditionsList != null)
			{
				if (conditionsList != null)
				{
					if (conditionsList != null)
					{
						if (campaignTypeOneofCase != (CampaignTypeOneofCase)1)
						{
							goto IL_0114;
						}
						campaignTypeCase_ = (CampaignTypeOneofCase)(campaignType_ = other.PhonePromptEvent.Clone());
					}
					campaignTypeCase_ = (CampaignTypeOneofCase)(campaignType_ = other.MicroEvent.Clone());
				}
				campaignTypeCase_ = (CampaignTypeOneofCase)(campaignType_ = other.MiniEvent.Clone());
			}
			CampaignMegaEvent megaEvent = other.MegaEvent;
			CampaignMegaEvent campaignMegaEvent = new CampaignMegaEvent
			{
				name_ = ""
			};
			string text = (campaignMegaEvent.name_ = megaEvent.name_);
			UnknownFieldSet unknownFieldSet = (campaignMegaEvent._unknownFields = UnknownFieldSet.Clone(megaEvent._unknownFields));
			campaignType_ = campaignMegaEvent;
			campaignTypeCase_ = CampaignTypeOneofCase.MegaEvent;
			goto IL_0114;
			IL_0114:
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001676")]
		[Cpp2IlInjected.Address(RVA = "0x32F0710", Offset = "0x32EF110", VA = "0x1832F0710", Slot = "10")]
		[DebuggerNonUserCode]
		public CampaignData Clone()
		{
			return new CampaignData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001686")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
		[DebuggerNonUserCode]
		public void ClearCampaignType()
		{
			//IL_0010: Expected O, but got I4
			campaignType_ = (campaignTypeCase_ = CampaignTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001687")]
		[Cpp2IlInjected.Address(RVA = "0x32F0E80", Offset = "0x32EF880", VA = "0x1832F0E80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(metadata_, other))
				{
					bool flag = object.Equals(conditions_, other);
					CampaignMegaEvent objB = default(CampaignMegaEvent);
					CampaignMiniEvent objB2 = default(CampaignMiniEvent);
					CampaignMicroEvent objB3 = default(CampaignMicroEvent);
					if (flag && canReenter_ == flag && object.Equals(MegaEvent, objB) && object.Equals(MiniEvent, objB2) && object.Equals(MicroEvent, objB3))
					{
						CampaignPhonePromptEvent objB4 = default(CampaignPhonePromptEvent);
						bool flag2 = object.Equals(PhonePromptEvent, objB4);
						if (flag2 && campaignTypeCase_ == (flag2 ? ((CampaignTypeOneofCase)1) : CampaignTypeOneofCase.None))
						{
							return object.Equals(_unknownFields, objB4);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001688")]
		[Cpp2IlInjected.Address(RVA = "0x32F1010", Offset = "0x32EFA10", VA = "0x1832F1010", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CampaignData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				LiveopsMetadata objB = other.metadata_;
				if (object.Equals(metadata_, objB))
				{
					ConditionsList objB2 = other.conditions_;
					if (object.Equals(conditions_, objB2))
					{
						bool flag = other.canReenter_;
						if (canReenter_ == flag)
						{
							CampaignMegaEvent megaEvent = MegaEvent;
							CampaignMegaEvent megaEvent2 = other.MegaEvent;
							if (object.Equals(megaEvent, megaEvent2))
							{
								CampaignMiniEvent miniEvent = MiniEvent;
								CampaignMiniEvent miniEvent2 = other.MiniEvent;
								if (object.Equals(miniEvent, miniEvent2))
								{
									CampaignMicroEvent microEvent = MicroEvent;
									CampaignMicroEvent microEvent2 = other.MicroEvent;
									if (object.Equals(microEvent, microEvent2))
									{
										CampaignPhonePromptEvent phonePromptEvent = PhonePromptEvent;
										CampaignPhonePromptEvent phonePromptEvent2 = other.PhonePromptEvent;
										if (object.Equals(phonePromptEvent, phonePromptEvent2))
										{
											CampaignTypeOneofCase campaignTypeOneofCase = other.campaignTypeCase_;
											if (campaignTypeCase_ == campaignTypeOneofCase)
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001689")]
		[Cpp2IlInjected.Address(RVA = "0x32F12D0", Offset = "0x32EFCD0", VA = "0x1832F12D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00cf
			while (true)
			{
				LiveopsMetadata liveopsMetadata = metadata_;
				if (liveopsMetadata != null)
				{
					int hashCode = liveopsMetadata.GetHashCode();
				}
				ConditionsList conditionsList = conditions_;
				if (conditionsList != null)
				{
					int hashCode2 = conditionsList.GetHashCode();
				}
				if (canReenter_)
				{
				}
				CampaignTypeOneofCase campaignTypeOneofCase = campaignTypeCase_;
				int num = 0;
				if (campaignTypeOneofCase != CampaignTypeOneofCase.MegaEvent)
				{
					continue;
				}
				object obj = campaignType_;
				if (obj != null)
				{
					int hashCode3 = obj.GetHashCode();
					if (campaignTypeCase_ != CampaignTypeOneofCase.MiniEvent)
					{
						continue;
					}
					object obj2 = campaignType_;
					if (obj2 != null)
					{
						int hashCode4 = obj2.GetHashCode();
						if (campaignTypeCase_ != CampaignTypeOneofCase.MicroEvent)
						{
							continue;
						}
						object obj3 = campaignType_;
						if (obj3 != null)
						{
							int hashCode5 = obj3.GetHashCode();
							if (campaignTypeCase_ == CampaignTypeOneofCase.PhonePromptEvent)
							{
								object obj4 = campaignType_;
								if (obj4 == null)
								{
									break;
								}
								int hashCode6 = obj4.GetHashCode();
							}
							UnknownFieldSet unknownFields = _unknownFields;
							if (unknownFields != null)
							{
								int hashCode7 = unknownFields.GetHashCode();
							}
							return 1;
						}
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600168A")]
		[Cpp2IlInjected.Address(RVA = "0x32F24C0", Offset = "0x32F0EC0", VA = "0x1832F24C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600168B")]
		[Cpp2IlInjected.Address(RVA = "0x32F2520", Offset = "0x32F0F20", VA = "0x1832F2520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0100
			while (true)
			{
				if ((long)metadata_ != 0)
				{
					LiveopsMetadata value = metadata_;
					output.WriteMessage(value);
				}
				if ((long)conditions_ != 0)
				{
					ConditionsList value2 = conditions_;
					output.WriteMessage(value2);
				}
				if (canReenter_)
				{
					bool value3 = canReenter_;
					output.WriteBool(value3);
				}
				CampaignTypeOneofCase campaignTypeOneofCase = campaignTypeCase_;
				int num = 0;
				if (campaignTypeOneofCase != CampaignTypeOneofCase.MegaEvent)
				{
					continue;
				}
				if (campaignTypeCase_ == CampaignTypeOneofCase.MegaEvent)
				{
					object obj = campaignType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (campaignTypeCase_ != CampaignTypeOneofCase.MiniEvent)
				{
					continue;
				}
				if (campaignTypeCase_ == CampaignTypeOneofCase.MiniEvent)
				{
					object obj2 = campaignType_;
					if (obj2 != null && obj2 == null)
					{
						break;
					}
				}
				if (campaignTypeCase_ != CampaignTypeOneofCase.MicroEvent)
				{
					continue;
				}
				if (campaignTypeCase_ == CampaignTypeOneofCase.MicroEvent)
				{
					object obj3 = campaignType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (campaignTypeCase_ == CampaignTypeOneofCase.PhonePromptEvent && campaignTypeCase_ == CampaignTypeOneofCase.PhonePromptEvent)
				{
					object obj4 = campaignType_;
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

		[Cpp2IlInjected.Token(Token = "0x600168C")]
		[Cpp2IlInjected.Address(RVA = "0x32F0320", Offset = "0x32EED20", VA = "0x1832F0320", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			LiveopsMetadata liveopsMetadata = metadata_;
			int num = 0;
			if (liveopsMetadata != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(liveopsMetadata);
			}
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num3++;
				num += num3;
			}
			if (campaignTypeCase_ == CampaignTypeOneofCase.MegaEvent)
			{
				if (campaignTypeCase_ != CampaignTypeOneofCase.MegaEvent)
				{
				}
				object obj = campaignType_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (campaignTypeCase_ == CampaignTypeOneofCase.MiniEvent)
			{
				if (campaignTypeCase_ != CampaignTypeOneofCase.MiniEvent)
				{
				}
				object obj2 = campaignType_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (campaignTypeCase_ == CampaignTypeOneofCase.MicroEvent)
			{
				if (campaignTypeCase_ != CampaignTypeOneofCase.MicroEvent)
				{
				}
				object obj3 = campaignType_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (campaignTypeCase_ == CampaignTypeOneofCase.PhonePromptEvent)
			{
				if (campaignTypeCase_ == CampaignTypeOneofCase.PhonePromptEvent)
				{
					object obj4 = campaignType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600168D")]
		[Cpp2IlInjected.Address(RVA = "0x32F1620", Offset = "0x32F0020", VA = "0x1832F1620", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignData other)
		{
			//Discarded unreachable code: IL_01f3
			//IL_00d5: Expected I4, but got O
			//IL_010e: Expected I4, but got O
			//IL_0147: Expected I4, but got O
			//IL_0180: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if ((long)other.metadata_ != 0)
			{
				LiveopsMetadata liveopsMetadata = metadata_;
				if (liveopsMetadata == null)
				{
					LiveopsMetadata liveopsMetadata2 = (metadata_ = new LiveopsMetadata());
					LiveopsMetadata liveopsMetadata3 = metadata_;
				}
				LiveopsMetadata other2 = other.metadata_;
				liveopsMetadata.MergeFrom(other2);
			}
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (conditions_ == null)
				{
					ConditionsList conditionsList = (conditions_ = new ConditionsList());
					conditionsList2 = conditions_;
				}
				ConditionsList other3 = other.conditions_;
				conditionsList2.MergeFrom(other3);
			}
			bool flag = other.canReenter_;
			if (flag)
			{
				canReenter_ = flag;
			}
			CampaignTypeOneofCase campaignTypeOneofCase = other.campaignTypeCase_;
			if (flag)
			{
				if (flag)
				{
					if (flag)
					{
						if (campaignTypeOneofCase != (CampaignTypeOneofCase)1)
						{
							goto IL_01d3;
						}
						if (PhonePromptEvent == null)
						{
							campaignTypeCase_ = (CampaignTypeOneofCase)(campaignType_ = new CampaignPhonePromptEvent());
						}
						CampaignPhonePromptEvent phonePromptEvent = PhonePromptEvent;
						CampaignPhonePromptEvent phonePromptEvent2 = other.PhonePromptEvent;
						phonePromptEvent.MergeFrom(phonePromptEvent2);
					}
					if (MicroEvent == null)
					{
						campaignTypeCase_ = (CampaignTypeOneofCase)(campaignType_ = new CampaignMicroEvent());
					}
					CampaignMicroEvent microEvent = MicroEvent;
					CampaignMicroEvent microEvent2 = other.MicroEvent;
					microEvent.MergeFrom(microEvent2);
				}
				if (MiniEvent == null)
				{
					campaignTypeCase_ = (CampaignTypeOneofCase)(campaignType_ = new CampaignMiniEvent());
				}
				CampaignMiniEvent miniEvent = MiniEvent;
				CampaignMiniEvent miniEvent2 = other.MiniEvent;
				miniEvent.MergeFrom(miniEvent2);
			}
			if (MegaEvent == null)
			{
				campaignTypeCase_ = (CampaignTypeOneofCase)(campaignType_ = new CampaignMegaEvent());
			}
			CampaignMegaEvent megaEvent = MegaEvent;
			CampaignMegaEvent megaEvent2 = other.MegaEvent;
			if (megaEvent2 != null)
			{
				string name_ = megaEvent2.name_;
				if (name_.m_stringLength != 0)
				{
					megaEvent.Name = name_;
				}
				UnknownFieldSet unknownFields = megaEvent2._unknownFields;
				UnknownFieldSet unknownFieldSet = (megaEvent._unknownFields = UnknownFieldSet.MergeFrom(megaEvent._unknownFields, unknownFields));
			}
			goto IL_01d3;
			IL_01d3:
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x600168E")]
		[Cpp2IlInjected.Address(RVA = "0x32F19C0", Offset = "0x32F03C0", VA = "0x1832F19C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0066: Expected I4, but got O
			//IL_00b5: Expected I4, but got O
			//IL_0118: Expected I4, but got O
			//IL_016c: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if ((int)num > 50)
				{
					if (num == 58)
					{
						CampaignMicroEvent campaignMicroEvent = new CampaignMicroEvent();
						if (campaignTypeCase_ == CampaignTypeOneofCase.MicroEvent)
						{
							if (campaignTypeCase_ != CampaignTypeOneofCase.MicroEvent)
							{
							}
							object obj = campaignType_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(campaignMicroEvent);
						campaignType_ = campaignMicroEvent;
						campaignTypeCase_ = (CampaignTypeOneofCase)campaignMicroEvent;
					}
					if (num != 66)
					{
						goto IL_01e2;
					}
					CampaignPhonePromptEvent builder = new CampaignPhonePromptEvent();
					if (campaignTypeCase_ == CampaignTypeOneofCase.PhonePromptEvent)
					{
						if (campaignTypeCase_ != CampaignTypeOneofCase.PhonePromptEvent)
						{
						}
						object obj2 = campaignType_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					campaignType_ = builder;
					campaignTypeCase_ = (CampaignTypeOneofCase)typeof(CampaignPhonePromptEvent).TypeHandle;
				}
				UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
				if (num == 42)
				{
					CampaignMegaEvent campaignMegaEvent = new CampaignMegaEvent();
					if (campaignTypeCase_ == CampaignTypeOneofCase.MegaEvent)
					{
						if (campaignTypeCase_ != CampaignTypeOneofCase.MegaEvent)
						{
						}
						object obj3 = campaignType_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
						if (obj3 != null)
						{
							UnknownFieldSet unknownFields = campaignMegaEvent._unknownFields;
							campaignMegaEvent._unknownFields = unknownFieldSet;
						}
					}
					input.ReadMessage(campaignMegaEvent);
					campaignType_ = campaignMegaEvent;
					campaignTypeCase_ = (CampaignTypeOneofCase)unknownFieldSet;
				}
				if ((long)unknownFieldSet != 50)
				{
					goto IL_01e2;
				}
				CampaignMiniEvent builder2 = new CampaignMiniEvent();
				if (campaignTypeCase_ == CampaignTypeOneofCase.MiniEvent)
				{
					if (campaignTypeCase_ != CampaignTypeOneofCase.MiniEvent)
					{
					}
					object obj4 = campaignType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				campaignType_ = builder2;
				campaignTypeCase_ = (CampaignTypeOneofCase)typeof(CampaignMiniEvent).TypeHandle;
			}
			LiveopsMetadata liveopsMetadata = default(LiveopsMetadata);
			if (num == 10)
			{
				LiveopsMetadata builder3 = default(LiveopsMetadata);
				if (metadata_ == null)
				{
					liveopsMetadata = (metadata_ = new LiveopsMetadata());
					builder3 = metadata_;
				}
				input.ReadMessage(builder3);
			}
			ConditionsList conditionsList = default(ConditionsList);
			if ((long)liveopsMetadata == 18)
			{
				ConditionsList builder4 = default(ConditionsList);
				if (conditions_ == null)
				{
					conditionsList = (conditions_ = new ConditionsList());
					builder4 = conditions_;
				}
				input.ReadMessage(builder4);
			}
			if ((long)conditionsList == 24)
			{
				bool flag = (canReenter_ = input.ReadBool());
			}
			goto IL_01e2;
			IL_01e2:
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600168F")]
		[Cpp2IlInjected.Address(RVA = "0x32F1170", Offset = "0x32EFB70", VA = "0x1832F1170", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				LiveopsMetadata liveopsMetadata = metadata_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001690")]
		[Cpp2IlInjected.Address(RVA = "0x32F20D0", Offset = "0x32F0AD0", VA = "0x1832F20D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0027, IL_002b, IL_0030, IL_0034, IL_0038, IL_0039, IL_003d, IL_0041, IL_0042, IL_0046, IL_004a, IL_004b, IL_005d, IL_0063, IL_0069
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				metadata_ = (LiveopsMetadata)num;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				metadata_ = (LiveopsMetadata)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001691")]
		[Cpp2IlInjected.Address(RVA = "0x32F05F0", Offset = "0x32EEFF0", VA = "0x1832F05F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_001e
			//IL_000d: Expected O, but got I4
			//IL_0016: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			if (fieldNumber <= 7)
			{
				int num = 0;
				metadata_ = (LiveopsMetadata)num;
				int num2 = 0;
				conditions_ = (ConditionsList)num2;
				canReenter_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001692")]
		[Cpp2IlInjected.Address(RVA = "0x32F1530", Offset = "0x32EFF30", VA = "0x1832F1530", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "CampaignType"))
			{
				CampaignTypeOneofCase campaignTypeOneofCase = campaignTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001693")]
		[Cpp2IlInjected.Address(RVA = "0x32F06A0", Offset = "0x32EF0A0", VA = "0x1832F06A0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "CampaignType"))
			{
				campaignType_ = (campaignTypeCase_ = CampaignTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001696")]
		[Cpp2IlInjected.Address(RVA = "0x32F15E0", Offset = "0x32EFFE0", VA = "0x1832F15E0")]
		public bool Init(string name)
		{
			Name = name;
			ConditionsList conditionsList = conditions_;
			if (conditionsList == null)
			{
				int num = 0;
			}
			return !conditionsList.IsEmpty;
		}

		[Cpp2IlInjected.Token(Token = "0x6001698")]
		[Cpp2IlInjected.Address(RVA = "0x32F23B0", Offset = "0x32F0DB0", VA = "0x1832F23B0")]
		public DateTime StartDate(IProfile profile, ITransactionContext context)
		{
			ConditionsList conditionsList = conditions_;
			bool flag = default(bool);
			if (!flag)
			{
				return DateTime.MinValue;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001699")]
		[Cpp2IlInjected.Address(RVA = "0x32F0D70", Offset = "0x32EF770", VA = "0x1832F0D70")]
		public DateTime EndDate(IProfile profile, ITransactionContext context)
		{
			ConditionsList conditionsList = conditions_;
			bool flag = default(bool);
			if (!flag)
			{
				return DateTime.MaxValue;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600169A")]
		[Cpp2IlInjected.Address(RVA = "0x32F1E80", Offset = "0x32F0880", VA = "0x1832F1E80")]
		public DateTime NextEvaluateDateTime(IProfile profile, ITransactionContext context)
		{
			ConditionsList conditionsList = conditions_;
			int num = 0;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag || flag2)
			{
			}
			ConditionsList conditionsList2 = conditions_;
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			if (!flag3 || flag4)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600169C")]
		[Cpp2IlInjected.Address(RVA = "0x32F0770", Offset = "0x32EF170", VA = "0x1832F0770", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_008f, IL_009c, IL_00a1, IL_00ae, IL_00b3, IL_00c4, IL_00c9, IL_00da, IL_00f3, IL_00f9, IL_00ff
			//IL_00eb: Expected O, but got I4
			int num = 0;
			ConditionsList conditionsList = conditions_;
			IEnumerable<ICondition> allConditions;
			if (conditionsList != null && !conditionsList.IsEmpty)
			{
				allConditions = (IEnumerable<ICondition>)conditions_.GetAllConditions();
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (allConditions != null)
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_005f;
						}
						num++;
					}
					while (num == 0)
					{
					}
					if (num != 0)
					{
						context.AddError("Conditions must use UTC time");
						num += 312;
						goto IL_005f;
					}
					goto IL_0067;
				}
				goto IL_006b;
			}
			goto IL_006f;
			IL_006b:
			if (allConditions == null)
			{
			}
			goto IL_006f;
			IL_005f:
			num += 312;
			goto IL_0067;
			IL_006f:
			context.AddError("Conditions is empty");
			if (campaignTypeCase_ <= CampaignTypeOneofCase.PhonePromptEvent)
			{
				context.AddError("CampaignType is not set");
				return;
			}
			bool flag = default(bool);
			string text = $"CampaignType \"{flag}\" has no validation code yet";
			throw new NullReferenceException();
			IL_0067:
			while (num == 0)
			{
			}
			goto IL_006b;
		}

		[Cpp2IlInjected.Token(Token = "0x600169D")]
		[Cpp2IlInjected.Address(RVA = "0x32F27C0", Offset = "0x32F11C0", VA = "0x1832F27C0")]
		static CampaignData()
		{
			Func<CampaignData> func = default(Func<CampaignData>);
			_parser = (MessageParser<CampaignData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
