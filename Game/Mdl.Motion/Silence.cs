using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Motion
{
	[Cpp2IlInjected.Token(Token = "0x20003AE")]
	public class Silence : Clip
	{
		[Cpp2IlInjected.Token(Token = "0x20003AF")]
		public delegate void FinishEventHandler();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40018C7")]
		private float _currentTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018C8")]
		private bool _finished;

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40018C6")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000FC6")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000FC7")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event FinishEventHandler OnFinish
		{
			[Cpp2IlInjected.Token(Token = "0x6000FC4")]
			[Cpp2IlInjected.Address(RVA = "0xF50CD0", Offset = "0xF4F6D0", VA = "0x180F50CD0")]
			[CompilerGenerated]
			add
			{
				FinishEventHandler onFinish = this.OnFinish;
				Delegate @delegate = Delegate.Combine(onFinish, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFinish)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000FC5")]
			[Cpp2IlInjected.Address(RVA = "0xF50D70", Offset = "0xF4F770", VA = "0x180F50D70")]
			[CompilerGenerated]
			remove
			{
				FinishEventHandler onFinish = this.OnFinish;
				Delegate @delegate = Delegate.Remove(onFinish, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFinish)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC8")]
		[Cpp2IlInjected.Address(RVA = "0xF50BA0", Offset = "0xF4F5A0", VA = "0x180F50BA0")]
		public Silence(float duration)
		{
			//Discarded unreachable code: IL_0034
			FinishEventHandler _003C_003E9__10_ = _003C_003Ec._003C_003E9__10_0;
			if (_003C_003E9__10_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(FinishEventHandler)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			this.OnFinish = _003C_003E9__10_;
			base._002Ector();
			Duration = duration;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC9")]
		[Cpp2IlInjected.Address(RVA = "0xF50B20", Offset = "0xF4F520", VA = "0x180F50B20", Slot = "5")]
		public bool Play(float elapsed, bool reverse = false)
		{
			if (!_finished)
			{
				_currentTime = elapsed;
				if (!(elapsed >= Duration))
				{
					return true;
				}
				_finished = true;
				this.OnFinish();
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FCA")]
		[Cpp2IlInjected.Address(RVA = "0xF50B70", Offset = "0xF4F570", VA = "0x180F50B70", Slot = "6")]
		public void Seek(float progress)
		{
			//IL_000d: Expected O, but got F4
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected F4, but got Unknown
			_finished = false;
			float num = ((Silence)progress).Duration;
			float num2 = (_currentTime = /*Error near IL_000e: Stack underflow*/* num);
		}
	}
}
