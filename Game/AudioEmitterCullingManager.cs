using System;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Audio;
using Mdl.Characters;
using Mdl.Systems;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AudioEmitterCullingManager : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float maxAttenuation = 100f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public TriggerType triggerType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public AK.Wwise.Event wwiseEvent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Vector3 offset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public bool collisionDisable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Bank soundbank;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Bank VOSoundbank;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Switch[] wwiseSwitch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool isInsideCollider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private SphereCollider zoneAttenuation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private AkGameObj currentgO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private AkAmbient wwiseAmbiance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private AkRadialEmitter radialEmitter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Switch skinVariation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private Switch ipSwitch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Switch characterSwitch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Character characterScript;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool typeCharacter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool usingRadialEmitter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Vector3 playerPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private AudioEmitterBankLoader bankLoader;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private AudioEmitterBankLoader voBankLoader;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool banksLoaded;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[field: Cpp2IlInjected.Token(Token = "0x4000060")]
	public static bool IsDebugVerbose
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED70", Offset = "0xA4D770", VA = "0x180A4ED70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE70", Offset = "0xA4D870", VA = "0x180A4EE70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool IsSoundBankReady
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDD0", Offset = "0xA4D7D0", VA = "0x180A4EDD0")]
		get
		{
			Bank bank = soundbank;
			if (bank != null && bank.IsValid())
			{
				AudioEmitterBankLoader audioEmitterBankLoader = bankLoader;
				if (audioEmitterBankLoader != null)
				{
					return audioEmitterBankLoader.IsLoaded;
				}
			}
			return true;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool IsVOSoundBankReady
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE20", Offset = "0xA4D820", VA = "0x180A4EE20")]
		get
		{
			Bank vOSoundbank = VOSoundbank;
			if (vOSoundbank != null && vOSoundbank.IsValid())
			{
				AudioEmitterBankLoader audioEmitterBankLoader = voBankLoader;
				if (audioEmitterBankLoader != null)
				{
					return audioEmitterBankLoader.IsLoaded;
				}
			}
			return true;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA4D7B0", Offset = "0xA4C1B0", VA = "0x180A4D7B0")]
	private void Awake()
	{
		if (!base.enabled)
		{
			UnityEngine.Object.Destroy(this);
		}
		AkGameObj akGameObj = (currentgO = base.gameObject.GetComponent<AkGameObj>());
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA4E7A0", Offset = "0xA4D1A0", VA = "0x180A4E7A0")]
	private unsafe void Start()
	{
		//IL_0038: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0046: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_0143: Expected native int or pointer, but got O
		AkGameObj akGameObj = (currentgO = base.gameObject.GetComponent<AkGameObj>());
		Character character = (characterScript = base.transform.parent.GetComponent<Character>());
		int num = 0;
		bool flag = default(bool);
		if (flag)
		{
			skinVariation = (Switch)num;
			ipSwitch = (Switch)num;
			characterSwitch = (Switch)num;
			typeCharacter = true;
		}
		AkRadialEmitter akRadialEmitter = (radialEmitter = base.gameObject.GetComponent<AkRadialEmitter>());
		AkRadialEmitter akRadialEmitter2 = radialEmitter;
		int num2 = 0;
		bool flag2 = (usingRadialEmitter = akRadialEmitter2 != (UnityEngine.Object)num2);
		if (!collisionDisable)
		{
			SphereCollider sphereCollider = (zoneAttenuation = base.gameObject.AddComponent<SphereCollider>());
			SphereCollider sphereCollider2 = zoneAttenuation;
			sphereCollider2.isTrigger = true;
			SphereCollider sphereCollider3 = zoneAttenuation;
			Vector3 center = sphereCollider2.center;
			if (!usingRadialEmitter)
			{
				SphereCollider sphereCollider4 = zoneAttenuation;
				float num4 = (sphereCollider4.radius = maxAttenuation);
			}
			AkRadialEmitter akRadialEmitter3 = radialEmitter;
			SphereCollider sphereCollider5 = zoneAttenuation;
			float num6 = (sphereCollider5.radius = maxAttenuation);
			AkRadialEmitter akRadialEmitter4 = radialEmitter;
			int num7 = ((akRadialEmitter4.enabled = false) ? 1 : 0);
			Transform transform = GameObject.FindWithTag("MainCamera").transform;
			SphereCollider sphereCollider6 = zoneAttenuation;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)playerPosition)->z = z;
			Collider component = sphereCollider6.GetComponent<Collider>();
			Bounds bounds = sphereCollider6.bounds;
			bool flag4 = default(bool);
			if (!flag4)
			{
				goto IL_0166;
			}
		}
		isInsideCollider = true;
		goto IL_0166;
		IL_01a6:
		AkGameObj akGameObj2 = default(AkGameObj);
		int num8 = ((akGameObj2.enabled = false) ? 1 : 0);
		throw new NullReferenceException();
		IL_0166:
		if (triggerType == TriggerType.UseAkAmbient)
		{
			AkAmbient akAmbient = (wwiseAmbiance = base.gameObject.GetComponent<AkAmbient>());
			if (triggerType == TriggerType.UseAkAmbient)
			{
				goto IL_01a6;
			}
		}
		if (!usingRadialEmitter)
		{
			akGameObj2 = currentgO;
			UnityEngine.Object.Destroy(akGameObj2);
			return;
		}
		goto IL_01a6;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xA4DBE0", Offset = "0xA4C5E0", VA = "0x180A4DBE0")]
	private void OnDisable()
	{
		//Discarded unreachable code: IL_011d
		AudioEmitterBankLoader audioEmitterBankLoader = bankLoader;
		if (audioEmitterBankLoader != null)
		{
			AudioEmitterBankLoader.BankLoaded value = OnBankLoaded;
			audioEmitterBankLoader.OnBankLoaded -= value;
		}
		AudioEmitterBankLoader audioEmitterBankLoader2 = voBankLoader;
		if (audioEmitterBankLoader2 != null)
		{
			AudioEmitterBankLoader.BankLoaded value2 = OnBankLoaded;
			audioEmitterBankLoader2.OnBankLoaded -= value2;
		}
		AkSoundEngine.StopAll(base.gameObject);
		if (collisionDisable)
		{
			isInsideCollider = false;
		}
		if (usingRadialEmitter)
		{
			AkRadialEmitter akRadialEmitter = radialEmitter;
			int num = ((akRadialEmitter.enabled = false) ? 1 : 0);
		}
		if (banksLoaded)
		{
			AudioEmitterBankLoader audioEmitterBankLoader3 = bankLoader;
			int referenceCount = 0;
			if (audioEmitterBankLoader3 != null)
			{
				audioEmitterBankLoader3.referenceCount = referenceCount;
			}
			AudioEmitterBankLoader audioEmitterBankLoader4 = voBankLoader;
			if (audioEmitterBankLoader4 != null)
			{
				audioEmitterBankLoader4.referenceCount = referenceCount;
			}
			banksLoaded = (byte)referenceCount != 0;
		}
		AKRESULT aKRESULT = AkSoundEngine.UnregisterGameObj(base.gameObject);
		if (triggerType != TriggerType.UseAkAmbient && !usingRadialEmitter)
		{
			UnityEngine.Object.Destroy(currentgO);
		}
		AkGameObj akGameObj = currentgO;
		int num2 = ((akGameObj.enabled = false) ? 1 : 0);
		string message = base.gameObject.name + " : AudioEmitterCullingManager.On Disable";
		GameObject context = base.gameObject;
		Debug.Log(message, context);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xA4DF00", Offset = "0xA4C900", VA = "0x180A4DF00")]
	private void OnEnable()
	{
		//Discarded unreachable code: IL_0192
		//IL_00b1: Expected O, but got I4
		AkGameObj akGameObj = (currentgO = base.gameObject.GetComponent<AkGameObj>());
		AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
		Bank bank = soundbank;
		if (bank != null && bank.IsValid() && (long)bankLoader == 0)
		{
			Bank bank2 = soundbank;
			AudioEmitterBankLoader audioEmitterBankLoader = (bankLoader = system.GetAudioBankLoader(bank2));
		}
		Bank vOSoundbank = VOSoundbank;
		if (vOSoundbank != null && vOSoundbank.IsValid() && (long)voBankLoader == 0)
		{
			Bank vOSoundbank2 = VOSoundbank;
			AudioEmitterBankLoader audioEmitterBankLoader2 = (voBankLoader = system.GetAudioBankLoader(vOSoundbank2));
		}
		if (collisionDisable)
		{
			AkGameObj akGameObj2 = currentgO;
			int num = 0;
			if (akGameObj2 == (UnityEngine.Object)num)
			{
				AkGameObj akGameObj3 = (currentgO = base.gameObject.AddComponent<AkGameObj>());
			}
			GameObject gameObject = base.gameObject;
			string text = base.gameObject.name;
			AKRESULT aKRESULT = AkSoundEngine.RegisterGameObj(gameObject, text);
			GameObject gameObject2 = base.gameObject;
			Transform transform = base.gameObject.transform;
			AKRESULT aKRESULT2 = AkSoundEngine.SetObjectPosition(gameObject2, transform);
			AudioEmitterBankLoader audioEmitterBankLoader3 = bankLoader;
			isInsideCollider = true;
			if (audioEmitterBankLoader3 == null && voBankLoader == audioEmitterBankLoader3)
			{
				ActivateTrigger();
			}
			if (!banksLoaded)
			{
				Bank bank3 = soundbank;
				LoadBank(audioEmitterBankLoader3, bank3);
				Bank vOSoundbank3 = VOSoundbank;
				AudioEmitterBankLoader audioBankLdr = voBankLoader;
				LoadBank(audioBankLdr, vOSoundbank3);
				banksLoaded = true;
			}
			string message = base.gameObject.name + " : AudioEmitterCullingManager.On Enable";
			GameObject context = base.gameObject;
			Debug.Log(message, context);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA4D850", Offset = "0xA4C250", VA = "0x180A4D850")]
	private void LoadBank(AudioEmitterBankLoader audioBankLdr, Bank bank)
	{
		if (audioBankLdr == null)
		{
			return;
		}
		if (audioBankLdr.IsLoaded)
		{
			AudioEmitterBankLoader.BankLoaded value = OnBankLoaded;
			audioBankLdr.OnBankLoaded -= value;
			ActivateTrigger();
			return;
		}
		AudioEmitterBankLoader.BankLoaded value2 = OnBankLoaded;
		audioBankLdr.OnBankLoaded -= value2;
		AudioEmitterBankLoader.BankLoaded b = OnBankLoaded;
		AudioEmitterBankLoader.BankLoaded onBankLoaded = audioBankLdr.OnBankLoaded;
		Delegate @delegate = Delegate.Combine(onBankLoaded, b);
		if ((object)@delegate == null || (object)@delegate != null)
		{
			while ((object)@delegate != onBankLoaded)
			{
			}
			return;
		}
		throw new InvalidCastException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA4E740", Offset = "0xA4D140", VA = "0x180A4E740")]
	private void StartEmitter()
	{
		AudioEmitterBankLoader audioEmitterBankLoader = bankLoader;
		if (audioEmitterBankLoader == null && voBankLoader == audioEmitterBankLoader)
		{
			ActivateTrigger();
		}
		else if (!banksLoaded)
		{
			Bank bank = soundbank;
			LoadBank(audioEmitterBankLoader, bank);
			Bank vOSoundbank = VOSoundbank;
			AudioEmitterBankLoader audioBankLdr = voBankLoader;
			LoadBank(audioBankLdr, vOSoundbank);
			banksLoaded = true;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA4DA00", Offset = "0xA4C400", VA = "0x180A4DA00")]
	private void OnBankLoaded(AudioEmitterBankLoader audioBankLdr)
	{
		//Discarded unreachable code: IL_001b
		AudioEmitterBankLoader.BankLoaded value = OnBankLoaded;
		audioBankLdr.OnBankLoaded -= value;
		ActivateTrigger();
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xA4DAA0", Offset = "0xA4C4A0", VA = "0x180A4DAA0")]
	private void OnDestroy()
	{
		//Discarded unreachable code: IL_007d
		//IL_001d: Expected O, but got I4
		//IL_0024: Expected O, but got I4
		if (base.enabled)
		{
			AkSoundEngine.StopAll(base.gameObject);
			int num = 0;
			bankLoader = (AudioEmitterBankLoader)num;
			voBankLoader = (AudioEmitterBankLoader)num;
			AKRESULT aKRESULT = AkSoundEngine.UnregisterGameObj(base.gameObject);
			if (usingRadialEmitter)
			{
				AkRadialEmitter akRadialEmitter = radialEmitter;
				int num2 = ((akRadialEmitter.enabled = false) ? 1 : 0);
			}
			if (triggerType != TriggerType.UseAkAmbient && !usingRadialEmitter)
			{
				UnityEngine.Object.Destroy(currentgO);
				return;
			}
			AkGameObj akGameObj = currentgO;
			int num3 = ((akGameObj.enabled = false) ? 1 : 0);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA4E360", Offset = "0xA4CD60", VA = "0x180A4E360")]
	private void OnTriggerEnter(Collider other)
	{
		//Discarded unreachable code: IL_00b0
		//IL_0034: Expected O, but got I4
		AkGameObj akGameObj = (currentgO = base.gameObject.GetComponent<AkGameObj>());
		if (other.CompareTag("MainCamera"))
		{
			AkGameObj akGameObj2 = currentgO;
			int num = 0;
			if (akGameObj2 == (UnityEngine.Object)num)
			{
				AkGameObj akGameObj3 = (currentgO = base.gameObject.AddComponent<AkGameObj>());
			}
			GameObject gameObject = base.gameObject;
			string text = base.gameObject.name;
			AKRESULT aKRESULT = AkSoundEngine.RegisterGameObj(gameObject, text);
			GameObject gameObject2 = base.gameObject;
			Transform transform = base.gameObject.transform;
			AKRESULT aKRESULT2 = AkSoundEngine.SetObjectPosition(gameObject2, transform);
			AudioEmitterBankLoader audioEmitterBankLoader = bankLoader;
			isInsideCollider = true;
			if (audioEmitterBankLoader == null && voBankLoader == audioEmitterBankLoader)
			{
				ActivateTrigger();
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA4ECA0", Offset = "0xA4D6A0", VA = "0x180A4ECA0")]
	private void UnloadBanks()
	{
		if (banksLoaded)
		{
			AudioEmitterBankLoader audioEmitterBankLoader = bankLoader;
			int referenceCount = 0;
			if (audioEmitterBankLoader != null)
			{
				audioEmitterBankLoader.referenceCount = referenceCount;
			}
			AudioEmitterBankLoader audioEmitterBankLoader2 = voBankLoader;
			if (audioEmitterBankLoader2 != null)
			{
				audioEmitterBankLoader2.referenceCount = referenceCount;
			}
			banksLoaded = (byte)referenceCount != 0;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA4D2F0", Offset = "0xA4BCF0", VA = "0x180A4D2F0")]
	private unsafe void ActivateTrigger()
	{
		//IL_00c6: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		GameObject gameObject2 = default(GameObject);
		GameObject gameObject3 = default(GameObject);
		bool flag = default(bool);
		int num;
		GameObject gameObject4 = default(GameObject);
		GameObject gameObject5 = default(GameObject);
		uint num2 = default(uint);
		GameObject gameObject6 = default(GameObject);
		int num4;
		GameObject gameObject = default(GameObject);
		do
		{
			Bank bank = soundbank;
			if (bank != null && bank.IsValid())
			{
				AudioEmitterBankLoader audioEmitterBankLoader = bankLoader;
				if (audioEmitterBankLoader == null || !audioEmitterBankLoader.IsLoaded)
				{
					goto IL_0050;
				}
			}
			Bank vOSoundbank = VOSoundbank;
			if (vOSoundbank != null && vOSoundbank.IsValid())
			{
				AudioEmitterBankLoader audioEmitterBankLoader2 = voBankLoader;
				if (audioEmitterBankLoader2 == null || !audioEmitterBankLoader2.IsLoaded)
				{
					goto IL_0050;
				}
			}
			if ((object)gameObject != null)
			{
				Debug.Log(gameObject2.name + " : AudioEmitterCullingManager.ActivateTrigger OK.", gameObject3);
			}
			if (flag)
			{
			}
			num = 0;
			if ((long)num < (long)(IntPtr)gameObject4)
			{
				num++;
			}
			if ((object)gameObject5 == null)
			{
				while (num == 0)
				{
				}
			}
			while (num2 != 1)
			{
			}
			int num3 = 0;
			if (gameObject3 == (UnityEngine.Object)num3)
			{
				AkAmbient component = gameObject6.GetComponent<AkAmbient>();
			}
			num4 = 0;
			continue;
			IL_0050:
			string message = base.gameObject.name + " : AudioEmitterCullingManager.ActivateTrigger sounds bank are not yet ready";
			gameObject = base.gameObject;
			Debug.Log(message, gameObject);
			return;
		}
		while (!(gameObject3 != (UnityEngine.Object)num4));
		GameObject value = default(GameObject);
		int num5 = ((int*)num)->CompareTo(value);
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA4E590", Offset = "0xA4CF90", VA = "0x180A4E590")]
	private void OnTriggerExit(Collider other)
	{
		//Discarded unreachable code: IL_00a4
		if (!other.CompareTag("MainCamera"))
		{
			return;
		}
		AkSoundEngine.StopAll(base.gameObject);
		isInsideCollider = false;
		if (usingRadialEmitter)
		{
			AkRadialEmitter akRadialEmitter = radialEmitter;
			int num = ((akRadialEmitter.enabled = false) ? 1 : 0);
		}
		if (banksLoaded)
		{
			AudioEmitterBankLoader audioEmitterBankLoader = bankLoader;
			int referenceCount = 0;
			if (audioEmitterBankLoader != null)
			{
				audioEmitterBankLoader.referenceCount = referenceCount;
			}
			AudioEmitterBankLoader audioEmitterBankLoader2 = voBankLoader;
			if (audioEmitterBankLoader2 != null)
			{
				audioEmitterBankLoader2.referenceCount = referenceCount;
			}
			banksLoaded = (byte)referenceCount != 0;
		}
		AKRESULT aKRESULT = AkSoundEngine.UnregisterGameObj(base.gameObject);
		if (triggerType != TriggerType.UseAkAmbient && !usingRadialEmitter)
		{
			UnityEngine.Object.Destroy(currentgO);
		}
		else
		{
			int num2 = 0;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA4ECF0", Offset = "0xA4D6F0", VA = "0x180A4ECF0")]
	public unsafe AudioEmitterCullingManager()
	{
		//IL_0019: Expected F4, but got I8
		//IL_0014: Expected native int or pointer, but got O
		int num = 0;
		ulong num2 = default(ulong);
		((Vector3*)(IntPtr)offset)->z = (long)num2;
		wwiseSwitch = new Switch[num];
		base._002Ector();
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	static AudioEmitterCullingManager()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
