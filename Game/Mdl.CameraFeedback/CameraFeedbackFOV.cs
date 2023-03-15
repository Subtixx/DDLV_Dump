using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.CameraFeedback
{
	[Cpp2IlInjected.Token(Token = "0x2000941")]
	public class CameraFeedbackFOV : CameraFeedbackExtension
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003356")]
		[SerializeField]
		private float lerp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003357")]
		private float modification;

		[Cpp2IlInjected.Token(Token = "0x6002A97")]
		[Cpp2IlInjected.Address(RVA = "0x164C140", Offset = "0x164AB40", VA = "0x18164C140", Slot = "6")]
		public override void OnFeedback(ref CameraFeedbackSystem.Modification modification)
		{
			//IL_0029: Expected F4, but got I4
			float num = (modification.fieldOfView = modification.fieldOfView);
			int num2 = 0;
			float deltaTime = Time.deltaTime;
			float t = lerp;
			int num3 = 0;
			float num4 = (this.modification = Mathf.Lerp(deltaTime, num3, t));
		}

		[Cpp2IlInjected.Token(Token = "0x6002A98")]
		[Cpp2IlInjected.Address(RVA = "0x1111FD0", Offset = "0x11109D0", VA = "0x181111FD0", Slot = "7")]
		public override void OnReset()
		{
			modification = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A99")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF90", Offset = "0xA7C990", VA = "0x180A7DF90")]
		public void SetModification(float value)
		{
			modification = value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A9A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraFeedbackFOV()
		{
		}
	}
}
