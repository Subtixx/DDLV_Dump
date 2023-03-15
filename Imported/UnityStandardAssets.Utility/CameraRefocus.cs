using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class CameraRefocus
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Camera Camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Vector3 Lookatpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Transform Parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 m_OrigCameraPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private bool m_Refocus;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2F085E0", Offset = "0x2F06FE0", VA = "0x182F085E0")]
		public unsafe CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
			//IL_0014: Expected native int or pointer, but got O
			float z = origCameraPos.z;
			((Vector3*)(IntPtr)m_OrigCameraPos)->z = z;
			Camera = camera;
			Parent = parent;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
		public void ChangeCamera(Camera camera)
		{
			Camera = camera;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
		public void ChangeParent(Transform parent)
		{
			Parent = parent;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2F08400", Offset = "0x2F06E00", VA = "0x182F08400")]
		public unsafe void GetFocusPoint()
		{
			//Discarded unreachable code: IL_0052
			//IL_004a: Expected F4, but got I4
			//IL_0045: Expected native int or pointer, but got O
			Transform transform = Parent.transform;
			float z = m_OrigCameraPos.z;
			Transform parent = Parent;
			Transform transform2 = parent.transform;
			Vector3 forward = parent.forward;
			bool flag = default(bool);
			if (!flag)
			{
				m_Refocus = flag;
				return;
			}
			((Vector3*)(IntPtr)Lookatpoint)->z = (flag ? 1 : 0);
			m_Refocus = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2F08580", Offset = "0x2F06F80", VA = "0x182F08580")]
		public void SetFocusPoint()
		{
			//Discarded unreachable code: IL_0022
			if (m_Refocus)
			{
				Transform transform = Camera.transform;
				float z = Lookatpoint.z;
			}
		}
	}
}
