using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000477")]
	public sealed class TargetArea : IMessage<TargetArea>, IMessage, IEquatable<TargetArea>, IDeepCloneable<TargetArea>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000478")]
		public enum TargetOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001811")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001812")]
			Any,
			[Cpp2IlInjected.Token(Token = "0x4001813")]
			Area
		}

		[Cpp2IlInjected.Token(Token = "0x400180A")]
		private static readonly MessageParser<TargetArea> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400180B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400180C")]
		public const int AnyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400180D")]
		public const int AreaFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400180E")]
		private object target_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400180F")]
		private TargetOneofCase targetCase_;

		[Cpp2IlInjected.Token(Token = "0x17000DF1")]
		[DebuggerNonUserCode]
		public static MessageParser<TargetArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60036BD")]
			[Cpp2IlInjected.Address(RVA = "0x2567580", Offset = "0x2565F80", VA = "0x182567580")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60036BE")]
			[Cpp2IlInjected.Address(RVA = "0x25674B0", Offset = "0x2565EB0", VA = "0x1825674B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60036BF")]
			[Cpp2IlInjected.Address(RVA = "0x25675E0", Offset = "0x2565FE0", VA = "0x1825675E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF4")]
		[DebuggerNonUserCode]
		public TargetAny Any
		{
			[Cpp2IlInjected.Token(Token = "0x60036C3")]
			[Cpp2IlInjected.Address(RVA = "0x25673E0", Offset = "0x2565DE0", VA = "0x1825673E0")]
			get
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60036C4")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				target_ = value;
				bool flag = (byte)(targetCase_ = ((value != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF5")]
		[DebuggerNonUserCode]
		public VillageAreaType Area
		{
			[Cpp2IlInjected.Token(Token = "0x60036C5")]
			[Cpp2IlInjected.Address(RVA = "0x2567440", Offset = "0x2565E40", VA = "0x182567440")]
			get
			{
				if (targetCase_ == TargetOneofCase.Area)
				{
					object obj = target_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60036C6")]
			[Cpp2IlInjected.Address(RVA = "0x25676F0", Offset = "0x25660F0", VA = "0x1825676F0")]
			set
			{
				//IL_0016: Expected I4, but got I8
				target_ = typeof(VillageAreaType).TypeHandle;
				targetCase_ = TargetOneofCase.Area;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DF6")]
		[DebuggerNonUserCode]
		public TargetOneofCase TargetCase
		{
			[Cpp2IlInjected.Token(Token = "0x60036C7")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return targetCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036C0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public TargetArea()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60036C1")]
		[Cpp2IlInjected.Address(RVA = "0x2567290", Offset = "0x2565C90", VA = "0x182567290")]
		[DebuggerNonUserCode]
		public TargetArea(TargetArea other)
		{
			//IL_0042: Expected I4, but got I8
			TargetOneofCase targetOneofCase = other.targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				TargetOneofCase targetOneofCase2 = other.targetCase_;
				if (other.target_ == null)
				{
					throw new InvalidCastException();
				}
				int fieldNumber = 0;
				TargetAny targetAny = default(TargetAny);
				targetAny.ClearFieldValue(fieldNumber);
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				targetAny._unknownFields = unknownFields;
				target_ = targetAny;
				targetCase_ = TargetOneofCase.Any;
			}
			if (targetOneofCase == TargetOneofCase.Area)
			{
				VillageAreaType area = other.Area;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036C2")]
		[Cpp2IlInjected.Address(RVA = "0x25664A0", Offset = "0x2564EA0", VA = "0x1825664A0", Slot = "10")]
		[DebuggerNonUserCode]
		public TargetArea Clone()
		{
			//Discarded unreachable code: IL_0067
			//IL_0044: Expected I4, but got I8
			TargetArea targetArea = new TargetArea();
			TargetOneofCase targetOneofCase = targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				TargetOneofCase targetOneofCase2 = targetCase_;
				if (target_ == null)
				{
					throw new InvalidCastException();
				}
				int fieldNumber = 0;
				TargetAny targetAny = default(TargetAny);
				targetAny.ClearFieldValue(fieldNumber);
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				targetAny._unknownFields = unknownFields;
				targetArea.target_ = targetAny;
				targetArea.targetCase_ = TargetOneofCase.Any;
			}
			if (targetOneofCase == TargetOneofCase.Area)
			{
				VillageAreaType area = Area;
			}
			UnknownFieldSet unknownFieldSet = (targetArea._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return targetArea;
		}

		[Cpp2IlInjected.Token(Token = "0x60036C8")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearTarget()
		{
			//IL_0010: Expected O, but got I4
			target_ = (targetCase_ = TargetOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036C9")]
		[Cpp2IlInjected.Address(RVA = "0x2566620", Offset = "0x2565020", VA = "0x182566620", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0069: Expected O, but got I4
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (targetCase_ == TargetOneofCase.Any)
					{
						object obj = target_;
						if (obj != null && obj == null)
						{
							goto IL_006e;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(TargetAny).TypeHandle != null && (object)typeof(TargetAny).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						VillageAreaType area = Area;
						int num2 = 0;
						VillageAreaType villageAreaType = default(VillageAreaType);
						if (area == villageAreaType && targetCase_ == (TargetOneofCase)villageAreaType)
						{
							bool flag2 = object.Equals(_unknownFields, num2);
						}
					}
				}
			}
			int num3 = 0;
			goto IL_006e;
			IL_006e:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036CA")]
		[Cpp2IlInjected.Address(RVA = "0x2566780", Offset = "0x2565180", VA = "0x182566780", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TargetArea other)
		{
			//IL_004d: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						goto IL_0090;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.targetCase_ == TargetOneofCase.Any)
				{
					obj2 = other.target_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					int area = (int)Area;
					VillageAreaType area2 = other.Area;
					if (area == (int)area2)
					{
						TargetOneofCase targetOneofCase = other.targetCase_;
						if (targetCase_ == targetOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0090;
			IL_0090:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036CB")]
		[Cpp2IlInjected.Address(RVA = "0x25669B0", Offset = "0x25653B0", VA = "0x1825669B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004c
			TargetOneofCase targetOneofCase = targetCase_;
			int num = 0;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				object obj = target_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (targetOneofCase == TargetOneofCase.Area && targetCase_ == TargetOneofCase.Area)
			{
				object obj2 = target_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60036CC")]
		[Cpp2IlInjected.Address(RVA = "0x2567040", Offset = "0x2565A40", VA = "0x182567040", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60036CD")]
		[Cpp2IlInjected.Address(RVA = "0x25670A0", Offset = "0x2565AA0", VA = "0x1825670A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0054
			//IL_002c: Expected O, but got I4
			TargetOneofCase targetOneofCase = targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				int num = 0;
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (targetOneofCase == TargetOneofCase.Area)
			{
				int area = (int)Area;
				output.WriteInt32(area);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60036CE")]
		[Cpp2IlInjected.Address(RVA = "0x2566240", Offset = "0x2564C40", VA = "0x182566240", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0069
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (targetCase_ == TargetOneofCase.Any)
			{
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (targetCase_ == TargetOneofCase.Area)
			{
				if (targetCase_ == TargetOneofCase.Area)
				{
					object obj2 = target_;
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

		[Cpp2IlInjected.Token(Token = "0x60036CF")]
		[Cpp2IlInjected.Address(RVA = "0x2566B90", Offset = "0x2565590", VA = "0x182566B90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TargetArea other)
		{
			if (other == null)
			{
				return;
			}
			TargetOneofCase targetOneofCase = other.targetCase_;
			if (targetOneofCase == TargetOneofCase.Any)
			{
				TargetOneofCase targetOneofCase2 = targetCase_;
				int num = 0;
				if (targetOneofCase2 == TargetOneofCase.Any)
				{
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					int fieldNumber = 0;
					TargetAny targetAny = default(TargetAny);
					targetAny.ClearFieldValue(fieldNumber);
					target_ = targetAny;
					bool flag = (byte)(targetCase_ = ((targetAny != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
				}
				if (targetCase_ == TargetOneofCase.Any)
				{
					object obj2 = target_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				object obj3 = default(object);
				if (other.targetCase_ == TargetOneofCase.Any)
				{
					obj3 = other.target_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj3 == null)
				{
					goto IL_00ab;
				}
			}
			if (targetOneofCase == TargetOneofCase.Area)
			{
				VillageAreaType area = other.Area;
			}
			goto IL_00ab;
			IL_00ab:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60036D0")]
		[Cpp2IlInjected.Address(RVA = "0x2566D90", Offset = "0x2565790", VA = "0x182566D90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0088: Expected O, but got I4
			//IL_0091: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				int fieldNumber = 0;
				TargetAny targetAny = default(TargetAny);
				targetAny.ClearFieldValue(fieldNumber);
				if (targetCase_ == TargetOneofCase.Any)
				{
					if (targetCase_ != TargetOneofCase.Any)
					{
					}
					object obj = target_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
					if (obj != null)
					{
						UnknownFieldSet unknownFields = targetAny._unknownFields;
						UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
						targetAny._unknownFields = unknownFields2;
					}
				}
				input.ReadMessage(targetAny);
				target_ = targetAny;
				bool flag = (byte)(targetCase_ = ((targetAny != null) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			if (num == 16)
			{
				int num2 = input.ReadInt32();
				target_ = num2;
				targetCase_ = TargetOneofCase.Area;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60036D1")]
		[Cpp2IlInjected.Address(RVA = "0x25668A0", Offset = "0x25652A0", VA = "0x1825668A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (targetCase_ == TargetOneofCase.Any)
			{
				object obj = target_;
				if (obj != null)
				{
					if (obj != null)
					{
						goto IL_001c;
					}
					goto IL_0037;
				}
			}
			goto IL_0027;
			IL_001c:
			if (fieldNumber == 2)
			{
				VillageAreaType area = Area;
			}
			goto IL_0027;
			IL_0037:
			throw new InvalidCastException();
			IL_0027:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
		}

		[Cpp2IlInjected.Token(Token = "0x60036D2")]
		[Cpp2IlInjected.Address(RVA = "0x2566F50", Offset = "0x2565950", VA = "0x182566F50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002a
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				target_ = num;
				bool flag = (byte)(targetCase_ = ((num != 0) ? TargetOneofCase.Any : TargetOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036D3")]
		[Cpp2IlInjected.Address(RVA = "0x25663A0", Offset = "0x2564DA0", VA = "0x1825663A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_0019: Expected O, but got I4
			//IL_0022: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				targetCase_ = TargetOneofCase.None;
				break;
			case 2:
			{
				VillageAreaType villageAreaType = default(VillageAreaType);
				target_ = villageAreaType;
				targetCase_ = TargetOneofCase.Area;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036D4")]
		[Cpp2IlInjected.Address(RVA = "0x2566AE0", Offset = "0x25654E0", VA = "0x182566AE0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				TargetOneofCase targetOneofCase = targetCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036D5")]
		[Cpp2IlInjected.Address(RVA = "0x2566430", Offset = "0x2564E30", VA = "0x182566430", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				target_ = (targetCase_ = TargetOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036D6")]
		[Cpp2IlInjected.Address(RVA = "0x2567180", Offset = "0x2565B80", VA = "0x182567180")]
		static TargetArea()
		{
			Func<TargetArea> func = default(Func<TargetArea>);
			_parser = (MessageParser<TargetArea>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
