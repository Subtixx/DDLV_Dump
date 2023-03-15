using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000852")]
	public class ListScrollIndicator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030E8")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030E9")]
		[SerializeField]
		private RectTransform _viewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030EA")]
		[SerializeField]
		private CanvasGroup _leftIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40030EB")]
		[SerializeField]
		private CanvasGroup _rightIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40030EC")]
		[SerializeField]
		private CanvasGroup _topIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40030ED")]
		[SerializeField]
		private CanvasGroup _bottomIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40030EE")]
		[SerializeField]
		private int _treshold = 100;

		[Cpp2IlInjected.Token(Token = "0x60034B7")]
		[Cpp2IlInjected.Address(RVA = "0x132E340", Offset = "0x132CD40", VA = "0x18132E340")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0027
			ScrollRect.ScrollRectEvent onValueChanged = _scrollRect.m_OnValueChanged;
			UnityAction<Vector2> unityAction = (UnityAction<Vector2>)(object)new UnityAction<T0>(OnValueChange);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			updateScrollIndicator();
		}

		[Cpp2IlInjected.Token(Token = "0x60034B8")]
		[Cpp2IlInjected.Address(RVA = "0x132E400", Offset = "0x132CE00", VA = "0x18132E400")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0024
			//IL_0010: Expected O, but got I4
			ScrollRect scrollRect = _scrollRect;
			int num = 0;
			if (scrollRect != (UnityEngine.Object)num)
			{
				_scrollRect.m_OnValueChanged.RemoveAllListeners();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034B9")]
		[Cpp2IlInjected.Address(RVA = "0x132E490", Offset = "0x132CE90", VA = "0x18132E490")]
		private void OnValueChange(Vector2 arg0)
		{
			updateScrollIndicator();
		}

		[Cpp2IlInjected.Token(Token = "0x60034BA")]
		[Cpp2IlInjected.Address(RVA = "0x132E4B0", Offset = "0x132CEB0", VA = "0x18132E4B0")]
		public void updateScrollIndicator()
		{
			//IL_0012: Expected O, but got I4
			//IL_003f: Expected F4, but got I4
			//IL_00da: Expected O, but got I4
			//IL_0106: Expected F4, but got I4
			//IL_01b0: Expected O, but got I4
			//IL_01d8: Expected F4, but got I4
			//IL_026d: Expected O, but got I4
			//IL_0296: Expected F4, but got I4
			int num = 0;
			CanvasGroup leftIndicator = _leftIndicator;
			int num2 = 0;
			bool flag = leftIndicator != (UnityEngine.Object)num2;
			int num3 = 0;
			if (flag)
			{
				if (!_scrollRect.enabled)
				{
					CanvasGroup leftIndicator2 = _leftIndicator;
					int num4 = 0;
					leftIndicator2.alpha = num4;
					CanvasGroup leftIndicator3 = _leftIndicator;
					int num5 = ((leftIndicator3.blocksRaycasts = false) ? 1 : 0);
					CanvasGroup leftIndicator4 = _leftIndicator;
					int num6 = ((leftIndicator4.interactable = false) ? 1 : 0);
				}
				Vector2 anchoredPosition = _scrollRect.m_Content.anchoredPosition;
				CanvasGroup leftIndicator5 = _leftIndicator;
				if ((long)num3 < (long)(IntPtr)anchoredPosition)
				{
				}
				int blocksRaycasts = 0;
				float alpha = leftIndicator5.alpha;
				leftIndicator5.blocksRaycasts = (byte)blocksRaycasts != 0;
				CanvasGroup leftIndicator6 = _leftIndicator;
				int interactable = 0;
				float alpha2 = leftIndicator6.alpha;
				leftIndicator6.interactable = (byte)interactable != 0;
				float alpha3 = default(float);
				_leftIndicator.alpha = alpha3;
			}
			CanvasGroup rightIndicator = _rightIndicator;
			int num7 = 0;
			if (rightIndicator != (UnityEngine.Object)num7)
			{
				bool flag4 = _scrollRect.enabled;
				CanvasGroup rightIndicator2 = _rightIndicator;
				if (!flag4)
				{
					int num8 = 0;
					rightIndicator2.alpha = num8;
					CanvasGroup rightIndicator3 = _rightIndicator;
					int num9 = ((rightIndicator3.blocksRaycasts = false) ? 1 : 0);
					CanvasGroup rightIndicator4 = _rightIndicator;
					int num10 = ((rightIndicator4.interactable = false) ? 1 : 0);
				}
				int blocksRaycasts2 = 0;
				float alpha4 = rightIndicator2.alpha;
				rightIndicator2.blocksRaycasts = (byte)blocksRaycasts2 != 0;
				CanvasGroup rightIndicator5 = _rightIndicator;
				int interactable2 = 0;
				float alpha5 = rightIndicator5.alpha;
				rightIndicator5.interactable = (byte)interactable2 != 0;
				ScrollRect scrollRect = _scrollRect;
				CanvasGroup rightIndicator6 = _rightIndicator;
				Vector2 anchoredPosition2 = scrollRect.m_Content.anchoredPosition;
				RectTransform content = _scrollRect.m_Content;
				RectTransform viewport = _viewport;
				float alpha6 = default(float);
				rightIndicator6.alpha = alpha6;
			}
			CanvasGroup topIndicator = _topIndicator;
			int num11 = 0;
			if (topIndicator != (UnityEngine.Object)num11)
			{
				if (!_scrollRect.enabled)
				{
					CanvasGroup topIndicator2 = _topIndicator;
					int num12 = 0;
					topIndicator2.alpha = num12;
					CanvasGroup topIndicator3 = _topIndicator;
					int num13 = ((topIndicator3.blocksRaycasts = false) ? 1 : 0);
					CanvasGroup topIndicator4 = _topIndicator;
					int num14 = ((topIndicator4.interactable = false) ? 1 : 0);
				}
				Vector2 anchoredPosition3 = _scrollRect.m_Content.anchoredPosition;
				CanvasGroup topIndicator5 = _topIndicator;
				int blocksRaycasts3 = 0;
				float alpha7 = topIndicator5.alpha;
				topIndicator5.blocksRaycasts = (byte)blocksRaycasts3 != 0;
				CanvasGroup topIndicator6 = _topIndicator;
				int interactable3 = 0;
				float alpha8 = topIndicator6.alpha;
				topIndicator6.interactable = (byte)interactable3 != 0;
				float alpha9 = default(float);
				_topIndicator.alpha = alpha9;
			}
			CanvasGroup bottomIndicator = _bottomIndicator;
			int num15 = 0;
			if (bottomIndicator != (UnityEngine.Object)num15)
			{
				bool flag9 = _scrollRect.enabled;
				CanvasGroup bottomIndicator2 = _bottomIndicator;
				if (flag9)
				{
					int num16 = 0;
					float alpha10 = default(float);
					bottomIndicator2.alpha = alpha10;
					int blocksRaycasts4 = 0;
					float alpha11 = bottomIndicator2.alpha;
					bottomIndicator2.blocksRaycasts = (byte)blocksRaycasts4 != 0;
					throw new NullReferenceException();
				}
				int num17 = 0;
				bottomIndicator2.alpha = num17;
				CanvasGroup bottomIndicator3 = _bottomIndicator;
				int num18 = ((bottomIndicator3.blocksRaycasts = false) ? 1 : 0);
				CanvasGroup bottomIndicator4 = _bottomIndicator;
				int num19 = ((bottomIndicator4.interactable = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034BB")]
		[Cpp2IlInjected.Address(RVA = "0x132E4A0", Offset = "0x132CEA0", VA = "0x18132E4A0")]
		public ListScrollIndicator()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
