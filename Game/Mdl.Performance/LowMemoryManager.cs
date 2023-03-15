using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Meta.Util;
using UnityEngine;

namespace Mdl.Performance
{
	[Cpp2IlInjected.Token(Token = "0x2000493")]
	public class LowMemoryManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000494")]
		public enum MemoryCleanStrategy
		{
			[Cpp2IlInjected.Token(Token = "0x4001CE3")]
			RemoveUnused,
			[Cpp2IlInjected.Token(Token = "0x4001CE4")]
			RemoveUnusedAndSystemGC
		}

		[Cpp2IlInjected.Token(Token = "0x4001CDF")]
		private static LowMemoryManager _singleton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001CE0")]
		public MemoryCleanStrategy CurrentCleanStrategy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4001CE1")]
		public int CallCountForGCHack = 1;

		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		public static LowMemoryManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6001457")]
			[Cpp2IlInjected.Address(RVA = "0xBBD920", Offset = "0xBBC320", VA = "0x180BBD920")]
			get
			{
				return _singleton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001458")]
		[Cpp2IlInjected.Address(RVA = "0xBBD170", Offset = "0xBBBB70", VA = "0x180BBD170")]
		public static void CreateSingleton()
		{
			//Discarded unreachable code: IL_002b
			//IL_000f: Expected I4, but got I8
			LowMemoryManager lowMemoryManager = new LowMemoryManager();
			lowMemoryManager.CallCountForGCHack = 1;
			_singleton = lowMemoryManager;
			Application.lowMemory += _singleton.OnLowMemory;
		}

		[Cpp2IlInjected.Token(Token = "0x6001459")]
		[Cpp2IlInjected.Address(RVA = "0xBBD270", Offset = "0xBBBC70", VA = "0x180BBD270")]
		public static void DestroySingleton()
		{
			LowMemoryManager singleton = _singleton;
			if (singleton != null)
			{
				Application.lowMemory -= singleton.OnLowMemory;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600145A")]
		[Cpp2IlInjected.Address(RVA = "0xBBD4D0", Offset = "0xBBBED0", VA = "0x180BBD4D0")]
		private void OnEnable()
		{
			Application.lowMemory += OnLowMemory;
		}

		[Cpp2IlInjected.Token(Token = "0x600145B")]
		[Cpp2IlInjected.Address(RVA = "0xBBD460", Offset = "0xBBBE60", VA = "0x180BBD460")]
		private void OnDisable()
		{
			Application.lowMemory -= OnLowMemory;
		}

		[Cpp2IlInjected.Token(Token = "0x600145C")]
		[Cpp2IlInjected.Address(RVA = "0xBBD540", Offset = "0xBBBF40", VA = "0x180BBD540")]
		private void OnLowMemory()
		{
			//Discarded unreachable code: IL_0022
			int num = 0;
			if (DebugSettings.Settings.lowMemoryManager_)
			{
				int num2 = 0;
				int num3 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			DeviceManager singleton = DeviceManager._singleton;
		}

		[Cpp2IlInjected.Token(Token = "0x600145D")]
		[Cpp2IlInjected.Address(RVA = "0xBBD330", Offset = "0xBBBD30", VA = "0x180BBD330")]
		[AsyncStateMachine(typeof(_003CDoMemoryCleaningTask_003Ed__11))]
		public Task DoMemoryCleaningTask(bool isDuringLoading)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600145E")]
		[Cpp2IlInjected.Address(RVA = "0xBBD7E0", Offset = "0xBBC1E0", VA = "0x180BBD7E0")]
		[AsyncStateMachine(typeof(_003CTryFreeMemory_003Ed__12))]
		public Task TryFreeMemory(bool removeUnusedAssets, GcMode gcMode, ulong collectIncrementalMs = 0uL)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600145F")]
		[Cpp2IlInjected.Address(RVA = "0xBBD910", Offset = "0xBBC310", VA = "0x180BBD910")]
		public LowMemoryManager()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
