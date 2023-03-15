using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.ClientModels;
using PlayFab.CloudScriptModels;
using PlayFab.DataModels;
using PlayFab.EconomyModels;
using PlayFab.LeaderboardsModels;
using PlayFab.ProfilesModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ClientSession : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum CreateAndPublishUgcError
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			CannotCreateItem,
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			CannotPublishItem,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class PlayFabCurrencies
		{
			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public Dictionary<string, string> Currencies
			{
				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CCurrencies_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CCurrencies_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();


			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public Dictionary<string, int> CurrencyAmounts
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CCurrencyAmounts_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CCurrencyAmounts_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = (Dictionary<string, int>)(object)new Dictionary<TKey, TValue>();


			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x14EFB90", Offset = "0x14EE590", VA = "0x1814EFB90")]
			public PlayFabCurrencies()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum ValidationErrorCode
		{
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			SessionConcurrencyDetected,
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			SessionConcurrencyUnknownError,
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			SessionTokenNotFound
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class ValidationResult
		{
			[Cpp2IlInjected.Token(Token = "0x17000050")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400006A")]
			public ValidationErrorCode ErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public GameSessionInfo GameSessionInfo
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CGameSessionInfo_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CGameSessionInfo_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public DateTime? LastSessionUpdated
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0xC4B5B0", Offset = "0xC49FB0", VA = "0x180C4B5B0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x11510D0", Offset = "0x114FAD0", VA = "0x1811510D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public bool IsSuccess
			{
				[Cpp2IlInjected.Token(Token = "0x60000D8")]
				[Cpp2IlInjected.Address(RVA = "0xE606E0", Offset = "0xE5F0E0", VA = "0x180E606E0")]
				get
				{
					return ErrorCode == ValidationErrorCode.Success;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public ValidationResult WithError(ValidationErrorCode errorCode)
			{
				ErrorCode = errorCode;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ValidationResult()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly PlayFabClientInstanceAPI client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly PlayFabAuthenticationInstanceAPI auth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly PlayFabDataInstanceAPI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly PlayFabEconomyInstanceAPI economy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly PlayFabCloudScriptInstanceAPI cloudscript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly PlayFabLeaderboardsInstanceAPI leaderboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly PlayFabProfilesInstanceAPI profiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly LoginResponse LoginResponse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly HttpClientWithTimeout http;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly TitleData TitleData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private PlayFabContext playfabContext;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly TimeSpan ClientFeaturesToggleUpdateDelay;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string EntityStr
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x102A420", Offset = "0x1028E20", VA = "0x18102A420")]
			get
			{
				//Discarded unreachable code: IL_0039
				string _003CType_003Ek__BackingField = loginResult.EntityToken.Entity.Type;
				string _003CId_003Ek__BackingField = loginResult.EntityToken.Entity.Id;
				return _003CType_003Ek__BackingField + "!" + _003CId_003Ek__BackingField;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Entity.Types EntityTypeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x102A580", Offset = "0x1028F80", VA = "0x18102A580")]
			get
			{
				string _003CType_003Ek__BackingField = loginResult.EntityToken.Entity.Type;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public PlayFab.DataModels.EntityKey DataEntity
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x102A200", Offset = "0x1028C00", VA = "0x18102A200")]
			get
			{
				//Discarded unreachable code: IL_0026
				PlayFabContext playFabContext = playfabContext;
				string _003CId_003Ek__BackingField = loginResult.EntityToken.Entity.Id;
				Entity.Types entityTypeEnum = EntityTypeEnum;
				PlayFab.DataModels.EntityKey result = default(PlayFab.DataModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public PlayFab.LeaderboardsModels.EntityKey LeaderboardsEntity
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x102A780", Offset = "0x1029180", VA = "0x18102A780")]
			get
			{
				//Discarded unreachable code: IL_0026
				PlayFabContext playFabContext = playfabContext;
				string _003CId_003Ek__BackingField = loginResult.EntityToken.Entity.Id;
				Entity.Types entityTypeEnum = EntityTypeEnum;
				PlayFab.LeaderboardsModels.EntityKey result = default(PlayFab.LeaderboardsModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public PlayFab.CloudScriptModels.EntityKey CloudScriptEntity
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x102A160", Offset = "0x1028B60", VA = "0x18102A160")]
			get
			{
				//Discarded unreachable code: IL_0026
				PlayFabContext playFabContext = playfabContext;
				string _003CId_003Ek__BackingField = loginResult.EntityToken.Entity.Id;
				Entity.Types entityTypeEnum = EntityTypeEnum;
				PlayFab.CloudScriptModels.EntityKey result = default(PlayFab.CloudScriptModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public PlayFab.EconomyModels.EntityKey EconomyEntity
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x102A320", Offset = "0x1028D20", VA = "0x18102A320")]
			get
			{
				//Discarded unreachable code: IL_0026
				PlayFabContext playFabContext = playfabContext;
				string _003CId_003Ek__BackingField = loginResult.EntityToken.Entity.Id;
				Entity.Types entityTypeEnum = EntityTypeEnum;
				PlayFab.EconomyModels.EntityKey result = default(PlayFab.EconomyModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public PlayFab.ProfilesModels.EntityKey ProfilesEntity
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x102A870", Offset = "0x1029270", VA = "0x18102A870")]
			get
			{
				//Discarded unreachable code: IL_0026
				PlayFabContext playFabContext = playfabContext;
				string _003CId_003Ek__BackingField = loginResult.EntityToken.Entity.Id;
				Entity.Types entityTypeEnum = EntityTypeEnum;
				PlayFab.ProfilesModels.EntityKey result = default(PlayFab.ProfilesModels.EntityKey);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public LoginResult loginResult
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CloginResult_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CloginResult_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public TitleConfig TitleConfig
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x102A910", Offset = "0x1029310", VA = "0x18102A910")]
			get
			{
				//Discarded unreachable code: IL_000c
				return TitleData.TitleConfig;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public PlayFabContext PlayfabContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return playfabContext;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DisneyPlayFabContext DisneyPlayfabContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x102A2A0", Offset = "0x1028CA0", VA = "0x18102A2A0")]
			get
			{
				if (playfabContext == null)
				{
					int num = 0;
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string PlayFabId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x102A820", Offset = "0x1029220", VA = "0x18102A820")]
			get
			{
				//Discarded unreachable code: IL_000c
				return loginResult.PlayFabId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string EntityToken
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x102A550", Offset = "0x1028F50", VA = "0x18102A550")]
			get
			{
				//Discarded unreachable code: IL_0011
				return loginResult.EntityToken.EntityToken;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string EntityId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x102A3C0", Offset = "0x1028DC0", VA = "0x18102A3C0")]
			get
			{
				//Discarded unreachable code: IL_0016
				return loginResult.EntityToken.Entity.Id;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string EntityType
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x102A650", Offset = "0x1029050", VA = "0x18102A650")]
			get
			{
				//Discarded unreachable code: IL_0016
				return loginResult.EntityToken.Entity.Type;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public DateTime? EntityTokenExpiration
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x102A520", Offset = "0x1028F20", VA = "0x18102A520")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool HasEntityTokenExpired
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x102A6B0", Offset = "0x10290B0", VA = "0x18102A6B0")]
			get
			{
				//Discarded unreachable code: IL_001b
				DateTime? tokenExpiration = loginResult.EntityToken.TokenExpiration;
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public PlayFabAuthenticationContext AuthContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x102A140", Offset = "0x1028B40", VA = "0x18102A140")]
			get
			{
				//Discarded unreachable code: IL_000c
				return loginResult.AuthenticationContext;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public EntityProfileBody EntityProfile
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CEntityProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			private set
			{
				_003CEntityProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public PlayFab.ClientModels.PlayerProfileModel PlayerProfileModel
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003CPlayerProfileModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			private set
			{
				_003CPlayerProfileModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public UserAccountInfo UserAccountInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			[CompilerGenerated]
			get
			{
				return _003CUserAccountInfo_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			[CompilerGenerated]
			private set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x88"), Cpp2IlInjected.Token(Token = "0x4000059")]
		public bool IsTesterEnv
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xBD6330", Offset = "0xBD4D30", VA = "0x180BD6330")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x102A930", Offset = "0x1029330", VA = "0x18102A930")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string GameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			[CompilerGenerated]
			get
			{
				return _003CGameVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAE8630", Offset = "0xAE7030", VA = "0x180AE8630")]
			[CompilerGenerated]
			set
			{
				_003CGameVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x98"), Cpp2IlInjected.Token(Token = "0x400005B")]
		public int? EnvIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD2D650", Offset = "0xD2C050", VA = "0x180D2D650")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TitleDataConfigHolder<ClientFeaturesToggleConfig> ClientFeaturesToggles
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			[CompilerGenerated]
			get
			{
				return _003CClientFeaturesToggles_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			[CompilerGenerated]
			private set
			{
				_003CClientFeaturesToggles_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1027B60", Offset = "0x1026560", VA = "0x181027B60")]
		public string BuildImageName(string name, uint version)
		{
			return string.Format("{0}_{1}_Image.jpg", name, "{0}_{1}_Image.jpg");
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1027D80", Offset = "0x1026780", VA = "0x181027D80")]
		public string BuildThumbName(string name, uint version)
		{
			return string.Format("{0}_{1}_Thumb.jpg", name, "{0}_{1}_Thumb.jpg");
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1027BD0", Offset = "0x10265D0", VA = "0x181027BD0")]
		public List<Image> BuildImages(string imageId, string imageUrl, string thumbId, string thumbUrl)
		{
			//Discarded unreachable code: IL_005c
			//IL_0048: Expected O, but got I4
			List<Image> list = (List<Image>)(object)new List<T>();
			Image image = new Image();
			image.Id = imageId;
			image.Url = imageUrl;
			image.Type = "Screenshot";
			((List<T>)(object)list).Add((T)image);
			if (image == null && image == null)
			{
				Image image2 = new Image();
				image2.Id = thumbId;
				image2.Url = (string)0;
				image2.Type = "Thumbnail";
				((List<T>)(object)list).Add((T)image2);
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1027A80", Offset = "0x1026480", VA = "0x181027A80")]
		public string BuildEntityStr(string entityType, string entityId)
		{
			return entityType + "!" + entityId;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1027AD0", Offset = "0x10264D0", VA = "0x181027AD0")]
		public string BuildEntityStr(Entity.Types entityType, string entityId)
		{
			string text = default(string);
			return text + "!" + entityId;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1028520", Offset = "0x1026F20", VA = "0x181028520")]
		[AsyncStateMachine(typeof(_003CGetProfileAsync_003Ed__20))]
		public Task<EntityProfileBody> GetProfileAsync(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<EntityProfileBody>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1028DC0", Offset = "0x10277C0", VA = "0x181028DC0")]
		[AsyncStateMachine(typeof(_003CGetVirtualCurrenciesAsync_003Ed__21))]
		public Task<PlayFabResult<GetVirtualCurrenciesResult>> GetVirtualCurrenciesAsync(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<GetVirtualCurrenciesResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1028190", Offset = "0x1026B90", VA = "0x181028190")]
		[AsyncStateMachine(typeof(_003CGetCurrenciesAsync_003Ed__23))]
		public Task<PlayFabCurrencies> GetCurrenciesAsync(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabCurrencies>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x10282E0", Offset = "0x1026CE0", VA = "0x1810282E0")]
		[AsyncStateMachine(typeof(_003CGetCurrencyAmountAsync_003Ed__24))]
		public Task<Dictionary<string, int>> GetCurrencyAmountAsync(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Dictionary<string, int>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1028940", Offset = "0x1027340", VA = "0x181028940")]
		[AsyncStateMachine(typeof(_003CGetStatisticsAsync_003Ed__25))]
		public Task<IReadOnlyDictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>> GetStatisticsAsync(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IReadOnlyDictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1028A80", Offset = "0x1027480", VA = "0x181028A80")]
		public Task<Dictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>> GetStatisticsAsync(EntityProfileBody profile, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0018
			while (profile != null && profile.Statistics != null)
			{
			}
			return (Task<Dictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>>)(object)Task.FromResult((Dictionary<string, PlayFab.ProfilesModels.EntityStatisticValue>)(object)new Dictionary<TKey, TValue>());
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1028660", Offset = "0x1027060", VA = "0x181028660")]
		[AsyncStateMachine(typeof(_003CGetStatisticAsync_003Ed__27))]
		public Task<PlayFab.ProfilesModels.EntityStatisticValue> GetStatisticAsync(string name, [Optional] int? version, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFab.ProfilesModels.EntityStatisticValue>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x10287D0", Offset = "0x10271D0", VA = "0x1810287D0")]
		[AsyncStateMachine(typeof(_003CGetStatisticValue_003Ed__28))]
		public Task<int> GetStatisticValue(string name, int value, [Optional] int? version, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<int>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x10291A0", Offset = "0x1027BA0", VA = "0x1810291A0")]
		[AsyncStateMachine(typeof(_003CPrepareUploadUrlAsync_003Ed__29))]
		public Task<PrepareUploadUrl.Result> PrepareUploadUrlAsync(PrepareUploadUrl.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PrepareUploadUrl.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1027F30", Offset = "0x1026930", VA = "0x181027F30")]
		[AsyncStateMachine(typeof(_003CCreateAndPublishUgcItem_003Ed__30))]
		public Task<(PlayFabError, PlayFab.EconomyModels.CatalogItem)> CreateAndPublishUgcItem(PlayFab.EconomyModels.CatalogItem item, PlayFab.EconomyModels.EntityKey entity)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(PlayFabError, PlayFab.EconomyModels.CatalogItem)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1027940", Offset = "0x1026340", VA = "0x181027940")]
		[AsyncStateMachine(typeof(_003CAddCurrencies_003Ed__31))]
		public Task<AddVirtualCurrenciesResult> AddCurrencies(List<(string, int)> currencies)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AddVirtualCurrenciesResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1029750", Offset = "0x1028150", VA = "0x181029750")]
		[AsyncStateMachine(typeof(_003CSubtractCurrencies_003Ed__32))]
		public Task<PlayFabResult<SubtractVirtualCurrenciesResult>> SubtractCurrencies(List<(string, int)> currencies)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<SubtractVirtualCurrenciesResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1028EE0", Offset = "0x10278E0", VA = "0x181028EE0")]
		[AsyncStateMachine(typeof(_003CGrantInventoryItems_003Ed__33))]
		public Task<PlayFabResult<GrantInventoryItemsResult>> GrantInventoryItems(List<(string, int)> items)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<GrantInventoryItemsResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1027DF0", Offset = "0x10267F0", VA = "0x181027DF0")]
		[AsyncStateMachine(typeof(_003CConsumeInventoryItems_003Ed__34))]
		public Task<PlayFabResult<ConsumeInventoryItemsResult>> ConsumeInventoryItems(List<(string, int)> items)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<ConsumeInventoryItemsResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1029890", Offset = "0x1028290", VA = "0x181029890")]
		public List<CurrencyDetails> ToCurrencyDetails(List<(string, int)> currencies)
		{
			PlayFabContext playFabContext = playfabContext;
			if (playFabContext != null)
			{
				return (List<CurrencyDetails>)(object)playFabContext.ToCurrencyDetails((List<>)(object)currencies);
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1029CD0", Offset = "0x10286D0", VA = "0x181029CD0")]
		private ClientSession(HttpClientWithTimeout httpClient, PlayFabClientInstanceAPI client, LoginResponse loginResponse, LoginResult loginResult, TitleData titleData)
		{
			//IL_001b: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			Dispose();
			this.client = client;
			LoginResponse = loginResponse;
			this.loginResult = (LoginResult)0;
			TitleData = (TitleData)0;
			int num = default(int);
			PlayFabContext playFabContext = new PlayFabContext(this, (ILogger)num);
			num = 0;
			playfabContext = playFabContext;
			PlayFabAuthenticationInstanceAPI playFabAuthenticationInstanceAPI = default(PlayFabAuthenticationInstanceAPI);
			auth = playFabAuthenticationInstanceAPI;
			PlayFabDataInstanceAPI playFabDataInstanceAPI = default(PlayFabDataInstanceAPI);
			data = playFabDataInstanceAPI;
			PlayFabEconomyInstanceAPI playFabEconomyInstanceAPI = default(PlayFabEconomyInstanceAPI);
			economy = playFabEconomyInstanceAPI;
			PlayFabCloudScriptInstanceAPI playFabCloudScriptInstanceAPI = default(PlayFabCloudScriptInstanceAPI);
			cloudscript = playFabCloudScriptInstanceAPI;
			PlayFabLeaderboardsInstanceAPI playFabLeaderboardsInstanceAPI = default(PlayFabLeaderboardsInstanceAPI);
			leaderboards = playFabLeaderboardsInstanceAPI;
			PlayFabProfilesInstanceAPI playFabProfilesInstanceAPI = default(PlayFabProfilesInstanceAPI);
			profiles = playFabProfilesInstanceAPI;
			PlayerProfileModel = (PlayFab.ClientModels.PlayerProfileModel)(object)playFabProfilesInstanceAPI;
			PlayFabApiSettings playFabApiSettings = (PlayFabApiSettings)(object)(UserAccountInfo = (UserAccountInfo)(object)playFabProfilesInstanceAPI.apiSettings);
			bool flag = default(bool);
			if (playFabContext.events == null || flag)
			{
			}
			int num2 = 0;
			http = httpClient;
			IsTesterEnv = (byte)num2 != 0;
			ClientFeaturesToggleConfig clientFeaturesToggleConfig = new ClientFeaturesToggleConfig();
			string text = (clientFeaturesToggleConfig.ProfileBackupPersistenceConfigKey = ClientFeaturesToggleConfig.DefaultProfileBackupConfigTitleDataKey);
			TitleDataOnlineSyncWithTimeDelay titleDataOnlineSyncWithTimeDelay = new TitleDataOnlineSyncWithTimeDelay();
			TimeSpan timeSpan = (titleDataOnlineSyncWithTimeDelay.SyncTimeDelay = ClientFeaturesToggleUpdateDelay);
			TitleDataConfigHolder<ClientFeaturesToggleConfig> titleDataConfigHolder = (ClientFeaturesToggles = (TitleDataConfigHolder<ClientFeaturesToggleConfig>)(object)new TitleDataConfigHolder<TitleDataType>((TitleDataType)clientFeaturesToggleConfig, titleDataOnlineSyncWithTimeDelay));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public void Dispose()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
		public void SetPlayFabContext(PlayFabContext playFabContext)
		{
			playfabContext = playFabContext;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x10292E0", Offset = "0x1027CE0", VA = "0x1810292E0")]
		[AsyncStateMachine(typeof(_003CRefreshEntityProfile_003Ed__105))]
		private Task RefreshEntityProfile(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1028070", Offset = "0x1026A70", VA = "0x181028070")]
		[AsyncStateMachine(typeof(_003CForceRefeshClientFeaturesToggle_003Ed__106))]
		private Task ForceRefeshClientFeaturesToggle(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1029500", Offset = "0x1027F00", VA = "0x181029500")]
		[AsyncStateMachine(typeof(_003CRefreshSession_003Ed__107))]
		public Task RefreshSession(LoginResult loginResult, [Optional] CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1028420", Offset = "0x1026E20", VA = "0x181028420")]
		public string GetPortalUrl()
		{
			//Discarded unreachable code: IL_0065
			if ((object)EnvIndex != null)
			{
				int envIndex = default(int);
				PortalDefinition portalByEnvironment = TitleData.TitleConfig.GetPortalByEnvironment(envIndex);
				if (portalByEnvironment != null)
				{
					bool flag = string.IsNullOrEmpty(portalByEnvironment.UserUrl);
					if (!flag)
					{
						if (IsTesterEnv != flag && !string.IsNullOrEmpty(portalByEnvironment.TesterUrl))
						{
							return portalByEnvironment.TesterUrl;
						}
						return portalByEnvironment.UserUrl;
					}
				}
			}
			return TitleData.TitleConfig.PortalUrl;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1028B40", Offset = "0x1027540", VA = "0x181028B40")]
		[AsyncStateMachine(typeof(_003CGetTitleDataAsync_003Ed__109))]
		private static Task<TitleData> GetTitleDataAsync(PlayFabClientInstanceAPI client, [Optional] CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<TitleData>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x10293E0", Offset = "0x1027DE0", VA = "0x1810293E0")]
		[AsyncStateMachine(typeof(_003CRefreshPlayerProfileModel_003Ed__110))]
		public Task<PlayFab.ClientModels.PlayerProfileModel> RefreshPlayerProfileModel(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFab.ClientModels.PlayerProfileModel>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1029630", Offset = "0x1028030", VA = "0x181029630")]
		[AsyncStateMachine(typeof(_003CRefreshUserAccountInfo_003Ed__111))]
		public Task<UserAccountInfo> RefreshUserAccountInfo(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<UserAccountInfo>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1028C60", Offset = "0x1027660", VA = "0x181028C60")]
		private static TitleData GetTitleData(GetPlayerCombinedInfoResultPayload payload)
		{
			//Discarded unreachable code: IL_002b
			TitleData titleData = new TitleData();
			bool flag = default(bool);
			if (payload != null && payload.TitleData != null && flag)
			{
				TitleConfig _003CTitleConfig_003Ek__BackingField = default(TitleConfig);
				titleData.TitleConfig = _003CTitleConfig_003Ek__BackingField;
			}
			if ((long)titleData.TitleConfig != 0)
			{
				return titleData;
			}
			Exception ex = new Exception("cannot retrieve TitleConfig");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1029020", Offset = "0x1027A20", VA = "0x181029020")]
		[AsyncStateMachine(typeof(_003CInitWithLoginResult_003Ed__113))]
		public static Task<LoginResponse> InitWithLoginResult(HttpClientWithTimeout httpClient, PlayFabClientInstanceAPI client, PlayFabResult<LoginResult> loginResult, bool refresh, [Optional] CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<LoginResponse>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x10277A0", Offset = "0x10261A0", VA = "0x1810277A0")]
		public static GetPlayerCombinedInfoRequestParams AddClientSessionIRP(GetPlayerCombinedInfoRequestParams userIRP)
		{
			//Discarded unreachable code: IL_0068
			if (userIRP == null)
			{
				GetPlayerCombinedInfoRequestParams getPlayerCombinedInfoRequestParams = new GetPlayerCombinedInfoRequestParams();
			}
			GetPlayerCombinedInfoRequestParams irp = userIRP;
			GetPlayerCombinedInfoRequestParams getPlayerCombinedInfoRequestParams2 = irp;
			if ((long)getPlayerCombinedInfoRequestParams2.TitleDataKeys == 0 || !getPlayerCombinedInfoRequestParams2.GetTitleData)
			{
				List<string> list = (getPlayerCombinedInfoRequestParams2.TitleDataKeys = (List<string>)(object)new List<T>());
			}
			((Action<T>)delegate(string filename)
			{
				//Discarded unreachable code: IL_0026
				if (!((List<T>)(object)irp.TitleDataKeys).Contains((T)filename))
				{
					((List<T>)(object)irp.TitleDataKeys).Add((T)filename);
				}
			})((T)"TitleConfig");
			irp.GetTitleData = true;
			return irp;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1029B20", Offset = "0x1028520", VA = "0x181029B20")]
		[AsyncStateMachine(typeof(_003CValidate_003Ed__115))]
		public Task<ValidationResult> Validate()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<ValidationResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1029C60", Offset = "0x1028660", VA = "0x181029C60")]
		static ClientSession()
		{
			TimeSpan clientFeaturesToggleUpdateDelay = default(TimeSpan);
			ClientFeaturesToggleUpdateDelay = clientFeaturesToggleUpdateDelay;
		}
	}
}
