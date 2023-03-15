using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class ObjectReferencePicker : SkinnedWindow, IListViewAdapter
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		public delegate void OnReferenceChanged(UnityEngine.Object reference);

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private const string SPRITE_ATLAS_PREFIX = "SpriteAtlasTexture-";

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static ObjectReferencePicker m_instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private OnReferenceChanged onReferenceChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		[SerializeField]
		private Image panel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		[SerializeField]
		private Image scrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		[SerializeField]
		private InputField searchBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		[SerializeField]
		private Image searchIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		[SerializeField]
		private Image searchBarBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		[SerializeField]
		private Text selectPromptText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		[SerializeField]
		private LayoutElement searchBarLayoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		[SerializeField]
		private LayoutElement buttonsLayoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		[SerializeField]
		private Button cancelButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		[SerializeField]
		private Button okButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		[SerializeField]
		private RecycledListView listView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		[SerializeField]
		private Image listViewBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		[SerializeField]
		private ObjectReferencePickerItem referenceItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private Canvas referenceCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private readonly List<UnityEngine.Object> references = (List<UnityEngine.Object>)(object)new List<T>(64);

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private readonly List<UnityEngine.Object> filteredReferences = (List<UnityEngine.Object>)(object)new List<T>(64);

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private UnityEngine.Object initialValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private UnityEngine.Object currentlySelectedObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private ObjectReferencePickerItem currentlySelectedItem;

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public static ObjectReferencePicker Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x12A5710", Offset = "0x12A4110", VA = "0x1812A5710")]
			get
			{
				//Discarded unreachable code: IL_004b
				if (!m_instance)
				{
					m_instance = UnityEngine.Object.FindObjectOfType<ObjectReferencePicker>();
					GameObject gameObject = m_instance.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					HashSet<Transform> ignoredTransformsInHierarchy = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
					Transform item = m_instance.transform;
					bool flag = ((HashSet<T>)(object)ignoredTransformsInHierarchy).Add((T)item);
				}
				return m_instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		int IListViewAdapter.Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x12A50F0", Offset = "0x12A3AF0", VA = "0x1812A50F0", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)filteredReferences)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		float IListViewAdapter.ItemHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0xE37B50", Offset = "0xE36550", VA = "0x180E37B50", Slot = "8")]
			get
			{
				UISkin skin = base.m_skin;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x12A4070", Offset = "0x12A2A70", VA = "0x1812A4070", Slot = "4")]
		protected override void Awake()
		{
			//Discarded unreachable code: IL_0077
			base.Awake();
			listView.SetAdapter(this);
			InputField.OnChangeEvent onValueChanged = searchBar.m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnSearchTextChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = cancelButton.m_OnClick;
			UnityAction call = Cancel;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = okButton.m_OnClick;
			UnityAction call2 = Close;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x12A5500", Offset = "0x12A3F00", VA = "0x1812A5500")]
		public void Show(OnReferenceChanged onReferenceChanged, Type referenceType, UnityEngine.Object[] references, UnityEngine.Object initialReference, Canvas referenceCanvas)
		{
			//Discarded unreachable code: IL_006a
			//IL_0007: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			initialValue = (UnityEngine.Object)0;
			this.onReferenceChanged = onReferenceChanged;
			RectTransform rectTransform = panel.rectTransform;
			int num = 0;
			Vector2 vector = (rectTransform.anchoredPosition = Vector2.zero);
			base.gameObject.SetActive(value: true);
			Text text = selectPromptText;
			string text2 = referenceType.Name;
			string text4 = (text.text = "Select " + text2);
			currentlySelectedObject = (UnityEngine.Object)0;
			GenerateReferenceItems(references, referenceType);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x12A4210", Offset = "0x12A2C10", VA = "0x1812A4210")]
		public void Cancel()
		{
			//Discarded unreachable code: IL_007f
			//IL_003c: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			UnityEngine.Object @object = currentlySelectedObject;
			UnityEngine.Object object2 = initialValue;
			if (@object != object2)
			{
				OnReferenceChanged onReferenceChanged = this.onReferenceChanged;
				if (onReferenceChanged != null)
				{
					UnityEngine.Object reference = initialValue;
					onReferenceChanged(reference);
				}
			}
			int num = 0;
			this.onReferenceChanged = (OnReferenceChanged)num;
			initialValue = (UnityEngine.Object)num;
			currentlySelectedObject = (UnityEngine.Object)num;
			currentlySelectedItem = (ObjectReferencePickerItem)num;
			((List<T>)(object)references).Clear();
			((List<T>)(object)filteredReferences).Clear();
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x12A4380", Offset = "0x12A2D80", VA = "0x1812A4380")]
		public void Close()
		{
			//Discarded unreachable code: IL_0045
			//IL_0009: Expected O, but got I4
			//IL_0010: Expected O, but got I4
			//IL_0017: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			int num = 0;
			onReferenceChanged = (OnReferenceChanged)num;
			initialValue = (UnityEngine.Object)num;
			currentlySelectedObject = (UnityEngine.Object)num;
			currentlySelectedItem = (ObjectReferencePickerItem)num;
			((List<T>)(object)references).Clear();
			((List<T>)(object)filteredReferences).Clear();
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x12A5300", Offset = "0x12A3D00", VA = "0x1812A5300", Slot = "6")]
		protected override void RefreshSkin()
		{
			//Discarded unreachable code: IL_0142
			UISkin skin = base.m_skin;
			Image image = panel;
			Color color = (image.color = skin.m_windowColor);
			UISkin skin2 = base.m_skin;
			Image image2 = listViewBackground;
			Color color2 = (image2.color = skin2.m_backgroundColor);
			UISkin skin3 = base.m_skin;
			Image image3 = scrollbar;
			Color color3 = (image3.color = skin3.m_scrollbarColor);
			UISkin skin4 = base.m_skin;
			selectPromptText.SetSkinText(skin4);
			InputField inputField = searchBar;
			UISkin skin5 = base.m_skin;
			inputField.m_TextComponent.SetSkinButtonText(skin5);
			UISkin skin6 = base.m_skin;
			Image image4 = searchBarBackground;
			Color color4 = (image4.color = skin6.m_buttonBackgroundColor);
			UISkin skin7 = base.m_skin;
			Image image5 = searchIcon;
			Color color5 = (image5.color = skin7.m_buttonTextColor);
			UISkin skin8 = base.m_skin;
			LayoutElement layoutElement = searchBarLayoutElement;
			UISkin skin9 = base.m_skin;
			LayoutElement layoutElement2 = buttonsLayoutElement;
			float b = Mathf.Min(45f, b);
			layoutElement2.SetHeight(b);
			UISkin skin10 = base.m_skin;
			cancelButton.SetSkinButton(skin10);
			UISkin skin11 = base.m_skin;
			okButton.SetSkinButton(skin11);
			listView.ResetList();
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x12A45B0", Offset = "0x12A2FB0", VA = "0x1812A45B0")]
		private void GenerateReferenceItems(UnityEngine.Object[] references, Type referenceType)
		{
			//Discarded unreachable code: IL_0161
			//IL_003a: Expected O, but got I4
			//IL_0160: Expected I4, but got I8
			((List<T>)(object)this.references).Clear();
			((List<T>)(object)filteredReferences).Clear();
			InputField inputField = searchBar;
			string text = (inputField.text = string.Empty);
			List<UnityEngine.Object> list = this.references;
			int num = 0;
			((List<T>)(object)list).Add((T)num);
			if (_003C_003Ec._003C_003E9__34_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Comparison<T>)delegate(UnityEngine.Object ref1, UnityEngine.Object ref2)
				{
					//Discarded unreachable code: IL_0016
					string text2 = ref1.GetName();
					string strB = ref2.GetName();
					return text2.CompareTo(strB);
				};
			}
			Type typeFromHandle = typeof(Texture);
			if (!((object)referenceType).Equals((object)typeFromHandle))
			{
				Type typeFromHandle2 = typeof(Texture);
				if (!((object)referenceType).Equals((object)typeFromHandle2))
				{
					Type typeFromHandle3 = typeof(Sprite);
					bool flag = ((object)referenceType).Equals((object)typeFromHandle3);
				}
			}
			int num2 = 0;
			int length = references.Length;
			if (num2 < length)
			{
				ulong num3 = default(ulong);
				if ((bool)references[num2] && (references[num2].hideFlags == HideFlags.None || references[num2].hideFlags == HideFlags.NotEditable || references[num2].hideFlags == HideFlags.HideInHierarchy || references[num2].hideFlags == HideFlags.HideInInspector) && (num3 == 0 || !references[num2].name.StartsWith("SpriteAtlasTexture-")))
				{
					List<UnityEngine.Object> list2 = this.references;
					UnityEngine.Object item = references[num2];
					((List<T>)(object)list2).Add((T)item);
				}
				num2++;
			}
			string empty2 = string.Empty;
			OnSearchTextChanged(empty2);
			ulong num4 = default(ulong);
			listView.UpdateList((byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x12A4AA0", Offset = "0x12A34A0", VA = "0x1812A4AA0", Slot = "9")]
		RecycledListItem IListViewAdapter.CreateItem(Transform parent)
		{
			ObjectReferencePickerItem original = referenceItemPrefab;
			int worldPositionStays = 0;
			ObjectReferencePickerItem objectReferencePickerItem = UnityEngine.Object.Instantiate(original, parent, (byte)worldPositionStays != 0);
			UISkin uISkin = (objectReferencePickerItem.Skin = base.m_skin);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x12A5130", Offset = "0x12A3B30", VA = "0x1812A5130")]
		private void OnSearchTextChanged(string value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x12A4D90", Offset = "0x12A3790", VA = "0x1812A4D90", Slot = "10")]
		void IListViewAdapter.SetItemContent(RecycledListItem item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x12A4B50", Offset = "0x12A3550", VA = "0x1812A4B50", Slot = "11")]
		void IListViewAdapter.OnItemClicked(RecycledListItem item)
		{
			bool flag = default(bool);
			if (flag)
			{
			}
			if ((object)item == null)
			{
			}
			int num = 0;
			if ((object)item != null)
			{
				currentlySelectedItem = (ObjectReferencePickerItem)item;
				currentlySelectedObject = item;
				if (onReferenceChanged == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x12A4450", Offset = "0x12A2E50", VA = "0x1812A4450")]
		public static void DestroyInstance()
		{
			//Discarded unreachable code: IL_0031
			if ((bool)m_instance)
			{
				HashSet<Transform> ignoredTransformsInHierarchy = RuntimeInspectorUtils.IgnoredTransformsInHierarchy;
				Transform item = m_instance.transform;
				bool flag = ((HashSet<T>)(object)ignoredTransformsInHierarchy).Remove((T)item);
				UnityEngine.Object.Destroy(m_instance);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x12A5650", Offset = "0x12A4050", VA = "0x1812A5650")]
		public ObjectReferencePicker()
		{
			((GlowingTile)(object)this)._002Ector();
		}
	}
}
