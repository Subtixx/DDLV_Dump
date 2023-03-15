using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Cpp2IlInjected;
using UnityEngine;

namespace DG.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public static class DOTweenCYInstruction
	{
		[Cpp2IlInjected.Token(Token = "0x200015A")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			private readonly Tween t;

			[Cpp2IlInjected.Token(Token = "0x170001BF")]
			public override bool keepWaiting
			{
				[Cpp2IlInjected.Token(Token = "0x60008C2")]
				[Cpp2IlInjected.Address(RVA = "0xA28210", Offset = "0xA26C10", VA = "0x180A28210", Slot = "7")]
				get
				{
					//Discarded unreachable code: IL_001c
					Tween tween = t;
					if (!tween.active)
					{
						int num = 0;
					}
					return !tween.IsComplete();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
			public WaitForCompletion(Tween tween)
			{
				((ComponentEditor)(object)this)._002Ector();
				t = tween;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			private readonly Tween t;

			[Cpp2IlInjected.Token(Token = "0x170001C0")]
			public override bool keepWaiting
			{
				[Cpp2IlInjected.Token(Token = "0x60008C4")]
				[Cpp2IlInjected.Address(RVA = "0xA283B0", Offset = "0xA26DB0", VA = "0x180A283B0", Slot = "7")]
				get
				{
					Tween tween = t;
					if (!tween.active)
					{
						int num = 0;
					}
					if (!tween.playedOnce)
					{
						return true;
					}
					int num2 = tween.CompletedLoops();
					num2++;
					int num3 = 0;
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008C5")]
			[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
			public WaitForRewind(Tween tween)
			{
				((System.Xml.Serialization.ListMap)(object)this)._002Ector();
				t = tween;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015C")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			private readonly Tween t;

			[Cpp2IlInjected.Token(Token = "0x170001C1")]
			public override bool keepWaiting
			{
				[Cpp2IlInjected.Token(Token = "0x60008C6")]
				[Cpp2IlInjected.Address(RVA = "0xA282E0", Offset = "0xA26CE0", VA = "0x180A282E0", Slot = "7")]
				get
				{
					//Discarded unreachable code: IL_000c
					return t.active;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008C7")]
			[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
			public WaitForKill(Tween tween)
			{
				((ComponentEditor)(object)this)._002Ector();
				t = tween;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015D")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			private readonly Tween t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			private readonly int elapsedLoops;

			[Cpp2IlInjected.Token(Token = "0x170001C2")]
			public override bool keepWaiting
			{
				[Cpp2IlInjected.Token(Token = "0x60008C8")]
				[Cpp2IlInjected.Address(RVA = "0xA282A0", Offset = "0xA26CA0", VA = "0x180A282A0", Slot = "7")]
				get
				{
					//Discarded unreachable code: IL_0021
					Tween tween = t;
					if (!tween.active)
					{
						int num = 0;
					}
					return tween.CompletedLoops() < elapsedLoops;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0xA28250", Offset = "0xA26C50", VA = "0x180A28250")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
				((ComponentEditor)(object)this)._002Ector();
				t = tween;
				this.elapsedLoops = elapsedLoops;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015E")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			private readonly Tween t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			private readonly float position;

			[Cpp2IlInjected.Token(Token = "0x170001C3")]
			public override bool keepWaiting
			{
				[Cpp2IlInjected.Token(Token = "0x60008CA")]
				[Cpp2IlInjected.Address(RVA = "0xA28350", Offset = "0xA26D50", VA = "0x180A28350", Slot = "7")]
				get
				{
					Tween tween = t;
					if (!tween.active)
					{
						int num = 0;
					}
					int num2 = tween.CompletedLoops();
					float num3 = position;
					num2++;
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0xA28300", Offset = "0xA26D00", VA = "0x180A28300")]
			public WaitForPosition(Tween tween, float position)
			{
				((TimeZoneInfo._003C_003Ec)(object)this)._002Ector();
				t = tween;
				this.position = position;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200015F")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			private readonly Tween t;

			[Cpp2IlInjected.Token(Token = "0x170001C4")]
			public override bool keepWaiting
			{
				[Cpp2IlInjected.Token(Token = "0x60008CC")]
				[Cpp2IlInjected.Address(RVA = "0xA28420", Offset = "0xA26E20", VA = "0x180A28420", Slot = "7")]
				get
				{
					//Discarded unreachable code: IL_001c
					Tween tween = t;
					if (!tween.active)
					{
						int num = 0;
					}
					return !tween.playedOnce;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008CD")]
			[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
			public WaitForStart(Tween tween)
			{
				((ComponentEditor)(object)this)._002Ector();
				t = tween;
				/*Error: Unexpected end of block*/;
			}
		}
	}
}
