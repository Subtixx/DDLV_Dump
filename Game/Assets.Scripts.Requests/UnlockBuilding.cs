using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta;
using Meta.Online;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[Category("Mdl/Request")]
	[Icon("Dialogue", false, "")]
	[Description("Unlock a locked building.")]
	public class UnlockBuilding : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		[RequiredField]
		public BBParameter<ItemBuildingFiltering> building;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public BBParameter<string> parameter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public BBParameter<int> parameterHashID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private BBParameter<CancellationTokenSource> cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private Task<Meta.UnlockBuilding.Types.Response> response;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xD38AB0", Offset = "0xD374B0", VA = "0x180D38AB0", Slot = "13")]
		protected override void OnExecute()
		{
			//IL_0055: Expected I4, but got O
			//IL_00b0: Expected I4, but got O
			BBParameter<> bBParameter = (BBParameter<>)(object)(cts = (BBParameter<CancellationTokenSource>)(object)BBParameter<T>.op_Implicit((T)new CancellationTokenSource()));
			BBParameter<ItemBuildingFiltering> bBParameter2 = building;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = ((ItemBuildingFiltering)((BBParameter<T>)(object)bBParameter2).value).Item;
			IBuildingUnlockable itemData = _003CInstance_003Ek__BackingField.GetItemData<IBuildingUnlockable>(item);
			if (itemData != null)
			{
				Client metaClient = SystemRoot.Instance.MetaClient;
				Meta.UnlockBuilding.Types.Request request = new Meta.UnlockBuilding.Types.Request();
				request.buildingId_ = (int)request;
				request.unlock_ = true;
				CancellationToken token = ((CancellationTokenSource)((BBParameter<T>)(object)cts).value).Token;
				Task<Meta.UnlockBuilding.Types.Response> task = (Task<Meta.UnlockBuilding.Types.Response>)(object)metaClient.UnlockBuilding(request, token);
			}
			response = (Task<Meta.UnlockBuilding.Types.Response>)itemData;
			if (((BBParameter<T>)(object)parameter).value != null)
			{
				Animator animator = SystemRoot.Instance._avatar.Animator;
				int trigger = (int)((BBParameter<T>)(object)parameterHashID).value;
				animator.SetTrigger(trigger);
				return;
			}
			string trigger2 = default(string);
			SystemRoot.Instance._avatar.Animator.SetTrigger(trigger2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xD38FC0", Offset = "0xD379C0", VA = "0x180D38FC0", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_005f
			//IL_004c: Expected O, but got I4
			Task<Meta.UnlockBuilding.Types.Response> task = response;
			if (task == null || task.IsCompleted)
			{
				Task<Meta.UnlockBuilding.Types.Response> task2 = response;
				if (task2 != null && !((TransactionAction<TResult>)((Task<TResult>)(object)task2).Result).IsValid)
				{
					Meta.UnlockBuilding.Types.Result result_ = ((Meta.UnlockBuilding.Types.Response)((Task<TResult>)(object)response).Result).result_;
					Debug.LogError($"UnlockBuilding failed: {result_}");
				}
				EndAction(success: true);
			}
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xD38F50", Offset = "0xD37950", VA = "0x180D38F50", Slot = "16")]
		protected override void OnStop()
		{
			//Discarded unreachable code: IL_0017
			((object)this)._002Ector();
			((CancellationTokenSource)((BBParameter<T>)(object)cts).value).Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public UnlockBuilding()
		{
		}
	}
}
