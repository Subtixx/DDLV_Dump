using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Environments.PointsOfInterest;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008DE")]
	public class InterruptibleMotivation : Motivation<InterruptibleMotivationConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x20008DF")]
		private class ConditionalMotivationInstance
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003180")]
			public InterruptibleMotivationConfig.ConditionalMotivation config;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003181")]
			public List<IMotivationCondition> conditions = (List<IMotivationCondition>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x60028EA")]
			[Cpp2IlInjected.Address(RVA = "0xE5EC20", Offset = "0xE5D620", VA = "0x180E5EC20")]
			public bool AllConditionsAreTrue(GameObject agent, IMotivation currentMotivation)
			{
				//Discarded unreachable code: IL_0046
				int num = 0;
				int num2 = 0;
				List<IMotivationCondition> list = conditions;
				bool flag = default(bool);
				if (flag)
				{
					num2 += num2;
					if ((object)"{il2cpp array field il2cppMethodInfo->}" != (object)typeof(IMotivationCondition).TypeHandle)
					{
						num2++;
						while (flag)
						{
						}
						int num3 = 0;
						num2++;
					}
					num2 += 312;
				}
				if (num2 + 1 != 0)
				{
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60028EB")]
			[Cpp2IlInjected.Address(RVA = "0xE5EE20", Offset = "0xE5D820", VA = "0x180E5EE20")]
			public ConditionalMotivationInstance()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20008E0")]
		private class ConditionalMotivationCooldown
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003182")]
			public ConditionalMotivationInstance motivation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003183")]
			public float remainingTime;

			[Cpp2IlInjected.Token(Token = "0x60028EC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ConditionalMotivationCooldown()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003178")]
		private IMotivation mainMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003179")]
		private IMotivation interrupt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400317A")]
		private GameObject agent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400317B")]
		private float reactionCooldown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400317C")]
		private float checkForConditionalMotivationInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400317D")]
		private ConditionalMotivationInstance conditionalMotivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400317E")]
		private List<ConditionalMotivationInstance> conditionalMotivations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400317F")]
		private List<ConditionalMotivationCooldown> conditionalMotivationCooldowns;

		[Cpp2IlInjected.Token(Token = "0x170005F2")]
		public override IMotivation SubMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x60028DD")]
			[Cpp2IlInjected.Address(RVA = "0x11BB7B0", Offset = "0x11BA1B0", VA = "0x1811BB7B0", Slot = "12")]
			get
			{
				if (interrupt != null || mainMotivation != null)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028DE")]
		[Cpp2IlInjected.Address(RVA = "0x11BB450", Offset = "0x11B9E50", VA = "0x1811BB450")]
		public InterruptibleMotivation(InterruptibleMotivationConfig config)
		{
			//Discarded unreachable code: IL_0050, IL_0056, IL_005c, IL_0062, IL_0068, IL_006e
			//IL_0041: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			conditionalMotivations = (List<ConditionalMotivationInstance>)(object)new List<T>();
			conditionalMotivationCooldowns = (List<ConditionalMotivationCooldown>)(object)new List<T>();
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
			List<InterruptibleMotivationConfig.ConditionalMotivation> conditionalInterrupts = config.conditionalInterrupts;
			bool flag = default(bool);
			if (flag)
			{
				ConditionalMotivationInstance conditionalMotivationInstance = new ConditionalMotivationInstance
				{
					config = (InterruptibleMotivationConfig.ConditionalMotivation)0
				};
				bool flag2 = default(bool);
				if (flag2)
				{
					List<IMotivationCondition> conditions = conditionalMotivationInstance.conditions;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028DF")]
		[Cpp2IlInjected.Address(RVA = "0x11BA3B0", Offset = "0x11B8DB0", VA = "0x1811BA3B0", Slot = "13")]
		public override string GetInfo(GameObject agent)
		{
			string result = default(string);
			string[] array;
			int num = default(int);
			while (true)
			{
				if (SubMotivation == null)
				{
					return ((Motivation<C>)(object)this).GetInfo(agent);
				}
				if ((long)interrupt == 0)
				{
					IMotivation motivation = mainMotivation;
					if (mainMotivation != null)
					{
					}
					num = 0;
					return result;
				}
				array = new string[7];
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = (string)(object)array;
				int num2 = 0;
				string newLine = Environment.NewLine;
				if (newLine != null && newLine == null)
				{
					continue;
				}
				array[1] = newLine;
				if ("Main Motivation : " != null && "Main Motivation : " == null)
				{
					continue;
				}
				array[2] = "Main Motivation : ";
				if (num != 0 && "Main Motivation : " != null && "Main Motivation : " == null)
				{
					continue;
				}
				int num3 = 0;
				string newLine2 = Environment.NewLine;
				if (newLine2 != null && newLine2 == null)
				{
					continue;
				}
				array[4] = newLine2;
				if ("Interrupt Motivation : " == null || "Interrupt Motivation : " != null)
				{
					array[5] = "Interrupt Motivation : ";
					if ("Interrupt Motivation : " == null || "Interrupt Motivation : " != null)
					{
						break;
					}
				}
			}
			array[6] = "Interrupt Motivation : ";
			string text = string.Concat(array);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E0")]
		[Cpp2IlInjected.Address(RVA = "0x11B9960", Offset = "0x11B8360", VA = "0x1811B9960", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//IL_0017: Expected O, but got I4
			//IL_008e: Expected O, but got I8
			//IL_009f: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			bool flag = default(bool);
			int num2;
			StimulusBroadcaster stimulusBroadcaster = default(StimulusBroadcaster);
			do
			{
				this.agent = agent;
				StimulusReceiver componentInChildren = agent.GetComponentInChildren<StimulusReceiver>();
				int num = 0;
				if (componentInChildren != (UnityEngine.Object)num)
				{
					StimulusReceiver.Stimulus value = OnStimulus;
					componentInChildren.OnStimulus -= value;
					StimulusReceiver.Stimulus value2 = OnStimulus;
					componentInChildren.OnStimulus += value2;
				}
				if ((long)interrupt != 0)
				{
					ConditionalMotivationInstance conditionalMotivationInstance = conditionalMotivation;
					if (conditionalMotivationInstance != null)
					{
						IMotivation currentMotivation = mainMotivation;
						flag = conditionalMotivationInstance.AllConditionsAreTrue(agent, currentMotivation);
						if (!flag)
						{
							goto IL_007c;
						}
					}
					IMotivation motivation = interrupt;
					return;
				}
				goto IL_007c;
				IL_007c:
				if (interrupt != null)
				{
					interrupt = (IMotivation)0;
				}
				if (mainMotivation == null)
				{
					mainMotivation = (IMotivation)flag;
					IMotivation motivation2 = mainMotivation;
				}
				num2 = 0;
			}
			while (!(stimulusBroadcaster != (UnityEngine.Object)num2));
			StimulusBroadcaster.ProbabilityFunction probabilityFunction = StimulusProbability;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E1")]
		[Cpp2IlInjected.Address(RVA = "0x11BB430", Offset = "0x11B9E30", VA = "0x1811BB430")]
		private float StimulusProbability(GameObject agent)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E2")]
		[Cpp2IlInjected.Address(RVA = "0x11BA840", Offset = "0x11B9240", VA = "0x1811BA840")]
		private void OnStimulus(GameObject sender, object message, StimulusBroadcaster.ProbabilityFunction probability)
		{
			//Discarded unreachable code: IL_0030
			//IL_0015: Invalid comparison between F4 and I4
			if (message == null)
			{
				return;
			}
			int num = 0;
			GameObject gameObject = agent;
			if (!(probability(gameObject) <= (float)num) && React(sender, message))
			{
				int num2 = 0;
				if (message != null)
				{
					GameObject gameObject2 = agent;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028E3")]
		[Cpp2IlInjected.Address(RVA = "0x11BAC10", Offset = "0x11B9610", VA = "0x1811BAC10")]
		public bool React(GameObject sender, object message)
		{
			//IL_0084: Expected O, but got I4
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			if ((long)interrupt == 0 && message != null)
			{
				int num = 0;
				IMotivation motivation = mainMotivation;
				if (" is interrupted by " != null)
				{
					if (" is interrupted by " != null)
					{
						goto IL_00f2;
					}
					_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
					CS_0024_003C_003E8__locals0.point = (IPointOfInterest)(object)CS_0024_003C_003E8__locals0;
					IMotivation subMotivation = SubMotivation;
					int num2 = 0;
					if (subMotivation != null && SubMotivation != null)
					{
						int num3 = 0;
						Type type = default(Type);
						Type obj = default(Type);
						if (((object)type).Equals((object)obj))
						{
							goto IL_0152;
						}
					}
					Func<VisitPointOfInterestConfig, bool> func = (Func<VisitPointOfInterestConfig, bool>)(object)(Func<T, TResult>)delegate(VisitPointOfInterestConfig c)
					{
						//Discarded unreachable code: IL_001b
						Type pointType = c.action.PointType;
						IPointOfInterest point = CS_0024_003C_003E8__locals0.point;
						Type obj2 = default(Type);
						return ((object)pointType).Equals((object)obj2);
					};
					int num4 = 0;
					VisitPointOfInterestConfig visitPointOfInterestConfig = default(VisitPointOfInterestConfig);
					if (visitPointOfInterestConfig != (UnityEngine.Object)num4)
					{
						GameObject gameObject = agent;
						uint num5 = default(uint);
						if (num2 < (int)num5)
						{
							num2 += num2;
							num2++;
						}
						if (num2 != 0)
						{
							IMotivation motivation2 = (interrupt = visitPointOfInterestConfig.Instantiate());
							IMotivation motivation3 = interrupt;
							motivation2 = (IMotivation)(object)((object)motivation2 + (object)motivation2);
							ulong num6 = default(ulong);
							motivation2 = (IMotivation)(motivation2 + num6);
							int num7 = 0;
							int num8 = 0;
							BeginInterruption();
							string name = agent.transform.name;
							goto IL_00f2;
						}
					}
				}
			}
			goto IL_0152;
			IL_0152:
			int num9 = 0;
			throw new NullReferenceException();
			IL_00f2:
			bool flag = default(bool);
			if (flag)
			{
				GameObject gameObject2 = agent;
				if (sender != gameObject2)
				{
					IMotivation motivation4 = interrupt;
					int num10 = 0;
					int num11 = 0;
					BeginInterruption();
					string name2 = agent.transform.parent.name;
					string name3 = sender.transform.name;
					string text = name2 + " is interrupted by " + name3;
				}
			}
			goto IL_0152;
		}

		[Cpp2IlInjected.Token(Token = "0x60028E4")]
		[Cpp2IlInjected.Address(RVA = "0x11B98F0", Offset = "0x11B82F0", VA = "0x1811B98F0")]
		private void BeginInterruption()
		{
			IMotivation motivation = mainMotivation;
			IMotivation motivation2 = interrupt;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E5")]
		[Cpp2IlInjected.Address(RVA = "0x11BA120", Offset = "0x11B8B20", VA = "0x1811BA120", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//IL_0010: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_0073: Expected O, but got I8
			StimulusReceiver componentInChildren = agent.GetComponentInChildren<StimulusReceiver>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num)
			{
				StimulusReceiver.Stimulus value = OnStimulus;
				componentInChildren.OnStimulus -= value;
			}
			StimulusBroadcaster componentInChildren2 = agent.GetComponentInChildren<StimulusBroadcaster>();
			int num2 = 0;
			if (componentInChildren2 != (UnityEngine.Object)num2)
			{
				StimulusBroadcaster.ProbabilityFunction probability = StimulusProbability;
				int num3 = 0;
				componentInChildren2.Broadcast(agent, num3, probability);
			}
			if (mainMotivation != null)
			{
			}
			if (interrupt != null)
			{
			}
			interrupt = (IMotivation)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028E6")]
		[Cpp2IlInjected.Address(RVA = "0x11BA330", Offset = "0x11B8D30", VA = "0x1811BA330", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			if (mainMotivation != null)
			{
			}
			if (interrupt == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028E7")]
		[Cpp2IlInjected.Address(RVA = "0x11BA960", Offset = "0x11B9360", VA = "0x1811BA960")]
		private void PickConditionalMotivation(GameObject agent)
		{
			//Discarded unreachable code: IL_00a9, IL_00af, IL_00b5, IL_00bb, IL_00c1, IL_00c7
			//IL_001f: Expected O, but got I4
			bool flag = default(bool);
			while (true)
			{
				List<ConditionalMotivationInstance> list = conditionalMotivations;
				int num = 0;
				if (flag)
				{
					ConditionalMotivationInstance motivation = (ConditionalMotivationInstance)0;
					List<ConditionalMotivationCooldown> list2 = conditionalMotivationCooldowns;
					Func<ConditionalMotivationCooldown, bool> func = (Func<ConditionalMotivationCooldown, bool>)(object)(Func<T, TResult>)delegate(ConditionalMotivationCooldown c)
					{
						//Discarded unreachable code: IL_0011
						ConditionalMotivationInstance conditionalMotivationInstance3 = motivation;
						return c.motivation == conditionalMotivationInstance3;
					};
					if (Enumerable.FirstOrDefault<ConditionalMotivationCooldown>((IEnumerable<>)list2, (Func<, >)(object)func) != null)
					{
					}
					int num2 = 0;
					ConditionalMotivationInstance conditionalMotivationInstance = motivation;
					float probability = conditionalMotivationInstance.config.probability;
					IMotivation subMotivation = SubMotivation;
					if (conditionalMotivationInstance.AllConditionsAreTrue(agent, subMotivation))
					{
						ConditionalMotivationInstance conditionalMotivationInstance2 = (conditionalMotivation = motivation);
						IMotivation motivation2 = (interrupt = motivation.config.motivation.Instantiate());
						BeginInterruption();
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028E8")]
		[Cpp2IlInjected.Address(RVA = "0x11BB280", Offset = "0x11B9C80", VA = "0x1811BB280")]
		private void StartCooldown(ConditionalMotivationInstance motivation)
		{
			_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
			CS_0024_003C_003E8__locals0.motivation = motivation;
			if ((long)CS_0024_003C_003E8__locals0.motivation != 0)
			{
				List<ConditionalMotivationCooldown> list = conditionalMotivationCooldowns;
				Func<ConditionalMotivationCooldown, bool> func = (Func<ConditionalMotivationCooldown, bool>)(object)(Func<T, TResult>)delegate(ConditionalMotivationCooldown c)
				{
					//Discarded unreachable code: IL_0011
					ConditionalMotivationInstance motivation4 = CS_0024_003C_003E8__locals0.motivation;
					return c.motivation == motivation4;
				};
				if (Enumerable.FirstOrDefault<ConditionalMotivationCooldown>((IEnumerable<>)list, (Func<, >)(object)func) != null)
				{
					ConditionalMotivationInstance motivation2 = CS_0024_003C_003E8__locals0.motivation;
					motivation.conditions = (List<IMotivationCondition>)(object)CS_0024_003C_003E8__locals0;
					throw new NullReferenceException();
				}
				List<ConditionalMotivationCooldown> list2 = conditionalMotivationCooldowns;
				ConditionalMotivationCooldown conditionalMotivationCooldown = new ConditionalMotivationCooldown();
				ConditionalMotivationInstance motivation3 = CS_0024_003C_003E8__locals0.motivation;
				float num = (conditionalMotivationCooldown.remainingTime = CS_0024_003C_003E8__locals0.motivation.config.cooldown);
				((List<T>)(object)list2).Add((T)conditionalMotivationCooldown);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028E9")]
		[Cpp2IlInjected.Address(RVA = "0x11B9C50", Offset = "0x11B8650", VA = "0x1811B9C50", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//Discarded unreachable code: IL_00dc
			//IL_0065: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			do
			{
				IL_0000:
				float num = (reactionCooldown = reactionCooldown);
				float num2 = (checkForConditionalMotivationInterval = checkForConditionalMotivationInterval);
				List<ConditionalMotivationCooldown> list = conditionalMotivationCooldowns;
				if (flag)
				{
				}
				int num3 = 0;
				if (flag && flag)
				{
					int num4 = 0;
					if (num4 != 0)
					{
						goto IL_0000;
					}
					if (num4 != 0)
					{
						continue;
					}
					int num5 = 0;
				}
				while (flag2)
				{
				}
			}
			while (1L != 0L);
			ConditionalMotivationInstance motivation = (ConditionalMotivationInstance)0;
			if ((long)motivation != 0)
			{
				Func<ConditionalMotivationCooldown, bool> func = (Func<ConditionalMotivationCooldown, bool>)(object)(Func<T, TResult>)delegate(ConditionalMotivationCooldown c)
				{
					//Discarded unreachable code: IL_0011
					ConditionalMotivationInstance conditionalMotivationInstance2 = motivation;
					return c.motivation == conditionalMotivationInstance2;
				};
				ConditionalMotivationCooldown conditionalMotivationCooldown = default(ConditionalMotivationCooldown);
				ConditionalMotivationCooldown conditionalMotivationCooldown2 = default(ConditionalMotivationCooldown);
				if (conditionalMotivationCooldown == null)
				{
					conditionalMotivationCooldown2 = new ConditionalMotivationCooldown();
					ConditionalMotivationInstance conditionalMotivationInstance = (conditionalMotivationCooldown2.motivation = motivation);
					float num6 = (conditionalMotivationCooldown2.remainingTime = motivation.config.cooldown);
				}
				float num7 = (conditionalMotivationCooldown2.remainingTime = motivation.config.cooldown);
			}
			throw new NullReferenceException();
		}
	}
}
