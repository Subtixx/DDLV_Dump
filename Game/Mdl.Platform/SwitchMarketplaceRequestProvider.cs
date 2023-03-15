using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using Meta.Online.Economy;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PlayFab.Json;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002D7")]
	public class SwitchMarketplaceRequestProvider : IMarketplaceRequestProvider
	{
		[Cpp2IlInjected.Token(Token = "0x20002D8")]
		public class NintendoPayload
		{
			[Cpp2IlInjected.Token(Token = "0x20002D9")]
			public enum TargetNintendoEndpoint
			{
				[Cpp2IlInjected.Token(Token = "0x40015A6")]
				Unknown,
				[Cpp2IlInjected.Token(Token = "0x40015A7")]
				All,
				[Cpp2IlInjected.Token(Token = "0x40015A8")]
				Consumables,
				[Cpp2IlInjected.Token(Token = "0x40015A9")]
				Subscriptions
			}

			[Cpp2IlInjected.Token(Token = "0x17000184")]
			[JsonPropertyAttribute]
			[@JsonProperty]
			public string NintendoToken
			{
				[Cpp2IlInjected.Token(Token = "0x6000C97")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CNintendoToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C98")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CNintendoToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000185")]
			[@JsonProperty]
			[JsonPropertyAttribute]
			public string NsaId
			{
				[Cpp2IlInjected.Token(Token = "0x6000C99")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CNsaId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C9A")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CNsaId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000186")]
			[@JsonProperty]
			[JsonPropertyAttribute]
			public List<string> CourseIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000C9B")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CCourseIds_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C9C")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CCourseIds_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			[@JsonProperty]
			[JsonPropertyAttribute]
			[JsonConverter(typeof(StringEnumConverter))]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40015A4")]
			public TargetNintendoEndpoint TargetEndpoint
			{
				[Cpp2IlInjected.Token(Token = "0x6000C9D")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000C9E")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			} = TargetNintendoEndpoint.Consumables;


			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x1219670", Offset = "0x1218070", VA = "0x181219670")]
			public NintendoPayload()
			{
			}//IL_0009: Expected I4, but got I8

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015A0")]
		private AuthManager.PlatformTokenProviderWithCache PlatformTokenProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x1068260", Offset = "0x1066C60", VA = "0x181068260", Slot = "5")]
		public string GetMarketplaceName()
		{
			return "Nintendo";
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public SwitchMarketplaceRequestProvider(AuthManager.PlatformTokenProviderWithCache platformProvider)
		{
			PlatformTokenProvider = platformProvider;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x1068290", Offset = "0x1066C90", VA = "0x181068290", Slot = "6")]
		[AsyncStateMachine(typeof(_003CGetMarketplacesData_003Ed__3))]
		public Task<List<RedeemData>> GetMarketplacesData()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<List<RedeemData>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x1068400", Offset = "0x1066E00", VA = "0x181068400")]
		[AsyncStateMachine(typeof(_003CRefreshNativeToken_003Ed__4))]
		private Task RefreshNativeToken()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public ServiceLabelData GetServiceLabelData()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x1068110", Offset = "0x1066B10", VA = "0x181068110", Slot = "8")]
		[AsyncStateMachine(typeof(_003CGetAuthCodeAsync_003Ed__6))]
		public Task<AuthCodeData> GetAuthCodeAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AuthCodeData>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x1068230", Offset = "0x1066C30", VA = "0x181068230", Slot = "9")]
		public string GetDebugInfo()
		{
			return "none";
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x10683B0", Offset = "0x1066DB0", VA = "0x1810683B0", Slot = "4")]
		public Task GrantAsync(CancellationToken ct)
		{
			int num = 0;
			return Task.CompletedTask;
		}
	}
}
