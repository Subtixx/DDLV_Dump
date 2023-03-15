using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Navigation;
using Mdl.Systems;
using Meta.Missions;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000235")]
	[RequireComponent(typeof(Trail))]
	public class ChaseTrailTarget : MonoBehaviour, IPlayerInteraction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001324")]
		public AK.Wwise.Event sfx_evilSquirrelPickup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001325")]
		private Trail trailComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001326")]
		private Transform[] patrolLocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001327")]
		private int patrolIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001328")]
		private int loopingIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001329")]
		private bool isOver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400132A")]
		[SerializeField]
		private InteractPreviewData InteractPreviewData;

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xA7B830", Offset = "0xA7A230", VA = "0x180A7B830")]
		public unsafe void StartChase(MissionObjective obj)
		{
			//Discarded unreachable code: IL_0161, IL_016d, IL_017b
			//IL_0108: Expected I4, but got I8
			Transform[] array = (patrolLocations = new Transform[((RepeatedField<T>)(object)obj.Data.Chase.patrolPath_).Count]);
			int num = 0;
			int num2 = 0;
			int count = ((RepeatedField<T>)(object)obj.Data.Chase.patrolPath_).Count;
			if (num2 < count)
			{
				LocationCustom location_ = ((CustomStepChase.Types.LocationCustomContainer)((RepeatedField<T>)(object)obj.Data.Chase.patrolPath_)[num]).location_;
				bool flag = default(bool);
				if (flag)
				{
					Transform[] array2 = patrolLocations;
					ulong num3 = default(ulong);
					if (num3 == 0 || flag)
					{
						num += 4;
						((ulong*)num3)->m_value = num3;
						num++;
						goto IL_008e;
					}
				}
				throw new NullReferenceException();
			}
			goto IL_008e;
			IL_008e:
			Transform[] array3 = patrolLocations;
			int patrolLoopingIndex_ = obj.Data.Chase.patrolLoopingIndex_;
			patrolLoopingIndex_ = Math.Min(array3.Length, patrolLoopingIndex_);
			int num4 = (loopingIndex = Math.Max(0, patrolLoopingIndex_));
			Trail trail = (trailComponent = GetComponent<Trail>());
			Trail trail2 = trailComponent;
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			trail2.Init(avatar);
			Transform[] array4 = patrolLocations;
			patrolIndex = 0;
			Trail trail3 = trailComponent;
			Transform transform2 = (trail3.Target = array4[0]);
			NavMeshAgent component = GetComponent<NavMeshAgent>();
			Transform target = trailComponent._target;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Trail trail4 = trailComponent;
			EventHandler value = OnReachDestination;
			trail4.ReachedDestination += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0xA7BD50", Offset = "0xA7A750", VA = "0x180A7BD50")]
		private void StopChase()
		{
			//Discarded unreachable code: IL_0043
			//IL_0010: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			Trail trail = trailComponent;
			int num = 0;
			if (trail != (UnityEngine.Object)num)
			{
				Trail trail2 = trailComponent;
				EventHandler value = OnReachDestination;
				trail2.ReachedDestination -= value;
				Trail trail3 = trailComponent;
				int num2 = 0;
				trail3.Target = (Transform)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
		public bool IsChaseCompleted(MissionObjective obj)
		{
			return isOver;
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0xA7B660", Offset = "0xA7A060", VA = "0x180A7B660", Slot = "4")]
		bool IPlayerInteraction.CanInteract()
		{
			return !isOver;
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0xA7B670", Offset = "0xA7A070", VA = "0x180A7B670", Slot = "5")]
		bool IPlayerInteraction.Interact()
		{
			//Discarded unreachable code: IL_0054
			//IL_0020: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			if (!isOver)
			{
				isOver = true;
				Trail trail = trailComponent;
				int num = 0;
				if (trail != (UnityEngine.Object)num)
				{
					Trail trail2 = trailComponent;
					EventHandler value = OnReachDestination;
					trail2.ReachedDestination -= value;
					Trail trail3 = trailComponent;
					int num2 = 0;
					trail3.Target = (Transform)num2;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "6")]
		InteractPreviewData IPlayerInteraction.GetInteractPreviewData()
		{
			return InteractPreviewData;
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0xA7B760", Offset = "0xA7A160", VA = "0x180A7B760")]
		private void NextTrailPatrol(bool reset = false)
		{
			//Discarded unreachable code: IL_003f
			Transform[] array = patrolLocations;
			if (!reset)
			{
				int num = patrolIndex;
				num = (patrolIndex = num + 1);
			}
			int num2 = (patrolIndex = 0);
			Trail trail = trailComponent;
			Transform transform2 = (trail.Target = array[num2]);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7D0", Offset = "0xA7A1D0", VA = "0x180A7B7D0")]
		private void OnReachDestination(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0040
			int num = patrolIndex;
			Transform[] array = patrolLocations;
			num = (patrolIndex = num + 1);
			int num2 = (patrolIndex = loopingIndex);
			Trail trail = trailComponent;
			Transform transform2 = (trail.Target = array[num2]);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ChaseTrailTarget()
		{
		}
	}
}
