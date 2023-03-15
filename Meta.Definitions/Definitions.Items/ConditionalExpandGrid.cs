using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003CB")]
	public sealed class ConditionalExpandGrid : IMessage<ConditionalExpandGrid>, IMessage, IEquatable<ConditionalExpandGrid>, IDeepCloneable<ConditionalExpandGrid>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20003CC")]
		public enum GridOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001403")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001404")]
			VillageArea
		}

		[Cpp2IlInjected.Token(Token = "0x40013FB")]
		private static readonly MessageParser<ConditionalExpandGrid> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40013FC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40013FD")]
		public const int VillageAreaFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40013FE")]
		public const int GridDataPathFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40013FF")]
		private string gridDataPath_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001400")]
		private object grid_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001401")]
		private GridOneofCase gridCase_;

		[Cpp2IlInjected.Token(Token = "0x17000B5F")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionalExpandGrid> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002D48")]
			[Cpp2IlInjected.Address(RVA = "0x24D28C0", Offset = "0x24D12C0", VA = "0x1824D28C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B60")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D49")]
			[Cpp2IlInjected.Address(RVA = "0x24D27F0", Offset = "0x24D11F0", VA = "0x1824D27F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B61")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002D4A")]
			[Cpp2IlInjected.Address(RVA = "0x24D2990", Offset = "0x24D1390", VA = "0x1824D2990", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B62")]
		[DebuggerNonUserCode]
		public VillageAreaType VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6002D4F")]
			[Cpp2IlInjected.Address(RVA = "0x24D2920", Offset = "0x24D1320", VA = "0x1824D2920")]
			get
			{
				if (gridCase_ == GridOneofCase.VillageArea)
				{
					object obj = grid_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002D50")]
			[Cpp2IlInjected.Address(RVA = "0x24D2B10", Offset = "0x24D1510", VA = "0x1824D2B10")]
			set
			{
				//IL_0016: Expected I4, but got I8
				grid_ = typeof(VillageAreaType).TypeHandle;
				gridCase_ = GridOneofCase.VillageArea;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B63")]
		[DebuggerNonUserCode]
		public string GridDataPath
		{
			[Cpp2IlInjected.Token(Token = "0x6002D51")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gridDataPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D52")]
			[Cpp2IlInjected.Address(RVA = "0x24D2AA0", Offset = "0x24D14A0", VA = "0x1824D2AA0")]
			set
			{
				string text = (gridDataPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B64")]
		[DebuggerNonUserCode]
		public GridOneofCase GridCase
		{
			[Cpp2IlInjected.Token(Token = "0x6002D53")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return gridCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4B")]
		[Cpp2IlInjected.Address(RVA = "0x24D2750", Offset = "0x24D1150", VA = "0x1824D2750")]
		[DebuggerNonUserCode]
		public ConditionalExpandGrid()
		{
			//IL_0018: Expected O, but got I4
			//IL_0021: Expected I4, but got I8
			gridDataPath_ = "";
			base._002Ector();
			VillageAreaType villageAreaType = default(VillageAreaType);
			grid_ = villageAreaType;
			gridCase_ = GridOneofCase.VillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4C")]
		[Cpp2IlInjected.Address(RVA = "0x24D2300", Offset = "0x24D0D00", VA = "0x1824D2300")]
		private void OnConstruction()
		{
			//IL_0007: Expected O, but got I4
			//IL_0010: Expected I4, but got I8
			VillageAreaType villageAreaType = default(VillageAreaType);
			grid_ = villageAreaType;
			gridCase_ = GridOneofCase.VillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4D")]
		[Cpp2IlInjected.Address(RVA = "0x24D2690", Offset = "0x24D1090", VA = "0x1824D2690")]
		[DebuggerNonUserCode]
		public ConditionalExpandGrid(ConditionalExpandGrid other)
		{
			//IL_0032: Expected I4, but got I8
			string text = (gridDataPath_ = other.gridDataPath_);
			if (other.gridCase_ == GridOneofCase.VillageArea)
			{
				int villageArea = (int)other.VillageArea;
				grid_ = typeof(VillageAreaType).TypeHandle;
				gridCase_ = GridOneofCase.VillageArea;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D4E")]
		[Cpp2IlInjected.Address(RVA = "0x24D1CE0", Offset = "0x24D06E0", VA = "0x1824D1CE0", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionalExpandGrid Clone()
		{
			//Discarded unreachable code: IL_004d
			//IL_0038: Expected I4, but got I8
			ConditionalExpandGrid conditionalExpandGrid = new ConditionalExpandGrid();
			string text = (conditionalExpandGrid.gridDataPath_ = gridDataPath_);
			if (gridCase_ == GridOneofCase.VillageArea)
			{
				int villageArea = (int)VillageArea;
				conditionalExpandGrid.grid_ = typeof(VillageAreaType).TypeHandle;
				conditionalExpandGrid.gridCase_ = GridOneofCase.VillageArea;
			}
			UnknownFieldSet unknownFieldSet = (conditionalExpandGrid._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionalExpandGrid;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D54")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearGrid()
		{
			//IL_0010: Expected O, but got I4
			grid_ = (gridCase_ = GridOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D55")]
		[Cpp2IlInjected.Address(RVA = "0x24D1DD0", Offset = "0x24D07D0", VA = "0x1824D1DD0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0025: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				VillageAreaType villageArea = VillageArea;
				int num = 0;
				VillageAreaType villageAreaType = default(VillageAreaType);
				if (villageArea == villageAreaType)
				{
					bool flag = gridDataPath_ != (string)num;
					if (!flag && gridCase_ == (flag ? GridOneofCase.VillageArea : GridOneofCase.None))
					{
						return object.Equals(_unknownFields, num);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D56")]
		[Cpp2IlInjected.Address(RVA = "0x24D1EA0", Offset = "0x24D08A0", VA = "0x1824D1EA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionalExpandGrid other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int villageArea = (int)VillageArea;
				VillageAreaType villageArea2 = other.VillageArea;
				if (villageArea == (int)villageArea2)
				{
					string text = other.gridDataPath_;
					if (!(gridDataPath_ != text))
					{
						GridOneofCase gridOneofCase = other.gridCase_;
						if (gridCase_ == gridOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x6002D57")]
		[Cpp2IlInjected.Address(RVA = "0x24D2000", Offset = "0x24D0A00", VA = "0x1824D2000", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0052
			//IL_0021: Expected O, but got I4
			int num = 0;
			if (gridCase_ == GridOneofCase.VillageArea)
			{
				if (gridCase_ == GridOneofCase.VillageArea)
				{
					object obj = grid_;
				}
				System.Net.Http.Headers.Token.Type type = (System.Net.Http.Headers.Token)num;
			}
			string text = gridDataPath_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D58")]
		[Cpp2IlInjected.Address(RVA = "0x24D2480", Offset = "0x24D0E80", VA = "0x1824D2480", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D59")]
		[Cpp2IlInjected.Address(RVA = "0x24D24E0", Offset = "0x24D0EE0", VA = "0x1824D24E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0046
			if (gridCase_ == GridOneofCase.VillageArea)
			{
				int villageArea = (int)VillageArea;
				output.WriteInt32(villageArea);
			}
			if (gridDataPath_.m_stringLength != 0)
			{
				string value = gridDataPath_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5A")]
		[Cpp2IlInjected.Address(RVA = "0x24D1AA0", Offset = "0x24D04A0", VA = "0x1824D1AA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0062
			int num = 0;
			if (gridCase_ == GridOneofCase.VillageArea)
			{
				if (gridCase_ == GridOneofCase.VillageArea)
				{
					object obj = grid_;
				}
				int num2 = CodedOutputStream.ComputeEnumSize(num);
			}
			string text = gridDataPath_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
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

		[Cpp2IlInjected.Token(Token = "0x6002D5B")]
		[Cpp2IlInjected.Address(RVA = "0x24D2280", Offset = "0x24D0C80", VA = "0x1824D2280", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionalExpandGrid other)
		{
			//Discarded unreachable code: IL_0047
			if (other != null)
			{
				string text = other.gridDataPath_;
				if (text.m_stringLength != 0)
				{
					GridDataPath = text;
				}
				if (other.gridCase_ == GridOneofCase.VillageArea)
				{
					VillageAreaType villageArea = other.VillageArea;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5C")]
		[Cpp2IlInjected.Address(RVA = "0x24D2190", Offset = "0x24D0B90", VA = "0x1824D2190", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			//IL_001f: Expected O, but got I4
			//IL_0028: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = input.ReadInt32();
					grid_ = num2;
					gridCase_ = GridOneofCase.VillageArea;
				}
				if (num == 18)
				{
					string text2 = (GridDataPath = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5D")]
		[Cpp2IlInjected.Address(RVA = "0x24D1F30", Offset = "0x24D0930", VA = "0x1824D1F30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				VillageAreaType villageArea = VillageArea;
			}
			string text = gridDataPath_;
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5E")]
		[Cpp2IlInjected.Address(RVA = "0x24D2360", Offset = "0x24D0D60", VA = "0x1824D2360", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				grid_ = typeof(VillageAreaType).TypeHandle;
				gridCase_ = GridOneofCase.VillageArea;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5F")]
		[Cpp2IlInjected.Address(RVA = "0x24D1BC0", Offset = "0x24D05C0", VA = "0x1824D1BC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
			{
				VillageAreaType villageAreaType = default(VillageAreaType);
				grid_ = villageAreaType;
				gridCase_ = GridOneofCase.VillageArea;
				break;
			}
			case 2:
				GridDataPath = "";
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D60")]
		[Cpp2IlInjected.Address(RVA = "0x24D20E0", Offset = "0x24D0AE0", VA = "0x1824D20E0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Grid"))
			{
				GridOneofCase gridOneofCase = gridCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D61")]
		[Cpp2IlInjected.Address(RVA = "0x24D1C70", Offset = "0x24D0670", VA = "0x1824D1C70", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Grid"))
			{
				grid_ = (gridCase_ = GridOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D62")]
		[Cpp2IlInjected.Address(RVA = "0x24D2580", Offset = "0x24D0F80", VA = "0x1824D2580")]
		static ConditionalExpandGrid()
		{
			Func<ConditionalExpandGrid> func = default(Func<ConditionalExpandGrid>);
			_parser = (MessageParser<ConditionalExpandGrid>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
