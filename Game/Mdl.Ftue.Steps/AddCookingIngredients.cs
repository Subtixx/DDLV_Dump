using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Systems;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x200058A")]
	[CreateAssetMenu]
	public class AddCookingIngredients : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400222A")]
		public int ingredientsAmount = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400222B")]
		public string messageKey = "tutorial_add_ingredients";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400222C")]
		private bool cancelled;

		[Cpp2IlInjected.Token(Token = "0x60018BE")]
		[Cpp2IlInjected.Address(RVA = "0xA3C530", Offset = "0xA3AF30", VA = "0x180A3C530", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__3))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60018BF")]
		[Cpp2IlInjected.Address(RVA = "0xA3C690", Offset = "0xA3B090", VA = "0x180A3C690")]
		private void SystemStopped(Mdl.Systems.System system)
		{
			cancelled = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60018C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6A0", Offset = "0xA3B0A0", VA = "0x180A3C6A0")]
		public AddCookingIngredients()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
