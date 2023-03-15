using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class OnlineMessageData : IMessage<OnlineMessageData>, IMessage, IEquatable<OnlineMessageData>, IDeepCloneable<OnlineMessageData>, IMessageFieldAccessor, IDataValidation, IFetchable, ITimeLimited
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000B7")]
			public sealed class RewardContent : IMessage<RewardContent>, IMessage, IEquatable<RewardContent>, IDeepCloneable<RewardContent>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				private static readonly MessageParser<RewardContent> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400037B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400037C")]
				public const int ItemIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				private int itemId_;

				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public const int QuantityFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400037F")]
				private int quantity_;

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				[DebuggerNonUserCode]
				public static MessageParser<RewardContent> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000804")]
					[Cpp2IlInjected.Address(RVA = "0x2FF23F0", Offset = "0x2FF0DF0", VA = "0x182FF23F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000805")]
					[Cpp2IlInjected.Address(RVA = "0x2FF2370", Offset = "0x2FF0D70", VA = "0x182FF2370")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000806")]
					[Cpp2IlInjected.Address(RVA = "0x2FF24B0", Offset = "0x2FF0EB0", VA = "0x182FF24B0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				[DebuggerNonUserCode]
				public int ItemId
				{
					[Cpp2IlInjected.Token(Token = "0x600080A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600080B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				[DebuggerNonUserCode]
				public int Quantity
				{
					[Cpp2IlInjected.Token(Token = "0x600080C")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600080D")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000807")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public RewardContent()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000808")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public RewardContent(RewardContent other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000809")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1B60", Offset = "0x2FF0560", VA = "0x182FF1B60", Slot = "10")]
				[DebuggerNonUserCode]
				public RewardContent Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600080E")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1BF0", Offset = "0x2FF05F0", VA = "0x182FF1BF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600080F")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(RewardContent other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000810")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000811")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2070", Offset = "0x2FF0A70", VA = "0x182FF2070", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000812")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000813")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1A00", Offset = "0x2FF0400", VA = "0x182FF1A00", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000814")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(RewardContent other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000815")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000816")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1DD0", Offset = "0x2FF07D0", VA = "0x182FF1DD0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000817")]
				[Cpp2IlInjected.Address(RVA = "0x2FF1F50", Offset = "0x2FF0950", VA = "0x182FF1F50", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000818")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private static readonly MessageParser<OnlineMessageData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public const int VersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public const int MinGameVersionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private string minGameVersion_;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public const int ActiveFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private bool active_;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public const int TitleFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private string title_;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public const int DescriptionFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private string description_;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public const int IconAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public const int RewardsFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly FieldCodec<Types.RewardContent> _repeated_rewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private readonly RepeatedField<Types.RewardContent> rewards_;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public const int StartDateFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private ConditionDate startDate_;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public const int EndDateFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private ConditionDate endDate_;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public const int LanguageFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private string language_;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public const int TesterPlayerIdsFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private static readonly FieldCodec<string> _repeated_testerPlayerIds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private readonly RepeatedField<string> testerPlayerIds_;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public const int RealUserPlayerIdsFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private static readonly FieldCodec<string> _repeated_realUserPlayerIds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private readonly RepeatedField<string> realUserPlayerIds_;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public const int LastUpdateTimestampFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private ConditionDate lastUpdateTimestamp_;

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineMessageData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0x298EBE0", Offset = "0x298D5E0", VA = "0x18298EBE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x298EAA0", Offset = "0x298D4A0", VA = "0x18298EAA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x298EC40", Offset = "0x298D640", VA = "0x18298EC40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "16")]
			set
			{
				version_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		[DebuggerNonUserCode]
		public string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "17")]
			get
			{
				return minGameVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x298EEA0", Offset = "0x298D8A0", VA = "0x18298EEA0", Slot = "18")]
			set
			{
				string text = (minGameVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		[DebuggerNonUserCode]
		public bool Active
		{
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90", Slot = "19")]
			get
			{
				return active_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0", Slot = "20")]
			set
			{
				active_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		[DebuggerNonUserCode]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "21")]
			get
			{
				return title_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x298EF10", Offset = "0x298D910", VA = "0x18298EF10", Slot = "22")]
			set
			{
				string text = (title_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "23")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x298ED50", Offset = "0x298D750", VA = "0x18298ED50", Slot = "24")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "25")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x298EDC0", Offset = "0x298D7C0", VA = "0x18298EDC0", Slot = "26")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.RewardContent> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		[DebuggerNonUserCode]
		public ConditionDate StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "31")]
			get
			{
				return startDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				startDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		[DebuggerNonUserCode]
		public ConditionDate EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0", Slot = "32")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		[DebuggerNonUserCode]
		public string Language
		{
			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060", Slot = "27")]
			get
			{
				return language_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x298EE30", Offset = "0x298D830", VA = "0x18298EE30", Slot = "28")]
			set
			{
				string text = (language_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		[DebuggerNonUserCode]
		public RepeatedField<string> TesterPlayerIds
		{
			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return testerPlayerIds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		[DebuggerNonUserCode]
		public RepeatedField<string> RealUserPlayerIds
		{
			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return realUserPlayerIds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		[DebuggerNonUserCode]
		public ConditionDate LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640", Slot = "29")]
			get
			{
				return lastUpdateTimestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60", Slot = "30")]
			set
			{
				lastUpdateTimestamp_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public bool IsTargetedForUsers
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x298EB70", Offset = "0x298D570", VA = "0x18298EB70")]
			get
			{
				//Discarded unreachable code: IL_001f
				if (((RepeatedField<T>)(object)testerPlayerIds_).Count > 0)
				{
					return true;
				}
				return ((RepeatedField<T>)(object)realUserPlayerIds_).Count > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x298E870", Offset = "0x298D270", VA = "0x18298E870")]
		[DebuggerNonUserCode]
		public OnlineMessageData()
		{
			//IL_0091: Expected I4, but got I8
			minGameVersion_ = "";
			title_ = "";
			description_ = "";
			iconAddress_ = "";
			rewards_ = (RepeatedField<Types.RewardContent>)(object)new RepeatedField<T>();
			language_ = "";
			testerPlayerIds_ = (RepeatedField<string>)(object)new RepeatedField<T>();
			realUserPlayerIds_ = (RepeatedField<string>)(object)new RepeatedField<T>();
			base._002Ector();
			ConditionDate conditionDate = new ConditionDate();
			int num = 0;
			Timestamp timestamp = (conditionDate.date_ = DateTime.UtcNow.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			startDate_ = conditionDate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x298DBE0", Offset = "0x298C5E0", VA = "0x18298DBE0")]
		private void OnConstruction()
		{
			//IL_002a: Expected I4, but got I8
			ConditionDate conditionDate = new ConditionDate();
			int num = 0;
			Timestamp timestamp = (conditionDate.date_ = DateTime.UtcNow.ToProto());
			conditionDate.localTime_ = false;
			conditionDate.operator_ = IntOperator.GreaterThanOrEqual;
			startDate_ = conditionDate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x298E6B0", Offset = "0x298D0B0", VA = "0x18298E6B0")]
		[DebuggerNonUserCode]
		public OnlineMessageData(OnlineMessageData other)
		{
			//IL_008e: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			int num = (version_ = other.version_);
			string text = (minGameVersion_ = other.minGameVersion_);
			bool flag = (active_ = other.active_);
			string text2 = (title_ = other.title_);
			string text3 = (description_ = other.description_);
			string text4 = (iconAddress_ = other.iconAddress_);
			RepeatedField<Types.RewardContent> repeatedField = (rewards_ = (RepeatedField<Types.RewardContent>)(object)((RepeatedField<T>)(object)other.rewards_).Clone());
			ConditionDate conditionDate = other.startDate_;
			int num2 = 0;
			if (conditionDate != null)
			{
				ConditionDate conditionDate2 = conditionDate.Clone();
			}
			startDate_ = (ConditionDate)num2;
			ConditionDate conditionDate3 = other.endDate_;
			if (conditionDate3 != null)
			{
				ConditionDate conditionDate4 = conditionDate3.Clone();
			}
			endDate_ = (ConditionDate)num2;
			string text5 = (language_ = other.language_);
			RepeatedField<string> repeatedField2 = (testerPlayerIds_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.testerPlayerIds_).Clone());
			RepeatedField<string> repeatedField3 = (realUserPlayerIds_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.realUserPlayerIds_).Clone());
			ConditionDate conditionDate5 = other.lastUpdateTimestamp_;
			ConditionDate conditionDate6 = default(ConditionDate);
			if (conditionDate5 != null)
			{
				conditionDate6 = conditionDate5.Clone();
			}
			lastUpdateTimestamp_ = conditionDate6;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x298CBF0", Offset = "0x298B5F0", VA = "0x18298CBF0", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineMessageData Clone()
		{
			return new OnlineMessageData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x298CF90", Offset = "0x298B990", VA = "0x18298CF90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((OnlineMessageData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x298CFF0", Offset = "0x298B9F0", VA = "0x18298CFF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineMessageData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.version_;
				if (version_ == num)
				{
					string text = other.minGameVersion_;
					if (!(minGameVersion_ != text))
					{
						bool flag = other.active_;
						if (active_ == flag)
						{
							string text2 = other.title_;
							if (!(title_ != text2))
							{
								string text3 = other.description_;
								if (!(description_ != text3))
								{
									string text4 = other.iconAddress_;
									if (!(iconAddress_ != text4))
									{
										RepeatedField<Types.RewardContent> repeatedField = rewards_;
										RepeatedField<Types.RewardContent> repeatedField2 = other.rewards_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											ConditionDate objB = other.startDate_;
											if (object.Equals(startDate_, objB))
											{
												ConditionDate objB2 = other.endDate_;
												if (object.Equals(endDate_, objB2))
												{
													string text5 = other.language_;
													if (!(language_ != text5))
													{
														RepeatedField<string> repeatedField3 = testerPlayerIds_;
														RepeatedField<string> repeatedField4 = other.testerPlayerIds_;
														if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
														{
															RepeatedField<string> repeatedField5 = realUserPlayerIds_;
															RepeatedField<string> repeatedField6 = other.realUserPlayerIds_;
															if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
															{
																ConditionDate objB3 = other.lastUpdateTimestamp_;
																if (object.Equals(lastUpdateTimestamp_, objB3))
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x298D390", Offset = "0x298BD90", VA = "0x18298D390", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_011b
			if (version_ != 0)
			{
			}
			string text = minGameVersion_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (active_)
			{
			}
			string text2 = title_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)rewards_).GetHashCode();
			ConditionDate conditionDate = startDate_;
			if (conditionDate != null)
			{
				int hashCode6 = conditionDate.GetHashCode();
			}
			ConditionDate conditionDate2 = endDate_;
			if (conditionDate2 != null)
			{
				int hashCode7 = conditionDate2.GetHashCode();
			}
			string text5 = language_;
			if (text5.m_stringLength != 0)
			{
				int hashCode8 = text5.GetHashCode();
			}
			int hashCode9 = ((RepeatedField<T>)(object)testerPlayerIds_).GetHashCode();
			int hashCode10 = ((RepeatedField<T>)(object)realUserPlayerIds_).GetHashCode();
			ConditionDate conditionDate3 = lastUpdateTimestamp_;
			if (conditionDate3 != null)
			{
				int hashCode11 = conditionDate3.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode12 = unknownFields.GetHashCode();
			}
			return hashCode10;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x298E0F0", Offset = "0x298CAF0", VA = "0x18298E0F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x298E150", Offset = "0x298CB50", VA = "0x18298E150", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0172
			if (version_ != 0)
			{
				int value = version_;
				output.WriteInt32(value);
			}
			if (minGameVersion_.m_stringLength != 0)
			{
				string value2 = minGameVersion_;
				output.WriteString(value2);
			}
			if (active_)
			{
				bool value3 = active_;
				output.WriteBool(value3);
			}
			if (title_.m_stringLength != 0)
			{
				string value4 = title_;
				output.WriteString(value4);
			}
			if (description_.m_stringLength != 0)
			{
				string value5 = description_;
				output.WriteString(value5);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value6 = iconAddress_;
				output.WriteString(value6);
			}
			RepeatedField<Types.RewardContent> repeatedField = rewards_;
			FieldCodec<Types.RewardContent> repeated_rewards_codec = _repeated_rewards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewards_codec);
			if ((long)startDate_ != 0)
			{
				ConditionDate value7 = startDate_;
				output.WriteMessage(value7);
			}
			if ((long)endDate_ != 0)
			{
				ConditionDate value8 = endDate_;
				output.WriteMessage(value8);
			}
			if (language_.m_stringLength != 0)
			{
				string value9 = language_;
				output.WriteString(value9);
			}
			RepeatedField<string> repeatedField2 = testerPlayerIds_;
			FieldCodec<string> repeated_testerPlayerIds_codec = _repeated_testerPlayerIds_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_testerPlayerIds_codec);
			RepeatedField<string> repeatedField3 = realUserPlayerIds_;
			FieldCodec<string> repeated_realUserPlayerIds_codec = _repeated_realUserPlayerIds_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_realUserPlayerIds_codec);
			if ((long)lastUpdateTimestamp_ != 0)
			{
				ConditionDate value10 = lastUpdateTimestamp_;
				output.WriteMessage(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x298C6F0", Offset = "0x298B0F0", VA = "0x18298C6F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01a2
			int num = version_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = minGameVersion_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = title_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = iconAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			RepeatedField<Types.RewardContent> repeatedField = rewards_;
			FieldCodec<Types.RewardContent> repeated_rewards_codec = _repeated_rewards_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rewards_codec);
			ConditionDate conditionDate = startDate_;
			num2 += num8;
			if (conditionDate != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(conditionDate);
				num9++;
				num2 += num9;
			}
			ConditionDate conditionDate2 = endDate_;
			if (conditionDate2 != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(conditionDate2);
				num10++;
				num2 += num10;
			}
			string text5 = language_;
			if (text5.m_stringLength != 0)
			{
				int num11 = CodedOutputStream.ComputeStringSize(text5);
				num11++;
				num2 += num11;
			}
			RepeatedField<string> repeatedField2 = testerPlayerIds_;
			FieldCodec<string> repeated_testerPlayerIds_codec = _repeated_testerPlayerIds_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_testerPlayerIds_codec);
			RepeatedField<string> repeatedField3 = realUserPlayerIds_;
			FieldCodec<string> repeated_realUserPlayerIds_codec = _repeated_realUserPlayerIds_codec;
			int num13 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_realUserPlayerIds_codec);
			ConditionDate conditionDate3 = lastUpdateTimestamp_;
			if (conditionDate3 != null)
			{
				int num14 = CodedOutputStream.ComputeMessageSize(conditionDate3);
				num14++;
				num2 += num14;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				num2 += num15;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x298D950", Offset = "0x298C350", VA = "0x18298D950", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineMessageData other)
		{
			//Discarded unreachable code: IL_01c6
			if (other == null)
			{
				return;
			}
			int num = other.version_;
			if (num != 0)
			{
				version_ = num;
			}
			string text = other.minGameVersion_;
			if (text.m_stringLength != 0)
			{
				MinGameVersion = text;
			}
			bool flag = other.active_;
			if (flag)
			{
				active_ = flag;
			}
			string text2 = other.title_;
			if (text2.m_stringLength != 0)
			{
				Title = text2;
			}
			string text3 = other.description_;
			if (text3.m_stringLength != 0)
			{
				Description = text3;
			}
			string text4 = other.iconAddress_;
			if (text4.m_stringLength != 0)
			{
				IconAddress = text4;
			}
			RepeatedField<Types.RewardContent> repeatedField = rewards_;
			RepeatedField<Types.RewardContent> repeatedField2 = other.rewards_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.startDate_ != 0)
			{
				ConditionDate conditionDate2 = default(ConditionDate);
				if (startDate_ == null)
				{
					ConditionDate conditionDate = (startDate_ = new ConditionDate());
					conditionDate2 = startDate_;
				}
				ConditionDate other2 = other.startDate_;
				conditionDate2.MergeFrom(other2);
			}
			if ((long)other.endDate_ != 0)
			{
				ConditionDate conditionDate4 = default(ConditionDate);
				if (endDate_ == null)
				{
					ConditionDate conditionDate3 = (endDate_ = new ConditionDate());
					conditionDate4 = endDate_;
				}
				ConditionDate other3 = other.endDate_;
				conditionDate4.MergeFrom(other3);
			}
			string text5 = other.language_;
			if (text5.m_stringLength != 0)
			{
				Language = text5;
			}
			RepeatedField<string> repeatedField3 = testerPlayerIds_;
			RepeatedField<string> repeatedField4 = other.testerPlayerIds_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			RepeatedField<string> repeatedField5 = realUserPlayerIds_;
			RepeatedField<string> repeatedField6 = other.realUserPlayerIds_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			if ((long)other.lastUpdateTimestamp_ != 0)
			{
				ConditionDate conditionDate6 = default(ConditionDate);
				if (lastUpdateTimestamp_ == null)
				{
					ConditionDate conditionDate5 = (lastUpdateTimestamp_ = new ConditionDate());
					conditionDate6 = lastUpdateTimestamp_;
				}
				ConditionDate other4 = other.lastUpdateTimestamp_;
				conditionDate6.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x298D590", Offset = "0x298BF90", VA = "0x18298D590", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_01d3
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 50)
			{
				if ((int)num > 74)
				{
					if ((int)num > 90)
					{
						if (num == 98)
						{
							RepeatedField<string> repeatedField = realUserPlayerIds_;
							FieldCodec<string> repeated_realUserPlayerIds_codec = _repeated_realUserPlayerIds_codec;
							((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_realUserPlayerIds_codec);
						}
						if (num != 106)
						{
							goto IL_01bc;
						}
						ConditionDate builder = default(ConditionDate);
						if (lastUpdateTimestamp_ == null)
						{
							ConditionDate conditionDate = (lastUpdateTimestamp_ = new ConditionDate());
							builder = lastUpdateTimestamp_;
						}
						input.ReadMessage(builder);
					}
					string text2 = default(string);
					if (num == 82)
					{
						text2 = (Language = input.ReadString());
					}
					if ((long)text2 != 90)
					{
						goto IL_01bc;
					}
					RepeatedField<string> repeatedField2 = testerPlayerIds_;
					FieldCodec<string> repeated_testerPlayerIds_codec = _repeated_testerPlayerIds_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_testerPlayerIds_codec);
				}
				if (num == 58)
				{
					RepeatedField<Types.RewardContent> repeatedField3 = rewards_;
					FieldCodec<Types.RewardContent> repeated_rewards_codec = _repeated_rewards_codec;
					((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rewards_codec);
				}
				ConditionDate conditionDate2 = default(ConditionDate);
				if (num == 66)
				{
					ConditionDate builder2 = default(ConditionDate);
					if (startDate_ == null)
					{
						conditionDate2 = (startDate_ = new ConditionDate());
						builder2 = startDate_;
					}
					input.ReadMessage(builder2);
				}
				if ((long)conditionDate2 != 74)
				{
					goto IL_01bc;
				}
				ConditionDate builder3 = default(ConditionDate);
				if (endDate_ == null)
				{
					ConditionDate conditionDate3 = (endDate_ = new ConditionDate());
					builder3 = endDate_;
				}
				input.ReadMessage(builder3);
			}
			string text8 = default(string);
			if ((int)num > 24)
			{
				string text4 = default(string);
				if (num == 34)
				{
					text4 = (Title = input.ReadString());
				}
				string text6 = default(string);
				if ((long)text4 == 42)
				{
					text6 = (Description = input.ReadString());
				}
				if ((long)text6 != 50)
				{
					goto IL_01bc;
				}
				text8 = (IconAddress = input.ReadString());
			}
			int num2 = default(int);
			if ((long)text8 == 8)
			{
				num2 = (version_ = input.ReadInt32());
			}
			string text10 = default(string);
			if (num2 == 18)
			{
				text10 = (MinGameVersion = input.ReadString());
			}
			if ((long)text10 == 24)
			{
				bool flag = (active_ = input.ReadBool());
			}
			goto IL_01bc;
			IL_01bc:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x298D1B0", Offset = "0x298BBB0", VA = "0x18298D1B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 12)
			{
				int num = version_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x298DCE0", Offset = "0x298C6E0", VA = "0x18298DCE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_0026, IL_002e, IL_002f, IL_0030, IL_0031, IL_0039, IL_003a, IL_0040, IL_0046, IL_004c, IL_0052, IL_0058
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			if (fieldNumber - 1 <= 12)
			{
				object obj = default(object);
				version_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x298CA50", Offset = "0x298B450", VA = "0x18298CA50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_001a
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 12)
			{
				version_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x298CC50", Offset = "0x298B650", VA = "0x18298CC50", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0067, IL_006d, IL_0073, IL_0079, IL_007f
			int num = 0;
			int num2 = 0;
			if ((IntPtr)endDate_ != (IntPtr)num2)
			{
				long seconds = startDate_.date_.Seconds;
				long seconds2 = endDate_.date_.Seconds;
				if (seconds > seconds2)
				{
					context.AddError("Start Date must be set to a date before the End Date.");
				}
			}
			if (((RepeatedField<T>)(object)rewards_).Count > 0)
			{
				RepeatedField<Types.RewardContent> repeatedField = rewards_;
				bool flag = default(bool);
				if (flag)
				{
					string error = default(string);
					context.AddError(error);
				}
			}
			int num3 = default(int);
			if (num3 <= 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x298E490", Offset = "0x298CE90", VA = "0x18298E490")]
		static OnlineMessageData()
		{
			Func<OnlineMessageData> func = default(Func<OnlineMessageData>);
			_parser = (MessageParser<OnlineMessageData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.RewardContent> parser = Types.RewardContent._parser;
			uint num = default(uint);
			_parser = (MessageParser<OnlineMessageData>)(object)FieldCodec.ForMessage<Types.RewardContent>(num, (MessageParser<>)(object)parser);
			_parser = (MessageParser<OnlineMessageData>)(object)FieldCodec.ForString(90u);
			_parser = (MessageParser<OnlineMessageData>)(object)FieldCodec.ForString(98u);
			/*Error: Unexpected end of block*/;
		}
	}
}
