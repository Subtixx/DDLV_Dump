using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B64")]
	public class Sapling : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003F4C")]
		private GardeningSlot gardeningSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003F4D")]
		private GridObjectScript gridObjectScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003F4E")]
		private bool inVillage;

		[Cpp2IlInjected.Token(Token = "0x60034BB")]
		[Cpp2IlInjected.Address(RVA = "0xCC7090", Offset = "0xCC5A90", VA = "0x180CC7090")]
		private void Start()
		{
			//Discarded unreachable code: IL_0051
			//IL_0046: Expected O, but got I4
			GardeningSlot gardeningSlot = (this.gardeningSlot = GetComponentInParent<GardeningSlot>());
			GridObjectScript gridObjectScript = (this.gridObjectScript = this.gardeningSlot.GetComponentInParent<GridObjectScript>());
			int handle = base.gameObject.scene.m_Handle;
			GameObject gameObject = default(GameObject);
			VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
			int num = 0;
			bool flag = (inVillage = component != (UnityEngine.Object)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60034BC")]
		[Cpp2IlInjected.Address(RVA = "0xCC6C90", Offset = "0xCC5690", VA = "0x180CC6C90")]
		public void Init(GardenData.Types.GardeningSlot gardeningSlot, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0077
			SaplingGrowthData sapling = gardeningSlot.Sapling;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item plantedSeedItem = gardeningSlot.PlantedSeedItem;
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			Client metaClient = SystemRoot.Instance.MetaClient;
			bool flag = inVillage;
			Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = metaClient.TransactionContext;
			int num = 0;
			SeedItemData seedItemData = default(SeedItemData);
			DateTime endOfGrowthTime = sapling.GetEndOfGrowthTime(seedItemData, world_, _003CTransactionContext_003Ek__BackingField, flag);
			DateTime maxValue = DateTime.MaxValue;
			if (endOfGrowthTime < maxValue)
			{
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034BD")]
		[Cpp2IlInjected.Address(RVA = "0xCC71D0", Offset = "0xCC5BD0", VA = "0x180CC71D0")]
		[AsyncStateMachine(typeof(_003CWaitForEndOfGrowth_003Ed__5))]
		private Task WaitForEndOfGrowth(DateTime endOfGrowthTimestamp, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034BE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public Sapling()
		{
		}
	}
}
