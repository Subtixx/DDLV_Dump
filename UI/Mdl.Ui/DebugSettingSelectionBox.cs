using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003F1")]
	public class DebugSettingSelectionBox : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003F2")]
		public class ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x17000427")]
			public string Text
			{
				[Cpp2IlInjected.Token(Token = "0x6001913")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CText_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6001914")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CText_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000428")]
			public object Data
			{
				[Cpp2IlInjected.Token(Token = "0x6001915")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CData_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6001916")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CData_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001917")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ItemData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001357")]
		private bool _isOpened;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001358")]
		private string _selectedString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001359")]
		private object _dataRefreshSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400135A")]
		private Action _onSizeChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400135B")]
		private Action<string, object> _onItemSelectionChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400135C")]
		private Action<DebugSettingSelectionBox, object, bool> _onBoxClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400135D")]
		[SerializeField]
		private TextBase _tfSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400135E")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400135F")]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001362")]
		[SerializeField]
		private GameObject _mcHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001363")]
		[SerializeField]
		private GameObject _prefabItem;

		[Cpp2IlInjected.Token(Token = "0x17000422")]
		public List<ItemData> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6001901")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CItems_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001902")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			private set
			{
				_003CItems_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000423")]
		public string Label
		{
			[Cpp2IlInjected.Token(Token = "0x6001904")]
			[Cpp2IlInjected.Address(RVA = "0x1556C10", Offset = "0x1555610", VA = "0x181556C10")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _tfLabel._text;
			}
			[Cpp2IlInjected.Token(Token = "0x6001905")]
			[Cpp2IlInjected.Address(RVA = "0x1556CE0", Offset = "0x15556E0", VA = "0x181556CE0")]
			set
			{
				//Discarded unreachable code: IL_0013
				TextBase tfLabel = _tfLabel;
				if (value == null)
				{
				}
				tfLabel.Text = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000424")]
		public bool IsOpened
		{
			[Cpp2IlInjected.Token(Token = "0x6001906")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return _isOpened;
			}
			[Cpp2IlInjected.Token(Token = "0x6001907")]
			[Cpp2IlInjected.Address(RVA = "0x1556C30", Offset = "0x1555630", VA = "0x181556C30")]
			set
			{
				//Discarded unreachable code: IL_0046
				GameObject mcHolder = _mcHolder;
				_isOpened = value;
				mcHolder.SetActive(value);
				RefreshVisual();
				FocusNavigation focusNavigation = _focusNavigation;
				if (!_isOpened)
				{
					FocusNavigationElement component = GetComponent<FocusNavigationElement>();
				}
				FocusNavigationElement componentInChildren = _mcHolder.GetComponentInChildren<FocusNavigationElement>();
				focusNavigation.SetFocus(componentInChildren);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000425")]
		public string SelectedString
		{
			[Cpp2IlInjected.Token(Token = "0x6001909")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _selectedString;
			}
			[Cpp2IlInjected.Token(Token = "0x600190A")]
			[Cpp2IlInjected.Address(RVA = "0x1556D50", Offset = "0x1555750", VA = "0x181556D50")]
			set
			{
				//Discarded unreachable code: IL_0021
				if (value == null)
				{
				}
				_selectedString = value;
				TextBase tfSelected = _tfSelected;
				string text = (tfSelected.Text = _selectedString);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000426")]
		public object SelectedData
		{
			[Cpp2IlInjected.Token(Token = "0x600190B")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			[CompilerGenerated]
			get
			{
				return _003CSelectedData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600190C")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			[CompilerGenerated]
			set
			{
				_003CSelectedData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001903")]
		[Cpp2IlInjected.Address(RVA = "0x1556140", Offset = "0x1554B40", VA = "0x181556140")]
		private void Awake()
		{
			FocusNavigation focusNavigation = (_focusNavigation = GetComponentInParent<FocusNavigation>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001908")]
		[Cpp2IlInjected.Address(RVA = "0x1556A40", Offset = "0x1555440", VA = "0x181556A40")]
		private void RefreshVisual()
		{
			//Discarded unreachable code: IL_007e
			if (Items == null)
			{
				return;
			}
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			if (_isOpened)
			{
				if ((object)transform != null)
				{
				}
				List<ItemData> list = Items;
			}
			_onSizeChanged?.Invoke();
			if (_isOpened)
			{
				int num2 = 0;
				EventSystem current = EventSystem.current;
				Transform transform2 = _mcHolder.transform;
				int index = 0;
				GameObject selectedGameObject = transform2.GetChild(index).gameObject;
				current.SetSelectedGameObject(selectedGameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600190D")]
		[Cpp2IlInjected.Address(RVA = "0x1556190", Offset = "0x1554B90", VA = "0x181556190")]
		public void OnClicked()
		{
			//IL_0033: Expected O, but got I4
			bool flag2 = (IsOpened = !_isOpened);
			Action<DebugSettingSelectionBox, object, bool> onBoxClicked = _onBoxClicked;
			if (onBoxClicked != null)
			{
				bool isOpened = _isOpened;
				object dataRefreshSource = _dataRefreshSource;
				onBoxClicked((T1)this, (T2)dataRefreshSource, (T3)isOpened);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600190E")]
		[Cpp2IlInjected.Address(RVA = "0x1556BD0", Offset = "0x15555D0", VA = "0x181556BD0")]
		public void SetDataRefreshOnActivation(object source, Action<DebugSettingSelectionBox, object, bool> onBoxClicked)
		{
			_dataRefreshSource = source;
			_onBoxClicked = onBoxClicked;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600190F")]
		[Cpp2IlInjected.Address(RVA = "0x15562F0", Offset = "0x1554CF0", VA = "0x1815562F0")]
		public void RefreshData(List<string> items, Action onSizeChanged)
		{
			//Discarded unreachable code: IL_0038
			//IL_0037: Expected O, but got I4
			Func<string, ItemData> _003C_003E9__33_ = _003C_003Ec._003C_003E9__33_0;
			if (_003C_003E9__33_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string x) => new ItemData
				{
					Text = x,
					Data = x
				});
			}
			List<ItemData> list = (List<ItemData>)(object)Enumerable.ToList<ItemData>(Enumerable.Select<string, ItemData>((IEnumerable<>)items, (Func<, >)(object)_003C_003E9__33_));
			int num = 0;
			this.RefreshData((List<>)(object)list, onSizeChanged, (Action<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001910")]
		[Cpp2IlInjected.Address(RVA = "0x1556470", Offset = "0x1554E70", VA = "0x181556470")]
		public unsafe void RefreshData(List<ItemData> items, Action onSizeChanged, [Optional] Action<string, object> onItemSelectionChanged)
		{
			//Discarded unreachable code: IL_00dc, IL_00e8
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Items = items;
			IEnumerator enumerator = _mcHolder.transform.GetEnumerator();
			int num5 = default(int);
			if (enumerator != null)
			{
				if (enumerator == null)
				{
				}
				num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
			}
			if (num5 != 0)
			{
			}
			int num6 = 0;
			if (0 < num5)
			{
				int num7 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				GameObject gameObject = default(GameObject);
				DebugSettingSelectionItem component = gameObject.GetComponent<DebugSettingSelectionItem>();
				Button component2 = component.GetComponent<Button>();
				if (num6 != 0)
				{
					UnityEngine.UI.Navigation navigation = ((Selectable)component2).m_Navigation;
					Selectable selectOnDown = ((Selectable)component2).m_Navigation.m_SelectOnDown;
					Button component3 = component.GetComponent<Button>();
					Button button = default(Button);
					UnityEngine.UI.Navigation navigation2 = ((Selectable)button).m_Navigation;
					Selectable selectOnDown2 = ((Selectable)button).m_Navigation.m_SelectOnDown;
					Button component4 = component.GetComponent<Button>();
				}
				Button button2 = default(Button);
				UnityEngine.UI.Navigation navigation3 = ((Selectable)button2).m_Navigation;
				Selectable selectOnDown3 = ((Selectable)button2).m_Navigation.m_SelectOnDown;
				Button component5 = component.GetComponent<Button>();
				num6++;
			}
			((int*)num6)->m_value = 0;
			((int*)num6)->m_value = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001911")]
		[Cpp2IlInjected.Address(RVA = "0x1556200", Offset = "0x1554C00", VA = "0x181556200")]
		private void OnItemSelected(string item, object data)
		{
			//Discarded unreachable code: IL_0044
			if (item == null)
			{
			}
			_selectedString = item;
			TextBase tfSelected = _tfSelected;
			string text = (tfSelected.Text = _selectedString);
			SelectedData = data;
			((Action<T1, T2>)(object)_onItemSelectionChanged)?.Invoke((T1)item, (T2)data);
			int num = ((IsOpened = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001912")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugSettingSelectionBox()
		{
		}
	}
}
