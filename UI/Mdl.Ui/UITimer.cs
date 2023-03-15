using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000201")]
	public class UITimer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000202")]
		public delegate void TimerEventDelegate(object sender, object param);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008D7")]
		public UnityEvent OnTimerCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40008D8")]
		[SerializeField]
		private TextBase _tfTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40008D9")]
		public string Prefix = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40008DB")]
		[SerializeField]
		private float timeLeft;

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		public TextBase Textfield
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _tfTimer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x40008DA")]
		public bool IsPaused
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCE")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000CCF")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			private set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event TimerEventDelegate TimerComplete
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCB")]
			[Cpp2IlInjected.Address(RVA = "0xC9AFC0", Offset = "0xC999C0", VA = "0x180C9AFC0")]
			[CompilerGenerated]
			add
			{
				TimerEventDelegate timerComplete = this.TimerComplete;
				Delegate @delegate = Delegate.Combine(timerComplete, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != timerComplete)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000CCC")]
			[Cpp2IlInjected.Address(RVA = "0xC9B060", Offset = "0xC99A60", VA = "0x180C9B060")]
			[CompilerGenerated]
			remove
			{
				TimerEventDelegate timerComplete = this.TimerComplete;
				Delegate @delegate = Delegate.Remove(timerComplete, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != timerComplete)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD0")]
		[Cpp2IlInjected.Address(RVA = "0xC9AE80", Offset = "0xC99880", VA = "0x180C9AE80")]
		private void Update()
		{
			//IL_0034: Invalid comparison between I4 and F4
			//IL_0085: Expected O, but got I4
			if (IsPaused)
			{
				return;
			}
			float num = timeLeft;
			int num2 = 0;
			float deltaTime = Time.deltaTime;
			TextBase tfTimer = _tfTimer;
			string prefix = Prefix;
			int num3 = 0;
			timeLeft = num;
			if (!((float)num3 > num))
			{
				string text = TextUtilities.FormatAbbrTime(num * 1000f);
				string text3 = (tfTimer.Text = prefix + text);
				return;
			}
			IsPaused = true;
			timeLeft = 0f;
			TimerEventDelegate timerComplete = this.TimerComplete;
			if (timerComplete != null)
			{
				int num4 = 0;
				timerComplete(this, num4);
			}
			UnityEvent onTimerCompleted = OnTimerCompleted;
			while (onTimerCompleted == null)
			{
			}
			onTimerCompleted.Invoke();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0xC9AAB0", Offset = "0xC994B0", VA = "0x180C9AAB0")]
		private void RefreshText()
		{
			//Discarded unreachable code: IL_0035
			float milliseconds = timeLeft * 1000f;
			TextBase tfTimer = _tfTimer;
			string prefix = Prefix;
			string text = TextUtilities.FormatAbbrTime(milliseconds);
			string text3 = (tfTimer.Text = prefix + text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0xC9AB90", Offset = "0xC99590", VA = "0x180C9AB90")]
		internal void StartTimer(float time)
		{
			int num = 0;
			timeLeft = time;
			ResumeTimer();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0xC9AE60", Offset = "0xC99860", VA = "0x180C9AE60")]
		public void StopTimer()
		{
			timeLeft = 0f;
			if (!IsPaused)
			{
				IsPaused = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0xC9AAA0", Offset = "0xC994A0", VA = "0x180C9AAA0")]
		public void PauseTimer()
		{
			if (!IsPaused)
			{
				IsPaused = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0xC9AB10", Offset = "0xC99510", VA = "0x180C9AB10")]
		public void ResumeTimer()
		{
			//Discarded unreachable code: IL_0045
			float milliseconds = timeLeft * 1000f;
			TextBase tfTimer = _tfTimer;
			string prefix = Prefix;
			string text = TextUtilities.FormatAbbrTime(milliseconds);
			string text3 = (tfTimer.Text = prefix + text);
			if (IsPaused)
			{
				IsPaused = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0xC9ABB0", Offset = "0xC995B0", VA = "0x180C9ABB0")]
		public unsafe void StartTimer(GameObject timerProvider)
		{
			//Discarded unreachable code: IL_0069
			//IL_001d: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0062: Expected F4, but got I4
			int num = 0;
			bool flag = Enum.TryParse<TextType>(base.gameObject.name, out *(TextType*)num);
			int num2 = 0;
			if (timerProvider == (UnityEngine.Object)num2)
			{
				return;
			}
			bool flag2 = timerProvider.TryGetComponent<IHasText>(out *(IHasText*)num);
			if (flag2)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				Prefix = (string)flag2;
			}
			if (timerProvider.TryGetComponent<IHasTimeSpan>(out *(IHasTimeSpan*)num))
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
				int num5 = 0;
				timeLeft = num5;
			}
			ResumeTimer();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0xC9AF70", Offset = "0xC99970", VA = "0x180C9AF70")]
		public UITimer()
		{
		}
	}
}
