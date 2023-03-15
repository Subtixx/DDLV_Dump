using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Cpp2IlInjected.Token(Token = "0x2000046")]
[ExecuteInEditMode]
public class BoingScaleEffect : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static int boingEffectID = Shader.PropertyToID("boingEffect");

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static bool UseGPUBoingEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public BoingScaleEffectData scaleEffectData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private AsyncOperationHandle<BoingScaleEffectData> loadingOperation;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private const string DefaultDataAddress = "guid:d8be02c6c56f7de42a32eaeb0805aa90";

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x16438E0", Offset = "0x16422E0", VA = "0x1816438E0")]
	[RuntimeInitializeOnLoadMethod]
	public static void SetupShaderGlobals()
	{
		Shader.SetGlobalFloat("BoingCoolDown", 5f);
		Shader.SetGlobalFloat("BoingDuration", 0.7f);
		Shader.SetGlobalFloat("PeakScaleIncrease", 0.15f);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x16437A0", Offset = "0x16421A0", VA = "0x1816437A0")]
	private void OnDestroy()
	{
		bool flag = default(bool);
		if (flag)
		{
			Addressables.Release<BoingScaleEffectData>((AsyncOperationHandle<>)loadingOperation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1643700", Offset = "0x1642100", VA = "0x181643700")]
	public Coroutine AnimateScale()
	{
		//Discarded unreachable code: IL_0026
		BoingScaleEffectData data = scaleEffectData;
		int _003C_003E1__state = default(int);
		_003CScaleAnimation_003Ed__8 _003CScaleAnimation_003Ed__ = new _003CScaleAnimation_003Ed__8(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CScaleAnimation_003Ed__._003C_003E4__this = this;
		_003CScaleAnimation_003Ed__.data = data;
		return StartCoroutine(_003CScaleAnimation_003Ed__);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1643850", Offset = "0x1642250", VA = "0x181643850")]
	[IteratorStateMachine(typeof(_003CScaleAnimation_003Ed__8))]
	private IEnumerator ScaleAnimation(BoingScaleEffectData data)
	{
		int _003C_003E1__state = default(int);
		_003CScaleAnimation_003Ed__8 _003CScaleAnimation_003Ed__ = new _003CScaleAnimation_003Ed__8(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CScaleAnimation_003Ed__._003C_003E4__this = this;
		_003CScaleAnimation_003Ed__.data = data;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public BoingScaleEffect()
	{
	}
}
