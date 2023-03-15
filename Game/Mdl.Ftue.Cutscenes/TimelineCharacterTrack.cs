using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Characters;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005FC")]
	[TrackClipType(typeof(TimelineCharacterAsset))]
	[TrackBindingType(typeof(GameObject))]
	public class TimelineCharacterTrack : TrackAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002451")]
		private bool characterDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002452")]
		private TimelineCharacterHolder charHolder;

		[Cpp2IlInjected.Token(Token = "0x6001A7E")]
		[Cpp2IlInjected.Address(RVA = "0x13CB6B0", Offset = "0x13CA0B0", VA = "0x1813CB6B0", Slot = "23")]
		public unsafe override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			//Discarded unreachable code: IL_00ba, IL_00c0, IL_00c6
			//IL_003c: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_00af: Expected I4, but got O
			UnityEngine.Object @object = default(UnityEngine.Object);
			PlayableDirector playableDirector = default(PlayableDirector);
			Character character = default(Character);
			Animator animator = default(Animator);
			IEnumerable<TimelineClip> enumerable = default(IEnumerable<TimelineClip>);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				if ((object)@object != null)
				{
				}
				Action<PlayableDirector> action = (Action<PlayableDirector>)(object)new Action<T>(Director_stopped);
				playableDirector.remove_stopped((Action<>)(object)action);
				Action<PlayableDirector> action2 = (Action<PlayableDirector>)(object)new Action<T>(Director_stopped);
				playableDirector.add_stopped((Action<>)(object)action2);
				int num2 = 0;
				if (!(character == (UnityEngine.Object)num2))
				{
					int num3 = 0;
					if (Application.isPlaying)
					{
						character.TalkingToRequestor = true;
						int num4 = ((character.enabled = false) ? 1 : 0);
					}
				}
				int num5 = 0;
				if (Application.isPlaying)
				{
					int num6 = 0;
					animator.ResetTrigger("Exit");
				}
				if (enumerable == null)
				{
					break;
				}
				int num7 = 0;
				if ((object)typeof(IEnumerator<TimelineClip>).TypeHandle == null)
				{
				}
				int num8 = 0;
				while (!flag2)
				{
				}
				int num9 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num9)
				{
					((int*)num)->m_value = num;
					((int*)num)->m_value = (int)graph;
					break;
				}
			}
			if (enumerable != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A7F")]
		[Cpp2IlInjected.Address(RVA = "0x13CBD40", Offset = "0x13CA740", VA = "0x1813CBD40")]
		private TimelineCharacterHolder GetCharHolder(PlayableDirector director)
		{
			//IL_0010: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			TimelineCharacterHolder timelineCharacterHolder = charHolder;
			int num = 0;
			if (timelineCharacterHolder == (UnityEngine.Object)num)
			{
				UnityEngine.Object genericBinding = director.GetGenericBinding(this);
				int num2 = 0;
				if ((object)genericBinding != null)
				{
				}
				int num3 = 0;
				if ((UnityEngine.Object)num2 == (UnityEngine.Object)num3)
				{
					throw new NullReferenceException();
				}
				TimelineCharacterHolder timelineCharacterHolder2 = default(TimelineCharacterHolder);
				charHolder = timelineCharacterHolder2;
			}
			return charHolder;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A80")]
		[Cpp2IlInjected.Address(RVA = "0x13CBE80", Offset = "0x13CA880", VA = "0x1813CBE80")]
		private Character GetCharacterFromDirector(PlayableDirector director)
		{
			//IL_0010: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			TimelineCharacterHolder timelineCharacterHolder = charHolder;
			int num = 0;
			if (timelineCharacterHolder == (UnityEngine.Object)num)
			{
				UnityEngine.Object genericBinding = director.GetGenericBinding(this);
				int num2 = 0;
				if ((object)genericBinding != null)
				{
				}
				int num3 = 0;
				if ((UnityEngine.Object)num2 == (UnityEngine.Object)num3)
				{
					goto IL_004d;
				}
				TimelineCharacterHolder timelineCharacterHolder2 = default(TimelineCharacterHolder);
				charHolder = timelineCharacterHolder2;
			}
			TimelineCharacterHolder timelineCharacterHolder3 = charHolder;
			if ((object)timelineCharacterHolder3 != null)
			{
				Character character = timelineCharacterHolder3.GetCharacter();
			}
			goto IL_004d;
			IL_004d:
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A81")]
		[Cpp2IlInjected.Address(RVA = "0x13CBBC0", Offset = "0x13CA5C0", VA = "0x1813CBBC0")]
		private void Director_stopped(PlayableDirector director)
		{
			//Discarded unreachable code: IL_0035
			Character characterFromDirector = GetCharacterFromDirector(director);
			charHolder?.Cleanup();
			RestoreCharacter(characterFromDirector);
			Action<PlayableDirector> action = (Action<PlayableDirector>)(object)new Action<T>(Director_stopped);
			director.remove_stopped((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A82")]
		[Cpp2IlInjected.Address(RVA = "0x13CBC90", Offset = "0x13CA690", VA = "0x1813CBC90")]
		private void DisableCharacter(Character character)
		{
			//Discarded unreachable code: IL_003c
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(character == (UnityEngine.Object)num))
			{
				int num2 = 0;
				if (Application.isPlaying && !charHolder.charIsLoaded)
				{
					characterDisabled = true;
					character.TalkingToRequestor = true;
					int num3 = ((character.enabled = false) ? 1 : 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A83")]
		[Cpp2IlInjected.Address(RVA = "0x13CBFD0", Offset = "0x13CA9D0", VA = "0x1813CBFD0")]
		internal void RestoreCharacter(Character character)
		{
			//Discarded unreachable code: IL_0077
			//IL_001a: Expected O, but got I4
			int num = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			TimelineCharacterHolder timelineCharacterHolder = charHolder;
			int num2 = 0;
			if (timelineCharacterHolder != (UnityEngine.Object)num2)
			{
				TimelineCharacterHolder timelineCharacterHolder2 = charHolder;
				if (timelineCharacterHolder2.usePlayerAvatar)
				{
					Transform finalPosition = timelineCharacterHolder2.finalPosition;
					Animator animator = default(Animator);
					animator.SetTrigger("Exit");
					int num3 = 0;
					Animator animator2 = default(Animator);
					animator2.SetTrigger("Locomotion");
					return;
				}
			}
			bool flag = default(bool);
			while (flag)
			{
			}
			while (characterDisabled == flag)
			{
			}
			Animator animator3 = default(Animator);
			animator3.SetTrigger("Locomotion");
			int num4 = 0;
			characterDisabled = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A84")]
		[Cpp2IlInjected.Address(RVA = "0x13CC1E0", Offset = "0x13CABE0", VA = "0x1813CC1E0")]
		public TimelineCharacterTrack()
		{
		}
	}
}
