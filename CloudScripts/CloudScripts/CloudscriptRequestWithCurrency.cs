using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using glPlayFab;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public abstract class CloudscriptRequestWithCurrency
	{
		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public string CurrencyOnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CCurrencyOnlineId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CCurrencyOnlineId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public string CurrencyOnlineType
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCurrencyOnlineType_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCurrencyOnlineType_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1165EA0", Offset = "0x11648A0", VA = "0x181165EA0")]
		public Task<(string, string)> GetOrSearchCurrencyByFriendlyName(DisneyPlayFabContext context, string friendlyName)
		{
			//Discarded unreachable code: IL_0021
			//IL_0017: Expected O, but got I4
			PlayFabEconomyInstanceAPI economy = context.economy;
			int num = 0;
			int num2 = 0;
			string text = economy.ItemFilterBy(SearchField.alternateIds_any, friendlyName, (string)num2, (SearchOperator)num, (SearchExtraFlags)num);
			return (Task<(string, string)>)(object)this.GetOrSearchCurrency(context, text);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1165F50", Offset = "0x1164950", VA = "0x181165F50")]
		public Task<(string, string)> GetOrSearchCurrencyByGameId(DisneyPlayFabContext context, int currencyGameId)
		{
			string text = SearchField.displayProperties_ID.ToQuery();
			string text2 = $"{text} eq {text}";
			return (Task<(string, string)>)(object)this.GetOrSearchCurrency(context, text2);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1166020", Offset = "0x1164A20", VA = "0x181166020")]
		[AsyncStateMachine(typeof(_003CGetOrSearchCurrency_003Ed__10))]
		private Task<(string, string)> GetOrSearchCurrency(DisneyPlayFabContext context, string currencyFilter)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(string, string)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected CloudscriptRequestWithCurrency()
		{
		}
	}
}
