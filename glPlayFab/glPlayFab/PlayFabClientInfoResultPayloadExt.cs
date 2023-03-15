using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using PlayFab.ClientModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public static class PlayFabClientInfoResultPayloadExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x1035E60", Offset = "0x1034860", VA = "0x181035E60")]
		public static bool IsDev(this GetPlayerCombinedInfoResultPayload infoResultPayload)
		{
			bool flag = default(bool);
			bool result = default(bool);
			if (infoResultPayload.UserReadOnlyData != null && flag)
			{
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x1035D40", Offset = "0x1034740", VA = "0x181035D40")]
		public static bool IsDevBattlePass(this GetPlayerCombinedInfoResultPayload infoResultPayload)
		{
			bool flag = default(bool);
			bool result = default(bool);
			if (infoResultPayload.UserReadOnlyData != null && flag)
			{
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1035DD0", Offset = "0x10347D0", VA = "0x181035DD0")]
		public static bool IsDevShop(this GetPlayerCombinedInfoResultPayload infoResultPayload)
		{
			bool flag = default(bool);
			bool result = default(bool);
			if (infoResultPayload.UserReadOnlyData != null && flag)
			{
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x1035F80", Offset = "0x1034980", VA = "0x181035F80")]
		public static bool IsTesterEnv(this GetPlayerCombinedInfoResultPayload infoResultPayload)
		{
			bool flag = default(bool);
			bool result = default(bool);
			if (infoResultPayload.UserReadOnlyData != null && flag)
			{
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1035EF0", Offset = "0x10348F0", VA = "0x181035EF0")]
		public static bool IsQAPromo(this GetPlayerCombinedInfoResultPayload infoResultPayload)
		{
			bool flag = default(bool);
			bool result = default(bool);
			if (infoResultPayload.UserReadOnlyData != null && flag)
			{
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1035BD0", Offset = "0x10345D0", VA = "0x181035BD0")]
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
						Func<UserOpenIdInfo, bool> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
						if (_003C_003E9__5_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(UserOpenIdInfo x)
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
			}
			return "";
		}
	}
}
