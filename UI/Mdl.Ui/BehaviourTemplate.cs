using System;
using Cpp2IlInjected;
using glPlayFab.Disney;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000890")]
	public class BehaviourTemplate : ComponentTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40032A7")]
		public bool Enabled;

		[Cpp2IlInjected.Token(Token = "0x600360D")]
		[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA612A0", VA = "0x180A628A0")]
		public void Load(Behaviour behaviour)
		{
			//Discarded unreachable code: IL_000f
			bool flag = (behaviour.enabled = Enabled);
		}

		[Cpp2IlInjected.Token(Token = "0x600360E")]
		[Cpp2IlInjected.Address(RVA = "0xA628D0", Offset = "0xA612D0", VA = "0x180A628D0")]
		public void Save(Behaviour behaviour)
		{
			//Discarded unreachable code: IL_000f
			bool flag = (Enabled = behaviour.enabled);
		}

		[Cpp2IlInjected.Token(Token = "0x600360F")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public BehaviourTemplate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
