using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C53")]
	public abstract class PlayerAction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40044B5")]
		public bool EnableDebugLog;

		[Cpp2IlInjected.Token(Token = "0x170007A1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40044B4")]
		public bool CanBeResumed
		{
			[Cpp2IlInjected.Token(Token = "0x60038A7")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60038A8")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			protected set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x60038A9")]
		[Cpp2IlInjected.Address(RVA = "0x14BAB70", Offset = "0x14B9570", VA = "0x1814BAB70", Slot = "4")]
		public virtual Task StartAction(PlayerAvatar avatar, PlayerTask task)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x60038AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x60038AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public virtual void CancelAction(PlayerAvatar avatar, PlayerTask task)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60038AC")]
		[Cpp2IlInjected.Address(RVA = "0x127C4C0", Offset = "0x127AEC0", VA = "0x18127C4C0", Slot = "7")]
		public virtual Vector3? OverrideDestination(PlayerAvatar avatar, PlayerTask task, Vector3 destination)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038AD")]
		[Cpp2IlInjected.Address(RVA = "0x14BAB10", Offset = "0x14B9510", VA = "0x1814BAB10", Slot = "8")]
		public virtual Task<bool> CanExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			return (Task<bool>)(object)Task.FromResult(result: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60038AE")]
		[Cpp2IlInjected.Address(RVA = "0x14BABC0", Offset = "0x14B95C0", VA = "0x1814BABC0", Slot = "9")]
		public virtual bool TryGetActionCost(GameObject target, PlayerTaskDefinition playerTaskDefinition, out Item currencyItem, out int amount)
		{
			//IL_000d: Expected I4, but got O
			Item invalid = Item.Invalid;
			currencyItem.ItemID = (int)invalid;
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038AF")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "10")]
		public virtual bool CanQueueTask(GameObject target)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60038B0")]
		[Cpp2IlInjected.Address(RVA = "0x8CA520", Offset = "0x8C8F20", VA = "0x1808CA520")]
		protected PlayerAction()
		{
		}
	}
}
