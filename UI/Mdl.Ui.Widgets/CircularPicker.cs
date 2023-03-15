using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Gestures;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200096B")]
	public class CircularPicker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200096C")]
		public delegate void ValueChangedDelegate(float angle, float distance, bool onRelease);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037EE")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40037EF")]
		public float maxDistance = 100f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037F0")]
		public RectTransform knob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40037F1")]
		private float _angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40037F2")]
		private float _distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40037F3")]
		private float _lastAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40037F4")]
		private float _lastDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40037F6")]
		private RectTransform _rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40037F7")]
		private TouchGesture _touch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40037F8")]
		private bool _movingKnob;

		[Cpp2IlInjected.Token(Token = "0x1700080D")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6003B41")]
			[Cpp2IlInjected.Address(RVA = "0x1001560", Offset = "0xFFFF60", VA = "0x181001560")]
			get
			{
				//Discarded unreachable code: IL_0009
				RectTransform rect = _rect;
				float result = default(float);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080E")]
		public float Angle
		{
			[Cpp2IlInjected.Token(Token = "0x6003B42")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get
			{
				return _angle;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B43")]
			[Cpp2IlInjected.Address(RVA = "0x1001650", Offset = "0x1000050", VA = "0x181001650")]
			set
			{
				//IL_000e: Expected F4, but got I4
				int num = 0;
				float angle = Mathf.Clamp(value, num, 360f);
				ValueChangedDelegate onValueChanged = this.OnValueChanged;
				_angle = angle;
				if (onValueChanged != null)
				{
					float distance = _distance;
					int onRelease = 0;
					onValueChanged(angle, distance, (byte)onRelease != 0);
				}
				UpdateKnobPosition();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700080F")]
		public float Distance
		{
			[Cpp2IlInjected.Token(Token = "0x6003B44")]
			[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39000", VA = "0x180E3A600")]
			get
			{
				return _distance;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B45")]
			[Cpp2IlInjected.Address(RVA = "0x10016B0", Offset = "0x10000B0", VA = "0x1810016B0")]
			set
			{
				float max = maxDistance;
				float min = minDistance;
				float num = Mathf.Clamp(value, min, max);
				ValueChangedDelegate onValueChanged = this.OnValueChanged;
				_distance = num;
				if (onValueChanged != null)
				{
					float angle = _angle;
					int onRelease = 0;
					max = num;
					onValueChanged(angle, max, (byte)onRelease != 0);
				}
				UpdateKnobPosition();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007C")]
		public event ValueChangedDelegate OnValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6003B46")]
			[Cpp2IlInjected.Address(RVA = "0x10014C0", Offset = "0xFFFEC0", VA = "0x1810014C0")]
			[CompilerGenerated]
			add
			{
				ValueChangedDelegate onValueChanged = this.OnValueChanged;
				Delegate @delegate = Delegate.Combine(onValueChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onValueChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003B47")]
			[Cpp2IlInjected.Address(RVA = "0x10015B0", Offset = "0xFFFFB0", VA = "0x1810015B0")]
			[CompilerGenerated]
			remove
			{
				ValueChangedDelegate onValueChanged = this.OnValueChanged;
				Delegate @delegate = Delegate.Remove(onValueChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onValueChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B48")]
		[Cpp2IlInjected.Address(RVA = "0x1000F10", Offset = "0xFFF910", VA = "0x181000F10")]
		private void Awake()
		{
			//IL_001a: Expected O, but got I4
			RectTransform rectTransform = (_rect = GetComponent<RectTransform>());
			int num = default(int);
			TouchGesture touch = new TouchGesture(_rect, (Camera)num);
			num = 0;
			_touch = touch;
			UpdateKnobPosition();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B49")]
		[Cpp2IlInjected.Address(RVA = "0x10012E0", Offset = "0xFFFCE0", VA = "0x1810012E0")]
		private void Update()
		{
			//Discarded unreachable code: IL_00d1
			//IL_00ca: Expected O, but got I4
			TouchGesture touch = _touch;
			int num = 0;
			touch.Update();
			TouchGesture.PhaseType _003CPhase_003Ek__BackingField = _touch.Phase;
			if (_003CPhase_003Ek__BackingField != TouchGesture.PhaseType.Began)
			{
				if (_003CPhase_003Ek__BackingField != TouchGesture.PhaseType.Down)
				{
					while (!_movingKnob)
					{
					}
					float angle = _angle;
					_movingKnob = false;
					if (!_movingKnob)
					{
						while (!_movingKnob)
						{
						}
					}
					ValueChangedDelegate onValueChanged = this.OnValueChanged;
					while (onValueChanged == null)
					{
					}
					float distance = _distance;
					onValueChanged(angle, distance, onRelease: true);
					return;
				}
				if (!_movingKnob)
				{
					return;
				}
			}
			else
			{
				RectTransform rect = _rect;
				RectTransform rect2 = _rect;
				float num2 = default(float);
				float num3 = num2 * 0.5f;
				float num4 = (_lastAngle = _angle);
				float num5 = (_lastDistance = _distance);
				TouchGesture touch2 = _touch;
				_movingKnob = true;
			}
			UpdateDistanceAndAngle((Vector2)num);
			UpdateKnobPosition();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B4A")]
		[Cpp2IlInjected.Address(RVA = "0x1000FC0", Offset = "0xFFF9C0", VA = "0x181000FC0")]
		private void UpdateDistanceAndAngle(Vector2 localPos)
		{
			//Discarded unreachable code: IL_00c2
			//IL_008c: Expected F4, but got I4
			RectTransform rect = _rect;
			RectTransform rect2 = _rect;
			float num = default(float);
			float num2 = num * 0.5f;
			float min = minDistance;
			float num3 = maxDistance;
			num2 = num3;
			num2 = num;
			float num4 = Mathf.Clamp(num2, min, num3);
			ValueChangedDelegate onValueChanged = this.OnValueChanged;
			_distance = num4;
			if (onValueChanged != null)
			{
				float angle = _angle;
				int onRelease = 0;
				num3 = num4;
				onValueChanged(angle, num3, (byte)onRelease != 0);
			}
			UpdateKnobPosition();
			Vector2 pos = default(Vector2);
			Angle angle2 = Trigo.PositionToAngle(pos);
			int num5 = 0;
			float value = default(float);
			float angle3 = Mathf.Clamp(value, num5, 360f);
			ValueChangedDelegate onValueChanged2 = this.OnValueChanged;
			_angle = angle3;
			if (onValueChanged2 != null)
			{
				float distance = _distance;
				int onRelease2 = 0;
				onValueChanged2(angle3, distance, (byte)onRelease2 != 0);
			}
			UpdateKnobPosition();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B4B")]
		[Cpp2IlInjected.Address(RVA = "0x1001160", Offset = "0xFFFB60", VA = "0x181001160")]
		private void UpdateKnobPosition()
		{
			//Discarded unreachable code: IL_0023
			RectTransform rect = _rect;
			RectTransform rect2 = _rect;
			RectTransform rectTransform = knob;
			float num = default(float);
			float num2 = num * (float)Math.PI;
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B4C")]
		[Cpp2IlInjected.Address(RVA = "0x10014B0", Offset = "0xFFFEB0", VA = "0x1810014B0")]
		public CircularPicker()
		{
		}
	}
}
