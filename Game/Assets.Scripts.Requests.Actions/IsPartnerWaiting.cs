using System;
using Cpp2IlInjected;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[Icon("Dialogue", false, "")]
	[Category("Mdl/Request")]
	public class IsPartnerWaiting : MdlConditionTask
	{
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x11BE090", Offset = "0x11BCA90", VA = "0x1811BE090", Slot = "15")]
		protected override bool OnCheck()
		{
			//IL_0015: Expected O, but got I4
			GameObject _003CConversationPartner_003Ek__BackingField = base.CharacterComponent.ConversationPartner;
			int num = 0;
			if (_003CConversationPartner_003Ek__BackingField != (UnityEngine.Object)num)
			{
				GameObject _003CConversationPartner_003Ek__BackingField2 = base.CharacterComponent.ConversationPartner;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public IsPartnerWaiting()
		{
		}
	}
}
