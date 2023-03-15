using System;
using Cpp2IlInjected;
using Mdl.Motion;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000008")]
public class turnInPlace : StateMachineBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Animator animator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Quaternion beginRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Quaternion endRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Tween<Quaternion> rotationTween;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private float turnF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float directionF;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC820", Offset = "0x1EAB220", VA = "0x181EAC820", Slot = "4")]
	public unsafe override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		//Discarded unreachable code: IL_00d3
		//IL_005f: Expected F4, but got I4
		//IL_007d: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		float num = (directionF = Mathf.Sign(turnF = animator.GetFloat("TurnRatio")) * 179.9999f);
		Transform transform = animator.transform;
		float t = turnF;
		float b = directionF;
		float num2 = Mathf.Lerp(0f, b, t);
		int num3 = 0;
		float z = Vector3.up.z;
		b = num2;
		Quaternion quaternion = Quaternion.AngleAxis(num2, (Vector3)num3);
		Quaternion quaternion2 = beginRotation;
		int num4 = default(int);
		Tween<Quaternion>.InterpolationFunction interpolationFunction = (Tween<Quaternion>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num4, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Quaternion, Quaternion, float, Quaternion>*/)(&Quaternion.Slerp));
		num4 = 0;
		int num5 = default(int);
		EasingFunction easingFunction = new EasingFunction(num5, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
		num5 = 0;
		Tween<Quaternion> tween = default(Tween<Quaternion>);
		rotationTween = tween;
		Tween<Quaternion> tween2 = rotationTween;
		Tween<Quaternion>.UpdateEventHandler updateEventHandler = (Tween<Quaternion>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate
		{
			//Discarded unreachable code: IL_000d
			Transform transform2 = animator.transform;
		};
		((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1EACB50", Offset = "0x1EAB550", VA = "0x181EACB50", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		//Discarded unreachable code: IL_001c
		Tween<Quaternion> tween = rotationTween;
		int num = 0;
		float deltaTime = Time.deltaTime;
		int reverse = 0;
		bool flag = ((Tween<T>)(object)tween).Play(deltaTime, (byte)reverse != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
	public turnInPlace()
	{
	}
}
