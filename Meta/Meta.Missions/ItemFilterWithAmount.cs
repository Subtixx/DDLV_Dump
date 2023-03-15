using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200102C")]
	public sealed class ItemFilterWithAmount : IMessage<ItemFilterWithAmount>, IMessage, IEquatable<ItemFilterWithAmount>, IDeepCloneable<ItemFilterWithAmount>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4004294")]
		private static readonly MessageParser<ItemFilterWithAmount> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004295")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004296")]
		public const int ItemFilterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004297")]
		private ItemFilter itemFilter_;

		[Cpp2IlInjected.Token(Token = "0x4004298")]
		public const int TargetAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004299")]
		private float targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x170016B7")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemFilterWithAmount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008314")]
			[Cpp2IlInjected.Address(RVA = "0x17132A0", Offset = "0x1711CA0", VA = "0x1817132A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008315")]
			[Cpp2IlInjected.Address(RVA = "0x17131D0", Offset = "0x1711BD0", VA = "0x1817131D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016B9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008316")]
			[Cpp2IlInjected.Address(RVA = "0x1713300", Offset = "0x1711D00", VA = "0x181713300", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BA")]
		[DebuggerNonUserCode]
		public ItemFilter ItemFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600831A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemFilter_;
			}
			[Cpp2IlInjected.Token(Token = "0x600831B")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				itemFilter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016BB")]
		[DebuggerNonUserCode]
		public float TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600831C")]
			[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600831D")]
			[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
			set
			{
				targetAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008317")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemFilterWithAmount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008318")]
		[Cpp2IlInjected.Address(RVA = "0x17130D0", Offset = "0x1711AD0", VA = "0x1817130D0")]
		[DebuggerNonUserCode]
		public ItemFilterWithAmount(ItemFilterWithAmount other)
		{
			//IL_0034: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			ItemFilter itemFilter = other.itemFilter_;
			if (itemFilter != null)
			{
				ItemFilter itemFilter2 = new ItemFilter();
				ItemFilterData data_ = itemFilter.data_;
				if (data_ != null)
				{
					ItemFilterData itemFilterData = data_.Clone();
				}
				int num = 0;
				itemFilter2.data_ = (ItemFilterData)num;
				UnknownFieldSet unknownFieldSet = (itemFilter2._unknownFields = UnknownFieldSet.Clone(itemFilter._unknownFields));
			}
			int num2 = 0;
			itemFilter_ = (ItemFilter)num2;
			float num3 = (targetAmount_ = other.targetAmount_);
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008319")]
		[Cpp2IlInjected.Address(RVA = "0x1712660", Offset = "0x1711060", VA = "0x181712660", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemFilterWithAmount Clone()
		{
			//Discarded unreachable code: IL_007c
			//IL_0035: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			ItemFilterWithAmount itemFilterWithAmount = new ItemFilterWithAmount();
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter != null)
			{
				ItemFilter itemFilter2 = new ItemFilter();
				ItemFilterData data_ = itemFilter.data_;
				if (data_ != null)
				{
					ItemFilterData itemFilterData = data_.Clone();
				}
				int num = 0;
				itemFilter2.data_ = (ItemFilterData)num;
				UnknownFieldSet unknownFieldSet = (itemFilter2._unknownFields = UnknownFieldSet.Clone(itemFilter._unknownFields));
			}
			int num2 = 0;
			itemFilterWithAmount.itemFilter_ = (ItemFilter)num2;
			float num3 = (itemFilterWithAmount.targetAmount_ = targetAmount_);
			UnknownFieldSet unknownFieldSet2 = (itemFilterWithAmount._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemFilterWithAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x600831E")]
		[Cpp2IlInjected.Address(RVA = "0x1712870", Offset = "0x1711270", VA = "0x181712870", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(itemFilter_, other))
				{
					UnknownFieldSet unknownFields = _unknownFields;
					bool result = default(bool);
					return result;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600831F")]
		[Cpp2IlInjected.Address(RVA = "0x1712790", Offset = "0x1711190", VA = "0x181712790", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemFilterWithAmount other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemFilter objB = other.itemFilter_;
				if (object.Equals(itemFilter_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008320")]
		[Cpp2IlInjected.Address(RVA = "0x1712A60", Offset = "0x1711460", VA = "0x181712A60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0034
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter != null)
			{
				int hashCode = itemFilter.GetHashCode();
			}
			if (itemFilter != null)
			{
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6008321")]
		[Cpp2IlInjected.Address(RVA = "0x1712ED0", Offset = "0x17118D0", VA = "0x181712ED0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008322")]
		[Cpp2IlInjected.Address(RVA = "0x1712F30", Offset = "0x1711930", VA = "0x181712F30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003e
			if ((long)itemFilter_ != 0)
			{
				ItemFilter value = itemFilter_;
				output.WriteMessage(value);
			}
			if (output != null)
			{
				float value2 = targetAmount_;
				output.WriteFloat(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008323")]
		[Cpp2IlInjected.Address(RVA = "0x17125B0", Offset = "0x1710FB0", VA = "0x1817125B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemFilter itemFilter = itemFilter_;
				num = 0;
				if (itemFilter != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemFilter);
				}
				num += 5;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008324")]
		[Cpp2IlInjected.Address(RVA = "0x1712B90", Offset = "0x1711590", VA = "0x181712B90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemFilterWithAmount other)
		{
			//Discarded unreachable code: IL_00c8
			if (other == null)
			{
				return;
			}
			ItemFilter itemFilter = other.itemFilter_;
			ItemFilterData data_ = default(ItemFilterData);
			if (itemFilter != null)
			{
				ItemFilter itemFilter2 = itemFilter_;
				if (itemFilter2 == null)
				{
					ItemFilter itemFilter3 = (itemFilter_ = new ItemFilter());
					ItemFilter itemFilter4 = itemFilter_;
				}
				if (itemFilter != null)
				{
					if ((long)itemFilter.data_ != 0)
					{
						if (itemFilter2.data_ == null)
						{
							ItemFilterData itemFilterData = (itemFilter2.data_ = new ItemFilterData());
							data_ = itemFilter2.data_;
						}
						ItemFilterData data_2 = itemFilter.data_;
						data_.MergeFrom(data_2);
					}
					UnknownFieldSet unknownFields = itemFilter._unknownFields;
					UnknownFieldSet unknownFieldSet = (itemFilter2._unknownFields = UnknownFieldSet.MergeFrom(itemFilter2._unknownFields, unknownFields));
				}
			}
			float num = other.targetAmount_;
			if (data_ != null)
			{
				targetAmount_ = num;
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6008325")]
		[Cpp2IlInjected.Address(RVA = "0x1712D10", Offset = "0x1711710", VA = "0x181712D10", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ItemFilter itemFilter = itemFilter_;
				if (itemFilter == null)
				{
					ItemFilter itemFilter2 = (itemFilter_ = new ItemFilter());
				}
				input.ReadMessage(itemFilter);
			}
			if (num == 21)
			{
				float num2 = (targetAmount_ = input.ReadFloat());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008326")]
		[Cpp2IlInjected.Address(RVA = "0x1712990", Offset = "0x1711390", VA = "0x181712990", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemFilter itemFilter = itemFilter_;
			}
			if (fieldNumber == 2)
			{
				float num = targetAmount_;
				return typeof(float).TypeHandle;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008327")]
		[Cpp2IlInjected.Address(RVA = "0x1712E00", Offset = "0x1711800", VA = "0x181712E00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected F4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				itemFilter_ = (ItemFilter)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				targetAmount_ = (float)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008328")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				targetAmount_ = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008329")]
		[Cpp2IlInjected.Address(RVA = "0x1712FC0", Offset = "0x17119C0", VA = "0x181712FC0")]
		static ItemFilterWithAmount()
		{
			Func<ItemFilterWithAmount> func = default(Func<ItemFilterWithAmount>);
			_parser = (MessageParser<ItemFilterWithAmount>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
