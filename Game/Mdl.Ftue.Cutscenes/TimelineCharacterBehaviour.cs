using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Characters;
using Meta;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20005FA")]
	public class TimelineCharacterBehaviour : PlayableBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002443")]
		public CharacterAnimation animationTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4002444")]
		public CharacterMovementTrigger animationMovementTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002445")]
		public OtherAnimations otherAnimationTriggers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002446")]
		public Toolbox.ToolType setTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002447")]
		public bool disableAnimations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4002448")]
		[Header("Override")]
		public bool overrideAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002449")]
		public AnimationClip defaultAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400244A")]
		public AnimationClip femaleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400244B")]
		public AnimationClip femaleGownOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400244C")]
		public AnimationClip maleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400244D")]
		public AnimationClip maleGownOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002450")]
		private Animator animatorComp;

		[Cpp2IlInjected.Token(Token = "0x170003CB")]
		public GameObject TargetObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001A74")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CTargetObject_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A75")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			set
			{
				_003CTargetObject_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CC")]
		public TimelineCharacterTrack CharacterTrack
		{
			[Cpp2IlInjected.Token(Token = "0x6001A76")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterTrack_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A77")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			set
			{
				_003CCharacterTrack_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A78")]
		[Cpp2IlInjected.Address(RVA = "0x13C9630", Offset = "0x13C8030", VA = "0x1813C9630", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
			//Discarded unreachable code: IL_023b
			//IL_0015: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00ea: Expected I4, but got F4
			//IL_015d: Expected O, but got I4
			//IL_017a: Expected O, but got I4
			//IL_018f: Expected O, but got I4
			//IL_01f3: Expected O, but got I4
			//IL_0217: Expected O, but got I4
			TimelineCharacterHolder component = TargetObject.GetComponent<TimelineCharacterHolder>();
			int num = 0;
			if (!(component != (UnityEngine.Object)num))
			{
				return;
			}
			Transform transform = TargetObject.transform;
			component.UpdateTransform(transform);
			Mdl.Characters.Character character = component.character;
			int num2 = 0;
			if (character == (UnityEngine.Object)num2)
			{
				Mdl.Characters.Character character2 = component.GetCharacter();
			}
			GameObject charGameObj = component.charGameObj;
			int num3 = 0;
			bool flag = charGameObj != (UnityEngine.Object)num3;
			int num4 = 0;
			if (flag)
			{
				Animator componentInChildren = component.charGameObj.GetComponentInChildren<Animator>(includeInactive: true);
			}
			animatorComp = (Animator)num4;
			Animator animator = animatorComp;
			OtherAnimations otherAnimations = default(OtherAnimations);
			string name = ((Enum)otherAnimations).ToString();
			OtherAnimations otherAnimations2 = otherAnimations;
			animator.ResetTrigger(name);
			string text3 = default(string);
			if ((overrideAnimation ? 1 : 0) == num4)
			{
				Animator animator2 = animatorComp;
				Animator animator5 = default(Animator);
				if (setTool == (Toolbox.ToolType)num4)
				{
					bool flag2 = default(bool);
					if (animationMovementTrigger != (CharacterMovementTrigger)num4)
					{
						animator2.SetTrigger("Locomotion");
						animatorComp.SetBool("Move", value: false);
						Animator animator3 = animatorComp;
						flag2 = animationMovementTrigger != CharacterMovementTrigger.Walk;
						animator3.SetFloat("Run", 2.3509887E-38f);
					}
					int value = 0;
					animator2.SetBool("Move", (byte)value != 0);
					CharacterAnimation characterAnimation = animationTrigger;
					if (characterAnimation == CharacterAnimation.None && otherAnimationTriggers == (flag2 ? OtherAnimations.TeleportStart : OtherAnimations.None))
					{
						Animator animator4 = animatorComp;
					}
					animator5 = animatorComp;
					if (characterAnimation != 0)
					{
						CharacterAnimation characterAnimation2 = animationTrigger;
						string text = ((Enum)characterAnimation2).ToString();
						CharacterAnimation characterAnimation3 = (animationTrigger = characterAnimation2);
					}
					OtherAnimations otherAnimations3 = otherAnimationTriggers;
					string text2 = ((Enum)otherAnimations3).ToString();
					OtherAnimations otherAnimations4 = (otherAnimationTriggers = otherAnimations3);
				}
				OtherAnimations otherAnimations5 = default(OtherAnimations);
				text3 = ((Enum)otherAnimations5).ToString();
				OtherAnimations otherAnimations6 = otherAnimations5;
				animator5.SetTrigger(text3);
				int num5 = 0;
				OtherAnimations otherAnimations7 = otherAnimations5;
				Toolbox.ToolType toolType = setTool;
			}
			int num6 = 0;
			bool flag3 = default(bool);
			if (flag3 || ProfilePlayer._map_furnitureData_codec != text3)
			{
			}
			if (ProfilePlayer._map_furnitureData_codec != text3)
			{
			}
			AnimationClip animationClip = femaleGownOverride;
			int num7 = 0;
			if (animationClip != (UnityEngine.Object)num7)
			{
				AnimationClip aniClipTarget = defaultAnimation;
				SetOverrideClip(aniClipTarget, animationClip);
				Animator animator6 = animatorComp;
				OtherAnimations otherAnimations8 = default(OtherAnimations);
				string trigger = ((Enum)otherAnimations8).ToString();
				OtherAnimations otherAnimations9 = otherAnimations8;
				animator6.SetTrigger(trigger);
			}
			if (disableAnimations)
			{
				int doEnable = 0;
				component.EnableAnimations((byte)doEnable != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A79")]
		[Cpp2IlInjected.Address(RVA = "0x13C9DA0", Offset = "0x13C87A0", VA = "0x1813C9DA0")]
		private void SetOverrideClip(AnimationClip aniClipTarget, AnimationClip aniClipOverride)
		{
			//Discarded unreachable code: IL_0045
			//IL_0044: Expected O, but got I4
			RuntimeAnimatorController runtimeAnimatorController = animatorComp.runtimeAnimatorController;
			if ((object)runtimeAnimatorController == null)
			{
			}
			int num = 0;
			if ((object)runtimeAnimatorController != null)
			{
				List<KeyValuePair<AnimationClip, AnimationClip>> list = (List<KeyValuePair<AnimationClip, AnimationClip>>)(object)new List<T>();
				bool result = default(bool);
				Predicate<KeyValuePair<AnimationClip, AnimationClip>> predicate = (Predicate<KeyValuePair<AnimationClip, AnimationClip>>)(object)(Predicate<T>)((KeyValuePair<AnimationClip, AnimationClip> x) => result);
				int num2 = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
				if (num2 != -1)
				{
					int num3 = 0;
					((List<T>)(object)list)[num2] = (T)num3;
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A7A")]
		[Cpp2IlInjected.Address(RVA = "0x13C9CB0", Offset = "0x13C86B0", VA = "0x1813C9CB0", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
			//Discarded unreachable code: IL_005b
			//IL_003c: Expected O, but got I4
			Animator animator;
			int num2;
			do
			{
				int num = 0;
				if (Application.isPlaying)
				{
					TimelineCharacterHolder component = TargetObject.GetComponent<TimelineCharacterHolder>();
					Transform transform = TargetObject.transform;
					component.UpdateTransform(transform);
					return;
				}
				animator = animatorComp;
				num2 = 0;
			}
			while (!(animator != (UnityEngine.Object)num2));
			Animator animator2 = animatorComp;
			int num3 = 0;
			float deltaTime = Time.deltaTime;
			animator2.Update(deltaTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A7B")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public TimelineCharacterBehaviour()
		{
		}
	}
}
