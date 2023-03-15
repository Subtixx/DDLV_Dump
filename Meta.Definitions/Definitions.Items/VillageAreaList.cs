using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200041A")]
	public sealed class VillageAreaList : IMessage<VillageAreaList>, IMessage, IEquatable<VillageAreaList>, IDeepCloneable<VillageAreaList>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001670")]
		private static readonly MessageParser<VillageAreaList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001671")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001672")]
		public const int AreaListFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001673")]
		private static readonly FieldCodec<VillageAreaType> _repeated_areaList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001674")]
		private readonly RepeatedField<VillageAreaType> areaList_ = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000CDD")]
		[DebuggerNonUserCode]
		public static MessageParser<VillageAreaList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003229")]
			[Cpp2IlInjected.Address(RVA = "0x17C2850", Offset = "0x17C1250", VA = "0x1817C2850")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600322A")]
			[Cpp2IlInjected.Address(RVA = "0x17C2780", Offset = "0x17C1180", VA = "0x1817C2780")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600322B")]
			[Cpp2IlInjected.Address(RVA = "0x17C28B0", Offset = "0x17C12B0", VA = "0x1817C28B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE0")]
		[DebuggerNonUserCode]
		public RepeatedField<VillageAreaType> AreaList
		{
			[Cpp2IlInjected.Token(Token = "0x600322F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return areaList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600322C")]
		[Cpp2IlInjected.Address(RVA = "0x17C2600", Offset = "0x17C1000", VA = "0x1817C2600")]
		[DebuggerNonUserCode]
		public VillageAreaList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600322D")]
		[Cpp2IlInjected.Address(RVA = "0x17C2680", Offset = "0x17C1080", VA = "0x1817C2680")]
		[DebuggerNonUserCode]
		public VillageAreaList(VillageAreaList other)
		{
			RepeatedField<VillageAreaType> repeatedField = (areaList_ = (RepeatedField<VillageAreaType>)(object)((RepeatedField<T>)(object)other.areaList_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600322E")]
		[Cpp2IlInjected.Address(RVA = "0x17C1CA0", Offset = "0x17C06A0", VA = "0x1817C1CA0", Slot = "10")]
		[DebuggerNonUserCode]
		public VillageAreaList Clone()
		{
			//Discarded unreachable code: IL_003b
			VillageAreaList villageAreaList = new VillageAreaList();
			RepeatedField<VillageAreaType> repeatedField = (villageAreaList.areaList_ = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>());
			RepeatedField<VillageAreaType> repeatedField2 = (villageAreaList.areaList_ = (RepeatedField<VillageAreaType>)(object)((RepeatedField<T>)(object)areaList_).Clone());
			UnknownFieldSet unknownFieldSet = (villageAreaList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return villageAreaList;
		}

		[Cpp2IlInjected.Token(Token = "0x6003230")]
		[Cpp2IlInjected.Address(RVA = "0x17C1F00", Offset = "0x17C0900", VA = "0x1817C1F00", Slot = "0")]
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
				RepeatedField<VillageAreaType> repeatedField = areaList_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003231")]
		[Cpp2IlInjected.Address(RVA = "0x17C1FE0", Offset = "0x17C09E0", VA = "0x1817C1FE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(VillageAreaList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<VillageAreaType> repeatedField = areaList_;
				RepeatedField<VillageAreaType> repeatedField2 = other.areaList_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003232")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)areaList_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6003233")]
		[Cpp2IlInjected.Address(RVA = "0x17C22C0", Offset = "0x17C0CC0", VA = "0x1817C22C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003234")]
		[Cpp2IlInjected.Address(RVA = "0x17C2320", Offset = "0x17C0D20", VA = "0x1817C2320", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<VillageAreaType> repeatedField = areaList_;
			FieldCodec<VillageAreaType> repeated_areaList_codec = _repeated_areaList_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_areaList_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003235")]
		[Cpp2IlInjected.Address(RVA = "0x17C1B90", Offset = "0x17C0590", VA = "0x1817C1B90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<VillageAreaType> repeatedField = areaList_;
			FieldCodec<VillageAreaType> repeated_areaList_codec = _repeated_areaList_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_areaList_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003236")]
		[Cpp2IlInjected.Address(RVA = "0x17C20F0", Offset = "0x17C0AF0", VA = "0x1817C20F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(VillageAreaList other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<VillageAreaType> repeatedField = areaList_;
				RepeatedField<VillageAreaType> repeatedField2 = other.areaList_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003237")]
		[Cpp2IlInjected.Address(RVA = "0x17C2170", Offset = "0x17C0B70", VA = "0x1817C2170", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<VillageAreaType> repeatedField = areaList_;
				FieldCodec<VillageAreaType> repeated_areaList_codec = _repeated_areaList_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_areaList_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003238")]
		[Cpp2IlInjected.Address(RVA = "0x17C2070", Offset = "0x17C0A70", VA = "0x1817C2070", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<VillageAreaType> repeatedField = areaList_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003239")]
		[Cpp2IlInjected.Address(RVA = "0x17C2260", Offset = "0x17C0C60", VA = "0x1817C2260", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600323A")]
		[Cpp2IlInjected.Address(RVA = "0x17C1C40", Offset = "0x17C0640", VA = "0x1817C1C40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<VillageAreaType> repeatedField = areaList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600323B")]
		[Cpp2IlInjected.Address(RVA = "0x17C1DD0", Offset = "0x17C07D0", VA = "0x1817C1DD0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0051
			if (((RepeatedField<T>)(object)areaList_).Count != 0)
			{
				int count = ((RepeatedField<T>)(object)areaList_).Count;
				int num = Enumerable.Count<VillageAreaType>(Enumerable.Distinct<VillageAreaType>((IEnumerable<>)(object)areaList_));
				if (count != num)
				{
					context.AddInvalidMemberError("Cannot have duplicate", "AreaList");
				}
			}
			else
			{
				context.AddInvalidMemberError("Enter at least one Biome", "AreaList");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600323C")]
		[Cpp2IlInjected.Address(RVA = "0x17C23E0", Offset = "0x17C0DE0", VA = "0x1817C23E0")]
		static VillageAreaList()
		{
			Func<VillageAreaList> func = default(Func<VillageAreaList>);
			MessageParser<VillageAreaList> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<VillageAreaList>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<VillageAreaType, int> func2 = (Func<VillageAreaType, int>)(object)(Func<T, TResult>)((VillageAreaType x) => (int)x);
			Func<int, VillageAreaType> func3 = (Func<int, VillageAreaType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<VillageAreaList>)(object)FieldCodec.ForEnum<VillageAreaType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
