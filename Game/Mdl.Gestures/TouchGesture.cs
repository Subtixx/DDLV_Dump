using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Gestures
{
	[Cpp2IlInjected.Token(Token = "0x2000543")]
	public class TouchGesture
	{
		[Cpp2IlInjected.Token(Token = "0x2000544")]
		public enum PhaseType
		{
			[Cpp2IlInjected.Token(Token = "0x40020BF")]
			Up,
			[Cpp2IlInjected.Token(Token = "0x40020C0")]
			Began,
			[Cpp2IlInjected.Token(Token = "0x40020C1")]
			Down,
			[Cpp2IlInjected.Token(Token = "0x40020C2")]
			Ended
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40020BB")]
		private bool _isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40020BC")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40020BD")]
		private RectTransform _zone;

		[Cpp2IlInjected.Token(Token = "0x17000324")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40020B8")]
		public PhaseType Phase
		{
			[Cpp2IlInjected.Token(Token = "0x600176B")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600176C")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000325")]
		public Vector2 LocalPos
		{
			[Cpp2IlInjected.Token(Token = "0x600176D")]
			[Cpp2IlInjected.Address(RVA = "0x13DC500", Offset = "0x13DAF00", VA = "0x1813DC500")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600176E")]
			[Cpp2IlInjected.Address(RVA = "0xF4CB30", Offset = "0xF4B530", VA = "0x180F4CB30")]
			[CompilerGenerated]
			private set
			{
				_003CLocalPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000326")]
		public Vector2 ScreenPos
		{
			[Cpp2IlInjected.Token(Token = "0x600176F")]
			[Cpp2IlInjected.Address(RVA = "0x10680D0", Offset = "0x1066AD0", VA = "0x1810680D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001770")]
			[Cpp2IlInjected.Address(RVA = "0xAC87A0", Offset = "0xAC71A0", VA = "0x180AC87A0")]
			[CompilerGenerated]
			private set
			{
				_003CScreenPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001771")]
		[Cpp2IlInjected.Address(RVA = "0x13DC4B0", Offset = "0x13DAEB0", VA = "0x1813DC4B0")]
		public TouchGesture(RectTransform zone, Camera camera)
		{
			_zone = zone;
			_camera = camera;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001772")]
		[Cpp2IlInjected.Address(RVA = "0x13DC4A0", Offset = "0x13DAEA0", VA = "0x1813DC4A0")]
		public void Update()
		{
			UpdatePc();
		}

		[Cpp2IlInjected.Token(Token = "0x6001773")]
		[Cpp2IlInjected.Address(RVA = "0x13DC220", Offset = "0x13DAC20", VA = "0x1813DC220")]
		private unsafe void UpdatePc()
		{
			//IL_0010: Expected F4, but got I4
			//IL_000b: Expected native int or pointer, but got O
			//IL_0025: Expected F4, but got I4
			//IL_0020: Expected native int or pointer, but got O
			//IL_006d: Expected I4, but got I8
			//IL_007d: Expected I4, but got I8
			//IL_0086: Expected I4, but got I8
			//IL_0097: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			((Vector2*)(IntPtr)ScreenPos)->y = 0f;
			int button = 0;
			Vector2 vector = default(Vector2);
			LocalPos = vector;
			((Vector2*)(IntPtr)LocalPos)->y = 0f;
			if (!Input.GetMouseButtonDown(button) && !Input.GetMouseButtonDown(1))
			{
				if ((!Input.GetMouseButton(0) && !Input.GetMouseButton(1)) || !_isValid)
				{
					if (!Input.GetMouseButtonUp(0) && !Input.GetMouseButtonUp(1))
					{
						Phase = PhaseType.Up;
					}
					_isValid = false;
					Phase = PhaseType.Ended;
				}
				Phase = PhaseType.Down;
			}
			int num3 = 0;
			bool flag = default(bool);
			if (flag)
			{
				Phase = PhaseType.Began;
				_isValid = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001774")]
		[Cpp2IlInjected.Address(RVA = "0x13DBFE0", Offset = "0x13DA9E0", VA = "0x1813DBFE0")]
		private unsafe void UpdateMobile()
		{
			//IL_0013: Expected I4, but got I8
			//IL_0064: Expected I4, but got I8
			//IL_006d: Expected I4, but got I8
			//IL_0082: Expected I4, but got I8
			//IL_009d: Expected F4, but got I4
			//IL_0098: Expected native int or pointer, but got O
			//IL_00a9: Expected F4, but got I4
			//IL_00a4: Expected native int or pointer, but got O
			int num = 0;
			if (Input.touchCount != 1)
			{
				Phase = PhaseType.Up;
				return;
			}
			Touch touch = default(Touch);
			float y = touch.m_RawPosition.y;
			int tapCount = touch.m_TapCount;
			float maximumPossiblePressure = touch.m_maximumPossiblePressure;
			float azimuthAngle = touch.m_AzimuthAngle;
			if (azimuthAngle != 0f)
			{
				if (azimuthAngle != 4E-45f && azimuthAngle != 6E-45f)
				{
					if (!_isValid)
					{
						return;
					}
					Phase = PhaseType.Down;
				}
				Phase = PhaseType.Ended;
				_isValid = false;
			}
			bool flag = default(bool);
			if (flag)
			{
				Phase = PhaseType.Began;
				_isValid = true;
				Vector2 vector = default(Vector2);
				ScreenPos = vector;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				((Vector2*)(IntPtr)LocalPos)->y = 0f;
				Vector2 vector2 = default(Vector2);
				LocalPos = vector2;
			}
		}
	}
}
