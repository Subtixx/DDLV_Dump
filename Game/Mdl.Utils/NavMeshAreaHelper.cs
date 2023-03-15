using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Scene;
using Google.Protobuf.Collections;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000789")]
	public class NavMeshAreaHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200078A")]
		public struct StopNavMeshAgentScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002B37")]
			private readonly NavMeshAreaHelper navMeshAreaHelper;

			[Cpp2IlInjected.Token(Token = "0x170004AD")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6002187")]
				[Cpp2IlInjected.Address(RVA = "0x12054A0", Offset = "0x1203EA0", VA = "0x1812054A0")]
				get
				{
					bool result = default(bool);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002188")]
			[Cpp2IlInjected.Address(RVA = "0x1205470", Offset = "0x1203E70", VA = "0x181205470")]
			public StopNavMeshAgentScope(NavMeshAreaHelper navMeshAreaHelper)
			{
				//Discarded unreachable code: IL_000e
				this.navMeshAreaHelper = navMeshAreaHelper;
				navMeshAreaHelper.StopNavMeshAgent();
			}

			[Cpp2IlInjected.Token(Token = "0x6002189")]
			[Cpp2IlInjected.Address(RVA = "0x1205450", Offset = "0x1203E50", VA = "0x181205450", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B29")]
		public bool useDefaultCosts = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002B2A")]
		public float normalCost = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B2B")]
		public float waterCost = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002B2C")]
		public float roadCost = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B2D")]
		[SerializeField]
		private bool _canWalkOnLand = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4002B2E")]
		[SerializeField]
		private bool _canWalkInWater;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B2F")]
		[FormerlySerializedAs("_validAreaTypes")]
		public List<VillageAreaType> validAreaTypes = (List<VillageAreaType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B30")]
		private NavMeshAgent navMeshAgent;

		[Cpp2IlInjected.Token(Token = "0x4002B31")]
		public const int VillageAreaStart = 3;

		[Cpp2IlInjected.Token(Token = "0x4002B32")]
		public const int VillageAreaWaterStart = 11;

		[Cpp2IlInjected.Token(Token = "0x4002B33")]
		public const int VillageAreaRoadStart = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B34")]
		private int walkableArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002B35")]
		private int defaultMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002B36")]
		private int counter;

		[Cpp2IlInjected.Token(Token = "0x170004AA")]
		public bool CanWalkOnLand
		{
			[Cpp2IlInjected.Token(Token = "0x6002178")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return _canWalkOnLand;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AB")]
		public bool CanWalkInWater
		{
			[Cpp2IlInjected.Token(Token = "0x6002179")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return _canWalkInWater;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AC")]
		public int AreaMask
		{
			[Cpp2IlInjected.Token(Token = "0x600217A")]
			[Cpp2IlInjected.Address(RVA = "0xF02B50", Offset = "0xF01550", VA = "0x180F02B50")]
			get
			{
				//Discarded unreachable code: IL_000c
				return navMeshAgent.walkableMask;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600217B")]
		[Cpp2IlInjected.Address(RVA = "0xF025F0", Offset = "0xF00FF0", VA = "0x180F025F0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0072
			int num = (walkableArea = NavMesh.GetAreaFromName("Walkable"));
			NavMeshAgent navMeshAgent = (this.navMeshAgent = GetComponent<NavMeshAgent>());
			PlayerNavigation playerNavigation = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			PlayerNavigation playerNavigation2 = playerNavigation;
			if ((long)PlayerNavigation.s_actuallyMoveAvatar == 0)
			{
				Mdl.Systems.System.SystemEvent value = PlayerNavigationStarted;
				playerNavigation2.SystemStartedEvent += value;
			}
			else
			{
				Init();
			}
			[Cpp2IlInjected.Token(Token = "0x600218B")]
			[Cpp2IlInjected.Address(RVA = "0x12167F0", Offset = "0x12151F0", VA = "0x1812167F0")]
			void Init()
			{
				//Discarded unreachable code: IL_0087
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.VillageAreaUnlocked value2 = OnVillageAreaUnlocked;
				_003CDispatcher_003Ek__BackingField.OnVillageAreaUnlocked += value2;
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneStack.PreCurrentSceneChanged value3 = OnPreCurrentSceneChanged;
				sceneStack.OnPreCurrentSceneChanged += value3;
				NavMeshAreaHelper navMeshAreaHelper = this;
				SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				int num2 = 0;
				SetAreaCosts();
			}
			[Cpp2IlInjected.Token(Token = "0x600218C")]
			[Cpp2IlInjected.Address(RVA = "0x1216AC0", Offset = "0x12154C0", VA = "0x181216AC0")]
			void PlayerNavigationStarted(Mdl.Systems.System system)
			{
				//Discarded unreachable code: IL_0022
				PlayerNavigation playerNavigation3 = playerNavigation;
				Mdl.Systems.System.SystemEvent value4 = PlayerNavigationStarted;
				playerNavigation3.SystemStartedEvent -= value4;
				Init();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600217C")]
		[Cpp2IlInjected.Address(RVA = "0xF02030", Offset = "0xF00A30", VA = "0x180F02030")]
		private void OnPreCurrentSceneChanged(SceneData currentScene, SceneData nextScene)
		{
			//Discarded unreachable code: IL_000f, IL_001f
			defaultMask = 1;
			SetAreaMask();
		}

		[Cpp2IlInjected.Token(Token = "0x600217D")]
		[Cpp2IlInjected.Address(RVA = "0xF01CD0", Offset = "0xF006D0", VA = "0x180F01CD0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0082
			//IL_005b: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.VillageAreaUnlocked value = OnVillageAreaUnlocked;
					_003CDispatcher_003Ek__BackingField.OnVillageAreaUnlocked -= value;
				}
			}
			if ((object)SystemRoot.Instance != null)
			{
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneStack.PreCurrentSceneChanged value2 = OnPreCurrentSceneChanged;
				sceneStack.OnPreCurrentSceneChanged -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600217E")]
		[Cpp2IlInjected.Address(RVA = "0xF02080", Offset = "0xF00A80", VA = "0x180F02080")]
		private void OnVillageAreaUnlocked(VillageAreaType areaType, [System.Runtime.InteropServices.Optional] List<CurrencyCost> costs)
		{
			SetAreaMask();
		}

		[Cpp2IlInjected.Token(Token = "0x600217F")]
		[Cpp2IlInjected.Address(RVA = "0xF020C0", Offset = "0xF00AC0", VA = "0x180F020C0")]
		public void SetAreaCosts()
		{
			//Discarded unreachable code: IL_0061, IL_0067, IL_006d
			int num = 0;
			if ((useDefaultCosts ? 1 : 0) == num)
			{
				NavMeshAgent navMeshAgent = this.navMeshAgent;
				float areaCost = normalCost;
				int areaIndex = walkableArea;
				navMeshAgent.SetAreaCost(areaIndex, areaCost);
				MapField<int, Village.Types.VillageArea> areas_ = SystemRoot.Instance.MetaClient.profile.Village.areas_;
				bool flag = default(bool);
				if (flag)
				{
					NavMeshAgent navMeshAgent2 = this.navMeshAgent;
					NavMeshAgent navMeshAgent3 = this.navMeshAgent;
					NavMeshAgent navMeshAgent4 = this.navMeshAgent;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002180")]
		[Cpp2IlInjected.Address(RVA = "0xF01A70", Offset = "0xF00470", VA = "0x180F01A70")]
		public int GetRoadAreaMask()
		{
			//Discarded unreachable code: IL_003d
			int num = 0;
			if ((_canWalkOnLand ? 1 : 0) != num)
			{
				MapField<int, Village.Types.VillageArea> areas_ = SystemRoot.Instance.MetaClient.profile.Village.areas_;
				bool flag = default(bool);
				if (flag)
				{
					List<VillageAreaType> list = validAreaTypes;
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002181")]
		[Cpp2IlInjected.Address(RVA = "0xF02320", Offset = "0xF00D20", VA = "0x180F02320")]
		public void SetAreaMask()
		{
			//Discarded unreachable code: IL_005c, IL_0062, IL_0068
			//IL_0012: Expected O, but got I4
			int num = 0;
			NavMeshAgent navMeshAgent = this.navMeshAgent;
			int num2 = 0;
			if (navMeshAgent == (UnityEngine.Object)num2)
			{
				return;
			}
			int num3 = defaultMask;
			MapField<int, Village.Types.VillageArea> areas_ = SystemRoot.Instance.MetaClient.profile.Village.areas_;
			bool flag = default(bool);
			if (flag)
			{
				List<VillageAreaType> list = validAreaTypes;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				if (_canWalkOnLand)
				{
				}
				while (!_canWalkInWater)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002182")]
		[Cpp2IlInjected.Address(RVA = "0xF02830", Offset = "0xF01230", VA = "0x180F02830")]
		public static bool TryGetVillageAreaFromMask(int areaMask, out VillageAreaType villageArea)
		{
			//Discarded unreachable code: IL_003c, IL_0042, IL_0048
			//IL_0026: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			IEnumerator enumerator = Enum.GetValues(typeof(VillageAreaType)).GetEnumerator();
			if (enumerator != null)
			{
				IEnumerator enumerator2 = enumerator;
				villageArea.value__ = (int)enumerator2;
				num2++;
			}
			num2++;
			if (num2 != 0)
			{
			}
			if (num2 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002183")]
		[Cpp2IlInjected.Address(RVA = "0xF02800", Offset = "0xF01200", VA = "0x180F02800")]
		public void StopNavMeshAgent()
		{
			//Discarded unreachable code: IL_0017
			if (counter == 1)
			{
				navMeshAgent.isStopped = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002184")]
		[Cpp2IlInjected.Address(RVA = "0xF02090", Offset = "0xF00A90", VA = "0x180F02090")]
		public void ResumeNavMeshAgent()
		{
			//Discarded unreachable code: IL_0011, IL_0012
			NavMeshAgent navMeshAgent = this.navMeshAgent;
			int num = ((navMeshAgent.isStopped = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002185")]
		[Cpp2IlInjected.Address(RVA = "0xF027D0", Offset = "0xF011D0", VA = "0x180F027D0")]
		public StopNavMeshAgentScope StopAgentScope()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002186")]
		[Cpp2IlInjected.Address(RVA = "0xF02AB0", Offset = "0xF014B0", VA = "0x180F02AB0")]
		public NavMeshAreaHelper()
		{
		}
	}
}
