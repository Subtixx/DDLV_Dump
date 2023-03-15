using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200061F")]
	public class MailboxObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002210")]
		private CancellationTokenSource infoGizmoCTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002211")]
		private CancellationToken ct;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002212")]
		private bool isNewMail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002213")]
		[SerializeField]
		private GameObject markerMail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002214")]
		[SerializeField]
		private GameObject markerAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002215")]
		private bool hasMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4002216")]
		private bool isDebug;

		[Cpp2IlInjected.Token(Token = "0x60027FE")]
		[Cpp2IlInjected.Address(RVA = "0xFA2CC0", Offset = "0xFA16C0", VA = "0x180FA2CC0")]
		[AsyncStateMachine(typeof(_003CGetInbox_003Ed__7))]
		public Task GetInbox()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027FF")]
		[Cpp2IlInjected.Address(RVA = "0xFA2E40", Offset = "0xFA1840", VA = "0x180FA2E40")]
		private void OnEnable()
		{
			//IL_0013: Expected F4, but got I4
			int num = 0;
			InvokeRepeating("CheckNewInbox", num, 10f);
		}

		[Cpp2IlInjected.Token(Token = "0x6002800")]
		[Cpp2IlInjected.Address(RVA = "0xFA2DC0", Offset = "0xFA17C0", VA = "0x180FA2DC0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0038
			//IL_0037: Expected O, but got I8
			CancelInvoke("CheckNewInbox");
			CancellationTokenSource cancellationTokenSource = infoGizmoCTS;
			hasMarker = false;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				infoGizmoCTS.Dispose();
				infoGizmoCTS = (CancellationTokenSource)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002801")]
		[Cpp2IlInjected.Address(RVA = "0xFA2B30", Offset = "0xFA1530", VA = "0x180FA2B30")]
		public void CheckNewInbox()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002802")]
		[Cpp2IlInjected.Address(RVA = "0xFA2E90", Offset = "0xFA1890", VA = "0x180FA2E90")]
		private void ShowFlag()
		{
			//Discarded unreachable code: IL_0035
			if (!hasMarker && (long)infoGizmoCTS == 0)
			{
				hasMarker = true;
				CancellationTokenSource cancellationTokenSource = (infoGizmoCTS = new CancellationTokenSource());
				BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002803")]
		[Cpp2IlInjected.Address(RVA = "0xFA2C70", Offset = "0xFA1670", VA = "0x180FA2C70")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_000c
			hasMarker = false;
			if ((object)this == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002804")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MailboxObject()
		{
		}
	}
}
