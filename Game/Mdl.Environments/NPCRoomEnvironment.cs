using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Meta;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000662")]
	internal class NPCRoomEnvironment : Environment
	{
		[Cpp2IlInjected.Token(Token = "0x6001C6A")]
		[Cpp2IlInjected.Address(RVA = "0xF00950", Offset = "0xEFF350", VA = "0x180F00950", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		protected override Task Init(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C6B")]
		[Cpp2IlInjected.Address(RVA = "0xF00AC0", Offset = "0xEFF4C0", VA = "0x180F00AC0")]
		public NPCRoomEnvironment()
		{
		}
	}
}
