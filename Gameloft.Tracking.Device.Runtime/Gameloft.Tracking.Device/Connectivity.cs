using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Gameloft.Tracking.Device.Platform;
using UnityEngine;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class Connectivity
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static ConnectivityStatus cachedStatus;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static SynchronizationContext syncContext;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static ConnectivityStatus CurrentStatus
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x402C050", Offset = "0x402AA50", VA = "0x18402C050")]
			get
			{
				return cachedStatus;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x402C1B0", Offset = "0x402ABB0", VA = "0x18402C1B0")]
			private set
			{
				//Discarded unreachable code: IL_0010
				int num = 0;
				cachedStatus = value;
				ReportConnectivityStatus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event EventHandler<ConnectivityStatus> OnConnectivityStatusChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x402BF50", Offset = "0x402A950", VA = "0x18402BF50")]
			[CompilerGenerated]
			add
			{
				EventHandler<ConnectivityStatus> onConnectivityStatusChanged = Connectivity.OnConnectivityStatusChanged;
				Delegate @delegate = Delegate.Combine(onConnectivityStatusChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConnectivityStatusChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x402C0B0", Offset = "0x402AAB0", VA = "0x18402C0B0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<ConnectivityStatus> onConnectivityStatusChanged = Connectivity.OnConnectivityStatusChanged;
				Delegate @delegate = Delegate.Remove(onConnectivityStatusChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConnectivityStatusChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x402BDE0", Offset = "0x402A7E0", VA = "0x18402BDE0")]
		static Connectivity()
		{
			//Discarded unreachable code: IL_0020
			int num = 0;
			Connectivity.OnConnectivityStatusChanged = (EventHandler<ConnectivityStatus>)(object)SynchronizationContext.Current;
			ConnectivityStatus connectivityStatus = GenericConnectivityStatusProvider.connectivityStatus;
			int num2 = 0;
			cachedStatus = connectivityStatus;
			ReportConnectivityStatus();
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x402BAF0", Offset = "0x402A4F0", VA = "0x18402BAF0")]
		public unsafe static void StartObserving()
		{
			//IL_0031: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			Action<ConnectivityStatus> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
			if (_003C_003E9__7_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(ConnectivityStatus status)
				{
					//Discarded unreachable code: IL_0023
					SynchronizationContext synchronizationContext = syncContext;
					SendOrPostCallback sendOrPostCallback = delegate
					{
						int num3 = (int)status;
					};
				};
			}
			GenericConnectivityStatusProvider.Interval = (TimeSpan)_003C_003E9__7_;
			int num = default(int);
			TimerCallback callback = new TimerCallback(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<object, void>*/)(&GenericConnectivityStatusProvider.OnNetworkStatusCheckRoutine));
			num = 0;
			TimeSpan interval = GenericConnectivityStatusProvider.Interval;
			int num2 = default(int);
			Timer interval2 = new Timer(callback, num2, interval, interval);
			num2 = 0;
			GenericConnectivityStatusProvider.Interval = (TimeSpan)interval2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x402BD90", Offset = "0x402A790", VA = "0x18402BD90")]
		public static void StopObserving()
		{
			int num = 0;
			GenericConnectivityStatusProvider.Stop();
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x402B980", Offset = "0x402A380", VA = "0x18402B980")]
		private static void ReportConnectivityStatus()
		{
			//IL_0023: Expected O, but got I4
			EventHandler<ConnectivityStatus> onConnectivityStatusChanged = Connectivity.OnConnectivityStatusChanged;
			if (onConnectivityStatusChanged != null)
			{
				Type typeFromHandle = typeof(Connectivity);
				ConnectivityStatus connectivityStatus = cachedStatus;
				onConnectivityStatusChanged(typeFromHandle, (TEventArgs)connectivityStatus);
			}
			string message = default(string);
			Debug.Log(message);
		}
	}
}
