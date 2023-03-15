using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Gestures
{
	[Cpp2IlInjected.Token(Token = "0x200053D")]
	public class HoldGesture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002071")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002072")]
		private RectTransform _zone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002073")]
		private bool _isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4002074")]
		private bool _isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002075")]
		private float _touchDuration;

		[Cpp2IlInjected.Token(Token = "0x170002F8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400206C")]
		public float MinDuration
		{
			[Cpp2IlInjected.Token(Token = "0x60016F2")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60016F3")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0")]
			set;
		} = 2f;


		[Cpp2IlInjected.Token(Token = "0x170002F9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x400206D")]
		public bool MustStayWithinZone
		{
			[Cpp2IlInjected.Token(Token = "0x60016F4")]
			[Cpp2IlInjected.Address(RVA = "0xC58490", Offset = "0xC56E90", VA = "0x180C58490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60016F5")]
			[Cpp2IlInjected.Address(RVA = "0xC584C0", Offset = "0xC56EC0", VA = "0x180C584C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002FA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x15"), Cpp2IlInjected.Token(Token = "0x400206E")]
		public bool IsTrue
		{
			[Cpp2IlInjected.Token(Token = "0x60016F6")]
			[Cpp2IlInjected.Address(RVA = "0xC584A0", Offset = "0xC56EA0", VA = "0x180C584A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60016F7")]
			[Cpp2IlInjected.Address(RVA = "0xC584D0", Offset = "0xC56ED0", VA = "0x180C584D0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002FB")]
		public Vector2 LocalPos
		{
			[Cpp2IlInjected.Token(Token = "0x60016F8")]
			[Cpp2IlInjected.Address(RVA = "0x1106770", Offset = "0x1105170", VA = "0x181106770")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60016F9")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			[CompilerGenerated]
			private set
			{
				_003CLocalPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FC")]
		public Vector2 ScreenPos
		{
			[Cpp2IlInjected.Token(Token = "0x60016FA")]
			[Cpp2IlInjected.Address(RVA = "0x1106790", Offset = "0x1105190", VA = "0x181106790")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60016FB")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
			[CompilerGenerated]
			private set
			{
				_003CScreenPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016FC")]
		[Cpp2IlInjected.Address(RVA = "0x15506A0", Offset = "0x154F0A0", VA = "0x1815506A0")]
		public HoldGesture(RectTransform zone, Camera camera)
		{
			_zone = zone;
			_camera = camera;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016FD")]
		[Cpp2IlInjected.Address(RVA = "0x1550000", Offset = "0x154EA00", VA = "0x181550000")]
		public void Release()
		{
			IsTrue = false;
			_isActive = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60016FE")]
		[Cpp2IlInjected.Address(RVA = "0x1550690", Offset = "0x154F090", VA = "0x181550690")]
		public void Update(float deltaTime)
		{
			UpdateMobile(deltaTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60016FF")]
		[Cpp2IlInjected.Address(RVA = "0x1550350", Offset = "0x154ED50", VA = "0x181550350")]
		private unsafe void UpdatePc(float deltaTime)
		{
			//IL_006f: Expected O, but got I4
			//IL_007b: Expected F4, but got I4
			//IL_0076: Expected native int or pointer, but got O
			//IL_008f: Expected F4, but got I4
			//IL_008a: Expected native int or pointer, but got O
			//IL_00ac: Expected O, but got I4
			//IL_00b8: Expected F4, but got I4
			//IL_00b3: Expected native int or pointer, but got O
			//IL_00cc: Expected F4, but got I4
			//IL_00c7: Expected native int or pointer, but got O
			IsTrue = false;
			if (!Input.GetMouseButton(0))
			{
				bool mouseButton = Input.GetMouseButton(1);
				if (!mouseButton)
				{
					IsTrue = mouseButton;
					_isActive = false;
					return;
				}
			}
			if (_isActive)
			{
				if (!_isValid)
				{
					return;
				}
				bool flag = default(bool);
				if (MustStayWithinZone)
				{
					int num = 0;
					if (!flag)
					{
						IsTrue = flag;
						_isActive = false;
					}
				}
				_touchDuration = deltaTime;
				int num2 = 0;
				int num3 = 0;
				ScreenPos = (Vector2)flag;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				Vector2 vector = default(Vector2);
				LocalPos = vector;
				((Vector2*)(IntPtr)LocalPos)->y = 0f;
			}
			_isActive = true;
			int num4 = 0;
			bool flag2 = default(bool);
			if (flag2)
			{
				int num5 = 0;
				int num6 = 0;
				ScreenPos = (Vector2)flag2;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				Vector2 vector2 = default(Vector2);
				LocalPos = vector2;
				((Vector2*)(IntPtr)LocalPos)->y = 0f;
				_touchDuration = 0f;
				_isValid = true;
				IsTrue = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001700")]
		[Cpp2IlInjected.Address(RVA = "0x1550010", Offset = "0x154EA10", VA = "0x181550010")]
		private unsafe void UpdateMobile(float deltaTime)
		{
			//IL_0090: Expected F4, but got I4
			//IL_008b: Expected native int or pointer, but got O
			//IL_00a4: Expected F4, but got I4
			//IL_009f: Expected native int or pointer, but got O
			//IL_00c4: Expected F4, but got I4
			//IL_00bf: Expected native int or pointer, but got O
			//IL_00d8: Expected F4, but got I4
			//IL_00d3: Expected native int or pointer, but got O
			int num = 0;
			IsTrue = false;
			if (Touches.ActiveTouchCount() != 1)
			{
				IsTrue = false;
				_isActive = false;
				return;
			}
			Touch touch = default(Touch);
			float y = touch.m_RawPosition.y;
			int tapCount = touch.m_TapCount;
			float maximumPossiblePressure = touch.m_maximumPossiblePressure;
			float azimuthAngle = touch.m_AzimuthAngle;
			if (_isActive)
			{
				if (!_isValid)
				{
					return;
				}
				bool flag = default(bool);
				if (MustStayWithinZone && !flag)
				{
					IsTrue = flag;
					_isActive = false;
				}
				_touchDuration = deltaTime;
				Vector2 vector = default(Vector2);
				ScreenPos = vector;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				Vector2 vector2 = default(Vector2);
				LocalPos = vector2;
				((Vector2*)(IntPtr)LocalPos)->y = 0f;
			}
			_isActive = true;
			bool flag2 = default(bool);
			if (flag2)
			{
				Vector2 vector3 = default(Vector2);
				ScreenPos = vector3;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				Vector2 vector4 = default(Vector2);
				LocalPos = vector4;
				((Vector2*)(IntPtr)LocalPos)->y = 0f;
				_touchDuration = 0f;
				_isValid = true;
				IsTrue = true;
			}
		}
	}
}
