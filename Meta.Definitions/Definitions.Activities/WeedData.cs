using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000896")]
	public sealed class WeedData : IGridStateData, IMessage<WeedData>, IMessage, IEquatable<WeedData>, IDeepCloneable<WeedData>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000897")]
		public enum DataOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4002A48")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4002A49")]
			LootOverride,
			[Cpp2IlInjected.Token(Token = "0x4002A4A")]
			Treasure
		}

		[Cpp2IlInjected.Token(Token = "0x2000898")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000899")]
			public sealed class TreasureLootOverride : IMessage<TreasureLootOverride>, IMessage, IEquatable<TreasureLootOverride>, IDeepCloneable<TreasureLootOverride>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002A4B")]
				private static readonly MessageParser<TreasureLootOverride> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002A4C")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002A4D")]
				public const int TreasureProbabilityFieldNumber = 10;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002A4E")]
				private int treasureProbability_;

				[Cpp2IlInjected.Token(Token = "0x4002A4F")]
				public const int LootTableFieldNumber = 11;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4002A50")]
				private int lootTable_;

				[Cpp2IlInjected.Token(Token = "0x1700181E")]
				[DebuggerNonUserCode]
				public static MessageParser<TreasureLootOverride> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006008")]
					[Cpp2IlInjected.Address(RVA = "0x237C6A0", Offset = "0x237B0A0", VA = "0x18237C6A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700181F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006009")]
					[Cpp2IlInjected.Address(RVA = "0x237C620", Offset = "0x237B020", VA = "0x18237C620")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001820")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600600A")]
					[Cpp2IlInjected.Address(RVA = "0x237C700", Offset = "0x237B100", VA = "0x18237C700", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001821")]
				[DebuggerNonUserCode]
				public int TreasureProbability
				{
					[Cpp2IlInjected.Token(Token = "0x600600E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600600F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001822")]
				[DebuggerNonUserCode]
				public int LootTable
				{
					[Cpp2IlInjected.Token(Token = "0x6006010")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006011")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600600B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public TreasureLootOverride()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600600C")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public TreasureLootOverride(TreasureLootOverride other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600600D")]
				[Cpp2IlInjected.Address(RVA = "0x237C0F0", Offset = "0x237AAF0", VA = "0x18237C0F0", Slot = "10")]
				[DebuggerNonUserCode]
				public TreasureLootOverride Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006012")]
				[Cpp2IlInjected.Address(RVA = "0x237C180", Offset = "0x237AB80", VA = "0x18237C180", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006013")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TreasureLootOverride other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006014")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006015")]
				[Cpp2IlInjected.Address(RVA = "0x237C420", Offset = "0x237AE20", VA = "0x18237C420", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006016")]
				[Cpp2IlInjected.Address(RVA = "0x237C480", Offset = "0x237AE80", VA = "0x18237C480", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006017")]
				[Cpp2IlInjected.Address(RVA = "0x237C000", Offset = "0x237AA00", VA = "0x18237C000", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006018")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TreasureLootOverride other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006019")]
				[Cpp2IlInjected.Address(RVA = "0x237C2D0", Offset = "0x237ACD0", VA = "0x18237C2D0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600601A")]
				[Cpp2IlInjected.Address(RVA = "0x237C210", Offset = "0x237AC10", VA = "0x18237C210", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600601B")]
				[Cpp2IlInjected.Address(RVA = "0x237C360", Offset = "0x237AD60", VA = "0x18237C360", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600601C")]
				[Cpp2IlInjected.Address(RVA = "0x237C0D0", Offset = "0x237AAD0", VA = "0x18237C0D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002A41")]
		private static readonly MessageParser<WeedData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002A42")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002A43")]
		public const int LootOverrideFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002A44")]
		public const int TreasureFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A45")]
		private object data_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A46")]
		private DataOneofCase dataCase_;

		[Cpp2IlInjected.Token(Token = "0x17001818")]
		[DebuggerNonUserCode]
		public static MessageParser<WeedData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005FEE")]
			[Cpp2IlInjected.Address(RVA = "0x17CC1F0", Offset = "0x17CABF0", VA = "0x1817CC1F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001819")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005FEF")]
			[Cpp2IlInjected.Address(RVA = "0x17CC0C0", Offset = "0x17CAAC0", VA = "0x1817CC0C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005FF0")]
			[Cpp2IlInjected.Address(RVA = "0x17CC2B0", Offset = "0x17CACB0", VA = "0x1817CC2B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181B")]
		[DebuggerNonUserCode]
		public Types.TreasureLootOverride LootOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6005FF4")]
			[Cpp2IlInjected.Address(RVA = "0x17CC190", Offset = "0x17CAB90", VA = "0x1817CC190")]
			get
			{
				int num = 0;
				if (dataCase_ == DataOneofCase.LootOverride)
				{
					object obj = data_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005FF5")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				data_ = value;
				bool flag = (byte)(dataCase_ = ((value != null) ? DataOneofCase.LootOverride : DataOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181C")]
		[DebuggerNonUserCode]
		public ItemWithState Treasure
		{
			[Cpp2IlInjected.Token(Token = "0x6005FF6")]
			[Cpp2IlInjected.Address(RVA = "0x17CC250", Offset = "0x17CAC50", VA = "0x1817CC250")]
			get
			{
				int num = 0;
				if (dataCase_ == DataOneofCase.Treasure)
				{
					object obj = data_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005FF7")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				data_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181D")]
		[DebuggerNonUserCode]
		public DataOneofCase DataCase
		{
			[Cpp2IlInjected.Token(Token = "0x6005FF8")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return dataCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005FF1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public WeedData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005FF2")]
		[Cpp2IlInjected.Address(RVA = "0x17CBF60", Offset = "0x17CA960", VA = "0x1817CBF60")]
		[DebuggerNonUserCode]
		public WeedData(WeedData other)
		{
			//IL_005c: Expected I4, but got O
			DataOneofCase dataOneofCase = other.dataCase_;
			if (dataOneofCase == DataOneofCase.LootOverride)
			{
				DataOneofCase dataOneofCase2 = other.dataCase_;
				if (other.data_ == null)
				{
					throw new InvalidCastException();
				}
				Types.TreasureLootOverride treasureLootOverride = default(Types.TreasureLootOverride);
				data_ = treasureLootOverride;
				bool flag = (byte)(dataCase_ = ((treasureLootOverride != null) ? DataOneofCase.LootOverride : DataOneofCase.None)) != 0;
			}
			if (dataOneofCase == DataOneofCase.Treasure)
			{
				DataOneofCase dataOneofCase3 = other.dataCase_;
				if (other.data_ == null)
				{
					throw new InvalidCastException();
				}
				ItemWithState itemWithState = default(ItemWithState);
				data_ = itemWithState;
				dataCase_ = (DataOneofCase)itemWithState;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005FF3")]
		[Cpp2IlInjected.Address(RVA = "0x17CB060", Offset = "0x17C9A60", VA = "0x1817CB060", Slot = "10")]
		[DebuggerNonUserCode]
		public WeedData Clone()
		{
			//Discarded unreachable code: IL_0075
			//IL_005e: Expected I4, but got O
			WeedData weedData = new WeedData();
			DataOneofCase dataOneofCase = dataCase_;
			if (dataOneofCase == DataOneofCase.LootOverride)
			{
				DataOneofCase dataOneofCase2 = dataCase_;
				if (data_ == null)
				{
					throw new InvalidCastException();
				}
				Types.TreasureLootOverride treasureLootOverride = default(Types.TreasureLootOverride);
				weedData.data_ = treasureLootOverride;
				bool flag = (byte)(weedData.dataCase_ = ((treasureLootOverride != null) ? DataOneofCase.LootOverride : DataOneofCase.None)) != 0;
			}
			if (dataOneofCase == DataOneofCase.Treasure)
			{
				DataOneofCase dataOneofCase3 = dataCase_;
				if (data_ == null)
				{
					throw new InvalidCastException();
				}
				ItemWithState itemWithState = default(ItemWithState);
				weedData.data_ = itemWithState;
				weedData.dataCase_ = (DataOneofCase)itemWithState;
			}
			UnknownFieldSet unknownFieldSet = (weedData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return weedData;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FF9")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearData()
		{
			//IL_0010: Expected O, but got I4
			data_ = (dataCase_ = DataOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FFA")]
		[Cpp2IlInjected.Address(RVA = "0x17CB320", Offset = "0x17C9D20", VA = "0x1817CB320", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (dataCase_ == DataOneofCase.LootOverride)
					{
						object obj = data_;
						if (obj != null && obj == null)
						{
							goto IL_0071;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(Types.TreasureLootOverride).TypeHandle != null && (object)typeof(Types.TreasureLootOverride).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						ItemWithState objB = default(ItemWithState);
						bool flag2 = object.Equals(Treasure, objB);
						if (flag2 && dataCase_ == (flag2 ? DataOneofCase.LootOverride : DataOneofCase.None))
						{
							bool flag3 = object.Equals(_unknownFields, objB);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0071;
			IL_0071:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005FFB")]
		[Cpp2IlInjected.Address(RVA = "0x17CB1F0", Offset = "0x17C9BF0", VA = "0x1817CB1F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WeedData other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (dataCase_ == DataOneofCase.LootOverride)
				{
					object obj = data_;
					if (obj != null && obj == null)
					{
						goto IL_0099;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.dataCase_ == DataOneofCase.LootOverride)
				{
					obj2 = other.data_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					ItemWithState treasure = Treasure;
					ItemWithState treasure2 = other.Treasure;
					if (object.Equals(treasure, treasure2))
					{
						DataOneofCase dataOneofCase = other.dataCase_;
						if (dataCase_ == dataOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0099;
			IL_0099:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005FFC")]
		[Cpp2IlInjected.Address(RVA = "0x17CB5A0", Offset = "0x17C9FA0", VA = "0x1817CB5A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0051
			DataOneofCase dataOneofCase = dataCase_;
			int num = 0;
			if (dataOneofCase == DataOneofCase.LootOverride)
			{
				object obj = data_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (dataOneofCase == DataOneofCase.Treasure)
			{
				object obj2 = data_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005FFD")]
		[Cpp2IlInjected.Address(RVA = "0x17CBCC0", Offset = "0x17CA6C0", VA = "0x1817CBCC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005FFE")]
		[Cpp2IlInjected.Address(RVA = "0x17CBD20", Offset = "0x17CA720", VA = "0x1817CBD20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			//IL_002c: Expected O, but got I4
			DataOneofCase dataOneofCase = dataCase_;
			int num = 0;
			if (dataOneofCase == DataOneofCase.LootOverride)
			{
				if (dataCase_ == DataOneofCase.LootOverride)
				{
					object obj = data_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (dataOneofCase == DataOneofCase.Treasure && dataCase_ == DataOneofCase.Treasure)
			{
				object obj2 = data_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005FFF")]
		[Cpp2IlInjected.Address(RVA = "0x17CAEA0", Offset = "0x17C98A0", VA = "0x1817CAEA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (dataCase_ == DataOneofCase.LootOverride)
			{
				if (dataCase_ == DataOneofCase.LootOverride)
				{
					object obj = data_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (dataCase_ == DataOneofCase.Treasure)
			{
				if (dataCase_ == DataOneofCase.Treasure)
				{
					object obj2 = data_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6006000")]
		[Cpp2IlInjected.Address(RVA = "0x17CB780", Offset = "0x17CA180", VA = "0x1817CB780", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WeedData other)
		{
			//IL_00dd: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.dataCase_ == DataOneofCase.LootOverride)
			{
				DataOneofCase dataOneofCase = dataCase_;
				int num = 0;
				if (dataOneofCase == DataOneofCase.LootOverride)
				{
					object obj = data_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(dataCase_ = (((data_ = new Types.TreasureLootOverride()) != null) ? DataOneofCase.LootOverride : DataOneofCase.None)) != 0;
				}
				if (dataCase_ == DataOneofCase.LootOverride)
				{
					object obj2 = data_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.dataCase_ == DataOneofCase.LootOverride)
				{
					object obj3 = other.data_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				return;
			}
			while ((long)typeof(Types.TreasureLootOverride).TypeHandle != 2)
			{
			}
			if (Treasure == null)
			{
				dataCase_ = (DataOneofCase)(data_ = new ItemWithState());
			}
			ItemWithState other2 = default(ItemWithState);
			Treasure.MergeFrom(other2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006001")]
		[Cpp2IlInjected.Address(RVA = "0x17CB9D0", Offset = "0x17CA3D0", VA = "0x1817CB9D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00a8: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Types.TreasureLootOverride treasureLootOverride = new Types.TreasureLootOverride();
				if (dataCase_ == DataOneofCase.LootOverride)
				{
					if (dataCase_ != DataOneofCase.LootOverride)
					{
					}
					object obj = data_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(treasureLootOverride);
				data_ = treasureLootOverride;
				bool flag = (byte)(dataCase_ = ((treasureLootOverride != null) ? DataOneofCase.LootOverride : DataOneofCase.None)) != 0;
			}
			if (num == 18)
			{
				ItemWithState builder = new ItemWithState();
				if (dataCase_ == DataOneofCase.Treasure)
				{
					if (dataCase_ != DataOneofCase.Treasure)
					{
					}
					object obj2 = data_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				data_ = builder;
				dataCase_ = (DataOneofCase)typeof(ItemWithState).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6006002")]
		[Cpp2IlInjected.Address(RVA = "0x17CB490", Offset = "0x17C9E90", VA = "0x1817CB490", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (dataCase_ == DataOneofCase.LootOverride)
			{
				object obj = data_;
				if (obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					goto IL_001c;
				}
			}
			goto IL_0038;
			IL_0038:
			object obj2 = default(object);
			return obj2;
			IL_001c:
			if (fieldNumber == 2)
			{
				if (dataCase_ == DataOneofCase.Treasure)
				{
					obj2 = data_;
					if (obj2 != null && obj2 == null)
					{
						goto IL_0040;
					}
				}
				goto IL_0038;
			}
			goto IL_0040;
			IL_0040:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006003")]
		[Cpp2IlInjected.Address(RVA = "0x17CBBD0", Offset = "0x17CA5D0", VA = "0x1817CBBD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			//IL_0043: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				data_ = num;
				bool flag = (byte)(dataCase_ = ((num != 0) ? DataOneofCase.LootOverride : DataOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				data_ = value;
				dataCase_ = (DataOneofCase)typeof(Types.TreasureLootOverride).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006004")]
		[Cpp2IlInjected.Address(RVA = "0x1686860", Offset = "0x1685260", VA = "0x181686860", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1 || fieldNumber == 2)
			{
				dataCase_ = DataOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006005")]
		[Cpp2IlInjected.Address(RVA = "0x17CB6D0", Offset = "0x17CA0D0", VA = "0x1817CB6D0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Data"))
			{
				DataOneofCase dataOneofCase = dataCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006006")]
		[Cpp2IlInjected.Address(RVA = "0x17CAFF0", Offset = "0x17C99F0", VA = "0x1817CAFF0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Data"))
			{
				data_ = (dataCase_ = DataOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006007")]
		[Cpp2IlInjected.Address(RVA = "0x17CBE50", Offset = "0x17CA850", VA = "0x1817CBE50")]
		static WeedData()
		{
			Func<WeedData> func = default(Func<WeedData>);
			_parser = (MessageParser<WeedData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
