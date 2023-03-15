using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.CloudScriptModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	public interface ICloudScriptExecutor
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PlayFabResult<ExecuteFunctionResult>> ExecuteFunctionAsync(ExecuteFunctionRequest request);

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UpdateEntityToken(string newEntityToken);
	}
}
