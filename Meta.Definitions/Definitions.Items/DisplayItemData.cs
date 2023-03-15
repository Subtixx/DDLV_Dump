using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Displays;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200058D")]
	public sealed class DisplayItemData : IMessage<DisplayItemData>, IMessage, IEquatable<DisplayItemData>, IDeepCloneable<DisplayItemData>, IMessageFieldAccessor, IItemData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200058E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200058F")]
			public sealed class PricesTable : IMessage<PricesTable>, IMessage, IEquatable<PricesTable>, IDeepCloneable<PricesTable>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001E19")]
				private static readonly MessageParser<PricesTable> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001E1A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001E1B")]
				public const int ThresholdsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4001E1C")]
				private static readonly FieldCodec<int> _repeated_thresholds_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001E1D")]
				private readonly RepeatedField<int> thresholds_;

				[Cpp2IlInjected.Token(Token = "0x170011D4")]
				[DebuggerNonUserCode]
				public static MessageParser<PricesTable> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004534")]
					[Cpp2IlInjected.Address(RVA = "0x2947B80", Offset = "0x2946580", VA = "0x182947B80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011D5")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004535")]
					[Cpp2IlInjected.Address(RVA = "0x2947B00", Offset = "0x2946500", VA = "0x182947B00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011D6")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004536")]
					[Cpp2IlInjected.Address(RVA = "0x2947BE0", Offset = "0x29465E0", VA = "0x182947BE0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011D7")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Thresholds
				{
					[Cpp2IlInjected.Token(Token = "0x600453A")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004537")]
				[Cpp2IlInjected.Address(RVA = "0x2947A80", Offset = "0x2946480", VA = "0x182947A80")]
				[DebuggerNonUserCode]
				public PricesTable()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004538")]
				[Cpp2IlInjected.Address(RVA = "0x2947980", Offset = "0x2946380", VA = "0x182947980")]
				[DebuggerNonUserCode]
				public PricesTable(PricesTable other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004539")]
				[Cpp2IlInjected.Address(RVA = "0x2947230", Offset = "0x2945C30", VA = "0x182947230", Slot = "10")]
				[DebuggerNonUserCode]
				public PricesTable Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600453B")]
				[Cpp2IlInjected.Address(RVA = "0x29473F0", Offset = "0x2945DF0", VA = "0x1829473F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600453C")]
				[Cpp2IlInjected.Address(RVA = "0x2947360", Offset = "0x2945D60", VA = "0x182947360", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(PricesTable other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600453D")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600453E")]
				[Cpp2IlInjected.Address(RVA = "0x2947720", Offset = "0x2946120", VA = "0x182947720", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600453F")]
				[Cpp2IlInjected.Address(RVA = "0x2947780", Offset = "0x2946180", VA = "0x182947780", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004540")]
				[Cpp2IlInjected.Address(RVA = "0x2947120", Offset = "0x2945B20", VA = "0x182947120", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004541")]
				[Cpp2IlInjected.Address(RVA = "0x2947640", Offset = "0x2946040", VA = "0x182947640", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(PricesTable other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004542")]
				[Cpp2IlInjected.Address(RVA = "0x2947550", Offset = "0x2945F50", VA = "0x182947550", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004543")]
				[Cpp2IlInjected.Address(RVA = "0x29474D0", Offset = "0x2945ED0", VA = "0x1829474D0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004544")]
				[Cpp2IlInjected.Address(RVA = "0x29476C0", Offset = "0x29460C0", VA = "0x1829476C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004545")]
				[Cpp2IlInjected.Address(RVA = "0x29471D0", Offset = "0x2945BD0", VA = "0x1829471D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001DFF")]
		private static readonly MessageParser<DisplayItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001E00")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001E01")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E02")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001E03")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E04")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E05")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E06")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E07")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E08")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E09")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E0A")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E0B")]
		public const int SizeXFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E0C")]
		private int sizeX_;

		[Cpp2IlInjected.Token(Token = "0x4001E0D")]
		public const int SizeYFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001E0E")]
		private int sizeY_;

		[Cpp2IlInjected.Token(Token = "0x4001E0F")]
		public const int DisplayTypeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001E10")]
		private DisplayType displayType_;

		[Cpp2IlInjected.Token(Token = "0x4001E11")]
		public const int UniqueTagsFiltersFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4001E12")]
		private static readonly FieldCodec<UniqueTagsFilter> _repeated_uniqueTagsFilters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001E13")]
		private readonly RepeatedField<UniqueTagsFilter> uniqueTagsFilters_ = (RepeatedField<UniqueTagsFilter>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001E14")]
		public const int PricesTablesFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4001E15")]
		private static readonly FieldCodec<Types.PricesTable> _repeated_pricesTables_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001E16")]
		private readonly RepeatedField<Types.PricesTable> pricesTables_ = (RepeatedField<Types.PricesTable>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001E17")]
		public const int RandomizeSlotsOrderFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001E18")]
		private bool randomizeSlotsOrder_;

		[Cpp2IlInjected.Token(Token = "0x170011C5")]
		[DebuggerNonUserCode]
		public static MessageParser<DisplayItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004507")]
			[Cpp2IlInjected.Address(RVA = "0x2C43410", Offset = "0x2C41E10", VA = "0x182C43410")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011C6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004508")]
			[Cpp2IlInjected.Address(RVA = "0x2C432E0", Offset = "0x2C41CE0", VA = "0x182C432E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011C7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004509")]
			[Cpp2IlInjected.Address(RVA = "0x2C43470", Offset = "0x2C41E70", VA = "0x182C43470", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011C8")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x600450E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x600450F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011C9")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004510")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004511")]
			[Cpp2IlInjected.Address(RVA = "0x2C43660", Offset = "0x2C42060", VA = "0x182C43660")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011CA")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6004512")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004513")]
			[Cpp2IlInjected.Address(RVA = "0x2C43580", Offset = "0x2C41F80", VA = "0x182C43580")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011CB")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004514")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004515")]
			[Cpp2IlInjected.Address(RVA = "0x2C435F0", Offset = "0x2C41FF0", VA = "0x182C435F0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011CC")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004516")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004517")]
			[Cpp2IlInjected.Address(RVA = "0x2C436D0", Offset = "0x2C420D0", VA = "0x182C436D0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011CD")]
		[DebuggerNonUserCode]
		public int SizeX
		{
			[Cpp2IlInjected.Token(Token = "0x6004518")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return sizeX_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004519")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				sizeX_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011CE")]
		[DebuggerNonUserCode]
		public int SizeY
		{
			[Cpp2IlInjected.Token(Token = "0x600451A")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return sizeY_;
			}
			[Cpp2IlInjected.Token(Token = "0x600451B")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set
			{
				sizeY_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011CF")]
		[DebuggerNonUserCode]
		public DisplayType DisplayType
		{
			[Cpp2IlInjected.Token(Token = "0x600451C")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return displayType_;
			}
			[Cpp2IlInjected.Token(Token = "0x600451D")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				displayType_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011D0")]
		[DebuggerNonUserCode]
		public RepeatedField<UniqueTagsFilter> UniqueTagsFilters
		{
			[Cpp2IlInjected.Token(Token = "0x600451E")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return uniqueTagsFilters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011D1")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.PricesTable> PricesTables
		{
			[Cpp2IlInjected.Token(Token = "0x600451F")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return pricesTables_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011D2")]
		[DebuggerNonUserCode]
		public bool RandomizeSlotsOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6004520")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get
			{
				return randomizeSlotsOrder_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004521")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set
			{
				randomizeSlotsOrder_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011D3")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600452D")]
			[Cpp2IlInjected.Address(RVA = "0x2C433B0", Offset = "0x2C41DB0", VA = "0x182C433B0", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600450A")]
		[Cpp2IlInjected.Address(RVA = "0x2C42F60", Offset = "0x2C41960", VA = "0x182C42F60")]
		[DebuggerNonUserCode]
		public DisplayItemData()
		{
			randomizeSlotsOrder_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600450B")]
		[Cpp2IlInjected.Address(RVA = "0x1368AC0", Offset = "0x13674C0", VA = "0x181368AC0")]
		private void OnConstruction()
		{
			randomizeSlotsOrder_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600450C")]
		[Cpp2IlInjected.Address(RVA = "0x2C43080", Offset = "0x2C41A80", VA = "0x182C43080")]
		[DebuggerNonUserCode]
		public DisplayItemData(DisplayItemData other)
		{
			//IL_00e0: Expected O, but got I4
			randomizeSlotsOrder_ = true;
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (sizeX_ = other.sizeX_);
			int num3 = (sizeY_ = other.sizeY_);
			DisplayType displayType = other.displayType_;
			if (displayType != null)
			{
				DisplayType displayType2 = displayType.Clone();
			}
			int num4 = 0;
			displayType_ = (DisplayType)num4;
			RepeatedField<UniqueTagsFilter> repeatedField = (uniqueTagsFilters_ = (RepeatedField<UniqueTagsFilter>)(object)((RepeatedField<T>)(object)other.uniqueTagsFilters_).Clone());
			RepeatedField<Types.PricesTable> repeatedField2 = (pricesTables_ = (RepeatedField<Types.PricesTable>)(object)((RepeatedField<T>)(object)other.pricesTables_).Clone());
			bool flag = (randomizeSlotsOrder_ = other.randomizeSlotsOrder_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600450D")]
		[Cpp2IlInjected.Address(RVA = "0x2C40C20", Offset = "0x2C3F620", VA = "0x182C40C20", Slot = "10")]
		[DebuggerNonUserCode]
		public DisplayItemData Clone()
		{
			return new DisplayItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004522")]
		[Cpp2IlInjected.Address(RVA = "0x2C41460", Offset = "0x2C3FE60", VA = "0x182C41460", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(DisplayItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4 && sizeX_ == (flag4 ? 1 : 0) && sizeY_ == (flag4 ? 1 : 0) && object.Equals(displayType_, other))
								{
									RepeatedField<UniqueTagsFilter> repeatedField = uniqueTagsFilters_;
									bool flag5 = default(bool);
									if (flag5)
									{
										RepeatedField<Types.PricesTable> repeatedField2 = pricesTables_;
										bool flag6 = default(bool);
										if (flag6 && randomizeSlotsOrder_ == flag6)
										{
											return object.Equals(_unknownFields, other);
										}
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

		[Cpp2IlInjected.Token(Token = "0x6004523")]
		[Cpp2IlInjected.Address(RVA = "0x2C41610", Offset = "0x2C40010", VA = "0x182C41610", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DisplayItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									int num2 = other.sizeX_;
									if (sizeX_ == num2)
									{
										int num3 = other.sizeY_;
										if (sizeY_ == num3)
										{
											DisplayType objB = other.displayType_;
											if (object.Equals(displayType_, objB))
											{
												RepeatedField<UniqueTagsFilter> repeatedField = uniqueTagsFilters_;
												RepeatedField<UniqueTagsFilter> repeatedField2 = other.uniqueTagsFilters_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													RepeatedField<Types.PricesTable> repeatedField3 = pricesTables_;
													RepeatedField<Types.PricesTable> repeatedField4 = other.pricesTables_;
													if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
													{
														bool flag = other.randomizeSlotsOrder_;
														if (randomizeSlotsOrder_ == flag)
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
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004524")]
		[Cpp2IlInjected.Address(RVA = "0x2C419F0", Offset = "0x2C403F0", VA = "0x182C419F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00d9
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			if (sizeX_ != 0)
			{
			}
			if (sizeY_ != 0)
			{
			}
			DisplayType displayType = displayType_;
			if (displayType != null)
			{
				int hashCode5 = displayType.GetHashCode();
			}
			int hashCode6 = ((RepeatedField<T>)(object)uniqueTagsFilters_).GetHashCode();
			int hashCode7 = ((RepeatedField<T>)(object)pricesTables_).GetHashCode();
			if (randomizeSlotsOrder_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return hashCode7;
		}

		[Cpp2IlInjected.Token(Token = "0x6004525")]
		[Cpp2IlInjected.Address(RVA = "0x2C424A0", Offset = "0x2C40EA0", VA = "0x182C424A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004526")]
		[Cpp2IlInjected.Address(RVA = "0x2C42A20", Offset = "0x2C41420", VA = "0x182C42A20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0137
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (sizeX_ != 0)
			{
				int value6 = sizeX_;
				output.WriteInt32(value6);
			}
			if (sizeY_ != 0)
			{
				int value7 = sizeY_;
				output.WriteInt32(value7);
			}
			if ((long)displayType_ != 0)
			{
				DisplayType value8 = displayType_;
				output.WriteMessage(value8);
			}
			RepeatedField<UniqueTagsFilter> repeatedField = uniqueTagsFilters_;
			FieldCodec<UniqueTagsFilter> repeated_uniqueTagsFilters_codec = _repeated_uniqueTagsFilters_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_uniqueTagsFilters_codec);
			RepeatedField<Types.PricesTable> repeatedField2 = pricesTables_;
			FieldCodec<Types.PricesTable> repeated_pricesTables_codec = _repeated_pricesTables_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_pricesTables_codec);
			if (randomizeSlotsOrder_)
			{
				bool value9 = randomizeSlotsOrder_;
				output.WriteBool(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004527")]
		[Cpp2IlInjected.Address(RVA = "0x2C407C0", Offset = "0x2C3F1C0", VA = "0x182C407C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			int num8 = sizeX_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			int num10 = sizeY_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			DisplayType displayType = displayType_;
			if (displayType != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(displayType);
				num12++;
				num2 += num12;
			}
			RepeatedField<UniqueTagsFilter> repeatedField = uniqueTagsFilters_;
			FieldCodec<UniqueTagsFilter> repeated_uniqueTagsFilters_codec = _repeated_uniqueTagsFilters_codec;
			int num13 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_uniqueTagsFilters_codec);
			RepeatedField<Types.PricesTable> repeatedField2 = pricesTables_;
			FieldCodec<Types.PricesTable> repeated_pricesTables_codec = _repeated_pricesTables_codec;
			int num14 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_pricesTables_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<Types.PricesTable>)(repeatedField2 + num15);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004528")]
		[Cpp2IlInjected.Address(RVA = "0x2C41C80", Offset = "0x2C40680", VA = "0x182C41C80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DisplayItemData other)
		{
			//Discarded unreachable code: IL_0145
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			int num2 = other.sizeX_;
			if (num2 != 0)
			{
				sizeX_ = num2;
			}
			int num3 = other.sizeY_;
			if (num3 != 0)
			{
				sizeY_ = num3;
			}
			if ((long)other.displayType_ != 0)
			{
				DisplayType displayType2 = default(DisplayType);
				if (displayType_ == null)
				{
					DisplayType displayType = (displayType_ = new DisplayType());
					displayType2 = displayType_;
				}
				DisplayType other2 = other.displayType_;
				displayType2.MergeFrom(other2);
			}
			RepeatedField<UniqueTagsFilter> repeatedField = uniqueTagsFilters_;
			RepeatedField<UniqueTagsFilter> repeatedField2 = other.uniqueTagsFilters_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<Types.PricesTable> repeatedField3 = pricesTables_;
			RepeatedField<Types.PricesTable> repeatedField4 = other.pricesTables_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			bool flag = other.randomizeSlotsOrder_;
			if (flag)
			{
				randomizeSlotsOrder_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004529")]
		[Cpp2IlInjected.Address(RVA = "0x2C41E40", Offset = "0x2C40840", VA = "0x182C41E40", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_015c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 66)
				{
					if (num == 74)
					{
						RepeatedField<UniqueTagsFilter> repeatedField = uniqueTagsFilters_;
						FieldCodec<UniqueTagsFilter> repeated_uniqueTagsFilters_codec = _repeated_uniqueTagsFilters_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_uniqueTagsFilters_codec);
					}
					if (num == 82)
					{
						RepeatedField<Types.PricesTable> repeatedField2 = pricesTables_;
						FieldCodec<Types.PricesTable> repeated_pricesTables_codec = _repeated_pricesTables_codec;
						((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_pricesTables_codec);
					}
					if (num != 88)
					{
						goto IL_0145;
					}
					bool flag = (randomizeSlotsOrder_ = input.ReadBool());
				}
				int num2 = default(int);
				if (num == 48)
				{
					num2 = (sizeX_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num2 == 56)
				{
					num3 = (sizeY_ = input.ReadInt32());
				}
				if (num3 != 66)
				{
					goto IL_0145;
				}
				DisplayType builder = default(DisplayType);
				if (displayType_ == null)
				{
					DisplayType displayType = (displayType_ = new DisplayType());
					builder = displayType_;
				}
				input.ReadMessage(builder);
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text2 = default(string);
				if (num == 26)
				{
					text2 = (DisplayName = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_0145;
				}
				text6 = (PrefabAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text6 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_0145;
			IL_0145:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600452A")]
		[Cpp2IlInjected.Address(RVA = "0x2C41850", Offset = "0x2C40250", VA = "0x182C41850", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600452B")]
		[Cpp2IlInjected.Address(RVA = "0x2C42100", Offset = "0x2C40B00", VA = "0x182C42100", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0020, IL_0028, IL_0030, IL_003f, IL_0045, IL_004b, IL_0051, IL_0057, IL_005d, IL_0063
			//IL_000e: Expected I4, but got O
			//IL_0037: Expected O, but got I4
			if (fieldNumber - 1 <= 10)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600452C")]
		[Cpp2IlInjected.Address(RVA = "0x2C40A90", Offset = "0x2C3F490", VA = "0x182C40A90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_001a
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 10)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600452E")]
		[Cpp2IlInjected.Address(RVA = "0x2C40C20", Offset = "0x2C3F620", VA = "0x182C40C20", Slot = "20")]
		IItemData IItemData.Clone()
		{
			DisplayItemData displayItemData = new DisplayItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600452F")]
		[Cpp2IlInjected.Address(RVA = "0x2C41BA0", Offset = "0x2C405A0", VA = "0x182C41BA0")]
		public bool HasPricesTable(int numItems)
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Types.PricesTable> repeatedField = pricesTables_;
			Func<Types.PricesTable, bool> func = (Func<Types.PricesTable, bool>)(object)(Func<T, TResult>)delegate(Types.PricesTable x)
			{
				//Discarded unreachable code: IL_0018
				int count = ((RepeatedField<T>)(object)x.thresholds_).Count;
				int num = numItems;
				return count == num;
			};
			return Enumerable.FirstOrDefault<Types.PricesTable>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func) != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004530")]
		[Cpp2IlInjected.Address(RVA = "0x2C41770", Offset = "0x2C40170", VA = "0x182C41770")]
		public Types.PricesTable FindPricesTable(int numItems)
		{
			//Discarded unreachable code: IL_0029
			RepeatedField<Types.PricesTable> repeatedField = pricesTables_;
			Func<Types.PricesTable, bool> func = (Func<Types.PricesTable, bool>)(object)(Func<T, TResult>)delegate(Types.PricesTable x)
			{
				//Discarded unreachable code: IL_0018
				int count = ((RepeatedField<T>)(object)x.thresholds_).Count;
				int num = numItems;
				return count == num;
			};
			return Enumerable.FirstOrDefault<Types.PricesTable>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6004531")]
		[Cpp2IlInjected.Address(RVA = "0x2C40C80", Offset = "0x2C3F680", VA = "0x182C40C80", Slot = "21")]
		public unsafe void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00d8, IL_00de, IL_00e4, IL_00ea, IL_00f6, IL_00fc, IL_0102
			//IL_006a: Expected O, but got I4
			//IL_006a: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			FakeProfile fakeProfile = new FakeProfile();
			FakeProfile fakeProfile2 = new FakeProfile();
			DisplayType displayType = displayType_;
			DisplayType.TypeOneofCase typeCase_ = displayType.typeCase_;
			if (typeCase_ == DisplayType.TypeOneofCase.StoreStage)
			{
				DisplayType.TypeOneofCase typeCase_2 = displayType.typeCase_;
				if (displayType.type_ == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				if (flag)
				{
					int num5 = sizeY_;
					int num6 = sizeX_;
					bool flag2 = default(bool);
					if (flag2)
					{
						string text = $"StoreLayoutArea_{flag2}x{flag2}";
						bool flag3 = default(bool);
						while (!flag3)
						{
						}
						flag2 = flag3;
						string text2 = $"{flag2}x{flag3}";
					}
					num++;
					while (num == 0)
					{
					}
				}
				if (num + 1 != 0)
				{
					return;
				}
			}
			else
			{
				while (typeCase_ != DisplayType.TypeOneofCase.StoreShelf)
				{
				}
			}
			if (displayType_.type_ != null)
			{
				bool flag4 = default(bool);
				if (flag4)
				{
					string text3 = $"StoreLayoutArea_{flag4}";
					bool flag5 = default(bool);
					while (!flag5)
					{
					}
					flag4 = flag5;
					string text4 = (flag4 ? ((bool*)1) : ((bool*)null))->ToString();
					bool flag6 = flag4;
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004532")]
		[Cpp2IlInjected.Address(RVA = "0x2C42CD0", Offset = "0x2C416D0", VA = "0x182C42CD0")]
		static DisplayItemData()
		{
			Func<DisplayItemData> func = default(Func<DisplayItemData>);
			_parser = (MessageParser<DisplayItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<UniqueTagsFilter> parser = UniqueTagsFilter._parser;
			uint num = default(uint);
			_parser = (MessageParser<DisplayItemData>)(object)FieldCodec.ForMessage<UniqueTagsFilter>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.PricesTable> parser2 = Types.PricesTable._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<DisplayItemData>)(object)FieldCodec.ForMessage<Types.PricesTable>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
