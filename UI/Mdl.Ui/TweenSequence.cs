using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008A7")]
	public class TweenSequence : ITween
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400339B")]
		private List<ITween> _tweens = (List<ITween>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40033A3")]
		public TweenDelegate OnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40033A4")]
		public object OnStartParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40033A5")]
		public TweenDelegate OnUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40033A6")]
		public object OnUpdateParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40033A7")]
		public TweenDelegate OnComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40033A8")]
		public object OnCompleteParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40033A9")]
		public TweenDelegate OnRepeat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40033AA")]
		public object OnRepeatParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40033AB")]
		private bool _isCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x40033AC")]
		private bool _isStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x40033AD")]
		private bool _isStartFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x83")]
		[Cpp2IlInjected.Token(Token = "0x40033AE")]
		private bool _isUpdateFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40033AF")]
		private bool _useYoyo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40033B0")]
		private int _currentIndex;

		[Cpp2IlInjected.Token(Token = "0x170007AC")]
		public bool IsComplete
		{
			[Cpp2IlInjected.Token(Token = "0x60036B3")]
			[Cpp2IlInjected.Address(RVA = "0x3F209E0", Offset = "0x3F1F3E0", VA = "0x183F209E0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_0037
				List<ITween> tweens = _tweens;
				Predicate<ITween> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
				if (_003C_003E9__2_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate
					{
						throw new NullReferenceException();
					};
				}
				return _isCompleted = ((List<T>)(object)tweens).TrueForAll((Predicate<>)(object)_003C_003E9__2_);
			}
			[Cpp2IlInjected.Token(Token = "0x60036B4")]
			[Cpp2IlInjected.Address(RVA = "0x3F20C90", Offset = "0x3F1F690", VA = "0x183F20C90", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_0030
				bool value2 = value;
				_isCompleted = value;
				List<ITween> tweens = _tweens;
				Action<ITween> action = (Action<ITween>)(object)(Action<T>)delegate
				{
					int num = 0;
					if ((value2 ? 1 : 0) != num)
					{
					}
					if ((value2 ? 1 : 0) == num)
					{
					}
					throw new NullReferenceException();
				};
				((List<T>)(object)tweens).ForEach((Action<>)(object)action);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007AD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400339C")]
		public bool IsInPeace
		{
			[Cpp2IlInjected.Token(Token = "0x60036B5")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0", Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036B6")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0", Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007AE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x400339D")]
		public int TagNum
		{
			[Cpp2IlInjected.Token(Token = "0x60036B7")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036B8")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0", Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007AF")]
		public object CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x60036B9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return _003CCancellationToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60036BA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "11")]
			[CompilerGenerated]
			set
			{
				_003CCancellationToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400339F")]
		public int RepeatOrigin
		{
			[Cpp2IlInjected.Token(Token = "0x60036BB")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036BC")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007B1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x40033A0")]
		public int Repeat
		{
			[Cpp2IlInjected.Token(Token = "0x60036BD")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0", Slot = "14")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036BE")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380", Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007B2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40033A1")]
		public int RepeatCount
		{
			[Cpp2IlInjected.Token(Token = "0x60036BF")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40", Slot = "16")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036C0")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730", Slot = "17")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007B3")]
		public object Target
		{
			[Cpp2IlInjected.Token(Token = "0x60036C1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return _003CTarget_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60036C2")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0", Slot = "20")]
			[CompilerGenerated]
			set
			{
				_003CTarget_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B4")]
		public float Ratio
		{
			[Cpp2IlInjected.Token(Token = "0x60036C3")]
			[Cpp2IlInjected.Address(RVA = "0x3F20B20", Offset = "0x3F1F520", VA = "0x183F20B20", Slot = "18")]
			get
			{
				List<ITween> tweens = _tweens;
				Func<ITween, bool> _003C_003E9__33_ = _003C_003Ec._003C_003E9__33_0;
				if (_003C_003E9__33_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				int num = Enumerable.Count<ITween>((IEnumerable<>)tweens, (Func<, >)(object)_003C_003E9__33_);
				List<ITween> tweens2 = _tweens;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F20890", Offset = "0x3F1F290", VA = "0x183F20890")]
		public TweenSequence(int repeat = 0, bool useYoyo = false, [Optional] TweenDelegate onComplete, [Optional] object onCompleteParam, [Optional] TweenDelegate onStart, [Optional] object onStartParam, [Optional] TweenDelegate onUpdate, [Optional] object onUpdateParam, [Optional] TweenDelegate onRepeat, [Optional] object onRepeatParam, [Optional] object cancellationToken)
		{
			//IL_002f: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			OnComplete = onComplete;
			Repeat = repeat;
			_useYoyo = useYoyo;
			OnCompleteParam = 0;
			OnStart = (TweenDelegate)0;
			OnStartParam = 0;
			OnUpdate = (TweenDelegate)0;
			OnUpdateParam = 0;
			OnRepeat = (TweenDelegate)0;
			OnRepeatParam = 0;
			CancellationToken = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F20280", Offset = "0x3F1EC80", VA = "0x183F20280")]
		public void Add(ITween tween)
		{
			//Discarded unreachable code: IL_0016
			if (!_isStarted)
			{
				((List<T>)(object)_tweens).Add((T)tween);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F20470", Offset = "0x3F1EE70", VA = "0x183F20470", Slot = "21")]
		public void Start()
		{
			//Discarded unreachable code: IL_004f
			if (!_isStarted)
			{
				List<ITween> tweens = _tweens;
				int currentIndex = 0;
				_isStarted = true;
				RepeatCount = currentIndex;
				_currentIndex = currentIndex;
				IsInPeace = (byte)currentIndex != 0;
				_isUpdateFrame = false;
				_isCompleted = false;
				TweenMax.Add(this);
				ITween tween = Enumerable.First<ITween>((IEnumerable<>)_tweens);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F202E0", Offset = "0x3F1ECE0", VA = "0x183F202E0", Slot = "23")]
		public void Kill()
		{
			//Discarded unreachable code: IL_0034
			List<ITween> tweens = _tweens;
			Action<ITween> _003C_003E9__51_ = _003C_003Ec._003C_003E9__51_0;
			if (_003C_003E9__51_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate
				{
					throw new NullReferenceException();
				};
			}
			((List<T>)(object)tweens).ForEach((Action<>)(object)_003C_003E9__51_);
			TweenMax.Remove(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60036C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F20560", Offset = "0x3F1EF60", VA = "0x183F20560", Slot = "22")]
		public void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
