using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x20006F5")]
	public sealed class VillageObjectLimitData : IMessage<VillageObjectLimitData>, IMessage, IEquatable<VillageObjectLimitData>, IDeepCloneable<VillageObjectLimitData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002353")]
		private static readonly MessageParser<VillageObjectLimitData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002354")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002355")]
		public const int UniqueLimitFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002356")]
		private int uniqueLimit_;

		[Cpp2IlInjected.Token(Token = "0x4002357")]
		public const int InstanceLimitFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002358")]
		private int instanceLimit_;

		[Cpp2IlInjected.Token(Token = "0x4002359")]
		public const int ExclusionsFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400235A")]
		private static readonly FieldCodec<ItemTypeSelector> _repeated_exclusions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400235B")]
		private readonly RepeatedField<ItemTypeSelector> exclusions_;

		[Cpp2IlInjected.Token(Token = "0x170013E1")]
		[DebuggerNonUserCode]
		public static MessageParser<VillageObjectLimitData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004D7E")]
			[Cpp2IlInjected.Address(RVA = "0x17C3950", Offset = "0x17C2350", VA = "0x1817C3950")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D7F")]
			[Cpp2IlInjected.Address(RVA = "0x17C3880", Offset = "0x17C2280", VA = "0x1817C3880")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D80")]
			[Cpp2IlInjected.Address(RVA = "0x17C39B0", Offset = "0x17C23B0", VA = "0x1817C39B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E4")]
		[DebuggerNonUserCode]
		public int UniqueLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6004D84")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return uniqueLimit_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D85")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				uniqueLimit_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E5")]
		[DebuggerNonUserCode]
		public int InstanceLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6004D86")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return instanceLimit_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004D87")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				instanceLimit_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E6")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemTypeSelector> Exclusions
		{
			[Cpp2IlInjected.Token(Token = "0x6004D88")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return exclusions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D81")]
		[Cpp2IlInjected.Address(RVA = "0x17C3760", Offset = "0x17C2160", VA = "0x1817C3760")]
		[DebuggerNonUserCode]
		public VillageObjectLimitData()
		{
			exclusions_ = (RepeatedField<ItemTypeSelector>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D82")]
		[Cpp2IlInjected.Address(RVA = "0x17C37E0", Offset = "0x17C21E0", VA = "0x1817C37E0")]
		[DebuggerNonUserCode]
		public VillageObjectLimitData(VillageObjectLimitData other)
		{
			int num = (uniqueLimit_ = other.uniqueLimit_);
			int num2 = (instanceLimit_ = other.instanceLimit_);
			RepeatedField<ItemTypeSelector> repeatedField = (exclusions_ = (RepeatedField<ItemTypeSelector>)(object)((RepeatedField<T>)(object)other.exclusions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004D83")]
		[Cpp2IlInjected.Address(RVA = "0x17C2B80", Offset = "0x17C1580", VA = "0x1817C2B80", Slot = "10")]
		[DebuggerNonUserCode]
		public VillageObjectLimitData Clone()
		{
			//Discarded unreachable code: IL_004c
			VillageObjectLimitData villageObjectLimitData = new VillageObjectLimitData();
			int num = (villageObjectLimitData.uniqueLimit_ = uniqueLimit_);
			int num2 = (villageObjectLimitData.instanceLimit_ = instanceLimit_);
			RepeatedField<ItemTypeSelector> repeatedField = (villageObjectLimitData.exclusions_ = (RepeatedField<ItemTypeSelector>)(object)((RepeatedField<T>)(object)exclusions_).Clone());
			UnknownFieldSet unknownFieldSet = (villageObjectLimitData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return villageObjectLimitData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D89")]
		[Cpp2IlInjected.Address(RVA = "0x17C2DB0", Offset = "0x17C17B0", VA = "0x1817C2DB0", Slot = "0")]
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
				if ((IntPtr)uniqueLimit_ == (IntPtr)typeof(VillageObjectLimitData).TypeHandle && (IntPtr)instanceLimit_ == (IntPtr)typeof(VillageObjectLimitData).TypeHandle)
				{
					RepeatedField<ItemTypeSelector> repeatedField = exclusions_;
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

		[Cpp2IlInjected.Token(Token = "0x6004D8A")]
		[Cpp2IlInjected.Address(RVA = "0x17C2EA0", Offset = "0x17C18A0", VA = "0x1817C2EA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(VillageObjectLimitData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.uniqueLimit_;
				if (uniqueLimit_ == num)
				{
					int num2 = other.instanceLimit_;
					if (instanceLimit_ == num2)
					{
						RepeatedField<ItemTypeSelector> repeatedField = exclusions_;
						RepeatedField<ItemTypeSelector> repeatedField2 = other.exclusions_;
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

		[Cpp2IlInjected.Token(Token = "0x6004D8B")]
		[Cpp2IlInjected.Address(RVA = "0x17C3010", Offset = "0x17C1A10", VA = "0x1817C3010", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0032
			if (uniqueLimit_ != 0)
			{
			}
			if (instanceLimit_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)exclusions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8C")]
		[Cpp2IlInjected.Address(RVA = "0x17C3380", Offset = "0x17C1D80", VA = "0x1817C3380", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8D")]
		[Cpp2IlInjected.Address(RVA = "0x17C3480", Offset = "0x17C1E80", VA = "0x1817C3480", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0059
			if (uniqueLimit_ != 0)
			{
				int value = uniqueLimit_;
				output.WriteInt32(value);
			}
			if (instanceLimit_ != 0)
			{
				int value2 = instanceLimit_;
				output.WriteInt32(value2);
			}
			RepeatedField<ItemTypeSelector> repeatedField = exclusions_;
			FieldCodec<ItemTypeSelector> repeated_exclusions_codec = _repeated_exclusions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_exclusions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8E")]
		[Cpp2IlInjected.Address(RVA = "0x17C29C0", Offset = "0x17C13C0", VA = "0x1817C29C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_006e
			int num = uniqueLimit_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = instanceLimit_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			RepeatedField<ItemTypeSelector> repeatedField = exclusions_;
			FieldCodec<ItemTypeSelector> repeated_exclusions_codec = _repeated_exclusions_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_exclusions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num6;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D8F")]
		[Cpp2IlInjected.Address(RVA = "0x17C30B0", Offset = "0x17C1AB0", VA = "0x1817C30B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(VillageObjectLimitData other)
		{
			//Discarded unreachable code: IL_005d
			if (other != null)
			{
				int num = other.uniqueLimit_;
				if (num != 0)
				{
					uniqueLimit_ = num;
				}
				int num2 = other.instanceLimit_;
				if (num2 != 0)
				{
					instanceLimit_ = num2;
				}
				RepeatedField<ItemTypeSelector> repeatedField = exclusions_;
				RepeatedField<ItemTypeSelector> repeatedField2 = other.exclusions_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D90")]
		[Cpp2IlInjected.Address(RVA = "0x17C3140", Offset = "0x17C1B40", VA = "0x1817C3140", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0066
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (uniqueLimit_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (instanceLimit_ = input.ReadInt32());
				}
				if (num3 == 26)
				{
					RepeatedField<ItemTypeSelector> repeatedField = exclusions_;
					FieldCodec<ItemTypeSelector> repeated_exclusions_codec = _repeated_exclusions_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_exclusions_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D91")]
		[Cpp2IlInjected.Address(RVA = "0x17C2F40", Offset = "0x17C1940", VA = "0x1817C2F40", Slot = "11")]
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
				RepeatedField<ItemTypeSelector> repeatedField = exclusions_;
			}
			int num2 = uniqueLimit_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D92")]
		[Cpp2IlInjected.Address(RVA = "0x17C3260", Offset = "0x17C1C60", VA = "0x1817C3260", Slot = "12")]
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
				instanceLimit_ = (int)obj;
			}
			else
			{
				object obj2 = default(object);
				uniqueLimit_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D93")]
		[Cpp2IlInjected.Address(RVA = "0x17C2AF0", Offset = "0x17C14F0", VA = "0x1817C2AF0", Slot = "13")]
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
					RepeatedField<ItemTypeSelector> repeatedField = exclusions_;
					break;
				}
				case 0:
					break;
				default:
					return;
				}
				instanceLimit_ = 0;
			}
			else
			{
				uniqueLimit_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D94")]
		[Cpp2IlInjected.Address(RVA = "0x17C2C50", Offset = "0x17C1650", VA = "0x1817C2C50")]
		public static VillageObjectLimitData Combine(VillageObjectLimitData limitA, VillageObjectLimitData limitB)
		{
			//Discarded unreachable code: IL_0055
			VillageObjectLimitData villageObjectLimitData = new VillageObjectLimitData();
			int num = limitA.uniqueLimit_;
			RepeatedField<ItemTypeSelector> repeatedField = villageObjectLimitData.exclusions_;
			villageObjectLimitData.uniqueLimit_ = num;
			int num2 = (villageObjectLimitData.instanceLimit_ = limitA.instanceLimit_);
			RepeatedField<ItemTypeSelector> repeatedField2 = limitA.exclusions_;
			RepeatedField<ItemTypeSelector> repeatedField3 = limitB.exclusions_;
			HashSet<ItemTypeSelector> hashSet = (HashSet<ItemTypeSelector>)(object)new HashSet<T>((IEqualityComparer<>)(object)repeatedField2);
			((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)(object)repeatedField3);
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)hashSet);
			return villageObjectLimitData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004D95")]
		[Cpp2IlInjected.Address(RVA = "0x17C3590", Offset = "0x17C1F90", VA = "0x1817C3590")]
		static VillageObjectLimitData()
		{
			Func<VillageObjectLimitData> func = default(Func<VillageObjectLimitData>);
			_parser = (MessageParser<VillageObjectLimitData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ItemTypeSelector> parser = ItemTypeSelector._parser;
			uint num = default(uint);
			_parser = (MessageParser<VillageObjectLimitData>)(object)FieldCodec.ForMessage<ItemTypeSelector>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
