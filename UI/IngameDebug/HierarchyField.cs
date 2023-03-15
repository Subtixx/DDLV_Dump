using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using GK;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class HierarchyField : RecycledListItem
	{
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		private enum ExpandedState
		{
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			Collapsed,
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			Expanded,
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			ArrowHidden
		}

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private const float INACTIVE_ITEM_TEXT_ALPHA = 0.57f;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private const float TEXT_X_OFFSET = 35f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		[SerializeField]
		private RectTransform contentTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		[SerializeField]
		private Text nameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		[SerializeField]
		private PointerEventListener clickListener;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		[SerializeField]
		private PointerEventListener expandToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[SerializeField]
		private Image expandArrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private Image background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private int m_skinVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private UISkin m_skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool m_isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private bool m_isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private ExpandedState m_isExpanded;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		public UISkin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return m_skin;
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xAE8980", Offset = "0xAE7380", VA = "0x180AE8980")]
			set
			{
				//Discarded unreachable code: IL_0086
				//IL_004e: Expected O, but got I4
				if (!(m_skin != value))
				{
					int version = m_skin.m_version;
					if (m_skinVersion == version)
					{
						return;
					}
				}
				m_skin = value;
				int version2 = m_skin.m_version;
				int num = 0;
				RectTransform rectTransform = this.rectTransform;
				m_skinVersion = version2;
				rectTransform.sizeDelta = (Vector2)num;
				UISkin skin = m_skin;
				nameText.SetSkinText(skin);
				UISkin skin2 = m_skin;
				Image image = expandArrow;
				Color color = (image.color = skin2.m_expandArrowColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xAE8610", Offset = "0xAE7010", VA = "0x180AE8610")]
			get
			{
				return m_isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xAE87D0", Offset = "0xAE71D0", VA = "0x180AE87D0")]
			set
			{
				//Discarded unreachable code: IL_007c
				m_isSelected = value;
				if (!value)
				{
					HierarchyData hierarchyData = Data;
					Image image = background;
					if (hierarchyData.m_depth == 0)
					{
						Color backgroundColor = m_skin.m_backgroundColor;
					}
					UISkin skin = m_skin;
				}
				UISkin skin2 = m_skin;
				Image image2 = background;
				Color color = (image2.color = skin2.m_selectedItemBackgroundColor);
				Color selectedItemTextColor = m_skin.m_selectedItemTextColor;
				if (m_isActive)
				{
				}
				nameText.color = selectedItemTextColor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		private bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xAE85F0", Offset = "0xAE6FF0", VA = "0x180AE85F0")]
			get
			{
				return m_isActive;
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xAE8640", Offset = "0xAE7040", VA = "0x180AE8640")]
			set
			{
				//Discarded unreachable code: IL_0028
				if (m_isActive != value)
				{
					m_isActive = value;
					Text text = nameText;
					if (m_isActive)
					{
					}
					Text text2 = nameText;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		private ExpandedState IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xAE8600", Offset = "0xAE7000", VA = "0x180AE8600")]
			get
			{
				return m_isExpanded;
			}
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xAE86D0", Offset = "0xAE70D0", VA = "0x180AE86D0")]
			set
			{
				//Discarded unreachable code: IL_005b
				if (m_isExpanded == value)
				{
					return;
				}
				m_isExpanded = value;
				PointerEventListener pointerEventListener = expandToggle;
				if (value != ExpandedState.ArrowHidden)
				{
					pointerEventListener.gameObject.SetActive(value: true);
					RectTransform rectTransform = expandArrow.rectTransform;
					if (m_isExpanded == ExpandedState.Expanded)
					{
					}
					float z = Vector3.zero.z;
				}
				else
				{
					GameObject gameObject = base.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x80"), Cpp2IlInjected.Token(Token = "0x40003AB")]
		public float PreferredWidth
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xAE8620", Offset = "0xAE7020", VA = "0x180AE8620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xAE8970", Offset = "0xAE7370", VA = "0x180AE8970")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public RuntimeHierarchy Hierarchy
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			[CompilerGenerated]
			get
			{
				return _003CHierarchy_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
			[CompilerGenerated]
			private set
			{
				_003CHierarchy_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public HierarchyData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xAE8630", Offset = "0xAE7030", VA = "0x180AE8630")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xAE7E20", Offset = "0xAE6820", VA = "0x180AE7E20")]
		public void Initialize(RuntimeHierarchy hierarchy)
		{
			//IL_0022: Expected O, but got I4
			Hierarchy = hierarchy;
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform == null || (object)transform != null)
			{
				rectTransform = (RectTransform)num;
				Image image = (background = clickListener.GetComponent<Image>());
				PointerEventListener pointerEventListener = expandToggle;
				PointerEventListener.PointerEvent value = delegate
				{
					//Discarded unreachable code: IL_0008
					HierarchyData hierarchyData = Data;
				};
				pointerEventListener.PointerClick += value;
				PointerEventListener pointerEventListener2 = clickListener;
				PointerEventListener.PointerEvent value2 = delegate
				{
					OnClick();
				};
				pointerEventListener2.PointerClick += value2;
				PointerEventListener pointerEventListener3 = clickListener;
				PointerEventListener.PointerEvent value3 = OnPointerDown;
				pointerEventListener3.PointerDown += value3;
				PointerEventListener pointerEventListener4 = clickListener;
				PointerEventListener.PointerEvent value4 = OnPointerUp;
				pointerEventListener4.PointerUp += value4;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xAE83C0", Offset = "0xAE6DC0", VA = "0x180AE83C0")]
		public void SetContent(HierarchyData data)
		{
			//Discarded unreachable code: IL_00b5
			Data = data;
			UISkin skin = m_skin;
			RectTransform rectTransform = contentTransform;
			int num = 0;
			Image image = background;
			RuntimeHierarchy runtimeHierarchy = Hierarchy;
			if (data.m_depth == 0)
			{
			}
			Sprite sprite = (image.sprite = runtimeHierarchy.m_transformDrawerBackground);
			HierarchyData hierarchyData = Data;
			Text text = nameText;
			string text3 = (text.text = hierarchyData.Name);
			if (Hierarchy.m_showHorizontalScrollbar)
			{
				LayoutRebuilder.ForceRebuildLayoutImmediate(nameText.rectTransform);
				int depth = Data.m_depth;
				UISkin skin2 = m_skin;
				Text text4 = nameText;
				int indentAmount = skin2.m_indentAmount;
				Vector2 sizeDelta = text4.rectTransform.sizeDelta;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xAE85B0", Offset = "0xAE6FB0", VA = "0x180AE85B0")]
		private void ToggleExpandedState()
		{
			//Discarded unreachable code: IL_0008
			HierarchyData hierarchyData = Data;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xAE81E0", Offset = "0xAE6BE0", VA = "0x180AE81E0")]
		public void Refresh()
		{
			//Discarded unreachable code: IL_00b0
			bool isActive = Data.IsActive;
			if (m_isActive != isActive)
			{
				Text text = nameText;
				m_isActive = isActive;
				if (m_isActive)
				{
				}
				Text text2 = nameText;
			}
			if (Data.ChildCount > 0)
			{
				HierarchyData hierarchyData = Data;
				int num = 0;
			}
			if (m_isExpanded == ExpandedState.ArrowHidden)
			{
				return;
			}
			PointerEventListener pointerEventListener = expandToggle;
			m_isExpanded = ExpandedState.ArrowHidden;
			if (2L != 2L)
			{
				pointerEventListener.gameObject.SetActive(value: true);
				RectTransform rectTransform = expandArrow.rectTransform;
				if (m_isExpanded == ExpandedState.Expanded)
				{
				}
				float z = Vector3.zero.z;
			}
			else
			{
				RectTransform rectTransform = default(RectTransform);
				GameObject gameObject = rectTransform.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xAE80A0", Offset = "0xAE6AA0", VA = "0x180AE80A0")]
		public void RefreshName()
		{
			//Discarded unreachable code: IL_006e
			HierarchyData hierarchyData = Data;
			Text text = nameText;
			string text3 = (text.text = hierarchyData.Name);
			if (Hierarchy.m_showHorizontalScrollbar)
			{
				LayoutRebuilder.ForceRebuildLayoutImmediate(nameText.rectTransform);
				int depth = Data.m_depth;
				UISkin skin = m_skin;
				Text text4 = nameText;
				int indentAmount = skin.m_indentAmount;
				Vector2 sizeDelta = text4.rectTransform.sizeDelta;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xAE8020", Offset = "0xAE6A20", VA = "0x180AE8020")]
		private void OnPointerDown(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_000f
			Hierarchy.OnDrawerPointerEvent(this, eventData, isPointerDown: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xAE8060", Offset = "0xAE6A60", VA = "0x180AE8060")]
		private void OnPointerUp(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0013
			RuntimeHierarchy runtimeHierarchy = Hierarchy;
			int isPointerDown = 0;
			runtimeHierarchy.OnDrawerPointerEvent(this, eventData, (byte)isPointerDown != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public HierarchyField()
		{
			((Geom)(object)this)._002Ector();
		}
	}
}
