using System;
using System.Runtime.CompilerServices;
using System.Security;
using Cpp2IlInjected;

namespace Mdl.Motion
{
	[Cpp2IlInjected.Token(Token = "0x20003B2")]
	public class Tween<T> : Clip
	{
		[Cpp2IlInjected.Token(Token = "0x20003B3")]
		public delegate T InterpolationFunction(T first, T second, float scale);

		[Cpp2IlInjected.Token(Token = "0x20003B4")]
		public delegate void UpdateEventHandler(T value, float progress);

		[Cpp2IlInjected.Token(Token = "0x20003B5")]
		public delegate void FinishEventHandler();

		[Cpp2IlInjected.Token(Token = "0x20003B6")]
		public delegate void CancelEventHandler(T value, float progress);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40018D1")]
		private InterpolationFunction _interpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40018D2")]
		private EasingFunction _easing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40018D3")]
		private float _progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40018D4")]
		private bool _finished;

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40018CE")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000FDC")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000FDD")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public T Start
		{
			[Cpp2IlInjected.Token(Token = "0x6000FDE")]
			[Cpp2IlInjected.Address(RVA = "0x3823CE0", Offset = "0x38226E0", VA = "0x183823CE0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000FDF")]
			[Cpp2IlInjected.Address(RVA = "0x3823E80", Offset = "0x3822880", VA = "0x183823E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public T End
		{
			[Cpp2IlInjected.Token(Token = "0x6000FE0")]
			[Cpp2IlInjected.Address(RVA = "0x3823CD0", Offset = "0x38226D0", VA = "0x183823CD0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000FE1")]
			[Cpp2IlInjected.Address(RVA = "0x3823E70", Offset = "0x3822870", VA = "0x183823E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event UpdateEventHandler OnUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6000FD6")]
			[Cpp2IlInjected.Address(RVA = "0x1C6C740", Offset = "0x1C6B140", VA = "0x181C6C740")]
			[CompilerGenerated]
			add
			{
				Tween<>.UpdateEventHandler onUpdate = (Tween<>.UpdateEventHandler)(object)((Tween<>)(object)this).OnUpdate;
				Delegate @delegate = Delegate.Combine(onUpdate, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onUpdate)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000FD7")]
			[Cpp2IlInjected.Address(RVA = "0x1C6C800", Offset = "0x1C6B200", VA = "0x181C6C800")]
			[CompilerGenerated]
			remove
			{
				Tween<>.UpdateEventHandler onUpdate = (Tween<>.UpdateEventHandler)(object)((Tween<>)(object)this).OnUpdate;
				Delegate @delegate = Delegate.Remove(onUpdate, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onUpdate)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event FinishEventHandler OnFinish
		{
			[Cpp2IlInjected.Token(Token = "0x6000FD8")]
			[Cpp2IlInjected.Address(RVA = "0x3823C10", Offset = "0x3822610", VA = "0x183823C10")]
			[CompilerGenerated]
			add
			{
				Tween<>.FinishEventHandler onFinish = (Tween<>.FinishEventHandler)(object)((Tween<>)(object)this).OnFinish;
				Delegate @delegate = Delegate.Combine(onFinish, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onFinish)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000FD9")]
			[Cpp2IlInjected.Address(RVA = "0x3823DB0", Offset = "0x38227B0", VA = "0x183823DB0")]
			[CompilerGenerated]
			remove
			{
				Tween<>.FinishEventHandler onFinish = (Tween<>.FinishEventHandler)(object)((Tween<>)(object)this).OnFinish;
				Delegate @delegate = Delegate.Remove(onFinish, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onFinish)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event CancelEventHandler OnCancel
		{
			[Cpp2IlInjected.Token(Token = "0x6000FDA")]
			[Cpp2IlInjected.Address(RVA = "0x3823B50", Offset = "0x3822550", VA = "0x183823B50")]
			[CompilerGenerated]
			add
			{
				Tween<>.CancelEventHandler onCancel = (Tween<>.CancelEventHandler)(object)((Tween<>)(object)this).OnCancel;
				Delegate @delegate = Delegate.Combine(onCancel, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onCancel)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000FDB")]
			[Cpp2IlInjected.Address(RVA = "0x3823CF0", Offset = "0x38226F0", VA = "0x183823CF0")]
			[CompilerGenerated]
			remove
			{
				Tween<>.CancelEventHandler onCancel = (Tween<>.CancelEventHandler)(object)((Tween<>)(object)this).OnCancel;
				Delegate @delegate = Delegate.Remove(onCancel, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onCancel)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE2")]
		[Cpp2IlInjected.Address(RVA = "0x38220F0", Offset = "0x3820AF0", VA = "0x1838220F0")]
		public Tween(float duration, T start, T end, InterpolationFunction interpolation, EasingFunction easing)
		{
			((Tween<>)(object)this)._finished = false;
			((Tween<>)(object)this)._finished = false;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE3")]
		[Cpp2IlInjected.Address(RVA = "0x3821200", Offset = "0x381FC00", VA = "0x183821200", Slot = "5")]
		public bool Play(float elapsed, bool reverse = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE4")]
		[Cpp2IlInjected.Address(RVA = "0x3821A20", Offset = "0x3820420", VA = "0x183821A20", Slot = "6")]
		public void Seek(float progress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE5")]
		[Cpp2IlInjected.Address(RVA = "0x3820F70", Offset = "0x381F970", VA = "0x183820F70")]
		public void ForceToFinish(bool reverse = false)
		{
			//Discarded unreachable code: IL_0008
			IPermission permission = ((CodeAccessPermission)this).Copy();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE6")]
		[Cpp2IlInjected.Address(RVA = "0x3820B50", Offset = "0x381F550", VA = "0x183820B50")]
		public void Cancel(bool reverse = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
