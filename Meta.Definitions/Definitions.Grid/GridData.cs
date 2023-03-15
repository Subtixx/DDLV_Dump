using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006F3")]
	public sealed class GridData : IMessage<GridData>, IMessage, IEquatable<GridData>, IDeepCloneable<GridData>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4002348")]
		private static readonly MessageParser<GridData> _parser = (MessageParser<GridData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new GridData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002349")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400234A")]
		public const int SizeXFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400234B")]
		private int sizeX_;

		[Cpp2IlInjected.Token(Token = "0x400234C")]
		public const int SizeYFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400234D")]
		private int sizeY_;

		[Cpp2IlInjected.Token(Token = "0x400234E")]
		public const int FloorTypesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400234F")]
		private static readonly FieldCodec<int> _repeated_floorTypes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002350")]
		private readonly RepeatedField<int> floorTypes_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170013D8")]
		[DebuggerNonUserCode]
		public static MessageParser<GridData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D5B")]
			[Cpp2IlInjected.Address(RVA = "0x2F8D440", Offset = "0x2F8BE40", VA = "0x182F8D440")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D5C")]
			[Cpp2IlInjected.Address(RVA = "0x2F8D230", Offset = "0x2F8BC30", VA = "0x182F8D230")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D5D")]
			[Cpp2IlInjected.Address(RVA = "0x2F8D4A0", Offset = "0x2F8BEA0", VA = "0x182F8D4A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DB")]
		[DebuggerNonUserCode]
		public int SizeX
		{
			[Cpp2IlInjected.Token(Token = "0x6004D61")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return sizeX_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D62")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				sizeX_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DC")]
		[DebuggerNonUserCode]
		public int SizeY
		{
			[Cpp2IlInjected.Token(Token = "0x6004D63")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return sizeY_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D64")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				sizeY_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DD")]
		[DebuggerNonUserCode]
		public RepeatedField<int> FloorTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004D65")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return floorTypes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DE")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6004D71")]
			[Cpp2IlInjected.Address(RVA = "0x2F8D300", Offset = "0x2F8BD00", VA = "0x182F8D300")]
			get
			{
				int num = 0;
				return sizeY_ > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DF")]
		public GridFloorType this[GridPosition gridPosition]
		{
			[Cpp2IlInjected.Token(Token = "0x6004D74")]
			[Cpp2IlInjected.Address(RVA = "0x2F8D320", Offset = "0x2F8BD20", VA = "0x182F8D320")]
			get
			{
				GridFloorType result = default(GridFloorType);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E0")]
		public GridFloorType this[int x, int y]
		{
			[Cpp2IlInjected.Token(Token = "0x6004D75")]
			[Cpp2IlInjected.Address(RVA = "0x2F8D330", Offset = "0x2F8BD30", VA = "0x182F8D330")]
			get
			{
				//IL_002b: Expected I4, but got O
				if (x < sizeX_)
				{
					int num = sizeY_;
					if (y >= num)
					{
						goto IL_0037;
					}
					RepeatedField<int> repeatedField = floorTypes_;
					int num2 = num * x;
					num2 += y;
					int num3 = (int)((RepeatedField<T>)(object)repeatedField)[num2];
				}
				ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("x");
				goto IL_0037;
				IL_0037:
				ArgumentOutOfRangeException ex2 = new ArgumentOutOfRangeException("y");
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D76")]
			[Cpp2IlInjected.Address(RVA = "0x2F8D5B0", Offset = "0x2F8BFB0", VA = "0x182F8D5B0")]
			set
			{
				//IL_002b: Expected O, but got I4
				if (x < sizeX_)
				{
					int num = sizeY_;
					if (y < num)
					{
						RepeatedField<int> repeatedField = floorTypes_;
						int num2 = num * x;
						num2 += y;
						((RepeatedField<T>)(object)repeatedField)[num2] = (T)y;
						return;
					}
				}
				else
				{
					ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("x");
				}
				ArgumentOutOfRangeException ex2 = new ArgumentOutOfRangeException("y");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D5E")]
		[Cpp2IlInjected.Address(RVA = "0x2F8D1B0", Offset = "0x2F8BBB0", VA = "0x182F8D1B0")]
		[DebuggerNonUserCode]
		public GridData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D5F")]
		[Cpp2IlInjected.Address(RVA = "0x2F8D0A0", Offset = "0x2F8BAA0", VA = "0x182F8D0A0")]
		[DebuggerNonUserCode]
		public GridData(GridData other)
		{
			int num = (sizeX_ = other.sizeX_);
			int num2 = (sizeY_ = other.sizeY_);
			RepeatedField<int> repeatedField = (floorTypes_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.floorTypes_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D60")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C250", Offset = "0x2F8AC50", VA = "0x182F8C250", Slot = "10")]
		[DebuggerNonUserCode]
		public GridData Clone()
		{
			//Discarded unreachable code: IL_005b
			GridData gridData = new GridData();
			RepeatedField<int> repeatedField = (gridData.floorTypes_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			int num = (gridData.sizeX_ = sizeX_);
			int num2 = (gridData.sizeY_ = sizeY_);
			RepeatedField<int> repeatedField2 = (gridData.floorTypes_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)floorTypes_).Clone());
			UnknownFieldSet unknownFieldSet = (gridData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gridData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D66")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C640", Offset = "0x2F8B040", VA = "0x182F8C640", Slot = "0")]
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
				if ((IntPtr)sizeX_ == (IntPtr)typeof(GridData).TypeHandle && (IntPtr)sizeY_ == (IntPtr)typeof(GridData).TypeHandle)
				{
					RepeatedField<int> repeatedField = floorTypes_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D67")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C5A0", Offset = "0x2F8AFA0", VA = "0x182F8C5A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.sizeX_;
				if (sizeX_ == num)
				{
					int num2 = other.sizeY_;
					if (sizeY_ == num2)
					{
						RepeatedField<int> repeatedField = floorTypes_;
						RepeatedField<int> repeatedField2 = other.floorTypes_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D68")]
		[Cpp2IlInjected.Address(RVA = "0x17C3010", Offset = "0x17C1A10", VA = "0x1817C3010", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0032
			if (sizeX_ != 0)
			{
			}
			if (sizeY_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)floorTypes_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D69")]
		[Cpp2IlInjected.Address(RVA = "0x2F8CDF0", Offset = "0x2F8B7F0", VA = "0x182F8CDF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D6A")]
		[Cpp2IlInjected.Address(RVA = "0x2F8CE50", Offset = "0x2F8B850", VA = "0x182F8CE50", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0059
			if (sizeX_ != 0)
			{
				int value = sizeX_;
				output.WriteInt32(value);
			}
			if (sizeY_ != 0)
			{
				int value2 = sizeY_;
				output.WriteInt32(value2);
			}
			RepeatedField<int> repeatedField = floorTypes_;
			FieldCodec<int> repeated_floorTypes_codec = _repeated_floorTypes_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_floorTypes_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D6B")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C090", Offset = "0x2F8AA90", VA = "0x182F8C090", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_006e
			int num = sizeX_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = sizeY_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			RepeatedField<int> repeatedField = floorTypes_;
			FieldCodec<int> repeated_floorTypes_codec = _repeated_floorTypes_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_floorTypes_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num6;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D6C")]
		[Cpp2IlInjected.Address(RVA = "0x2F8CBA0", Offset = "0x2F8B5A0", VA = "0x182F8CBA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridData other)
		{
			//Discarded unreachable code: IL_005d
			if (other != null)
			{
				int num = other.sizeX_;
				if (num != 0)
				{
					sizeX_ = num;
				}
				int num2 = other.sizeY_;
				if (num2 != 0)
				{
					sizeY_ = num2;
				}
				RepeatedField<int> repeatedField = floorTypes_;
				RepeatedField<int> repeatedField2 = other.floorTypes_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D6D")]
		[Cpp2IlInjected.Address(RVA = "0x2F8CA70", Offset = "0x2F8B470", VA = "0x182F8CA70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0072
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				num += 4294967272u;
				if (num != 4294967293u)
				{
					goto IL_005b;
				}
				RepeatedField<int> repeatedField = floorTypes_;
				FieldCodec<int> repeated_floorTypes_codec = _repeated_floorTypes_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_floorTypes_codec);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (sizeX_ = input.ReadInt32());
			}
			if (num2 == 16)
			{
				int num3 = (sizeY_ = input.ReadInt32());
			}
			goto IL_005b;
			IL_005b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004D6E")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C730", Offset = "0x2F8B130", VA = "0x182F8C730", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_001e;
				}
				RepeatedField<int> repeatedField = floorTypes_;
			}
			int num2 = sizeX_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D6F")]
		[Cpp2IlInjected.Address(RVA = "0x2F8CC30", Offset = "0x2F8B630", VA = "0x182F8CC30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0020
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num == 1)
				{
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					/*Error: Unexpected end of block*/;
				}
				object obj = default(object);
				sizeY_ = (int)obj;
			}
			else
			{
				object obj2 = default(object);
				sizeX_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D70")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C1C0", Offset = "0x2F8ABC0", VA = "0x182F8C1C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_002b
			//IL_0020: Expected I4, but got I8
			//IL_002a: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					RepeatedField<int> repeatedField = floorTypes_;
					break;
				}
				case 0:
					break;
				default:
					return;
				}
				sizeY_ = 0;
			}
			else
			{
				sizeX_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D72")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C380", Offset = "0x2F8AD80", VA = "0x182F8C380")]
		public bool Contains(GridPosition position)
		{
			if ((object)position != null && (long)(IntPtr)position < (long)sizeX_)
			{
				return (long)(IntPtr)position < (long)sizeY_;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D73")]
		[Cpp2IlInjected.Address(RVA = "0x2F8CD50", Offset = "0x2F8B750", VA = "0x182F8CD50")]
		public void SetFloorTypesSize()
		{
			//Discarded unreachable code: IL_002d
			//IL_0028: Expected O, but got I4
			int num = sizeY_;
			((RepeatedField<T>)(object)floorTypes_).Clear();
			int num2 = 0;
			if (num > 0)
			{
				RepeatedField<int> repeatedField = floorTypes_;
				int num3 = 0;
				((RepeatedField<T>)(object)repeatedField).Add((T)num3);
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D77")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C3B0", Offset = "0x2F8ADB0", VA = "0x182F8C3B0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0060
			RepeatedField<int> repeatedField = floorTypes_;
			Func<GridFloorType, int, GridFloorType> _003C_003E9__47_ = _003C_003Ec._003C_003E9__47_0;
			if (_003C_003E9__47_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)delegate
				{
					/*Error: Unexpected end of block*/;
				};
			}
			int num = 0;
			int num2 = Enumerable.Aggregate<int, GridFloorType>((IEnumerable<>)(object)repeatedField, num, (Func<, , >)(object)_003C_003E9__47_);
			if (num2 <= 512)
			{
				context.AddError("GridData contains Shore, but no Water");
			}
			if (num2 > 4096 && num2 != 4096)
			{
				context.AddError("A Surface grid should only have Surface");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D78")]
		[Cpp2IlInjected.Address(RVA = "0x2F8C800", Offset = "0x2F8B200", VA = "0x182F8C800")]
		public static GridData Get(string path)
		{
			//IL_002a: Expected I4, but got I8
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				GridData message = ProtoParser.Parse<GridData>(FileSystem.Data.ReadAllBytes(path));
				ulong num = default(ulong);
				bool flag2 = ProtoDatabase.Instance.TrySet(path, message, overrideIfExists: true, (byte)num != 0);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D79")]
		[Cpp2IlInjected.Address(RVA = "0x2F8CF60", Offset = "0x2F8B960", VA = "0x182F8CF60")]
		static GridData()
		{
			_parser = (MessageParser<GridData>)(object)FieldCodec.ForInt32(26u);
			/*Error: Unexpected end of block*/;
		}
	}
}
