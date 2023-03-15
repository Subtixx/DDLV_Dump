using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x2000739")]
	public sealed class StoreShelf : IDataValidation, IMessage<StoreShelf>, IMessage, IEquatable<StoreShelf>, IDeepCloneable<StoreShelf>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200073A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200073B")]
			public enum ItemType
			{
				[Cpp2IlInjected.Token(Token = "0x400242E")]
				[OriginalName("Feet")]
				Feet,
				[Cpp2IlInjected.Token(Token = "0x400242F")]
				[OriginalName("Back")]
				Back,
				[Cpp2IlInjected.Token(Token = "0x4002430")]
				[OriginalName("Hand")]
				Hand,
				[Cpp2IlInjected.Token(Token = "0x4002431")]
				[OriginalName("Head")]
				Head,
				[Cpp2IlInjected.Token(Token = "0x4002432")]
				[OriginalName("Neck")]
				Neck,
				[Cpp2IlInjected.Token(Token = "0x4002433")]
				[OriginalName("Top")]
				Top,
				[Cpp2IlInjected.Token(Token = "0x4002434")]
				[OriginalName("Bottom")]
				Bottom,
				[Cpp2IlInjected.Token(Token = "0x4002435")]
				[OriginalName("Costume")]
				Costume,
				[Cpp2IlInjected.Token(Token = "0x4002436")]
				[OriginalName("Jewelry")]
				Jewelry,
				[Cpp2IlInjected.Token(Token = "0x4002437")]
				[OriginalName("SmallFurniture")]
				SmallFurniture
			}

			[Cpp2IlInjected.Token(Token = "0x200073C")]
			public sealed class ItemDefinition : IMessage<ItemDefinition>, IMessage, IEquatable<ItemDefinition>, IDeepCloneable<ItemDefinition>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002438")]
				private static readonly MessageParser<ItemDefinition> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002439")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400243A")]
				public const int TypeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400243B")]
				private ItemType type_;

				[Cpp2IlInjected.Token(Token = "0x400243C")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400243D")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x17001461")]
				[DebuggerNonUserCode]
				public static MessageParser<ItemDefinition> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005004")]
					[Cpp2IlInjected.Address(RVA = "0x2371F70", Offset = "0x2370970", VA = "0x182371F70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001462")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005005")]
					[Cpp2IlInjected.Address(RVA = "0x2371EF0", Offset = "0x23708F0", VA = "0x182371EF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001463")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005006")]
					[Cpp2IlInjected.Address(RVA = "0x2371FD0", Offset = "0x23709D0", VA = "0x182371FD0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001464")]
				[DebuggerNonUserCode]
				public ItemType Type
				{
					[Cpp2IlInjected.Token(Token = "0x600500A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(ItemType);
					}
					[Cpp2IlInjected.Token(Token = "0x600500B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001465")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x600500C")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600500D")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005007")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ItemDefinition()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005008")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public ItemDefinition(ItemDefinition other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005009")]
				[Cpp2IlInjected.Address(RVA = "0x2371AA0", Offset = "0x23704A0", VA = "0x182371AA0", Slot = "10")]
				[DebuggerNonUserCode]
				public ItemDefinition Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600500E")]
				[Cpp2IlInjected.Address(RVA = "0x2371B30", Offset = "0x2370530", VA = "0x182371B30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600500F")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ItemDefinition other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005010")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005011")]
				[Cpp2IlInjected.Address(RVA = "0x2371D80", Offset = "0x2370780", VA = "0x182371D80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005012")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005013")]
				[Cpp2IlInjected.Address(RVA = "0x23719D0", Offset = "0x23703D0", VA = "0x1823719D0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005014")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ItemDefinition other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005015")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005016")]
				[Cpp2IlInjected.Address(RVA = "0x2371BC0", Offset = "0x23705C0", VA = "0x182371BC0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005017")]
				[Cpp2IlInjected.Address(RVA = "0x2371CB0", Offset = "0x23706B0", VA = "0x182371CB0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005018")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002423")]
		private static readonly MessageParser<StoreShelf> _parser = (MessageParser<StoreShelf>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new StoreShelf()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002424")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002425")]
		public const int ItemDefinitionListFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002426")]
		private static readonly FieldCodec<Types.ItemDefinition> _repeated_itemDefinitionList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002427")]
		private readonly RepeatedField<Types.ItemDefinition> itemDefinitionList_ = (RepeatedField<Types.ItemDefinition>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002428")]
		public const int ExtraAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002429")]
		private int extraAmount_;

		[Cpp2IlInjected.Token(Token = "0x400242A")]
		public const int ItemsSequenceFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400242B")]
		private static readonly FieldCodec<ItemsSequence> _repeated_itemsSequence_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400242C")]
		private readonly RepeatedField<ItemsSequence> itemsSequence_ = (RepeatedField<ItemsSequence>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700145B")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreShelf> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004FEE")]
			[Cpp2IlInjected.Address(RVA = "0x25533B0", Offset = "0x2551DB0", VA = "0x1825533B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FEF")]
			[Cpp2IlInjected.Address(RVA = "0x25532E0", Offset = "0x2551CE0", VA = "0x1825532E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FF0")]
			[Cpp2IlInjected.Address(RVA = "0x2553410", Offset = "0x2551E10", VA = "0x182553410", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145E")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.ItemDefinition> ItemDefinitionList
		{
			[Cpp2IlInjected.Token(Token = "0x6004FF4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemDefinitionList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700145F")]
		[DebuggerNonUserCode]
		public int ExtraAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6004FF5")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return extraAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FF6")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				extraAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001460")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemsSequence> ItemsSequence
		{
			[Cpp2IlInjected.Token(Token = "0x6004FF7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return itemsSequence_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FED")]
		[Cpp2IlInjected.Address(RVA = "0x25524A0", Offset = "0x2550EA0", VA = "0x1825524A0", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004a
			if (extraAmount_ <= 0)
			{
				return;
			}
			RepeatedField<Types.ItemDefinition> repeatedField = itemDefinitionList_;
			Predicate<Types.ItemDefinition> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((Types.ItemDefinition x) => x.amount_ > 0);
			}
			if (!((RepeatedField<>)(object)repeatedField).Any<Types.ItemDefinition>((Predicate<>)(object)_003C_003E9__0_))
			{
				context.AddInvalidMemberError("ItemDefinitionList must have at least one valid entry with amount greater than 0.", "ExtraAmount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF1")]
		[Cpp2IlInjected.Address(RVA = "0x2553220", Offset = "0x2551C20", VA = "0x182553220")]
		[DebuggerNonUserCode]
		public StoreShelf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF2")]
		[Cpp2IlInjected.Address(RVA = "0x2553090", Offset = "0x2551A90", VA = "0x182553090")]
		[DebuggerNonUserCode]
		public StoreShelf(StoreShelf other)
		{
			RepeatedField<Types.ItemDefinition> repeatedField = (itemDefinitionList_ = (RepeatedField<Types.ItemDefinition>)(object)((RepeatedField<T>)(object)other.itemDefinitionList_).Clone());
			int num = (extraAmount_ = other.extraAmount_);
			RepeatedField<ItemsSequence> repeatedField2 = (itemsSequence_ = (RepeatedField<ItemsSequence>)(object)((RepeatedField<T>)(object)other.itemsSequence_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF3")]
		[Cpp2IlInjected.Address(RVA = "0x25522F0", Offset = "0x2550CF0", VA = "0x1825522F0", Slot = "11")]
		[DebuggerNonUserCode]
		public StoreShelf Clone()
		{
			//Discarded unreachable code: IL_006f
			StoreShelf storeShelf = new StoreShelf();
			RepeatedField<Types.ItemDefinition> repeatedField = (storeShelf.itemDefinitionList_ = (RepeatedField<Types.ItemDefinition>)(object)new RepeatedField<T>());
			RepeatedField<ItemsSequence> repeatedField2 = (storeShelf.itemsSequence_ = (RepeatedField<ItemsSequence>)(object)new RepeatedField<T>());
			RepeatedField<Types.ItemDefinition> repeatedField3 = (storeShelf.itemDefinitionList_ = (RepeatedField<Types.ItemDefinition>)(object)((RepeatedField<T>)(object)itemDefinitionList_).Clone());
			int num = (storeShelf.extraAmount_ = extraAmount_);
			RepeatedField<ItemsSequence> repeatedField4 = (storeShelf.itemsSequence_ = (RepeatedField<ItemsSequence>)(object)((RepeatedField<T>)(object)itemsSequence_).Clone());
			UnknownFieldSet unknownFieldSet = (storeShelf._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeShelf;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF8")]
		[Cpp2IlInjected.Address(RVA = "0x2552710", Offset = "0x2551110", VA = "0x182552710", Slot = "0")]
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
				RepeatedField<Types.ItemDefinition> repeatedField = itemDefinitionList_;
				bool flag = default(bool);
				if (flag && extraAmount_ == (flag ? 1 : 0))
				{
					RepeatedField<ItemsSequence> repeatedField2 = itemsSequence_;
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

		[Cpp2IlInjected.Token(Token = "0x6004FF9")]
		[Cpp2IlInjected.Address(RVA = "0x2552650", Offset = "0x2551050", VA = "0x182552650", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(StoreShelf other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.ItemDefinition> repeatedField = itemDefinitionList_;
				RepeatedField<Types.ItemDefinition> repeatedField2 = other.itemDefinitionList_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int num = other.extraAmount_;
					if (extraAmount_ == num)
					{
						RepeatedField<ItemsSequence> repeatedField3 = itemsSequence_;
						RepeatedField<ItemsSequence> repeatedField4 = other.itemsSequence_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FFA")]
		[Cpp2IlInjected.Address(RVA = "0x7C3190", Offset = "0x7C1B90", VA = "0x1807C3190", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_003a
			int hashCode = ((RepeatedField<T>)(object)itemDefinitionList_).GetHashCode();
			if (extraAmount_ != 0)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)itemsSequence_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FFB")]
		[Cpp2IlInjected.Address(RVA = "0x2552C50", Offset = "0x2551650", VA = "0x182552C50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FFC")]
		[Cpp2IlInjected.Address(RVA = "0x2552CB0", Offset = "0x25516B0", VA = "0x182552CB0", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0059
			RepeatedField<Types.ItemDefinition> repeatedField = itemDefinitionList_;
			FieldCodec<Types.ItemDefinition> repeated_itemDefinitionList_codec = _repeated_itemDefinitionList_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemDefinitionList_codec);
			if (extraAmount_ != 0)
			{
				int value = extraAmount_;
				output.WriteInt32(value);
			}
			RepeatedField<ItemsSequence> repeatedField2 = itemsSequence_;
			FieldCodec<ItemsSequence> repeated_itemsSequence_codec = _repeated_itemsSequence_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_itemsSequence_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FFD")]
		[Cpp2IlInjected.Address(RVA = "0x2552120", Offset = "0x2550B20", VA = "0x182552120", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0073
			RepeatedField<Types.ItemDefinition> repeatedField = itemDefinitionList_;
			FieldCodec<Types.ItemDefinition> repeated_itemDefinitionList_codec = _repeated_itemDefinitionList_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemDefinitionList_codec);
			int num2 = extraAmount_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += num3;
			}
			RepeatedField<ItemsSequence> repeatedField2 = itemsSequence_;
			FieldCodec<ItemsSequence> repeated_itemsSequence_codec = _repeated_itemsSequence_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_itemsSequence_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FFE")]
		[Cpp2IlInjected.Address(RVA = "0x2552900", Offset = "0x2551300", VA = "0x182552900", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreShelf other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				RepeatedField<Types.ItemDefinition> repeatedField = itemDefinitionList_;
				RepeatedField<Types.ItemDefinition> repeatedField2 = other.itemDefinitionList_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num = other.extraAmount_;
				if (num != 0)
				{
					extraAmount_ = num;
				}
				RepeatedField<ItemsSequence> repeatedField3 = itemsSequence_;
				RepeatedField<ItemsSequence> repeatedField4 = other.itemsSequence_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FFF")]
		[Cpp2IlInjected.Address(RVA = "0x25529B0", Offset = "0x25513B0", VA = "0x1825529B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0070
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.ItemDefinition> repeatedField = itemDefinitionList_;
					FieldCodec<Types.ItemDefinition> repeated_itemDefinitionList_codec = _repeated_itemDefinitionList_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemDefinitionList_codec);
				}
				int num2 = default(int);
				if (num == 16)
				{
					num2 = (extraAmount_ = input.ReadInt32());
				}
				if (num2 == 26)
				{
					RepeatedField<ItemsSequence> repeatedField2 = itemsSequence_;
					FieldCodec<ItemsSequence> repeated_itemsSequence_codec = _repeated_itemsSequence_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsSequence_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005000")]
		[Cpp2IlInjected.Address(RVA = "0x2552820", Offset = "0x2551220", VA = "0x182552820", Slot = "12")]
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
					RepeatedField<ItemsSequence> repeatedField = itemsSequence_;
				}
				int num2 = extraAmount_;
			}
			RepeatedField<Types.ItemDefinition> repeatedField2 = itemDefinitionList_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005001")]
		[Cpp2IlInjected.Address(RVA = "0x2552B20", Offset = "0x2551520", VA = "0x182552B20", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num != 1)
				{
					object obj = default(object);
					extraAmount_ = (int)obj;
					return;
				}
			}
			else
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005002")]
		[Cpp2IlInjected.Address(RVA = "0x2552270", Offset = "0x2550C70", VA = "0x182552270", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num == 1)
				{
					extraAmount_ = 0;
				}
				return;
			}
			RepeatedField<Types.ItemDefinition> repeatedField = itemDefinitionList_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005003")]
		[Cpp2IlInjected.Address(RVA = "0x2552E00", Offset = "0x2551800", VA = "0x182552E00")]
		static StoreShelf()
		{
			MessageParser<Types.ItemDefinition> parser = Types.ItemDefinition._parser;
			uint num = default(uint);
			_parser = (MessageParser<StoreShelf>)(object)FieldCodec.ForMessage<Types.ItemDefinition>(num, (MessageParser<>)(object)parser);
			MessageParser<ItemsSequence> parser2 = Definitions.Displays.ItemsSequence._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<StoreShelf>)(object)FieldCodec.ForMessage<ItemsSequence>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
