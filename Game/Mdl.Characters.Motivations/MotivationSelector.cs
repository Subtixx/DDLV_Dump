using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008E6")]
	public class MotivationSelector : Motivation<MotivationSelectorConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x20008E7")]
		private class MotivationCooldown
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003196")]
			public MotivationSelectorConfig.MotivationParameters motivation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003197")]
			public float remainingTime;

			[Cpp2IlInjected.Token(Token = "0x6002903")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public MotivationCooldown()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003192")]
		private MotivationSelectorConfig.MotivationParameters motivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003193")]
		private IMotivation motivationInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003194")]
		private List<MotivationCooldown> motivationCooldown = (List<MotivationCooldown>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003195")]
		private MotivationSelectorConfig.MotivationParameters fallbackMotivationParameters;

		[Cpp2IlInjected.Token(Token = "0x170005F3")]
		public override IMotivation SubMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x60028F6")]
			[Cpp2IlInjected.Address(RVA = "0xEFD7C0", Offset = "0xEFC1C0", VA = "0x180EFD7C0", Slot = "12")]
			get
			{
				if (motivationInstance != null)
				{
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028F7")]
		[Cpp2IlInjected.Address(RVA = "0xEFD720", Offset = "0xEFC120", VA = "0x180EFD720")]
		public MotivationSelector(MotivationSelectorConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x60028F8")]
		[Cpp2IlInjected.Address(RVA = "0xEFCC40", Offset = "0xEFB640", VA = "0x180EFCC40", Slot = "13")]
		public override string GetInfo(GameObject agent)
		{
			//Discarded unreachable code: IL_0132, IL_0138, IL_013e, IL_0144
			bool flag = default(bool);
			string text = default(string);
			bool flag2 = default(bool);
			string[] array;
			string text5 = default(string);
			string newLine3;
			while (true)
			{
				int num = 0;
				List<MotivationCooldown> list = motivationCooldown;
				if (flag)
				{
					int num2 = 0;
					string newLine = Environment.NewLine;
					string text2 = $"{text} : {text}{newLine}";
					string text3 = "" + text2;
				}
				if (!flag)
				{
				}
				string text4 = "Fallback Inactive";
				if (flag2)
				{
					text4 = "Fallback Active";
				}
				array = new string[7];
				int num3 = 0;
				string newLine2 = Environment.NewLine;
				if (newLine2 != null && newLine2 == null)
				{
					continue;
				}
				array[0] = newLine2;
				if ("Cooldowns : " != null && "Cooldowns : " == null)
				{
					continue;
				}
				array[1] = "Cooldowns : ";
				if (text5 != null && "Cooldowns : " == null)
				{
					continue;
				}
				array[2] = text5;
				if (" -" != null && " -" == null)
				{
					continue;
				}
				array[3] = " -";
				if (text4 != null && " -" == null)
				{
					continue;
				}
				array[4] = text4;
				if ("-" == null || "-" != null)
				{
					array[5] = "-";
					int num4 = 0;
					newLine3 = Environment.NewLine;
					if (newLine3 == null || newLine3 != null)
					{
						break;
					}
				}
			}
			array[6] = newLine3;
			return string.Concat(array);
		}

		[Cpp2IlInjected.Token(Token = "0x60028F9")]
		[Cpp2IlInjected.Address(RVA = "0xEFC620", Offset = "0xEFB020", VA = "0x180EFC620", Slot = "14")]
		public override bool CanBeInterrupted(GameObject interruptee, GameObject interruptor)
		{
			IMotivation motivation;
			do
			{
				motivation = motivationInstance;
			}
			while (motivation == null);
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			IMotivation subMotivation = motivation.SubMotivation;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028FA")]
		[Cpp2IlInjected.Address(RVA = "0xEFD1B0", Offset = "0xEFBBB0", VA = "0x180EFD1B0")]
		private MotivationSelectorConfig.MotivationParameters PickMotivation()
		{
			//Discarded unreachable code: IL_007f, IL_0085, IL_008b, IL_0091
			//IL_001e: Expected O, but got I4
			int num = 0;
			List<MotivationSelectorConfig.MotivationParameters> list = (List<MotivationSelectorConfig.MotivationParameters>)(object)new List<T>();
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				MotivationSelectorConfig.MotivationParameters motivation = (MotivationSelectorConfig.MotivationParameters)0;
				List<MotivationCooldown> list2 = motivationCooldown;
				Func<MotivationCooldown, bool> func = (Func<MotivationCooldown, bool>)(object)(Func<T, TResult>)delegate(MotivationCooldown c)
				{
					//Discarded unreachable code: IL_0011
					MotivationSelectorConfig.MotivationParameters motivationParameters = motivation;
					return c.motivation == motivationParameters;
				};
				if (Enumerable.FirstOrDefault<MotivationCooldown>((IEnumerable<>)list2, (Func<, >)(object)func) != null)
				{
				}
				MotivationSelectorConfig.MotivationParameters item = motivation;
				((List<T>)(object)list).Add((T)item);
			}
			num++;
			if (num != 0)
			{
			}
			int num3 = UnityEngine.Random.Range(0, num);
			bool flag2 = default(bool);
			int num4 = default(int);
			if (flag2)
			{
				num4++;
			}
			if (num4 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028FB")]
		[Cpp2IlInjected.Address(RVA = "0xEFC430", Offset = "0xEFAE30", VA = "0x180EFC430")]
		private void BeginNextMotivation(GameObject agent)
		{
			//Discarded unreachable code: IL_00ac
			//IL_0029: Expected O, but got I4
			MotivationSelectorConfig.MotivationParameters motivationParameters = (this.motivation = PickMotivation());
			if ((long)this.motivation == 0)
			{
				MotivationConfig motivationConfig = motivationParameters.config;
				int num = 0;
				if (!(motivationConfig != (UnityEngine.Object)num))
				{
					((List<T>)(object)motivationCooldown).Clear();
					MotivationSelectorConfig.MotivationParameters motivationParameters2 = (this.motivation = PickMotivation());
				}
				MotivationSelectorConfig.MotivationParameters motivationParameters4 = default(MotivationSelectorConfig.MotivationParameters);
				if (fallbackMotivationParameters == null)
				{
					MotivationSelectorConfig.MotivationParameters motivationParameters3 = new MotivationSelectorConfig.MotivationParameters();
					MotivationConfig motivationConfig2 = (motivationParameters3.config = motivationParameters3.config);
					fallbackMotivationParameters = motivationParameters3;
					motivationParameters4 = fallbackMotivationParameters;
				}
				this.motivation = motivationParameters4;
			}
			MotivationSelectorConfig.MotivationParameters motivationParameters5 = this.motivation;
			if (motivationParameters5 != null)
			{
				IMotivation motivation = (motivationInstance = motivationParameters5.config.Instantiate());
			}
			if (motivationInstance == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028FC")]
		[Cpp2IlInjected.Address(RVA = "0xEFCBA0", Offset = "0xEFB5A0", VA = "0x180EFCBA0")]
		private MotivationSelectorConfig.MotivationParameters GetFallbackMotivation()
		{
			//Discarded unreachable code: IL_0028
			MotivationSelectorConfig.MotivationParameters motivationParameters = fallbackMotivationParameters;
			if (motivationParameters == null)
			{
				MotivationSelectorConfig.MotivationParameters motivationParameters2 = new MotivationSelectorConfig.MotivationParameters();
				MotivationConfig motivationConfig = (motivationParameters2.config = motivationParameters2.config);
				fallbackMotivationParameters = motivationParameters2;
			}
			return motivationParameters;
		}

		[Cpp2IlInjected.Token(Token = "0x60028FD")]
		[Cpp2IlInjected.Address(RVA = "0xEFC3D0", Offset = "0xEFADD0", VA = "0x180EFC3D0")]
		private void BeginMotivation(GameObject agent)
		{
			if (motivationInstance == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028FE")]
		[Cpp2IlInjected.Address(RVA = "0xEFC700", Offset = "0xEFB100", VA = "0x180EFC700", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			if (motivationInstance == null || motivationInstance != null)
			{
				BeginNextMotivation(agent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028FF")]
		[Cpp2IlInjected.Address(RVA = "0xEFCAC0", Offset = "0xEFB4C0", VA = "0x180EFCAC0", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//IL_0012: Expected O, but got I4
			//IL_0019: Expected O, but got I4
			if (motivationInstance != null)
			{
			}
			int num = 0;
			motivationInstance = (IMotivation)num;
			motivation = (MotivationSelectorConfig.MotivationParameters)num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002900")]
		[Cpp2IlInjected.Address(RVA = "0xEFCB40", Offset = "0xEFB540", VA = "0x180EFCB40", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			if (motivationInstance == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002901")]
		[Cpp2IlInjected.Address(RVA = "0xEFD580", Offset = "0xEFBF80", VA = "0x180EFD580")]
		private void StartCooldown(MotivationSelectorConfig.MotivationParameters motivation)
		{
			if ((long)motivation != 0)
			{
				List<MotivationCooldown> list = this.motivationCooldown;
				Func<MotivationCooldown, bool> func = (Func<MotivationCooldown, bool>)(object)(Func<T, TResult>)delegate(MotivationCooldown c)
				{
					//Discarded unreachable code: IL_0011
					MotivationSelectorConfig.MotivationParameters motivationParameters2 = motivation;
					return c.motivation == motivationParameters2;
				};
				if (Enumerable.FirstOrDefault<MotivationCooldown>((IEnumerable<>)list, (Func<, >)(object)func) != null)
				{
					_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0;
					motivation = (MotivationSelectorConfig.MotivationParameters)(object)CS_0024_003C_003E8__locals0;
					throw new NullReferenceException();
				}
				List<MotivationCooldown> list2 = this.motivationCooldown;
				MotivationCooldown motivationCooldown = new MotivationCooldown();
				MotivationSelectorConfig.MotivationParameters motivationParameters = motivation;
				float num = (motivationCooldown.remainingTime = motivation.cooldown);
				((List<T>)(object)list2).Add((T)motivationCooldown);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002902")]
		[Cpp2IlInjected.Address(RVA = "0xEFC7A0", Offset = "0xEFB1A0", VA = "0x180EFC7A0", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//Discarded unreachable code: IL_007c
			//IL_0022: Expected O, but got I4
			List<MotivationCooldown> list = this.motivationCooldown;
			bool flag = default(bool);
			if (flag)
			{
			}
			if (flag)
			{
				return true;
			}
			if (1 == 0)
			{
				MotivationSelectorConfig.MotivationParameters motivation = (MotivationSelectorConfig.MotivationParameters)0;
				if ((long)motivation != 0)
				{
					Func<MotivationCooldown, bool> func = (Func<MotivationCooldown, bool>)(object)(Func<T, TResult>)delegate(MotivationCooldown c)
					{
						//Discarded unreachable code: IL_0011
						MotivationSelectorConfig.MotivationParameters motivationParameters3 = motivation;
						return c.motivation == motivationParameters3;
					};
					MotivationCooldown motivationCooldown = default(MotivationCooldown);
					if (motivationCooldown == null)
					{
						MotivationCooldown motivationCooldown2 = new MotivationCooldown();
						MotivationSelectorConfig.MotivationParameters motivationParameters = (motivationCooldown2.motivation = motivation);
						float num = (motivationCooldown2.remainingTime = motivation.cooldown);
					}
					MotivationSelectorConfig.MotivationParameters motivationParameters2 = motivation;
				}
			}
			throw new NullReferenceException();
		}
	}
}
