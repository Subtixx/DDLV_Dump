using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x200092B")]
	internal class TimidCritterApproach : Motivation<TimidCritterApproachConfig>, ICritterApproachMotivation, ICritterMotivation, IMotivation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032FC")]
		private Critter critter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032FD")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032FE")]
		private Environment environment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40032FF")]
		private GridScript currentGrid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003300")]
		private float hideTimer = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4003301")]
		private bool? hidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003302")]
		private Vector3? avatarPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003303")]
		private bool sitting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003304")]
		private GameObject hidingVFXInstance;

		[Cpp2IlInjected.Token(Token = "0x6002A1D")]
		[Cpp2IlInjected.Address(RVA = "0x13D4530", Offset = "0x13D2F30", VA = "0x1813D4530")]
		public TimidCritterApproach(TimidCritterApproachConfig timidCritterApproachConfig)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)timidCritterApproachConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1E")]
		[Cpp2IlInjected.Address(RVA = "0x13D3960", Offset = "0x13D2360", VA = "0x1813D3960", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_008c
			Critter critter = (this.critter = agent.GetComponent<Critter>());
			PlayerAvatar playerAvatar = (avatar = SystemRoot.Instance._avatar);
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			Environment environment = (this.environment = gameObject.GetComponent<Environment>());
			Critter critter2 = this.critter;
			Environment environment2 = this.environment;
			Transform transform = critter2.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			GridScript gridScript = default(GridScript);
			currentGrid = gridScript;
			this.critter.Agent.ResetPath();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A1F")]
		[Cpp2IlInjected.Address(RVA = "0x13D3BD0", Offset = "0x13D25D0", VA = "0x1813D3BD0", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A20")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A21")]
		[Cpp2IlInjected.Address(RVA = "0x13D4330", Offset = "0x13D2D30", VA = "0x1813D4330", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//IL_000b: Expected O, but got I4
			//IL_0012: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_0040: Expected O, but got I8
			int num = 0;
			int num2 = 0;
			hidden = (bool?)(object)num;
			avatarPosition = (Vector3?)(object)num2;
			GameObject gameObject = hidingVFXInstance;
			sitting = (byte)num != 0;
			int num3 = 0;
			if (gameObject != (Object)num3)
			{
				Object.Destroy(hidingVFXInstance);
				hidingVFXInstance = (GameObject)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A22")]
		[Cpp2IlInjected.Address(RVA = "0x12DA890", Offset = "0x12D9290", VA = "0x1812DA890", Slot = "19")]
		public bool ShouldTrigger(GameObject agent)
		{
			//Discarded unreachable code: IL_0002
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A23")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "20")]
		public bool ShouldFlee(GameObject agent)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A24")]
		[Cpp2IlInjected.Address(RVA = "0x13D43F0", Offset = "0x13D2DF0", VA = "0x1813D43F0", Slot = "21")]
		public bool ShouldEnterLocomotionAnimationState(GameObject agent)
		{
			//Discarded unreachable code: IL_0002
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A25")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "22")]
		public void CancelFeeding(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A26")]
		[Cpp2IlInjected.Address(RVA = "0x13D3910", Offset = "0x13D2310", VA = "0x1813D3910", Slot = "23")]
		public bool CanInteractWithAvatar()
		{
			bool? flag = hidden;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A27")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "24")]
		public bool CanBeFed()
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A28")]
		[Cpp2IlInjected.Address(RVA = "0x13D4450", Offset = "0x13D2E50", VA = "0x1813D4450")]
		private void Sit()
		{
			//IL_0012: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			GameObject gameObject = hidingVFXInstance;
			hidden = (bool?)(object)num;
			sitting = true;
			int num3 = 0;
			if (gameObject != (Object)num3)
			{
				Object.Destroy(hidingVFXInstance);
				hidingVFXInstance = (GameObject)num;
			}
		}
	}
}
