using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008AD")]
	public class TweenLite : ITween
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40033DB")]
		public TweenDelegate OnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40033DC")]
		public object OnStartParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40033DD")]
		public TweenDelegate OnUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40033DE")]
		public object OnUpdateParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40033DF")]
		public TweenDelegate OnComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40033E0")]
		public object OnCompleteParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40033E1")]
		public TweenDelegate OnRepeat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40033E2")]
		public object OnRepeatParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40033E3")]
		private eEaseType _ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40033E4")]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40033E5")]
		private bool _isCanvasGroupAdded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40033E6")]
		private object _cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40033E7")]
		private int _tagNum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40033E8")]
		private int _repeatCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40033E9")]
		private float _delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40033EA")]
		private float _startTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40033EB")]
		private float _startAndDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40033EC")]
		private bool _isBackward;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x40033ED")]
		private bool _useFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA6")]
		[Cpp2IlInjected.Token(Token = "0x40033EE")]
		private bool _useYoyo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA7")]
		[Cpp2IlInjected.Token(Token = "0x40033EF")]
		private bool _usePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40033F0")]
		private bool _useOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40033F1")]
		private bool _useOffsetTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x40033F2")]
		private bool _useOffsetBot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAB")]
		[Cpp2IlInjected.Token(Token = "0x40033F3")]
		private bool _useOffsetLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40033F4")]
		private bool _useOffsetRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x40033F5")]
		private bool _useScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAE")]
		[Cpp2IlInjected.Token(Token = "0x40033F6")]
		private bool _useSizeDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAF")]
		[Cpp2IlInjected.Token(Token = "0x40033F7")]
		private bool _useRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40033F8")]
		private bool _useAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x40033F9")]
		private bool _destroyTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40033FA")]
		private Vector3 _startPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40033FB")]
		private Vector3 _endPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40033FC")]
		private Vector4 _startOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40033FD")]
		private Vector4 _endOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40033FE")]
		private float _startOffsetTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40033FF")]
		private float _endOffsetTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4003400")]
		private float _startOffsetBot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4003401")]
		private float _endOffsetBot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4003402")]
		private float _startOffsetLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4003403")]
		private float _endOffsetLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4003404")]
		private float _startOffsetRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4003405")]
		private float _endOffsetRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4003406")]
		private Vector3 _startScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4003407")]
		private Vector3 _endScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4003408")]
		private Vector2 _startSizeDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4003409")]
		private Vector2 _endSizeDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400340A")]
		private Vector3 _startRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400340B")]
		private Vector3 _endRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x400340C")]
		private float _startAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400340D")]
		private float _factorAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x400340E")]
		private float _endAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400340F")]
		private bool _isStartFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x4003410")]
		private bool _isUpdateFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4003411")]
		private object _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003412")]
		private TweenLiteArgs _args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003413")]
		private Transform _transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003414")]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.Token(Token = "0x170007B5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40033D3")]
		public bool IsComplete
		{
			[Cpp2IlInjected.Token(Token = "0x60036D5")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036D6")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007B6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x11"), Cpp2IlInjected.Token(Token = "0x40033D4")]
		public bool IsInPeace
		{
			[Cpp2IlInjected.Token(Token = "0x60036D7")]
			[Cpp2IlInjected.Address(RVA = "0x5706D0", Offset = "0x56F0D0", VA = "0x1805706D0", Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036D8")]
			[Cpp2IlInjected.Address(RVA = "0x570700", Offset = "0x56F100", VA = "0x180570700", Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007B7")]
		public int TagNum
		{
			[Cpp2IlInjected.Token(Token = "0x60036D9")]
			[Cpp2IlInjected.Address(RVA = "0x725190", Offset = "0x723B90", VA = "0x180725190", Slot = "8")]
			get
			{
				return _tagNum;
			}
			[Cpp2IlInjected.Token(Token = "0x60036DA")]
			[Cpp2IlInjected.Address(RVA = "0x725370", Offset = "0x723D70", VA = "0x180725370", Slot = "9")]
			set
			{
				_tagNum = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B8")]
		public int RepeatCount
		{
			[Cpp2IlInjected.Token(Token = "0x60036DB")]
			[Cpp2IlInjected.Address(RVA = "0xA8E090", Offset = "0xA8CA90", VA = "0x180A8E090", Slot = "16")]
			get
			{
				return _repeatCount;
			}
			[Cpp2IlInjected.Token(Token = "0x60036DC")]
			[Cpp2IlInjected.Address(RVA = "0xA8E170", Offset = "0xA8CB70", VA = "0x180A8E170", Slot = "17")]
			set
			{
				_repeatCount = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007B9")]
		public object Target
		{
			[Cpp2IlInjected.Token(Token = "0x60036DD")]
			[Cpp2IlInjected.Address(RVA = "0x738EC0", Offset = "0x7378C0", VA = "0x180738EC0", Slot = "19")]
			get
			{
				return _target;
			}
			[Cpp2IlInjected.Token(Token = "0x60036DE")]
			[Cpp2IlInjected.Address(RVA = "0x739EB0", Offset = "0x7388B0", VA = "0x180739EB0", Slot = "20")]
			set
			{
				_target = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BA")]
		public object CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x60036DF")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80", Slot = "10")]
			get
			{
				return _cancellationToken;
			}
			[Cpp2IlInjected.Token(Token = "0x60036E0")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490", Slot = "11")]
			set
			{
				_cancellationToken = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007BB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x40033D5")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60036E1")]
			[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036E2")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007BC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40033D6")]
		public float CurrentTime
		{
			[Cpp2IlInjected.Token(Token = "0x60036E3")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036E4")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007BD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x40033D7")]
		public float Ratio
		{
			[Cpp2IlInjected.Token(Token = "0x60036E5")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320", Slot = "18")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036E6")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007BE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40033D8")]
		public int RepeatOrigin
		{
			[Cpp2IlInjected.Token(Token = "0x60036E7")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0", Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036E8")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0", Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007BF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x40033D9")]
		public int Repeat
		{
			[Cpp2IlInjected.Token(Token = "0x60036E9")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960", Slot = "14")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036EA")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0", Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007C0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40033DA")]
		public int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60036EB")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036EC")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60036ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F15CA0", Offset = "0x3F146A0", VA = "0x183F15CA0")]
		public TweenLite(object target, float duration, TweenLiteArgs args, bool isBackward = false, int tagNum = int.MinValue, [Optional] object cancellationToken)
		{
			//IL_0012: Expected I4, but got I8
			//IL_003c: Expected O, but got I4
			int num = 0;
			_tagNum = int.MinValue;
			_target = target;
			_tagNum = 0;
			_args = args;
			Duration = duration;
			_isBackward = false;
			_cancellationToken = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F12E70", Offset = "0x3F11870", VA = "0x183F12E70", Slot = "1")]
		~TweenLite()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			_target = num;
		}

		[Cpp2IlInjected.Token(Token = "0x60036EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F14060", Offset = "0x3F12A60", VA = "0x183F14060")]
		public static TweenLite To(object target, float duration, TweenLiteArgs vars, int tagNum = int.MinValue, [Optional] object cancellationToken)
		{
			//IL_0010: Expected I4, but got I8
			//IL_003a: Expected O, but got I4
			TweenLite tweenLite = default(TweenLite);
			tweenLite._tagNum = int.MinValue;
			tweenLite._tagNum = tagNum;
			tweenLite._target = target;
			tweenLite._args = vars;
			tweenLite.Duration = duration;
			tweenLite._isBackward = false;
			tweenLite._cancellationToken = 0;
			tweenLite.Start();
			return tweenLite;
		}

		[Cpp2IlInjected.Token(Token = "0x60036F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F14150", Offset = "0x3F12B50", VA = "0x183F14150")]
		public static TweenLite To(TweenDefinition tweenDefinition, [Optional] IHasTween owner)
		{
			//Discarded unreachable code: IL_006e
			//IL_0036: Expected I4, but got I8
			GameObject target = tweenDefinition.Target;
			float duration = tweenDefinition.Duration;
			TweenLiteArgs args = new TweenLiteArgs(tweenDefinition, owner);
			bool isBackward = tweenDefinition.IsBackward;
			GameObject target2 = tweenDefinition.Target;
			TweenLite tweenLite = default(TweenLite);
			tweenLite._tagNum = int.MinValue;
			tweenLite._target = target;
			tweenLite._args = args;
			tweenLite.Duration = duration;
			tweenLite._isBackward = isBackward;
			if ((object)target2 == null)
			{
			}
			tweenLite._cancellationToken = target2;
			tweenLite.Start();
			return tweenLite;
		}

		[Cpp2IlInjected.Token(Token = "0x60036F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F12ED0", Offset = "0x3F118D0", VA = "0x183F12ED0")]
		public static TweenLite From(object target, float duration, TweenLiteArgs vars, int tagNum = int.MinValue, [Optional] object cancellationToken)
		{
			//IL_0010: Expected I4, but got I8
			//IL_003a: Expected O, but got I4
			TweenLite tweenLite = default(TweenLite);
			tweenLite._tagNum = int.MinValue;
			tweenLite._tagNum = tagNum;
			tweenLite._target = target;
			tweenLite._args = vars;
			tweenLite.Duration = duration;
			tweenLite._isBackward = true;
			tweenLite._cancellationToken = 0;
			tweenLite.Start();
			return tweenLite;
		}

		[Cpp2IlInjected.Token(Token = "0x60036F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F12C40", Offset = "0x3F11640", VA = "0x183F12C40")]
		public unsafe static TweenLite DelayCall(float delayTime, Action action)
		{
			//Discarded unreachable code: IL_00ee
			//IL_0040: Expected O, but got I4
			//IL_0048: Expected native int or pointer, but got O
			//IL_0055: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_008d: Expected F4, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00b6: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			//IL_00d6: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			_003C_003Ec__DisplayClass107_0 _003C_003Ec__DisplayClass107_ = new _003C_003Ec__DisplayClass107_0();
			_003C_003Ec__DisplayClass107_.action = action;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			TweenDelegate tweenDelegate = default(TweenDelegate);
			((Delegate)tweenDelegate).method_ptr = (IntPtr)__ldftn(_003C_003Ec__DisplayClass107_0._003CDelayCall_003Eb__0);
			((Delegate)tweenDelegate).method = (IntPtr)__ldftn(_003C_003Ec__DisplayClass107_0._003CDelayCall_003Eb__0);
			((Delegate)tweenDelegate).m_target = _003C_003Ec__DisplayClass107_;
			TweenLiteArgs tweenLiteArgs = default(TweenLiteArgs);
			tweenLiteArgs.Offset = (Vector4?)(object)num3;
			((Nullable<>*)(IntPtr)tweenLiteArgs.SizeDelta)->has_value = (byte)num != 0;
			tweenLiteArgs.Position = (Vector3?)(object)num2;
			tweenLiteArgs.Scale = (Vector3?)(object)num2;
			tweenLiteArgs.OffsetTop = (float?)(object)num;
			tweenLiteArgs.Rotation = (Vector3?)(object)num2;
			tweenLiteArgs.OffsetBot = (float?)(object)num;
			tweenLiteArgs.Alpha = (float?)(object)num;
			tweenLiteArgs.StartAlpha = (float?)(object)num;
			tweenLiteArgs.Delay = num;
			tweenLiteArgs.UseFrame = (byte)num != 0;
			tweenLiteArgs.OnComplete = tweenDelegate;
			tweenLiteArgs.OnCompleteParam = num;
			tweenLiteArgs.OnStart = (TweenDelegate)num;
			tweenLiteArgs.OnStartParam = num;
			tweenLiteArgs.OnUpdate = (TweenDelegate)num;
			tweenLiteArgs.OnUpdateParam = num;
			tweenLiteArgs.OnRepeat = (TweenDelegate)num;
			tweenLiteArgs.OnRepeatParam = num;
			tweenLiteArgs.CancellationToken = num;
			return To(0, delayTime, tweenLiteArgs, int.MinValue, num);
		}

		[Cpp2IlInjected.Token(Token = "0x60036F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F12A10", Offset = "0x3F11410", VA = "0x183F12A10")]
		public unsafe static TweenLite DelayCall(int delayFrame, Action action)
		{
			//Discarded unreachable code: IL_00f2
			//IL_0040: Expected O, but got I4
			//IL_0048: Expected native int or pointer, but got O
			//IL_0055: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_008d: Expected F4, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00b6: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			//IL_00d6: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			//IL_00f1: Expected O, but got I4
			//IL_00f1: Expected F4, but got I4
			//IL_00f1: Expected O, but got I4
			_003C_003Ec__DisplayClass108_0 _003C_003Ec__DisplayClass108_ = new _003C_003Ec__DisplayClass108_0();
			_003C_003Ec__DisplayClass108_.action = action;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			TweenDelegate tweenDelegate = default(TweenDelegate);
			((Delegate)tweenDelegate).method_ptr = (IntPtr)__ldftn(_003C_003Ec__DisplayClass108_0._003CDelayCall_003Eb__0);
			((Delegate)tweenDelegate).method = (IntPtr)__ldftn(_003C_003Ec__DisplayClass108_0._003CDelayCall_003Eb__0);
			((Delegate)tweenDelegate).m_target = _003C_003Ec__DisplayClass108_;
			TweenLiteArgs tweenLiteArgs = default(TweenLiteArgs);
			tweenLiteArgs.Offset = (Vector4?)(object)num3;
			((Nullable<>*)(IntPtr)tweenLiteArgs.SizeDelta)->has_value = (byte)num != 0;
			tweenLiteArgs.Position = (Vector3?)(object)num2;
			tweenLiteArgs.Scale = (Vector3?)(object)num2;
			tweenLiteArgs.OffsetTop = (float?)(object)num;
			tweenLiteArgs.Rotation = (Vector3?)(object)num2;
			tweenLiteArgs.OffsetBot = (float?)(object)num;
			tweenLiteArgs.Alpha = (float?)(object)num;
			tweenLiteArgs.StartAlpha = (float?)(object)num;
			tweenLiteArgs.Delay = num;
			tweenLiteArgs.UseFrame = true;
			tweenLiteArgs.OnComplete = tweenDelegate;
			tweenLiteArgs.OnCompleteParam = num;
			tweenLiteArgs.OnStart = (TweenDelegate)num;
			tweenLiteArgs.OnStartParam = num;
			tweenLiteArgs.OnUpdate = (TweenDelegate)num;
			tweenLiteArgs.OnUpdateParam = num;
			tweenLiteArgs.OnRepeat = (TweenDelegate)num;
			tweenLiteArgs.OnRepeatParam = num;
			int num5 = 0;
			tweenLiteArgs.CancellationToken = num;
			return To(0, num5, tweenLiteArgs, int.MinValue, num);
		}

		[Cpp2IlInjected.Token(Token = "0x60036F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F12FC0", Offset = "0x3F119C0", VA = "0x183F12FC0")]
		private void InitProperties(TweenLiteArgs args, bool isBackward)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60036F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F90", Offset = "0x3F12990", VA = "0x183F13F90", Slot = "21")]
		public void Start()
		{
			//IL_001f: Expected I4, but got I8
			//IL_004e: Expected I4, but got I8
			bool isBackward = _isBackward;
			TweenLiteArgs args = _args;
			InitProperties(args, isBackward);
			FrameCount = 0;
			if (_useFrame)
			{
			}
			int num = 0;
			float startAndDelayTime = (_startTime = Time.realtimeSinceStartup);
			_isStartFrame = false;
			IsComplete = false;
			_repeatCount = 0;
			_startAndDelayTime = startAndDelayTime;
			Update();
			TweenMax.Add(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60036F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F14290", Offset = "0x3F12C90", VA = "0x183F14290", Slot = "22")]
		public void Update()
		{
			//IL_002e: Expected O, but got I4
			//IL_00f8: Expected I4, but got O
			//IL_0124: Expected I4, but got O
			//IL_01b7: Expected I4, but got O
			//IL_01cc: Invalid comparison between I4 and F4
			//IL_01f2: Expected F4, but got I4
			//IL_0205: Expected F8, but got I4
			//IL_0205: Expected F8, but got I4
			//IL_0205: Expected F8, but got I4
			//IL_0205: Expected F8, but got I4
			//IL_0212: Expected F4, but got I4
			//IL_0225: Expected F8, but got I4
			//IL_0225: Expected F8, but got I4
			//IL_0225: Expected F8, but got I4
			//IL_0225: Expected F8, but got I4
			//IL_0232: Expected F4, but got I4
			//IL_0245: Expected F8, but got I4
			//IL_0245: Expected F8, but got I4
			//IL_0245: Expected F8, but got I4
			//IL_0245: Expected F8, but got I4
			//IL_0252: Expected F4, but got I4
			//IL_0265: Expected F8, but got I4
			//IL_0265: Expected F8, but got I4
			//IL_0265: Expected F8, but got I4
			//IL_0265: Expected F8, but got I4
			//IL_0272: Expected F4, but got I4
			//IL_0285: Expected F8, but got I4
			//IL_0285: Expected F8, but got I4
			//IL_0285: Expected F8, but got I4
			//IL_0285: Expected F8, but got I4
			//IL_0292: Expected F4, but got I4
			//IL_02a5: Expected F8, but got I4
			//IL_02a5: Expected F8, but got I4
			//IL_02a5: Expected F8, but got I4
			//IL_02a5: Expected F8, but got I4
			//IL_02b2: Expected F4, but got I4
			//IL_02c5: Expected F8, but got I4
			//IL_02c5: Expected F8, but got I4
			//IL_02c5: Expected F8, but got I4
			//IL_02c5: Expected F8, but got I4
			//IL_02d2: Expected F4, but got I4
			//IL_02e5: Expected F8, but got I4
			//IL_02e5: Expected F8, but got I4
			//IL_02e5: Expected F8, but got I4
			//IL_02e5: Expected F8, but got I4
			//IL_02f2: Expected F4, but got I4
			//IL_0305: Expected F8, but got I4
			//IL_0305: Expected F8, but got I4
			//IL_0305: Expected F8, but got I4
			//IL_0305: Expected F8, but got I4
			//IL_0312: Expected F4, but got I4
			//IL_0325: Expected F8, but got I4
			//IL_0325: Expected F8, but got I4
			//IL_0325: Expected F8, but got I4
			//IL_0325: Expected F8, but got I4
			//IL_0332: Expected F4, but got I4
			//IL_0345: Expected F8, but got I4
			//IL_0345: Expected F8, but got I4
			//IL_0345: Expected F8, but got I4
			//IL_0345: Expected F8, but got I4
			//IL_0352: Expected F4, but got I4
			//IL_0365: Expected F8, but got I4
			//IL_0365: Expected F8, but got I4
			//IL_0365: Expected F8, but got I4
			//IL_0365: Expected F8, but got I4
			//IL_0372: Expected F4, but got I4
			//IL_0385: Expected F8, but got I4
			//IL_0385: Expected F8, but got I4
			//IL_0385: Expected F8, but got I4
			//IL_0385: Expected F8, but got I4
			//IL_0392: Expected F4, but got I4
			//IL_039d: Expected F4, but got I4
			//IL_03a8: Expected F4, but got I4
			//IL_03b6: Expected F4, but got I4
			//IL_03be: Expected F4, but got I4
			//IL_03d1: Expected F8, but got I4
			//IL_03d1: Expected F8, but got I4
			//IL_03d1: Expected F8, but got I4
			//IL_03d1: Expected F8, but got I4
			//IL_03de: Expected F4, but got I4
			//IL_03ec: Expected F4, but got I4
			//IL_03fa: Expected F4, but got I4
			//IL_040d: Expected F8, but got I4
			//IL_040d: Expected F8, but got I4
			//IL_040d: Expected F8, but got I4
			//IL_040d: Expected F8, but got I4
			//IL_041a: Expected F4, but got I4
			//IL_042b: Expected F4, but got I4
			//IL_043e: Expected F8, but got I4
			//IL_043e: Expected F8, but got I4
			//IL_043e: Expected F8, but got I4
			//IL_043e: Expected F8, but got I4
			//IL_044b: Expected F4, but got I4
			//IL_045e: Expected F8, but got I4
			//IL_045e: Expected F8, but got I4
			//IL_045e: Expected F8, but got I4
			//IL_045e: Expected F8, but got I4
			//IL_046b: Expected F4, but got I4
			//IL_047e: Expected F8, but got I4
			//IL_047e: Expected F8, but got I4
			//IL_047e: Expected F8, but got I4
			//IL_047e: Expected F8, but got I4
			//IL_048b: Expected F4, but got I4
			//IL_049e: Expected F8, but got I4
			//IL_049e: Expected F8, but got I4
			//IL_049e: Expected F8, but got I4
			//IL_049e: Expected F8, but got I4
			//IL_04ab: Expected F4, but got I4
			//IL_04be: Expected F8, but got I4
			//IL_04be: Expected F8, but got I4
			//IL_04be: Expected F8, but got I4
			//IL_04be: Expected F8, but got I4
			//IL_04cb: Expected F4, but got I4
			//IL_04de: Expected F8, but got I4
			//IL_04de: Expected F8, but got I4
			//IL_04de: Expected F8, but got I4
			//IL_04de: Expected F8, but got I4
			//IL_04eb: Expected F4, but got I4
			//IL_04fe: Expected F8, but got I4
			//IL_04fe: Expected F8, but got I4
			//IL_04fe: Expected F8, but got I4
			//IL_04fe: Expected F8, but got I4
			//IL_050b: Expected F4, but got I4
			//IL_051e: Expected F8, but got I4
			//IL_051e: Expected F8, but got I4
			//IL_051e: Expected F8, but got I4
			//IL_051e: Expected F8, but got I4
			//IL_052b: Expected F4, but got I4
			//IL_053e: Expected F8, but got I4
			//IL_053e: Expected F8, but got I4
			//IL_053e: Expected F8, but got I4
			//IL_053e: Expected F8, but got I4
			//IL_054b: Expected F4, but got I4
			//IL_0556: Expected F4, but got I4
			//IL_056c: Expected F8, but got I4
			//IL_056c: Expected F8, but got I4
			//IL_056c: Expected F8, but got I4
			//IL_056c: Expected F8, but got I4
			//IL_0579: Expected F4, but got I4
			//IL_058c: Expected F8, but got I4
			//IL_058c: Expected F8, but got I4
			//IL_058c: Expected F8, but got I4
			//IL_058c: Expected F8, but got I4
			//IL_0599: Expected F4, but got I4
			//IL_05a9: Expected F4, but got O
			//IL_05ad: Invalid comparison between F4 and I4
			//IL_0614: Expected O, but got I4
			//IL_062e: Expected O, but got I4
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			object target3 = default(object);
			while (true)
			{
				object target = _target;
				int num = 0;
				if (target != null)
				{
					if (target != null)
					{
					}
					if (target != null)
					{
						int num2 = 0;
						if (target != null)
						{
							if (flag)
							{
							}
							int num3 = 0;
							if (gameObject == (UnityEngine.Object)num3)
							{
								IsComplete = true;
								Repeat = num;
								TweenMax.Remove(this);
								if ((_isCanvasGroupAdded ? 1 : 0) != num)
								{
									UnityEngine.Object.Destroy(_canvasGroup);
								}
								if ((_destroyTarget ? 1 : 0) == num)
								{
									continue;
								}
								object target2 = _target;
								if (target2 == null)
								{
									continue;
								}
								int num4 = 0;
								if (target2 == null)
								{
									continue;
								}
								int num5 = 0;
							}
						}
					}
				}
				int num6 = 0;
				if ((IsComplete ? 1 : 0) != num)
				{
					if (Repeat == 0)
					{
						TweenDelegate onComplete = OnComplete;
						if (onComplete != null)
						{
							object onCompleteParam = OnCompleteParam;
							onComplete(this, onCompleteParam);
						}
						IsInPeace = true;
						if ((_destroyTarget ? 1 : 0) != num)
						{
							target3 = _target;
							if (target3 != null)
							{
								int num7 = 0;
								if (target3 != null)
								{
									int num8 = 0;
								}
							}
						}
						if (!_isCanvasGroupAdded)
						{
							continue;
						}
						UnityEngine.Object.Destroy(_canvasGroup);
					}
					FrameCount = (int)target3;
					if ((IntPtr)(_useFrame ? 1 : 0) != (IntPtr)target3)
					{
					}
					int num9 = 0;
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					int num10 = Repeat;
					_startTime = realtimeSinceStartup;
					IsComplete = (byte)(int)target3 != 0;
					_startAndDelayTime = realtimeSinceStartup;
					if (num10 > 0)
					{
						Repeat = num10;
					}
					TweenDelegate onRepeat = OnRepeat;
					if (onRepeat != null)
					{
						object onRepeatParam = OnRepeatParam;
						onRepeat(this, onRepeatParam);
					}
				}
				if ((IntPtr)(_useFrame ? 1 : 0) != (IntPtr)target3)
				{
					int num11 = FrameCount;
					num11 = (FrameCount = num11 + 1);
				}
				int num12 = 0;
				float num13 = (CurrentTime = Time.realtimeSinceStartup);
				if ((IntPtr)(_isStartFrame ? 1 : 0) == (IntPtr)target3)
				{
					if ((IntPtr)(_isUpdateFrame ? 1 : 0) != (IntPtr)target3)
					{
						goto IL_01b7;
					}
					_isStartFrame = true;
				}
				if ((IntPtr)(_isUpdateFrame ? 1 : 0) != (IntPtr)target3)
				{
					_isStartFrame = (byte)(int)target3 != 0;
				}
				goto IL_01b7;
				IL_01b7:
				float num14 = Duration;
				if (!(num13 >= num14))
				{
					if (!((float)num6 >= num13))
					{
						eEaseType ease = _ease;
						Ratio = num13;
						int num15 = 0;
						int num16 = 0;
						int num17 = 0;
						Ratio = num17;
						int num18 = 0;
						int num19 = 0;
						double num20 = TweenMax.EaseOutInCubic(num18, num19, num16, num15);
						int num21 = 0;
						Ratio = num21;
						int num22 = 0;
						int num23 = 0;
						double num24 = TweenMax.EaseInCirc(num22, num23, num16, num15);
						int num25 = 0;
						Ratio = num25;
						int num26 = 0;
						int num27 = 0;
						double num28 = TweenMax.EaseOutCirc(num26, num27, num16, num15);
						int num29 = 0;
						Ratio = num29;
						int num30 = 0;
						int num31 = 0;
						double num32 = TweenMax.EaseInOutCirc(num30, num31, num16, num15);
						int num33 = 0;
						Ratio = num33;
						int num34 = 0;
						int num35 = 0;
						double num36 = TweenMax.EaseOutInCirc(num34, num35, num16, num15);
						int num37 = 0;
						Ratio = num37;
						int num38 = 0;
						int num39 = 0;
						double num40 = TweenMax.EaseInExpo(num38, num39, num16, num15);
						int num41 = 0;
						Ratio = num41;
						int num42 = 0;
						int num43 = 0;
						double num44 = TweenMax.EaseOutExpo(num42, num43, num16, num15);
						int num45 = 0;
						Ratio = num45;
						int num46 = 0;
						int num47 = 0;
						double num48 = TweenMax.EaseInOutExpo(num46, num47, num16, num15);
						int num49 = 0;
						Ratio = num49;
						int num50 = 0;
						int num51 = 0;
						double num52 = TweenMax.EaseOutInExpo(num50, num51, num16, num15);
						int num53 = 0;
						Ratio = num53;
						int num54 = 0;
						int num55 = 0;
						double num56 = TweenMax.EaseInElastic(num54, num55, num16, num15);
						int num57 = 0;
						Ratio = num57;
						int num58 = 0;
						int num59 = 0;
						double num60 = TweenMax.EaseOutElastic(num58, num59, num16, num15);
						int num61 = 0;
						Ratio = num61;
						int num62 = 0;
						int num63 = 0;
						double num64 = TweenMax.EaseInOutElastic(num62, num63, num16, num15);
						int num65 = 0;
						Ratio = num65;
						int num66 = 0;
						int num67 = 0;
						double num68 = TweenMax.EaseOutInElastic(num66, num67, num16, num15);
						int num69 = 0;
						Ratio = num69;
						int num70 = 0;
						Ratio = num70;
						int num71 = 0;
						Ratio = num71;
						int num72 = 0;
						int num73 = 0;
						Ratio = num73;
						Ratio = num73;
						int num74 = 0;
						int num75 = 0;
						double num76 = TweenMax.EaseOutInQuad(num74, num75, num72, num15);
						int num77 = 0;
						Ratio = num77;
						int num78 = 0;
						int num79 = 0;
						Ratio = num78;
						int num80 = 0;
						int num81 = 0;
						Ratio = num81;
						int num82 = 0;
						int num83 = 0;
						double num84 = TweenMax.EaseOutInQuart(num82, num83, num80, num79);
						int num85 = 0;
						Ratio = num85;
						int num86 = 0;
						int num87 = 0;
						int num88 = 0;
						Ratio = num88;
						int num89 = 0;
						int num90 = 0;
						double num91 = TweenMax.EaseOutInQuint(num89, num90, num87, num86);
						int num92 = 0;
						Ratio = num92;
						int num93 = 0;
						int num94 = 0;
						double num95 = TweenMax.EaseInSine(num93, num94, num87, num86);
						int num96 = 0;
						Ratio = num96;
						int num97 = 0;
						int num98 = 0;
						double num99 = TweenMax.EaseOutSine(num97, num98, num87, num86);
						int num100 = 0;
						Ratio = num100;
						int num101 = 0;
						int num102 = 0;
						double num103 = TweenMax.EaseInOutSine(num101, num102, num87, num86);
						int num104 = 0;
						Ratio = num104;
						int num105 = 0;
						int num106 = 0;
						double num107 = TweenMax.EaseOutInSine(num105, num106, num87, num86);
						int num108 = 0;
						Ratio = num108;
						int num109 = 0;
						int num110 = 0;
						double num111 = TweenMax.EaseInBounce(num109, num110, num87, num86);
						int num112 = 0;
						Ratio = num112;
						int num113 = 0;
						int num114 = 0;
						double num115 = TweenMax.EaseOutBounce(num113, num114, num87, num86);
						int num116 = 0;
						Ratio = num116;
						int num117 = 0;
						int num118 = 0;
						double num119 = TweenMax.EaseInOutBounce(num117, num118, num87, num86);
						int num120 = 0;
						Ratio = num120;
						int num121 = 0;
						int num122 = 0;
						double num123 = TweenMax.EaseOutInBounce(num121, num122, num87, num86);
						int num124 = 0;
						Ratio = num124;
						int num125 = 0;
						Ratio = num125;
						int num126 = 0;
						int num127 = 0;
						int num128 = 0;
						double num129 = TweenMax.EaseInOutBack(num127, num128, num126, num126);
						int num130 = 0;
						Ratio = num130;
						int num131 = 0;
						int num132 = 0;
						double num133 = TweenMax.EaseOutInBack(num131, num132, num126, num126);
						int num134 = 0;
						Ratio = num134;
					}
					float delay = _delay;
					Ratio = (float)target3;
					if (delay > (float)num6)
					{
						continue;
					}
				}
				CurrentTime = num14;
				IsComplete = true;
				Ratio = 1f;
				if ((IntPtr)(_useYoyo ? 1 : 0) != (IntPtr)target3)
				{
					int num135 = _repeatCount;
					if ((long)(_useYoyo ? 1 : 0) < (long)(IntPtr)target3)
					{
						num135++;
					}
					if (num135 != 1)
					{
					}
				}
				if ((IntPtr)(_usePosition ? 1 : 0) == (IntPtr)target3)
				{
					continue;
				}
				RectTransform rectTransform = _rectTransform;
				int num136 = 0;
				if (!(rectTransform != (UnityEngine.Object)num136))
				{
					Transform transform = _transform;
					int num137 = 0;
					if (transform != (UnityEngine.Object)num137)
					{
						/*Error: Could not find block for branch target IL_0634*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F13E30", Offset = "0x3F12830", VA = "0x183F13E30", Slot = "23")]
		public void Kill()
		{
			int num = 0;
			IsComplete = true;
			Repeat = num;
			TweenMax.Remove(this);
			if ((_isCanvasGroupAdded ? 1 : 0) != num)
			{
				UnityEngine.Object.Destroy(_canvasGroup);
			}
			if ((_destroyTarget ? 1 : 0) == num)
			{
				return;
			}
			object target = _target;
			if (target != null)
			{
				int num2 = 0;
				if (target != null)
				{
					int num3 = 0;
				}
			}
		}
	}
}
