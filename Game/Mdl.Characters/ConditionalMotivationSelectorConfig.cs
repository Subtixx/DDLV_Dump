using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008B4")]
	[CreateAssetMenu]
	internal class ConditionalMotivationSelectorConfig : MotivationConfig
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20008B5")]
		public class MotivationParameters
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40030E1")]
			[NonReorderable]
			public List<MotivationConditionConfig> conditions = (List<MotivationConditionConfig>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40030E2")]
			public MotivationConfig config;

			[Cpp2IlInjected.Token(Token = "0x600283F")]
			[Cpp2IlInjected.Address(RVA = "0x1783B70", Offset = "0x1782570", VA = "0x181783B70")]
			public MotivationParameters()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030DF")]
		public List<MotivationParameters> motivations = (List<MotivationParameters>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030E0")]
		public MotivationConfig fallback;

		[Cpp2IlInjected.Token(Token = "0x600283D")]
		[Cpp2IlInjected.Address(RVA = "0xA8EDD0", Offset = "0xA8D7D0", VA = "0x180A8EDD0", Slot = "4")]
		public override IMotivation Instantiate()
		{
			ConditionalMotivationSelector conditionalMotivationSelector = new ConditionalMotivationSelector(this);
			List<MotivationParameters> list = motivations;
			Func<MotivationParameters, ConditionalMotivationSelector.MotivationParameters> _003C_003E9__6_ = ConditionalMotivationSelector._003C_003Ec._003C_003E9__6_0;
			if (_003C_003E9__6_ == null)
			{
				ConditionalMotivationSelector._003C_003Ec._003C_003E9 = (ConditionalMotivationSelector._003C_003Ec)(object)(Func<T, TResult>)delegate(MotivationParameters x)
				{
					//Discarded unreachable code: IL_0049
					ConditionalMotivationSelector.MotivationParameters motivationParameters = new ConditionalMotivationSelector.MotivationParameters
					{
						config = x
					};
					List<MotivationConditionConfig> conditions = x.conditions;
					Func<MotivationConditionConfig, IMotivationCondition> _003C_003E9__6_2 = ConditionalMotivationSelector._003C_003Ec._003C_003E9__6_1;
					if (_003C_003E9__6_2 == null)
					{
						ConditionalMotivationSelector._003C_003Ec._003C_003E9 = (ConditionalMotivationSelector._003C_003Ec)(object)(Func<T, TResult>)((MotivationConditionConfig y) => y.Instantiate());
					}
					List<IMotivationCondition> list3 = (motivationParameters.conditions = (List<IMotivationCondition>)(object)Enumerable.ToList<IMotivationCondition>(Enumerable.Select<MotivationConditionConfig, IMotivationCondition>((IEnumerable<>)conditions, (Func<, >)(object)_003C_003E9__6_2)));
					return motivationParameters;
				};
			}
			List<ConditionalMotivationSelector.MotivationParameters> list2 = (conditionalMotivationSelector.motivationParameters = (List<ConditionalMotivationSelector.MotivationParameters>)(object)Enumerable.ToList<ConditionalMotivationSelector.MotivationParameters>(Enumerable.Select<MotivationParameters, ConditionalMotivationSelector.MotivationParameters>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__6_)));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600283E")]
		[Cpp2IlInjected.Address(RVA = "0xA8EF90", Offset = "0xA8D990", VA = "0x180A8EF90")]
		public ConditionalMotivationSelectorConfig()
		{
		}
	}
}
