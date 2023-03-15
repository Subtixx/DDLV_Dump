using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Rewired;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class DragRigidbody : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private const float k_Spring = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private const float k_Damper = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private const float k_Drag = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private const float k_AngularDrag = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private const float k_Distance = 0.2f;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private const bool k_AttachToCenterOfMass = false;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private SpringJoint m_SpringJoint;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B160", Offset = "0x2F09B60", VA = "0x182F0B160")]
		private void Update()
		{
			//Discarded unreachable code: IL_0135
			//IL_00cd: Expected O, but got I4
			//IL_00e8: Expected O, but got I4
			//IL_0132: Expected O, but got F4
			int num = 0;
			Mouse mouse = ReInput.controllers.Mouse;
			int index = 0;
			if (!mouse.GetButtonDown(index))
			{
				return;
			}
			if (!GetComponent<Camera>())
			{
				int num2 = 0;
				Camera main = Camera.main;
			}
			Camera component = GetComponent<Camera>();
			int num3 = 0;
			float z = UnityEngine.Input.mousePosition.z;
			float z2 = UnityEngine.Input.mousePosition.z;
			bool flag = default(bool);
			Rigidbody rigidbody = default(Rigidbody);
			Rigidbody rigidbody2 = default(Rigidbody);
			if (flag && (bool)rigidbody && !rigidbody2.isKinematic)
			{
				if (!m_SpringJoint)
				{
					GameObject gameObject = new GameObject("Rigidbody dragger");
					Rigidbody rigidbody3 = gameObject.AddComponent<Rigidbody>();
					SpringJoint springJoint = (m_SpringJoint = gameObject.AddComponent<SpringJoint>());
					rigidbody3.isKinematic = true;
				}
				SpringJoint springJoint2 = m_SpringJoint;
				int num4 = 0;
				springJoint2.transform.position = (Vector3)num4;
				SpringJoint springJoint3 = m_SpringJoint;
				int num5 = 0;
				Vector3 zero = Vector3.zero;
				springJoint3.anchor = (Vector3)num5;
				m_SpringJoint.spring = 50f;
				m_SpringJoint.damper = 5f;
				m_SpringJoint.maxDistance = 0.2f;
				Rigidbody connectedBody = default(Rigidbody);
				m_SpringJoint.connectedBody = connectedBody;
				float num6 = default(float);
				Coroutine coroutine = StartCoroutine("DragObject", num6);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B040", Offset = "0x2F09A40", VA = "0x182F0B040")]
		[IteratorStateMachine(typeof(_003CDragObject_003Ed__8))]
		private IEnumerator DragObject(float distance)
		{
			int _003C_003E1__state = default(int);
			_003CDragObject_003Ed__8 _003CDragObject_003Ed__ = new _003CDragObject_003Ed__8(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDragObject_003Ed__._003C_003E4__this = this;
			_003CDragObject_003Ed__.distance = distance;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B0C0", Offset = "0x2F09AC0", VA = "0x182F0B0C0")]
		private Camera FindCamera()
		{
			if (!GetComponent<Camera>())
			{
				int num = 0;
				return Camera.main;
			}
			return GetComponent<Camera>();
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DragRigidbody()
		{
		}
	}
}
