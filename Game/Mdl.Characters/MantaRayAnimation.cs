using System;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008A7")]
	public class MantaRayAnimation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030C1")]
		public MantaRayAnimationConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030C2")]
		public Transform ray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030C3")]
		private float hAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40030C4")]
		private float vAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40030C5")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.Token(Token = "0x6002806")]
		[Cpp2IlInjected.Address(RVA = "0xBBDC50", Offset = "0xBBC650", VA = "0x180BBDC50")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_00bd
			//IL_000b: Expected F4, but got I4
			//IL_001e: Expected F4, but got I4
			//IL_0083: Expected native int or pointer, but got O
			float num = (hAngle = UnityEngine.Random.Range(0f, (float)Math.PI * 2f));
			float num2 = UnityEngine.Random.Range(0f, (float)Math.PI * 2f);
			Transform transform = ray;
			vAngle = num2;
			Transform transform2 = transform.transform;
			float maxDepth = config.maxDepth;
			float num3 = vAngle;
			float num4 = hAngle;
			MantaRayAnimationConfig mantaRayAnimationConfig = config;
			float num5 = hAngle;
			float maxDepth2 = mantaRayAnimationConfig.maxDepth;
			float num6 = vAngle;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)lastPosition)->z = z;
			Transform transform3 = ray.transform;
			Transform transform4 = ray.transform;
			float z2 = lastPosition.z;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			num5 = num6;
		}

		[Cpp2IlInjected.Token(Token = "0x6002807")]
		[Cpp2IlInjected.Address(RVA = "0xBBDE70", Offset = "0xBBC870", VA = "0x180BBDE70")]
		private unsafe void Update()
		{
			//Discarded unreachable code: IL_00f8
			//IL_00f2: Expected native int or pointer, but got O
			float hSpeed = config.hSpeed;
			int num = 0;
			float deltaTime = Time.deltaTime;
			MantaRayAnimationConfig mantaRayAnimationConfig = config;
			hAngle = deltaTime;
			float num2 = Trigo.ClampAngleRadians(deltaTime);
			MantaRayAnimationConfig mantaRayAnimationConfig2 = config;
			hAngle = num2;
			float vSpeed = mantaRayAnimationConfig2.vSpeed;
			int num3 = 0;
			float num4 = Trigo.ClampAngleRadians(vAngle = Time.deltaTime);
			Transform transform = ray;
			vAngle = num4;
			Transform transform2 = transform.transform;
			float maxDepth = config.maxDepth;
			float num5 = vAngle;
			float num6 = hAngle;
			Transform transform3 = ray.transform;
			Transform transform4 = ray.transform;
			float z = lastPosition.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			num6 = num5;
			deltaTime = num5;
			Transform transform5 = ray;
			Transform transform6 = transform5.transform;
			float z3 = transform5.position.z;
			((Vector3*)(IntPtr)lastPosition)->z = z3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002808")]
		[Cpp2IlInjected.Address(RVA = "0xBBD9E0", Offset = "0xBBC3E0", VA = "0x180BBD9E0")]
		private Vector3 GetPosition(float hAngle, float vAngle, float maxDepth)
		{
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			float num = vAngle * 0.5f;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002809")]
		[Cpp2IlInjected.Address(RVA = "0xBBD9A0", Offset = "0xBBC3A0", VA = "0x180BBD9A0")]
		private float GetDepth(float radians, float maxDepth)
		{
			return radians * 0.5f;
		}

		[Cpp2IlInjected.Token(Token = "0x600280A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MantaRayAnimation()
		{
		}
	}
}
