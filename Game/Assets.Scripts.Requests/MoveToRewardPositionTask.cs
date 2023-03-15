using System;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Characters.Motivations;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[Description("MoveToRewardPosition")]
	[Category("Mdl/Hangout")]
	public class MoveToRewardPositionTask : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		protected float stuckCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		protected float updatePathCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		protected Vector3 lastPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		protected Vector3 destinationPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public BBParameter<bool> ReportFailureAsSuccess;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public BBParameter<float> FailureCloseEnoughDistance;

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		protected float stuckCheckInterval
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0xF00380", Offset = "0xEFED80", VA = "0x180F00380")]
			get
			{
				FollowConfig config;
				do
				{
					config = Config;
				}
				while ((object)config == null);
				return config.stuckCheckInterval;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		protected float updatePathInterval
		{
			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0xF003B0", Offset = "0xEFEDB0", VA = "0x180F003B0")]
			get
			{
				FollowConfig config;
				do
				{
					config = Config;
				}
				while ((object)config == null);
				return config.updatePathInterval;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		protected float keepDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0xF00320", Offset = "0xEFED20", VA = "0x180F00320")]
			get
			{
				FollowConfig config;
				do
				{
					config = Config;
				}
				while ((object)config == null);
				return config.keepDistance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		protected float slowDownDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0xF00350", Offset = "0xEFED50", VA = "0x180F00350")]
			get
			{
				FollowConfig config;
				do
				{
					config = Config;
				}
				while ((object)config == null);
				return config.slowDownDistance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		protected FollowConfig Config
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0xF00280", Offset = "0xEFEC80", VA = "0x180F00280")]
			get
			{
				if ((object)base.CharacterComponent.moveToMotivation == null)
				{
					int num = 0;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xEFF4E0", Offset = "0xEFDEE0", VA = "0x180EFF4E0", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0045
			//IL_0016: Expected O, but got I4
			((object)this)._002Ector();
			Character characterComponent = base.CharacterComponent;
			int num = 0;
			if (characterComponent != (UnityEngine.Object)num)
			{
				Character characterComponent2 = base.CharacterComponent;
				Character characterComponent3 = base.CharacterComponent;
				UpdateDestination(characterComponent3);
			}
			else
			{
				Debug.LogWarning("Failed to start moving to reward position due to missing character or reward position");
				int success = 0;
				EndAction((byte)success != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xEFFDB0", Offset = "0xEFE7B0", VA = "0x180EFFDB0")]
		private void UpdateDestination(Character character)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xEFF600", Offset = "0xEFE000", VA = "0x180EFF600", Slot = "14")]
		protected unsafe override void OnUpdate()
		{
			//Discarded unreachable code: IL_01fa
			//IL_001e: Expected O, but got I4
			//IL_0099: Expected native int or pointer, but got O
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			float num5 = default(float);
			Character characterComponent2;
			float num6 = default(float);
			do
			{
				((object)this)._002Ector();
				int num = 0;
				float deltaTime = Time.deltaTime;
				Character characterComponent = base.CharacterComponent;
				int num2 = 0;
				if (!(characterComponent != (UnityEngine.Object)num2))
				{
					Debug.LogError("Ending move to because no character");
					int success = 0;
					EndAction((byte)success != 0);
				}
				bool hasPath = base.CharacterComponent.NavMeshAgentComponent.hasPath;
				int num3 = 0;
				if (hasPath && !base.CharacterComponent.NavMeshAgentComponent.isStopped)
				{
					FollowConfig config = Config;
					if ((object)config != null)
					{
					}
					if ((object)config == null)
					{
						Transform transform = base.agent.transform;
						float z = vector.z;
						((Vector3*)(IntPtr)lastPos)->z = z;
					}
					float num4 = (stuckCheck = stuckCheck);
					if ((object)Config != null)
					{
					}
					Transform transform2 = base.agent.transform;
					float z2 = lastPos.z;
					float z3 = vector2.z;
					base.CharacterComponent.NavMeshAgentComponent.ResetPath();
					bool success2 = ShouldReportFailureAsSuccess();
					EndAction(success2);
					Debug.LogError("Failed to get to position; stuck!");
				}
				if ((object)Config != null)
				{
				}
				Transform transform3 = base.agent.transform;
				float z4 = vector3.z;
				if (base.CharacterComponent.NavMeshAgentComponent.hasPath)
				{
					if ((object)Config != null)
					{
					}
					if ((object)Config != null)
					{
					}
					base.CharacterComponent.NavMeshAgentComponent.ResetPath();
					EndAction(success: true);
				}
				if ((object)Config != null)
				{
				}
				FollowConfig config2 = Config;
				if ((object)config2 != null)
				{
					num5 = config2.slowDownDistance;
				}
				characterComponent2 = base.CharacterComponent;
			}
			while (num5 >= num6);
			NavMeshAgent _003CNavMeshAgentComponent_003Ek__BackingField = characterComponent2.NavMeshAgentComponent;
			NavMeshAgent _003CNavMeshAgentComponent_003Ek__BackingField2 = base.CharacterComponent.NavMeshAgentComponent;
			float num7 = (_003CNavMeshAgentComponent_003Ek__BackingField2.speed = base.CharacterComponent.walkSpeed);
			float num8 = (updatePathCheck = updatePathCheck);
			FollowConfig config3 = Config;
			float num9 = default(float);
			if ((object)config3 != null)
			{
				num9 = config3.stuckCheckInterval;
			}
			updatePathCheck = num9;
			Character characterComponent3 = base.CharacterComponent;
			UpdateDestination(characterComponent3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xEFFC30", Offset = "0xEFE630", VA = "0x180EFFC30")]
		private bool ShouldReportFailureAsSuccess()
		{
			//IL_003a: Expected F4, but got O
			//IL_0047: Expected F4, but got O
			if (((BBParameter<T>)(object)ReportFailureAsSuccess).value != null)
			{
				float z = destinationPos.z;
				Transform transform = base.agent.transform;
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				float num = (float)((BBParameter<T>)(object)FailureCloseEnoughDistance).value;
				float num2 = (float)((BBParameter<T>)(object)FailureCloseEnoughDistance).value;
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xF001B0", Offset = "0xEFEBB0", VA = "0x180F001B0")]
		public unsafe MoveToRewardPositionTask()
		{
			//IL_0012: Expected native int or pointer, but got O
			//IL_0029: Expected native int or pointer, but got O
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)lastPos)->z = z;
			float z2 = Vector3.zero.z;
			((Vector3*)(IntPtr)destinationPos)->z = z2;
			BBParameter<> reportFailureAsSuccess = default(BBParameter<>);
			ReportFailureAsSuccess = (BBParameter<bool>)(object)reportFailureAsSuccess;
			BBParameter<> failureCloseEnoughDistance = default(BBParameter<>);
			FailureCloseEnoughDistance = (BBParameter<float>)(object)failureCloseEnoughDistance;
			base._002Ector();
		}
	}
}
