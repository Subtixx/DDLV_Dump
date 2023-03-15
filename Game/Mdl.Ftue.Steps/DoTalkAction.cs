using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Utils;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x200058E")]
	[CreateAssetMenu]
	public class DoTalkAction : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002244")]
		[ItemID]
		public int characterID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002245")]
		public float DelayBeforeFadeIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002246")]
		public float FadeInDuration;

		[Cpp2IlInjected.Token(Token = "0x60018D2")]
		[Cpp2IlInjected.Address(RVA = "0x19CFCA0", Offset = "0x19CE6A0", VA = "0x1819CFCA0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__3))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60018D3")]
		[Cpp2IlInjected.Address(RVA = "0xF060E0", Offset = "0xF04AE0", VA = "0x180F060E0")]
		public DoTalkAction()
		{
		}
	}
}
