using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AnalogActor : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private RectTransform rectTramsform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float Deslocaton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Vector3 InitialPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float speed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Vector3 initialScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Vector3 ScaleSmear;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Vector3 oldPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float _MaxVelocitySmear;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float MinvelocitySmear;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2F06510", Offset = "0x2F04F10", VA = "0x182F06510")]
	private unsafe void Start()
	{
		//Discarded unreachable code: IL_0048
		//IL_002c: Expected native int or pointer, but got O
		//IL_0042: Expected native int or pointer, but got O
		RectTransform rectTransform = (rectTramsform = GetComponent<RectTransform>());
		RectTransform rectTransform2 = rectTramsform;
		RectTransform rectTransform3 = rectTramsform;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		((Vector3*)(IntPtr)InitialPosition)->z = z;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		((Vector3*)(IntPtr)initialScale)->z = z2;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2F065C0", Offset = "0x2F04FC0", VA = "0x182F065C0")]
	private unsafe void Update()
	{
		//Discarded unreachable code: IL_0124
		//IL_004d: Expected O, but got I4
		//IL_008f: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_00b0: Expected F4, but got I4
		//IL_00ea: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_011e: Expected native int or pointer, but got O
		int num = 0;
		float axis = Input.GetAxis("Horizontal");
		float axis2 = Input.GetAxis("Vertical");
		if (!(axis <= 0.05f))
		{
		}
		if (!(axis2 <= 0.05f))
		{
		}
		RectTransform rectTransform = rectTramsform;
		int num2 = 0;
		float deltaTime = Time.deltaTime;
		int num3 = 0;
		float num4 = Mathf.Clamp01(deltaTime);
		rectTransform.anchoredPosition3D = (Vector3)num3;
		Transform transform = base.transform;
		float z = oldPosition.z;
		Vector3 vector = default(Vector3);
		float z2 = vector.z;
		float num5 = default(float);
		if (!(num5 > 0.001f))
		{
			Transform transform2 = base.transform;
			int num6 = 0;
			Quaternion identity = Quaternion.identity;
			transform2.rotation = (Quaternion)num6;
			int num7 = 0;
			base.transform.localScale = (Vector3)num7;
		}
		int num8 = 0;
		float value = default(float);
		float value2 = Mathf.Clamp(value, num8, 1f);
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		float num9 = Mathf.Clamp01(value2);
		int num10 = 0;
		float deltaTime2 = Time.deltaTime;
		int num11 = 0;
		float num12 = Mathf.Clamp01(deltaTime2);
		transform3.localScale = (Vector3)num11;
		Transform transform5 = base.transform;
		int num13 = 0;
		Vector3 right = Vector3.right;
		transform5.rotation = (Quaternion)num13;
		Transform transform6 = base.transform;
		Vector3 vector2 = default(Vector3);
		float z3 = vector2.z;
		((Vector3*)(IntPtr)oldPosition)->z = z3;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2F06B40", Offset = "0x2F05540", VA = "0x182F06B40")]
	public unsafe AnalogActor()
	{
		//IL_000e: Expected F4, but got I4
		//IL_0009: Expected native int or pointer, but got O
		((Vector3*)(IntPtr)ScaleSmear)->z = 0f;
		Deslocaton = 20f;
		speed = 10f;
		_MaxVelocitySmear = 0.2f;
		base._002Ector();
	}
}
