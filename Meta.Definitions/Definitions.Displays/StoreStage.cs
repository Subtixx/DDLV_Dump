using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x2000758")]
	public sealed class StoreStage : IMessage<StoreStage>, IMessage, IEquatable<StoreStage>, IDeepCloneable<StoreStage>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000759")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200075A")]
			public sealed class SequenceEntry : IMessage<SequenceEntry>, IMessage, IEquatable<SequenceEntry>, IDeepCloneable<SequenceEntry>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40024A9")]
				private static readonly MessageParser<SequenceEntry> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40024AA")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40024AB")]
				public const int LayoutTypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40024AC")]
				private LayoutType layoutType_;

				[Cpp2IlInjected.Token(Token = "0x40024AD")]
				public const int ItemsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40024AE")]
				private ItemsSequence items_;

				[Cpp2IlInjected.Token(Token = "0x1700149E")]
				[DebuggerNonUserCode]
				public static MessageParser<SequenceEntry> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600513C")]
					[Cpp2IlInjected.Address(RVA = "0x23747B0", Offset = "0x23731B0", VA = "0x1823747B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700149F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600513D")]
					[Cpp2IlInjected.Address(RVA = "0x2374730", Offset = "0x2373130", VA = "0x182374730")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170014A0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600513E")]
					[Cpp2IlInjected.Address(RVA = "0x2374810", Offset = "0x2373210", VA = "0x182374810", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170014A1")]
				[DebuggerNonUserCode]
				public LayoutType LayoutType
				{
					[Cpp2IlInjected.Token(Token = "0x6005142")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(LayoutType);
					}
					[Cpp2IlInjected.Token(Token = "0x6005143")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170014A2")]
				[DebuggerNonUserCode]
				public ItemsSequence Items
				{
					[Cpp2IlInjected.Token(Token = "0x6005144")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005145")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600513F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public SequenceEntry()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005140")]
				[Cpp2IlInjected.Address(RVA = "0x23746C0", Offset = "0x23730C0", VA = "0x1823746C0")]
				[DebuggerNonUserCode]
				public SequenceEntry(SequenceEntry other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005141")]
				[Cpp2IlInjected.Address(RVA = "0x2374090", Offset = "0x2372A90", VA = "0x182374090", Slot = "10")]
				[DebuggerNonUserCode]
				public SequenceEntry Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005146")]
				[Cpp2IlInjected.Address(RVA = "0x2374130", Offset = "0x2372B30", VA = "0x182374130", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005147")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(SequenceEntry other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005148")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005149")]
				[Cpp2IlInjected.Address(RVA = "0x2374550", Offset = "0x2372F50", VA = "0x182374550", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600514A")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600514B")]
				[Cpp2IlInjected.Address(RVA = "0x2373FC0", Offset = "0x23729C0", VA = "0x182373FC0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600514C")]
				[Cpp2IlInjected.Address(RVA = "0x23743A0", Offset = "0x2372DA0", VA = "0x1823743A0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(SequenceEntry other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600514D")]
				[Cpp2IlInjected.Address(RVA = "0x23742B0", Offset = "0x2372CB0", VA = "0x1823742B0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600514E")]
				[Cpp2IlInjected.Address(RVA = "0x23741E0", Offset = "0x2372BE0", VA = "0x1823741E0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600514F")]
				[Cpp2IlInjected.Address(RVA = "0x2374480", Offset = "0x2372E80", VA = "0x182374480", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005150")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40024A1")]
		private static readonly MessageParser<StoreStage> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024A2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024A3")]
		public const int LayoutsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40024A4")]
		private static readonly FieldCodec<LayoutInfo> _repeated_layouts_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024A5")]
		private readonly RepeatedField<LayoutInfo> layouts_ = (RepeatedField<LayoutInfo>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40024A6")]
		public const int ItemsSequenceFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40024A7")]
		private static readonly FieldCodec<Types.SequenceEntry> _repeated_itemsSequence_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024A8")]
		private readonly RepeatedField<Types.SequenceEntry> itemsSequence_ = (RepeatedField<Types.SequenceEntry>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001499")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreStage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005128")]
			[Cpp2IlInjected.Address(RVA = "0x2554420", Offset = "0x2552E20", VA = "0x182554420")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700149A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005129")]
			[Cpp2IlInjected.Address(RVA = "0x2554350", Offset = "0x2552D50", VA = "0x182554350")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700149B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600512A")]
			[Cpp2IlInjected.Address(RVA = "0x2554480", Offset = "0x2552E80", VA = "0x182554480", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700149C")]
		[DebuggerNonUserCode]
		public RepeatedField<LayoutInfo> Layouts
		{
			[Cpp2IlInjected.Token(Token = "0x600512E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return layouts_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700149D")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.SequenceEntry> ItemsSequence
		{
			[Cpp2IlInjected.Token(Token = "0x600512F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemsSequence_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600512B")]
		[Cpp2IlInjected.Address(RVA = "0x2554110", Offset = "0x2552B10", VA = "0x182554110")]
		[DebuggerNonUserCode]
		public StoreStage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600512C")]
		[Cpp2IlInjected.Address(RVA = "0x25541D0", Offset = "0x2552BD0", VA = "0x1825541D0")]
		[DebuggerNonUserCode]
		public StoreStage(StoreStage other)
		{
			RepeatedField<LayoutInfo> repeatedField = (layouts_ = (RepeatedField<LayoutInfo>)(object)((RepeatedField<T>)(object)other.layouts_).Clone());
			RepeatedField<Types.SequenceEntry> repeatedField2 = (itemsSequence_ = (RepeatedField<Types.SequenceEntry>)(object)((RepeatedField<T>)(object)other.itemsSequence_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600512D")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552080", VA = "0x182553680", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreStage Clone()
		{
			//Discarded unreachable code: IL_005f
			StoreStage storeStage = new StoreStage();
			RepeatedField<LayoutInfo> repeatedField = (storeStage.layouts_ = (RepeatedField<LayoutInfo>)(object)new RepeatedField<T>());
			RepeatedField<Types.SequenceEntry> repeatedField2 = (storeStage.itemsSequence_ = (RepeatedField<Types.SequenceEntry>)(object)new RepeatedField<T>());
			RepeatedField<LayoutInfo> repeatedField3 = (storeStage.layouts_ = (RepeatedField<LayoutInfo>)(object)((RepeatedField<T>)(object)layouts_).Clone());
			RepeatedField<Types.SequenceEntry> repeatedField4 = (storeStage.itemsSequence_ = (RepeatedField<Types.SequenceEntry>)(object)((RepeatedField<T>)(object)itemsSequence_).Clone());
			UnknownFieldSet unknownFieldSet = (storeStage._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeStage;
		}

		[Cpp2IlInjected.Token(Token = "0x6005130")]
		[Cpp2IlInjected.Address(RVA = "0x2553830", Offset = "0x2552230", VA = "0x182553830", Slot = "0")]
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
				RepeatedField<LayoutInfo> repeatedField = layouts_;
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<Types.SequenceEntry> repeatedField2 = itemsSequence_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005131")]
		[Cpp2IlInjected.Address(RVA = "0x2553930", Offset = "0x2552330", VA = "0x182553930", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreStage other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<LayoutInfo> repeatedField = layouts_;
				RepeatedField<LayoutInfo> repeatedField2 = other.layouts_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					RepeatedField<Types.SequenceEntry> repeatedField3 = itemsSequence_;
					RepeatedField<Types.SequenceEntry> repeatedField4 = other.itemsSequence_;
					if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005132")]
		[Cpp2IlInjected.Address(RVA = "0x13AB0A0", Offset = "0x13A9AA0", VA = "0x1813AB0A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002c
			int hashCode = ((RepeatedField<T>)(object)layouts_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)itemsSequence_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005133")]
		[Cpp2IlInjected.Address(RVA = "0x2553D30", Offset = "0x2552730", VA = "0x182553D30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005134")]
		[Cpp2IlInjected.Address(RVA = "0x2553D90", Offset = "0x2552790", VA = "0x182553D90", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0040
			RepeatedField<LayoutInfo> repeatedField = layouts_;
			FieldCodec<LayoutInfo> repeated_layouts_codec = _repeated_layouts_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_layouts_codec);
			RepeatedField<Types.SequenceEntry> repeatedField2 = itemsSequence_;
			FieldCodec<Types.SequenceEntry> repeated_itemsSequence_codec = _repeated_itemsSequence_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_itemsSequence_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005135")]
		[Cpp2IlInjected.Address(RVA = "0x2553520", Offset = "0x2551F20", VA = "0x182553520", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			RepeatedField<LayoutInfo> repeatedField = layouts_;
			FieldCodec<LayoutInfo> repeated_layouts_codec = _repeated_layouts_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_layouts_codec);
			RepeatedField<Types.SequenceEntry> repeatedField2 = itemsSequence_;
			FieldCodec<Types.SequenceEntry> repeated_itemsSequence_codec = _repeated_itemsSequence_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_itemsSequence_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<LayoutInfo>)(repeatedField + num3);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005136")]
		[Cpp2IlInjected.Address(RVA = "0x2553BE0", Offset = "0x25525E0", VA = "0x182553BE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreStage other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				RepeatedField<LayoutInfo> repeatedField = layouts_;
				RepeatedField<LayoutInfo> repeatedField2 = other.layouts_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<Types.SequenceEntry> repeatedField3 = itemsSequence_;
				RepeatedField<Types.SequenceEntry> repeatedField4 = other.itemsSequence_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005137")]
		[Cpp2IlInjected.Address(RVA = "0x2553A80", Offset = "0x2552480", VA = "0x182553A80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005b
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<LayoutInfo> repeatedField = layouts_;
					FieldCodec<LayoutInfo> repeated_layouts_codec = _repeated_layouts_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_layouts_codec);
				}
				if (num == 18)
				{
					RepeatedField<Types.SequenceEntry> repeatedField2 = itemsSequence_;
					FieldCodec<Types.SequenceEntry> repeated_itemsSequence_codec = _repeated_itemsSequence_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsSequence_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005138")]
		[Cpp2IlInjected.Address(RVA = "0x25539F0", Offset = "0x25523F0", VA = "0x1825539F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<LayoutInfo> repeatedField = layouts_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.SequenceEntry> repeatedField2 = itemsSequence_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005139")]
		[Cpp2IlInjected.Address(RVA = "0x2553C80", Offset = "0x2552680", VA = "0x182553C80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			switch (fieldNumber)
			{
			default:
				return;
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				break;
			}
			case 2:
				break;
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600513A")]
		[Cpp2IlInjected.Address(RVA = "0x2553610", Offset = "0x2552010", VA = "0x182553610", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.SequenceEntry> repeatedField = itemsSequence_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600513B")]
		[Cpp2IlInjected.Address(RVA = "0x2553E80", Offset = "0x2552880", VA = "0x182553E80")]
		static StoreStage()
		{
			Func<StoreStage> func = default(Func<StoreStage>);
			_parser = (MessageParser<StoreStage>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<LayoutInfo> parser = LayoutInfo._parser;
			uint num = default(uint);
			_parser = (MessageParser<StoreStage>)(object)FieldCodec.ForMessage<LayoutInfo>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.SequenceEntry> parser2 = Types.SequenceEntry._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<StoreStage>)(object)FieldCodec.ForMessage<Types.SequenceEntry>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
