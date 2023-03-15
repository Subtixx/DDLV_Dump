using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000711")]
	internal class AnimatorMonitor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002931")]
		private readonly List<(string stateName, HashSet<string> eventsReceived)> monitoredStates = (List<(string stateName, HashSet<string> eventsReceived)>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002932")]
		private readonly List<(string tagName, HashSet<string> eventsReceived)> monitoredTags = (List<(string tagName, HashSet<string> eventsReceived)>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002933")]
		private Animator _animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002934")]
		private AnimationEventDispatcher _animationEventDispatcher;

		[Cpp2IlInjected.Token(Token = "0x17000472")]
		private Animator animator
		{
			[Cpp2IlInjected.Token(Token = "0x6001F57")]
			[Cpp2IlInjected.Address(RVA = "0xA401C0", Offset = "0xA3EBC0", VA = "0x180A401C0")]
			get
			{
				Animator animator = _animator;
				if ((object)animator == null)
				{
					Animator component = GetComponent<Animator>();
				}
				_animator = animator;
				return animator;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000473")]
		private AnimationEventDispatcher animationEventDispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6001F58")]
			[Cpp2IlInjected.Address(RVA = "0xA40150", Offset = "0xA3EB50", VA = "0x180A40150")]
			get
			{
				AnimationEventDispatcher animationEventDispatcher = _animationEventDispatcher;
				if ((object)animationEventDispatcher == null)
				{
					AnimationEventDispatcher component = GetComponent<AnimationEventDispatcher>();
				}
				_animationEventDispatcher = animationEventDispatcher;
				return animationEventDispatcher;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F59")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9C0", Offset = "0xA3E3C0", VA = "0x180A3F9C0")]
		private void Start()
		{
			//Discarded unreachable code: IL_000f, IL_0020
			List<(string, HashSet<string>)> list = monitoredStates;
			base.enabled = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5A")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA40", Offset = "0xA3E440", VA = "0x180A3FA40")]
		private void Update()
		{
			//Discarded unreachable code: IL_012d
			int num = 0;
			int num2 = 0;
			int size = ((List<>)(object)monitoredStates)._size;
			size += 2;
			Animator animator = _animator;
			if ((object)animator == null)
			{
				Animator component = GetComponent<Animator>();
			}
			_animator = animator;
			List<(string, HashSet<string>)> list = monitoredStates;
			AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
			float length = animatorStateInfo.m_Length;
			int loop = animatorStateInfo.m_Loop;
			int num3 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			bool flag = default(bool);
			if (!flag)
			{
				((List<T>)(object)monitoredStates).RemoveAt(size);
			}
			int size2 = ((List<>)(object)monitoredTags)._size;
			size = size2;
			size += 2;
			Animator animator2 = _animator;
			if ((object)animator2 == null)
			{
				Animator component2 = GetComponent<Animator>();
			}
			_animator = animator2;
			List<(string, HashSet<string>)> list2 = monitoredTags;
			AnimatorStateInfo animatorStateInfo2 = default(AnimatorStateInfo);
			float length2 = animatorStateInfo2.m_Length;
			int loop2 = animatorStateInfo2.m_Loop;
			int num4 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			bool flag2 = default(bool);
			if (!flag2)
			{
				((List<T>)(object)monitoredTags).RemoveAt(size2);
			}
			List<(string, HashSet<string>)> list3 = monitoredStates;
			List<(string, HashSet<string>)> list4 = monitoredTags;
			int num5 = ((base.enabled = false) ? 1 : 0);
			AnimationEventDispatcher component3 = default(AnimationEventDispatcher);
			if ((object)_animationEventDispatcher == null)
			{
				component3 = GetComponent<AnimationEventDispatcher>();
			}
			_animationEventDispatcher = component3;
			AnimationEventDispatcher.AnimationEventHandler value = OnAnimationEvent;
			AnimationEventDispatcher.AnimationEventHandler animationEvent = component3.AnimationEvent;
			Delegate @delegate = Delegate.Remove(animationEvent, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != animationEvent)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F170", Offset = "0xA3DB70", VA = "0x180A3F170")]
		public void AddStateMonitor(string stateName)
		{
			//Discarded unreachable code: IL_004b
			//IL_0044: Expected O, but got I4
			List<(string, HashSet<string>)> list = monitoredStates;
			Predicate<(string, HashSet<string>)> predicate = (Predicate<(string, HashSet<string>)>)(object)(Predicate<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			if (((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate) == -1)
			{
				List<(string, HashSet<string>)> list2 = monitoredStates;
				HashSet<string> hashSet = (HashSet<string>)(object)new HashSet<T>();
				int num = 0;
				((List<T>)(object)list2).Add((T)num);
				CheckEnabled();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F680", Offset = "0xA3E080", VA = "0x180A3F680")]
		public bool IsMonitoringState(string stateName)
		{
			//Discarded unreachable code: IL_002f
			List<(string, HashSet<string>)> list = monitoredStates;
			Predicate<(string, HashSet<string>)> predicate = (Predicate<(string, HashSet<string>)>)(object)(Predicate<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			return ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate) != -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5D")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE20", Offset = "0xA3E820", VA = "0x180A3FE20")]
		public bool WasEventReceivedDuringState(string tagName, string eventName)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F330", Offset = "0xA3DD30", VA = "0x180A3F330")]
		public void AddTagMonitor(string tagName)
		{
			//Discarded unreachable code: IL_004b
			//IL_0044: Expected O, but got I4
			List<(string, HashSet<string>)> list = monitoredTags;
			Predicate<(string, HashSet<string>)> predicate = (Predicate<(string, HashSet<string>)>)(object)(Predicate<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			if (((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate) == -1)
			{
				List<(string, HashSet<string>)> list2 = monitoredTags;
				HashSet<string> hashSet = (HashSet<string>)(object)new HashSet<T>();
				int num = 0;
				((List<T>)(object)list2).Add((T)num);
				CheckEnabled();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F5F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F770", Offset = "0xA3E170", VA = "0x180A3F770")]
		public bool IsMonitoringTag(string tagName)
		{
			//Discarded unreachable code: IL_002f
			List<(string, HashSet<string>)> list = monitoredTags;
			Predicate<(string, HashSet<string>)> predicate = (Predicate<(string, HashSet<string>)>)(object)(Predicate<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			return ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate) != -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F60")]
		[Cpp2IlInjected.Address(RVA = "0xA3FF60", Offset = "0xA3E960", VA = "0x180A3FF60")]
		public bool WasEventReceivedDuringTag(string tagName, string eventName)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F61")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4F0", Offset = "0xA3DEF0", VA = "0x180A3F4F0")]
		private void CheckEnabled()
		{
			//Discarded unreachable code: IL_0060
			List<(string, HashSet<string>)> list = monitoredStates;
			List<(string, HashSet<string>)> list2 = monitoredTags;
			base.enabled = true;
			AnimationEventDispatcher animationEventDispatcher = _animationEventDispatcher;
			if ((object)animationEventDispatcher == null)
			{
				AnimationEventDispatcher component = GetComponent<AnimationEventDispatcher>();
			}
			_animationEventDispatcher = animationEventDispatcher;
			AnimationEventDispatcher.AnimationEventHandler b = OnAnimationEvent;
			AnimationEventDispatcher.AnimationEventHandler animationEvent = animationEventDispatcher.AnimationEvent;
			Delegate @delegate = Delegate.Combine(animationEvent, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != animationEvent)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F62")]
		[Cpp2IlInjected.Address(RVA = "0xA3F860", Offset = "0xA3E260", VA = "0x180A3F860")]
		private void OnAnimationEvent(string eventName, AnimationEventDispatcher.AnimationEventArgs args)
		{
			//Discarded unreachable code: IL_004a
			List<(string, HashSet<string>)> list = monitoredStates;
			int num = 0;
			int num2 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			List<(string, HashSet<string>)> list2 = monitoredStates;
			num++;
			uint num3 = num3 + 16;
			while (list2 != null)
			{
			}
			List<(string, HashSet<string>)> list3 = monitoredTags;
			int num4 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			List<(string, HashSet<string>)> list4 = monitoredTags;
			num++;
			num3 += 16;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F63")]
		[Cpp2IlInjected.Address(RVA = "0xA400A0", Offset = "0xA3EAA0", VA = "0x180A400A0")]
		public AnimatorMonitor()
		{
		}
	}
}
