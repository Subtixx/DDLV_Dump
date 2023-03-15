using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Characters.MotivationConditions
{
	[Cpp2IlInjected.Token(Token = "0x2000903")]
	[CreateAssetMenu]
	internal class ConditionItemConditionConfig : MotivationConditionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003244")]
		[ItemID]
		[SerializeField]
		private int _conditionItemID;

		[Cpp2IlInjected.Token(Token = "0x170005F6")]
		public Item ConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002971")]
			[Cpp2IlInjected.Address(RVA = "0xA8E280", Offset = "0xA8CC80", VA = "0x180A8E280")]
			get
			{
				long num = Convert.ToInt64((uint)_conditionItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002972")]
		[Cpp2IlInjected.Address(RVA = "0xA8E200", Offset = "0xA8CC00", VA = "0x180A8E200", Slot = "4")]
		public override IMotivationCondition Instantiate()
		{
			ConditionItemCondition conditionItemCondition = new ConditionItemCondition(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002973")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public ConditionItemConditionConfig()
		{
		}
	}
}
