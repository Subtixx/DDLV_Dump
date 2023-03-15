using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			Trigger,
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			Replace,
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			Activate,
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			Enable,
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			Animate,
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			Deactivate
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Mode action = Mode.Activate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public GameObject source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int triggerCount = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool repeatTrigger;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2F04B90", Offset = "0x2F03590", VA = "0x182F04B90")]
		private void DoActivateTrigger()
		{
			//Discarded unreachable code: IL_00c3, IL_00c8, IL_00cd, IL_00d6, IL_00db
			//IL_002d: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_00b6: Expected O, but got I4
			//IL_00c2: Expected I4, but got I8
			if (!repeatTrigger)
			{
				return;
			}
			Object @object = target;
			if ((object)@object == null)
			{
				GameObject gameObject = base.gameObject;
			}
			if ((object)@object == null)
			{
			}
			int num = 0;
			int num2 = 0;
			if (@object != (Object)num2)
			{
				int num3 = 0;
			}
			if (action > Mode.Deactivate)
			{
				return;
			}
			int num4 = 0;
			GameObject gameObject2 = default(GameObject);
			if (!(gameObject2 != (Object)num4))
			{
				return;
			}
			gameObject2.BroadcastMessage("DoActivateTrigger");
			GameObject gameObject3 = source;
			int num5 = 0;
			if (!(gameObject3 != (Object)num5))
			{
				return;
			}
			int num6 = 0;
			if (gameObject2 != (Object)num6)
			{
				GameObject gameObject4 = source;
				Transform transform = gameObject2.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform2 = gameObject2.transform;
				Object.DestroyObject(gameObject2);
				int num7 = 0;
				if (gameObject2 != (Object)num7)
				{
					ulong num8 = default(ulong);
					gameObject2.SetActive((byte)num8 != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2F04FB0", Offset = "0x2F039B0", VA = "0x182F04FB0")]
		private void OnTriggerEnter(Collider other)
		{
			DoActivateTrigger();
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2F04FC0", Offset = "0x2F039C0", VA = "0x182F04FC0")]
		public ActivateTrigger()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_0012: Expected I4, but got I8

	}
}
