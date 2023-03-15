using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005B2")]
	[CreateAssetMenu]
	public class SwipeCameraTutorial : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002320")]
		public GameObject uiPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002321")]
		public float minPanDistance = 2f;

		[Cpp2IlInjected.Token(Token = "0x6001960")]
		[Cpp2IlInjected.Address(RVA = "0x1067770", Offset = "0x1066170", VA = "0x181067770", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__2))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001961")]
		[Cpp2IlInjected.Address(RVA = "0x10678C0", Offset = "0x10662C0", VA = "0x1810678C0")]
		public SwipeCameraTutorial()
		{
		}
	}
}
