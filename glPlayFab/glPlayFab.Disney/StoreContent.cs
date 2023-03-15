using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	public class StoreContent
	{
		[Cpp2IlInjected.Token(Token = "0x2000180")]
		public enum ContentType
		{
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			Bundle,
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			Item
		}

		[Cpp2IlInjected.Token(Token = "0x2000181")]
		public enum SaleType
		{
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			PriceDiscountValue,
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			PriceDiscountPct
		}

		[Cpp2IlInjected.Token(Token = "0x2000182")]
		public class SaleData
		{
			[Cpp2IlInjected.Token(Token = "0x170001CD")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40005FA")]
			public SaleType Type
			{
				[Cpp2IlInjected.Token(Token = "0x6000758")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000759")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170001CE")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40005FB")]
			public DateTime StartDate
			{
				[Cpp2IlInjected.Token(Token = "0x600075A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600075B")]
				[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170001CF")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40005FC")]
			public DateTime EndDate
			{
				[Cpp2IlInjected.Token(Token = "0x600075C")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600075D")]
				[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170001D0")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40005FD")]
			public int Data
			{
				[Cpp2IlInjected.Token(Token = "0x600075E")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600075F")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x1AEB8E0", Offset = "0x1AEA2E0", VA = "0x181AEB8E0")]
			public int ApplyTo(int originalAmount)
			{
				SaleType saleType = Type;
				if (saleType != SaleType.PriceDiscountPct && saleType == SaleType.PriceDiscountValue)
				{
					return originalAmount;
				}
				return originalAmount;
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x1AEB920", Offset = "0x1AEA320", VA = "0x181AEB920")]
			public bool IsActive(DateTime cmpTime)
			{
				DateTime dateTime = StartDate;
				bool flag = cmpTime >= dateTime;
				if (!flag)
				{
					return flag;
				}
				DateTime dateTime2 = EndDate;
				return cmpTime < dateTime2;
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SaleData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40005EB")]
		public ContentType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40005ED")]
		public int Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public List<Price> AvailablePrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CAvailablePrices_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CAvailablePrices_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40005EF")]
		public bool ArePricesOverriden
		{
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x31"), Cpp2IlInjected.Token(Token = "0x40005F0")]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x997D90", Offset = "0x996790", VA = "0x180997D90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x997DC0", Offset = "0x9967C0", VA = "0x180997DC0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public List<SaleData> Sales
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CSales_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CSales_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public DateTime? StartDateServerOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x116CEA0", Offset = "0x116B8A0", VA = "0x18116CEA0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x116CFE0", Offset = "0x116B9E0", VA = "0x18116CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public DateTime? EndDateServerOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x1024680", Offset = "0x1023080", VA = "0x181024680")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x1024800", Offset = "0x1023200", VA = "0x181024800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x14F6AC0", Offset = "0x14F54C0", VA = "0x1814F6AC0")]
		public bool IsActive(DateTime cmpTime)
		{
			if ((object)typeof(DateTime).TypeHandle != null && (object)typeof(DateTime).TypeHandle != null)
			{
				DateTime? dateTime = StartDateServerOnly;
				bool flag = default(bool);
				if ((object)typeof(DateTime).TypeHandle != null && flag)
				{
					DateTime? dateTime2 = EndDateServerOnly;
					bool result = default(bool);
					if (flag)
					{
						return result;
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public StoreContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x14F6BE0", Offset = "0x14F55E0", VA = "0x1814F6BE0")]
		public StoreContent(StoreContent other)
		{
			//Discarded unreachable code: IL_00fe
			//IL_0077: Expected O, but got I4
			ContentType contentType = (Type = other.Type);
			string text = (Id = other.Id);
			int num = other.Quantity;
			int num2 = 0;
			Quantity = num;
			List<Price> list = other.AvailablePrices;
			if (list != null)
			{
				Func<Price, Price> _003C_003E9__41_ = _003C_003Ec._003C_003E9__41_0;
				if (_003C_003E9__41_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Price x)
					{
						//Discarded unreachable code: IL_0024
						Price price = new Price();
						int num4 = (price.Amount = x.Amount);
						int num5 = (price.CurrencyItemId = x.CurrencyItemId);
						return price;
					};
				}
				List<Price> list2 = (List<Price>)(object)Enumerable.ToList<Price>(Enumerable.Select<Price, Price>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__41_));
			}
			AvailablePrices = (List<Price>)num2;
			bool flag = (ArePricesOverriden = other.ArePricesOverriden);
			bool flag2 = (IsFeatured = other.IsFeatured);
			List<SaleData> list3 = other.Sales;
			List<SaleData> list4 = default(List<SaleData>);
			if (list3 != null)
			{
				Func<SaleData, SaleData> func = default(Func<SaleData, SaleData>);
				if (_003C_003Ec._003C_003E9__41_1 == null)
				{
					func = (Func<SaleData, SaleData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(SaleData x)
					{
						//Discarded unreachable code: IL_0042
						SaleData saleData = new SaleData();
						SaleType saleType = (saleData.Type = x.Type);
						DateTime dateTime3 = (saleData.StartDate = x.StartDate);
						DateTime dateTime4 = (saleData.EndDate = x.EndDate);
						int num3 = (saleData.Data = x.Data);
						return saleData;
					});
				}
				list4 = (List<SaleData>)(object)Enumerable.ToList<SaleData>(Enumerable.Select<SaleData, SaleData>((IEnumerable<>)list3, (Func<, >)(object)func));
			}
			Sales = list4;
			DateTime? dateTime = (StartDateServerOnly = other.StartDateServerOnly);
			DateTime? dateTime2 = (EndDateServerOnly = other.EndDateServerOnly);
		}
	}
}
