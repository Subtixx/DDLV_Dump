using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Motion;
using Mdl.Ui.Widgets;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200027E")]
	public class SlideInOut : Introducable
	{
		[Cpp2IlInjected.Token(Token = "0x200027F")]
		public enum SlideAxisType
		{
			[Cpp2IlInjected.Token(Token = "0x4000B58")]
			Vertical,
			[Cpp2IlInjected.Token(Token = "0x4000B59")]
			Horizontal
		}

		[Cpp2IlInjected.Token(Token = "0x2000280")]
		public enum SlideState
		{
			[Cpp2IlInjected.Token(Token = "0x4000B5B")]
			Opening,
			[Cpp2IlInjected.Token(Token = "0x4000B5C")]
			Closing
		}

		[Cpp2IlInjected.Token(Token = "0x2000281")]
		public delegate void OutStateDelegate(SlideState s);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B4D")]
		public SlideState CurrentState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000B4E")]
		public float OpeningTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B4F")]
		public float ClosingTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000B50")]
		public float SlideOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000B51")]
		public float ShowStatePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000B52")]
		public float HideStatePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B53")]
		public float OutStatePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000B54")]
		public SlideAxisType SlideAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B55")]
		private Tween<Vector2> _actionTween;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000B56")]
		public OutStateDelegate OnSlideOut;

		[Cpp2IlInjected.Token(Token = "0x170002F3")]
		private RectTransform rectTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000FE1")]
			[Cpp2IlInjected.Address(RVA = "0x15F5CC0", Offset = "0x15F46C0", VA = "0x1815F5CC0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.GetComponent<RectTransform>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE2")]
		[Cpp2IlInjected.Address(RVA = "0x15F56C0", Offset = "0x15F40C0", VA = "0x1815F56C0")]
		public unsafe void Open()
		{
			//Discarded unreachable code: IL_0116
			//IL_004b: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			StopAllCoroutines();
			Tween<Vector2> actionTween = _actionTween;
			int num = 0;
			if (actionTween != null)
			{
				Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(OnMoveOutFinished);
				((Tween<T>)(object)actionTween).remove_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
				Tween<Vector2> actionTween2 = _actionTween;
				Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(OnTweenUpdated);
				((Tween<T>)(object)actionTween2).remove_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
				_actionTween = (Tween<Vector2>)num;
			}
			CurrentState = (SlideState)num;
			if (SlideAxis == (SlideAxisType)num)
			{
				Vector2 anchoredPosition = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
			}
			float outStatePosition = OutStatePosition;
			Vector2 anchoredPosition2 = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
			Vector2 anchoredPosition3 = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
			Vector2 anchoredPosition4 = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
			int num2 = default(int);
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector2, Vector2, float, Vector2>*/)(&Vector2.Lerp));
			num2 = 0;
			int num3 = default(int);
			EasingFunction easingFunction = new EasingFunction(num3, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num3 = 0;
			Tween<Vector2> actionTween3 = default(Tween<Vector2>);
			_actionTween = actionTween3;
			Tween<Vector2> actionTween4 = _actionTween;
			Tween<Vector2>.FinishEventHandler finishEventHandler2 = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(OnMoveOutFinished);
			((Tween<T>)(object)actionTween4).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler2);
			Tween<Vector2> actionTween5 = _actionTween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler2 = (Tween<Vector2>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(OnTweenUpdated);
			((Tween<T>)(object)actionTween5).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE3")]
		[Cpp2IlInjected.Address(RVA = "0x15F5D10", Offset = "0x15F4710", VA = "0x1815F5D10")]
		[IteratorStateMachine(typeof(_003CopenCoroutine_003Ed__16))]
		private IEnumerator openCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CopenCoroutine_003Ed__16 _003CopenCoroutine_003Ed__ = new _003CopenCoroutine_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CopenCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE4")]
		[Cpp2IlInjected.Address(RVA = "0x15F4CD0", Offset = "0x15F36D0", VA = "0x1815F4CD0")]
		public unsafe void Close()
		{
			//Discarded unreachable code: IL_0104
			//IL_00a6: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			StopAllCoroutines();
			Tween<Vector2> actionTween = _actionTween;
			if (actionTween != null)
			{
				Tween<Vector2>.FinishEventHandler finishEventHandler = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(OnMoveOutFinished);
				((Tween<T>)(object)actionTween).remove_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
				Tween<Vector2> actionTween2 = _actionTween;
				Tween<Vector2>.UpdateEventHandler updateEventHandler = (Tween<Vector2>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(OnTweenUpdated);
				((Tween<T>)(object)actionTween2).remove_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			}
			if (SlideAxis == SlideAxisType.Vertical)
			{
				Vector2 anchoredPosition = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
			}
			float outStatePosition = OutStatePosition;
			Vector2 anchoredPosition2 = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
			Vector2 anchoredPosition3 = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
			Vector2 anchoredPosition4 = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
			int num = default(int);
			Tween<Vector2>.InterpolationFunction interpolationFunction = (Tween<Vector2>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector2, Vector2, float, Vector2>*/)(&Vector2.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num2 = 0;
			Tween<Vector2> actionTween3 = default(Tween<Vector2>);
			_actionTween = actionTween3;
			Tween<Vector2> actionTween4 = _actionTween;
			Tween<Vector2>.FinishEventHandler finishEventHandler2 = (Tween<Vector2>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(OnMoveOutFinished);
			((Tween<T>)(object)actionTween4).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler2);
			Tween<Vector2> actionTween5 = _actionTween;
			Tween<Vector2>.UpdateEventHandler updateEventHandler2 = (Tween<Vector2>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(OnTweenUpdated);
			((Tween<T>)(object)actionTween5).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE5")]
		[Cpp2IlInjected.Address(RVA = "0x15F5300", Offset = "0x15F3D00", VA = "0x1815F5300")]
		private void OnMoveOutFinished()
		{
			//Discarded unreachable code: IL_00e1
			OutStateDelegate onSlideOut = OnSlideOut;
			if (onSlideOut != null)
			{
				SlideState currentState = CurrentState;
				onSlideOut(currentState);
			}
			SlideState currentState2 = CurrentState;
			_003CopenCoroutine_003Ed__16 _003CopenCoroutine_003Ed__ = default(_003CopenCoroutine_003Ed__16);
			if (currentState2 == SlideState.Opening)
			{
				if (SlideAxis == (SlideAxisType)currentState2)
				{
					Vector2 anchoredPosition = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
				}
				float showStatePosition = ShowStatePosition;
				Vector2 anchoredPosition2 = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
				Vector2 anchoredPosition3 = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
				int _003C_003E1__state = default(int);
				_003CopenCoroutine_003Ed__ = new _003CopenCoroutine_003Ed__16(_003C_003E1__state);
				_003C_003E1__state = 0;
			}
			if ((long)_003CopenCoroutine_003Ed__ == 1)
			{
				int num = 0;
				if (SlideAxis == (SlideAxisType)num)
				{
					Vector2 anchoredPosition4 = this.rectTransform.anchoredPosition;
				}
				float hideStatePosition = HideStatePosition;
				RectTransform rectTransform = default(RectTransform);
				Vector2 anchoredPosition5 = rectTransform.anchoredPosition;
				float showStatePosition = hideStatePosition;
				hideStatePosition = showStatePosition;
				Vector2 anchoredPosition6 = base.gameObject.GetComponent<RectTransform>().anchoredPosition;
				int _003C_003E1__state2 = default(int);
				_003CcloseCoroutine_003Ed__19 _003CcloseCoroutine_003Ed__ = new _003CcloseCoroutine_003Ed__19(_003C_003E1__state2);
				_003C_003E1__state2 = 0;
				_003CcloseCoroutine_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CcloseCoroutine_003Ed__);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE6")]
		[Cpp2IlInjected.Address(RVA = "0x15F5C50", Offset = "0x15F4650", VA = "0x1815F5C50")]
		[IteratorStateMachine(typeof(_003CcloseCoroutine_003Ed__19))]
		private IEnumerator closeCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CcloseCoroutine_003Ed__19 _003CcloseCoroutine_003Ed__ = new _003CcloseCoroutine_003Ed__19(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CcloseCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE7")]
		[Cpp2IlInjected.Address(RVA = "0x15F5640", Offset = "0x15F4040", VA = "0x1815F5640")]
		private void OnTweenUpdated(Vector2 value, float progress)
		{
			//Discarded unreachable code: IL_000d
			RectTransform component = base.gameObject.GetComponent<RectTransform>();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE8")]
		[Cpp2IlInjected.Address(RVA = "0x15F5BE0", Offset = "0x15F45E0", VA = "0x1815F5BE0")]
		private void Update()
		{
			//IL_0029: Expected O, but got I8
			Tween<Vector2> actionTween = _actionTween;
			if (actionTween != null)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				int reverse = 0;
				if (!((Tween<T>)(object)actionTween).Play(deltaTime, (byte)reverse != 0))
				{
					_actionTween = (Tween<Vector2>)0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FE9")]
		[Cpp2IlInjected.Address(RVA = "0x15F5200", Offset = "0x15F3C00", VA = "0x1815F5200", Slot = "4")]
		[AsyncStateMachine(typeof(_003CIntroduce_003Ed__22))]
		public override Task Introduce()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FEA")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public SlideInOut()
		{
		}
	}
}
