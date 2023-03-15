using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Utils;
using Rewired;
using UnityEngine;

namespace Mdl.Gestures
{
	[Cpp2IlInjected.Token(Token = "0x200053F")]
	public class MoveGesture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002084")]
		public float MouseWheelScaleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002085")]
		public float MouseRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002086")]
		public float JoystickRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002091")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002092")]
		private RectTransform _zone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002093")]
		private Vector2 _lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002094")]
		private Vector2 _lastAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002095")]
		private bool _wasDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4002096")]
		private Vector2 _deltaPosRotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4002097")]
		private bool _automaticRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8D")]
		[Cpp2IlInjected.Token(Token = "0x4002098")]
		private bool _disableGamepad;

		[Cpp2IlInjected.Token(Token = "0x17000305")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002081")]
		public float MaxForce
		{
			[Cpp2IlInjected.Token(Token = "0x6001716")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001717")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0")]
			set;
		} = 0.5f;


		[Cpp2IlInjected.Token(Token = "0x17000306")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4002082")]
		public float Friction
		{
			[Cpp2IlInjected.Token(Token = "0x6001718")]
			[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001719")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000307")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002083")]
		public bool AllowMoveWithTwoFingers
		{
			[Cpp2IlInjected.Token(Token = "0x600171A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600171B")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000308")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4002087")]
		public bool IsActivePan
		{
			[Cpp2IlInjected.Token(Token = "0x600171C")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600171D")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000309")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x29"), Cpp2IlInjected.Token(Token = "0x4002088")]
		public bool IsActiveRotate
		{
			[Cpp2IlInjected.Token(Token = "0x600171E")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600171F")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700030A")]
		public Vector2 LocalPos
		{
			[Cpp2IlInjected.Token(Token = "0x6001720")]
			[Cpp2IlInjected.Address(RVA = "0xEFF420", Offset = "0xEFDE20", VA = "0x180EFF420")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001721")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4B0", Offset = "0xEFDEB0", VA = "0x180EFF4B0")]
			[CompilerGenerated]
			private set
			{
				_003CLocalPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030B")]
		public Vector2 ScreenPos
		{
			[Cpp2IlInjected.Token(Token = "0x6001722")]
			[Cpp2IlInjected.Address(RVA = "0xEFF440", Offset = "0xEFDE40", VA = "0x180EFF440")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001723")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4D0", Offset = "0xEFDED0", VA = "0x180EFF4D0")]
			[CompilerGenerated]
			private set
			{
				_003CScreenPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030C")]
		public Vector2 DeltaPos
		{
			[Cpp2IlInjected.Token(Token = "0x6001724")]
			[Cpp2IlInjected.Address(RVA = "0xEFF3C0", Offset = "0xEFDDC0", VA = "0x180EFF3C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001725")]
			[Cpp2IlInjected.Address(RVA = "0xEFF480", Offset = "0xEFDE80", VA = "0x180EFF480")]
			[CompilerGenerated]
			private set
			{
				_003CDeltaPos_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x44"), Cpp2IlInjected.Token(Token = "0x400208C")]
		public float LocalScale
		{
			[Cpp2IlInjected.Token(Token = "0x6001726")]
			[Cpp2IlInjected.Address(RVA = "0xD392E0", Offset = "0xD37CE0", VA = "0x180D392E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001727")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4C0", Offset = "0xEFDEC0", VA = "0x180EFF4C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700030E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x400208D")]
		public float DeltaScale
		{
			[Cpp2IlInjected.Token(Token = "0x6001728")]
			[Cpp2IlInjected.Address(RVA = "0xEFF3E0", Offset = "0xEFDDE0", VA = "0x180EFF3E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001729")]
			[Cpp2IlInjected.Address(RVA = "0xDD6D20", Offset = "0xDD5720", VA = "0x180DD6D20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700030F")]
		public Vector2 LocalAngle
		{
			[Cpp2IlInjected.Token(Token = "0x600172A")]
			[Cpp2IlInjected.Address(RVA = "0xEFF400", Offset = "0xEFDE00", VA = "0x180EFF400")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600172B")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4A0", Offset = "0xEFDEA0", VA = "0x180EFF4A0")]
			[CompilerGenerated]
			private set
			{
				_003CLocalAngle_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000310")]
		public Vector2 DeltaAngle
		{
			[Cpp2IlInjected.Token(Token = "0x600172C")]
			[Cpp2IlInjected.Address(RVA = "0xEFF3A0", Offset = "0xEFDDA0", VA = "0x180EFF3A0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600172D")]
			[Cpp2IlInjected.Address(RVA = "0xEFF470", Offset = "0xEFDE70", VA = "0x180EFF470")]
			[CompilerGenerated]
			private set
			{
				_003CDeltaAngle_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000311")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x5C"), Cpp2IlInjected.Token(Token = "0x4002090")]
		public bool TwoFingers
		{
			[Cpp2IlInjected.Token(Token = "0x600172E")]
			[Cpp2IlInjected.Address(RVA = "0x9657A0", Offset = "0x9641A0", VA = "0x1809657A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600172F")]
			[Cpp2IlInjected.Address(RVA = "0x9765E0", Offset = "0x974FE0", VA = "0x1809765E0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000312")]
		public bool DisableGamepad
		{
			[Cpp2IlInjected.Token(Token = "0x6001730")]
			[Cpp2IlInjected.Address(RVA = "0xEFF3F0", Offset = "0xEFDDF0", VA = "0x180EFF3F0")]
			get
			{
				return _disableGamepad;
			}
			[Cpp2IlInjected.Token(Token = "0x6001731")]
			[Cpp2IlInjected.Address(RVA = "0xEFF490", Offset = "0xEFDE90", VA = "0x180EFF490")]
			set
			{
				_disableGamepad = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000313")]
		public bool AutomaticRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6001732")]
			[Cpp2IlInjected.Address(RVA = "0xEFF390", Offset = "0xEFDD90", VA = "0x180EFF390")]
			get
			{
				return _automaticRotation;
			}
			[Cpp2IlInjected.Token(Token = "0x6001733")]
			[Cpp2IlInjected.Address(RVA = "0xEFF460", Offset = "0xEFDE60", VA = "0x180EFF460")]
			set
			{
				_automaticRotation = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001734")]
		[Cpp2IlInjected.Address(RVA = "0xEFF300", Offset = "0xEFDD00", VA = "0x180EFF300")]
		public MoveGesture(RectTransform zone, Camera camera, bool automaticRotation = false, bool disableGamepad = false)
		{
			//IL_0040: Expected O, but got I4
			int num = 0;
			Friction = 0.5f;
			MouseWheelScaleSpeed = 1200f;
			MouseRotationSpeed = 6f;
			JoystickRotationSpeed = 120f;
			ApplyRotation((Vector3)num);
			_zone = zone;
			_camera = camera;
			_automaticRotation = automaticRotation;
			_disableGamepad = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001735")]
		[Cpp2IlInjected.Address(RVA = "0xEFDFD0", Offset = "0xEFC9D0", VA = "0x180EFDFD0")]
		public unsafe void Reset()
		{
			//IL_001f: Expected F4, but got I4
			//IL_001a: Expected native int or pointer, but got O
			//IL_0026: Expected F4, but got I4
			//IL_0044: Expected F4, but got I4
			//IL_003f: Expected native int or pointer, but got O
			//IL_0062: Expected F4, but got I4
			//IL_005d: Expected native int or pointer, but got O
			//IL_008e: Expected F4, but got I4
			//IL_0089: Expected native int or pointer, but got O
			//IL_00ac: Expected F4, but got I4
			//IL_00a7: Expected native int or pointer, but got O
			//IL_00c7: Expected F4, but got I4
			//IL_00c2: Expected native int or pointer, but got O
			int num = 0;
			Vector2 zero = Vector2.zero;
			int num2 = 0;
			int num3 = 0;
			DeltaPos = zero;
			((Vector2*)(IntPtr)DeltaPos)->y = 0f;
			LocalScale = num3;
			Vector2 zero2 = Vector2.zero;
			int num4 = 0;
			DeltaAngle = zero2;
			((Vector2*)(IntPtr)DeltaAngle)->y = 0f;
			Vector2 zero3 = Vector2.zero;
			int num5 = 0;
			LocalAngle = zero3;
			((Vector2*)(IntPtr)LocalAngle)->y = 0f;
			IsActivePan = false;
			_wasDown = false;
			Vector2 zero4 = Vector2.zero;
			int num6 = 0;
			_lastPosition = zero4;
			((Vector2*)(IntPtr)_lastPosition)->y = 0f;
			Vector2 zero5 = Vector2.zero;
			int num7 = 0;
			_lastAngle = zero5;
			((Vector2*)(IntPtr)_lastAngle)->y = 0f;
			Vector2 vector = (_deltaPosRotate = Vector2.zero);
			((Vector2*)(IntPtr)_deltaPosRotate)->y = 0f;
			_disableGamepad = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001736")]
		[Cpp2IlInjected.Address(RVA = "0xEFF2F0", Offset = "0xEFDCF0", VA = "0x180EFF2F0")]
		public void Update(float deltaTime)
		{
			UpdatePc(deltaTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6001737")]
		[Cpp2IlInjected.Address(RVA = "0xEFE8E0", Offset = "0xEFD2E0", VA = "0x180EFE8E0")]
		private unsafe void UpdatePc(float deltaTime)
		{
			//IL_002e: Expected F4, but got I4
			//IL_0029: Expected native int or pointer, but got O
			//IL_005a: Expected O, but got I4
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected F4, but got Unknown
			//IL_0129: Expected native int or pointer, but got O
			//IL_0170: Expected O, but got F4
			//IL_0178: Expected native int or pointer, but got O
			//IL_0185: Expected O, but got F4
			//IL_018d: Expected native int or pointer, but got O
			//IL_01a9: Expected native int or pointer, but got O
			//IL_01e9: Expected native int or pointer, but got O
			//IL_023b: Expected native int or pointer, but got O
			//IL_02a9: Expected F4, but got I4
			//IL_02a4: Expected native int or pointer, but got O
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Expected F4, but got Unknown
			//IL_02ba: Expected O, but got F4
			//IL_02c2: Expected native int or pointer, but got O
			//IL_02cf: Expected O, but got F4
			//IL_02d7: Expected native int or pointer, but got O
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected F4, but got Unknown
			//IL_02f6: Expected O, but got F4
			//IL_02fe: Expected native int or pointer, but got O
			//IL_030b: Expected O, but got F4
			//IL_0313: Expected native int or pointer, but got O
			//IL_0320: Expected O, but got F4
			//IL_0328: Expected native int or pointer, but got O
			//IL_0334: Expected O, but got F4
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Expected F4, but got Unknown
			//IL_033e: Expected O, but got F4
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected F4, but got Unknown
			//IL_0349: Expected O, but got F4
			//IL_0351: Expected native int or pointer, but got O
			//IL_035e: Expected O, but got F4
			//IL_0366: Expected native int or pointer, but got O
			TwoFingers = false;
			int num = 0;
			Mouse mouse = ReInput.controllers.Mouse;
			Vector2 vector = (ScreenPos = mouse.screenPosition);
			((Vector2*)(IntPtr)ScreenPos)->y = 0f;
			Vector2 screenPositionDelta = mouse.screenPositionDelta;
			int index = 0;
			bool button = mouse.GetButton(index);
			bool button2 = mouse.GetButton(1);
			float axis = mouse.GetAxis(2);
			float mouseWheelScaleSpeed = ((MoveGesture)0).MouseWheelScaleSpeed;
			float num2 = (DeltaScale = /*Error near IL_005b: Stack underflow*/* mouseWheelScaleSpeed);
			if (button != button2)
			{
				TwoFingers = true;
			}
			int num3 = 0;
			Vector2 zero = Vector2.zero;
			int num4 = 0;
			Vector2 zero2 = Vector2.zero;
			if (!button && !button)
			{
				int num5 = 0;
				Vector2 zero3 = Vector2.zero;
				int num6 = 0;
				Vector2 zero4 = Vector2.zero;
				_wasDown = button;
				IsActivePan = false;
				ApplyPanFriction(deltaTime);
				ApplyRotateFriction(deltaTime);
				return;
			}
			Vector2 vector2 = ScreenPos;
			float y = ScreenPos.y;
			RectTransform zone = _zone;
			Camera camera = _camera;
			Vector2 vector3 = Positions.ToLocalPos(vector2, zone, camera);
			int num7 = 0;
			Vector2 zero5 = Vector2.zero;
			IsActivePan = false;
			int num8 = 0;
			Vector2 zero6 = Vector2.zero;
			int num9 = 0;
			Vector2 vector4 = (DeltaPos = Vector2.zero);
			((Vector2*)(IntPtr)DeltaPos)->y = y;
			if (!_wasDown)
			{
				int num10 = 0;
				bool flag = default(bool);
				if (flag)
				{
					LocalPos = vector2;
					_lastPosition = vector2;
					IsActivePan = true;
				}
			}
			_wasDown = true;
			float num11 = MaxForce;
			int num12 = 0;
			DeltaPos = (Vector2)num11;
			((Vector2*)(IntPtr)DeltaPos)->y = num11;
			LocalPos = (Vector2)num11;
			((Vector2*)(IntPtr)LocalPos)->y = num11;
			Vector2 vector5 = (ScreenPos = Vector2.zero);
			((Vector2*)(IntPtr)ScreenPos)->y = y;
			_lastPosition = vector2;
			IsActivePan = true;
			if (TwoFingers && !AllowMoveWithTwoFingers)
			{
				int num13 = 0;
				Vector2 vector6 = (DeltaPos = Vector2.zero);
				((Vector2*)(IntPtr)DeltaPos)->y = y;
			}
			if (!_automaticRotation)
			{
				int num14 = 0;
				bool flag2 = (TwoFingers ? 1 : 0) == num14;
				int num15 = 0;
				Vector2 zero7 = Vector2.zero;
				IsActiveRotate = false;
			}
			int num16 = 0;
			if ((IsActiveRotate ? 1 : 0) == num16)
			{
				Vector2 vector7 = (_deltaPosRotate = Vector2.zero);
				((Vector2*)(IntPtr)_deltaPosRotate)->y = y;
				if (!_wasDown)
				{
					int num17 = 0;
					Vector2 mousePosition = Input.mousePosition;
					bool flag3 = default(bool);
					if (!flag3)
					{
						int num18 = 0;
						Vector2 zero8 = Vector2.zero;
					}
					IsActiveRotate = true;
				}
				bool flag4 = (_wasDown = !_automaticRotation);
			}
			Vector2 zero9 = Vector2.zero;
			float num20 = default(float);
			float num21 = default(float);
			if (_automaticRotation)
			{
				int num19 = 0;
				Vector2 zero10 = Vector2.zero;
				_deltaPosRotate = screenPositionDelta;
				((Vector2*)(IntPtr)_deltaPosRotate)->y = 0f;
				float joystickRotationSpeed = ((MoveGesture)screenPositionDelta).JoystickRotationSpeed;
				num20 = /*Error near IL_02b0: Stack underflow*/* joystickRotationSpeed;
				DeltaAngle = (Vector2)num20;
				((Vector2*)(IntPtr)DeltaAngle)->y = num21;
				LocalAngle = (Vector2)num20;
				((Vector2*)(IntPtr)LocalAngle)->y = num21;
			}
			_deltaPosRotate = vector2;
			float mouseRotationSpeed = ((MoveGesture)vector2).MouseRotationSpeed;
			float num22 = /*Error near IL_02ec: Stack underflow*/* mouseRotationSpeed;
			DeltaAngle = (Vector2)num22;
			float y2 = default(float);
			((Vector2*)(IntPtr)DeltaAngle)->y = y2;
			LocalAngle = (Vector2)num22;
			((Vector2*)(IntPtr)LocalAngle)->y = y2;
			_deltaPosRotate = (Vector2)num21;
			((Vector2*)(IntPtr)_deltaPosRotate)->y = num20;
			float joystickRotationSpeed2 = ((MoveGesture)num21).JoystickRotationSpeed;
			float num23 = /*Error near IL_0335: Stack underflow*/* joystickRotationSpeed2;
			float joystickRotationSpeed3 = ((MoveGesture)num20).JoystickRotationSpeed;
			float y3 = /*Error near IL_033f: Stack underflow*/* joystickRotationSpeed3;
			DeltaAngle = (Vector2)num23;
			((Vector2*)(IntPtr)DeltaAngle)->y = y3;
			LocalAngle = (Vector2)num23;
			((Vector2*)(IntPtr)LocalAngle)->y = y3;
			_lastPosition = vector2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001738")]
		[Cpp2IlInjected.Address(RVA = "0xEFE0D0", Offset = "0xEFCAD0", VA = "0x180EFE0D0")]
		private unsafe void UpdateMobile(float deltaTime)
		{
			//IL_00aa: Expected O, but got I4
			//IL_00b2: Expected native int or pointer, but got O
			//IL_00c6: Expected O, but got F4
			//IL_00ea: Expected native int or pointer, but got O
			//IL_00f7: Expected F4, but got I4
			//IL_0106: Expected native int or pointer, but got O
			//IL_013e: Expected native int or pointer, but got O
			//IL_018d: Expected O, but got F4
			//IL_0195: Expected native int or pointer, but got O
			//IL_01c2: Expected native int or pointer, but got O
			//IL_01df: Expected O, but got F4
			//IL_01e7: Expected native int or pointer, but got O
			//IL_01f4: Expected F4, but got I4
			//IL_0203: Expected O, but got F4
			//IL_020b: Expected native int or pointer, but got O
			//IL_0229: Expected native int or pointer, but got O
			//IL_023c: Expected native int or pointer, but got O
			//IL_025b: Expected O, but got I4
			//IL_0263: Expected native int or pointer, but got O
			//IL_0286: Expected O, but got I4
			//IL_028e: Expected native int or pointer, but got O
			//IL_029b: Expected F4, but got I4
			//IL_02b5: Expected O, but got I4
			//IL_02bd: Expected native int or pointer, but got O
			//IL_02db: Expected F4, but got I4
			//IL_02e8: Expected O, but got I4
			//IL_030a: Expected native int or pointer, but got O
			//IL_0317: Expected F4, but got I4
			int num = 0;
			bool flag = Input.touchCount >= 2;
			int num2 = 0;
			TwoFingers = flag;
			int num3 = Touches.ActiveTouchCount();
			Vector2 zero6 = default(Vector2);
			if (num3 != 0)
			{
				int num4 = 0;
				if (Input.touchCount != 1)
				{
					Touch touch = default(Touch);
					float y = touch.m_RawPosition.y;
					int tapCount = touch.m_TapCount;
					float maximumPossiblePressure = touch.m_maximumPossiblePressure;
					float azimuthAngle = touch.m_AzimuthAngle;
					Touch touch2 = default(Touch);
					int tapCount2 = touch2.m_TapCount;
					float maximumPossiblePressure2 = touch2.m_maximumPossiblePressure;
					Camera camera = _camera;
					RectTransform zone = _zone;
					Vector2 screenPos = default(Vector2);
					Vector2 vector = Positions.ToLocalPos(screenPos, zone, camera);
					Vector2 lastAngle = _lastAngle;
					int num5 = 0;
					float y2 = _lastAngle.y;
					ScreenPos = (Vector2)tapCount2;
					((Vector2*)(IntPtr)ScreenPos)->y = maximumPossiblePressure2;
					Vector2 zero = Vector2.zero;
					_lastAngle = (Vector2)maximumPossiblePressure2;
					if (!IsActiveRotate)
					{
						int num6 = 0;
						Vector2 zero2 = Vector2.zero;
						int num7 = 0;
						int num8 = 0;
						((Vector2*)(IntPtr)DeltaPos)->y = maximumPossiblePressure2;
						DeltaScale = num8;
						Vector2 zero3 = Vector2.zero;
						((Vector2*)(IntPtr)DeltaAngle)->y = maximumPossiblePressure2;
						if (!_wasDown)
						{
							Vector2 lastPosition = ScreenPos;
							float y3 = ScreenPos.y;
							bool flag2 = default(bool);
							if (flag2)
							{
								_lastPosition = lastPosition;
								((Vector2*)(IntPtr)_lastPosition)->y = y3;
								float num9 = default(float);
								LocalScale = num9;
								IsActiveRotate = true;
							}
						}
						_wasDown = true;
						return;
					}
					maximumPossiblePressure2 = y2;
					float num10 = default(float);
					maximumPossiblePressure2 = num10;
					LocalScale = num10;
					DeltaScale = maximumPossiblePressure2;
					Vector2 zero4 = default(Vector2);
					if (!AllowMoveWithTwoFingers)
					{
						int num11 = 0;
						zero4 = Vector2.zero;
						DeltaPos = (Vector2)num10;
						((Vector2*)(IntPtr)DeltaPos)->y = maximumPossiblePressure2;
					}
					if (num3 == 1)
					{
						if ((long)zero4 != 3 && (long)zero4 != 4)
						{
							if ((long)zero4 != 3 && (long)zero4 != 4)
							{
								goto IL_0210;
							}
							((Vector2*)(IntPtr)_lastPosition)->y = y2;
						}
						int num12 = 0;
						Vector2 zero5 = Vector2.zero;
						int num13 = 0;
						int num14 = 0;
						DeltaPos = (Vector2)num10;
						((Vector2*)(IntPtr)DeltaPos)->y = maximumPossiblePressure2;
						LocalScale = num14;
						zero6 = Vector2.zero;
						_lastAngle = (Vector2)num10;
						((Vector2*)(IntPtr)_lastAngle)->y = maximumPossiblePressure2;
					}
					goto IL_0210;
				}
				goto IL_0215;
			}
			goto IL_02e8;
			IL_0215:
			int num15 = 0;
			Vector2 zero7 = Vector2.zero;
			int num16 = 0;
			((Vector2*)(IntPtr)_lastAngle)->y = deltaTime;
			Vector2 zero8 = Vector2.zero;
			((Vector2*)(IntPtr)DeltaAngle)->y = deltaTime;
			Touch touch3 = default(Touch);
			int tapCount3 = touch3.m_TapCount;
			float maximumPossiblePressure3 = touch3.m_maximumPossiblePressure;
			ScreenPos = (Vector2)tapCount3;
			((Vector2*)(IntPtr)ScreenPos)->y = maximumPossiblePressure3;
			int num19 = default(int);
			if (!IsActivePan)
			{
				int num17 = 0;
				Vector2 zero9 = Vector2.zero;
				int num18 = 0;
				DeltaPos = (Vector2)tapCount3;
				((Vector2*)(IntPtr)DeltaPos)->y = maximumPossiblePressure3;
				LocalScale = num18;
				if ((_wasDown ? 1 : 0) == num18)
				{
					num19 = 0;
					bool flag3 = default(bool);
					if (flag3)
					{
						LocalPos = (Vector2)tapCount3;
						((Vector2*)(IntPtr)LocalPos)->y = maximumPossiblePressure3;
						IsActivePan = true;
					}
				}
				_wasDown = true;
			}
			int num20 = 0;
			LocalScale = num20;
			maximumPossiblePressure3 = deltaTime;
			ApplyMovement(maximumPossiblePressure3, (Vector2)num19);
			goto IL_02e8;
			IL_02e8:
			int num21 = 0;
			_wasDown = false;
			IsActivePan = false;
			Vector2 zero10 = Vector2.zero;
			int num22 = 0;
			((Vector2*)(IntPtr)_lastAngle)->y = deltaTime;
			LocalScale = num22;
			ApplyPanFriction(deltaTime);
			ApplyRotateFriction(deltaTime);
			/*Error: Unexpected end of block*/;
			IL_0210:
			while ((object)zero6 == null)
			{
			}
			goto IL_0215;
		}

		[Cpp2IlInjected.Token(Token = "0x6001739")]
		[Cpp2IlInjected.Address(RVA = "0xEFDDD0", Offset = "0xEFC7D0", VA = "0x180EFDDD0")]
		private void ApplyMovement(float deltaTime, Vector2 localPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600173A")]
		[Cpp2IlInjected.Address(RVA = "0xEFDD30", Offset = "0xEFC730", VA = "0x180EFDD30")]
		private unsafe void ApplyMovementDelta(float deltaTime, Vector2 deltaInput, Vector2 localPos)
		{
			//IL_0015: Expected F4, but got I4
			//IL_0010: Expected native int or pointer, but got O
			//IL_0028: Expected F4, but got I4
			//IL_0023: Expected native int or pointer, but got O
			//IL_0041: Expected F4, but got I4
			//IL_003c: Expected native int or pointer, but got O
			int num = 0;
			DeltaPos = deltaInput;
			((Vector2*)(IntPtr)DeltaPos)->y = 0f;
			LocalPos = deltaInput;
			((Vector2*)(IntPtr)LocalPos)->y = 0f;
			Vector2 vector = (ScreenPos = Vector2.zero);
			((Vector2*)(IntPtr)ScreenPos)->y = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x600173B")]
		[Cpp2IlInjected.Address(RVA = "0xEFDF70", Offset = "0xEFC970", VA = "0x180EFDF70")]
		private void ApplyScale(Vector2 localPos1, Vector2 localPos2)
		{
			float num = default(float);
			LocalScale = num;
			DeltaScale = num;
		}

		[Cpp2IlInjected.Token(Token = "0x600173C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void ApplyRotation(Vector3 direction)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600173D")]
		[Cpp2IlInjected.Address(RVA = "0xEFDE70", Offset = "0xEFC870", VA = "0x180EFDE70")]
		private unsafe void ApplyPanFriction(float deltaTime)
		{
			//IL_0021: Expected native int or pointer, but got O
			//IL_0034: Expected native int or pointer, but got O
			Vector2 vector = DeltaPos;
			float y = DeltaPos.y;
			DeltaPos = vector;
			((Vector2*)(IntPtr)DeltaPos)->y = y;
			LocalPos = vector;
			((Vector2*)(IntPtr)LocalPos)->y = y;
		}

		[Cpp2IlInjected.Token(Token = "0x600173E")]
		[Cpp2IlInjected.Address(RVA = "0xEFDEF0", Offset = "0xEFC8F0", VA = "0x180EFDEF0")]
		private unsafe void ApplyRotateFriction(float deltaTime)
		{
			//IL_0021: Expected native int or pointer, but got O
			//IL_0034: Expected native int or pointer, but got O
			Vector2 vector = DeltaAngle;
			float y = DeltaAngle.y;
			DeltaAngle = vector;
			((Vector2*)(IntPtr)DeltaAngle)->y = y;
			LocalAngle = vector;
			((Vector2*)(IntPtr)LocalAngle)->y = y;
		}
	}
}
