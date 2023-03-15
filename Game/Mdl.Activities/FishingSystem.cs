using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B46")]
	public class FishingSystem : Mdl.Systems.System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003EBE")]
		public AssetReference FishingMenuPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003EBF")]
		public Transform MiniGameCharacterPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003EC0")]
		public float SpectatorMinTeleportDistance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4003EC1")]
		public float SpectatorBehindCameraTeleportDistance = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003EC2")]
		public float SpectatorBehindCameraTeleportLateralDistance = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4003EC3")]
		public float NearbyCharactersDistanceThreshold = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003EC4")]
		public float NearbyCharactersMoodDuration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003EC5")]
		public string NearbyCharactersVictoryMood = "Celebrate";

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003EC6")]
		public string NearbyCharactersDefeatMood = "Sad";

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003EC7")]
		public FishingMiniGame MiniGame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003EC8")]
		private BodyOfWater[] bodiesOfWater;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003EC9")]
		private Task<bool> fishTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003ECA")]
		private List<(uint pendingFishID, PendingFish pendingFish)> pendingFishesHeldByFishing = (List<(uint pendingFishID, PendingFish pendingFish)>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003ECB")]
		[SerializeField]
		private float spectatorDistance = 1f;

		[Cpp2IlInjected.Token(Token = "0x17000717")]
		public bool FishingInProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600342A")]
			[Cpp2IlInjected.Address(RVA = "0x137D420", Offset = "0x137BE20", VA = "0x18137D420")]
			get
			{
				bool flag = default(bool);
				if ((object)this == null || flag)
				{
					int num = 0;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600342B")]
		[Cpp2IlInjected.Address(RVA = "0x137A790", Offset = "0x1379190", VA = "0x18137A790")]
		internal Task<bool> Fish(StartFishing.Types.Request startFishingRequest, Vector3 origin, FishRipple fishRipple, FishingRod fishingRod, CancellationToken ct)
		{
			float z = origin.z;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> task = default(Task<>);
			fishTask = (Task<bool>)(object)task;
			return fishTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600342C")]
		[Cpp2IlInjected.Address(RVA = "0x137A5F0", Offset = "0x1378FF0", VA = "0x18137A5F0")]
		[AsyncStateMachine(typeof(_003CFishTask_003Ed__17))]
		private Task<bool> FishTask(StartFishing.Types.Request startFishingRequest, Vector3 origin, FishRipple fishRipple, FishingRod fishingRod, CancellationToken ct)
		{
			float z = origin.z;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600342D")]
		[Cpp2IlInjected.Address(RVA = "0x137CEA0", Offset = "0x137B8A0", VA = "0x18137CEA0")]
		private void UpdateHangoutRewardPosition(Vector3 origin)
		{
			//IL_0014: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			HangoutSystem system = SystemRoot.Instance.GetSystem<HangoutSystem>();
			int num = 0;
			if (system != (UnityEngine.Object)num)
			{
				Mdl.Characters.Character character = system.Character;
				int num2 = 0;
				if (character != (UnityEngine.Object)num2)
				{
					Transform _003Ctransform_003Ek__BackingField = avatar.transform;
					Transform miniGameCharacterPosition = MiniGameCharacterPosition;
					Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					float z2 = origin.z;
					return;
				}
			}
			Transform _003Ctransform_003Ek__BackingField3 = avatar.transform;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600342E")]
		[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
		internal IEnumerable<BodyOfWater> GetBodiesOfWater()
		{
			BodyOfWater[] array = bodiesOfWater;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600342F")]
		[Cpp2IlInjected.Address(RVA = "0x137AB30", Offset = "0x1379530", VA = "0x18137AB30")]
		internal unsafe IEnumerable<BodyOfWater> GetBodiesOfWater(VillageAreaType villageAreaType)
		{
			//Discarded unreachable code: IL_002b
			BodyOfWater[] array = bodiesOfWater;
			Func<BodyOfWater, bool> func = (Func<BodyOfWater, bool>)(object)(Func<T, TResult>)((BodyOfWater x) => (IntPtr)(void*)x.VillageArea == (IntPtr)(void*)(int)villageAreaType);
			return (IEnumerable<BodyOfWater>)Enumerable.Where<BodyOfWater>((IEnumerable<>)(object)array, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6003430")]
		[Cpp2IlInjected.Address(RVA = "0x137A950", Offset = "0x1379350", VA = "0x18137A950")]
		private unsafe static IEnumerable<BodyOfWater> GetAvailableFishingLocations(IEnumerable<BodyOfWater> bodiesOfWater, PendingFish pendingFish)
		{
			switch (pendingFish.location_.locationTypeCase_)
			{
			case ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea:
			{
				Func<BodyOfWater, bool> func = (Func<BodyOfWater, bool>)(object)(Func<T, TResult>)delegate(BodyOfWater x)
				{
					//Discarded unreachable code: IL_002e
					PendingFish pendingFish2 = pendingFish;
					VillageAreaType? _003CVillageArea_003Ek__BackingField = x.VillageArea;
					VillageAreaType villageArea = pendingFish2.location_.VillageArea;
					bool flag = (IntPtr)(void*)_003CVillageArea_003Ek__BackingField == (IntPtr)(void*)(int)villageArea;
					if ((IntPtr)(void*)_003CVillageArea_003Ek__BackingField == (IntPtr)(flag ? 1 : 0))
					{
						int num3 = 0;
					}
					return IsValidFishingLocation(x);
				};
				return (IEnumerable<BodyOfWater>)Enumerable.Where<BodyOfWater>((IEnumerable<>)bodiesOfWater, (Func<, >)(object)func);
			}
			default:
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x600345D")]
			[Cpp2IlInjected.Address(RVA = "0x11E7B20", Offset = "0x11E6520", VA = "0x1811E7B20")]
			bool IsValidFishingLocation(BodyOfWater bodyOfWater)
			{
				//IL_0010: Expected O, but got I4
				GameObject _003CRipple_003Ek__BackingField = bodyOfWater.Ripple;
				int num = 0;
				if (_003CRipple_003Ek__BackingField == (UnityEngine.Object)num)
				{
					int forcedFishingDataItemID_ = pendingFish.forcedFishingDataItemID_;
					FishingDataItemData fishingData = bodyOfWater.FishingData;
					if (fishingData != null)
					{
					}
					if ((IntPtr)forcedFishingDataItemID_ == (IntPtr)fishingData)
					{
						return bodyOfWater.AreConditionsTrue();
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003431")]
		[Cpp2IlInjected.Address(RVA = "0x137CCC0", Offset = "0x137B6C0", VA = "0x18137CCC0")]
		private void SuccessFishingSFX()
		{
			//Discarded unreachable code: IL_0015
			SystemRoot.Instance._avatar.AudioController.PostSuccessFishingSFX();
		}

		[Cpp2IlInjected.Token(Token = "0x6003432")]
		[Cpp2IlInjected.Address(RVA = "0x137C550", Offset = "0x137AF50", VA = "0x18137C550", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_005e
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneStack.CurrentSceneChanged value = OnCurrentSceneChanged;
			sceneStack.OnCurrentSceneChanged += value;
			CancellationToken cancellationToken = this.GetOrAddComponent<CancellationTokenProvider>().CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			SystemEvent value2 = OnGridEditModeStopped;
			system.SystemStoppedEvent += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003433")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003434")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003435")]
		[Cpp2IlInjected.Address(RVA = "0x137C8A0", Offset = "0x137B2A0", VA = "0x18137C8A0", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_00a8
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneStack.CurrentSceneChanged value = OnCurrentSceneChanged;
				sceneStack.OnCurrentSceneChanged -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.PendingFishAdded value2 = OnPendingFishAdded;
				_003CDispatcher_003Ek__BackingField.OnPendingFishAdded -= value2;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.PendingFishRemoved value3 = OnPendingFishRemoved;
				_003CDispatcher_003Ek__BackingField2.OnPendingFishRemoved -= value3;
				GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
				SystemEvent value4 = OnGridEditModeStopped;
				system.SystemStoppedEvent -= value4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003436")]
		[Cpp2IlInjected.Address(RVA = "0x137AC10", Offset = "0x1379610", VA = "0x18137AC10")]
		private unsafe void OnCurrentSceneChanged(SceneData scene)
		{
			//Discarded unreachable code: IL_010b, IL_0126, IL_013b, IL_0143, IL_015c, IL_016c, IL_0174, IL_0179, IL_017e, IL_0187, IL_018b, IL_019a, IL_01ad, IL_01b2
			//IL_0020: Expected native int or pointer, but got O
			//IL_0033: Expected native int or pointer, but got O
			//IL_00c0: Expected O, but got I4
			//IL_00c9: Expected I4, but got I8
			//IL_0114: Expected I4, but got I8
			int num = 0;
			_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0();
			AsyncOperation operation = scene.sceneInstance.m_Operation;
			((SceneInstance*)(IntPtr)CS_0024_003C_003E8__locals0.scene.sceneInstance)->m_Operation = operation;
			CameraNavigationConfig editCameraConfig = scene.EditCameraConfig;
			((SceneData*)(IntPtr)CS_0024_003C_003E8__locals0.scene)->EditCameraConfig = editCameraConfig;
			if ((long)num < (long)(IntPtr)CS_0024_003C_003E8__locals0)
			{
				num++;
			}
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.PendingFishAdded value = OnPendingFishAdded;
			_003CDispatcher_003Ek__BackingField.OnPendingFishAdded -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.PendingFishRemoved value2 = OnPendingFishRemoved;
			_003CDispatcher_003Ek__BackingField2.OnPendingFishRemoved -= value2;
			SceneData scene2 = CS_0024_003C_003E8__locals0.scene;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<OffGridBuildingItemData, bool> cpp2il__autoParamName__idx_ = (Func<OffGridBuildingItemData, bool>)(object)(Func<T, TResult>)delegate(OffGridBuildingItemData x)
			{
				//Discarded unreachable code: IL_0016
				CameraNavigationConfig cameraConfig = CS_0024_003C_003E8__locals0.scene.CameraConfig;
				return (IntPtr)x.scene_ == (IntPtr)cameraConfig;
			};
			IEnumerable<> cpp2il__autoParamName__idx_2 = default(IEnumerable<>);
			if (!cpp2il__autoParamName__idx_2.Any<OffGridBuildingItemData>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				bodiesOfWater = (BodyOfWater[])num;
			}
			GameObject gameObject = default(GameObject);
			ulong num2 = default(ulong);
			BodyOfWater[] array = (bodiesOfWater = gameObject.GetComponentsInChildren<BodyOfWater>((byte)num2 != 0));
			if (num < array.Length)
			{
				BodyOfWater bodyOfWater = array[num];
				SceneData scene3 = CS_0024_003C_003E8__locals0.scene;
				Item _003CSceneItem_003Ek__BackingField = default(Item);
				bodyOfWater.SceneItem = _003CSceneItem_003Ek__BackingField;
				num++;
			}
			EventHandler value3 = default(EventHandler);
			gameObject.GetComponent<Mdl.Environments.Environment>().EnvironmentEnteredEvent += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6003437")]
		[Cpp2IlInjected.Address(RVA = "0x137B5E0", Offset = "0x1379FE0", VA = "0x18137B5E0")]
		private void OnEnteredValidEnvironment(object sender, EventArgs e)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003438")]
		[Cpp2IlInjected.Address(RVA = "0x137C180", Offset = "0x137AB80", VA = "0x18137C180")]
		private void OnPendingFishAdded(uint pendingFishID, PendingFish pendingFish)
		{
			//Discarded unreachable code: IL_006e, IL_0074, IL_007a
			//IL_0028: Expected O, but got I4
			int num = 0;
			BodyOfWater[] array = bodiesOfWater;
			if (array == null)
			{
				return;
			}
			Task<bool> task = fishTask;
			if (task != null)
			{
				if (!task.IsCompleted)
				{
					goto IL_004b;
				}
				fishTask = (Task<bool>)num;
			}
			if (FishingSystem.GetAvailableFishingLocations((IEnumerable<>)(object)array, pendingFish) != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_004f;
					}
					num++;
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				num++;
				goto IL_004b;
			}
			goto IL_004f;
			IL_004f:
			if (num + 1 != 0)
			{
			}
			Item arg = default(Item);
			Debug.LogError($"FISHING: Failed to spawn the specific fish {arg}");
			throw new NullReferenceException();
			IL_004b:
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003439")]
		[Cpp2IlInjected.Address(RVA = "0x137C4D0", Offset = "0x137AED0", VA = "0x18137C4D0")]
		private void OnPendingFishRemoved(uint pendingFishID)
		{
			//Discarded unreachable code: IL_0029
			BodyOfWater[] array = bodiesOfWater;
			int num = 0;
			int length = array.Length;
			if (num < length && !array[num].RemoveFish(pendingFishID))
			{
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600343A")]
		[Cpp2IlInjected.Address(RVA = "0x137BD50", Offset = "0x137A750", VA = "0x18137BD50")]
		private unsafe void OnGridEditModeStopped(Mdl.Systems.System system)
		{
			//Discarded unreachable code: IL_00ff, IL_0105, IL_010b, IL_0111, IL_0117, IL_011d
			//IL_005b: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_00f3: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if ((IntPtr)bodiesOfWater == (IntPtr)num3)
			{
				return;
			}
			List<uint> list = (List<uint>)(object)new List<T>();
			BodyOfWater[] array = bodiesOfWater;
			int length = array.Length;
			if (num < length)
			{
				BodyOfWater bodyOfWater = array[num];
				if (!bodyOfWater.FishRippleIsInvalid(out *(uint*)num))
				{
					GameObject _003CRipple_003Ek__BackingField = bodyOfWater.Ripple;
					int num4 = 0;
					if (!(_003CRipple_003Ek__BackingField != (UnityEngine.Object)num4))
					{
						goto IL_00d3;
					}
					FishRipple component = bodyOfWater.Ripple.GetComponent<FishRipple>();
					int visible = 0;
					component.ToggleHiddenVFX((byte)visible != 0);
					num++;
				}
				Client client = default(Client);
				PendingFish pendingFish = (PendingFish)((MapField<TKey, TValue>)(object)client.profile.world_.pendingFishes_)[(TKey)num];
				if ((pendingFish.isSpecific_ ? 1 : 0) == num)
				{
					bool flag = bodyOfWater.RemoveFish((uint)num);
					if (bodyOfWater.AddFish((uint)num, pendingFish))
					{
						goto IL_00d3;
					}
					((List<T>)(object)list).Add((T)num);
					num++;
				}
				bodyOfWater.Ripple.GetComponent<FishRipple>().ToggleHiddenVFX(visible: true);
				goto IL_00d3;
			}
			goto IL_00d7;
			IL_00d3:
			num++;
			goto IL_00d7;
			IL_00d7:
			bool flag2 = default(bool);
			if (flag2)
			{
				Client client2 = default(Client);
				PendingFish pendingFish2 = (PendingFish)((MapField<TKey, TValue>)(object)client2.profile.world_.pendingFishes_)[(TKey)num3];
				OnPendingFishAdded((uint)num3, pendingFish2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600343B")]
		[Cpp2IlInjected.Address(RVA = "0x137D210", Offset = "0x137BC10", VA = "0x18137D210")]
		[AsyncStateMachine(typeof(_003CUpdatePendingFishes_003Ed__32))]
		private Task UpdatePendingFishes(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600343C")]
		[Cpp2IlInjected.Address(RVA = "0x137D330", Offset = "0x137BD30", VA = "0x18137D330")]
		public FishingSystem()
		{
		}
	}
}
