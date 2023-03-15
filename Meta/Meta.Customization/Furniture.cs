using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010F7")]
	public sealed class Furniture : IFurniture, IMessage<Furniture>, IMessage, IEquatable<Furniture>, IDeepCloneable<Furniture>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4004606")]
		private static readonly MessageParser<Furniture> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004607")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004608")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004609")]
		private uint id_;

		[Cpp2IlInjected.Token(Token = "0x400460A")]
		public const int FurnitureItemFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400460B")]
		private int furnitureItem_;

		[Cpp2IlInjected.Token(Token = "0x400460C")]
		public const int CurrentDesignFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400460D")]
		private int currentDesign_;

		[Cpp2IlInjected.Token(Token = "0x17001833")]
		Item IFurniture.FurnitureItem
		{
			[Cpp2IlInjected.Token(Token = "0x6008A49")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "4")]
			get
			{
				int num = furnitureItem_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001834")]
		int IFurniture.CurrentDesign
		{
			[Cpp2IlInjected.Token(Token = "0x6008A4A")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0", Slot = "5")]
			get
			{
				return currentDesign_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001835")]
		[DebuggerNonUserCode]
		public static MessageParser<Furniture> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008A4B")]
			[Cpp2IlInjected.Address(RVA = "0x180B690", Offset = "0x180A090", VA = "0x18180B690")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001836")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A4C")]
			[Cpp2IlInjected.Address(RVA = "0x180B5C0", Offset = "0x1809FC0", VA = "0x18180B5C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001837")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A4D")]
			[Cpp2IlInjected.Address(RVA = "0x180B6F0", Offset = "0x180A0F0", VA = "0x18180B6F0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001838")]
		[DebuggerNonUserCode]
		public uint Id
		{
			[Cpp2IlInjected.Token(Token = "0x6008A52")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A53")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001839")]
		[DebuggerNonUserCode]
		public int FurnitureItem
		{
			[Cpp2IlInjected.Token(Token = "0x6008A54")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return furnitureItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A55")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				furnitureItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183A")]
		[DebuggerNonUserCode]
		public int CurrentDesign
		{
			[Cpp2IlInjected.Token(Token = "0x6008A56")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return currentDesign_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A57")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				currentDesign_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A4E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Furniture()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A4F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnConstruction()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008A50")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public Furniture(Furniture other)
		{
			OnConstruction();
			uint num = (id_ = other.id_);
			int num2 = (furnitureItem_ = other.furnitureItem_);
			int num3 = (currentDesign_ = other.currentDesign_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A51")]
		[Cpp2IlInjected.Address(RVA = "0x180AE70", Offset = "0x1809870", VA = "0x18180AE70", Slot = "12")]
		[DebuggerNonUserCode]
		public Furniture Clone()
		{
			//Discarded unreachable code: IL_0047
			Furniture furniture = default(Furniture);
			furniture.OnConstruction();
			uint num = (furniture.id_ = id_);
			int num2 = (furniture.furnitureItem_ = furnitureItem_);
			int num3 = (furniture.currentDesign_ = currentDesign_);
			UnknownFieldSet unknownFieldSet = (furniture._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return furniture;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A58")]
		[Cpp2IlInjected.Address(RVA = "0x180AF00", Offset = "0x1809900", VA = "0x18180AF00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(int)id_ == (IntPtr)typeof(Furniture).TypeHandle && (IntPtr)furnitureItem_ == (IntPtr)typeof(Furniture).TypeHandle && (IntPtr)currentDesign_ == (IntPtr)typeof(Furniture).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A59")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(Furniture other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.id_;
				if (id_ == num)
				{
					int num2 = other.furnitureItem_;
					if (furnitureItem_ == num2)
					{
						int num3 = other.currentDesign_;
						if (currentDesign_ == num3)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A5A")]
		[Cpp2IlInjected.Address(RVA = "0x180B0C0", Offset = "0x1809AC0", VA = "0x18180B0C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (id_ != 0)
				{
				}
				if (furnitureItem_ != 0)
				{
				}
				if (currentDesign_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A5B")]
		[Cpp2IlInjected.Address(RVA = "0x180B3A0", Offset = "0x1809DA0", VA = "0x18180B3A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008A5C")]
		[Cpp2IlInjected.Address(RVA = "0x180B400", Offset = "0x1809E00", VA = "0x18180B400", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0059
			if (id_ != 0)
			{
				uint value = id_;
				output.WriteUInt32(value);
			}
			if (furnitureItem_ != 0)
			{
				int value2 = furnitureItem_;
				output.WriteInt32(value2);
			}
			if (currentDesign_ != 0)
			{
				int value3 = currentDesign_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008A5D")]
		[Cpp2IlInjected.Address(RVA = "0x180AD70", Offset = "0x1809770", VA = "0x18180AD70", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				uint num = id_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeUInt32Size(num);
				}
				int num4 = furnitureItem_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = currentDesign_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num8 = unknownFields.CalculateSize();
			return num8 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A5E")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(Furniture other)
		{
			if (other != null)
			{
				uint num = other.id_;
				if (num != 0)
				{
					id_ = num;
				}
				int num2 = other.furnitureItem_;
				if (num2 != 0)
				{
					furnitureItem_ = num2;
				}
				int num3 = other.currentDesign_;
				if (num3 != 0)
				{
					currentDesign_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A5F")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(id_ = (uint)input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (furnitureItem_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (currentDesign_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A60")]
		[Cpp2IlInjected.Address(RVA = "0x180AFE0", Offset = "0x18099E0", VA = "0x18180AFE0", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				uint num2 = id_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A61")]
		[Cpp2IlInjected.Address(RVA = "0x180B280", Offset = "0x1809C80", VA = "0x18180B280", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					currentDesign_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					furnitureItem_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				id_ = (uint)(int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A62")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				currentDesign_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A63")]
		[Cpp2IlInjected.Address(RVA = "0x180B4B0", Offset = "0x1809EB0", VA = "0x18180B4B0")]
		static Furniture()
		{
			Func<Furniture> func = default(Func<Furniture>);
			_parser = (MessageParser<Furniture>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
