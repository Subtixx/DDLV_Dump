using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using glPlayFab;
using glPlayFab.Disney;
using Newtonsoft.Json;
using PlayFab;
using PlayFab.CloudScriptModels;
using PlayFab.EconomyModels;
using PlayFab.ProfilesModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DisneyCloudScript : ICloudScriptExecutor
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class DeleteAllInventoryItemsResult
		{
			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public List<(string id, string instanceId)> DeletedItems
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CDeletedItems_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CDeletedItems_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEE6C80", Offset = "0xEE5680", VA = "0x180EE6C80")]
			public DeleteAllInventoryItemsResult WithResult(PlayFabError error)
			{
				PlayFabError = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public DeleteAllInventoryItemsResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class AddOnlineCurrencyResult
		{
			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400006A")]
			public int NewAmount
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xEE6C80", Offset = "0xEE5680", VA = "0x180EE6C80")]
			public AddOnlineCurrencyResult WithResult(PlayFabError error)
			{
				PlayFabError = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public AddOnlineCurrencyResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class FoundersPackConfig
		{
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public class AwardedFounderPackTitleData
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				public class StoreAwardedData
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000072")]
					public string PackPrettyName;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x4000073")]
					public string PackInstanceId;

					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public StoreAwardedData()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400006F")]
				public static readonly int CURRENT_DATA_VERSION;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public int DataVersion;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000071")]
				public Dictionary<string, StoreAwardedData> AwarwedPacksPerStore;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x392E140", Offset = "0x392CB40", VA = "0x18392E140")]
				public void AddStoreAwardedData(string storeName, StoreAwardedData data)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x392E1B0", Offset = "0x392CBB0", VA = "0x18392E1B0")]
				public bool TryGetStoreAwardedData(string storeFrontName, out StoreAwardedData storeAwardedData)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0x392E260", Offset = "0x392CC60", VA = "0x18392E260")]
				public AwardedFounderPackTitleData()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private static readonly string BasePackInventoryKey_IAPPackName = "FoundersPackBaseGame";

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private static readonly string FoundersPackDeluxeGame_IAPPackName;

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string FoundersPackUltimateGame_IAPPackName;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly string AwardedFounderPackGlobalKey;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x392E900", Offset = "0x392D300", VA = "0x18392E900")]
			public static string GetAutoRewardPack(string storeFrontUniqueName)
			{
				return StoreFrontKey(BasePackInventoryKey_IAPPackName, storeFrontUniqueName);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x392EAB0", Offset = "0x392D4B0", VA = "0x18392EAB0")]
			public static string StoreFrontKey(string iapPackName, string storeFrontUniqueName)
			{
				if ("_OnlineKey" != null)
				{
					return iapPackName + "_OnlineKey";
				}
				return iapPackName + "_" + storeFrontUniqueName + "_OnlineKey";
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x392E970", Offset = "0x392D370", VA = "0x18392E970")]
			public static List<string> GetStoreFrontAllFoundersPacks(string storeFrontUniqueName)
			{
				//Discarded unreachable code: IL_0041
				List<string> list = (List<string>)(object)new List<T>();
				string item = StoreFrontKey(BasePackInventoryKey_IAPPackName, storeFrontUniqueName);
				((List<T>)(object)list).Add((T)item);
				string item2 = StoreFrontKey(FoundersPackDeluxeGame_IAPPackName, storeFrontUniqueName);
				((List<T>)(object)list).Add((T)item2);
				string item3 = StoreFrontKey(FoundersPackUltimateGame_IAPPackName, storeFrontUniqueName);
				((List<T>)(object)list).Add((T)item3);
				return list;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public FoundersPackConfig()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x392EB40", Offset = "0x392D540", VA = "0x18392EB40")]
			static FoundersPackConfig()
			{
				BasePackInventoryKey_IAPPackName = "FoundersPackDeluxe";
				BasePackInventoryKey_IAPPackName = "FoundersPackUltimate";
				BasePackInventoryKey_IAPPackName = "awarded_founders_pack";
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class GetPlaystationEntitlements
		{
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public class PlaystationEntitlementInfo
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				public string id;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public string activeDate;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public string inactiveDate;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public string entitlementType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public int useCount;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				public int useLimit;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public string packageType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public bool activeFlag;

				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public PlaystationEntitlementInfo()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum Error
			{
				[Cpp2IlInjected.Token(Token = "0x400007D")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400007E")]
				HttpStatusCodeFailed,
				[Cpp2IlInjected.Token(Token = "0x400007F")]
				HttpException,
				[Cpp2IlInjected.Token(Token = "0x4000080")]
				InvalidParams,
				[Cpp2IlInjected.Token(Token = "0x4000081")]
				InvalidIssuerId
			}

			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public class ResultData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public int nextOffset;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000083")]
				public int previousOffset;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				public List<PlaystationEntitlementInfo> entitlements;

				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public ResultData()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public class Result
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				public Error Error;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000086")]
				public string ErrorMessage;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000087")]
				public ResultData ResultData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public Exception Exception;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
				public Result WithResult(Error error)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x392FAC0", Offset = "0x392E4C0", VA = "0x18392FAC0")]
				public Result WithResult(Error error, string message)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x392F6E0", Offset = "0x392E0E0", VA = "0x18392F6E0")]
				public Result WithException(Error error, Exception e)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Result()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GetPlaystationEntitlements()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private class GetPlaystationAccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public class PlaystationAccessTokenInfo
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				public string access_token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				public string token_type;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public string expires_in;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				public string scope;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public string id_token;

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public PlaystationAccessTokenInfo()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum Error
			{
				[Cpp2IlInjected.Token(Token = "0x400008F")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000090")]
				HttpStatusCodeFailed,
				[Cpp2IlInjected.Token(Token = "0x4000091")]
				HttpException,
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				InvalidParams,
				[Cpp2IlInjected.Token(Token = "0x4000093")]
				InvalidIssuerId
			}

			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public class Result
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public Error Error;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public string ErrorMessage;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public PlaystationAccessTokenInfo ResultData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public Exception Exception;

				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
				public Result WithResult(Error error)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x392FAC0", Offset = "0x392E4C0", VA = "0x18392FAC0")]
				public Result WithResult(Error error, string message)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x392F6E0", Offset = "0x392E0E0", VA = "0x18392F6E0")]
				public Result WithException(Error error, Exception e)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Result()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GetPlaystationAccessToken()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private class VerifyEpicTokenResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public bool active;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public string scope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string token_type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public int expires_in;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public string expires_at;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public string account_id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public string client_id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public string application_id;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public VerifyEpicTokenResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class GetEpicEntitlementsFromEOS
		{
			[Cpp2IlInjected.Token(Token = "0x2000029")]
			public class EpicEntitlementsInfo
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				public string id;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				public string entitlementName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				public string catalogItemId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				public string entitlementType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				public string grantDate;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public bool consumable;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public string status;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public int useCount;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public string entitlementSource;

				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public EpicEntitlementsInfo()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200002A")]
			public enum Error
			{
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				InvalidArg_Entitlements,
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				HttpStatusCodeFailed,
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				HttpException
			}

			[Cpp2IlInjected.Token(Token = "0x200002B")]
			public class Result
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Error Error;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public List<EpicEntitlementsInfo> ResultData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public Exception Exception;

				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
				public Result WithResult(Error error)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x392F780", Offset = "0x392E180", VA = "0x18392F780")]
				public Result WithException(Error error, Exception e)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Result()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GetEpicEntitlementsFromEOS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private class RedeemEpicEntitlementsToEOS
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			public class RedeemJsonBody
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public List<string> entitlementIds;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public string sandboxId;

				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public RedeemJsonBody()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200002E")]
			public enum Error
			{
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				InvalidArg_Entitlements,
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				HttpStatusCodeFailed,
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				HttpException
			}

			[Cpp2IlInjected.Token(Token = "0x200002F")]
			public class Result
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public Error Error;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public Exception Exception;

				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
				public Result WithResult(Error error)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0x392F750", Offset = "0x392E150", VA = "0x18392F750")]
				public Result WithException(Error error, Exception e)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Result()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RedeemEpicEntitlementsToEOS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public class BatchInventoryOperationsResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public List<ExecuteInventoryOperationsResponse> Response = (List<ExecuteInventoryOperationsResponse>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public PlayFabError Error;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public string Idempotency;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x392E320", Offset = "0x392CD20", VA = "0x18392E320")]
			public BatchInventoryOperationsResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public class GetRecipeItemResults
		{
			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public List<CatalogItem> Items
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CItems_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E4")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CItems_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GetRecipeItemResults()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class SpendOnlineCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x2000033")]
			public class CurrencyInfo
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public int currencyID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public int amount;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public string playfabItemID;

				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public CurrencyInfo()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000034")]
			public enum Error
			{
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				PlayfabError
			}

			[Cpp2IlInjected.Token(Token = "0x2000035")]
			public class Result
			{
				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public Error Error
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
					[CompilerGenerated]
					get
					{
						return default(Error);
					}
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public PlayFabError PlayFabError
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public List<CurrencyInfo> NewAmounts
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public List<InventoryItem> CurrencyToUpdate
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x392FB20", Offset = "0x392E520", VA = "0x18392FB20")]
				public Result WithResult(PlayFabError error)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
				public Result WithError(Error error)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x392F7B0", Offset = "0x392E1B0", VA = "0x18392F7B0")]
				public Result WithInventoryUpdateItems(List<InventoryItem> updatedItems)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x392FDD0", Offset = "0x392E7D0", VA = "0x18392FDD0")]
				public Result()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000037")]
			public class Request
			{
				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public int CurrencyID
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
					[CompilerGenerated]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public string StoreFrontGroupUniqueName
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Request()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SpendOnlineCurrency()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public class Log
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private ILogger logger;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
			public Log(ILogger logger)
			{
				this.logger = logger;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x392ECA0", Offset = "0x392D6A0", VA = "0x18392ECA0")]
			public void info(string msg)
			{
				if (logger == null)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x392ED20", Offset = "0x392D720", VA = "0x18392ED20")]
			public void warning(string msg)
			{
				if (logger == null)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x392EC20", Offset = "0x392D620", VA = "0x18392EC20")]
			public void error(string msg)
			{
				if (logger == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		internal class PlayFabCloudScriptContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			internal GetEntityProfileResponse profileResponse;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			internal GetVirtualCurrenciesResult getVirtualCurriencesResult;

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			internal Dictionary<string, string> Currencies
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CCurrencies_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				private set
				{
					_003CCurrencies_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();


			[Cpp2IlInjected.Token(Token = "0x17000033")]
			internal Dictionary<string, int> CurrencyAmounts
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CCurrencyAmounts_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				private set
				{
					_003CCurrencyAmounts_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = (Dictionary<string, int>)(object)new Dictionary<TKey, TValue>();


			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x392EE60", Offset = "0x392D860", VA = "0x18392EE60")]
			public void Clear()
			{
				//Discarded unreachable code: IL_0017
				((Dictionary<TKey, TValue>)(object)Currencies).Clear();
				((Dictionary<TKey, TValue>)(object)CurrencyAmounts).Clear();
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x392EEE0", Offset = "0x392D8E0", VA = "0x18392EEE0")]
			public PlayFabCloudScriptContext()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public enum GetDataState
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			Unchanged,
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			Updated
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public class GetNewOrUpdateDataResult<T> where T : IOnlineLiveopsConfig
		{
			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public List<T> Configs
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return ((GetNewOrUpdateDataResult<>)(object)this)._003CConfigs_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000108")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					((GetNewOrUpdateDataResult<>)(object)this)._003CConfigs_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40000D6")]
			public bool IsOnlineUserFlagEnabled
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
			public GetNewOrUpdateDataResult()
			{
			}//Discarded unreachable code: IL_0007

		}

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private const string lastRefreshDateKey = "last_refresh";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private string EpicServerCustomIdPrefix = "epic_";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly int ExecuteInventoryOperations_MAX_OPERATIONS = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private OnlineProfileUpdater profileUpdater;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly DisneyPlayFabContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected readonly ICloudScriptExecutor executor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public readonly IServerDataFilesLoader serverLiveopsDataFilesLoader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private MethodInfo[] Methods;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected DateTime Now
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x116CF00", Offset = "0x116B900", VA = "0x18116CF00")]
			get
			{
				TimeSpan? timeSpan = DebugGamePortalSkipTime;
				if ((object)typeof(DateTime).TypeHandle != null)
				{
					int num = 0;
					DateTime utcNow = DateTime.UtcNow;
					TimeSpan? timeSpan2 = DebugGamePortalSkipTime;
					DateTime result = default(DateTime);
					return result;
				}
				int num2 = 0;
				return DateTime.UtcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public DateTime GamePortalTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x116CF00", Offset = "0x116B900", VA = "0x18116CF00")]
			get
			{
				TimeSpan? timeSpan = DebugGamePortalSkipTime;
				if ((object)typeof(DateTime).TypeHandle != null)
				{
					int num = 0;
					DateTime utcNow = DateTime.UtcNow;
					TimeSpan? timeSpan2 = DebugGamePortalSkipTime;
					DateTime result = default(DateTime);
					return result;
				}
				int num2 = 0;
				return DateTime.UtcNow;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TimeSpan? DebugGamePortalSkipTime
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x116CEA0", Offset = "0x116B8A0", VA = "0x18116CEA0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x116CFE0", Offset = "0x116B9E0", VA = "0x18116CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x58"), Cpp2IlInjected.Token(Token = "0x4000066")]
		private PlayFabCloudScriptContext csContext
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private List<BattlePassConfigV2> AllBattlePasses
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x116CDE0", Offset = "0x116B7E0", VA = "0x18116CDE0")]
			get
			{
				int cpp2il__autoParamName__idx_ = 0;
				return (List<BattlePassConfigV2>)(object)GetAllLiveopsConfigsByType<BattlePassConfigV2>((ServerDataType)cpp2il__autoParamName__idx_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private List<BundleConfig> AllBundles
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x116CE20", Offset = "0x116B820", VA = "0x18116CE20")]
			get
			{
				return (List<BundleConfig>)(object)GetAllLiveopsConfigsByType<BundleConfig>(ServerDataType.Bundles);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private List<StoreConfig> AllStores
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x116CE60", Offset = "0x116B860", VA = "0x18116CE60")]
			get
			{
				return (List<StoreConfig>)(object)GetAllLiveopsConfigsByType<StoreConfig>(ServerDataType.Stores);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private bool ForceRefreshLiveopsItems
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x116CEB0", Offset = "0x116B8B0", VA = "0x18116CEB0")]
			get
			{
				if (serverLiveopsDataFilesLoader != null)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1168D30", Offset = "0x1167730", VA = "0x181168D30")]
		[AsyncStateMachine(typeof(_003CGetBattlePassesAsync_003Ed__0))]
		public Task<GetBattlePasses.Result> GetBattlePassesAsync(GetBattlePasses.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetBattlePasses.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1167230", Offset = "0x1165C30", VA = "0x181167230")]
		[AsyncStateMachine(typeof(_003CCollectBPTaskCurrencyAsync_003Ed__1))]
		public Task<CollectBPTaskCurrency.Result> CollectBPTaskCurrencyAsync(CollectBPTaskCurrency.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CollectBPTaskCurrency.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x116B380", Offset = "0x1169D80", VA = "0x18116B380")]
		[AsyncStateMachine(typeof(_003CPurchaseBPRewardAsync_003Ed__2))]
		public Task<PurchaseBPReward.Result> PurchaseBPRewardAsync(PurchaseBPReward.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PurchaseBPReward.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x116B230", Offset = "0x1169C30", VA = "0x18116B230")]
		[AsyncStateMachine(typeof(_003CPurchaseBPPremiumPassAsync_003Ed__3))]
		public Task<PurchaseBPPremiumPass.Result> PurchaseBPPremiumPassAsync(PurchaseBPPremiumPass.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PurchaseBPPremiumPass.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x116B0E0", Offset = "0x1169AE0", VA = "0x18116B0E0")]
		[AsyncStateMachine(typeof(_003CPurchaseBPCurrencyAsync_003Ed__4))]
		public Task<PurchaseBPCurrency.Result> PurchaseBPCurrencyAsync(PurchaseBPCurrency.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PurchaseBPCurrency.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1167C70", Offset = "0x1166670", VA = "0x181167C70")]
		[AsyncStateMachine(typeof(_003CDEBUG_DeleteAllInventoryItems_003Ed__6))]
		public Task<DeleteAllInventoryItemsResult> DEBUG_DeleteAllInventoryItems()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<DeleteAllInventoryItemsResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x11679D0", Offset = "0x11663D0", VA = "0x1811679D0")]
		[AsyncStateMachine(typeof(_003CDEBUG_AddOnlineCurrency_003Ed__8))]
		public Task<AddOnlineCurrencyResult> DEBUG_AddOnlineCurrency(int currencyID, int currencyAmount)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<AddOnlineCurrencyResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1167B10", Offset = "0x1166510", VA = "0x181167B10")]
		[AsyncStateMachine(typeof(_003CDEBUG_ClaimBundle_003Ed__9))]
		public Task<PlayFabError> DEBUG_ClaimBundle(string bundleId, string authPlatformName)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabError>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1166AC0", Offset = "0x11654C0", VA = "0x181166AC0")]
		[AsyncStateMachine(typeof(_003CCheatResetAllPromoCode_003Ed__10))]
		public Task<bool> CheatResetAllPromoCode()
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1167DA0", Offset = "0x11667A0", VA = "0x181167DA0")]
		[AsyncStateMachine(typeof(_003CDEBUG_ResetDailyChest_003Ed__12))]
		public Task<PlayFabError> DEBUG_ResetDailyChest()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabError>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1167EE0", Offset = "0x11668E0", VA = "0x181167EE0")]
		[AsyncStateMachine(typeof(_003CDEBUG_Skip1DayServerForChest_003Ed__13))]
		public Task<PlayFabError> DEBUG_Skip1DayServerForChest()
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PlayFabError>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x116A0E0", Offset = "0x1168AE0", VA = "0x18116A0E0")]
		[AsyncStateMachine(typeof(_003CHACKFIX_SonyFounderPackDuplicate_003Ed__14))]
		private Task HACKFIX_SonyFounderPackDuplicate()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1169FD0", Offset = "0x11689D0", VA = "0x181169FD0")]
		[AsyncStateMachine(typeof(_003CHACKFIX_ResetOnlineDreamshardsToFixExploit_003Ed__15))]
		private Task HACKFIX_ResetOnlineDreamshardsToFixExploit()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x116A870", Offset = "0x1169270", VA = "0x18116A870")]
		[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__16))]
		public Task<Login.Result> LoginAsync(Login.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Login.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x116C9F0", Offset = "0x116B3F0", VA = "0x18116C9F0")]
		[AsyncStateMachine(typeof(_003CUpdateSessionTokenAsync_003Ed__17))]
		public Task<UpdateSessionToken.Result> UpdateSessionTokenAsync(UpdateSessionToken.Request request)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<UpdateSessionToken.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1166180", Offset = "0x1164B80", VA = "0x181166180")]
		[AsyncStateMachine(typeof(_003CAutoRedeemFoundersPackAsync_003Ed__19))]
		public Task<AutoRedeemFoundersPack.Result> AutoRedeemFoundersPackAsync(AutoRedeemFoundersPack.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<AutoRedeemFoundersPack.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x116B9D0", Offset = "0x116A3D0", VA = "0x18116B9D0")]
		[AsyncStateMachine(typeof(_003CRedeemProductIdsAsync_003Ed__20))]
		public Task<RedeemProductIds.Result> RedeemProductIdsAsync(RedeemProductIds.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<RedeemProductIds.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x11694E0", Offset = "0x1167EE0", VA = "0x1811694E0")]
		[AsyncStateMachine(typeof(_003CGetPlaystationEntitlementsAsync_003Ed__22))]
		private Task<GetPlaystationEntitlements.Result> GetPlaystationEntitlementsAsync(string serviceLabel, string authorizationToken, int issuerId)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetPlaystationEntitlements.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1169390", Offset = "0x1167D90", VA = "0x181169390")]
		[AsyncStateMachine(typeof(_003CGetPlaystationAcessTokenAsync_003Ed__24))]
		private Task<GetPlaystationAccessToken.Result> GetPlaystationAcessTokenAsync(string authCode, int issuerId)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetPlaystationAccessToken.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x116AD50", Offset = "0x1169750", VA = "0x18116AD50")]
		[AsyncStateMachine(typeof(_003CPostLoginAsync_003Ed__25))]
		public Task<PostLogin.Result> PostLoginAsync(PostLogin.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PostLogin.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x116C090", Offset = "0x116AA90", VA = "0x18116C090")]
		[AsyncStateMachine(typeof(_003CTransferMarketplacePacksAsync_003Ed__26))]
		public Task<TransferMarketplacePacks.Result> TransferMarketplacePacksAsync(TransferMarketplacePacks.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<TransferMarketplacePacks.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x116C1D0", Offset = "0x116ABD0", VA = "0x18116C1D0")]
		[AsyncStateMachine(typeof(_003CTransferMarketplacePacksImplAsync_003Ed__27))]
		private Task<TransferMarketplacePacks.ServerResult> TransferMarketplacePacksImplAsync(TransferMarketplacePacks.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<TransferMarketplacePacks.ServerResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x116C890", Offset = "0x116B290", VA = "0x18116C890")]
		[AsyncStateMachine(typeof(_003CUpdateDisplayNameAsync_003Ed__28))]
		public Task<UpdateDisplayName.Result> UpdateDisplayNameAsync(UpdateDisplayName.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<UpdateDisplayName.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x116BCE0", Offset = "0x116A6E0", VA = "0x18116BCE0")]
		[AsyncStateMachine(typeof(_003CResetDisplayNameChangeCooldownAsync_003Ed__29))]
		public Task<ResetDisplayNameChangeCooldown.Result> ResetDisplayNameChangeCooldownAsync(ResetDisplayNameChangeCooldown.Request request)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<ResetDisplayNameChangeCooldown.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x11667E0", Offset = "0x11651E0", VA = "0x1811667E0")]
		private string BuildEpicServerId(string clientId, string accountId)
		{
			return EpicServerCustomIdPrefix + clientId + "_" + accountId;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x116CB40", Offset = "0x116B540", VA = "0x18116CB40")]
		[AsyncStateMachine(typeof(_003CVerifyEpicAccessToken_003Ed__33))]
		private Task<(VerifyEpicTokenResult, VerifyEpicTokenError)> VerifyEpicAccessToken(string accessToken, string clientId, string accountId)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(VerifyEpicTokenResult, VerifyEpicTokenError)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1168FB0", Offset = "0x11679B0", VA = "0x181168FB0")]
		[AsyncStateMachine(typeof(_003CGetEpicEntitlementsFromEOSAsync_003Ed__35))]
		private Task<GetEpicEntitlementsFromEOS.Result> GetEpicEntitlementsFromEOSAsync(RedeemEpicEntitlements.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetEpicEntitlementsFromEOS.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x116B740", Offset = "0x116A140", VA = "0x18116B740")]
		[AsyncStateMachine(typeof(_003CRedeemEpicEntitlementsToEOSAsync_003Ed__37))]
		private Task<RedeemEpicEntitlementsToEOS.Result> RedeemEpicEntitlementsToEOSAsync(RedeemEpicEntitlements.Request request, List<string> entitlementsToRedeem)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<RedeemEpicEntitlementsToEOS.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x116A9B0", Offset = "0x11693B0", VA = "0x18116A9B0")]
		[AsyncStateMachine(typeof(_003CLoginWithEpicAsync_003Ed__38))]
		public Task<LoginWithEpic.Result> LoginWithEpicAsync(LoginWithEpic.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<LoginWithEpic.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x116A730", Offset = "0x1169130", VA = "0x18116A730")]
		[AsyncStateMachine(typeof(_003CLinkEpicAccountAsync_003Ed__39))]
		public Task<LinkEpicAccount.Result> LinkEpicAccountAsync(LinkEpicAccount.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<LinkEpicAccount.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x116C740", Offset = "0x116B140", VA = "0x18116C740")]
		[AsyncStateMachine(typeof(_003CUnlinkEpicAccountAsync_003Ed__40))]
		public Task<UnlinkEpicAccount.Result> UnlinkEpicAccountAsync(UnlinkEpicAccount.Request request)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<UnlinkEpicAccount.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1166E70", Offset = "0x1165870", VA = "0x181166E70")]
		[AsyncStateMachine(typeof(_003CCheckEpicLinkingStatusAsync_003Ed__41))]
		public Task<CheckEpicLinkingStatus.Result> CheckEpicLinkingStatusAsync(CheckEpicLinkingStatus.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CheckEpicLinkingStatus.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1169C30", Offset = "0x1168630", VA = "0x181169C30")]
		[AsyncStateMachine(typeof(_003CGetScheduledItemsAsync_003Ed__42))]
		public Task<GetScheduledItems.Result> GetScheduledItemsAsync(GetScheduledItems.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetScheduledItems.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x11674A0", Offset = "0x1165EA0", VA = "0x1811674A0")]
		[AsyncStateMachine(typeof(_003CConsumeScheduledItemsAsync_003Ed__43))]
		public Task<ConsumeScheduledItems.Result> ConsumeScheduledItemsAsync(ConsumeScheduledItems.Request request)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<ConsumeScheduledItems.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1169A10", Offset = "0x1168410", VA = "0x181169A10")]
		private List<RedeemItemResponse> GetRedeemItemsFromGrantResult(GrantInventoryItemsResult grantResult)
		{
			//Discarded unreachable code: IL_0059, IL_005f, IL_0065
			//IL_003a: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			List<RedeemItemResponse> list = (List<RedeemItemResponse>)(object)new List<T>();
			if (grantResult != null)
			{
				List<InventoryItemResponseDto> items = grantResult.Items;
				bool flag = default(bool);
				if (flag)
				{
					RedeemItemResponse redeemItemResponse = new RedeemItemResponse();
					int num = 0;
					int num2 = default(int);
					redeemItemResponse.ChangedQuantity = (uint)num2;
					redeemItemResponse.Quantity = (uint)num2;
					redeemItemResponse.InstanceId = (string)num;
					redeemItemResponse.CurrencyId = (string)num;
					redeemItemResponse.CurrencyType = "Item";
					((List<T>)(object)list).Add((T)redeemItemResponse);
				}
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x116B610", Offset = "0x116A010", VA = "0x18116B610")]
		[AsyncStateMachine(typeof(_003CRedeemEpicEntitlementsAsync_003Ed__45))]
		public Task<RedeemEpicEntitlements.Result> RedeemEpicEntitlementsAsync(RedeemEpicEntitlements.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<RedeemEpicEntitlements.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x116B8A0", Offset = "0x116A2A0", VA = "0x18116B8A0")]
		[AsyncStateMachine(typeof(_003CRedeemEpicPurchasesAsync_003Ed__46))]
		public Task<RedeemEpicPurchases.Result> RedeemEpicPurchasesAsync(RedeemEpicPurchases.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<RedeemEpicPurchases.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1168C10", Offset = "0x1167610", VA = "0x181168C10")]
		private static byte[] FromBase64Url(string base64Url)
		{
			//Discarded unreachable code: IL_003e
			int num;
			do
			{
				num = base64Url.m_stringLength;
				if ((long)(IntPtr)base64Url < 0L)
				{
					num++;
				}
			}
			while (num == 0);
			string text = default(string);
			return Convert.FromBase64String((base64Url + text).Replace("_", "/").Replace("-", "+"));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x116ABA0", Offset = "0x11695A0", VA = "0x18116ABA0")]
		[IteratorStateMachine(typeof(_003COwnedEpicItems_003Ed__48))]
		private IEnumerable<string> OwnedEpicItems(JwtPayload payload)
		{
			new _003COwnedEpicItems_003Ed__48(-2)._003C_003E3__payload = payload;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1169770", Offset = "0x1168170", VA = "0x181169770")]
		[AsyncStateMachine(typeof(_003CGetPublicKeyAsync_003Ed__49))]
		private Task<string> GetPublicKeyAsync(string kid)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1168AD0", Offset = "0x11674D0", VA = "0x181168AD0")]
		[AsyncStateMachine(typeof(_003CFollowUserAsync_003Ed__50))]
		public Task<FollowUser.Result> FollowUserAsync(FollowUser.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<FollowUser.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x11681D0", Offset = "0x1166BD0", VA = "0x1811681D0")]
		[AsyncStateMachine(typeof(_003CExecuteFollowAction_003Ed__51))]
		private Task<(FollowUser.Error, int)> ExecuteFollowAction(bool isUnfollowing, string followingPlayfabId, string followingEntityId, string followerPlayfabId, string followerEntityId)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(FollowUser.Error, int)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x116A1F0", Offset = "0x1168BF0", VA = "0x18116A1F0")]
		[AsyncStateMachine(typeof(_003CLikeNewsFeedAsync_003Ed__52))]
		public Task<LikeNewsFeed.Result> LikeNewsFeedAsync(LikeNewsFeed.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<LikeNewsFeed.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x116A5B0", Offset = "0x1168FB0", VA = "0x18116A5B0")]
		[AsyncStateMachine(typeof(_003CLikeNewsFeedStatisticsUpdate_003Ed__53))]
		private Task<(LikeNewsFeed.Error, bool)> LikeNewsFeedStatisticsUpdate(EntityProfileBody profile, string dailyStatisticName, string allTimeStatisticName, int maxValueCheck = 0)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(LikeNewsFeed.Error, bool)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x116A330", Offset = "0x1168D30", VA = "0x18116A330")]
		[AsyncStateMachine(typeof(_003CLikeNewsFeedGiverUpdate_003Ed__54))]
		private Task<LikeNewsFeed.Result> LikeNewsFeedGiverUpdate(string ugcItemId)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<LikeNewsFeed.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x116A470", Offset = "0x1168E70", VA = "0x18116A470")]
		[AsyncStateMachine(typeof(_003CLikeNewsFeedReceiverUpdate_003Ed__55))]
		private Task<LikeNewsFeed.ResultReceiver> LikeNewsFeedReceiverUpdate(string ugcItemId, string newsFeedCreatorId)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<LikeNewsFeed.ResultReceiver>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x116AC10", Offset = "0x1169610", VA = "0x18116AC10")]
		[AsyncStateMachine(typeof(_003CPostEventPictureAsync_003Ed__56))]
		public Task<PostEventPicture.Result> PostEventPictureAsync(PostEventPicture.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PostEventPicture.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1166FB0", Offset = "0x11659B0", VA = "0x181166FB0")]
		[AsyncStateMachine(typeof(_003CClaimOnlineInboxAsync_003Ed__57))]
		public Task<ClaimOnlineInbox.Result> ClaimOnlineInboxAsync(ClaimOnlineInbox.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ClaimOnlineInbox.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x11675F0", Offset = "0x1165FF0", VA = "0x1811675F0")]
		[AsyncStateMachine(typeof(_003CCraftRecipeAndConsumeKey_003Ed__58))]
		private Task<List<InventoryOperation>> CraftRecipeAndConsumeKey(CatalogItem recipe, InventoryItem key)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<List<InventoryOperation>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x116BB00", Offset = "0x116A500", VA = "0x18116BB00")]
		[AsyncStateMachine(typeof(_003CRefundOnlineInboxAsync_003Ed__59))]
		public Task<RefundOnlineInbox.Result> RefundOnlineInboxAsync(RefundOnlineInbox.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<RefundOnlineInbox.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x164FBE0", Offset = "0x164E5E0", VA = "0x18164FBE0")]
		public IEnumerable<> GetBatch<T>(int P_0, int P_1, IEnumerable<> P_2)
		{
			IEnumerator<> enumerator = ((IEnumerable<T>)P_2).GetEnumerator();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1166530", Offset = "0x1164F30", VA = "0x181166530")]
		[AsyncStateMachine(typeof(_003CBatchInventoryOperations_003Ed__63))]
		public Task<BatchInventoryOperationsResult> BatchInventoryOperations(List<InventoryOperation> operations, [Optional] IdempotencyIdGenerator idempotencyIdGenerator, [Optional] string collectionId)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<BatchInventoryOperationsResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x11666A0", Offset = "0x11650A0", VA = "0x1811666A0")]
		[AsyncStateMachine(typeof(_003CBatchUpdateInventoryItems_003Ed__64))]
		public Task<BatchInventoryOperationsResult> BatchUpdateInventoryItems(List<InventoryItem> items)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<BatchInventoryOperationsResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x11663F0", Offset = "0x1164DF0", VA = "0x1811663F0")]
		[AsyncStateMachine(typeof(_003CBatchDeleteInventoryItems_003Ed__65))]
		public Task<BatchInventoryOperationsResult> BatchDeleteInventoryItems(List<InventoryItem> items)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<BatchInventoryOperationsResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x11662B0", Offset = "0x1164CB0", VA = "0x1811662B0")]
		[AsyncStateMachine(typeof(_003CBatchAddInventoryItems_003Ed__66))]
		public Task<BatchInventoryOperationsResult> BatchAddInventoryItems(List<InventoryItem> items)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<BatchInventoryOperationsResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x11698C0", Offset = "0x11682C0", VA = "0x1811698C0")]
		[AsyncStateMachine(typeof(_003CGetRecipeFromPromoCodeId_003Ed__68))]
		public Task<GetRecipeItemResults> GetRecipeFromPromoCodeId(string promocodeId)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<GetRecipeItemResults>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x11670F0", Offset = "0x1165AF0", VA = "0x1811670F0")]
		[AsyncStateMachine(typeof(_003CClaimPromoCodeAsync_003Ed__69))]
		public Task<ClaimPromoCode.Result> ClaimPromoCodeAsync(ClaimPromoCode.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<ClaimPromoCode.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1169240", Offset = "0x1167C40", VA = "0x181169240")]
		[AsyncStateMachine(typeof(_003CGetOnlineCurrencyToSpendAsync_003Ed__71))]
		public Task<SpendOnlineCurrency.Result> GetOnlineCurrencyToSpendAsync(SpendOnlineCurrency.Request currencyInfo, int currencyAmount)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SpendOnlineCurrency.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x116BE10", Offset = "0x116A810", VA = "0x18116BE10")]
		[AsyncStateMachine(typeof(_003CSpendOnlineCurrencyAsync_003Ed__72))]
		public Task<SpendOnlineCurrency.Result> SpendOnlineCurrencyAsync(SpendOnlineCurrency.Request currencyInfo, int currencyAmount)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SpendOnlineCurrency.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1167370", Offset = "0x1165D70", VA = "0x181167370")]
		[AsyncStateMachine(typeof(_003CCollectLootPresentAsync_003Ed__73))]
		public Task<CollectLootPresent.Result> CollectLootPresentAsync(CollectLootPresent.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<CollectLootPresent.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1166850", Offset = "0x1165250", VA = "0x181166850")]
		[AsyncStateMachine(typeof(_003CCheatAddFollowers_003Ed__74))]
		public Task<bool> CheatAddFollowers(bool applyToCurrentPlayer, int maxNumberOfFollowers)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1166990", Offset = "0x1165390", VA = "0x181166990")]
		[AsyncStateMachine(typeof(_003CCheatRemoveFollowers_003Ed__75))]
		public Task<bool> CheatRemoveFollowers(int maxNumberOfUnfollows)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1166C00", Offset = "0x1165600", VA = "0x181166C00")]
		[AsyncStateMachine(typeof(_003CCheatTLEResetProgression_003Ed__76))]
		public Task<bool> CheatTLEResetProgression()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1166D40", Offset = "0x1165740", VA = "0x181166D40")]
		[AsyncStateMachine(typeof(_003CCheatTLEResetProgression_003Ed__77))]
		public Task<bool> CheatTLEResetProgression(PlayFabTLEContext.Type tleType)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1168090", Offset = "0x1166A90", VA = "0x181168090")]
		[AsyncStateMachine(typeof(_003CDoProfileBackupAsync_003Ed__78))]
		public Task<DoProfileBackup.Result> DoProfileBackupAsync(DoProfileBackup.Request request)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<DoProfileBackup.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1167750", Offset = "0x1166150", VA = "0x181167750")]
		private unsafe void CreateOnlineProfileUpdater()
		{
			//Discarded unreachable code: IL_009f
			//IL_0070: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			if ((long)profileUpdater == 0)
			{
				OnlineProfileUpdater.StaticContext staticContext = new OnlineProfileUpdater.StaticContext();
				OnlineEnvironment onlineEnvironment = (staticContext.OnlineEnv = OnlineEnvironmentConfig.GetOnlineEnvFromTitleId(context.TitleId));
				OnlineProfileUpdater onlineProfileUpdater = default(OnlineProfileUpdater);
				List<OnlineProfileUpdate> list = (onlineProfileUpdater.profileUpdatesSorted = (List<OnlineProfileUpdate>)(object)new List<T>());
				List<OnlineProfileUpdate> list2 = (onlineProfileUpdater.recurringProfileUpdates = (List<OnlineProfileUpdate>)(object)new List<T>());
				onlineProfileUpdater.AddUpdate3ProfileUpdateHotFixes();
				onlineProfileUpdater.CurrentStaticContext = staticContext;
				if (OnlineProfileUpdater.StaticContext.IsOnlineEnvDebugOrDev(onlineProfileUpdater.CurrentStaticContext))
				{
					int num = default(int);
					Func<OnlineProfileUpdater.StaticContext, bool> func = (Func<OnlineProfileUpdater.StaticContext, bool>)(object)new Func<T, TResult>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<OnlineProfileUpdater.StaticContext, bool>*/)(&OnlineProfileUpdater.StaticContext.IsOnlineEnvDebugOrDev));
					num = 0;
					int num2 = default(int);
					Func<OnlineProfileUpdater.ClientContext, bool> func2 = (Func<OnlineProfileUpdater.ClientContext, bool>)(object)new Func<T, TResult>(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<OnlineProfileUpdater.ClientContext, bool>*/)(&OnlineProfileUpdater.ClientContext.IsDebugBuild));
					num2 = 0;
					onlineProfileUpdater.AddRecurringUpdate<AddDevInboxMessageOnEveryContinueGame>((Func<, >)(object)func, (Func<, >)(object)func2);
				}
				onlineProfileUpdater.PostInit();
				profileUpdater = onlineProfileUpdater;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1168020", Offset = "0x1166A20", VA = "0x181168020")]
		public int Debug_AddUnitTestDummyDebugPotatoesTests()
		{
			profileUpdater.AddUnitTestDummyDebugPotatoesTests();
			OnlineProfileUpdate onlineProfileUpdate = Enumerable.LastOrDefault<OnlineProfileUpdate>((IEnumerable<>)profileUpdater.profileUpdatesSorted);
			if (onlineProfileUpdate != null)
			{
				return onlineProfileUpdate.OnlineVersion;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x116AE60", Offset = "0x1169860", VA = "0x18116AE60")]
		[AsyncStateMachine(typeof(_003CPreGameLoadHandShakeAsync_003Ed__82))]
		public Task<PreGameLoad.HandShake.Result> PreGameLoadHandShakeAsync(PreGameLoad.HandShake.Request request)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PreGameLoad.HandShake.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x116AFA0", Offset = "0x11699A0", VA = "0x18116AFA0")]
		[AsyncStateMachine(typeof(_003CPreGameLoadSendRequestedDataAsync_003Ed__83))]
		public Task<PreGameLoad.SendRequestedData.Result> PreGameLoadSendRequestedDataAsync(PreGameLoad.SendRequestedData.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PreGameLoad.SendRequestedData.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x116B4D0", Offset = "0x1169ED0", VA = "0x18116B4D0")]
		[AsyncStateMachine(typeof(_003CPurchaseVerifierAsync_003Ed__84))]
		public Task<PurchaseVerifier.Result> PurchaseVerifierAsync(PurchaseVerifier.Request request)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<PurchaseVerifier.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1168E70", Offset = "0x1167870", VA = "0x181168E70")]
		[AsyncStateMachine(typeof(_003CGetBundlesAsync_003Ed__85))]
		public Task<GetBundles.Result> GetBundlesAsync(GetBundles.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetBundles.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1169D70", Offset = "0x1168770", VA = "0x181169D70")]
		[AsyncStateMachine(typeof(_003CGetStoresAsync_003Ed__86))]
		public Task<GetStores.Result> GetStoresAsync(GetStores.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetStores.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x116BF60", Offset = "0x116A960", VA = "0x18116BF60")]
		[AsyncStateMachine(typeof(_003CStorePurchaseAsync_003Ed__87))]
		public Task<StorePurchase.Result> StorePurchaseAsync(StorePurchase.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<StorePurchase.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x116C9D0", Offset = "0x116B3D0", VA = "0x18116C9D0", Slot = "5")]
		public void UpdateEntityToken(string newEntityToken)
		{
			DisneyPlayFabContext disneyPlayFabContext = context;
			if (disneyPlayFabContext != null)
			{
				disneyPlayFabContext.BaseEntityToken = newEntityToken;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x164FA90", Offset = "0x164E490", VA = "0x18164FA90")]
		private List<> GetAllLiveopsConfigsByType<T>(ServerDataType cpp2il__autoParamName__idx_0) where T : IOnlineLiveopsConfig
		{
			if ((long)serverLiveopsDataFilesLoader != 0)
			{
				IServerDataFilesLoader serverDataFilesLoader = serverLiveopsDataFilesLoader;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				uint num3 = num3 + num3;
				num += 328;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x11690F0", Offset = "0x1167AF0", VA = "0x1811690F0")]
		private Task<GetNewOrUpdateDataResult<BattlePassConfigV2>> GetNewOrUpdatedBattlePasses(ILiveopsDataParams dataParams, DateTime utcNow, GetLiveopsDataResult<BattlePassConfigV2> result, [Optional] Func<BattlePassConfigV2, KnownConfig, bool> configRefreshCheckCB)
		{
			Task<> result2 = default(Task<>);
			return (Task<GetNewOrUpdateDataResult<BattlePassConfigV2>>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1169160", Offset = "0x1167B60", VA = "0x181169160")]
		private Task<GetNewOrUpdateDataResult<BundleConfig>> GetNewOrUpdatedBundles(ILiveopsDataParams dataParams, DateTime utcNow, GetLiveopsDataResult<BundleConfig> result, [Optional] Func<BundleConfig, KnownConfig, bool> configRefreshCheckCB)
		{
			Task<> result2 = default(Task<>);
			return (Task<GetNewOrUpdateDataResult<BundleConfig>>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x11691D0", Offset = "0x1167BD0", VA = "0x1811691D0")]
		private Task<GetNewOrUpdateDataResult<StoreConfig>> GetNewOrUpdatedStores(ILiveopsDataParams dataParams, DateTime utcNow, GetLiveopsDataResult<StoreConfig> result, [Optional] Func<StoreConfig, KnownConfig, bool> configRefreshCheckCB)
		{
			Task<> result2 = default(Task<>);
			return (Task<GetNewOrUpdateDataResult<StoreConfig>>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x164FC30", Offset = "0x164E630", VA = "0x18164FC30")]
		[AsyncStateMachine(typeof(_003CGetNewOrUpdatedConfigs_003Ed__120<>))]
		private Task<GetNewOrUpdateDataResult<T>> GetNewOrUpdatedConfigs<T>(ILiveopsDataParams dataParams, DateTime utcNow, GetLiveopsDataResult<T> result, [Optional] Func<T, KnownConfig, bool> configRefreshCheckCB) where T : IOnlineLiveopsConfig
		{
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<GetNewOrUpdateDataResult<T>>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x116CCB0", Offset = "0x116B6B0", VA = "0x18116CCB0")]
		public DisneyCloudScript(DisneyPlayFabContext context, bool createCloudScriptContext = false, [Optional] ICloudScriptExecutor executor, [Optional] IServerDataFilesLoader serverLiveopsDataFilesLoader)
		{
			//IL_0015: Expected I4, but got I8
			//IL_0030: Expected O, but got I4
			this.executor = executor;
			this.context = context;
			this.serverLiveopsDataFilesLoader = (IServerDataFilesLoader)0;
			if (createCloudScriptContext)
			{
				PlayFabCloudScriptContext playFabCloudScriptContext = (csContext = new PlayFabCloudScriptContext());
			}
			CreateOnlineProfileUpdater();
			MethodInfo[] array = (Methods = GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x116BC30", Offset = "0x116A630", VA = "0x18116BC30")]
		private void ResetContext()
		{
			((Dictionary<TKey, TValue>)(object)csContext.Currencies).Clear();
			((Dictionary<TKey, TValue>)(object)csContext.CurrencyAmounts).Clear();
			PlayFabCloudScriptContext playFabCloudScriptContext = csContext;
			PlayFabCloudScriptContext playFabCloudScriptContext2 = csContext;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1169650", Offset = "0x1168050", VA = "0x181169650")]
		[AsyncStateMachine(typeof(_003CGetProfileAsync_003Ed__123))]
		public Task<EntityProfileBody> GetProfileAsync(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<EntityProfileBody>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1169EB0", Offset = "0x11688B0", VA = "0x181169EB0")]
		[AsyncStateMachine(typeof(_003CGetVirtualCurrenciesAsync_003Ed__124))]
		public Task<GetVirtualCurrenciesResult> GetVirtualCurrenciesAsync(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<GetVirtualCurrenciesResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x116AAF0", Offset = "0x11694F0", VA = "0x18116AAF0")]
		private static bool Matches(MethodInfo method, string methodName, Type argumentType, Type returnType)
		{
			if (method.Name != null)
			{
				return true;
			}
			string name = method.Name;
			string text = methodName + "Async";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1168360", Offset = "0x1166D60", VA = "0x181168360")]
		public Task<PlayFabResult<ExecuteFunctionResult>> ExecuteFunctionAsync(string functionName, string arguments)
		{
			//IL_0034: Expected O, but got I4
			//IL_00a3: Expected I4, but got I8
			//IL_00d5: Expected I4, but got I8
			MethodInfo[] methods = Methods;
			Func<MethodInfo, bool> func = (Func<MethodInfo, bool>)(object)(Func<T, TResult>)delegate(MethodInfo x)
			{
				//Discarded unreachable code: IL_0033
				string text2 = functionName;
				if (string.Equals(x.Name, text2))
				{
					return true;
				}
				string name = x.Name;
				string b = text2 + "Async";
				return string.Equals(name, b);
			};
			MethodInfo methodInfo = Enumerable.FirstOrDefault<MethodInfo>((IEnumerable<>)(object)methods, (Func<, >)(object)func);
			int num = 0;
			if (methodInfo != (MethodInfo)num)
			{
				Type parameterType = methodInfo.GetParameters()[0].ParameterType;
				object obj = JsonConvert.DeserializeObject(arguments, parameterType);
				if (obj != null)
				{
					string _003CFunctionName_003Ek__BackingField = functionName;
					ExecuteFunctionRequest executeFunctionRequest = new ExecuteFunctionRequest();
					executeFunctionRequest.FunctionName = _003CFunctionName_003Ek__BackingField;
					executeFunctionRequest.FunctionParameter = obj;
					AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
					int num2 = 0;
					Task<> result = default(Task<>);
					return (Task<PlayFabResult<ExecuteFunctionResult>>)(object)result;
				}
			}
			PlayFabResult<ExecuteFunctionResult> playFabResult = (PlayFabResult<ExecuteFunctionResult>)(object)new PlayFabResult<TResult>();
			PlayFabError playFabError = new PlayFabError();
			playFabError.Error = PlayFabErrorCode.CloudScriptNotFound;
			int num3 = 0;
			string text = (playFabError.ErrorMessage = functionName + "(" + arguments + ")");
			playFabError.HttpCode = 404;
			playFabError.ErrorMessage = (string)(object)playFabError;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1168910", Offset = "0x1167310", VA = "0x181168910")]
		private Task<PlayFabResult<ExecuteFunctionResult>> ExecuteFunctionAsync(string functionName, object parameter)
		{
			//Discarded unreachable code: IL_001e
			ExecuteFunctionRequest executeFunctionRequest = new ExecuteFunctionRequest();
			executeFunctionRequest.FunctionName = functionName;
			executeFunctionRequest.FunctionParameter = parameter;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<ExecuteFunctionResult>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x11687D0", Offset = "0x11671D0", VA = "0x1811687D0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CExecuteFunctionAsync_003Ed__128))]
		public Task<PlayFabResult<ExecuteFunctionResult>> ExecuteFunctionAsync(ExecuteFunctionRequest request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<ExecuteFunctionResult>>)(object)result;
		}
	}
}
