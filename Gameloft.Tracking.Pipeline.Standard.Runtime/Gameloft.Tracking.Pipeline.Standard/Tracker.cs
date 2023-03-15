using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.EventConveyor;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Notify;
using Gameloft.Tracking.Pipeline.Standard.Events;
using Gameloft.Tracking.Pipeline.Standard.Service;
using Gameloft.Tracking.Pipeline.Standard.Storage;
using Gameloft.Tracking.Scheduling;
using Gameloft.Tracking.Service;
using Newtonsoft.Json.Linq;
using Serilog;

namespace Gameloft.Tracking.Pipeline.Standard
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class Tracker : IStandardTracker, ITracker, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Gameloft.Tracking.EventConveyor.IEventConveyor eventConveyor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly IScopeablePersistentStorage storage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly IEtsServiceProtocol remoteService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IUploadScheduler scheduler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IReadOnlyCollection<int> bannedEvents;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[field: Cpp2IlInjected.Token(Token = "0x4000009")]
		public static string Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x28CADC0", Offset = "0x28C97C0", VA = "0x1828CADC0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Options Settings
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CSettings_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CSettings_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400000B")]
		public Session SessionInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400000C")]
		public Notifier Notifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OnlineEnvironment OnlineEnvironment
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x28CACF0", Offset = "0x28C96F0", VA = "0x1828CACF0", Slot = "10")]
			get
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x28CACD0", Offset = "0x28C96D0", VA = "0x1828CACD0", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_000f
				return SessionInfo.CurrentState > Session.State.Inactive;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400000D")]
		public ConnectivityType Connectivity
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28CAC00", Offset = "0x28C9600", VA = "0x1828CAC00")]
		public Tracker(string clientId, Options options)
		{
			GenericEventFactory<StandardEvent> genericEventFactory = (GenericEventFactory<StandardEvent>)(object)new GenericEventFactory<T>();
			DefaultComponentFactory defaultComponentFactory = new DefaultComponentFactory();
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28CA180", Offset = "0x28C8B80", VA = "0x1828CA180")]
		internal Tracker(string clientId, Options options, IEventFactory eventFactory, IComponentFactory componentFactory)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28C8740", Offset = "0x28C7140", VA = "0x1828C8740", Slot = "12")]
		public void InitializeOnline(OnlineEnvironment env)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28C9E00", Offset = "0x28C8800", VA = "0x1828C9E00", Slot = "13")]
		public void StartSending()
		{
			//Discarded unreachable code: IL_0034
			//IL_0020: Expected I4, but got I8
			ILogger logger = this.logger;
			Session session = SessionInfo;
			if (session.CurrentState > Session.State.Inactive)
			{
				session.CurrentState = Session.State.Normal;
				IUploadScheduler uploadScheduler = scheduler;
				Gameloft.Tracking.Notify.NotifierExtensions.Notify(Notifier, TrackingNotification.Type.UploadingResumed);
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("Tracker is in suspended state.");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28C9EF0", Offset = "0x28C88F0", VA = "0x1828C9EF0", Slot = "14")]
		public void StopSending()
		{
			//Discarded unreachable code: IL_001b
			ILogger logger = this.logger;
			IUploadScheduler uploadScheduler = scheduler;
			Gameloft.Tracking.Notify.NotifierExtensions.Notify(Notifier, TrackingNotification.Type.UploadingSuspended);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28C9F90", Offset = "0x28C8990", VA = "0x1828C9F90", Slot = "15")]
		public void Suspend()
		{
			ILogger logger = this.logger;
			if (SessionInfo.CurrentState > Session.State.Inactive)
			{
				ILogger logger2 = this.logger;
				SessionInfo.EndSession();
				StopSending();
				Gameloft.Tracking.EventConveyor.IEventConveyor eventConveyor = this.eventConveyor;
				IScopeablePersistentStorage scopeablePersistentStorage = storage;
				Notifier notifier = Notifier;
				int notificationType = 0;
				Gameloft.Tracking.Notify.NotifierExtensions.Notify(notifier, (TrackingNotification.Type)notificationType);
				return;
			}
			ILogger logger3 = this.logger;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28C9D20", Offset = "0x28C8720", VA = "0x1828C9D20", Slot = "16")]
		public void Resume()
		{
			//Discarded unreachable code: IL_0036
			ILogger logger = this.logger;
			Session session = SessionInfo;
			Activate();
			Gameloft.Tracking.Notify.NotifierExtensions.Notify(Notifier, TrackingNotification.Type.TrackingResumed);
			if (SessionInfo.CurrentState == Session.State.Normal)
			{
				StartSending();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x28C97E0", Offset = "0x28C81E0", VA = "0x1828C97E0", Slot = "8")]
		public void PushEvent(UserEvent eventData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28C9620", Offset = "0x28C8020", VA = "0x1828C9620")]
		public void PushEvent(int uniqueEventId, JObject eventData, EventPriority priority = EventPriority.Normal)
		{
			ILogger logger = this.logger;
			if (eventData != null)
			{
				string text = eventData.ToString();
			}
			if (eventData != null)
			{
				if (SessionInfo.CurrentState != Session.State.TrackingBanned)
				{
					new EventData((Dictionary<, >)(object)eventData.ToObject<Dictionary<string, object>>()).Type = uniqueEventId;
					return;
				}
				ILogger logger2 = this.logger;
				throw new NullReferenceException();
			}
			ArgumentNullException ex = new ArgumentNullException("eventData");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28C8650", Offset = "0x28C7050", VA = "0x1828C8650", Slot = "9")]
		public void Dispose()
		{
			ILogger logger = this.logger;
			StopSending();
			Gameloft.Tracking.EventConveyor.IEventConveyor eventConveyor = this.eventConveyor;
			SessionInfo.Dispose();
			IEtsServiceProtocol etsServiceProtocol = remoteService;
			IUploadScheduler uploadScheduler = scheduler;
			IScopeablePersistentStorage scopeablePersistentStorage = storage;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28C9450", Offset = "0x28C7E50", VA = "0x1828C9450")]
		private void OnServiceBanReceived(EtsStatusCode statusCode)
		{
			//Discarded unreachable code: IL_007b
			//IL_0045: Expected I4, but got I8
			//IL_005b: Expected I4, but got I8
			//IL_007a: Expected I4, but got I8
			ILogger logger = this.logger;
			IUploadScheduler uploadScheduler = scheduler;
			uint num = default(uint);
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						if (statusCode == EtsStatusCode.BlockUploadAndEraseV2)
						{
							goto IL_0045;
						}
						if (statusCode != EtsStatusCode.StopTrackingV2)
						{
							return;
						}
					}
					ILogger logger2 = this.logger;
					SessionInfo.CurrentState = Session.State.TrackingBanned;
				}
				goto IL_0045;
			}
			ILogger logger3 = this.logger;
			SessionInfo.CurrentState = Session.State.SendingBlocked;
			return;
			IL_0045:
			ILogger logger4 = this.logger;
			SessionInfo.CurrentState = Session.State.SendingBlocked;
			IScopeablePersistentStorage scopeablePersistentStorage = storage;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28C8AD0", Offset = "0x28C74D0", VA = "0x1828C8AD0")]
		private void InternalPushEvent(EventData eventData, UserEventReflectionData attributeData, EventPriority priority = EventPriority.Normal)
		{
			//Discarded unreachable code: IL_00ad, IL_00ce, IL_00ef, IL_0110, IL_0131, IL_0138, IL_0141, IL_014a, IL_0153, IL_015c, IL_016a, IL_0177, IL_018b, IL_0190, IL_0199, IL_019d, IL_01da, IL_01de, IL_01e5, IL_01ed, IL_01f8, IL_021b, IL_022f, IL_0235, IL_023b, IL_0241, IL_0247, IL_024d, IL_0253, IL_0259, IL_025f
			//IL_017f: Expected O, but got I4
			//IL_01af: Expected O, but got I4
			int num = 0;
			IReadOnlyCollection<int> readOnlyCollection = bannedEvents;
			if (readOnlyCollection != null)
			{
				int _003CType_003Ek__BackingField = eventData.Type;
				if (Enumerable.Contains<int>((IEnumerable<>)readOnlyCollection, _003CType_003Ek__BackingField))
				{
					ILogger logger = this.logger;
					return;
				}
			}
			StandardEvent standardEvent = new StandardEvent();
			standardEvent.EventData = eventData;
			standardEvent.Priority = priority;
			EventData _003CEventData_003Ek__BackingField = standardEvent.EventData;
			Guid guid = Guid.NewGuid();
			int num2 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = default(string);
			string text2 = (_003CEventData_003Ek__BackingField.UUID = text.ToUpper(invariantCulture));
			EventData _003CEventData_003Ek__BackingField2 = standardEvent.EventData;
			int num3 = (_003CEventData_003Ek__BackingField2.Token = SessionInfo.CreateEventToken());
			EventData _003CEventData_003Ek__BackingField3 = standardEvent.EventData;
			ConnectivityType connectivityType = Connectivity;
			Dictionary<string, object> _003CUserData_003Ek__BackingField = _003CEventData_003Ek__BackingField3.UserData;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28C84C0", Offset = "0x28C6EC0", VA = "0x1828C84C0")]
		private void Activate()
		{
			ILogger logger = this.logger;
			IScopeablePersistentStorage scopeablePersistentStorage = storage;
			SessionInfo.StartSession();
			Gameloft.Tracking.EventConveyor.IEventConveyor eventConveyor = this.eventConveyor;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28C8580", Offset = "0x28C6F80", VA = "0x1828C8580")]
		private void Deactivate()
		{
			ILogger logger = this.logger;
			SessionInfo.EndSession();
			StopSending();
			Gameloft.Tracking.EventConveyor.IEventConveyor eventConveyor = this.eventConveyor;
			IScopeablePersistentStorage scopeablePersistentStorage = storage;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28CA100", Offset = "0x28C8B00", VA = "0x1828CA100")]
		static Tracker()
		{
			AssemblyInformationalVersionAttribute assemblyInformationalVersionAttribute = default(AssemblyInformationalVersionAttribute);
			Version = assemblyInformationalVersionAttribute.m_informationalVersion;
			throw new NullReferenceException();
		}
	}
}
