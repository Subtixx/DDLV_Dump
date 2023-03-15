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
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[Category("Mdl/Request")]
	[Icon("Dialogue", false, "")]
	[Description("Upgrade a building (player pay for it)\nBuilding need to be unlocked and present in village first\nCastle and UrbanWishingWell are not supported")]
	public class UpgradeBuilding : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		[RequiredField]
		public BBParameter<ItemBuildingFiltering> building;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public BBParameter<string> parameter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public BBParameter<int> parameterHashID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private BBParameter<CancellationTokenSource> cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private Task<Meta.UpgradeBuilding.Types.Response> response;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xD3DCC0", Offset = "0xD3C6C0", VA = "0x180D3DCC0", Slot = "13")]
		protected override void OnExecute()
		{
			//IL_001b: Expected O, but got I4
			//IL_0107: Expected I4, but got O
			int num = 0;
			BBParameter<> bBParameter = (BBParameter<>)(object)(cts = (BBParameter<CancellationTokenSource>)(object)BBParameter<T>.op_Implicit((T)new CancellationTokenSource()));
			response = (Task<Meta.UpgradeBuilding.Types.Response>)num;
			ItemBuildingFiltering value = (ItemBuildingFiltering)((BBParameter<T>)(object)building).value;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Building && ((BBParameter<T>)(object)building).value == null && ((BBParameter<T>)(object)building).value == null)
			{
				Item item = ((ItemBuildingFiltering)((BBParameter<T>)(object)building).value).Item;
				IItemData itemData = default(IItemData);
				if (itemData != null)
				{
					Client client = default(Client);
					Profile profile = client.profile;
					if (client != null)
					{
						ProfileWorld world_ = profile.world_;
						bool flag = default(bool);
						if (!flag)
						{
							return;
						}
					}
					if (((BBParameter<T>)(object)building).value == null)
					{
						GridCollection gridCollection_ = profile.world_.gridCollection_;
						CancellationToken token = ((CancellationTokenSource)((BBParameter<T>)(object)cts).value).Token;
					}
					Client metaClient = SystemRoot.Instance.MetaClient;
					Item kitchenStall = BuildingItem.KitchenStall;
					CancellationToken token2 = ((CancellationTokenSource)((BBParameter<T>)(object)cts).value).Token;
					Task<Meta.UpgradeBuilding.Types.Response> task = default(Task<Meta.UpgradeBuilding.Types.Response>);
					response = task;
				}
				if (string.IsNullOrEmpty((string)((BBParameter<T>)(object)parameter).value))
				{
					int num2 = 0;
					int trigger = (int)((BBParameter<T>)(object)parameterHashID).value;
					Animator animator = default(Animator);
					animator.SetTrigger(trigger);
					return;
				}
				int num3 = 0;
				string value2 = (string)((BBParameter<T>)(object)parameter).value;
				Animator animator2 = default(Animator);
				animator2.SetTrigger(value2);
			}
			ItemBuildingFiltering value3 = (ItemBuildingFiltering)((BBParameter<T>)(object)building).value;
			Debug.LogError($"UpgradeBuilding: {value3} is not supported");
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xD3E570", Offset = "0xD3CF70", VA = "0x180D3E570", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_005f
			//IL_004c: Expected O, but got I4
			Task<Meta.UpgradeBuilding.Types.Response> task = response;
			if (task == null || task.IsCompleted)
			{
				Task<Meta.UpgradeBuilding.Types.Response> task2 = response;
				if (task2 != null && !((TransactionAction<TResult>)((Task<TResult>)(object)task2).Result).IsValid)
				{
					Meta.UpgradeBuilding.Types.Result result_ = ((Meta.UpgradeBuilding.Types.Response)((Task<TResult>)(object)response).Result).result_;
					Debug.LogError($"UpgradeBuilding failed: {result_}");
				}
				EndAction(success: true);
			}
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xD3E500", Offset = "0xD3CF00", VA = "0x180D3E500", Slot = "16")]
		protected override void OnStop()
		{
			//Discarded unreachable code: IL_0017
			((object)this)._002Ector();
			((CancellationTokenSource)((BBParameter<T>)(object)cts).value).Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public UpgradeBuilding()
		{
		}
	}
}
