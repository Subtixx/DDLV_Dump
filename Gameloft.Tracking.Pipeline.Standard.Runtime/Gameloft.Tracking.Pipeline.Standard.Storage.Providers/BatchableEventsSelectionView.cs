using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Logging;
using Gameloft.Tracking.Pipeline.Standard.Events;
using Gameloft.Tracking.Storage;
using Serilog;

namespace Gameloft.Tracking.Pipeline.Standard.Storage.Providers
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	internal class BatchableEventsSelectionView : IEventsSelection, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private class BatchableViewEventsQueryTransaction : IEventsQueryTransaction, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private BatchableEventsSelectionView parent;

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public IEnumerable<Event> Events
			{
				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x28B7F30", Offset = "0x28B6930", VA = "0x1828B7F30", Slot = "4")]
				get
				{
					//IL_0019: Expected I4, but got I8
					BatchableEventsSelectionView _003C_003E4__this = parent;
					int num = 0;
					_003CEventsEnumerable_003Ed__14 _003CEventsEnumerable_003Ed__ = default(_003CEventsEnumerable_003Ed__14);
					_003CEventsEnumerable_003Ed__._003C_003E1__state = -2;
					int currentManagedThreadId = Environment.CurrentManagedThreadId;
					_003CEventsEnumerable_003Ed__._003C_003E4__this = _003C_003E4__this;
					_003CEventsEnumerable_003Ed__._003C_003El__initialThreadId = currentManagedThreadId;
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public bool IsClosed
			{
				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				[CompilerGenerated]
				set
				{
					_003CIsClosed_003Ek__BackingField = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x5391F0", Offset = "0x537BF0", VA = "0x1805391F0")]
			public BatchableViewEventsQueryTransaction(BatchableEventsSelectionView parent)
			{
				this.parent = parent;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xA28AC0", Offset = "0xA274C0", VA = "0x180A28AC0", Slot = "5")]
			public void Close()
			{
				_003CIsClosed_003Ek__BackingField = true;
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xA28AC0", Offset = "0xA274C0", VA = "0x180A28AC0", Slot = "6")]
			public void Dispose()
			{
				_003CIsClosed_003Ek__BackingField = true;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly IPersistentStorage storage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly TrackingContext appContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private IEventsSelection processedSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private List<StandardEvent> batchedEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int numEventsCollected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private bool isFinalized;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int RawSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x28B7EE0", Offset = "0x28B68E0", VA = "0x1828B7EE0", Slot = "4")]
			get
			{
				if (processedSelection != null)
				{
				}
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public EventScope EventScope
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCB0", Offset = "0x6DC6B0", VA = "0x1806DDCB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x28B7DC0", Offset = "0x28B67C0", VA = "0x1828B7DC0")]
		public BatchableEventsSelectionView(TrackingContext context, IPersistentStorage storage)
		{
			//Discarded unreachable code: IL_0042
			ILogger logger = (ILogger)(appContext = (TrackingContext)context.Logger);
			ILogger logger2 = (this.logger = appContext.Logger.SubLogger(this));
			this.storage = storage;
			processedSelection = (IEventsSelection)logger2;
			Initialize();
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x28B7A70", Offset = "0x28B6470", VA = "0x1828B7A70", Slot = "6")]
		public IEventsQueryTransaction RequestAccess()
		{
			BatchableViewEventsQueryTransaction batchableViewEventsQueryTransaction = default(BatchableViewEventsQueryTransaction);
			batchableViewEventsQueryTransaction.parent = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x28B79C0", Offset = "0x28B63C0", VA = "0x1828B79C0", Slot = "10")]
		public virtual void PurgeOnlyCollected()
		{
			//Discarded unreachable code: IL_002d
			ILogger logger = this.logger;
			int num = numEventsCollected;
			IEnumerable<StandardEvent> enumerable = (IEnumerable<StandardEvent>)Enumerable.Skip<StandardEvent>((IEnumerable<>)batchedEvents, num);
			if (this.StoreBatchedEvents((IEnumerable<>)enumerable))
			{
				((IDisposable)this).Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x28B7930", Offset = "0x28B6330", VA = "0x1828B7930", Slot = "11")]
		public virtual void PurgeAll()
		{
			//Discarded unreachable code: IL_0016
			ILogger logger = this.logger;
			IEventsSelection eventsSelection = processedSelection;
			isFinalized = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x28B7560", Offset = "0x28B5F60", VA = "0x1828B7560", Slot = "12")]
		public virtual void Dispose()
		{
			ILogger logger = this.logger;
			if (!isFinalized)
			{
				ILogger logger2 = this.logger;
				List<StandardEvent> list = batchedEvents;
				if (this.StoreBatchedEvents((IEnumerable<>)list))
				{
					IEventsSelection eventsSelection = processedSelection;
				}
			}
			IEventsSelection eventsSelection2 = processedSelection;
			isFinalized = true;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x28B76E0", Offset = "0x28B60E0", VA = "0x1828B76E0")]
		private void Initialize()
		{
			//Discarded unreachable code: IL_0042, IL_0048, IL_004e
			//IL_0019: Expected I4, but got I8
			//IL_0023: Expected I4, but got O
			int num = 0;
			IEventsSelection eventsSelection = processedSelection;
			EventBatcher._003CBatch_003Ed__0 _003CBatch_003Ed__ = default(EventBatcher._003CBatch_003Ed__0);
			_003CBatch_003Ed__._003C_003E1__state = -2;
			int num2 = 0;
			_003CBatch_003Ed__._003C_003El__initialThreadId = (int)_003CBatch_003Ed__;
			IEnumerable<StandardEvent> _003C_003E3__events = default(IEnumerable<StandardEvent>);
			_003CBatch_003Ed__._003C_003E3__events = _003C_003E3__events;
			List<StandardEvent> list = (batchedEvents = (List<StandardEvent>)(object)Enumerable.ToList<StandardEvent>((IEnumerable<>)(object)_003CBatch_003Ed__));
			List<StandardEvent> list2 = (List<StandardEvent>)(object)new List<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x28B7670", Offset = "0x28B6070", VA = "0x1828B7670")]
		[IteratorStateMachine(typeof(_003CEventsEnumerable_003Ed__14))]
		private IEnumerable<Event> EventsEnumerable()
		{
			//IL_0012: Expected I4, but got I8
			int num = 0;
			_003CEventsEnumerable_003Ed__14 _003CEventsEnumerable_003Ed__ = default(_003CEventsEnumerable_003Ed__14);
			_003CEventsEnumerable_003Ed__._003C_003E1__state = -2;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003CEventsEnumerable_003Ed__._003C_003E4__this = this;
			_003CEventsEnumerable_003Ed__._003C_003El__initialThreadId = currentManagedThreadId;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x28B7AD0", Offset = "0x28B64D0", VA = "0x1828B7AD0")]
		private bool StoreBatchedEvents(IEnumerable<Event> eventsList)
		{
			//Discarded unreachable code: IL_004f, IL_0055, IL_005b
			int num = 0;
			ILogger logger = this.logger;
			if ("store unprocessed batched events into new slot" != null)
			{
				if ((long)num < (long)(IntPtr)"store unprocessed batched events into new slot")
				{
					num += num;
					num++;
				}
				IPersistentStorage persistentStorage = storage;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num += 312;
				num += 344;
			}
			string text = default(string);
			if (text != null)
			{
			}
			throw new NullReferenceException();
		}
	}
}
