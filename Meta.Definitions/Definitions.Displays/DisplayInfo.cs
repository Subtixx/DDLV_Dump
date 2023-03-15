using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x200073F")]
	public sealed class DisplayInfo : IMessage<DisplayInfo>, IMessage, IEquatable<DisplayInfo>, IDeepCloneable<DisplayInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002441")]
		private static readonly MessageParser<DisplayInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002442")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002443")]
		public const int SlotsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002444")]
		private static readonly FieldCodec<DisplaySlot> _repeated_slots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002445")]
		private readonly RepeatedField<DisplaySlot> slots_ = (RepeatedField<DisplaySlot>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002446")]
		public const int LayoutTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002447")]
		private LayoutType layoutType_;

		[Cpp2IlInjected.Token(Token = "0x4002448")]
		public const int LastRefreshFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002449")]
		private Timestamp lastRefresh_;

		[Cpp2IlInjected.Token(Token = "0x17001466")]
		public DateTime LastRefreshDateTime
		{
			[Cpp2IlInjected.Token(Token = "0x6005021")]
			[Cpp2IlInjected.Address(RVA = "0xC107F0", Offset = "0xC0F1F0", VA = "0x180C107F0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return lastRefresh_.ToDateTime();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001467")]
		[DebuggerNonUserCode]
		public static MessageParser<DisplayInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005023")]
			[Cpp2IlInjected.Address(RVA = "0x2C40650", Offset = "0x2C3F050", VA = "0x182C40650")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001468")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005024")]
			[Cpp2IlInjected.Address(RVA = "0x2C40580", Offset = "0x2C3EF80", VA = "0x182C40580")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001469")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005025")]
			[Cpp2IlInjected.Address(RVA = "0x2C406B0", Offset = "0x2C3F0B0", VA = "0x182C406B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700146A")]
		[DebuggerNonUserCode]
		public RepeatedField<DisplaySlot> Slots
		{
			[Cpp2IlInjected.Token(Token = "0x600502A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700146B")]
		[DebuggerNonUserCode]
		public LayoutType LayoutType
		{
			[Cpp2IlInjected.Token(Token = "0x600502B")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return layoutType_;
			}
			[Cpp2IlInjected.Token(Token = "0x600502C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				layoutType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700146C")]
		[DebuggerNonUserCode]
		public Timestamp LastRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x600502D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return lastRefresh_;
			}
			[Cpp2IlInjected.Token(Token = "0x600502E")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				lastRefresh_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005022")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F620", Offset = "0x2C3E020", VA = "0x182C3F620")]
		public bool CanRefresh(IFatigue fatigue, DateTime now)
		{
			//Discarded unreachable code: IL_0027
			if (fatigue != null)
			{
				DateTime lastRefresh = lastRefresh_.ToDateTime();
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				return fatigue.CanRefresh(lastRefresh, now);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005026")]
		[Cpp2IlInjected.Address(RVA = "0x2C40470", Offset = "0x2C3EE70", VA = "0x182C40470")]
		[DebuggerNonUserCode]
		public DisplayInfo()
		{
			//IL_0019: Expected O, but got I4
			Timestamp timestamp = (lastRefresh_ = ((DateTime)0).ToProto());
		}

		[Cpp2IlInjected.Token(Token = "0x6005027")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FDB0", Offset = "0x2C3E7B0", VA = "0x182C3FDB0")]
		private void OnConstruction()
		{
			//IL_0006: Expected O, but got I4
			Timestamp timestamp = (lastRefresh_ = ((DateTime)0).ToProto());
		}

		[Cpp2IlInjected.Token(Token = "0x6005028")]
		[Cpp2IlInjected.Address(RVA = "0x2C402C0", Offset = "0x2C3ECC0", VA = "0x182C402C0")]
		[DebuggerNonUserCode]
		public DisplayInfo(DisplayInfo other)
		{
			//IL_001b: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			int num = 0;
			Timestamp timestamp = (lastRefresh_ = ((DateTime)num).ToProto());
			RepeatedField<DisplaySlot> repeatedField = (slots_ = (RepeatedField<DisplaySlot>)(object)((RepeatedField<T>)(object)other.slots_).Clone());
			LayoutType layoutType = (layoutType_ = other.layoutType_);
			Timestamp timestamp2 = other.lastRefresh_;
			if (timestamp2 != null)
			{
				Timestamp timestamp3 = timestamp2.Clone();
			}
			lastRefresh_ = (Timestamp)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005029")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F7C0", Offset = "0x2C3E1C0", VA = "0x182C3F7C0", Slot = "10")]
		[DebuggerNonUserCode]
		public DisplayInfo Clone()
		{
			return new DisplayInfo(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600502F")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F820", Offset = "0x2C3E220", VA = "0x182C3F820", Slot = "0")]
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
				RepeatedField<DisplaySlot> repeatedField = slots_;
				bool flag = default(bool);
				if (flag && layoutType_ == (flag ? LayoutType.TwoItemsMirror : LayoutType.OneItem) && object.Equals(lastRefresh_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005030")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F910", Offset = "0x2C3E310", VA = "0x182C3F910", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DisplayInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<DisplaySlot> repeatedField = slots_;
				RepeatedField<DisplaySlot> repeatedField2 = other.slots_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					LayoutType layoutType = other.layoutType_;
					if (layoutType_ == layoutType)
					{
						Timestamp objB = other.lastRefresh_;
						if (object.Equals(lastRefresh_, objB))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005031")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FAA0", Offset = "0x2C3E4A0", VA = "0x182C3FAA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0043
			int hashCode = ((RepeatedField<T>)(object)slots_).GetHashCode();
			if (layoutType_ != 0)
			{
			}
			Timestamp timestamp = lastRefresh_;
			if (timestamp != null)
			{
				int hashCode2 = timestamp.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005032")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FF80", Offset = "0x2C3E980", VA = "0x182C3FF80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005033")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FFE0", Offset = "0x2C3E9E0", VA = "0x182C3FFE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004a
			RepeatedField<DisplaySlot> repeatedField = slots_;
			FieldCodec<DisplaySlot> repeated_slots_codec = _repeated_slots_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_slots_codec);
			if (layoutType_ != 0)
			{
			}
			if ((long)lastRefresh_ != 0)
			{
				Timestamp value = lastRefresh_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005034")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F4F0", Offset = "0x2C3DEF0", VA = "0x182C3F4F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0075
			RepeatedField<DisplaySlot> repeatedField = slots_;
			FieldCodec<DisplaySlot> repeated_slots_codec = _repeated_slots_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_slots_codec);
			LayoutType layoutType = layoutType_;
			if (layoutType != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)layoutType);
				num2++;
				num += num2;
			}
			Timestamp timestamp = lastRefresh_;
			if (timestamp != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(timestamp);
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

		[Cpp2IlInjected.Token(Token = "0x6005035")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FB40", Offset = "0x2C3E540", VA = "0x182C3FB40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DisplayInfo other)
		{
			//Discarded unreachable code: IL_0088
			if (other == null)
			{
				return;
			}
			RepeatedField<DisplaySlot> repeatedField = slots_;
			RepeatedField<DisplaySlot> repeatedField2 = other.slots_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			LayoutType layoutType = other.layoutType_;
			if (layoutType != 0)
			{
				layoutType_ = layoutType;
			}
			if ((long)other.lastRefresh_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastRefresh_ == null)
				{
					Timestamp timestamp = (lastRefresh_ = new Timestamp());
					timestamp2 = lastRefresh_;
				}
				Timestamp other2 = other.lastRefresh_;
				timestamp2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6005036")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FC40", Offset = "0x2C3E640", VA = "0x182C3FC40", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_007f
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				RepeatedField<DisplaySlot> repeatedField = slots_;
				FieldCodec<DisplaySlot> repeated_slots_codec = _repeated_slots_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_slots_codec);
			}
			int num2 = default(int);
			if (num == 16)
			{
				num2 = (int)(layoutType_ = (LayoutType)input.ReadInt32());
			}
			if (num2 == 26)
			{
				Timestamp builder = default(Timestamp);
				if (lastRefresh_ == null)
				{
					Timestamp timestamp = (lastRefresh_ = new Timestamp());
					builder = lastRefresh_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005037")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F9C0", Offset = "0x2C3E3C0", VA = "0x182C3F9C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					Timestamp timestamp = lastRefresh_;
				}
				LayoutType layoutType = layoutType_;
			}
			RepeatedField<DisplaySlot> repeatedField = slots_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005038")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FE50", Offset = "0x2C3E850", VA = "0x182C3FE50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			//IL_0029: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					return;
				case 0:
				{
					object obj = default(object);
					layoutType_ = (LayoutType)obj;
					return;
				}
				}
				int num2 = 0;
				if (value == null || value != null)
				{
					lastRefresh_ = (Timestamp)num2;
					return;
				}
			}
			else
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005039")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F720", Offset = "0x2C3E120", VA = "0x182C3F720", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_001a: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 0:
					layoutType_ = LayoutType.OneItem;
					break;
				}
				return;
			}
			RepeatedField<DisplaySlot> repeatedField = slots_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600503A")]
		[Cpp2IlInjected.Address(RVA = "0x2C400F0", Offset = "0x2C3EAF0", VA = "0x182C400F0")]
		static DisplayInfo()
		{
			Func<DisplayInfo> func = default(Func<DisplayInfo>);
			_parser = (MessageParser<DisplayInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<DisplaySlot> parser = DisplaySlot._parser;
			uint num = default(uint);
			_parser = (MessageParser<DisplayInfo>)(object)FieldCodec.ForMessage<DisplaySlot>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
