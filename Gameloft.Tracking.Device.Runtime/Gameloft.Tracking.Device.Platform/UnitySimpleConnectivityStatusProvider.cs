using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Gameloft.Tracking.Device.Platform
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class UnitySimpleConnectivityStatusProvider
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private class SimpleTimer : MonoBehaviour
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private Coroutine coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private Action callback;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x402EFF0", Offset = "0x402D9F0", VA = "0x18402EFF0")]
			public void Run(TimeSpan interval, Action callback)
			{
				//IL_001d: Expected I4, but got I8
				this.callback = callback;
				_003COnTick_003Ed__2 _003COnTick_003Ed__ = default(_003COnTick_003Ed__2);
				((IDisposable)_003COnTick_003Ed__).Dispose();
				_003COnTick_003Ed__._003C_003E4__this = this;
				_003COnTick_003Ed__._003C_003E1__state = 0;
				_003COnTick_003Ed__.interval = interval;
				Coroutine coroutine = (this.coroutine = StartCoroutine(_003COnTick_003Ed__));
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x402F090", Offset = "0x402DA90", VA = "0x18402F090")]
			public void Stop()
			{
				Coroutine routine = coroutine;
				StopCoroutine(routine);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x402EF70", Offset = "0x402D970", VA = "0x18402EF70")]
			[IteratorStateMachine(typeof(_003COnTick_003Ed__2))]
			private IEnumerator OnTick(TimeSpan interval)
			{
				//IL_0016: Expected I4, but got I8
				_003COnTick_003Ed__2 _003COnTick_003Ed__ = default(_003COnTick_003Ed__2);
				((IDisposable)_003COnTick_003Ed__).Dispose();
				_003COnTick_003Ed__._003C_003E4__this = this;
				_003COnTick_003Ed__._003C_003E1__state = 0;
				_003COnTick_003Ed__.interval = interval;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
			public SimpleTimer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly TimeSpan Interval;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static ConnectivityStatus connectivityStatus;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4030400", Offset = "0x402EE00", VA = "0x184030400")]
		private static ConnectivityStatus GetConnectivityStatus()
		{
			int num = 0;
			NetworkReachability internetReachability = Application.internetReachability;
			if (internetReachability != 0)
			{
				switch (internetReachability)
				{
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4030440", Offset = "0x402EE40", VA = "0x184030440")]
		static UnitySimpleConnectivityStatusProvider()
		{
			int num = 0;
			TimeSpan interval = default(TimeSpan);
			Interval = interval;
			NetworkReachability internetReachability = Application.internetReachability;
			if (internetReachability != 0)
			{
				switch (internetReachability)
				{
				}
			}
		}
	}
}
