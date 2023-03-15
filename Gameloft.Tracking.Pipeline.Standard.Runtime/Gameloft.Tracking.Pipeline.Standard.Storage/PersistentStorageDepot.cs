using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Storage;
using Gameloft.Tracking.Storage.Slots;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Serilog;

namespace Gameloft.Tracking.Pipeline.Standard.Storage
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class PersistentStorageDepot : IScopeablePersistentStorage, IClosablePersistentStorage, IPersistentStorage, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly TrackingContext appContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private StorageChain storages;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private EventScope defaultStorageScope;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool IsOpenned
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD4F750", Offset = "0xD4E150", VA = "0x180D4F750", Slot = "14")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x28C6710", Offset = "0x28C5110", VA = "0x1828C6710", Slot = "7")]
			get
			{
				StorageChain cpp2il__autoParamName__idx_ = storages;
				Func<StorageScopePair, bool> _003C_003E9__4_ = _003C_003Ec._003C_003E9__4_0;
				if (_003C_003E9__4_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(StorageScopePair st)
					{
						//Discarded unreachable code: IL_0010
						IPersistentStorage _003CStorage_003Ek__BackingField = st.Storage;
						return (object)typeof(IPersistentStorage).TypeHandle == null;
					};
				}
				return !((IEnumerable<>)(object)cpp2il__autoParamName__idx_).Any<StorageScopePair>((Func<, >)(object)_003C_003E9__4_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40000A7")]
		public StorageOptions Settings
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public JObject Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x28C6560", Offset = "0x28C4F60", VA = "0x1828C6560", Slot = "8")]
			get
			{
				EventScope eventScope = defaultStorageScope;
				StorageChain storageChain = storages;
				Func<StorageScopePair, ScopeDescriptorPair> _003C_003E9__11_ = _003C_003Ec._003C_003E9__11_0;
				if (_003C_003E9__11_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						int num = 0;
						int num2 = 0;
						throw new NullReferenceException();
					};
				}
				return JObject.FromObject(Enumerable.ToList<ScopeDescriptorPair>(Enumerable.Select<StorageScopePair, ScopeDescriptorPair>((IEnumerable<>)(object)storageChain, (Func<, >)(object)_003C_003E9__11_)));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public EventScope EventScope
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x28C6840", Offset = "0x28C5240", VA = "0x1828C6840", Slot = "4")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x28C62F0", Offset = "0x28C4CF0", VA = "0x1828C62F0")]
		public PersistentStorageDepot(TrackingContext context, StorageOptions options)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28C4910", Offset = "0x28C3310", VA = "0x1828C4910", Slot = "5")]
		public void Open()
		{
			//Discarded unreachable code: IL_003d
			if ((long)storages <= 0)
			{
				ILogger logger = this.logger;
				if (!RestoreFromDescriptor())
				{
					EmergencyRestore();
					StoreDescriptor();
				}
				StorageChain storageChain = storages;
				EventScope scope = defaultStorageScope;
				storageChain.ActivateStorage(scope);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28C3CC0", Offset = "0x28C26C0", VA = "0x1828C3CC0", Slot = "6")]
		public void Close()
		{
			//Discarded unreachable code: IL_002d
			//IL_002c: Expected O, but got I8
			if ((long)storages > 0)
			{
				ILogger logger = this.logger;
				StoreDescriptor();
				storages.Dispose();
				storages = (StorageChain)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28C60E0", Offset = "0x28C4AE0", VA = "0x1828C60E0", Slot = "9")]
		public void Store(Event evt)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28C5BB0", Offset = "0x28C45B0", VA = "0x1828C5BB0", Slot = "10")]
		public void StoreAll(IEnumerable<Event> events)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x28C46A0", Offset = "0x28C30A0", VA = "0x1828C46A0", Slot = "11")]
		public IEventsProvider GetBatchProvider()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x28C49C0", Offset = "0x28C33C0", VA = "0x1828C49C0", Slot = "12")]
		public void PurgeEntireStorage()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x28C3CC0", Offset = "0x28C26C0", VA = "0x1828C3CC0", Slot = "13")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_002d
			//IL_002c: Expected O, but got I8
			if ((long)storages > 0)
			{
				ILogger logger = this.logger;
				StoreDescriptor();
				storages.Dispose();
				storages = (StorageChain)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x28C4FE0", Offset = "0x28C39E0", VA = "0x1828C4FE0")]
		private bool RestoreFromDescriptor()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x28C5C60", Offset = "0x28C4660", VA = "0x1828C5C60")]
		private void StoreDescriptor()
		{
			//Discarded unreachable code: IL_00a2, IL_00a8, IL_00ae
			int num = 0;
			ILogger logger = this.logger;
			TrackingContext context = appContext;
			ILogger _003CLogger_003Ek__BackingField = appContext.Logger;
			Stream stream = new Gameloft.Tracking.Storage.Slots.StorageSlot("storage.desc", context).Create();
			JsonTextWriter jsonTextWriter = new JsonTextWriter(new StreamWriter(stream));
			JsonSerializer jsonSerializer = new JsonSerializer();
			EventScope eventScope = defaultStorageScope;
			StorageChain storageChain = storages;
			Func<StorageScopePair, ScopeDescriptorPair> _003C_003E9__11_ = _003C_003Ec._003C_003E9__11_0;
			if (_003C_003E9__11_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num3 = 0;
					int num4 = 0;
					throw new NullReferenceException();
				};
			}
			JObject value = JObject.FromObject(Enumerable.ToList<ScopeDescriptorPair>(Enumerable.Select<StorageScopePair, ScopeDescriptorPair>((IEnumerable<>)(object)storageChain, (Func<, >)(object)_003C_003E9__11_)));
			jsonSerializer.Serialize(jsonTextWriter, value);
			if (jsonTextWriter != null)
			{
			}
			if (stream != null)
			{
			}
			int num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x28C3D60", Offset = "0x28C2760", VA = "0x1828C3D60")]
		private void EmergencyRestore()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x28C4C20", Offset = "0x28C3620", VA = "0x1828C4C20")]
		private IEnumerable<string> QueryUnaccountedSlots(IEnumerable<StorageDescriptor> descriptors)
		{
			//Discarded unreachable code: IL_0086
			Func<StorageDescriptor, string> _003C_003E9__26_ = _003C_003Ec._003C_003E9__26_0;
			if (_003C_003E9__26_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			IEnumerable<StorageDescriptor> enumerable = (IEnumerable<StorageDescriptor>)Enumerable.Select<StorageDescriptor, string>((IEnumerable<>)descriptors, (Func<, >)(object)_003C_003E9__26_);
			Func<StorageDescriptor, bool> func = default(Func<StorageDescriptor, bool>);
			if (_003C_003Ec._003C_003E9__26_1 == null)
			{
				func = (Func<StorageDescriptor, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			IEnumerable<StorageDescriptor> enumerable2 = (IEnumerable<StorageDescriptor>)Enumerable.Where<StorageDescriptor>((IEnumerable<>)descriptors, (Func<, >)(object)func);
			Func<StorageDescriptor, IEnumerable<string>> func2 = default(Func<StorageDescriptor, IEnumerable<string>>);
			if (_003C_003Ec._003C_003E9__26_2 == null)
			{
				func2 = (Func<StorageDescriptor, IEnumerable<string>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(StorageDescriptor d)
				{
					IReadOnlyCollection<string> _003CBuffered_003Ek__BackingField = d.Buffered;
					/*Error: Unexpected end of block*/;
				});
			}
			IEnumerable<StorageDescriptor> enumerable3 = (IEnumerable<StorageDescriptor>)Enumerable.SelectMany<StorageDescriptor, string>((IEnumerable<>)enumerable2, (Func<, >)(object)func2);
			IEnumerable<string> enumerable4 = (IEnumerable<string>)Enumerable.Concat<string>((IEnumerable<>)enumerable, (IEnumerable<>)enumerable3);
			IEnumerable<string> result = default(IEnumerable<string>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x28C4630", Offset = "0x28C3030", VA = "0x1828C4630")]
		private IEnumerable<string> EnumSlotFiles()
		{
			throw new NullReferenceException();
		}
	}
}
