using Cpp2IlInjected;
using Mdl.Characters;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[Category("Mdl")]
	[Description("CharacterSetAnimationTrigger")]
	public class CharacterSetAnimationTrigger : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public BBParameter<string> parameter;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x12E8B20", Offset = "0x12E7520", VA = "0x1812E8B20", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_006b
			//IL_0023: Expected O, but got I4
			if (!string.IsNullOrEmpty((string)((BBParameter<T>)(object)parameter).value))
			{
				Character characterComponent = base.CharacterComponent;
				int num = 0;
				if (characterComponent != (Object)num)
				{
					Character characterComponent2 = base.CharacterComponent;
					BBParameter<string> bBParameter = parameter;
					Animator _003CAnimatorComponent_003Ek__BackingField = characterComponent2.AnimatorComponent;
					string value = (string)((BBParameter<T>)(object)bBParameter).value;
					_003CAnimatorComponent_003Ek__BackingField.SetTrigger(value);
					EndAction(success: true);
					return;
				}
			}
			Debug.LogError("Either no parameter specified, or no character");
			int success = 0;
			EndAction((byte)success != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public CharacterSetAnimationTrigger()
		{
		}
	}
}
