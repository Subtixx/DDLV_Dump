using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20006FB")]
	public abstract class AnimationEventDispatcher : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20006FC")]
		public delegate void AnimationEventHandler(string eventName, AnimationEventArgs args);

		[Cpp2IlInjected.Token(Token = "0x20006FD")]
		public class AnimationEventArgs : EventArgs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40028E0")]
			public readonly int? Int;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40028E1")]
			public readonly float? Float;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40028E2")]
			public readonly string String;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40028E3")]
			public readonly UnityEngine.Object Object;

			[Cpp2IlInjected.Token(Token = "0x6001F11")]
			[Cpp2IlInjected.Address(RVA = "0x156A900", Offset = "0x1569300", VA = "0x18156A900")]
			public AnimationEventArgs([System.Runtime.InteropServices.Optional] int? intParam, [System.Runtime.InteropServices.Optional] float? floatParam, [System.Runtime.InteropServices.Optional] string stringParam, [System.Runtime.InteropServices.Optional] UnityEngine.Object objectParam)
			{
				//IL_0022: Expected O, but got I4
				String = stringParam;
				Int = intParam;
				Float = floatParam;
				Object = (UnityEngine.Object)0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000045")]
		public event AnimationEventHandler AnimationEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001F03")]
			[Cpp2IlInjected.Address(RVA = "0xA3E130", Offset = "0xA3CB30", VA = "0x180A3E130")]
			[CompilerGenerated]
			add
			{
				AnimationEventHandler animationEvent = this.AnimationEvent;
				Delegate @delegate = Delegate.Combine(animationEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != animationEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001F04")]
			[Cpp2IlInjected.Address(RVA = "0xA3E1D0", Offset = "0xA3CBD0", VA = "0x180A3E1D0")]
			[CompilerGenerated]
			remove
			{
				AnimationEventHandler animationEvent = this.AnimationEvent;
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
		}

		[Cpp2IlInjected.Token(Token = "0x6001F05")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD00", Offset = "0xA3C700", VA = "0x180A3DD00")]
		protected void DispatchAnimationEvent([System.Runtime.InteropServices.Optional][CallerMemberName] string eventName)
		{
			AnimationEventArgs args = default(AnimationEventArgs);
			this.AnimationEvent?.Invoke(eventName, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F06")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC40", Offset = "0xA3C640", VA = "0x180A3DC40")]
		protected void DispatchAnimationEvent(int intParam, [System.Runtime.InteropServices.Optional][CallerMemberName] string eventName)
		{
			AnimationEventArgs args = default(AnimationEventArgs);
			this.AnimationEvent?.Invoke(eventName, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F07")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEF0", Offset = "0xA3C8F0", VA = "0x180A3DEF0")]
		protected void DispatchAnimationEvent(float floatParam, [System.Runtime.InteropServices.Optional][CallerMemberName] string eventName)
		{
			AnimationEventArgs args = default(AnimationEventArgs);
			this.AnimationEvent?.Invoke(eventName, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F08")]
		[Cpp2IlInjected.Address(RVA = "0xA3DE50", Offset = "0xA3C850", VA = "0x180A3DE50")]
		protected void DispatchAnimationEvent(string stringParam, [System.Runtime.InteropServices.Optional][CallerMemberName] string eventName)
		{
			AnimationEventArgs args = default(AnimationEventArgs);
			this.AnimationEvent?.Invoke(eventName, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F09")]
		[Cpp2IlInjected.Address(RVA = "0xA3DDB0", Offset = "0xA3C7B0", VA = "0x180A3DDB0")]
		protected void DispatchAnimationEvent(UnityEngine.Object objectParam, [System.Runtime.InteropServices.Optional][CallerMemberName] string eventName)
		{
			//IL_000a: Expected O, but got I4
			//IL_000a: Expected O, but got I4
			//IL_000a: Expected O, but got I4
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			AnimationEventArgs args = new AnimationEventArgs((Nullable<>)num, (Nullable<>)num2, (string)num3, objectParam);
			num3 = 0;
			num2 = 0;
			num = 0;
			this.AnimationEvent?.Invoke(eventName, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F0A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD90", Offset = "0xA3C790", VA = "0x180A3DD90")]
		private void DispatchAnimationEvent(string eventName, AnimationEventArgs eventArgs)
		{
			this.AnimationEvent?.Invoke(eventName, eventArgs);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F0B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFC0", Offset = "0xA3C9C0", VA = "0x180A3DFC0")]
		[AsyncStateMachine(typeof(_003CWaitForEvent_003Ed__11))]
		public Task<AnimationEventArgs> WaitForEvent(string eventName, CancellationToken ct, [System.Runtime.InteropServices.Optional] TimeSpan? timeout)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<AnimationEventArgs>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F0C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected AnimationEventDispatcher()
		{
		}
	}
}
