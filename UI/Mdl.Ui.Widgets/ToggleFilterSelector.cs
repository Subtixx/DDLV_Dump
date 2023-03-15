using System.Collections.Generic;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Buildings;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009AD")]
	public class ToggleFilterSelector : FilterSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40038F3")]
		public bool selectMultiple;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40038F4")]
		public List<Filter> allFilters = (List<Filter>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40038F5")]
		public List<Filter> selectedFilters = (List<Filter>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40038F6")]
		[SerializeField]
		protected RectTransform _mcSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40038F7")]
		[SerializeField]
		protected TextBase _tfSelectedCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40038F8")]
		[SerializeField]
		protected bool _showSelectedHeader = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40038F9")]
		[SerializeField]
		protected BaseButton _btnToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40038FA")]
		[SerializeField]
		protected GameObject highlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40038FB")]
		public RectTransform filtersAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40038FC")]
		[SerializeField]
		protected LayoutElement _layout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40038FD")]
		[SerializeField]
		protected bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40038FE")]
		[SerializeField]
		protected bool showHeader = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40038FF")]
		[SerializeField]
		protected GameObject _focusAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003900")]
		[SerializeField]
		protected RectTransform headerContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003901")]
		[SerializeField]
		private float _headerHeight = 55f;

		[Cpp2IlInjected.Token(Token = "0x6003CB0")]
		[Cpp2IlInjected.Address(RVA = "0x17F0ED0", Offset = "0x17EF8D0", VA = "0x1817F0ED0", Slot = "6")]
		public virtual void Init()
		{
			//Discarded unreachable code: IL_011d
			//IL_0059: Expected O, but got I4
			//IL_00bc: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			//IL_00f3: Expected O, but got I4
			int num = 0;
			if ((isOpen ? 1 : 0) != num)
			{
				GameObject gameObject = filtersAnchor.gameObject;
				bool active = isOpen;
				gameObject.SetActive(active);
				LayoutRebuilder.ForceRebuildLayoutImmediate(filtersAnchor);
				if ((isOpen ? 1 : 0) != num)
				{
					Vector2 sizeDelta = filtersAnchor.sizeDelta;
				}
				LayoutElement layout = _layout;
				int num2 = 0;
				if (layout != (Object)num2)
				{
					float preferredWidth = _layout.preferredWidth;
					TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
					TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t.SetEase(Ease.OutCubic);
				}
			}
			GameObject gameObject2 = headerContent.gameObject;
			bool active2 = showHeader;
			gameObject2.SetActive(active2);
			RectTransform rectTransform = filtersAnchor;
			int num3 = 0;
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			int num4 = 0;
			if ((showHeader ? 1 : 0) != num)
			{
			}
			rectTransform.anchoredPosition = (Vector2)num3;
			Transform transform = _btnToggle.Background.transform;
			int num5 = 0;
			transform.rotation = (Quaternion)num5;
			Transform transform2 = highlightBg.transform;
			int num6 = 0;
			transform2.rotation = (Quaternion)num6;
			Button.ButtonClickedEvent onClick = _btnToggle.ButtonComponent.m_OnClick;
			UnityAction call = OnToggleClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB1")]
		[Cpp2IlInjected.Address(RVA = "0x14D7B20", Offset = "0x14D6520", VA = "0x1814D7B20")]
		protected void OnToggleClickHandler()
		{
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB2")]
		[Cpp2IlInjected.Address(RVA = "0x17F13C0", Offset = "0x17EFDC0", VA = "0x1817F13C0", Slot = "7")]
		protected virtual void Toggle()
		{
			//Discarded unreachable code: IL_00bc
			//IL_009f: Expected O, but got I4
			RectTransform rectTransform = filtersAnchor;
			bool flag = (isOpen = !isOpen);
			GameObject gameObject = rectTransform.gameObject;
			bool active = isOpen;
			gameObject.SetActive(active);
			LayoutRebuilder.ForceRebuildLayoutImmediate(filtersAnchor);
			if (isOpen)
			{
				Vector2 sizeDelta = filtersAnchor.sizeDelta;
			}
			Transform transform = _btnToggle.Background.transform;
			int num = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t = default(TweenerCore<Quaternion, Vector3, QuaternionOptions>);
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = t.SetEase(Ease.OutCubic);
			Transform transform2 = highlightBg.transform;
			int num2 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = default(TweenerCore<Quaternion, Vector3, QuaternionOptions>);
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = t2.SetEase(Ease.OutCubic);
			LayoutElement layout = _layout;
			int num3 = 0;
			if (layout != (Object)num3)
			{
				float preferredWidth = _layout.preferredWidth;
				TweenerCore<Vector2, Vector2, VectorOptions> t3 = default(TweenerCore<Vector2, Vector2, VectorOptions>);
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = t3.SetEase(Ease.OutCubic);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB3")]
		[Cpp2IlInjected.Address(RVA = "0x17F0E70", Offset = "0x17EF870", VA = "0x1817F0E70", Slot = "5")]
		public override HashSet<Filter> CurrentFilters()
		{
			return (HashSet<Filter>)(object)new HashSet<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public override void SelectFilters(HashSet<Filter> filters)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB5")]
		[Cpp2IlInjected.Address(RVA = "0x17F1270", Offset = "0x17EFC70", VA = "0x1817F1270")]
		public void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_0072
			//IL_0009: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			int num = 0;
			if (focusNavigation == (Object)num)
			{
				return;
			}
			if (filtersAnchor.childCount > 0 && isOpen)
			{
				RectTransform rectTransform = filtersAnchor;
				int index = 0;
				FocusNavigationElement component = rectTransform.GetChild(index).GetComponent<FocusNavigationElement>();
			}
			RectTransform rectTransform2 = headerContent;
			int num2 = 0;
			if (rectTransform2 != (Object)num2)
			{
				GameObject focusAnchor = _focusAnchor;
				if ((object)focusAnchor != null)
				{
					FocusNavigationElement component2 = focusAnchor.GetComponent<FocusNavigationElement>();
				}
				int num3 = 0;
				focusNavigation.SetFocus((FocusNavigationElement)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CB6")]
		[Cpp2IlInjected.Address(RVA = "0x17F1650", Offset = "0x17F0050", VA = "0x1817F1650")]
		public ToggleFilterSelector()
		{
			((FishingStallLayout)(object)this)._002Ector();
		}
	}
}
