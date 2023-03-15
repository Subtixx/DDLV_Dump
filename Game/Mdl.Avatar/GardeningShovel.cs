using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Activities;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000AA5")]
	internal class GardeningShovel : Tool
	{
		[Cpp2IlInjected.Token(Token = "0x2000AA6")]
		private enum RaycastBlockerResult
		{
			[Cpp2IlInjected.Token(Token = "0x4003AB3")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4003AB4")]
			Blocked,
			[Cpp2IlInjected.Token(Token = "0x4003AB5")]
			Occupied,
			[Cpp2IlInjected.Token(Token = "0x4003AB6")]
			FoundBlocker
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003AA1")]
		[SerializeField]
		private float distanceFromAvatar = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003AA2")]
		public GameObject shovelVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4003AA3")]
		public GameObject shovelBuffedVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003AA4")]
		public GameObject shovelTrailVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003AA5")]
		public GameObject shovelBuffedTrailVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003AA6")]
		public AssetReferenceGameObject collectedItemsGizmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4003AA7")]
		public RewardSpawnAnimationData rewardSpawnAnimationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4003AA8")]
		public float largeColliderSizeThreshold = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4003AA9")]
		public ShovelHoldBehaviour holdBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4003AAA")]
		private AnimationEventDispatcher animationEventDispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4003AAB")]
		private TaskCompletionSource<bool> shovelHitTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4003AAC")]
		private bool buffedUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4003AAD")]
		[SerializeField]
		private float shovelTrauma = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4003AAE")]
		[Header("Audio")]
		public AK.Wwise.Event makeHoleSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4003AAF")]
		public AK.Wwise.Event coverHoleSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4003AB0")]
		private AK.Wwise.Event shovelSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4003AB1")]
		private CreateGardeningTile.Types.ListOfLandscapingExceptions exceptions;

		[Cpp2IlInjected.Token(Token = "0x170006DC")]
		public override Toolbox.ToolType ToolType
		{
			[Cpp2IlInjected.Token(Token = "0x6003125")]
			[Cpp2IlInjected.Address(RVA = "0x8C8560", Offset = "0x8C6F60", VA = "0x1808C8560", Slot = "8")]
			get
			{
				return Toolbox.ToolType.GardeningShovel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003126")]
		[Cpp2IlInjected.Address(RVA = "0x8C80B0", Offset = "0x8C6AB0", VA = "0x1808C80B0", Slot = "5")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_004f
			//IL_001c: Expected O, but got I4
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
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
		}

		[Cpp2IlInjected.Token(Token = "0x6003127")]
		[Cpp2IlInjected.Address(RVA = "0x8C78B0", Offset = "0x8C62B0", VA = "0x1808C78B0", Slot = "6")]
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

		[Cpp2IlInjected.Token(Token = "0x6003128")]
		[Cpp2IlInjected.Address(RVA = "0x8C69F0", Offset = "0x8C53F0", VA = "0x1808C69F0", Slot = "10")]
		public unsafe override (IEnumerable<GameObject>, IEnumerable<Vector3>) GetToolPreview(PlayerAvatar avatar)
		{
			//IL_0028: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			//IL_00fd: Expected O, but got F4
			//IL_0141: Expected O, but got F4
			GameObject gameObject = default(GameObject);
			GridScript gridScript = default(GridScript);
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			GridPosition position = default(GridPosition);
			(RaycastBlockerResult, GridObjectScript) tuple = default((RaycastBlockerResult, GridObjectScript));
			Vector3 vector3 = default(Vector3);
			(GridObject, GridObjectScript) tuple2 = default((GridObject, GridObjectScript));
			GameObject gameObject2 = default(GameObject);
			Vector3 vector4 = default(Vector3);
			GameObject[] array3;
			GameObject gameObject3 = default(GameObject);
			while (true)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				if (gameObject.GetComponent<Mdl.Environments.Environment>().CanGarden)
				{
					int num = 0;
					if (!(gridScript == (UnityEngine.Object)num))
					{
						float z = vector.z;
						float z2 = vector2.z;
						Item gardeningTileItem = CreateGardeningTile.GardeningTileItem;
						int editGrid = 0;
						int num2 = 0;
						int num3 = 0;
						GridPosition gridPosition = CreateGardeningTile.AdjustPosition(position);
						int orientation = 0;
						if (gridScript.IsAreaInside(in *(GridPosition*)num3, (GridOrientation)orientation, in *(GridArea*)num2, (byte)editGrid != 0))
						{
							if (avatar.GetMapLocation() != null)
							{
							}
							int num4 = 0;
							CreateGardeningTile.Types.Result createTileValidationResult = GetCreateTileValidationResult(gridScript.GridID, (GridPosition)num4);
							if ((long)tuple > 1)
							{
								goto IL_0098;
							}
						}
						(IEnumerable<GameObject>, IEnumerable<Vector3>) noPreview = ((IEnumerable<GameObject>, IEnumerable<Vector3>))Tool.get_NoPreview();
						goto IL_0098;
					}
				}
				goto IL_00e6;
				IL_00e6:
				float z3 = vector3.z;
				(new Vector3[1])[1] = (Vector3)z3;
				goto IL_00fd;
				IL_0098:
				if (_003C_003Ec._003C_003E9__29_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridObject x)
					{
						if (x.ItemID == 0)
						{
						}
						GridState state_ = x.state_;
						if (state_ != null)
						{
							GardenData gardenData = state_.GardenData;
							if (gardenData != null)
							{
								RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData.slots_;
								Func<GardenData.Types.GardeningSlot, bool> func = default(Func<GardenData.Types.GardeningSlot, bool>);
								if (_003C_003Ec._003C_003E9__29_1 == null)
								{
									func = (Func<GardenData.Types.GardeningSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GardenData.Types.GardeningSlot y)
									{
										Item plantedSeedItem = y.PlantedSeedItem;
										throw new NullReferenceException();
									});
								}
								bool flag = ((IEnumerable<>)(object)slots_).All<GardenData.Types.GardeningSlot>((Func<, >)(object)func);
								int num9 = 0;
							}
						}
						int num10 = 0;
						throw new NullReferenceException();
					};
				}
				int num5 = 0;
				if (_003C_003Ec._003C_003E9__28_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridObject x)
					{
						//Discarded unreachable code: IL_0009
						int itemID = x.ItemID;
						bool result = default(bool);
						return result;
					};
					int num6 = 0;
				}
				if ((object)tuple2 == null)
				{
					if (avatar.GetMapLocation() == null)
					{
					}
					goto IL_00e6;
				}
				goto IL_00fd;
				IL_00fd:
				GameObject[] array = new GameObject[1];
				if ((object)gameObject2 == null || (object)gameObject2 != null)
				{
					array[0] = gameObject2;
					float z4 = vector4.z;
					GameObject[] noPreviewGameObjects = Tool.NoPreviewGameObjects;
					Vector3[] array2 = new Vector3[1];
					int num7 = 0;
					array2[1] = (Vector3)z4;
					array3 = new GameObject[1];
					if ((object)gameObject3 == null || (object)gameObject3 != null)
					{
						break;
					}
				}
			}
			array3[0] = gameObject3;
			Vector3[] noPreviewPositions = Tool.NoPreviewPositions;
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003129")]
		[Cpp2IlInjected.Address(RVA = "0x8C6340", Offset = "0x8C4D40", VA = "0x1808C6340")]
		private (RaycastBlockerResult, GridObjectScript) GetRaycastBlocker(PlayerAvatar avatar, Vector3 position, CreateGardeningTile.Types.Result result)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600312A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5E10", Offset = "0x8C4810", VA = "0x1808C5E10")]
		internal static CreateGardeningTile.Types.Result GetCreateTileValidationResult(uint gridID, GridPosition gridPosition)
		{
			//Discarded unreachable code: IL_003f
			//IL_000d: Expected I4, but got O
			//IL_0014: Expected I4, but got O
			CreateGardeningTile.Types.Request request = new CreateGardeningTile.Types.Request();
			request.positionX_ = (int)gridPosition;
			request.positionY_ = (int)gridPosition;
			request.gridID_ = gridID;
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			Client metaClient3 = SystemRoot.Instance.MetaClient;
			CreateGardeningTile.Types.Result result = default(CreateGardeningTile.Types.Result);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600312B")]
		[Cpp2IlInjected.Address(RVA = "0x8C83A0", Offset = "0x8C6DA0", VA = "0x1808C83A0", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUseTool_003Ed__25))]
		protected override Task<bool> UseTool(PlayerAvatar avatar)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600312C")]
		[Cpp2IlInjected.Address(RVA = "0x8C58E0", Offset = "0x8C42E0", VA = "0x1808C58E0")]
		private void AddHoldBehaviour(ShovelHoldBehaviourType behaviourType, GridScript grid, GridPosition gridPosition)
		{
			//Discarded unreachable code: IL_0049
			//IL_0010: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			ShovelHoldBehaviour shovelHoldBehaviour = holdBehaviour;
			int num = 0;
			if (shovelHoldBehaviour != (UnityEngine.Object)num)
			{
				PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
				BaseHoldBehaviour currentHoldBehaviour = system._currentHoldBehaviour;
				int num2 = 0;
				if (currentHoldBehaviour == (UnityEngine.Object)num2)
				{
					ShovelHoldBehaviour shovelHoldBehaviour2 = (ShovelHoldBehaviour)(system.CurrentHoldBehaviour = UnityEngine.Object.Instantiate(holdBehaviour));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600312D")]
		[Cpp2IlInjected.Address(RVA = "0x8C61B0", Offset = "0x8C4BB0", VA = "0x1808C61B0")]
		private static (GridObject, GridObjectScript) GetFilteredGridObject(GridScript gridScript, IEnumerable<GridObject> objectsAtThisPosition, Func<GridObject, bool> filter)
		{
			if (filter != null)
			{
				Func<GridObject, bool> filter2 = default(Func<GridObject, bool>);
				Func<GridObject, bool> func = (Func<GridObject, bool>)(object)(Func<T, TResult>)((GridObject x) => (byte)(int)filter2((T)x) != 0);
				GridObject gridObject = default(GridObject);
				if (gridObject != null)
				{
					uint iD_ = gridObject.iD_;
					int num = 0;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600312E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5CC0", Offset = "0x8C46C0", VA = "0x1808C5CC0")]
		private static (GridObject, GridObjectScript) GetBlocker(GridScript gridScript, IEnumerable<GridObject> objectsAtThisPosition)
		{
			while (_003C_003Ec._003C_003E9__28_0 != null)
			{
			}
			_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridObject x)
			{
				//Discarded unreachable code: IL_0009
				int itemID = x.ItemID;
				bool result = default(bool);
				return result;
			};
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600312F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6060", Offset = "0x8C4A60", VA = "0x1808C6060")]
		internal static (GridObject, GridObjectScript) GetEmptyGardeningSlot(GridScript gridScript, IEnumerable<GridObject> objectsAtThisPosition)
		{
			while (_003C_003Ec._003C_003E9__29_0 != null)
			{
			}
			_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridObject x)
			{
				if (x.ItemID == 0)
				{
				}
				GridState state_ = x.state_;
				if (state_ != null)
				{
					GardenData gardenData = state_.GardenData;
					if (gardenData != null)
					{
						RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData.slots_;
						Func<GardenData.Types.GardeningSlot, bool> func = default(Func<GardenData.Types.GardeningSlot, bool>);
						if (_003C_003Ec._003C_003E9__29_1 == null)
						{
							func = (Func<GardenData.Types.GardeningSlot, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GardenData.Types.GardeningSlot y)
							{
								Item plantedSeedItem = y.PlantedSeedItem;
								throw new NullReferenceException();
							});
						}
						bool flag = ((IEnumerable<>)(object)slots_).All<GardenData.Types.GardeningSlot>((Func<, >)(object)func);
						int num = 0;
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			};
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003130")]
		[Cpp2IlInjected.Address(RVA = "0x8C6310", Offset = "0x8C4D10", VA = "0x1808C6310")]
		private IEnumerable<GridObject> GetGridObjectsAtPosition(GridPosition gridPosition, GridScript gridScript)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003131")]
		[Cpp2IlInjected.Address(RVA = "0x8C7450", Offset = "0x8C5E50", VA = "0x1808C7450")]
		private Vector3 GetToolUseWorldPosition(PlayerAvatar avatar)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003132")]
		[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6390", VA = "0x1808C7990")]
		[AsyncStateMachine(typeof(_003CPlayAnimationAndWaitForTask_003Ed__32))]
		private Task PlayAnimationAndWaitForTask(PlayerAvatar avatar, Func<Task> task, Vector3 centerWorldPosition, bool buffed)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003133")]
		[Cpp2IlInjected.Address(RVA = "0x8C5AD0", Offset = "0x8C44D0", VA = "0x1808C5AD0")]
		internal (Vector3, Quaternion) FindCorrectAvatarTransform(PlayerAvatar avatar, Vector3 centerWorldPosition)
		{
			//IL_0027: Expected O, but got I4
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num3;
			((GridObjectStateUser)this).cancellationTokenSource = (CancellationTokenSource)num3;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003134")]
		[Cpp2IlInjected.Address(RVA = "0x8C7AF0", Offset = "0x8C64F0", VA = "0x1808C7AF0")]
		private unsafe Task RemoveBlocker(PlayerAvatar avatar, GridObjectScript blockerGridObjectScript)
		{
			//IL_0065: Expected native int or pointer, but got O
			//IL_0077: Invalid comparison between O and F4
			//IL_00cb: Expected native int or pointer, but got O
			//IL_00ef: Expected O, but got I4
			int num = 0;
			if (SystemRoot.Instance.MetaClient.profile.HasEnoughMana(ManaData.Types.ManaSpendingActionType.CreateGardeningTile))
			{
				GridObjectScript gridObjectScript = blockerGridObjectScript;
				GameObject gameObject = default(GameObject);
				OnToolInteractedWithObject(gameObject);
				Transform transform = blockerGridObjectScript.transform;
				GridObjectScript gridObjectScript2 = blockerGridObjectScript;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 gridObjectPosition = default(Vector3);
				((Vector3*)(IntPtr)gridObjectPosition)->z = z;
				bool flag = default(bool);
				Bounds bounds = default(Bounds);
				if (flag && bounds > (object)largeColliderSizeThreshold)
				{
					Transform transform2 = blockerGridObjectScript.transform;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					Transform _003Ctransform_003Ek__BackingField = avatar.transform;
					GridObjectScript gridObjectScript3 = blockerGridObjectScript;
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
					Transform transform3 = gridObjectScript3.transform;
					Vector3 vector4 = default(Vector3);
					float z4 = vector4.z;
					Vector3 vector5 = default(Vector3);
					float z5 = vector5.z;
					((Vector3*)(IntPtr)gridObjectPosition)->z = z5;
				}
				Func<Task> func = (Func<Task>)(object)(Func<TResult>)delegate
				{
					//Discarded unreachable code: IL_004b
					GridObjectScript gridObjectScript4 = blockerGridObjectScript;
					GardeningShovel gardeningShovel = this;
					float z6 = gridObjectPosition.z;
					uint gridID = gridObjectScript4.GridScript.GridID;
					GridObjectScript gridObjectScript5 = blockerGridObjectScript;
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript5.GridObject;
					int num4 = 0;
					RewardSpawnAnimationData rewardSpawnAnimationDataOverride = gridObjectScript5.GetComponent<Blocker>().rewardSpawnAnimationDataOverride;
					Task result2 = default(Task);
					return result2;
				};
				int num2 = 0;
				Task result = default(Task);
				return result;
			}
			int num3 = 0;
			Task task = avatar.NotEnoughManaAndWaitAnimation((CancellationToken)num3);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003135")]
		[Cpp2IlInjected.Address(RVA = "0x8C7540", Offset = "0x8C5F40", VA = "0x1808C7540")]
		private void OnAvatarAnimationEvent(string eventName, AnimationEventDispatcher.AnimationEventArgs args)
		{
			//Discarded unreachable code: IL_00c3
			//IL_002b: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			if (eventName == null)
			{
				return;
			}
			if ("shovelFX" != null)
			{
				if (buffedUse)
				{
					GameObject gameObject = shovelBuffedVFXPrefab;
					int num = 0;
					if (!(gameObject != (UnityEngine.Object)num))
					{
					}
				}
				GameObject gameObject2 = shovelVFXPrefab;
				int num2 = 0;
				if (gameObject2 != (UnityEngine.Object)num2)
				{
					GameObject original = shovelVFXPrefab;
					Transform parent = base.transform;
					DestroyOnEnable orAddComponent = UnityEngine.Object.Instantiate(original, parent).GetOrAddComponent<DestroyOnEnable>();
				}
				if (buffedUse)
				{
					GameObject gameObject3 = shovelBuffedTrailVFXPrefab;
					int num3 = 0;
					if (!(gameObject3 != (UnityEngine.Object)num3))
					{
					}
				}
				GameObject gameObject4 = shovelTrailVFXPrefab;
				int num4 = 0;
				if (gameObject4 != (UnityEngine.Object)num4)
				{
					GameObject gameObject5 = shovelTrailVFXPrefab;
					int num5 = 0;
					GameObject gameObject6 = default(GameObject);
					DestroyOnEnable orAddComponent2 = gameObject6.GetOrAddComponent<DestroyOnEnable>();
				}
				if (shovelSFX == null)
				{
				}
			}
			else
			{
				while ("shovelFX" == null)
				{
				}
				if (eventName == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003136")]
		[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C6EF0", VA = "0x1808C84F0")]
		public GardeningShovel()
		{
		}
	}
}
