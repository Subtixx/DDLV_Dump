using Cpp2IlInjected;
using Rewired;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D5")]
	public static class DefaultInputProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6001081")]
		[Cpp2IlInjected.Address(RVA = "0x1621C80", Offset = "0x1620680", VA = "0x181621C80")]
		public static InputProvider Get()
		{
			//Discarded unreachable code: IL_0017
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			return RewiredInputProvider.GetPlayerInputProvider(players.GetPlayer(playerId));
		}
	}
}
