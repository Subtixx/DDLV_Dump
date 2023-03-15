using System.ComponentModel;
using Cpp2IlInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[ParadoxNotion.Design.Category("Mdl/AI")]
	[Icon("Dialogue", false, "")]
	[ParadoxNotion.Design.Description("either set targetPosition or targetGameObject. tells the ai to move them. you need to check event moved to know when the charcter reached its destination")]
	public class AiSetMoveToTarget : ActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public BBParameter<Vector3> targetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public BBParameter<GameObject> targetGameObject;

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xA3D140", Offset = "0xA3BB40", VA = "0x180A3D140", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_000c
				return GetType().Name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF20", Offset = "0xA3B920", VA = "0x180A3CF20", Slot = "13")]
		protected override void OnExecute()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "14")]
		protected override void OnUpdate()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F0", Offset = "0x8CBEF0", VA = "0x1808CD4F0", Slot = "15")]
		protected override void OnStop(bool interrupted)
		{
			string filter = ((IBindingListView)this).Filter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		protected override void OnStop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void OnPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xA3D130", Offset = "0xA3BB30", VA = "0x180A3D130")]
		public AiSetMoveToTarget()
		{
		}
	}
}
