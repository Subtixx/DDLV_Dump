using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	public sealed class CropSubTypeFilter : IMessage<CropSubTypeFilter>, IMessage, IEquatable<CropSubTypeFilter>, IDeepCloneable<CropSubTypeFilter>, IMessageFieldAccessor, ISubTypeFilter
	{
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private static readonly MessageParser<CropSubTypeFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public const int ValuesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private static readonly FieldCodec<CropType> _repeated_values_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private readonly RepeatedField<CropType> values_ = (RepeatedField<CropType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170003A3")]
		[DebuggerNonUserCode]
		public static MessageParser<CropSubTypeFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000F8C")]
			[Cpp2IlInjected.Address(RVA = "0x2D42690", Offset = "0x2D41090", VA = "0x182D42690")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F8D")]
			[Cpp2IlInjected.Address(RVA = "0x2D425C0", Offset = "0x2D40FC0", VA = "0x182D425C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F8E")]
			[Cpp2IlInjected.Address(RVA = "0x2D426F0", Offset = "0x2D410F0", VA = "0x182D426F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A6")]
		[DebuggerNonUserCode]
		public RepeatedField<CropType> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F92")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F8F")]
		[Cpp2IlInjected.Address(RVA = "0x2D42540", Offset = "0x2D40F40", VA = "0x182D42540")]
		[DebuggerNonUserCode]
		public CropSubTypeFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F90")]
		[Cpp2IlInjected.Address(RVA = "0x2D42440", Offset = "0x2D40E40", VA = "0x182D42440")]
		[DebuggerNonUserCode]
		public CropSubTypeFilter(CropSubTypeFilter other)
		{
			RepeatedField<CropType> repeatedField = (values_ = (RepeatedField<CropType>)(object)((RepeatedField<T>)(object)other.values_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F91")]
		[Cpp2IlInjected.Address(RVA = "0x2D41B10", Offset = "0x2D40510", VA = "0x182D41B10", Slot = "10")]
		[DebuggerNonUserCode]
		public CropSubTypeFilter Clone()
		{
			//Discarded unreachable code: IL_003b
			CropSubTypeFilter cropSubTypeFilter = new CropSubTypeFilter();
			RepeatedField<CropType> repeatedField = (cropSubTypeFilter.values_ = (RepeatedField<CropType>)(object)new RepeatedField<T>());
			RepeatedField<CropType> repeatedField2 = (cropSubTypeFilter.values_ = (RepeatedField<CropType>)(object)((RepeatedField<T>)(object)values_).Clone());
			UnknownFieldSet unknownFieldSet = (cropSubTypeFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return cropSubTypeFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F93")]
		[Cpp2IlInjected.Address(RVA = "0x2D41CD0", Offset = "0x2D406D0", VA = "0x182D41CD0", Slot = "0")]
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
				RepeatedField<CropType> repeatedField = values_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F94")]
		[Cpp2IlInjected.Address(RVA = "0x2D41C40", Offset = "0x2D40640", VA = "0x182D41C40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CropSubTypeFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<CropType> repeatedField = values_;
				RepeatedField<CropType> repeatedField2 = other.values_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F95")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)values_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F96")]
		[Cpp2IlInjected.Address(RVA = "0x2D42100", Offset = "0x2D40B00", VA = "0x182D42100", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F97")]
		[Cpp2IlInjected.Address(RVA = "0x2D42160", Offset = "0x2D40B60", VA = "0x182D42160", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<CropType> repeatedField = values_;
			FieldCodec<CropType> repeated_values_codec = _repeated_values_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_values_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F98")]
		[Cpp2IlInjected.Address(RVA = "0x2D41A00", Offset = "0x2D40400", VA = "0x182D41A00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<CropType> repeatedField = values_;
			FieldCodec<CropType> repeated_values_codec = _repeated_values_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_values_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F99")]
		[Cpp2IlInjected.Address(RVA = "0x2D41F30", Offset = "0x2D40930", VA = "0x182D41F30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CropSubTypeFilter other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<CropType> repeatedField = values_;
				RepeatedField<CropType> repeatedField2 = other.values_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F9A")]
		[Cpp2IlInjected.Address(RVA = "0x2D41FB0", Offset = "0x2D409B0", VA = "0x182D41FB0", Slot = "5")]
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
				RepeatedField<CropType> repeatedField = values_;
				FieldCodec<CropType> repeated_values_codec = _repeated_values_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_values_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F9B")]
		[Cpp2IlInjected.Address(RVA = "0x2D41DB0", Offset = "0x2D407B0", VA = "0x182D41DB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<CropType> repeatedField = values_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F9C")]
		[Cpp2IlInjected.Address(RVA = "0x2D420A0", Offset = "0x2D40AA0", VA = "0x182D420A0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F9D")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AB0", Offset = "0x2D404B0", VA = "0x182D41AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<CropType> repeatedField = values_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F9E")]
		[Cpp2IlInjected.Address(RVA = "0x2D41E30", Offset = "0x2D40830", VA = "0x182D41E30", Slot = "14")]
		public bool IsValid(ItemDatabase itemDb, Item item)
		{
			int num = 0;
			ItemType itemType = default(ItemType);
			bool flag = default(bool);
			ActivityItemType activityItemType = default(ActivityItemType);
			bool flag2 = default(bool);
			if (itemType == ItemType.ActivityItem && flag && activityItemType == ActivityItemType.Crop && flag2)
			{
				RepeatedField<CropType> repeatedField = values_;
				bool result = default(bool);
				return result;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F9F")]
		[Cpp2IlInjected.Address(RVA = "0x2D42220", Offset = "0x2D40C20", VA = "0x182D42220")]
		static CropSubTypeFilter()
		{
			Func<CropSubTypeFilter> func = default(Func<CropSubTypeFilter>);
			MessageParser<CropSubTypeFilter> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<CropSubTypeFilter>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<CropType, int> func2 = (Func<CropType, int>)(object)(Func<T, TResult>)((CropType x) => (int)x);
			Func<int, CropType> func3 = (Func<int, CropType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<CropSubTypeFilter>)(object)FieldCodec.ForEnum<CropType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
