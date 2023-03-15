using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using PlayFab;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000991")]
	public interface IOnlineAction
	{
		[Cpp2IlInjected.Token(Token = "0x17000E8B")]
		bool IsPlayFabSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x60053FD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60053FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> Execute(ClientSession clientSession, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60053FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PlayFabErrorCode GetPlayFabResult();

		[Cpp2IlInjected.Token(Token = "0x60053FC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetPlayFabResult(PlayFabErrorCode playFabResult);
	}
}
