using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002E4")]
	public sealed class BenefitsHouseData : IMessage<BenefitsHouseData>, IMessage, IEquatable<BenefitsHouseData>, IDeepCloneable<BenefitsHouseData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000D3D")]
		private static readonly MessageParser<BenefitsHouseData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D3E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000D3F")]
		public const int HomeStorageSizeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000D40")]
		private int homeStorageSize_;

		[Cpp2IlInjected.Token(Token = "0x4000D41")]
		public const int ManaRecoveryPerTickFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000D42")]
		private int manaRecoveryPerTick_;

		[Cpp2IlInjected.Token(Token = "0x4000D43")]
		public const int ExpansionLimitsRoomsFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000D44")]
		private int expansionLimitsRooms_;

		[Cpp2IlInjected.Token(Token = "0x4000D45")]
		public const int ExpansionLimitsFloorsFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000D46")]
		private int expansionLimitsFloors_;

		[Cpp2IlInjected.Token(Token = "0x4000D47")]
		public const int CanReplaceWithSkinsFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000D48")]
		private bool canReplaceWithSkins_;

		[Cpp2IlInjected.Token(Token = "0x1700074C")]
		[DebuggerNonUserCode]
		public static MessageParser<BenefitsHouseData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001F87")]
			[Cpp2IlInjected.Address(RVA = "0x32E4FA0", Offset = "0x32E39A0", VA = "0x1832E4FA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F88")]
			[Cpp2IlInjected.Address(RVA = "0x32E4ED0", Offset = "0x32E38D0", VA = "0x1832E4ED0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F89")]
			[Cpp2IlInjected.Address(RVA = "0x32E5000", Offset = "0x32E3A00", VA = "0x1832E5000", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074F")]
		[DebuggerNonUserCode]
		public int HomeStorageSize
		{
			[Cpp2IlInjected.Token(Token = "0x6001F8D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return homeStorageSize_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F8E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				homeStorageSize_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000750")]
		[DebuggerNonUserCode]
		public int ManaRecoveryPerTick
		{
			[Cpp2IlInjected.Token(Token = "0x6001F8F")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return manaRecoveryPerTick_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F90")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				manaRecoveryPerTick_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000751")]
		[DebuggerNonUserCode]
		public int ExpansionLimitsRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6001F91")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return expansionLimitsRooms_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F92")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				expansionLimitsRooms_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000752")]
		[DebuggerNonUserCode]
		public int ExpansionLimitsFloors
		{
			[Cpp2IlInjected.Token(Token = "0x6001F93")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return expansionLimitsFloors_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F94")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				expansionLimitsFloors_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000753")]
		[DebuggerNonUserCode]
		public bool CanReplaceWithSkins
		{
			[Cpp2IlInjected.Token(Token = "0x6001F95")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return canReplaceWithSkins_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F96")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				canReplaceWithSkins_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F8A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BenefitsHouseData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001F8B")]
		[Cpp2IlInjected.Address(RVA = "0x207E0F0", Offset = "0x207CAF0", VA = "0x18207E0F0")]
		[DebuggerNonUserCode]
		public BenefitsHouseData(BenefitsHouseData other)
		{
			int num = (homeStorageSize_ = other.homeStorageSize_);
			int num2 = (manaRecoveryPerTick_ = other.manaRecoveryPerTick_);
			int num3 = (expansionLimitsRooms_ = other.expansionLimitsRooms_);
			int num4 = (expansionLimitsFloors_ = other.expansionLimitsFloors_);
			bool flag = (canReplaceWithSkins_ = other.canReplaceWithSkins_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F8C")]
		[Cpp2IlInjected.Address(RVA = "0x32E4940", Offset = "0x32E3340", VA = "0x1832E4940", Slot = "10")]
		[DebuggerNonUserCode]
		public BenefitsHouseData Clone()
		{
			//Discarded unreachable code: IL_0067
			BenefitsHouseData benefitsHouseData = new BenefitsHouseData();
			int num = (benefitsHouseData.homeStorageSize_ = homeStorageSize_);
			int num2 = (benefitsHouseData.manaRecoveryPerTick_ = manaRecoveryPerTick_);
			int num3 = (benefitsHouseData.expansionLimitsRooms_ = expansionLimitsRooms_);
			int num4 = (benefitsHouseData.expansionLimitsFloors_ = expansionLimitsFloors_);
			bool flag = (benefitsHouseData.canReplaceWithSkins_ = canReplaceWithSkins_);
			UnknownFieldSet unknownFieldSet = (benefitsHouseData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return benefitsHouseData;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F97")]
		[Cpp2IlInjected.Address(RVA = "0x32E49E0", Offset = "0x32E33E0", VA = "0x1832E49E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)homeStorageSize_ == (IntPtr)typeof(BenefitsHouseData).TypeHandle && (IntPtr)manaRecoveryPerTick_ == (IntPtr)typeof(BenefitsHouseData).TypeHandle && (IntPtr)expansionLimitsRooms_ == (IntPtr)typeof(BenefitsHouseData).TypeHandle && (IntPtr)expansionLimitsFloors_ == (IntPtr)typeof(BenefitsHouseData).TypeHandle && (IntPtr)(canReplaceWithSkins_ ? 1 : 0) == (IntPtr)typeof(BenefitsHouseData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F98")]
		[Cpp2IlInjected.Address(RVA = "0x207D900", Offset = "0x207C300", VA = "0x18207D900", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BenefitsHouseData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.homeStorageSize_;
				if (homeStorageSize_ == num)
				{
					int num2 = other.manaRecoveryPerTick_;
					if (manaRecoveryPerTick_ == num2)
					{
						int num3 = other.expansionLimitsRooms_;
						if (expansionLimitsRooms_ == num3)
						{
							int num4 = other.expansionLimitsFloors_;
							if (expansionLimitsFloors_ == num4)
							{
								bool flag = other.canReplaceWithSkins_;
								if (canReplaceWithSkins_ == flag)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F99")]
		[Cpp2IlInjected.Address(RVA = "0x207DA60", Offset = "0x207C460", VA = "0x18207DA60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (homeStorageSize_ != 0)
				{
				}
				if (manaRecoveryPerTick_ != 0)
				{
				}
				if (expansionLimitsRooms_ != 0)
				{
				}
				if (expansionLimitsFloors_ != 0)
				{
				}
				if (canReplaceWithSkins_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9A")]
		[Cpp2IlInjected.Address(RVA = "0x32E4D60", Offset = "0x32E3760", VA = "0x1832E4D60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9B")]
		[Cpp2IlInjected.Address(RVA = "0x207DEE0", Offset = "0x207C8E0", VA = "0x18207DEE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_008b
			if (homeStorageSize_ != 0)
			{
				int value = homeStorageSize_;
				output.WriteInt32(value);
			}
			if (manaRecoveryPerTick_ != 0)
			{
				int value2 = manaRecoveryPerTick_;
				output.WriteInt32(value2);
			}
			if (expansionLimitsRooms_ != 0)
			{
				int value3 = expansionLimitsRooms_;
				output.WriteInt32(value3);
			}
			if (expansionLimitsFloors_ != 0)
			{
				int value4 = expansionLimitsFloors_;
				output.WriteInt32(value4);
			}
			if (canReplaceWithSkins_)
			{
				bool value5 = canReplaceWithSkins_;
				output.WriteBool(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9C")]
		[Cpp2IlInjected.Address(RVA = "0x32E4800", Offset = "0x32E3200", VA = "0x1832E4800", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = homeStorageSize_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = manaRecoveryPerTick_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = expansionLimitsRooms_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				int num8 = expansionLimitsFloors_;
				if (num8 != 0)
				{
					int num9 = CodedOutputStream.ComputeInt32Size(num8);
					num9++;
					num2 += num9;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num10 = unknownFields.CalculateSize();
			return num10 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9D")]
		[Cpp2IlInjected.Address(RVA = "0x207DC20", Offset = "0x207C620", VA = "0x18207DC20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BenefitsHouseData other)
		{
			if (other != null)
			{
				int num = other.homeStorageSize_;
				if (num != 0)
				{
					homeStorageSize_ = num;
				}
				int num2 = other.manaRecoveryPerTick_;
				if (num2 != 0)
				{
					manaRecoveryPerTick_ = num2;
				}
				int num3 = other.expansionLimitsRooms_;
				if (num3 != 0)
				{
					expansionLimitsRooms_ = num3;
				}
				int num4 = other.expansionLimitsFloors_;
				if (num4 != 0)
				{
					expansionLimitsFloors_ = num4;
				}
				bool flag = other.canReplaceWithSkins_;
				if (flag)
				{
					canReplaceWithSkins_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9E")]
		[Cpp2IlInjected.Address(RVA = "0x207DB40", Offset = "0x207C540", VA = "0x18207DB40", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0092
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 24)
				{
					int num2 = (expansionLimitsRooms_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 32)
				{
					num3 = (expansionLimitsFloors_ = input.ReadInt32());
				}
				if (num3 != 40)
				{
					goto IL_007b;
				}
				bool flag = (canReplaceWithSkins_ = input.ReadBool());
			}
			int num4 = default(int);
			if (num == 8)
			{
				num4 = (homeStorageSize_ = input.ReadInt32());
			}
			if (num4 == 16)
			{
				int num5 = (manaRecoveryPerTick_ = input.ReadInt32());
			}
			goto IL_007b;
			IL_007b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9F")]
		[Cpp2IlInjected.Address(RVA = "0x32E4A90", Offset = "0x32E3490", VA = "0x1832E4A90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_0026;
				}
				bool flag = canReplaceWithSkins_;
			}
			int num2 = homeStorageSize_;
			goto IL_0026;
			IL_0026:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA0")]
		[Cpp2IlInjected.Address(RVA = "0x32E4BA0", Offset = "0x32E35A0", VA = "0x1832E4BA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0042
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			//IL_002f: Expected I4, but got O
			//IL_0038: Expected I4, but got O
			//IL_0041: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							object obj2 = default(object);
							canReplaceWithSkins_ = (byte)(int)obj2 != 0;
							break;
						}
						case 0:
						{
							object obj = default(object);
							expansionLimitsFloors_ = (int)obj;
							break;
						}
						}
					}
					else
					{
						object obj3 = default(object);
						expansionLimitsRooms_ = (int)obj3;
					}
				}
				else
				{
					object obj4 = default(object);
					manaRecoveryPerTick_ = (int)obj4;
				}
			}
			else
			{
				object obj5 = default(object);
				homeStorageSize_ = (int)obj5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA1")]
		[Cpp2IlInjected.Address(RVA = "0x207D2A0", Offset = "0x207BCA0", VA = "0x18207D2A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016, IL_0020, IL_002a
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			//IL_0029: Expected I4, but got I8
			//IL_0033: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				canReplaceWithSkins_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA2")]
		[Cpp2IlInjected.Address(RVA = "0x32E4DC0", Offset = "0x32E37C0", VA = "0x1832E4DC0")]
		static BenefitsHouseData()
		{
			Func<BenefitsHouseData> func = default(Func<BenefitsHouseData>);
			_parser = (MessageParser<BenefitsHouseData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
