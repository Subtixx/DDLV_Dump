using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.CloudScriptModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public static class PlayFabCloudscriptInstanceAPIExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x1037950", Offset = "0x1036350", VA = "0x181037950")]
		public static EntityKey GetCloudscriptEntityKey(this PlayFabAuthenticationContext self)
		{
			//Discarded unreachable code: IL_0024
			EntityKey entityKey = new EntityKey();
			string text = (entityKey.Type = self.EntityType);
			string text2 = (entityKey.Id = self.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x10379D0", Offset = "0x10363D0", VA = "0x1810379D0")]
		public static EntityKey GetEntityKey(this PlayFabCloudScriptInstanceAPI self)
		{
			//Discarded unreachable code: IL_002b
			PlayFabAuthenticationContext authenticationContext = self.authenticationContext;
			EntityKey entityKey = new EntityKey();
			string text = (entityKey.Type = authenticationContext.EntityType);
			string text2 = (entityKey.Id = authenticationContext.EntityId);
			return entityKey;
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x26D22E0", Offset = "0x26D0CE0", VA = "0x1826D22E0")]
		[AsyncStateMachine(typeof(_003CExecuteFunctionAsync2_003Ed__2<>))]
		public static Task<PlayFabResult<ExecuteFunctionResult<TRESULT>>> ExecuteFunctionAsync2<TRESULT>(this PlayFabCloudScriptInstanceAPI self, string functionName, object request, [Optional] EntityKey entity)
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<PlayFabResult<ExecuteFunctionResult<TRESULT>>>)(object)result;
		}
	}
}
