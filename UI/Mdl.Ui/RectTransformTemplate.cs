using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000893")]
	public class RectTransformTemplate : TransformTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40032B9")]
		public Vector2 SizeDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40032BA")]
		public Vector2 Pivot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40032BB")]
		public Vector2 AnchorMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40032BC")]
		public Vector2 AnchorMax;

		[Cpp2IlInjected.Token(Token = "0x6003617")]
		[Cpp2IlInjected.Address(RVA = "0xF3FCD0", Offset = "0xF3E6D0", VA = "0x180F3FCD0")]
		public void Load(RectTransform rt, bool ignoreParent = false)
		{
			//Discarded unreachable code: IL_006d
			//IL_0014: Expected O, but got I4
			if (!ignoreParent)
			{
				Transform parent = Parent;
				int num = 0;
				if (parent != (UnityEngine.Object)num)
				{
					Transform parent2 = Parent;
					Transform parent3 = rt.parent;
					if (parent2 != parent3)
					{
						Transform transform = (((Transform)rt).parentInternal = Parent);
					}
				}
			}
			float z = Position.z;
			float z2 = Rotation.z;
			float z3 = Scale.z;
			LayoutRebuilder.MarkLayoutForRebuild(rt);
		}

		[Cpp2IlInjected.Token(Token = "0x6003618")]
		[Cpp2IlInjected.Address(RVA = "0xF3FEF0", Offset = "0xF3E8F0", VA = "0x180F3FEF0")]
		public unsafe void Save(RectTransform rt)
		{
			//Discarded unreachable code: IL_00be
			//IL_001c: Expected native int or pointer, but got O
			//IL_0032: Expected native int or pointer, but got O
			//IL_0048: Expected native int or pointer, but got O
			//IL_0069: Expected F4, but got I4
			//IL_0064: Expected native int or pointer, but got O
			//IL_0085: Expected F4, but got I4
			//IL_0080: Expected native int or pointer, but got O
			//IL_00a1: Expected F4, but got I4
			//IL_009c: Expected native int or pointer, but got O
			//IL_00bd: Expected F4, but got I4
			//IL_00b8: Expected native int or pointer, but got O
			Transform transform = (Parent = rt.parent);
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)Position)->z = z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			((Vector3*)(IntPtr)Rotation)->z = z2;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			((Vector3*)(IntPtr)Scale)->z = z3;
			Vector2 vector4 = (SizeDelta = rt.sizeDelta);
			((Vector2*)(IntPtr)SizeDelta)->y = 0f;
			Vector2 vector5 = (Pivot = rt.pivot);
			((Vector2*)(IntPtr)Pivot)->y = 0f;
			Vector2 vector6 = (AnchorMin = rt.anchorMin);
			((Vector2*)(IntPtr)AnchorMin)->y = 0f;
			Vector2 vector7 = (AnchorMax = rt.anchorMax);
			((Vector2*)(IntPtr)AnchorMax)->y = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6003619")]
		[Cpp2IlInjected.Address(RVA = "0xF40040", Offset = "0xF3EA40", VA = "0x180F40040")]
		public unsafe RectTransformTemplate()
		{
			//IL_001d: Expected F4, but got I4
			//IL_0018: Expected native int or pointer, but got O
			//IL_002a: Expected O, but got I8
			//IL_0035: Expected native int or pointer, but got O
			//IL_0056: Expected F4, but got I4
			//IL_0051: Expected native int or pointer, but got O
			//IL_0071: Expected F4, but got I4
			//IL_006c: Expected native int or pointer, but got O
			int num = 0;
			Vector2 zero = Vector2.zero;
			int num2 = 0;
			SizeDelta = zero;
			((Vector2*)(IntPtr)SizeDelta)->y = 0f;
			Pivot = (Vector2)1056964608;
			((Vector2*)(IntPtr)Pivot)->y = 0.5f;
			Vector2 zero2 = Vector2.zero;
			int num3 = 0;
			AnchorMin = zero2;
			((Vector2*)(IntPtr)AnchorMin)->y = 0f;
			AnchorMax = Vector2.zero;
			((Vector2*)(IntPtr)AnchorMax)->y = 0f;
			base._002Ector();
		}
	}
}
