using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200086F")]
	public sealed class PendingFishSelector : IMessage<PendingFishSelector>, IMessage, IEquatable<PendingFishSelector>, IDeepCloneable<PendingFishSelector>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000870")]
		public enum SelectorOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40021E7")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40021E8")]
			PendingFishID,
			[Cpp2IlInjected.Token(Token = "0x40021E9")]
			BodyOfWater
		}

		[Cpp2IlInjected.Token(Token = "0x2000871")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000872")]
			public sealed class BodyOfWaterData : IMessage<BodyOfWaterData>, IMessage, IEquatable<BodyOfWaterData>, IDeepCloneable<BodyOfWaterData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40021EA")]
				private static readonly MessageParser<BodyOfWaterData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40021EB")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40021EC")]
				public const int LocationFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40021ED")]
				private ActivityDataLocationFilter location_;

				[Cpp2IlInjected.Token(Token = "0x40021EE")]
				public const int IndexFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40021EF")]
				private int index_;

				[Cpp2IlInjected.Token(Token = "0x17000BBE")]
				[DebuggerNonUserCode]
				public static MessageParser<BodyOfWaterData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004714")]
					[Cpp2IlInjected.Address(RVA = "0x25C32D0", Offset = "0x25C1CD0", VA = "0x1825C32D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000BBF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004715")]
					[Cpp2IlInjected.Address(RVA = "0x25C3250", Offset = "0x25C1C50", VA = "0x1825C3250")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000BC0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004716")]
					[Cpp2IlInjected.Address(RVA = "0x25C3330", Offset = "0x25C1D30", VA = "0x1825C3330", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000BC1")]
				[DebuggerNonUserCode]
				public ActivityDataLocationFilter Location
				{
					[Cpp2IlInjected.Token(Token = "0x600471A")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600471B")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000BC2")]
				[DebuggerNonUserCode]
				public int Index
				{
					[Cpp2IlInjected.Token(Token = "0x600471C")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600471D")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004717")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public BodyOfWaterData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004718")]
				[Cpp2IlInjected.Address(RVA = "0x25C31D0", Offset = "0x25C1BD0", VA = "0x1825C31D0")]
				[DebuggerNonUserCode]
				public BodyOfWaterData(BodyOfWaterData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004719")]
				[Cpp2IlInjected.Address(RVA = "0x25C2B90", Offset = "0x25C1590", VA = "0x1825C2B90", Slot = "10")]
				[DebuggerNonUserCode]
				public BodyOfWaterData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600471E")]
				[Cpp2IlInjected.Address(RVA = "0x25C2C40", Offset = "0x25C1640", VA = "0x1825C2C40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600471F")]
				[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(BodyOfWaterData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004720")]
				[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004721")]
				[Cpp2IlInjected.Address(RVA = "0x25C3060", Offset = "0x25C1A60", VA = "0x1825C3060", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004722")]
				[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004723")]
				[Cpp2IlInjected.Address(RVA = "0x25C2AC0", Offset = "0x25C14C0", VA = "0x1825C2AC0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004724")]
				[Cpp2IlInjected.Address(RVA = "0x25C2EB0", Offset = "0x25C18B0", VA = "0x1825C2EB0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(BodyOfWaterData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004725")]
				[Cpp2IlInjected.Address(RVA = "0x25C2DC0", Offset = "0x25C17C0", VA = "0x1825C2DC0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004726")]
				[Cpp2IlInjected.Address(RVA = "0x25C2CF0", Offset = "0x25C16F0", VA = "0x1825C2CF0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004727")]
				[Cpp2IlInjected.Address(RVA = "0x25C2F90", Offset = "0x25C1990", VA = "0x1825C2F90", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004728")]
				[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40021E0")]
		private static readonly MessageParser<PendingFishSelector> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40021E1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40021E2")]
		public const int PendingFishIDFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40021E3")]
		public const int BodyOfWaterFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40021E4")]
		private object selector_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40021E5")]
		private SelectorOneofCase selectorCase_;

		[Cpp2IlInjected.Token(Token = "0x17000BB8")]
		[DebuggerNonUserCode]
		public static MessageParser<PendingFishSelector> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60046F9")]
			[Cpp2IlInjected.Address(RVA = "0x7AEB60", Offset = "0x7AD560", VA = "0x1807AEB60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BB9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046FA")]
			[Cpp2IlInjected.Address(RVA = "0x7AEA90", Offset = "0x7AD490", VA = "0x1807AEA90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60046FB")]
			[Cpp2IlInjected.Address(RVA = "0x7AEC30", Offset = "0x7AD630", VA = "0x1807AEC30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBB")]
		[DebuggerNonUserCode]
		public uint PendingFishID
		{
			[Cpp2IlInjected.Token(Token = "0x60046FF")]
			[Cpp2IlInjected.Address(RVA = "0x7AEBC0", Offset = "0x7AD5C0", VA = "0x1807AEBC0")]
			get
			{
				if (selectorCase_ == SelectorOneofCase.PendingFishID)
				{
					object obj = selector_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004700")]
			[Cpp2IlInjected.Address(RVA = "0x7AED40", Offset = "0x7AD740", VA = "0x1807AED40")]
			set
			{
				//IL_0014: Expected I4, but got I8
				selector_ = typeof(uint).TypeHandle;
				selectorCase_ = SelectorOneofCase.PendingFishID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBC")]
		[DebuggerNonUserCode]
		public Types.BodyOfWaterData BodyOfWater
		{
			[Cpp2IlInjected.Token(Token = "0x6004701")]
			[Cpp2IlInjected.Address(RVA = "0x7AEA30", Offset = "0x7AD430", VA = "0x1807AEA30")]
			get
			{
				int num = 0;
				if (selectorCase_ == SelectorOneofCase.BodyOfWater)
				{
					object obj = selector_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004702")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				selector_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BBD")]
		[DebuggerNonUserCode]
		public SelectorOneofCase SelectorCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004703")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return selectorCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60046FC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PendingFishSelector()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60046FD")]
		[Cpp2IlInjected.Address(RVA = "0x7AE900", Offset = "0x7AD300", VA = "0x1807AE900")]
		[DebuggerNonUserCode]
		public PendingFishSelector(PendingFishSelector other)
		{
			//IL_002c: Expected I4, but got I8
			//IL_004e: Expected I4, but got O
			SelectorOneofCase selectorOneofCase = other.selectorCase_;
			if (selectorOneofCase == SelectorOneofCase.PendingFishID)
			{
				uint pendingFishID = other.PendingFishID;
				selector_ = typeof(uint).TypeHandle;
				selectorCase_ = SelectorOneofCase.PendingFishID;
			}
			if (selectorOneofCase == SelectorOneofCase.BodyOfWater)
			{
				SelectorOneofCase selectorOneofCase2 = other.selectorCase_;
				if (other.selector_ == null)
				{
					throw new InvalidCastException();
				}
				Types.BodyOfWaterData bodyOfWaterData = default(Types.BodyOfWaterData);
				selector_ = bodyOfWaterData;
				selectorCase_ = (SelectorOneofCase)bodyOfWaterData;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60046FE")]
		[Cpp2IlInjected.Address(RVA = "0x7ADBE0", Offset = "0x7AC5E0", VA = "0x1807ADBE0", Slot = "10")]
		[DebuggerNonUserCode]
		public PendingFishSelector Clone()
		{
			//Discarded unreachable code: IL_0067
			//IL_002c: Expected I4, but got I8
			//IL_0050: Expected I4, but got O
			PendingFishSelector pendingFishSelector = new PendingFishSelector();
			SelectorOneofCase selectorOneofCase = selectorCase_;
			if (selectorOneofCase == SelectorOneofCase.PendingFishID)
			{
				uint pendingFishID = PendingFishID;
				pendingFishSelector.selector_ = typeof(uint).TypeHandle;
				pendingFishSelector.selectorCase_ = SelectorOneofCase.PendingFishID;
			}
			if (selectorOneofCase == SelectorOneofCase.BodyOfWater)
			{
				SelectorOneofCase selectorOneofCase2 = selectorCase_;
				if (selector_ == null)
				{
					throw new InvalidCastException();
				}
				Types.BodyOfWaterData bodyOfWaterData = default(Types.BodyOfWaterData);
				pendingFishSelector.selector_ = bodyOfWaterData;
				pendingFishSelector.selectorCase_ = (SelectorOneofCase)bodyOfWaterData;
			}
			UnknownFieldSet unknownFieldSet = (pendingFishSelector._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pendingFishSelector;
		}

		[Cpp2IlInjected.Token(Token = "0x6004704")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearSelector()
		{
			//IL_0010: Expected O, but got I4
			selector_ = (selectorCase_ = SelectorOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004705")]
		[Cpp2IlInjected.Address(RVA = "0x7ADD40", Offset = "0x7AC740", VA = "0x1807ADD40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = default(uint);
				if (PendingFishID == num)
				{
					Types.BodyOfWaterData objB = default(Types.BodyOfWaterData);
					bool flag = object.Equals(BodyOfWater, objB);
					if (flag && selectorCase_ == (flag ? SelectorOneofCase.PendingFishID : SelectorOneofCase.None))
					{
						return object.Equals(_unknownFields, objB);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004706")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE30", Offset = "0x7AC830", VA = "0x1807ADE30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PendingFishSelector other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint pendingFishID = PendingFishID;
				uint pendingFishID2 = other.PendingFishID;
				if (pendingFishID == pendingFishID2)
				{
					Types.BodyOfWaterData bodyOfWater = BodyOfWater;
					Types.BodyOfWaterData bodyOfWater2 = other.BodyOfWater;
					if (object.Equals(bodyOfWater, bodyOfWater2))
					{
						SelectorOneofCase selectorOneofCase = other.selectorCase_;
						if (selectorCase_ == selectorOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004707")]
		[Cpp2IlInjected.Address(RVA = "0x7ADFF0", Offset = "0x7AC9F0", VA = "0x1807ADFF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004e
			int num = 0;
			if (selectorCase_ == SelectorOneofCase.PendingFishID)
			{
				if (selectorCase_ != SelectorOneofCase.PendingFishID)
				{
				}
				object obj = selector_;
			}
			if (selectorCase_ == SelectorOneofCase.BodyOfWater)
			{
				object obj2 = selector_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004708")]
		[Cpp2IlInjected.Address(RVA = "0x7AE570", Offset = "0x7ACF70", VA = "0x1807AE570", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004709")]
		[Cpp2IlInjected.Address(RVA = "0x7AE710", Offset = "0x7AD110", VA = "0x1807AE710", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0048
			SelectorOneofCase selectorOneofCase = selectorCase_;
			if (selectorOneofCase == SelectorOneofCase.PendingFishID)
			{
				uint pendingFishID = PendingFishID;
				output.WriteUInt32(pendingFishID);
			}
			if (selectorOneofCase == SelectorOneofCase.BodyOfWater && selectorCase_ == SelectorOneofCase.BodyOfWater)
			{
				object obj = selector_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600470A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD980", Offset = "0x7AC380", VA = "0x1807AD980", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (selectorCase_ == SelectorOneofCase.PendingFishID)
			{
				if (selectorCase_ == SelectorOneofCase.PendingFishID)
				{
					object obj = selector_;
				}
				int num2 = CodedOutputStream.ComputeUInt32Size((uint)num);
			}
			if (selectorCase_ == SelectorOneofCase.BodyOfWater)
			{
				if (selectorCase_ == SelectorOneofCase.BodyOfWater)
				{
					object obj2 = selector_;
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

		[Cpp2IlInjected.Token(Token = "0x600470B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE330", Offset = "0x7ACD30", VA = "0x1807AE330", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PendingFishSelector other)
		{
			if (other == null)
			{
				return;
			}
			if (other.selectorCase_ != SelectorOneofCase.PendingFishID)
			{
				while ((long)typeof(Types.BodyOfWaterData).TypeHandle != 2)
				{
				}
				Types.BodyOfWaterData bodyOfWaterData = default(Types.BodyOfWaterData);
				if (bodyOfWaterData == null)
				{
					Types.BodyOfWaterData bodyOfWaterData2 = new Types.BodyOfWaterData();
				}
				Types.BodyOfWaterData bodyOfWater = other.BodyOfWater;
				Types.BodyOfWaterData bodyOfWaterData3 = default(Types.BodyOfWaterData);
				bodyOfWaterData3.MergeFrom(bodyOfWater);
				throw new NullReferenceException();
			}
			uint num = (PendingFishID = other.PendingFishID);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600470C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE1D0", Offset = "0x7ACBD0", VA = "0x1807AE1D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0068: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 8)
			{
				int num3 = (int)(PendingFishID = (uint)input.ReadInt32());
			}
			if (num == 18)
			{
				Types.BodyOfWaterData builder = new Types.BodyOfWaterData();
				if (selectorCase_ == SelectorOneofCase.BodyOfWater)
				{
					if (selectorCase_ != SelectorOneofCase.BodyOfWater)
					{
					}
					object obj = selector_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				selector_ = builder;
				selectorCase_ = (SelectorOneofCase)typeof(Types.BodyOfWaterData).TypeHandle;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600470D")]
		[Cpp2IlInjected.Address(RVA = "0x7ADEE0", Offset = "0x7AC8E0", VA = "0x1807ADEE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				uint pendingFishID = PendingFishID;
			}
			if (fieldNumber == 2)
			{
				while (selectorCase_ != SelectorOneofCase.BodyOfWater)
				{
				}
				object obj = selector_;
				while (obj == null)
				{
				}
				if (obj == null)
				{
					goto IL_0037;
				}
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
			IL_0037:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600470E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE440", Offset = "0x7ACE40", VA = "0x1807AE440", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0018: Expected I4, but got I8
			//IL_0037: Expected I4, but got O
			if (fieldNumber == 1)
			{
				selector_ = typeof(uint).TypeHandle;
				selectorCase_ = SelectorOneofCase.PendingFishID;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				selector_ = value;
				selectorCase_ = (SelectorOneofCase)typeof(uint).TypeHandle;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600470F")]
		[Cpp2IlInjected.Address(RVA = "0x7ADAE0", Offset = "0x7AC4E0", VA = "0x1807ADAE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_0022: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
			{
				uint num = default(uint);
				selector_ = num;
				selectorCase_ = SelectorOneofCase.PendingFishID;
				break;
			}
			case 2:
				selectorCase_ = SelectorOneofCase.None;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004710")]
		[Cpp2IlInjected.Address(RVA = "0x7AE120", Offset = "0x7ACB20", VA = "0x1807AE120", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Selector"))
			{
				SelectorOneofCase selectorOneofCase = selectorCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004711")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB70", Offset = "0x7AC570", VA = "0x1807ADB70", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Selector"))
			{
				selector_ = (selectorCase_ = SelectorOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004712")]
		[Cpp2IlInjected.Address(RVA = "0x7AE5D0", Offset = "0x7ACFD0", VA = "0x1807AE5D0")]
		public unsafe bool TryGetPendingFish(ProfileWorld world, out PendingFish pendingFish)
		{
			//IL_0042: Expected O, but got I4
			int num = 0;
			SelectorOneofCase selectorOneofCase = selectorCase_;
			if (selectorOneofCase == SelectorOneofCase.PendingFishID)
			{
				MapField<uint, PendingFish> pendingFishes_ = world.pendingFishes_;
				uint pendingFishID = PendingFishID;
			}
			if (selectorOneofCase == SelectorOneofCase.BodyOfWater)
			{
				if (selectorCase_ == SelectorOneofCase.BodyOfWater)
				{
					object obj = selector_;
					if (obj != null && obj == null)
					{
						goto IL_0048;
					}
				}
				if (!world.TryGetBodyOfWater((Types.BodyOfWaterData)num, out *(BodyOfWater*)num))
				{
				}
			}
			int num2 = 0;
			goto IL_0048;
			IL_0048:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004713")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7F0", Offset = "0x7AD1F0", VA = "0x1807AE7F0")]
		static PendingFishSelector()
		{
			Func<PendingFishSelector> func = default(Func<PendingFishSelector>);
			_parser = (MessageParser<PendingFishSelector>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
