using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Mdl.Characters;
using Mdl.Characters.Critters;
using Mdl.Environments.PointsOfInterest;
using Meta.Missions;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000728")]
	public static class CharacterUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4002989")]
		private static readonly float DefaultRotationDuration_Animated;

		[Cpp2IlInjected.Token(Token = "0x400298A")]
		private static readonly float DefaultRotationDuration_NotAnimated;

		[Cpp2IlInjected.Token(Token = "0x6001FBE")]
		[Cpp2IlInjected.Address(RVA = "0xA783D0", Offset = "0xA76DD0", VA = "0x180A783D0")]
		public static bool CanActWhileSeated(Character character)
		{
			//Discarded unreachable code: IL_0022
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = character != (UnityEngine.Object)num;
			if (!flag)
			{
				return flag;
			}
			if (character.CanTalkWhileSeated)
			{
				return true;
			}
			return character.CanSelfieWhileSeated;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FBF")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6B0", Offset = "0xA790B0", VA = "0x180A7A6B0")]
		public static bool TalkingWhileSeated(Character character, CancellationToken ct)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (character != (UnityEngine.Object)num && character.RelaxingBehaviour.Relaxing && flag && CanActWhileSeated(character) && character.CanTalkWhileSeated)
			{
				return character.TalkingToRequestor;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4D0", Offset = "0xA78ED0", VA = "0x180A7A4D0")]
		public static bool SelfieWhileSeated(Character character, CancellationToken ct)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (character != (UnityEngine.Object)num && character.RelaxingBehaviour.Relaxing && flag && CanActWhileSeated(character) && character.CanSelfieWhileSeated)
			{
				return character.IsInSelfieCamera;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC1")]
		[Cpp2IlInjected.Address(RVA = "0xA78C20", Offset = "0xA77620", VA = "0x180A78C20")]
		public static void EnableCharacter(GameObject agent, bool enable)
		{
			//Discarded unreachable code: IL_0035
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			CharacterTurnAnimationController component = agent.GetComponent<CharacterTurnAnimationController>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				component.enabled = enable;
			}
			Character component2 = agent.GetComponent<Character>();
			int num2 = 0;
			if (component2 != (UnityEngine.Object)num2)
			{
				component2.enabled = enable;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC2")]
		[Cpp2IlInjected.Address(RVA = "0xA7A070", Offset = "0xA78A70", VA = "0x180A7A070")]
		[AsyncStateMachine(typeof(_003CPlayAnimation_003Ed__6))]
		public static Task PlayAnimation(GameObject agent, string animState, string triggerToSet, string triggerToReset, float maxTime, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC3")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1E0", Offset = "0xA78BE0", VA = "0x180A7A1E0")]
		[AsyncStateMachine(typeof(_003CPlayAnimation_003Ed__7))]
		public static Task PlayAnimation(GameObject agent, string animState, string triggerToSet, string triggerToReset, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC4")]
		[Cpp2IlInjected.Address(RVA = "0xA7A340", Offset = "0xA78D40", VA = "0x180A7A340")]
		public static bool QuestIsActive(MissionSlot slot)
		{
			//Discarded unreachable code: IL_0009, IL_000e
			MissionSlotState state_ = slot.state_;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC5")]
		[Cpp2IlInjected.Address(RVA = "0xA79A60", Offset = "0xA78460", VA = "0x180A79A60")]
		public static IPointOfInterest GetHouseMeetingPoint(GameObject agent, IEnumerable<IPointOfInterest> points)
		{
			//Discarded unreachable code: IL_0086, IL_008c, IL_0092, IL_0098
			//IL_0012: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				Character component = agent.GetComponent<Character>();
				int num2 = 0;
				if (!(component != (UnityEngine.Object)num2))
				{
					break;
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item _003CItem_003Ek__BackingField = component.Item;
				CharacterItemData itemData = _003CInstance_003Ek__BackingField.GetItemData<CharacterItemData>(_003CItem_003Ek__BackingField);
				if (itemData != null)
				{
					Type type = itemData.GetType();
					Type typeFromHandle = typeof(MeetingPoint);
					bool flag = ((object)type).Equals((object)typeFromHandle);
					while (!flag)
					{
					}
					while (!flag2)
					{
					}
					int count = ((CaptureCollection)flag).Count;
					if (itemData.House == 0)
					{
						continue;
					}
					num++;
				}
				num++;
				if (itemData != null)
				{
				}
				if (num == 0)
				{
				}
				break;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A370", Offset = "0xA78D70", VA = "0x180A7A370")]
		[AsyncStateMachine(typeof(_003CSayHi_003Ed__10))]
		public static Task SayHi(GameObject agent, GameObject target, string animTrigger, float duration, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC7")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB70", Offset = "0xA79570", VA = "0x180A7AB70")]
		[AsyncStateMachine(typeof(_003CWander_003Ed__11))]
		public static Task Wander(GameObject agent, Transform aroundPoint, float speed, float minDistance, float maxDistance, float minIdleTime, float maxIdleTime, CancellationToken ct, bool resetTrigger = true)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC8")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9E0", Offset = "0xA793E0", VA = "0x180A7A9E0")]
		[AsyncStateMachine(typeof(_003CWalkTo_003Ed__12))]
		public static Task<bool> WalkTo(NavMeshAgent agent, Vector3 destination, float fullSpeed, float slowDownSpeed, float slowDownDistance, CancellationToken ct, bool resetTrigger = true)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC9")]
		[Cpp2IlInjected.Address(RVA = "0xA78B60", Offset = "0xA77560", VA = "0x180A78B60")]
		public static float DistanceFromDestination(NavMeshAgent agent)
		{
			//Discarded unreachable code: IL_002e
			if (!float.IsInfinity(agent.remainingDistance))
			{
				return agent.remainingDistance;
			}
			Transform transform = agent.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCA")]
		[Cpp2IlInjected.Address(RVA = "0xA7A790", Offset = "0xA79190", VA = "0x180A7A790")]
		public static void Teleport(NavMeshAgent agent, Vector3 destination, float maxDistance)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCB")]
		[Cpp2IlInjected.Address(RVA = "0xA78D40", Offset = "0xA77740", VA = "0x180A78D40")]
		public unsafe static Vector3? FindValidDestination(NavMeshAgent agent, Vector3 destination, float maxDistance, bool reachable = true)
		{
			//IL_0012: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_0065: Expected F4, but got I4
			//IL_0065: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				int num2 = 0;
				NavMeshAreaHelper navMeshAreaHelper = default(NavMeshAreaHelper);
				if (navMeshAreaHelper != (UnityEngine.Object)num2)
				{
					navMeshAreaHelper.SetAreaCosts();
					navMeshAreaHelper.SetAreaMask();
				}
				int num3 = 0;
				Critter critter = default(Critter);
				if (critter != (UnityEngine.Object)num3)
				{
					goto IL_0082;
				}
				int num4 = 0;
				if ((navMeshAreaHelper._canWalkOnLand ? 1 : 0) != num4)
				{
					int num5 = 0;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					bool flag2 = default(bool);
					if (!flag2)
					{
						goto IL_00a4;
					}
					int num6 = 0;
				}
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				if (NavMesh.SamplePosition((Vector3)num, out *(NavMeshHit*)num9, num8, reachable ? 1 : 0))
				{
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					float x = vector2.x;
					bool flag3 = default(bool);
					if (flag3)
					{
						int num10 = 0;
						goto IL_0082;
					}
				}
			}
			goto IL_00a4;
			IL_00a4:
			int num11 = 0;
			throw new NullReferenceException();
			IL_0082:
			int num12 = 0;
			bool flag4 = default(bool);
			if (flag4)
			{
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				float x2 = vector3.x;
				bool flag5 = default(bool);
				if (flag5)
				{
					int num13 = 0;
				}
			}
			goto IL_00a4;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A010", Offset = "0xA78A10", VA = "0x180A7A010")]
		private static void LogError(string msg)
		{
			Debug.LogWarning(msg);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCD")]
		[Cpp2IlInjected.Address(RVA = "0xA79360", Offset = "0xA77D60", VA = "0x180A79360")]
		public static bool FindValidPosition(Vector3 targetPosition, Vector3 originPosition, out Vector3 validPosition, float maxDistance, int areaMask, bool reachable, [System.Runtime.InteropServices.Optional] string debugInfo)
		{
			//IL_001a: Expected O, but got F4
			//IL_001a: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_0083: Expected F4, but got O
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				if ("" == null)
				{
					float num2 = default(float);
					string text = $" for {num} with maxDistance: {num2}";
				}
				Debug.LogWarning("Failed to sample position" + "");
			}
			NavMeshPath navMeshPath = new NavMeshPath();
			bool flag2 = default(bool);
			if (flag2)
			{
				NavMeshPathStatus status = navMeshPath.status;
			}
			string text2 = default(string);
			if (num == 0)
			{
				NavMeshPathStatus status2 = navMeshPath.status;
				string arg = default(string);
				NavMeshPathStatus navMeshPathStatus = default(NavMeshPathStatus);
				text2 = $"Failed to find path{arg}, status={navMeshPathStatus}";
				Debug.LogWarning(text2);
			}
			float num3 = (validPosition.z = targetPosition.z);
			int num4 = 0;
			validPosition.z = (float)text2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCE")]
		[Cpp2IlInjected.Address(RVA = "0xA796E0", Offset = "0xA780E0", VA = "0x180A796E0")]
		public static bool FindValidPosition(Vector3 targetPosition, Vector3 originPosition, out Vector3 validPosition, out NavMeshHit hit, float maxDistance, NavMeshQueryFilter queryFilter, bool reachable, string debugInfo)
		{
			//IL_001a: Expected O, but got F4
			//IL_001a: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_0083: Expected F4, but got O
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				if ("" == null)
				{
					float num2 = default(float);
					string text = $" for {num} with maxDistance: {num2}";
				}
				Debug.LogWarning("Failed to sample position" + "");
			}
			NavMeshPath navMeshPath = new NavMeshPath();
			bool flag2 = default(bool);
			if (flag2)
			{
				NavMeshPathStatus status = navMeshPath.status;
			}
			string text2 = default(string);
			if (num == 0)
			{
				NavMeshPathStatus status2 = navMeshPath.status;
				string arg = default(string);
				NavMeshPathStatus navMeshPathStatus = default(NavMeshPathStatus);
				text2 = $"Failed to find path{arg}, status={navMeshPathStatus}";
				Debug.LogWarning(text2);
			}
			float num3 = (validPosition.z = targetPosition.z);
			int num4 = 0;
			validPosition.z = (float)text2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCF")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5B0", Offset = "0xA78FB0", VA = "0x180A7A5B0")]
		public static bool ShouldTurn(GameObject characterGO, Vector3 destination)
		{
			Transform transform = characterGO.transform;
			float z = destination.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			Transform transform2 = characterGO.transform;
			int num = 0;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD0")]
		[Cpp2IlInjected.Address(RVA = "0xA78A20", Offset = "0xA77420", VA = "0x180A78A20")]
		public static Task CharacterFaceTarget(GameObject characterGO, Vector3 destination, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0026
			Transform transform = characterGO.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = vector.z;
			float z3 = destination.z;
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD1")]
		[Cpp2IlInjected.Address(RVA = "0xA78830", Offset = "0xA77230", VA = "0x180A78830")]
		public static Task CharacterFaceTargetWithBehavior(GameObject characterGO, Vector3 destination, CharacterFacingBehavior facingBehavior, CancellationToken ct, [System.Runtime.InteropServices.Optional] float? overrideRotationDuration, [System.Runtime.InteropServices.Optional] Action perFrameCallback)
		{
			//Discarded unreachable code: IL_002a
			Transform transform = characterGO.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = vector.z;
			float z3 = destination.z;
			int num = 0;
			if (facingBehavior == CharacterFacingBehavior.NotAnimated)
			{
			}
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD2")]
		[Cpp2IlInjected.Address(RVA = "0xA78520", Offset = "0xA76F20", VA = "0x180A78520")]
		public static Task CharacterFaceTargetFromPosition(GameObject characterGO, Vector3 fromPosition, Vector3 destination, CharacterFacingBehavior facingBehavior, CancellationToken ct, [System.Runtime.InteropServices.Optional] float? overrideRotationDuration)
		{
			float z = fromPosition.z;
			float z2 = destination.z;
			float z3 = fromPosition.z;
			int num = 0;
			if (facingBehavior == CharacterFacingBehavior.NotAnimated)
			{
			}
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD3")]
		[Cpp2IlInjected.Address(RVA = "0xA78460", Offset = "0xA76E60", VA = "0x180A78460")]
		public unsafe static Task CharacterFaceDirection(GameObject characterGO, Vector3 direction, CancellationToken ct)
		{
			//IL_0006: Expected native int or pointer, but got O
			((Vector3*)(IntPtr)direction)->y = 0f;
			float z = direction.z;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD4")]
		[Cpp2IlInjected.Address(RVA = "0xA786D0", Offset = "0xA770D0", VA = "0x180A786D0")]
		[AsyncStateMachine(typeof(_003CCharacterFaceTargetInternal_003Ed__24))]
		private static Task CharacterFaceTargetInternal(GameObject characterGO, Vector3 lookDir, CharacterFacingBehavior facingBehavior, float rotationDuration, Action perFrameCallback, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD5")]
		[Cpp2IlInjected.Address(RVA = "0xA79E70", Offset = "0xA78870", VA = "0x180A79E70")]
		[AsyncStateMachine(typeof(_003CGiveAnimation_003Ed__25))]
		public static Task<bool> GiveAnimation(IEnumerable<ItemInstance> itemlist, Animator giverAnimator, GameObject givePosition, bool useGiveOffset, GameObject receivePosition, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}
	}
}
