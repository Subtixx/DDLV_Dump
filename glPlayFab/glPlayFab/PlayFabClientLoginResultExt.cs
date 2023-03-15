using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using PlayFab.ClientModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class PlayFabClientLoginResultExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x1037600", Offset = "0x1036000", VA = "0x181037600")]
		public static string GetGameloftIDLink(this LoginResult loginResult)
		{
			if (loginResult != null)
			{
				GetPlayerCombinedInfoResultPayload infoResultPayload = loginResult.InfoResultPayload;
				if (infoResultPayload != null)
				{
					UserAccountInfo accountInfo = infoResultPayload.AccountInfo;
					if (accountInfo != null)
					{
						List<UserOpenIdInfo> openIdInfo = accountInfo.OpenIdInfo;
						if (openIdInfo != null)
						{
							Func<UserOpenIdInfo, bool> _003C_003E9__5_ = PlayFabClientInfoResultPayloadExt._003C_003Ec._003C_003E9__5_0;
							if (_003C_003E9__5_ == null)
							{
								PlayFabClientInfoResultPayloadExt._003C_003Ec._003C_003E9 = (PlayFabClientInfoResultPayloadExt._003C_003Ec)(object)(Func<T, TResult>)delegate(UserOpenIdInfo x)
								{
									//Discarded unreachable code: IL_0015
									string connectionId = x.ConnectionId;
									string connectionId2 = GameloftIdConnection.ConnectionId;
									return string.Equals(connectionId, connectionId2);
								};
							}
							UserOpenIdInfo userOpenIdInfo = Enumerable.FirstOrDefault<UserOpenIdInfo>((IEnumerable<>)openIdInfo, (Func<, >)(object)_003C_003E9__5_);
							if (userOpenIdInfo != null && userOpenIdInfo.Subject != null)
							{
							}
						}
					}
					if ("" != null)
					{
					}
				}
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x10377A0", Offset = "0x10361A0", VA = "0x1810377A0")]
		public static bool IsGameloftIDLinked(this LoginResult loginResult)
		{
			if (loginResult != null)
			{
				GetPlayerCombinedInfoResultPayload infoResultPayload = loginResult.InfoResultPayload;
				if (infoResultPayload != null)
				{
					UserAccountInfo accountInfo = infoResultPayload.AccountInfo;
					if (accountInfo != null)
					{
						List<UserOpenIdInfo> openIdInfo = accountInfo.OpenIdInfo;
						if (openIdInfo != null)
						{
							Func<UserOpenIdInfo, bool> _003C_003E9__5_ = PlayFabClientInfoResultPayloadExt._003C_003Ec._003C_003E9__5_0;
							if (_003C_003E9__5_ == null)
							{
								PlayFabClientInfoResultPayloadExt._003C_003Ec._003C_003E9 = (PlayFabClientInfoResultPayloadExt._003C_003Ec)(object)(Func<T, TResult>)delegate(UserOpenIdInfo x)
								{
									//Discarded unreachable code: IL_0015
									string connectionId = x.ConnectionId;
									string connectionId2 = GameloftIdConnection.ConnectionId;
									return string.Equals(connectionId, connectionId2);
								};
							}
							UserOpenIdInfo userOpenIdInfo = Enumerable.FirstOrDefault<UserOpenIdInfo>((IEnumerable<>)openIdInfo, (Func<, >)(object)_003C_003E9__5_);
							if (userOpenIdInfo != null && userOpenIdInfo.Subject != null)
							{
							}
						}
					}
					if ("" != null)
					{
					}
				}
			}
			return !string.IsNullOrEmpty("");
		}
	}
}
