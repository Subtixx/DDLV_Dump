using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ObjectEnabler : StateMachineBehaviour
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct Tags
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string TagToEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public bool Enable;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<Tags> ObjectToggle;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xF03500", Offset = "0xF01F00", VA = "0x180F03500", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		//Discarded unreachable code: IL_0049, IL_004f
		//IL_0026: Expected O, but got I4
		int num = 0;
		int num2 = 0;
		if (layerIndex != 0)
		{
			float layerWeight = animator.GetLayerWeight(layerIndex);
			if ((object)animator == null)
			{
				return;
			}
		}
		NPCAnimationObjectSpawner component = animator.GetComponent<NPCAnimationObjectSpawner>();
		int num3 = 0;
		if (!(component != (UnityEngine.Object)num3))
		{
			return;
		}
		List<NPCAnimationObjectSpawner.TagObjectPairs> tagObjectPairsList = component.TagObjectPairsList;
		bool flag = default(bool);
		if (!flag)
		{
			return;
		}
		List<Tags> objectToggle = ObjectToggle;
		bool flag2 = default(bool);
		if (flag2)
		{
			while (!flag2)
			{
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xF037B0", Offset = "0xF021B0", VA = "0x180F037B0", Slot = "10")]
	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
	{
		//Discarded unreachable code: IL_0066, IL_006c
		//IL_0012: Expected O, but got I4
		bool flag = default(bool);
		NPCAnimationObjectSpawner.TagObjectPairs item = default(NPCAnimationObjectSpawner.TagObjectPairs);
		while (true)
		{
			int num = 0;
			NPCAnimationObjectSpawner component = animator.GetComponent<NPCAnimationObjectSpawner>();
			int num2 = 0;
			if (component != (UnityEngine.Object)num2)
			{
				List<NPCAnimationObjectSpawner.TagObjectPairs> tagObjectPairsList = component.TagObjectPairsList;
				if (flag)
				{
					List<Tags> objectToggle = ObjectToggle;
					Func<Tags, bool> cpp2il__autoParamName__idx_ = (Func<Tags, bool>)(object)(Func<T, TResult>)delegate
					{
						NPCAnimationObjectSpawner.TagObjectPairs tagObjectPairs = item;
						/*Error: Unexpected end of block*/;
					};
					if (((IEnumerable<>)objectToggle).Any<Tags>((Func<, >)(object)cpp2il__autoParamName__idx_))
					{
						GameObject referenceObject = item.ReferenceObject;
						int active = 0;
						referenceObject.SetActive((byte)active != 0);
						break;
					}
					continue;
				}
				break;
			}
			break;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
	public ObjectEnabler()
	{
	}
}
