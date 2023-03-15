using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class StoreContent : IMessage<StoreContent>, IMessage, IEquatable<StoreContent>, IDeepCloneable<StoreContent>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public enum ContentTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			Bundle,
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			Item
		}

		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000A1")]
			public sealed class StoreSale : IMessage<StoreSale>, IMessage, IEquatable<StoreSale>, IDeepCloneable<StoreSale>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000306")]
				private static readonly MessageParser<StoreSale> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000308")]
				public const int StartDateFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000309")]
				private ConditionDate startDate_;

				[Cpp2IlInjected.Token(Token = "0x400030A")]
				public const int EndDateFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				private ConditionDate endDate_;

				[Cpp2IlInjected.Token(Token = "0x400030C")]
				public const int TypeFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400030D")]
				private StoreSaleType type_;

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				[DebuggerNonUserCode]
				public static MessageParser<StoreSale> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600070C")]
					[Cpp2IlInjected.Address(RVA = "0x2376320", Offset = "0x2374D20", VA = "0x182376320")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600070D")]
					[Cpp2IlInjected.Address(RVA = "0x23762A0", Offset = "0x2374CA0", VA = "0x1823762A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600070E")]
					[Cpp2IlInjected.Address(RVA = "0x2376380", Offset = "0x2374D80", VA = "0x182376380", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				[DebuggerNonUserCode]
				public ConditionDate StartDate
				{
					[Cpp2IlInjected.Token(Token = "0x6000713")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000714")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				[DebuggerNonUserCode]
				public ConditionDate EndDate
				{
					[Cpp2IlInjected.Token(Token = "0x6000715")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000716")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				[DebuggerNonUserCode]
				public StoreSaleType Type
				{
					[Cpp2IlInjected.Token(Token = "0x6000717")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000718")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600070F")]
				[Cpp2IlInjected.Address(RVA = "0x2376130", Offset = "0x2374B30", VA = "0x182376130")]
				[DebuggerNonUserCode]
				public StoreSale()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000710")]
				[Cpp2IlInjected.Address(RVA = "0x2375BD0", Offset = "0x23745D0", VA = "0x182375BD0")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000711")]
				[Cpp2IlInjected.Address(RVA = "0x2376060", Offset = "0x2374A60", VA = "0x182376060")]
				[DebuggerNonUserCode]
				public StoreSale(StoreSale other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000712")]
				[Cpp2IlInjected.Address(RVA = "0x2375650", Offset = "0x2374050", VA = "0x182375650", Slot = "10")]
				[DebuggerNonUserCode]
				public StoreSale Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x2375750", Offset = "0x2374150", VA = "0x182375750", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600071A")]
				[Cpp2IlInjected.Address(RVA = "0x713280", Offset = "0x711C80", VA = "0x180713280", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(StoreSale other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600071B")]
				[Cpp2IlInjected.Address(RVA = "0x7133C0", Offset = "0x711DC0", VA = "0x1807133C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600071C")]
				[Cpp2IlInjected.Address(RVA = "0x2375E30", Offset = "0x2374830", VA = "0x182375E30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600071D")]
				[Cpp2IlInjected.Address(RVA = "0x2375E90", Offset = "0x2374890", VA = "0x182375E90", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600071E")]
				[Cpp2IlInjected.Address(RVA = "0x23754F0", Offset = "0x2373EF0", VA = "0x1823754F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600071F")]
				[Cpp2IlInjected.Address(RVA = "0x23758D0", Offset = "0x23742D0", VA = "0x1823758D0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(StoreSale other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000720")]
				[Cpp2IlInjected.Address(RVA = "0x2375A50", Offset = "0x2374450", VA = "0x182375A50", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000721")]
				[Cpp2IlInjected.Address(RVA = "0x2375830", Offset = "0x2374230", VA = "0x182375830", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000722")]
				[Cpp2IlInjected.Address(RVA = "0x2375D40", Offset = "0x2374740", VA = "0x182375D40", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000723")]
				[Cpp2IlInjected.Address(RVA = "0x2375600", Offset = "0x2374000", VA = "0x182375600", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000724")]
				[Cpp2IlInjected.Address(RVA = "0x2375490", Offset = "0x2373E90", VA = "0x182375490")]
				public int ApplyTo(int originalAmount)
				{
					return default(int);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public struct FullPriceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public ContentPrice OriginalPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public int UpdatedPriceAmount;

			[Cpp2IlInjected.Token(Token = "0x170001C4")]
			public bool IsOnSale
			{
				[Cpp2IlInjected.Token(Token = "0x6000729")]
				[Cpp2IlInjected.Address(RVA = "0x9D3270", Offset = "0x9D1C70", VA = "0x1809D3270")]
				get
				{
					//Discarded unreachable code: IL_0010
					int updatedPriceAmount = UpdatedPriceAmount;
					return (long)(IntPtr)"{il2cpp field on {'constant1' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x1C}" > (long)updatedPriceAmount;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public struct ItemReward
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public IItemData ItemData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public int Quantity;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public class Info
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public List<ItemReward> Items;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public List<ContentPrice> Prices;

			[Cpp2IlInjected.Token(Token = "0x170001C5")]
			public Types.StoreSale ActiveSale
			{
				[Cpp2IlInjected.Token(Token = "0x600072A")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CActiveSale_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600072B")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CActiveSale_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Info()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private static readonly MessageParser<StoreContent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public const int BundleFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public const int ItemFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public const int IsFeaturedFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private bool isFeatured_;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public const int SalesFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private static readonly FieldCodec<Types.StoreSale> _repeated_sales_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private readonly RepeatedField<Types.StoreSale> sales_ = (RepeatedField<Types.StoreSale>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private object contentType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private ContentTypeOneofCase contentTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreContent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x26396B0", Offset = "0x26380B0", VA = "0x1826396B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x2639510", Offset = "0x2637F10", VA = "0x182639510")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x26397C0", Offset = "0x26381C0", VA = "0x1826397C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		[DebuggerNonUserCode]
		public StoreContentBundle Bundle
		{
			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x26394B0", Offset = "0x2637EB0", VA = "0x1826394B0")]
			get
			{
				int num = 0;
				if (contentTypeCase_ == ContentTypeOneofCase.Bundle)
				{
					object obj = contentType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x25F14A0", Offset = "0x25EFEA0", VA = "0x1825F14A0")]
			set
			{
				contentType_ = value;
				bool flag = (byte)(contentTypeCase_ = ((value != null) ? ContentTypeOneofCase.Bundle : ContentTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		[DebuggerNonUserCode]
		public StoreContentItem Item
		{
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x2639650", Offset = "0x2638050", VA = "0x182639650")]
			get
			{
				int num = 0;
				if (contentTypeCase_ == ContentTypeOneofCase.Item)
				{
					object obj = contentType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x25F1460", Offset = "0x25EFE60", VA = "0x1825F1460")]
			set
			{
				contentType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		[DebuggerNonUserCode]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return isFeatured_;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				isFeatured_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.StoreSale> Sales
		{
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return sales_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		[DebuggerNonUserCode]
		public ContentTypeOneofCase ContentTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return contentTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public bool IsBundle
		{
			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0x2480DB0", Offset = "0x247F7B0", VA = "0x182480DB0")]
			get
			{
				return contentTypeCase_ == ContentTypeOneofCase.Bundle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public bool IsItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x26395E0", Offset = "0x2637FE0", VA = "0x1826395E0")]
			get
			{
				return contentTypeCase_ == ContentTypeOneofCase.Item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x26395F0", Offset = "0x2637FF0", VA = "0x1826395F0")]
			get
			{
				while (true)
				{
					if (Type != null)
					{
						/*Error: Could not find block for branch target IL_0009*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public IStoreContentType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x2639710", Offset = "0x2638110", VA = "0x182639710")]
			get
			{
				ContentTypeOneofCase contentTypeOneofCase = contentTypeCase_;
				if (contentTypeOneofCase != ContentTypeOneofCase.Bundle)
				{
					if (contentTypeOneofCase != ContentTypeOneofCase.Item)
					{
						int num = 0;
					}
					while (contentTypeCase_ != ContentTypeOneofCase.Item)
					{
					}
					object obj = contentType_;
					while (obj == null)
					{
					}
					if (obj == null)
					{
						throw new InvalidCastException();
					}
				}
				while (contentTypeCase_ != ContentTypeOneofCase.Bundle)
				{
				}
				object obj2 = contentType_;
				while (obj2 == null)
				{
				}
				while (obj2 != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public Types.StoreSale ActiveSale
		{
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x2639470", Offset = "0x2637E70", VA = "0x182639470")]
			get
			{
				return Enumerable.FirstOrDefault<Types.StoreSale>((IEnumerable<>)(object)sales_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x26393F0", Offset = "0x2637DF0", VA = "0x1826393F0")]
		[DebuggerNonUserCode]
		public StoreContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x26390B0", Offset = "0x2637AB0", VA = "0x1826390B0")]
		[DebuggerNonUserCode]
		public StoreContent(StoreContent other)
		{
			//IL_0066: Expected O, but got I4
			//IL_00a5: Expected I4, but got O
			//IL_00ae: Expected I4, but got O
			bool flag = (isFeatured_ = other.isFeatured_);
			RepeatedField<Types.StoreSale> repeatedField = (sales_ = (RepeatedField<Types.StoreSale>)(object)((RepeatedField<T>)(object)other.sales_).Clone());
			ContentTypeOneofCase contentTypeOneofCase = other.contentTypeCase_;
			if (contentTypeOneofCase == ContentTypeOneofCase.Bundle)
			{
				ContentTypeOneofCase contentTypeOneofCase2 = other.contentTypeCase_;
				if (other.contentType_ == null)
				{
					throw new InvalidCastException();
				}
				StoreContentBundle storeContentBundle = new StoreContentBundle();
				int num = 0;
				storeContentBundle.id_ = (string)num;
				RepeatedField<> overrideAvailablePrices_ = default(RepeatedField<>);
				storeContentBundle.overrideAvailablePrices_ = (RepeatedField<ContentPrice>)(object)overrideAvailablePrices_;
				UnknownFieldSet unknownFields = default(UnknownFieldSet);
				storeContentBundle._unknownFields = unknownFields;
				contentType_ = storeContentBundle;
			}
			if (contentTypeOneofCase == ContentTypeOneofCase.Item)
			{
				ContentTypeOneofCase contentTypeOneofCase3 = other.contentTypeCase_;
				if (other.contentType_ == null)
				{
					throw new InvalidCastException();
				}
				StoreContentItem storeContentItem = new StoreContentItem();
				storeContentItem.item_ = (int)storeContentItem;
				storeContentItem.quantity_ = (int)storeContentItem;
				RepeatedField<> availablePrices_ = default(RepeatedField<>);
				storeContentItem.availablePrices_ = (RepeatedField<ContentPrice>)(object)availablePrices_;
				UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
				storeContentItem._unknownFields = unknownFields2;
				contentType_ = storeContentItem;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x26376E0", Offset = "0x26360E0", VA = "0x1826376E0", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreContent Clone()
		{
			return new StoreContent(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
		[DebuggerNonUserCode]
		public void ClearContentType()
		{
			//IL_0010: Expected O, but got I4
			contentType_ = (contentTypeCase_ = ContentTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2637D20", Offset = "0x2636720", VA = "0x182637D20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((StoreContent)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2637D80", Offset = "0x2636780", VA = "0x182637D80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreContent other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (contentTypeCase_ == ContentTypeOneofCase.Bundle)
				{
					object obj = contentType_;
					if (obj != null && obj == null)
					{
						goto IL_00ca;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.contentTypeCase_ == ContentTypeOneofCase.Bundle)
				{
					obj2 = other.contentType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					StoreContentItem item = Item;
					StoreContentItem item2 = other.Item;
					if (object.Equals(item, item2))
					{
						bool flag = other.isFeatured_;
						if (isFeatured_ == flag)
						{
							RepeatedField<Types.StoreSale> repeatedField = sales_;
							RepeatedField<Types.StoreSale> repeatedField2 = other.sales_;
							if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
							{
								ContentTypeOneofCase contentTypeOneofCase = other.contentTypeCase_;
								if (contentTypeCase_ == contentTypeOneofCase)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									bool flag2 = object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00ca;
			IL_00ca:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2638130", Offset = "0x2636B30", VA = "0x182638130", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006d
			ContentTypeOneofCase contentTypeOneofCase = contentTypeCase_;
			int num = 0;
			if (contentTypeOneofCase == ContentTypeOneofCase.Bundle)
			{
				object obj = contentType_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (contentTypeOneofCase == ContentTypeOneofCase.Item)
			{
				object obj2 = contentType_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			if (isFeatured_)
			{
			}
			int hashCode3 = ((RepeatedField<T>)(object)sales_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode3;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2638CB0", Offset = "0x26376B0", VA = "0x182638CB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2638D10", Offset = "0x2637710", VA = "0x182638D10", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0093
			//IL_002f: Expected O, but got I4
			ContentTypeOneofCase contentTypeOneofCase = contentTypeCase_;
			int num = 0;
			if (contentTypeOneofCase == ContentTypeOneofCase.Bundle)
			{
				if (contentTypeCase_ == ContentTypeOneofCase.Bundle)
				{
					object obj = contentType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (contentTypeOneofCase == ContentTypeOneofCase.Item && contentTypeCase_ == ContentTypeOneofCase.Item)
			{
				object obj2 = contentType_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (isFeatured_)
			{
				bool value = isFeatured_;
				output.WriteBool(value);
			}
			RepeatedField<Types.StoreSale> repeatedField = sales_;
			FieldCodec<Types.StoreSale> repeated_sales_codec = _repeated_sales_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_sales_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2637400", Offset = "0x2635E00", VA = "0x182637400", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			int num = 0;
			if (contentTypeCase_ == ContentTypeOneofCase.Bundle)
			{
				if (contentTypeCase_ == ContentTypeOneofCase.Bundle)
				{
					object obj = contentType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (contentTypeCase_ == ContentTypeOneofCase.Item)
			{
				if (contentTypeCase_ == ContentTypeOneofCase.Item)
				{
					object obj2 = contentType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			RepeatedField<Types.StoreSale> repeatedField = sales_;
			FieldCodec<Types.StoreSale> repeated_sales_codec = _repeated_sales_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_sales_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<Types.StoreSale>)(repeatedField + num5);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x2638880", Offset = "0x2637280", VA = "0x182638880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreContent other)
		{
			//Discarded unreachable code: IL_011c
			//IL_00e3: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			bool flag = other.isFeatured_;
			if (flag)
			{
				isFeatured_ = flag;
			}
			RepeatedField<Types.StoreSale> repeatedField = sales_;
			RepeatedField<Types.StoreSale> repeatedField2 = other.sales_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if (other.contentTypeCase_ == ContentTypeOneofCase.Bundle)
			{
				object obj = default(object);
				if (contentTypeCase_ == ContentTypeOneofCase.Bundle)
				{
					obj = contentType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					bool flag2 = (byte)(contentTypeCase_ = (((contentType_ = new StoreContentBundle()) != null) ? ContentTypeOneofCase.Bundle : ContentTypeOneofCase.None)) != 0;
				}
				if (contentTypeCase_ == ContentTypeOneofCase.Bundle)
				{
					object obj2 = contentType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.contentTypeCase_ == ContentTypeOneofCase.Bundle)
				{
					object obj3 = other.contentType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(StoreContentBundle).TypeHandle == 2)
			{
				if (Item == null)
				{
					contentTypeCase_ = (ContentTypeOneofCase)(contentType_ = new StoreContentItem());
				}
				StoreContentItem item = Item;
				StoreContentItem item2 = other.Item;
				item.MergeFrom(item2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x26385E0", Offset = "0x2636FE0", VA = "0x1826385E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00e8: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					bool flag = (isFeatured_ = input.ReadBool());
				}
				if (num != 34)
				{
					goto IL_00e8;
				}
				RepeatedField<Types.StoreSale> repeatedField = sales_;
				FieldCodec<Types.StoreSale> repeated_sales_codec = _repeated_sales_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_sales_codec);
			}
			bool flag2 = default(bool);
			if (num == 10)
			{
				StoreContentBundle storeContentBundle = new StoreContentBundle();
				if (contentTypeCase_ == ContentTypeOneofCase.Bundle)
				{
					if (contentTypeCase_ != ContentTypeOneofCase.Bundle)
					{
					}
					object obj = contentType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(storeContentBundle);
				contentType_ = storeContentBundle;
				flag2 = (byte)(contentTypeCase_ = ((storeContentBundle != null) ? ContentTypeOneofCase.Bundle : ContentTypeOneofCase.None)) != 0;
			}
			if (flag2)
			{
				StoreContentItem builder = new StoreContentItem();
				if (contentTypeCase_ == ContentTypeOneofCase.Item)
				{
					if (contentTypeCase_ != ContentTypeOneofCase.Item)
					{
					}
					object obj2 = contentType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				contentType_ = builder;
				contentTypeCase_ = (ContentTypeOneofCase)typeof(StoreContentItem).TypeHandle;
			}
			goto IL_00e8;
			IL_00e8:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x2637F00", Offset = "0x2636900", VA = "0x182637F00", Slot = "11")]
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
						if (num != 1)
						{
							goto IL_0031;
						}
						RepeatedField<Types.StoreSale> repeatedField = sales_;
					}
					bool flag = isFeatured_;
				}
				StoreContentItem item = Item;
			}
			StoreContentBundle bundle = Bundle;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x2638B00", Offset = "0x2637500", VA = "0x182638B00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001b: Expected I4, but got O
			//IL_002d: Expected O, but got I4
			//IL_0038: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0 || num != 1)
					{
						object obj = default(object);
						isFeatured_ = (byte)(int)obj != 0;
						return;
					}
					InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				}
				else
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						contentType_ = num2;
						contentTypeCase_ = (ContentTypeOneofCase)typeof(StoreContentItem).TypeHandle;
						return;
					}
				}
				throw new InvalidCastException();
			}
			if (value == null || value != null)
			{
				contentType_ = value;
				bool flag = (byte)(contentTypeCase_ = ((value != null) ? ContentTypeOneofCase.Bundle : ContentTypeOneofCase.None)) != 0;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x26375D0", Offset = "0x2635FD0", VA = "0x1826375D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0034
			//IL_002c: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				switch (num)
				{
				case 1:
				{
					RepeatedField<Types.StoreSale> repeatedField = sales_;
					break;
				}
				case 0:
					break;
				default:
					return;
				}
				isFeatured_ = false;
			}
			else
			{
				int num2 = 0;
				contentType_ = num2;
				contentTypeCase_ = (ContentTypeOneofCase)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2638480", Offset = "0x2636E80", VA = "0x182638480", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ContentType"))
			{
				ContentTypeOneofCase contentTypeOneofCase = contentTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2637670", Offset = "0x2636070", VA = "0x182637670", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ContentType"))
			{
				contentType_ = (contentTypeCase_ = ContentTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2638530", Offset = "0x2636F30", VA = "0x182638530")]
		public ContentPrice GetOriginalPrice()
		{
			//Discarded unreachable code: IL_0024
			IStoreContentType type = Type;
			ContentPrice contentPrice = default(ContentPrice);
			ContentPrice contentPrice2 = default(ContentPrice);
			if (type == null || type == null || contentPrice == null)
			{
				contentPrice2 = new ContentPrice();
				int num = (contentPrice2.currencyId_ = 0);
			}
			return contentPrice2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2638000", Offset = "0x2636A00", VA = "0x182638000")]
		public FullPriceInfo GetFullPriceInfo()
		{
			//IL_001d: Expected I4, but got I8
			int num = 0;
			IStoreContentType storeContentType = default(IStoreContentType);
			ContentPrice contentPrice = default(ContentPrice);
			ContentPrice contentPrice2 = default(ContentPrice);
			if (storeContentType == null || storeContentType == null || contentPrice == null)
			{
				contentPrice2 = new ContentPrice();
				contentPrice2.currencyId_ = 0;
			}
			Types.StoreSale storeSale = default(Types.StoreSale);
			if (storeSale != null)
			{
				int amount_ = contentPrice2.amount_;
				int num2 = storeSale.ApplyTo(amount_);
			}
			int amount_2 = contentPrice2.amount_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2637740", Offset = "0x2636140", VA = "0x182637740", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_011e, IL_0124, IL_012a, IL_0130, IL_0136, IL_013c, IL_0142, IL_0148, IL_014e, IL_0154, IL_015a, IL_0160, IL_0166, IL_016c, IL_0172, IL_0178, IL_017e, IL_0184, IL_018a, IL_0190, IL_0196, IL_019c, IL_01a2
			//IL_001b: Expected O, but got I4
			//IL_010d: Expected F4, but got I4
			//IL_010d: Expected F4, but got I4
			RepeatedField<Types.StoreSale> repeatedField = sales_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			_003C_003Ec__DisplayClass63_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass63_0();
			CS_0024_003C_003E8__locals0.sale = (Types.StoreSale)0;
			context.AddInvalidMemberError("Start Date must be set.", "StartDate");
			context.AddInvalidMemberError("End Date must be set.", "EndDate");
			if (context != null)
			{
				Stack<string> _003CStackName_003Ek__BackingField = context.StackName;
				object syncRoot = ((Stack<>)(object)_003CStackName_003Ek__BackingField)._syncRoot;
				if (CS_0024_003C_003E8__locals0 > CS_0024_003C_003E8__locals0)
				{
					object syncRoot2 = ((Stack<>)(object)_003CStackName_003Ek__BackingField)._syncRoot;
					DateTime arg = default(DateTime);
					DateTime arg2 = default(DateTime);
					string error = $"Start Date {arg} must be a date before the End Date {arg2}.";
					context.AddError(error);
				}
			}
			RepeatedField<Types.StoreSale> repeatedField2 = sales_;
			Func<Types.StoreSale, bool> func = (Func<Types.StoreSale, bool>)(object)(Func<T, TResult>)delegate(Types.StoreSale x)
			{
				//Discarded unreachable code: IL_009e
				Types.StoreSale sale = CS_0024_003C_003E8__locals0.sale;
				if (x != sale)
				{
					ConditionDate startDate_ = x.startDate_;
					if (startDate_ != null && (long)x.endDate_ != 0 && (long)sale.startDate_ != 0 && (long)sale.endDate_ != 0)
					{
						long seconds = startDate_.date_.Seconds;
						long seconds2 = CS_0024_003C_003E8__locals0.sale.startDate_.date_.Seconds;
						long seconds3 = x.startDate_.date_.Seconds;
						Types.StoreSale sale2 = CS_0024_003C_003E8__locals0.sale;
						seconds = seconds3;
						Timestamp date_ = sale2.endDate_.date_;
						long seconds4 = date_.Seconds;
						return true;
					}
				}
				int num4 = 0;
				throw new NullReferenceException();
			};
			List<Types.StoreSale> list = (List<Types.StoreSale>)(object)Enumerable.ToList<Types.StoreSale>(Enumerable.Where<Types.StoreSale>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func));
			IStoreContentType type = Type;
			if (type == null || type == null)
			{
			}
			string error2 = "Sales overlap detected for content " + "unknown" + ".";
			context.AddError(error2);
			Stack<object> _003CStack_003Ek__BackingField = context.Stack;
			if (_003CStack_003Ek__BackingField != null)
			{
				int num = default(int);
				int num2 = default(int);
				if ((long)((Stack<>)(object)_003CStack_003Ek__BackingField)._syncRoot == 1)
				{
					num = 0;
					context.RequireGreater(num2, num, "PriceDiscountValue");
				}
				while (num2 != 2)
				{
				}
				int num3 = 0;
				context.RequireGreater((float)num3, (float)num, "PriceDiscountPct");
			}
			context.AddInvalidMemberError("Type of sale must be set.", "Type");
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x26382A0", Offset = "0x2636CA0", VA = "0x1826382A0")]
		public Info GetInfo()
		{
			//Discarded unreachable code: IL_0057
			IStoreContentType type = Type;
			if (type != null && type != null)
			{
				IStoreContentType type2 = Type;
				Info info = new Info();
				info.Name = (string)(object)info;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				info.Items = (List<ItemReward>)(object)info;
				info.Prices = (List<ContentPrice>)(object)info;
				Types.StoreSale storeSale = (info.ActiveSale = Enumerable.FirstOrDefault<Types.StoreSale>((IEnumerable<>)(object)sales_));
				return info;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2638EE0", Offset = "0x26378E0", VA = "0x182638EE0")]
		static StoreContent()
		{
			Func<StoreContent> func = default(Func<StoreContent>);
			_parser = (MessageParser<StoreContent>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.StoreSale> parser = Types.StoreSale._parser;
			uint num = default(uint);
			_parser = (MessageParser<StoreContent>)(object)FieldCodec.ForMessage<Types.StoreSale>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
