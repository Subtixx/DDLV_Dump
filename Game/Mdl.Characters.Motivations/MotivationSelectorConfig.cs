using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008EA")]
	[CreateAssetMenu]
	public class MotivationSelectorConfig : MotivationConfig
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20008EB")]
		public class MotivationParameters
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400319C")]
			public int weight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400319D")]
			public float cooldown;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400319E")]
			public MotivationConfig config;

			[Cpp2IlInjected.Token(Token = "0x600290A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public MotivationParameters()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400319A")]
		[Tooltip("Motivation to use when none is valid (null means no fallback, cooldowns will be flushed instead)")]
		public MotivationConfig fallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400319B")]
		[Tooltip("Motivations with weights and cooldowns. Note that the same motivation will not be picked twice in a row.")]
		public List<MotivationParameters> motivations = (List<MotivationParameters>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6002908")]
		[Cpp2IlInjected.Address(RVA = "0xEFC280", Offset = "0xEFAC80", VA = "0x180EFC280", Slot = "4")]
		public override IMotivation Instantiate()
		{
			MotivationSelector motivationSelector = default(MotivationSelector);
			List<MotivationSelector.MotivationCooldown> list = (motivationSelector.motivationCooldown = (List<MotivationSelector.MotivationCooldown>)(object)new List<T>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002909")]
		[Cpp2IlInjected.Address(RVA = "0xEFC350", Offset = "0xEFAD50", VA = "0x180EFC350")]
		public MotivationSelectorConfig()
		{
		}
	}
}
