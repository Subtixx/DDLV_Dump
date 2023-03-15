using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Storage;
using Serilog;

namespace Gameloft.Tracking.Pipeline.Standard.Storage
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class StorageChain : IReadOnlyCollection<StorageScopePair>, IEnumerable<StorageScopePair>, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly TrackingContext appContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly StorageOptions settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private List<StorageScopePair> storages;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x28C8200", Offset = "0x28C6C00", VA = "0x1828C8200", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)storages)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public StorageScopePair Acceptance
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x28C81B0", Offset = "0x28C6BB0", VA = "0x1828C81B0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public StorageScopePair Delivery
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x28C8240", Offset = "0x28C6C40", VA = "0x1828C8240")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x28C7F30", Offset = "0x28C6930", VA = "0x1828C7F30")]
		public StorageChain(TrackingContext context, StorageOptions options, IEnumerable<StorageScopePair> storagesChain)
		{
			ILogger logger = (ILogger)(appContext = (TrackingContext)context.Logger);
			settings = options;
			if (storagesChain != null)
			{
				List<StorageScopePair> list = (List<StorageScopePair>)(object)Enumerable.ToList<StorageScopePair>((IEnumerable<>)storagesChain);
				if (list != null)
				{
					storages = list;
					if (Enumerable.Any<StorageScopePair>((IEnumerable<>)storages))
					{
						List<StorageScopePair> cpp2il__autoParamName__idx_ = storages;
						Func<StorageScopePair, bool> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
						if (_003C_003E9__7_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								throw new NullReferenceException();
							};
						}
						if (!((IEnumerable<>)cpp2il__autoParamName__idx_).Any<StorageScopePair>((Func<, >)(object)_003C_003E9__7_))
						{
							return;
						}
					}
					ArgumentException ex = new ArgumentException("Storages collection param is empty or invalid");
				}
			}
			ArgumentNullException ex2 = new ArgumentNullException("storagesChain");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x28C77B0", Offset = "0x28C61B0", VA = "0x1828C77B0")]
		public void ActivateStorage(EventScope scope)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x28C7E30", Offset = "0x28C6830", VA = "0x1828C7E30", Slot = "5")]
		public IEnumerator<StorageScopePair> GetEnumerator()
		{
			List<StorageScopePair> list = storages;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x28C7EB0", Offset = "0x28C68B0", VA = "0x1828C7EB0", Slot = "6")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			List<StorageScopePair> list = storages;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x28C7CB0", Offset = "0x28C66B0", VA = "0x1828C7CB0", Slot = "7")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0023, IL_0029
			int num = 0;
			List<StorageScopePair> list = storages;
			bool flag = default(bool);
			if (flag)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num += 312;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x28C7BD0", Offset = "0x28C65D0", VA = "0x1828C7BD0")]
		private IPersistentStorage CreateStorage()
		{
			TrackingContext context = appContext;
			ILogger _003CLogger_003Ek__BackingField = appContext.Logger;
			StorageOptions options = settings;
			CategorizedPersistentStorage categorizedPersistentStorage = new CategorizedPersistentStorage(context, options);
			/*Error: Unexpected end of block*/;
		}
	}
}
