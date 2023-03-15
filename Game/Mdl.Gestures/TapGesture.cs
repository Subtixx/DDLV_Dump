using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Gestures
{
	[Cpp2IlInjected.Token(Token = "0x2000542")]
	public class TapGesture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40020B4")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40020B5")]
		private RectTransform _zone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40020B6")]
		private bool _isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40020B7")]
		private float _touchDuration;

		[Cpp2IlInjected.Token(Token = "0x1700031D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40020AD")]
		public float MaxDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6001758")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001759")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0")]
			set;
		} = 0.2f;


		[Cpp2IlInjected.Token(Token = "0x1700031E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x40020AE")]
		public float DragTolerance
		{
			[Cpp2IlInjected.Token(Token = "0x600175A")]
			[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600175B")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
			set;
		} = 1f;


		[Cpp2IlInjected.Token(Token = "0x1700031F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40020AF")]
		public bool UseLeftClick
		{
			[Cpp2IlInjected.Token(Token = "0x600175C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600175D")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x17000320")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x19"), Cpp2IlInjected.Token(Token = "0x40020B0")]
		public bool UseRightClick
		{
			[Cpp2IlInjected.Token(Token = "0x600175E")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600175F")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000321")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1A"), Cpp2IlInjected.Token(Token = "0x40020B1")]
		public bool IsTrue
		{
			[Cpp2IlInjected.Token(Token = "0x6001760")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001761")]
			[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000322")]
		public Vector2 LocalPos
		{
			[Cpp2IlInjected.Token(Token = "0x6001762")]
			[Cpp2IlInjected.Address(RVA = "0x10680D0", Offset = "0x1066AD0", VA = "0x1810680D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001763")]
			[Cpp2IlInjected.Address(RVA = "0xAC87A0", Offset = "0xAC71A0", VA = "0x180AC87A0")]
			[CompilerGenerated]
			private set
			{
				_003CLocalPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000323")]
		public Vector2 ScreenPos
		{
			[Cpp2IlInjected.Token(Token = "0x6001764")]
			[Cpp2IlInjected.Address(RVA = "0x10680F0", Offset = "0x1066AF0", VA = "0x1810680F0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001765")]
			[Cpp2IlInjected.Address(RVA = "0xF4C7F0", Offset = "0xF4B1F0", VA = "0x180F4C7F0")]
			[CompilerGenerated]
			private set
			{
				_003CScreenPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001766")]
		[Cpp2IlInjected.Address(RVA = "0x106F4A0", Offset = "0x106DEA0", VA = "0x18106F4A0")]
		public TapGesture(RectTransform zone, Camera camera)
		{
			_zone = zone;
			_camera = camera;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001767")]
		[Cpp2IlInjected.Address(RVA = "0x106EE10", Offset = "0x106D810", VA = "0x18106EE10")]
		public void Release()
		{
			IsTrue = false;
			_isValid = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001768")]
		[Cpp2IlInjected.Address(RVA = "0x106F490", Offset = "0x106DE90", VA = "0x18106F490")]
		public void Update(float deltaTime)
		{
			UpdatePc(deltaTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6001769")]
		[Cpp2IlInjected.Address(RVA = "0x106F180", Offset = "0x106DB80", VA = "0x18106F180")]
		private unsafe void UpdatePc(float deltaTime)
		{
			//IL_003f: Expected O, but got I4
			//IL_004b: Expected F4, but got I4
			//IL_0046: Expected native int or pointer, but got O
			//IL_005f: Expected F4, but got I4
			//IL_005a: Expected native int or pointer, but got O
			IsTrue = false;
			if ((UseLeftClick && Input.GetMouseButtonDown(0)) || (UseRightClick && Input.GetMouseButtonDown(1)))
			{
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
				int num2 = 0;
				int num3 = 0;
				ScreenPos = (Vector2)flag;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				Vector2 vector = default(Vector2);
				LocalPos = vector;
				((Vector2*)(IntPtr)LocalPos)->y = 0f;
				_touchDuration = 0f;
				_isValid = true;
			}
			if ((UseLeftClick && Input.GetMouseButton(0)) || (UseRightClick && Input.GetMouseButton(1)))
			{
				if (!_isValid)
				{
					return;
				}
				_touchDuration = deltaTime;
				if (deltaTime <= MaxDuration)
				{
					return;
				}
			}
			if (_isValid)
			{
				int num4 = 0;
				float num5 = DragTolerance;
				IsTrue = true;
			}
			_isValid = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600176A")]
		[Cpp2IlInjected.Address(RVA = "0x106EE20", Offset = "0x106D820", VA = "0x18106EE20")]
		private unsafe void UpdateMobile(float deltaTime)
		{
			//IL_00be: Expected F4, but got I4
			//IL_00b9: Expected native int or pointer, but got O
			//IL_00d2: Expected F4, but got I4
			//IL_00cd: Expected native int or pointer, but got O
			int num = 0;
			IsTrue = false;
			if (Touches.ActiveTouchCount() != 1)
			{
				if (_isValid)
				{
					int num2 = 0;
					int touchCount = Input.touchCount;
					Touch touch = default(Touch);
					float y = touch.m_RawPosition.y;
					int tapCount = touch.m_TapCount;
					float maximumPossiblePressure = touch.m_maximumPossiblePressure;
					float azimuthAngle = touch.m_AzimuthAngle;
					float num3 = DragTolerance;
					IsTrue = true;
				}
				_isValid = false;
				return;
			}
			Touch touch2 = default(Touch);
			float y2 = touch2.m_RawPosition.y;
			int tapCount2 = touch2.m_TapCount;
			float maximumPossiblePressure2 = touch2.m_maximumPossiblePressure;
			if (touch2.m_AzimuthAngle != 0f)
			{
				while (!_isValid)
				{
				}
				_touchDuration = deltaTime;
				while (deltaTime <= MaxDuration)
				{
				}
			}
			bool flag = default(bool);
			while (!flag)
			{
			}
			Vector2 vector = default(Vector2);
			ScreenPos = vector;
			((Vector2*)(IntPtr)ScreenPos)->y = 0f;
			Vector2 vector2 = default(Vector2);
			LocalPos = vector2;
			((Vector2*)(IntPtr)LocalPos)->y = 0f;
			_touchDuration = 0f;
			_isValid = true;
			_isValid = false;
		}
	}
}
