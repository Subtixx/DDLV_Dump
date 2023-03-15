using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	public class FlowLayoutGroup : LayoutGroup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public float Spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public bool ChildForceExpandWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public bool ChildForceExpandHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private float _layoutHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private readonly IList<RectTransform> _rowList = (IList<RectTransform>)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		protected bool IsCenterAlign
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x1660F90", Offset = "0x165F990", VA = "0x181660F90")]
			get
			{
				TextAnchor textAnchor = m_ChildAlignment;
				if (textAnchor != TextAnchor.LowerCenter && textAnchor != TextAnchor.MiddleCenter)
				{
					return textAnchor == TextAnchor.UpperCenter;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		protected bool IsRightAlign
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB1")]
			[Cpp2IlInjected.Address(RVA = "0x1660FF0", Offset = "0x165F9F0", VA = "0x181660FF0")]
			get
			{
				TextAnchor textAnchor = m_ChildAlignment;
				if (textAnchor != TextAnchor.LowerRight && textAnchor != TextAnchor.MiddleRight)
				{
					return textAnchor == TextAnchor.UpperRight;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		protected bool IsMiddleAlign
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB2")]
			[Cpp2IlInjected.Address(RVA = "0x1660FD0", Offset = "0x165F9D0", VA = "0x181660FD0")]
			get
			{
				//Discarded unreachable code: IL_0009
				TextAnchor textAnchor = m_ChildAlignment;
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		protected bool IsLowerAlign
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB3")]
			[Cpp2IlInjected.Address(RVA = "0x1660FB0", Offset = "0x165F9B0", VA = "0x181660FB0")]
			get
			{
				//Discarded unreachable code: IL_0009
				TextAnchor textAnchor = m_ChildAlignment;
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x1660030", Offset = "0x165EA30", VA = "0x181660030", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x16608C0", Offset = "0x165F2C0", VA = "0x1816608C0", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
			//Discarded unreachable code: IL_0008
			RectTransform rectTransform = base.rectTransform;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAE")]
		[Cpp2IlInjected.Address(RVA = "0x1660920", Offset = "0x165F320", VA = "0x181660920", Slot = "38")]
		public override void SetLayoutVertical()
		{
			//Discarded unreachable code: IL_0008
			RectTransform rectTransform = base.rectTransform;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAF")]
		[Cpp2IlInjected.Address(RVA = "0x1660160", Offset = "0x165EB60", VA = "0x181660160", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
			//Discarded unreachable code: IL_003e
			RectTransform rectTransform = base.rectTransform;
			float layoutHeight = default(float);
			_layoutHeight = layoutHeight;
			if ((object)base.rectTransform != null)
			{
				RectTransform component = GetComponent<RectTransform>();
				Vector2 sizeDelta = GetComponent<RectTransform>().sizeDelta;
				float layoutHeight2 = _layoutHeight;
				component.sizeDelta = sizeDelta;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x1660980", Offset = "0x165F380", VA = "0x181660980")]
		public float SetLayout(float width, int axis, bool layoutInput)
		{
			//IL_00df: Invalid comparison between F4 and I4
			RectTransform rectTransform = base.rectTransform;
			RectTransform rectTransform2 = base.rectTransform;
			int left = m_Padding.left;
			int right = m_Padding.right;
			TextAnchor textAnchor = m_ChildAlignment;
			if (right != -3)
			{
			}
			RectOffset rectOffset = m_Padding;
			ulong num = default(ulong);
			if (num != 0)
			{
				int bottom = rectOffset.bottom;
			}
			int top = rectOffset.top;
			List<RectTransform> list = base.m_RectChildren;
			int num2 = 0;
			int num3 = 0;
			bool isLowerAlign = IsLowerAlign;
			if (isLowerAlign)
			{
				int size = ((List<>)(object)list)._size;
				size -= num2;
			}
			float num4 = default(float);
			float num5 = num4;
			IList<RectTransform> rowList = _rowList;
			if ((isLowerAlign ? 1 : 0) > (false ? 1 : 0))
			{
			}
			if (!layoutInput)
			{
				TextAnchor textAnchor2 = m_ChildAlignment;
				if (!isLowerAlign && textAnchor2 != TextAnchor.LowerCenter)
				{
					if (isLowerAlign || textAnchor2 != TextAnchor.MiddleCenter)
					{
					}
					float layoutHeight = _layoutHeight;
				}
				int left2 = m_Padding.left;
			}
			IList<RectTransform> rowList2 = _rowList;
			int num6 = 0;
			IList<RectTransform> rowList3 = _rowList;
			if (!(num5 <= (float)num6))
			{
			}
			List<RectTransform> list2 = base.m_RectChildren;
			num2++;
			int left3 = default(int);
			if (!layoutInput)
			{
				TextAnchor textAnchor3 = m_ChildAlignment;
				if ((long)list2 != 4294967293L && textAnchor3 != TextAnchor.LowerCenter)
				{
					if ((long)list2 == 4294967293L || textAnchor3 != TextAnchor.MiddleCenter)
					{
					}
					float layoutHeight2 = _layoutHeight;
				}
				left3 = m_Padding.left;
			}
			IList<RectTransform> rowList4 = _rowList;
			TextAnchor textAnchor4 = m_ChildAlignment;
			if (left3 != -3)
			{
			}
			RectOffset rectOffset2 = m_Padding;
			ulong num7 = default(ulong);
			if (num7 != 0)
			{
				int top2 = rectOffset2.top;
			}
			int bottom2 = rectOffset2.bottom;
			if (!layoutInput || axis == 1)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165ECA0", VA = "0x1816602A0")]
		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
		{
			switch (m_ChildAlignment)
			{
			default:
				return yOffset;
			case TextAnchor.MiddleCenter:
			{
				float result = groupHeight * 0.5f;
				float layoutHeight = _layoutHeight;
				return result;
			}
			case TextAnchor.LowerCenter:
				return groupHeight;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x16603D0", Offset = "0x165EDD0", VA = "0x1816603D0")]
		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis, bool lastRow = false)
		{
			//Discarded unreachable code: IL_0144
			//IL_007a: Expected O, but got I4
			//IL_00fe: Expected O, but got I4
			//IL_0106: Expected O, but got I4
			//IL_0107: Invalid comparison between F4 and I4
			//IL_0110: Expected O, but got I4
			bool childForceExpandWidth = ChildForceExpandWidth;
			int num = 0;
			if (!childForceExpandWidth)
			{
				switch (m_ChildAlignment)
				{
				}
			}
			int num2 = 0;
			int num5 = default(int);
			if (childForceExpandWidth)
			{
				IList<RectTransform> rowList = _rowList;
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_008d;
					}
					num++;
				}
				if ((long)num < (long)(IntPtr)typeof(IList<RectTransform>).TypeHandle)
				{
					IList<RectTransform> rowList2 = _rowList;
					uint num4 = default(uint);
					if (num < (int)num4)
					{
						num += num;
						if (num == (int)num4)
						{
							goto IL_009c;
						}
						num++;
					}
					num5 = 0;
					float num6 = LayoutUtility.GetFlexibleWidth((RectTransform)num);
					IList<RectTransform> rowList3 = _rowList;
					num++;
					while (rowList3 != null)
					{
					}
					goto IL_008d;
				}
				goto IL_00ab;
			}
			goto IL_00af;
			IL_008d:
			num5 += num5;
			num += 312;
			goto IL_009c;
			IL_00af:
			IList<RectTransform> rowList4 = _rowList;
			uint num7 = default(uint);
			if (num < (int)num7)
			{
				num += num;
				if (num == (int)num7)
				{
					goto IL_00eb;
				}
				num++;
			}
			if (num < num)
			{
				bool isLowerAlign = IsLowerAlign;
				if (isLowerAlign)
				{
					IList<RectTransform> rowList5 = _rowList;
					isLowerAlign = (byte)((isLowerAlign ? 1u : 0u) - (uint)num) != 0;
				}
				goto IL_00eb;
			}
			return;
			IL_00ab:
			if (num <= 0)
			{
			}
			goto IL_00af;
			IL_009c:
			num5 += num5;
			num += 312;
			goto IL_00ab;
			IL_00eb:
			IList<RectTransform> rowList6 = _rowList;
			int axis2 = 0;
			float preferredSize = LayoutUtility.GetPreferredSize((RectTransform)num, axis2);
			if (!(LayoutUtility.GetFlexibleWidth((RectTransform)num) <= (float)num2))
			{
			}
			float preferredSize2 = LayoutUtility.GetPreferredSize((RectTransform)num, 1);
			if ((ChildForceExpandHeight ? 1 : 0) != num)
			{
				preferredSize2 = rowHeight;
			}
			preferredSize2 = rowWidth;
			if (IsMiddleAlign || IsLowerAlign)
			{
			}
			float num8 = default(float);
			preferredSize2 = num8;
			IList<RectTransform> rowList7 = _rowList;
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x1660300", Offset = "0x165ED00", VA = "0x181660300")]
		public float GetGreatestMinimumChildWidth()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x1660F10", Offset = "0x165F910", VA = "0x181660F10")]
		public FlowLayoutGroup()
		{
		}
	}
}
