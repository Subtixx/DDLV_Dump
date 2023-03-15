using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008B0")]
	internal class ConditionalMotivationSelector : Motivation<ConditionalMotivationSelectorConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x20008B1")]
		private class MotivationParameters
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40030D7")]
			public List<IMotivationCondition> conditions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40030D8")]
			public ConditionalMotivationSelectorConfig.MotivationParameters config;

			[Cpp2IlInjected.Token(Token = "0x6002836")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public MotivationParameters()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030D4")]
		private MotivationParameters currentMotivationParameter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030D5")]
		private readonly List<MotivationParameters> motivationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40030D6")]
		private IMotivation motivationInstance;

		[Cpp2IlInjected.Token(Token = "0x170005E1")]
		public override IMotivation SubMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x600282E")]
			[Cpp2IlInjected.Address(RVA = "0xA8F8B0", Offset = "0xA8E2B0", VA = "0x180A8F8B0", Slot = "12")]
			get
			{
				if (motivationInstance != null)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600282F")]
		[Cpp2IlInjected.Address(RVA = "0xA8F720", Offset = "0xA8E120", VA = "0x180A8F720")]
		public ConditionalMotivationSelector(ConditionalMotivationSelectorConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
			List<ConditionalMotivationSelectorConfig.MotivationParameters> motivations = config.motivations;
			Func<ConditionalMotivationSelectorConfig.MotivationParameters, MotivationParameters> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
			if (_003C_003E9__6_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ConditionalMotivationSelectorConfig.MotivationParameters x)
				{
					//Discarded unreachable code: IL_0049
					MotivationParameters motivationParameters = new MotivationParameters
					{
						config = x
					};
					List<MotivationConditionConfig> conditions = x.conditions;
					Func<MotivationConditionConfig, IMotivationCondition> _003C_003E9__6_2 = _003C_003Ec._003C_003E9__6_1;
					if (_003C_003E9__6_2 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MotivationConditionConfig y) => y.Instantiate());
					}
					List<IMotivationCondition> list2 = (motivationParameters.conditions = (List<IMotivationCondition>)(object)Enumerable.ToList<IMotivationCondition>(Enumerable.Select<MotivationConditionConfig, IMotivationCondition>((IEnumerable<>)conditions, (Func<, >)(object)_003C_003E9__6_2)));
					return motivationParameters;
				};
			}
			List<MotivationParameters> list = (motivationParameters = (List<MotivationParameters>)(object)Enumerable.ToList<MotivationParameters>(Enumerable.Select<ConditionalMotivationSelectorConfig.MotivationParameters, MotivationParameters>((IEnumerable<>)motivations, (Func<, >)(object)_003C_003E9__6_)));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002830")]
		[Cpp2IlInjected.Address(RVA = "0xA8F5F0", Offset = "0xA8DFF0", VA = "0x180A8F5F0", Slot = "13")]
		public override string GetInfo(GameObject agent)
		{
			//Discarded unreachable code: IL_004a
			//IL_0049: Expected O, but got I4
			if ((long)motivationInstance == 0)
			{
				return ((Motivation<C>)(object)this).GetInfo(agent);
			}
			string info = ((Motivation<C>)(object)this).GetInfo(agent);
			int num = 0;
			string newLine = Environment.NewLine;
			IMotivation motivation = motivationInstance;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			return info + newLine + (string)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002831")]
		[Cpp2IlInjected.Address(RVA = "0xA8F010", Offset = "0xA8DA10", VA = "0x180A8F010", Slot = "14")]
		public override bool CanBeInterrupted(GameObject interruptee, GameObject interruptor)
		{
			//IL_000f: Expected I4, but got O
			if (motivationInstance != null)
			{
				return (byte)(int)typeof(IMotivation).TypeHandle != 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002832")]
		[Cpp2IlInjected.Address(RVA = "0xA8F090", Offset = "0xA8DA90", VA = "0x180A8F090", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			if (motivationInstance == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002833")]
		[Cpp2IlInjected.Address(RVA = "0xA8F510", Offset = "0xA8DF10", VA = "0x180A8F510", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//IL_0012: Expected O, but got I4
			//IL_0019: Expected O, but got I4
			if (motivationInstance != null)
			{
			}
			int num = 0;
			motivationInstance = (IMotivation)num;
			currentMotivationParameter = (MotivationParameters)num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002834")]
		[Cpp2IlInjected.Address(RVA = "0xA8F590", Offset = "0xA8DF90", VA = "0x180A8F590", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			if (motivationInstance == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002835")]
		[Cpp2IlInjected.Address(RVA = "0xA8F100", Offset = "0xA8DB00", VA = "0x180A8F100", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//Discarded unreachable code: IL_009d
			//IL_005a: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			int num;
			bool flag = default(bool);
			Func<IMotivationCondition, bool> func = default(Func<IMotivationCondition, bool>);
			bool flag2 = default(bool);
			do
			{
				num = 0;
				int num2 = 0;
				List<MotivationParameters> list = motivationParameters;
				if (!flag)
				{
					continue;
				}
				if (func == null)
				{
					func = (Func<IMotivationCondition, bool>)(object)(Func<T, TResult>)delegate(IMotivationCondition x)
					{
						//Discarded unreachable code: IL_002d
						ConditionalMotivationSelector conditionalMotivationSelector = this;
						GameObject agent2 = agent;
						IMotivation currentMotivation = conditionalMotivationSelector.motivationInstance;
						int num8 = 0;
						uint num9 = default(uint);
						if (num8 < (int)num9)
						{
							num8 += num8;
							num8++;
						}
						return x.IsTrue(agent2, currentMotivation);
					};
				}
				while (!flag2)
				{
				}
			}
			while (num != 0);
			int num3 = 0;
			int num4 = 0;
			bool flag3 = (UnityEngine.Object)num != (UnityEngine.Object)num4;
			int num5 = default(int);
			if (flag3)
			{
				if (num3 != 0)
				{
				}
				if (!flag3)
				{
					num5 = 0;
					int num6 = 0;
					if (!((UnityEngine.Object)num != (UnityEngine.Object)num6))
					{
						goto IL_0084;
					}
				}
				int num7 = default(int);
				motivationInstance = (IMotivation)num7;
				goto IL_0084;
			}
			goto IL_0089;
			IL_0089:
			if (num5 == 0 || (object)agent != null)
			{
			}
			throw new NullReferenceException();
			IL_0084:
			if (num5 == 0)
			{
			}
			goto IL_0089;
		}
	}
}
