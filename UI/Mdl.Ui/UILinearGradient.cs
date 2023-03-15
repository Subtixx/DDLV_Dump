using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008BF")]
	public class UILinearGradient : BaseMeshEffect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400345D")]
		public Color ColorFrom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400345E")]
		public Color ColorTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400345F")]
		[Range(-180f, 180f)]
		public float Angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4003460")]
		public bool IgnoreRatio;

		[Cpp2IlInjected.Token(Token = "0x6003727")]
		[Cpp2IlInjected.Address(RVA = "0xC968F0", Offset = "0xC952F0", VA = "0x180C968F0", Slot = "20")]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			//Discarded unreachable code: IL_0067
			//IL_0062: Expected O, but got I4
			int num = 0;
			if (base.enabled)
			{
				RectTransform rectTransform = base.graphic.rectTransform;
				float num2 = Angle * ((float)Math.PI / 180f);
				if ((IgnoreRatio ? 1 : 0) == num)
				{
				}
				int num3 = 0;
				int currentVertCount = vh.currentVertCount;
				if (num < currentVertCount)
				{
					vh.PopulateUIVertex(ref *(UIVertex*)num3, num);
					Color colorFrom = ColorFrom;
					Color colorTo = ColorTo;
					int num4 = 0;
					vh.SetUIVertex((UIVertex)num4, num);
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003728")]
		[Cpp2IlInjected.Address(RVA = "0xC96790", Offset = "0xC95190", VA = "0x180C96790")]
		protected Matrix2x3 LocalPositionMatrix(Rect rect, Vector2 dir)
		{
			int num = 0;
			int num2 = 0;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num2;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003729")]
		[Cpp2IlInjected.Address(RVA = "0xC96D00", Offset = "0xC95700", VA = "0x180C96D00")]
		public UILinearGradient()
		{
			Color white = Color.white;
			Color white2 = Color.white;
			IgnoreRatio = true;
			base._002Ector();
		}
	}
}
