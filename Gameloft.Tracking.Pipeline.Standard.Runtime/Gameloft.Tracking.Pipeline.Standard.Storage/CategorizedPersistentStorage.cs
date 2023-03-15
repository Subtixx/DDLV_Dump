using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Notify;
using Gameloft.Tracking.Pipeline.Standard.Events;
using Gameloft.Tracking.Pipeline.Standard.Storage.Providers;
using Gameloft.Tracking.Storage;
using Newtonsoft.Json.Linq;
using Serilog;

namespace Gameloft.Tracking.Pipeline.Standard.Storage
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class CategorizedPersistentStorage : IPersistentStorage, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly List<StorageCategory> Categories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly TrackingContext appContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Dictionary<StorageCategory, IPersistentStorage> storages;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x28BF1C0", Offset = "0x28BDBC0", VA = "0x1828BF1C0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_0036
				Dictionary<StorageCategory, IPersistentStorage>.ValueCollection values = (Dictionary<StorageCategory, IPersistentStorage>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)storages).get_Values();
				Func<IPersistentStorage, bool> _003C_003E9__1_ = _003C_003Ec._003C_003E9__1_0;
				if (_003C_003E9__1_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IPersistentStorage st) => (object)typeof(IPersistentStorage).TypeHandle == null);
				}
				return !((IEnumerable<>)(object)values).Any<IPersistentStorage>((Func<, >)(object)_003C_003E9__1_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400009B")]
		public StorageOptions Settings
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public JObject Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x28BEFC0", Offset = "0x28BD9C0", VA = "0x1828BEFC0", Slot = "5")]
			get
			{
				Dictionary<StorageCategory, IPersistentStorage> dictionary = storages;
				Func<KeyValuePair<StorageCategory, IPersistentStorage>, StorageCategory> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
				if (_003C_003E9__6_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				Func<KeyValuePair<StorageCategory, IPersistentStorage>, JObject> func = default(Func<KeyValuePair<StorageCategory, IPersistentStorage>, JObject>);
				if (_003C_003Ec._003C_003E9__6_1 == null)
				{
					func = (Func<KeyValuePair<StorageCategory, IPersistentStorage>, JObject>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					});
				}
				return JObject.FromObject(Enumerable.ToDictionary<KeyValuePair<StorageCategory, IPersistentStorage>, StorageCategory, JObject>((IEnumerable<>)dictionary, (Func<, >)(object)_003C_003E9__6_, (Func<, >)(object)func));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x28BECC0", Offset = "0x28BD6C0", VA = "0x1828BECC0")]
		public CategorizedPersistentStorage(TrackingContext context, StorageOptions options)
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_0052, IL_00a2, IL_00a8
			//IL_0072: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			Dictionary<StorageCategory, IPersistentStorage> dictionary = (Dictionary<StorageCategory, IPersistentStorage>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28BEC00", Offset = "0x28BD600", VA = "0x1828BEC00")]
		public CategorizedPersistentStorage(TrackingContext context, StorageOptions options, JObject descriptor)
		{
			//Discarded unreachable code: IL_000f
			Dictionary<StorageCategory, StorageDescriptor> dictionary = descriptor.ToObject<Dictionary<StorageCategory, StorageDescriptor>>();
			ILogger _003CLogger_003Ek__BackingField = context.Logger;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28BE990", Offset = "0x28BD390", VA = "0x1828BE990")]
		public CategorizedPersistentStorage(TrackingContext context, StorageOptions options, IReadOnlyDictionary<StorageCategory, StorageDescriptor> descriptors)
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_0052, IL_005d, IL_0065, IL_006b
			Dictionary<StorageCategory, IPersistentStorage> dictionary = (Dictionary<StorageCategory, IPersistentStorage>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28BE780", Offset = "0x28BD180", VA = "0x1828BE780", Slot = "6")]
		public void Store(Event evt)
		{
			//Discarded unreachable code: IL_0016, IL_001c, IL_0022
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (evt != null)
			{
			}
			StorageCategory storageCategory = DecideCategory((StandardEvent)num);
			Dictionary<StorageCategory, IPersistentStorage> dictionary = storages;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28BE430", Offset = "0x28BCE30", VA = "0x1828BE430", Slot = "7")]
		public void StoreAll(IEnumerable<Event> events)
		{
			//Discarded unreachable code: IL_007e, IL_0084, IL_008a, IL_0090
			//IL_0061: Expected O, but got I4
			int num;
			bool flag = default(bool);
			_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass11_0);
			do
			{
				IL_0000:
				num = 0;
				IEnumerable<StandardEvent> enumerable = (IEnumerable<StandardEvent>)Enumerable.Cast<StandardEvent>((IEnumerable)events);
				List<StorageCategory> categories = Categories;
				if (flag)
				{
					CS_0024_003C_003E8__locals0._003C_003E4__this = this;
					CS_0024_003C_003E8__locals0.category = StorageCategory.Prioritized;
					Func<StandardEvent, bool> func = (Func<StandardEvent, bool>)(object)(Func<T, TResult>)((StandardEvent evt) => CS_0024_003C_003E8__locals0._003C_003E4__this.DecideCategory(evt) == CS_0024_003C_003E8__locals0.category);
					IEnumerable<StandardEvent> enumerable2 = (IEnumerable<StandardEvent>)Enumerable.Where<StandardEvent>((IEnumerable<>)enumerable, (Func<, >)(object)func);
					if (!Enumerable.Any<StandardEvent>((IEnumerable<>)enumerable2))
					{
						goto IL_0000;
					}
					Dictionary<StorageCategory, IPersistentStorage> dictionary = storages;
					StorageCategory category = CS_0024_003C_003E8__locals0.category;
					IPersistentStorage persistentStorage = (IPersistentStorage)((Dictionary<TKey, TValue>)(object)dictionary)[(TKey)category];
					Notifier _003CNotifier_003Ek__BackingField = appContext.Notifier;
					StandardEvent standardEvent = Enumerable.First<StandardEvent>((IEnumerable<>)enumerable2);
				}
			}
			while (num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28BDC50", Offset = "0x28BC650", VA = "0x1828BDC50", Slot = "8")]
		public IEventsProvider GetBatchProvider()
		{
			TrackingContext trackingContext = appContext;
			ILogger _003CLogger_003Ek__BackingField = appContext.Logger;
			Dictionary<StorageCategory, IPersistentStorage> dictionary = storages;
			PrioritizedDataProvider prioritizedDataProvider = new PrioritizedDataProvider(trackingContext, (IReadOnlyDictionary<, >)dictionary);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x28BE2A0", Offset = "0x28BCCA0", VA = "0x1828BE2A0", Slot = "9")]
		public void PurgeEntireStorage()
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			Dictionary<StorageCategory, IPersistentStorage>.ValueCollection values = (Dictionary<StorageCategory, IPersistentStorage>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)storages).get_Values();
			bool flag = default(bool);
			if (flag)
			{
				num += num;
				num++;
				num += 392;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x28BDAC0", Offset = "0x28BC4C0", VA = "0x1828BDAC0", Slot = "10")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			Dictionary<StorageCategory, IPersistentStorage>.ValueCollection values = (Dictionary<StorageCategory, IPersistentStorage>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)storages).get_Values();
			bool flag = default(bool);
			if (flag)
			{
				num += num;
				num++;
				num += 312;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x28BDD30", Offset = "0x28BC730", VA = "0x1828BDD30")]
		private void InitFromDescriptor(IReadOnlyDictionary<StorageCategory, StorageDescriptor> descriptors)
		{
			//Discarded unreachable code: IL_008f, IL_0095, IL_009b, IL_00a1, IL_00ad
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected I4, but got Unknown
			int num = 0;
			IEnumerable<StorageCategory> enumerable = (IEnumerable<StorageCategory>)Enumerable.Cast<StorageCategory>((IEnumerable)Enum.GetValues(typeof(StorageCategory)));
			StorageOptions storageOptions = default(StorageOptions);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						num += num;
						goto IL_0078;
					}
					num++;
				}
				Dictionary<StorageCategory, IPersistentStorage> dictionary = storages;
				TrackingContext trackingContext = appContext;
				ILogger _003CLogger_003Ek__BackingField = appContext.Logger;
				storageOptions = Settings;
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0078;
					}
					num++;
				}
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
				throw new NullReferenceException();
			}
			goto IL_0085;
			IL_0078:
			num += num;
			num += num;
			NullReferenceException ex = default(NullReferenceException);
			num += ex;
			goto IL_0085;
			IL_0085:
			if (enumerable != null)
			{
			}
			if (storageOptions == null)
			{
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x28BD9F0", Offset = "0x28BC3F0", VA = "0x1828BD9F0")]
		private StorageCategory DecideCategory(StandardEvent evt)
		{
			//Discarded unreachable code: IL_001d
			EventPriority _003CPriority_003Ek__BackingField = evt.Priority;
			if (_003CPriority_003Ek__BackingField == EventPriority.Normal)
			{
			}
			if (_003CPriority_003Ek__BackingField == EventPriority.High)
			{
				int num = 0;
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x28BE8C0", Offset = "0x28BD2C0", VA = "0x1828BE8C0")]
		static CategorizedPersistentStorage()
		{
			//IL_000e: Expected O, but got I4
			//IL_0016: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			List<StorageCategory> list = (List<StorageCategory>)(object)new List<T>
			{
				(T)1,
				(T)2
			};
			int num = 0;
			((List<T>)(object)list).Add((T)num);
			Categories = list;
			throw new NullReferenceException();
		}
	}
}
