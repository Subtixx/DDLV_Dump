using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x200078A")]
	public sealed class ItemSelectorFieldOptions : IMessage<ItemSelectorFieldOptions>, IMessage, IEquatable<ItemSelectorFieldOptions>, IDeepCloneable<ItemSelectorFieldOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40025C5")]
		private static readonly MessageParser<ItemSelectorFieldOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40025C6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40025C7")]
		public const int HideItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025C8")]
		private bool hideItem_;

		[Cpp2IlInjected.Token(Token = "0x40025C9")]
		public const int HideItemListFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40025CA")]
		private bool hideItemList_;

		[Cpp2IlInjected.Token(Token = "0x40025CB")]
		public const int HideItemGeneratorFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x40025CC")]
		private bool hideItemGenerator_;

		[Cpp2IlInjected.Token(Token = "0x40025CD")]
		public const int HideFilterGeneratorFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x40025CE")]
		private bool hideFilterGenerator_;

		[Cpp2IlInjected.Token(Token = "0x40025CF")]
		public const int HideVariableFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40025D0")]
		private bool hideVariable_;

		[Cpp2IlInjected.Token(Token = "0x40025D1")]
		public const int ManualFilterFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x40025D2")]
		private bool manualFilter_;

		[Cpp2IlInjected.Token(Token = "0x17001508")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemSelectorFieldOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600530D")]
			[Cpp2IlInjected.Address(RVA = "0x63C100", Offset = "0x63AB00", VA = "0x18063C100")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001509")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600530E")]
			[Cpp2IlInjected.Address(RVA = "0x63BFD0", Offset = "0x63A9D0", VA = "0x18063BFD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700150A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600530F")]
			[Cpp2IlInjected.Address(RVA = "0x63C160", Offset = "0x63AB60", VA = "0x18063C160", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700150B")]
		[DebuggerNonUserCode]
		public bool HideItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005313")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return hideItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005314")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				hideItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700150C")]
		[DebuggerNonUserCode]
		public bool HideItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6005315")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return hideItemList_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005316")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			set
			{
				hideItemList_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700150D")]
		[DebuggerNonUserCode]
		public bool HideItemGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6005317")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get
			{
				return hideItemGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005318")]
			[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
			set
			{
				hideItemGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700150E")]
		[DebuggerNonUserCode]
		public bool HideFilterGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6005319")]
			[Cpp2IlInjected.Address(RVA = "0x63C0A0", Offset = "0x63AAA0", VA = "0x18063C0A0")]
			get
			{
				return hideFilterGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x600531A")]
			[Cpp2IlInjected.Address(RVA = "0x63C270", Offset = "0x63AC70", VA = "0x18063C270")]
			set
			{
				hideFilterGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700150F")]
		[DebuggerNonUserCode]
		public bool HideVariable
		{
			[Cpp2IlInjected.Token(Token = "0x600531B")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return hideVariable_;
			}
			[Cpp2IlInjected.Token(Token = "0x600531C")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				hideVariable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001510")]
		[DebuggerNonUserCode]
		public bool ManualFilter
		{
			[Cpp2IlInjected.Token(Token = "0x600531D")]
			[Cpp2IlInjected.Address(RVA = "0x63C0F0", Offset = "0x63AAF0", VA = "0x18063C0F0")]
			get
			{
				return manualFilter_;
			}
			[Cpp2IlInjected.Token(Token = "0x600531E")]
			[Cpp2IlInjected.Address(RVA = "0x63C2C0", Offset = "0x63ACC0", VA = "0x18063C2C0")]
			set
			{
				manualFilter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005310")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemSelectorFieldOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005311")]
		[Cpp2IlInjected.Address(RVA = "0x63BF60", Offset = "0x63A960", VA = "0x18063BF60")]
		[DebuggerNonUserCode]
		public ItemSelectorFieldOptions(ItemSelectorFieldOptions other)
		{
			bool flag = (hideItem_ = other.hideItem_);
			bool flag2 = (hideItemList_ = other.hideItemList_);
			bool flag3 = (hideItemGenerator_ = other.hideItemGenerator_);
			bool flag4 = (hideFilterGenerator_ = other.hideFilterGenerator_);
			bool flag5 = (hideVariable_ = other.hideVariable_);
			bool flag6 = (manualFilter_ = other.manualFilter_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005312")]
		[Cpp2IlInjected.Address(RVA = "0x63B590", Offset = "0x639F90", VA = "0x18063B590", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemSelectorFieldOptions Clone()
		{
			//Discarded unreachable code: IL_0077
			ItemSelectorFieldOptions itemSelectorFieldOptions = new ItemSelectorFieldOptions();
			bool flag = (itemSelectorFieldOptions.hideItem_ = hideItem_);
			bool flag2 = (itemSelectorFieldOptions.hideItemList_ = hideItemList_);
			bool flag3 = (itemSelectorFieldOptions.hideItemGenerator_ = hideItemGenerator_);
			bool flag4 = (itemSelectorFieldOptions.hideFilterGenerator_ = hideFilterGenerator_);
			bool flag5 = (itemSelectorFieldOptions.hideVariable_ = hideVariable_);
			bool flag6 = (itemSelectorFieldOptions.manualFilter_ = manualFilter_);
			UnknownFieldSet unknownFieldSet = (itemSelectorFieldOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemSelectorFieldOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x600531F")]
		[Cpp2IlInjected.Address(RVA = "0x63B630", Offset = "0x63A030", VA = "0x18063B630", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(hideItem_ ? 1 : 0) == (IntPtr)typeof(ItemSelectorFieldOptions).TypeHandle && (IntPtr)(hideItemList_ ? 1 : 0) == (IntPtr)typeof(ItemSelectorFieldOptions).TypeHandle && (IntPtr)(hideItemGenerator_ ? 1 : 0) == (IntPtr)typeof(ItemSelectorFieldOptions).TypeHandle && (IntPtr)(hideFilterGenerator_ ? 1 : 0) == (IntPtr)typeof(ItemSelectorFieldOptions).TypeHandle && (IntPtr)(hideVariable_ ? 1 : 0) == (IntPtr)typeof(ItemSelectorFieldOptions).TypeHandle && (IntPtr)(manualFilter_ ? 1 : 0) == (IntPtr)typeof(ItemSelectorFieldOptions).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005320")]
		[Cpp2IlInjected.Address(RVA = "0x63B6F0", Offset = "0x63A0F0", VA = "0x18063B6F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemSelectorFieldOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.hideItem_;
				if (hideItem_ == flag)
				{
					bool flag2 = other.hideItemList_;
					if (hideItemList_ == flag2)
					{
						bool flag3 = other.hideItemGenerator_;
						if (hideItemGenerator_ == flag3)
						{
							bool flag4 = other.hideFilterGenerator_;
							if (hideFilterGenerator_ == flag4)
							{
								bool flag5 = other.hideVariable_;
								if (hideVariable_ == flag5)
								{
									bool flag6 = other.manualFilter_;
									if (manualFilter_ == flag6)
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										return object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005321")]
		[Cpp2IlInjected.Address(RVA = "0x63B850", Offset = "0x63A250", VA = "0x18063B850", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (hideItem_)
				{
				}
				if (hideItemList_)
				{
				}
				if (hideItemGenerator_)
				{
				}
				if (hideFilterGenerator_)
				{
				}
				if (hideVariable_)
				{
				}
				if (manualFilter_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005322")]
		[Cpp2IlInjected.Address(RVA = "0x63BCC0", Offset = "0x63A6C0", VA = "0x18063BCC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005323")]
		[Cpp2IlInjected.Address(RVA = "0x63BD20", Offset = "0x63A720", VA = "0x18063BD20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a4
			if (hideItem_)
			{
				bool value = hideItem_;
				output.WriteBool(value);
			}
			if (hideItemList_)
			{
				bool value2 = hideItemList_;
				output.WriteBool(value2);
			}
			if (hideItemGenerator_)
			{
				bool value3 = hideItemGenerator_;
				output.WriteBool(value3);
			}
			if (hideFilterGenerator_)
			{
				bool value4 = hideFilterGenerator_;
				output.WriteBool(value4);
			}
			if (hideVariable_)
			{
				bool value5 = hideVariable_;
				output.WriteBool(value5);
			}
			if (manualFilter_)
			{
				bool value6 = manualFilter_;
				output.WriteBool(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005324")]
		[Cpp2IlInjected.Address(RVA = "0x63B4C0", Offset = "0x639EC0", VA = "0x18063B4C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x6005325")]
		[Cpp2IlInjected.Address(RVA = "0x63B940", Offset = "0x63A340", VA = "0x18063B940", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemSelectorFieldOptions other)
		{
			if (other != null)
			{
				bool flag = other.hideItem_;
				if (flag)
				{
					hideItem_ = flag;
				}
				bool flag2 = other.hideItemList_;
				if (flag2)
				{
					hideItemList_ = flag2;
				}
				bool flag3 = other.hideItemGenerator_;
				if (flag3)
				{
					hideItemGenerator_ = flag3;
				}
				bool flag4 = other.hideFilterGenerator_;
				if (flag4)
				{
					hideFilterGenerator_ = flag4;
				}
				bool flag5 = other.hideVariable_;
				if (flag5)
				{
					hideVariable_ = flag5;
				}
				bool flag6 = other.manualFilter_;
				if (flag6)
				{
					manualFilter_ = flag6;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005326")]
		[Cpp2IlInjected.Address(RVA = "0x63B9D0", Offset = "0x63A3D0", VA = "0x18063B9D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a5
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 32)
				{
					bool flag = (hideFilterGenerator_ = input.ReadBool());
				}
				bool flag2 = default(bool);
				if (num == 40)
				{
					flag2 = (hideVariable_ = input.ReadBool());
				}
				if (!flag2)
				{
					goto IL_008e;
				}
				bool flag3 = (manualFilter_ = input.ReadBool());
			}
			bool flag4 = default(bool);
			if (num == 8)
			{
				flag4 = (hideItem_ = input.ReadBool());
			}
			bool flag5 = default(bool);
			if (flag4)
			{
				flag5 = (hideItemList_ = input.ReadBool());
			}
			if (flag5)
			{
				bool flag6 = (hideItemGenerator_ = input.ReadBool());
			}
			goto IL_008e;
			IL_008e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005327")]
		[Cpp2IlInjected.Address(RVA = "0x63B750", Offset = "0x63A150", VA = "0x18063B750", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				bool flag = hideItem_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005328")]
		[Cpp2IlInjected.Address(RVA = "0x63BAC0", Offset = "0x63A4C0", VA = "0x18063BAC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				hideItem_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005329")]
		[Cpp2IlInjected.Address(RVA = "0x63B530", Offset = "0x639F30", VA = "0x18063B530", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0014, IL_001c, IL_0024, IL_002c
			if (fieldNumber <= 5)
			{
				hideItem_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600532A")]
		[Cpp2IlInjected.Address(RVA = "0x63BE50", Offset = "0x63A850", VA = "0x18063BE50")]
		static ItemSelectorFieldOptions()
		{
			Func<ItemSelectorFieldOptions> func = default(Func<ItemSelectorFieldOptions>);
			_parser = (MessageParser<ItemSelectorFieldOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
