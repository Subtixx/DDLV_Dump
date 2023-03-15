using System;
using System.Collections;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class WeatherProfileDeprecated : ScriptableObject
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public struct WeatherTag
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public string label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public float value;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	[Header("General")]
	public float fadeInTime = 1.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public float fadeOutTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public WeatherTag[] tags;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	[Header("SFX")]
	public State AudioConditionCloudState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public State AudioConditionRainState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public State AudioConditionWindState;

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract IEnumerator FadeInWeather(Vector3 fxPosition);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract IEnumerator FadeOutWeather();

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void UpdateWeather();

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void ClearWeather();

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x838D50", Offset = "0x837750", VA = "0x180838D50")]
	public void SwitchWeatherAudio()
	{
		//Discarded unreachable code: IL_0022
		AudioConditionCloudState.SetValue();
		AudioConditionRainState.SetValue();
		AudioConditionWindState.SetValue();
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x838DA0", Offset = "0x8377A0", VA = "0x180838DA0")]
	protected WeatherProfileDeprecated()
	{
		int num = 0;
		fadeOutTime = 1.5f;
		tags = new WeatherTag[num];
		base._002Ector();
	}
}
