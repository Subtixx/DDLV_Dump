using Cpp2IlInjected;
using Mdl.Audio;
using Mdl.Systems;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[Icon("Dialogue", false, "")]
	[Category("Mdl")]
	public class SkipEndVo : MdlActionTask
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xF54BD0", Offset = "0xF535D0", VA = "0x180F54BD0", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0027
			//IL_001c: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				AudioManager system = _003CInstance_003Ek__BackingField.GetSystem<AudioManager>();
			}
			int num = 0;
			int num2 = 0;
			if ((Object)num != (Object)num2)
			{
			}
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public SkipEndVo()
		{
		}
	}
}
