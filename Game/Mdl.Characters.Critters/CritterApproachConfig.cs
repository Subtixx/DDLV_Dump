using System;
using Cpp2IlInjected;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Characters.Critters
{
	[Cpp2IlInjected.Token(Token = "0x2000923")]
	internal abstract class CritterApproachConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032E4")]
		public float minDistanceToTrigger = 10f;

		[Cpp2IlInjected.Token(Token = "0x60029EF")]
		[Cpp2IlInjected.Address(RVA = "0x10FF8B0", Offset = "0x10FE2B0", VA = "0x1810FF8B0")]
		internal bool ShouldTrigger(GameObject agent)
		{
			//IL_0019: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			PlayerTask currentTask = SystemRoot.Instance.GetSystem<PlayerNavigation>().CurrentTask;
			int num = 0;
			if (currentTask != (UnityEngine.Object)num)
			{
				Critter taskData = currentTask.GetTaskData<Critter>();
				int num2 = 0;
				if (taskData == (UnityEngine.Object)num2)
				{
					int num3 = 0;
				}
			}
			Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform = agent.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			float num4 = minDistanceToTrigger;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60029F0")]
		[Cpp2IlInjected.Address(RVA = "0x10FFB60", Offset = "0x10FE560", VA = "0x1810FFB60")]
		protected CritterApproachConfig()
		{
		}
	}
}
