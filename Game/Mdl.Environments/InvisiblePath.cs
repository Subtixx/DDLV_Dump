using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000654")]
	public class InvisiblePath : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025B5")]
		private Collider pathCollider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40025B6")]
		private Rect? localBoundXZ;

		[Cpp2IlInjected.Token(Token = "0x170003F6")]
		private Rect? LocalBoundXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6001C3F")]
			[Cpp2IlInjected.Address(RVA = "0x11BD6D0", Offset = "0x11BC0D0", VA = "0x1811BD6D0")]
			get
			{
				bool flag = default(bool);
				if (!flag && (IntPtr)"{il2cpp array field il2cppMethodInfo->}" == (IntPtr)(flag ? 1 : 0))
				{
					Vector3 vector = default(Vector3);
					float z = vector.z;
					int num = 0;
					int num2 = 0;
					int num3 = 0;
				}
				int num4 = 0;
				int num5 = 0;
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num5;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C3E")]
		[Cpp2IlInjected.Address(RVA = "0x11BD680", Offset = "0x11BC080", VA = "0x1811BD680")]
		private void Start()
		{
			Collider collider = (pathCollider = GetComponent<Collider>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C40")]
		[Cpp2IlInjected.Address(RVA = "0x11BD540", Offset = "0x11BBF40", VA = "0x1811BD540")]
		public bool IsInside(Vector3 position)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001C41")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InvisiblePath()
		{
		}
	}
}
