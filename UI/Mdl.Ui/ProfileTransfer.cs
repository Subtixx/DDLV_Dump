using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000299")]
	public class ProfileTransfer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000BB9")]
		public static string avatarCode;

		[Cpp2IlInjected.Token(Token = "0x6001066")]
		[Cpp2IlInjected.Address(RVA = "0xE1E6B0", Offset = "0xE1D0B0", VA = "0x180E1E6B0")]
		[AsyncStateMachine(typeof(_003CRetrieveCode_003Ed__1))]
		public Task RetrieveCode()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001067")]
		[Cpp2IlInjected.Address(RVA = "0xE1E7C0", Offset = "0xE1D1C0", VA = "0x180E1E7C0")]
		[AsyncStateMachine(typeof(_003CShowPopupCode_003Ed__2))]
		public Task ShowPopupCode(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001068")]
		[Cpp2IlInjected.Address(RVA = "0xE1E5B0", Offset = "0xE1CFB0", VA = "0x180E1E5B0")]
		[AsyncStateMachine(typeof(_003CNeedInternetWarning_003Ed__3))]
		public Task NeedInternetWarning([Optional] CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001069")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ProfileTransfer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600106A")]
		[Cpp2IlInjected.Address(RVA = "0xE1E8A0", Offset = "0xE1D2A0", VA = "0x180E1E8A0")]
		static ProfileTransfer()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
