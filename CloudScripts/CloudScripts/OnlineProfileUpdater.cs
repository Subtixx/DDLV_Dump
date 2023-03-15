using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using glPlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	public class OnlineProfileUpdater
	{
		[Cpp2IlInjected.Token(Token = "0x2000136")]
		public class StaticContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public OnlineEnvironment OnlineEnv;

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x39304E0", Offset = "0x392EEE0", VA = "0x1839304E0")]
			public static bool IsOnlineEnvDebug(StaticContext ctx)
			{
				if (ctx == null)
				{
					int num = 0;
				}
				return ctx.OnlineEnv == OnlineEnvironment.Debug;
			}

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x39304F0", Offset = "0x392EEF0", VA = "0x1839304F0")]
			public static bool IsOnlineEnvDev(StaticContext ctx)
			{
				if (ctx == null)
				{
					int num = 0;
				}
				return ctx.OnlineEnv == OnlineEnvironment.Dev;
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x39304C0", Offset = "0x392EEC0", VA = "0x1839304C0")]
			public static bool IsOnlineEnvDebugOrDev(StaticContext ctx)
			{
				if (ctx != null)
				{
					OnlineEnvironment onlineEnv = ctx.OnlineEnv;
					if (onlineEnv == OnlineEnvironment.Debug)
					{
					}
					return onlineEnv == OnlineEnvironment.Dev;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public StaticContext()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000137")]
		public class ClientContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public bool IsDebugBuildType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			public string RuntimePlatformName;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x392E4B0", Offset = "0x392CEB0", VA = "0x18392E4B0")]
			public static bool IsDebugBuild(ClientContext ctx)
			{
				if (ctx == null)
				{
					int num = 0;
				}
				return ctx.IsDebugBuildType;
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x392E4C0", Offset = "0x392CEC0", VA = "0x18392E4C0")]
			private static bool IsPlatform(ClientContext ctx, string platformName)
			{
				if (ctx != null)
				{
					string runtimePlatformName = ctx.RuntimePlatformName;
					return ctx.RuntimePlatformName.Equals(platformName);
				}
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x392E3E0", Offset = "0x392CDE0", VA = "0x18392E3E0")]
			public static bool IsDebugBuildAndHeadlessProject(ClientContext ctx)
			{
				if (ctx != null && ctx.IsDebugBuildType)
				{
					string runtimePlatformName = ctx.RuntimePlatformName;
					string headlessProject = RuntimePlatformNames.HeadlessProject;
					if (!string.IsNullOrEmpty(runtimePlatformName) && !string.IsNullOrEmpty(headlessProject))
					{
						return ctx.RuntimePlatformName.Equals(headlessProject);
					}
					int num = 0;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ClientContext()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private StaticContext CurrentStaticContext;

		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public static readonly int MaximumNumberOfChain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private List<OnlineProfileUpdate> profileUpdatesSorted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private List<OnlineProfileUpdate> recurringProfileUpdates;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public int MaxOnlineVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x11707D0", Offset = "0x116F1D0", VA = "0x1811707D0")]
			get
			{
				OnlineProfileUpdate onlineProfileUpdate;
				do
				{
					onlineProfileUpdate = Enumerable.LastOrDefault<OnlineProfileUpdate>((IEnumerable<>)profileUpdatesSorted);
				}
				while (onlineProfileUpdate == null);
				return onlineProfileUpdate.OnlineVersion;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40005D4")]
		public int CurrentMaximumNumberOfChain
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1170410", Offset = "0x116EE10", VA = "0x181170410")]
		private IEnumerable<OnlineProfileUpdate> ProfilesUpdatesSortedFor(ClientContext ctx)
		{
			//Discarded unreachable code: IL_0029
			List<OnlineProfileUpdate> list = profileUpdatesSorted;
			Func<OnlineProfileUpdate, bool> func = (Func<OnlineProfileUpdate, bool>)(object)(Func<T, TResult>)delegate(OnlineProfileUpdate x)
			{
				//Discarded unreachable code: IL_001c
				//IL_001c: Expected I4, but got O
				Func<ClientContext, bool> _003CClientContextCondFunc_003Ek__BackingField = x.ClientContextCondFunc;
				if (_003CClientContextCondFunc_003Ek__BackingField != null)
				{
					ClientContext arg = ctx;
					return (byte)(int)_003CClientContextCondFunc_003Ek__BackingField((T)arg) != 0;
				}
				return true;
			};
			return (IEnumerable<OnlineProfileUpdate>)Enumerable.Where<OnlineProfileUpdate>((IEnumerable<>)list, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1170500", Offset = "0x116EF00", VA = "0x181170500")]
		private IEnumerable<OnlineProfileUpdate> RecurringProfilesUpdatesSortedFor(ClientContext ctx)
		{
			//Discarded unreachable code: IL_0029
			List<OnlineProfileUpdate> list = recurringProfileUpdates;
			Func<OnlineProfileUpdate, bool> func = (Func<OnlineProfileUpdate, bool>)(object)(Func<T, TResult>)delegate(OnlineProfileUpdate x)
			{
				//Discarded unreachable code: IL_001c
				//IL_001c: Expected I4, but got O
				Func<ClientContext, bool> _003CClientContextCondFunc_003Ek__BackingField = x.ClientContextCondFunc;
				if (_003CClientContextCondFunc_003Ek__BackingField != null)
				{
					ClientContext arg = ctx;
					return (byte)(int)_003CClientContextCondFunc_003Ek__BackingField((T)arg) != 0;
				}
				return true;
			};
			return (IEnumerable<OnlineProfileUpdate>)Enumerable.Where<OnlineProfileUpdate>((IEnumerable<>)list, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x116FB50", Offset = "0x116E550", VA = "0x18116FB50")]
		public bool HasAnyUpdate(int onlineVersion)
		{
			//Discarded unreachable code: IL_001a
			List<OnlineProfileUpdate> cpp2il__autoParamName__idx_ = profileUpdatesSorted;
			int num = 0;
			OnlineProfileUpdate onlineProfileUpdate = ((IEnumerable<>)cpp2il__autoParamName__idx_).Last<OnlineProfileUpdate>();
			return onlineVersion < onlineProfileUpdate.OnlineVersion;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x26D0E00", Offset = "0x26CF800", VA = "0x1826D0E00")]
		private void AddUpdate<T>(int P_0, int P_1, bool P_2, Func<, > P_3, Func<, > P_4) where T : OnlineProfileUpdate, new()
		{
			//Discarded unreachable code: IL_0013
			StaticContext currentStaticContext = CurrentStaticContext;
			bool flag = default(bool);
			if (flag)
			{
				List<OnlineProfileUpdate> list = profileUpdatesSorted;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x26D0D30", Offset = "0x26CF730", VA = "0x1826D0D30")]
		private void AddRecurringUpdate<T>(Func<, > P_0, Func<, > P_1) where T : OnlineProfileUpdate, new()
		{
			//Discarded unreachable code: IL_001d
			if (P_0 != null)
			{
				StaticContext currentStaticContext = CurrentStaticContext;
				if (P_0((T)currentStaticContext) == null)
				{
					return;
				}
			}
			List<OnlineProfileUpdate> list = recurringProfileUpdates;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1170630", Offset = "0x116F030", VA = "0x181170630")]
		internal unsafe OnlineProfileUpdater(StaticContext staticContext)
		{
			//IL_0041: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			List<OnlineProfileUpdate> list = (profileUpdatesSorted = (List<OnlineProfileUpdate>)(object)new List<T>());
			List<OnlineProfileUpdate> list2 = (recurringProfileUpdates = (List<OnlineProfileUpdate>)(object)new List<T>());
			AddUpdate3ProfileUpdateHotFixes();
			CurrentStaticContext = staticContext;
			if (StaticContext.IsOnlineEnvDebugOrDev(CurrentStaticContext))
			{
				int num = default(int);
				Func<StaticContext, bool> func = (Func<StaticContext, bool>)(object)new Func<T, TResult>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<StaticContext, bool>*/)(&StaticContext.IsOnlineEnvDebugOrDev));
				num = 0;
				int num2 = default(int);
				Func<ClientContext, bool> func2 = (Func<ClientContext, bool>)(object)new Func<T, TResult>(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<ClientContext, bool>*/)(&ClientContext.IsDebugBuild));
				num2 = 0;
				AddRecurringUpdate<AddDevInboxMessageOnEveryContinueGame>((Func<, >)(object)func, (Func<, >)(object)func2);
			}
			PostInit();
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x116FBD0", Offset = "0x116E5D0", VA = "0x18116FBD0")]
		public void PostInit()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void AddUpdate3ProfileUpdateHotFixes()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x116F770", Offset = "0x116E170", VA = "0x18116F770")]
		private unsafe void AddPermanentDebugTests()
		{
			//IL_001a: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			if (StaticContext.IsOnlineEnvDebugOrDev(CurrentStaticContext))
			{
				int num = default(int);
				Func<StaticContext, bool> func = (Func<StaticContext, bool>)(object)new Func<T, TResult>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<StaticContext, bool>*/)(&StaticContext.IsOnlineEnvDebugOrDev));
				num = 0;
				int num2 = default(int);
				Func<ClientContext, bool> func2 = (Func<ClientContext, bool>)(object)new Func<T, TResult>(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<ClientContext, bool>*/)(&ClientContext.IsDebugBuild));
				num2 = 0;
				AddRecurringUpdate<AddDevInboxMessageOnEveryContinueGame>((Func<, >)(object)func, (Func<, >)(object)func2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x116F870", Offset = "0x116E270", VA = "0x18116F870")]
		public unsafe void AddUnitTestDummyDebugPotatoesTests()
		{
			//Discarded unreachable code: IL_00c2
			//IL_0028: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			if (StaticContext.IsOnlineEnvDebug(CurrentStaticContext))
			{
				((List<T>)(object)profileUpdatesSorted).Clear();
				int num = default(int);
				Func<StaticContext, bool> func = (Func<StaticContext, bool>)(object)new Func<T, TResult>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<StaticContext, bool>*/)(&StaticContext.IsOnlineEnvDebug));
				num = 0;
				int num2 = default(int);
				Func<ClientContext, bool> func2 = (Func<ClientContext, bool>)(object)new Func<T, TResult>(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<ClientContext, bool>*/)(&ClientContext.IsDebugBuildAndHeadlessProject));
				num2 = 0;
				int num3 = 0;
				AddUpdate<DummyDebugSetPlayerNameToPotato>(int.MaxValue, 1, (byte)num3 != 0, (Func<, >)(object)func, (Func<, >)(object)func2);
				int num4 = default(int);
				Func<StaticContext, bool> func3 = (Func<StaticContext, bool>)(object)new Func<T, TResult>(num4, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<StaticContext, bool>*/)(&StaticContext.IsOnlineEnvDebug));
				num4 = 0;
				int num5 = default(int);
				Func<ClientContext, bool> func4 = (Func<ClientContext, bool>)(object)new Func<T, TResult>(num5, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<ClientContext, bool>*/)(&ClientContext.IsDebugBuildAndHeadlessProject));
				num5 = 0;
				AddUpdate<DummyDebugAddHelloWorldInKeyChain>(int.MaxValue, 2, true, (Func<, >)(object)func3, (Func<, >)(object)func4);
				int num6 = default(int);
				Func<StaticContext, bool> func5 = (Func<StaticContext, bool>)(object)new Func<T, TResult>(num6, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<StaticContext, bool>*/)(&StaticContext.IsOnlineEnvDebug));
				num6 = 0;
				int num7 = default(int);
				Func<ClientContext, bool> func6 = (Func<ClientContext, bool>)(object)new Func<T, TResult>(num7, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<ClientContext, bool>*/)(&ClientContext.IsDebugBuildAndHeadlessProject));
				num7 = 0;
				int num8 = 0;
				AddUpdate<DummyDebugReplaceSettingsWithPotatoes>(int.MaxValue, 3, (byte)num8 != 0, (Func<, >)(object)func5, (Func<, >)(object)func6);
				PostInit();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x116FAD0", Offset = "0x116E4D0", VA = "0x18116FAD0")]
		public ClientContext ClientContextFromRequest(PreGameLoad.HandShake.Request request)
		{
			//Discarded unreachable code: IL_0024
			ClientContext clientContext = new ClientContext();
			bool flag = (clientContext.IsDebugBuildType = request.IsDebugBuildType);
			string text = (clientContext.RuntimePlatformName = request.RunningPlatformName);
			return clientContext;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x116F290", Offset = "0x116DC90", VA = "0x18116F290")]
		public void AddOnlineProfileUpdaterToRequestData(PreGameLoad.HandShake.Request request, PreGameLoad.HandShake.Result result)
		{
			//IL_014a: Expected I4, but got I8
			//IL_014a: Expected O, but got I4
			int version;
			bool flag2 = default(bool);
			ulong num10 = default(ulong);
			do
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				version = request.Version;
				int clientOnlineVersion = request.OnlineVersion;
				ClientContext clientContext = new ClientContext();
				bool flag = (clientContext.IsDebugBuildType = request.IsDebugBuildType);
				string text = (clientContext.RuntimePlatformName = request.RunningPlatformName);
				List<OnlineProfileUpdate> list = profileUpdatesSorted;
				PreGameLoad.HandShake.Result result2 = result;
				if (version - 1 <= 174)
				{
					int num4 = clientOnlineVersion;
					int maxOnlineVersion = MaxOnlineVersion;
					int num5 = clientOnlineVersion;
					OnlineProfileUpdate onlineProfileUpdate = ((IEnumerable<>)profileUpdatesSorted).Last<OnlineProfileUpdate>();
					if (num5 < onlineProfileUpdate.OnlineVersion)
					{
						int num6 = CurrentMaximumNumberOfChain;
						int num7 = clientOnlineVersion;
						int maxOnlineVersion2 = MaxOnlineVersion;
					}
					PreGameLoad.HandShake.Result result3 = result.WithStatus(PreGameLoad.HandShake.Status.NoUpdateProfileVersionUpToDate);
					List<OnlineProfileUpdate> list2 = (List<OnlineProfileUpdate>)(object)Enumerable.ToList<OnlineProfileUpdate>(this.ProfilesUpdatesSortedFor(clientContext));
					PreGameLoad.HandShake.Result result4 = result.WithStatus(PreGameLoad.HandShake.Status.NoUpdateAvailableForThisClientContext);
					Predicate<OnlineProfileUpdate> predicate = (Predicate<OnlineProfileUpdate>)(object)(Predicate<T>)delegate(OnlineProfileUpdate x)
					{
						//Discarded unreachable code: IL_0011
						int _003COnlineVersion_003Ek__BackingField = x.OnlineVersion;
						return clientOnlineVersion < _003COnlineVersion_003Ek__BackingField;
					};
					int num8 = ((List<T>)(object)list2).FindIndex((Predicate<>)(object)predicate);
					int size = ((List<>)(object)profileUpdatesSorted)._size;
					if (num8 < size)
					{
						List<OnlineProfileUpdate> list3 = profileUpdatesSorted;
						int num9 = 0;
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						num8++;
						num8++;
					}
					List<OnlineProfileUpdate> list4 = (List<OnlineProfileUpdate>)(object)Enumerable.ToList<OnlineProfileUpdate>(this.RecurringProfilesUpdatesSortedFor(clientContext));
					if (!flag2)
					{
						continue;
					}
					AddProfileUpdateToResult((OnlineProfileUpdate)num2, (byte)num10 != 0);
					PreGameLoad.HandShake.Result result5 = result.WithStatus(PreGameLoad.HandShake.Status.TooManyChainInProfilerUpdater);
					PreGameLoad.HandShake.Result result6 = result.WithStatus(PreGameLoad.HandShake.Status.InvalidOnlineVersion);
				}
				PreGameLoad.HandShake.Result result7 = result.WithStatus(PreGameLoad.HandShake.Status.InvalidVersion);
				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0x3933170", Offset = "0x3931B70", VA = "0x183933170")]
				void AddProfileUpdateToResult(OnlineProfileUpdate profileUpdateToAdd, bool isRecurring)
				{
					//Discarded unreachable code: IL_004d
					//IL_004c: Expected I4, but got I8
					PreGameLoad.OnlineProfileUpdaterTransferData item = profileUpdateToAdd.ListRequiredData();
					PreGameLoad.HandShake.Result result8 = result;
					if ((long)result8.RequestedData == 0)
					{
						List<PreGameLoad.OnlineProfileUpdaterTransferData> list5 = (result8.RequestedData = (List<PreGameLoad.OnlineProfileUpdaterTransferData>)(object)new List<T>());
					}
					((List<T>)(object)result8.RequestedData).Add((T)item);
					PreGameLoad.HandShake.Result result9 = result;
					if (!isRecurring)
					{
					}
					result.Status = PreGameLoad.HandShake.Status.UpdateAvailable;
				}
			}
			while (version != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x116FFF0", Offset = "0x116E9F0", VA = "0x18116FFF0")]
		public void ProcessRequestedData(PreGameLoad.SendRequestedData.Request request, PreGameLoad.SendRequestedData.Result result)
		{
			//Discarded unreachable code: IL_0126, IL_012c, IL_0132, IL_0138, IL_013e, IL_0144, IL_014a
			//IL_0030: Expected O, but got I4
			int num = (result.NewOnlineVersion = request.HandShakeRequest.OnlineVersion);
			List<PreGameLoad.OnlineProfileUpdaterTransferData> clientDataToFix = request.ClientDataToFix;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			PreGameLoad.OnlineProfileUpdaterTransferData receivedData = (PreGameLoad.OnlineProfileUpdaterTransferData)0;
			PreGameLoad.HandShake.Request handShakeRequest = request.HandShakeRequest;
			ClientContext clientContext = new ClientContext();
			bool flag2 = (clientContext.IsDebugBuildType = handShakeRequest.IsDebugBuildType);
			string text = (clientContext.RuntimePlatformName = handShakeRequest.RunningPlatformName);
			List<OnlineProfileUpdate> list = (List<OnlineProfileUpdate>)(object)Enumerable.ToList<OnlineProfileUpdate>(this.ProfilesUpdatesSortedFor(clientContext));
			Predicate<OnlineProfileUpdate> predicate = (Predicate<OnlineProfileUpdate>)(object)(Predicate<T>)delegate(OnlineProfileUpdate x)
			{
				//Discarded unreachable code: IL_001d
				PreGameLoad.OnlineProfileUpdaterTransferData onlineProfileUpdaterTransferData3 = receivedData;
				string uniqueName2 = x.UniqueName;
				string name2 = onlineProfileUpdaterTransferData3.Name;
				return uniqueName2.Equals(name2);
			};
			OnlineProfileUpdate onlineProfileUpdate = (OnlineProfileUpdate)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			if (onlineProfileUpdate == null)
			{
				IEnumerable<OnlineProfileUpdate> enumerable = default(IEnumerable<OnlineProfileUpdate>);
				List<OnlineProfileUpdate> list2 = (List<OnlineProfileUpdate>)(object)Enumerable.ToList<OnlineProfileUpdate>((IEnumerable<>)enumerable);
				Predicate<OnlineProfileUpdate> predicate2 = (Predicate<OnlineProfileUpdate>)(object)(Predicate<T>)delegate(OnlineProfileUpdate x)
				{
					//Discarded unreachable code: IL_001d
					PreGameLoad.OnlineProfileUpdaterTransferData onlineProfileUpdaterTransferData2 = receivedData;
					string uniqueName = x.UniqueName;
					string name = onlineProfileUpdaterTransferData2.Name;
					return uniqueName.Equals(name);
				};
				if (((List<T>)(object)list2).Find((Predicate<>)(object)predicate2) == null)
				{
					PreGameLoad.OnlineProfileUpdaterTransferData onlineProfileUpdaterTransferData = receivedData;
				}
			}
			PreGameLoad.OnlineProfileUpdaterTransferData data = receivedData;
			PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult processingResult = onlineProfileUpdate.ProcessRequiredData(data);
			if (processingResult != PreGameLoad.OnlineProfileUpdaterTransferData.ProcessingResult.ProcessingOk)
			{
				PreGameLoad.SendRequestedData.Result result2 = result.WithError(PreGameLoad.SendRequestedData.Error.Failed);
			}
			int _003CNewOnlineVersion_003Ek__BackingField = result.NewOnlineVersion;
			result.NewOnlineVersion = (int)processingResult;
			if ((long)result.FixedData == 0)
			{
				List<PreGameLoad.OnlineProfileUpdaterTransferData> list3 = (result.FixedData = (List<PreGameLoad.OnlineProfileUpdaterTransferData>)(object)new List<T>());
			}
			List<PreGameLoad.OnlineProfileUpdaterTransferData> fixedData = result.FixedData;
			PreGameLoad.OnlineProfileUpdaterTransferData item = receivedData;
			((List<T>)(object)fixedData).Add((T)item);
		}
	}
}
