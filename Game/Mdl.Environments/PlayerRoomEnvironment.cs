using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Meta;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000677")]
	internal class PlayerRoomEnvironment : Environment
	{
		[Cpp2IlInjected.Token(Token = "0x6001CBD")]
		[Cpp2IlInjected.Address(RVA = "0x14D1380", Offset = "0x14CFD80", VA = "0x1814D1380", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		protected override Task Init(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBE")]
		[Cpp2IlInjected.Address(RVA = "0xF00AC0", Offset = "0xEFF4C0", VA = "0x180F00AC0")]
		public PlayerRoomEnvironment()
		{
		}
	}
}
