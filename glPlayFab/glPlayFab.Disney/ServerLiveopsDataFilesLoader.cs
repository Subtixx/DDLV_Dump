using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	public abstract class ServerLiveopsDataFilesLoader : IServerDataFilesLoader
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		protected ConcurrentDictionary<ServerDataType, List<IServerDataConfig>> loadedConfigs;

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public abstract bool IsDebug
		{
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x14F5DA0", Offset = "0x14F47A0", VA = "0x1814F5DA0", Slot = "5")]
		public List<IServerDataConfig> GetConfigsByType(ServerDataType dataType)
		{
			ConcurrentDictionary<ServerDataType, List<IServerDataConfig>> concurrentDictionary = loadedConfigs;
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x1B22A80", Offset = "0x1B21480", VA = "0x181B22A80")]
		protected void SetConfigsByType<T>(ServerDataType serverDataType, List<T> configs) where T : IServerDataConfig
		{
			//Discarded unreachable code: IL_0014
			ConcurrentDictionary<ServerDataType, List<IServerDataConfig>> concurrentDictionary = loadedConfigs;
			List<IServerDataConfig> list = (List<IServerDataConfig>)(object)Enumerable.ToList<IServerDataConfig>(Enumerable.Cast<IServerDataConfig>((IEnumerable)configs));
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x14F5E20", Offset = "0x14F4820", VA = "0x1814F5E20", Slot = "4")]
		public ServerDataResult Load()
		{
			//Discarded unreachable code: IL_0086
			//IL_0016: Expected I4, but got I8
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.serverDataResult = ServerDataResult.Success;
			ServerDataResult serverDataResult = (CS_0024_003C_003E8__locals0.serverDataResult = PreLoad());
			if (serverDataResult == ServerDataResult.Success)
			{
				ConcurrentDictionary<ServerDataType, List<IServerDataConfig>> concurrentDictionary = (loadedConfigs = (ConcurrentDictionary<ServerDataType, List<IServerDataConfig>>)(object)new ConcurrentDictionary<TKey, TValue>());
				Func<ServerDataResult> func = (Func<ServerDataResult>)(object)(Func<TResult>)delegate
				{
					bool isDebug3 = CS_0024_003C_003E8__locals0._003C_003E4__this.IsDebug;
					throw new NullReferenceException();
				};
				CS_0024_003C_003E8__locals0._003CLoad_003Eg__LoadData_007C3((Func<>)(object)func);
				Func<ServerDataResult> func2 = (Func<ServerDataResult>)(object)(Func<TResult>)delegate
				{
					bool isDebug2 = CS_0024_003C_003E8__locals0._003C_003E4__this.IsDebug;
					throw new NullReferenceException();
				};
				CS_0024_003C_003E8__locals0._003CLoad_003Eg__LoadData_007C3((Func<>)(object)func2);
				Func<ServerDataResult> func3 = (Func<ServerDataResult>)(object)(Func<TResult>)delegate
				{
					bool isDebug = CS_0024_003C_003E8__locals0._003C_003E4__this.IsDebug;
					throw new NullReferenceException();
				};
				CS_0024_003C_003E8__locals0._003CLoad_003Eg__LoadData_007C3((Func<>)(object)func3);
				if (CS_0024_003C_003E8__locals0.serverDataResult == ServerDataResult.Success)
				{
					PostLoad();
				}
			}
			return serverDataResult;
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "8")]
		protected virtual ServerDataResult PreLoad()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "9")]
		protected virtual void PostLoad()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract ServerDataResult LoadBattlePasses();

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract ServerDataResult LoadBundles();

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract ServerDataResult LoadStores();

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected ServerLiveopsDataFilesLoader()
		{
			PostLoad();
		}
	}
}
