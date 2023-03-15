using System.Collections.Generic;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.AuthenticationModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public static class PlayFabAuthInstanceAPIExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1035A50", Offset = "0x1034450", VA = "0x181035A50")]
		public static EntityKey GetEntityKey(this PlayFabAuthenticationContext self)
		{
			//Discarded unreachable code: IL_0024
			EntityKey entityKey = new EntityKey();
			string text = (entityKey.Type = self.EntityType);
			string text2 = (entityKey.Id = self.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x1035AD0", Offset = "0x10344D0", VA = "0x181035AD0")]
		public static Task<PlayFabResult<GetEntityTokenResponse>> GetEntityTokenAsync(this PlayFabAuthenticationInstanceAPI self)
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected O, but got I4
			//IL_0013: Expected O, but got I4
			GetEntityTokenRequest getEntityTokenRequest = new GetEntityTokenRequest();
			int num = 0;
			int num2 = 0;
			return (Task<PlayFabResult<GetEntityTokenResponse>>)(object)self.GetEntityTokenAsync(getEntityTokenRequest, (object)num2, (Dictionary<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x10358E0", Offset = "0x10342E0", VA = "0x1810358E0")]
		public static PlayFabApiSettings Clone(this PlayFabApiSettings self)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
