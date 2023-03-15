using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000920")]
	public sealed class DefaultOffGridBuildingData : IMessage<DefaultOffGridBuildingData>, IMessage, IEquatable<DefaultOffGridBuildingData>, IDeepCloneable<DefaultOffGridBuildingData>, IMessageFieldAccessor, IDefaultGridCollectionContainer
	{
		[Cpp2IlInjected.Token(Token = "0x40024FC")]
		private static readonly MessageParser<DefaultOffGridBuildingData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024FD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024FE")]
		public const int DefaultOffGridBuildingFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024FF")]
		private OffGridBuilding defaultOffGridBuilding_;

		[Cpp2IlInjected.Token(Token = "0x4002500")]
		public const int DefaultGridCollectionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002501")]
		private GridCollection defaultGridCollection_;

		[Cpp2IlInjected.Token(Token = "0x17000D86")]
		[DebuggerNonUserCode]
		public static MessageParser<DefaultOffGridBuildingData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004F58")]
			[Cpp2IlInjected.Address(RVA = "0x1A245E0", Offset = "0x1A22FE0", VA = "0x181A245E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D87")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F59")]
			[Cpp2IlInjected.Address(RVA = "0x1A24510", Offset = "0x1A22F10", VA = "0x181A24510")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D88")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F5A")]
			[Cpp2IlInjected.Address(RVA = "0x1A24640", Offset = "0x1A23040", VA = "0x181A24640", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D89")]
		[DebuggerNonUserCode]
		public OffGridBuilding DefaultOffGridBuilding
		{
			[Cpp2IlInjected.Token(Token = "0x6004F5E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return defaultOffGridBuilding_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F5F")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				defaultOffGridBuilding_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D8A")]
		[DebuggerNonUserCode]
		public GridCollection DefaultGridCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6004F60")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "14")]
			get
			{
				return defaultGridCollection_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F61")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				defaultGridCollection_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DefaultOffGridBuildingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5C")]
		[Cpp2IlInjected.Address(RVA = "0x1A24470", Offset = "0x1A22E70", VA = "0x181A24470")]
		[DebuggerNonUserCode]
		public DefaultOffGridBuildingData(DefaultOffGridBuildingData other)
		{
			//IL_0021: Expected O, but got I4
			OffGridBuilding offGridBuilding = other.defaultOffGridBuilding_;
			int num = 0;
			if (offGridBuilding != null)
			{
				OffGridBuilding offGridBuilding2 = offGridBuilding.Clone();
			}
			defaultOffGridBuilding_ = (OffGridBuilding)num;
			GridCollection gridCollection = other.defaultGridCollection_;
			GridCollection gridCollection2 = default(GridCollection);
			if (gridCollection != null)
			{
				gridCollection2 = gridCollection.Clone();
			}
			defaultGridCollection_ = gridCollection2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5D")]
		[Cpp2IlInjected.Address(RVA = "0x1A23DB0", Offset = "0x1A227B0", VA = "0x181A23DB0", Slot = "10")]
		[DebuggerNonUserCode]
		public DefaultOffGridBuildingData Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_0021: Expected O, but got I4
			DefaultOffGridBuildingData defaultOffGridBuildingData = new DefaultOffGridBuildingData();
			OffGridBuilding offGridBuilding = defaultOffGridBuilding_;
			int num = 0;
			if (offGridBuilding != null)
			{
				OffGridBuilding offGridBuilding2 = offGridBuilding.Clone();
			}
			defaultOffGridBuildingData.defaultOffGridBuilding_ = (OffGridBuilding)num;
			GridCollection gridCollection = defaultGridCollection_;
			GridCollection gridCollection2 = default(GridCollection);
			if (gridCollection != null)
			{
				gridCollection2 = gridCollection.Clone();
			}
			defaultOffGridBuildingData.defaultGridCollection_ = gridCollection2;
			UnknownFieldSet unknownFieldSet = (defaultOffGridBuildingData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return defaultOffGridBuildingData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F62")]
		[Cpp2IlInjected.Address(RVA = "0x1A23E80", Offset = "0x1A22880", VA = "0x181A23E80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(defaultOffGridBuilding_, other) && object.Equals(defaultGridCollection_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F63")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultOffGridBuildingData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				OffGridBuilding objB = other.defaultOffGridBuilding_;
				if (object.Equals(defaultOffGridBuilding_, objB))
				{
					GridCollection objB2 = other.defaultGridCollection_;
					if (object.Equals(defaultGridCollection_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F64")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				OffGridBuilding offGridBuilding = defaultOffGridBuilding_;
				if (offGridBuilding != null)
				{
					int hashCode = offGridBuilding.GetHashCode();
				}
				GridCollection gridCollection = defaultGridCollection_;
				if (gridCollection != null)
				{
					int hashCode2 = gridCollection.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F65")]
		[Cpp2IlInjected.Address(RVA = "0x1A24300", Offset = "0x1A22D00", VA = "0x181A24300", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F66")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)defaultOffGridBuilding_ != 0)
			{
				OffGridBuilding value = defaultOffGridBuilding_;
				output.WriteMessage(value);
			}
			if ((long)defaultGridCollection_ != 0)
			{
				GridCollection value2 = defaultGridCollection_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F67")]
		[Cpp2IlInjected.Address(RVA = "0x1A23CE0", Offset = "0x1A226E0", VA = "0x181A23CE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				OffGridBuilding offGridBuilding = defaultOffGridBuilding_;
				num = 0;
				if (offGridBuilding != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(offGridBuilding);
				}
				GridCollection gridCollection = defaultGridCollection_;
				if (gridCollection != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(gridCollection);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F68")]
		[Cpp2IlInjected.Address(RVA = "0x1A24110", Offset = "0x1A22B10", VA = "0x181A24110", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DefaultOffGridBuildingData other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.defaultOffGridBuilding_ != 0)
			{
				OffGridBuilding offGridBuilding = defaultOffGridBuilding_;
				if (offGridBuilding == null)
				{
					OffGridBuilding offGridBuilding2 = (defaultOffGridBuilding_ = new OffGridBuilding());
					OffGridBuilding offGridBuilding3 = defaultOffGridBuilding_;
				}
				OffGridBuilding other2 = other.defaultOffGridBuilding_;
				offGridBuilding.MergeFrom(other2);
			}
			if ((long)other.defaultGridCollection_ != 0)
			{
				GridCollection gridCollection2 = default(GridCollection);
				if (defaultGridCollection_ == null)
				{
					GridCollection gridCollection = (defaultGridCollection_ = new GridCollection());
					gridCollection2 = defaultGridCollection_;
				}
				GridCollection other3 = other.defaultGridCollection_;
				gridCollection2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004F69")]
		[Cpp2IlInjected.Address(RVA = "0x1A23FD0", Offset = "0x1A229D0", VA = "0x181A23FD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				OffGridBuilding offGridBuilding = defaultOffGridBuilding_;
				if (offGridBuilding == null)
				{
					OffGridBuilding offGridBuilding2 = (defaultOffGridBuilding_ = new OffGridBuilding());
				}
				input.ReadMessage(offGridBuilding);
			}
			if (num == 18)
			{
				GridCollection builder = default(GridCollection);
				if (defaultGridCollection_ == null)
				{
					GridCollection gridCollection = (defaultGridCollection_ = new GridCollection());
					builder = defaultGridCollection_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6A")]
		[Cpp2IlInjected.Address(RVA = "0x1A23F40", Offset = "0x1A22940", VA = "0x181A23F40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				OffGridBuilding offGridBuilding = defaultOffGridBuilding_;
			}
			if (fieldNumber == 2)
			{
				GridCollection gridCollection = defaultGridCollection_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6B")]
		[Cpp2IlInjected.Address(RVA = "0x1A24240", Offset = "0x1A22C40", VA = "0x181A24240", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					defaultOffGridBuilding_ = (OffGridBuilding)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6C")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6D")]
		[Cpp2IlInjected.Address(RVA = "0x1A24360", Offset = "0x1A22D60", VA = "0x181A24360")]
		static DefaultOffGridBuildingData()
		{
			Func<DefaultOffGridBuildingData> func = default(Func<DefaultOffGridBuildingData>);
			_parser = (MessageParser<DefaultOffGridBuildingData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
