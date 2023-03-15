using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using DeltaDNA;
using Gameloft.Common;
using Mdl.Platform;
using Meta.Tracking;
using Serilog;
using Serilog.Core;

namespace Mdl.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x20002A1")]
	public class DeltaDNAConsumer : TrackingConsumer
	{
		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x1624D80", Offset = "0x1623780", VA = "0x181624D80")]
		public DeltaDNAConsumer(LoggerConfiguration loggerConfig)
		{
			//Discarded unreachable code: IL_00fc
			//IL_0013: Expected I4, but got O
			while (true)
			{
				base._002Ector();
				Serilog.Core.Logger logger = loggerConfig.CreateLogger();
				DeltaDNA.Logger.sLogLevel = (DeltaDNA.Logger.Level)logger;
				string userID = ((DDNA)(object)Singleton<T>.Instance).UserID;
				DDNA instance = (DDNA)(object)Singleton<T>.Instance;
				int loggingLevel = 0;
				instance.SetLoggingLevel((DeltaDNA.Logger.Level)loggingLevel);
				new UnityRemoteConfig().Initialize().FireAndForgetTask();
				((DDNA)(object)Singleton<T>.Instance).StartSDK(userID);
				if (userID != null)
				{
					int num = 0;
					PlatformInterfaceManager instance2 = PlatformInterfaceManager.Instance;
					if (instance2 != null && instance2.PlayerPrefs == null)
					{
					}
				}
				if (logger == null)
				{
					break;
				}
				object[] array = new object[4];
				if ("[DDSDK] " != null && "[DDSDK] " == null)
				{
					continue;
				}
				array[0] = "[DDSDK] ";
				if (userID != null && "[DDSDK] " == null)
				{
					continue;
				}
				array[1] = userID;
				string userID2 = ((DDNA)(object)Singleton<T>.Instance).UserID;
				if (userID2 == null || userID2 != null)
				{
					array[2] = userID2;
					if (userID2 == null || userID2 != null)
					{
						array[3] = userID2;
						string messageTemplate = string.Format("{0} : delta DDNA currentUserID={1}, UserID={2}, newUser={3}", array);
						logger.Information(messageTemplate);
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x1624A50", Offset = "0x1623450", VA = "0x181624A50", Slot = "4")]
		public override void TrackEvent(TrackingEventBase trackingEvent, bool isHighPriority = false)
		{
			//Discarded unreachable code: IL_0038, IL_003e, IL_0044
			GameEvent gameEvent = new GameEvent(trackingEvent.EventName);
			Dictionary<string, object> _003CParameters_003Ek__BackingField = trackingEvent.Parameters;
			bool flag = default(bool);
			if (flag)
			{
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				while (!flag2)
				{
				}
			}
			DDNA instance = (DDNA)(object)Singleton<T>.Instance;
			if ((object)instance != null)
			{
				EventAction eventAction = instance.RecordSampledEvent(gameEvent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x16240C0", Offset = "0x1622AC0", VA = "0x1816240C0", Slot = "7")]
		protected override object GetProduct(TrackingProducts complexParamProduct)
		{
			TrackingVirtualCurrency[] virtualCurrencies = complexParamProduct.virtualCurrencies;
			TrackingRealCurrency realCurrency = complexParamProduct.realCurrency;
			TrackingItem[] items = complexParamProduct.items;
			Product product = GetProduct(items, realCurrency, virtualCurrencies);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x16248A0", Offset = "0x16232A0", VA = "0x1816248A0", Slot = "8")]
		protected override object GetReward(TrackingRewards complexParamReward)
		{
			Params @params = new Params();
			string rewardName = complexParamReward.rewardName;
			Params params2 = @params.AddParam("rewardName", rewardName);
			TrackingVirtualCurrency[] virtualCurrencies = complexParamReward.virtualCurrencies;
			TrackingRealCurrency realCurrency = complexParamReward.realCurrency;
			TrackingItem[] items = complexParamReward.items;
			Product product = GetProduct(items, realCurrency, virtualCurrencies);
			Params params3 = params2.AddParam("rewardProducts", product);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x16240F0", Offset = "0x1622AF0", VA = "0x1816240F0")]
		protected Product GetProduct(TrackingItem[] items, TrackingRealCurrency realCurrency, TrackingVirtualCurrency[] virtualCurrencies)
		{
			//Discarded unreachable code: IL_013d, IL_0161
			//IL_0134: Expected I8, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Product product = new Product();
			if (items != null)
			{
				string text = $"_{product}";
				int num5 = default(int);
				string text2 = default(string);
				if (product != null && num5 > 0)
				{
					string text3 = text2 + "_traits:";
					bool flag = default(bool);
					if (!flag)
					{
					}
				}
				int num6 = default(int);
				if (product != null && num6 > 0)
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
				}
				num4++;
			}
			if (virtualCurrencies != null)
			{
				int length = virtualCurrencies.Length;
				if (num4 < length)
				{
					TrackingVirtualCurrency trackingVirtualCurrency = virtualCurrencies[num4];
					int virtualCurrencyAmount = trackingVirtualCurrency.virtualCurrencyAmount;
					string virtualCurrencyType = trackingVirtualCurrency.virtualCurrencyType;
					string virtualCurrencyName = trackingVirtualCurrency.virtualCurrencyName;
					Product product2 = (Product)(object)((Product<T>)(object)product).AddVirtualCurrency(virtualCurrencyName, virtualCurrencyType, (long)virtualCurrencyAmount);
					num4++;
				}
			}
			return product;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x1624980", Offset = "0x1623380", VA = "0x181624980")]
		private string GetTagLabel(KeyValuePair<TagItemType, string> tag)
		{
			//Discarded unreachable code: IL_0002, IL_0008, IL_000e, IL_0014
			string result = default(string);
			return result;
		}
	}
}
