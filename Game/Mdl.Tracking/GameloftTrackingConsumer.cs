using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Gameloft.Tracking.EventConveyor;
using Gameloft.Tracking.Pipeline.Standard;
using Gameloft.Tracking.Pipeline.Standard.Serialization;
using Gameloft.Tracking.Pipeline.Standard.Service;
using Gameloft.Tracking.Service;
using Meta.Tracking;
using Newtonsoft.Json.Linq;
using Serilog;
using UnityEngine;

namespace Mdl.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x20002A6")]
	public class GameloftTrackingConsumer : TrackingConsumer
	{
		[Cpp2IlInjected.Token(Token = "0x20002A7")]
		protected struct EventParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001508")]
			public string paramName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4001509")]
			public object paramValue;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001505")]
		private readonly TrackingComponent _tracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001506")]
		private string PrettyTrackingName = "GameloftTracking";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001507")]
		private readonly double ConveyorDelayMS = 4.6071824188000174E+18;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		private string storageFolderPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x8C37A0", Offset = "0x8C21A0", VA = "0x1808C37A0")]
			get
			{
				//Discarded unreachable code: IL_001c
				IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
				if ((object)typeof(FileSystem).TypeHandle == null)
				{
					return "tracking";
				}
				IFileSystem _003CSave_003Ek__BackingField2 = FileSystem.Save;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		private TrackingComponent FindTrackerComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA3")]
			[Cpp2IlInjected.Address(RVA = "0x8C3740", Offset = "0x8C2140", VA = "0x1808C3740")]
			get
			{
				return UnityEngine.Object.FindObjectOfType<TrackingComponent>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void LogTracking(string message)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x8C3150", Offset = "0x8C1B50", VA = "0x1808C3150")]
		public unsafe GameloftTrackingConsumer(string clientId, LoggerConfiguration loggerConfig)
		{
			//IL_001b: Expected F8, but got I8
			//IL_00ec: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			//IL_013e: Expected O, but got I4
			TrackingComponent trackingComponent = (_tracker = UnityEngine.Object.FindObjectOfType<TrackingComponent>());
			bool flag = default(bool);
			if (!flag)
			{
				List<string> list = observedEvents;
				int num = 0;
				List<string> list2 = observedEvents;
				int num2 = 0;
				List<string> list3 = observedEvents;
				int num3 = 0;
				List<string> list4 = observedEvents;
				List<string> list5 = observedEvents;
				int num4 = 0;
				string text = "[Tracking/GL] GameloftTrackingConsumer ctor started - about to build TrackingComponentBuilder with clientId=" + clientId;
				IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
				string text2 = storageFolderPath;
				if (text2 == null)
				{
					IFileSystem _003CSave_003Ek__BackingField2 = FileSystem.Save;
					string text3 = storageFolderPath;
				}
				TrackingComponentBuilder trackingComponentBuilder = new TrackingComponentBuilder(clientId).WithLoggerConfig(loggerConfig);
				string storagePath = storageFolderPath;
				TrackingComponentBuilder trackingComponentBuilder2 = trackingComponentBuilder.WithStorageFolderPath(storagePath).OverrideStorageSlotsManagementStrategy(StorageSlotStrategy.AutoCloseOnWrite);
				TimeSpan interval = default(TimeSpan);
				ConveyorOptions conveyorOptions = new ConveyorOptions
				{
					Interval = interval
				};
				int num5 = 0;
				TrackingComponentBuilder trackingComponentBuilder3 = trackingComponentBuilder2.WithEventConveyorOptions(conveyorOptions);
				int num6 = 0;
				GameloftTrackingOverrideConfig gameloftTrackingOverrideConfig = default(GameloftTrackingOverrideConfig);
				((object)gameloftTrackingOverrideConfig).FieldGetter((string)num6, (string)num5, ref *(object*)text2);
				ExtendedServiceOptions _003CServiceOptions_003Ek__BackingField = (_tracker = trackingComponentBuilder3.WithOnlineConfigOverrider(gameloftTrackingOverrideConfig).Build()).Tracker.Settings.ServiceOptions;
				int num7 = (int)(_003CServiceOptions_003Ek__BackingField.DataFormat = SerializationFormat.Json);
				SerializationFormat _003CDataFormat_003Ek__BackingField = _003CServiceOptions_003Ek__BackingField.DataFormat;
				int maxNumberOfEventsPerPackage = ((ServiceOptions)_003CServiceOptions_003Ek__BackingField).maxNumberOfEventsPerPackage;
				GameObject gameObject = default(GameObject);
				gameObject.name = (string)num7;
				return;
			}
			GameObject gameObject2 = default(GameObject);
			string name = gameObject2.name;
			string text4 = "[Tracking/GL] GameloftTrackingConsumer ctor skipped since " + name + " already exists";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x8C2C10", Offset = "0x8C1610", VA = "0x1808C2C10")]
		public GameloftTrackingConsumer(GameloftTrackingConfig config, string store, string version, LoggerConfiguration loggerConfig)
		{
			//IL_001b: Expected F8, but got I8
			//IL_00d4: Expected O, but got I4
			TrackingComponent trackingComponent = (_tracker = UnityEngine.Object.FindObjectOfType<TrackingComponent>());
			bool flag = default(bool);
			if (!flag)
			{
				string text = "[Tracking/GL] GameloftTrackingConsumer ctor started - about to build TrackingComponentBuilder with store=" + store + " and version=" + version;
				IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
				if (storageFolderPath == null)
				{
					IFileSystem _003CSave_003Ek__BackingField2 = FileSystem.Save;
					string text2 = storageFolderPath;
				}
				TrackingComponentBuilder trackingComponentBuilder = new TrackingComponentBuilder(config.GetClientId(store, version));
				string storagePath = storageFolderPath;
				TrackingComponentBuilder trackingComponentBuilder2 = default(TrackingComponentBuilder);
				TrackingComponentBuilder trackingComponentBuilder3 = trackingComponentBuilder2.WithStorageFolderPath(storagePath).OverrideStorageSlotsManagementStrategy(StorageSlotStrategy.AutoCloseOnWrite);
				TimeSpan interval = default(TimeSpan);
				TrackingComponentBuilder trackingComponentBuilder4 = trackingComponentBuilder3.WithEventConveyorOptions(new ConveyorOptions
				{
					Interval = interval
				});
				GameloftTrackingOverrideConfig onlineConfigOverrider = new GameloftTrackingOverrideConfig();
				TrackingComponent trackingComponent2 = (_tracker = trackingComponentBuilder4.WithOnlineConfigOverrider(onlineConfigOverrider).Build());
				int num = 0;
				GameObject gameObject = default(GameObject);
				gameObject.name = (string)num;
				IntPtr cachedPtr = ((UnityEngine.Object)gameObject).m_CachedPtr;
				IntPtr cachedPtr2 = ((UnityEngine.Object)gameObject).m_CachedPtr;
				return;
			}
			GameObject gameObject2 = default(GameObject);
			string name = gameObject2.name;
			string text3 = "[Tracking/GL] GameloftTrackingConsumer ctor skipped since " + name + " already exists";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2730", Offset = "0x8C1130", VA = "0x1808C2730")]
		private void SetDataFormat()
		{
			//Discarded unreachable code: IL_003b
			ExtendedServiceOptions _003CServiceOptions_003Ek__BackingField = _tracker.Tracker.Settings.ServiceOptions;
			int _003CDataFormat_003Ek__BackingField = (int)(_003CServiceOptions_003Ek__BackingField.DataFormat = SerializationFormat.Json);
			_tracker.Tracker.Settings.StorageOptions.DataFormat = (SerializationFormat)_003CDataFormat_003Ek__BackingField;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2790", Offset = "0x8C1190", VA = "0x1808C2790", Slot = "4")]
		public override void TrackEvent(TrackingEventBase trackingEvent, bool isHighPriority = false)
		{
			//Discarded unreachable code: IL_006c, IL_0072, IL_0078, IL_007e
			//IL_0049: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			JObject arg = new JObject();
			int eventId = trackingEvent.GetEventId();
			string eventName = trackingEvent.EventName;
			string text = $"[Tracking/GL] Tracking new event '{eventName}' with id {eventName}.";
			Dictionary<string, object> _003CParameters_003Ek__BackingField = trackingEvent.Parameters;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (flag2)
				{
				}
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				bool flag4 = default(bool);
				while (flag4)
				{
				}
				while (!flag4)
				{
				}
				JToken jToken = JToken.FromObject(flag4);
				JToken jToken2 = JToken.FromObject(flag4).ToString();
			}
			string text2 = $"[Tracking/GL] Tracking event completed with results => {arg}.";
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x8C24C0", Offset = "0x8C0EC0", VA = "0x1808C24C0", Slot = "7")]
		protected override object GetProduct(TrackingProducts complexParamProduct)
		{
			TrackingVirtualCurrency[] virtualCurrencies = complexParamProduct.virtualCurrencies;
			TrackingRealCurrency realCurrency = complexParamProduct.realCurrency;
			TrackingItem[] items = complexParamProduct.items;
			List<EventParams> product = (List<EventParams>)(object)this.GetProduct(items, realCurrency, virtualCurrencies);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x8C24F0", Offset = "0x8C0EF0", VA = "0x1808C24F0", Slot = "8")]
		protected override object GetReward(TrackingRewards complexParamReward)
		{
			List<EventParams> list = (List<EventParams>)(object)new List<T>();
			string rewardName = complexParamReward.rewardName;
			TrackingVirtualCurrency[] virtualCurrencies = complexParamReward.virtualCurrencies;
			TrackingRealCurrency realCurrency = complexParamReward.realCurrency;
			TrackingItem[] items = complexParamReward.items;
			List<EventParams> product = (List<EventParams>)(object)this.GetProduct(items, realCurrency, virtualCurrencies);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x8C1860", Offset = "0x8C0260", VA = "0x1808C1860")]
		protected List<EventParams> GetProduct(TrackingItem[] items, TrackingRealCurrency realCurrency, TrackingVirtualCurrency[] virtualCurrencies)
		{
			//Discarded unreachable code: IL_010f, IL_0133
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			List<EventParams> list = (List<EventParams>)(object)new List<T>();
			string text = $"_{list}";
			int num5 = default(int);
			string text2 = default(string);
			if (list != null && num5 > 0)
			{
				string text3 = text2 + "_traits:";
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
			int num6 = default(int);
			int num7 = default(int);
			if (list != null && num6 > 0)
			{
				string text4 = text2 + "_tags:";
				bool flag2 = default(bool);
				if (flag2)
				{
					string[] array = new string[5];
					if (text4 != null && array == null)
					{
						throw new IndexOutOfRangeException();
					}
					array[0] = text4;
					if ("_" != null && "_" == null)
					{
						throw new IndexOutOfRangeException();
					}
					array[1] = "_";
					string text5 = default(string);
					if (text5 != null && text5 == null)
					{
						throw new IndexOutOfRangeException();
					}
					array[2] = text5;
					if (":" != null && ":" == null)
					{
						throw new IndexOutOfRangeException();
					}
					array[3] = ":";
					if (":" == null)
					{
						throw new IndexOutOfRangeException();
					}
					string text6 = string.Concat(array);
				}
				num7 = 0;
			}
			List<EventParams> list2 = (List<EventParams>)(object)new List<T>();
			num4++;
			List<EventParams> list3 = (List<EventParams>)(object)new List<T>();
			if ((long)num7 < (long)(IntPtr)list3)
			{
				List<EventParams> list4 = (List<EventParams>)(object)new List<T>();
				num7++;
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x8C2660", Offset = "0x8C1060", VA = "0x1808C2660")]
		private string GetTagLabel(KeyValuePair<TagItemType, string> tag)
		{
			//Discarded unreachable code: IL_0002, IL_0008, IL_000e, IL_0014
			string result = default(string);
			return result;
		}
	}
}
