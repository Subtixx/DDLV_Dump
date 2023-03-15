using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F32")]
	public class LiveopsManager : BaseOnlineManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003E03")]
		private readonly List<ILiveopsGroup> liveopsGroupInfos = (List<ILiveopsGroup>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170015B5")]
		public override double FetchDataIntervalTime
		{
			[Cpp2IlInjected.Token(Token = "0x6007CC1")]
			[Cpp2IlInjected.Address(RVA = "0x18AB270", Offset = "0x18A9C70", VA = "0x1818AB270", Slot = "4")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B6")]
		public override string LocalFileRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6007CC2")]
			[Cpp2IlInjected.Address(RVA = "0x18AB280", Offset = "0x18A9C80", VA = "0x1818AB280", Slot = "5")]
			get
			{
				return "liveops";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007CC3")]
		[Cpp2IlInjected.Address(RVA = "0x18AA720", Offset = "0x18A9120", VA = "0x1818AA720")]
		private string LiveopsGroupPath(string filename)
		{
			return Path.Combine(LocalFileRoot, filename);
		}

		[Cpp2IlInjected.Token(Token = "0x6007CC4")]
		[Cpp2IlInjected.Address(RVA = "0x18AAE80", Offset = "0x18A9880", VA = "0x1818AAE80")]
		public LiveopsManager(OnlineClient onlineClient)
			: base(onlineClient)
		{
			//Discarded unreachable code: IL_00d7
			List<ILiveopsGroup> list2 = liveopsGroupInfos;
			LiveopsGroupInfo<BattlePassSeasonData> liveopsGroupInfo = (LiveopsGroupInfo<BattlePassSeasonData>)(object)new LiveopsGroupInfo<T>(onlineClient)
			{
				LocalFilename = "battlepasses.dat"
			};
			Func<CancellationToken, Dictionary<string, BattlePassSeasonData>, Task<bool>> func = (Func<CancellationToken, Dictionary<string, BattlePassSeasonData>, Task<bool>>)(((LiveopsGroupInfo<>)(object)liveopsGroupInfo).OnDataLoadedAction = (Func<CancellationToken, Dictionary<string, T>, Task<bool>>)(object)(Func<T1, T2, TResult>)delegate
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder4 = AsyncTaskMethodBuilder<TResult>.Create();
				int num4 = 0;
				Task<> result4 = default(Task<>);
				return (Task<bool>)(object)result4;
			});
			Func<CancellationToken, List<KnownLiveopsItem>, Task<LiveopsGroupInfo<BattlePassSeasonData>.FetchActionResult>> func2 = (Func<CancellationToken, List<KnownLiveopsItem>, Task<LiveopsGroupInfo<BattlePassSeasonData>.FetchActionResult>>)(object)(((LiveopsGroupInfo<>)(object)liveopsGroupInfo).FetchAction = (Func<CancellationToken, List<KnownLiveopsItem>, Task<LiveopsGroupInfo<T>.FetchActionResult>>)(object)(Func<T1, T2, TResult>)delegate
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder3 = AsyncTaskMethodBuilder<TResult>.Create();
				int num3 = 0;
				Task<> result3 = default(Task<>);
				return (Task<LiveopsGroupInfo<BattlePassSeasonData>.FetchActionResult>)(object)result3;
			});
			((List<T>)(object)list2).Add((T)liveopsGroupInfo);
			List<ILiveopsGroup> list3 = liveopsGroupInfos;
			LiveopsGroupInfo<OnlineBundleData> liveopsGroupInfo2 = (LiveopsGroupInfo<OnlineBundleData>)(object)new LiveopsGroupInfo<T>(onlineClient)
			{
				LocalFilename = "bundles.dat"
			};
			Func<CancellationToken, List<KnownLiveopsItem>, Task<LiveopsGroupInfo<OnlineBundleData>.FetchActionResult>> func3 = (Func<CancellationToken, List<KnownLiveopsItem>, Task<LiveopsGroupInfo<OnlineBundleData>.FetchActionResult>>)(object)(((LiveopsGroupInfo<>)(object)liveopsGroupInfo2).FetchAction = (Func<CancellationToken, List<KnownLiveopsItem>, Task<LiveopsGroupInfo<T>.FetchActionResult>>)(object)(Func<T1, T2, TResult>)delegate
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder2 = AsyncTaskMethodBuilder<TResult>.Create();
				int num2 = 0;
				Task<> result2 = default(Task<>);
				return (Task<LiveopsGroupInfo<OnlineBundleData>.FetchActionResult>)(object)result2;
			});
			((List<T>)(object)list3).Add((T)liveopsGroupInfo2);
			List<ILiveopsGroup> list4 = liveopsGroupInfos;
			LiveopsGroupInfo<OnlineStoreData> liveopsGroupInfo3 = (LiveopsGroupInfo<OnlineStoreData>)(object)new LiveopsGroupInfo<T>(onlineClient)
			{
				LocalFilename = "stores.dat"
			};
			Func<CancellationToken, List<KnownLiveopsItem>, Task<LiveopsGroupInfo<OnlineStoreData>.FetchActionResult>> func4 = (Func<CancellationToken, List<KnownLiveopsItem>, Task<LiveopsGroupInfo<OnlineStoreData>.FetchActionResult>>)(object)(((LiveopsGroupInfo<>)(object)liveopsGroupInfo3).FetchAction = (Func<CancellationToken, List<KnownLiveopsItem>, Task<LiveopsGroupInfo<T>.FetchActionResult>>)(object)(Func<T1, T2, TResult>)delegate
			{
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				int num = 0;
				Task<> result = default(Task<>);
				return (Task<LiveopsGroupInfo<OnlineStoreData>.FetchActionResult>)(object)result;
			});
			((List<T>)(object)list4).Add((T)liveopsGroupInfo3);
		}

		[Cpp2IlInjected.Token(Token = "0x6007CC5")]
		[Cpp2IlInjected.Address(RVA = "0x18AA7C0", Offset = "0x18A91C0", VA = "0x1818AA7C0", Slot = "6")]
		[AsyncStateMachine(typeof(_003CLoad_003Ed__7))]
		protected override Task<bool> Load(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007CC6")]
		[Cpp2IlInjected.Address(RVA = "0x18AA490", Offset = "0x18A8E90", VA = "0x1818AA490")]
		[AsyncStateMachine(typeof(_003CFetchAndSave_003Ed__8))]
		private Task FetchAndSave(ILiveopsGroup liveopsGroup, bool forceSave, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007CC7")]
		[Cpp2IlInjected.Address(RVA = "0x18AA5E0", Offset = "0x18A8FE0", VA = "0x1818AA5E0", Slot = "7")]
		[AsyncStateMachine(typeof(_003CFetchAndSave_003Ed__9))]
		protected override Task FetchAndSave(bool forceSave, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007CC8")]
		[Cpp2IlInjected.Address(RVA = "0x19C3060", Offset = "0x19C1A60", VA = "0x1819C3060")]
		public ILiveopsGroup GetGroup<T>()
		{
			Func<ILiveopsGroup, bool> func = default(Func<ILiveopsGroup, bool>);
			return Enumerable.FirstOrDefault<ILiveopsGroup>((IEnumerable<>)liveopsGroupInfos, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6007CC9")]
		[Cpp2IlInjected.Address(RVA = "0x19C2F50", Offset = "0x19C1950", VA = "0x1819C2F50")]
		public List<T> GetData<T>() where T : IFetchable
		{
			//Discarded unreachable code: IL_001c
			if ((object)typeof(ILiveopsGroup).TypeHandle != null)
			{
			}
			if ((object)typeof(ILiveopsGroup).TypeHandle != null)
			{
				return (List<T>)typeof(ILiveopsGroup).TypeHandle;
			}
			return (List<T>)typeof(ILiveopsGroup).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6007CCA")]
		[Cpp2IlInjected.Address(RVA = "0x19C2E10", Offset = "0x19C1810", VA = "0x1819C2E10")]
		[AsyncStateMachine(typeof(_003CFetchAndGetData_003Ed__12<>))]
		public Task<List<T>> FetchAndGetData<T>(CancellationToken ct) where T : IFetchable
		{
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<List<T>>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007CCB")]
		[Cpp2IlInjected.Address(RVA = "0x19C2CC0", Offset = "0x19C16C0", VA = "0x1819C2CC0")]
		[AsyncStateMachine(typeof(_003CFetchAndGetDataWithId_003Ed__13<>))]
		public Task<Dictionary<string, T>> FetchAndGetDataWithId<T>(CancellationToken ct) where T : IFetchable
		{
			int num = 0;
			int num2 = 0;
			Task<> result = default(Task<>);
			return (Task<Dictionary<string, T>>)(object)result;
		}
	}
}
