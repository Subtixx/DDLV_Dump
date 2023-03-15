using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008C0")]
	public sealed class HangoutSettingsData : IMessage<HangoutSettingsData>, IMessage, IEquatable<HangoutSettingsData>, IDeepCloneable<HangoutSettingsData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20008C1")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20008C2")]
			public sealed class ActivityFriendshipData : IMessage<ActivityFriendshipData>, IMessage, IEquatable<ActivityFriendshipData>, IDeepCloneable<ActivityFriendshipData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400235B")]
				private static readonly MessageParser<ActivityFriendshipData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400235C")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400235D")]
				public const int ActivitySuccessAmountFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400235E")]
				private int activitySuccessAmount_;

				[Cpp2IlInjected.Token(Token = "0x400235F")]
				public const int ActivityFailureAmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4002360")]
				private int activityFailureAmount_;

				[Cpp2IlInjected.Token(Token = "0x4002361")]
				public const int PreferredActivitySuccessAmountFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002362")]
				private int preferredActivitySuccessAmount_;

				[Cpp2IlInjected.Token(Token = "0x4002363")]
				public const int PreferredActivityFailureAmountFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4002364")]
				private int preferredActivityFailureAmount_;

				[Cpp2IlInjected.Token(Token = "0x17000C9F")]
				[DebuggerNonUserCode]
				public static MessageParser<ActivityFriendshipData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004AE4")]
					[Cpp2IlInjected.Address(RVA = "0x1BF45E0", Offset = "0x1BF2FE0", VA = "0x181BF45E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA0")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004AE5")]
					[Cpp2IlInjected.Address(RVA = "0x1BF4560", Offset = "0x1BF2F60", VA = "0x181BF4560")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA1")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004AE6")]
					[Cpp2IlInjected.Address(RVA = "0x1BF4640", Offset = "0x1BF3040", VA = "0x181BF4640", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA2")]
				[DebuggerNonUserCode]
				public int ActivitySuccessAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6004AEA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004AEB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA3")]
				[DebuggerNonUserCode]
				public int ActivityFailureAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6004AEC")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004AED")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA4")]
				[DebuggerNonUserCode]
				public int PreferredActivitySuccessAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6004AEE")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004AEF")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA5")]
				[DebuggerNonUserCode]
				public int PreferredActivityFailureAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6004AF0")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004AF1")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004AE7")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ActivityFriendshipData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004AE8")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4500", Offset = "0x1BF2F00", VA = "0x181BF4500")]
				[DebuggerNonUserCode]
				public ActivityFriendshipData(ActivityFriendshipData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004AE9")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3D20", Offset = "0x1BF2720", VA = "0x181BF3D20", Slot = "10")]
				[DebuggerNonUserCode]
				public ActivityFriendshipData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004AF2")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3DB0", Offset = "0x1BF27B0", VA = "0x181BF3DB0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004AF3")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3E50", Offset = "0x1BF2850", VA = "0x181BF3E50", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ActivityFriendshipData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004AF4")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3F60", Offset = "0x1BF2960", VA = "0x181BF3F60", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004AF5")]
				[Cpp2IlInjected.Address(RVA = "0x1BF42B0", Offset = "0x1BF2CB0", VA = "0x181BF42B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004AF6")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4310", Offset = "0x1BF2D10", VA = "0x181BF4310", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004AF7")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3BB0", Offset = "0x1BF25B0", VA = "0x181BF3BB0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004AF8")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4020", Offset = "0x1BF2A20", VA = "0x181BF4020", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ActivityFriendshipData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004AF9")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4090", Offset = "0x1BF2A90", VA = "0x181BF4090", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004AFA")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3E90", Offset = "0x1BF2890", VA = "0x181BF3E90", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004AFB")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4150", Offset = "0x1BF2B50", VA = "0x181BF4150", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004AFC")]
				[Cpp2IlInjected.Address(RVA = "0x1BF3CE0", Offset = "0x1BF26E0", VA = "0x181BF3CE0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20008C4")]
			public sealed class ActivityGardenData : IMessage<ActivityGardenData>, IMessage, IEquatable<ActivityGardenData>, IDeepCloneable<ActivityGardenData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002366")]
				private static readonly MessageParser<ActivityGardenData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002367")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002368")]
				public const int ActivityFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002369")]
				private HangoutActivityType activity_;

				[Cpp2IlInjected.Token(Token = "0x400236A")]
				public const int GardensFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x400236B")]
				private static readonly FieldCodec<int> _repeated_gardens_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400236C")]
				private readonly RepeatedField<int> gardens_;

				[Cpp2IlInjected.Token(Token = "0x17000CA6")]
				[DebuggerNonUserCode]
				public static MessageParser<ActivityGardenData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004B01")]
					[Cpp2IlInjected.Address(RVA = "0x1BF52E0", Offset = "0x1BF3CE0", VA = "0x181BF52E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA7")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004B02")]
					[Cpp2IlInjected.Address(RVA = "0x1BF5260", Offset = "0x1BF3C60", VA = "0x181BF5260")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA8")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004B03")]
					[Cpp2IlInjected.Address(RVA = "0x1BF5340", Offset = "0x1BF3D40", VA = "0x181BF5340", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA9")]
				[DebuggerNonUserCode]
				public HangoutActivityType Activity
				{
					[Cpp2IlInjected.Token(Token = "0x6004B07")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(HangoutActivityType);
					}
					[Cpp2IlInjected.Token(Token = "0x6004B08")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CAA")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Gardens
				{
					[Cpp2IlInjected.Token(Token = "0x6004B09")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004B04")]
				[Cpp2IlInjected.Address(RVA = "0x1BF51E0", Offset = "0x1BF3BE0", VA = "0x181BF51E0")]
				[DebuggerNonUserCode]
				public ActivityGardenData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B05")]
				[Cpp2IlInjected.Address(RVA = "0x1BF50E0", Offset = "0x1BF3AE0", VA = "0x181BF50E0")]
				[DebuggerNonUserCode]
				public ActivityGardenData(ActivityGardenData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B06")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4860", Offset = "0x1BF3260", VA = "0x181BF4860", Slot = "10")]
				[DebuggerNonUserCode]
				public ActivityGardenData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004B0A")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4990", Offset = "0x1BF3390", VA = "0x181BF4990", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004B0B")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4A70", Offset = "0x1BF3470", VA = "0x181BF4A70", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ActivityGardenData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004B0C")]
				[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004B0D")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4E50", Offset = "0x1BF3850", VA = "0x181BF4E50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004B0E")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4EB0", Offset = "0x1BF38B0", VA = "0x181BF4EB0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B0F")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4700", Offset = "0x1BF3100", VA = "0x181BF4700", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004B10")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4BE0", Offset = "0x1BF35E0", VA = "0x181BF4BE0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ActivityGardenData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B11")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4C70", Offset = "0x1BF3670", VA = "0x181BF4C70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B12")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4B10", Offset = "0x1BF3510", VA = "0x181BF4B10", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004B13")]
				[Cpp2IlInjected.Address(RVA = "0x1BF4D80", Offset = "0x1BF3780", VA = "0x181BF4D80", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B14")]
				[Cpp2IlInjected.Address(RVA = "0x1BF47F0", Offset = "0x1BF31F0", VA = "0x181BF47F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002342")]
		private static readonly MessageParser<HangoutSettingsData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002343")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002344")]
		public const int StandardActionFriendshipMultiplierFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002345")]
		private float standardActionFriendshipMultiplier_;

		[Cpp2IlInjected.Token(Token = "0x4002346")]
		public const int PreferredActionFriendshipMultiplierFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002347")]
		private float preferredActionFriendshipMultiplier_;

		[Cpp2IlInjected.Token(Token = "0x4002348")]
		public const int SelfieFriendshipGainFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002349")]
		private int selfieFriendshipGain_;

		[Cpp2IlInjected.Token(Token = "0x400234A")]
		public const int SelfieRequiresHangoutFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400234B")]
		private bool selfieRequiresHangout_;

		[Cpp2IlInjected.Token(Token = "0x400234C")]
		public const int HangoutGatherResultMinDistanceFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400234D")]
		private int hangoutGatherResultMinDistance_;

		[Cpp2IlInjected.Token(Token = "0x400234E")]
		public const int HangoutGatherResultMaxDistanceFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400234F")]
		private int hangoutGatherResultMaxDistance_;

		[Cpp2IlInjected.Token(Token = "0x4002350")]
		public const int ActivityDataFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4002351")]
		private static readonly MapField<int, Types.ActivityFriendshipData>.Codec _map_activityData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002352")]
		private readonly MapField<int, Types.ActivityFriendshipData> activityData_ = (MapField<int, Types.ActivityFriendshipData>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4002353")]
		public const int GardenToActivityTypeFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4002354")]
		private static readonly FieldCodec<Types.ActivityGardenData> _repeated_gardenToActivityType_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002355")]
		private readonly RepeatedField<Types.ActivityGardenData> gardenToActivityType_ = (RepeatedField<Types.ActivityGardenData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002356")]
		public const int RestrictedGatherItemRewardTypesFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4002357")]
		private static readonly FieldCodec<ItemType> _repeated_restrictedGatherItemRewardTypes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002358")]
		private readonly RepeatedField<ItemType> restrictedGatherItemRewardTypes_ = (RepeatedField<ItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002359")]
		public const int ReplacementGatherItemRewardFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400235A")]
		private ItemReward replacementGatherItemReward_;

		[Cpp2IlInjected.Token(Token = "0x17000C92")]
		[DebuggerNonUserCode]
		public static MessageParser<HangoutSettingsData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC1")]
			[Cpp2IlInjected.Address(RVA = "0x17035A0", Offset = "0x1701FA0", VA = "0x1817035A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C93")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC2")]
			[Cpp2IlInjected.Address(RVA = "0x17034D0", Offset = "0x1701ED0", VA = "0x1817034D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C94")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC3")]
			[Cpp2IlInjected.Address(RVA = "0x1703610", Offset = "0x1702010", VA = "0x181703610", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C95")]
		[DebuggerNonUserCode]
		public float StandardActionFriendshipMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC7")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get
			{
				return standardActionFriendshipMultiplier_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AC8")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			set
			{
				standardActionFriendshipMultiplier_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C96")]
		[DebuggerNonUserCode]
		public float PreferredActionFriendshipMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC9")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320")]
			get
			{
				return preferredActionFriendshipMultiplier_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004ACA")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			set
			{
				preferredActionFriendshipMultiplier_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C97")]
		[DebuggerNonUserCode]
		public int SelfieFriendshipGain
		{
			[Cpp2IlInjected.Token(Token = "0x6004ACB")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return selfieFriendshipGain_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004ACC")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				selfieFriendshipGain_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C98")]
		[DebuggerNonUserCode]
		public bool SelfieRequiresHangout
		{
			[Cpp2IlInjected.Token(Token = "0x6004ACD")]
			[Cpp2IlInjected.Address(RVA = "0x1703600", Offset = "0x1702000", VA = "0x181703600")]
			get
			{
				return selfieRequiresHangout_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004ACE")]
			[Cpp2IlInjected.Address(RVA = "0x1703720", Offset = "0x1702120", VA = "0x181703720")]
			set
			{
				selfieRequiresHangout_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C99")]
		[DebuggerNonUserCode]
		public int HangoutGatherResultMinDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6004ACF")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return hangoutGatherResultMinDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AD0")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				hangoutGatherResultMinDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9A")]
		[DebuggerNonUserCode]
		public int HangoutGatherResultMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6004AD1")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return hangoutGatherResultMaxDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AD2")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				hangoutGatherResultMaxDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9B")]
		[DebuggerNonUserCode]
		public MapField<int, Types.ActivityFriendshipData> ActivityData
		{
			[Cpp2IlInjected.Token(Token = "0x6004AD3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return activityData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9C")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.ActivityGardenData> GardenToActivityType
		{
			[Cpp2IlInjected.Token(Token = "0x6004AD4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return gardenToActivityType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9D")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemType> RestrictedGatherItemRewardTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004AD5")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return restrictedGatherItemRewardTypes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9E")]
		[DebuggerNonUserCode]
		public ItemReward ReplacementGatherItemReward
		{
			[Cpp2IlInjected.Token(Token = "0x6004AD6")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return replacementGatherItemReward_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004AD7")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				replacementGatherItemReward_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004AC4")]
		[Cpp2IlInjected.Address(RVA = "0x17033D0", Offset = "0x1701DD0", VA = "0x1817033D0")]
		[DebuggerNonUserCode]
		public HangoutSettingsData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004AC5")]
		[Cpp2IlInjected.Address(RVA = "0x1703190", Offset = "0x1701B90", VA = "0x181703190")]
		[DebuggerNonUserCode]
		public HangoutSettingsData(HangoutSettingsData other)
		{
			//IL_00eb: Expected O, but got I4
			float num = (standardActionFriendshipMultiplier_ = other.standardActionFriendshipMultiplier_);
			float num2 = (preferredActionFriendshipMultiplier_ = other.preferredActionFriendshipMultiplier_);
			int num3 = (selfieFriendshipGain_ = other.selfieFriendshipGain_);
			bool flag = (selfieRequiresHangout_ = other.selfieRequiresHangout_);
			int num4 = (hangoutGatherResultMinDistance_ = other.hangoutGatherResultMinDistance_);
			int num5 = (hangoutGatherResultMaxDistance_ = other.hangoutGatherResultMaxDistance_);
			MapField<int, Types.ActivityFriendshipData> mapField = (activityData_ = (MapField<int, Types.ActivityFriendshipData>)(object)((MapField<TKey, TValue>)(object)other.activityData_).Clone());
			RepeatedField<Types.ActivityGardenData> repeatedField = (gardenToActivityType_ = (RepeatedField<Types.ActivityGardenData>)(object)((RepeatedField<T>)(object)other.gardenToActivityType_).Clone());
			RepeatedField<ItemType> repeatedField2 = (restrictedGatherItemRewardTypes_ = (RepeatedField<ItemType>)(object)((RepeatedField<T>)(object)other.restrictedGatherItemRewardTypes_).Clone());
			ItemReward itemReward = other.replacementGatherItemReward_;
			if (itemReward != null)
			{
				ItemReward itemReward2 = itemReward.Clone();
			}
			int num6 = 0;
			replacementGatherItemReward_ = (ItemReward)num6;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004AC6")]
		[Cpp2IlInjected.Address(RVA = "0x1701BA0", Offset = "0x17005A0", VA = "0x181701BA0", Slot = "10")]
		[DebuggerNonUserCode]
		public HangoutSettingsData Clone()
		{
			return new HangoutSettingsData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004AD8")]
		[Cpp2IlInjected.Address(RVA = "0x1701C00", Offset = "0x1700600", VA = "0x181701C00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((HangoutSettingsData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004AD9")]
		[Cpp2IlInjected.Address(RVA = "0x1701C60", Offset = "0x1700660", VA = "0x181701C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(HangoutSettingsData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					int num = other.selfieFriendshipGain_;
					if (selfieFriendshipGain_ == num)
					{
						bool flag = other.selfieRequiresHangout_;
						if (selfieRequiresHangout_ == flag)
						{
							int num2 = other.hangoutGatherResultMinDistance_;
							if (hangoutGatherResultMinDistance_ == num2)
							{
								int num3 = other.hangoutGatherResultMaxDistance_;
								if (hangoutGatherResultMaxDistance_ == num3)
								{
									MapField<int, Types.ActivityFriendshipData> mapField = activityData_;
									MapField<int, Types.ActivityFriendshipData> mapField2 = other.activityData_;
									if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
									{
										RepeatedField<Types.ActivityGardenData> repeatedField = gardenToActivityType_;
										RepeatedField<Types.ActivityGardenData> repeatedField2 = other.gardenToActivityType_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											RepeatedField<ItemType> repeatedField3 = restrictedGatherItemRewardTypes_;
											RepeatedField<ItemType> repeatedField4 = other.restrictedGatherItemRewardTypes_;
											if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
											{
												ItemReward objB = other.replacementGatherItemReward_;
												if (object.Equals(replacementGatherItemReward_, objB))
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
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004ADA")]
		[Cpp2IlInjected.Address(RVA = "0x1702030", Offset = "0x1700A30", VA = "0x181702030", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_008e
			if (ProtobufEqualityComparers.BitwiseSingleEqualityComparer != null)
			{
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			}
			if (selfieFriendshipGain_ != 0)
			{
			}
			if (selfieRequiresHangout_)
			{
			}
			if (hangoutGatherResultMinDistance_ != 0)
			{
			}
			if (hangoutGatherResultMaxDistance_ != 0)
			{
			}
			int hashCode = ((MapField<TKey, TValue>)(object)activityData_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)gardenToActivityType_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)restrictedGatherItemRewardTypes_).GetHashCode();
			ItemReward itemReward = replacementGatherItemReward_;
			int result = hashCode3;
			if (itemReward != null)
			{
				int hashCode4 = itemReward.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ADB")]
		[Cpp2IlInjected.Address(RVA = "0x1702AD0", Offset = "0x17014D0", VA = "0x181702AD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ADC")]
		[Cpp2IlInjected.Address(RVA = "0x1702B30", Offset = "0x1701530", VA = "0x181702B30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00fc
			float value = standardActionFriendshipMultiplier_;
			output.WriteFloat(value);
			if (output != null)
			{
				float value2 = preferredActionFriendshipMultiplier_;
				output.WriteFloat(value2);
			}
			if (selfieFriendshipGain_ != 0)
			{
				int value3 = selfieFriendshipGain_;
				output.WriteInt32(value3);
			}
			if (selfieRequiresHangout_)
			{
				bool value4 = selfieRequiresHangout_;
				output.WriteBool(value4);
			}
			if (hangoutGatherResultMinDistance_ != 0)
			{
				int value5 = hangoutGatherResultMinDistance_;
				output.WriteInt32(value5);
			}
			if (hangoutGatherResultMaxDistance_ != 0)
			{
				int value6 = hangoutGatherResultMaxDistance_;
				output.WriteInt32(value6);
			}
			MapField<int, Types.ActivityFriendshipData> mapField = activityData_;
			MapField<int, Types.ActivityFriendshipData>.Codec map_activityData_codec = _map_activityData_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_activityData_codec);
			RepeatedField<Types.ActivityGardenData> repeatedField = gardenToActivityType_;
			FieldCodec<Types.ActivityGardenData> repeated_gardenToActivityType_codec = _repeated_gardenToActivityType_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_gardenToActivityType_codec);
			RepeatedField<ItemType> repeatedField2 = restrictedGatherItemRewardTypes_;
			FieldCodec<ItemType> repeated_restrictedGatherItemRewardTypes_codec = _repeated_restrictedGatherItemRewardTypes_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_restrictedGatherItemRewardTypes_codec);
			if ((long)replacementGatherItemReward_ != 0)
			{
				ItemReward value7 = replacementGatherItemReward_;
				output.WriteMessage(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ADD")]
		[Cpp2IlInjected.Address(RVA = "0x1701810", Offset = "0x1700210", VA = "0x181701810", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			uint num = num + 5;
			int num2 = selfieFriendshipGain_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += (uint)num3;
			}
			int num4 = hangoutGatherResultMinDistance_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += (uint)num5;
			}
			int num6 = hangoutGatherResultMaxDistance_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += (uint)num7;
			}
			MapField<int, Types.ActivityFriendshipData> mapField = activityData_;
			MapField<int, Types.ActivityFriendshipData>.Codec map_activityData_codec = _map_activityData_codec;
			int num8 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_activityData_codec);
			RepeatedField<Types.ActivityGardenData> repeatedField = gardenToActivityType_;
			FieldCodec<Types.ActivityGardenData> repeated_gardenToActivityType_codec = _repeated_gardenToActivityType_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_gardenToActivityType_codec);
			RepeatedField<ItemType> repeatedField2 = restrictedGatherItemRewardTypes_;
			FieldCodec<ItemType> repeated_restrictedGatherItemRewardTypes_codec = _repeated_restrictedGatherItemRewardTypes_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_restrictedGatherItemRewardTypes_codec);
			ItemReward itemReward = replacementGatherItemReward_;
			if (itemReward != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(itemReward);
				num11++;
				mapField = (MapField<int, Types.ActivityFriendshipData>)(mapField + num11);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num12 = unknownFields.CalculateSize();
				mapField = (MapField<int, Types.ActivityFriendshipData>)(mapField + num12);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004ADE")]
		[Cpp2IlInjected.Address(RVA = "0x17022F0", Offset = "0x1700CF0", VA = "0x1817022F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(HangoutSettingsData other)
		{
			//Discarded unreachable code: IL_0120
			if (other == null)
			{
				return;
			}
			float num = other.standardActionFriendshipMultiplier_;
			if (other != null)
			{
				standardActionFriendshipMultiplier_ = num;
			}
			float num2 = other.preferredActionFriendshipMultiplier_;
			if (other != null)
			{
				preferredActionFriendshipMultiplier_ = num2;
			}
			int num3 = other.selfieFriendshipGain_;
			if (num3 != 0)
			{
				selfieFriendshipGain_ = num3;
			}
			bool flag = other.selfieRequiresHangout_;
			if (flag)
			{
				selfieRequiresHangout_ = flag;
			}
			int num4 = other.hangoutGatherResultMinDistance_;
			if (num4 != 0)
			{
				hangoutGatherResultMinDistance_ = num4;
			}
			int num5 = other.hangoutGatherResultMaxDistance_;
			if (num5 != 0)
			{
				hangoutGatherResultMaxDistance_ = num5;
			}
			MapField<int, Types.ActivityFriendshipData> mapField = activityData_;
			MapField<int, Types.ActivityFriendshipData> mapField2 = other.activityData_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			RepeatedField<Types.ActivityGardenData> repeatedField = gardenToActivityType_;
			RepeatedField<Types.ActivityGardenData> repeatedField2 = other.gardenToActivityType_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<ItemType> repeatedField3 = restrictedGatherItemRewardTypes_;
			RepeatedField<ItemType> repeatedField4 = other.restrictedGatherItemRewardTypes_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			if ((long)other.replacementGatherItemReward_ != 0)
			{
				ItemReward itemReward2 = default(ItemReward);
				if (replacementGatherItemReward_ == null)
				{
					ItemReward itemReward = (replacementGatherItemReward_ = new ItemReward());
					itemReward2 = replacementGatherItemReward_;
				}
				ItemReward other2 = other.replacementGatherItemReward_;
				itemReward2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004ADF")]
		[Cpp2IlInjected.Address(RVA = "0x1702490", Offset = "0x1700E90", VA = "0x181702490", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_014b
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 40)
			{
				if ((int)num > 66)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 82)
						{
							goto IL_0134;
						}
						ItemReward itemReward = replacementGatherItemReward_;
						if (itemReward == null)
						{
							ItemReward itemReward2 = (replacementGatherItemReward_ = new ItemReward());
						}
						input.ReadMessage(itemReward);
					}
					RepeatedField<ItemType> repeatedField = restrictedGatherItemRewardTypes_;
					FieldCodec<ItemType> repeated_restrictedGatherItemRewardTypes_codec = _repeated_restrictedGatherItemRewardTypes_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_restrictedGatherItemRewardTypes_codec);
				}
				int num2 = default(int);
				if (num == 48)
				{
					num2 = (hangoutGatherResultMaxDistance_ = input.ReadInt32());
				}
				if (num2 == 58)
				{
					MapField<int, Types.ActivityFriendshipData> mapField = activityData_;
					MapField<int, Types.ActivityFriendshipData>.Codec map_activityData_codec = _map_activityData_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_activityData_codec);
				}
				if (num2 != 66)
				{
					goto IL_0134;
				}
				RepeatedField<Types.ActivityGardenData> repeatedField2 = gardenToActivityType_;
				FieldCodec<Types.ActivityGardenData> repeated_gardenToActivityType_codec = _repeated_gardenToActivityType_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_gardenToActivityType_codec);
			}
			int num4 = default(int);
			if ((int)num > 21)
			{
				int num3 = default(int);
				if (num == 24)
				{
					num3 = (selfieFriendshipGain_ = input.ReadInt32());
				}
				bool flag = default(bool);
				if (num3 == 32)
				{
					flag = (selfieRequiresHangout_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0134;
				}
				num4 = (hangoutGatherResultMinDistance_ = input.ReadInt32());
			}
			if (num4 == 13)
			{
				float num5 = (standardActionFriendshipMultiplier_ = input.ReadFloat());
			}
			if (num4 == 21)
			{
				float num6 = (preferredActionFriendshipMultiplier_ = input.ReadFloat());
			}
			goto IL_0134;
			IL_0134:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004AE0")]
		[Cpp2IlInjected.Address(RVA = "0x1701E50", Offset = "0x1700850", VA = "0x181701E50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
			{
				float num = standardActionFriendshipMultiplier_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004AE1")]
		[Cpp2IlInjected.Address(RVA = "0x1702770", Offset = "0x1701170", VA = "0x181702770", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014
			//IL_000e: Expected F4, but got O
			//IL_001b: Expected O, but got I4
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				standardActionFriendshipMultiplier_ = (float)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004AE2")]
		[Cpp2IlInjected.Address(RVA = "0x1701A40", Offset = "0x1700440", VA = "0x181701A40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0019
			if (fieldNumber - 1 <= 9)
			{
				standardActionFriendshipMultiplier_ = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004AE3")]
		[Cpp2IlInjected.Address(RVA = "0x1702DA0", Offset = "0x17017A0", VA = "0x181702DA0")]
		static HangoutSettingsData()
		{
			Func<HangoutSettingsData> func = default(Func<HangoutSettingsData>);
			_parser = (MessageParser<HangoutSettingsData>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<Types.ActivityFriendshipData> parser = Types.ActivityFriendshipData._parser;
			uint num = default(uint);
			FieldCodec<> CS_0024_003C_003E8__locals0 = FieldCodec.ForMessage<Types.ActivityFriendshipData>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<HangoutSettingsData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, CS_0024_003C_003E8__locals0, num2);
			MessageParser<Types.ActivityGardenData> parser2 = Types.ActivityGardenData._parser;
			uint num3 = default(uint);
			_parser = (MessageParser<HangoutSettingsData>)(object)FieldCodec.ForMessage<Types.ActivityGardenData>(num3, (MessageParser<>)(object)parser2);
			Func<ItemType, int> func2 = (Func<ItemType, int>)(object)(Func<T, TResult>)((ItemType x) => (int)x);
			Func<int, ItemType> func3 = (Func<int, ItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num4 = default(uint);
			_parser = (MessageParser<HangoutSettingsData>)(object)FieldCodec.ForEnum<ItemType>(num4, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
