using Cpp2IlInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[Description("MoveToRewardPosition")]
	[Category("Mdl/Hangout")]
	public class RotateTowardsRewardPositionTask : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public BBParameter<float> speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		[SliderField(1, 180)]
		public BBParameter<float> angleDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public BBParameter<Vector3> upVector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public bool waitActionFinish;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xCC50F0", Offset = "0xCC3AF0", VA = "0x180CC50F0", Slot = "14")]
		protected override void OnUpdate()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xCC5410", Offset = "0xCC3E10", VA = "0x180CC5410")]
		public RotateTowardsRewardPositionTask()
		{
			BBParameter<> bBParameter = default(BBParameter<>);
			speed = (BBParameter<float>)(object)bBParameter;
			BBParameter<> bBParameter2 = default(BBParameter<>);
			angleDifference = (BBParameter<float>)(object)bBParameter2;
			float z = Vector3.up.z;
			BBParameter<> bBParameter3 = default(BBParameter<>);
			upVector = (BBParameter<Vector3>)(object)bBParameter3;
			base._002Ector();
		}
	}
}
