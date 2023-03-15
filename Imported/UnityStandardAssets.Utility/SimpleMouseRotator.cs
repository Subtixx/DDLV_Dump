using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public Vector2 rotationRange = (Vector2)1116471296;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public float dampingTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public bool autoZeroVerticalOnMobile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public bool autoZeroHorizontalOnMobile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public bool relative;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private Vector3 m_TargetAngles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private Vector3 m_FollowAngles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private Vector3 m_FollowVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private Quaternion m_OriginalRotation;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1E60", Offset = "0x3DC0860", VA = "0x183DC1E60")]
		private void Start()
		{
			//Discarded unreachable code: IL_0008
			Transform transform = base.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1EA0", Offset = "0x3DC08A0", VA = "0x183DC1EA0")]
		private unsafe void Update()
		{
			//Discarded unreachable code: IL_0163
			//IL_0034: Expected native int or pointer, but got O
			//IL_0082: Expected native int or pointer, but got O
			//IL_0092: Invalid comparison between O and F4
			//IL_00b9: Expected native int or pointer, but got O
			//IL_00de: Expected O, but got F4
			//IL_00e6: Expected native int or pointer, but got O
			//IL_010d: Expected native int or pointer, but got O
			//IL_011a: Expected O, but got F4
			//IL_014d: Expected native int or pointer, but got O
			Transform transform = base.transform;
			Quaternion quaternion = (transform.localRotation = m_OriginalRotation);
			if (!relative)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int width = Screen.width;
				float y = default(float);
				((Vector3*)(IntPtr)m_TargetAngles)->y = y;
				int num4 = 0;
				int height = Screen.height;
			}
			float axis = CrossPlatformInputManager.GetAxis("Mouse X");
			float axis2 = CrossPlatformInputManager.GetAxis("Mouse Y");
			if (!(m_TargetAngles.y <= 180f))
			{
				float y2 = m_FollowAngles.y;
				((Vector3*)(IntPtr)m_FollowAngles)->y = y2;
			}
			if (m_TargetAngles > (object)180f)
			{
				Vector3 vector = (m_FollowAngles = m_FollowAngles);
			}
			float y3 = m_FollowAngles.y;
			((Vector3*)(IntPtr)m_FollowAngles)->y = y3;
			Vector3 vector2 = (m_FollowAngles = m_FollowAngles);
			float num5 = rotationSpeed;
			m_TargetAngles = (Vector3)num5;
			((Vector3*)(IntPtr)m_TargetAngles)->y = num5;
			float y4 = rotationRange.y;
			float y5 = Mathf.Clamp(num5, y4, y4);
			((Vector3*)(IntPtr)m_TargetAngles)->y = y5;
			float num6 = default(float);
			m_TargetAngles = (Vector3)num6;
			float z = m_TargetAngles.z;
			float num7 = dampingTime;
			float z2 = m_FollowAngles.z;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			((Vector3*)(IntPtr)m_FollowAngles)->z = z3;
			Transform transform2 = base.transform;
			Quaternion originalRotation2 = m_OriginalRotation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2240", Offset = "0x3DC0C40", VA = "0x183DC2240")]
		public unsafe SimpleMouseRotator()
		{
			//IL_000d: Expected O, but got I8
			//IL_0018: Expected native int or pointer, but got O
			((Vector2*)(IntPtr)rotationRange)->y = 70f;
			rotationSpeed = 10f;
			dampingTime = 0.2f;
			autoZeroVerticalOnMobile = true;
			relative = true;
			base._002Ector();
		}
	}
}
