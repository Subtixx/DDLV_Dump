using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Activities;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Systems;
using Mdl.Utils;
using Mdl.Utils.EQ;
using Meta;
using Meta.Grids;
using Meta.Online;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000AB3")]
	internal class Pickaxe : Tool
	{
		[Cpp2IlInjected.Token(Token = "0x2000AB4")]
		private class IsValidTargetForPickaxe : EnvironmentQuery.TestComponent<Collider>
		{
			[Cpp2IlInjected.Token(Token = "0x4003B04")]
			private static readonly ProfilerMarker s_Test_IsValidPickaxeTarget_MiningRock;

			[Cpp2IlInjected.Token(Token = "0x4003B05")]
			private static readonly ProfilerMarker s_Test_IsValidPickaxeTarget_Blocker;

			[Cpp2IlInjected.Token(Token = "0x170006DF")]
			public override float Cost
			{
				[Cpp2IlInjected.Token(Token = "0x6003164")]
				[Cpp2IlInjected.Address(RVA = "0x1691F90", Offset = "0x1690990", VA = "0x181691F90", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6003165")]
			[Cpp2IlInjected.Address(RVA = "0x1691CB0", Offset = "0x16906B0", VA = "0x181691CB0", Slot = "7")]
			protected override (bool, float) FilterAndScoreComponent(GameObject queryObject, Vector3 queryPosition, GameObject gameObject, Collider collider, Vector3 position)
			{
				Transform transform = queryObject.transform;
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6003166")]
			[Cpp2IlInjected.Address(RVA = "0x1691F20", Offset = "0x1690920", VA = "0x181691F20")]
			public IsValidTargetForPickaxe()
			{
				((EnvironmentQuery.TestComponent<T>)(object)this)._002Ector();
			}

			[Cpp2IlInjected.Token(Token = "0x6003167")]
			[Cpp2IlInjected.Address(RVA = "0x1691E60", Offset = "0x1690860", VA = "0x181691E60")]
			static IsValidTargetForPickaxe()
			{
				//IL_0021: Expected O, but got I
				//IL_003c: Expected O, but got I
				int num = 0;
				int flags = 0;
				int metadataCount = 0;
				ushort categoryId = default(ushort);
				IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("FilterAndScore.IsValidMiningRock", categoryId, (MarkerFlags)flags, metadataCount);
				int num2 = 0;
				s_Test_IsValidPickaxeTarget_MiningRock = (ProfilerMarker)(long)intPtr;
				int flags2 = 0;
				int metadataCount2 = 0;
				ushort categoryId2 = default(ushort);
				s_Test_IsValidPickaxeTarget_Blocker = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("FilterAndScore.IsValidBlocker", categoryId2, (MarkerFlags)flags2, metadataCount2);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003AF1")]
		public float hitRadius = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4003AF2")]
		public float moveDuration = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003AF3")]
		public float minDistanceToRock = 1.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4003AF4")]
		public float maxDistanceToRock = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4003AF5")]
		public GameObject trailVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003AF6")]
		public GameObject hitVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003AF7")]
		public AK.Wwise.Event hitSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003AF8")]
		public AssetReferenceGameObject buffedTrailVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4003AF9")]
		public AssetReferenceGameObject buffedHitVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4003AFA")]
		public GameObject audioEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4003AFB")]
		private AnimationEventDispatcher animationEventDispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4003AFC")]
		private TaskCompletionSource<bool> miningHitTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4003AFD")]
		private bool buffedMiningHit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4003AFE")]
		private EnvironmentQuery eqFindMinableRock = new EnvironmentQuery();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4003AFF")]
		[SerializeField]
		private float miningHitTrauma = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4003B00")]
		public float eqDistance = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4003B01")]
		public float eqWeightDistance = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4003B02")]
		public float eqWeightDirection = 1f;

		[Cpp2IlInjected.Token(Token = "0x4003B03")]
		private static readonly TimeSpan timeOutDuration;

		[Cpp2IlInjected.Token(Token = "0x170006DE")]
		public override Toolbox.ToolType ToolType
		{
			[Cpp2IlInjected.Token(Token = "0x6003155")]
			[Cpp2IlInjected.Address(RVA = "0xF12970", Offset = "0xF11370", VA = "0x180F12970", Slot = "8")]
			get
			{
				return Toolbox.ToolType.Pickaxe;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003156")]
		[Cpp2IlInjected.Address(RVA = "0xF12130", Offset = "0xF10B30", VA = "0x180F12130", Slot = "5")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_0100
			//IL_0016: Expected O, but got I4
			base.Start();
			PlayerAvatar componentInParent = GetComponentInParent<PlayerAvatar>();
			int num = 0;
			if (componentInParent != (UnityEngine.Object)num)
			{
				AnimationEventDispatcher animationEventDispatcher = (this.animationEventDispatcher = componentInParent.GetComponentInChildren<AnimationEventDispatcher>());
				AnimationEventDispatcher animationEventDispatcher2 = this.animationEventDispatcher;
				AnimationEventDispatcher.AnimationEventHandler value = OnAvatarAnimationEvent;
				animationEventDispatcher2.AnimationEvent += value;
			}
			bool enableDebugLog = EnableDebugLog;
			EnvironmentQuery environmentQuery = eqFindMinableRock;
			SphereCastGenerator sphereCastGenerator = new SphereCastGenerator();
			int layerMask = 0;
			float num2 = (sphereCastGenerator.Distance = eqDistance);
			float num3 = (sphereCastGenerator.Radius = hitRadius);
			sphereCastGenerator.OnNavMesh = false;
			sphereCastGenerator.LayerMask = layerMask;
			environmentQuery.AddGenerator(sphereCastGenerator);
			EnvironmentQuery environmentQuery2 = eqFindMinableRock;
			IsValidTargetForPickaxe filter = new IsValidTargetForPickaxe();
			environmentQuery2.AddFilter(filter);
			EnvironmentQuery environmentQuery3 = eqFindMinableRock;
			float weight = eqWeightDistance;
			TestDistanceToQuerier testDistanceToQuerier = new TestDistanceToQuerier();
			float num4 = (testDistanceToQuerier.MaxDistance = eqDistance);
			environmentQuery3.AddTest(weight, testDistanceToQuerier);
			EnvironmentQuery environmentQuery4 = eqFindMinableRock;
			TestDirectionToQuerier test = new TestDirectionToQuerier();
			environmentQuery4.AddTest(weight, test);
		}

		[Cpp2IlInjected.Token(Token = "0x6003157")]
		[Cpp2IlInjected.Address(RVA = "0xF12050", Offset = "0xF10A50", VA = "0x180F12050", Slot = "6")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0035
			//IL_0016: Expected O, but got I4
			base.OnDestroy();
			AnimationEventDispatcher animationEventDispatcher = this.animationEventDispatcher;
			int num = 0;
			if (animationEventDispatcher != (UnityEngine.Object)num)
			{
				AnimationEventDispatcher animationEventDispatcher2 = this.animationEventDispatcher;
				AnimationEventDispatcher.AnimationEventHandler value = OnAvatarAnimationEvent;
				animationEventDispatcher2.AnimationEvent -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003158")]
		[Cpp2IlInjected.Address(RVA = "0xF11AB0", Offset = "0xF104B0", VA = "0x180F11AB0")]
		private static bool IsValidMiningRock(Collider collider)
		{
			Mdl.Activities.MiningRock component = collider.GetComponent<Mdl.Activities.MiningRock>();
			if ((object)component != null && component.Data != null)
			{
				Meta.MiningRock data = component.Data;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
				return data.IsFull(_003CTransactionContext_003Ek__BackingField);
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003159")]
		[Cpp2IlInjected.Address(RVA = "0xF119D0", Offset = "0xF103D0", VA = "0x180F119D0")]
		private static bool IsValidBlocker(Collider collider)
		{
			//IL_0010: Expected O, but got I4
			ItemScript component = collider.GetComponent<ItemScript>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				int itemID = component.Item.ItemID;
				bool result = default(bool);
				return result;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600315A")]
		[Cpp2IlInjected.Address(RVA = "0xF11720", Offset = "0xF10120", VA = "0x180F11720", Slot = "10")]
		public override (IEnumerable<GameObject>, IEnumerable<Vector3>) GetToolPreview(PlayerAvatar avatar)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600315B")]
		[Cpp2IlInjected.Address(RVA = "0xF126D0", Offset = "0xF110D0", VA = "0x180F126D0", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUseTool_003Ed__26))]
		protected override Task<bool> UseTool(PlayerAvatar avatar)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600315C")]
		[Cpp2IlInjected.Address(RVA = "0xF11CE0", Offset = "0xF106E0", VA = "0x180F11CE0")]
		[AsyncStateMachine(typeof(_003CMoveAvatarIntoPosition_003Ed__27))]
		private Task MoveAvatarIntoPosition(PlayerAvatar avatar, Collider collider)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600315D")]
		[Cpp2IlInjected.Address(RVA = "0xF12560", Offset = "0xF10F60", VA = "0x180F12560")]
		[AsyncStateMachine(typeof(_003CUseToolForBlocker_003Ed__28))]
		private Task<bool> UseToolForBlocker(PlayerAvatar avatar, Collider collider, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600315E")]
		[Cpp2IlInjected.Address(RVA = "0xF115E0", Offset = "0xF0FFE0", VA = "0x180F115E0")]
		private Task DelayAndRemoveBlocker(Collider collider, CancellationToken ct)
		{
			//Discarded unreachable code: IL_003a
			GridObjectScript component = collider.GetComponent<GridObjectScript>();
			Transform transform = collider.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			uint gridID = component.GridScript.GridID;
			GridObject _003CGridObject_003Ek__BackingField = component.GridObject;
			RewardSpawnAnimationData rewardSpawnAnimationDataOverride = component.GetComponent<Blocker>().rewardSpawnAnimationDataOverride;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600315F")]
		[Cpp2IlInjected.Address(RVA = "0xF11E20", Offset = "0xF10820", VA = "0x180F11E20")]
		private void OnAvatarAnimationEvent(string eventName, AnimationEventDispatcher.AnimationEventArgs args)
		{
			//Discarded unreachable code: IL_0049
			//IL_0046: Expected O, but got I4
			if (eventName != null && "miningHit" != null)
			{
				AK.Wwise.Event @event = hitSFX;
				GameObject gameObject = audioEmitter;
				uint num = @event.Post(gameObject);
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				TaskCompletionSource<bool> taskCompletionSource = miningHitTCS;
				if (taskCompletionSource != null)
				{
					bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)1);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003160")]
		[Cpp2IlInjected.Address(RVA = "0xF11BE0", Offset = "0xF105E0", VA = "0x180F11BE0")]
		[AsyncStateMachine(typeof(_003CMiningHitTCSTimeout_003Ed__32))]
		private static Task MiningHitTCSTimeout(TaskCompletionSource<bool> tcs)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003161")]
		[Cpp2IlInjected.Address(RVA = "0xF12880", Offset = "0xF11280", VA = "0x180F12880")]
		public Pickaxe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003162")]
		[Cpp2IlInjected.Address(RVA = "0xF12810", Offset = "0xF11210", VA = "0x180F12810")]
		static Pickaxe()
		{
			TimeSpan timeSpan = default(TimeSpan);
			timeOutDuration = timeSpan;
		}
	}
}
