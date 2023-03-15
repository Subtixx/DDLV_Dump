using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.StateMachineBehaviors
{
	[Cpp2IlInjected.Token(Token = "0x200022E")]
	public class DestroyObject : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200022F")]
		public enum OnState
		{
			[Cpp2IlInjected.Token(Token = "0x4001311")]
			Enter,
			[Cpp2IlInjected.Token(Token = "0x4001312")]
			Exit
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400130D")]
		public bool destroyParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400130E")]
		public OnState onState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400130F")]
		public float delay;

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x1625FE0", Offset = "0x16249E0", VA = "0x181625FE0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			//Discarded unreachable code: IL_0030
			if (onState == OnState.Enter)
			{
				int num = 0;
				if ((destroyParent ? 1 : 0) != num)
				{
					Transform parent = animator.transform.parent;
				}
				GameObject gameObject = animator.gameObject;
				Destroy(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x1626050", Offset = "0x1624A50", VA = "0x181626050", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			//Discarded unreachable code: IL_0030
			if (onState == OnState.Exit)
			{
				int num = 0;
				if ((destroyParent ? 1 : 0) != num)
				{
					Transform parent = animator.transform.parent;
				}
				GameObject gameObject = animator.gameObject;
				Destroy(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x1625EE0", Offset = "0x16248E0", VA = "0x181625EE0")]
		private void Destroy(GameObject obj)
		{
			//Discarded unreachable code: IL_0010, IL_001f
			if (!Addressables.ReleaseInstance(obj))
			{
				Object.Destroy(obj);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public DestroyObject()
		{
		}
	}
}
