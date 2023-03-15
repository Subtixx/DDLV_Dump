using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private float m_TimeOut = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private bool m_DetachChildren;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3DC39E0", Offset = "0x3DC23E0", VA = "0x183DC39E0")]
		private void Awake()
		{
			float timeOut = m_TimeOut;
			Invoke("DestroyNow", timeOut);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3A30", Offset = "0x3DC2430", VA = "0x183DC3A30")]
		private void DestroyNow()
		{
			//Discarded unreachable code: IL_0020
			if (m_DetachChildren)
			{
				base.transform.DetachChildren();
			}
			Object.Destroy(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x83A300", Offset = "0x838D00", VA = "0x18083A300")]
		public TimedObjectDestructor()
		{
		}
	}
}
