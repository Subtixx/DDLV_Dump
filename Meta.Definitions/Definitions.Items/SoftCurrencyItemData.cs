using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200037C")]
	public sealed class SoftCurrencyItemData : IMessage<SoftCurrencyItemData>, IMessage, IEquatable<SoftCurrencyItemData>, IDeepCloneable<SoftCurrencyItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasCurrencyGlotIDs, IGridPlaceableItemData, IGridEditRestriction, IGenericBuyable, IIsOnlineOnly, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200037D")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200037E")]
			public sealed class HardCurrencyCost : IMessage<HardCurrencyCost>, IMessage, IEquatable<HardCurrencyCost>, IDeepCloneable<HardCurrencyCost>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40011CD")]
				private static readonly MessageParser<HardCurrencyCost> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40011CE")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40011CF")]
				public const int TierMinFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40011D0")]
				private int tierMin_;

				[Cpp2IlInjected.Token(Token = "0x40011D1")]
				public const int TierMaxFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40011D2")]
				private int tierMax_;

				[Cpp2IlInjected.Token(Token = "0x40011D3")]
				public const int ConversionEquationFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40011D4")]
				private string conversionEquation_;

				[Cpp2IlInjected.Token(Token = "0x17000A0F")]
				[DebuggerNonUserCode]
				public static MessageParser<HardCurrencyCost> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60028BA")]
					[Cpp2IlInjected.Address(RVA = "0x236E0F0", Offset = "0x236CAF0", VA = "0x18236E0F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A10")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60028BB")]
					[Cpp2IlInjected.Address(RVA = "0x236E070", Offset = "0x236CA70", VA = "0x18236E070")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A11")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60028BC")]
					[Cpp2IlInjected.Address(RVA = "0x236E150", Offset = "0x236CB50", VA = "0x18236E150", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A12")]
				[DebuggerNonUserCode]
				public int TierMin
				{
					[Cpp2IlInjected.Token(Token = "0x60028C0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60028C1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A13")]
				[DebuggerNonUserCode]
				public int TierMax
				{
					[Cpp2IlInjected.Token(Token = "0x60028C2")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60028C3")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000A14")]
				[DebuggerNonUserCode]
				public string ConversionEquation
				{
					[Cpp2IlInjected.Token(Token = "0x60028C4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60028C5")]
					[Cpp2IlInjected.Address(RVA = "0x236E210", Offset = "0x236CC10", VA = "0x18236E210")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60028BD")]
				[Cpp2IlInjected.Address(RVA = "0x236E020", Offset = "0x236CA20", VA = "0x18236E020")]
				[DebuggerNonUserCode]
				public HardCurrencyCost()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60028BE")]
				[Cpp2IlInjected.Address(RVA = "0x236DF80", Offset = "0x236C980", VA = "0x18236DF80")]
				[DebuggerNonUserCode]
				public HardCurrencyCost(HardCurrencyCost other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60028BF")]
				[Cpp2IlInjected.Address(RVA = "0x236D780", Offset = "0x236C180", VA = "0x18236D780", Slot = "10")]
				[DebuggerNonUserCode]
				public HardCurrencyCost Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60028C6")]
				[Cpp2IlInjected.Address(RVA = "0x236D8D0", Offset = "0x236C2D0", VA = "0x18236D8D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60028C7")]
				[Cpp2IlInjected.Address(RVA = "0x236D850", Offset = "0x236C250", VA = "0x18236D850", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(HardCurrencyCost other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60028C8")]
				[Cpp2IlInjected.Address(RVA = "0x236DA60", Offset = "0x236C460", VA = "0x18236DA60", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60028C9")]
				[Cpp2IlInjected.Address(RVA = "0x236DD50", Offset = "0x236C750", VA = "0x18236DD50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60028CA")]
				[Cpp2IlInjected.Address(RVA = "0x236DDB0", Offset = "0x236C7B0", VA = "0x18236DDB0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60028CB")]
				[Cpp2IlInjected.Address(RVA = "0x236D600", Offset = "0x236C000", VA = "0x18236D600", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60028CC")]
				[Cpp2IlInjected.Address(RVA = "0x236DBB0", Offset = "0x236C5B0", VA = "0x18236DBB0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(HardCurrencyCost other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60028CD")]
				[Cpp2IlInjected.Address(RVA = "0x236DB00", Offset = "0x236C500", VA = "0x18236DB00", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60028CE")]
				[Cpp2IlInjected.Address(RVA = "0x236D990", Offset = "0x236C390", VA = "0x18236D990", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60028CF")]
				[Cpp2IlInjected.Address(RVA = "0x236DC30", Offset = "0x236C630", VA = "0x18236DC30", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60028D0")]
				[Cpp2IlInjected.Address(RVA = "0x236D700", Offset = "0x236C100", VA = "0x18236D700", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000380")]
		private class EquationContext : IEquationContext
		{
			[Cpp2IlInjected.Token(Token = "0x17000A15")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40011D6")]
			public float Amount
			{
				[Cpp2IlInjected.Token(Token = "0x60028D5")]
				[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60028D6")]
				[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x60028D7")]
			[Cpp2IlInjected.Address(RVA = "0x9D31D0", Offset = "0x9D1BD0", VA = "0x1809D31D0", Slot = "4")]
			public float GetVariableValue(string variableName)
			{
				if (!string.Equals(variableName, "Amount"))
				{
					int num = 0;
				}
				return Amount;
			}

			[Cpp2IlInjected.Token(Token = "0x60028D8")]
			[Cpp2IlInjected.Address(RVA = "0x9D3230", Offset = "0x9D1C30", VA = "0x1809D3230", Slot = "5")]
			public bool HasVariableValue(string variableName)
			{
				return string.Equals(variableName, "Amount");
			}

			[Cpp2IlInjected.Token(Token = "0x60028D9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public EquationContext()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40011B1")]
		private static readonly MessageParser<SoftCurrencyItemData> _parser = (MessageParser<SoftCurrencyItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new SoftCurrencyItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40011B2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40011B3")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40011B4")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40011B5")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40011B6")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011B7")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40011B8")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011B9")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40011BA")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011BB")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40011BC")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40011BD")]
		public const int GridAreaDataFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40011BE")]
		private GridAreaData gridAreaData_;

		[Cpp2IlInjected.Token(Token = "0x40011BF")]
		public const int HardCurrencyConversionTiersFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x40011C0")]
		private static readonly FieldCodec<Types.HardCurrencyCost> _repeated_hardCurrencyConversionTiers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40011C1")]
		private readonly RepeatedField<Types.HardCurrencyCost> hardCurrencyConversionTiers_ = (RepeatedField<Types.HardCurrencyCost>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40011C2")]
		public const int DefaultCurrencyItemIDFieldNumber = 78;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40011C3")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x40011C4")]
		public const int IsOnlineOnlyFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40011C5")]
		private bool isOnlineOnly_;

		[Cpp2IlInjected.Token(Token = "0x40011C6")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40011C7")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x40011C8")]
		public const int CurrencyGlotIDFieldNumber = 1000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40011C9")]
		private uint currencyGlotID_;

		[Cpp2IlInjected.Token(Token = "0x40011CA")]
		private static readonly GridEditRestriction gridEditRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40011CB")]
		private Equation equation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40011CC")]
		private EquationContext equationContext = new EquationContext();

		[Cpp2IlInjected.Token(Token = "0x170009FD")]
		[DebuggerNonUserCode]
		public static MessageParser<SoftCurrencyItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600288B")]
			[Cpp2IlInjected.Address(RVA = "0x262AA00", Offset = "0x2629400", VA = "0x18262AA00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009FE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600288C")]
			[Cpp2IlInjected.Address(RVA = "0x262A8D0", Offset = "0x26292D0", VA = "0x18262A8D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009FF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600288D")]
			[Cpp2IlInjected.Address(RVA = "0x262AA60", Offset = "0x2629460", VA = "0x18262AA60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A00")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002892")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002893")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A01")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002894")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002895")]
			[Cpp2IlInjected.Address(RVA = "0x262AC50", Offset = "0x2629650", VA = "0x18262AC50")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A02")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002896")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002897")]
			[Cpp2IlInjected.Address(RVA = "0x262AB70", Offset = "0x2629570", VA = "0x18262AB70")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A03")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002898")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002899")]
			[Cpp2IlInjected.Address(RVA = "0x262ABE0", Offset = "0x26295E0", VA = "0x18262ABE0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A04")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600289A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600289B")]
			[Cpp2IlInjected.Address(RVA = "0x262ACC0", Offset = "0x26296C0", VA = "0x18262ACC0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A05")]
		[DebuggerNonUserCode]
		public GridAreaData GridAreaData
		{
			[Cpp2IlInjected.Token(Token = "0x600289C")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "25")]
			get
			{
				return gridAreaData_;
			}
			[Cpp2IlInjected.Token(Token = "0x600289D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				gridAreaData_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A06")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.HardCurrencyCost> HardCurrencyConversionTiers
		{
			[Cpp2IlInjected.Token(Token = "0x600289E")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return hardCurrencyConversionTiers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A07")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600289F")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028A0")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A08")]
		[DebuggerNonUserCode]
		public bool IsOnlineOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60028A1")]
			[Cpp2IlInjected.Address(RVA = "0x1781430", Offset = "0x177FE30", VA = "0x181781430", Slot = "29")]
			get
			{
				return isOnlineOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028A2")]
			[Cpp2IlInjected.Address(RVA = "0x1781A50", Offset = "0x1780450", VA = "0x181781A50")]
			set
			{
				isOnlineOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A09")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60028A3")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028A4")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A0A")]
		[DebuggerNonUserCode]
		public uint CurrencyGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60028A5")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820", Slot = "23")]
			get
			{
				return currencyGlotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60028A6")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				currencyGlotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A0B")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60028B2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "27")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A0C")]
		public uint CurrencyTypeGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60028B3")]
			[Cpp2IlInjected.Address(RVA = "0x262A8C0", Offset = "0x26292C0", VA = "0x18262A8C0", Slot = "24")]
			get
			{
				return 440881u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A0D")]
		public GridEditRestriction GridEditRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60028B4")]
			[Cpp2IlInjected.Address(RVA = "0x262A9A0", Offset = "0x26293A0", VA = "0x18262A9A0", Slot = "26")]
			get
			{
				return gridEditRestriction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000A0E")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x60028B5")]
			[Cpp2IlInjected.Address(RVA = "0x2628D30", Offset = "0x2627730", VA = "0x182628D30", Slot = "28")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600288E")]
		[Cpp2IlInjected.Address(RVA = "0x262A500", Offset = "0x2628F00", VA = "0x18262A500")]
		[DebuggerNonUserCode]
		public SoftCurrencyItemData()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600288F")]
		[Cpp2IlInjected.Address(RVA = "0x2629AB0", Offset = "0x26284B0", VA = "0x182629AB0")]
		private void OnConstruction()
		{
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002890")]
		[Cpp2IlInjected.Address(RVA = "0x262A650", Offset = "0x2629050", VA = "0x18262A650")]
		[DebuggerNonUserCode]
		public SoftCurrencyItemData(SoftCurrencyItemData other)
		{
			//IL_00c8: Expected O, but got I4
			GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			GridAreaData gridAreaData2 = other.gridAreaData_;
			if (gridAreaData2 != null)
			{
				GridAreaData gridAreaData3 = gridAreaData2.Clone();
			}
			int num2 = 0;
			gridAreaData_ = (GridAreaData)num2;
			RepeatedField<Types.HardCurrencyCost> repeatedField = (hardCurrencyConversionTiers_ = (RepeatedField<Types.HardCurrencyCost>)(object)((RepeatedField<T>)(object)other.hardCurrencyConversionTiers_).Clone());
			int num3 = (defaultCurrencyItemID_ = other.defaultCurrencyItemID_);
			bool flag = (isOnlineOnly_ = other.isOnlineOnly_);
			uint num4 = (glotID_ = other.glotID_);
			uint num5 = (currencyGlotID_ = other.currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002891")]
		[Cpp2IlInjected.Address(RVA = "0x2628C60", Offset = "0x2627660", VA = "0x182628C60", Slot = "10")]
		[DebuggerNonUserCode]
		public SoftCurrencyItemData Clone()
		{
			return new SoftCurrencyItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60028A7")]
		[Cpp2IlInjected.Address(RVA = "0x2628D90", Offset = "0x2627790", VA = "0x182628D90", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(SoftCurrencyItemData).TypeHandle)
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
								if (!flag4 && object.Equals(gridAreaData_, other))
								{
									RepeatedField<Types.HardCurrencyCost> repeatedField = hardCurrencyConversionTiers_;
									bool flag5 = default(bool);
									if (flag5 && defaultCurrencyItemID_ == (flag5 ? 1 : 0) && isOnlineOnly_ == flag5 && glotID_ == (flag5 ? 1u : 0u) && currencyGlotID_ == (flag5 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x60028A8")]
		[Cpp2IlInjected.Address(RVA = "0x2628F10", Offset = "0x2627910", VA = "0x182628F10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SoftCurrencyItemData other)
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
									GridAreaData objB = other.gridAreaData_;
									if (object.Equals(gridAreaData_, objB))
									{
										RepeatedField<Types.HardCurrencyCost> repeatedField = hardCurrencyConversionTiers_;
										RepeatedField<Types.HardCurrencyCost> repeatedField2 = other.hardCurrencyConversionTiers_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											int num2 = other.defaultCurrencyItemID_;
											if (defaultCurrencyItemID_ == num2)
											{
												bool flag = other.isOnlineOnly_;
												if (isOnlineOnly_ == flag)
												{
													uint num3 = other.glotID_;
													if (glotID_ == num3)
													{
														uint num4 = other.currencyGlotID_;
														if (currencyGlotID_ == num4)
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
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028A9")]
		[Cpp2IlInjected.Address(RVA = "0x26294F0", Offset = "0x2627EF0", VA = "0x1826294F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00d1
			int num = 0;
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
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int hashCode5 = gridAreaData.GetHashCode();
			}
			int hashCode6 = ((RepeatedField<T>)(object)hardCurrencyConversionTiers_).GetHashCode();
			if (defaultCurrencyItemID_ != 0)
			{
			}
			if (isOnlineOnly_)
			{
			}
			if (glotID_ != 0)
			{
			}
			if (currencyGlotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60028AA")]
		[Cpp2IlInjected.Address(RVA = "0x2629ED0", Offset = "0x26288D0", VA = "0x182629ED0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60028AB")]
		[Cpp2IlInjected.Address(RVA = "0x2629F30", Offset = "0x2628930", VA = "0x182629F30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0139
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
			if ((long)gridAreaData_ != 0)
			{
				GridAreaData value6 = gridAreaData_;
				output.WriteMessage(value6);
			}
			RepeatedField<Types.HardCurrencyCost> repeatedField = hardCurrencyConversionTiers_;
			FieldCodec<Types.HardCurrencyCost> repeated_hardCurrencyConversionTiers_codec = _repeated_hardCurrencyConversionTiers_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_hardCurrencyConversionTiers_codec);
			if (defaultCurrencyItemID_ != 0)
			{
				int value7 = defaultCurrencyItemID_;
				output.WriteInt32(value7);
			}
			if (isOnlineOnly_)
			{
				bool value8 = isOnlineOnly_;
				output.WriteBool(value8);
			}
			if (glotID_ != 0)
			{
				uint value9 = glotID_;
				output.WriteUInt32(value9);
			}
			if (currencyGlotID_ != 0)
			{
				uint value10 = currencyGlotID_;
				output.WriteUInt32(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60028AC")]
		[Cpp2IlInjected.Address(RVA = "0x26287E0", Offset = "0x26271E0", VA = "0x1826287E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_016b
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
			GridAreaData gridAreaData = gridAreaData_;
			if (gridAreaData != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(gridAreaData);
				num8++;
				num2 += num8;
			}
			RepeatedField<Types.HardCurrencyCost> repeatedField = hardCurrencyConversionTiers_;
			FieldCodec<Types.HardCurrencyCost> repeated_hardCurrencyConversionTiers_codec = _repeated_hardCurrencyConversionTiers_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_hardCurrencyConversionTiers_codec);
			int num10 = defaultCurrencyItemID_;
			num2 += num9;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11 += 2;
				num2 += num11;
			}
			uint num12 = glotID_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeUInt32Size(num12);
				num13 += 2;
				num2 += num13;
			}
			uint num14 = currencyGlotID_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeUInt32Size(num14);
				num15 += 2;
				num2 += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num2 += num16;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60028AD")]
		[Cpp2IlInjected.Address(RVA = "0x2629910", Offset = "0x2628310", VA = "0x182629910", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SoftCurrencyItemData other)
		{
			//Discarded unreachable code: IL_0143
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
			if ((long)other.gridAreaData_ != 0)
			{
				GridAreaData gridAreaData2 = default(GridAreaData);
				if (gridAreaData_ == null)
				{
					GridAreaData gridAreaData = (gridAreaData_ = new GridAreaData());
					gridAreaData2 = gridAreaData_;
				}
				GridAreaData other2 = other.gridAreaData_;
				gridAreaData2.MergeFrom(other2);
			}
			RepeatedField<Types.HardCurrencyCost> repeatedField = hardCurrencyConversionTiers_;
			RepeatedField<Types.HardCurrencyCost> repeatedField2 = other.hardCurrencyConversionTiers_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num2 = other.defaultCurrencyItemID_;
			if (num2 != 0)
			{
				defaultCurrencyItemID_ = num2;
			}
			bool flag = other.isOnlineOnly_;
			if (flag)
			{
				isOnlineOnly_ = flag;
			}
			uint num3 = other.glotID_;
			if (num3 != 0)
			{
				glotID_ = num3;
			}
			uint num4 = other.currencyGlotID_;
			if (num4 != 0)
			{
				currencyGlotID_ = num4;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60028AE")]
		[Cpp2IlInjected.Address(RVA = "0x2629690", Offset = "0x2628090", VA = "0x182629690", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0165
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 624)
				{
					if (num == 800)
					{
						bool flag = (isOnlineOnly_ = input.ReadBool());
					}
					int num2 = default(int);
					if (num == 7992)
					{
						num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					if (num2 != 8000)
					{
						goto IL_014e;
					}
					int num3 = (int)(currencyGlotID_ = (uint)input.ReadInt32());
				}
				GridAreaData gridAreaData = default(GridAreaData);
				if (num == 50)
				{
					GridAreaData builder = default(GridAreaData);
					if (gridAreaData_ == null)
					{
						gridAreaData = (gridAreaData_ = new GridAreaData());
						builder = gridAreaData_;
					}
					input.ReadMessage(builder);
				}
				if ((long)gridAreaData == 58)
				{
					RepeatedField<Types.HardCurrencyCost> repeatedField = hardCurrencyConversionTiers_;
					FieldCodec<Types.HardCurrencyCost> repeated_hardCurrencyConversionTiers_codec = _repeated_hardCurrencyConversionTiers_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_hardCurrencyConversionTiers_codec);
				}
				if ((long)gridAreaData != 624)
				{
					goto IL_014e;
				}
				int num4 = (defaultCurrencyItemID_ = input.ReadInt32());
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
					goto IL_014e;
				}
				text6 = (PrefabAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text6 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			if (num5 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_014e;
			IL_014e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60028AF")]
		[Cpp2IlInjected.Address(RVA = "0x2629050", Offset = "0x2627A50", VA = "0x182629050", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 78)
			{
				if (fieldNumber == 100)
				{
					bool flag = isOnlineOnly_;
				}
				if (fieldNumber == 999)
				{
				}
				if (fieldNumber != 1000)
				{
					goto IL_0033;
				}
			}
			if (fieldNumber - 1 <= 6)
			{
				int num = iD_;
			}
			if (fieldNumber != 78)
			{
			}
			goto IL_0033;
			IL_0033:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028B0")]
		[Cpp2IlInjected.Address(RVA = "0x2629B10", Offset = "0x2628510", VA = "0x182629B10", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0038, IL_0039, IL_003a, IL_003b, IL_003c, IL_004b, IL_0051, IL_0057, IL_005d, IL_0063, IL_0069, IL_006f
			//IL_0011: Expected I4, but got O
			//IL_0021: Expected I4, but got O
			//IL_0029: Expected I4, but got O
			//IL_0037: Expected I4, but got O
			//IL_0043: Expected O, but got I4
			if (fieldNumber > 78)
			{
				switch (fieldNumber)
				{
				case 100:
				{
					object obj3 = default(object);
					isOnlineOnly_ = (byte)(int)obj3 != 0;
					break;
				}
				case 999:
				{
					object obj2 = default(object);
					glotID_ = (uint)(int)obj2;
					break;
				}
				default:
				{
					object obj = default(object);
					currencyGlotID_ = (uint)(int)obj;
					break;
				}
				}
			}
			else if (fieldNumber - 1 <= 6)
			{
				object obj4 = default(object);
				iD_ = (int)obj4;
			}
			else
			{
				defaultCurrencyItemID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028B1")]
		[Cpp2IlInjected.Address(RVA = "0x2628AB0", Offset = "0x26274B0", VA = "0x182628AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_003d, IL_003e, IL_003f, IL_0040, IL_0049
			//IL_0023: Expected I4, but got I8
			//IL_003c: Expected I4, but got I8
			if (fieldNumber > 78)
			{
				switch (fieldNumber)
				{
				case 100:
					isOnlineOnly_ = false;
					break;
				case 999:
					glotID_ = 0u;
					break;
				}
			}
			else if (fieldNumber - 1 <= 6)
			{
				iD_ = 0;
			}
			else if (fieldNumber != 78)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028B6")]
		[Cpp2IlInjected.Address(RVA = "0x2629210", Offset = "0x2627C10", VA = "0x182629210")]
		public int GetHardCurrencyPriceForSoftCurrency(int amount)
		{
			//Discarded unreachable code: IL_0056
			//IL_0050: Expected O, but got I4
			bool flag = default(bool);
			Types.HardCurrencyCost hardCurrencyCost = default(Types.HardCurrencyCost);
			uint num2 = default(uint);
			bool flag2 = default(bool);
			do
			{
				int num = 0;
				RepeatedField<Types.HardCurrencyCost> repeatedField = hardCurrencyConversionTiers_;
				if (flag)
				{
				}
				if (num != 0)
				{
					continue;
				}
				if (_003C_003Ec._003C_003E9__90_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(Types.HardCurrencyCost x)
					{
						//Discarded unreachable code: IL_0015
						if (x.tierMin_ != 0)
						{
							int num3 = 0;
						}
						return x.tierMax_ == 0;
					};
				}
				if (hardCurrencyCost != null)
				{
				}
			}
			while (num2 != 0 && !flag2);
			Equation.Parse(hardCurrencyCost.conversionEquation_).parsedEquation = (List<IToken>)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028B7")]
		[Cpp2IlInjected.Address(RVA = "0x2628C60", Offset = "0x2627660", VA = "0x182628C60", Slot = "20")]
		IItemData IItemData.Clone()
		{
			SoftCurrencyItemData softCurrencyItemData = new SoftCurrencyItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028B8")]
		[Cpp2IlInjected.Address(RVA = "0x2628CC0", Offset = "0x26276C0", VA = "0x182628CC0", Slot = "30")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001b
			if (currencyGlotID_ == 0)
			{
				context.AddInvalidMemberError("Must be properly defined", "CurrencyGlotID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028B9")]
		[Cpp2IlInjected.Address(RVA = "0x262A1D0", Offset = "0x2628BD0", VA = "0x18262A1D0")]
		static SoftCurrencyItemData()
		{
			MessageParser<Types.HardCurrencyCost> parser = Types.HardCurrencyCost._parser;
			uint num = default(uint);
			_parser = (MessageParser<SoftCurrencyItemData>)(object)FieldCodec.ForMessage<Types.HardCurrencyCost>(num, (MessageParser<>)(object)parser);
			GridEditRestriction gridEditRestriction = new GridEditRestriction();
			GridEditRestriction.Types.Restriction restriction = new GridEditRestriction.Types.Restriction();
			int num2 = ((restriction.Value = false) ? 1 : 0);
			gridEditRestriction.canMove_ = restriction;
			GridEditRestriction.Types.Restriction restriction2 = new GridEditRestriction.Types.Restriction();
			int num3 = ((restriction2.Value = false) ? 1 : 0);
			gridEditRestriction.canRotate_ = restriction2;
			GridEditRestriction.Types.Restriction restriction3 = new GridEditRestriction.Types.Restriction();
			int num4 = ((restriction3.Value = false) ? 1 : 0);
			gridEditRestriction.canBeRemoved_ = restriction3;
			gridEditRestriction.canBeCleared_ = false;
			GridEditRestriction.Types.Restriction restriction4 = new GridEditRestriction.Types.Restriction();
			int num5 = ((restriction4.Value = false) ? 1 : 0);
			gridEditRestriction.canBeSelected_ = restriction4;
			_parser = (MessageParser<SoftCurrencyItemData>)(object)gridEditRestriction;
			throw new NullReferenceException();
		}
	}
}
