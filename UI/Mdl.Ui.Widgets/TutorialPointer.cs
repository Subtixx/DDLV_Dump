using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009B3")]
	public class TutorialPointer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003916")]
		private TutorialWidgetAnchor anchorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003917")]
		public List<Image> blockers = (List<Image>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003918")]
		public RectTransform handAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003919")]
		[HideInInspector]
		public RectTransform self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400391A")]
		[HideInInspector]
		public RectTransform parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400391B")]
		[HideInInspector]
		public RectTransform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400391C")]
		[HideInInspector]
		public Vector3[] worldPoints = new Vector3[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400391D")]
		[HideInInspector]
		public Vector2[] screenPoints = new Vector2[2];

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400391E")]
		[HideInInspector]
		public Vector2[] localPoints = new Vector2[2];

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400391F")]
		private Camera camera;

		[Cpp2IlInjected.Token(Token = "0x1700085A")]
		public TutorialWidgetAnchor AnchorType
		{
			[Cpp2IlInjected.Token(Token = "0x6003CCA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return anchorType;
			}
			[Cpp2IlInjected.Token(Token = "0x6003CCB")]
			[Cpp2IlInjected.Address(RVA = "0x17F51A0", Offset = "0x17F3BA0", VA = "0x1817F51A0")]
			set
			{
				anchorType = value;
				TutorialUtil.AnchorWithRotation(handAnchor, value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CCC")]
		[Cpp2IlInjected.Address(RVA = "0x17F4970", Offset = "0x17F3370", VA = "0x1817F4970")]
		public void Init(RectTransform target, Camera camera, TutorialWidgetAnchor anchorType, bool allowInputOutsideTarget)
		{
			//Discarded unreachable code: IL_0058
			this.target = target;
			this.anchorType = anchorType;
			this.camera = camera;
			RectTransform rectTransform = (self = GetComponent<RectTransform>());
			RectTransform rectTransform2 = (parent = base.transform.parent.GetComponent<RectTransform>());
			UpdatePosition();
			RectTransform rectTransform3 = handAnchor;
			List<Image> list = blockers;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CCD")]
		[Cpp2IlInjected.Address(RVA = "0x17F4B50", Offset = "0x17F3550", VA = "0x1817F4B50")]
		public unsafe void UpdatePosition()
		{
			//Discarded unreachable code: IL_01c3
			//IL_0010: Expected O, but got I4
			//IL_00f8: Expected O, but got I4
			//IL_0136: Expected O, but got I4
			RectTransform rectTransform = target;
			int num = 0;
			if (rectTransform != (Object)num)
			{
				RectTransform rectTransform2 = target;
				Vector3[] fourCornersArray = worldPoints;
				rectTransform2.GetWorldCorners(fourCornersArray);
				RectTransform rectTransform3 = self;
				int num2 = 0;
				Vector2 vector = (rectTransform3.anchorMin = Vector2.zero);
				RectTransform rectTransform4 = self;
				int num3 = 0;
				Vector2 vector2 = (rectTransform4.anchorMax = Vector2.one);
				Vector3[] array = worldPoints;
				Vector2[] array2 = screenPoints;
				Camera camera = this.camera;
				Vector3 vector3 = array[1];
				Vector2 vector4 = default(Vector2);
				array2[0] = vector4;
				Vector3[] array3 = worldPoints;
				Vector2[] array4 = screenPoints;
				Vector3 vector5 = array3[4];
				Camera camera2 = this.camera;
				Vector2 vector6 = default(Vector2);
				array4[1] = vector6;
				Vector2[] array5 = screenPoints;
				Vector2[] array6 = localPoints;
				Vector2 screenPoint = array5[0];
				Vector2 vector7 = array5[0];
				int num4 = 0;
				RectTransform rect = self;
				int num5 = 0;
				bool flag = RectTransformUtility.ScreenPointToLocalPointInRectangle(rect, screenPoint, (Camera)num5, out *(Vector2*)array6);
				Vector2[] array7 = screenPoints;
				Vector2[] array8 = localPoints;
				Vector2 screenPoint2 = array7[1];
				Vector2 vector8 = array7[1];
				RectTransform rect2 = self;
				int num6 = 0;
				bool flag2 = RectTransformUtility.ScreenPointToLocalPointInRectangle(rect2, screenPoint2, (Camera)num6, out *(Vector2*)array8);
				Vector2[] array9 = localPoints;
				RectTransform rectTransform5 = self;
				RectTransform rectTransform6 = parent;
				Vector2 anchorMin = array9[0];
				Vector2[] array10 = localPoints;
				RectTransform rectTransform7 = parent;
				Vector2 vector9 = array10[0];
				rectTransform5.anchorMin = anchorMin;
				Vector2[] array11 = localPoints;
				RectTransform rectTransform8 = self;
				RectTransform rectTransform9 = parent;
				Vector2 anchorMax = array11[1];
				Vector2[] array12 = localPoints;
				RectTransform rectTransform10 = parent;
				Vector2 vector10 = array12[1];
				rectTransform8.anchorMax = anchorMax;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CCE")]
		[Cpp2IlInjected.Address(RVA = "0x17F50B0", Offset = "0x17F3AB0", VA = "0x1817F50B0")]
		public TutorialPointer()
		{
		}
	}
}
