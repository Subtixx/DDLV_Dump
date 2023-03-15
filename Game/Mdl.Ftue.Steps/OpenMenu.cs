using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005A4")]
	[CreateAssetMenu]
	public class OpenMenu : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40022B6")]
		public AssetReference menu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40022B7")]
		public bool isPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40022B8")]
		public bool waitUntilExit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x40022B9")]
		public bool withChoice;

		[Cpp2IlInjected.Token(Token = "0x600192B")]
		[Cpp2IlInjected.Address(RVA = "0xF05F80", Offset = "0xF04980", VA = "0x180F05F80", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__4))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x600192C")]
		[Cpp2IlInjected.Address(RVA = "0xF060E0", Offset = "0xF04AE0", VA = "0x180F060E0")]
		public OpenMenu()
		{
		}
	}
}
