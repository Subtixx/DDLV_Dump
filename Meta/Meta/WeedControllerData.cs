using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008BC")]
	public sealed class WeedControllerData : IMessage<WeedControllerData>, IMessage, IEquatable<WeedControllerData>, IDeepCloneable<WeedControllerData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002320")]
		private static readonly MessageParser<WeedControllerData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002321")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002322")]
		public const int TreasureDefaultProbabilityFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002323")]
		private int treasureDefaultProbability_;

		[Cpp2IlInjected.Token(Token = "0x4002324")]
		public const int TreasureMinDistanceFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002325")]
		private int treasureMinDistance_;

		[Cpp2IlInjected.Token(Token = "0x4002326")]
		public const int TreasureMaxDistanceFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002327")]
		private int treasureMaxDistance_;

		[Cpp2IlInjected.Token(Token = "0x4002328")]
		public const int TimeBetweenMinigamesFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002329")]
		private Duration timeBetweenMinigames_;

		[Cpp2IlInjected.Token(Token = "0x400232A")]
		public const int MinigameProbabilityFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400232B")]
		private int minigameProbability_;

		[Cpp2IlInjected.Token(Token = "0x400232C")]
		public const int MinigameDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400232D")]
		private ItemCollectMinigameData minigameData_;

		[Cpp2IlInjected.Token(Token = "0x17000C7E")]
		[DebuggerNonUserCode]
		public static MessageParser<WeedControllerData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004A7A")]
			[Cpp2IlInjected.Address(RVA = "0x15E6950", Offset = "0x15E5350", VA = "0x1815E6950")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C7F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004A7B")]
			[Cpp2IlInjected.Address(RVA = "0x15E6880", Offset = "0x15E5280", VA = "0x1815E6880")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C80")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004A7C")]
			[Cpp2IlInjected.Address(RVA = "0x15E69B0", Offset = "0x15E53B0", VA = "0x1815E69B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C81")]
		[DebuggerNonUserCode]
		public int TreasureDefaultProbability
		{
			[Cpp2IlInjected.Token(Token = "0x6004A81")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return treasureDefaultProbability_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A82")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				treasureDefaultProbability_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C82")]
		[DebuggerNonUserCode]
		public int TreasureMinDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6004A83")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return treasureMinDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A84")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				treasureMinDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C83")]
		[DebuggerNonUserCode]
		public int TreasureMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6004A85")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return treasureMaxDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A86")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				treasureMaxDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C84")]
		[DebuggerNonUserCode]
		public Duration TimeBetweenMinigames
		{
			[Cpp2IlInjected.Token(Token = "0x6004A87")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return timeBetweenMinigames_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A88")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				timeBetweenMinigames_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C85")]
		[DebuggerNonUserCode]
		public int MinigameProbability
		{
			[Cpp2IlInjected.Token(Token = "0x6004A89")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return minigameProbability_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A8A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				minigameProbability_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C86")]
		[DebuggerNonUserCode]
		public ItemCollectMinigameData MinigameData
		{
			[Cpp2IlInjected.Token(Token = "0x6004A8B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return minigameData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004A8C")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				minigameData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A7D")]
		[Cpp2IlInjected.Address(RVA = "0x15E6690", Offset = "0x15E5090", VA = "0x1815E6690")]
		[DebuggerNonUserCode]
		public WeedControllerData()
		{
			Duration duration = (timeBetweenMinigames_ = new Duration());
			ItemCollectMinigameData itemCollectMinigameData = (minigameData_ = new ItemCollectMinigameData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A7E")]
		[Cpp2IlInjected.Address(RVA = "0x15E6150", Offset = "0x15E4B50", VA = "0x1815E6150")]
		private void OnConstruction()
		{
			Duration duration = (timeBetweenMinigames_ = new Duration());
			ItemCollectMinigameData itemCollectMinigameData = (minigameData_ = new ItemCollectMinigameData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A7F")]
		[Cpp2IlInjected.Address(RVA = "0x15E6730", Offset = "0x15E5130", VA = "0x1815E6730")]
		[DebuggerNonUserCode]
		public WeedControllerData(WeedControllerData other)
		{
			//IL_006d: Expected O, but got I4
			Duration duration = (timeBetweenMinigames_ = new Duration());
			ItemCollectMinigameData itemCollectMinigameData = (minigameData_ = new ItemCollectMinigameData());
			int num = other.treasureDefaultProbability_;
			int num2 = 0;
			treasureDefaultProbability_ = num;
			int num3 = (treasureMinDistance_ = other.treasureMinDistance_);
			int num4 = (treasureMaxDistance_ = other.treasureMaxDistance_);
			Duration duration2 = other.timeBetweenMinigames_;
			if (duration2 != null)
			{
				Duration duration3 = duration2.Clone();
			}
			timeBetweenMinigames_ = (Duration)num2;
			int num5 = (minigameProbability_ = other.minigameProbability_);
			ItemCollectMinigameData itemCollectMinigameData2 = other.minigameData_;
			ItemCollectMinigameData itemCollectMinigameData3 = default(ItemCollectMinigameData);
			if (itemCollectMinigameData2 != null)
			{
				itemCollectMinigameData3 = itemCollectMinigameData2.Clone();
			}
			minigameData_ = itemCollectMinigameData3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A80")]
		[Cpp2IlInjected.Address(RVA = "0x15E5960", Offset = "0x15E4360", VA = "0x1815E5960", Slot = "10")]
		[DebuggerNonUserCode]
		public WeedControllerData Clone()
		{
			//Discarded unreachable code: IL_00b4
			//IL_006f: Expected O, but got I4
			WeedControllerData weedControllerData = new WeedControllerData();
			Duration duration = (weedControllerData.timeBetweenMinigames_ = new Duration());
			ItemCollectMinigameData itemCollectMinigameData = (weedControllerData.minigameData_ = new ItemCollectMinigameData());
			int num = treasureDefaultProbability_;
			int num2 = 0;
			weedControllerData.treasureDefaultProbability_ = num;
			int num3 = (weedControllerData.treasureMinDistance_ = treasureMinDistance_);
			int num4 = (weedControllerData.treasureMaxDistance_ = treasureMaxDistance_);
			Duration duration2 = timeBetweenMinigames_;
			if (duration2 != null)
			{
				Duration duration3 = duration2.Clone();
			}
			weedControllerData.timeBetweenMinigames_ = (Duration)num2;
			int num5 = (weedControllerData.minigameProbability_ = minigameProbability_);
			ItemCollectMinigameData itemCollectMinigameData2 = minigameData_;
			ItemCollectMinigameData itemCollectMinigameData3 = default(ItemCollectMinigameData);
			if (itemCollectMinigameData2 != null)
			{
				itemCollectMinigameData3 = itemCollectMinigameData2.Clone();
			}
			weedControllerData.minigameData_ = itemCollectMinigameData3;
			UnknownFieldSet unknownFieldSet = (weedControllerData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return weedControllerData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A8D")]
		[Cpp2IlInjected.Address(RVA = "0x15E5B80", Offset = "0x15E4580", VA = "0x1815E5B80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)treasureDefaultProbability_ == (IntPtr)typeof(WeedControllerData).TypeHandle && (IntPtr)treasureMinDistance_ == (IntPtr)typeof(WeedControllerData).TypeHandle && (IntPtr)treasureMaxDistance_ == (IntPtr)typeof(WeedControllerData).TypeHandle)
				{
					bool flag = object.Equals(timeBetweenMinigames_, other);
					if (flag && minigameProbability_ == (flag ? 1 : 0) && object.Equals(minigameData_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A8E")]
		[Cpp2IlInjected.Address(RVA = "0x15E5AE0", Offset = "0x15E44E0", VA = "0x1815E5AE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WeedControllerData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.treasureDefaultProbability_;
				if (treasureDefaultProbability_ == num)
				{
					int num2 = other.treasureMinDistance_;
					if (treasureMinDistance_ == num2)
					{
						int num3 = other.treasureMaxDistance_;
						if (treasureMaxDistance_ == num3)
						{
							Duration objB = other.timeBetweenMinigames_;
							if (object.Equals(timeBetweenMinigames_, objB))
							{
								int num4 = other.minigameProbability_;
								if (minigameProbability_ == num4)
								{
									ItemCollectMinigameData objB2 = other.minigameData_;
									if (object.Equals(minigameData_, objB2))
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

		[Cpp2IlInjected.Token(Token = "0x6004A8F")]
		[Cpp2IlInjected.Address(RVA = "0x15E5D70", Offset = "0x15E4770", VA = "0x1815E5D70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (treasureDefaultProbability_ != 0)
				{
				}
				if (treasureMinDistance_ != 0)
				{
				}
				if (treasureMaxDistance_ != 0)
				{
				}
				Duration duration = timeBetweenMinigames_;
				if (duration != null)
				{
					int hashCode = duration.GetHashCode();
				}
				if (minigameProbability_ != 0)
				{
				}
				ItemCollectMinigameData itemCollectMinigameData = minigameData_;
				if (itemCollectMinigameData != null)
				{
					int hashCode2 = itemCollectMinigameData.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004A90")]
		[Cpp2IlInjected.Address(RVA = "0x15E63F0", Offset = "0x15E4DF0", VA = "0x1815E63F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A91")]
		[Cpp2IlInjected.Address(RVA = "0x15E6450", Offset = "0x15E4E50", VA = "0x1815E6450", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a8
			if (treasureDefaultProbability_ != 0)
			{
				int value = treasureDefaultProbability_;
				output.WriteInt32(value);
			}
			if (treasureMinDistance_ != 0)
			{
				int value2 = treasureMinDistance_;
				output.WriteInt32(value2);
			}
			if (treasureMaxDistance_ != 0)
			{
				int value3 = treasureMaxDistance_;
				output.WriteInt32(value3);
			}
			if ((long)timeBetweenMinigames_ != 0)
			{
				Duration value4 = timeBetweenMinigames_;
				output.WriteMessage(value4);
			}
			if (minigameProbability_ != 0)
			{
				int value5 = minigameProbability_;
				output.WriteInt32(value5);
			}
			if ((long)minigameData_ != 0)
			{
				ItemCollectMinigameData value6 = minigameData_;
				output.WriteMessage(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004A92")]
		[Cpp2IlInjected.Address(RVA = "0x15E5740", Offset = "0x15E4140", VA = "0x1815E5740", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = treasureDefaultProbability_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = treasureMinDistance_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = treasureMaxDistance_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				Duration duration = timeBetweenMinigames_;
				if (duration != null)
				{
					int num8 = CodedOutputStream.ComputeMessageSize(duration);
					num8++;
					num2 += num8;
				}
				int num9 = minigameProbability_;
				if (num9 != 0)
				{
					int num10 = CodedOutputStream.ComputeInt32Size(num9);
					num10++;
					num2 += num10;
				}
				ItemCollectMinigameData itemCollectMinigameData = minigameData_;
				if (itemCollectMinigameData != null)
				{
					int num11 = CodedOutputStream.ComputeMessageSize(itemCollectMinigameData);
					num11++;
					num2 += num11;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num12 = unknownFields.CalculateSize();
			return num12 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A93")]
		[Cpp2IlInjected.Address(RVA = "0x15E6000", Offset = "0x15E4A00", VA = "0x1815E6000", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WeedControllerData other)
		{
			//Discarded unreachable code: IL_00e8
			if (other == null)
			{
				return;
			}
			int num = other.treasureDefaultProbability_;
			if (num != 0)
			{
				treasureDefaultProbability_ = num;
			}
			int num2 = other.treasureMinDistance_;
			if (num2 != 0)
			{
				treasureMinDistance_ = num2;
			}
			int num3 = other.treasureMaxDistance_;
			if (num3 != 0)
			{
				treasureMaxDistance_ = num3;
			}
			if ((long)other.timeBetweenMinigames_ != 0)
			{
				Duration duration2 = default(Duration);
				if (timeBetweenMinigames_ == null)
				{
					Duration duration = (timeBetweenMinigames_ = new Duration());
					duration2 = timeBetweenMinigames_;
				}
				Duration other2 = other.timeBetweenMinigames_;
				duration2.MergeFrom(other2);
			}
			int num4 = other.minigameProbability_;
			if (num4 != 0)
			{
				minigameProbability_ = num4;
			}
			if ((long)other.minigameData_ != 0)
			{
				ItemCollectMinigameData itemCollectMinigameData2 = default(ItemCollectMinigameData);
				if (minigameData_ == null)
				{
					ItemCollectMinigameData itemCollectMinigameData = (minigameData_ = new ItemCollectMinigameData());
					itemCollectMinigameData2 = minigameData_;
				}
				ItemCollectMinigameData other3 = other.minigameData_;
				itemCollectMinigameData2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004A94")]
		[Cpp2IlInjected.Address(RVA = "0x15E5E60", Offset = "0x15E4860", VA = "0x1815E5E60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00d3
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 34)
				{
					Duration duration = timeBetweenMinigames_;
					if (duration == null)
					{
						Duration duration2 = (timeBetweenMinigames_ = new Duration());
					}
					input.ReadMessage(duration);
				}
				int num2 = default(int);
				if (num == 40)
				{
					num2 = (minigameProbability_ = input.ReadInt32());
				}
				if (num2 != 50)
				{
					goto IL_00bc;
				}
				ItemCollectMinigameData builder = default(ItemCollectMinigameData);
				if (minigameData_ == null)
				{
					ItemCollectMinigameData itemCollectMinigameData = (minigameData_ = new ItemCollectMinigameData());
					builder = minigameData_;
				}
				input.ReadMessage(builder);
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (treasureDefaultProbability_ = input.ReadInt32());
			}
			int num4 = default(int);
			if (num3 == 16)
			{
				num4 = (treasureMinDistance_ = input.ReadInt32());
			}
			if (num4 == 24)
			{
				int num5 = (treasureMaxDistance_ = input.ReadInt32());
			}
			goto IL_00bc;
			IL_00bc:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004A95")]
		[Cpp2IlInjected.Address(RVA = "0x15E5C60", Offset = "0x15E4660", VA = "0x1815E5C60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				int num = treasureDefaultProbability_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A96")]
		[Cpp2IlInjected.Address(RVA = "0x15E61E0", Offset = "0x15E4BE0", VA = "0x1815E61E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_0016, IL_001e, IL_0028, IL_0029, IL_002f, IL_0035, IL_003b
			//IL_000d: Expected I4, but got O
			//IL_0015: Expected I4, but got O
			//IL_001d: Expected I4, but got O
			//IL_0027: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				treasureDefaultProbability_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A97")]
		[Cpp2IlInjected.Address(RVA = "0x15E58E0", Offset = "0x15E42E0", VA = "0x1815E58E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber <= 5)
			{
				treasureDefaultProbability_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004A98")]
		[Cpp2IlInjected.Address(RVA = "0x15E6580", Offset = "0x15E4F80", VA = "0x1815E6580")]
		static WeedControllerData()
		{
			Func<WeedControllerData> func = default(Func<WeedControllerData>);
			_parser = (MessageParser<WeedControllerData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
