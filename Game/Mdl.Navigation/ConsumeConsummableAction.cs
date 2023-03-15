using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Systems;
using Mdl.Ui;
using Meta;
using Meta.Online;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BAC")]
	internal class ConsumeConsummableAction : PlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004101")]
		public AssetReferenceGameObject ConsumeVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004102")]
		public VolumeProfile PostProcessProfile;

		[Cpp2IlInjected.Token(Token = "0x60035D3")]
		[Cpp2IlInjected.Address(RVA = "0xA92A30", Offset = "0xA91430", VA = "0x180A92A30", Slot = "8")]
		public override Task<bool> CanExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			ConsumeConsummableTaskData taskData = task.GetTaskData<ConsumeConsummableTaskData>();
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			ConsumeItem.Types.Request _003CRequest_003Ek__BackingField = taskData.Request;
			Client metaClient3 = SystemRoot.Instance.MetaClient;
			ConsumeItem.Types.Result result = default(ConsumeItem.Types.Result);
			if (result != ConsumeItem.Types.Result.MemoryShardAlreadyCollected && result != ConsumeItem.Types.Result.CraftingRecipeAlreadyUnlocked)
			{
				return (Task<bool>)(object)base.CanExecuteAction(avatar, task, ct);
			}
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			Task<> task2 = Task.FromResult(result: false);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035D4")]
		[Cpp2IlInjected.Address(RVA = "0xA92E30", Offset = "0xA91830", VA = "0x180A92E30", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__3))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035D5")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public ConsumeConsummableAction()
		{
		}
	}
}
