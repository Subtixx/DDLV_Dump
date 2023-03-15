using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010FE")]
	public sealed class Makeup : IMessage<Makeup>, IMessage, IEquatable<Makeup>, IDeepCloneable<Makeup>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400461B")]
		private static readonly MessageParser<Makeup> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400461C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400461D")]
		public const int MakeupItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400461E")]
		private int makeupItemID_;

		[Cpp2IlInjected.Token(Token = "0x400461F")]
		public const int ColorIndex1FieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4004620")]
		private int colorIndex1_;

		[Cpp2IlInjected.Token(Token = "0x4004621")]
		public const int ColorIndex2FieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004622")]
		private int colorIndex2_;

		[Cpp2IlInjected.Token(Token = "0x4004623")]
		public const int ColorIndex3FieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4004624")]
		private int colorIndex3_;

		[Cpp2IlInjected.Token(Token = "0x4004625")]
		public const int OpacityFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004626")]
		private float opacity_;

		[Cpp2IlInjected.Token(Token = "0x4004627")]
		public const int GlossFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4004628")]
		private float gloss_;

		[Cpp2IlInjected.Token(Token = "0x17001840")]
		[DebuggerNonUserCode]
		public static MessageParser<Makeup> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008A8B")]
			[Cpp2IlInjected.Address(RVA = "0x18B44F0", Offset = "0x18B2EF0", VA = "0x1818B44F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001841")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A8C")]
			[Cpp2IlInjected.Address(RVA = "0x18B4420", Offset = "0x18B2E20", VA = "0x1818B4420")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001842")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A8D")]
			[Cpp2IlInjected.Address(RVA = "0x18B4550", Offset = "0x18B2F50", VA = "0x1818B4550", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001843")]
		[DebuggerNonUserCode]
		public int MakeupItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6008A91")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return makeupItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A92")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				makeupItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001844")]
		[DebuggerNonUserCode]
		public int ColorIndex1
		{
			[Cpp2IlInjected.Token(Token = "0x6008A93")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return colorIndex1_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A94")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				colorIndex1_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001845")]
		[DebuggerNonUserCode]
		public int ColorIndex2
		{
			[Cpp2IlInjected.Token(Token = "0x6008A95")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return colorIndex2_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A96")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				colorIndex2_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001846")]
		[DebuggerNonUserCode]
		public int ColorIndex3
		{
			[Cpp2IlInjected.Token(Token = "0x6008A97")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return colorIndex3_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A98")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				colorIndex3_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001847")]
		[DebuggerNonUserCode]
		public float Opacity
		{
			[Cpp2IlInjected.Token(Token = "0x6008A99")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get
			{
				return opacity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A9A")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
			set
			{
				opacity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001848")]
		[DebuggerNonUserCode]
		public float Gloss
		{
			[Cpp2IlInjected.Token(Token = "0x6008A9B")]
			[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39000", VA = "0x180E3A600")]
			get
			{
				return gloss_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A9C")]
			[Cpp2IlInjected.Address(RVA = "0xE3ABE0", Offset = "0xE395E0", VA = "0x180E3ABE0")]
			set
			{
				gloss_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A8E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public Makeup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008A8F")]
		[Cpp2IlInjected.Address(RVA = "0x18B43B0", Offset = "0x18B2DB0", VA = "0x1818B43B0")]
		[DebuggerNonUserCode]
		public Makeup(Makeup other)
		{
			int num = (makeupItemID_ = other.makeupItemID_);
			int num2 = (colorIndex1_ = other.colorIndex1_);
			int num3 = (colorIndex2_ = other.colorIndex2_);
			int num4 = (colorIndex3_ = other.colorIndex3_);
			float num5 = (opacity_ = other.opacity_);
			float num6 = (gloss_ = other.gloss_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A90")]
		[Cpp2IlInjected.Address(RVA = "0x18B3670", Offset = "0x18B2070", VA = "0x1818B3670", Slot = "10")]
		[DebuggerNonUserCode]
		public Makeup Clone()
		{
			//Discarded unreachable code: IL_0077
			Makeup makeup = new Makeup();
			int num = (makeup.makeupItemID_ = makeupItemID_);
			int num2 = (makeup.colorIndex1_ = colorIndex1_);
			int num3 = (makeup.colorIndex2_ = colorIndex2_);
			int num4 = (makeup.colorIndex3_ = colorIndex3_);
			float num5 = (makeup.opacity_ = opacity_);
			float num6 = (makeup.gloss_ = gloss_);
			UnknownFieldSet unknownFieldSet = (makeup._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return makeup;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A9D")]
		[Cpp2IlInjected.Address(RVA = "0x18B3860", Offset = "0x18B2260", VA = "0x1818B3860", Slot = "0")]
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
				if ((IntPtr)makeupItemID_ == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle && (IntPtr)colorIndex1_ == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle && (IntPtr)colorIndex2_ == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle && (IntPtr)colorIndex3_ == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A9E")]
		[Cpp2IlInjected.Address(RVA = "0x18B3710", Offset = "0x18B2110", VA = "0x1818B3710", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Makeup other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.makeupItemID_;
				if (makeupItemID_ == num)
				{
					int num2 = other.colorIndex1_;
					if (colorIndex1_ == num2)
					{
						int num3 = other.colorIndex2_;
						if (colorIndex2_ == num3)
						{
							int num4 = other.colorIndex3_;
							if (colorIndex3_ == num4)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A9F")]
		[Cpp2IlInjected.Address(RVA = "0x18B3B20", Offset = "0x18B2520", VA = "0x1818B3B20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0064
			//IL_0039: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			if (makeupItemID_ != 0)
			{
			}
			if (colorIndex1_ != 0)
			{
			}
			if (colorIndex2_ != 0)
			{
			}
			int num = colorIndex3_;
			int num2 = default(int);
			if (num != 0)
			{
				num2 = 0;
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = default(EqualityComparer<float>);
			if (num != 0)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField).GetHashCode((T)num2);
			}
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField != null)
			{
				int hashCode2 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num2);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6008AA0")]
		[Cpp2IlInjected.Address(RVA = "0x18B40F0", Offset = "0x18B2AF0", VA = "0x1818B40F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008AA1")]
		[Cpp2IlInjected.Address(RVA = "0x18B4150", Offset = "0x18B2B50", VA = "0x1818B4150", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_009a
			if (makeupItemID_ != 0)
			{
				int value = makeupItemID_;
				output.WriteInt32(value);
			}
			if (colorIndex1_ != 0)
			{
				int value2 = colorIndex1_;
				output.WriteInt32(value2);
			}
			if (colorIndex2_ != 0)
			{
				int value3 = colorIndex2_;
				output.WriteInt32(value3);
			}
			if (colorIndex3_ != 0)
			{
				int value4 = colorIndex3_;
				output.WriteInt32(value4);
			}
			if (output != null)
			{
				float value5 = opacity_;
				output.WriteFloat(value5);
			}
			if (output != null)
			{
				float value6 = gloss_;
				output.WriteFloat(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008AA2")]
		[Cpp2IlInjected.Address(RVA = "0x18B34B0", Offset = "0x18B1EB0", VA = "0x1818B34B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = makeupItemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = colorIndex1_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = colorIndex2_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				int num8 = colorIndex3_;
				if (num8 != 0)
				{
					int num9 = CodedOutputStream.ComputeInt32Size(num8);
					num9++;
					num2 += num9;
				}
				num2 += 5;
				num2 += 5;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num10 = unknownFields.CalculateSize();
			return num10 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008AA3")]
		[Cpp2IlInjected.Address(RVA = "0x18B3D50", Offset = "0x18B2750", VA = "0x1818B3D50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Makeup other)
		{
			if (other != null)
			{
				int num = other.makeupItemID_;
				if (num != 0)
				{
					makeupItemID_ = num;
				}
				int num2 = other.colorIndex1_;
				if (num2 != 0)
				{
					colorIndex1_ = num2;
				}
				int num3 = other.colorIndex2_;
				if (num3 != 0)
				{
					colorIndex2_ = num3;
				}
				int num4 = other.colorIndex3_;
				if (num4 != 0)
				{
					colorIndex3_ = num4;
				}
				float num5 = other.opacity_;
				if (num4 != 0)
				{
					opacity_ = num5;
				}
				float num6 = other.gloss_;
				if (num4 != 0)
				{
					gloss_ = num6;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AA4")]
		[Cpp2IlInjected.Address(RVA = "0x18B3DF0", Offset = "0x18B27F0", VA = "0x1818B3DF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a9
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 32)
				{
					int num2 = (colorIndex3_ = input.ReadInt32());
				}
				if (num == 45)
				{
					float num3 = (opacity_ = input.ReadFloat());
				}
				if (num != 53)
				{
					goto IL_0092;
				}
				float num4 = (gloss_ = input.ReadFloat());
			}
			int num5 = default(int);
			if (num == 8)
			{
				num5 = (makeupItemID_ = input.ReadInt32());
			}
			int num6 = default(int);
			if (num5 == 16)
			{
				num6 = (colorIndex1_ = input.ReadInt32());
			}
			if (num6 == 24)
			{
				int num7 = (colorIndex2_ = input.ReadInt32());
			}
			goto IL_0092;
			IL_0092:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008AA5")]
		[Cpp2IlInjected.Address(RVA = "0x18B39F0", Offset = "0x18B23F0", VA = "0x1818B39F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				int num = makeupItemID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008AA6")]
		[Cpp2IlInjected.Address(RVA = "0x18B3EE0", Offset = "0x18B28E0", VA = "0x1818B3EE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				makeupItemID_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AA7")]
		[Cpp2IlInjected.Address(RVA = "0x18B3600", Offset = "0x18B2000", VA = "0x1818B3600", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022, IL_002c, IL_0038
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			if (fieldNumber <= 5)
			{
				makeupItemID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AA8")]
		[Cpp2IlInjected.Address(RVA = "0x18B42A0", Offset = "0x18B2CA0", VA = "0x1818B42A0")]
		static Makeup()
		{
			Func<Makeup> func = default(Func<Makeup>);
			_parser = (MessageParser<Makeup>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
