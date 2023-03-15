using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using PlayFab.ServerModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	public static class PlayFabServerInfoResultPayloadExt
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x103F730", Offset = "0x103E130", VA = "0x18103F730")]
		public static string GetGameloftIDLink(this GetPlayerCombinedInfoResultPayload infoResultPayload)
		{
			if (infoResultPayload != null)
			{
				UserAccountInfo accountInfo = infoResultPayload.AccountInfo;
				if (accountInfo != null)
				{
					List<UserOpenIdInfo> openIdInfo = accountInfo.OpenIdInfo;
					if (openIdInfo != null)
					{
						Func<UserOpenIdInfo, bool> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
						if (_003C_003E9__0_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(UserOpenIdInfo x)
							{
								//Discarded unreachable code: IL_0015
								string connectionId = x.ConnectionId;
								string connectionId2 = GameloftIdConnection.ConnectionId;
								return string.Equals(connectionId, connectionId2);
							};
						}
						UserOpenIdInfo userOpenIdInfo = Enumerable.FirstOrDefault<UserOpenIdInfo>((IEnumerable<>)openIdInfo, (Func<, >)(object)_003C_003E9__0_);
						if (userOpenIdInfo != null && userOpenIdInfo.Subject != null)
						{
						}
					}
				}
			}
			return "";
		}
	}
}
