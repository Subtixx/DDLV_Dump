using Cpp2IlInjected;
using Mdl.Utils;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[Category("Mdl/Hangout")]
	[Description("ToggleCharacterMovement")]
	public class ToggleCharacterMovement : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public BBParameter<bool> isStopped = (BBParameter<bool>)(object)BBParameter<T>.op_Implicit((T)0);

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x13D4580", Offset = "0x13D2F80", VA = "0x1813D4580", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0054
			//IL_0015: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			NavMeshAreaHelper component = base.CharacterComponent.GetComponent<NavMeshAreaHelper>();
			int num = 0;
			if (component != (Object)num && ((BBParameter<T>)(object)isStopped).value != null)
			{
				component.StopNavMeshAgent();
			}
			int num2 = 0;
			if (component != (Object)num2 && ((BBParameter<T>)(object)isStopped).value == null)
			{
				component.ResumeNavMeshAgent();
			}
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x13D46C0", Offset = "0x13D30C0", VA = "0x1813D46C0")]
		public ToggleCharacterMovement()
		{
		}//IL_0006: Expected O, but got I4

	}
}
