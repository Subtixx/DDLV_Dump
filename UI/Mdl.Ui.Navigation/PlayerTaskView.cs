using System;
using System.Xml;
using Cpp2IlInjected;
using Mdl.Motion;
using Mdl.Navigation;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x200095B")]
	public class PlayerTaskView : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037A3")]
		private float _rOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40037A4")]
		private Rect _bgBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40037A5")]
		private float _duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40037A6")]
		[SerializeField]
		private GameObject _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40037A7")]
		[SerializeField]
		private Image _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40037A8")]
		[SerializeField]
		private Button _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40037A9")]
		[SerializeField]
		private GameObject _mcVfxIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40037AA")]
		[SerializeField]
		private GameObject _mcVfxContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40037AB")]
		[SerializeField]
		private GameObject _mcVfxEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40037AC")]
		private RectTransform _mcVfxIndicatorRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40037AD")]
		private Tween<Vector2> tween;

		[Cpp2IlInjected.Token(Token = "0x17000807")]
		public Button Button
		{
			[Cpp2IlInjected.Token(Token = "0x6003AE6")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _button;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE7")]
		[Cpp2IlInjected.Address(RVA = "0xE10D60", Offset = "0xE0F760", VA = "0x180E10D60")]
		public void Init(PlayerTaskDefinition definition)
		{
			//Discarded unreachable code: IL_000d
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)_icon).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE8")]
		[Cpp2IlInjected.Address(RVA = "0xE10D90", Offset = "0xE0F790", VA = "0x180E10D90")]
		private void OnDestroy()
		{
			TweenMax.KillAllByCancelationToken(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE9")]
		[Cpp2IlInjected.Address(RVA = "0xE10E00", Offset = "0xE0F800", VA = "0x180E10E00")]
		public unsafe void PlayAnimation()
		{
			//Discarded unreachable code: IL_007b
			//IL_003f: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			Transform transform = _mcBackground.transform;
			GameObject mcVfxIndicator = _mcVfxIndicator;
			_rOffset = 40f;
			_duration = 0.15f;
			Transform transform2 = mcVfxIndicator.transform;
			int num = 0;
			if ((object)transform2 != null)
			{
			}
			_mcVfxIndicatorRect = (RectTransform)num;
			RectTransform mcVfxIndicatorRect = _mcVfxIndicatorRect;
			TweenDelegate onUpdate = new TweenDelegate(this, (IntPtr)__ldftn(PlayerTaskView.PlayParticle));
			var vars = (_003C_003Ef__AnonymousType28<int, TweenDelegate>)(object)new
			{
				Repeat = (_003CRepeat_003Ej__TPar)(-1),
				OnUpdate = (_003COnUpdate_003Ej__TPar)onUpdate
			};
			TweenMax tweenMax = TweenMax.To(this, 1f, vars, int.MinValue, this);
			PlayTop();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AEA")]
		[Cpp2IlInjected.Address(RVA = "0xE10D90", Offset = "0xE0F790", VA = "0x180E10D90")]
		public void KillAnimation()
		{
			TweenMax.KillAllByCancelationToken(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AEB")]
		[Cpp2IlInjected.Address(RVA = "0xE13030", Offset = "0xE11A30", VA = "0x180E13030")]
		private void Update()
		{
			Tween<Vector2> tween = this.tween;
			if (tween != null)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				int reverse = 0;
				bool flag = ((Tween<T>)(object)tween).Play(deltaTime, (byte)reverse != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AEC")]
		[Cpp2IlInjected.Address(RVA = "0xE128E0", Offset = "0xE112E0", VA = "0x180E128E0")]
		private unsafe void PlayTop()
		{
			//Discarded unreachable code: IL_0065
			//IL_000c: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			int num = default(int);
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector2, Vector2, float, Vector2>*/)(&Vector2.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num2 = 0;
			Tween<Vector2> tween = default(Tween<Vector2>);
			this.tween = tween;
			Tween<Vector2> tween2 = this.tween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate(Vector2 pos, float progress)
			{
				//Discarded unreachable code: IL_000d
				_mcVfxIndicatorRect.anchoredPosition = pos;
			};
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Vector2> tween3 = this.tween;
			Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(PlayTopRight);
			((Tween<T>)(object)tween3).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AED")]
		[Cpp2IlInjected.Address(RVA = "0xE12630", Offset = "0xE11030", VA = "0x180E12630")]
		private unsafe void PlayTopRight()
		{
			//Discarded unreachable code: IL_0062
			//IL_0019: Expected O, but got I4
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(bezier);
			int num = default(int);
			EasingFunction easingFunction = new EasingFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num = 0;
			Tween<Vector2> tween = default(Tween<Vector2>);
			this.tween = tween;
			Tween<Vector2> tween2 = this.tween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate(Vector2 pos, float progress)
			{
				//Discarded unreachable code: IL_000d
				_mcVfxIndicatorRect.anchoredPosition = pos;
			};
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Vector2> tween3 = this.tween;
			Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(PlayRight);
			((Tween<T>)(object)tween3).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
			[Cpp2IlInjected.Token(Token = "0x6003AF8")]
			[Cpp2IlInjected.Address(RVA = "0xE12F10", Offset = "0xE11910", VA = "0x180E12F10")]
			Vector2 bezier(Vector2 a, Vector2 b, float p)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AEE")]
		[Cpp2IlInjected.Address(RVA = "0xE120D0", Offset = "0xE10AD0", VA = "0x180E120D0")]
		private unsafe void PlayRight()
		{
			//Discarded unreachable code: IL_0065
			//IL_000c: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			int num = default(int);
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector2, Vector2, float, Vector2>*/)(&Vector2.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num2 = 0;
			Tween<Vector2> tween = default(Tween<Vector2>);
			this.tween = tween;
			Tween<Vector2> tween2 = this.tween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate(Vector2 pos, float progress)
			{
				//Discarded unreachable code: IL_000d
				_mcVfxIndicatorRect.anchoredPosition = pos;
			};
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Vector2> tween3 = this.tween;
			Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(PlayBottomRight);
			((Tween<T>)(object)tween3).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AEF")]
		[Cpp2IlInjected.Address(RVA = "0xE11340", Offset = "0xE0FD40", VA = "0x180E11340")]
		private unsafe void PlayBottomRight()
		{
			//Discarded unreachable code: IL_0062
			//IL_0019: Expected O, but got I4
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(bezier);
			int num = default(int);
			EasingFunction easingFunction = new EasingFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num = 0;
			Tween<Vector2> tween = default(Tween<Vector2>);
			this.tween = tween;
			Tween<Vector2> tween2 = this.tween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate(Vector2 pos, float progress)
			{
				//Discarded unreachable code: IL_000d
				_mcVfxIndicatorRect.anchoredPosition = pos;
			};
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Vector2> tween3 = this.tween;
			Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(PlayBottom);
			((Tween<T>)(object)tween3).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
			[Cpp2IlInjected.Token(Token = "0x6003AFB")]
			[Cpp2IlInjected.Address(RVA = "0xE12CD0", Offset = "0xE116D0", VA = "0x180E12CD0")]
			Vector2 bezier(Vector2 a, Vector2 b, float p)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF0")]
		[Cpp2IlInjected.Address(RVA = "0xE115F0", Offset = "0xE0FFF0", VA = "0x180E115F0")]
		private unsafe void PlayBottom()
		{
			//Discarded unreachable code: IL_0065
			//IL_000c: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			int num = default(int);
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector2, Vector2, float, Vector2>*/)(&Vector2.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num2 = 0;
			Tween<Vector2> tween = default(Tween<Vector2>);
			this.tween = tween;
			Tween<Vector2> tween2 = this.tween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate(Vector2 pos, float progress)
			{
				//Discarded unreachable code: IL_000d
				_mcVfxIndicatorRect.anchoredPosition = pos;
			};
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Vector2> tween3 = this.tween;
			Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(PlayBottomLeft);
			((Tween<T>)(object)tween3).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF1")]
		[Cpp2IlInjected.Address(RVA = "0xE11090", Offset = "0xE0FA90", VA = "0x180E11090")]
		private unsafe void PlayBottomLeft()
		{
			//Discarded unreachable code: IL_0062
			//IL_0019: Expected O, but got I4
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(bezier);
			int num = default(int);
			EasingFunction easingFunction = new EasingFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num = 0;
			Tween<Vector2> tween = default(Tween<Vector2>);
			this.tween = tween;
			Tween<Vector2> tween2 = this.tween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate(Vector2 pos, float progress)
			{
				//Discarded unreachable code: IL_000d
				_mcVfxIndicatorRect.anchoredPosition = pos;
			};
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Vector2> tween3 = this.tween;
			Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(PlayLeft);
			((Tween<T>)(object)tween3).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
			[Cpp2IlInjected.Token(Token = "0x6003AFE")]
			[Cpp2IlInjected.Address(RVA = "0xE12BB0", Offset = "0xE115B0", VA = "0x180E12BB0")]
			Vector2 bezier(Vector2 a, Vector2 b, float p)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF2")]
		[Cpp2IlInjected.Address(RVA = "0xE118A0", Offset = "0xE102A0", VA = "0x180E118A0")]
		private unsafe void PlayLeft()
		{
			//Discarded unreachable code: IL_0065
			//IL_000c: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			int num = default(int);
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector2, Vector2, float, Vector2>*/)(&Vector2.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num2 = 0;
			Tween<Vector2> tween = default(Tween<Vector2>);
			this.tween = tween;
			Tween<Vector2> tween2 = this.tween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate(Vector2 pos, float progress)
			{
				//Discarded unreachable code: IL_000d
				_mcVfxIndicatorRect.anchoredPosition = pos;
			};
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Vector2> tween3 = this.tween;
			Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(PlayTopLeft);
			((Tween<T>)(object)tween3).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF3")]
		[Cpp2IlInjected.Address(RVA = "0xE12380", Offset = "0xE10D80", VA = "0x180E12380")]
		private unsafe void PlayTopLeft()
		{
			//Discarded unreachable code: IL_0062
			//IL_0019: Expected O, but got I4
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(bezier);
			int num = default(int);
			EasingFunction easingFunction = new EasingFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num = 0;
			Tween<Vector2> tween = default(Tween<Vector2>);
			this.tween = tween;
			Tween<Vector2> tween2 = this.tween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate(Vector2 pos, float progress)
			{
				//Discarded unreachable code: IL_000d
				_mcVfxIndicatorRect.anchoredPosition = pos;
			};
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Vector2> tween3 = this.tween;
			Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(PlayTop);
			((Tween<T>)(object)tween3).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
			[Cpp2IlInjected.Token(Token = "0x6003B01")]
			[Cpp2IlInjected.Address(RVA = "0xE12DF0", Offset = "0xE117F0", VA = "0x180E12DF0")]
			Vector2 bezier(Vector2 a, Vector2 b, float p)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF4")]
		[Cpp2IlInjected.Address(RVA = "0xE11B50", Offset = "0xE10550", VA = "0x180E11B50")]
		private unsafe void PlayParticle()
		{
			//IL_0014: Expected O, but got I4
			TweenDelegate onUpdate = new TweenDelegate(this, (IntPtr)__ldftn(PlayerTaskView.PlayParticle));
			var vars = (_003C_003Ef__AnonymousType28<int, TweenDelegate>)(object)new
			{
				Repeat = (_003CRepeat_003Ej__TPar)(-1),
				OnUpdate = (_003COnUpdate_003Ej__TPar)onUpdate
			};
			TweenMax tweenMax = TweenMax.To(this, 1f, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF5")]
		[Cpp2IlInjected.Address(RVA = "0xE11C50", Offset = "0xE10650", VA = "0x180E11C50")]
		public void PlayParticle(ITween tween, object param)
		{
			//Discarded unreachable code: IL_00ac
			//IL_0058: Expected F4, but got I4
			//IL_0058: Expected F4, but got I4
			//IL_0058: Expected F4, but got I4
			//IL_0062: Expected I4, but got I8
			//IL_0096: Expected O, but got I4
			//IL_0096: Expected O, but got I8
			//IL_00a9: Expected O, but got I8
			RectTransform component = _mcVfxContainer.GetComponent<RectTransform>();
			RectTransform component2 = _mcVfxIndicator.GetComponent<RectTransform>();
			GameObject gameObject = UnityEngine.Object.Instantiate(_mcVfxEmitter, component);
			RectTransform component3 = gameObject.GetComponent<RectTransform>();
			Vector2 anchoredPosition = component2.anchoredPosition;
			Vector2 anchoredPosition2 = component2.anchoredPosition;
			component3.anchoredPosition = anchoredPosition;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Quaternion quaternion = Quaternion.Euler(num, num3, num2);
			ulong num4 = default(ulong);
			gameObject.SetActive((byte)num4 != 0);
			int num5 = 0;
			int num6 = 0;
			TweenDelegate _003C_003E9__27_ = _003C_003Ec._003C_003E9__27_0;
			if (_003C_003E9__27_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(TweenDelegate)delegate
				{
					//Discarded unreachable code: IL_0019
					int num9 = 0;
					uint num10 = default(uint);
					if (num9 < (int)num10)
					{
						num9 += num9;
						num9++;
					}
					if ((object)typeof(UnityEngine.Object).TypeHandle != null)
					{
					}
					int num11 = 0;
				};
			}
			ulong num7 = default(ulong);
			_003C_003Ef__AnonymousType6<float, float, float, float> physics2D = default(_003C_003Ef__AnonymousType6<float, float, float, float>);
			var vars = (_003C_003Ef__AnonymousType29<bool, float, _003C_003Ef__AnonymousType6<float, float, float, float>, TweenDelegate>)(object)new
			{
				UseFrame = (_003CUseFrame_003Ej__TPar)num7,
				Alpha = (_003CAlpha_003Ej__TPar)num6,
				Physics2D = (_003CPhysics2D_003Ej__TPar)physics2D,
				OnComplete = (_003COnComplete_003Ej__TPar)_003C_003E9__27_
			};
			uint tagNum = default(uint);
			ulong num8 = default(ulong);
			TweenMax tweenMax = TweenMax.To(gameObject, 20f, vars, (int)tagNum, num8);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF6")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PlayerTaskView()
		{
		}
	}
}
