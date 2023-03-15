using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public class PortalLiveopsGameData : ServerLiveopsDataFilesLoader
	{
		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public static PortalLiveopsGameData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x14F48C0", Offset = "0x14F32C0", VA = "0x1814F48C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x14F4A20", Offset = "0x14F3420", VA = "0x1814F4A20")]
			[CompilerGenerated]
			private set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public override bool IsDebug
		{
			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "7")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public string DirPath
		{
			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x14F4900", Offset = "0x14F3300", VA = "0x1814F4900")]
			get
			{
				int num = 0;
				if (Debugger.IsAttached)
				{
					int num2 = 0;
					string text = Path.Combine(Directory.GetCurrentDirectory(), "..", "Data");
				}
				return Path.Combine("Data", "Liveops");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x14F4840", Offset = "0x14F3240", VA = "0x1814F4840", Slot = "8")]
		protected override ServerDataResult PreLoad()
		{
			if (Directory.Exists(DirPath))
			{
				int num = 0;
				return ServerDataResult.AlreadyLoaded;
			}
			return ServerDataResult.DirectoryNotFound;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x14F47F0", Offset = "0x14F31F0", VA = "0x1814F47F0", Slot = "9")]
		protected override void PostLoad()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x14F45B0", Offset = "0x14F2FB0", VA = "0x1814F45B0", Slot = "10")]
		protected override ServerDataResult LoadBattlePasses()
		{
			string cpp2il__autoParamName__idx_ = Path.Combine(DirPath, "BattlePasses");
			int cpp2il__autoParamName__idx_2 = 0;
			return LoadLiveopsData<BattlePassConfigV2>((ServerDataType)cpp2il__autoParamName__idx_2, cpp2il__autoParamName__idx_, "*.json");
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x14F4670", Offset = "0x14F3070", VA = "0x1814F4670", Slot = "11")]
		protected override ServerDataResult LoadBundles()
		{
			string cpp2il__autoParamName__idx_ = Path.Combine(DirPath, "Bundles");
			return LoadLiveopsData<BundleConfig>(ServerDataType.Bundles, cpp2il__autoParamName__idx_, "*.json");
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x14F4730", Offset = "0x14F3130", VA = "0x1814F4730", Slot = "12")]
		protected override ServerDataResult LoadStores()
		{
			string cpp2il__autoParamName__idx_ = Path.Combine(DirPath, "Stores");
			return LoadLiveopsData<StoreConfig>(ServerDataType.Stores, cpp2il__autoParamName__idx_, "*.json");
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x1B12A80", Offset = "0x1B11480", VA = "0x181B12A80")]
		private ServerDataResult LoadLiveopsData<T>(ServerDataType cpp2il__autoParamName__idx_0, string cpp2il__autoParamName__idx_1, string cpp2il__autoParamName__idx_2) where T : IServerDataConfig
		{
			//Discarded unreachable code: IL_0061
			//IL_0046: Expected O, but got I4
			bool flag = default(bool);
			uint num3 = default(uint);
			string text = default(string);
			while (true)
			{
				int num = 0;
				if (!Directory.Exists(cpp2il__autoParamName__idx_1))
				{
					break;
				}
				ConcurrentDictionary<ServerDataType, List<IServerDataConfig>> concurrentDictionary = loadedConfigs;
				if (flag)
				{
					break;
				}
				int num2 = 0;
				JsonSerializerSettings jsonSerializerSettings = ServerDataUtils.CreateLiveopsJsonSerializerSettings();
				IEnumerable<string> enumerable = (IEnumerable<string>)Directory.EnumerateFiles(cpp2il__autoParamName__idx_1, cpp2il__autoParamName__idx_2, SearchOption.AllDirectories);
				if (enumerable != null)
				{
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_0048;
						}
						num++;
					}
					text = File.ReadAllText((string)num);
					goto IL_0048;
				}
				goto IL_004f;
				IL_004f:
				if (enumerable != null)
				{
				}
				if (num == 0)
				{
					int num4 = 0;
					break;
				}
				continue;
				IL_0048:
				text += text;
				goto IL_004f;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PortalLiveopsGameData()
		{
		}
	}
}
