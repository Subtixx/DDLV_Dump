using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Loop Vertical Scroll Rect", 51)]
	public class LoopVerticalScrollRect : LoopScrollRect
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0xF9AED0", Offset = "0xF998D0", VA = "0x180F9AED0", Slot = "38")]
		protected override float GetSize(RectTransform item)
		{
			//IL_0017: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			float result = base.contentSpacing;
			GridLayoutGroup gridLayout = m_GridLayout;
			int num = 0;
			if (!(gridLayout != (UnityEngine.Object)num))
			{
				float num2 = LayoutUtility.GetPreferredHeight(item);
				return result;
			}
			GridLayoutGroup gridLayout2 = m_GridLayout;
			int num3 = 0;
			if (!(gridLayout != (UnityEngine.Object)num3))
			{
				float num4 = LayoutUtility.GetPreferredWidth(item);
			}
			GridLayoutGroup gridLayout3 = m_GridLayout;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0xF9AEA0", Offset = "0xF998A0", VA = "0x180F9AEA0", Slot = "39")]
		protected override float GetDimension(Vector2 vector)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0xF9AFE0", Offset = "0xF999E0", VA = "0x180F9AFE0", Slot = "40")]
		protected override Vector2 GetVector(float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0xF9AD60", Offset = "0xF99760", VA = "0x180F9AD60", Slot = "4")]
		protected override void Awake()
		{
			//Discarded unreachable code: IL_003a, IL_0046
			//IL_0023: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			((object)this)._002Ector();
			directionSign = -1;
			GridLayoutGroup component = base.m_Content.GetComponent<GridLayoutGroup>();
			int num = 0;
			if (component != (UnityEngine.Object)num && component.m_Constraint != GridLayoutGroup.Constraint.FixedColumnCount)
			{
				Debug.LogError("[LoopHorizontalScrollRect] unsupported GridLayoutGroup constraint");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0xF9B010", Offset = "0xF99A10", VA = "0x180F9B010", Slot = "41")]
		protected override bool UpdateItems(Bounds viewBounds, Bounds contentBounds)
		{
			//IL_0017: Invalid comparison between F4 and I4
			//IL_002f: Invalid comparison between F4 and I4
			//IL_0034: Invalid comparison between F4 and I4
			//IL_0041: Invalid comparison between F4 and I4
			//IL_0055: Invalid comparison between F4 and I4
			//IL_008b: Invalid comparison between F4 and I4
			//IL_00a2: Invalid comparison between F4 and I4
			//IL_00aa: Invalid comparison between F4 and I4
			//IL_00be: Invalid comparison between F4 and I4
			//IL_00d9: Invalid comparison between F4 and I4
			//IL_00e1: Invalid comparison between F4 and I4
			//IL_00f5: Invalid comparison between F4 and I4
			//IL_00ff: Invalid comparison between F4 and I4
			//IL_0108: Invalid comparison between F4 and I4
			//IL_0116: Invalid comparison between F4 and I4
			//IL_0120: Invalid comparison between F4 and I4
			//IL_013d: Invalid comparison between F4 and I4
			//IL_0147: Invalid comparison between F4 and I4
			//IL_0150: Invalid comparison between F4 and I4
			//IL_0162: Invalid comparison between F4 and I4
			//IL_016c: Invalid comparison between F4 and I4
			Vector3 vector = default(Vector3);
			float num5 = default(float);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			Vector3 vector4 = default(Vector3);
			Vector3 vector5 = default(Vector3);
			Vector3 vector6 = default(Vector3);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				float num3 = threshold;
				float num4 = DeleteItemAtEnd();
				if (!(num4 <= (float)num2))
				{
					float y = vector.y;
					if (!(num4 <= y) && DeleteItemAtEnd() > (float)num2)
					{
						continue;
					}
					if (!(num4 <= (float)num2))
					{
						num5 = NewItemAtEnd();
						if (!(num5 <= (float)num2) && !(vector2.y <= num5) && NewItemAtEnd() > (float)num2)
						{
							continue;
						}
					}
				}
				float y2 = vector3.y;
				if (!(num5 > y2))
				{
					float num6 = threshold;
					if (vector4.y <= num6)
					{
						break;
					}
					float num7 = DeleteItemAtStart();
					num5 = num7;
					if (num7 <= (float)num2)
					{
						break;
					}
					if (!(vector5.y <= num7) && DeleteItemAtStart() > (float)num2)
					{
						continue;
					}
					if (num5 <= (float)num2)
					{
						break;
					}
				}
				float num8 = NewItemAtStart();
				num5 = num8;
				if (num8 <= (float)num2)
				{
					break;
				}
				float y3 = vector6.y;
				if (!(num8 <= y3) && NewItemAtStart() > (float)num2)
				{
					continue;
				}
				if (num5 <= (float)num2)
				{
					break;
				}
				int num9 = 0;
				float num10 = DeleteItemAtEnd();
				float num11;
				if (!(num10 <= (float)num9))
				{
					if (DeleteItemAtEnd() > (float)num9)
					{
						continue;
					}
					if (!(num10 <= (float)num9))
					{
						num11 = NewItemAtEnd();
						if (!(num11 <= (float)num9) && NewItemAtEnd() > (float)num9)
						{
							continue;
						}
					}
				}
				float num12 = threshold;
				float num13 = DeleteItemAtStart();
				num11 = num13;
				if (num13 <= (float)num9)
				{
					break;
				}
				if (!(DeleteItemAtStart() > (float)num9))
				{
					if (num11 <= (float)num9)
					{
						break;
					}
					float num14 = NewItemAtStart();
					num11 = num14;
					if (num14 <= (float)num9 || !(NewItemAtStart() > (float)num9))
					{
						break;
					}
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
		public int GetEndIndex()
		{
			return itemTypeEnd;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0xF9B640", Offset = "0xF9A040", VA = "0x180F9B640")]
		public LoopVerticalScrollRect()
		{
		}
	}
}
