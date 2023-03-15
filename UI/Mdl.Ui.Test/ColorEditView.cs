using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000911")]
	public class ColorEditView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000912")]
		public delegate void ColorChanged(Color baseColor);

		[Cpp2IlInjected.Token(Token = "0x2000913")]
		public delegate void SaveDesign(DesignWorkingCopy design);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003586")]
		[SerializeField]
		private ColorPicker _colorPicker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003587")]
		[SerializeField]
		private Button _undoButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003588")]
		[SerializeField]
		private Button _redoButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003589")]
		[SerializeField]
		private Button _saveButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400358A")]
		public ColorChanged OnColorChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400358B")]
		public SaveDesign OnSaveDesign;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400358E")]
		private bool _constructed;

		[Cpp2IlInjected.Token(Token = "0x170007E5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x400358C")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x60038F2")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60038F3")]
			[Cpp2IlInjected.Address(RVA = "0x951E90", Offset = "0x950890", VA = "0x180951E90")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007E6")]
		public HistoryStack<DesignWorkingCopy> DesignHistory
		{
			[Cpp2IlInjected.Token(Token = "0x60038F4")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CDesignHistory_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60038F5")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CDesignHistory_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038F6")]
		[Cpp2IlInjected.Address(RVA = "0x114F990", Offset = "0x114E390", VA = "0x18114F990")]
		private void Construct()
		{
			//Discarded unreachable code: IL_008b
			ColorPicker colorPicker = _colorPicker;
			ColorPicker.ColorChanged value = SelectColor;
			colorPicker.OnColorChanged += value;
			Button.ButtonClickedEvent onClick = _undoButton.m_OnClick;
			UnityAction call = Undo;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _redoButton.m_OnClick;
			UnityAction call2 = Redo;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _saveButton.m_OnClick;
			UnityAction call3 = Save;
			onClick3.AddListener(call3);
			_constructed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60038F7")]
		[Cpp2IlInjected.Address(RVA = "0x114FD80", Offset = "0x114E780", VA = "0x18114FD80")]
		public unsafe void Show(HistoryStack<DesignWorkingCopy> designHistory)
		{
			//Discarded unreachable code: IL_00de
			//IL_00dd: Expected O, but got I4
			int num = 0;
			if (!_constructed)
			{
				ColorPicker colorPicker = _colorPicker;
				ColorPicker.ColorChanged value = SelectColor;
				colorPicker.OnColorChanged += value;
				Button.ButtonClickedEvent onClick = _undoButton.m_OnClick;
				UnityAction call = Undo;
				onClick.AddListener(call);
				Button.ButtonClickedEvent onClick2 = _redoButton.m_OnClick;
				UnityAction call2 = Redo;
				onClick2.AddListener(call2);
				Button.ButtonClickedEvent onClick3 = _saveButton.m_OnClick;
				UnityAction call3 = Save;
				onClick3.AddListener(call3);
				_constructed = true;
			}
			base.gameObject.SetActive(value: true);
			IsShown = true;
			DesignHistory = designHistory;
			bool flag = ColorUtility.TryParseHtmlString(((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).Data.baseColor_, out *(Color*)num);
			_colorPicker.Color = (Color)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60038F8")]
		[Cpp2IlInjected.Address(RVA = "0x114FB40", Offset = "0x114E540", VA = "0x18114FB40")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0018
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			IsShown = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60038F9")]
		[Cpp2IlInjected.Address(RVA = "0x114FBE0", Offset = "0x114E5E0", VA = "0x18114FBE0")]
		public void Save()
		{
			//Discarded unreachable code: IL_001f
			SaveDesign onSaveDesign = OnSaveDesign;
			if (onSaveDesign != null)
			{
				DesignWorkingCopy current = (DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current;
				onSaveDesign(current);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038FA")]
		[Cpp2IlInjected.Address(RVA = "0x1150000", Offset = "0x114EA00", VA = "0x181150000")]
		public void Undo()
		{
			//Discarded unreachable code: IL_0016
			if (((HistoryStack<T>)(object)DesignHistory).Undo())
			{
				UpdateColor();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038FB")]
		[Cpp2IlInjected.Address(RVA = "0x114FB80", Offset = "0x114E580", VA = "0x18114FB80")]
		public void Redo()
		{
			//Discarded unreachable code: IL_0016
			if (((HistoryStack<T>)(object)DesignHistory).Redo())
			{
				UpdateColor();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038FC")]
		[Cpp2IlInjected.Address(RVA = "0x1150060", Offset = "0x114EA60", VA = "0x181150060")]
		private void UpdateColor()
		{
			//Discarded unreachable code: IL_004a
			Color white = Color.white;
			if (!string.IsNullOrEmpty(((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).Data.baseColor_))
			{
				string baseColor_ = ((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current).Data.baseColor_;
			}
			ColorPicker colorPicker = _colorPicker;
			if (OnColorChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038FD")]
		[Cpp2IlInjected.Address(RVA = "0x114FC50", Offset = "0x114E650", VA = "0x18114FC50")]
		private void SelectColor(Color color)
		{
			//Discarded unreachable code: IL_0041
			DesignWorkingCopy designWorkingCopy = new DesignWorkingCopy((DesignWorkingCopy)((HistoryStack<T>)(object)DesignHistory).Current);
			Design _003CData_003Ek__BackingField = designWorkingCopy.Data;
			string text = default(string);
			string text3 = (_003CData_003Ek__BackingField.BaseColor = "#" + text);
			((HistoryStack<T>)(object)DesignHistory).Push((T)designWorkingCopy);
			if (OnColorChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038FE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ColorEditView()
		{
		}
	}
}
