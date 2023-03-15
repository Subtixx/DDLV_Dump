using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Device.Platform
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class GenericConnectivityStatusProvider
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly TimeSpan Interval;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static ConnectivityStatus connectivityStatus;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Action<ConnectivityStatus> callback;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static Timer timer;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static bool IsRunning
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x402D850", Offset = "0x402C250", VA = "0x18402D850")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static ConnectivityStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x402D8B0", Offset = "0x402C2B0", VA = "0x18402D8B0")]
			get
			{
				return connectivityStatus;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x402D910", Offset = "0x402C310", VA = "0x18402D910")]
			private set
			{
				//IL_001d: Expected O, but got I4
				GenericConnectivityStatusProvider.connectivityStatus = value;
				Action<ConnectivityStatus> action = callback;
				if (action != null)
				{
					ConnectivityStatus connectivityStatus = GenericConnectivityStatusProvider.connectivityStatus;
					action((T)connectivityStatus);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x402D410", Offset = "0x402BE10", VA = "0x18402D410")]
		public unsafe static void Start(Action<ConnectivityStatus> cb)
		{
			//IL_0012: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			Interval = (TimeSpan)cb;
			int num = default(int);
			TimerCallback timerCallback = new TimerCallback(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<object, void>*/)(&OnNetworkStatusCheckRoutine));
			num = 0;
			TimeSpan interval = Interval;
			int num2 = default(int);
			Timer interval2 = new Timer(timerCallback, num2, interval, interval);
			num2 = 0;
			Interval = (TimeSpan)interval2;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x402D5A0", Offset = "0x402BFA0", VA = "0x18402D5A0")]
		public static void Stop()
		{
			//Discarded unreachable code: IL_0024, IL_002a
			int num = 0;
			int initialState = default(int);
			AutoResetEvent autoResetEvent = new AutoResetEvent((byte)initialState != 0);
			initialState = 0;
			bool flag = timer.Dispose(autoResetEvent);
			bool flag2 = autoResetEvent.WaitOne();
			if (autoResetEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x402D2E0", Offset = "0x402BCE0", VA = "0x18402D2E0")]
		private static void OnNetworkStatusCheckRoutine(object state)
		{
			//IL_0023: Expected O, but got I4
			int num = 0;
			GenericConnectivityStatusProvider.connectivityStatus = GetConnectivityStatus();
			Action<ConnectivityStatus> action = callback;
			if (action != null)
			{
				ConnectivityStatus connectivityStatus = GenericConnectivityStatusProvider.connectivityStatus;
				action((T)connectivityStatus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x402D200", Offset = "0x402BC00", VA = "0x18402D200")]
		private static ConnectivityStatus GetConnectivityStatus()
		{
			int num = 0;
			NetworkInterfaceType activeNetworkType = GetActiveNetworkType();
			int num2 = (int)activeNetworkType;
			if (num2 != 1)
			{
				if (num2 <= 62)
				{
					goto IL_002d;
				}
				if (num2 > 71)
				{
					if (num2 == 117)
					{
						goto IL_0037;
					}
					if (activeNetworkType <= NetworkInterfaceType.Unknown)
					{
						return ConnectivityStatus.Mobile;
					}
				}
				else
				{
					if (num2 == 69)
					{
						goto IL_0037;
					}
					if (num2 == 71)
					{
						goto IL_002d;
					}
				}
				goto IL_0039;
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
			IL_0037:
			return ConnectivityStatus.Ethernet;
			IL_002d:
			if (num2 <= 71 && num2 < 71)
			{
				goto IL_0037;
			}
			goto IL_0039;
			IL_0039:
			return ConnectivityStatus.Unknown;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x402CBC0", Offset = "0x402B5C0", VA = "0x18402CBC0")]
		private static NetworkInterfaceType GetActiveNetworkType()
		{
			//Discarded unreachable code: IL_012e, IL_0134, IL_013a, IL_0146, IL_0158, IL_015e
			uint num6 = default(uint);
			uint num7 = default(uint);
			uint num8 = default(uint);
			Func<UnicastIPAddressInformation, bool> func = default(Func<UnicastIPAddressInformation, bool>);
			bool flag = default(bool);
			int num9 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				Func<NetworkInterface, bool> _003C_003E9__10_ = _003C_003Ec._003C_003E9__10_0;
				if (_003C_003E9__10_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((NetworkInterface info) => info.OperationalStatus == OperationalStatus.Up);
				}
				IEnumerable<NetworkInterface> enumerable = (IEnumerable<NetworkInterface>)Enumerable.Where<NetworkInterface>((IEnumerable<>)(object)allNetworkInterfaces, (Func<, >)(object)_003C_003E9__10_);
				UdpClient udpClient = new UdpClient("1.0.0.0", 1);
				int num3 = 0;
				EndPoint localEndPoint = udpClient.m_ClientSocket.LocalEndPoint;
				int num4 = 0;
				if (localEndPoint == null)
				{
					break;
				}
				int num5 = 0;
				if (localEndPoint != null)
				{
					IPAddress localAddr = (IPAddress)typeof(IPEndPoint).TypeHandle;
					if (num < (int)num6)
					{
						num += num;
						if (num == (int)num6)
						{
							goto IL_00d9;
						}
						num++;
					}
					if (num < (int)num7)
					{
						num += num;
						num++;
					}
					if (num != 0)
					{
						if (num < (int)num8)
						{
							num += num;
							if (num == (int)num8)
							{
								goto IL_00e9;
							}
							num++;
						}
						if (func == null)
						{
							func = (Func<UnicastIPAddressInformation, bool>)(object)(Func<T, TResult>)delegate(UnicastIPAddressInformation addr)
							{
								IPAddress iPAddress = localAddr;
								IPAddress address = addr.Address;
								throw new NullReferenceException();
							};
						}
						while (!flag)
						{
						}
						num++;
						goto IL_00d9;
					}
					goto IL_00f1;
				}
				throw new InvalidCastException();
				IL_00f1:
				num++;
				if (num != 0)
				{
					num9 = 0;
				}
				if (udpClient == null)
				{
					if (num != 0)
					{
						if (num9 == 199)
						{
						}
						if (num9 != 197)
						{
						}
					}
					if (udpClient != null)
					{
					}
					if (udpClient == null)
					{
						if (num != 0)
						{
						}
						throw new NullReferenceException();
					}
					continue;
				}
				throw new NullReferenceException();
				IL_00d9:
				num += 312;
				num += 312;
				goto IL_00e9;
				IL_00e9:
				num += 312;
				goto IL_00f1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x402D770", Offset = "0x402C170", VA = "0x18402D770")]
		private static ConnectivityStatus ToConnectivityStatus(NetworkInterfaceType ifaceType)
		{
			if (ifaceType <= NetworkInterfaceType.FastEthernetT)
			{
				goto IL_001b;
			}
			if (ifaceType > NetworkInterfaceType.Wireless80211)
			{
				if (ifaceType != NetworkInterfaceType.GigabitEthernet)
				{
					return ConnectivityStatus.Mobile;
				}
			}
			else if (ifaceType != NetworkInterfaceType.FastEthernetFx)
			{
				if (ifaceType == NetworkInterfaceType.Wireless80211)
				{
					goto IL_001b;
				}
				goto IL_0027;
			}
			goto IL_0025;
			IL_001b:
			if (ifaceType <= NetworkInterfaceType.Wireless80211 && ifaceType < NetworkInterfaceType.Wireless80211)
			{
				goto IL_0025;
			}
			goto IL_0027;
			IL_0025:
			return ConnectivityStatus.Ethernet;
			IL_0027:
			return ConnectivityStatus.Unknown;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x402D7C0", Offset = "0x402C1C0", VA = "0x18402D7C0")]
		static GenericConnectivityStatusProvider()
		{
			int num = 0;
			TimeSpan interval = default(TimeSpan);
			Interval = interval;
			connectivityStatus = GetConnectivityStatus();
		}
	}
}
