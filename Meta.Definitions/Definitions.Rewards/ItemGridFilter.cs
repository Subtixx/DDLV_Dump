using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	public sealed class ItemGridFilter : BaseItemFilter, IMessage<ItemGridFilter>, IMessage, IEquatable<ItemGridFilter>, IDeepCloneable<ItemGridFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private static readonly MessageParser<ItemGridFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public const int MinAreaSizeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		private AreaSize minAreaSize_;

		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public const int MaxAreaSizeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private AreaSize maxAreaSize_;

		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public const int CanRotateFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private bool canRotate_;

		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public const int SizeQualifierFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private GridSizeQualifier sizeQualifier_;

		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public const int IgnoreSizeForTagsFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private static readonly FieldCodec<int> _repeated_ignoreSizeForTags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private readonly RepeatedField<int> ignoreSizeForTags_;

		[Cpp2IlInjected.Token(Token = "0x170003FA")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemGridFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60011C0")]
			[Cpp2IlInjected.Address(RVA = "0x25DD4F0", Offset = "0x25DBEF0", VA = "0x1825DD4F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60011C1")]
			[Cpp2IlInjected.Address(RVA = "0x25DD420", Offset = "0x25DBE20", VA = "0x1825DD420")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60011C2")]
			[Cpp2IlInjected.Address(RVA = "0x25DD550", Offset = "0x25DBF50", VA = "0x1825DD550", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FD")]
		[DebuggerNonUserCode]
		public AreaSize MinAreaSize
		{
			[Cpp2IlInjected.Token(Token = "0x60011C6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return minAreaSize_;
			}
			[Cpp2IlInjected.Token(Token = "0x60011C7")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				minAreaSize_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FE")]
		[DebuggerNonUserCode]
		public AreaSize MaxAreaSize
		{
			[Cpp2IlInjected.Token(Token = "0x60011C8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return maxAreaSize_;
			}
			[Cpp2IlInjected.Token(Token = "0x60011C9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				maxAreaSize_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FF")]
		[DebuggerNonUserCode]
		public bool CanRotate
		{
			[Cpp2IlInjected.Token(Token = "0x60011CA")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return canRotate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60011CB")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				canRotate_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000400")]
		[DebuggerNonUserCode]
		public GridSizeQualifier SizeQualifier
		{
			[Cpp2IlInjected.Token(Token = "0x60011CC")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return sizeQualifier_;
			}
			[Cpp2IlInjected.Token(Token = "0x60011CD")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				sizeQualifier_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000401")]
		[DebuggerNonUserCode]
		public RepeatedField<int> IgnoreSizeForTags
		{
			[Cpp2IlInjected.Token(Token = "0x60011CE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return ignoreSizeForTags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011C3")]
		[Cpp2IlInjected.Address(RVA = "0x25DD3A0", Offset = "0x25DBDA0", VA = "0x1825DD3A0")]
		[DebuggerNonUserCode]
		public ItemGridFilter()
		{
			ignoreSizeForTags_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			((ServiceContainer)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60011C4")]
		[Cpp2IlInjected.Address(RVA = "0x25DD2A0", Offset = "0x25DBCA0", VA = "0x1825DD2A0")]
		[DebuggerNonUserCode]
		public ItemGridFilter(ItemGridFilter other)
		{
			//IL_001b: Expected O, but got I4
			AreaSize areaSize = other.minAreaSize_;
			int num = 0;
			if (areaSize != null)
			{
				AreaSize areaSize2 = areaSize.Clone();
			}
			minAreaSize_ = (AreaSize)num;
			AreaSize areaSize3 = other.maxAreaSize_;
			AreaSize areaSize4 = default(AreaSize);
			if (areaSize3 != null)
			{
				areaSize4 = areaSize3.Clone();
			}
			maxAreaSize_ = areaSize4;
			bool flag = (canRotate_ = other.canRotate_);
			GridSizeQualifier gridSizeQualifier = (sizeQualifier_ = other.sizeQualifier_);
			RepeatedField<int> repeatedField = (ignoreSizeForTags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.ignoreSizeForTags_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011C5")]
		[Cpp2IlInjected.Address(RVA = "0x25DC360", Offset = "0x25DAD60", VA = "0x1825DC360", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemGridFilter Clone()
		{
			//Discarded unreachable code: IL_008b
			//IL_0021: Expected O, but got I4
			ItemGridFilter itemGridFilter = new ItemGridFilter();
			AreaSize areaSize = minAreaSize_;
			int num = 0;
			if (areaSize != null)
			{
				AreaSize areaSize2 = areaSize.Clone();
			}
			itemGridFilter.minAreaSize_ = (AreaSize)num;
			AreaSize areaSize3 = maxAreaSize_;
			AreaSize areaSize4 = default(AreaSize);
			if (areaSize3 != null)
			{
				areaSize4 = areaSize3.Clone();
			}
			itemGridFilter.maxAreaSize_ = areaSize4;
			bool flag = (itemGridFilter.canRotate_ = canRotate_);
			GridSizeQualifier gridSizeQualifier = (itemGridFilter.sizeQualifier_ = sizeQualifier_);
			RepeatedField<int> repeatedField = (itemGridFilter.ignoreSizeForTags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)ignoreSizeForTags_).Clone());
			UnknownFieldSet unknownFieldSet = (itemGridFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemGridFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x60011CF")]
		[Cpp2IlInjected.Address(RVA = "0x25DC690", Offset = "0x25DB090", VA = "0x1825DC690", Slot = "0")]
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
				if (object.Equals(minAreaSize_, other))
				{
					bool flag = object.Equals(maxAreaSize_, other);
					if (flag && canRotate_ == flag && sizeQualifier_ == (flag ? GridSizeQualifier.Small : GridSizeQualifier.None))
					{
						RepeatedField<int> repeatedField = ignoreSizeForTags_;
						bool flag2 = default(bool);
						if (flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011D0")]
		[Cpp2IlInjected.Address(RVA = "0x25DC7A0", Offset = "0x25DB1A0", VA = "0x1825DC7A0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemGridFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				AreaSize objB = other.minAreaSize_;
				if (object.Equals(minAreaSize_, objB))
				{
					AreaSize objB2 = other.maxAreaSize_;
					if (object.Equals(maxAreaSize_, objB2))
					{
						bool flag = other.canRotate_;
						if (canRotate_ == flag)
						{
							GridSizeQualifier gridSizeQualifier = other.sizeQualifier_;
							if (sizeQualifier_ == gridSizeQualifier)
							{
								RepeatedField<int> repeatedField = ignoreSizeForTags_;
								RepeatedField<int> repeatedField2 = other.ignoreSizeForTags_;
								if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011D1")]
		[Cpp2IlInjected.Address(RVA = "0x25DC9A0", Offset = "0x25DB3A0", VA = "0x1825DC9A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005f
			AreaSize areaSize = minAreaSize_;
			if (areaSize != null)
			{
				int hashCode = areaSize.GetHashCode();
			}
			AreaSize areaSize2 = maxAreaSize_;
			if (areaSize2 != null)
			{
				int hashCode2 = areaSize2.GetHashCode();
			}
			if (canRotate_)
			{
			}
			if (sizeQualifier_ != 0)
			{
			}
			int hashCode3 = ((RepeatedField<T>)(object)ignoreSizeForTags_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60011D2")]
		[Cpp2IlInjected.Address(RVA = "0x25DCF90", Offset = "0x25DB990", VA = "0x1825DCF90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60011D3")]
		[Cpp2IlInjected.Address(RVA = "0x25DCFF0", Offset = "0x25DB9F0", VA = "0x1825DCFF0", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007f
			if ((long)minAreaSize_ != 0)
			{
				AreaSize value = minAreaSize_;
				output.WriteMessage(value);
			}
			if ((long)maxAreaSize_ != 0)
			{
				AreaSize value2 = maxAreaSize_;
				output.WriteMessage(value2);
			}
			if (canRotate_)
			{
				bool value3 = canRotate_;
				output.WriteBool(value3);
			}
			if (sizeQualifier_ != 0)
			{
			}
			RepeatedField<int> repeatedField = ignoreSizeForTags_;
			FieldCodec<int> repeated_ignoreSizeForTags_codec = _repeated_ignoreSizeForTags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_ignoreSizeForTags_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60011D4")]
		[Cpp2IlInjected.Address(RVA = "0x25DC130", Offset = "0x25DAB30", VA = "0x1825DC130", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_008f
			AreaSize areaSize = minAreaSize_;
			int num = 0;
			if (areaSize != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(areaSize);
			}
			AreaSize areaSize2 = maxAreaSize_;
			if (areaSize2 != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(areaSize2);
				num3++;
				num += num3;
			}
			GridSizeQualifier gridSizeQualifier = sizeQualifier_;
			if (gridSizeQualifier != 0)
			{
				int num4 = CodedOutputStream.ComputeEnumSize((int)gridSizeQualifier);
				num4++;
				num += num4;
			}
			RepeatedField<int> repeatedField = ignoreSizeForTags_;
			FieldCodec<int> repeated_ignoreSizeForTags_codec = _repeated_ignoreSizeForTags_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_ignoreSizeForTags_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num5;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60011D5")]
		[Cpp2IlInjected.Address(RVA = "0x25DCC60", Offset = "0x25DB660", VA = "0x1825DCC60", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemGridFilter other)
		{
			//Discarded unreachable code: IL_00de
			if (other == null)
			{
				return;
			}
			if ((long)other.minAreaSize_ != 0)
			{
				AreaSize areaSize = minAreaSize_;
				if (areaSize == null)
				{
					AreaSize areaSize2 = (minAreaSize_ = new AreaSize());
					AreaSize areaSize3 = minAreaSize_;
				}
				AreaSize other2 = other.minAreaSize_;
				areaSize.MergeFrom(other2);
			}
			if ((long)other.maxAreaSize_ != 0)
			{
				AreaSize areaSize5 = default(AreaSize);
				if (maxAreaSize_ == null)
				{
					AreaSize areaSize4 = (maxAreaSize_ = new AreaSize());
					areaSize5 = maxAreaSize_;
				}
				AreaSize other3 = other.maxAreaSize_;
				areaSize5.MergeFrom(other3);
			}
			bool flag = other.canRotate_;
			if (flag)
			{
				canRotate_ = flag;
			}
			GridSizeQualifier gridSizeQualifier = other.sizeQualifier_;
			if (gridSizeQualifier != 0)
			{
				sizeQualifier_ = gridSizeQualifier;
			}
			RepeatedField<int> repeatedField = ignoreSizeForTags_;
			RepeatedField<int> repeatedField2 = other.ignoreSizeForTags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60011D6")]
		[Cpp2IlInjected.Address(RVA = "0x25DCA80", Offset = "0x25DB480", VA = "0x1825DCA80", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00da
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 24)
			{
				if (num == 32)
				{
					int num2 = (int)(sizeQualifier_ = (GridSizeQualifier)input.ReadInt32());
				}
				num += 4294967256u;
				if (num != 4294967293u)
				{
					goto IL_00c3;
				}
				RepeatedField<int> repeatedField = ignoreSizeForTags_;
				FieldCodec<int> repeated_ignoreSizeForTags_codec = _repeated_ignoreSizeForTags_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_ignoreSizeForTags_codec);
			}
			AreaSize areaSize = default(AreaSize);
			if (num == 10)
			{
				AreaSize builder = default(AreaSize);
				if (minAreaSize_ == null)
				{
					areaSize = (minAreaSize_ = new AreaSize());
					builder = minAreaSize_;
				}
				input.ReadMessage(builder);
			}
			AreaSize areaSize2 = default(AreaSize);
			if ((long)areaSize == 18)
			{
				AreaSize builder2 = default(AreaSize);
				if (maxAreaSize_ == null)
				{
					areaSize2 = (maxAreaSize_ = new AreaSize());
					builder2 = maxAreaSize_;
				}
				input.ReadMessage(builder2);
			}
			if ((long)areaSize2 == 24)
			{
				bool flag = (canRotate_ = input.ReadBool());
			}
			goto IL_00c3;
			IL_00c3:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60011D7")]
		[Cpp2IlInjected.Address(RVA = "0x25DC870", Offset = "0x25DB270", VA = "0x1825DC870", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_003d;
							}
							RepeatedField<int> repeatedField = ignoreSizeForTags_;
						}
						GridSizeQualifier gridSizeQualifier = sizeQualifier_;
					}
					bool flag = canRotate_;
				}
				AreaSize areaSize = maxAreaSize_;
			}
			AreaSize areaSize2 = minAreaSize_;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60011D8")]
		[Cpp2IlInjected.Address(RVA = "0x25DCDC0", Offset = "0x25DB7C0", VA = "0x1825DCDC0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			//IL_0039: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0)
					{
						object obj = default(object);
						canRotate_ = (byte)(int)obj != 0;
						return;
					}
					if (num == 0 || num != 1)
					{
						object obj2 = default(object);
						sizeQualifier_ = (GridSizeQualifier)obj2;
						return;
					}
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				}
				else
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						maxAreaSize_ = (AreaSize)num2;
						return;
					}
				}
				throw new InvalidCastException();
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60011D9")]
		[Cpp2IlInjected.Address(RVA = "0x25DC2A0", Offset = "0x25DACA0", VA = "0x1825DC2A0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0032
			//IL_0028: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num == 0 || num == 0)
			{
				return;
			}
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					RepeatedField<int> repeatedField = ignoreSizeForTags_;
					break;
				}
				case 0:
					break;
				default:
					return;
				}
				sizeQualifier_ = GridSizeQualifier.None;
			}
			else
			{
				canRotate_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60011DA")]
		[Cpp2IlInjected.Address(RVA = "0x25DC590", Offset = "0x25DAF90", VA = "0x1825DC590", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_00ed, IL_00fd, IL_012f
				//IL_0162: Expected I4, but got I8
				ItemGridFilter itemGridFilter = this;
				if (((long)itemGridFilter.minAreaSize_ != 0 || (long)itemGridFilter.maxAreaSize_ != 0 || itemGridFilter.sizeQualifier_ != 0) && ((RepeatedField<T>)(object)itemGridFilter.ignoreSizeForTags_).Count > 0)
				{
					ItemDatabase itemDatabase = itemDb;
					Item item = x.Item;
					IItemData itemData = default(IItemData);
					IHasTags tagItem = (IHasTags)itemData;
					if ((long)tagItem != 0)
					{
						RepeatedField<int> repeatedField = ignoreSizeForTags_;
						Predicate<int> predicate2 = (Predicate<int>)(object)(Predicate<T>)delegate
						{
							//Discarded unreachable code: IL_0009
							IHasTags hasTags = tagItem;
							bool result = default(bool);
							return result;
						};
						if (!((RepeatedField<>)(object)repeatedField).Any<int>((Predicate<>)(object)predicate2))
						{
						}
					}
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item2 = x.Item;
				IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
				bool flag = default(bool);
				if (gridPlaceableItemData != null && gridPlaceableItemData != null && flag)
				{
					GridSizeQualifier gridSizeQualifier = sizeQualifier_;
					GridSizeQualifier gridSizeQualifier2 = default(GridSizeQualifier);
					if (gridSizeQualifier == GridSizeQualifier.None || gridSizeQualifier == gridSizeQualifier2)
					{
						ItemGridFilter itemGridFilter2 = this;
						bool flag2 = itemGridFilter2.canRotate_;
						AreaSize areaSize = itemGridFilter2.maxAreaSize_;
						AreaSize areaSize2 = itemGridFilter2.minAreaSize_;
						bool flag3 = default(bool);
						return !flag3;
					}
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60011DB")]
		[Cpp2IlInjected.Address(RVA = "0x25DC490", Offset = "0x25DAE90", VA = "0x1825DC490", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_00ea, IL_00fa, IL_012c
				//IL_015f: Expected I4, but got I8
				ItemGridFilter itemGridFilter = this;
				if (((long)itemGridFilter.minAreaSize_ != 0 || (long)itemGridFilter.maxAreaSize_ != 0 || itemGridFilter.sizeQualifier_ != 0) && ((RepeatedField<T>)(object)itemGridFilter.ignoreSizeForTags_).Count > 0)
				{
					ItemDatabase itemDatabase = itemDb;
					Item item = x.Item;
					IItemData itemData = default(IItemData);
					IHasTags tagItem = (IHasTags)itemData;
					if ((long)tagItem != 0)
					{
						RepeatedField<int> repeatedField = ignoreSizeForTags_;
						Predicate<int> predicate2 = (Predicate<int>)(object)(Predicate<T>)delegate
						{
							//Discarded unreachable code: IL_0009
							IHasTags hasTags = tagItem;
							bool result2 = default(bool);
							return result2;
						};
						if (!((RepeatedField<>)(object)repeatedField).Any<int>((Predicate<>)(object)predicate2))
						{
						}
					}
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item2 = x.Item;
				IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
				bool flag = default(bool);
				if (gridPlaceableItemData != null && gridPlaceableItemData != null && flag)
				{
					GridSizeQualifier gridSizeQualifier = sizeQualifier_;
					GridSizeQualifier gridSizeQualifier2 = default(GridSizeQualifier);
					if (gridSizeQualifier == GridSizeQualifier.None || gridSizeQualifier == gridSizeQualifier2)
					{
						ItemGridFilter itemGridFilter2 = this;
						bool flag2 = itemGridFilter2.canRotate_;
						AreaSize areaSize = itemGridFilter2.maxAreaSize_;
						AreaSize areaSize2 = itemGridFilter2.minAreaSize_;
						bool result = default(bool);
						return result;
					}
				}
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60011DC")]
		[Cpp2IlInjected.Address(RVA = "0x25DD160", Offset = "0x25DBB60", VA = "0x1825DD160")]
		static ItemGridFilter()
		{
			Func<ItemGridFilter> func = default(Func<ItemGridFilter>);
			_parser = (MessageParser<ItemGridFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ItemGridFilter>)(object)FieldCodec.ForInt32(42u);
			/*Error: Unexpected end of block*/;
		}
	}
}
