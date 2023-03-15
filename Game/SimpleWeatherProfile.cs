using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200009A")]
[CreateAssetMenu]
public class SimpleWeatherProfile : WeatherProfileDeprecated
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	[Header("Clouds")]
	public Texture2D cloudsTex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public Vector2 tiling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public Vector2 speed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public Color cloudColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	[Header("Wind")]
	public Vector3 windDir;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	[Range(0f, 1f)]
	public float windStrength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public float trunkStrength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public float trunkSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public float leavesStrength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public float leavesSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public float leavesOffsetFrequency;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public float heightStrength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public float heightSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public float heightOffsetFrequency;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public float bendScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public float normalBend;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public float leavesCutoff;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	[Header("Lightning")]
	public bool enableLightning;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public Vector2 delayBetweenStrikes;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public Vector2 strikeDuration;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public float strikeBrightnessFactor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public List<AnimationCurve> strikeBrightnessAdditive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private GameObject activeVFX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private float lastStrikeTime;

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0xF50F20", Offset = "0xF4F920", VA = "0x180F50F20", Slot = "4")]
	[IteratorStateMachine(typeof(_003CFadeInWeather_003Ed__24))]
	public override IEnumerator FadeInWeather(Vector3 fxPosition)
	{
		int _003C_003E1__state = default(int);
		_003CFadeInWeather_003Ed__24 _003CFadeInWeather_003Ed__ = new _003CFadeInWeather_003Ed__24(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CFadeInWeather_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xF50F90", Offset = "0xF4F990", VA = "0x180F50F90", Slot = "5")]
	[IteratorStateMachine(typeof(_003CFadeOutWeather_003Ed__25))]
	public override IEnumerator FadeOutWeather()
	{
		int _003C_003E1__state = default(int);
		_003CFadeOutWeather_003Ed__25 _003CFadeOutWeather_003Ed__ = new _003CFadeOutWeather_003Ed__25(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CFadeOutWeather_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0xF50E10", Offset = "0xF4F810", VA = "0x180F50E10", Slot = "7")]
	public override void ClearWeather()
	{
		//IL_0024: Expected O, but got I4
		Shader.EnableKeyword("_CLOUDS_OFF");
		Shader.DisableKeyword("_CLOUDS_ON");
		GameObject gameObject = activeVFX;
		int num = 0;
		if (gameObject != (UnityEngine.Object)num)
		{
			UnityEngine.Object.Destroy(activeVFX);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
	public override void UpdateWeather()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xF51000", Offset = "0xF4FA00", VA = "0x180F51000")]
	public unsafe SimpleWeatherProfile()
	{
		//IL_001d: Expected F4, but got I4
		//IL_0018: Expected native int or pointer, but got O
		//IL_0036: Expected F4, but got I4
		//IL_0031: Expected native int or pointer, but got O
		//IL_0058: Expected native int or pointer, but got O
		//IL_00fc: Expected F4, but got I4
		//IL_00f7: Expected native int or pointer, but got O
		int num = 0;
		Vector2 one = Vector2.one;
		int num2 = 0;
		tiling = one;
		((Vector2*)(IntPtr)tiling)->y = 0f;
		speed = Vector2.one;
		((Vector2*)(IntPtr)speed)->y = 0f;
		Color black = Color.black;
		Vector3 left = Vector3.left;
		int num3 = 0;
		float z = left.z;
		((Vector3*)(IntPtr)windDir)->z = z;
		windStrength = 0.026f;
		trunkStrength = 2f;
		trunkSpeed = 3f;
		leavesStrength = 0.2f;
		leavesSpeed = 8f;
		leavesOffsetFrequency = 17.3f;
		heightStrength = 1.3f;
		heightSpeed = 5f;
		heightOffsetFrequency = 6.5f;
		bendScale = 47f;
		normalBend = 0.069f;
		leavesCutoff = 0.36f;
		strikeDuration = Vector2.zero;
		((Vector2*)(IntPtr)strikeDuration)->y = 0f;
		strikeBrightnessFactor = 20f;
		base._002Ector();
	}
}
