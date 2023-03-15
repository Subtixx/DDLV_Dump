using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008F5")]
	internal class TimidBehaviour : Motivation<TimidBehaviourConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40031E6")]
		private Character character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40031E7")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40031E8")]
		private float hideTimer = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40031E9")]
		private bool? hidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40031EA")]
		private Vector3? avatarPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40031EB")]
		private AnimationClip originalIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40031EC")]
		private int originalAvoidancePriority;

		[Cpp2IlInjected.Token(Token = "0x6002935")]
		[Cpp2IlInjected.Address(RVA = "0x13D3840", Offset = "0x13D2240", VA = "0x1813D3840")]
		public TimidBehaviour(TimidBehaviourConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002936")]
		[Cpp2IlInjected.Address(RVA = "0x13D2B80", Offset = "0x13D1580", VA = "0x1813D2B80", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_00b9
			//IL_00b8: Expected O, but got I4
			Character character = (this.character = agent.GetComponent<Character>());
			PlayerAvatar playerAvatar = (avatar = SystemRoot.Instance._avatar);
			this.character.NavMeshAgentComponent.ResetPath();
			int num = (originalAvoidancePriority = this.character.NavMeshAgentComponent.avoidancePriority);
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			Animator _003CAnimatorComponent_003Ek__BackingField = this.character.AnimatorComponent;
			int num2 = 0;
			RuntimeAnimatorController runtimeAnimatorController = _003CAnimatorComponent_003Ek__BackingField.runtimeAnimatorController;
			if ((object)runtimeAnimatorController == null)
			{
				return;
			}
			int num3 = 0;
			if ((object)runtimeAnimatorController != null)
			{
				List<KeyValuePair<AnimationClip, AnimationClip>> list = (List<KeyValuePair<AnimationClip, AnimationClip>>)(object)new List<T>();
				bool result = default(bool);
				Predicate<KeyValuePair<AnimationClip, AnimationClip>> predicate = (Predicate<KeyValuePair<AnimationClip, AnimationClip>>)(object)(Predicate<T>)((KeyValuePair<AnimationClip, AnimationClip> x) => result);
				int index = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
				int num4 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				originalIdle = (AnimationClip)(object)predicate;
				int num5 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				int num6 = 0;
				((List<T>)(object)list)[index] = (T)num6;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002937")]
		[Cpp2IlInjected.Address(RVA = "0x13D2F60", Offset = "0x13D1960", VA = "0x1813D2F60", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002938")]
		[Cpp2IlInjected.Address(RVA = "0x13D3650", Offset = "0x13D2050", VA = "0x1813D3650", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			ResetState();
		}

		[Cpp2IlInjected.Token(Token = "0x6002939")]
		[Cpp2IlInjected.Address(RVA = "0x13D33C0", Offset = "0x13D1DC0", VA = "0x1813D33C0", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_0070
			//IL_006f: Expected O, but got I4
			ResetState();
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			Animator _003CAnimatorComponent_003Ek__BackingField = character.AnimatorComponent;
			int num = 0;
			RuntimeAnimatorController runtimeAnimatorController = _003CAnimatorComponent_003Ek__BackingField.runtimeAnimatorController;
			if ((object)runtimeAnimatorController == null)
			{
				return;
			}
			int num2 = 0;
			if ((object)runtimeAnimatorController != null)
			{
				List<KeyValuePair<AnimationClip, AnimationClip>> list = (List<KeyValuePair<AnimationClip, AnimationClip>>)(object)new List<T>();
				bool result = default(bool);
				Predicate<KeyValuePair<AnimationClip, AnimationClip>> predicate = (Predicate<KeyValuePair<AnimationClip, AnimationClip>>)(object)(Predicate<T>)((KeyValuePair<AnimationClip, AnimationClip> x) => result);
				int index = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
				int num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num3 += num3;
				AnimationClip animationClip = originalIdle;
				int num4 = 0;
				((List<T>)(object)list)[index] = (T)num4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600293A")]
		[Cpp2IlInjected.Address(RVA = "0x13D3660", Offset = "0x13D2060", VA = "0x1813D3660")]
		private void ResetState()
		{
			//Discarded unreachable code: IL_0048
			//IL_0024: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				character.AnimatorComponent.SetTrigger("Exit");
			}
			int num = 0;
			int num2 = 0;
			hidden = (bool?)(object)num;
			avatarPosition = (Vector3?)(object)num2;
			NavMeshAgent _003CNavMeshAgentComponent_003Ek__BackingField = character.NavMeshAgentComponent;
			int num4 = (_003CNavMeshAgentComponent_003Ek__BackingField.avoidancePriority = originalAvoidancePriority);
		}
	}
}
