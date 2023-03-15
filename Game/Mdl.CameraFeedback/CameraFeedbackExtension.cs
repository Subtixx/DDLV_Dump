using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.CameraFeedback
{
	[Cpp2IlInjected.Token(Token = "0x200093A")]
	[RequireComponent(typeof(CameraFeedbackSystem))]
	public abstract class CameraFeedbackExtension : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003343")]
		private CameraFeedbackSystem system;

		[Cpp2IlInjected.Token(Token = "0x6002A75")]
		[Cpp2IlInjected.Address(RVA = "0x164BFE0", Offset = "0x164A9E0", VA = "0x18164BFE0", Slot = "4")]
		protected virtual void Awake()
		{
			//Discarded unreachable code: IL_0020
			CameraFeedbackSystem cameraFeedbackSystem = (system = GetComponent<CameraFeedbackSystem>());
			((List<T>)(object)system.extensions).Add((T)this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A76")]
		[Cpp2IlInjected.Address(RVA = "0x164C0B0", Offset = "0x164AAB0", VA = "0x18164C0B0", Slot = "5")]
		protected virtual void OnDestroy()
		{
			//Discarded unreachable code: IL_0013
			bool flag = ((List<T>)(object)system.extensions).Remove((T)this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A77")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void OnFeedback(ref CameraFeedbackSystem.Modification modification);

		[Cpp2IlInjected.Token(Token = "0x6002A78")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnReset();

		[Cpp2IlInjected.Token(Token = "0x6002A79")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected CameraFeedbackExtension()
		{
		}
	}
}
