using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Gameloft.Tracking.Storage;

namespace Gameloft.Tracking.Device.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class GlobalKeyValueStorage
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static KeyValueStorage kvs;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static IStorageSlotFileSystem StorageFS
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x402DC80", Offset = "0x402C680", VA = "0x18402DC80")]
			[CompilerGenerated]
			get
			{
				return _003CStorageFS_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x402DCC0", Offset = "0x402C6C0", VA = "0x18402DCC0")]
			[CompilerGenerated]
			private set
			{
				_003CStorageFS_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static KeyValueStorage Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x402DB30", Offset = "0x402C530", VA = "0x18402DB30")]
			get
			{
				int num = 0;
				KeyValueStorage keyValueStorage = kvs;
				if (keyValueStorage == null)
				{
					IStorageSlotFileSystem fs = StorageFS;
					KeyValueStorage keyValueStorage2 = new KeyValueStorage("events.bin", fs);
				}
				StorageFS = (IStorageSlotFileSystem)keyValueStorage;
				string obj = default(string);
				Monitor.Exit(obj);
				return kvs;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x402DA30", Offset = "0x402C430", VA = "0x18402DA30")]
		public static void Initialize(IStorageSlotFileSystem customfs)
		{
			if (customfs != null)
			{
				StorageFS = customfs;
				InvalidOperationException ex = new InvalidOperationException("Can't override global storage slots file system handler after the kvs instance creation");
			}
			ArgumentNullException ex2 = new ArgumentNullException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x402DA00", Offset = "0x402C400", VA = "0x18402DA00")]
		public static ValueSet Get(string batchName)
		{
			//Discarded unreachable code: IL_000e
			int num = 0;
			return Instance.GetValueSet(batchName);
		}
	}
}
