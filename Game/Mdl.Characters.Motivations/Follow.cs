using System;
using System.Diagnostics;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008CC")]
	public class Follow : Motivation<FollowConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400313E")]
		private Character character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400313F")]
		private float stuckCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003140")]
		private float updatePathCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003141")]
		private Vector3 lastPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003142")]
		private Vector3 lastTargetPos;

		[Cpp2IlInjected.Token(Token = "0x60028A7")]
		[Cpp2IlInjected.Address(RVA = "0x14630C0", Offset = "0x1461AC0", VA = "0x1814630C0")]
		public Follow(FollowConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x60028A8")]
		[Cpp2IlInjected.Address(RVA = "0x1462A80", Offset = "0x1461480", VA = "0x181462A80", Slot = "19")]
		protected virtual GameObject GetCharacterToFollow(Character fromCharacter)
		{
			//Discarded unreachable code: IL_0007
			return fromCharacter.characterToFollow;
		}

		[Cpp2IlInjected.Token(Token = "0x60028A9")]
		[Cpp2IlInjected.Address(RVA = "0x14623A0", Offset = "0x1460DA0", VA = "0x1814623A0", Slot = "15")]
		protected unsafe override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_007f
			//IL_001e: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0072: Expected native int or pointer, but got O
			//IL_007e: Expected F4, but got I4
			Character character = (this.character = agent.GetComponent<Character>());
			Character character2 = this.character;
			int num = 0;
			bool flag = character2 != (UnityEngine.Object)num;
			if (flag)
			{
				Character fromCharacter = this.character;
				GameObject characterToFollow = GetCharacterToFollow(fromCharacter);
				int num2 = 0;
				if (characterToFollow != (UnityEngine.Object)num2)
				{
					UpdateDestination();
					Character fromCharacter2 = this.character;
					Transform transform = GetCharacterToFollow(fromCharacter2).transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					((Vector3*)(IntPtr)lastTargetPos)->z = z;
				}
			}
			stuckCheck = (flag ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60028AA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60028AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60028AC")]
		[Cpp2IlInjected.Address(RVA = "0x1462500", Offset = "0x1460F00", VA = "0x181462500", Slot = "18")]
		protected unsafe override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0012: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			//IL_0094: Expected native int or pointer, but got O
			//IL_00e0: Expected F4, but got I4
			//IL_01a5: Expected F4, but got O
			//IL_01d3: Expected native int or pointer, but got O
			int num = 0;
			Character character = this.character;
			int num2 = 0;
			if (!(character == (UnityEngine.Object)num2))
			{
				Character fromCharacter = this.character;
				GameObject characterToFollow = GetCharacterToFollow(fromCharacter);
				int num3 = 0;
				if (!(characterToFollow == (UnityEngine.Object)num3))
				{
					bool hasPath = this.character.NavMeshAgentComponent.hasPath;
					int num4 = 0;
					if (hasPath)
					{
						bool isStopped = this.character.NavMeshAgentComponent.isStopped;
						if (!isStopped)
						{
							float z = default(float);
							float num5 = default(float);
							if (!isStopped)
							{
								Transform transform = agent.transform;
								Vector3 vector = default(Vector3);
								z = vector.z;
								num5 = stuckCheck;
								((Vector3*)(IntPtr)lastPos)->z = z;
							}
							stuckCheck = num5;
							stuckCheck = z;
							Transform transform2 = agent.transform;
							float z2 = lastPos.z;
							Vector3 vector2 = default(Vector3);
							float z3 = vector2.z;
							this.character.NavMeshAgentComponent.ResetPath();
							return true;
						}
					}
					stuckCheck = 1f;
					Character fromCharacter2 = this.character;
					Transform transform3 = GetCharacterToFollow(fromCharacter2).transform;
					Transform transform4 = agent.transform;
					Vector3 vector3 = default(Vector3);
					float z4 = vector3.z;
					float num6 = default(float);
					if (this.character.NavMeshAgentComponent.hasPath)
					{
						while (num6 >= num6)
						{
						}
					}
					Character character2 = this.character;
					if (!(num6 >= num6))
					{
						NavMeshAgent _003CNavMeshAgentComponent_003Ek__BackingField = character2.NavMeshAgentComponent;
					}
					NavMeshAgent _003CNavMeshAgentComponent_003Ek__BackingField2 = character2.NavMeshAgentComponent;
					float num7 = (_003CNavMeshAgentComponent_003Ek__BackingField2.speed = character2.walkSpeed);
					float num8 = updatePathCheck;
					Character fromCharacter3 = this.character;
					updatePathCheck = num8;
					Transform transform5 = GetCharacterToFollow(fromCharacter3).transform;
					float z5 = lastTargetPos.z;
					num8 = num6;
					Vector3 vector4 = default(Vector3);
					float z6 = vector4.z;
					float num9 = default(float);
					while (num9 <= 1f)
					{
					}
					updatePathCheck = (float)vector4;
					UpdateDestination();
					Character fromCharacter4 = this.character;
					Transform transform6 = GetCharacterToFollow(fromCharacter4).transform;
					Vector3 vector5 = default(Vector3);
					float z7 = vector5.z;
					((Vector3*)(IntPtr)lastTargetPos)->z = z7;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028AD")]
		[Cpp2IlInjected.Address(RVA = "0x1462D70", Offset = "0x1461770", VA = "0x181462D70")]
		private void UpdateDestination()
		{
			//Discarded unreachable code: IL_006c
			Character character = this.character;
			NavMeshAgent _003CNavMeshAgentComponent_003Ek__BackingField = character.NavMeshAgentComponent;
			GameObject characterToFollow = GetCharacterToFollow(character);
			Transform transform = characterToFollow.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform2 = characterToFollow.transform;
			int agentTypeID = _003CNavMeshAgentComponent_003Ek__BackingField.agentTypeID;
			int walkableMask = _003CNavMeshAgentComponent_003Ek__BackingField.walkableMask;
			bool flag = default(bool);
			if (flag)
			{
				NavMeshPath navMeshPath = new NavMeshPath();
				Transform transform3 = _003CNavMeshAgentComponent_003Ek__BackingField.transform;
				bool flag2 = default(bool);
				if (flag2 && navMeshPath.status != NavMeshPathStatus.PathInvalid)
				{
					bool flag3 = _003CNavMeshAgentComponent_003Ek__BackingField.SetPath(navMeshPath);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028AE")]
		[Cpp2IlInjected.Address(RVA = "0x1462190", Offset = "0x1460B90", VA = "0x181462190")]
		[Conditional("DEBUG_FOLLOW_SHOW_PATH")]
		private void DebugPath()
		{
			//Discarded unreachable code: IL_0050
			if (!character.NavMeshAgentComponent.hasPath)
			{
				return;
			}
			Vector3[] corners = character.NavMeshAgentComponent.path.corners;
			if (corners.Length > 1)
			{
				int num = 0;
				int num2 = corners.Length - 1;
				if (num < num2)
				{
					num++;
					Color magenta = Color.magenta;
					num++;
				}
			}
		}
	}
}
