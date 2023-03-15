using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FishingTarget : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	private SpriteRenderer[] arrows;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	private float sinAmplitude;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private float sinSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private float fadeInDuration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private float fadeOutDuration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private float bounceDuration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private float bounceAmplitude;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private AnimationCurve bounce;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private Vector3[] directions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Vector3[] positions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Vector3 baseScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Coroutine fadeOutCoroutine;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x14559D0", Offset = "0x14543D0", VA = "0x1814559D0")]
	private unsafe void Awake()
	{
		//Discarded unreachable code: IL_007e
		//IL_0015: Expected native int or pointer, but got O
		//IL_0075: Expected O, but got F4
		Transform transform = base.transform;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		((Vector3*)(IntPtr)baseScale)->z = z;
		Vector3[] array = (positions = new Vector3[arrows.Length]);
		Vector3[] array2 = positions;
		int num = 0;
		if (num < array2.Length)
		{
			Transform transform2 = arrows[num].transform;
			num++;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			array2[1] = (Vector3)z2;
			Vector3[] array3 = positions;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1455ED0", Offset = "0x14548D0", VA = "0x181455ED0")]
	private void Update()
	{
		//Discarded unreachable code: IL_0045
		int num = 0;
		SpriteRenderer[] array = arrows;
		if (num < array.Length)
		{
			Transform transform = array[num].transform;
			Vector3[] array2 = positions;
			Vector3[] array3 = directions;
			int num2 = 0;
			float time = Time.time;
			SpriteRenderer[] array4 = arrows;
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1455C30", Offset = "0x1454630", VA = "0x181455C30")]
	public void FadeIn([Optional] Action callback)
	{
		Coroutine coroutine = fadeOutCoroutine;
		if (coroutine != null)
		{
			StopCoroutine(coroutine);
		}
		if (!base.isActiveAndEnabled)
		{
			callback?.Invoke();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1455CC0", Offset = "0x14546C0", VA = "0x181455CC0")]
	public void FadeOut([Optional] Action callback)
	{
		//IL_0055: Expected F4, but got I4
		if (!base.isActiveAndEnabled)
		{
			callback?.Invoke();
			return;
		}
		float duration = fadeOutDuration;
		Action callback2 = delegate
		{
			callback?.Invoke();
			FishingTarget fishingTarget = this;
			throw new NullReferenceException();
		};
		int num = 0;
		IEnumerator routine = Fading(1f, num, duration, callback2);
		Coroutine coroutine = (fadeOutCoroutine = StartCoroutine(routine));
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1455E10", Offset = "0x1454810", VA = "0x181455E10")]
	[IteratorStateMachine(typeof(_003CFading_003Ed__16))]
	private IEnumerator Fading(float from, float to, float duration, Action callback)
	{
		//IL_0017: Expected O, but got I4
		int _003C_003E1__state = default(int);
		_003CFading_003Ed__16 _003CFading_003Ed__ = new _003CFading_003Ed__16(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CFading_003Ed__._003C_003E4__this = this;
		_003CFading_003Ed__.callback = (Action)0;
		_003CFading_003Ed__.from = from;
		_003CFading_003Ed__.to = to;
		_003CFading_003Ed__.duration = duration;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1455B40", Offset = "0x1454540", VA = "0x181455B40")]
	public void Bounce()
	{
		//Discarded unreachable code: IL_0019
		int _003C_003E1__state = default(int);
		_003CBouncing_003Ed__18 _003CBouncing_003Ed__ = new _003CBouncing_003Ed__18(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CBouncing_003Ed__._003C_003E4__this = this;
		Coroutine coroutine = StartCoroutine(_003CBouncing_003Ed__);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1455BC0", Offset = "0x14545C0", VA = "0x181455BC0")]
	[IteratorStateMachine(typeof(_003CBouncing_003Ed__18))]
	private IEnumerator Bouncing()
	{
		int _003C_003E1__state = default(int);
		_003CBouncing_003Ed__18 _003CBouncing_003Ed__ = new _003CBouncing_003Ed__18(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CBouncing_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public FishingTarget()
	{
	}
}
