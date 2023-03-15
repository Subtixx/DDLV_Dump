using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200008E")]
[CreateAssetMenu]
public class ClearSkiesProfile : WeatherProfileDeprecated
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	[Range(0f, 1f)]
	public float windStrength = 0.026f;

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0xA82CE0", Offset = "0xA816E0", VA = "0x180A82CE0", Slot = "4")]
	[IteratorStateMachine(typeof(_003CFadeInWeather_003Ed__1))]
	public override IEnumerator FadeInWeather(Vector3 fxPosition)
	{
		int _003C_003E1__state = default(int);
		_003CFadeInWeather_003Ed__1 _003CFadeInWeather_003Ed__ = new _003CFadeInWeather_003Ed__1(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CFadeInWeather_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0xA82D50", Offset = "0xA81750", VA = "0x180A82D50", Slot = "5")]
	[IteratorStateMachine(typeof(_003CFadeOutWeather_003Ed__2))]
	public override IEnumerator FadeOutWeather()
	{
		int _003C_003E1__state = default(int);
		_003CFadeOutWeather_003Ed__2 _003CFadeOutWeather_003Ed__ = new _003CFadeOutWeather_003Ed__2(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CFadeOutWeather_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
	public override void ClearWeather()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
	public override void UpdateWeather()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xA82DC0", Offset = "0xA817C0", VA = "0x180A82DC0")]
	public ClearSkiesProfile()
	{
	}
}
