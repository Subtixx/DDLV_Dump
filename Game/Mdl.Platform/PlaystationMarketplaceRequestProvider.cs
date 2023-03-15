using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online.Economy;
using Meta.Util;
using Newtonsoft.Json;
using PlayFab.Json;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002C7")]
	public class PlaystationMarketplaceRequestProvider : IMarketplaceRequestProvider
	{
		[Cpp2IlInjected.Token(Token = "0x20002C8")]
		public enum SonyPlayStationEnv
		{
			[Cpp2IlInjected.Token(Token = "0x4001576")]
			Dev = 1,
			[Cpp2IlInjected.Token(Token = "0x4001577")]
			QA = 8,
			[Cpp2IlInjected.Token(Token = "0x4001578")]
			Retail = 0x100
		}

		[Cpp2IlInjected.Token(Token = "0x20002C9")]
		public class PlayStation4MarketplaceRequestPayload
		{
			[Cpp2IlInjected.Token(Token = "0x17000170")]
			[@JsonProperty]
			[JsonPropertyAttribute]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4001579")]
			public int Environment
			{
				[Cpp2IlInjected.Token(Token = "0x6000C45")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000C46")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			} = 256;


			[Cpp2IlInjected.Token(Token = "0x17000171")]
			[JsonPropertyAttribute]
			[@JsonProperty]
			public string PSNUserId
			{
				[Cpp2IlInjected.Token(Token = "0x6000C47")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CPSNUserId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C48")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CPSNUserId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000172")]
			[JsonPropertyAttribute]
			[@JsonProperty]
			public string AuthorizationCode
			{
				[Cpp2IlInjected.Token(Token = "0x6000C49")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CAuthorizationCode_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C4A")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CAuthorizationCode_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000173")]
			[JsonPropertyAttribute]
			[@JsonProperty]
			public string OfflineAuthorizationCode
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003COfflineAuthorizationCode_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C4C")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003COfflineAuthorizationCode_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000174")]
			[JsonPropertyAttribute]
			[@JsonProperty]
			public string RedirectUri
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CRedirectUri_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C4E")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CRedirectUri_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000175")]
			[JsonPropertyAttribute]
			[@JsonProperty]
			public string OfflineRedirectUri
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4F")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				[CompilerGenerated]
				get
				{
					return _003COfflineRedirectUri_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C50")]
				[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
				[CompilerGenerated]
				set
				{
					_003COfflineRedirectUri_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000176")]
			[@JsonProperty]
			[JsonPropertyAttribute]
			[DefaultValue("0")]
			public string ServiceLabel
			{
				[Cpp2IlInjected.Token(Token = "0x6000C51")]
				[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
				[CompilerGenerated]
				get
				{
					return _003CServiceLabel_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C52")]
				[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
				[CompilerGenerated]
				set
				{
					_003CServiceLabel_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = "0";


			[Cpp2IlInjected.Token(Token = "0x6000C53")]
			[Cpp2IlInjected.Address(RVA = "0x1603B80", Offset = "0x1602580", VA = "0x181603B80")]
			public PlayStation4MarketplaceRequestPayload()
			{
			}//IL_000d: Expected I4, but got I8

		}

		[Cpp2IlInjected.Token(Token = "0x20002CA")]
		public class PlayStation5MarketplaceRequestPayload
		{
			[Cpp2IlInjected.Token(Token = "0x17000177")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4001580")]
			public int PsEnvironment
			{
				[Cpp2IlInjected.Token(Token = "0x6000C54")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000C55")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000178")]
			public string AuthenticationToken
			{
				[Cpp2IlInjected.Token(Token = "0x6000C56")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CAuthenticationToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C57")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CAuthenticationToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000179")]
			public string PsnUserId
			{
				[Cpp2IlInjected.Token(Token = "0x6000C58")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CPsnUserId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C59")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CPsnUserId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700017A")]
			public string ServiceLabel
			{
				[Cpp2IlInjected.Token(Token = "0x6000C5A")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CServiceLabel_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C5B")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CServiceLabel_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700017B")]
			public string[] Ids
			{
				[Cpp2IlInjected.Token(Token = "0x6000C5C")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CIds_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000C5D")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CIds_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C5E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public PlayStation5MarketplaceRequestPayload()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400156A")]
		private SonyPlayStationEnv env;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400156B")]
		private string authCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400156C")]
		private string userId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400156D")]
		private bool isPS5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400156E")]
		private readonly string marketplaceName;

		[Cpp2IlInjected.Token(Token = "0x400156F")]
		private const string Playstation4MarkeplaceName = "PlayStation5";

		[Cpp2IlInjected.Token(Token = "0x4001570")]
		private const string Playstation5MarkeplaceName = "PlayStation5";

		[Cpp2IlInjected.Token(Token = "0x4001571")]
		private const string PS5_SIEA_SERVICE_LABEL = "1";

		[Cpp2IlInjected.Token(Token = "0x4001572")]
		private const string PS5_SIEE_SERVICE_LABEL = "2";

		[Cpp2IlInjected.Token(Token = "0x4001573")]
		private const string PS4_SIEA_SERVICE_LABEL = "3";

		[Cpp2IlInjected.Token(Token = "0x4001574")]
		private const string PS4_SIEE_SERVICE_LABEL = "4";

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "5")]
		public string GetMarketplaceName()
		{
			return marketplaceName;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0xCB2250", Offset = "0xCB0C50", VA = "0x180CB2250")]
		public static string GetDefaultServiceLabel(RuntimePlatform platformServiceLabelToFetch)
		{
			return "1";
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0xCB24B0", Offset = "0xCB0EB0", VA = "0x180CB24B0")]
		public unsafe PlaystationMarketplaceRequestProvider(bool isPs5, string authCode, string userId, SonyPlayStationEnv env = SonyPlayStationEnv.Retail)
		{
			//Discarded unreachable code: IL_0055
			//IL_000b: Expected O, but got I4
			int num = 0;
			base.FieldGetter((string)num, authCode, ref *(object*)userId);
			isPS5 = isPs5;
			marketplaceName = "PlayStation5";
			this.authCode = authCode;
			this.userId = userId;
			this.env = (SonyPlayStationEnv)0;
			int num2 = 0;
			DebugSettings settings = DebugSettings.Settings;
			string pSNOverrideEnv_ = settings.pSNOverrideEnv_;
			if (settings == null)
			{
				int num3 = 0;
				string pSNOverrideEnv_2 = DebugSettings.Settings.pSNOverrideEnv_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0xCB2040", Offset = "0xCB0A40", VA = "0x180CB2040", Slot = "9")]
		public string GetDebugInfo()
		{
			//Discarded unreachable code: IL_0073
			//IL_0067: Expected O, but got I4
			object[] array;
			SonyPlayStationEnv sonyPlayStationEnv;
			while (true)
			{
				array = new object[4];
				string text = marketplaceName;
				if (text != null && array == null)
				{
					continue;
				}
				array[0] = text;
				string text2 = authCode;
				if (text2 != null && array == null)
				{
					continue;
				}
				array[1] = text2;
				string text3 = userId;
				if (text3 == null || array != null)
				{
					array[2] = text3;
					sonyPlayStationEnv = env;
					if (sonyPlayStationEnv == (SonyPlayStationEnv)0 || sonyPlayStationEnv != 0)
					{
						break;
					}
				}
			}
			array[3] = sonyPlayStationEnv;
			return string.Format("marketplaceName={0} authCode={1} userId={2} env={3}", array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0xCB2280", Offset = "0xCB0C80", VA = "0x180CB2280", Slot = "6")]
		[AsyncStateMachine(typeof(_003CGetMarketplacesData_003Ed__15))]
		public Task<List<RedeemData>> GetMarketplacesData()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<List<RedeemData>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0xCB23A0", Offset = "0xCB0DA0", VA = "0x180CB23A0", Slot = "7")]
		public ServiceLabelData GetServiceLabelData()
		{
			//Discarded unreachable code: IL_002c
			ServiceLabelData serviceLabelData = new ServiceLabelData();
			bool flag = (serviceLabelData.IsPS5 = isPS5);
			serviceLabelData.PS4ServiceLabel = "1";
			serviceLabelData.PS5ServiceLabel = "1";
			return serviceLabelData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0xCB1F50", Offset = "0xCB0950", VA = "0x180CB1F50", Slot = "8")]
		[AsyncStateMachine(typeof(_003CGetAuthCodeAsync_003Ed__17))]
		public Task<AuthCodeData> GetAuthCodeAsync()
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AuthCodeData>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0xCB2460", Offset = "0xCB0E60", VA = "0x180CB2460", Slot = "4")]
		public Task GrantAsync(CancellationToken ct)
		{
			int num = 0;
			return Task.CompletedTask;
		}
	}
}
