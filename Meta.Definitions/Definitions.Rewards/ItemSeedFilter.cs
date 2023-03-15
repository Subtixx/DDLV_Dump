using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	public sealed class ItemSeedFilter : BaseItemFilter, IMessage<ItemSeedFilter>, IMessage, IEquatable<ItemSeedFilter>, IDeepCloneable<ItemSeedFilter>, IMessageFieldAccessor, IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private static readonly MessageParser<ItemSeedFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public const int ProducedTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private ActivityItemType producedType_;

		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public const int CropTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private CropType cropType_;

		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public const int HasProductFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private bool hasProduct_;

		[Cpp2IlInjected.Token(Token = "0x170003E9")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemSeedFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600114E")]
			[Cpp2IlInjected.Address(RVA = "0x25EE2C0", Offset = "0x25ECCC0", VA = "0x1825EE2C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600114F")]
			[Cpp2IlInjected.Address(RVA = "0x25EE1F0", Offset = "0x25ECBF0", VA = "0x1825EE1F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001150")]
			[Cpp2IlInjected.Address(RVA = "0x25EE320", Offset = "0x25ECD20", VA = "0x1825EE320", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EC")]
		[DebuggerNonUserCode]
		public ActivityItemType ProducedType
		{
			[Cpp2IlInjected.Token(Token = "0x6001155")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return producedType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001156")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				producedType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003ED")]
		[DebuggerNonUserCode]
		public CropType CropType
		{
			[Cpp2IlInjected.Token(Token = "0x6001157")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return cropType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001158")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				cropType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EE")]
		[DebuggerNonUserCode]
		public bool HasProduct
		{
			[Cpp2IlInjected.Token(Token = "0x6001159")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return hasProduct_;
			}
			[Cpp2IlInjected.Token(Token = "0x600115A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				hasProduct_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001151")]
		[Cpp2IlInjected.Address(RVA = "0x25EE150", Offset = "0x25ECB50", VA = "0x1825EE150")]
		[DebuggerNonUserCode]
		public ItemSeedFilter()
		{
			//IL_000f: Expected I4, but got I8
			((System.Xml.Schema.FacetsChecker)(object)this)._002Ector();
			producedType_ = ActivityItemType.Crop;
			hasProduct_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001152")]
		[Cpp2IlInjected.Address(RVA = "0x25EDEB0", Offset = "0x25EC8B0", VA = "0x1825EDEB0")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			producedType_ = ActivityItemType.Crop;
			hasProduct_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001153")]
		[Cpp2IlInjected.Address(RVA = "0x25EE180", Offset = "0x25ECB80", VA = "0x1825EE180")]
		[DebuggerNonUserCode]
		public ItemSeedFilter(ItemSeedFilter other)
		{
			//IL_000f: Expected I4, but got I8
			((System.Xml.Schema.FacetsChecker)(object)this)._002Ector();
			producedType_ = ActivityItemType.Crop;
			hasProduct_ = true;
			ActivityItemType activityItemType = (producedType_ = other.producedType_);
			CropType cropType = (cropType_ = other.cropType_);
			bool flag = (hasProduct_ = other.hasProduct_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001154")]
		[Cpp2IlInjected.Address(RVA = "0x25EDA60", Offset = "0x25EC460", VA = "0x1825EDA60", Slot = "14")]
		[DebuggerNonUserCode]
		public ItemSeedFilter Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_000f: Expected I4, but got I8
			ItemSeedFilter itemSeedFilter = new ItemSeedFilter();
			itemSeedFilter.producedType_ = ActivityItemType.Crop;
			itemSeedFilter.hasProduct_ = true;
			ActivityItemType activityItemType = (itemSeedFilter.producedType_ = producedType_);
			CropType cropType = (itemSeedFilter.cropType_ = cropType_);
			bool flag = (itemSeedFilter.hasProduct_ = hasProduct_);
			UnknownFieldSet unknownFieldSet = (itemSeedFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemSeedFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x600115B")]
		[Cpp2IlInjected.Address(RVA = "0x25EDD00", Offset = "0x25EC700", VA = "0x1825EDD00", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)producedType_ == (IntPtr)typeof(ItemSeedFilter).TypeHandle && (IntPtr)(void*)(int)cropType_ == (IntPtr)typeof(ItemSeedFilter).TypeHandle && (IntPtr)(hasProduct_ ? 1 : 0) == (IntPtr)typeof(ItemSeedFilter).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600115C")]
		[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ItemSeedFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ActivityItemType activityItemType = other.producedType_;
				if (producedType_ == activityItemType)
				{
					CropType cropType = other.cropType_;
					if (cropType_ == cropType)
					{
						bool flag = other.hasProduct_;
						if (hasProduct_ == flag)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600115D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EC90", Offset = "0x1E0D690", VA = "0x181E0EC90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (producedType_ != 0)
				{
				}
				if (cropType_ != 0)
				{
				}
				if (hasProduct_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600115E")]
		[Cpp2IlInjected.Address(RVA = "0x25EDFE0", Offset = "0x25EC9E0", VA = "0x1825EDFE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600115F")]
		[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003c
			if (producedType_ != 0)
			{
			}
			if (cropType_ != 0)
			{
			}
			if (hasProduct_)
			{
				bool value = hasProduct_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001160")]
		[Cpp2IlInjected.Address(RVA = "0x25ED990", Offset = "0x25EC390", VA = "0x1825ED990", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ActivityItemType activityItemType = producedType_;
				num = 0;
				if (activityItemType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)activityItemType);
				}
				CropType cropType = cropType_;
				if (cropType != 0)
				{
					int num3 = CodedOutputStream.ComputeEnumSize((int)cropType);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001161")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemSeedFilter other)
		{
			if (other != null)
			{
				ActivityItemType activityItemType = other.producedType_;
				if (activityItemType != 0)
				{
					producedType_ = activityItemType;
				}
				CropType cropType = other.cropType_;
				if (cropType != 0)
				{
					cropType_ = cropType;
				}
				bool flag = other.hasProduct_;
				if (flag)
				{
					hasProduct_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001162")]
		[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(producedType_ = (ActivityItemType)input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (int)(cropType_ = (CropType)input.ReadInt32());
				}
				if (num3 == 24)
				{
					bool flag = (hasProduct_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001163")]
		[Cpp2IlInjected.Address(RVA = "0x25EDDA0", Offset = "0x25EC7A0", VA = "0x1825EDDA0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_001e;
				}
				bool flag = hasProduct_;
			}
			ActivityItemType activityItemType = producedType_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001164")]
		[Cpp2IlInjected.Address(RVA = "0x25EDEC0", Offset = "0x25EC8C0", VA = "0x1825EDEC0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					hasProduct_ = (byte)(int)obj2 != 0;
					break;
				}
				case 0:
				{
					object obj = default(object);
					cropType_ = (CropType)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				producedType_ = (ActivityItemType)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001165")]
		[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				hasProduct_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001166")]
		[Cpp2IlInjected.Address(RVA = "0x25EDC00", Offset = "0x25EC600", VA = "0x1825EDC00", Slot = "6")]
		protected override void DoFilter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				//Discarded unreachable code: IL_0054
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					int num2 = 0;
					if (itemData != null)
					{
						ItemDatabase itemDatabase2 = itemDb;
						ItemSeedFilter itemSeedFilter = this;
						if ((itemSeedFilter.hasProduct_ ? 1 : 0) == num2)
						{
						}
						IItemData itemData2 = default(IItemData);
						if (itemSeedFilter.producedType_ == ActivityItemType.Crop && itemData2 != null && itemData2 != null)
						{
							CropType cropType = itemSeedFilter.cropType_;
							int num3 = 0;
						}
					}
				}
				return true;
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001167")]
		[Cpp2IlInjected.Address(RVA = "0x25EDB00", Offset = "0x25EC500", VA = "0x1825EDB00", Slot = "7")]
		protected override void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			//Discarded unreachable code: IL_002a
			Predicate<ItemWithState> predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState x)
			{
				ItemDatabase itemDatabase = itemDb;
				Item item = x.Item;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					int num2 = 0;
					if (itemData != null)
					{
						ItemDatabase itemDatabase2 = itemDb;
						ItemSeedFilter itemSeedFilter = this;
						if ((itemSeedFilter.hasProduct_ ? 1 : 0) == num2)
						{
						}
						IItemData itemData2 = default(IItemData);
						if (itemSeedFilter.producedType_ == ActivityItemType.Crop && itemData2 != null && itemData2 != null)
						{
							CropType cropType = itemSeedFilter.cropType_;
							return true;
						}
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			};
			int num = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001168")]
		[Cpp2IlInjected.Address(RVA = "0x25EE040", Offset = "0x25ECA40", VA = "0x1825EE040")]
		static ItemSeedFilter()
		{
			Func<ItemSeedFilter> func = default(Func<ItemSeedFilter>);
			_parser = (MessageParser<ItemSeedFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
