using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.InputSystem;
using Mdl.Utils;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B3D")]
	public class FishingMinigameGameplay
	{
		[Cpp2IlInjected.Token(Token = "0x2000B3E")]
		public enum MinigameState
		{
			[Cpp2IlInjected.Token(Token = "0x4003E8B")]
			Active,
			[Cpp2IlInjected.Token(Token = "0x4003E8C")]
			Inactive,
			[Cpp2IlInjected.Token(Token = "0x4003E8D")]
			Failing,
			[Cpp2IlInjected.Token(Token = "0x4003E8E")]
			Finished
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003E77")]
		private float elapsedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E78")]
		private InputAction inputAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003E7A")]
		private FishingMinigameGameplayConfig[] roundConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003E7B")]
		private int currentRoundIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003E87")]
		private CallOnce enterTriggerCallOnce = new CallOnce();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003E88")]
		private CallOnce exitTriggerCallOnce = new CallOnce();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003E89")]
		private FishingMiniGame.FishingResult pendingFailState;

		[Cpp2IlInjected.Token(Token = "0x17000711")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003E79")]
		public MinigameState State
		{
			[Cpp2IlInjected.Token(Token = "0x60033C9")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60033CA")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000712")]
		public float NormalizedProgress
		{
			[Cpp2IlInjected.Token(Token = "0x60033CB")]
			[Cpp2IlInjected.Address(RVA = "0x1375510", Offset = "0x1373F10", VA = "0x181375510")]
			get
			{
				if (State == MinigameState.Active)
				{
					int num = currentRoundIndex;
					if (num != -1)
					{
						FishingMinigameGameplayConfig fishingMinigameGameplayConfig = roundConfigs[num];
						return elapsedTime;
					}
				}
				int num2 = 0;
				throw new IndexOutOfRangeException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000088")]
		public event EventHandler<FishingMiniGameEventArgs> OnBeginRound
		{
			[Cpp2IlInjected.Token(Token = "0x60033CC")]
			[Cpp2IlInjected.Address(RVA = "0x1375EE0", Offset = "0x13748E0", VA = "0x181375EE0")]
			[CompilerGenerated]
			add
			{
				EventHandler<FishingMiniGameEventArgs> onBeginRound = this.OnBeginRound;
				Delegate @delegate = Delegate.Combine(onBeginRound, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBeginRound)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033CD")]
			[Cpp2IlInjected.Address(RVA = "0x13765C0", Offset = "0x1374FC0", VA = "0x1813765C0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<FishingMiniGameEventArgs> onBeginRound = this.OnBeginRound;
				Delegate @delegate = Delegate.Remove(onBeginRound, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBeginRound)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000089")]
		public event EventHandler<FishingMiniGameEventArgs> OnEndRound
		{
			[Cpp2IlInjected.Token(Token = "0x60033CE")]
			[Cpp2IlInjected.Address(RVA = "0x1376020", Offset = "0x1374A20", VA = "0x181376020")]
			[CompilerGenerated]
			add
			{
				EventHandler<FishingMiniGameEventArgs> onEndRound = this.OnEndRound;
				Delegate @delegate = Delegate.Combine(onEndRound, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEndRound)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033CF")]
			[Cpp2IlInjected.Address(RVA = "0x1376700", Offset = "0x1375100", VA = "0x181376700")]
			[CompilerGenerated]
			remove
			{
				EventHandler<FishingMiniGameEventArgs> onEndRound = this.OnEndRound;
				Delegate @delegate = Delegate.Remove(onEndRound, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEndRound)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008A")]
		public event EventHandler<FishingMiniGameEventArgs> OnEnterTriggerZone
		{
			[Cpp2IlInjected.Token(Token = "0x60033D0")]
			[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
			[CompilerGenerated]
			add
			{
				EventHandler<FishingMiniGameEventArgs> onEnterTriggerZone = this.OnEnterTriggerZone;
				Delegate @delegate = Delegate.Combine(onEnterTriggerZone, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEnterTriggerZone)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033D1")]
			[Cpp2IlInjected.Address(RVA = "0x13767A0", Offset = "0x13751A0", VA = "0x1813767A0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<FishingMiniGameEventArgs> onEnterTriggerZone = this.OnEnterTriggerZone;
				Delegate @delegate = Delegate.Remove(onEnterTriggerZone, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEnterTriggerZone)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008B")]
		public event EventHandler<FishingMiniGameEventArgs> OnExitTriggerZone
		{
			[Cpp2IlInjected.Token(Token = "0x60033D2")]
			[Cpp2IlInjected.Address(RVA = "0x1376160", Offset = "0x1374B60", VA = "0x181376160")]
			[CompilerGenerated]
			add
			{
				EventHandler<FishingMiniGameEventArgs> onExitTriggerZone = this.OnExitTriggerZone;
				Delegate @delegate = Delegate.Combine(onExitTriggerZone, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onExitTriggerZone)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033D3")]
			[Cpp2IlInjected.Address(RVA = "0x1376840", Offset = "0x1375240", VA = "0x181376840")]
			[CompilerGenerated]
			remove
			{
				EventHandler<FishingMiniGameEventArgs> onExitTriggerZone = this.OnExitTriggerZone;
				Delegate @delegate = Delegate.Remove(onExitTriggerZone, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onExitTriggerZone)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008C")]
		public event EventHandler<FishingMiniGameEventArgs> OnInputSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x60033D4")]
			[Cpp2IlInjected.Address(RVA = "0x1376480", Offset = "0x1374E80", VA = "0x181376480")]
			[CompilerGenerated]
			add
			{
				EventHandler<FishingMiniGameEventArgs> onInputSuccess = this.OnInputSuccess;
				Delegate @delegate = Delegate.Combine(onInputSuccess, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInputSuccess)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033D5")]
			[Cpp2IlInjected.Address(RVA = "0x1376B60", Offset = "0x1375560", VA = "0x181376B60")]
			[CompilerGenerated]
			remove
			{
				EventHandler<FishingMiniGameEventArgs> onInputSuccess = this.OnInputSuccess;
				Delegate @delegate = Delegate.Remove(onInputSuccess, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInputSuccess)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008D")]
		public event EventHandler<FishingMiniGameEventArgs> OnInputFail
		{
			[Cpp2IlInjected.Token(Token = "0x60033D6")]
			[Cpp2IlInjected.Address(RVA = "0x13763E0", Offset = "0x1374DE0", VA = "0x1813763E0")]
			[CompilerGenerated]
			add
			{
				EventHandler<FishingMiniGameEventArgs> onInputFail = this.OnInputFail;
				Delegate @delegate = Delegate.Combine(onInputFail, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInputFail)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033D7")]
			[Cpp2IlInjected.Address(RVA = "0x1376AC0", Offset = "0x13754C0", VA = "0x181376AC0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<FishingMiniGameEventArgs> onInputFail = this.OnInputFail;
				Delegate @delegate = Delegate.Remove(onInputFail, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onInputFail)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008E")]
		public event Action<FishingMiniGame.FishingResult> OnMinigameCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60033D8")]
			[Cpp2IlInjected.Address(RVA = "0x1376520", Offset = "0x1374F20", VA = "0x181376520")]
			[CompilerGenerated]
			add
			{
				Action<FishingMiniGame.FishingResult> onMinigameCompleted = this.OnMinigameCompleted;
				Delegate @delegate = Delegate.Combine(onMinigameCompleted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMinigameCompleted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033D9")]
			[Cpp2IlInjected.Address(RVA = "0x1376C00", Offset = "0x1375600", VA = "0x181376C00")]
			[CompilerGenerated]
			remove
			{
				Action<FishingMiniGame.FishingResult> onMinigameCompleted = this.OnMinigameCompleted;
				Delegate @delegate = Delegate.Remove(onMinigameCompleted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMinigameCompleted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008F")]
		public event EventHandler<FishingMiniGameEventArgs> OnFinishedSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x60033DA")]
			[Cpp2IlInjected.Address(RVA = "0x1376340", Offset = "0x1374D40", VA = "0x181376340")]
			[CompilerGenerated]
			add
			{
				EventHandler<FishingMiniGameEventArgs> onFinishedSuccess = this.OnFinishedSuccess;
				Delegate @delegate = Delegate.Combine(onFinishedSuccess, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFinishedSuccess)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033DB")]
			[Cpp2IlInjected.Address(RVA = "0x1376A20", Offset = "0x1375420", VA = "0x181376A20")]
			[CompilerGenerated]
			remove
			{
				EventHandler<FishingMiniGameEventArgs> onFinishedSuccess = this.OnFinishedSuccess;
				Delegate @delegate = Delegate.Remove(onFinishedSuccess, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFinishedSuccess)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000090")]
		public event EventHandler<FishingMiniGameEventArgs> OnFinishedRopeBroke
		{
			[Cpp2IlInjected.Token(Token = "0x60033DC")]
			[Cpp2IlInjected.Address(RVA = "0x13762A0", Offset = "0x1374CA0", VA = "0x1813762A0")]
			[CompilerGenerated]
			add
			{
				EventHandler<FishingMiniGameEventArgs> onFinishedRopeBroke = this.OnFinishedRopeBroke;
				Delegate @delegate = Delegate.Combine(onFinishedRopeBroke, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFinishedRopeBroke)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033DD")]
			[Cpp2IlInjected.Address(RVA = "0x1376980", Offset = "0x1375380", VA = "0x181376980")]
			[CompilerGenerated]
			remove
			{
				EventHandler<FishingMiniGameEventArgs> onFinishedRopeBroke = this.OnFinishedRopeBroke;
				Delegate @delegate = Delegate.Remove(onFinishedRopeBroke, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFinishedRopeBroke)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000091")]
		public event EventHandler<FishingMiniGameEventArgs> OnFinishedFishEscaped
		{
			[Cpp2IlInjected.Token(Token = "0x60033DE")]
			[Cpp2IlInjected.Address(RVA = "0x1376200", Offset = "0x1374C00", VA = "0x181376200")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033DF")]
			[Cpp2IlInjected.Address(RVA = "0x13768E0", Offset = "0x13752E0", VA = "0x1813768E0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000092")]
		public event EventHandler<FishingMiniGameEventArgs> OnCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x60033E0")]
			[Cpp2IlInjected.Address(RVA = "0x1375F80", Offset = "0x1374980", VA = "0x181375F80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60033E1")]
			[Cpp2IlInjected.Address(RVA = "0x1376660", Offset = "0x1375060", VA = "0x181376660")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033E2")]
		[Cpp2IlInjected.Address(RVA = "0x1375E40", Offset = "0x1374840", VA = "0x181375E40")]
		public FishingMinigameGameplay()
		{
		}//IL_0010: Expected I4, but got I8


		[Cpp2IlInjected.Token(Token = "0x60033E3")]
		[Cpp2IlInjected.Address(RVA = "0x1374D70", Offset = "0x1373770", VA = "0x181374D70")]
		public void Begin(InputAction inputAction, FishingMinigameGameplayConfig[] configs)
		{
			this.inputAction = inputAction;
			roundConfigs = configs;
			TransitionToBeginRound();
		}

		[Cpp2IlInjected.Token(Token = "0x60033E4")]
		[Cpp2IlInjected.Address(RVA = "0x1375AC0", Offset = "0x13744C0", VA = "0x181375AC0")]
		public void Update(float deltaTime)
		{
			//IL_0046: Expected I4, but got I8
			//IL_0086: Expected I4, but got I8
			//IL_009c: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_013d: Expected O, but got I4
			//IL_013d: Expected F4, but got I4
			int num2 = default(int);
			do
			{
				MinigameState minigameState = State;
				if (minigameState == MinigameState.Finished)
				{
					return;
				}
				FishingMinigameGameplayConfig[] array = roundConfigs;
				elapsedTime = deltaTime;
				int num = currentRoundIndex;
				FishingMinigameGameplayConfig fishingMinigameGameplayConfig = array[num];
				switch (minigameState)
				{
				case MinigameState.Failing:
					if (!(deltaTime <= fishingMinigameGameplayConfig.FailTime))
					{
						FishingMiniGame.FishingResult result = pendingFailState;
						State = MinigameState.Finished;
						FireOnMinigameFinished(result);
					}
					return;
				case MinigameState.Inactive:
					num2 = 0;
					TransitionToBeginRound();
					break;
				}
				while (num2 != 0)
				{
				}
				if ((inputAction.IsTriggered ? 1 : 0) != num2)
				{
					TransitionToEndRound();
					FireFailResultEvent(FishingMiniGame.FishingResult.Canceled);
					State = MinigameState.Finished;
					Action<FishingMiniGame.FishingResult> onMinigameCompleted = this.OnMinigameCompleted;
					while (onMinigameCompleted == null)
					{
					}
					onMinigameCompleted((T)3);
				}
				CallOnce callOnce = enterTriggerCallOnce;
				Action a = delegate
				{
					//Discarded unreachable code: IL_0046
					//IL_003a: Expected O, but got I4
					//IL_003a: Expected F4, but got I4
					if (State == MinigameState.Active)
					{
						int num12 = currentRoundIndex;
						if (num12 != -1)
						{
							FishingMinigameGameplayConfig fishingMinigameGameplayConfig3 = roundConfigs[num12];
						}
					}
					int num13 = 0;
					EventHandler<FishingMiniGameEventArgs> onEnterTriggerZone = this.OnEnterTriggerZone;
					if (onEnterTriggerZone != null)
					{
						int num14 = 0;
						FishingMiniGameEventArgs e4 = this.CreateArgs((float)num13, (Nullable<>)num14);
						onEnterTriggerZone(this, (TEventArgs)e4);
					}
				};
				callOnce.InvokeOnce(a);
			}
			while (!inputAction.IsTriggered);
			float normalizedProgress = NormalizedProgress;
			EventHandler<FishingMiniGameEventArgs> onInputSuccess = this.OnInputSuccess;
			int num3 = 0;
			if (onInputSuccess != null)
			{
				FishingMiniGameEventArgs e = this.CreateArgs(deltaTime, (Nullable<>)num3);
				onInputSuccess(this, (TEventArgs)e);
			}
			TransitionToEndRound();
			FishingMinigameGameplayConfig[] array2 = roundConfigs;
			int num4 = currentRoundIndex;
			num4++;
			while (num4 != array2.Length)
			{
			}
			EventHandler<FishingMiniGameEventArgs> onFinishedSuccess = this.OnFinishedSuccess;
			while (onFinishedSuccess == null)
			{
			}
			int num5 = 0;
			int num6 = 0;
			FishingMiniGameEventArgs e2 = this.CreateArgs((float)num6, (Nullable<>)num3);
			onFinishedSuccess(this, (TEventArgs)e2);
			CallOnce callOnce2 = exitTriggerCallOnce;
			Action a2 = delegate
			{
				//Discarded unreachable code: IL_0046
				//IL_003a: Expected O, but got I4
				//IL_003a: Expected F4, but got I4
				if (State == MinigameState.Active)
				{
					int num9 = currentRoundIndex;
					if (num9 != -1)
					{
						FishingMinigameGameplayConfig fishingMinigameGameplayConfig2 = roundConfigs[num9];
					}
				}
				int num10 = 0;
				EventHandler<FishingMiniGameEventArgs> onExitTriggerZone = this.OnExitTriggerZone;
				if (onExitTriggerZone != null)
				{
					int num11 = 0;
					FishingMiniGameEventArgs e3 = this.CreateArgs((float)num10, (Nullable<>)num11);
					onExitTriggerZone(this, (TEventArgs)e3);
				}
			};
			int num7 = 0;
			callOnce2.InvokeOnce(a2);
			int num8 = 0;
			bool flag = num7 <= 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033E5")]
		[Cpp2IlInjected.Address(RVA = "0x1375710", Offset = "0x1374110", VA = "0x181375710")]
		private void TransitionToEndRound()
		{
			//Discarded unreachable code: IL_0050
			//IL_0022: Expected I4, but got I8
			//IL_0044: Expected O, but got I4
			//IL_0044: Expected F4, but got I4
			if (State == MinigameState.Active && currentRoundIndex != -1)
			{
				FishingMinigameGameplayConfig[] array = roundConfigs;
			}
			State = MinigameState.Inactive;
			elapsedTime = 0f;
			EventHandler<FishingMiniGameEventArgs> onEndRound = this.OnEndRound;
			if (onEndRound != null)
			{
				int num = 0;
				int num2 = 0;
				FishingMiniGameEventArgs e = this.CreateArgs((float)num2, (Nullable<>)num);
				onEndRound(this, (TEventArgs)e);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033E6")]
		[Cpp2IlInjected.Address(RVA = "0x13755B0", Offset = "0x1373FB0", VA = "0x1813755B0")]
		private void TransitionToBeginRound()
		{
			//Discarded unreachable code: IL_00ba
			//IL_004c: Expected I4, but got I8
			//IL_0065: Expected O, but got I4
			//IL_0065: Expected F4, but got I4
			//IL_007a: Expected I4, but got I8
			//IL_0093: Expected O, but got I4
			//IL_009d: Expected I4, but got I8
			//IL_00b9: Expected O, but got I4
			int length = roundConfigs.Length;
			if (length != 0)
			{
				int num = currentRoundIndex;
				num++;
				if (num != length)
				{
					enterTriggerCallOnce.Reset();
					exitTriggerCallOnce.Reset();
					elapsedTime = 0f;
					State = MinigameState.Active;
					EventHandler<FishingMiniGameEventArgs> onBeginRound = this.OnBeginRound;
					if (onBeginRound != null)
					{
						int num2 = 0;
						int num3 = 0;
						FishingMiniGameEventArgs e = this.CreateArgs((float)num3, (Nullable<>)num2);
						onBeginRound(this, (TEventArgs)e);
					}
				}
				else
				{
					State = MinigameState.Finished;
					Action<FishingMiniGame.FishingResult> onMinigameCompleted = this.OnMinigameCompleted;
					while (onMinigameCompleted == null)
					{
					}
					int num4 = 0;
					onMinigameCompleted((T)num4);
				}
			}
			else
			{
				State = MinigameState.Finished;
				FireOnCancelled();
				Action<FishingMiniGame.FishingResult> onMinigameCompleted2 = this.OnMinigameCompleted;
				while (onMinigameCompleted2 == null)
				{
				}
				onMinigameCompleted2((T)3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033E7")]
		[Cpp2IlInjected.Address(RVA = "0x13757D0", Offset = "0x13741D0", VA = "0x1813757D0")]
		private void TransitionToFail(FishingMiniGame.FishingResult result)
		{
			//Discarded unreachable code: IL_006c
			//IL_003f: Expected I4, but got I8
			//IL_005f: Expected O, but got I4
			//IL_005f: Expected F4, but got I4
			if (State == MinigameState.Active)
			{
				int num = currentRoundIndex;
				if (num != -1)
				{
					FishingMinigameGameplayConfig fishingMinigameGameplayConfig = roundConfigs[num];
				}
			}
			int num2 = 0;
			TransitionToEndRound();
			elapsedTime = 0f;
			State = MinigameState.Failing;
			pendingFailState = result;
			EventHandler<FishingMiniGameEventArgs> onInputFail = this.OnInputFail;
			if (onInputFail != null)
			{
				int num3 = 0;
				FishingMiniGameEventArgs e = this.CreateArgs((float)num2, (Nullable<>)num3);
				onInputFail(this, (TEventArgs)e);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033E8")]
		[Cpp2IlInjected.Address(RVA = "0x13758D0", Offset = "0x13742D0", VA = "0x1813758D0")]
		private void TransitionToQuickFail(FishingMiniGame.FishingResult result)
		{
			//IL_000f: Expected I4, but got I8
			TransitionToEndRound();
			State = MinigameState.Finished;
			if (this.OnMinigameCompleted == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033E9")]
		[Cpp2IlInjected.Address(RVA = "0x1375510", Offset = "0x1373F10", VA = "0x181375510")]
		private float GetNormalizedProgress()
		{
			if (State == MinigameState.Active)
			{
				int num = currentRoundIndex;
				if (num != -1)
				{
					FishingMinigameGameplayConfig fishingMinigameGameplayConfig = roundConfigs[num];
					return elapsedTime;
				}
			}
			int num2 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033EA")]
		[Cpp2IlInjected.Address(RVA = "0x1374EC0", Offset = "0x13738C0", VA = "0x181374EC0")]
		private void FireFailResultEvent(FishingMiniGame.FishingResult result)
		{
			//IL_000d: Expected I4, but got I8
			if (result == FishingMiniGame.FishingResult.RopeBroke)
			{
				State = MinigameState.Finished;
				FireOnCancelled();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033EB")]
		[Cpp2IlInjected.Address(RVA = "0x1374FC0", Offset = "0x13739C0", VA = "0x181374FC0")]
		private void FireOnBeginRound()
		{
			//IL_0017: Expected O, but got I4
			//IL_0017: Expected F4, but got I4
			EventHandler<FishingMiniGameEventArgs> onBeginRound = this.OnBeginRound;
			if (onBeginRound != null)
			{
				int num = 0;
				int num2 = 0;
				FishingMiniGameEventArgs e = this.CreateArgs((float)num2, (Nullable<>)num);
				onBeginRound(this, (TEventArgs)e);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033EC")]
		[Cpp2IlInjected.Address(RVA = "0x13750D0", Offset = "0x1373AD0", VA = "0x1813750D0")]
		private void FireOnEndRound(float progress)
		{
			//IL_0015: Expected O, but got I4
			EventHandler<FishingMiniGameEventArgs> onEndRound = this.OnEndRound;
			if (onEndRound != null)
			{
				int num = 0;
				FishingMiniGameEventArgs e = this.CreateArgs(progress, (Nullable<>)num);
				onEndRound(this, (TEventArgs)e);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033ED")]
		[Cpp2IlInjected.Address(RVA = "0x1375140", Offset = "0x1373B40", VA = "0x181375140")]
		private void FireOnEnterTriggerZone(float progress)
		{
			//IL_0015: Expected O, but got I4
			EventHandler<FishingMiniGameEventArgs> onEnterTriggerZone = this.OnEnterTriggerZone;
			if (onEnterTriggerZone != null)
			{
				int num = 0;
				FishingMiniGameEventArgs e = this.CreateArgs(progress, (Nullable<>)num);
				onEnterTriggerZone(this, (TEventArgs)e);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033EE")]
		[Cpp2IlInjected.Address(RVA = "0x13751B0", Offset = "0x1373BB0", VA = "0x1813751B0")]
		private void FireOnExitTriggerZone(float progress)
		{
			//IL_0015: Expected O, but got I4
			EventHandler<FishingMiniGameEventArgs> onExitTriggerZone = this.OnExitTriggerZone;
			if (onExitTriggerZone != null)
			{
				int num = 0;
				FishingMiniGameEventArgs e = this.CreateArgs(progress, (Nullable<>)num);
				onExitTriggerZone(this, (TEventArgs)e);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033EF")]
		[Cpp2IlInjected.Address(RVA = "0x13754C0", Offset = "0x1373EC0", VA = "0x1813754C0")]
		private void FireOnMinigameFinished(FishingMiniGame.FishingResult result)
		{
			if (this.OnMinigameCompleted == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033F0")]
		[Cpp2IlInjected.Address(RVA = "0x13753E0", Offset = "0x1373DE0", VA = "0x1813753E0")]
		private void FireOnInputFail(float progress)
		{
			//IL_0015: Expected O, but got I4
			EventHandler<FishingMiniGameEventArgs> onInputFail = this.OnInputFail;
			if (onInputFail != null)
			{
				int num = 0;
				FishingMiniGameEventArgs e = this.CreateArgs(progress, (Nullable<>)num);
				onInputFail(this, (TEventArgs)e);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033F1")]
		[Cpp2IlInjected.Address(RVA = "0x1375450", Offset = "0x1373E50", VA = "0x181375450")]
		private void FireOnInputSuccess(float progress)
		{
			//IL_0015: Expected O, but got I4
			EventHandler<FishingMiniGameEventArgs> onInputSuccess = this.OnInputSuccess;
			if (onInputSuccess != null)
			{
				int num = 0;
				FishingMiniGameEventArgs e = this.CreateArgs(progress, (Nullable<>)num);
				onInputSuccess(this, (TEventArgs)e);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033F2")]
		[Cpp2IlInjected.Address(RVA = "0x1375030", Offset = "0x1373A30", VA = "0x181375030")]
		private void FireOnCancelled()
		{
			FishingMiniGameEventArgs e = default(FishingMiniGameEventArgs);
			((EventHandler<TEventArgs>)(object)this.OnCancelled)?.Invoke((object)this, (TEventArgs)e);
		}

		[Cpp2IlInjected.Token(Token = "0x60033F3")]
		[Cpp2IlInjected.Address(RVA = "0x1375350", Offset = "0x1373D50", VA = "0x181375350")]
		private void FireOnFinishedSuccess()
		{
			EventHandler<FishingMiniGameEventArgs> onFinishedSuccess = this.OnFinishedSuccess;
			if (onFinishedSuccess != null)
			{
				int num = 0;
				FishingMiniGameEventArgs e = default(FishingMiniGameEventArgs);
				onFinishedSuccess(this, (TEventArgs)e);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033F4")]
		[Cpp2IlInjected.Address(RVA = "0x13752C0", Offset = "0x1373CC0", VA = "0x1813752C0")]
		private void FireOnFinishedRopeBroke()
		{
			FishingMiniGameEventArgs e = default(FishingMiniGameEventArgs);
			((EventHandler<TEventArgs>)(object)this.OnFinishedRopeBroke)?.Invoke((object)this, (TEventArgs)e);
		}

		[Cpp2IlInjected.Token(Token = "0x60033F5")]
		[Cpp2IlInjected.Address(RVA = "0x1375220", Offset = "0x1373C20", VA = "0x181375220")]
		private void FireOnFinishedFishEscaped()
		{
			FishingMiniGameEventArgs e = default(FishingMiniGameEventArgs);
			((EventHandler<TEventArgs>)(object)this.OnFinishedFishEscaped)?.Invoke((object)this, (TEventArgs)e);
		}

		[Cpp2IlInjected.Token(Token = "0x60033F6")]
		[Cpp2IlInjected.Address(RVA = "0x1374DB0", Offset = "0x13737B0", VA = "0x181374DB0")]
		private FishingMiniGameEventArgs CreateArgs(float progress = 0f, [System.Runtime.InteropServices.Optional] FishingMiniGame.FishingResult? result)
		{
			//Discarded unreachable code: IL_0046
			//IL_003d: Expected O, but got I4
			int num = currentRoundIndex;
			FishingMinigameGameplayConfig[] array = roundConfigs;
			if (num < array.Length)
			{
			}
			int num2 = 0;
			FishingMiniGameEventArgs fishingMiniGameEventArgs = new FishingMiniGameEventArgs();
			fishingMiniGameEventArgs.NormalizedProgress = progress;
			int num3 = (fishingMiniGameEventArgs.CurrentRoundIndex = currentRoundIndex);
			fishingMiniGameEventArgs.Config = (FishingMinigameGameplayConfig)num2;
			fishingMiniGameEventArgs.Result = result;
			return fishingMiniGameEventArgs;
		}

		[Cpp2IlInjected.Token(Token = "0x60033F7")]
		[Cpp2IlInjected.Address(RVA = "0x1375570", Offset = "0x1373F70", VA = "0x181375570")]
		private bool IsFinalRound()
		{
			//Discarded unreachable code: IL_001c
			FishingMinigameGameplayConfig[] array = roundConfigs;
			int num = currentRoundIndex;
			num++;
			return num == array.Length;
		}

		[Cpp2IlInjected.Token(Token = "0x60033F8")]
		[Cpp2IlInjected.Address(RVA = "0x13755A0", Offset = "0x1373FA0", VA = "0x1813755A0")]
		private bool IsNotFirstRound()
		{
			return currentRoundIndex > 0;
		}
	}
}
