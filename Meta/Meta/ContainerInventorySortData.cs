using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class ContainerInventorySortData : IMessage<ContainerInventorySortData>, IMessage, IEquatable<ContainerInventorySortData>, IDeepCloneable<ContainerInventorySortData>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly MessageParser<ContainerInventorySortData> _parser = (MessageParser<ContainerInventorySortData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ContainerInventorySortData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public const int ByTypesOrderFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly FieldCodec<ActivityItemType> _repeated_byTypesOrder_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly RepeatedField<ActivityItemType> byTypesOrder_ = (RepeatedField<ActivityItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[DebuggerNonUserCode]
		public static MessageParser<ContainerInventorySortData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x18B9AB0", Offset = "0x18B84B0", VA = "0x1818B9AB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x18B99E0", Offset = "0x18B83E0", VA = "0x1818B99E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x18B9B10", Offset = "0x18B8510", VA = "0x1818B9B10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[DebuggerNonUserCode]
		public RepeatedField<ActivityItemType> ByTypesOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return byTypesOrder_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x18B9960", Offset = "0x18B8360", VA = "0x1818B9960")]
		[DebuggerNonUserCode]
		public ContainerInventorySortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x18B9860", Offset = "0x18B8260", VA = "0x1818B9860")]
		[DebuggerNonUserCode]
		public ContainerInventorySortData(ContainerInventorySortData other)
		{
			RepeatedField<ActivityItemType> repeatedField = (byTypesOrder_ = (RepeatedField<ActivityItemType>)(object)((RepeatedField<T>)(object)other.byTypesOrder_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x18B8B70", Offset = "0x18B7570", VA = "0x1818B8B70", Slot = "10")]
		[DebuggerNonUserCode]
		public ContainerInventorySortData Clone()
		{
			//Discarded unreachable code: IL_003b
			ContainerInventorySortData containerInventorySortData = new ContainerInventorySortData();
			RepeatedField<ActivityItemType> repeatedField = (containerInventorySortData.byTypesOrder_ = (RepeatedField<ActivityItemType>)(object)new RepeatedField<T>());
			RepeatedField<ActivityItemType> repeatedField2 = (containerInventorySortData.byTypesOrder_ = (RepeatedField<ActivityItemType>)(object)((RepeatedField<T>)(object)byTypesOrder_).Clone());
			UnknownFieldSet unknownFieldSet = (containerInventorySortData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return containerInventorySortData;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x18B9160", Offset = "0x18B7B60", VA = "0x1818B9160", Slot = "0")]
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
				RepeatedField<ActivityItemType> repeatedField = byTypesOrder_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x18B9240", Offset = "0x18B7C40", VA = "0x1818B9240", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ContainerInventorySortData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ActivityItemType> repeatedField = byTypesOrder_;
				RepeatedField<ActivityItemType> repeatedField2 = other.byTypesOrder_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)byTypesOrder_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x18B9520", Offset = "0x18B7F20", VA = "0x1818B9520", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x18B9580", Offset = "0x18B7F80", VA = "0x1818B9580", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<ActivityItemType> repeatedField = byTypesOrder_;
			FieldCodec<ActivityItemType> repeated_byTypesOrder_codec = _repeated_byTypesOrder_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_byTypesOrder_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x18B8A60", Offset = "0x18B7460", VA = "0x1818B8A60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<ActivityItemType> repeatedField = byTypesOrder_;
			FieldCodec<ActivityItemType> repeated_byTypesOrder_codec = _repeated_byTypesOrder_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_byTypesOrder_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x18B9350", Offset = "0x18B7D50", VA = "0x1818B9350", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ContainerInventorySortData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<ActivityItemType> repeatedField = byTypesOrder_;
				RepeatedField<ActivityItemType> repeatedField2 = other.byTypesOrder_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x18B93D0", Offset = "0x18B7DD0", VA = "0x1818B93D0", Slot = "5")]
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
				RepeatedField<ActivityItemType> repeatedField = byTypesOrder_;
				FieldCodec<ActivityItemType> repeated_byTypesOrder_codec = _repeated_byTypesOrder_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_byTypesOrder_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x18B92D0", Offset = "0x18B7CD0", VA = "0x1818B92D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ActivityItemType> repeatedField = byTypesOrder_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x18B94C0", Offset = "0x18B7EC0", VA = "0x1818B94C0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x18B8B10", Offset = "0x18B7510", VA = "0x1818B8B10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<ActivityItemType> repeatedField = byTypesOrder_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x18B8CA0", Offset = "0x18B76A0", VA = "0x1818B8CA0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_003a: Expected I4, but got O
			int num = Enumerable.Count<ActivityItemType>(Enumerable.Distinct<ActivityItemType>((IEnumerable<>)(object)byTypesOrder_));
			int count = ((RepeatedField<T>)(object)byTypesOrder_).Count;
			if (num == count)
			{
				Array values = Enum.GetValues(typeof(ActivityItemType));
				List<ActivityItemType> list = (List<ActivityItemType>)(object)new List<T>((int)list);
				if (values == null)
				{
				}
				if (list != null)
				{
					RepeatedField<ActivityItemType> repeatedField = byTypesOrder_;
					Predicate<ActivityItemType> predicate = default(Predicate<ActivityItemType>);
					int num2 = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
					Func<ActivityItemType, bool> func = default(Func<ActivityItemType, bool>);
					if (_003C_003Ec._003C_003E9__28_0 == null)
					{
						func = (Func<ActivityItemType, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							//Discarded unreachable code: IL_001c
							Type typeFromHandle = typeof(IBackpackItem);
							ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo = default(ItemDatabase.ItemTypeMetaInfo);
							Type protobufClassType = itemTypeMetaInfo.ProtobufClassType;
							return typeFromHandle.IsAssignableFrom(protobufClassType);
						});
					}
					if (Enumerable.Where<ActivityItemType>((IEnumerable<>)list, (Func<, >)(object)func).ToArray<ActivityItemType>().Length == 0)
					{
						return;
					}
					if (_003C_003Ec._003C_003E9__28_1 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)delegate(string x, ActivityItemType y)
						{
							string text = string.Format("{0}, ", "{0}, ");
							return x + text;
						};
					}
					string message = default(string);
					context.AddInvalidMemberError(message, "ByTypesOrder");
					return;
				}
				throw new InvalidCastException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x18B9640", Offset = "0x18B8040", VA = "0x1818B9640")]
		static ContainerInventorySortData()
		{
			Func<ActivityItemType, int> func = (Func<ActivityItemType, int>)(object)(Func<T, TResult>)((ActivityItemType x) => (int)x);
			Func<int, ActivityItemType> func2 = (Func<int, ActivityItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ContainerInventorySortData>)(object)FieldCodec.ForEnum<ActivityItemType>(num, (Func<, >)(object)func, (Func<, >)(object)func2);
			/*Error: Unexpected end of block*/;
		}
	}
}
