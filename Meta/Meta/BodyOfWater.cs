using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007E5")]
	public sealed class BodyOfWater : IMessage<BodyOfWater>, IMessage, IEquatable<BodyOfWater>, IDeepCloneable<BodyOfWater>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001F72")]
		private static readonly MessageParser<BodyOfWater> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F73")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F74")]
		public const int LastFishingFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F75")]
		private Timestamp lastFishing_;

		[Cpp2IlInjected.Token(Token = "0x4001F76")]
		public const int CurrentPendingFishFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F77")]
		private PendingFish currentPendingFish_;

		[Cpp2IlInjected.Token(Token = "0x4001F78")]
		public const int RequestedFishConditionIDFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F79")]
		private int requestedFishConditionID_;

		[Cpp2IlInjected.Token(Token = "0x4001F7A")]
		public const int RequestedFishItemIDFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001F7B")]
		private int requestedFishItemID_;

		[Cpp2IlInjected.Token(Token = "0x4001F7C")]
		public const int LocationFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001F7D")]
		private ActivityDataLocationFilter location_;

		[Cpp2IlInjected.Token(Token = "0x4001F7E")]
		public const int RequestedPendingFishIDFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4001F7F")]
		private static readonly FieldCodec<uint?> _single_requestedPendingFishID_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001F80")]
		private uint? requestedPendingFishID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001F81")]
		private IWorldEventDispatcher dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001F82")]
		private ITransactionContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001F83")]
		private Profile profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001F84")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x17000A93")]
		[DebuggerNonUserCode]
		public static MessageParser<BodyOfWater> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600417F")]
			[Cpp2IlInjected.Address(RVA = "0x1AC0570", Offset = "0x1ABEF70", VA = "0x181AC0570")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A94")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004180")]
			[Cpp2IlInjected.Address(RVA = "0x1AC0350", Offset = "0x1ABED50", VA = "0x181AC0350")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A95")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004181")]
			[Cpp2IlInjected.Address(RVA = "0x1AC07B0", Offset = "0x1ABF1B0", VA = "0x181AC07B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A96")]
		[DebuggerNonUserCode]
		public Timestamp LastFishing
		{
			[Cpp2IlInjected.Token(Token = "0x6004185")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return lastFishing_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004186")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				lastFishing_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A97")]
		[DebuggerNonUserCode]
		public PendingFish CurrentPendingFish
		{
			[Cpp2IlInjected.Token(Token = "0x6004187")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return currentPendingFish_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004188")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				currentPendingFish_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A98")]
		[DebuggerNonUserCode]
		public int RequestedFishConditionID
		{
			[Cpp2IlInjected.Token(Token = "0x6004189")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return requestedFishConditionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600418A")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				requestedFishConditionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A99")]
		[DebuggerNonUserCode]
		public int RequestedFishItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600418B")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return requestedFishItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600418C")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				requestedFishItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A9A")]
		[DebuggerNonUserCode]
		public ActivityDataLocationFilter Location
		{
			[Cpp2IlInjected.Token(Token = "0x600418D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x600418E")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				location_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A9B")]
		[DebuggerNonUserCode]
		public uint? RequestedPendingFishID
		{
			[Cpp2IlInjected.Token(Token = "0x600418F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return requestedPendingFishID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004190")]
			[Cpp2IlInjected.Address(RVA = "0x7B2EF0", Offset = "0x7B18F0", VA = "0x1807B2EF0")]
			set
			{
				requestedPendingFishID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A9C")]
		private Item RequestedFishItem
		{
			[Cpp2IlInjected.Token(Token = "0x600419C")]
			[Cpp2IlInjected.Address(RVA = "0x1AC0750", Offset = "0x1ABF150", VA = "0x181AC0750")]
			get
			{
				long num = Convert.ToInt64((uint)requestedFishItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A9D")]
		private FishItemData RequestedFishItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600419D")]
			[Cpp2IlInjected.Address(RVA = "0x1AC0630", Offset = "0x1ABF030", VA = "0x181AC0630")]
			get
			{
				//Discarded unreachable code: IL_0014
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)requestedFishItemID_);
				FishItemData result = default(FishItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A9E")]
		private FishingDataItemData FishingData
		{
			[Cpp2IlInjected.Token(Token = "0x600419E")]
			[Cpp2IlInjected.Address(RVA = "0x1AC0420", Offset = "0x1ABEE20", VA = "0x181AC0420")]
			get
			{
				//Discarded unreachable code: IL_0028
				IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<FishingDataItemData, ActivityDataItemType>(ItemType.ActivityData, ActivityDataItemType.FishingData);
				Func<FishingDataItemData, bool> func = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData x)
				{
					//Discarded unreachable code: IL_0019
					//IL_0019: Expected I4, but got O
					Item item = x.result_.Item;
					int num = requestedFishItemID_;
					return (byte)(int)typeof(Item).TypeHandle != 0;
				};
				return Enumerable.FirstOrDefault<FishingDataItemData>(allByType, (Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A9F")]
		private Item RequestedFishConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600419F")]
			[Cpp2IlInjected.Address(RVA = "0x1AC05D0", Offset = "0x1ABEFD0", VA = "0x181AC05D0")]
			get
			{
				long num = Convert.ToInt64((uint)requestedFishConditionID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004182")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BodyOfWater()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004183")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0270", Offset = "0x1ABEC70", VA = "0x181AC0270")]
		[DebuggerNonUserCode]
		public BodyOfWater(BodyOfWater other)
		{
			//IL_0021: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			Timestamp timestamp = other.lastFishing_;
			int num = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			lastFishing_ = (Timestamp)num;
			PendingFish pendingFish = other.currentPendingFish_;
			if (pendingFish != null)
			{
				PendingFish pendingFish2 = pendingFish.Clone();
			}
			currentPendingFish_ = (PendingFish)num;
			int num2 = (requestedFishConditionID_ = other.requestedFishConditionID_);
			int num3 = (requestedFishItemID_ = other.requestedFishItemID_);
			ActivityDataLocationFilter activityDataLocationFilter = other.location_;
			ActivityDataLocationFilter activityDataLocationFilter2 = default(ActivityDataLocationFilter);
			if (activityDataLocationFilter != null)
			{
				activityDataLocationFilter2 = activityDataLocationFilter.Clone();
			}
			location_ = activityDataLocationFilter2;
			uint? num4 = (requestedPendingFishID_ = other.requestedPendingFishID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004184")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE700", Offset = "0x1ABD100", VA = "0x181ABE700", Slot = "10")]
		[DebuggerNonUserCode]
		public BodyOfWater Clone()
		{
			//Discarded unreachable code: IL_00a3
			//IL_0021: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			BodyOfWater bodyOfWater = new BodyOfWater();
			Timestamp timestamp = lastFishing_;
			int num = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			bodyOfWater.lastFishing_ = (Timestamp)num;
			PendingFish pendingFish = currentPendingFish_;
			if (pendingFish != null)
			{
				PendingFish pendingFish2 = pendingFish.Clone();
			}
			bodyOfWater.currentPendingFish_ = (PendingFish)num;
			int num2 = (bodyOfWater.requestedFishConditionID_ = requestedFishConditionID_);
			int num3 = (bodyOfWater.requestedFishItemID_ = requestedFishItemID_);
			ActivityDataLocationFilter activityDataLocationFilter = location_;
			ActivityDataLocationFilter activityDataLocationFilter2 = default(ActivityDataLocationFilter);
			if (activityDataLocationFilter != null)
			{
				activityDataLocationFilter2 = activityDataLocationFilter.Clone();
			}
			bodyOfWater.location_ = activityDataLocationFilter2;
			uint? num4 = (bodyOfWater.requestedPendingFishID_ = requestedPendingFishID_);
			UnknownFieldSet unknownFieldSet = (bodyOfWater._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return bodyOfWater;
		}

		[Cpp2IlInjected.Token(Token = "0x6004191")]
		[Cpp2IlInjected.Address(RVA = "0x1ABECB0", Offset = "0x1ABD6B0", VA = "0x181ABECB0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			//IL_0076: Expected O, but got I4
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
				if (object.Equals(lastFishing_, other))
				{
					bool flag = object.Equals(currentPendingFish_, other);
					if (flag && requestedFishConditionID_ == (flag ? 1 : 0) && requestedFishItemID_ == (flag ? 1 : 0))
					{
						int num2 = 0;
						if (object.Equals(location_, other))
						{
							uint? num3 = requestedPendingFishID_;
							bool flag2 = (IntPtr)(void*)num3 == (IntPtr)num2;
							if ((IntPtr)(void*)num3 == (IntPtr)num2 != flag2)
							{
								return object.Equals(_unknownFields, flag2);
							}
						}
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004192")]
		[Cpp2IlInjected.Address(RVA = "0x1ABEBB0", Offset = "0x1ABD5B0", VA = "0x181ABEBB0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BodyOfWater other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Timestamp objB = other.lastFishing_;
				if (object.Equals(lastFishing_, objB))
				{
					PendingFish objB2 = other.currentPendingFish_;
					if (object.Equals(currentPendingFish_, objB2))
					{
						int num = other.requestedFishConditionID_;
						if (requestedFishConditionID_ == num)
						{
							int num2 = other.requestedFishItemID_;
							if (requestedFishItemID_ == num2)
							{
								ActivityDataLocationFilter objB3 = other.location_;
								if (object.Equals(location_, objB3))
								{
									uint? num3 = requestedPendingFishID_;
									uint? num4 = other.requestedPendingFishID_;
									bool flag = (object)num3 == (object)num4;
									if ((object)num3 == (object)num4 != flag)
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
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004193")]
		[Cpp2IlInjected.Address(RVA = "0x1ABEF50", Offset = "0x1ABD950", VA = "0x181ABEF50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Timestamp timestamp = lastFishing_;
				int num = 0;
				if (timestamp != null)
				{
					int hashCode = timestamp.GetHashCode();
				}
				PendingFish pendingFish = currentPendingFish_;
				if (pendingFish != null)
				{
					int hashCode2 = pendingFish.GetHashCode();
				}
				if (requestedFishConditionID_ != 0)
				{
				}
				if (requestedFishItemID_ != 0)
				{
				}
				ActivityDataLocationFilter activityDataLocationFilter = location_;
				if (activityDataLocationFilter != null)
				{
					int hashCode3 = activityDataLocationFilter.GetHashCode();
				}
				uint? num2 = requestedPendingFishID_;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004194")]
		[Cpp2IlInjected.Address(RVA = "0x1ABFE40", Offset = "0x1ABE840", VA = "0x181ABFE40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004195")]
		[Cpp2IlInjected.Address(RVA = "0x1ABFF80", Offset = "0x1ABE980", VA = "0x181ABFF80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00aa
			if ((long)lastFishing_ != 0)
			{
				Timestamp value = lastFishing_;
				output.WriteMessage(value);
			}
			if ((long)currentPendingFish_ != 0)
			{
				PendingFish value2 = currentPendingFish_;
				output.WriteMessage(value2);
			}
			if (requestedFishConditionID_ != 0)
			{
				int value3 = requestedFishConditionID_;
				output.WriteInt32(value3);
			}
			if (requestedFishItemID_ != 0)
			{
				int value4 = requestedFishItemID_;
				output.WriteInt32(value4);
			}
			if ((long)location_ != 0)
			{
				ActivityDataLocationFilter value5 = location_;
				output.WriteMessage(value5);
			}
			FieldCodec<uint?> single_requestedPendingFishID_codec = _single_requestedPendingFishID_codec;
			uint? value6 = requestedPendingFishID_;
			((FieldCodec<T>)(object)single_requestedPendingFishID_codec).WriteTagAndValue(output, (T)value6);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004196")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE4A0", Offset = "0x1ABCEA0", VA = "0x181ABE4A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00d1
			Timestamp timestamp = lastFishing_;
			int num = 0;
			if (timestamp != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(timestamp);
			}
			PendingFish pendingFish = currentPendingFish_;
			if (pendingFish != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(pendingFish);
				num3++;
				num += num3;
			}
			int num4 = requestedFishConditionID_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			int num6 = requestedFishItemID_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			ActivityDataLocationFilter activityDataLocationFilter = location_;
			if (activityDataLocationFilter != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(activityDataLocationFilter);
				num8++;
				num += num8;
			}
			FieldCodec<uint?> single_requestedPendingFishID_codec = _single_requestedPendingFishID_codec;
			uint? value = requestedPendingFishID_;
			int num9 = ((FieldCodec<T>)(object)single_requestedPendingFishID_codec).CalculateSizeWithTag((T)value);
			num += num9;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num += num10;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004197")]
		[Cpp2IlInjected.Address(RVA = "0x1ABF760", Offset = "0x1ABE160", VA = "0x181ABF760", Slot = "4")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(BodyOfWater other)
		{
			//Discarded unreachable code: IL_0122
			if (other == null)
			{
				return;
			}
			if ((long)other.lastFishing_ != 0)
			{
				Timestamp timestamp = lastFishing_;
				if (timestamp == null)
				{
					Timestamp timestamp2 = (lastFishing_ = new Timestamp());
					Timestamp timestamp3 = lastFishing_;
				}
				Timestamp other2 = other.lastFishing_;
				timestamp.MergeFrom(other2);
			}
			if ((long)other.currentPendingFish_ != 0)
			{
				PendingFish pendingFish2 = default(PendingFish);
				if (currentPendingFish_ == null)
				{
					PendingFish pendingFish = (currentPendingFish_ = new PendingFish());
					pendingFish2 = currentPendingFish_;
				}
				PendingFish other3 = other.currentPendingFish_;
				pendingFish2.MergeFrom(other3);
			}
			int num = other.requestedFishConditionID_;
			if (num != 0)
			{
				requestedFishConditionID_ = num;
			}
			int num2 = other.requestedFishItemID_;
			if (num2 != 0)
			{
				requestedFishItemID_ = num2;
			}
			if ((long)other.location_ != 0)
			{
				ActivityDataLocationFilter activityDataLocationFilter2 = default(ActivityDataLocationFilter);
				if (location_ == null)
				{
					ActivityDataLocationFilter activityDataLocationFilter = (location_ = new ActivityDataLocationFilter());
					activityDataLocationFilter2 = location_;
				}
				ActivityDataLocationFilter other4 = other.location_;
				activityDataLocationFilter2.MergeFrom(other4);
			}
			uint? num3 = other.requestedPendingFishID_;
			if ((IntPtr)(((object)num3 == null) ? 1 : 0) == (IntPtr)(void*)num3)
			{
				uint? num4 = (requestedPendingFishID_ = other.requestedPendingFishID_);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004198")]
		[Cpp2IlInjected.Address(RVA = "0x1ABF4F0", Offset = "0x1ABDEF0", VA = "0x181ABF4F0", Slot = "5")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0108
			ActivityDataLocationFilter activityDataLocationFilter = default(ActivityDataLocationFilter);
			ActivityDataLocationFilter builder = default(ActivityDataLocationFilter);
			Timestamp timestamp = default(Timestamp);
			Timestamp builder2 = default(Timestamp);
			PendingFish pendingFish = default(PendingFish);
			PendingFish builder3 = default(PendingFish);
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					break;
				}
				if ((int)num > 24)
				{
					if (num == 32)
					{
						int num2 = (requestedFishItemID_ = input.ReadInt32());
					}
					if (num == 42)
					{
						if (location_ == null)
						{
							activityDataLocationFilter = (location_ = new ActivityDataLocationFilter());
							builder = location_;
						}
						input.ReadMessage(builder);
					}
					if ((long)activityDataLocationFilter != 50)
					{
						goto IL_00f1;
					}
					uint? num3 = (uint?)((FieldCodec<T>)(object)_single_requestedPendingFishID_codec).Read(input);
					if ((IntPtr)(((object)num3 == null) ? 1 : 0) != (IntPtr)(void*)num3)
					{
						continue;
					}
					requestedPendingFishID_ = num3;
				}
				if (num == 10)
				{
					if (lastFishing_ == null)
					{
						timestamp = (lastFishing_ = new Timestamp());
						builder2 = lastFishing_;
					}
					input.ReadMessage(builder2);
				}
				if ((long)timestamp == 18)
				{
					if (currentPendingFish_ == null)
					{
						pendingFish = (currentPendingFish_ = new PendingFish());
						builder3 = currentPendingFish_;
					}
					input.ReadMessage(builder3);
				}
				if ((long)pendingFish == 24)
				{
					int num4 = (requestedFishConditionID_ = input.ReadInt32());
				}
				goto IL_00f1;
				IL_00f1:
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004199")]
		[Cpp2IlInjected.Address(RVA = "0x1ABEE00", Offset = "0x1ABD800", VA = "0x181ABEE00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				Timestamp timestamp = lastFishing_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600419A")]
		[Cpp2IlInjected.Address(RVA = "0x1ABFBE0", Offset = "0x1ABE5E0", VA = "0x181ABFBE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_001c, IL_0020, IL_0028, IL_0030, IL_0038, IL_003c, IL_0040, IL_0048, IL_004c, IL_005a, IL_0060
			//IL_0017: Expected O, but got I4
			//IL_002f: Expected I4, but got O
			//IL_0037: Expected I4, but got O
			//IL_0053: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				lastFishing_ = (Timestamp)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600419B")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE670", Offset = "0x1ABD070", VA = "0x181ABE670", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0005
			if (fieldNumber > 5)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041A0")]
		[Cpp2IlInjected.Address(RVA = "0x1ABF070", Offset = "0x1ABDA70", VA = "0x181ABF070")]
		internal void Initialize(in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0115
			//IL_0081: Expected I4, but got I8
			//IL_00c3: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			IWorldEventDispatcher worldEventDispatcher = world.dispatcher;
			int num = 0;
			dispatcher = worldEventDispatcher;
			this.context = context;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num2 = requestedFishConditionID_;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag || flag2)
			{
				return;
			}
			int num3 = requestedFishItemID_;
			if ((object)requestedPendingFishID_ != null)
			{
				return;
			}
			int itemID = RequestedFishConditionItem.ItemID;
			bool flag3 = default(bool);
			if (flag3)
			{
				PendingFish pendingFish = new PendingFish();
				int num4 = (pendingFish.forcedFishingDataItemID_ = FishingData.iD_);
				pendingFish.rarity_ = FishRippleRarity.Specific;
				ActivityDataLocationFilter activityDataLocationFilter = (pendingFish.location_ = location_);
				pendingFish.isSpecific_ = true;
				ProfileWorld world_ = profile.world_;
				IWorldEventDispatcher worldEventDispatcher2 = dispatcher;
				uint num5 = world_.AddPendingFish(pendingFish, worldEventDispatcher2);
				requestedPendingFishID_ = (uint?)(object)num;
			}
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)num;
			int num6 = requestedFishConditionID_;
			int num7 = 0;
			IWorldEventDispatcher worldEventDispatcher3 = dispatcher;
			if (worldEventDispatcher3 != null)
			{
				int num8 = 0;
				if (worldEventDispatcher3 != null)
				{
					ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
				}
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
		}

		[Cpp2IlInjected.Token(Token = "0x60041A1")]
		[Cpp2IlInjected.Address(RVA = "0x1ABF940", Offset = "0x1ABE340", VA = "0x181ABF940")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_00e7
			//IL_0044: Expected I4, but got I8
			//IL_0084: Expected O, but got I8
			//IL_00af: Expected O, but got I4
			//IL_00e6: Expected O, but got I8
			bool flag = default(bool);
			ulong num4 = default(ulong);
			uint num5 = default(uint);
			do
			{
				if ((long)dispatcher == 0)
				{
					return;
				}
				int num = requestedFishConditionID_;
				if (flag)
				{
					if ((object)requestedPendingFishID_ == null)
					{
						PendingFish pendingFish = new PendingFish();
						int num2 = (pendingFish.forcedFishingDataItemID_ = FishingData.iD_);
						pendingFish.rarity_ = FishRippleRarity.Specific;
						ActivityDataLocationFilter activityDataLocationFilter = (pendingFish.location_ = location_);
						pendingFish.isSpecific_ = true;
						ProfileWorld world_ = profile.world_;
						IWorldEventDispatcher worldEventDispatcher = dispatcher;
						uint num3 = world_.AddPendingFish(pendingFish, worldEventDispatcher);
						requestedPendingFishID_ = (uint?)(object)num4;
						currentPendingFish_ = pendingFish;
					}
					return;
				}
			}
			while ((object)requestedPendingFishID_ == null || !((MapField<TKey, TValue>)(object)profile.world_.pendingFishes_).ContainsKey((TKey)num5));
			ProfileWorld world_2 = profile.world_;
			uint? num6 = requestedPendingFishID_;
			IWorldEventDispatcher worldEventDispatcher2 = dispatcher;
			uint pendingFishID = default(uint);
			world_2.RemovePendingFish(pendingFishID, worldEventDispatcher2);
			requestedPendingFishID_ = (uint?)(object)0;
		}

		[Cpp2IlInjected.Token(Token = "0x60041A2")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE810", Offset = "0x1ABD210", VA = "0x181ABE810")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)requestedFishConditionID_);
			int num3 = 0;
			IWorldEventDispatcher worldEventDispatcher = dispatcher;
			if (worldEventDispatcher != null)
			{
				int num4 = 0;
				if (worldEventDispatcher != null)
				{
					ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
				}
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041A3")]
		[Cpp2IlInjected.Address(RVA = "0x1ABEB80", Offset = "0x1ABD580", VA = "0x181ABEB80")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041A4")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE9A0", Offset = "0x1ABD3A0", VA = "0x181ABE9A0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0043
			//IL_0038: Expected O, but got I8
			//IL_0038: Expected O, but got I8
			int num = requestedFishItemID_;
			bool flag = default(bool);
			if (flag && FishingData == null)
			{
				long num2 = Convert.ToInt64((uint)requestedFishItemID_);
				long num3 = Convert.ToInt64((uint)requestedFishItemID_);
				string error = $"[BodyOfWater] Selected fish have no entry in ActivityData.FishingData (ID: {num2}, Name: {num3})";
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041A5")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0120", Offset = "0x1ABEB20", VA = "0x181AC0120")]
		static BodyOfWater()
		{
			Func<BodyOfWater> func = default(Func<BodyOfWater>);
			_parser = (MessageParser<BodyOfWater>)(object)new MessageParser<T>((Func<>)(object)func);
			uint num = default(uint);
			_parser = (MessageParser<BodyOfWater>)(object)FieldCodec.ForStructWrapper<uint>(num);
			/*Error: Unexpected end of block*/;
		}
	}
}
