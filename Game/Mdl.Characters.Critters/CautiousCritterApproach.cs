using System;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x200092C")]
	internal class CautiousCritterApproach : Motivation<CautiousCritterApproachConfig>, ICritterApproachMotivation, ICritterMotivation, IMotivation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003305")]
		private Critter critter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003306")]
		private PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003307")]
		private Mdl.Environments.Environment environment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003308")]
		private GridScript currentGrid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003309")]
		private float timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400330A")]
		private bool highAlert;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400330B")]
		private Vector3 avatarPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400330C")]
		private bool sitting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400330D")]
		private GameObject highAlertVFXInstance;

		[Cpp2IlInjected.Token(Token = "0x6002A29")]
		[Cpp2IlInjected.Address(RVA = "0x12DA8B0", Offset = "0x12D92B0", VA = "0x1812DA8B0")]
		public CautiousCritterApproach(CautiousCritterApproachConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2A")]
		[Cpp2IlInjected.Address(RVA = "0x12D9EA0", Offset = "0x12D88A0", VA = "0x1812D9EA0", Slot = "15")]
		protected unsafe override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_00c9
			//IL_00b7: Expected native int or pointer, but got O
			Critter critter = (this.critter = agent.GetComponent<Critter>());
			PlayerAvatar playerAvatar = (avatar = SystemRoot.Instance._avatar);
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			Mdl.Environments.Environment environment = (this.environment = gameObject.GetComponent<Mdl.Environments.Environment>());
			Critter critter2 = this.critter;
			Mdl.Environments.Environment environment2 = this.environment;
			Transform transform = critter2.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			GridScript gridScript = default(GridScript);
			currentGrid = gridScript;
			PlayerAvatar playerAvatar2 = avatar;
			highAlert = false;
			timer = 0f;
			Transform _003Ctransform_003Ek__BackingField = playerAvatar2.transform;
			Critter critter3 = this.critter;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			((Vector3*)(IntPtr)avatarPosition)->z = z2;
			critter3.Agent.ResetPath();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2B")]
		[Cpp2IlInjected.Address(RVA = "0x12DA160", Offset = "0x12D8B60", VA = "0x1812DA160", Slot = "18")]
		protected unsafe override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0014: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			//IL_012d: Expected O, but got I4
			//IL_014b: Expected O, but got I8
			//IL_016a: Invalid comparison between I4 and F4
			//IL_0198: Invalid comparison between F4 and I4
			//IL_01bb: Expected native int or pointer, but got O
			//IL_01f9: Expected F4, but got O
			//IL_020d: Expected F4, but got O
			//IL_022b: Expected native int or pointer, but got O
			//IL_023c: Expected O, but got I4
			int num = 0;
			Critter critter = this.critter;
			int num2 = 0;
			int num3 = 0;
			if (!(critter == (UnityEngine.Object)num3))
			{
				PlayerAvatar playerAvatar = avatar;
				Mdl.Environments.Environment environment = this.environment;
				Transform _003Ctransform_003Ek__BackingField = playerAvatar.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num4 = 0;
				GridScript gridScript = default(GridScript);
				if (gridScript != (UnityEngine.Object)num4)
				{
					GridScript gridScript2 = currentGrid;
					if (gridScript != gridScript2)
					{
						goto IL_025f;
					}
				}
				bool flag = default(bool);
				if (flag)
				{
					Transform _003Ctransform_003Ek__BackingField2 = avatar.transform;
					Critter critter2 = this.critter;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					Transform transform = critter2.transform;
					Vector3 vector3 = default(Vector3);
					float z3 = vector3.z;
					float num5 = default(float);
					if (!(num5 > elapsed))
					{
						highAlert = false;
						if (sitting)
						{
							Animator animator = this.critter.Animator;
							AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
							float length = animatorStateInfo.m_Length;
							int loop = animatorStateInfo.m_Loop;
							bool flag2 = default(bool);
							if (flag2)
							{
								goto IL_00f6;
							}
						}
						Critter critter3 = this.critter;
						sitting = true;
						critter3.Animator.SetTrigger("Sit");
						goto IL_00f6;
					}
					goto IL_014b;
				}
			}
			goto IL_025f;
			IL_025f:
			int num6 = 0;
			throw new NullReferenceException();
			IL_014b:
			float num7 = timer;
			int num8 = 0;
			bool flag3 = highAlert;
			timer = num7;
			Transform _003Ctransform_003Ek__BackingField4 = default(Transform);
			if (!((float)num8 >= num7))
			{
				if (!flag3)
				{
					Transform transform2 = this.critter.transform;
					Transform _003Ctransform_003Ek__BackingField3 = avatar.transform;
					transform2.LookAt(_003Ctransform_003Ek__BackingField3);
				}
				if (num7 <= (float)num8)
				{
					goto IL_025f;
				}
				_003Ctransform_003Ek__BackingField4 = avatar.transform;
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				((Vector3*)(IntPtr)avatarPosition)->z = z4;
			}
			Critter critter4 = this.critter;
			bool flag4 = (highAlert = (object)_003Ctransform_003Ek__BackingField4 == null);
			if ((object)_003Ctransform_003Ek__BackingField4 != null)
			{
				Animator animator2 = critter4.Animator;
				animator2.SetTrigger("Exit");
				timer = (float)animator2;
			}
			Animator animator3 = default(Animator);
			animator3.SetTrigger("HighAlert");
			timer = (float)animator3;
			Transform _003Ctransform_003Ek__BackingField5 = avatar.transform;
			Vector3 vector5 = default(Vector3);
			float z5 = vector5.z;
			((Vector3*)(IntPtr)avatarPosition)->z = z5;
			int num9 = 0;
			GameObject gameObject = default(GameObject);
			if (gameObject != (UnityEngine.Object)num9)
			{
				Transform transform3 = this.critter.transform;
				GameObject gameObject2 = (highAlertVFXInstance = UnityEngine.Object.Instantiate(gameObject, transform3));
			}
			goto IL_025f;
			IL_00f6:
			Transform transform4 = this.critter.transform;
			Transform _003Ctransform_003Ek__BackingField6 = avatar.transform;
			transform4.LookAt(_003Ctransform_003Ek__BackingField6);
			GameObject gameObject3 = highAlertVFXInstance;
			int num10 = 0;
			if (gameObject3 != (UnityEngine.Object)num10)
			{
				gameObject = highAlertVFXInstance;
				UnityEngine.Object.Destroy(gameObject);
				highAlertVFXInstance = (GameObject)0;
				goto IL_014b;
			}
			goto IL_025f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2D")]
		[Cpp2IlInjected.Address(RVA = "0x12DA750", Offset = "0x12D9150", VA = "0x1812DA750", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			//IL_0027: Expected O, but got I8
			GameObject gameObject = highAlertVFXInstance;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(highAlertVFXInstance);
				highAlertVFXInstance = (GameObject)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2E")]
		[Cpp2IlInjected.Address(RVA = "0x12DA890", Offset = "0x12D9290", VA = "0x1812DA890", Slot = "19")]
		public bool ShouldTrigger(GameObject agent)
		{
			//Discarded unreachable code: IL_0002
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A2F")]
		[Cpp2IlInjected.Address(RVA = "0x12DA800", Offset = "0x12D9200", VA = "0x1812DA800", Slot = "20")]
		public bool ShouldFlee(GameObject agent)
		{
			if (highAlert)
			{
				Transform _003Ctransform_003Ek__BackingField = avatar.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A30")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "21")]
		public bool ShouldEnterLocomotionAnimationState(GameObject agent)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A31")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "22")]
		public void CancelFeeding(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002A32")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "23")]
		public bool CanInteractWithAvatar()
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A33")]
		[Cpp2IlInjected.Address(RVA = "0x12D9E90", Offset = "0x12D8890", VA = "0x1812D9E90", Slot = "24")]
		public bool CanBeFed()
		{
			return !highAlert;
		}
	}
}
