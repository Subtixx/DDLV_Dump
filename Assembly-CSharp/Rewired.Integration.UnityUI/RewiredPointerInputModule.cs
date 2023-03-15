using System;
using System.Collections.Generic;
using System.Text;
using Cpp2IlInjected;
using Rewired.UI;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public abstract class RewiredPointerInputModule : BaseInputModule
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		protected class MouseState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			private List<ButtonState> m_TrackedButtons = (List<ButtonState>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x1E95840", Offset = "0x1E94240", VA = "0x181E95840")]
			public bool AnyPressesThisFrame()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x1E95910", Offset = "0x1E94310", VA = "0x181E95910")]
			public bool AnyReleasesThisFrame()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x1E959E0", Offset = "0x1E943E0", VA = "0x181E959E0")]
			public ButtonState GetButtonState(int button)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x1E95B60", Offset = "0x1E94560", VA = "0x181E95B60")]
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
			{
				ButtonState buttonState = GetButtonState(button);
				buttonState.m_EventData.buttonState = stateForMouseButton;
				buttonState.m_EventData.buttonData = data;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E95BC0", Offset = "0x1E945C0", VA = "0x181E95BC0")]
			public MouseState()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public class MouseButtonEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public PointerEventData.FramePressState buttonState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public PlayerPointerEventData buttonData;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x1E95810", Offset = "0x1E94210", VA = "0x181E95810")]
			public bool PressedThisFrame()
			{
				PointerEventData.FramePressState framePressState = buttonState;
				if (framePressState == PointerEventData.FramePressState.Pressed)
				{
					return true;
				}
				return framePressState == PointerEventData.FramePressState.PressedAndReleased;
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x1E95830", Offset = "0x1E94230", VA = "0x181E95830")]
			public bool ReleasedThisFrame()
			{
				PointerEventData.FramePressState framePressState = buttonState;
				if (framePressState == PointerEventData.FramePressState.Released)
				{
				}
				return framePressState == PointerEventData.FramePressState.PressedAndReleased;
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public MouseButtonEventData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		protected class ButtonState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			private int m_Button;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			private MouseButtonEventData m_EventData;

			[Cpp2IlInjected.Token(Token = "0x17000238")]
			public MouseButtonEventData eventData
			{
				[Cpp2IlInjected.Token(Token = "0x60003AD")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get
				{
					return m_EventData;
				}
				[Cpp2IlInjected.Token(Token = "0x60003AE")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				set
				{
					m_EventData = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000239")]
			public int button
			{
				[Cpp2IlInjected.Token(Token = "0x60003AF")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get
				{
					return m_Button;
				}
				[Cpp2IlInjected.Token(Token = "0x60003B0")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set
				{
					m_Button = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ButtonState()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			private Vector2 m_MousePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			private Vector2 m_MousePositionPrev;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			private int m_LastUpdatedFrame = -1;

			[Cpp2IlInjected.Token(Token = "0x1700023A")]
			unsafe int IMouseInputSource.playerId
			{
				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0x1EA3310", Offset = "0x1EA1D10", VA = "0x181EA3310", Slot = "4")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					int num = 0;
					if (Time.frameCount != m_LastUpdatedFrame)
					{
						int num2 = 0;
						int frameCount = Time.frameCount;
						Vector2 mousePosition = m_MousePosition;
						float y = m_MousePosition.y;
						m_MousePositionPrev = mousePosition;
						((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
						m_LastUpdatedFrame = frameCount;
						Vector3 mousePosition2 = Input.mousePosition;
						m_MousePosition = (Vector2)y;
						((Vector2*)(IntPtr)m_MousePosition)->y = y;
					}
					return 0;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700023B")]
			unsafe int ITouchInputSource.playerId
			{
				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0x1EA3310", Offset = "0x1EA1D10", VA = "0x181EA3310", Slot = "14")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					int num = 0;
					if (Time.frameCount != m_LastUpdatedFrame)
					{
						int num2 = 0;
						int frameCount = Time.frameCount;
						Vector2 mousePosition = m_MousePosition;
						float y = m_MousePosition.y;
						m_MousePositionPrev = mousePosition;
						((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
						m_LastUpdatedFrame = frameCount;
						Vector3 mousePosition2 = Input.mousePosition;
						m_MousePosition = (Vector2)y;
						((Vector2*)(IntPtr)m_MousePosition)->y = y;
					}
					return 0;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700023C")]
			unsafe bool IMouseInputSource.enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60003B4")]
				[Cpp2IlInjected.Address(RVA = "0x1EA3240", Offset = "0x1EA1C40", VA = "0x181EA3240", Slot = "5")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					int num = 0;
					if (Time.frameCount != m_LastUpdatedFrame)
					{
						int num2 = 0;
						int frameCount = Time.frameCount;
						Vector2 mousePosition = m_MousePosition;
						float y = m_MousePosition.y;
						m_MousePositionPrev = mousePosition;
						((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
						m_LastUpdatedFrame = frameCount;
						Vector3 mousePosition2 = Input.mousePosition;
						m_MousePosition = (Vector2)y;
						((Vector2*)(IntPtr)m_MousePosition)->y = y;
					}
					return true;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700023D")]
			unsafe bool IMouseInputSource.locked
			{
				[Cpp2IlInjected.Token(Token = "0x60003B5")]
				[Cpp2IlInjected.Address(RVA = "0x1EA32A0", Offset = "0x1EA1CA0", VA = "0x181EA32A0", Slot = "6")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					int num = 0;
					if (Time.frameCount != m_LastUpdatedFrame)
					{
						int num2 = 0;
						int frameCount = Time.frameCount;
						Vector2 mousePosition = m_MousePosition;
						float y = m_MousePosition.y;
						m_MousePositionPrev = mousePosition;
						((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
						m_LastUpdatedFrame = frameCount;
						Vector3 mousePosition2 = Input.mousePosition;
						m_MousePosition = (Vector2)y;
						((Vector2*)(IntPtr)m_MousePosition)->y = y;
					}
					int num3 = 0;
					return Cursor.lockState == CursorLockMode.Locked;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700023E")]
			unsafe int IMouseInputSource.buttonCount
			{
				[Cpp2IlInjected.Token(Token = "0x60003B6")]
				[Cpp2IlInjected.Address(RVA = "0x1EA31E0", Offset = "0x1EA1BE0", VA = "0x181EA31E0", Slot = "7")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					int num = 0;
					if (Time.frameCount != m_LastUpdatedFrame)
					{
						int num2 = 0;
						int frameCount = Time.frameCount;
						Vector2 mousePosition = m_MousePosition;
						float y = m_MousePosition.y;
						m_MousePositionPrev = mousePosition;
						((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
						m_LastUpdatedFrame = frameCount;
						Vector3 mousePosition2 = Input.mousePosition;
						m_MousePosition = (Vector2)y;
						((Vector2*)(IntPtr)m_MousePosition)->y = y;
					}
					return 3;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700023F")]
			unsafe Vector2 IMouseInputSource.screenPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60003BA")]
				[Cpp2IlInjected.Address(RVA = "0x1EA33F0", Offset = "0x1EA1DF0", VA = "0x181EA33F0", Slot = "11")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					int num = 0;
					if (Time.frameCount != m_LastUpdatedFrame)
					{
						int num2 = 0;
						int frameCount = Time.frameCount;
						Vector2 mousePosition = m_MousePosition;
						float y = m_MousePosition.y;
						m_MousePositionPrev = mousePosition;
						((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
						m_LastUpdatedFrame = frameCount;
						Vector3 mousePosition2 = Input.mousePosition;
						m_MousePosition = (Vector2)y;
						((Vector2*)(IntPtr)m_MousePosition)->y = y;
					}
					Vector3 mousePosition3 = Input.mousePosition;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000240")]
			unsafe Vector2 IMouseInputSource.screenPositionDelta
			{
				[Cpp2IlInjected.Token(Token = "0x60003BB")]
				[Cpp2IlInjected.Address(RVA = "0x1EA3370", Offset = "0x1EA1D70", VA = "0x181EA3370", Slot = "12")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					do
					{
						int num = 0;
					}
					while (Time.frameCount == m_LastUpdatedFrame);
					int num2 = 0;
					int frameCount = Time.frameCount;
					Vector2 mousePosition = m_MousePosition;
					float y = m_MousePosition.y;
					m_MousePositionPrev = mousePosition;
					((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
					m_LastUpdatedFrame = frameCount;
					Vector3 mousePosition2 = Input.mousePosition;
					m_MousePosition = (Vector2)y;
					((Vector2*)(IntPtr)m_MousePosition)->y = y;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000241")]
			unsafe Vector2 IMouseInputSource.wheelDelta
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x1EA3470", Offset = "0x1EA1E70", VA = "0x181EA3470", Slot = "13")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					int num = 0;
					if (Time.frameCount != m_LastUpdatedFrame)
					{
						int num2 = 0;
						int frameCount = Time.frameCount;
						Vector2 mousePosition = m_MousePosition;
						float y = m_MousePosition.y;
						m_MousePositionPrev = mousePosition;
						((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
						m_LastUpdatedFrame = frameCount;
						Vector3 mousePosition2 = Input.mousePosition;
						m_MousePosition = (Vector2)y;
						((Vector2*)(IntPtr)m_MousePosition)->y = y;
					}
					int num3 = 0;
					return Input.mouseScrollDelta;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000242")]
			unsafe bool ITouchInputSource.touchSupported
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x1EA35E0", Offset = "0x1EA1FE0", VA = "0x181EA35E0", Slot = "15")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					int num = 0;
					if (Time.frameCount != m_LastUpdatedFrame)
					{
						int num2 = 0;
						int frameCount = Time.frameCount;
						Vector2 mousePosition = m_MousePosition;
						float y = m_MousePosition.y;
						m_MousePositionPrev = mousePosition;
						((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
						m_LastUpdatedFrame = frameCount;
						Vector3 mousePosition2 = Input.mousePosition;
						m_MousePosition = (Vector2)y;
						((Vector2*)(IntPtr)m_MousePosition)->y = y;
					}
					int num3 = 0;
					return Input.touchSupported;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000243")]
			unsafe int ITouchInputSource.touchCount
			{
				[Cpp2IlInjected.Token(Token = "0x60003BE")]
				[Cpp2IlInjected.Address(RVA = "0x1EA3580", Offset = "0x1EA1F80", VA = "0x181EA3580", Slot = "16")]
				get
				{
					//IL_003a: Expected native int or pointer, but got O
					//IL_0055: Expected O, but got F4
					//IL_005d: Expected native int or pointer, but got O
					int num = 0;
					if (Time.frameCount != m_LastUpdatedFrame)
					{
						int num2 = 0;
						int frameCount = Time.frameCount;
						Vector2 mousePosition = m_MousePosition;
						float y = m_MousePosition.y;
						m_MousePositionPrev = mousePosition;
						((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
						m_LastUpdatedFrame = frameCount;
						Vector3 mousePosition2 = Input.mousePosition;
						m_MousePosition = (Vector2)y;
						((Vector2*)(IntPtr)m_MousePosition)->y = y;
					}
					int num3 = 0;
					return Input.touchCount;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x1EA3090", Offset = "0x1EA1A90", VA = "0x181EA3090", Slot = "8")]
			unsafe bool IMouseInputSource.GetButtonDown(int button)
			{
				//IL_003a: Expected native int or pointer, but got O
				//IL_0055: Expected O, but got F4
				//IL_005d: Expected native int or pointer, but got O
				int num = 0;
				if (Time.frameCount != m_LastUpdatedFrame)
				{
					int num2 = 0;
					int frameCount = Time.frameCount;
					Vector2 mousePosition = m_MousePosition;
					float y = m_MousePosition.y;
					m_MousePositionPrev = mousePosition;
					((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
					m_LastUpdatedFrame = frameCount;
					Vector3 mousePosition2 = Input.mousePosition;
					m_MousePosition = (Vector2)y;
					((Vector2*)(IntPtr)m_MousePosition)->y = y;
				}
				return Input.GetMouseButtonDown(button);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x1EA3100", Offset = "0x1EA1B00", VA = "0x181EA3100", Slot = "9")]
			unsafe bool IMouseInputSource.GetButtonUp(int button)
			{
				//IL_003a: Expected native int or pointer, but got O
				//IL_0055: Expected O, but got F4
				//IL_005d: Expected native int or pointer, but got O
				int num = 0;
				if (Time.frameCount != m_LastUpdatedFrame)
				{
					int num2 = 0;
					int frameCount = Time.frameCount;
					Vector2 mousePosition = m_MousePosition;
					float y = m_MousePosition.y;
					m_MousePositionPrev = mousePosition;
					((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
					m_LastUpdatedFrame = frameCount;
					Vector3 mousePosition2 = Input.mousePosition;
					m_MousePosition = (Vector2)y;
					((Vector2*)(IntPtr)m_MousePosition)->y = y;
				}
				return Input.GetMouseButtonUp(button);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x1EA3170", Offset = "0x1EA1B70", VA = "0x181EA3170", Slot = "10")]
			unsafe bool IMouseInputSource.GetButton(int button)
			{
				//IL_003a: Expected native int or pointer, but got O
				//IL_0055: Expected O, but got F4
				//IL_005d: Expected native int or pointer, but got O
				int num = 0;
				if (Time.frameCount != m_LastUpdatedFrame)
				{
					int num2 = 0;
					int frameCount = Time.frameCount;
					Vector2 mousePosition = m_MousePosition;
					float y = m_MousePosition.y;
					m_MousePositionPrev = mousePosition;
					((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
					m_LastUpdatedFrame = frameCount;
					Vector3 mousePosition2 = Input.mousePosition;
					m_MousePosition = (Vector2)y;
					((Vector2*)(IntPtr)m_MousePosition)->y = y;
				}
				return Input.GetMouseButton(button);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x1EA34D0", Offset = "0x1EA1ED0", VA = "0x181EA34D0", Slot = "17")]
			Touch ITouchInputSource.GetTouch(int index)
			{
				//IL_0036: Expected O, but got F4
				int num = 0;
				int frameCount = Time.frameCount;
				int num2 = 0;
				int frameCount2 = Time.frameCount;
				Vector3 mousePosition = Input.mousePosition;
				Touch touch = default(Touch);
				float y = touch.m_RawPosition.y;
				int tapCount = touch.m_TapCount;
				m_MousePosition = (Vector2)y;
				float maximumPossiblePressure = touch.m_maximumPossiblePressure;
				float azimuthAngle = touch.m_AzimuthAngle;
				m_LastUpdatedFrame = tapCount;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x1EA3640", Offset = "0x1EA2040", VA = "0x181EA3640")]
			private unsafe void TryUpdate()
			{
				//IL_003a: Expected native int or pointer, but got O
				//IL_0055: Expected O, but got F4
				//IL_005d: Expected native int or pointer, but got O
				int num = 0;
				if (Time.frameCount != m_LastUpdatedFrame)
				{
					int num2 = 0;
					int frameCount = Time.frameCount;
					Vector2 mousePosition = m_MousePosition;
					float y = m_MousePosition.y;
					m_MousePositionPrev = mousePosition;
					((Vector2*)(IntPtr)m_MousePositionPrev)->y = y;
					m_LastUpdatedFrame = frameCount;
					Vector3 mousePosition2 = Input.mousePosition;
					m_MousePosition = (Vector2)y;
					((Vector2*)(IntPtr)m_MousePosition)->y = y;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x1EA36A0", Offset = "0x1EA20A0", VA = "0x181EA36A0")]
			public UnityInputSource()
			{
			}//IL_0010: Expected I4, but got I8

		}

		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public const int kMouseLeftId = -1;

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public const int kMouseRightId = -2;

		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public const int kMouseMiddleId = -3;

		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public const int kFakeTouchesId = -4;

		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private const int customButtonsStartingId = -2147483520;

		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private const int customButtonsMaxCount = 128;

		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private const int customButtonsLastId = -2147483392;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly List<IMouseInputSource> m_MouseInputSourcesList = (List<IMouseInputSource>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData = (Dictionary<int, Dictionary<int, PlayerPointerEventData>[]>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private ITouchInputSource m_UserDefaultTouchInputSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private UnityInputSource __m_DefaultInputSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private readonly MouseState m_MouseState = new MouseState
		{
			m_TrackedButtons = (List<ButtonState>)(object)new List<T>()
		};

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		private UnityInputSource defaultInputSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x1E9B1A0", Offset = "0x1E99BA0", VA = "0x181E9B1A0")]
			get
			{
				//IL_0021: Expected I4, but got I8
				UnityInputSource _m_DefaultInputSource = __m_DefaultInputSource;
				if (_m_DefaultInputSource == null)
				{
					UnityInputSource unityInputSource = new UnityInputSource();
					unityInputSource.m_LastUpdatedFrame = -1;
					__m_DefaultInputSource = unityInputSource;
				}
				return _m_DefaultInputSource;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		private IMouseInputSource defaultMouseInputSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x1E9B220", Offset = "0x1E99C20", VA = "0x181E9B220")]
			get
			{
				UnityInputSource unityInputSource = defaultInputSource;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		protected ITouchInputSource defaultTouchInputSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x1E9B220", Offset = "0x1E99C20", VA = "0x181E9B220")]
			get
			{
				UnityInputSource unityInputSource = defaultInputSource;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		protected virtual bool isMouseSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x1E9B230", Offset = "0x1E99C30", VA = "0x181E9B230", Slot = "26")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A1B0", Offset = "0x1E98BB0", VA = "0x181E9A1B0")]
		protected bool IsDefaultMouse(IMouseInputSource mouse)
		{
			return defaultInputSource == mouse;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1E98C00", Offset = "0x1E97600", VA = "0x181E98C00")]
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A8D0", Offset = "0x1E992D0", VA = "0x181E9A8D0")]
		public void RemoveMouseInputSource(IMouseInputSource source)
		{
			if (source != null)
			{
				bool flag = ((List<T>)(object)m_MouseInputSourcesList).Remove((T)source);
				return;
			}
			ArgumentNullException ex = new ArgumentNullException("source");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1E98040", Offset = "0x1E96A40", VA = "0x181E98040")]
		public void AddMouseInputSource(IMouseInputSource source)
		{
			if (!UnityTools.IsNullOrDestroyed(source))
			{
				((List<T>)(object)m_MouseInputSourcesList).Add((T)source);
				return;
			}
			ArgumentNullException ex = new ArgumentNullException("source");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1E98A80", Offset = "0x1E97480", VA = "0x181E98A80")]
		public int GetMouseInputSourceCount(int playerId)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1E99E60", Offset = "0x1E98860", VA = "0x181E99E60")]
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
		{
			if (UnityTools.IsNullOrDestroyed(m_UserDefaultTouchInputSource))
			{
				UnityInputSource unityInputSource = defaultInputSource;
			}
			return m_UserDefaultTouchInputSource;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x1E9AA30", Offset = "0x1E99430", VA = "0x181E9AA30")]
		public void RemoveTouchInputSource(ITouchInputSource source)
		{
			if (source != null)
			{
				return;
			}
			ArgumentNullException ex = new ArgumentNullException("source");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1E98130", Offset = "0x1E96B30", VA = "0x181E98130")]
		public void AddTouchInputSource(ITouchInputSource source)
		{
			if (!UnityTools.IsNullOrDestroyed(source))
			{
				m_UserDefaultTouchInputSource = source;
			}
			ArgumentNullException ex = new ArgumentNullException("source");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1E99E30", Offset = "0x1E98830", VA = "0x181E99E30")]
		public int GetTouchInputSourceCount(int playerId)
		{
			bool flag = IsDefaultPlayer(playerId);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1E98200", Offset = "0x1E96C00", VA = "0x181E98200")]
		protected void ClearMouseInputSources()
		{
			//Discarded unreachable code: IL_000c
			((List<T>)(object)m_MouseInputSourcesList).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract bool IsDefaultPlayer(int playerId);

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1E99760", Offset = "0x1E98160", VA = "0x181E99760")]
		protected unsafe bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
		{
			//Discarded unreachable code: IL_007f, IL_008e, IL_009c, IL_00a5, IL_00c5, IL_00cd, IL_00d8, IL_0124, IL_012d, IL_014d, IL_0156, IL_017b, IL_01a1, IL_01a7
			//IL_0011: Expected O, but got I4
			//IL_00bd: Expected I4, but got I8
			//IL_00f6: Expected I4, but got I8
			//IL_0145: Expected I4, but got I8
			//IL_0184: Expected I4, but got O
			//IL_018e: Expected I4, but got I8
			//IL_0198: Expected I4, but got I8
			//IL_01a1: Expected I4, but got O
			while (true)
			{
				Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> playerPointerData = m_PlayerPointerData;
				int num = 0;
				if (!((Dictionary<TKey, TValue>)(object)playerPointerData).TryGetValue((TKey)playerId, out *(TValue*)num))
				{
					Dictionary<int, PlayerPointerEventData>[] array = new Dictionary<int, PlayerPointerEventData>[pointerIndex + 1];
					if (num < array.Length)
					{
						Dictionary<int, PlayerPointerEventData> dictionary = (Dictionary<int, PlayerPointerEventData>)(object)new Dictionary<TKey, TValue>();
						if (dictionary != null && dictionary == null)
						{
							continue;
						}
						num += 4;
						num++;
					}
					Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> playerPointerData2 = m_PlayerPointerData;
					throw new NullReferenceException();
				}
				Dictionary<int, PlayerPointerEventData>[] array2 = new Dictionary<int, PlayerPointerEventData>[pointerIndex + 1];
				if (num != 0)
				{
					num++;
					while (num != 0)
					{
					}
					Dictionary<int, PlayerPointerEventData> dictionary2 = (Dictionary<int, PlayerPointerEventData>)(object)new Dictionary<TKey, TValue>();
					if (dictionary2 == null || dictionary2 != null)
					{
						break;
					}
				}
			}
			Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> playerPointerData3 = m_PlayerPointerData;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1E98630", Offset = "0x1E97030", VA = "0x181E98630")]
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
		{
			//IL_001c: Expected I4, but got I8
			//IL_0077: Expected I4, but got I8
			//IL_0080: Expected I4, but got I8
			//IL_0089: Expected I4, but got I8
			PlayerPointerEventData playerPointerEventData = new PlayerPointerEventData(base.m_EventSystem);
			playerPointerEventData.buttonIndex = -1;
			playerPointerEventData.playerId = playerId;
			playerPointerEventData.inputSourceIndex = pointerIndex;
			((PointerEventData)playerPointerEventData).pointerId = pointerTypeId;
			playerPointerEventData.sourceType = PointerEventType.Mouse;
			ITouchInputSource touchInputSource = GetTouchInputSource(playerId, pointerIndex);
			IMouseInputSource mouseInputSource = (playerPointerEventData.mouseSource = GetMouseInputSource(playerId, pointerIndex));
			if (pointerTypeId != -1)
			{
				if (pointerTypeId != -2)
				{
					if (pointerTypeId != -3)
					{
						if (pointerTypeId > 128)
						{
							goto IL_0089;
						}
						playerPointerEventData.buttonIndex = pointerTypeId;
					}
					playerPointerEventData.buttonIndex = 2;
				}
				playerPointerEventData.buttonIndex = 1;
			}
			playerPointerEventData.buttonIndex = 0;
			goto IL_0089;
			IL_0089:
			return playerPointerEventData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A980", Offset = "0x1E99380", VA = "0x181E9A980")]
		protected void RemovePointerData(PlayerPointerEventData data)
		{
			//Discarded unreachable code: IL_001b
			Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> playerPointerData = m_PlayerPointerData;
			bool flag = default(bool);
			if (flag)
			{
				int _003CinputSourceIndex_003Ek__BackingField = data.inputSourceIndex;
				int _003CpointerId_003Ek__BackingField = ((PointerEventData)data).pointerId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1E99EF0", Offset = "0x1E988F0", VA = "0x181E99EF0")]
		protected unsafe PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
		{
			int fingerId = ((Touch*)input)->fingerId;
			bool flag = default(bool);
			if (flag)
			{
			}
			TouchPhase phase = ((Touch*)input)->phase;
			if (((Touch*)input)->phase != TouchPhase.Canceled)
			{
				TouchPhase phase2 = ((Touch*)input)->phase;
			}
			if (flag)
			{
				Vector2 position = ((Touch*)input)->position;
			}
			Vector2 position2 = ((Touch*)input)->position;
			int num = 0;
			Vector2 zero = Vector2.zero;
			Vector2 position3 = ((Touch*)input)->position;
			EventSystem eventSystem = base.m_EventSystem;
			RaycastResult raycastResult = default(RaycastResult);
			float distance = raycastResult.distance;
			int sortingOrder = raycastResult.sortingOrder;
			Vector3 worldNormal = raycastResult.worldNormal;
			((List<T>)(object)m_RaycastResultCache).Clear();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1E98E00", Offset = "0x1E97800", VA = "0x181E98E00", Slot = "28")]
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
		{
			//IL_0045: Expected I, but got F4
			//IL_0057: Expected O, but got I4
			//IL_0069: Expected I4, but got O
			//IL_007f: Expected I, but got O
			//IL_0087: Expected O, but got I4
			//IL_009a: Expected I, but got O
			//IL_00a2: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			//IL_0143: Expected O, but got I4
			//IL_01d7: Expected O, but got I4
			int num = 0;
			if (GetMouseInputSource(playerId, mouseIndex) != null)
			{
				Awake();
				bool flag = default(bool);
				if (flag)
				{
				}
				if (flag || flag)
				{
				}
				int num2 = 0;
				Vector2 zero = Vector2.zero;
				EventSystem eventSystem = base.m_EventSystem;
				RaycastResult raycastResult = default(RaycastResult);
				float distance = raycastResult.distance;
				((UnityEngine.Object)eventSystem).m_CachedPtr = (IntPtr)distance;
				int sortingOrder = raycastResult.sortingOrder;
				eventSystem.m_CurrentInputModule = (BaseInputModule)sortingOrder;
				Vector3 worldNormal = raycastResult.worldNormal;
				eventSystem.m_sendNavigationEvents = (byte)(int)worldNormal != 0;
				((List<T>)(object)m_RaycastResultCache).Clear();
				int num3 = 0;
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)worldNormal;
				base.m_AxisEventData = (AxisEventData)sortingOrder;
				base.m_BaseEventData = (BaseEventData)worldNormal;
				int num4 = 0;
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)worldNormal;
				base.m_AxisEventData = (AxisEventData)sortingOrder;
				base.m_BaseEventData = (BaseEventData)worldNormal;
				uint num5 = default(uint);
				if (num < (int)num5)
				{
					num += num;
					num++;
				}
				uint num6 = default(uint);
				if ((int)num6 < num)
				{
					int num7 = 0;
					num6++;
					int num8 = 0;
					num7 += num7;
				}
				MouseState mouseState = m_MouseState;
				int num9 = 0;
				PointerEventData.FramePressState framePressState = default(PointerEventData.FramePressState);
				int buttonState = (int)framePressState;
				int button = 0;
				ButtonState buttonState2 = mouseState.GetButtonState(button);
				buttonState2.m_EventData.buttonState = (PointerEventData.FramePressState)buttonState;
				buttonState2.m_EventData.buttonData = (PlayerPointerEventData)num6;
				MouseState mouseState2 = m_MouseState;
				uint buttonId = default(uint);
				int buttonState3 = (int)StateForMouseButton(playerId, mouseIndex, (int)buttonId);
				ButtonState buttonState4 = mouseState2.GetButtonState(1);
				buttonState4.m_EventData.buttonState = (PointerEventData.FramePressState)buttonState3;
				buttonState4.m_EventData.buttonData = (PlayerPointerEventData)num6;
				MouseState mouseState3 = m_MouseState;
				uint buttonId2 = default(uint);
				int buttonState5 = (int)StateForMouseButton(playerId, mouseIndex, (int)buttonId2);
				ButtonState buttonState6 = mouseState3.GetButtonState(2);
				buttonState6.m_EventData.buttonState = (PointerEventData.FramePressState)buttonState5;
				buttonState6.m_EventData.buttonData = (PlayerPointerEventData)(object)mouseState2;
				int num10 = 0;
				uint num11 = default(uint);
				if (num10 < (int)num11)
				{
					num10 += num10;
					num10++;
				}
				uint num12 = default(uint);
				if ((int)num12 < num10)
				{
					MouseState mouseState4 = m_MouseState;
					int num13 = 0;
					int buttonState7 = (int)StateForMouseButton(playerId, mouseIndex, (int)num12);
					ButtonState buttonState8 = mouseState4.GetButtonState((int)num12);
					buttonState8.m_EventData.buttonState = (PointerEventData.FramePressState)buttonState7;
					buttonState8.m_EventData.buttonData = (PlayerPointerEventData)num12;
					num12++;
					num12 += num12;
				}
				return m_MouseState;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x1E98860", Offset = "0x1E97260", VA = "0x181E98860")]
		protected unsafe PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
		{
			//IL_000f: Expected O, but got I4
			bool flag = default(bool);
			uint num2 = default(uint);
			while (true)
			{
				int num = 0;
				if (((Dictionary<TKey, TValue>)(object)m_PlayerPointerData).TryGetValue((TKey)playerId, out *(TValue*)num))
				{
					if (flag)
					{
					}
					if (num2 != 0)
					{
						/*Error: Could not find block for branch target IL_001b*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x1E9AAB0", Offset = "0x1E994B0", VA = "0x181E9AAB0")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			if (useDragThreshold)
			{
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A7B0", Offset = "0x1E991B0", VA = "0x181E9A7B0", Slot = "29")]
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
		{
			//Discarded unreachable code: IL_003f
			//IL_003e: Expected O, but got I4
			PointerEventType _003CsourceType_003Ek__BackingField = pointerEvent.sourceType;
			if (_003CsourceType_003Ek__BackingField == PointerEventType.Mouse || _003CsourceType_003Ek__BackingField == PointerEventType.Touch)
			{
				int _003CinputSourceIndex_003Ek__BackingField = pointerEvent.inputSourceIndex;
				int _003CplayerId_003Ek__BackingField = pointerEvent.playerId;
				IMouseInputSource mouseInputSource = GetMouseInputSource(_003CplayerId_003Ek__BackingField, _003CinputSourceIndex_003Ek__BackingField);
				if (mouseInputSource == null || mouseInputSource == null || mouseInputSource == null)
				{
				}
				int num = 0;
				HandlePointerExitAndEnter(pointerEvent, (GameObject)num);
				return;
			}
			NotImplementedException ex = new NotImplementedException();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A420", Offset = "0x1E98E20", VA = "0x181E9A420", Slot = "30")]
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
		{
			//Discarded unreachable code: IL_00e4
			//IL_001c: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			if (!pointerEvent.IsPointerMoving())
			{
				return;
			}
			GameObject _003CpointerDrag_003Ek__BackingField = ((PointerEventData)pointerEvent).pointerDrag;
			int num = 0;
			if (_003CpointerDrag_003Ek__BackingField == (UnityEngine.Object)num)
			{
				return;
			}
			if (pointerEvent.sourceType == PointerEventType.Mouse)
			{
				int _003CinputSourceIndex_003Ek__BackingField = pointerEvent.inputSourceIndex;
				int _003CplayerId_003Ek__BackingField = pointerEvent.playerId;
				IMouseInputSource mouseInputSource = GetMouseInputSource(_003CplayerId_003Ek__BackingField, _003CinputSourceIndex_003Ek__BackingField);
				if (mouseInputSource == null || mouseInputSource != null || mouseInputSource == null)
				{
					return;
				}
			}
			EventSystem eventSystem = base.m_EventSystem;
			Vector2 _003CpressPosition_003Ek__BackingField = ((PointerEventData)pointerEvent).pressPosition;
			if ((object)eventSystem != null)
			{
				GameObject _003CpointerDrag_003Ek__BackingField2 = ((PointerEventData)pointerEvent).pointerDrag;
				ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler = ExecuteEvents.s_BeginDragHandler;
				bool flag = ExecuteEvents.Execute<IBeginDragHandler>(_003CpointerDrag_003Ek__BackingField2, pointerEvent, (ExecuteEvents.EventFunction<>)(object)s_BeginDragHandler);
				((PointerEventData)pointerEvent).dragging = true;
			}
			GameObject pointerPress = ((PointerEventData)pointerEvent).m_PointerPress;
			GameObject _003CpointerDrag_003Ek__BackingField3 = ((PointerEventData)pointerEvent).pointerDrag;
			if (pointerPress != _003CpointerDrag_003Ek__BackingField3)
			{
				GameObject pointerPress2 = ((PointerEventData)pointerEvent).m_PointerPress;
				((PointerEventData)pointerEvent).eligibleForClick = false;
				int num2 = 0;
				pointerEvent.pointerPress = (GameObject)num2;
			}
			GameObject _003CpointerDrag_003Ek__BackingField4 = ((PointerEventData)pointerEvent).pointerDrag;
			ExecuteEvents.EventFunction<IDragHandler> s_DragHandler = ExecuteEvents.s_DragHandler;
			bool flag2 = ExecuteEvents.Execute<IDragHandler>(_003CpointerDrag_003Ek__BackingField4, pointerEvent, (ExecuteEvents.EventFunction<>)(object)s_DragHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A1D0", Offset = "0x1E98BD0", VA = "0x181E9A1D0", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerTypeId)
		{
			//Discarded unreachable code: IL_0030, IL_0036, IL_003c, IL_0042
			int num = 0;
			int num2 = 0;
			Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> playerPointerData = m_PlayerPointerData;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				if (flag2 && flag3)
				{
					num++;
				}
				num++;
			}
			if (num + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x1E98250", Offset = "0x1E96C50", VA = "0x181E98250")]
		protected void ClearSelection()
		{
			//Discarded unreachable code: IL_0029, IL_002f, IL_0035, IL_003b, IL_0041, IL_0047
			int num = 0;
			int num2 = 0;
			BaseEventData baseEventData = GetBaseEventData();
			Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> playerPointerData = m_PlayerPointerData;
			bool flag = default(bool);
			if (flag)
			{
				int num3 = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				num3++;
			}
			int num4 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E9ABF0", Offset = "0x1E995F0", VA = "0x181E9ABF0", Slot = "3")]
		public override string ToString()
		{
			//Discarded unreachable code: IL_009d, IL_00a3, IL_00a9, IL_00af, IL_00b5
			//IL_0024: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Type type = GetType();
			if ((object)type != null)
			{
				string text = type.ToString();
			}
			StringBuilder stringBuilder = new StringBuilder("<b>Pointer Input Module of type: </b>" + (string)num);
			StringBuilder stringBuilder2 = stringBuilder.AppendLine();
			Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> playerPointerData = m_PlayerPointerData;
			bool flag = default(bool);
			if (flag)
			{
				string text2 = default(string);
				string value = "<B>Player Id:</b> " + text2;
				StringBuilder stringBuilder3 = stringBuilder.AppendLine(value);
				string text3 = default(string);
				string value2 = "<B>Pointer Index:</b> " + text3;
				StringBuilder stringBuilder4 = stringBuilder.AppendLine(value2);
				bool flag2 = default(bool);
				if (flag2)
				{
					string text4 = default(string);
					string value3 = "<B>Button Id:</b> " + text4;
					StringBuilder stringBuilder5 = stringBuilder.AppendLine(value3);
				}
				num++;
			}
			return stringBuilder.ToString();
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E98770", Offset = "0x1E97170", VA = "0x181E98770")]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			//Discarded unreachable code: IL_002f
			//IL_002e: Expected O, but got I4
			GameObject eventHandler = ExecuteEvents.GetEventHandler<ISelectHandler>(currentOverGo);
			GameObject currentSelected = base.m_EventSystem.m_CurrentSelected;
			if (eventHandler != currentSelected)
			{
				EventSystem eventSystem = base.m_EventSystem;
				int num = 0;
				eventSystem.SetSelectedGameObject((GameObject)num, pointerEvent);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E98540", Offset = "0x1E96F40", VA = "0x181E98540")]
		protected unsafe void CopyFromTo(PointerEventData from, PointerEventData to)
		{
			//IL_0021: Expected native int or pointer, but got O
			//IL_0047: Expected native int or pointer, but got O
			//IL_0071: Expected native int or pointer, but got O
			//IL_009b: Expected O, but got F4
			//IL_00b0: Expected O, but got I4
			Vector2 _003Cposition_003Ek__BackingField = from.position;
			float y = from.position.y;
			to.position = _003Cposition_003Ek__BackingField;
			((Vector2*)(IntPtr)to.position)->y = y;
			Vector2 _003Cdelta_003Ek__BackingField = from.delta;
			float y2 = from.delta.y;
			to.delta = _003Cdelta_003Ek__BackingField;
			((Vector2*)(IntPtr)to.delta)->y = y2;
			Vector2 _003CscrollDelta_003Ek__BackingField = from.scrollDelta;
			float y3 = from.scrollDelta.y;
			to.scrollDelta = _003CscrollDelta_003Ek__BackingField;
			((Vector2*)(IntPtr)to.scrollDelta)->y = y3;
			RaycastResult raycastResult = (to.pointerCurrentRaycast = from.pointerCurrentRaycast);
			float distance = from.pointerCurrentRaycast.distance;
			to.pointerCurrentRaycast = (RaycastResult)distance;
			int sortingOrder = from.pointerCurrentRaycast.sortingOrder;
			to.pointerCurrentRaycast = (RaycastResult)sortingOrder;
			Vector3 vector = (Vector3)(to.pointerCurrentRaycast = (RaycastResult)from.pointerCurrentRaycast.worldNormal);
			GameObject gameObject = (to.pointerEnter = from.pointerEnter);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x1E9AB20", Offset = "0x1E99520", VA = "0x181E9AB20")]
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
		{
			IMouseInputSource mouseInputSource = GetMouseInputSource(playerId, mouseIndex);
			if (mouseInputSource == null || mouseInputSource != null || mouseInputSource == null)
			{
			}
			return PointerEventData.FramePressState.NotChanged;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E9B050", Offset = "0x1E99A50", VA = "0x181E9B050")]
		protected RewiredPointerInputModule()
		{
		}
	}
}
