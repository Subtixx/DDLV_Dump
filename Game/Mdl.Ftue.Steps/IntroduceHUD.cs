using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005A0")]
	[CreateAssetMenu]
	public class IntroduceHUD : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40022A3")]
		public HudApparitionPhases HUDToAppear;

		[Cpp2IlInjected.Token(Token = "0x6001923")]
		[Cpp2IlInjected.Address(RVA = "0x11BB810", Offset = "0x11BA210", VA = "0x1811BB810", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__1))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001924")]
		[Cpp2IlInjected.Address(RVA = "0xF060E0", Offset = "0xF04AE0", VA = "0x180F060E0")]
		public IntroduceHUD()
		{
		}
	}
}
