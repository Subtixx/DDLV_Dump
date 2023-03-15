using System;
using Cpp2IlInjected;
using UnityEngine;

namespace LeoLuz
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[RequireComponent(typeof(Canvas))]
	public class AnalogicKnob : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[InputAxesListDropdown(false)]
		public string HorizontalAxis = "Horizontal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[InputAxesListDropdown(false)]
		public string VerticalAxis = "Vertical";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float _sensitivity = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public RectTransform AnalogicKnobObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public RectTransform RootCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[HideInInspector]
		public float XNormalScope = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[HideInInspector]
		public float YNormalScope = 0.6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private Vector2 StartPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Vector2 CurrentKnobPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Vector2 RawAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[ReadOnly]
		public Vector2 NormalizedAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private float ReturnSpeed = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private Vector2 ScreenPixels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private Vector2 CanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Vector2 ProportionPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Vector2 AnalogicStartPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Touch AnalogTouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private bool Released;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private Vector2 lastFrameNormalizedAxis;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2F06B90", Offset = "0x2F05590", VA = "0x182F06B90")]
		public void OnDrawGizmosSelected()
		{
			int num = 0;
			Input.Autoconfigure();
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2F06BE0", Offset = "0x2F055E0", VA = "0x182F06BE0")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_0112
			//IL_0026: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			//IL_0081: Expected F4, but got I4
			//IL_007c: Expected native int or pointer, but got O
			//IL_009f: Expected F4, but got O
			//IL_009a: Expected native int or pointer, but got O
			//IL_00c8: Expected F4, but got I4
			//IL_00c3: Expected native int or pointer, but got O
			//IL_00d4: Expected F4, but got I4
			//IL_00cf: Expected native int or pointer, but got O
			//IL_00eb: Expected O, but got F4
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected O, but got Unknown
			//IL_00f6: Expected F4, but got O
			//IL_0106: Expected O, but got F4
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected F4, but got Unknown
			Input.RegisterAxisMobile(VerticalAxis);
			Input.RegisterAxisMobile(HorizontalAxis);
			RectTransform analogicKnobObject = AnalogicKnobObject;
			int num = 0;
			if (analogicKnobObject == (UnityEngine.Object)num)
			{
				Debug.Log("Specify the object of the knob");
			}
			RectTransform rootCanvas = RootCanvas;
			int num2 = 0;
			if (rootCanvas == (UnityEngine.Object)num2)
			{
				Debug.Log("Specify the object of the knob");
			}
			RectTransform component = RootCanvas.GetComponent<RectTransform>();
			Vector2 anchoredPosition = AnalogicKnobObject.anchoredPosition;
			int num3 = 0;
			AnalogicStartPosition = anchoredPosition;
			((Vector2*)(IntPtr)AnalogicStartPosition)->y = 0f;
			int width = Screen.width;
			int num4 = 0;
			int height = Screen.height;
			((Vector2*)(IntPtr)ScreenPixels)->y = (float)anchoredPosition;
			Debug.Log(component.name);
			Vector2 proportionPercent = (CanvasSize = component.sizeDelta);
			((Vector2*)(IntPtr)CanvasSize)->y = 0f;
			((Vector2*)(IntPtr)ProportionPercent)->y = 0f;
			float xNormalScope = XNormalScope;
			ProportionPercent = proportionPercent;
			Vector2 screenPixels = ((AnalogicKnob)xNormalScope).ScreenPixels;
			Vector2 vector = /*Error near IL_00ec: Stack underflow*/* screenPixels;
			XNormalScope = (float)vector;
			float yNormalScope = ((AnalogicKnob)ScreenPixels.y).YNormalScope;
			float num5 = (YNormalScope = /*Error near IL_0107: Stack underflow*/* yNormalScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2F06E70", Offset = "0x2F05870", VA = "0x182F06E70")]
		private unsafe void Update()
		{
			//Discarded unreachable code: IL_0198
			//IL_0023: Expected native int or pointer, but got O
			//IL_0079: Expected O, but got I4
			//IL_0083: Expected O, but got F4
			//IL_008e: Expected native int or pointer, but got O
			//IL_00ce: Expected O, but got F4
			//IL_00d6: Expected native int or pointer, but got O
			//IL_00f6: Expected O, but got I4
			//IL_0111: Expected O, but got I4
			//IL_014a: Expected O, but got I4
			Vector2 normalizedAxis = NormalizedAxis;
			float y = NormalizedAxis.y;
			int button = 0;
			lastFrameNormalizedAxis = normalizedAxis;
			((Vector2*)(IntPtr)lastFrameNormalizedAxis)->y = y;
			if (UnityEngine.Input.GetMouseButtonDown(button))
			{
				goto IL_0093;
			}
			int num = 0;
			if (UnityEngine.Input.GetMouseButton(num))
			{
				Vector3 mousePosition = UnityEngine.Input.mousePosition;
				float xNormalScope = XNormalScope;
				Vector3 mousePosition2 = UnityEngine.Input.mousePosition;
				if (!(YNormalScope <= mousePosition2.y))
				{
					Vector3 mousePosition3 = UnityEngine.Input.mousePosition;
					Vector2 vector = Vector2.ClampMagnitude((Vector2)num, 1f);
					NormalizedAxis = (Vector2)xNormalScope;
					((Vector2*)(IntPtr)NormalizedAxis)->y = 1f;
					goto IL_0093;
				}
			}
			goto IL_00f6;
			IL_00f6:
			if (UnityEngine.Input.GetMouseButtonUp(0))
			{
				int num2 = 0;
				Released = true;
				NormalizedAxis = (Vector2)num2;
			}
			if (Released)
			{
				RectTransform analogicKnobObject = AnalogicKnobObject;
				Vector2 anchoredPosition = analogicKnobObject.anchoredPosition;
				int num3 = 0;
				float deltaTime = Time.deltaTime;
				int num4 = 0;
				float num5 = Mathf.Clamp01(deltaTime);
				analogicKnobObject.anchoredPosition = (Vector2)num4;
			}
			string horizontalAxis = HorizontalAxis;
			float y2 = NormalizedAxis.y;
			Input.SetAxisMobile(VerticalAxis, y2);
			Vector2 vector2 = lastFrameNormalizedAxis;
			Input.PressButtonDownMobile(HorizontalAxis);
			float y3 = lastFrameNormalizedAxis.y;
			Input.PressButtonDownMobile(VerticalAxis);
			return;
			IL_0093:
			Vector3 mousePosition4 = UnityEngine.Input.mousePosition;
			float xNormalScope2 = XNormalScope;
			Vector3 mousePosition5 = UnityEngine.Input.mousePosition;
			if (!(YNormalScope <= mousePosition5.y))
			{
				Released = false;
				Vector3 mousePosition6 = UnityEngine.Input.mousePosition;
				StartPosition = (Vector2)xNormalScope2;
				((Vector2*)(IntPtr)StartPosition)->y = xNormalScope2;
				RectTransform analogicKnobObject2 = AnalogicKnobObject;
				int num6 = 0;
				Vector3 mousePosition7 = UnityEngine.Input.mousePosition;
				analogicKnobObject2.anchoredPosition = (Vector2)num6;
			}
			goto IL_00f6;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2F071F0", Offset = "0x2F05BF0", VA = "0x182F071F0")]
		public AnalogicKnob()
		{
		}
	}
}
