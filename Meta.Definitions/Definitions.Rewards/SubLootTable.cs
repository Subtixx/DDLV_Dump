using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000214")]
	public sealed class SubLootTable : IMessage<SubLootTable>, IMessage, IEquatable<SubLootTable>, IDeepCloneable<SubLootTable>, IMessageFieldAccessor, IGenerator, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4000871")]
		private static readonly MessageParser<SubLootTable> _parser = (MessageParser<SubLootTable>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new SubLootTable()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000872")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000873")]
		public const int MinFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000874")]
		private int min_;

		[Cpp2IlInjected.Token(Token = "0x4000875")]
		public const int MaxFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000876")]
		private int max_;

		[Cpp2IlInjected.Token(Token = "0x4000877")]
		public const int WeightFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000878")]
		private int weight_;

		[Cpp2IlInjected.Token(Token = "0x4000879")]
		public const int EmptyFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400087A")]
		private bool empty_;

		[Cpp2IlInjected.Token(Token = "0x400087B")]
		public const int ItemsFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x400087C")]
		private static readonly FieldCodec<ItemWithState> _repeated_items_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400087D")]
		private readonly RepeatedField<ItemWithState> items_ = (RepeatedField<ItemWithState>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400087E")]
		public const int Types_FieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x400087F")]
		private static readonly FieldCodec<LootType> _repeated_types_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000880")]
		private readonly RepeatedField<LootType> types_ = (RepeatedField<LootType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000881")]
		public const int QualitiesFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4000882")]
		private static readonly FieldCodec<Quality> _repeated_qualities_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000883")]
		private readonly RepeatedField<Quality> qualities_ = (RepeatedField<Quality>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000884")]
		public const int RaritiesFieldNumber = 30;

		[Cpp2IlInjected.Token(Token = "0x4000885")]
		private static readonly FieldCodec<int> _repeated_rarities_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000886")]
		private readonly RepeatedField<int> rarities_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000887")]
		public const int MinRarityFieldNumber = 31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000888")]
		private int minRarity_;

		[Cpp2IlInjected.Token(Token = "0x4000889")]
		public const int MaxRarityFieldNumber = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400088A")]
		private int maxRarity_;

		[Cpp2IlInjected.Token(Token = "0x400088B")]
		public const int FiltersFieldNumber = 100;

		[Cpp2IlInjected.Token(Token = "0x400088C")]
		private static readonly FieldCodec<SubLootTable> _repeated_filters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400088D")]
		private readonly RepeatedField<SubLootTable> filters_ = (RepeatedField<SubLootTable>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700047C")]
		[DebuggerNonUserCode]
		public static MessageParser<SubLootTable> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001410")]
			[Cpp2IlInjected.Address(RVA = "0x255CD40", Offset = "0x255B740", VA = "0x18255CD40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001411")]
			[Cpp2IlInjected.Address(RVA = "0x255CC70", Offset = "0x255B670", VA = "0x18255CC70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001412")]
			[Cpp2IlInjected.Address(RVA = "0x255CDA0", Offset = "0x255B7A0", VA = "0x18255CDA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047F")]
		[DebuggerNonUserCode]
		public int Min
		{
			[Cpp2IlInjected.Token(Token = "0x6001416")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return min_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001417")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				min_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000480")]
		[DebuggerNonUserCode]
		public int Max
		{
			[Cpp2IlInjected.Token(Token = "0x6001418")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return max_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001419")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				max_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000481")]
		[DebuggerNonUserCode]
		public int Weight
		{
			[Cpp2IlInjected.Token(Token = "0x600141A")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return weight_;
			}
			[Cpp2IlInjected.Token(Token = "0x600141B")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				weight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000482")]
		[DebuggerNonUserCode]
		public bool Empty
		{
			[Cpp2IlInjected.Token(Token = "0x600141C")]
			[Cpp2IlInjected.Address(RVA = "0x1703600", Offset = "0x1702000", VA = "0x181703600")]
			get
			{
				return empty_;
			}
			[Cpp2IlInjected.Token(Token = "0x600141D")]
			[Cpp2IlInjected.Address(RVA = "0x1703720", Offset = "0x1702120", VA = "0x181703720")]
			set
			{
				empty_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000483")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemWithState> Items
		{
			[Cpp2IlInjected.Token(Token = "0x600141E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return items_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000484")]
		[DebuggerNonUserCode]
		public RepeatedField<LootType> Types_
		{
			[Cpp2IlInjected.Token(Token = "0x600141F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return types_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000485")]
		[DebuggerNonUserCode]
		public RepeatedField<Quality> Qualities
		{
			[Cpp2IlInjected.Token(Token = "0x6001420")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return qualities_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000486")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Rarities
		{
			[Cpp2IlInjected.Token(Token = "0x6001421")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return rarities_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000487")]
		[DebuggerNonUserCode]
		public int MinRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6001422")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return minRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001423")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				minRarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000488")]
		[DebuggerNonUserCode]
		public int MaxRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6001424")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return maxRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001425")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				maxRarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000489")]
		[DebuggerNonUserCode]
		public RepeatedField<SubLootTable> Filters
		{
			[Cpp2IlInjected.Token(Token = "0x6001426")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return filters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001413")]
		[Cpp2IlInjected.Address(RVA = "0x255CAE0", Offset = "0x255B4E0", VA = "0x18255CAE0")]
		[DebuggerNonUserCode]
		public SubLootTable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001414")]
		[Cpp2IlInjected.Address(RVA = "0x255C7C0", Offset = "0x255B1C0", VA = "0x18255C7C0")]
		[DebuggerNonUserCode]
		public SubLootTable(SubLootTable other)
		{
			int num = (min_ = other.min_);
			int num2 = (max_ = other.max_);
			int num3 = (weight_ = other.weight_);
			bool flag = (empty_ = other.empty_);
			RepeatedField<ItemWithState> repeatedField = (items_ = (RepeatedField<ItemWithState>)(object)((RepeatedField<T>)(object)other.items_).Clone());
			RepeatedField<LootType> repeatedField2 = (types_ = (RepeatedField<LootType>)(object)((RepeatedField<T>)(object)other.types_).Clone());
			RepeatedField<Quality> repeatedField3 = (qualities_ = (RepeatedField<Quality>)(object)((RepeatedField<T>)(object)other.qualities_).Clone());
			RepeatedField<int> repeatedField4 = (rarities_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.rarities_).Clone());
			int num4 = (minRarity_ = other.minRarity_);
			int num5 = (maxRarity_ = other.maxRarity_);
			RepeatedField<SubLootTable> repeatedField5 = (filters_ = (RepeatedField<SubLootTable>)(object)((RepeatedField<T>)(object)other.filters_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001415")]
		[Cpp2IlInjected.Address(RVA = "0x2558A40", Offset = "0x2557440", VA = "0x182558A40", Slot = "10")]
		[DebuggerNonUserCode]
		public SubLootTable Clone()
		{
			return new SubLootTable(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001427")]
		[Cpp2IlInjected.Address(RVA = "0x25592F0", Offset = "0x2557CF0", VA = "0x1825592F0", Slot = "0")]
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
				if ((object)_repeated_qualities_codec == (object)typeof(SubLootTable).TypeHandle && (IntPtr)max_ == (IntPtr)typeof(SubLootTable).TypeHandle && (IntPtr)weight_ == (IntPtr)typeof(SubLootTable).TypeHandle && (IntPtr)(empty_ ? 1 : 0) == (IntPtr)typeof(SubLootTable).TypeHandle)
				{
					RepeatedField<ItemWithState> repeatedField = items_;
					bool flag = default(bool);
					if (flag)
					{
						RepeatedField<LootType> repeatedField2 = types_;
						bool flag2 = default(bool);
						if (flag2)
						{
							RepeatedField<Quality> repeatedField3 = qualities_;
							bool flag3 = default(bool);
							if (flag3)
							{
								RepeatedField<int> repeatedField4 = rarities_;
								bool flag4 = default(bool);
								if (flag4 && minRarity_ == (flag4 ? 1 : 0) && maxRarity_ == (flag4 ? 1 : 0))
								{
									RepeatedField<SubLootTable> repeatedField5 = filters_;
									bool flag5 = default(bool);
									if (flag5)
									{
										return object.Equals(_unknownFields, other);
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001428")]
		[Cpp2IlInjected.Address(RVA = "0x2559160", Offset = "0x2557B60", VA = "0x182559160", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SubLootTable other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.min_;
				if ((IntPtr)_repeated_qualities_codec == (IntPtr)num)
				{
					int num2 = other.max_;
					if (max_ == num2)
					{
						int num3 = other.weight_;
						if (weight_ == num3)
						{
							bool flag = other.empty_;
							if (empty_ == flag)
							{
								RepeatedField<ItemWithState> repeatedField = items_;
								RepeatedField<ItemWithState> repeatedField2 = other.items_;
								if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
								{
									RepeatedField<LootType> repeatedField3 = types_;
									RepeatedField<LootType> repeatedField4 = other.types_;
									if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
									{
										RepeatedField<Quality> repeatedField5 = qualities_;
										RepeatedField<Quality> repeatedField6 = other.qualities_;
										if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
										{
											RepeatedField<int> repeatedField7 = rarities_;
											RepeatedField<int> repeatedField8 = other.rarities_;
											if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
											{
												int num4 = other.minRarity_;
												if (minRarity_ == num4)
												{
													int num5 = other.maxRarity_;
													if (maxRarity_ == num5)
													{
														RepeatedField<SubLootTable> repeatedField9 = filters_;
														RepeatedField<SubLootTable> repeatedField10 = other.filters_;
														if (((RepeatedField<T>)(object)repeatedField9).Equals((RepeatedField<>)(object)repeatedField10))
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
							}
						}
					}
				}
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001429")]
		[Cpp2IlInjected.Address(RVA = "0x255AF60", Offset = "0x2559960", VA = "0x18255AF60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_009a
			if (min_ != 0)
			{
			}
			if (max_ != 0)
			{
			}
			if (weight_ != 0)
			{
			}
			if (empty_)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)items_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)types_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)qualities_).GetHashCode();
			RepeatedField<int> repeatedField = rarities_;
			hashCode = hashCode3;
			hashCode2 = ((RepeatedField<T>)(object)repeatedField).GetHashCode();
			if (minRarity_ != 0)
			{
			}
			if (maxRarity_ != 0)
			{
			}
			int hashCode4 = ((RepeatedField<T>)(object)filters_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x600142A")]
		[Cpp2IlInjected.Address(RVA = "0x255C050", Offset = "0x255AA50", VA = "0x18255C050", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600142B")]
		[Cpp2IlInjected.Address(RVA = "0x255C0B0", Offset = "0x255AAB0", VA = "0x18255C0B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0123
			if ((long)_repeated_qualities_codec != 0)
			{
				int value = min_;
				output.WriteInt32(value);
			}
			if (max_ != 0)
			{
				int value2 = max_;
				output.WriteInt32(value2);
			}
			if (weight_ != 0)
			{
				int value3 = weight_;
				output.WriteInt32(value3);
			}
			if (empty_)
			{
				bool value4 = empty_;
				output.WriteBool(value4);
			}
			RepeatedField<ItemWithState> repeatedField = items_;
			FieldCodec<ItemWithState> repeated_items_codec = _repeated_items_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_items_codec);
			RepeatedField<LootType> repeatedField2 = types_;
			FieldCodec<LootType> repeated_types_codec = _repeated_types_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_types_codec);
			RepeatedField<Quality> repeatedField3 = qualities_;
			FieldCodec<Quality> repeated_qualities_codec = _repeated_qualities_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_qualities_codec);
			RepeatedField<int> repeatedField4 = rarities_;
			FieldCodec<int> repeated_rarities_codec = _repeated_rarities_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_rarities_codec);
			if (minRarity_ != 0)
			{
				int value5 = minRarity_;
				output.WriteInt32(value5);
			}
			if (maxRarity_ != 0)
			{
				int value6 = maxRarity_;
				output.WriteInt32(value6);
			}
			RepeatedField<SubLootTable> repeatedField5 = filters_;
			FieldCodec<SubLootTable> repeated_filters_codec = _repeated_filters_codec;
			((RepeatedField<T>)(object)repeatedField5).WriteTo(output, (FieldCodec<>)(object)repeated_filters_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600142C")]
		[Cpp2IlInjected.Address(RVA = "0x2558620", Offset = "0x2557020", VA = "0x182558620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0125
			int num = min_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = max_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			int num6 = weight_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			RepeatedField<ItemWithState> repeatedField = items_;
			FieldCodec<ItemWithState> repeated_items_codec = _repeated_items_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_items_codec);
			RepeatedField<LootType> repeatedField2 = types_;
			FieldCodec<LootType> repeated_types_codec = _repeated_types_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_types_codec);
			RepeatedField<Quality> repeatedField3 = qualities_;
			FieldCodec<Quality> repeated_qualities_codec = _repeated_qualities_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_qualities_codec);
			RepeatedField<int> repeatedField4 = rarities_;
			FieldCodec<int> repeated_rarities_codec = _repeated_rarities_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_rarities_codec);
			int num12 = minRarity_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13 += 2;
			}
			int num14 = maxRarity_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15 += 2;
			}
			RepeatedField<SubLootTable> repeatedField5 = filters_;
			FieldCodec<SubLootTable> repeated_filters_codec = _repeated_filters_codec;
			int num16 = ((RepeatedField<T>)(object)repeatedField5).CalculateSize((FieldCodec<>)(object)repeated_filters_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num17 = unknownFields.CalculateSize();
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600142D")]
		[Cpp2IlInjected.Address(RVA = "0x255BB30", Offset = "0x255A530", VA = "0x18255BB30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SubLootTable other)
		{
			//Discarded unreachable code: IL_0116
			if (other != null)
			{
				int num = other.min_;
				if (num != 0)
				{
					min_ = num;
				}
				int num2 = other.max_;
				if (num2 != 0)
				{
					max_ = num2;
				}
				int num3 = other.weight_;
				if (num3 != 0)
				{
					weight_ = num3;
				}
				bool flag = other.empty_;
				if (flag)
				{
					empty_ = flag;
				}
				RepeatedField<ItemWithState> repeatedField = items_;
				RepeatedField<ItemWithState> repeatedField2 = other.items_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<LootType> repeatedField3 = types_;
				RepeatedField<LootType> repeatedField4 = other.types_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<Quality> repeatedField5 = qualities_;
				RepeatedField<Quality> repeatedField6 = other.qualities_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				RepeatedField<int> repeatedField7 = rarities_;
				RepeatedField<int> repeatedField8 = other.rarities_;
				((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
				int num4 = other.minRarity_;
				if (num4 != 0)
				{
					minRarity_ = num4;
				}
				int num5 = other.maxRarity_;
				if (num5 != 0)
				{
					maxRarity_ = num5;
				}
				RepeatedField<SubLootTable> repeatedField9 = filters_;
				RepeatedField<SubLootTable> repeatedField10 = other.filters_;
				((RepeatedField<T>)(object)repeatedField9).Add((IEnumerable<>)(object)repeatedField10);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600142E")]
		[Cpp2IlInjected.Address(RVA = "0x255B7C0", Offset = "0x255A1C0", VA = "0x18255B7C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0182
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 90)
			{
				goto IL_00d2;
			}
			if ((int)num > 240)
			{
				if ((int)num > 248)
				{
					if (num == 256)
					{
						int num2 = (maxRarity_ = input.ReadInt32());
					}
					if (num != 802)
					{
						goto IL_016b;
					}
					RepeatedField<SubLootTable> repeatedField = filters_;
					FieldCodec<SubLootTable> repeated_filters_codec = _repeated_filters_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_filters_codec);
				}
				if (num == 242)
				{
					goto IL_00a0;
				}
				if (num != 248)
				{
					goto IL_016b;
				}
				int num3 = (minRarity_ = input.ReadInt32());
			}
			if ((long)input == 4294967293L)
			{
				goto IL_00b9;
			}
			if (num == 240)
			{
				goto IL_00a0;
			}
			goto IL_016b;
			IL_016b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			return;
			IL_00a0:
			RepeatedField<int> repeatedField2 = rarities_;
			FieldCodec<int> repeated_rarities_codec = _repeated_rarities_codec;
			((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rarities_codec);
			goto IL_00b9;
			IL_00b9:
			RepeatedField<Quality> repeatedField3 = qualities_;
			FieldCodec<Quality> repeated_qualities_codec = _repeated_qualities_codec;
			((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_qualities_codec);
			goto IL_00d2;
			IL_00d2:
			bool flag = default(bool);
			if ((int)num > 24)
			{
				if (num == 32)
				{
					flag = (empty_ = input.ReadBool());
				}
				if (flag)
				{
					RepeatedField<ItemWithState> repeatedField4 = items_;
					FieldCodec<ItemWithState> repeated_items_codec = _repeated_items_codec;
					((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_items_codec);
				}
				if (!flag)
				{
					goto IL_016b;
				}
				RepeatedField<LootType> repeatedField5 = types_;
				FieldCodec<LootType> repeated_types_codec = _repeated_types_codec;
				((RepeatedField<T>)(object)repeatedField5).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_types_codec);
			}
			int num4 = default(int);
			if (flag)
			{
				num4 = (min_ = input.ReadInt32());
			}
			int num5 = default(int);
			if (num4 == 16)
			{
				num5 = (max_ = input.ReadInt32());
			}
			if (num5 == 24)
			{
				int num6 = (weight_ = input.ReadInt32());
			}
			goto IL_016b;
		}

		[Cpp2IlInjected.Token(Token = "0x600142F")]
		[Cpp2IlInjected.Address(RVA = "0x255A3C0", Offset = "0x2558DC0", VA = "0x18255A3C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				int num = min_;
			}
			if ((object)typeof(int).TypeHandle != null && (object)typeof(int).TypeHandle != null && (long)typeof(int).TypeHandle != 1 && fieldNumber == 100)
			{
				RepeatedField<SubLootTable> repeatedField = filters_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001430")]
		[Cpp2IlInjected.Address(RVA = "0x255BC90", Offset = "0x255A690", VA = "0x18255BC90", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0017, IL_001f, IL_006a, IL_0070
			//IL_000e: Expected I4, but got O
			//IL_0016: Expected I4, but got O
			//IL_001e: Expected I4, but got O
			//IL_0026: Expected I4, but got O
			//IL_004e: Expected I4, but got O
			//IL_0057: Expected I4, but got O
			object obj = default(object);
			object obj2 = default(object);
			object obj3 = default(object);
			while (true)
			{
				if (fieldNumber - 1 <= 11)
				{
					min_ = (int)obj;
					return;
				}
				if ((object)typeof(int).TypeHandle == null)
				{
					break;
				}
				if ((object)typeof(int).TypeHandle != null)
				{
					if ((long)typeof(int).TypeHandle == 1 || fieldNumber != 100)
					{
						maxRarity_ = (int)obj2;
						return;
					}
					continue;
				}
				minRarity_ = (int)obj3;
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001431")]
		[Cpp2IlInjected.Address(RVA = "0x2558900", Offset = "0x2557300", VA = "0x182558900", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 11)
			{
				min_ = 0;
				return;
			}
			if ((object)typeof(IList).TypeHandle != null)
			{
				if ((object)typeof(IList).TypeHandle != null && (long)typeof(IList).TypeHandle != 1)
				{
					while (fieldNumber != 100)
					{
					}
					RepeatedField<SubLootTable> repeatedField = filters_;
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001432")]
		[Cpp2IlInjected.Address(RVA = "0x255B2C0", Offset = "0x2559CC0", VA = "0x18255B2C0")]
		private bool ItemTypeIsMatching(Item item)
		{
			RepeatedField<LootType> repeatedField2;
			bool flag = default(bool);
			ActivityItemType activityItemType = default(ActivityItemType);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			ItemType itemType = default(ItemType);
			bool flag6 = default(bool);
			ItemType itemType2 = default(ItemType);
			while (true)
			{
				RepeatedField<LootType> repeatedField = types_;
				int num = 0;
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				repeatedField2 = types_;
				if (num >= count)
				{
					break;
				}
				LootType lootType = (LootType)((RepeatedField<T>)(object)repeatedField2)[num];
				int num2 = 0;
				if ((long)repeatedField2 <= 5)
				{
					if (lootType.itemTypeCase_ != LootType.ItemTypeOneofCase.ActivityItem)
					{
					}
					int num3 = 0;
					if (lootType.ActivityItem.activityItemCase_ != (LootActivityItem.ActivityItemOneofCase)num)
					{
						int num4 = 0;
						if (lootType.ActivityItem.activityItemCase_ != LootActivityItem.ActivityItemOneofCase.ActivityItemType || !flag || lootType.ActivityItem.ActivityItemType != activityItemType)
						{
							if (lootType.ActivityItem.activityItemCase_ != LootActivityItem.ActivityItemOneofCase.CropType)
							{
								continue;
							}
							while (!flag2)
							{
							}
							LootActivityItem activityItem = lootType.ActivityItem;
							int num5 = 0;
							CropType cropType = activityItem.CropType;
							if (lootType.itemTypeCase_ != LootType.ItemTypeOneofCase.Furniture)
							{
							}
							if (lootType.Furniture.furnitureItemCase_ != (LootFurnitureItem.FurnitureItemOneofCase)num)
							{
							}
						}
					}
					if (!flag3)
					{
					}
					FurnitureItemType furnitureItemType = lootType.Furniture.FurnitureItemType;
					if (lootType.itemTypeCase_ != LootType.ItemTypeOneofCase.Clothing)
					{
					}
					int num6 = 0;
					if (lootType.Clothing.clothingItemCase_ == (LootClothingItem.ClothingItemOneofCase)num)
					{
					}
					if (!flag4)
					{
					}
					ClothingItemType clothingItemType = lootType.Clothing.ClothingItemType;
					if (lootType.itemTypeCase_ != LootType.ItemTypeOneofCase.Currency)
					{
					}
					int num7 = 0;
					if (lootType.Currency.currencyItemCase_ == (LootCurrencyItem.CurrencyItemOneofCase)num)
					{
					}
					if (!flag5)
					{
					}
					CurrencyType currencyType = lootType.Currency.CurrencyType;
				}
				if (itemType == ItemType.ActivityData)
				{
					if (lootType.itemTypeCase_ != (LootType.ItemTypeOneofCase)itemType)
					{
					}
					int num8 = 0;
					if (lootType.ActivityData.activityDataItemCase_ == (LootActivityDataItem.ActivityDataItemOneofCase)num)
					{
					}
					if (!flag6)
					{
					}
					ActivityDataItemType activityDataItemType = lootType.ActivityData.ActivityDataItemType;
				}
				if (lootType.itemTypeCase_ != (LootType.ItemTypeOneofCase)itemType2)
				{
					RepeatedField<LootType> repeatedField3 = types_;
					num++;
				}
				break;
			}
			int count2 = ((RepeatedField<T>)(object)repeatedField2).Count;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001433")]
		[Cpp2IlInjected.Address(RVA = "0x2559AF0", Offset = "0x25584F0", VA = "0x182559AF0")]
		private List<ItemWithState> GetAllItemWithStatePreFiltered(List<ItemWithState> items, ItemDatabase itemDb)
		{
			//Discarded unreachable code: IL_013f, IL_0145, IL_014b, IL_0151, IL_0157, IL_015d, IL_0163, IL_0169
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (items == null)
			{
				int count = ((RepeatedField<T>)(object)items_).Count;
				if (((RepeatedField<T>)(object)types_).Count > 0)
				{
					uint capacity = default(uint);
					List<ItemWithState> list = (List<ItemWithState>)(object)new List<T>((int)capacity);
					IEnumerable<IItemData> allItemsData = (IEnumerable<IItemData>)itemDb.get_AllItemsData();
					if (allItemsData != null)
					{
						while (allItemsData == null)
						{
						}
						bool flag = default(bool);
						while (!flag)
						{
						}
						bool flag2 = default(bool);
						while (!flag2)
						{
						}
						ItemWithState item = new ItemWithState();
						((List<T>)(object)list).Add((T)item);
					}
					num++;
					if (allItemsData != null)
					{
					}
					if (num != 0)
					{
					}
					num++;
					if (num == 0)
					{
					}
				}
				IEnumerable<IItemData> allItemsData2 = (IEnumerable<IItemData>)itemDb.get_AllItemsData();
				Func<IItemData, bool> _003C_003E9__79_ = _003C_003Ec._003C_003E9__79_2;
				if (_003C_003E9__79_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IItemData x) => x.IsBuyable());
				}
				IEnumerable<IItemData> enumerable = (IEnumerable<IItemData>)Enumerable.Where<IItemData>((IEnumerable<>)allItemsData2, (Func<, >)(object)_003C_003E9__79_);
				Func<IItemData, ItemWithState> func = default(Func<IItemData, ItemWithState>);
				if (_003C_003Ec._003C_003E9__79_3 == null)
				{
					func = (Func<IItemData, ItemWithState>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IItemData x) => new ItemWithState()));
				}
				List<ItemWithState> list2 = (List<ItemWithState>)(object)Enumerable.ToList<ItemWithState>(Enumerable.Select<IItemData, ItemWithState>((IEnumerable<>)enumerable, (Func<, >)(object)func));
				if (num + 1 != 0)
				{
				}
				Func<ItemWithState, ItemWithState> func2 = default(Func<ItemWithState, ItemWithState>);
				if (_003C_003Ec._003C_003E9__79_1 == null)
				{
					func2 = (Func<ItemWithState, ItemWithState>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemWithState x) => x.Clone()));
				}
				List<ItemWithState> list3 = (List<ItemWithState>)(object)Enumerable.ToList<ItemWithState>(Enumerable.Select<ItemWithState, ItemWithState>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
			}
			Func<ItemWithState, ItemWithState> _003C_003E9__79_2 = _003C_003Ec._003C_003E9__79_0;
			if (_003C_003E9__79_2 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemWithState x) => x.Clone());
			}
			return (List<ItemWithState>)(object)Enumerable.ToList<ItemWithState>(Enumerable.Select<ItemWithState, ItemWithState>((IEnumerable<>)items, (Func<, >)(object)_003C_003E9__79_2));
		}

		[Cpp2IlInjected.Token(Token = "0x6001434")]
		[Cpp2IlInjected.Address(RVA = "0x255A570", Offset = "0x2558F70", VA = "0x18255A570")]
		private unsafe List<ItemWithState> GetFilteredItemList(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items, RewardGenerationParameters parameters, ItemDatabase itemDb)
		{
			//Discarded unreachable code: IL_0167, IL_016d, IL_0173, IL_0179, IL_017f, IL_0185, IL_018b, IL_0191, IL_0197, IL_019d, IL_01a3
			//IL_0016: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			int num = 0;
			ItemDatabase itemDb2 = (ItemDatabase)0;
			RewardGenerationParameters parameters2 = (RewardGenerationParameters)0;
			ItemDatabase itemDatabase = itemDb2;
			List<ItemWithState> list = default(List<ItemWithState>);
			List<ItemWithState> filteredItems = list;
			if (((RepeatedField<T>)(object)items_).Count > 0)
			{
				List<ItemWithState> list2 = filteredItems;
				Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
				{
					//Discarded unreachable code: IL_002c
					RepeatedField<ItemWithState> repeatedField3 = items_;
					Predicate<ItemWithState> predicate5 = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState y)
					{
						//Discarded unreachable code: IL_001b
						Item item5 = y.Item;
						Item item6 = x.Item;
						return *(Item*)item5 == *(Item*)item6;
					};
					bool flag2 = default(bool);
					return !flag2;
				};
				int num2 = ((List<T>)(object)list2).RemoveAll((Predicate<>)(object)predicate);
				RepeatedField<ItemWithState> repeatedField = items_;
				Func<ItemWithState, bool> func = (Func<ItemWithState, bool>)(object)(Func<T, TResult>)delegate(ItemWithState x)
				{
					//Discarded unreachable code: IL_002f
					List<ItemWithState> list6 = filteredItems;
					Predicate<ItemWithState> predicate4 = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState y)
					{
						//Discarded unreachable code: IL_001b
						Item item3 = y.Item;
						Item item4 = x.Item;
						return *(Item*)item3 == *(Item*)item4;
					};
					return ((List<T>)(object)list6).Find((Predicate<>)(object)predicate4) != null;
				};
				IEnumerable<ItemWithState> enumerable = (IEnumerable<ItemWithState>)Enumerable.Where<ItemWithState>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				Func<ItemWithState, ItemWithState> _003C_003E9__80_ = _003C_003Ec._003C_003E9__80_2;
				if (_003C_003E9__80_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemWithState x) => x.Clone());
				}
				filteredItems = (List<ItemWithState>)(object)Enumerable.ToList<ItemWithState>(Enumerable.Select<ItemWithState, ItemWithState>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__80_));
			}
			if (((RepeatedField<T>)(object)types_).Count > 0 && (items != null || ((RepeatedField<T>)(object)items_).Count > 0))
			{
				List<ItemWithState> list3 = filteredItems;
				Predicate<ItemWithState> predicate2 = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
				{
					//Discarded unreachable code: IL_0013
					SubLootTable subLootTable2 = this;
					Item item2 = x.Item;
					bool flag = default(bool);
					return !flag;
				};
				int num3 = ((List<T>)(object)list3).RemoveAll((Predicate<>)(object)predicate2);
			}
			List<ItemWithState> list4 = filteredItems;
			Predicate<ItemWithState> predicate3 = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//IL_0067: Expected O, but got I4
				ItemDatabase itemDatabase3 = itemDb2;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData == null || itemData == null)
				{
					if (itemData != null)
					{
						int num5 = maxRarity_;
						SubLootTable subLootTable = this;
						if (100 > 100)
						{
							if (((RepeatedField<T>)(object)rarities_).Count > 0)
							{
								RepeatedField<int> repeatedField2 = rarities_;
								int itemID_ = x.itemID_;
								if (!((RepeatedField<T>)(object)repeatedField2).Contains((T)itemID_))
								{
									goto IL_006a;
								}
							}
							goto IL_006d;
						}
					}
					goto IL_006a;
				}
				goto IL_006d;
				IL_006a:
				int num6 = 0;
				goto IL_006d;
				IL_006d:
				throw new NullReferenceException();
			};
			int num4 = ((List<T>)(object)list4).RemoveAll((Predicate<>)(object)predicate3);
			List<ItemWithState> list5 = filteredItems;
			ItemDatabase itemDatabase2 = itemDb2;
			ItemMinLevelFilter itemMinLevelFilter = default(ItemMinLevelFilter);
			((BaseItemFilter)itemMinLevelFilter).Filter(itemDatabase2, (List<>)(object)list5);
			return filteredItems;
		}

		[Cpp2IlInjected.Token(Token = "0x6001435")]
		[Cpp2IlInjected.Address(RVA = "0x255AB10", Offset = "0x2559510", VA = "0x18255AB10")]
		private List<ItemWithState> GetFilteredItemList(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items, RewardGenerationParameters parameters, ItemDatabase itemDb)
		{
			//Discarded unreachable code: IL_00ad, IL_00b3
			//IL_0016: Expected O, but got I4
			int num = 0;
			RewardGenerationParameters parameters2 = (RewardGenerationParameters)0;
			RewardGenerationParameters rewardGenerationParameters = parameters2;
			List<ItemWithState> list = default(List<ItemWithState>);
			List<ItemWithState> filteredItems = list;
			Func<SubLootTable, int> _003C_003E9__81_ = _003C_003Ec._003C_003E9__81_1;
			if (_003C_003E9__81_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SubLootTable x) => x.weight_);
			}
			IEnumerable<SubLootTable> enumerable = default(IEnumerable<SubLootTable>);
			int num2 = Enumerable.Sum<SubLootTable>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__81_);
			int num3;
			if (num2 > 0)
			{
				int minValue = 0;
				num3 = random.Next(minValue, num2);
				if (num3 != 0)
				{
					uint num4 = default(uint);
					if (num < (int)num4)
					{
						num += num;
						if (num == (int)num4)
						{
							goto IL_008f;
						}
						num++;
					}
					List<ItemWithState> list2 = filteredItems;
					RewardGenerationParameters rewardGenerationParameters2 = parameters2;
					num++;
					goto IL_008f;
				}
				goto IL_0097;
			}
			goto IL_00a7;
			IL_0097:
			num++;
			if (num3 != 0)
			{
			}
			List<ItemWithState> result = default(List<ItemWithState>);
			if (num != 0)
			{
				return result;
			}
			goto IL_00a7;
			IL_008f:
			num += 312;
			goto IL_0097;
			IL_00a7:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001436")]
		[Cpp2IlInjected.Address(RVA = "0x2558FA0", Offset = "0x25579A0", VA = "0x182558FA0")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//IL_0016: Expected O, but got I8
			RewardGenerationParameters parameters = (RewardGenerationParameters)0;
			if (!empty_)
			{
				RewardGenerationParameters rewardGenerationParameters = parameters;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				List<ItemWithState> filteredItems = (List<ItemWithState>)(object)this.GetFilteredItemList(ref playerProfile, ref worldProfile, (List<>)(object)items, rewardGenerationParameters, _003CInstance_003Ek__BackingField);
				bool flag = default(bool);
				if (!flag)
				{
					List<ItemWithState> list = filteredItems;
					bool result = default(bool);
					return result;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001437")]
		[Cpp2IlInjected.Address(RVA = "0x255B100", Offset = "0x2559B00", VA = "0x18255B100")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items, RewardGenerationParameters parameters)
		{
			//IL_0014: Expected O, but got I4
			RewardGenerationParameters parameters2 = (RewardGenerationParameters)0;
			if (!empty_)
			{
				RewardGenerationParameters rewardGenerationParameters = parameters2;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				List<ItemWithState> list = default(List<ItemWithState>);
				List<ItemWithState> filteredItems = list;
				bool flag = default(bool);
				if (!flag)
				{
					List<ItemWithState> list2 = filteredItems;
					bool result = default(bool);
					return result;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001438")]
		[Cpp2IlInjected.Address(RVA = "0x2558F70", Offset = "0x2557970", VA = "0x182558F70")]
		public IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items)
		{
			int num = 0;
			IReward result = default(IReward);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001439")]
		[Cpp2IlInjected.Address(RVA = "0x25595E0", Offset = "0x2557FE0", VA = "0x1825595E0")]
		public IReward GenerateThis(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items, [Optional] RewardGenerationParameters parameters)
		{
			//IL_0063: Expected I4, but got O
			//IL_007e: Expected O, but got I4
			if (!empty_)
			{
				int num = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int num2 = min_;
				int num3 = max_;
				if (num2 != 0 || num3 == 0)
				{
				}
				List<ItemWithState> list = default(List<ItemWithState>);
				int size = ((List<>)(object)list)._size;
				int num4 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				int num5 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
				if ((object)list == (object)softCurrencyItem)
				{
					IProfilePlayer section = playerProfile.Section;
				}
				ItemReward itemReward = new ItemReward();
				itemReward.id_ = (int)itemReward;
				int amount_ = default(int);
				itemReward.amount_ = amount_;
				IItemData itemData = default(IItemData);
				if (itemReward != null || itemData == null)
				{
				}
				itemReward.state_ = (ItemState)0;
				itemReward = (ItemReward)(object)((object)itemReward + (object)typeof(IProfilePlayer).TypeHandle);
			}
			NullGenerator _003CDefault_003Ek__BackingField = NullGenerator.Default;
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600143A")]
		[Cpp2IlInjected.Address(RVA = "0x25594D0", Offset = "0x2557ED0", VA = "0x1825594D0")]
		private ItemState GenerateItemState(Item chosenItem, Random random, RewardGenerationParameters parameters, ItemDatabase itemDb)
		{
			IItemData itemData = default(IItemData);
			if (itemData == null)
			{
			}
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			int iD = itemData.ID;
			iD += 312;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600143B")]
		[Cpp2IlInjected.Address(RVA = "0x2558AA0", Offset = "0x25574A0", VA = "0x182558AA0", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_010a, IL_0110, IL_0116, IL_011c
			int num4 = default(int);
			int num5 = default(int);
			Predicate<LootType> predicate = default(Predicate<LootType>);
			bool flag = default(bool);
			IItemData itemData = default(IItemData);
			string error = default(string);
			do
			{
				int num = 0;
				if ((long)_repeated_qualities_codec < -1)
				{
					context.AddInvalidMemberError("Cannot be lower than -1", "Min");
				}
				if (max_ < -1)
				{
					context.AddInvalidMemberError("Cannot be lower than -1", "Max");
				}
				int num2 = min_;
				if (num2 == -1 || max_ == -1)
				{
					int num3 = max_;
					if (num2 != num3)
					{
						context.AddError("Both Min and Max must be set to -1 to be valid");
						num4 = min_;
						num5 = max_;
					}
				}
				if (num4 > num5)
				{
					context.AddInvalidMemberError("Cannot be greater than Max", "Min");
				}
				if (weight_ < num)
				{
					context.AddInvalidMemberError("Cannot be negative", "Weight");
				}
				RepeatedField<LootType> repeatedField = types_;
				if (_003C_003Ec._003C_003E9__87_0 == null)
				{
					predicate = (Predicate<LootType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((LootType x) => x.itemTypeCase_ == LootType.ItemTypeOneofCase.None));
				}
				if (((RepeatedField<>)(object)repeatedField).Any<LootType>((Predicate<>)(object)predicate))
				{
					context.AddInvalidMemberError("Cannot be None", "Types_");
				}
				RepeatedField<ItemWithState> repeatedField2 = items_;
				if (flag)
				{
					while (itemData == null)
					{
					}
					while (itemData == null)
					{
					}
					context.AddError(error);
				}
			}
			while (itemData != null);
		}

		[Cpp2IlInjected.Token(Token = "0x600143C")]
		[Cpp2IlInjected.Address(RVA = "0x255C380", Offset = "0x255AD80", VA = "0x18255C380")]
		static SubLootTable()
		{
			MessageParser<ItemWithState> parser = ItemWithState._parser;
			uint num = default(uint);
			_parser = (MessageParser<SubLootTable>)(object)FieldCodec.ForMessage<ItemWithState>(num, (MessageParser<>)(object)parser);
			MessageParser<LootType> parser2 = LootType._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<SubLootTable>)(object)FieldCodec.ForMessage<LootType>(num2, (MessageParser<>)(object)parser2);
			Func<Quality, int> func = (Func<Quality, int>)(object)(Func<T, TResult>)((Quality x) => (int)x);
			Func<int, Quality> func2 = (Func<int, Quality>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num3 = default(uint);
			_parser = (MessageParser<SubLootTable>)(object)FieldCodec.ForEnum<Quality>(num3, (Func<, >)(object)func, (Func<, >)(object)func2);
			uint num4 = default(uint);
			_parser = (MessageParser<SubLootTable>)(object)FieldCodec.ForInt32(num4);
			MessageParser<SubLootTable> parser3 = _parser;
			uint num5 = default(uint);
			_parser = (MessageParser<SubLootTable>)(object)FieldCodec.ForMessage<SubLootTable>(num5, (MessageParser<>)(object)parser3);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600143D")]
		[Cpp2IlInjected.Address(RVA = "0x2558FA0", Offset = "0x25579A0", VA = "0x182558FA0", Slot = "14")]
		bool IGenerator.IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//IL_0016: Expected O, but got I8
			RewardGenerationParameters parameters = (RewardGenerationParameters)0;
			if (!empty_)
			{
				RewardGenerationParameters rewardGenerationParameters = parameters;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				List<ItemWithState> filteredItems = (List<ItemWithState>)(object)this.GetFilteredItemList(ref playerProfile, ref worldProfile, (List<>)(object)items, rewardGenerationParameters, _003CInstance_003Ek__BackingField);
				bool flag = default(bool);
				if (!flag)
				{
					List<ItemWithState> list = filteredItems;
					bool result = default(bool);
					return result;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600143E")]
		[Cpp2IlInjected.Address(RVA = "0x2558F70", Offset = "0x2557970", VA = "0x182558F70", Slot = "15")]
		IReward IGenerator.Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			int num = 0;
			IReward result = default(IReward);
			return result;
		}
	}
}
