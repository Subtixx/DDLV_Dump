using System.Collections;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class WeatherProfile : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	[Header("General")]
	public float fadeInTime = 1.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public float fadeOutTime = 1.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public VolumeProfile postProcessOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	[Header("SFX")]
	public State AudioConditionCloudState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public State AudioConditionRainState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public State AudioConditionWindState;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract IEnumerator FadeInWeather(Volume weatherVolume, Vector3 fxPosition);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract IEnumerator FadeOutWeather(Volume weatherVolume);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void UpdateWeather(Volume weatherVolume);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void ClearWeather();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x838D50", Offset = "0x837750", VA = "0x180838D50")]
	public void SwitchWeatherAudio()
	{
		//Discarded unreachable code: IL_0022
		AudioConditionCloudState.SetValue();
		AudioConditionRainState.SetValue();
		AudioConditionWindState.SetValue();
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x838E00", Offset = "0x837800", VA = "0x180838E00")]
	protected WeatherProfile()
	{
	}
}
