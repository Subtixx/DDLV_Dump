using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public float minDuration = 8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public float maxDuration = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private float m_MaxLifetime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private bool m_EarlyStop;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C550", Offset = "0x2F1AF50", VA = "0x182F1C550")]
		[IteratorStateMachine(typeof(_003CStart_003Ed__4))]
		private IEnumerator Start()
		{
			int _003C_003E1__state = default(int);
			_003CStart_003Ed__4 _003CStart_003Ed__ = new _003CStart_003Ed__4(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CStart_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C5C0", Offset = "0x2F1AFC0", VA = "0x182F1C5C0")]
		public void Stop()
		{
			m_EarlyStop = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C5D0", Offset = "0x2F1AFD0", VA = "0x182F1C5D0")]
		public ParticleSystemDestroyer()
		{
		}
	}
}
