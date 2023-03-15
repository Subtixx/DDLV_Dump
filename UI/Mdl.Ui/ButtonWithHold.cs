using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	public class ButtonWithHold : Button, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private bool isHolding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x101")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private bool isPointerDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private float pointerDownTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private float holdTime = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private float _holdingTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private float _interval = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public UnityEvent OnTapAndHold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public UnityEvent OnHolding;

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x114"), Cpp2IlInjected.Token(Token = "0x400069F")]
		public float Interval
		{
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xA6CA90", Offset = "0xA6B490", VA = "0x180A6CA90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0xA6CAC0", Offset = "0xA6B4C0", VA = "0x180A6CAC0")]
			set;
		} = 0.5f;


		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x118"), Cpp2IlInjected.Token(Token = "0x40006A0")]
		public float AccelerationRate
		{
			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0xA6CA80", Offset = "0xA6B480", VA = "0x180A6CA80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0xA6CAB0", Offset = "0xA6B4B0", VA = "0x180A6CAB0")]
			set;
		} = 0.1f;


		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x11C"), Cpp2IlInjected.Token(Token = "0x40006A1")]
		public float AccelerationLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0xA6CA70", Offset = "0xA6B470", VA = "0x180A6CA70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0xA6CAA0", Offset = "0xA6B4A0", VA = "0x180A6CAA0")]
			set;
		} = 0.25f;


		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8C0", Offset = "0xA6B2C0", VA = "0x180A6C8C0", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
			base.OnPointerDown(eventData);
			isPointerDown = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8E0", Offset = "0xA6B2E0", VA = "0x180A6C8E0", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
			base.OnPointerUp(eventData);
			isHolding = false;
			pointerDownTimer = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8A0", Offset = "0xA6B2A0", VA = "0x180A6C8A0")]
		private void HoldReset()
		{
			isPointerDown = false;
			pointerDownTimer = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6C910", Offset = "0xA6B310", VA = "0x180A6C910")]
		private void Update()
		{
			//IL_0063: Expected F4, but got I4
			//IL_009d: Expected F4, but got I4
			//IL_00a5: Expected F4, but got I4
			if (!isPointerDown)
			{
				if (isHolding)
				{
					int num = 0;
					float deltaTime = Time.deltaTime;
					float interval = _interval;
					_holdingTimer = deltaTime;
					OnHolding?.Invoke();
					float b = AccelerationLimit;
					deltaTime = interval;
					float interval2 = Mathf.Max(deltaTime, b);
					int num2 = 0;
					_interval = interval2;
					_holdingTimer = num2;
				}
			}
			else
			{
				int num3 = 0;
				float num4 = (pointerDownTimer = Time.deltaTime);
				OnTapAndHold?.Invoke();
				float interval3 = Interval;
				int num5 = 0;
				pointerDownTimer = num5;
				_holdingTimer = num5;
				isHolding = true;
				_interval = interval3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA30", Offset = "0xA6B430", VA = "0x180A6CA30")]
		public ButtonWithHold()
		{
		}
	}
}
