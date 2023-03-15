using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005A2")]
	[CreateAssetMenu]
	public class MoveAvatarWithJoystick : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40022AA")]
		public float minDistance = 5f;

		[Cpp2IlInjected.Token(Token = "0x6001927")]
		[Cpp2IlInjected.Address(RVA = "0xEFD950", Offset = "0xEFC350", VA = "0x180EFD950", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__1))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001928")]
		[Cpp2IlInjected.Address(RVA = "0xEFDAB0", Offset = "0xEFC4B0", VA = "0x180EFDAB0")]
		public MoveAvatarWithJoystick()
		{
		}
	}
}
