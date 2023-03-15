using Cpp2IlInjected;
using GenericFunctionsPro;
using LeoLuz;
using UnityEngine;

namespace TouchToPcInput
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class TouchScopeToButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[Tooltip("0f is lef, 1 is right, 0 is down, 1 is up")]
		[LargeHeader("Simple Tap Scope", "cyan", 17)]
		public Vector2 StartScopeNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[Tooltip("0f is lef, 1 is right, 0 is down, 1 is up")]
		public Vector2 EndScopeNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[ReadOnly]
		public bool TouchDownOnLastFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[ReadOnly]
		public bool TouchStationaryOnLastFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[ReadOnly]
		public bool MoveTouchEndToNextFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[ReadOnly]
		public bool disableSlide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[ReadOnly]
		public Vector2 TouchBeganPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[ReadOnly]
		public Vector2 TouchMovedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[ReadOnly]
		public Vector2 SwipeDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[ReadOnly]
		public string TouchBeganButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float StationaryDeadZone = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[InputAxesListDropdown(false)]
		public string TouchBeganConvertTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public string TouchStationaryButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[InputAxesListDropdown(false)]
		public string TouchStationaryConvertTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public string TouchEndedButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[InputAxesListDropdown(false)]
		public string TouchEndedConvertTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[InputAxesListDropdown(false)]
		public string SlideAxisHorizontal = "Horizontal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[InputAxesListDropdown(false)]
		public string SlideAxisVertical = "Vertical";

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float PixelsPerAxisUnit = 50f;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Start()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4240", Offset = "0x3DC2C40", VA = "0x183DC4240")]
		private void Update()
		{
			if (!UnityEngine.Input.GetMouseButtonDown(0))
			{
				bool mouseButton = UnityEngine.Input.GetMouseButton(0);
				if (!mouseButton)
				{
					if (TouchStationaryOnLastFrame != mouseButton)
					{
						string touchEndedConvertTo = TouchEndedConvertTo;
						if (TouchDownOnLastFrame != mouseButton)
						{
							TouchDownOnLastFrame = mouseButton;
						}
						Input.PressButtonUpMobile(touchEndedConvertTo);
					}
					return;
				}
				Vector3 mousePosition = UnityEngine.Input.mousePosition;
				float num = default(float);
				if (!(StationaryDeadZone > num))
				{
					string slideAxisHorizontal = SlideAxisHorizontal;
					float y = SwipeDirection.y;
					Input.AxisUpdateMobileOld(SlideAxisVertical, y);
					return;
				}
				TouchStationaryOnLastFrame = true;
				if (!TouchDownOnLastFrame)
				{
					while (disableSlide)
					{
					}
					Input.PressButtonMobile(TouchStationaryConvertTo);
				}
			}
			else
			{
				TouchDownOnLastFrame = true;
				Vector3 mousePosition2 = UnityEngine.Input.mousePosition;
				disableSlide = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4460", Offset = "0x3DC2E60", VA = "0x183DC4460")]
		public TouchScopeToButton()
		{
		}
	}
}
