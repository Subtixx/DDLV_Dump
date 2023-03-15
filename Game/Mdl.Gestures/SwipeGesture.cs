using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Gestures
{
	[Cpp2IlInjected.Token(Token = "0x2000541")]
	public class SwipeGesture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40020AA")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40020AB")]
		private RectTransform _zone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40020AC")]
		private Vector2 _startPosition;

		[Cpp2IlInjected.Token(Token = "0x17000314")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40020A1")]
		public float MinSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x6001742")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001743")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0")]
			set;
		} = 100f;


		[Cpp2IlInjected.Token(Token = "0x17000315")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x40020A2")]
		public float MinDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6001744")]
			[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001745")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
			set;
		} = 100f;


		[Cpp2IlInjected.Token(Token = "0x17000316")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40020A3")]
		public bool MustStayWithinZone
		{
			[Cpp2IlInjected.Token(Token = "0x6001746")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001747")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000317")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x19"), Cpp2IlInjected.Token(Token = "0x40020A4")]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6001748")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001749")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000318")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1A"), Cpp2IlInjected.Token(Token = "0x40020A5")]
		public bool IsTrue
		{
			[Cpp2IlInjected.Token(Token = "0x600174A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600174B")]
			[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000319")]
		public Vector2 Direction
		{
			[Cpp2IlInjected.Token(Token = "0x600174C")]
			[Cpp2IlInjected.Address(RVA = "0x10680D0", Offset = "0x1066AD0", VA = "0x1810680D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600174D")]
			[Cpp2IlInjected.Address(RVA = "0xAC87A0", Offset = "0xAC71A0", VA = "0x180AC87A0")]
			[CompilerGenerated]
			private set
			{
				_003CDirection_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031A")]
		public Vector2 ScreenPos
		{
			[Cpp2IlInjected.Token(Token = "0x600174E")]
			[Cpp2IlInjected.Address(RVA = "0x10680F0", Offset = "0x1066AF0", VA = "0x1810680F0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600174F")]
			[Cpp2IlInjected.Address(RVA = "0xF4C7F0", Offset = "0xF4B1F0", VA = "0x180F4C7F0")]
			[CompilerGenerated]
			private set
			{
				_003CScreenPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031B")]
		public Vector2 LocalPos
		{
			[Cpp2IlInjected.Token(Token = "0x6001750")]
			[Cpp2IlInjected.Address(RVA = "0xEFF420", Offset = "0xEFDE20", VA = "0x180EFF420")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001751")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4B0", Offset = "0xEFDEB0", VA = "0x180EFF4B0")]
			[CompilerGenerated]
			private set
			{
				_003CLocalPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x40020A9")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6001752")]
			[Cpp2IlInjected.Address(RVA = "0xBC59C0", Offset = "0xBC43C0", VA = "0x180BC59C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001753")]
			[Cpp2IlInjected.Address(RVA = "0xBC5B40", Offset = "0xBC4540", VA = "0x180BC5B40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001754")]
		[Cpp2IlInjected.Address(RVA = "0x1068070", Offset = "0x1066A70", VA = "0x181068070")]
		public SwipeGesture(RectTransform zone, Camera camera)
		{
			_zone = zone;
			_camera = camera;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001755")]
		[Cpp2IlInjected.Address(RVA = "0x1068060", Offset = "0x1066A60", VA = "0x181068060")]
		public void Update(float deltaTime)
		{
			UpdatePc(deltaTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6001756")]
		[Cpp2IlInjected.Address(RVA = "0x1067C80", Offset = "0x1066680", VA = "0x181067C80")]
		private unsafe void UpdatePc(float deltaTime)
		{
			//IL_0068: Expected O, but got I4
			//IL_0074: Expected F4, but got I4
			//IL_006f: Expected native int or pointer, but got O
			//IL_0088: Expected F4, but got I4
			//IL_0083: Expected native int or pointer, but got O
			//IL_00a0: Expected O, but got F4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected F4, but got Unknown
			//IL_00cb: Expected F4, but got I4
			//IL_00c6: Expected native int or pointer, but got O
			//IL_00e1: Expected O, but got I4
			//IL_00ed: Expected F4, but got I4
			//IL_00e8: Expected native int or pointer, but got O
			//IL_011c: Expected F4, but got I4
			//IL_0117: Expected native int or pointer, but got O
			IsTrue = false;
			if (!Input.GetMouseButtonDown(0) && !Input.GetMouseButtonDown(1))
			{
				bool mouseButton = Input.GetMouseButton(0);
				if (!mouseButton && !Input.GetMouseButton(1))
				{
					IsActive = false;
				}
				if (!IsActive)
				{
					return;
				}
				if (MustStayWithinZone)
				{
					int num = 0;
					bool flag = default(bool);
					while (!flag)
					{
					}
				}
				Duration = deltaTime;
				int num2 = 0;
				int num3 = 0;
				ScreenPos = (Vector2)mouseButton;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				Vector2 vector = default(Vector2);
				LocalPos = vector;
				((Vector2*)(IntPtr)LocalPos)->y = 0f;
				float num4 = default(float);
				if (num4 <= MinDistance)
				{
					return;
				}
				float num5 = ((SwipeGesture)MinSpeed).Duration;
				float num6 = /*Error near IL_00a1: Stack underflow*/* num5;
				if (!(num4 <= num6))
				{
					IsTrue = true;
				}
				IsActive = false;
				Vector2 vector2 = default(Vector2);
				Direction = vector2;
				((Vector2*)(IntPtr)Direction)->y = 0f;
			}
			int num7 = 0;
			bool flag2 = default(bool);
			if (flag2)
			{
				int num8 = 0;
				int num9 = 0;
				ScreenPos = (Vector2)flag2;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				Vector2 startPosition = default(Vector2);
				LocalPos = startPosition;
				_startPosition = startPosition;
				Duration = 0f;
				IsActive = true;
				((Vector2*)(IntPtr)LocalPos)->y = (flag2 ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001757")]
		[Cpp2IlInjected.Address(RVA = "0x10678D0", Offset = "0x10662D0", VA = "0x1810678D0")]
		private unsafe void UpdateMobile(float deltaTime)
		{
			//IL_0081: Expected F4, but got I4
			//IL_007c: Expected native int or pointer, but got O
			//IL_0095: Expected F4, but got I4
			//IL_0090: Expected native int or pointer, but got O
			//IL_00ad: Expected O, but got F4
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected F4, but got Unknown
			//IL_00d8: Expected F4, but got I4
			//IL_00d3: Expected native int or pointer, but got O
			//IL_00f1: Expected F4, but got I4
			//IL_00ec: Expected native int or pointer, but got O
			//IL_0120: Expected F4, but got O
			//IL_011b: Expected native int or pointer, but got O
			int num = 0;
			IsTrue = false;
			if (Touches.ActiveTouchCount() != 1)
			{
				IsActive = false;
				return;
			}
			Touch touch = default(Touch);
			float y = touch.m_RawPosition.y;
			int tapCount = touch.m_TapCount;
			float maximumPossiblePressure = touch.m_maximumPossiblePressure;
			if (touch.m_AzimuthAngle != 0f)
			{
				if (!IsActive)
				{
					return;
				}
				bool flag = default(bool);
				if (MustStayWithinZone && !flag)
				{
					IsActive = flag;
				}
				Duration = deltaTime;
				Vector2 vector = default(Vector2);
				ScreenPos = vector;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				Vector2 vector2 = default(Vector2);
				LocalPos = vector2;
				((Vector2*)(IntPtr)LocalPos)->y = 0f;
				float num2 = default(float);
				if (num2 <= MinDistance)
				{
					return;
				}
				float num3 = ((SwipeGesture)MinSpeed).Duration;
				float num4 = /*Error near IL_00ae: Stack underflow*/* num3;
				if (!(num2 <= num4))
				{
					IsTrue = true;
				}
				IsActive = false;
				Vector2 vector3 = default(Vector2);
				Direction = vector3;
				((Vector2*)(IntPtr)Direction)->y = 0f;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				Vector2 vector4 = default(Vector2);
				ScreenPos = vector4;
				((Vector2*)(IntPtr)ScreenPos)->y = 0f;
				Vector2 startPosition = default(Vector2);
				LocalPos = startPosition;
				_startPosition = startPosition;
				Duration = 0f;
				IsActive = true;
				((Vector2*)(IntPtr)LocalPos)->y = (float)vector4;
			}
		}
	}
}
