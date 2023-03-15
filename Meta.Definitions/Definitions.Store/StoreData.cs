using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Store
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	public sealed class StoreData : IMessage<StoreData>, IMessage, IEquatable<StoreData>, IDeepCloneable<StoreData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private static readonly MessageParser<StoreData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public const int RefreshFatigueFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private AnyFatigue refreshFatigue_;

		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public const int ItemMinWeightFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private int itemMinWeight_;

		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public const int ItemMaxWeightFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private int itemMaxWeight_;

		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public const int ItemIncWeightFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private int itemIncWeight_;

		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public const int MinNumberOfHCItemsPerRefreshFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private int minNumberOfHCItemsPerRefresh_;

		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public const int MaxPercentageOfHCItemsPerRefreshFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private float maxPercentageOfHCItemsPerRefresh_;

		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public const int FurnituresToDisplayFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private static readonly FieldCodec<int> _repeated_furnituresToDisplay_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private readonly RepeatedField<int> furnituresToDisplay_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public const int ClothingsToDisplayFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private static readonly FieldCodec<int> _repeated_clothingsToDisplay_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private readonly RepeatedField<int> clothingsToDisplay_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public const string DatabaseNameDefault = "Store_Default";

		[Cpp2IlInjected.Token(Token = "0x17000356")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000DE6")]
			[Cpp2IlInjected.Address(RVA = "0x263B160", Offset = "0x2639B60", VA = "0x18263B160")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000357")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000DE7")]
			[Cpp2IlInjected.Address(RVA = "0x263B090", Offset = "0x2639A90", VA = "0x18263B090")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000358")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000DE8")]
			[Cpp2IlInjected.Address(RVA = "0x263B1C0", Offset = "0x2639BC0", VA = "0x18263B1C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000359")]
		[DebuggerNonUserCode]
		public AnyFatigue RefreshFatigue
		{
			[Cpp2IlInjected.Token(Token = "0x6000DEC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return refreshFatigue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000DED")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				refreshFatigue_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035A")]
		[DebuggerNonUserCode]
		public int ItemMinWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000DEE")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return itemMinWeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000DEF")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				itemMinWeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035B")]
		[DebuggerNonUserCode]
		public int ItemMaxWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000DF0")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return itemMaxWeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000DF1")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				itemMaxWeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035C")]
		[DebuggerNonUserCode]
		public int ItemIncWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000DF2")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return itemIncWeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000DF3")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				itemIncWeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035D")]
		[DebuggerNonUserCode]
		public int MinNumberOfHCItemsPerRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x6000DF4")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return minNumberOfHCItemsPerRefresh_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000DF5")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				minNumberOfHCItemsPerRefresh_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035E")]
		[DebuggerNonUserCode]
		public float MaxPercentageOfHCItemsPerRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x6000DF6")]
			[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0")]
			get
			{
				return maxPercentageOfHCItemsPerRefresh_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000DF7")]
			[Cpp2IlInjected.Address(RVA = "0xDD7740", Offset = "0xDD6140", VA = "0x180DD7740")]
			set
			{
				maxPercentageOfHCItemsPerRefresh_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035F")]
		[DebuggerNonUserCode]
		public RepeatedField<int> FurnituresToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6000DF8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return furnituresToDisplay_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000360")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ClothingsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6000DF9")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return clothingsToDisplay_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE9")]
		[Cpp2IlInjected.Address(RVA = "0x263AFE0", Offset = "0x26399E0", VA = "0x18263AFE0")]
		[DebuggerNonUserCode]
		public StoreData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEA")]
		[Cpp2IlInjected.Address(RVA = "0x263AE40", Offset = "0x2639840", VA = "0x18263AE40")]
		[DebuggerNonUserCode]
		public StoreData(StoreData other)
		{
			//IL_003d: Expected O, but got I4
			AnyFatigue anyFatigue = other.refreshFatigue_;
			if (anyFatigue != null)
			{
				AnyFatigue anyFatigue2 = anyFatigue.Clone();
			}
			int num = 0;
			refreshFatigue_ = (AnyFatigue)num;
			int num2 = (itemMinWeight_ = other.itemMinWeight_);
			int num3 = (itemMaxWeight_ = other.itemMaxWeight_);
			int num4 = (itemIncWeight_ = other.itemIncWeight_);
			int num5 = (minNumberOfHCItemsPerRefresh_ = other.minNumberOfHCItemsPerRefresh_);
			float num6 = (maxPercentageOfHCItemsPerRefresh_ = other.maxPercentageOfHCItemsPerRefresh_);
			RepeatedField<int> repeatedField = (furnituresToDisplay_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.furnituresToDisplay_).Clone());
			RepeatedField<int> repeatedField2 = (clothingsToDisplay_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.clothingsToDisplay_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DEB")]
		[Cpp2IlInjected.Address(RVA = "0x2639BF0", Offset = "0x26385F0", VA = "0x182639BF0", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreData Clone()
		{
			//Discarded unreachable code: IL_00cf
			//IL_003e: Expected O, but got I4
			StoreData storeData = new StoreData();
			RepeatedField<int> repeatedField = (storeData.furnituresToDisplay_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (storeData.clothingsToDisplay_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			AnyFatigue anyFatigue = refreshFatigue_;
			if (anyFatigue != null)
			{
				AnyFatigue anyFatigue2 = anyFatigue.Clone();
			}
			int num = 0;
			storeData.refreshFatigue_ = (AnyFatigue)num;
			int num2 = (storeData.itemMinWeight_ = itemMinWeight_);
			int num3 = (storeData.itemMaxWeight_ = itemMaxWeight_);
			int num4 = (storeData.itemIncWeight_ = itemIncWeight_);
			int num5 = (storeData.minNumberOfHCItemsPerRefresh_ = minNumberOfHCItemsPerRefresh_);
			float num6 = (storeData.maxPercentageOfHCItemsPerRefresh_ = maxPercentageOfHCItemsPerRefresh_);
			RepeatedField<int> repeatedField3 = (storeData.furnituresToDisplay_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)furnituresToDisplay_).Clone());
			RepeatedField<int> repeatedField4 = (storeData.clothingsToDisplay_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)clothingsToDisplay_).Clone());
			UnknownFieldSet unknownFieldSet = (storeData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFA")]
		[Cpp2IlInjected.Address(RVA = "0x2639DC0", Offset = "0x26387C0", VA = "0x182639DC0", Slot = "0")]
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
				bool flag = object.Equals(refreshFatigue_, other);
				if (flag && itemMinWeight_ == (flag ? 1 : 0) && itemMaxWeight_ == (flag ? 1 : 0) && itemIncWeight_ == (flag ? 1 : 0) && minNumberOfHCItemsPerRefresh_ == (flag ? 1 : 0))
				{
					RepeatedField<int> repeatedField = furnituresToDisplay_;
					bool flag2 = default(bool);
					if (flag2)
					{
						RepeatedField<int> repeatedField2 = clothingsToDisplay_;
						bool flag3 = default(bool);
						if (flag3)
						{
							UnknownFieldSet unknownFields = _unknownFields;
							bool result = default(bool);
							return result;
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFB")]
		[Cpp2IlInjected.Address(RVA = "0x2639F60", Offset = "0x2638960", VA = "0x182639F60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				AnyFatigue objB = other.refreshFatigue_;
				if (object.Equals(refreshFatigue_, objB))
				{
					int num = other.itemMinWeight_;
					if (itemMinWeight_ == num)
					{
						int num2 = other.itemMaxWeight_;
						if (itemMaxWeight_ == num2)
						{
							int num3 = other.itemIncWeight_;
							if (itemIncWeight_ == num3)
							{
								int num4 = other.minNumberOfHCItemsPerRefresh_;
								if (minNumberOfHCItemsPerRefresh_ == num4)
								{
									RepeatedField<int> repeatedField = furnituresToDisplay_;
									RepeatedField<int> repeatedField2 = other.furnituresToDisplay_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
									{
										RepeatedField<int> repeatedField3 = clothingsToDisplay_;
										RepeatedField<int> repeatedField4 = other.clothingsToDisplay_;
										if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
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
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFC")]
		[Cpp2IlInjected.Address(RVA = "0x263A230", Offset = "0x2638C30", VA = "0x18263A230", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0084
			//IL_004b: Expected O, but got I4
			AnyFatigue anyFatigue = refreshFatigue_;
			if (anyFatigue != null)
			{
				int hashCode = anyFatigue.GetHashCode();
			}
			if (itemMinWeight_ != 0)
			{
			}
			if (itemMaxWeight_ != 0)
			{
			}
			if (itemIncWeight_ != 0)
			{
			}
			int num = minNumberOfHCItemsPerRefresh_;
			int num2 = default(int);
			if (num != 0)
			{
				num2 = 0;
			}
			if (num != 0)
			{
				int hashCode2 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num2);
			}
			int hashCode3 = ((RepeatedField<T>)(object)furnituresToDisplay_).GetHashCode();
			int hashCode4 = ((RepeatedField<T>)(object)clothingsToDisplay_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode4;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFD")]
		[Cpp2IlInjected.Address(RVA = "0x263AA90", Offset = "0x2639490", VA = "0x18263AA90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFE")]
		[Cpp2IlInjected.Address(RVA = "0x263AAF0", Offset = "0x26394F0", VA = "0x18263AAF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d3
			if ((long)refreshFatigue_ != 0)
			{
				AnyFatigue value = refreshFatigue_;
				output.WriteMessage(value);
			}
			if (itemMinWeight_ != 0)
			{
				int value2 = itemMinWeight_;
				output.WriteInt32(value2);
			}
			if (itemMaxWeight_ != 0)
			{
				int value3 = itemMaxWeight_;
				output.WriteInt32(value3);
			}
			if (itemIncWeight_ != 0)
			{
				int value4 = itemIncWeight_;
				output.WriteInt32(value4);
			}
			if (minNumberOfHCItemsPerRefresh_ != 0)
			{
				int value5 = minNumberOfHCItemsPerRefresh_;
				output.WriteInt32(value5);
			}
			if (output != null)
			{
				float value6 = maxPercentageOfHCItemsPerRefresh_;
				output.WriteFloat(value6);
			}
			RepeatedField<int> repeatedField = furnituresToDisplay_;
			FieldCodec<int> repeated_furnituresToDisplay_codec = _repeated_furnituresToDisplay_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_furnituresToDisplay_codec);
			RepeatedField<int> repeatedField2 = clothingsToDisplay_;
			FieldCodec<int> repeated_clothingsToDisplay_codec = _repeated_clothingsToDisplay_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_clothingsToDisplay_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFF")]
		[Cpp2IlInjected.Address(RVA = "0x26398D0", Offset = "0x26382D0", VA = "0x1826398D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00ea
			AnyFatigue anyFatigue = refreshFatigue_;
			int num = 0;
			if (anyFatigue != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(anyFatigue);
			}
			int num3 = itemMinWeight_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			int num5 = itemMaxWeight_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			int num7 = itemIncWeight_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num += num8;
			}
			int num9 = minNumberOfHCItemsPerRefresh_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num += num10;
			}
			num += 5;
			RepeatedField<int> repeatedField = furnituresToDisplay_;
			FieldCodec<int> repeated_furnituresToDisplay_codec = _repeated_furnituresToDisplay_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_furnituresToDisplay_codec);
			RepeatedField<int> repeatedField2 = clothingsToDisplay_;
			FieldCodec<int> repeated_clothingsToDisplay_codec = _repeated_clothingsToDisplay_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_clothingsToDisplay_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num += num13;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E00")]
		[Cpp2IlInjected.Address(RVA = "0x263A670", Offset = "0x2639070", VA = "0x18263A670", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreData other)
		{
			//Discarded unreachable code: IL_00f0
			if (other == null)
			{
				return;
			}
			if ((long)other.refreshFatigue_ != 0)
			{
				AnyFatigue anyFatigue = refreshFatigue_;
				if (anyFatigue == null)
				{
					AnyFatigue anyFatigue2 = (refreshFatigue_ = new AnyFatigue());
				}
				AnyFatigue other2 = other.refreshFatigue_;
				anyFatigue.MergeFrom(other2);
			}
			int num = other.itemMinWeight_;
			if (num != 0)
			{
				itemMinWeight_ = num;
			}
			int num2 = other.itemMaxWeight_;
			if (num2 != 0)
			{
				itemMaxWeight_ = num2;
			}
			int num3 = other.itemIncWeight_;
			if (num3 != 0)
			{
				itemIncWeight_ = num3;
			}
			int num4 = other.minNumberOfHCItemsPerRefresh_;
			if (num4 != 0)
			{
				minNumberOfHCItemsPerRefresh_ = num4;
			}
			float num5 = other.maxPercentageOfHCItemsPerRefresh_;
			if (num4 != 0)
			{
				maxPercentageOfHCItemsPerRefresh_ = num5;
			}
			RepeatedField<int> repeatedField = furnituresToDisplay_;
			RepeatedField<int> repeatedField2 = other.furnituresToDisplay_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<int> repeatedField3 = clothingsToDisplay_;
			RepeatedField<int> repeatedField4 = other.clothingsToDisplay_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000E01")]
		[Cpp2IlInjected.Address(RVA = "0x263A410", Offset = "0x2638E10", VA = "0x18263A410", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0120
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 40)
			{
				goto IL_007b;
			}
			if ((int)num > 80)
			{
				if (num == 82)
				{
					goto IL_0062;
				}
				num += 4294967208u;
				if (num != 4294967293u)
				{
					goto IL_0109;
				}
				RepeatedField<int> repeatedField = clothingsToDisplay_;
				FieldCodec<int> repeated_clothingsToDisplay_codec = _repeated_clothingsToDisplay_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_clothingsToDisplay_codec);
			}
			if (num == 53)
			{
				float num2 = (maxPercentageOfHCItemsPerRefresh_ = input.ReadFloat());
			}
			if (num == 80)
			{
				goto IL_0062;
			}
			goto IL_0109;
			IL_007b:
			int num5 = default(int);
			if ((int)num > 16)
			{
				int num3 = default(int);
				if (num == 24)
				{
					num3 = (itemMaxWeight_ = input.ReadInt32());
				}
				int num4 = default(int);
				if (num3 == 32)
				{
					num4 = (itemIncWeight_ = input.ReadInt32());
				}
				if (num4 != 40)
				{
					goto IL_0109;
				}
				num5 = (minNumberOfHCItemsPerRefresh_ = input.ReadInt32());
			}
			AnyFatigue anyFatigue = default(AnyFatigue);
			if (num5 == 10)
			{
				AnyFatigue builder = default(AnyFatigue);
				if (refreshFatigue_ == null)
				{
					anyFatigue = (refreshFatigue_ = new AnyFatigue());
					builder = refreshFatigue_;
				}
				input.ReadMessage(builder);
			}
			if ((long)anyFatigue == 16)
			{
				int num6 = (itemMinWeight_ = input.ReadInt32());
			}
			goto IL_0109;
			IL_0062:
			RepeatedField<int> repeatedField2 = furnituresToDisplay_;
			FieldCodec<int> repeated_furnituresToDisplay_codec = _repeated_furnituresToDisplay_codec;
			((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_furnituresToDisplay_codec);
			goto IL_007b;
			IL_0109:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000E02")]
		[Cpp2IlInjected.Address(RVA = "0x263A0C0", Offset = "0x2638AC0", VA = "0x18263A0C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				AnyFatigue anyFatigue = refreshFatigue_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E03")]
		[Cpp2IlInjected.Address(RVA = "0x263A7C0", Offset = "0x26391C0", VA = "0x18263A7C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 10)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				refreshFatigue_ = (AnyFatigue)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E04")]
		[Cpp2IlInjected.Address(RVA = "0x2639AD0", Offset = "0x26384D0", VA = "0x182639AD0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0008, IL_0009, IL_000a, IL_000b, IL_000c, IL_000d
			if (fieldNumber - 1 > 10)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E05")]
		[Cpp2IlInjected.Address(RVA = "0x263ACE0", Offset = "0x26396E0", VA = "0x18263ACE0")]
		static StoreData()
		{
			Func<StoreData> func = default(Func<StoreData>);
			_parser = (MessageParser<StoreData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<StoreData>)(object)FieldCodec.ForInt32(82u);
			_parser = (MessageParser<StoreData>)(object)FieldCodec.ForInt32(90u);
			/*Error: Unexpected end of block*/;
		}
	}
}
