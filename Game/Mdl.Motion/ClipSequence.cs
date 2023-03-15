using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Motion
{
	[Cpp2IlInjected.Token(Token = "0x20003A8")]
	public class ClipSequence : Clip
	{
		[Cpp2IlInjected.Token(Token = "0x20003A9")]
		public delegate void FinishEventHandler();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018A3")]
		private List<Clip> _clips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018A4")]
		private int _currentClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40018A5")]
		private bool _finished;

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000F9A")]
			[Cpp2IlInjected.Address(RVA = "0xA859D0", Offset = "0xA843D0", VA = "0x180A859D0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_001e
				int num = 0;
				int num2 = 0;
				List<Clip> clips = _clips;
				bool flag = default(bool);
				if (flag)
				{
					num += num;
					num++;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event FinishEventHandler OnFinish
		{
			[Cpp2IlInjected.Token(Token = "0x6000F98")]
			[Cpp2IlInjected.Address(RVA = "0xA85930", Offset = "0xA84330", VA = "0x180A85930")]
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
			[Cpp2IlInjected.Token(Token = "0x6000F99")]
			[Cpp2IlInjected.Address(RVA = "0xA85B70", Offset = "0xA84570", VA = "0x180A85B70")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F9B")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0")]
		public void Append(Clip clip)
		{
			//Discarded unreachable code: IL_000d
			((List<T>)(object)_clips).Add((T)clip);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F9C")]
		[Cpp2IlInjected.Address(RVA = "0xA85300", Offset = "0xA83D00", VA = "0x180A85300", Slot = "5")]
		public bool Play(float elapsed, bool reverse = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000F9D")]
		[Cpp2IlInjected.Address(RVA = "0xA85490", Offset = "0xA83E90", VA = "0x180A85490", Slot = "6")]
		public void Seek(float progress)
		{
			//Discarded unreachable code: IL_005c
			int num = ((_finished = false) ? 1 : 0);
			List<Clip> clips = _clips;
			bool flag = default(bool);
			if (flag)
			{
				num += num;
				num++;
			}
			int num2 = 0;
			int num3 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			uint num4 = default(uint);
			if (num2 < (int)num4)
			{
				num2 += num2;
				num2++;
			}
			float num5 = default(float);
			if (!(progress > num5) && num2 != (flag ? 1 : 0))
			{
				int num6 = 0;
				num2++;
				uint num7 = num7 + 8;
				num6 += num6;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F9E")]
		[Cpp2IlInjected.Address(RVA = "0xA857D0", Offset = "0xA841D0", VA = "0x180A857D0")]
		public ClipSequence()
		{
			//Discarded unreachable code: IL_003a
			FinishEventHandler _003C_003E9__12_ = _003C_003Ec._003C_003E9__12_0;
			if (_003C_003E9__12_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(FinishEventHandler)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			this.OnFinish = _003C_003E9__12_;
			_clips = (List<Clip>)(object)new List<T>();
			base._002Ector();
		}
	}
}
