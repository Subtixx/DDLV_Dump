using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008BE")]
	internal class WaterSpawn : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030F6")]
		[SerializeField]
		public VillageAreaType VillageArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030F7")]
		[SerializeField]
		public WaterSpawnConfig Config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030F8")]
		[SerializeField]
		[ItemID]
		private List<int> _conditionsItems = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x600285F")]
		[Cpp2IlInjected.Address(RVA = "0xD4E100", Offset = "0xD4CB00", VA = "0x180D4E100")]
		private void Awake()
		{
			//IL_0010: Expected O, but got I4
			WaterSpawnConfig config = Config;
			int num = 0;
			if (config == (UnityEngine.Object)num)
			{
				WaterSpawnConfig waterSpawnConfig = (Config = ScriptableObject.CreateInstance<WaterSpawnConfig>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002860")]
		[Cpp2IlInjected.Address(RVA = "0xD4E190", Offset = "0xD4CB90", VA = "0x180D4E190")]
		public bool IsAvailable()
		{
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			VillageAreaType villageArea = VillageArea;
			if (world_.IsVillageAreaUnlocked(villageArea) && AllConditionsAreTrue())
			{
				CharacterManager characterManager = default(CharacterManager);
				CharacterSpawnTracker spawnCounts = characterManager.SpawnCounts;
				WaterSpawnConfig config = Config;
				int num = spawnCounts.CountFor(config);
				WaterSpawnConfig config2 = Config;
				return num < config2.MaxNumberOfSpawns;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002861")]
		[Cpp2IlInjected.Address(RVA = "0xD4DF50", Offset = "0xD4C950", VA = "0x180D4DF50")]
		public bool AllConditionsAreTrue()
		{
			//IL_005c: Expected O, but got I4
			int num = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Mdl.Online.Client client = _003CInstance_003Ek__BackingField.Client;
				if ((object)client != null && client.MetaClient == null)
				{
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			Meta.Online.Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = default(Meta.Online.Client.ClientTransactionContext);
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				Mdl.Online.Client client2 = _003CInstance_003Ek__BackingField2.Client;
				if ((object)client2 != null)
				{
					Meta.Online.Client _003CMetaClient_003Ek__BackingField = client2.MetaClient;
					if (_003CMetaClient_003Ek__BackingField != null)
					{
						_003CTransactionContext_003Ek__BackingField = _003CMetaClient_003Ek__BackingField.TransactionContext;
					}
				}
			}
			return ConditionItemData.Evaluate((IEnumerable<>)_conditionsItems, (IProfile)num, (ITransactionContext)_003CTransactionContext_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x6002862")]
		[Cpp2IlInjected.Address(RVA = "0xD4E310", Offset = "0xD4CD10", VA = "0x180D4E310")]
		public WaterSpawn()
		{
		}
	}
}
