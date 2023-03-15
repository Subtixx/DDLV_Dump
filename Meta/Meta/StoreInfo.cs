using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Displays;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Store;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000902")]
	public sealed class StoreInfo : IMessage<StoreInfo>, IMessage, IEquatable<StoreInfo>, IDeepCloneable<StoreInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000903")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000904")]
			public enum RefreshType
			{
				[Cpp2IlInjected.Token(Token = "0x400248C")]
				[OriginalName("Available")]
				Available,
				[Cpp2IlInjected.Token(Token = "0x400248D")]
				[OriginalName("ShowcaseOnly")]
				ShowcaseOnly,
				[Cpp2IlInjected.Token(Token = "0x400248E")]
				[OriginalName("ForceAll")]
				ForceAll
			}

			[Cpp2IlInjected.Token(Token = "0x2000905")]
			public sealed class StoreDisplay : IMessage<StoreDisplay>, IMessage, IEquatable<StoreDisplay>, IDeepCloneable<StoreDisplay>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400248F")]
				private static readonly MessageParser<StoreDisplay> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002490")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002491")]
				public const int DisplayItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002492")]
				private int displayItemID_;

				[Cpp2IlInjected.Token(Token = "0x4002493")]
				public const int DisplayInfoFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002494")]
				private DisplayInfo displayInfo_;

				[Cpp2IlInjected.Token(Token = "0x17000D5F")]
				[DebuggerNonUserCode]
				public static MessageParser<StoreDisplay> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004E74")]
					[Cpp2IlInjected.Address(RVA = "0x26075F0", Offset = "0x2605FF0", VA = "0x1826075F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D60")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004E75")]
					[Cpp2IlInjected.Address(RVA = "0x2607570", Offset = "0x2605F70", VA = "0x182607570")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D61")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004E76")]
					[Cpp2IlInjected.Address(RVA = "0x2607650", Offset = "0x2606050", VA = "0x182607650", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D62")]
				[DebuggerNonUserCode]
				public int DisplayItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6004E7A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6004E7B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D63")]
				[DebuggerNonUserCode]
				public DisplayInfo DisplayInfo
				{
					[Cpp2IlInjected.Token(Token = "0x6004E7C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004E7D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004E77")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public StoreDisplay()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004E78")]
				[Cpp2IlInjected.Address(RVA = "0x2607500", Offset = "0x2605F00", VA = "0x182607500")]
				[DebuggerNonUserCode]
				public StoreDisplay(StoreDisplay other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004E79")]
				[Cpp2IlInjected.Address(RVA = "0x2606ED0", Offset = "0x26058D0", VA = "0x182606ED0", Slot = "10")]
				[DebuggerNonUserCode]
				public StoreDisplay Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004E7E")]
				[Cpp2IlInjected.Address(RVA = "0x2606F70", Offset = "0x2605970", VA = "0x182606F70", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004E7F")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(StoreDisplay other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004E80")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004E81")]
				[Cpp2IlInjected.Address(RVA = "0x2607390", Offset = "0x2605D90", VA = "0x182607390", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004E82")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004E83")]
				[Cpp2IlInjected.Address(RVA = "0x2606E00", Offset = "0x2605800", VA = "0x182606E00", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004E84")]
				[Cpp2IlInjected.Address(RVA = "0x26071E0", Offset = "0x2605BE0", VA = "0x1826071E0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(StoreDisplay other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004E85")]
				[Cpp2IlInjected.Address(RVA = "0x26070F0", Offset = "0x2605AF0", VA = "0x1826070F0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004E86")]
				[Cpp2IlInjected.Address(RVA = "0x2607020", Offset = "0x2605A20", VA = "0x182607020", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004E87")]
				[Cpp2IlInjected.Address(RVA = "0x26072C0", Offset = "0x2605CC0", VA = "0x1826072C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004E88")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000907")]
		public class SequenceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x17000D64")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002496")]
			public bool IsActive
			{
				[Cpp2IlInjected.Token(Token = "0x6004E8D")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6004E8E")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000D65")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x11"), Cpp2IlInjected.Token(Token = "0x4002497")]
			public bool AnyItemPicked
			{
				[Cpp2IlInjected.Token(Token = "0x6004E8F")]
				[Cpp2IlInjected.Address(RVA = "0x5706D0", Offset = "0x56F0D0", VA = "0x1805706D0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6004E90")]
				[Cpp2IlInjected.Address(RVA = "0x570700", Offset = "0x56F100", VA = "0x180570700")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000D66")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x12"), Cpp2IlInjected.Token(Token = "0x4002498")]
			public bool WasRefreshed
			{
				[Cpp2IlInjected.Token(Token = "0x6004E91")]
				[Cpp2IlInjected.Address(RVA = "0x5706F0", Offset = "0x56F0F0", VA = "0x1805706F0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6004E92")]
				[Cpp2IlInjected.Address(RVA = "0x570720", Offset = "0x56F120", VA = "0x180570720")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6004E93")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SequenceStatus()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400247A")]
		private static readonly MessageParser<StoreInfo> _parser = (MessageParser<StoreInfo>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new StoreInfo()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400247B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400247C")]
		public const int BuildingItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400247D")]
		private int buildingItemID_;

		[Cpp2IlInjected.Token(Token = "0x400247E")]
		public const int DisplaysFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400247F")]
		private static readonly FieldCodec<Types.StoreDisplay> _repeated_displays_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002480")]
		private readonly RepeatedField<Types.StoreDisplay> displays_ = (RepeatedField<Types.StoreDisplay>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002481")]
		public const int LastRefreshFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002482")]
		private Timestamp lastRefresh_;

		[Cpp2IlInjected.Token(Token = "0x4002483")]
		public const int WeightedItemsFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4002484")]
		private static readonly MapField<int, int>.Codec _map_weightedItems_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002485")]
		private readonly MapField<int, int> weightedItems_ = (MapField<int, int>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4002486")]
		public const int CurrentSequenceIndexPerUpgradeFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4002487")]
		private static readonly FieldCodec<int> _repeated_currentSequenceIndexPerUpgrade_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002488")]
		private readonly RepeatedField<int> currentSequenceIndexPerUpgrade_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400248A")]
		private StoreData storeData;

		[Cpp2IlInjected.Token(Token = "0x17000D53")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E49")]
			[Cpp2IlInjected.Address(RVA = "0xC10810", Offset = "0xC0F210", VA = "0x180C10810")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D54")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E4A")]
			[Cpp2IlInjected.Address(RVA = "0xC10720", Offset = "0xC0F120", VA = "0x180C10720")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D55")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E4B")]
			[Cpp2IlInjected.Address(RVA = "0xC10AA0", Offset = "0xC0F4A0", VA = "0x180C10AA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D56")]
		[DebuggerNonUserCode]
		public int BuildingItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004E50")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return buildingItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E51")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				buildingItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D57")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.StoreDisplay> Displays
		{
			[Cpp2IlInjected.Token(Token = "0x6004E52")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return displays_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D58")]
		[DebuggerNonUserCode]
		public Timestamp LastRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x6004E53")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return lastRefresh_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E54")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				lastRefresh_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D59")]
		[DebuggerNonUserCode]
		public MapField<int, int> WeightedItems
		{
			[Cpp2IlInjected.Token(Token = "0x6004E55")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return weightedItems_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D5A")]
		[DebuggerNonUserCode]
		public RepeatedField<int> CurrentSequenceIndexPerUpgrade
		{
			[Cpp2IlInjected.Token(Token = "0x6004E56")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return currentSequenceIndexPerUpgrade_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D5B")]
		[field: Cpp2IlInjected.Token(Token = "0x4002489")]
		public static StoreData StoreEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6004E62")]
			[Cpp2IlInjected.Address(RVA = "0xC10A40", Offset = "0xC0F440", VA = "0x180C10A40")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000D5C")]
		public ProtoDatabase ProtoDb
		{
			[Cpp2IlInjected.Token(Token = "0x6004E63")]
			[Cpp2IlInjected.Address(RVA = "0xC10870", Offset = "0xC0F270", VA = "0x180C10870")]
			get
			{
				return ProtoDatabase.Instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D5D")]
		public StoreData StoreData
		{
			[Cpp2IlInjected.Token(Token = "0x6004E64")]
			[Cpp2IlInjected.Address(RVA = "0xC10910", Offset = "0xC0F310", VA = "0x180C10910")]
			get
			{
				//Discarded unreachable code: IL_0027
				StoreData storeData = this.storeData;
				if (storeData == null)
				{
					ProtoDatabase protoDb = ProtoDb;
					bool flag = default(bool);
					if (flag)
					{
					}
					StoreData storeData2 = (this.storeData = StoreEmpty);
				}
				return storeData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D5E")]
		public DateTime LastRefreshDateTime
		{
			[Cpp2IlInjected.Token(Token = "0x6004E67")]
			[Cpp2IlInjected.Address(RVA = "0xC107F0", Offset = "0xC0F1F0", VA = "0x180C107F0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return lastRefresh_.ToDateTime();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E4C")]
		[Cpp2IlInjected.Address(RVA = "0xC10590", Offset = "0xC0EF90", VA = "0x180C10590")]
		[DebuggerNonUserCode]
		public StoreInfo()
		{
			//IL_0033: Expected O, but got I4
			Timestamp timestamp = (lastRefresh_ = ((DateTime)0).ToProto());
		}

		[Cpp2IlInjected.Token(Token = "0x6004E4D")]
		[Cpp2IlInjected.Address(RVA = "0xC0F500", Offset = "0xC0DF00", VA = "0x180C0F500")]
		private void OnConstruction()
		{
			//IL_0006: Expected O, but got I4
			Timestamp timestamp = (lastRefresh_ = ((DateTime)0).ToProto());
		}

		[Cpp2IlInjected.Token(Token = "0x6004E4E")]
		[Cpp2IlInjected.Address(RVA = "0xC102E0", Offset = "0xC0ECE0", VA = "0x180C102E0")]
		[DebuggerNonUserCode]
		public StoreInfo(StoreInfo other)
		{
			//IL_0035: Expected O, but got I4
			//IL_0081: Expected O, but got I4
			int num = 0;
			Timestamp timestamp = (lastRefresh_ = ((DateTime)num).ToProto());
			int num2 = (buildingItemID_ = other.buildingItemID_);
			RepeatedField<Types.StoreDisplay> repeatedField = (displays_ = (RepeatedField<Types.StoreDisplay>)(object)((RepeatedField<T>)(object)other.displays_).Clone());
			Timestamp timestamp2 = other.lastRefresh_;
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = timestamp2.Clone();
			}
			lastRefresh_ = (Timestamp)num;
			MapField<int, int> mapField = (weightedItems_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)other.weightedItems_).Clone());
			RepeatedField<int> repeatedField2 = (currentSequenceIndexPerUpgrade_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.currentSequenceIndexPerUpgrade_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E4F")]
		[Cpp2IlInjected.Address(RVA = "0xC0AA80", Offset = "0xC09480", VA = "0x180C0AA80", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreInfo Clone()
		{
			return new StoreInfo(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E57")]
		[Cpp2IlInjected.Address(RVA = "0xC0AAE0", Offset = "0xC094E0", VA = "0x180C0AAE0", Slot = "0")]
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
				if ((IntPtr)buildingItemID_ == (IntPtr)typeof(StoreInfo).TypeHandle)
				{
					RepeatedField<Types.StoreDisplay> repeatedField = displays_;
					bool flag = default(bool);
					if (flag && object.Equals(lastRefresh_, other))
					{
						MapField<int, int> mapField = weightedItems_;
						bool flag2 = default(bool);
						if (flag2)
						{
							RepeatedField<int> repeatedField2 = currentSequenceIndexPerUpgrade_;
							bool flag3 = default(bool);
							if (flag3)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E58")]
		[Cpp2IlInjected.Address(RVA = "0xC0AC30", Offset = "0xC09630", VA = "0x180C0AC30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.buildingItemID_;
				if (buildingItemID_ == num)
				{
					RepeatedField<Types.StoreDisplay> repeatedField = displays_;
					RepeatedField<Types.StoreDisplay> repeatedField2 = other.displays_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						Timestamp objB = other.lastRefresh_;
						if (object.Equals(lastRefresh_, objB))
						{
							MapField<int, int> mapField = weightedItems_;
							MapField<int, int> mapField2 = other.weightedItems_;
							if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
							{
								RepeatedField<int> repeatedField3 = currentSequenceIndexPerUpgrade_;
								RepeatedField<int> repeatedField4 = other.currentSequenceIndexPerUpgrade_;
								if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E59")]
		[Cpp2IlInjected.Address(RVA = "0xC0ED50", Offset = "0xC0D750", VA = "0x180C0ED50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005e
			if (buildingItemID_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)displays_).GetHashCode();
			Timestamp timestamp = lastRefresh_;
			if (timestamp != null)
			{
				int hashCode2 = timestamp.GetHashCode();
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)weightedItems_).GetHashCode();
			int hashCode4 = ((RepeatedField<T>)(object)currentSequenceIndexPerUpgrade_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode4;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E5A")]
		[Cpp2IlInjected.Address(RVA = "0xC0F8B0", Offset = "0xC0E2B0", VA = "0x180C0F8B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E5B")]
		[Cpp2IlInjected.Address(RVA = "0xC0FE70", Offset = "0xC0E870", VA = "0x180C0FE70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_008d
			if (buildingItemID_ != 0)
			{
				int value = buildingItemID_;
				output.WriteInt32(value);
			}
			RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			FieldCodec<Types.StoreDisplay> repeated_displays_codec = _repeated_displays_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_displays_codec);
			if ((long)lastRefresh_ != 0)
			{
				Timestamp value2 = lastRefresh_;
				output.WriteMessage(value2);
			}
			MapField<int, int> mapField = weightedItems_;
			MapField<int, int>.Codec map_weightedItems_codec = _map_weightedItems_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_weightedItems_codec);
			RepeatedField<int> repeatedField2 = currentSequenceIndexPerUpgrade_;
			FieldCodec<int> repeated_currentSequenceIndexPerUpgrade_codec = _repeated_currentSequenceIndexPerUpgrade_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_currentSequenceIndexPerUpgrade_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E5C")]
		[Cpp2IlInjected.Address(RVA = "0xC0A420", Offset = "0xC08E20", VA = "0x180C0A420", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00a3
			int num = buildingItemID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			FieldCodec<Types.StoreDisplay> repeated_displays_codec = _repeated_displays_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_displays_codec);
			Timestamp timestamp = lastRefresh_;
			num2 += num4;
			if (timestamp != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(timestamp);
				num5++;
				num2 += num5;
			}
			MapField<int, int> mapField = weightedItems_;
			MapField<int, int>.Codec map_weightedItems_codec = _map_weightedItems_codec;
			int num6 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_weightedItems_codec);
			RepeatedField<int> repeatedField2 = currentSequenceIndexPerUpgrade_;
			FieldCodec<int> repeated_currentSequenceIndexPerUpgrade_codec = _repeated_currentSequenceIndexPerUpgrade_codec;
			int num7 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_currentSequenceIndexPerUpgrade_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num2 += num8;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E5D")]
		[Cpp2IlInjected.Address(RVA = "0xC0F030", Offset = "0xC0DA30", VA = "0x180C0F030", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreInfo other)
		{
			//Discarded unreachable code: IL_00ba
			if (other == null)
			{
				return;
			}
			int num = other.buildingItemID_;
			if (num != 0)
			{
				buildingItemID_ = num;
			}
			RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			RepeatedField<Types.StoreDisplay> repeatedField2 = other.displays_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.lastRefresh_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastRefresh_ == null)
				{
					Timestamp timestamp = (lastRefresh_ = new Timestamp());
					timestamp2 = lastRefresh_;
				}
				Timestamp other2 = other.lastRefresh_;
				timestamp2.MergeFrom(other2);
			}
			MapField<int, int> mapField = weightedItems_;
			MapField<int, int> mapField2 = other.weightedItems_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			RepeatedField<int> repeatedField3 = currentSequenceIndexPerUpgrade_;
			RepeatedField<int> repeatedField4 = other.currentSequenceIndexPerUpgrade_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004E5E")]
		[Cpp2IlInjected.Address(RVA = "0xC0F180", Offset = "0xC0DB80", VA = "0x180C0F180", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00cf
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					MapField<int, int> mapField = weightedItems_;
					MapField<int, int>.Codec map_weightedItems_codec = _map_weightedItems_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_weightedItems_codec);
				}
				num += 4294967256u;
				if (num != 4294967293u)
				{
					goto IL_00b8;
				}
				RepeatedField<int> repeatedField = currentSequenceIndexPerUpgrade_;
				FieldCodec<int> repeated_currentSequenceIndexPerUpgrade_codec = _repeated_currentSequenceIndexPerUpgrade_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_currentSequenceIndexPerUpgrade_codec);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (buildingItemID_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				RepeatedField<Types.StoreDisplay> repeatedField2 = displays_;
				FieldCodec<Types.StoreDisplay> repeated_displays_codec = _repeated_displays_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_displays_codec);
			}
			if (num2 == 26)
			{
				Timestamp builder = default(Timestamp);
				if (lastRefresh_ == null)
				{
					Timestamp timestamp = (lastRefresh_ = new Timestamp());
					builder = lastRefresh_;
				}
				input.ReadMessage(builder);
			}
			goto IL_00b8;
			IL_00b8:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004E5F")]
		[Cpp2IlInjected.Address(RVA = "0xC0EC50", Offset = "0xC0D650", VA = "0x180C0EC50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_003d;
							}
							RepeatedField<int> repeatedField = currentSequenceIndexPerUpgrade_;
						}
						MapField<int, int> mapField = weightedItems_;
					}
					Timestamp timestamp = lastRefresh_;
				}
				RepeatedField<Types.StoreDisplay> repeatedField2 = displays_;
			}
			int num2 = buildingItemID_;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E60")]
		[Cpp2IlInjected.Address(RVA = "0xC0F5A0", Offset = "0xC0DFA0", VA = "0x180C0F5A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0032
			//IL_0029: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			while (true)
			{
				int num = fieldNumber - 1;
				if (num == 0)
				{
					break;
				}
				if (num == 0)
				{
					continue;
				}
				if (num != 0)
				{
					switch (num)
					{
					case 0:
						continue;
					case 1:
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						/*Error: Unexpected end of block*/;
					}
					}
				}
				int num2 = 0;
				if (value == null || value != null)
				{
					lastRefresh_ = (Timestamp)num2;
					return;
				}
			}
			object obj = default(object);
			buildingItemID_ = (int)obj;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E61")]
		[Cpp2IlInjected.Address(RVA = "0xC0A9A0", Offset = "0xC093A0", VA = "0x180C0A9A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0030
			//IL_002f: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0)
				{
					if (num != 0 && num != 1)
					{
						return;
					}
					MapField<int, int> mapField = weightedItems_;
				}
				RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			}
			buildingItemID_ = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E65")]
		[Cpp2IlInjected.Address(RVA = "0xC0F770", Offset = "0xC0E170", VA = "0x180C0F770")]
		public LayoutArea StoreLayoutArea(int sizeX, int sizeY)
		{
			string type = string.Format("{0}x{1}", "{0}x{1}", "{0}x{1}");
			return StoreLayoutArea(type);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E66")]
		[Cpp2IlInjected.Address(RVA = "0xC0F810", Offset = "0xC0E210", VA = "0x180C0F810")]
		public unsafe LayoutArea StoreLayoutArea(string type)
		{
			int num = 0;
			ProtoDatabase protoDb = ProtoDb;
			string text = "StoreLayoutArea_" + type;
			bool flag = protoDb.TryGet(text, out *(LayoutArea*)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E68")]
		[Cpp2IlInjected.Address(RVA = "0xC0A840", Offset = "0xC09240", VA = "0x180C0A840")]
		public bool CanRefresh(DateTime now)
		{
			//Discarded unreachable code: IL_004d
			if (CanRefreshStore(now))
			{
				return true;
			}
			DateTime now2 = now;
			IFatigue fatigue = StoreData.refreshFatigue_.Fatigue;
			RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			Predicate<Types.StoreDisplay> predicate = (Predicate<Types.StoreDisplay>)(object)(Predicate<T>)delegate(Types.StoreDisplay x)
			{
				//Discarded unreachable code: IL_0024
				DisplayInfo displayInfo_ = x.displayInfo_;
				if (displayInfo_ == null)
				{
					int num = 0;
				}
				DateTime now3 = now2;
				IFatigue fatigue2 = fatigue;
				return displayInfo_.CanRefresh(fatigue2, now3);
			};
			return ((RepeatedField<>)(object)repeatedField).Any<Types.StoreDisplay>((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E69")]
		[Cpp2IlInjected.Address(RVA = "0xC0A720", Offset = "0xC09120", VA = "0x180C0A720")]
		public bool CanRefreshStore(DateTime now)
		{
			//Discarded unreachable code: IL_0038
			IFatigue fatigue = StoreData.refreshFatigue_.Fatigue;
			if (fatigue != null)
			{
				DateTime lastRefresh = lastRefresh_.ToDateTime();
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				return fatigue.CanRefresh(lastRefresh, now);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6A")]
		[Cpp2IlInjected.Address(RVA = "0xC0A5E0", Offset = "0xC08FE0", VA = "0x180C0A5E0")]
		public bool CanRefreshDisplays(DateTime now)
		{
			//Discarded unreachable code: IL_0041
			IFatigue fatigue = StoreData.refreshFatigue_.Fatigue;
			RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			Predicate<Types.StoreDisplay> predicate = (Predicate<Types.StoreDisplay>)(object)(Predicate<T>)delegate(Types.StoreDisplay x)
			{
				//Discarded unreachable code: IL_0024
				DisplayInfo displayInfo_ = x.displayInfo_;
				if (displayInfo_ == null)
				{
					int num = 0;
				}
				DateTime now2 = now;
				IFatigue fatigue2 = fatigue;
				return displayInfo_.CanRefresh(fatigue2, now2);
			};
			return ((RepeatedField<>)(object)repeatedField).Any<Types.StoreDisplay>((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6B")]
		[Cpp2IlInjected.Address(RVA = "0xC0F3D0", Offset = "0xC0DDD0", VA = "0x180C0F3D0")]
		public DateTime NextAutoRefresh(DateTime now)
		{
			//Discarded unreachable code: IL_0031
			IFatigue fatigue = StoreData.refreshFatigue_.Fatigue;
			if (fatigue != null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				return fatigue.NextAutoRefresh(now);
			}
			return DateTime.MinValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6C")]
		[Cpp2IlInjected.Address(RVA = "0xC0EBC0", Offset = "0xC0D5C0", VA = "0x180C0EBC0")]
		private int GetBuildingUpgradeLevel(ProfileWorld profileWorld, Item buildingItem)
		{
			//Discarded unreachable code: IL_0024
			GridCollection gridCollection_ = profileWorld.gridCollection_;
			HouseData houseData = default(HouseData);
			HouseData houseData2 = default(HouseData);
			if (houseData != null && (long)houseData.upgradeState_ != 0)
			{
				return houseData2.upgradeState_.level_;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6D")]
		[Cpp2IlInjected.Address(RVA = "0xC0E4D0", Offset = "0xC0CED0", VA = "0x180C0E4D0")]
		public List<Dictionary<int, int>> GetAvailableDisplaysPerUpgrade(ProfileWorld profileWorld, DateTime now, Item buildingItem, Types.RefreshType type)
		{
			//Discarded unreachable code: IL_0021
			GridCollection gridCollection_ = profileWorld.gridCollection_;
			HouseData houseData = default(HouseData);
			if (houseData != null && (long)houseData.upgradeState_ != 0)
			{
				HouseData houseData2 = default(HouseData);
				UpgradeState upgradeState_ = houseData2.upgradeState_;
			}
			List<Dictionary<int, int>> result = default(List<Dictionary<int, int>>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6E")]
		[Cpp2IlInjected.Address(RVA = "0xC0E5A0", Offset = "0xC0CFA0", VA = "0x180C0E5A0")]
		public List<Dictionary<int, int>> GetAvailableDisplaysPerUpgrade(DateTime now, Item buildingItem, int upgradeLevel, Types.RefreshType type)
		{
			//Discarded unreachable code: IL_0053, IL_0058, IL_005e, IL_00ad, IL_00b2, IL_00b8, IL_00bd, IL_00c1, IL_00c7, IL_00ea, IL_00f0, IL_00f6, IL_00fc, IL_0102, IL_0108, IL_010e, IL_0114
			//IL_0066: Expected O, but got I4
			//IL_0068: Expected I4, but got O
			//IL_00cf: Expected O, but got I4
			//IL_00d1: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			List<Dictionary<int, int>> list = (List<Dictionary<int, int>>)(object)new List<T>();
			if (upgradeLevel > 0)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Dictionary<int, int> dictionary = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();
				RepeatedField<Types.StoreDisplay> repeatedField = displays_;
				bool flag = default(bool);
				if (flag)
				{
					while (list == null)
					{
					}
					IFatigue fatigue = StoreData.refreshFatigue_.Fatigue;
					bool flag2 = default(bool);
					while (flag2)
					{
					}
					throw new NullReferenceException();
				}
				int useLowerLast = 0;
				BuildingItemData buildingUpgradable = default(BuildingItemData);
				uint num5 = default(uint);
				UpgradeData upgradeData = buildingUpgradable.GetUpgradeData((int)num5, (byte)useLowerLast != 0);
				if (upgradeData != null && upgradeData.Store != null)
				{
					Dictionary<int, int> item = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();
					RepeatedField<BenefitsStoreData.Types.StoreDisplay> repeatedField2 = upgradeData.Store.displays_;
					bool flag3 = default(bool);
					if (flag3)
					{
						throw new NullReferenceException();
					}
					((List<T>)(object)list).Add((T)item);
				}
				num5++;
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6F")]
		[Cpp2IlInjected.Address(RVA = "0xC0EE40", Offset = "0xC0D840", VA = "0x180C0EE40")]
		public bool HasEmptyDisplays(ProfileWorld profileWorld, DateTime now, Item buildingItem)
		{
			//Discarded unreachable code: IL_005e
			GridCollection gridCollection_ = profileWorld.gridCollection_;
			HouseData houseData = default(HouseData);
			if (profileWorld != null && profileWorld.gridCollection_ != null && houseData != null && (long)houseData.upgradeState_ != 0)
			{
				GridCollection gridCollection_2 = profileWorld.gridCollection_;
				HouseData houseData2 = default(HouseData);
				UpgradeState upgradeState_ = houseData2.upgradeState_;
			}
			Func<Dictionary<int, int>, bool> cpp2il__autoParamName__idx_ = default(Func<Dictionary<int, int>, bool>);
			if (_003C_003Ec._003C_003E9__68_0 == null)
			{
				cpp2il__autoParamName__idx_ = (Func<Dictionary<int, int>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Dictionary<int, int> x)
				{
					Func<KeyValuePair<int, int>, bool> _003C_003E9__68_ = _003C_003Ec._003C_003E9__68_1;
					if (_003C_003E9__68_ == null)
					{
						bool result = default(bool);
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, int> y) => result);
					}
					return ((IEnumerable<>)x).Any<KeyValuePair<int, int>>((Func<, >)(object)_003C_003E9__68_);
				});
			}
			List<Dictionary<int, int>> cpp2il__autoParamName__idx_2 = default(List<Dictionary<int, int>>);
			return ((IEnumerable<>)cpp2il__autoParamName__idx_2).Any<Dictionary<int, int>>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E70")]
		[Cpp2IlInjected.Address(RVA = "0xC0AD40", Offset = "0xC09740", VA = "0x180C0AD40")]
		public unsafe bool GenerateDisplaySlots(in Player player, in World world, ITransactionContext context, Item buildingItem, Types.RefreshType refreshType, [Optional] (Item Item, int Type)? forceStoreFilter)
		{
			//IL_00b1: Expected O, but got I4
			//IL_00c6: Expected I4, but got O
			//IL_016a: Expected O, but got I4
			//IL_0211: Expected O, but got I4
			//IL_0213: Expected I4, but got O
			//IL_0231: Expected O, but got I4
			//IL_0231: Expected O, but got I4
			//IL_023d: Expected O, but got I4
			//IL_023f: Expected I4, but got O
			//IL_0253: Expected O, but got I4
			ProfileWorld profileWorld = default(ProfileWorld);
			HouseData houseData = default(HouseData);
			HouseData houseData2 = default(HouseData);
			List<Dictionary<int, int>> list = default(List<Dictionary<int, int>>);
			Func<KeyValuePair<int, int>, int> func = default(Func<KeyValuePair<int, int>, int>);
			Func<KeyValuePair<int, int>, int> func2 = default(Func<KeyValuePair<int, int>, int>);
			List<ItemWithState> allAvailableItemsData;
			ProfilePlayer profilePlayer = default(ProfilePlayer);
			IEnumerable<IItemData> enumerable;
			bool flag = default(bool);
			Func<IItemData, ItemWithState> func4 = default(Func<IItemData, ItemWithState>);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				GridCollection gridCollection_ = profileWorld.gridCollection_;
				if (houseData != null && (IntPtr)houseData.upgradeState_ != (IntPtr)num4)
				{
					UpgradeState upgradeState_ = houseData2.upgradeState_;
				}
				List<Dictionary<int, int>> availableDisplaysPerUpgrade = list;
				Dictionary<int, int> availableDisplays = (Dictionary<int, int>)(object)new Dictionary<TKey, TValue>();
				List<Dictionary<int, int>> list2 = availableDisplaysPerUpgrade;
				Action<KeyValuePair<int, int>> action = default(Action<KeyValuePair<int, int>>);
				Action<Dictionary<int, int>> action2 = (Action<Dictionary<int, int>>)(object)(Action<T>)delegate(Dictionary<int, int> x)
				{
					Action<KeyValuePair<int, int>> action3 = action;
					if (action3 == null)
					{
						action = (Action<KeyValuePair<int, int>>)(object)(Action<T>)delegate
						{
							//Discarded unreachable code: IL_000d, IL_0011, IL_001e, IL_0038
							//IL_002d: Expected I4, but got O
							//IL_0035: Expected O, but got I4
							//IL_0037: Expected I4, but got O
							Dictionary<int, int> dictionary2 = availableDisplays;
							throw new NullReferenceException();
						};
					}
					MoreLinq.ForEach<KeyValuePair<int, int>>((IEnumerable<>)x, (Action<>)(object)action3);
				};
				((List<T>)(object)list2).ForEach((Action<>)(object)action2);
				if (((Dictionary<TKey, TValue>)(object)availableDisplays).Count <= 0)
				{
					continue;
				}
				List<SequenceStatus> list3 = (List<SequenceStatus>)(object)new List<T>();
				if (num4 > 0)
				{
					if (((RepeatedField<T>)(object)currentSequenceIndexPerUpgrade_).Count < num4)
					{
						RepeatedField<int> repeatedField = currentSequenceIndexPerUpgrade_;
						int num5 = 0;
						((RepeatedField<T>)(object)repeatedField).Add((T)num5);
					}
					SequenceStatus sequenceStatus = new SequenceStatus();
					int _003CIsActive_003Ek__BackingField = (int)((RepeatedField<T>)(object)currentSequenceIndexPerUpgrade_)[num4];
					sequenceStatus.IsActive = (byte)_003CIsActive_003Ek__BackingField != 0;
					((List<T>)(object)list3).Add((T)sequenceStatus);
					num4++;
				}
				WeightInfo weightInfo2 = new WeightInfo();
				int num6 = (weightInfo2.DefaultValue = StoreData.itemMaxWeight_);
				MapField<int, int> mapField = weightedItems_;
				if (_003C_003Ec._003C_003E9__70_16 == null)
				{
					func = (Func<KeyValuePair<int, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, int> x) => (int)((KeyValuePair<, >*)(&x))->key));
				}
				if (_003C_003Ec._003C_003E9__70_17 == null)
				{
					func2 = (Func<KeyValuePair<int, int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				Dictionary<int, KeyValuePair<int, int>> dictionary = (Dictionary<int, KeyValuePair<int, int>>)(object)(weightInfo2.WeightedItems = (Dictionary<int, int>)(object)Enumerable.ToDictionary<KeyValuePair<int, int>, int, int>((IEnumerable<>)(object)mapField, (Func<, >)(object)func, (Func<, >)(object)func2));
				WeightInfo weightInfo = weightInfo2;
				allAvailableItemsData = (List<ItemWithState>)num4;
				ListInventory wardrobe = profilePlayer.Wardrobe;
				IEnumerable<IItemData> allItemsData = (IEnumerable<IItemData>)ItemDatabase.Instance.get_AllItemsData();
				Func<IItemData, bool> func3 = (Func<IItemData, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0012
					ItemType itemType = default(ItemType);
					if (itemType != ItemType.Clothing)
					{
						return true;
					}
					ListInventory listInventory = wardrobe;
					bool flag4 = default(bool);
					return !flag4;
				};
				enumerable = (IEnumerable<IItemData>)Enumerable.Where<IItemData>((IEnumerable<>)allItemsData, (Func<, >)(object)func3);
				if (!flag)
				{
					break;
				}
				((RepeatedField<T>)(object)displays_).Clear();
				if (_003C_003Ec._003C_003E9__70_2 == null)
				{
					func4 = (Func<IItemData, ItemWithState>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IItemData x) => new ItemWithState()));
				}
				allAvailableItemsData = (List<ItemWithState>)(object)Enumerable.ToList<ItemWithState>(Enumerable.Select<IItemData, ItemWithState>((IEnumerable<>)enumerable, (Func<, >)(object)func4));
				List<KeyValuePair<int, int>> list4 = (List<KeyValuePair<int, int>>)(object)Enumerable.ToList<KeyValuePair<int, int>>((IEnumerable<>)(object)weightedItems_);
				if (flag2)
				{
					MapField<int, int> mapField2 = weightedItems_;
					int num7 = (int)((MapField<TKey, TValue>)(object)mapField2)[(TKey)num2];
					int itemIncWeight_ = StoreData.itemIncWeight_;
					itemIncWeight_ += num7;
					((MapField<TKey, TValue>)(object)mapField2)[(TKey)num2] = (TValue)itemIncWeight_;
					int num8 = (int)((MapField<TKey, TValue>)(object)weightedItems_)[(TKey)num2];
					StoreData storeData = StoreData;
					bool flag3 = ((MapField<TKey, TValue>)(object)weightedItems_).Remove((TKey)num2);
				}
				num4++;
				if (num4 == 0)
				{
					if (num4 == 0)
					{
					}
					break;
				}
			}
			Func<IItemData, bool> func5 = (Func<IItemData, bool>)(object)(Func<T, TResult>)delegate(IItemData x)
			{
				//Discarded unreachable code: IL_0031
				RepeatedField<Types.StoreDisplay> repeatedField2 = displays_;
				Predicate<DisplaySlot> predicate = default(Predicate<DisplaySlot>);
				Predicate<Types.StoreDisplay> predicate2 = (Predicate<Types.StoreDisplay>)(object)(Predicate<T>)delegate(Types.StoreDisplay y)
				{
					//Discarded unreachable code: IL_0039
					DisplayInfo displayInfo_ = y.displayInfo_;
					if (displayInfo_ == null)
					{
					}
					Predicate<DisplaySlot> predicate3 = predicate;
					RepeatedField<DisplaySlot> slots_ = displayInfo_.slots_;
					Predicate<DisplaySlot> predicate4 = default(Predicate<DisplaySlot>);
					if (predicate3 == null)
					{
						predicate4 = (predicate = (Predicate<DisplaySlot>)(object)(Predicate<T>)delegate(DisplaySlot z)
						{
							//Discarded unreachable code: IL_002d
							ItemAmount item_ = z.item_;
							if (item_ == null)
							{
							}
							IItemData itemData = x;
							int id_ = item_.id_;
							int num9 = 0;
							uint num10 = default(uint);
							if (num9 < (int)num10)
							{
								num9 += num9;
								num9++;
							}
							return id_ == num9;
						});
					}
					return ((RepeatedField<>)(object)slots_).Any<DisplaySlot>((Predicate<>)(object)predicate4);
				};
				return !((RepeatedField<>)(object)repeatedField2).Any<Types.StoreDisplay>((Predicate<>)(object)predicate2);
			};
			IEnumerable<IItemData> enumerable2 = (IEnumerable<IItemData>)Enumerable.Where<IItemData>((IEnumerable<>)enumerable, (Func<, >)(object)func5);
			Func<IItemData, ItemWithState> func6 = default(Func<IItemData, ItemWithState>);
			if (_003C_003Ec._003C_003E9__70_4 == null)
			{
				func6 = (Func<IItemData, ItemWithState>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IItemData x) => new ItemWithState()));
			}
			allAvailableItemsData = (List<ItemWithState>)(object)Enumerable.ToList<ItemWithState>(Enumerable.Select<IItemData, ItemWithState>((IEnumerable<>)enumerable2, (Func<, >)(object)func6));
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			BuildingItemData buildingItemData = default(BuildingItemData);
			string name_ = buildingItemData.name_;
			string key = "Store_" + name_;
			ProfilePlayer profilePlayer2 = default(ProfilePlayer);
			Random random = new Random(profilePlayer2.GetRandomSeed(key));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E71")]
		[Cpp2IlInjected.Address(RVA = "0xC10020", Offset = "0xC0EA20", VA = "0x180C10020")]
		static StoreInfo()
		{
			MessageParser<Types.StoreDisplay> parser = Types.StoreDisplay._parser;
			uint num = default(uint);
			_parser = (MessageParser<StoreInfo>)(object)FieldCodec.ForMessage<Types.StoreDisplay>(num, (MessageParser<>)(object)parser);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<int> fieldCodec2 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num2 = default(uint);
			_parser = (MessageParser<StoreInfo>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num2);
			_parser = (MessageParser<StoreInfo>)(object)FieldCodec.ForInt32(42u);
			_parser = (MessageParser<StoreInfo>)(object)new StoreData();
			/*Error: Unexpected end of block*/;
		}
	}
}
