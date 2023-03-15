using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x200088D")]
	public sealed class GardenData : IGridStateData, IGridStateDailyResetNotify, IGridStateNeedInitialize, IMessage<GardenData>, IMessage, IEquatable<GardenData>, IDeepCloneable<GardenData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200088E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200088F")]
			public sealed class GardeningSlot : IMessage<GardeningSlot>, IMessage, IEquatable<GardeningSlot>, IDeepCloneable<GardeningSlot>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000890")]
				public enum StateOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x4002A33")]
					None = 0,
					[Cpp2IlInjected.Token(Token = "0x4002A34")]
					Sapling = 3,
					[Cpp2IlInjected.Token(Token = "0x4002A35")]
					Harvest = 4
				}

				[Cpp2IlInjected.Token(Token = "0x4002A28")]
				private static readonly MessageParser<GardeningSlot> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002A29")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002A2A")]
				public const int PlantedSeedItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002A2B")]
				private int plantedSeedItemID_;

				[Cpp2IlInjected.Token(Token = "0x4002A2C")]
				public const int LastActivityFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002A2D")]
				private Timestamp lastActivity_;

				[Cpp2IlInjected.Token(Token = "0x4002A2E")]
				public const int SaplingFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4002A2F")]
				public const int HarvestFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002A30")]
				private object state_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002A31")]
				private StateOneofCase stateCase_;

				[Cpp2IlInjected.Token(Token = "0x1700180A")]
				public Item PlantedSeedItem
				{
					[Cpp2IlInjected.Token(Token = "0x6005FAD")]
					[Cpp2IlInjected.Address(RVA = "0x2942170", Offset = "0x2940B70", VA = "0x182942170")]
					get
					{
						return default(Item);
					}
					[Cpp2IlInjected.Token(Token = "0x6005FAE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700180B")]
				public object State
				{
					[Cpp2IlInjected.Token(Token = "0x6005FAF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700180C")]
				[DebuggerNonUserCode]
				public static MessageParser<GardeningSlot> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005FB0")]
					[Cpp2IlInjected.Address(RVA = "0x2942110", Offset = "0x2940B10", VA = "0x182942110")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700180D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005FB1")]
					[Cpp2IlInjected.Address(RVA = "0x2942030", Offset = "0x2940A30", VA = "0x182942030")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700180E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005FB2")]
					[Cpp2IlInjected.Address(RVA = "0x2942230", Offset = "0x2940C30", VA = "0x182942230", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700180F")]
				[DebuggerNonUserCode]
				public int PlantedSeedItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6005FB6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6005FB7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001810")]
				[DebuggerNonUserCode]
				public Timestamp LastActivity
				{
					[Cpp2IlInjected.Token(Token = "0x6005FB8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005FB9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001811")]
				[DebuggerNonUserCode]
				public SaplingGrowthData Sapling
				{
					[Cpp2IlInjected.Token(Token = "0x6005FBA")]
					[Cpp2IlInjected.Address(RVA = "0x29421D0", Offset = "0x2940BD0", VA = "0x1829421D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005FBB")]
					[Cpp2IlInjected.Address(RVA = "0x24CC990", Offset = "0x24CB390", VA = "0x1824CC990")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001812")]
				[DebuggerNonUserCode]
				public TreeAndBushData Harvest
				{
					[Cpp2IlInjected.Token(Token = "0x6005FBC")]
					[Cpp2IlInjected.Address(RVA = "0x29420B0", Offset = "0x2940AB0", VA = "0x1829420B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005FBD")]
					[Cpp2IlInjected.Address(RVA = "0x1AC4270", Offset = "0x1AC2C70", VA = "0x181AC4270")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001813")]
				[DebuggerNonUserCode]
				public StateOneofCase StateCase
				{
					[Cpp2IlInjected.Token(Token = "0x6005FBE")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(StateOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005FB3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public GardeningSlot()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FB4")]
				[Cpp2IlInjected.Address(RVA = "0x2941EC0", Offset = "0x29408C0", VA = "0x182941EC0")]
				[DebuggerNonUserCode]
				public GardeningSlot(GardeningSlot other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FB5")]
				[Cpp2IlInjected.Address(RVA = "0x2940F60", Offset = "0x293F960", VA = "0x182940F60", Slot = "10")]
				[DebuggerNonUserCode]
				public GardeningSlot Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005FBF")]
				[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
				[DebuggerNonUserCode]
				public void ClearState()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC0")]
				[Cpp2IlInjected.Address(RVA = "0x2940FC0", Offset = "0x293F9C0", VA = "0x182940FC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC1")]
				[Cpp2IlInjected.Address(RVA = "0x29410E0", Offset = "0x293FAE0", VA = "0x1829410E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(GardeningSlot other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC2")]
				[Cpp2IlInjected.Address(RVA = "0x29412D0", Offset = "0x293FCD0", VA = "0x1829412D0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC3")]
				[Cpp2IlInjected.Address(RVA = "0x2941BD0", Offset = "0x29405D0", VA = "0x182941BD0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC4")]
				[Cpp2IlInjected.Address(RVA = "0x2941C30", Offset = "0x2940630", VA = "0x182941C30", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC5")]
				[Cpp2IlInjected.Address(RVA = "0x2940CD0", Offset = "0x293F6D0", VA = "0x182940CD0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC6")]
				[Cpp2IlInjected.Address(RVA = "0x2941770", Offset = "0x2940170", VA = "0x182941770", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(GardeningSlot other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC7")]
				[Cpp2IlInjected.Address(RVA = "0x29414E0", Offset = "0x293FEE0", VA = "0x1829414E0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC8")]
				[Cpp2IlInjected.Address(RVA = "0x29411D0", Offset = "0x293FBD0", VA = "0x1829411D0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005FC9")]
				[Cpp2IlInjected.Address(RVA = "0x2941A30", Offset = "0x2940430", VA = "0x182941A30", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FCA")]
				[Cpp2IlInjected.Address(RVA = "0x2940E90", Offset = "0x293F890", VA = "0x182940E90", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005FCB")]
				[Cpp2IlInjected.Address(RVA = "0x2941430", Offset = "0x293FE30", VA = "0x182941430", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005FCC")]
				[Cpp2IlInjected.Address(RVA = "0x2940EF0", Offset = "0x293F8F0", VA = "0x182940EF0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002A23")]
		private static readonly MessageParser<GardenData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A24")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A25")]
		public const int SlotsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002A26")]
		private static readonly FieldCodec<Types.GardeningSlot> _repeated_slots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A27")]
		private readonly RepeatedField<Types.GardeningSlot> slots_;

		[Cpp2IlInjected.Token(Token = "0x17001806")]
		[DebuggerNonUserCode]
		public static MessageParser<GardenData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005F98")]
			[Cpp2IlInjected.Address(RVA = "0x218F590", Offset = "0x218DF90", VA = "0x18218F590")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001807")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F99")]
			[Cpp2IlInjected.Address(RVA = "0x218F4C0", Offset = "0x218DEC0", VA = "0x18218F4C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001808")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F9A")]
			[Cpp2IlInjected.Address(RVA = "0x218F5F0", Offset = "0x218DFF0", VA = "0x18218F5F0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001809")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.GardeningSlot> Slots
		{
			[Cpp2IlInjected.Token(Token = "0x6005F9E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F96")]
		[Cpp2IlInjected.Address(RVA = "0x218E970", Offset = "0x218D370", VA = "0x18218E970")]
		public GridStateDailyResetResult ExecuteDailyReset(Item item, in WorldProfile worldProfile, Random random, ITransactionContext context)
		{
			IProfileWorld profileWorld = worldProfile.Section;
			DateTime dateTime = default(DateTime);
			DateTime localTime = dateTime;
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			bool flag = default(bool);
			GardenItemData gardenItemData = default(GardenItemData);
			if (flag && gardenItemData.expires_)
			{
				RepeatedField<Types.GardeningSlot> repeatedField = slots_;
				Func<Types.GardeningSlot, bool> func = (Func<Types.GardeningSlot, bool>)(object)(Func<T, TResult>)delegate(Types.GardeningSlot x)
				{
					//Discarded unreachable code: IL_003f
					DateTime dateTime5 = localTime;
					IProfileWorld profileWorld3 = profileWorld;
					DateTime dateTime6 = x.lastActivity_.ToDateTime();
					DateTime dateTime7 = default(DateTime);
					TimeSpan timeSpan3 = dateTime5 - dateTime7;
					TimeSpan timeSpan4 = gardenItemData.expirationDuration_.ToTimeSpan();
					return timeSpan3 > timeSpan4;
				};
				if (((IEnumerable<>)(object)repeatedField).All<Types.GardeningSlot>((Func<, >)(object)func))
				{
					goto IL_0082;
				}
			}
			RepeatedField<Types.GardeningSlot> repeatedField2 = slots_;
			GardeningData gardeningData = default(GardeningData);
			Func<Types.GardeningSlot, bool> func2 = (Func<Types.GardeningSlot, bool>)(object)(Func<T, TResult>)delegate(Types.GardeningSlot x)
			{
				//Discarded unreachable code: IL_004b
				if ((object)x.PlantedSeedItem == null)
				{
				}
				Timestamp lastActivity_ = x.lastActivity_;
				DateTime dateTime2 = localTime;
				IProfileWorld profileWorld2 = profileWorld;
				DateTime dateTime3 = lastActivity_.ToDateTime();
				DateTime dateTime4 = default(DateTime);
				TimeSpan timeSpan = dateTime2 - dateTime4;
				TimeSpan timeSpan2 = gardeningData.emptyGardeningSlotExpiration_.ToTimeSpan();
				return timeSpan > timeSpan2;
			};
			if (!((IEnumerable<>)(object)repeatedField2).All<Types.GardeningSlot>((Func<, >)(object)func2))
			{
				int num = 0;
			}
			goto IL_0082;
			IL_0082:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F97")]
		[Cpp2IlInjected.Address(RVA = "0x218ED10", Offset = "0x218D710", VA = "0x18218ED10")]
		public void Initialize(IItemData itemData, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_001b, IL_0021
			RepeatedField<Types.GardeningSlot> repeatedField = slots_;
			bool flag = default(bool);
			if (flag)
			{
				SeedItemData seedItemData = default(SeedItemData);
				while (seedItemData == null)
				{
				}
				if (seedItemData != null)
				{
				}
				while (seedItemData == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F9B")]
		[Cpp2IlInjected.Address(RVA = "0x218F440", Offset = "0x218DE40", VA = "0x18218F440")]
		[DebuggerNonUserCode]
		public GardenData()
		{
			slots_ = (RepeatedField<Types.GardeningSlot>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F9C")]
		[Cpp2IlInjected.Address(RVA = "0x218F3B0", Offset = "0x218DDB0", VA = "0x18218F3B0")]
		[DebuggerNonUserCode]
		public GardenData(GardenData other)
		{
			RepeatedField<Types.GardeningSlot> repeatedField = (slots_ = (RepeatedField<Types.GardeningSlot>)(object)((RepeatedField<T>)(object)other.slots_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F9D")]
		[Cpp2IlInjected.Address(RVA = "0x218E720", Offset = "0x218D120", VA = "0x18218E720", Slot = "12")]
		[DebuggerNonUserCode]
		public GardenData Clone()
		{
			//Discarded unreachable code: IL_002e
			GardenData gardenData = new GardenData();
			RepeatedField<Types.GardeningSlot> repeatedField = (gardenData.slots_ = (RepeatedField<Types.GardeningSlot>)(object)((RepeatedField<T>)(object)slots_).Clone());
			UnknownFieldSet unknownFieldSet = (gardenData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gardenData;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F9F")]
		[Cpp2IlInjected.Address(RVA = "0x218E800", Offset = "0x218D200", VA = "0x18218E800", Slot = "0")]
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
				RepeatedField<Types.GardeningSlot> repeatedField = slots_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA0")]
		[Cpp2IlInjected.Address(RVA = "0x218E8E0", Offset = "0x218D2E0", VA = "0x18218E8E0", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(GardenData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.GardeningSlot> repeatedField = slots_;
				RepeatedField<Types.GardeningSlot> repeatedField2 = other.slots_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA1")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)slots_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA2")]
		[Cpp2IlInjected.Address(RVA = "0x218F0C0", Offset = "0x218DAC0", VA = "0x18218F0C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA3")]
		[Cpp2IlInjected.Address(RVA = "0x218F120", Offset = "0x218DB20", VA = "0x18218F120", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Types.GardeningSlot> repeatedField = slots_;
			FieldCodec<Types.GardeningSlot> repeated_slots_codec = _repeated_slots_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_slots_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA4")]
		[Cpp2IlInjected.Address(RVA = "0x218E610", Offset = "0x218D010", VA = "0x18218E610", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Types.GardeningSlot> repeatedField = slots_;
			FieldCodec<Types.GardeningSlot> repeated_slots_codec = _repeated_slots_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_slots_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA5")]
		[Cpp2IlInjected.Address(RVA = "0x218EFE0", Offset = "0x218D9E0", VA = "0x18218EFE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(GardenData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Types.GardeningSlot> repeatedField = slots_;
				RepeatedField<Types.GardeningSlot> repeatedField2 = other.slots_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA6")]
		[Cpp2IlInjected.Address(RVA = "0x218EEF0", Offset = "0x218D8F0", VA = "0x18218EEF0", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.GardeningSlot> repeatedField = slots_;
					FieldCodec<Types.GardeningSlot> repeated_slots_codec = _repeated_slots_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_slots_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA7")]
		[Cpp2IlInjected.Address(RVA = "0x218EC90", Offset = "0x218D690", VA = "0x18218EC90", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.GardeningSlot> repeatedField = slots_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA8")]
		[Cpp2IlInjected.Address(RVA = "0x218F060", Offset = "0x218DA60", VA = "0x18218F060", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FA9")]
		[Cpp2IlInjected.Address(RVA = "0x218E6C0", Offset = "0x218D0C0", VA = "0x18218E6C0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Types.GardeningSlot> repeatedField = slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FAA")]
		[Cpp2IlInjected.Address(RVA = "0x218F1E0", Offset = "0x218DBE0", VA = "0x18218F1E0")]
		static GardenData()
		{
			Func<GardenData> func = default(Func<GardenData>);
			_parser = (MessageParser<GardenData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.GardeningSlot> parser = Types.GardeningSlot._parser;
			uint num = default(uint);
			_parser = (MessageParser<GardenData>)(object)FieldCodec.ForMessage<Types.GardeningSlot>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FAB")]
		[Cpp2IlInjected.Address(RVA = "0x218E7E0", Offset = "0x218D1E0", VA = "0x18218E7E0", Slot = "4")]
		GridStateDailyResetResult IGridStateDailyResetNotify.ExecuteDailyReset(Item item, in WorldProfile worldProfile, Random random, ITransactionContext context)
		{
			GridStateDailyResetResult result = default(GridStateDailyResetResult);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FAC")]
		[Cpp2IlInjected.Address(RVA = "0x218E7F0", Offset = "0x218D1F0", VA = "0x18218E7F0", Slot = "5")]
		void IGridStateNeedInitialize.Initialize(IItemData itemData, in WorldProfile worldProfile, ITransactionContext context)
		{
			Initialize(itemData, in worldProfile, context);
		}
	}
}
