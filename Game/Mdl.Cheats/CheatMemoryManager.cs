using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Mdl.Performance;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Util;
using Rewired.Data.Mapping;
using UnityEngine;
using UnityEngine.Scripting;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000841")]
	[CreateAssetMenu]
	public class CheatMemoryManager : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E0A")]
		private List<Texture2D> _textures = (List<Texture2D>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E0B")]
		private List<byte> _bytes = (List<byte>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002E0C")]
		private int _memCleaningStrategy;

		[Cpp2IlInjected.Token(Token = "0x17000544")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 18)]
		public bool ShowMemoryInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6002539")]
			[Cpp2IlInjected.Address(RVA = "0xA7D400", Offset = "0xA7BE00", VA = "0x180A7D400")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return DebugSettings.Settings.showMemoryInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x600253A")]
			[Cpp2IlInjected.Address(RVA = "0xA7D6F0", Offset = "0xA7C0F0", VA = "0x180A7D6F0")]
			set
			{
				//Discarded unreachable code: IL_0047
				//IL_0039: Expected O, but got I4
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				int num2 = 0;
				settings.showMemoryInfo_ = value;
				if (DebugSettings.Settings.showMemoryInfo_)
				{
					FPSDisplay component = SystemRoot.Instance.gameObject.GetComponent<FPSDisplay>();
					int num3 = 0;
					if (component == (UnityEngine.Object)num3)
					{
						GameObject gameObject = default(GameObject);
						FPSDisplay fPSDisplay = gameObject.AddComponent<FPSDisplay>();
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000545")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 36)]
		public bool ShowMipmapStreamingInfo
		{
			[Cpp2IlInjected.Token(Token = "0x600253B")]
			[Cpp2IlInjected.Address(RVA = "0xA7D460", Offset = "0xA7BE60", VA = "0x180A7D460")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return DebugSettings.Settings.showMipmapStreamingInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x600253C")]
			[Cpp2IlInjected.Address(RVA = "0xA7D8C0", Offset = "0xA7C2C0", VA = "0x180A7D8C0")]
			set
			{
				//Discarded unreachable code: IL_0047
				//IL_0039: Expected O, but got I4
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				int num2 = 0;
				settings.showMipmapStreamingInfo_ = value;
				if (DebugSettings.Settings.showMipmapStreamingInfo_)
				{
					FPSDisplay component = SystemRoot.Instance.gameObject.GetComponent<FPSDisplay>();
					int num3 = 0;
					if (component == (UnityEngine.Object)num3)
					{
						GameObject gameObject = default(GameObject);
						FPSDisplay fPSDisplay = gameObject.AddComponent<FPSDisplay>();
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000546")]
		public string[] VisibilityNames
		{
			[Cpp2IlInjected.Token(Token = "0x6002542")]
			[Cpp2IlInjected.Address(RVA = "0xA7D4C0", Offset = "0xA7BEC0", VA = "0x180A7D4C0")]
			get
			{
				return Enum.GetNames(typeof(LowMemoryManager.MemoryCleanStrategy));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000547")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 89)]
		public int CompositionCullerVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x6002543")]
			[Cpp2IlInjected.Address(RVA = "0xA7D320", Offset = "0xA7BD20", VA = "0x180A7D320")]
			get
			{
				//Discarded unreachable code: IL_0002, IL_0008
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6002544")]
			[Cpp2IlInjected.Address(RVA = "0xA7D5E0", Offset = "0xA7BFE0", VA = "0x180A7D5E0")]
			set
			{
				//Discarded unreachable code: IL_002b
				if (_memCleaningStrategy != value)
				{
					_memCleaningStrategy = value;
					if (1L == 0L)
					{
					}
					LowMemoryManager singleton = LowMemoryManager._singleton;
					int num = (int)(singleton.CurrentCleanStrategy = (LowMemoryManager.MemoryCleanStrategy)_memCleaningStrategy);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000548")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 106)]
		public int CallCountForGCHack
		{
			[Cpp2IlInjected.Token(Token = "0x6002545")]
			[Cpp2IlInjected.Address(RVA = "0xA7D2A0", Offset = "0xA7BCA0", VA = "0x180A7D2A0")]
			get
			{
				//Discarded unreachable code: IL_0002, IL_0008, IL_0013
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6002546")]
			[Cpp2IlInjected.Address(RVA = "0xA7D560", Offset = "0xA7BF60", VA = "0x180A7D560")]
			set
			{
				//Discarded unreachable code: IL_0012
				if (1L == 0L)
				{
				}
				LowMemoryManager._singleton.CallCountForGCHack = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000549")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 119)]
		public unsafe int MaxThreadCount
		{
			[Cpp2IlInjected.Token(Token = "0x6002547")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3D0", Offset = "0xA7BDD0", VA = "0x180A7D3D0")]
			get
			{
				int num = 0;
				ThreadPool.GetMaxThreads(out *(int*)num, out *(int*)num);
				return num;
			}
			[Cpp2IlInjected.Token(Token = "0x6002548")]
			[Cpp2IlInjected.Address(RVA = "0xA7D6B0", Offset = "0xA7C0B0", VA = "0x180A7D6B0")]
			set
			{
				int num = 0;
				ThreadPool.GetMaxThreads(out *(int*)num, out *(int*)num);
				bool flag = ThreadPool.SetMaxThreads(value, num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054A")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 138)]
		public unsafe int MaxCompletionThreadCount
		{
			[Cpp2IlInjected.Token(Token = "0x6002549")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3A0", Offset = "0xA7BDA0", VA = "0x180A7D3A0")]
			get
			{
				int num = 0;
				ThreadPool.GetMaxThreads(out *(int*)num, out *(int*)num);
				return num;
			}
			[Cpp2IlInjected.Token(Token = "0x600254A")]
			[Cpp2IlInjected.Address(RVA = "0xA7D670", Offset = "0xA7C070", VA = "0x180A7D670")]
			set
			{
				int num = 0;
				ThreadPool.GetMaxThreads(out *(int*)num, out *(int*)num);
				bool flag = ThreadPool.SetMaxThreads(num, value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600253D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8E0", Offset = "0xA7B2E0", VA = "0x180A7C8E0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 54)]
		public void Allocate_1024x1024_Texture()
		{
			//Discarded unreachable code: IL_001f
			List<Texture2D> textures = _textures;
			Texture2D item = new Texture2D(1024, 1024);
			((List<T>)(object)textures).Add((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x600253E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9E0", Offset = "0xA7B3E0", VA = "0x180A7C9E0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 60)]
		public void Allocate_4096x4096_Texture()
		{
			//Discarded unreachable code: IL_001f
			List<Texture2D> textures = _textures;
			Texture2D item = new Texture2D(4096, 4096);
			((List<T>)(object)textures).Add((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x600253F")]
		[Cpp2IlInjected.Address(RVA = "0xA7C970", Offset = "0xA7B370", VA = "0x180A7C970")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 66)]
		public void Allocate_10M()
		{
			//Discarded unreachable code: IL_000d
			int capacity = ((List<T>)(object)_bytes).Capacity;
		}

		[Cpp2IlInjected.Token(Token = "0x6002540")]
		[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7B270", VA = "0x180A7C870")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 72)]
		public void Allocate_100M()
		{
			//Discarded unreachable code: IL_000d
			int capacity = ((List<T>)(object)_bytes).Capacity;
		}

		[Cpp2IlInjected.Token(Token = "0x6002541")]
		[Cpp2IlInjected.Address(RVA = "0xA7CCF0", Offset = "0xA7B6F0", VA = "0x180A7CCF0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 78)]
		public void Free_10M_100M()
		{
			//Discarded unreachable code: IL_0018
			((List<T>)(object)_bytes).Clear();
			((List<T>)(object)_bytes).Capacity = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600254B")]
		[Cpp2IlInjected.Address(RVA = "0xA7D0E0", Offset = "0xA7BAE0", VA = "0x180A7D0E0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 157)]
		public void UnloadUnusedAssets()
		{
			//Discarded unreachable code: IL_002b, IL_0031, IL_0037
			((List<T>)(object)_textures).Clear();
			((List<T>)(object)_bytes).Clear();
			((List<T>)(object)_bytes).Capacity = 1;
			int num = 0;
			AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
		}

		[Cpp2IlInjected.Token(Token = "0x600254C")]
		[Cpp2IlInjected.Address(RVA = "0xA7CD60", Offset = "0xA7B760", VA = "0x180A7CD60")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 169)]
		public void LoadAllAssetBundles()
		{
			//Discarded unreachable code: IL_003f, IL_0045
			//IL_0022: Expected O, but got I4
			uint num2 = default(uint);
			int num;
			string text = default(string);
			string message = default(string);
			do
			{
				num = 0;
				IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if ((object)typeof(FileSystem).TypeHandle != null)
				{
					IFileSystem binaryLocalizationFs = LocalizationProtoBufTableProvider.GetBinaryLocalizationFs((CultureInfo)0);
					AssetBundle assetBundle = AssetBundle.LoadFromFile(text);
					text += text;
					Debug.LogError(message);
				}
			}
			while (num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600254D")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA70", Offset = "0xA7B470", VA = "0x180A7CA70")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 186)]
		public void DoSystemGCCollect()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, blocking: true, compacting: true);
			uint num4 = default(uint);
			if (num4 == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600254E")]
		[Cpp2IlInjected.Address(RVA = "0xA7CBD0", Offset = "0xA7B5D0", VA = "0x180A7CBD0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 196)]
		public void DoUnityGCCollectIncremental()
		{
			//IL_000a: Expected I8, but got I4
			int num = 0;
			int num2 = 0;
			bool flag = GarbageCollector.CollectIncremental(0uL);
			uint num3 = default(uint);
			if (num3 == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600254F")]
		[Cpp2IlInjected.Address(RVA = "0xA7D040", Offset = "0xA7BA40", VA = "0x180A7D040")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatMemoryManager.cs", 208)]
		public void TraceAllocatableNativeMemory()
		{
			//IL_0006: Expected O, but got I4
			IList<HardwareJoystickMap.Platform> variants_base = (IList<HardwareJoystickMap.Platform>)((HardwareJoystickMap.Platform_NintendoSwitch_Base)0).get_variants_base();
			string message = default(string);
			Debug.Log(message);
		}

		[Cpp2IlInjected.Token(Token = "0x6002550")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1E0", Offset = "0xA7BBE0", VA = "0x180A7D1E0")]
		public CheatMemoryManager()
		{
		}
	}
}
