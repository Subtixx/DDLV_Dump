using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008A5")]
	public class TweenMax : ITween
	{
		[Cpp2IlInjected.Token(Token = "0x4003333")]
		public const int NO_TAG = int.MinValue;

		[Cpp2IlInjected.Token(Token = "0x4003334")]
		private static List<ITween> tweens = (List<ITween>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x4003335")]
		private static HashSet<ITween> targetsRemoved;

		[Cpp2IlInjected.Token(Token = "0x4003336")]
		private static bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4003338")]
		public bool IsComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400333F")]
		public TweenDelegate OnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003340")]
		public object OnStartParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003341")]
		public TweenDelegate OnUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003342")]
		public object OnUpdateParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003343")]
		public TweenDelegate OnComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003344")]
		public object OnCompleteParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003345")]
		public TweenDelegate OnRepeat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003346")]
		public object OnRepeatParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003347")]
		private eEaseType _ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003348")]
		private object _cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003349")]
		private int _tagNum = int.MinValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400334A")]
		private int _repeatCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400334B")]
		private float _delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400334C")]
		private float _startTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400334D")]
		private float _startAndDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400334E")]
		private bool _isBackward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x400334F")]
		private bool _useFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
		[Cpp2IlInjected.Token(Token = "0x4003350")]
		private bool _useYoyo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
		[Cpp2IlInjected.Token(Token = "0x4003351")]
		private bool _useBezier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003352")]
		private bool _usePhysics2d;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4003353")]
		private bool _releaseFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x4003354")]
		private bool _usePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x4003355")]
		private bool _usePosX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4003356")]
		private bool _usePosY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
		[Cpp2IlInjected.Token(Token = "0x4003357")]
		private bool _useWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
		[Cpp2IlInjected.Token(Token = "0x4003358")]
		private bool _useHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9F")]
		[Cpp2IlInjected.Token(Token = "0x4003359")]
		private bool _useScaleX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400335A")]
		private bool _useScaleY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x400335B")]
		private bool _useScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x400335C")]
		private bool _useRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x400335D")]
		private bool _useRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400335E")]
		private bool _useRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x400335F")]
		private bool _useRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA6")]
		[Cpp2IlInjected.Token(Token = "0x4003360")]
		private bool _useAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA7")]
		[Cpp2IlInjected.Token(Token = "0x4003361")]
		private bool _destroyTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003362")]
		private float[] _bezierProp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003363")]
		private float[,] _beziers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003364")]
		private float _brightness;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4003365")]
		private float _contrast;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003366")]
		private float _saturation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003367")]
		private Physics2DProp _physicsX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003368")]
		private Physics2DProp _physicsY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003369")]
		private float _physicsFriction = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400336A")]
		private float _physicsTimeScale = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400336B")]
		private int _step;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400336C")]
		private int _stepsPerTimeUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400336D")]
		private bool _isStartFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
		[Cpp2IlInjected.Token(Token = "0x400336E")]
		private bool _isUpdateFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400336F")]
		private object _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4003370")]
		private object _vars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4003371")]
		private List<TweenPropertyInfo> listTpi;

		[Cpp2IlInjected.Token(Token = "0x4003372")]
		private const string str_position = "Position";

		[Cpp2IlInjected.Token(Token = "0x4003373")]
		private const string str_alpha = "Alpha";

		[Cpp2IlInjected.Token(Token = "0x4003374")]
		private const string str_x = "X";

		[Cpp2IlInjected.Token(Token = "0x4003375")]
		private const string str_y = "Y";

		[Cpp2IlInjected.Token(Token = "0x4003376")]
		private const string str_width = "Width";

		[Cpp2IlInjected.Token(Token = "0x4003377")]
		private const string str_height = "Height";

		[Cpp2IlInjected.Token(Token = "0x4003378")]
		private const string str_scaleX = "ScaleX";

		[Cpp2IlInjected.Token(Token = "0x4003379")]
		private const string str_scaleY = "ScaleY";

		[Cpp2IlInjected.Token(Token = "0x400337A")]
		private const string str_scale = "Scale";

		[Cpp2IlInjected.Token(Token = "0x400337B")]
		private const string str_rotation = "Rotation";

		[Cpp2IlInjected.Token(Token = "0x400337C")]
		private const string str_rotationX = "RotationX";

		[Cpp2IlInjected.Token(Token = "0x400337D")]
		private const string str_rotationY = "RotationY";

		[Cpp2IlInjected.Token(Token = "0x400337E")]
		private const string str_rotationZ = "RotationZ";

		[Cpp2IlInjected.Token(Token = "0x400337F")]
		private const string str_useFrame = "UseFrame";

		[Cpp2IlInjected.Token(Token = "0x4003380")]
		private const string str_delay = "Delay";

		[Cpp2IlInjected.Token(Token = "0x4003381")]
		private const string str_onComplete = "OnComplete";

		[Cpp2IlInjected.Token(Token = "0x4003382")]
		private const string str_onCompleteParam = "OnCompleteParam";

		[Cpp2IlInjected.Token(Token = "0x4003383")]
		private const string str_onStart = "OnStart";

		[Cpp2IlInjected.Token(Token = "0x4003384")]
		private const string str_onStartParam = "OnStartParam";

		[Cpp2IlInjected.Token(Token = "0x4003385")]
		private const string str_onUpdate = "OnUpdate";

		[Cpp2IlInjected.Token(Token = "0x4003386")]
		private const string str_onUpdateParam = "OnUpdateParam";

		[Cpp2IlInjected.Token(Token = "0x4003387")]
		private const string str_onRepeat = "OnRepeat";

		[Cpp2IlInjected.Token(Token = "0x4003388")]
		private const string str_onRepeatParam = "OnRepeatParam";

		[Cpp2IlInjected.Token(Token = "0x4003389")]
		private const string str_ease = "Ease";

		[Cpp2IlInjected.Token(Token = "0x400338A")]
		private const string str_brightness = "Brightness";

		[Cpp2IlInjected.Token(Token = "0x400338B")]
		private const string str_saturation = "Saturation";

		[Cpp2IlInjected.Token(Token = "0x400338C")]
		private const string str_contrast = "Contrast";

		[Cpp2IlInjected.Token(Token = "0x400338D")]
		private const string str_repeat = "Repeat";

		[Cpp2IlInjected.Token(Token = "0x400338E")]
		private const string str_useYoyo = "UseYoyo";

		[Cpp2IlInjected.Token(Token = "0x400338F")]
		private const string str_bezier = "Bezier";

		[Cpp2IlInjected.Token(Token = "0x4003390")]
		private const string str_physics2d = "Physics2D";

		[Cpp2IlInjected.Token(Token = "0x4003391")]
		private const string str_destroyTarget = "DestroyTarget";

		[Cpp2IlInjected.Token(Token = "0x4003392")]
		private const string str_cancellationToken = "CancellationToken";

		[Cpp2IlInjected.Token(Token = "0x4003393")]
		private const string str_angle = "Angle";

		[Cpp2IlInjected.Token(Token = "0x4003394")]
		private const string str_velocity = "Velocity";

		[Cpp2IlInjected.Token(Token = "0x4003395")]
		private const string str_gravity = "Gravity";

		[Cpp2IlInjected.Token(Token = "0x4003396")]
		private const string str_acceleration = "Acceleration";

		[Cpp2IlInjected.Token(Token = "0x4003397")]
		private const string str_friction = "Friction";

		[Cpp2IlInjected.Token(Token = "0x4003398")]
		private const string str_aAngle = "AccelerationAngle";

		[Cpp2IlInjected.Token(Token = "0x4003399")]
		private const string str_timeScale = "TimeScale";

		[Cpp2IlInjected.Token(Token = "0x1700079E")]
		bool ITween.IsComplete
		{
			[Cpp2IlInjected.Token(Token = "0x6003687")]
			[Cpp2IlInjected.Address(RVA = "0x5706D0", Offset = "0x56F0D0", VA = "0x1805706D0", Slot = "4")]
			get
			{
				return IsComplete;
			}
			[Cpp2IlInjected.Token(Token = "0x6003688")]
			[Cpp2IlInjected.Address(RVA = "0x570700", Offset = "0x56F100", VA = "0x180570700", Slot = "5")]
			set
			{
				IsComplete = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700079F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003337")]
		public bool IsInPeace
		{
			[Cpp2IlInjected.Token(Token = "0x6003689")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0", Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600368A")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710", Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007A0")]
		public int TagNum
		{
			[Cpp2IlInjected.Token(Token = "0x600368B")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670", Slot = "8")]
			get
			{
				return _tagNum;
			}
			[Cpp2IlInjected.Token(Token = "0x600368C")]
			[Cpp2IlInjected.Address(RVA = "0x10247F0", Offset = "0x10231F0", VA = "0x1810247F0", Slot = "9")]
			set
			{
				_tagNum = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A1")]
		int ITween.Repeat
		{
			[Cpp2IlInjected.Token(Token = "0x600368D")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960", Slot = "14")]
			get
			{
				return Repeat;
			}
			[Cpp2IlInjected.Token(Token = "0x600368E")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0", Slot = "15")]
			set
			{
				Repeat = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A2")]
		int ITween.RepeatCount
		{
			[Cpp2IlInjected.Token(Token = "0x600368F")]
			[Cpp2IlInjected.Address(RVA = "0x1D8F910", Offset = "0x1D8E310", VA = "0x181D8F910", Slot = "16")]
			get
			{
				return _repeatCount;
			}
			[Cpp2IlInjected.Token(Token = "0x6003690")]
			[Cpp2IlInjected.Address(RVA = "0x1D8FD50", Offset = "0x1D8E750", VA = "0x181D8FD50", Slot = "17")]
			set
			{
				_repeatCount = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A3")]
		public object Target
		{
			[Cpp2IlInjected.Token(Token = "0x6003691")]
			[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10", Slot = "19")]
			get
			{
				return _target;
			}
			[Cpp2IlInjected.Token(Token = "0x6003692")]
			[Cpp2IlInjected.Address(RVA = "0xE269B0", Offset = "0xE253B0", VA = "0x180E269B0", Slot = "20")]
			set
			{
				_target = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A4")]
		public object CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6003693")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640", Slot = "10")]
			get
			{
				return _cancellationToken;
			}
			[Cpp2IlInjected.Token(Token = "0x6003694")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60", Slot = "11")]
			set
			{
				_cancellationToken = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4003339")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6003695")]
			[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003696")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007A6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400333A")]
		public float CurrentTime
		{
			[Cpp2IlInjected.Token(Token = "0x6003697")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003698")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007A7")]
		public float Delay
		{
			[Cpp2IlInjected.Token(Token = "0x6003699")]
			[Cpp2IlInjected.Address(RVA = "0x1062BE0", Offset = "0x10615E0", VA = "0x181062BE0")]
			get
			{
				return _delay;
			}
			[Cpp2IlInjected.Token(Token = "0x600369A")]
			[Cpp2IlInjected.Address(RVA = "0x3F20260", Offset = "0x3F1EC60", VA = "0x183F20260")]
			set
			{
				_delay = value;
				_startAndDelayTime = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007A8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x400333B")]
		public float Ratio
		{
			[Cpp2IlInjected.Token(Token = "0x600369B")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320", Slot = "18")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600369C")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007A9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400333C")]
		public int RepeatOrigin
		{
			[Cpp2IlInjected.Token(Token = "0x600369D")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0", Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600369E")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0", Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007AA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x400333D")]
		public int Repeat
		{
			[Cpp2IlInjected.Token(Token = "0x600369F")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036A0")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007AB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400333E")]
		public int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60036A1")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60036A2")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6003657")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C750", Offset = "0x3F1B150", VA = "0x183F1C750")]
		public unsafe static void UpdateAll([Optional] object sender, [Optional] EventArgs e)
		{
			//Discarded unreachable code: IL_009a, IL_00a0, IL_00ac, IL_00b8, IL_00be, IL_00c4
			//IL_0040: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				List<ITween> obj = tweens;
				Monitor.Enter(obj, ref *(bool*)num3);
				if (((List<>)(object)tweens)._size > 0)
				{
					HashSet<ITween> obj2 = targetsRemoved;
					HashSet<ITween> hashSet = targetsRemoved;
					if (flag)
					{
						if (!((List<T>)(object)tweens).Contains((T)num2))
						{
							continue;
						}
						bool flag2 = ((List<T>)(object)tweens).Remove((T)num2);
					}
					if (num3 != 0)
					{
						throw new NullReferenceException();
					}
					((HashSet<T>)(object)targetsRemoved).Clear();
					Monitor.Exit(obj2);
					if (num3 != 0)
					{
						break;
					}
				}
				int size = ((List<>)(object)tweens)._size;
				int num4 = size - 1;
				size = num4;
				if (num4 > -1)
				{
					List<ITween> list = tweens;
				}
				Monitor.Exit(obj);
				if (num3 == 0)
				{
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003658")]
		[Cpp2IlInjected.Address(RVA = "0x3F15D50", Offset = "0x3F14750", VA = "0x183F15D50")]
		internal unsafe static void Add(ITween tween)
		{
			//Discarded unreachable code: IL_0021
			int num = 0;
			List<ITween> obj = tweens;
			Monitor.Enter(obj, ref *(bool*)num);
			((List<T>)(object)tweens).Add((T)tween);
			Monitor.Exit(obj);
		}

		[Cpp2IlInjected.Token(Token = "0x6003659")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C4A0", Offset = "0x3F1AEA0", VA = "0x183F1C4A0")]
		internal unsafe static void Remove(ITween tween)
		{
			//Discarded unreachable code: IL_0022
			int num = 0;
			HashSet<ITween> obj = targetsRemoved;
			Monitor.Enter(obj, ref *(bool*)num);
			bool flag = ((HashSet<T>)(object)targetsRemoved).Add((T)tween);
			Monitor.Exit(obj);
		}

		[Cpp2IlInjected.Token(Token = "0x600365A")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C1A0", Offset = "0x3F1ABA0", VA = "0x183F1C1A0")]
		public unsafe static void KillAll()
		{
			//Discarded unreachable code: IL_0036, IL_003c
			int num = 0;
			List<ITween> obj = tweens;
			Monitor.Enter(obj, ref *(bool*)num);
			((List<T>)(object)tweens).Clear();
			Monitor.Exit(obj);
			HashSet<ITween> obj2 = targetsRemoved;
			((HashSet<T>)(object)targetsRemoved).Clear();
			Monitor.Exit(obj2);
		}

		[Cpp2IlInjected.Token(Token = "0x600365B")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C010", Offset = "0x3F1AA10", VA = "0x183F1C010")]
		public unsafe static void KillAllByTag(int tagNum = int.MinValue)
		{
			//Discarded unreachable code: IL_0049, IL_004f
			int num = 0;
			List<ITween> obj = tweens;
			Monitor.Enter(obj, ref *(bool*)num);
			ITween[] array = (ITween[])(object)((List<T>)(object)tweens).ToArray();
			if (array != null && array.Length != 0 && num < array.Length)
			{
				if (array[num] == null || (IntPtr)array == (IntPtr)tagNum)
				{
				}
				num++;
			}
			Monitor.Exit(obj);
		}

		[Cpp2IlInjected.Token(Token = "0x600365C")]
		[Cpp2IlInjected.Address(RVA = "0x3F1BE70", Offset = "0x3F1A870", VA = "0x183F1BE70")]
		public unsafe static void KillAllByCancelationToken(object token)
		{
			//Discarded unreachable code: IL_0049, IL_004f, IL_0055
			int num = 0;
			List<ITween> obj = tweens;
			Monitor.Enter(obj, ref *(bool*)num);
			ITween[] array = (ITween[])(object)((List<T>)(object)tweens).ToArray();
			if (array != null && array.Length != 0 && num < array.Length)
			{
				if (array[num] != null)
				{
				}
				if ((IntPtr)num == (IntPtr)token)
				{
				}
				num++;
			}
			Monitor.Exit(obj);
		}

		[Cpp2IlInjected.Token(Token = "0x600365D")]
		[Cpp2IlInjected.Address(RVA = "0x3F18750", Offset = "0x3F17150", VA = "0x183F18750")]
		public unsafe static bool HasCancelationToken(object token)
		{
			//Discarded unreachable code: IL_005f
			int num = 0;
			int num2 = 0;
			List<ITween> obj = tweens;
			Monitor.Enter(obj, ref *(bool*)num2);
			ITween[] array = (ITween[])(object)((List<T>)(object)tweens).ToArray();
			if (array != null && array.Length != 0 && num2 < array.Length)
			{
				if (array[num2] != null)
				{
				}
				if ((IntPtr)num2 != (IntPtr)token)
				{
					num2++;
				}
				num2++;
			}
			num2++;
			Monitor.Exit(obj);
			if (num2 != 0)
			{
			}
			int num3 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x600365E")]
		[Cpp2IlInjected.Address(RVA = "0x3F17540", Offset = "0x3F15F40", VA = "0x183F17540")]
		internal static double EaseNone(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600365F")]
		[Cpp2IlInjected.Address(RVA = "0x3F17420", Offset = "0x3F15E20", VA = "0x183F17420")]
		internal static double EaseInQuad(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003660")]
		[Cpp2IlInjected.Address(RVA = "0x3F184E0", Offset = "0x3F16EE0", VA = "0x183F184E0")]
		internal static double EaseOutQuad(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003661")]
		[Cpp2IlInjected.Address(RVA = "0x3F171E0", Offset = "0x3F15BE0", VA = "0x183F171E0")]
		internal static double EaseInOutQuad(double t, double b, double c, double d)
		{
			//Discarded unreachable code: IL_0002
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003662")]
		[Cpp2IlInjected.Address(RVA = "0x3F18050", Offset = "0x3F16A50", VA = "0x183F18050")]
		internal static double EaseOutInQuad(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003663")]
		[Cpp2IlInjected.Address(RVA = "0x3F168F0", Offset = "0x3F152F0", VA = "0x183F168F0")]
		internal static double EaseInCubic(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003664")]
		[Cpp2IlInjected.Address(RVA = "0x3F17720", Offset = "0x3F16120", VA = "0x183F17720")]
		internal static double EaseOutCubic(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003665")]
		[Cpp2IlInjected.Address(RVA = "0x3F16E20", Offset = "0x3F15820", VA = "0x183F16E20")]
		internal static double EaseInOutCubic(double t, double b, double c, double d)
		{
			//Discarded unreachable code: IL_0002
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003666")]
		[Cpp2IlInjected.Address(RVA = "0x3F17D20", Offset = "0x3F16720", VA = "0x183F17D20")]
		internal static double EaseOutInCubic(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003667")]
		[Cpp2IlInjected.Address(RVA = "0x3F17440", Offset = "0x3F15E40", VA = "0x183F17440")]
		internal static double EaseInQuart(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003668")]
		[Cpp2IlInjected.Address(RVA = "0x3F18510", Offset = "0x3F16F10", VA = "0x183F18510")]
		internal static double EaseOutQuart(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003669")]
		[Cpp2IlInjected.Address(RVA = "0x3F17240", Offset = "0x3F15C40", VA = "0x183F17240")]
		internal static double EaseInOutQuart(double t, double b, double c, double d)
		{
			//Discarded unreachable code: IL_0002
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600366A")]
		[Cpp2IlInjected.Address(RVA = "0x3F18160", Offset = "0x3F16B60", VA = "0x183F18160")]
		internal static double EaseOutInQuart(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600366B")]
		[Cpp2IlInjected.Address(RVA = "0x3F17460", Offset = "0x3F15E60", VA = "0x183F17460")]
		internal static double EaseInQuint(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600366C")]
		[Cpp2IlInjected.Address(RVA = "0x3F18550", Offset = "0x3F16F50", VA = "0x183F18550")]
		internal static double EaseOutQuint(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600366D")]
		[Cpp2IlInjected.Address(RVA = "0x3F172D0", Offset = "0x3F15CD0", VA = "0x183F172D0")]
		internal static double EaseInOutQuint(double t, double b, double c, double d)
		{
			//Discarded unreachable code: IL_0002
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600366E")]
		[Cpp2IlInjected.Address(RVA = "0x3F18280", Offset = "0x3F16C80", VA = "0x183F18280")]
		internal static double EaseOutInQuint(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600366F")]
		[Cpp2IlInjected.Address(RVA = "0x3F17490", Offset = "0x3F15E90", VA = "0x183F17490")]
		internal static double EaseInSine(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003670")]
		[Cpp2IlInjected.Address(RVA = "0x3F18590", Offset = "0x3F16F90", VA = "0x183F18590")]
		internal static double EaseOutSine(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003671")]
		[Cpp2IlInjected.Address(RVA = "0x3F17360", Offset = "0x3F15D60", VA = "0x183F17360")]
		internal static double EaseInOutSine(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003672")]
		[Cpp2IlInjected.Address(RVA = "0x3F183A0", Offset = "0x3F16DA0", VA = "0x183F183A0")]
		internal static double EaseOutInSine(double t, double b, double c, double d)
		{
			double num = EaseInSine(t, b, c, d);
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003673")]
		[Cpp2IlInjected.Address(RVA = "0x3F16A60", Offset = "0x3F15460", VA = "0x183F16A60")]
		internal static double EaseInExpo(double t, double b, double c, double d)
		{
			return Math.Pow(t, b);
		}

		[Cpp2IlInjected.Token(Token = "0x6003674")]
		[Cpp2IlInjected.Address(RVA = "0x3F178A0", Offset = "0x3F162A0", VA = "0x183F178A0")]
		internal static double EaseOutExpo(double t, double b, double c, double d)
		{
			return Math.Pow(t, b);
		}

		[Cpp2IlInjected.Token(Token = "0x6003675")]
		[Cpp2IlInjected.Address(RVA = "0x3F17070", Offset = "0x3F15A70", VA = "0x183F17070")]
		internal static double EaseInOutExpo(double t, double b, double c, double d)
		{
			return Math.Pow(Math.Pow(t, b), b);
		}

		[Cpp2IlInjected.Token(Token = "0x6003676")]
		[Cpp2IlInjected.Address(RVA = "0x3F17F40", Offset = "0x3F16940", VA = "0x183F17F40")]
		internal static double EaseOutInExpo(double t, double b, double c, double d)
		{
			double num = EaseInExpo(t, b, c, d);
			num = t;
			return EaseOutExpo(num, b, c, d);
		}

		[Cpp2IlInjected.Token(Token = "0x6003677")]
		[Cpp2IlInjected.Address(RVA = "0x3F16820", Offset = "0x3F15220", VA = "0x183F16820")]
		internal static double EaseInCirc(double t, double b, double c, double d)
		{
			return b;
		}

		[Cpp2IlInjected.Token(Token = "0x6003678")]
		[Cpp2IlInjected.Address(RVA = "0x3F17660", Offset = "0x3F16060", VA = "0x183F17660")]
		internal static double EaseOutCirc(double t, double b, double c, double d)
		{
			return d;
		}

		[Cpp2IlInjected.Token(Token = "0x6003679")]
		[Cpp2IlInjected.Address(RVA = "0x3F16CF0", Offset = "0x3F156F0", VA = "0x183F16CF0")]
		internal static double EaseInOutCirc(double t, double b, double c, double d)
		{
			return b;
		}

		[Cpp2IlInjected.Token(Token = "0x600367A")]
		[Cpp2IlInjected.Address(RVA = "0x3F17C10", Offset = "0x3F16610", VA = "0x183F17C10")]
		internal static double EaseOutInCirc(double t, double b, double c, double d)
		{
			double num = EaseInCirc(t, b, c, d);
			num = t;
			return EaseOutCirc(num, b, c, d);
		}

		[Cpp2IlInjected.Token(Token = "0x600367B")]
		[Cpp2IlInjected.Address(RVA = "0x3F16910", Offset = "0x3F15310", VA = "0x183F16910")]
		internal static double EaseInElastic(double t, double b, double c, double d)
		{
			double num = Math.Pow(t, b);
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600367C")]
		[Cpp2IlInjected.Address(RVA = "0x3F17750", Offset = "0x3F16150", VA = "0x183F17750")]
		internal static double EaseOutElastic(double t, double b, double c, double d)
		{
			double num = Math.Pow(t, b);
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600367D")]
		[Cpp2IlInjected.Address(RVA = "0x3F16EA0", Offset = "0x3F158A0", VA = "0x183F16EA0")]
		internal static double EaseInOutElastic(double t, double b, double c, double d)
		{
			double num = Math.Pow(t, b);
			num = t;
			double num2 = Math.Pow(num, b);
			num2 = t;
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x600367E")]
		[Cpp2IlInjected.Address(RVA = "0x3F17E30", Offset = "0x3F16830", VA = "0x183F17E30")]
		internal static double EaseOutInElastic(double t, double b, double c, double d)
		{
			double num = EaseInElastic(t, b, c, d);
			num = t;
			return EaseOutElastic(num, b, c, d);
		}

		[Cpp2IlInjected.Token(Token = "0x600367F")]
		[Cpp2IlInjected.Address(RVA = "0x3F16740", Offset = "0x3F15140", VA = "0x183F16740")]
		internal static double EaseInBack(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003680")]
		[Cpp2IlInjected.Address(RVA = "0x3F17550", Offset = "0x3F15F50", VA = "0x183F17550")]
		internal static double EaseOutBack(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003681")]
		[Cpp2IlInjected.Address(RVA = "0x3F16B30", Offset = "0x3F15530", VA = "0x183F16B30")]
		internal static double EaseInOutBack(double t, double b, double c, double d)
		{
			//Discarded unreachable code: IL_0002
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003682")]
		[Cpp2IlInjected.Address(RVA = "0x3F17980", Offset = "0x3F16380", VA = "0x183F17980")]
		internal static double EaseOutInBack(double t, double b, double c, double d)
		{
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003683")]
		[Cpp2IlInjected.Address(RVA = "0x3F16770", Offset = "0x3F15170", VA = "0x183F16770")]
		internal static double EaseInBounce(double t, double b, double c, double d)
		{
			//IL_000b: Expected F8, but got I4
			int num = 0;
			double num2 = EaseOutBounce(t, num, c, d);
			return c;
		}

		[Cpp2IlInjected.Token(Token = "0x6003684")]
		[Cpp2IlInjected.Address(RVA = "0x3F17590", Offset = "0x3F15F90", VA = "0x183F17590")]
		internal static double EaseOutBounce(double t, double b, double c, double d)
		{
			//Discarded unreachable code: IL_0002, IL_0004, IL_0006
			return t;
		}

		[Cpp2IlInjected.Token(Token = "0x6003685")]
		[Cpp2IlInjected.Address(RVA = "0x3F16BD0", Offset = "0x3F155D0", VA = "0x183F16BD0")]
		internal static double EaseInOutBounce(double t, double b, double c, double d)
		{
			//IL_000b: Expected F8, but got I4
			//IL_001b: Expected F8, but got I4
			int num = 0;
			double num2 = EaseOutBounce(t, num, c, d);
			int num3 = 0;
			num2 = t;
			return EaseInBounce(num2, num3, c, d);
		}

		[Cpp2IlInjected.Token(Token = "0x6003686")]
		[Cpp2IlInjected.Address(RVA = "0x3F17AB0", Offset = "0x3F164B0", VA = "0x183F17AB0")]
		internal static double EaseOutInBounce(double t, double b, double c, double d)
		{
			//IL_000b: Expected F8, but got I4
			int num = 0;
			double num2 = EaseOutBounce(t, num, c, d);
			num2 = c;
			num2 = t;
			return EaseOutBounce(num2, c, c, d);
		}

		[Cpp2IlInjected.Token(Token = "0x60036A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F20150", Offset = "0x3F1EB50", VA = "0x183F20150")]
		public TweenMax(object target, float duration, object vars, bool isBackward = false, int tagNum = int.MinValue, [Optional] object cancellationToken)
		{
			//IL_0010: Expected I4, but got I8
			//IL_0058: Expected O, but got I4
			List<TweenPropertyInfo> list = (listTpi = (List<TweenPropertyInfo>)(object)new List<T>());
			int num = 0;
			_target = target;
			_tagNum = 0;
			Duration = duration;
			_vars = vars;
			_cancellationToken = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F18630", Offset = "0x3F17030", VA = "0x183F18630", Slot = "1")]
		~TweenMax()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			_target = num;
		}

		[Cpp2IlInjected.Token(Token = "0x60036A5")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C690", Offset = "0x3F1B090", VA = "0x183F1C690")]
		public static TweenMax To(object target, float duration, object vars, int tagNum = int.MinValue, [Optional] object cancellationToken)
		{
			//Discarded unreachable code: IL_0008
			TweenMax tweenMax = default(TweenMax);
			tweenMax.Start();
			return tweenMax;
		}

		[Cpp2IlInjected.Token(Token = "0x60036A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F18690", Offset = "0x3F17090", VA = "0x183F18690")]
		public static TweenMax From(object target, float duration, object vars, int tagNum = int.MinValue, [Optional] object cancellationToken)
		{
			//Discarded unreachable code: IL_0008
			TweenMax tweenMax = default(TweenMax);
			tweenMax.Start();
			return tweenMax;
		}

		[Cpp2IlInjected.Token(Token = "0x60036A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F196B0", Offset = "0x3F180B0", VA = "0x183F196B0")]
		private void InitProperties(object vars, bool isBackward)
		{
			//IL_0055: Expected O, but got I4
			//IL_0475: Expected I4, but got O
			//IL_04e4: Expected I4, but got O
			//IL_04fe: Expected I4, but got O
			PropertyInfo[] properties;
			RectTransform rectTransform = default(RectTransform);
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			Vector3 vector4 = default(Vector3);
			Vector3 vector5 = default(Vector3);
			Vector3 vector6 = default(Vector3);
			Transform transform = default(Transform);
			object obj = default(object);
			object obj2 = default(object);
			object obj4 = default(object);
			object obj5 = default(object);
			object obj6 = default(object);
			object obj8 = default(object);
			object obj10 = default(object);
			int num4;
			Vector2 anchoredPosition2 = default(Vector2);
			Vector3 vector7 = default(Vector3);
			Vector3 vector8 = default(Vector3);
			float z8 = default(float);
			Vector3 vector9 = default(Vector3);
			Vector2 sizeDelta = default(Vector2);
			float z9 = default(float);
			Vector3 vector10 = default(Vector3);
			float z10 = default(float);
			Vector3 vector11 = default(Vector3);
			Quaternion quaternion = default(Quaternion);
			CanvasRenderer componentInChildren2 = default(CanvasRenderer);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				num4 = 0;
				_isBackward = isBackward;
				properties = vars.GetType().GetProperties();
				((List<T>)(object)listTpi).Clear();
				if (num4 >= properties.Length)
				{
					continue;
				}
				object target = _target;
				if (target != null && target != null)
				{
					int num5 = 0;
					bool flag = rectTransform != (UnityEngine.Object)num5;
					int length = properties.Length;
					if (flag)
					{
						goto IL_0238;
					}
					string name = properties[num4].Name;
					if (name != null)
					{
						if ((long)name > 2607911122L)
						{
							if ((long)name > 3270900971L)
							{
								if ((long)name == 3691781268L)
								{
									if (name == null)
									{
										goto IL_03df;
									}
									float z = vector.z;
									_usePosY = true;
								}
								if ((long)name == 3708558887L)
								{
									if (name == null)
									{
										goto IL_03df;
									}
									_usePosX = true;
								}
								if ((long)name != 3799987242L || name == null)
								{
									goto IL_03df;
								}
								float z2 = vector2.z;
								_usePos = true;
							}
							if ((long)name == 2624688741L)
							{
								if (name == null)
								{
									goto IL_03df;
								}
								_useRotationX = true;
							}
							if ((long)name == 3254123352L)
							{
								if (name == null)
								{
									goto IL_03df;
								}
								float z3 = vector3.z;
								_useScaleY = true;
							}
							if ((long)name != 3270900971L || name == null)
							{
								goto IL_03df;
							}
							_useScaleX = true;
						}
						if ((long)name > 55079499)
						{
							if ((long)name == 676498961)
							{
								if (name == null)
								{
									goto IL_03df;
								}
								float z4 = vector4.z;
								_useScale = true;
							}
							if ((long)name == 2591133503L)
							{
								if (name == null)
								{
									goto IL_03df;
								}
								float z5 = vector5.z;
								_useRotationZ = true;
							}
							if ((long)name != 2607911122L || name == null)
							{
								goto IL_03df;
							}
							float z6 = vector6.z;
							_useRotationY = true;
						}
						if ((long)name == 36861823)
						{
							if (name == null)
							{
								goto IL_03df;
							}
							_useRotation = true;
						}
						if ((long)name == 55079499 && name != null)
						{
							CanvasRenderer componentInChildren = transform.GetComponentInChildren<CanvasRenderer>();
							if ((object)componentInChildren != null)
							{
								float alpha = componentInChildren.GetAlpha();
							}
							_useAlpha = true;
							goto IL_0238;
						}
					}
				}
				goto IL_03df;
				IL_03df:
				string name2 = properties[num4].Name;
				if (name2 == null || (long)name2 <= 1054471185)
				{
					continue;
				}
				if ((long)name2 > 2008543277)
				{
					if ((long)name2 > 2119076945)
					{
						if ((long)name2 == 2559428980L)
						{
							if (name2 == null)
							{
								continue;
							}
							PropertyInfo propertyInfo = properties[num4];
							OnCompleteParam = obj;
							num4++;
						}
						if ((long)obj == 3048564068L)
						{
							if (obj == null)
							{
								continue;
							}
							PropertyInfo propertyInfo2 = properties[num4];
							object obj3 = obj2;
							_useYoyo = (byte)(int)obj3 != 0;
							num4++;
						}
						PropertyInfo propertyInfo3 = properties[num4];
						OnRepeatParam = obj4;
						num4++;
					}
					if ((long)obj4 == 2063504715)
					{
						if (obj4 == null)
						{
							continue;
						}
						PropertyInfo propertyInfo4 = properties[num4];
						_cancellationToken = obj5;
						num4++;
					}
					if ((long)obj5 != 2119076945 || obj5 == null)
					{
						continue;
					}
					PropertyInfo propertyInfo5 = properties[num4];
					object obj7 = obj6;
					_useFrame = (byte)(int)obj7 != 0;
					num4++;
				}
				PropertyInfo propertyInfo6 = properties[num4];
				object obj9 = obj8;
				_ease = (eEaseType)(int)obj9;
				num4++;
				PropertyInfo propertyInfo7 = properties[num4];
				OnStartParam = obj10;
				num4++;
				if ((long)obj10 == 1236439463 && obj10 != null)
				{
					break;
				}
				continue;
				IL_0238:
				string name3 = properties[num4].Name;
				if (name3 != null)
				{
					if ((long)name3 <= 2607911122L)
					{
						goto IL_031b;
					}
					if ((long)name3 > 3270900971L)
					{
						if ((long)name3 == 3691781268L)
						{
							if (name3 == null)
							{
								goto IL_03df;
							}
							Vector2 anchoredPosition = rectTransform.anchoredPosition;
						}
						if ((long)name3 == 3708558887L)
						{
							if (name3 == null)
							{
								goto IL_03df;
							}
							anchoredPosition2 = rectTransform.anchoredPosition;
						}
						if ((long)anchoredPosition2 != 3799987242L || (object)anchoredPosition2 == null)
						{
							goto IL_03df;
						}
						float z7 = vector7.z;
					}
					if ((long)name3 != 2624688741L || name3 != null)
					{
						if ((long)vector8 == 3254123352L)
						{
							if ((object)vector8 == null)
							{
								goto IL_03df;
							}
							z8 = vector9.z;
						}
						if (z8 == -122.99398f && z8 != 0f)
						{
							goto IL_031b;
						}
					}
				}
				goto IL_03df;
				IL_031b:
				if ((long)name3 > 466695522)
				{
					if ((long)name3 == 994238399)
					{
						if (name3 == null)
						{
							goto IL_03df;
						}
						sizeDelta = rectTransform.sizeDelta;
						_useWidth = true;
					}
					if ((long)sizeDelta == 2591133503L)
					{
						if ((object)sizeDelta == null)
						{
							goto IL_03df;
						}
						z9 = vector10.z;
					}
					if (z9 != -1.9981847E-22f || z9 == 0f)
					{
						goto IL_03df;
					}
					z10 = vector11.z;
				}
				if (z10 != 1.3111668E-37f || z10 != 0f)
				{
					if ((long)quaternion == 55079499)
					{
						if ((object)quaternion == null)
						{
							goto IL_03df;
						}
						componentInChildren2 = rectTransform.GetComponentInChildren<CanvasRenderer>();
						if ((object)componentInChildren2 != null)
						{
							float alpha2 = componentInChildren2.GetAlpha();
						}
					}
					if ((long)componentInChildren2 == 466695522 && (object)componentInChildren2 != null)
					{
						Vector2 sizeDelta2 = rectTransform.sizeDelta;
						_useHeight = true;
					}
				}
				goto IL_03df;
			}
			PropertyInfo propertyInfo8 = properties[num4];
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C5C0", Offset = "0x3F1AFC0", VA = "0x183F1C5C0", Slot = "21")]
		public void Start()
		{
			//IL_001f: Expected I4, but got I8
			//IL_004e: Expected I4, but got I8
			bool isBackward = _isBackward;
			object vars = _vars;
			InitProperties(vars, isBackward);
			FrameCount = 0;
			if (_useFrame)
			{
			}
			int num = 0;
			float startAndDelayTime = (_startTime = Time.realtimeSinceStartup);
			_isStartFrame = false;
			IsInPeace = false;
			_repeatCount = 0;
			_startAndDelayTime = startAndDelayTime;
			Update();
			Add(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60036A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F1CC60", Offset = "0x3F1B660", VA = "0x183F1CC60", Slot = "22")]
		public void Update()
		{
			//IL_0035: Expected O, but got I4
			//IL_017c: Invalid comparison between I4 and F4
			//IL_01bd: Expected F4, but got I4
			//IL_01c8: Expected F4, but got I4
			//IL_01d3: Expected F4, but got I4
			//IL_01de: Expected F4, but got I4
			//IL_01e9: Expected F4, but got I4
			//IL_01f4: Expected F4, but got I4
			//IL_01ff: Expected F4, but got I4
			//IL_020a: Expected F4, but got I4
			//IL_0215: Expected F4, but got I4
			//IL_0220: Expected F4, but got I4
			//IL_022b: Expected F4, but got I4
			//IL_0236: Expected F4, but got I4
			//IL_0241: Expected F4, but got I4
			//IL_024c: Expected F4, but got I4
			//IL_0257: Expected F4, but got I4
			//IL_0262: Expected F4, but got I4
			//IL_026d: Expected F4, but got I4
			//IL_0278: Expected F4, but got I4
			//IL_0280: Expected F4, but got I4
			//IL_028b: Expected F4, but got I4
			//IL_0296: Expected F4, but got I4
			//IL_02a1: Expected F4, but got I4
			//IL_02ac: Expected F4, but got I4
			//IL_02b7: Expected F4, but got I4
			//IL_02c2: Expected F4, but got I4
			//IL_02cd: Expected F4, but got I4
			//IL_02d8: Expected F4, but got I4
			//IL_02e3: Expected F4, but got I4
			//IL_02ee: Expected F4, but got I4
			//IL_02f9: Expected F4, but got I4
			//IL_0304: Expected F4, but got I4
			//IL_030f: Expected F4, but got I4
			//IL_031a: Expected F4, but got I4
			//IL_0325: Expected F4, but got I4
			//IL_0330: Expected F4, but got I4
			int num2;
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			int num11 = default(int);
			float num14;
			float num15;
			do
			{
				int num = 0;
				num2 = 0;
				_003C_003Ec__DisplayClass192_0 _003C_003Ec__DisplayClass192_ = new _003C_003Ec__DisplayClass192_0();
				object target = _target;
				if (target != null)
				{
					if (target != null)
					{
					}
					if (target != null)
					{
						int num3 = 0;
						if (target != null)
						{
							if (flag)
							{
							}
							int num4 = 0;
							if (gameObject == (UnityEngine.Object)num4 && (object)gameObject != null)
							{
								IsComplete = true;
								Repeat = num2;
								Remove(this);
								if ((_destroyTarget ? 1 : 0) == num2 || _target == null)
								{
									return;
								}
							}
						}
					}
				}
				if ((IsComplete ? 1 : 0) != num2)
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
						if ((_destroyTarget ? 1 : 0) == num2)
						{
							return;
						}
						object target2 = _target;
						if (target2 != null)
						{
							int num5 = 0;
							if (target2 != null)
							{
								int num6 = 0;
							}
						}
						return;
					}
					FrameCount = num2;
					if ((_useFrame ? 1 : 0) != num2)
					{
					}
					int num7 = 0;
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					int num8 = Repeat;
					_startTime = realtimeSinceStartup;
					float num9 = (_startAndDelayTime = _delay);
					IsComplete = (byte)num2 != 0;
					if (num8 > 0)
					{
						int num10 = (Repeat = num8 - 1);
					}
					TweenDelegate onRepeat = OnRepeat;
					if (onRepeat == null)
					{
						goto IL_0136;
					}
					object onRepeatParam = OnRepeatParam;
					onRepeat(this, onRepeatParam);
				}
				num11 = 0;
				goto IL_0136;
				IL_0136:
				if ((_useFrame ? 1 : 0) != num2)
				{
					int num12 = FrameCount;
					num12 = (FrameCount = num12 + 1);
				}
				int num13 = 0;
				num14 = (CurrentTime = Time.realtimeSinceStartup);
				num15 = Duration;
			}
			while (num14 >= num15 || (float)num11 >= num14);
			bool isUpdateFrame = _isUpdateFrame;
			if ((_isStartFrame ? 1 : 0) == num2)
			{
				if (isUpdateFrame)
				{
					goto IL_01aa;
				}
				_isStartFrame = true;
			}
			if (isUpdateFrame)
			{
				_isStartFrame = (byte)num2 != 0;
			}
			goto IL_01aa;
			IL_01aa:
			eEaseType ease = _ease;
			int num16 = 0;
			Ratio = num16;
			int num17 = 0;
			Ratio = num17;
			int num18 = 0;
			Ratio = num18;
			int num19 = 0;
			Ratio = num19;
			int num20 = 0;
			Ratio = num20;
			int num21 = 0;
			Ratio = num21;
			int num22 = 0;
			Ratio = num22;
			int num23 = 0;
			Ratio = num23;
			int num24 = 0;
			Ratio = num24;
			int num25 = 0;
			Ratio = num25;
			int num26 = 0;
			Ratio = num26;
			int num27 = 0;
			Ratio = num27;
			int num28 = 0;
			Ratio = num28;
			int num29 = 0;
			Ratio = num29;
			int num30 = 0;
			Ratio = num30;
			int num31 = 0;
			Ratio = num31;
			int num32 = 0;
			Ratio = num32;
			int num33 = 0;
			Ratio = num33;
			Ratio = num33;
			int num34 = 0;
			Ratio = num34;
			int num35 = 0;
			Ratio = num35;
			int num36 = 0;
			Ratio = num36;
			int num37 = 0;
			Ratio = num37;
			int num38 = 0;
			Ratio = num38;
			int num39 = 0;
			Ratio = num39;
			int num40 = 0;
			Ratio = num40;
			int num41 = 0;
			Ratio = num41;
			int num42 = 0;
			Ratio = num42;
			int num43 = 0;
			Ratio = num43;
			int num44 = 0;
			Ratio = num44;
			int num45 = 0;
			Ratio = num45;
			int num46 = 0;
			Ratio = num46;
			int num47 = 0;
			Ratio = num47;
			int num48 = 0;
			Ratio = num48;
			int num49 = 0;
			Ratio = num49;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60036AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F15EA0", Offset = "0x3F148A0", VA = "0x183F15EA0")]
		private void ChangeBezierFactor(float n)
		{
			//IL_0032: Expected O, but got I4
			object target = _target;
			bool flag = default(bool);
			if (target != null && target != null && flag)
			{
				float[,] beziers = _beziers;
				if (!flag)
				{
				}
				float num = beziers[1];
				int num2 = 0;
				RectTransform rectTransform = default(RectTransform);
				if (rectTransform != (UnityEngine.Object)num2)
				{
					throw new NullReferenceException();
				}
				int num3 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F16240", Offset = "0x3F14C40", VA = "0x183F16240")]
		private void ChangePhysicsFactor(float n)
		{
			//IL_0038: Expected O, but got F4
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected F4, but got Unknown
			//IL_006e: Expected O, but got F4
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected F4, but got Unknown
			//IL_007c: Expected O, but got I4
			//IL_0171: Expected O, but got F4
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected F4, but got Unknown
			//IL_0191: Expected O, but got F4
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected F4, but got Unknown
			//IL_01ec: Expected O, but got F4
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected F4, but got Unknown
			object target = _target;
			if (target == null || target == null)
			{
				return;
			}
			float num = CurrentTime;
			if (_isBackward)
			{
			}
			float num2 = num * 0.001f;
			float physicsFriction = _physicsFriction;
			float physicsTimeScale = ((TweenMax)num2)._physicsTimeScale;
			float num3 = /*Error near IL_0039: Stack underflow*/* physicsTimeScale;
			if (!_isBackward)
			{
				Physics2DProp physicsX = _physicsX;
				float num4 = num3 * 0.5f;
				float acceleration = _physicsY.acceleration;
				physicsFriction = num3;
				float acceleration2 = ((Physics2DProp)num4).acceleration;
				float num5 = /*Error near IL_006f: Stack underflow*/* acceleration2;
				int num6 = 0;
				RectTransform rectTransform = default(RectTransform);
				if (!(rectTransform != (UnityEngine.Object)num6))
				{
					int num7 = 0;
					return;
				}
			}
			if ((long)(IntPtr)typeof(UnityEngine.Object).TypeHandle > 0L)
			{
				Physics2DProp physicsX2 = _physicsX;
				float num8 = (physicsX2.value = physicsX2.value);
				Physics2DProp physicsY = _physicsY;
				float num9 = (physicsY.value = physicsY.v);
				Physics2DProp physicsX3 = _physicsX;
				float num10 = (physicsX3.v = physicsX3.v);
				Physics2DProp physicsY2 = _physicsY;
				float num11 = (physicsY2.v = physicsY2.v);
				Physics2DProp physicsX4 = _physicsX;
				float num12 = (physicsX4.v = physicsX4.v);
				Physics2DProp physicsY3 = _physicsY;
				float num13 = (physicsY3.v = physicsY3.v);
				Physics2DProp physicsX5 = _physicsX;
				float num14 = (physicsX5.v = physicsX5.a);
				Physics2DProp physicsY4 = _physicsY;
				float num15 = (physicsY4.v = physicsY4.a);
				Physics2DProp physicsX6 = _physicsX;
				float v = ((Physics2DProp)_physicsFriction).v;
				float num16 = (physicsX6.v = /*Error near IL_0172: Stack underflow*/* v);
				Physics2DProp physicsY5 = _physicsY;
				float physicsFriction2 = ((TweenMax)physicsY5.v)._physicsFriction;
				float num17 = (physicsY5.v = /*Error near IL_0192: Stack underflow*/* physicsFriction2);
				Physics2DProp physicsX7 = _physicsX;
				float num18 = (physicsX7.value = physicsX7.v);
				Physics2DProp physicsY6 = _physicsY;
				float num19 = (physicsY6.value = physicsY6.value);
			}
			Physics2DProp physicsX8 = _physicsX;
			float value = _physicsY.value;
			float v2 = ((Physics2DProp)n).v;
			float num20 = /*Error near IL_01ed: Stack underflow*/* v2;
			bool flag = default(bool);
			if (!flag)
			{
				int num21 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C380", Offset = "0x3F1AD80", VA = "0x183F1C380", Slot = "23")]
		public void Kill()
		{
			int num = 0;
			IsComplete = true;
			Repeat = num;
			Remove(this);
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

		[Cpp2IlInjected.Token(Token = "0x60036AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F18950", Offset = "0x3F17350", VA = "0x183F18950")]
		protected void InitBezierProp(object target, float[,] beziers)
		{
			//Discarded unreachable code: IL_00af
			//IL_0019: Expected O, but got I4
			//IL_0083: Expected F4, but got O
			if (target == null || target == null)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			RectTransform rectTransform = default(RectTransform);
			if (rectTransform != (UnityEngine.Object)num2)
			{
				Vector2 anchoredPosition = rectTransform.anchoredPosition;
				Vector2 anchoredPosition2 = rectTransform.anchoredPosition;
				if (_isBackward)
				{
					float[] bezierProp = _bezierProp;
					int length = bezierProp.Length;
					float num3 = (beziers[0] = bezierProp[0]);
					float num4 = (beziers[0] = _bezierProp[0]);
					Vector2 anchoredPosition3 = rectTransform.anchoredPosition;
					beziers[0] = (float)anchoredPosition3;
					Vector2 anchoredPosition4 = rectTransform.anchoredPosition;
				}
				float num5 = beziers[0];
				float num6 = beziers[0];
				float num7 = beziers[num];
				_beziers = (float[,])anchoredPosition2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F18EC0", Offset = "0x3F178C0", VA = "0x183F18EC0")]
		private void InitPhysics2dProp(object vars)
		{
			//Discarded unreachable code: IL_023c
			object target = _target;
			if (target == null || target == null)
			{
				return;
			}
			PropertyInfo[] properties = vars.GetType().GetProperties();
			int num = 0;
			int num2 = 0;
			int length = properties.Length;
			float physicsTimeScale = default(float);
			float num6 = default(float);
			float num7 = default(float);
			float num3 = default(float);
			float num8;
			if (num < length)
			{
				string name = properties[num2].Name;
				if (name != null)
				{
					object value4 = default(object);
					if ((long)name > 2029757373)
					{
						object value2 = default(object);
						if ((long)name > 3124789842L)
						{
							object value = default(object);
							if ((long)name == 3732656288L)
							{
								if (!string.Equals(name, "AccelerationAngle"))
								{
									goto IL_01d0;
								}
								value = properties[num2].GetValue(vars);
								num3 = Convert.ToSingle(value);
								num2++;
							}
							if ((long)value != 4108661723L || value == null)
							{
								goto IL_01d0;
							}
							value2 = properties[num2].GetValue(vars);
							float num4 = Convert.ToSingle(value2);
							num2++;
						}
						object value3 = default(object);
						if ((long)value2 == 2731115230L)
						{
							if (value2 == null)
							{
								goto IL_01d0;
							}
							value3 = properties[num2].GetValue(vars);
							physicsTimeScale = Convert.ToSingle(value3);
							num2++;
						}
						if ((long)value3 != 3124789842L || value3 == null)
						{
							goto IL_01d0;
						}
						value4 = properties[num2].GetValue(vars);
						float num5 = Convert.ToSingle(value4);
						num2++;
					}
					object value5 = default(object);
					if ((long)value4 == 86852581)
					{
						if (value4 == null)
						{
							goto IL_01d0;
						}
						value5 = properties[num2].GetValue(vars);
						num6 = Convert.ToSingle(value5);
						num2++;
					}
					object value6 = default(object);
					if ((long)value5 == 969184184)
					{
						if (value5 == null)
						{
							goto IL_01d0;
						}
						value6 = properties[num2].GetValue(vars);
						num7 = Convert.ToSingle(value6);
						num2++;
					}
					if ((long)value6 == 2029757373 && value6 != null)
					{
						num8 = Convert.ToSingle(properties[num2].GetValue(vars));
					}
				}
				goto IL_01d0;
			}
			goto IL_01d6;
			IL_01d6:
			num8 = num3;
			if (float.IsNaN(num8))
			{
				num3 = num7;
			}
			num8 = num6;
			if (!float.IsNaN(num8))
			{
				num8 = num6;
			}
			_physicsTimeScale = physicsTimeScale;
			_stepsPerTimeUnit = 60;
			RectTransform rectTransform = default(RectTransform);
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			int stepsPerTimeUnit = _stepsPerTimeUnit;
			Physics2DProp physicsX = default(Physics2DProp);
			_physicsX = physicsX;
			Vector2 anchoredPosition2 = rectTransform.anchoredPosition;
			int stepsPerTimeUnit2 = _stepsPerTimeUnit;
			Physics2DProp physicsY = default(Physics2DProp);
			_physicsY = physicsY;
			return;
			IL_01d0:
			num2++;
			goto IL_01d6;
		}

		[Cpp2IlInjected.Token(Token = "0x60036AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F20070", Offset = "0x3F1EA70", VA = "0x183F20070")]
		static TweenMax()
		{
			tweens = (List<ITween>)(object)new HashSet<T>();
		}
	}
}
