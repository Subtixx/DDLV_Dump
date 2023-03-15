using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000858")]
	public class RectTransformUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x60034E0")]
		[Cpp2IlInjected.Address(RVA = "0xF40260", Offset = "0xF3EC60", VA = "0x180F40260")]
		public static void SetAlpha(RectTransform root, float alpha)
		{
			//Discarded unreachable code: IL_0032
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(root == (Object)num))
			{
				CanvasRenderer[] componentsInChildren = root.GetComponentsInChildren<CanvasRenderer>();
				int num2 = 0;
				int length = componentsInChildren.Length;
				if (num2 < length)
				{
					componentsInChildren[num2].SetAlpha(alpha);
					num2++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034E1")]
		[Cpp2IlInjected.Address(RVA = "0xF40340", Offset = "0xF3ED40", VA = "0x180F40340")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			//Discarded unreachable code: IL_0067
			Vector2 pivot = from.pivot;
			Rect rect = from.rect;
			Rect rect2 = from.rect;
			Vector2 pivot2 = from.pivot;
			Rect rect3 = from.rect;
			Vector3 position = from.position;
			int num = 0;
			Rect rect4 = to.rect;
			Vector2 pivot3 = to.pivot;
			Rect rect5 = to.rect;
			Rect rect6 = to.rect;
			Vector2 pivot4 = to.pivot;
			Rect rect7 = to.rect;
			return to.anchoredPosition;
		}

		[Cpp2IlInjected.Token(Token = "0x60034E2")]
		[Cpp2IlInjected.Address(RVA = "0xF400D0", Offset = "0xF3EAD0", VA = "0x180F400D0")]
		public static Vector2 GetPosOnUIFrom3D(GameObject obj3D, RectTransform ui)
		{
			//Discarded unreachable code: IL_0047
			int num = 0;
			Camera main = Camera.main;
			Transform transform = obj3D.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			RectTransform component = ui.GetComponentInParent<Canvas>().GetComponent<RectTransform>();
			Vector2 sizeDelta = component.sizeDelta;
			Vector2 sizeDelta2 = component.sizeDelta;
			Vector2 sizeDelta3 = component.sizeDelta;
			return component.sizeDelta;
		}

		[Cpp2IlInjected.Token(Token = "0x60034E3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public RectTransformUtilities()
		{
		}
	}
}
