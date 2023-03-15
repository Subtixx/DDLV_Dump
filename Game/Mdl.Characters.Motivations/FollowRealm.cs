using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008CE")]
	internal class FollowRealm : Follow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003147")]
		private new readonly FollowRealmConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003148")]
		private AnimationClip originalIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003149")]
		private AnimationClip originalWalk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400314A")]
		private AnimationClip originalRun;

		[Cpp2IlInjected.Token(Token = "0x60028B1")]
		[Cpp2IlInjected.Address(RVA = "0x1462130", Offset = "0x1460B30", VA = "0x181462130")]
		public FollowRealm(FollowRealmConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
			this.config = config;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028B2")]
		[Cpp2IlInjected.Address(RVA = "0x14616C0", Offset = "0x14600C0", VA = "0x1814616C0", Slot = "15")]
		protected unsafe override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_013d
			//IL_001e: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0072: Expected native int or pointer, but got O
			//IL_007e: Expected F4, but got I4
			//IL_0092: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			//IL_0103: Expected O, but got I4
			//IL_012c: Expected O, but got I4
			Character character = (base.character = agent.GetComponent<Character>());
			Character character2 = base.character;
			int num = 0;
			bool flag = character2 != (UnityEngine.Object)num;
			if (flag)
			{
				Character fromCharacter = base.character;
				GameObject characterToFollow = GetCharacterToFollow(fromCharacter);
				int num2 = 0;
				if (characterToFollow != (UnityEngine.Object)num2)
				{
					base.UpdateDestination();
					Character fromCharacter2 = base.character;
					Transform transform = GetCharacterToFollow(fromCharacter2).transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					((Vector3*)(IntPtr)base.lastTargetPos)->z = z;
				}
			}
			base.stuckCheck = (flag ? 1 : 0);
			Animator component = agent.GetComponent<Animator>();
			int num3 = 0;
			if (!(component != (UnityEngine.Object)num3))
			{
				return;
			}
			int num4 = 0;
			RuntimeAnimatorController runtimeAnimatorController = component.runtimeAnimatorController;
			if ((object)runtimeAnimatorController == null)
			{
				return;
			}
			int num5 = 0;
			int num6 = 0;
			if ((object)runtimeAnimatorController != null)
			{
				List<KeyValuePair<AnimationClip, AnimationClip>> list = (List<KeyValuePair<AnimationClip, AnimationClip>>)(object)new List<T>();
				AnimationClip idleOverride = config.idleOverride;
				int num7 = 0;
				if (idleOverride != (UnityEngine.Object)num7)
				{
					AnimationClip idleOverride2 = config.idleOverride;
				}
				AnimationClip walkOverride = config.walkOverride;
				int num8 = 0;
				if (walkOverride != (UnityEngine.Object)num8)
				{
					AnimationClip walkOverride2 = config.walkOverride;
				}
				AnimationClip runOverride = config.runOverride;
				int num9 = 0;
				if (runOverride != (UnityEngine.Object)num9)
				{
					AnimationClip runOverride2 = config.runOverride;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028B3")]
		[Cpp2IlInjected.Address(RVA = "0x1461AA0", Offset = "0x14604A0", VA = "0x181461AA0", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_00bc
			//IL_0010: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			Animator component = agent.GetComponent<Animator>();
			int num = 0;
			if (!(component != (UnityEngine.Object)num))
			{
				return;
			}
			int num2 = 0;
			RuntimeAnimatorController runtimeAnimatorController = component.runtimeAnimatorController;
			if ((object)runtimeAnimatorController == null)
			{
				return;
			}
			int num3 = 0;
			if ((object)runtimeAnimatorController != null)
			{
				List<KeyValuePair<AnimationClip, AnimationClip>> list = (List<KeyValuePair<AnimationClip, AnimationClip>>)(object)new List<T>();
				AnimationClip idleOverride = config.idleOverride;
				int num4 = 0;
				if (idleOverride != (UnityEngine.Object)num4)
				{
					FollowRealmConfig followRealmConfig = config;
					AnimationClip animationClip = originalIdle;
				}
				AnimationClip walkOverride = config.walkOverride;
				int num5 = 0;
				if (walkOverride != (UnityEngine.Object)num5)
				{
					FollowRealmConfig followRealmConfig2 = config;
					AnimationClip animationClip2 = originalWalk;
				}
				AnimationClip runOverride = config.runOverride;
				int num6 = 0;
				if (runOverride != (UnityEngine.Object)num6)
				{
					FollowRealmConfig followRealmConfig3 = config;
					AnimationClip animationClip3 = originalRun;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028B4")]
		[Cpp2IlInjected.Address(RVA = "0x1461D70", Offset = "0x1460770", VA = "0x181461D70", Slot = "19")]
		protected override GameObject GetCharacterToFollow(Character fromCharacter)
		{
			//Discarded unreachable code: IL_0007
			return fromCharacter.Avatar;
		}
	}
}
