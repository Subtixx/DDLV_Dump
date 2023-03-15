using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200085F")]
	public static class RectTransformExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60034EA")]
		[Cpp2IlInjected.Address(RVA = "0xF3D560", Offset = "0xF3BF60", VA = "0x180F3D560")]
		private static bool HasEnoughVisibleCorner(this RectTransform rectTransform, int requiredCorner, [Optional] Camera camera)
		{
			//Discarded unreachable code: IL_0079
			//IL_0038: Expected O, but got I4
			Vector3[] array = new Vector3[4];
			rectTransform.GetWorldCorners(array);
			int num = 0;
			int width = Screen.width;
			int num2 = 0;
			int height = Screen.height;
			int num3 = 0;
			Rect screenBounds = (Rect)num3;
			Func<Vector3, Vector3> func = (Func<Vector3, Vector3>)(object)(Func<T, TResult>)delegate
			{
				int num4 = 0;
				bool flag = default(bool);
				if (flag)
				{
				}
				throw new NullReferenceException();
			};
			IEnumerable<Vector3> enumerable = (IEnumerable<Vector3>)Enumerable.Select<Vector3, Vector3>((IEnumerable<>)(object)array, (Func<, >)(object)func);
			Func<Vector3, bool> func2 = (Func<Vector3, bool>)(object)(Func<T, TResult>)delegate(Vector3 x)
			{
				float z = x.z;
				bool result = default(bool);
				return result;
			};
			return Enumerable.Count<Vector3>(Enumerable.Take<Vector3>(Enumerable.Where<Vector3>((IEnumerable<>)enumerable, (Func<, >)(object)func2), requiredCorner)) >= requiredCorner;
		}

		[Cpp2IlInjected.Token(Token = "0x60034EB")]
		[Cpp2IlInjected.Address(RVA = "0xF3D790", Offset = "0xF3C190", VA = "0x180F3D790")]
		public static bool IsFullyVisible(this RectTransform rectTransform)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			return rectTransform.HasEnoughVisibleCorner(4, (Camera)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60034EC")]
		[Cpp2IlInjected.Address(RVA = "0xF3D7A0", Offset = "0xF3C1A0", VA = "0x180F3D7A0")]
		public static bool IsPartiallyVisible(this RectTransform rectTransform)
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			return rectTransform.HasEnoughVisibleCorner(1, (Camera)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60034ED")]
		[Cpp2IlInjected.Address(RVA = "0xF3D7B0", Offset = "0xF3C1B0", VA = "0x180F3D7B0")]
		public static bool IsWorldRectangleFullyVisibleFrom(this RectTransform rectTransform, Camera camera)
		{
			return rectTransform.HasEnoughVisibleCorner(4, camera);
		}

		[Cpp2IlInjected.Token(Token = "0x60034EE")]
		[Cpp2IlInjected.Address(RVA = "0xF3D7C0", Offset = "0xF3C1C0", VA = "0x180F3D7C0")]
		public static bool IsWorldRectanglePartiallyVisibleFrom(this RectTransform rectTransform, Camera camera)
		{
			return rectTransform.HasEnoughVisibleCorner(1, camera);
		}

		[Cpp2IlInjected.Token(Token = "0x60034EF")]
		[Cpp2IlInjected.Address(RVA = "0xF3D7D0", Offset = "0xF3C1D0", VA = "0x180F3D7D0")]
		public static void RebuildLayout(this RectTransform rt)
		{
			LayoutRebuilder.ForceRebuildLayoutImmediate(rt);
		}

		[Cpp2IlInjected.Token(Token = "0x60034F0")]
		[Cpp2IlInjected.Address(RVA = "0xF3D830", Offset = "0xF3C230", VA = "0x180F3D830")]
		public static void SetAlpha(this RectTransform rt, float alpha)
		{
			//Discarded unreachable code: IL_0026
			CanvasRenderer[] componentsInChildren = rt.GetComponentsInChildren<CanvasRenderer>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				componentsInChildren[num].SetAlpha(alpha);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034F1")]
		[Cpp2IlInjected.Address(RVA = "0xF3E1C0", Offset = "0xF3CBC0", VA = "0x180F3E1C0")]
		public static void SetLeft(this RectTransform rt, float left)
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected O, but got I4
			int num = 0;
			Vector2 offsetMin = rt.offsetMin;
			rt.offsetMin = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60034F2")]
		[Cpp2IlInjected.Address(RVA = "0xF3E5F0", Offset = "0xF3CFF0", VA = "0x180F3E5F0")]
		public static void SetRight(this RectTransform rt, float right)
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected O, but got I4
			int num = 0;
			Vector2 offsetMax = rt.offsetMax;
			rt.offsetMax = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60034F3")]
		[Cpp2IlInjected.Address(RVA = "0xF3E800", Offset = "0xF3D200", VA = "0x180F3E800")]
		public static void SetTop(this RectTransform rt, float top)
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected O, but got I4
			int num = 0;
			Vector2 offsetMax = rt.offsetMax;
			rt.offsetMax = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60034F4")]
		[Cpp2IlInjected.Address(RVA = "0xF3E170", Offset = "0xF3CB70", VA = "0x180F3E170")]
		public static void SetBottom(this RectTransform rt, float bottom)
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected O, but got I4
			int num = 0;
			Vector2 offsetMin = rt.offsetMin;
			rt.offsetMin = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60034F5")]
		[Cpp2IlInjected.Address(RVA = "0xF3E210", Offset = "0xF3CC10", VA = "0x180F3E210")]
		public static void SetOffset(this RectTransform rt, float left, float right, float top, float bottom)
		{
		}//Discarded unreachable code: IL_0001


		[Cpp2IlInjected.Token(Token = "0x60034F6")]
		[Cpp2IlInjected.Address(RVA = "0xF3E290", Offset = "0xF3CC90", VA = "0x180F3E290")]
		public static void SetOffset(this RectTransform rt, Vector4 lrtb)
		{
			//Discarded unreachable code: IL_0008
			float w = lrtb.w;
		}

		[Cpp2IlInjected.Token(Token = "0x60034F7")]
		[Cpp2IlInjected.Address(RVA = "0xF3D030", Offset = "0xF3BA30", VA = "0x180F3D030")]
		public static Vector4 GetOffset(this RectTransform rt)
		{
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034F8")]
		[Cpp2IlInjected.Address(RVA = "0xF3E650", Offset = "0xF3D050", VA = "0x180F3E650")]
		public static void SetStretchAll(this RectTransform rt)
		{
			//Discarded unreachable code: IL_002c
			//IL_0023: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			int num = 0;
			Vector2 anchorMin = rt.anchorMin;
			int num2 = 0;
			Vector2 anchorMax = rt.anchorMax;
			(Vector2, Vector2) stretchAll = AnchorPresets.StretchAll;
			rt.anchorMin = (Vector2)num2;
			rt.anchorMax = (Vector2)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60034F9")]
		[Cpp2IlInjected.Address(RVA = "0xF3D8E0", Offset = "0xF3C2E0", VA = "0x180F3D8E0")]
		public static void SetAnchorCenter(this RectTransform rt)
		{
			//Discarded unreachable code: IL_0054
			//IL_002b: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			int num = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector2 anchorMin = rt.anchorMin;
			int num2 = 0;
			Vector2 anchorMax = rt.anchorMax;
			(Vector2, Vector2) middleCenter = AnchorPresets.MiddleCenter;
			rt.anchorMin = (Vector2)num2;
			rt.anchorMax = (Vector2)num2;
			int num3 = 0;
			int num4 = 0;
			rt.sizeDelta = (Vector2)num4;
			int num5 = 0;
			Vector2 vector2 = (rt.anchoredPosition = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x60034FA")]
		[Cpp2IlInjected.Address(RVA = "0xF3D0E0", Offset = "0xF3BAE0", VA = "0x180F3D0E0")]
		public static PivotPresetType GetPivotPreset(this RectTransform rt)
		{
			//Discarded unreachable code: IL_0047, IL_0049, IL_004b, IL_004d, IL_004f, IL_0051, IL_0053, IL_0055, IL_0057
			Vector2 pivot = rt.pivot;
			Vector2 pivot2 = rt.pivot;
			Vector2 pivot3 = rt.pivot;
			Vector2 pivot4 = rt.pivot;
			Vector2 pivot5 = rt.pivot;
			Vector2 pivot6 = rt.pivot;
			Vector2 pivot7 = rt.pivot;
			Vector2 pivot8 = rt.pivot;
			Vector2 pivot9 = rt.pivot;
			return PivotPresetType.BottomRight;
		}

		[Cpp2IlInjected.Token(Token = "0x60034FB")]
		[Cpp2IlInjected.Address(RVA = "0xF3E310", Offset = "0xF3CD10", VA = "0x180F3E310")]
		public static void SetPivotPreset(this RectTransform rt, PivotPresetType type)
		{
			//Discarded unreachable code: IL_001b
			if (type - 1 <= PivotPresetType.BottomCenter)
			{
				Vector2 vector = (rt.pivot = PivotPresets.BottomRight);
			}
			AnchorPresetType anchorPreset = rt.GetAnchorPreset();
		}

		[Cpp2IlInjected.Token(Token = "0x60034FC")]
		[Cpp2IlInjected.Address(RVA = "0xF3C270", Offset = "0xF3AC70", VA = "0x180F3C270")]
		public static AnchorPresetType GetAnchorPreset(this RectTransform rt)
		{
			//Discarded unreachable code: IL_0018, IL_0021, IL_002a, IL_0033, IL_003c, IL_0045, IL_004e, IL_0057, IL_0061, IL_006b, IL_0075, IL_007f, IL_0089, IL_0093, IL_009d, IL_00a7
			Vector2 anchorMin = rt.anchorMin;
			int num = 0;
			Vector2 anchorMax = rt.anchorMax;
			(Vector2, Vector2) topLeft = AnchorPresets.TopLeft;
			return AnchorPresetType.TopLeft;
		}

		[Cpp2IlInjected.Token(Token = "0x60034FD")]
		[Cpp2IlInjected.Address(RVA = "0xF3DAB0", Offset = "0xF3C4B0", VA = "0x180F3DAB0")]
		public static void SetAnchorPreset(this RectTransform rt, AnchorPresetType type)
		{
			//Discarded unreachable code: IL_0073
			//IL_002d: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_0072: Expected O, but got I4
			//IL_0072: Expected O, but got I4
			Vector2 anchorMin = rt.anchorMin;
			int num = 0;
			Vector2 anchorMax = rt.anchorMax;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			if (type <= AnchorPresetType.StretchHBottom)
			{
			}
			rt.anchorMin = (Vector2)num;
			rt.anchorMax = (Vector2)num;
			int num6 = default(int);
			int num7 = default(int);
			if (num2 != 0)
			{
				rt.position = (Vector3)num;
				if (num2 == 0)
				{
				}
				if (num5 != 0)
				{
				}
				if (num4 == 0)
				{
					num6 = 0;
				}
				num7 = 0;
				rt.sizeDelta = (Vector2)num6;
			}
			if (num3 != 0)
			{
				UpdateOffsets(rt, (Rect)num6, (Vector2)num7, (byte)num4 != 0, (byte)num5 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034FE")]
		[Cpp2IlInjected.Address(RVA = "0xF3ECB0", Offset = "0xF3D6B0", VA = "0x180F3ECB0")]
		private unsafe static void UpdatePositionAndSize(RectTransform rt, Rect oldRect, Vector2 oldPos, bool isStretchV, bool isStretchH)
		{
			//IL_001b: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			if ((object)rt == null)
			{
				float width = ((Rect*)oldRect)->width;
				int num = 0;
				float height = ((Rect*)oldRect)->height;
				rt.sizeDelta = (Vector2)num;
				return;
			}
			float width2 = ((Rect*)oldRect)->width;
			int num2 = default(int);
			if (!isStretchV)
			{
				num2 = 0;
				float height2 = ((Rect*)oldRect)->height;
			}
			rt.sizeDelta = (Vector2)num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034FF")]
		[Cpp2IlInjected.Address(RVA = "0xF3E860", Offset = "0xF3D260", VA = "0x180F3E860")]
		private unsafe static void UpdateOffsets(RectTransform rt, Rect oldRect, Vector2 oldPos, bool isStretchV, bool isStretchH)
		{
			//Discarded unreachable code: IL_00f6
			//IL_0010: Expected O, but got I4
			//IL_0087: Expected O, but got I4
			//IL_009a: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_00bd: Expected O, but got I4
			//IL_00c5: Expected O, but got I4
			Transform parent = rt.parent;
			int num = 0;
			if (!(parent == (UnityEngine.Object)num))
			{
				Transform parent2 = rt.parent;
				float width = ((Rect*)oldRect)->width;
				float height = ((Rect*)oldRect)->height;
				Vector2 pivot = rt.pivot;
				Vector2 anchoredPosition = rt.anchoredPosition;
				Vector2 pivot2 = rt.pivot;
				Vector2 anchoredPosition2 = rt.anchoredPosition;
				Vector2 pivot3 = rt.pivot;
				Vector2 anchoredPosition3 = rt.anchoredPosition;
				Vector2 pivot4 = rt.pivot;
				int num2 = 0;
				Vector2 anchoredPosition4 = rt.anchoredPosition;
				if (isStretchV)
				{
					int num3 = 0;
					Vector2 offsetMax = rt.offsetMax;
					rt.offsetMax = (Vector2)num3;
					int num4 = 0;
					Vector2 offsetMin = rt.offsetMin;
					rt.offsetMin = (Vector2)num4;
					int num5 = 0;
					Vector2 offsetMin2 = rt.offsetMin;
					rt.offsetMin = (Vector2)num5;
					Vector2 offsetMax2 = rt.offsetMax;
					rt.offsetMin = (Vector2)num2;
					rt.offsetMax = (Vector2)num2;
				}
				int num6 = 0;
			}
			else
			{
				GameObject gameObject = rt.gameObject;
				string name = default(string);
				if ((object)gameObject != null)
				{
					name = gameObject.name;
				}
				Debug.LogWarning("[UI][" + name + "] Trying to update offsets for a object that has no parent!");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003500")]
		[Cpp2IlInjected.Address(RVA = "0xF3CC90", Offset = "0xF3B690", VA = "0x180F3CC90")]
		public static Bounds GetBounds(this RectTransform rt, RectTransform src)
		{
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				Matrix4x4 matrix4x = default(Matrix4x4);
				float m = matrix4x.m02;
				Vector3[] array = new Vector3[4];
				int num3 = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				float num4 = Mathf.Min(Mathf.Min(m, float.MaxValue), float.MaxValue);
				float num5 = Mathf.Max(Mathf.Max(Mathf.Min(z, float.MaxValue), float.MinValue), float.MinValue);
				float num6 = Mathf.Max(z, float.MinValue);
				num3++;
				float z2 = Vector3.zero.z;
			}
			int num7 = 0;
			int num8 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003501")]
		[Cpp2IlInjected.Address(RVA = "0xF3BEA0", Offset = "0xF3A8A0", VA = "0x180F3BEA0")]
		public static bool Contains(this RectTransform rt, RectTransform src, bool isStrict = true)
		{
			//IL_000b: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (!(src == (UnityEngine.Object)num2))
			{
				Rect rect = src.rect;
				int num3 = 0;
				Rect rect2 = src.rect;
				int num4 = 0;
				Bounds bounds = src.GetBounds(rt);
				if (!isStrict)
				{
					bool flag = default(bool);
					bool flag2 = default(bool);
					bool flag3 = default(bool);
					bool flag4 = default(bool);
					if (flag || flag2 || flag3 || !flag4)
					{
					}
					return true;
				}
				bool flag5 = default(bool);
				if (flag5)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003502")]
		[Cpp2IlInjected.Address(RVA = "0xF3BDB0", Offset = "0xF3A7B0", VA = "0x180F3BDB0")]
		public static bool ContainsMouseCursor(this RectTransform rt)
		{
			//Discarded unreachable code: IL_000f
			int num = 0;
			int num2 = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003503")]
		[Cpp2IlInjected.Address(RVA = "0xF3C1E0", Offset = "0xF3ABE0", VA = "0x180F3C1E0")]
		public static bool Contains(this RectTransform rt, Vector3 worldPosition)
		{
			//Discarded unreachable code: IL_0011
			float z = worldPosition.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			bool result = default(bool);
			return result;
		}
	}
}
