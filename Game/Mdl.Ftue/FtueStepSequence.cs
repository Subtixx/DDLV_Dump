using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using Meta.Util;
using UnityEngine;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x200057E")]
	[CreateAssetMenu]
	public class FtueStepSequence : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40021FC")]
		[NonReorderable]
		public List<FtueStep> tasks = (List<FtueStep>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x600189B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4FC0", Offset = "0x8B39C0", VA = "0x1808B4FC0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__1))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x600189C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5140", Offset = "0x8B3B40", VA = "0x1808B5140")]
		public FtueStepSequence()
		{
			onlyInControlType = (List<ControlSchemeType>)(object)new List<T>();
			blockInputWhileWaiting = true;
			((ScriptableObject)this)._002Ector();
		}
	}
}
