using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using DeltaDNA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unity.Services.RemoteConfig;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class UnityRemoteConfig
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public struct userAttributes
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public struct appAttributes
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private const string DISABLED_EVENTS_RC_KEY = "disabledEvents";

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private const string UGS_ENVIRONMENT = "production";

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x13E4360", Offset = "0x13E2D60", VA = "0x1813E4360")]
	[AsyncStateMachine(typeof(_003CInitialize_003Ed__4))]
	public Task Initialize()
	{
		int num = 0;
		Task result = default(Task);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x13E4260", Offset = "0x13E2C60", VA = "0x1813E4260")]
	[AsyncStateMachine(typeof(_003CInitializeRemoteConfigAsync_003Ed__5))]
	private Task InitializeRemoteConfigAsync()
	{
		int num = 0;
		Task result = default(Task);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x13E3CA0", Offset = "0x13E26A0", VA = "0x1813E3CA0")]
	private void ApplyRemoteConfigSettings(ConfigResponse configResponse)
	{
		//Discarded unreachable code: IL_0133, IL_013e, IL_0149
		int num = 0;
		RemoteConfigService instance = RemoteConfigService.Instance;
		Action<ConfigResponse> action = (Action<ConfigResponse>)(object)new Action<T>(ApplyRemoteConfigSettings);
		instance.remove_FetchCompleted((Action<>)(object)action);
		int num2 = 0;
		JObject config = RemoteConfigService.Instance.appConfig.config;
		Debug.Log($"Remote Config Remote Values changed {config}");
		int num3 = 0;
		if (!RemoteConfigService.Instance.appConfig.config.ContainsKey("disabledEvents"))
		{
			return;
		}
		int num4 = 0;
		JToken value = RemoteConfigService.Instance.appConfig.config.GetValue("disabledEvents");
		if (!value.HasValues)
		{
			return;
		}
		DDNARemoteEventDisabler.DisabledEvents disabledEvents = JsonConvert.DeserializeObject<DDNARemoteEventDisabler.DisabledEvents>(value.ToString());
		List<DDNARemoteEventDisabler.DisabledEvents.EventFilter> _003CEventNames_003Ek__BackingField = disabledEvents.EventNames;
		if (_003CEventNames_003Ek__BackingField == null)
		{
			return;
		}
		int size = ((List<>)(object)_003CEventNames_003Ek__BackingField)._size;
		string text = $"Remote Config - Game Overrides will disable {_003CEventNames_003Ek__BackingField} events ";
		List<DDNARemoteEventDisabler.DisabledEvents.EventFilter> _003CEventNames_003Ek__BackingField2 = disabledEvents.EventNames;
		Func<DDNARemoteEventDisabler.DisabledEvents.EventFilter, string> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
		if (_003C_003E9__6_ == null)
		{
			_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DDNARemoteEventDisabler.DisabledEvents.EventFilter e) => e.EventName);
		}
		IEnumerable<DDNARemoteEventDisabler.DisabledEvents.EventFilter> enumerable = (IEnumerable<DDNARemoteEventDisabler.DisabledEvents.EventFilter>)Enumerable.Select<DDNARemoteEventDisabler.DisabledEvents.EventFilter, string>((IEnumerable<>)_003CEventNames_003Ek__BackingField2, (Func<, >)(object)_003C_003E9__6_);
		string text2 = string.Join(", ", (IEnumerable<>)enumerable);
		Debug.Log(text + "\n " + text2);
		DDNA instance2 = (DDNA)(object)Singleton<T>.Instance;
		List<DDNARemoteEventDisabler.DisabledEvents.EventFilter> _003CEventNames_003Ek__BackingField3 = disabledEvents.EventNames;
		DDNARemoteEventDisabler.SetExcludedEvents(instance2, (List<>)(object)_003CEventNames_003Ek__BackingField3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
	public UnityRemoteConfig()
	{
	}
}
