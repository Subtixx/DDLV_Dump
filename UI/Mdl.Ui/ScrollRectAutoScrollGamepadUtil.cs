using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.RewiredConsts;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000885")]
	public class ScrollRectAutoScrollGamepadUtil : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400326A")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisX = 146;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400326B")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisY = 147;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400326C")]
		private List<int> supportedAxisInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400326D")]
		public ScrollRect ScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400326E")]
		public float StickInputThreshold = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400326F")]
		public float ScrollSpeed = 6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003270")]
		public float AutoScrollSpeed = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003271")]
		public bool EnableAutoScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4003272")]
		private bool _initialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003273")]
		private UiRoot _uiRoot;

		[Cpp2IlInjected.Token(Token = "0x60035CD")]
		[Cpp2IlInjected.Address(RVA = "0x1257E30", Offset = "0x1256830", VA = "0x181257E30")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_005f
			//IL_002e: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			if ((long)supportedAxisInputs == 0)
			{
				List<int> list = (supportedAxisInputs = (List<int>)(object)new List<T>(4));
				List<int> list2 = supportedAxisInputs;
				int rewiredAxisX = RewiredAxisX;
				((List<T>)(object)list2).Add((T)rewiredAxisX);
				List<int> list3 = supportedAxisInputs;
				int rewiredAxisY = RewiredAxisY;
				((List<T>)(object)list3).Add((T)rewiredAxisY);
			}
			int num = 0;
			UiRoot uiRoot = (_uiRoot = UiRoot.Instance);
			_initialized = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60035CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B48F0", Offset = "0x8B32F0", VA = "0x1808B48F0")]
		private void OnDisable()
		{
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x60035CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B48F0", Offset = "0x8B32F0", VA = "0x1808B48F0")]
		private void OnDestroy()
		{
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x60035D0")]
		[Cpp2IlInjected.Address(RVA = "0x1257C90", Offset = "0x1256690", VA = "0x181257C90")]
		private void OnAutoScrollUpdate()
		{
			//IL_0022: Expected O, but got I4
			if (!EnableAutoScroll || Input.GetMouseButton(0))
			{
				return;
			}
			ScrollRect scrollRect = ScrollRect;
			int num = 0;
			if (scrollRect != (UnityEngine.Object)num)
			{
				ScrollRect scrollRect2 = ScrollRect;
				if (scrollRect2.m_Vertical)
				{
					Vector2 anchoredPosition = ScrollRect.m_Content.anchoredPosition;
					throw new NullReferenceException();
				}
				if (scrollRect2.m_Horizontal)
				{
					RectTransform content = scrollRect2.m_Content;
					Vector2 anchoredPosition2 = content.anchoredPosition;
					Vector2 anchoredPosition3 = ScrollRect.m_Content.anchoredPosition;
					Vector2 anchoredPosition4 = default(Vector2);
					content.anchoredPosition = anchoredPosition4;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035D1")]
		[Cpp2IlInjected.Address(RVA = "0x1257F10", Offset = "0x1256910", VA = "0x181257F10")]
		private void Update()
		{
			//Discarded unreachable code: IL_0181
			//IL_005e: Expected O, but got I4
			//IL_00fc: Expected O, but got I4
			ScrollRect scrollRect = ScrollRect;
			RectTransform content = scrollRect.m_Content;
			bool flag = scrollRect.m_Viewport.Contains(content);
			UiRoot uiRoot = _uiRoot;
			bool flag2 = !flag;
			bool activeSelf = uiRoot._genericAlert.gameObject.activeSelf;
			if (!activeSelf && _initialized != activeSelf)
			{
				ScrollRect scrollRect2 = ScrollRect;
				int num = 0;
				if (scrollRect2 != (UnityEngine.Object)num)
				{
					bool activeInHierarchy = ScrollRect.m_Content.gameObject.activeInHierarchy;
				}
			}
			if (!flag2)
			{
				return;
			}
			if (EnableAutoScroll)
			{
				OnAutoScrollUpdate();
			}
			List<int> list = supportedAxisInputs;
			if (!this.HasValidInput((List<>)(object)list))
			{
				return;
			}
			float axis = Input.GetAxis(RewiredAxisX);
			float axis2 = Input.GetAxis(RewiredAxisY);
			if (!(axis <= axis2))
			{
			}
			if (RewiredAxisY <= 0)
			{
				return;
			}
			float stickInputThreshold = StickInputThreshold;
			if (!(axis > stickInputThreshold) && axis2 <= stickInputThreshold)
			{
				return;
			}
			ScrollRect scrollRect3 = ScrollRect;
			int num2 = 0;
			if (scrollRect3 != (UnityEngine.Object)num2)
			{
				ScrollRect scrollRect4 = ScrollRect;
				ScrollRect scrollRect5 = default(ScrollRect);
				if (scrollRect4.m_Vertical)
				{
					RectTransform content2 = scrollRect4.m_Content;
					Vector2 anchoredPosition = content2.anchoredPosition;
					Vector2 anchoredPosition2 = ScrollRect.m_Content.anchoredPosition;
					Vector2 anchoredPosition3 = default(Vector2);
					content2.anchoredPosition = anchoredPosition3;
					scrollRect5 = ScrollRect;
				}
				if (scrollRect5.m_Horizontal)
				{
					RectTransform content3 = scrollRect5.m_Content;
					Vector2 anchoredPosition4 = content3.anchoredPosition;
					Vector2 anchoredPosition5 = ScrollRect.m_Content.anchoredPosition;
					Vector2 anchoredPosition6 = default(Vector2);
					content3.anchoredPosition = anchoredPosition6;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035D2")]
		[Cpp2IlInjected.Address(RVA = "0x1257C20", Offset = "0x1256620", VA = "0x181257C20")]
		private bool IsInputValid(int input)
		{
			//IL_000d: Expected I4, but got O
			float axis = Input.GetAxis(input);
			return (byte)(int)typeof(Input).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60035D3")]
		[Cpp2IlInjected.Address(RVA = "0x1257A50", Offset = "0x1256450", VA = "0x181257A50")]
		private bool HasValidInput(List<int> inputs)
		{
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
				while ((object)typeof(Input).TypeHandle == null)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035D4")]
		[Cpp2IlInjected.Address(RVA = "0x1258250", Offset = "0x1256C50", VA = "0x181258250")]
		public ScrollRectAutoScrollGamepadUtil()
		{
		}//IL_000d: Expected I4, but got I8
		//IL_001a: Expected I4, but got I8

	}
}
