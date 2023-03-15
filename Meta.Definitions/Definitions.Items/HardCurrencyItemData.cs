using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000376")]
	public sealed class HardCurrencyItemData : IMessage<HardCurrencyItemData>, IMessage, IEquatable<HardCurrencyItemData>, IDeepCloneable<HardCurrencyItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasCurrencyGlotIDs, IGenericBuyable, IIsOnlineOnly, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000377")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000378")]
			public sealed class HardCurrencySkipTimerCost : IMessage<HardCurrencySkipTimerCost>, IMessage, IEquatable<HardCurrencySkipTimerCost>, IDeepCloneable<HardCurrencySkipTimerCost>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40011A5")]
				private static readonly MessageParser<HardCurrencySkipTimerCost> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40011A6")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40011A7")]
				public const int TierMinFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40011A8")]
				private int tierMin_;

				[Cpp2IlInjected.Token(Token = "0x40011A9")]
				public const int TierMaxFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40011AA")]
				private int tierMax_;

				[Cpp2IlInjected.Token(Token = "0x40011AB")]
				public const int ConversionEquationFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40011AC")]
				private string conversionEquation_;

				[Cpp2IlInjected.Token(Token = "0x170009F6")]
				[DebuggerNonUserCode]
				public static MessageParser<HardCurrencySkipTimerCost> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002867")]
					[Cpp2IlInjected.Address(RVA = "0x2942FD0", Offset = "0x29419D0", VA = "0x182942FD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009F7")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002868")]
					[Cpp2IlInjected.Address(RVA = "0x2942F50", Offset = "0x2941950", VA = "0x182942F50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009F8")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002869")]
					[Cpp2IlInjected.Address(RVA = "0x2943030", Offset = "0x2941A30", VA = "0x182943030", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009F9")]
				[DebuggerNonUserCode]
				public int TierMin
				{
					[Cpp2IlInjected.Token(Token = "0x600286D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600286E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009FA")]
				[DebuggerNonUserCode]
				public int TierMax
				{
					[Cpp2IlInjected.Token(Token = "0x600286F")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002870")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170009FB")]
				[DebuggerNonUserCode]
				public string ConversionEquation
				{
					[Cpp2IlInjected.Token(Token = "0x6002871")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002872")]
					[Cpp2IlInjected.Address(RVA = "0x29430F0", Offset = "0x2941AF0", VA = "0x1829430F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600286A")]
				[Cpp2IlInjected.Address(RVA = "0x2942F00", Offset = "0x2941900", VA = "0x182942F00")]
				[DebuggerNonUserCode]
				public HardCurrencySkipTimerCost()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600286B")]
				[Cpp2IlInjected.Address(RVA = "0x2942E60", Offset = "0x2941860", VA = "0x182942E60")]
				[DebuggerNonUserCode]
				public HardCurrencySkipTimerCost(HardCurrencySkipTimerCost other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600286C")]
				[Cpp2IlInjected.Address(RVA = "0x2942840", Offset = "0x2941240", VA = "0x182942840", Slot = "10")]
				[DebuggerNonUserCode]
				public HardCurrencySkipTimerCost Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002873")]
				[Cpp2IlInjected.Address(RVA = "0x2942910", Offset = "0x2941310", VA = "0x182942910", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002874")]
				[Cpp2IlInjected.Address(RVA = "0x236D850", Offset = "0x236C250", VA = "0x18236D850", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(HardCurrencySkipTimerCost other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002875")]
				[Cpp2IlInjected.Address(RVA = "0x236DA60", Offset = "0x236C460", VA = "0x18236DA60", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002876")]
				[Cpp2IlInjected.Address(RVA = "0x2942CF0", Offset = "0x29416F0", VA = "0x182942CF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002877")]
				[Cpp2IlInjected.Address(RVA = "0x236DDB0", Offset = "0x236C7B0", VA = "0x18236DDB0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002878")]
				[Cpp2IlInjected.Address(RVA = "0x29426C0", Offset = "0x29410C0", VA = "0x1829426C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002879")]
				[Cpp2IlInjected.Address(RVA = "0x2942AA0", Offset = "0x29414A0", VA = "0x182942AA0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(HardCurrencySkipTimerCost other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600287A")]
				[Cpp2IlInjected.Address(RVA = "0x2942B20", Offset = "0x2941520", VA = "0x182942B20", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600287B")]
				[Cpp2IlInjected.Address(RVA = "0x29429D0", Offset = "0x29413D0", VA = "0x1829429D0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600287C")]
				[Cpp2IlInjected.Address(RVA = "0x2942BD0", Offset = "0x29415D0", VA = "0x182942BD0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600287D")]
				[Cpp2IlInjected.Address(RVA = "0x29427C0", Offset = "0x29411C0", VA = "0x1829427C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200037A")]
		private class EquationContext : IEquationContext
		{
			[Cpp2IlInjected.Token(Token = "0x170009FC")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40011AE")]
			public float Minutes
			{
				[Cpp2IlInjected.Token(Token = "0x6002882")]
				[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6002883")]
				[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6002884")]
			[Cpp2IlInjected.Address(RVA = "0x8EDD30", Offset = "0x8EC730", VA = "0x1808EDD30", Slot = "4")]
			public float GetVariableValue(string variableName)
			{
				if (!string.Equals(variableName, "Minutes"))
				{
					int num = 0;
				}
				return Minutes;
			}

			[Cpp2IlInjected.Token(Token = "0x6002885")]
			[Cpp2IlInjected.Address(RVA = "0x8EDD90", Offset = "0x8EC790", VA = "0x1808EDD90", Slot = "5")]
			public bool HasVariableValue(string variableName)
			{
				return string.Equals(variableName, "Minutes");
			}

			[Cpp2IlInjected.Token(Token = "0x6002886")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public EquationContext()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400118C")]
		private static readonly MessageParser<HardCurrencyItemData> _parser = (MessageParser<HardCurrencyItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new HardCurrencyItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400118D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400118E")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400118F")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001190")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001191")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001192")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001193")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001194")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001195")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001196")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001197")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001198")]
		public const int SkipTimerTiersFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4001199")]
		private static readonly FieldCodec<Types.HardCurrencySkipTimerCost> _repeated_skipTimerTiers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400119A")]
		private readonly RepeatedField<Types.HardCurrencySkipTimerCost> skipTimerTiers_ = (RepeatedField<Types.HardCurrencySkipTimerCost>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400119B")]
		public const int DefaultCurrencyItemIDFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400119C")]
		private int defaultCurrencyItemID_;

		[Cpp2IlInjected.Token(Token = "0x400119D")]
		public const int IsOnlineOnlyFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400119E")]
		private bool isOnlineOnly_;

		[Cpp2IlInjected.Token(Token = "0x400119F")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40011A0")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x40011A1")]
		public const int CurrencyGlotIDFieldNumber = 1000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40011A2")]
		private uint currencyGlotID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40011A3")]
		private Equation equation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40011A4")]
		private EquationContext equationContext = new EquationContext();

		[Cpp2IlInjected.Token(Token = "0x170009E6")]
		[DebuggerNonUserCode]
		public static MessageParser<HardCurrencyItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600283C")]
			[Cpp2IlInjected.Address(RVA = "0x2FA0970", Offset = "0x2F9F370", VA = "0x182FA0970")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009E7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600283D")]
			[Cpp2IlInjected.Address(RVA = "0x2FA08A0", Offset = "0x2F9F2A0", VA = "0x182FA08A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009E8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600283E")]
			[Cpp2IlInjected.Address(RVA = "0x2FA09D0", Offset = "0x2F9F3D0", VA = "0x182FA09D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009E9")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002842")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002843")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009EA")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002844")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002845")]
			[Cpp2IlInjected.Address(RVA = "0x2FA0BC0", Offset = "0x2F9F5C0", VA = "0x182FA0BC0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009EB")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002846")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002847")]
			[Cpp2IlInjected.Address(RVA = "0x2FA0AE0", Offset = "0x2F9F4E0", VA = "0x182FA0AE0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009EC")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002848")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002849")]
			[Cpp2IlInjected.Address(RVA = "0x2FA0B50", Offset = "0x2F9F550", VA = "0x182FA0B50")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009ED")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600284A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600284B")]
			[Cpp2IlInjected.Address(RVA = "0x2FA0C30", Offset = "0x2F9F630", VA = "0x182FA0C30")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009EE")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.HardCurrencySkipTimerCost> SkipTimerTiers
		{
			[Cpp2IlInjected.Token(Token = "0x600284C")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return skipTimerTiers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009EF")]
		[DebuggerNonUserCode]
		public int DefaultCurrencyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600284D")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return defaultCurrencyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600284E")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				defaultCurrencyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009F0")]
		[DebuggerNonUserCode]
		public bool IsOnlineOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600284F")]
			[Cpp2IlInjected.Address(RVA = "0x70CA70", Offset = "0x70B470", VA = "0x18070CA70", Slot = "27")]
			get
			{
				return isOnlineOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002850")]
			[Cpp2IlInjected.Address(RVA = "0x70CE60", Offset = "0x70B860", VA = "0x18070CE60")]
			set
			{
				isOnlineOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009F1")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002851")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002852")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009F2")]
		[DebuggerNonUserCode]
		public uint CurrencyGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002853")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830", Slot = "23")]
			get
			{
				return currencyGlotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002854")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				currencyGlotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009F3")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002860")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "25")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009F4")]
		public uint CurrencyTypeGlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002861")]
			[Cpp2IlInjected.Address(RVA = "0x254FCA0", Offset = "0x254E6A0", VA = "0x18254FCA0", Slot = "24")]
			get
			{
				return 440880u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170009F5")]
		Item IGenericBuyable.DefaultCurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002862")]
			[Cpp2IlInjected.Address(RVA = "0x2F9F080", Offset = "0x2F9DA80", VA = "0x182F9F080", Slot = "26")]
			get
			{
				long num = Convert.ToInt64((uint)defaultCurrencyItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600283F")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0790", Offset = "0x2F9F190", VA = "0x182FA0790")]
		[DebuggerNonUserCode]
		public HardCurrencyItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002840")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0590", Offset = "0x2F9EF90", VA = "0x182FA0590")]
		[DebuggerNonUserCode]
		public HardCurrencyItemData(HardCurrencyItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField = (skipTimerTiers_ = (RepeatedField<Types.HardCurrencySkipTimerCost>)(object)((RepeatedField<T>)(object)other.skipTimerTiers_).Clone());
			int num2 = (defaultCurrencyItemID_ = other.defaultCurrencyItemID_);
			bool flag = (isOnlineOnly_ = other.isOnlineOnly_);
			uint num3 = (glotID_ = other.glotID_);
			uint num4 = (currencyGlotID_ = other.currencyGlotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002841")]
		[Cpp2IlInjected.Address(RVA = "0x2F9EFB0", Offset = "0x2F9D9B0", VA = "0x182F9EFB0", Slot = "10")]
		[DebuggerNonUserCode]
		public HardCurrencyItemData Clone()
		{
			return new HardCurrencyItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002855")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F200", Offset = "0x2F9DC00", VA = "0x182F9F200", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(HardCurrencyItemData).TypeHandle)
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
								if (!flag4)
								{
									RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField = skipTimerTiers_;
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

		[Cpp2IlInjected.Token(Token = "0x6002856")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F0E0", Offset = "0x2F9DAE0", VA = "0x182F9F0E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(HardCurrencyItemData other)
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
									RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField = skipTimerTiers_;
									RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField2 = other.skipTimerTiers_;
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
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002857")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F520", Offset = "0x2F9DF20", VA = "0x182F9F520", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00bb
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
			int hashCode5 = ((RepeatedField<T>)(object)skipTimerTiers_).GetHashCode();
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
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002858")]
		[Cpp2IlInjected.Address(RVA = "0x2FA00F0", Offset = "0x2F9EAF0", VA = "0x182FA00F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002859")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0150", Offset = "0x2F9EB50", VA = "0x182FA0150", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_011e
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
			RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField = skipTimerTiers_;
			FieldCodec<Types.HardCurrencySkipTimerCost> repeated_skipTimerTiers_codec = _repeated_skipTimerTiers_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_skipTimerTiers_codec);
			if (defaultCurrencyItemID_ != 0)
			{
				int value6 = defaultCurrencyItemID_;
				output.WriteInt32(value6);
			}
			if (isOnlineOnly_)
			{
				bool value7 = isOnlineOnly_;
				output.WriteBool(value7);
			}
			if (glotID_ != 0)
			{
				uint value8 = glotID_;
				output.WriteUInt32(value8);
			}
			if (currencyGlotID_ != 0)
			{
				uint value9 = currencyGlotID_;
				output.WriteUInt32(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600285A")]
		[Cpp2IlInjected.Address(RVA = "0x2F9EB80", Offset = "0x2F9D580", VA = "0x182F9EB80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_014a
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
			RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField = skipTimerTiers_;
			FieldCodec<Types.HardCurrencySkipTimerCost> repeated_skipTimerTiers_codec = _repeated_skipTimerTiers_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_skipTimerTiers_codec);
			int num9 = defaultCurrencyItemID_;
			num2 += num8;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			uint num11 = glotID_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeUInt32Size(num11);
				num12 += 2;
				num2 += num12;
			}
			uint num13 = currencyGlotID_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeUInt32Size(num13);
				num14 += 2;
				num2 += num14;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				num2 += num15;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600285B")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FA40", Offset = "0x2F9E440", VA = "0x182F9FA40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(HardCurrencyItemData other)
		{
			//Discarded unreachable code: IL_0107
			if (other != null)
			{
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
				RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField = skipTimerTiers_;
				RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField2 = other.skipTimerTiers_;
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
		}

		[Cpp2IlInjected.Token(Token = "0x600285C")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FB70", Offset = "0x2F9E570", VA = "0x182F9FB70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_012d
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 56)
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
						goto IL_0116;
					}
					int num3 = (int)(currencyGlotID_ = (uint)input.ReadInt32());
				}
				if (num == 50)
				{
					RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField = skipTimerTiers_;
					FieldCodec<Types.HardCurrencySkipTimerCost> repeated_skipTimerTiers_codec = _repeated_skipTimerTiers_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_skipTimerTiers_codec);
				}
				if (num != 56)
				{
					goto IL_0116;
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
					goto IL_0116;
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
			goto IL_0116;
			IL_0116:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600285D")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F370", Offset = "0x2F9DD70", VA = "0x182F9F370", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 100)
			{
				if (fieldNumber == 999)
				{
				}
				if (fieldNumber != 1000)
				{
					goto IL_0027;
				}
			}
			if (fieldNumber - 1 <= 6)
			{
				int num = iD_;
			}
			if (fieldNumber != 100)
			{
			}
			goto IL_0027;
			IL_0027:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600285E")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FD80", Offset = "0x2F9E780", VA = "0x182F9FD80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0033, IL_0034, IL_0035, IL_0036, IL_0037, IL_0044, IL_0054, IL_005a, IL_0060, IL_0066, IL_006c
			//IL_0014: Expected I4, but got O
			//IL_0024: Expected I4, but got O
			//IL_0032: Expected I4, but got O
			if (fieldNumber > 100)
			{
				if (fieldNumber == 999)
				{
					object obj = default(object);
					glotID_ = (uint)(int)obj;
					return;
				}
				while (fieldNumber != 1000)
				{
				}
				object obj2 = default(object);
				currencyGlotID_ = (uint)(int)obj2;
			}
			else if (fieldNumber - 1 <= 6)
			{
				object obj3 = default(object);
				iD_ = (int)obj3;
			}
			else
			{
				isOnlineOnly_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600285F")]
		[Cpp2IlInjected.Address(RVA = "0x2F9EE20", Offset = "0x2F9D820", VA = "0x182F9EE20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0039, IL_003a, IL_003b, IL_003c, IL_003f, IL_0046
			//IL_0016: Expected I4, but got I8
			//IL_0028: Expected I4, but got I8
			//IL_0038: Expected I4, but got I8
			if (fieldNumber > 100)
			{
				switch (fieldNumber)
				{
				case 999:
					glotID_ = 0u;
					break;
				case 1000:
					currencyGlotID_ = 0u;
					break;
				}
			}
			else if (fieldNumber - 1 <= 6)
			{
				iD_ = 0;
			}
			else if (fieldNumber != 100)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002863")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F6B0", Offset = "0x2F9E0B0", VA = "0x182F9F6B0")]
		public int GetPriceToSkip(TimeSpan timeToSkip)
		{
			//Discarded unreachable code: IL_005f
			//IL_005d: Expected O, but got F8
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				RepeatedField<Types.HardCurrencySkipTimerCost> repeatedField = skipTimerTiers_;
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				Types.HardCurrencySkipTimerCost hardCurrencySkipTimerCost = default(Types.HardCurrencySkipTimerCost);
				if (num == 0)
				{
					if (_003C_003Ec._003C_003E9__82_0 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(Types.HardCurrencySkipTimerCost x)
						{
							//Discarded unreachable code: IL_0015
							if (x.tierMin_ != 0)
							{
								int num5 = 0;
							}
							return x.tierMax_ == 0;
						};
					}
					if (hardCurrencySkipTimerCost != null)
					{
					}
				}
				uint num2 = default(uint);
				bool flag3 = default(bool);
				if (num2 == 0 || flag3)
				{
					Equation equation = Equation.Parse(hardCurrencySkipTimerCost.conversionEquation_);
				}
				int num3 = 0;
				double num4 = default(double);
				hardCurrencySkipTimerCost._unknownFields = (UnknownFieldSet)num4;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002864")]
		[Cpp2IlInjected.Address(RVA = "0x2F9EFB0", Offset = "0x2F9D9B0", VA = "0x182F9EFB0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			HardCurrencyItemData hardCurrencyItemData = new HardCurrencyItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002865")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F010", Offset = "0x2F9DA10", VA = "0x182F9F010", Slot = "28")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001b
			if (currencyGlotID_ == 0)
			{
				context.AddInvalidMemberError("Must be properly defined", "CurrencyGlotID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002866")]
		[Cpp2IlInjected.Address(RVA = "0x2FA03C0", Offset = "0x2F9EDC0", VA = "0x182FA03C0")]
		static HardCurrencyItemData()
		{
			MessageParser<Types.HardCurrencySkipTimerCost> parser = Types.HardCurrencySkipTimerCost._parser;
			uint num = default(uint);
			_parser = (MessageParser<HardCurrencyItemData>)(object)FieldCodec.ForMessage<Types.HardCurrencySkipTimerCost>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
