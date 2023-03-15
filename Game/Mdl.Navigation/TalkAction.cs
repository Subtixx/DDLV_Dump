using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Dialogues;
using Mdl.Missions;
using Mdl.Systems;
using Meta.Missions;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BF7")]
	public class TalkAction : PlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40042A0")]
		public AK.Wwise.Event _sfxEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40042A1")]
		public OrbitCameraConfig OrbitCameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40042A2")]
		public float cameraTargetRatio = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40042A3")]
		public Vector3 cameraTargetLargeCharacterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40042A4")]
		public Vector3 cameraTargetSmallCharacterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40042A5")]
		public float minHeightCameraTarget = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40042A6")]
		public float cameraYawCorrection = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40042A7")]
		public float cameraMaxPitch = 35f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40042A8")]
		public float ExclusionRadius = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x40042AA")]
		public bool UpdateAvatar;

		[Cpp2IlInjected.Token(Token = "0x1700074F")]
		private MissionManager MissionManager
		{
			[Cpp2IlInjected.Token(Token = "0x60036A8")]
			[Cpp2IlInjected.Address(RVA = "0x106E9F0", Offset = "0x106D3F0", VA = "0x18106E9F0")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<MissionManager>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000750")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x5C"), Cpp2IlInjected.Token(Token = "0x40042A9")]
		public bool UpdateCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60036A9")]
			[Cpp2IlInjected.Address(RVA = "0x9657A0", Offset = "0x9641A0", VA = "0x1809657A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036AA")]
			[Cpp2IlInjected.Address(RVA = "0x9765E0", Offset = "0x974FE0", VA = "0x1809765E0")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x60036AB")]
		[Cpp2IlInjected.Address(RVA = "0x106E680", Offset = "0x106D080", VA = "0x18106E680", Slot = "4")]
		public override System.Threading.Tasks.Task StartAction(PlayerAvatar avatar, PlayerTask task)
		{
			//Discarded unreachable code: IL_004e
			Character taskData = task.GetTaskData<Character>();
			taskData.TalkingToRequestor = true;
			GameObject gameObject = (taskData.CharacterRequestor = avatar.gameObject);
			if (!SystemRoot.Instance.GetSystem<AudioManager>().InFTUESequence)
			{
				AK.Wwise.Event sfxEvent = _sfxEvent;
				GameObject gameObject2 = base.gameObject;
				uint num = sfxEvent.Post(gameObject2);
			}
			return base.StartAction(avatar, task);
		}

		[Cpp2IlInjected.Token(Token = "0x60036AC")]
		[Cpp2IlInjected.Address(RVA = "0x106DB90", Offset = "0x106C590", VA = "0x18106DB90", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__17))]
		public override System.Threading.Tasks.Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036AD")]
		[Cpp2IlInjected.Address(RVA = "0x106DA30", Offset = "0x106C430", VA = "0x18106DA30")]
		private GameObject CreateExclusionArea(Vector3 obstaclePosition, PlayerAvatar avatar)
		{
			//Discarded unreachable code: IL_005a
			int num = 0;
			avatar.ChangeMovementEnabled((byte)num != 0);
			GameObject gameObject = new GameObject();
			Transform transform = gameObject.transform;
			Transform transform3 = (transform.parent = base.transform);
			Transform transform4 = gameObject.transform;
			float z = obstaclePosition.z;
			NavMeshObstacle navMeshObstacle = gameObject.AddComponent<NavMeshObstacle>();
			int num2 = (int)(navMeshObstacle.shape = NavMeshObstacleShape.Capsule);
			float exclusionRadius = ExclusionRadius;
			navMeshObstacle.carving = true;
			return gameObject;
		}

		[Cpp2IlInjected.Token(Token = "0x60036AE")]
		[Cpp2IlInjected.Address(RVA = "0x106DCE0", Offset = "0x106C6E0", VA = "0x18106DCE0")]
		[AsyncStateMachine(typeof(_003CFindDialogueTree_003Ed__19))]
		private Task<Func<System.Threading.Tasks.Task>> FindDialogueTree(PlayerTask task, PlayerAvatar avatar, Character character, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Func<System.Threading.Tasks.Task>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036AF")]
		[Cpp2IlInjected.Address(RVA = "0x106E130", Offset = "0x106CB30", VA = "0x18106E130")]
		[AsyncStateMachine(typeof(_003CPlayDialogueTask_003Ed__20))]
		private System.Threading.Tasks.Task PlayDialogueTask(PlayerAvatar avatar, Character character, IBlackboard blackboard, bool setResolver, DialogueTree dialogueTree, MissionSlot slot, bool missionComplete, CancellationToken ct)
		{
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036B0")]
		[Cpp2IlInjected.Address(RVA = "0x106E2C0", Offset = "0x106CCC0", VA = "0x18106E2C0")]
		[AsyncStateMachine(typeof(_003CSecretCharacterDiscovered_003Ed__21))]
		private System.Threading.Tasks.Task SecretCharacterDiscovered(Character character)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036B1")]
		[Cpp2IlInjected.Address(RVA = "0x106DFE0", Offset = "0x106C9E0", VA = "0x18106DFE0")]
		[AsyncStateMachine(typeof(_003CMissionCompleteStep_003Ed__22))]
		private System.Threading.Tasks.Task MissionCompleteStep(Character character, MissionSlot slot, DialogueSystem dialogueSystem, CancellationToken ct)
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036B2")]
		[Cpp2IlInjected.Address(RVA = "0x106D980", Offset = "0x106C380", VA = "0x18106D980", Slot = "6")]
		public override void CancelAction(PlayerAvatar avatar, PlayerTask task)
		{
			//Discarded unreachable code: IL_0011
			Character taskData = task.GetTaskData<Character>();
			int num = ((taskData.TalkingToRequestor = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60036B3")]
		[Cpp2IlInjected.Address(RVA = "0x106DE80", Offset = "0x106C880", VA = "0x18106DE80")]
		[AsyncStateMachine(typeof(_003CGetMissionStepDialogInstance_003Ed__24))]
		private Task<(DialogueTree, MissionSlot, MissionObjective)> GetMissionStepDialogInstance(Character character, MissionObjective obj)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(DialogueTree, MissionSlot, MissionObjective)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60036B4")]
		[Cpp2IlInjected.Address(RVA = "0x106E3C0", Offset = "0x106CDC0", VA = "0x18106E3C0")]
		public static IBlackboard SetObjectiveBlackboard(IBlackboard blackboard, MissionObjective obj)
		{
			//Discarded unreachable code: IL_0033, IL_0039
			int num = 0;
			if (obj != null && obj.GetStepBBVariables() != null)
			{
				bool flag = default(bool);
				uint num2 = default(uint);
				if (flag && num < (int)num2)
				{
					num += num;
					num++;
				}
				MissionSlot missionSlot = default(MissionSlot);
				int slotId_ = missionSlot.slotId_;
				MissionSlot missionSlot2 = default(MissionSlot);
				MissionSlotClass class_ = missionSlot2.class_;
			}
			return blackboard;
		}

		[Cpp2IlInjected.Token(Token = "0x60036B5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("VisualDebugLineOfSight")]
		private void DrawPosition(Vector3 position, Color color)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60036B6")]
		[Cpp2IlInjected.Address(RVA = "0x106E9C0", Offset = "0x106D3C0", VA = "0x18106E9C0")]
		public TalkAction()
		{
		}
	}
}
