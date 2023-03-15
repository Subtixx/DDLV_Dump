using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.CameraFeedback
{
	[Cpp2IlInjected.Token(Token = "0x2000940")]
	public class CameraFeedbackBounce : CameraFeedbackExtension
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003353")]
		private float start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003354")]
		private float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003355")]
		private AnimationCurve curve;

		[Cpp2IlInjected.Token(Token = "0x6002A93")]
		[Cpp2IlInjected.Address(RVA = "0x164BED0", Offset = "0x164A8D0", VA = "0x18164BED0", Slot = "6")]
		public override void OnFeedback(ref CameraFeedbackSystem.Modification modification)
		{
			//Discarded unreachable code: IL_002d
			AnimationCurve animationCurve = curve;
			if (animationCurve != null)
			{
				int num = 0;
				float time = Time.time;
				float num2 = animationCurve.Evaluate(time);
				Transform transform = base.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A94")]
		[Cpp2IlInjected.Address(RVA = "0x164BFC0", Offset = "0x164A9C0", VA = "0x18164BFC0", Slot = "7")]
		public override void OnReset()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A95")]
		[Cpp2IlInjected.Address(RVA = "0x164BE80", Offset = "0x164A880", VA = "0x18164BE80")]
		public void Bounce(float duration, AnimationCurve curve)
		{
			int num = 0;
			float time = Time.time;
			this.curve = curve;
			start = time;
			this.duration = duration;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A96")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CameraFeedbackBounce()
		{
		}
	}
}
