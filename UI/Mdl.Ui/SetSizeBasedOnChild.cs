using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200088B")]
	public class SetSizeBasedOnChild : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200088C")]
		public enum SizeAdjustment
		{
			[Cpp2IlInjected.Token(Token = "0x40032A1")]
			Width,
			[Cpp2IlInjected.Token(Token = "0x40032A2")]
			Height,
			[Cpp2IlInjected.Token(Token = "0x40032A3")]
			Both,
			[Cpp2IlInjected.Token(Token = "0x40032A4")]
			None
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003293")]
		[SerializeField]
		private SizeAdjustment _sizeToAdjust = SizeAdjustment.None;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003294")]
		[SerializeField]
		private HorizontalLayoutGroup _horizontalLayoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003295")]
		[SerializeField]
		private VerticalLayoutGroup _verticalLayoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003296")]
		[SerializeField]
		[Header("Adjust to one specific child instead of all of them")]
		private RectTransform _specificChild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003297")]
		[SerializeField]
		[Header("Recommended unless spacing is required at the end")]
		private bool _useChildCountMinusOne;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003298")]
		[SerializeField]
		[Header("Fill if you need to notify UI Auto Scroll")]
		private UIAutoScroll _autoScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003299")]
		[SerializeField]
		[Header("Select if it need to be done OnEnable")]
		private bool _adjustSizeOnEnable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400329A")]
		[SerializeField]
		[Header("Fill with SetSizeBasedOnChild in Child if they need to be done in cascade")]
		private SetSizeBasedOnChild[] cascadeSetSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400329B")]
		[SerializeField]
		[Header("Set to have a min height")]
		private float minHeight = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400329C")]
		[Header("Set if padding is required")]
		private float paddingTop = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400329D")]
		private float paddingBottom = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400329E")]
		private float paddingLeft = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400329F")]
		private float paddingRight = -1f;

		[Cpp2IlInjected.Token(Token = "0x60035FE")]
		[Cpp2IlInjected.Address(RVA = "0x1261A60", Offset = "0x1260460", VA = "0x181261A60")]
		private void OnEnable()
		{
			if (_adjustSizeOnEnable)
			{
				DoAdjustment();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035FF")]
		[Cpp2IlInjected.Address(RVA = "0x1261A70", Offset = "0x1260470", VA = "0x181261A70")]
		public void SetPadding(float top = -1f, float bottom = -1f, float left = -1f, float right = -1f)
		{
			//IL_0007: Expected F4, but got I4
			paddingRight = 0f;
			paddingTop = top;
			paddingBottom = bottom;
			paddingLeft = left;
		}

		[Cpp2IlInjected.Token(Token = "0x6003600")]
		[Cpp2IlInjected.Address(RVA = "0xF0A950", Offset = "0xF09350", VA = "0x180F0A950")]
		public void SetMinY(float min)
		{
			minHeight = min;
		}

		[Cpp2IlInjected.Token(Token = "0x6003601")]
		[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
		public void SetSpecificChild(RectTransform child)
		{
			_specificChild = child;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003602")]
		[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
		public void SetSizeToAdjust(SizeAdjustment sizeAdjustment)
		{
			_sizeToAdjust = sizeAdjustment;
		}

		[Cpp2IlInjected.Token(Token = "0x6003603")]
		[Cpp2IlInjected.Address(RVA = "0x1261940", Offset = "0x1260340", VA = "0x181261940")]
		public void DoAdjustment()
		{
			//Discarded unreachable code: IL_007e
			//IL_006f: Expected O, but got I4
			SetSizeBasedOnChild[] array = cascadeSetSize;
			if (array != null && array.Length != 0)
			{
				int num = 0;
				if (num < array.Length)
				{
					array[num].DoAdjustment();
					SetSizeBasedOnChild[] array2 = cascadeSetSize;
					num++;
				}
			}
			SizeAdjustment sizeToAdjust = _sizeToAdjust;
			if (sizeToAdjust != 0)
			{
				if (sizeToAdjust != 0)
				{
					if (sizeToAdjust != SizeAdjustment.Height)
					{
						goto IL_005b;
					}
					AdjustWidth();
				}
				AdjustHeight();
			}
			AdjustWidth();
			goto IL_005b;
			IL_005b:
			UIAutoScroll autoScroll = _autoScroll;
			int num2 = 0;
			if (autoScroll != (UnityEngine.Object)num2)
			{
				_autoScroll.StartAutoScroll();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003604")]
		[Cpp2IlInjected.Address(RVA = "0x12614C0", Offset = "0x125FEC0", VA = "0x1812614C0")]
		private void AdjustWidth()
		{
			//Discarded unreachable code: IL_012a, IL_0130, IL_013c
			//IL_0014: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			//IL_0129: Expected O, but got I4
			uint num6 = default(uint);
			Vector2 vector = default(Vector2);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				RectTransform specificChild = _specificChild;
				int num3 = 0;
				if (!(specificChild != (UnityEngine.Object)num3))
				{
					HorizontalLayoutGroup horizontalLayoutGroup = _horizontalLayoutGroup;
					int num4 = 0;
					if (horizontalLayoutGroup != (UnityEngine.Object)num4)
					{
						int left = ((LayoutGroup)_horizontalLayoutGroup).m_Padding.left;
						int right = ((LayoutGroup)_horizontalLayoutGroup).m_Padding.right;
						HorizontalLayoutGroup horizontalLayoutGroup2 = _horizontalLayoutGroup;
						if ((_useChildCountMinusOne ? 1 : 0) != num)
						{
							int childCount = base.transform.childCount;
						}
						int childCount2 = base.transform.childCount;
					}
					VerticalLayoutGroup verticalLayoutGroup = _verticalLayoutGroup;
					int num5 = 0;
					if (verticalLayoutGroup != (UnityEngine.Object)num5)
					{
						int left2 = ((LayoutGroup)_verticalLayoutGroup).m_Padding.left;
						int right2 = ((LayoutGroup)_verticalLayoutGroup).m_Padding.right;
					}
					IEnumerator enumerator = base.transform.GetEnumerator();
					if (enumerator != null)
					{
						if (num < (int)num6)
						{
							num += num;
							num++;
						}
						if (enumerator == null)
						{
							break;
						}
					}
					if ((object)vector != null)
					{
					}
					if ((object)vector != null)
					{
						continue;
					}
				}
				RectTransform specificChild2 = _specificChild;
				Vector2 sizeDelta = specificChild2.sizeDelta;
				if ((object)specificChild2 != null)
				{
				}
				if ((object)specificChild2 != null)
				{
				}
				RectTransform component = base.gameObject.GetComponent<RectTransform>();
				int num7 = 0;
				Vector2 sizeDelta2 = component.sizeDelta;
				component.sizeDelta = (Vector2)num7;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003605")]
		[Cpp2IlInjected.Address(RVA = "0x1261030", Offset = "0x125FA30", VA = "0x181261030")]
		private void AdjustHeight()
		{
			//Discarded unreachable code: IL_012f, IL_0135, IL_0141
			//IL_0014: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_012e: Expected O, but got I4
			Transform transform = default(Transform);
			uint num6 = default(uint);
			Vector2 vector = default(Vector2);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				RectTransform specificChild = _specificChild;
				int num3 = 0;
				if (!(specificChild != (UnityEngine.Object)num3))
				{
					HorizontalLayoutGroup horizontalLayoutGroup = _horizontalLayoutGroup;
					int num4 = 0;
					if (horizontalLayoutGroup != (UnityEngine.Object)num4)
					{
						int top = ((LayoutGroup)_horizontalLayoutGroup).m_Padding.top;
						int bottom = ((LayoutGroup)_horizontalLayoutGroup).m_Padding.bottom;
					}
					VerticalLayoutGroup verticalLayoutGroup = _verticalLayoutGroup;
					int num5 = 0;
					if (verticalLayoutGroup != (UnityEngine.Object)num5)
					{
						int top2 = ((LayoutGroup)_verticalLayoutGroup).m_Padding.top;
						int bottom2 = ((LayoutGroup)_verticalLayoutGroup).m_Padding.bottom;
						VerticalLayoutGroup verticalLayoutGroup2 = _verticalLayoutGroup;
						if ((_useChildCountMinusOne ? 1 : 0) != num)
						{
							transform = base.transform;
							int childCount = transform.childCount;
						}
						int childCount2 = transform.transform.childCount;
					}
					IEnumerator enumerator = base.transform.GetEnumerator();
					if (enumerator != null)
					{
						if (num < (int)num6)
						{
							num += num;
							num++;
						}
						if (enumerator == null)
						{
							break;
						}
					}
					if ((object)vector != null)
					{
					}
					if ((object)vector != null)
					{
						continue;
					}
				}
				RectTransform specificChild2 = _specificChild;
				Vector2 sizeDelta = specificChild2.sizeDelta;
				if ((object)specificChild2 != null)
				{
				}
				if ((object)specificChild2 != null)
				{
				}
				RectTransform component = base.gameObject.GetComponent<RectTransform>();
				int num7 = 0;
				Vector2 sizeDelta2 = component.sizeDelta;
				component.sizeDelta = (Vector2)num7;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003606")]
		[Cpp2IlInjected.Address(RVA = "0x1261A90", Offset = "0x1260490", VA = "0x181261A90")]
		public SetSizeBasedOnChild()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
