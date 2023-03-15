using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000004")]
[ExecuteInEditMode]
[RequireComponent(typeof(LineRenderer))]
public class FishingLine : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private LineRenderer m_LineRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x113070", Offset = "0x112470")]
	public float tension;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float colorTension;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 lineStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Vector3 lineEnd;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int resolution = 16;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private LineRenderer _LineRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1370CB0", Offset = "0x136F6B0", VA = "0x181370CB0")]
		get
		{
			bool flag = default(bool);
			if (flag)
			{
				LineRenderer lineRenderer = (m_LineRenderer = GetComponent<LineRenderer>());
			}
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1370730", Offset = "0x136F130", VA = "0x181370730")]
	private void OnEnable()
	{
		Application.onBeforeRender += UpdatePoints;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x13706C0", Offset = "0x136F0C0", VA = "0x1813706C0")]
	private void OnDisable()
	{
		Application.onBeforeRender -= UpdatePoints;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13707A0", Offset = "0x136F1A0", VA = "0x1813707A0")]
	public void UpdatePoints()
	{
		//Discarded unreachable code: IL_012e
		//IL_0047: Expected O, but got F4
		//IL_007c: Expected O, but got F4
		//IL_00ce: Expected F4, but got I4
		//IL_00d7: Expected F4, but got I4
		//IL_00e0: Expected F4, but got I4
		//IL_00f4: Expected O, but got F4
		Vector3[] array = new Vector3[resolution];
		LineRenderer lineRenderer = _LineRenderer;
		int vertexCount = resolution;
		lineRenderer.SetVertexCount(vertexCount);
		Transform transform = base.transform;
		float z = lineStart.z;
		Vector3 vector = default(Vector3);
		float z2 = vector.z;
		array[1] = (Vector3)z2;
		int num = resolution;
		Transform transform2 = base.transform;
		float z3 = lineEnd.z;
		int num2 = num - 1;
		Vector3 vector2 = default(Vector3);
		float z4 = vector2.z;
		array[1] = (Vector3)z4;
		float z5 = lineStart.z;
		float num3 = Mathf.Clamp01(0.5f);
		float num4 = tension;
		Vector3 gravity = Physics.gravity;
		if (resolution - 1 > 1)
		{
			int num5 = 0;
			Transform transform3 = base.transform;
			float z6 = lineStart.z;
			float num6 = Mathf.Clamp01(num5);
			float num7 = Mathf.Clamp01(num5);
			float num8 = Mathf.Clamp01(num5);
			Vector3 vector3 = default(Vector3);
			float z7 = vector3.z;
			array[1] = (Vector3)z7;
			int num9 = resolution - 1;
		}
		_LineRenderer.SetPositions(array);
		Material sharedMaterial = ((Renderer)_LineRenderer).GetSharedMaterial();
		float value = colorTension;
		sharedMaterial.SetFloat("_Tension_fishing_line", value);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1370CA0", Offset = "0x136F6A0", VA = "0x181370CA0")]
	public FishingLine()
	{
	}//IL_000a: Expected I4, but got I8

}
