using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Logging;
using Gameloft.Tracking.Storage;
using Gameloft.Tracking.Storage.Providers;
using Serilog;

namespace Gameloft.Tracking.Pipeline.Standard.Storage.Providers
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class PrioritizedDataProvider : IEventsProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly IReadOnlyDictionary<StorageCategory, IEventsProvider> providers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly IPersistentStorage batchableEventsStorage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly TrackingContext appContext;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int TotalSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x28C7570", Offset = "0x28C5F70", VA = "0x1828C7570", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_0026
				IReadOnlyDictionary<StorageCategory, IEventsProvider> readOnlyDictionary = providers;
				if (_003C_003Ec._003C_003E9__1_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public EventScope EventScope
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCE0", Offset = "0x6DC6E0", VA = "0x1806DDCE0", Slot = "5")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x28C7190", Offset = "0x28C5B90", VA = "0x1828C7190")]
		public PrioritizedDataProvider(TrackingContext context, IReadOnlyDictionary<StorageCategory, IPersistentStorage> storages)
		{
			//IL_00a6: Expected O, but got I4
			ILogger logger = (ILogger)(appContext = (TrackingContext)context.Logger);
			ILogger logger2 = (this.logger = appContext.Logger.SubLogger(this));
			Func<KeyValuePair<StorageCategory, IPersistentStorage>, StorageCategory> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
			if (_003C_003E9__6_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			Func<KeyValuePair<StorageCategory, IPersistentStorage>, IEventsProvider> func = default(Func<KeyValuePair<StorageCategory, IPersistentStorage>, IEventsProvider>);
			if (_003C_003Ec._003C_003E9__6_1 == null)
			{
				func = (Func<KeyValuePair<StorageCategory, IPersistentStorage>, IEventsProvider>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				});
			}
			Dictionary<StorageCategory, KeyValuePair<StorageCategory, IPersistentStorage>> dictionary = (Dictionary<StorageCategory, KeyValuePair<StorageCategory, IPersistentStorage>>)(object)Enumerable.ToDictionary<KeyValuePair<StorageCategory, IPersistentStorage>, StorageCategory, IEventsProvider>((IEnumerable<>)storages, (Func<, >)(object)_003C_003E9__6_, (Func<, >)(object)func);
			if (dictionary != null)
			{
				providers = (IReadOnlyDictionary<StorageCategory, IEventsProvider>)dictionary;
				if (_003C_003Ec._003C_003E9__6_2 == null)
				{
					bool result = default(bool);
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<StorageCategory, IPersistentStorage> kv) => result);
				}
				batchableEventsStorage = (IPersistentStorage)0;
			}
			ArgumentNullException ex = new ArgumentNullException("storages");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x28C6DD0", Offset = "0x28C57D0", VA = "0x1828C6DD0", Slot = "6")]
		public IEventsSelection QueryEvents()
		{
			ILogger logger = this.logger;
			IReadOnlyDictionary<StorageCategory, IEventsProvider> readOnlyDictionary = providers;
			int category = 0;
			IEventsSelection item = CreateView((StorageCategory)category);
			List<IEventsSelection> list = default(List<IEventsSelection>);
			((List<T>)(object)list).Add((T)item);
			IEventsSelection item2 = CreateView(StorageCategory.Batchable);
			((List<T>)(object)list).Add((T)item2);
			IEventsSelection item3 = CreateView(StorageCategory.Normal);
			((List<T>)(object)list).Add((T)item3);
			Func<IEventsSelection, int> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
			if (_003C_003E9__7_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				};
			}
			if (Enumerable.Sum<IEventsSelection>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__7_) > 0)
			{
				TrackingContext trackingContext = appContext;
				ILogger _003CLogger_003Ek__BackingField = appContext.Logger;
				Gameloft.Tracking.Storage.Providers.CompositeEventsSelectionView compositeEventsSelectionView = new Gameloft.Tracking.Storage.Providers.CompositeEventsSelectionView(trackingContext, (IEnumerable<>)list);
			}
			Gameloft.Tracking.Storage.Providers.EmptyEventsSelection arg = new Gameloft.Tracking.Storage.Providers.EmptyEventsSelection();
			ILogger logger2 = this.logger;
			string text = $"Events selection view constructed (size={arg})";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x28C6B50", Offset = "0x28C5550", VA = "0x1828C6B50")]
		private IEventsSelection CreateView(StorageCategory category)
		{
			if (category <= StorageCategory.Normal)
			{
				IReadOnlyDictionary<StorageCategory, IEventsProvider> readOnlyDictionary = providers;
			}
			BatchableEventsSelectionView batchableEventsSelectionView = default(BatchableEventsSelectionView);
			if (category == StorageCategory.Batchable)
			{
				TrackingContext trackingContext = appContext;
				IPersistentStorage storage = batchableEventsStorage;
				ILogger _003CLogger_003Ek__BackingField = appContext.Logger;
				batchableEventsSelectionView.appContext = trackingContext;
				batchableEventsSelectionView.appContext = trackingContext;
				batchableEventsSelectionView.appContext = trackingContext;
				batchableEventsSelectionView.appContext = trackingContext;
				batchableEventsSelectionView.appContext = (TrackingContext)_003CLogger_003Ek__BackingField;
				ILogger processedSelection = (batchableEventsSelectionView.logger = batchableEventsSelectionView.appContext.Logger.SubLogger(batchableEventsSelectionView));
				batchableEventsSelectionView.storage = storage;
				batchableEventsSelectionView.processedSelection = (IEventsSelection)processedSelection;
				batchableEventsSelectionView.Initialize();
			}
			string text = $"Unexpected storage category (value={batchableEventsSelectionView})";
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
