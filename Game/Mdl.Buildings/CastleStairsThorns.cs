using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Navigation;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x2000986")]
	public class CastleStairsThorns : MonoBehaviour, IPlayerTaskProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400347E")]
		[SerializeField]
		private PlayerTaskDefinition _upgradeBuildingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400347F")]
		[SerializeField]
		private UpgradeBuildingData _upgradeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003480")]
		[SerializeField]
		private NavMeshObstacle _navObstacle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003481")]
		private bool _hasBeenUpgraded;

		[Cpp2IlInjected.Token(Token = "0x6002C70")]
		[Cpp2IlInjected.Address(RVA = "0x12D87F0", Offset = "0x12D71F0", VA = "0x1812D87F0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0055
			//IL_0017: Expected O, but got I4
			UpgradeBuildingData upgradeData = _upgradeData;
			_hasBeenUpgraded = false;
			int num = 0;
			if (upgradeData != (UnityEngine.Object)num)
			{
				UpgradeBuildingData upgradeData2 = _upgradeData;
				UpgradeBuildingData.BuildingUpgrade value = OnBuildingUpgrade;
				upgradeData2.OnBuildingUpgrade -= value;
				UpgradeBuildingData upgradeData3 = _upgradeData;
				UpgradeBuildingData.BuildingUpgrade value2 = OnBuildingUpgrade;
				upgradeData3.OnBuildingUpgrade += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C71")]
		[Cpp2IlInjected.Address(RVA = "0x12D8690", Offset = "0x12D7090", VA = "0x1812D8690")]
		private void OnBuildingUpgrade()
		{
			//Discarded unreachable code: IL_002b
			//IL_0017: Expected O, but got I4
			NavMeshObstacle navObstacle = _navObstacle;
			_hasBeenUpgraded = true;
			int num = 0;
			if (navObstacle != (UnityEngine.Object)num)
			{
				NavMeshObstacle navObstacle2 = _navObstacle;
				int num2 = ((navObstacle2.enabled = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C72")]
		[Cpp2IlInjected.Address(RVA = "0x12D8620", Offset = "0x12D7020", VA = "0x1812D8620", Slot = "4")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__6))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__6(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C73")]
		[Cpp2IlInjected.Address(RVA = "0x12D8720", Offset = "0x12D7120", VA = "0x1812D8720")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_002f
			//IL_0010: Expected O, but got I4
			UpgradeBuildingData upgradeData = _upgradeData;
			int num = 0;
			if (upgradeData != (UnityEngine.Object)num)
			{
				UpgradeBuildingData upgradeData2 = _upgradeData;
				UpgradeBuildingData.BuildingUpgrade value = OnBuildingUpgrade;
				upgradeData2.OnBuildingUpgrade -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C74")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CastleStairsThorns()
		{
		}
	}
}
