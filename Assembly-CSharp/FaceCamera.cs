using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class FaceCamera : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private Transform camera;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E91FF0", Offset = "0x1E909F0", VA = "0x181E91FF0")]
	private void Start()
	{
		int num = 0;
		Transform transform = (camera = Camera.main.transform);
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E92030", Offset = "0x1E90A30", VA = "0x181E92030")]
	private void Update()
	{
		//Discarded unreachable code: IL_0039
		Transform transform = base.transform;
		Transform target = camera;
		transform.LookAt(target);
		Transform transform2 = base.transform;
		Transform transform3 = camera;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		float z2 = Vector3.up.z;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public FaceCamera()
	{
	}
}
