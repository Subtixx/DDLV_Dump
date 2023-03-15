using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007FA")]
	public sealed class CustomLocationPositions : IMessage<CustomLocationPositions>, IMessage, IEquatable<CustomLocationPositions>, IDeepCloneable<CustomLocationPositions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20007FB")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20007FC")]
			public sealed class CustomLocationPosition : IMessage<CustomLocationPosition>, IMessage, IEquatable<CustomLocationPosition>, IDeepCloneable<CustomLocationPosition>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x20007FD")]
				public enum GridSelectionOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x4001FEA")]
					None = 0,
					[Cpp2IlInjected.Token(Token = "0x4001FEB")]
					Area = 2,
					[Cpp2IlInjected.Token(Token = "0x4001FEC")]
					GridDataPath = 3
				}

				[Cpp2IlInjected.Token(Token = "0x4001FDB")]
				private static readonly MessageParser<CustomLocationPosition> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001FDC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001FDD")]
				public const int GUIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001FDE")]
				private string gUID_;

				[Cpp2IlInjected.Token(Token = "0x4001FDF")]
				public const int AreaFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4001FE0")]
				public const int GridDataPathFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4001FE1")]
				public const int PositionXFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001FE2")]
				private int positionX_;

				[Cpp2IlInjected.Token(Token = "0x4001FE3")]
				public const int PositionYFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4001FE4")]
				private int positionY_;

				[Cpp2IlInjected.Token(Token = "0x4001FE5")]
				public const int PreferSubGridFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001FE6")]
				private bool preferSubGrid_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4001FE7")]
				private object gridSelection_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4001FE8")]
				private GridSelectionOneofCase gridSelectionCase_;

				[Cpp2IlInjected.Token(Token = "0x17000AD4")]
				[DebuggerNonUserCode]
				public static MessageParser<CustomLocationPosition> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004293")]
					[Cpp2IlInjected.Address(RVA = "0x26437C0", Offset = "0x26421C0", VA = "0x1826437C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AD5")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004294")]
					[Cpp2IlInjected.Address(RVA = "0x26436D0", Offset = "0x26420D0", VA = "0x1826436D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AD6")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004295")]
					[Cpp2IlInjected.Address(RVA = "0x2643890", Offset = "0x2642290", VA = "0x182643890", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AD7")]
				[DebuggerNonUserCode]
				public string GUID
				{
					[Cpp2IlInjected.Token(Token = "0x6004299")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600429A")]
					[Cpp2IlInjected.Address(RVA = "0x26439C0", Offset = "0x26423C0", VA = "0x1826439C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AD8")]
				[DebuggerNonUserCode]
				public VillageAreaType Area
				{
					[Cpp2IlInjected.Token(Token = "0x600429B")]
					[Cpp2IlInjected.Address(RVA = "0x2643660", Offset = "0x2642060", VA = "0x182643660")]
					get
					{
						return default(VillageAreaType);
					}
					[Cpp2IlInjected.Token(Token = "0x600429C")]
					[Cpp2IlInjected.Address(RVA = "0x2643950", Offset = "0x2642350", VA = "0x182643950")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AD9")]
				[DebuggerNonUserCode]
				public string GridDataPath
				{
					[Cpp2IlInjected.Token(Token = "0x600429D")]
					[Cpp2IlInjected.Address(RVA = "0x2643750", Offset = "0x2642150", VA = "0x182643750")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600429E")]
					[Cpp2IlInjected.Address(RVA = "0x2643A30", Offset = "0x2642430", VA = "0x182643A30")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ADA")]
				[DebuggerNonUserCode]
				public int PositionX
				{
					[Cpp2IlInjected.Token(Token = "0x600429F")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60042A0")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ADB")]
				[DebuggerNonUserCode]
				public int PositionY
				{
					[Cpp2IlInjected.Token(Token = "0x60042A1")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60042A2")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ADC")]
				[DebuggerNonUserCode]
				public bool PreferSubGrid
				{
					[Cpp2IlInjected.Token(Token = "0x60042A3")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60042A4")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ADD")]
				[DebuggerNonUserCode]
				public GridSelectionOneofCase GridSelectionCase
				{
					[Cpp2IlInjected.Token(Token = "0x60042A5")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(GridSelectionOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ADE")]
				public VillageAreaType? VillageArea
				{
					[Cpp2IlInjected.Token(Token = "0x60042B4")]
					[Cpp2IlInjected.Address(RVA = "0x2643820", Offset = "0x2642220", VA = "0x182643820")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60042B5")]
					[Cpp2IlInjected.Address(RVA = "0x2643AA0", Offset = "0x26424A0", VA = "0x182643AA0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004296")]
				[Cpp2IlInjected.Address(RVA = "0x2643610", Offset = "0x2642010", VA = "0x182643610")]
				[DebuggerNonUserCode]
				public CustomLocationPosition()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004297")]
				[Cpp2IlInjected.Address(RVA = "0x26434E0", Offset = "0x2641EE0", VA = "0x1826434E0")]
				[DebuggerNonUserCode]
				public CustomLocationPosition(CustomLocationPosition other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004298")]
				[Cpp2IlInjected.Address(RVA = "0x2642670", Offset = "0x2641070", VA = "0x182642670", Slot = "10")]
				[DebuggerNonUserCode]
				public CustomLocationPosition Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60042A6")]
				[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
				[DebuggerNonUserCode]
				public void ClearGridSelection()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042A7")]
				[Cpp2IlInjected.Address(RVA = "0x26427D0", Offset = "0x26411D0", VA = "0x1826427D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60042A8")]
				[Cpp2IlInjected.Address(RVA = "0x26428F0", Offset = "0x26412F0", VA = "0x1826428F0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(CustomLocationPosition other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60042A9")]
				[Cpp2IlInjected.Address(RVA = "0x2642B50", Offset = "0x2641550", VA = "0x182642B50", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60042AA")]
				[Cpp2IlInjected.Address(RVA = "0x2643220", Offset = "0x2641C20", VA = "0x182643220", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60042AB")]
				[Cpp2IlInjected.Address(RVA = "0x2643280", Offset = "0x2641C80", VA = "0x182643280", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042AC")]
				[Cpp2IlInjected.Address(RVA = "0x26422E0", Offset = "0x2640CE0", VA = "0x1826422E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60042AD")]
				[Cpp2IlInjected.Address(RVA = "0x2642DC0", Offset = "0x26417C0", VA = "0x182642DC0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(CustomLocationPosition other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042AE")]
				[Cpp2IlInjected.Address(RVA = "0x2642E90", Offset = "0x2641890", VA = "0x182642E90", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042AF")]
				[Cpp2IlInjected.Address(RVA = "0x26429E0", Offset = "0x26413E0", VA = "0x1826429E0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60042B0")]
				[Cpp2IlInjected.Address(RVA = "0x2642FF0", Offset = "0x26419F0", VA = "0x182642FF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042B1")]
				[Cpp2IlInjected.Address(RVA = "0x2642510", Offset = "0x2640F10", VA = "0x182642510", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60042B2")]
				[Cpp2IlInjected.Address(RVA = "0x2642D10", Offset = "0x2641710", VA = "0x182642D10", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60042B3")]
				[Cpp2IlInjected.Address(RVA = "0x2642600", Offset = "0x2641000", VA = "0x182642600", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001FD6")]
		private static readonly MessageParser<CustomLocationPositions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FD7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FD8")]
		public const int PositionsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001FD9")]
		private static readonly FieldCodec<Types.CustomLocationPosition> _repeated_positions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FDA")]
		private readonly RepeatedField<Types.CustomLocationPosition> positions_ = (RepeatedField<Types.CustomLocationPosition>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000AD0")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomLocationPositions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600427F")]
			[Cpp2IlInjected.Address(RVA = "0x18C5020", Offset = "0x18C3A20", VA = "0x1818C5020")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004280")]
			[Cpp2IlInjected.Address(RVA = "0x18C4F50", Offset = "0x18C3950", VA = "0x1818C4F50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004281")]
			[Cpp2IlInjected.Address(RVA = "0x18C5080", Offset = "0x18C3A80", VA = "0x1818C5080", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AD3")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.CustomLocationPosition> Positions
		{
			[Cpp2IlInjected.Token(Token = "0x6004285")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return positions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004282")]
		[Cpp2IlInjected.Address(RVA = "0x18C4DD0", Offset = "0x18C37D0", VA = "0x1818C4DD0")]
		[DebuggerNonUserCode]
		public CustomLocationPositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004283")]
		[Cpp2IlInjected.Address(RVA = "0x18C4E50", Offset = "0x18C3850", VA = "0x1818C4E50")]
		[DebuggerNonUserCode]
		public CustomLocationPositions(CustomLocationPositions other)
		{
			RepeatedField<Types.CustomLocationPosition> repeatedField = (positions_ = (RepeatedField<Types.CustomLocationPosition>)(object)((RepeatedField<T>)(object)other.positions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004284")]
		[Cpp2IlInjected.Address(RVA = "0x18C4560", Offset = "0x18C2F60", VA = "0x1818C4560", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomLocationPositions Clone()
		{
			//Discarded unreachable code: IL_003b
			CustomLocationPositions customLocationPositions = new CustomLocationPositions();
			RepeatedField<Types.CustomLocationPosition> repeatedField = (customLocationPositions.positions_ = (RepeatedField<Types.CustomLocationPosition>)(object)new RepeatedField<T>());
			RepeatedField<Types.CustomLocationPosition> repeatedField2 = (customLocationPositions.positions_ = (RepeatedField<Types.CustomLocationPosition>)(object)((RepeatedField<T>)(object)positions_).Clone());
			UnknownFieldSet unknownFieldSet = (customLocationPositions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customLocationPositions;
		}

		[Cpp2IlInjected.Token(Token = "0x6004286")]
		[Cpp2IlInjected.Address(RVA = "0x18C4720", Offset = "0x18C3120", VA = "0x1818C4720", Slot = "0")]
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
				RepeatedField<Types.CustomLocationPosition> repeatedField = positions_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004287")]
		[Cpp2IlInjected.Address(RVA = "0x18C4690", Offset = "0x18C3090", VA = "0x1818C4690", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomLocationPositions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.CustomLocationPosition> repeatedField = positions_;
				RepeatedField<Types.CustomLocationPosition> repeatedField2 = other.positions_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004288")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)positions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004289")]
		[Cpp2IlInjected.Address(RVA = "0x18C4AE0", Offset = "0x18C34E0", VA = "0x1818C4AE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600428A")]
		[Cpp2IlInjected.Address(RVA = "0x18C4B40", Offset = "0x18C3540", VA = "0x1818C4B40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Types.CustomLocationPosition> repeatedField = positions_;
			FieldCodec<Types.CustomLocationPosition> repeated_positions_codec = _repeated_positions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_positions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600428B")]
		[Cpp2IlInjected.Address(RVA = "0x18C4450", Offset = "0x18C2E50", VA = "0x1818C4450", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Types.CustomLocationPosition> repeatedField = positions_;
			FieldCodec<Types.CustomLocationPosition> repeated_positions_codec = _repeated_positions_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_positions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600428C")]
		[Cpp2IlInjected.Address(RVA = "0x18C4A00", Offset = "0x18C3400", VA = "0x1818C4A00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomLocationPositions other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Types.CustomLocationPosition> repeatedField = positions_;
				RepeatedField<Types.CustomLocationPosition> repeatedField2 = other.positions_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600428D")]
		[Cpp2IlInjected.Address(RVA = "0x18C4910", Offset = "0x18C3310", VA = "0x1818C4910", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.CustomLocationPosition> repeatedField = positions_;
					FieldCodec<Types.CustomLocationPosition> repeated_positions_codec = _repeated_positions_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_positions_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600428E")]
		[Cpp2IlInjected.Address(RVA = "0x18C4800", Offset = "0x18C3200", VA = "0x1818C4800", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.CustomLocationPosition> repeatedField = positions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600428F")]
		[Cpp2IlInjected.Address(RVA = "0x18C4A80", Offset = "0x18C3480", VA = "0x1818C4A80", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004290")]
		[Cpp2IlInjected.Address(RVA = "0x18C4500", Offset = "0x18C2F00", VA = "0x1818C4500", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Types.CustomLocationPosition> repeatedField = positions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004291")]
		[Cpp2IlInjected.Address(RVA = "0x18C4880", Offset = "0x18C3280", VA = "0x1818C4880")]
		public static string GetPath(string gridLayoutPath)
		{
			//Discarded unreachable code: IL_0013
			string directoryName = Path.GetDirectoryName(gridLayoutPath);
			string text = default(string);
			return text + "/CustomLocations.json";
		}

		[Cpp2IlInjected.Token(Token = "0x6004292")]
		[Cpp2IlInjected.Address(RVA = "0x18C4C00", Offset = "0x18C3600", VA = "0x1818C4C00")]
		static CustomLocationPositions()
		{
			Func<CustomLocationPositions> func = default(Func<CustomLocationPositions>);
			_parser = (MessageParser<CustomLocationPositions>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.CustomLocationPosition> parser = Types.CustomLocationPosition._parser;
			uint num = default(uint);
			_parser = (MessageParser<CustomLocationPositions>)(object)FieldCodec.ForMessage<Types.CustomLocationPosition>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
