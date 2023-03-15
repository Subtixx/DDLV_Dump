using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x2000741")]
	public sealed class LayoutInfo : IMessage<LayoutInfo>, IMessage, IEquatable<LayoutInfo>, IDeepCloneable<LayoutInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000742")]
		public class AreaSize : IEquatable<AreaSize>
		{
			[Cpp2IlInjected.Token(Token = "0x17001472")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002452")]
			public int X
			{
				[Cpp2IlInjected.Token(Token = "0x6005056")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6005057")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17001473")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4002453")]
			public int Y
			{
				[Cpp2IlInjected.Token(Token = "0x6005058")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6005059")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6005055")]
			[Cpp2IlInjected.Address(RVA = "0x9D1A20", Offset = "0x9D0420", VA = "0x1809D1A20")]
			public static AreaSize New(int sizeX, int sizeY)
			{
				//Discarded unreachable code: IL_0016
				AreaSize areaSize = new AreaSize();
				areaSize.X = sizeX;
				areaSize.Y = sizeY;
				return areaSize;
			}

			[Cpp2IlInjected.Token(Token = "0x600505A")]
			[Cpp2IlInjected.Address(RVA = "0x9D19F0", Offset = "0x9D03F0", VA = "0x1809D19F0", Slot = "4")]
			public bool Equals(AreaSize other)
			{
				//Discarded unreachable code: IL_0023
				int num = other.X;
				if (X != num)
				{
					int num2 = 0;
				}
				int num3 = other.Y;
				return Y == num3;
			}

			[Cpp2IlInjected.Token(Token = "0x600505B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public AreaSize()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400244B")]
		public static LayoutInfo Default;

		[Cpp2IlInjected.Token(Token = "0x400244C")]
		private static readonly MessageParser<LayoutInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400244D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400244E")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400244F")]
		private LayoutType type_;

		[Cpp2IlInjected.Token(Token = "0x4002450")]
		public const int WeightFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002451")]
		private int weight_;

		[Cpp2IlInjected.Token(Token = "0x1700146D")]
		[DebuggerNonUserCode]
		public static MessageParser<LayoutInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600503F")]
			[Cpp2IlInjected.Address(RVA = "0x2744FA0", Offset = "0x27439A0", VA = "0x182744FA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700146E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005040")]
			[Cpp2IlInjected.Address(RVA = "0x2744ED0", Offset = "0x27438D0", VA = "0x182744ED0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700146F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005041")]
			[Cpp2IlInjected.Address(RVA = "0x2745000", Offset = "0x2743A00", VA = "0x182745000", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001470")]
		[DebuggerNonUserCode]
		public LayoutType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6005045")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005046")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001471")]
		[DebuggerNonUserCode]
		public int Weight
		{
			[Cpp2IlInjected.Token(Token = "0x6005047")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return weight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005048")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				weight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600503E")]
		[Cpp2IlInjected.Address(RVA = "0x2744970", Offset = "0x2743370", VA = "0x182744970")]
		public List<AreaSize> GetAreas(int gridSizeX, int gridSizeY)
		{
			//Discarded unreachable code: IL_0067
			List<AreaSize> list = (List<AreaSize>)(object)new List<T>();
			LayoutType layoutType = type_;
			if (layoutType != 0)
			{
				if (layoutType != 0)
				{
					if (layoutType != 0)
					{
						if (layoutType != LayoutType.TwoItemsMirror)
						{
							goto IL_0065;
						}
						int num = 0;
						AreaSize item = AreaSize.New(gridSizeY, gridSizeY);
						((List<T>)(object)list).Add((T)item);
						num++;
					}
					AreaSize item2 = default(AreaSize);
					((List<T>)(object)list).Add((T)item2);
				}
				AreaSize item3 = AreaSize.New(gridSizeX, gridSizeY);
				((List<T>)(object)list).Add((T)item3);
				AreaSize areaSize = AreaSize.New(gridSizeX, gridSizeY);
			}
			AreaSize item4 = AreaSize.New(gridSizeX, gridSizeY);
			((List<T>)(object)list).Add((T)item4);
			goto IL_0065;
			IL_0065:
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6005042")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LayoutInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005043")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public LayoutInfo(LayoutInfo other)
		{
			LayoutType layoutType = (type_ = other.type_);
			int num = (weight_ = other.weight_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005044")]
		[Cpp2IlInjected.Address(RVA = "0x2744850", Offset = "0x2743250", VA = "0x182744850", Slot = "10")]
		[DebuggerNonUserCode]
		public LayoutInfo Clone()
		{
			//Discarded unreachable code: IL_0037
			LayoutInfo layoutInfo = new LayoutInfo();
			LayoutType layoutType = (layoutInfo.type_ = type_);
			int num = (layoutInfo.weight_ = weight_);
			UnknownFieldSet unknownFieldSet = (layoutInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return layoutInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6005049")]
		[Cpp2IlInjected.Address(RVA = "0x27448E0", Offset = "0x27432E0", VA = "0x1827448E0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)type_ == (IntPtr)typeof(LayoutInfo).TypeHandle && (IntPtr)weight_ == (IntPtr)typeof(LayoutInfo).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600504A")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LayoutInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				LayoutType layoutType = other.type_;
				if (type_ == layoutType)
				{
					int num = other.weight_;
					if (weight_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600504B")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (type_ != 0)
				{
				}
				if (weight_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600504C")]
		[Cpp2IlInjected.Address(RVA = "0x2744D10", Offset = "0x2743710", VA = "0x182744D10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600504D")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (type_ != 0)
			{
			}
			if (weight_ != 0)
			{
				int value = weight_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600504E")]
		[Cpp2IlInjected.Address(RVA = "0x2744780", Offset = "0x2743180", VA = "0x182744780", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				LayoutType layoutType = type_;
				num = 0;
				if (layoutType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)layoutType);
				}
				int num3 = weight_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600504F")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LayoutInfo other)
		{
			if (other != null)
			{
				LayoutType layoutType = other.type_;
				if (layoutType != 0)
				{
					type_ = layoutType;
				}
				int num = other.weight_;
				if (num != 0)
				{
					weight_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005050")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(type_ = (LayoutType)input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (weight_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005051")]
		[Cpp2IlInjected.Address(RVA = "0x2744B50", Offset = "0x2743550", VA = "0x182744B50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				LayoutType layoutType = type_;
			}
			if (fieldNumber == 2)
			{
				int num = weight_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005052")]
		[Cpp2IlInjected.Address(RVA = "0x2744C40", Offset = "0x2743640", VA = "0x182744C40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				type_ = (LayoutType)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			weight_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005053")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				type_ = LayoutType.OneItem;
				break;
			case 2:
				weight_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005054")]
		[Cpp2IlInjected.Address(RVA = "0x2744D70", Offset = "0x2743770", VA = "0x182744D70")]
		static LayoutInfo()
		{
			//IL_000f: Expected I4, but got I8
			LayoutInfo CS_0024_003C_003E8__locals0 = new LayoutInfo
			{
				type_ = LayoutType.OneItem
			};
			Default = CS_0024_003C_003E8__locals0;
			Default = (LayoutInfo)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new LayoutInfo()));
			throw new NullReferenceException();
		}
	}
}
