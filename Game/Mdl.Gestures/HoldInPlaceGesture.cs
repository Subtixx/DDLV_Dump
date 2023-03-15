using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Gestures
{
	[Cpp2IlInjected.Token(Token = "0x200053E")]
	internal class HoldInPlaceGesture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400207E")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400207F")]
		private RectTransform _zone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002080")]
		private bool _isActive;

		[Cpp2IlInjected.Token(Token = "0x170002FD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002076")]
		public float MinDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6001701")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001702")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0")]
			set;
		} = 2f;


		[Cpp2IlInjected.Token(Token = "0x170002FE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4002077")]
		public float DragTolerance
		{
			[Cpp2IlInjected.Token(Token = "0x6001703")]
			[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001704")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
			set;
		} = 1f;


		[Cpp2IlInjected.Token(Token = "0x170002FF")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002078")]
		public bool MustStayWithinZone
		{
			[Cpp2IlInjected.Token(Token = "0x6001705")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001706")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000300")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x19"), Cpp2IlInjected.Token(Token = "0x4002079")]
		public bool IsTrue
		{
			[Cpp2IlInjected.Token(Token = "0x6001707")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001708")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000301")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1A"), Cpp2IlInjected.Token(Token = "0x400207A")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6001709")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600170A")]
			[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000302")]
		public Vector2 LocalPos
		{
			[Cpp2IlInjected.Token(Token = "0x600170B")]
			[Cpp2IlInjected.Address(RVA = "0x10680D0", Offset = "0x1066AD0", VA = "0x1810680D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600170C")]
			[Cpp2IlInjected.Address(RVA = "0xAC87A0", Offset = "0xAC71A0", VA = "0x180AC87A0")]
			[CompilerGenerated]
			private set
			{
				_003CLocalPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000303")]
		public Vector2 ScreenPos
		{
			[Cpp2IlInjected.Token(Token = "0x600170D")]
			[Cpp2IlInjected.Address(RVA = "0x10680F0", Offset = "0x1066AF0", VA = "0x1810680F0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600170E")]
			[Cpp2IlInjected.Address(RVA = "0xF4C7F0", Offset = "0xF4B1F0", VA = "0x180F4C7F0")]
			[CompilerGenerated]
			private set
			{
				_003CScreenPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000304")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x400207D")]
		public float TouchDuration
		{
			[Cpp2IlInjected.Token(Token = "0x600170F")]
			[Cpp2IlInjected.Address(RVA = "0xE3A600", Offset = "0xE39000", VA = "0x180E3A600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001710")]
			[Cpp2IlInjected.Address(RVA = "0xE3ABE0", Offset = "0xE395E0", VA = "0x180E3ABE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001711")]
		[Cpp2IlInjected.Address(RVA = "0x1550DA0", Offset = "0x154F7A0", VA = "0x181550DA0")]
		public HoldInPlaceGesture(RectTransform zone, Camera camera)
		{
			_zone = zone;
			_camera = camera;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001712")]
		[Cpp2IlInjected.Address(RVA = "0x1550700", Offset = "0x154F100", VA = "0x181550700")]
		public void Release()
		{
			IsTrue = false;
			_isActive = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001713")]
		[Cpp2IlInjected.Address(RVA = "0x1550D90", Offset = "0x154F790", VA = "0x181550D90")]
		public void Update(float deltaTime)
		{
			UpdatePc(deltaTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6001714")]
		[Cpp2IlInjected.Address(RVA = "0x1550A40", Offset = "0x154F440", VA = "0x181550A40")]
		private unsafe void UpdatePc(float deltaTime)
		{
			//IL_006d: Expected F4, but got I4
			//IL_0075: Expected I4, but got O
			//IL_0099: Expected O, but got I4
			//IL_00a5: Expected F4, but got I4
			//IL_00a0: Expected native int or pointer, but got O
			//IL_00b9: Expected F4, but got I4
			//IL_00b4: Expected native int or pointer, but got O
			IsTrue = false;
			if (!Input.GetMouseButton(0))
			{
				bool mouseButton = Input.GetMouseButton(1);
				if (!mouseButton)
				{
					IsTrue = false;
					_isActive = mouseButton;
					return;
				}
			}
			if (_isActive)
			{
				if (!IsValid)
				{
					return;
				}
				if (MustStayWithinZone)
				{
					int num = 0;
					bool flag = default(bool);
					if (!flag)
					{
						IsTrue = false;
						_isActive = flag;
						return;
					}
				}
				int num2 = 0;
				float num3 = default(float);
				if (!(num3 > DragTolerance))
				{
					TouchDuration = 0f;
					Vector2 vector = default(Vector2);
					IsTrue = (byte)(int)vector != 0;
				}
				IsTrue = false;
			}
			_isActive = true;
			int num4 = 0;
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			int num5 = 0;
			int num6 = 0;
			ScreenPos = (Vector2)flag2;
			((Vector2*)(IntPtr)ScreenPos)->y = 0f;
			Vector2 vector2 = default(Vector2);
			LocalPos = vector2;
			((Vector2*)(IntPtr)LocalPos)->y = 0f;
			TouchDuration = 0f;
			IsValid = true;
			IsTrue = true;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001715")]
		[Cpp2IlInjected.Address(RVA = "0x1550710", Offset = "0x154F110", VA = "0x181550710")]
		private unsafe void UpdateMobile(float deltaTime)
		{
			//IL_008b: Expected I4, but got O
			//IL_00b2: Expected F4, but got I4
			//IL_00ad: Expected native int or pointer, but got O
			//IL_00c6: Expected F4, but got I4
			//IL_00c1: Expected native int or pointer, but got O
			int num = 0;
			IsTrue = false;
			if (Touches.ActiveTouchCount() != 1)
			{
				return;
			}
			Touch touch = default(Touch);
			float y = touch.m_RawPosition.y;
			int tapCount = touch.m_TapCount;
			float maximumPossiblePressure = touch.m_maximumPossiblePressure;
			float azimuthAngle = touch.m_AzimuthAngle;
			if (_isActive)
			{
				if (!IsValid)
				{
					IsTrue = false;
					_isActive = false;
				}
				bool flag = default(bool);
				if (MustStayWithinZone && !flag)
				{
					IsTrue = false;
					_isActive = flag;
					return;
				}
				float num2 = default(float);
				if (!(num2 > DragTolerance))
				{
					TouchDuration = deltaTime;
					Vector2 vector = default(Vector2);
					IsTrue = (byte)(int)vector != 0;
				}
				IsTrue = false;
			}
			_isActive = true;
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			Vector2 vector2 = default(Vector2);
			ScreenPos = vector2;
			((Vector2*)(IntPtr)ScreenPos)->y = 0f;
			Vector2 vector3 = default(Vector2);
			LocalPos = vector3;
			((Vector2*)(IntPtr)LocalPos)->y = 0f;
			TouchDuration = 0f;
			IsValid = true;
			IsTrue = true;
			/*Error: Unexpected end of block*/;
		}
	}
}
