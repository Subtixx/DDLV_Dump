using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002E3")]
	[RequiredAllNotNull]
	public class SelectedFilterItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000DCE")]
		public GameObject Bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000DCF")]
		public GameObject Border;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000DD0")]
		public TextBase TfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000DD1")]
		public Image Image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000DD2")]
		public List<UIGameColors.GameColorName> BgColorForBlackText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000DD3")]
		private List<string> _colorForBlackText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000DD4")]
		[SerializeField]
		private float _colorBrightnessThreshold = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x6001286")]
		[Cpp2IlInjected.Address(RVA = "0x125C310", Offset = "0x125AD10", VA = "0x18125C310")]
		private void OnEnable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001287")]
		[Cpp2IlInjected.Address(RVA = "0x125CDA0", Offset = "0x125B7A0", VA = "0x18125CDA0")]
		public void SetTagData(ITagData tagData)
		{
			int order = default(int);
			TagFilter filter = new TagFilter(tagData, order);
			order = 0;
			SetFilter(filter);
		}

		[Cpp2IlInjected.Token(Token = "0x6001288")]
		[Cpp2IlInjected.Address(RVA = "0x125C890", Offset = "0x125B290", VA = "0x18125C890")]
		public void SetFilter(Filter filter)
		{
			//Discarded unreachable code: IL_003a, IL_00a1, IL_00b0, IL_00b7, IL_00c6, IL_00d6, IL_00db, IL_00e0, IL_00e5, IL_00ea, IL_00f9, IL_00fa, IL_0109
			int num = 0;
			if ((object)filter == null)
			{
				string displayName = filter.DisplayName;
				Color color = filter.Color;
				TfName.StringID = displayName;
				RefreshLayout();
			}
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			int iD = filter.ID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001289")]
		[Cpp2IlInjected.Address(RVA = "0x125C4E0", Offset = "0x125AEE0", VA = "0x18125C4E0")]
		public void RefreshDisplay(string locId, Dictionary<string, object> param, Color color)
		{
			//Discarded unreachable code: IL_0029
			TextBase tfName = TfName;
			string text2 = (tfName.StringID = LocalizationManager.FromStringID(locId, (Dictionary<, >)(object)param));
			Border.SetActive(value: true);
			RefreshLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x600128A")]
		[Cpp2IlInjected.Address(RVA = "0x125C480", Offset = "0x125AE80", VA = "0x18125C480")]
		public void RefreshDisplay(string locId, Color color)
		{
			//Discarded unreachable code: IL_0013
			TfName.StringID = locId;
			RefreshLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x600128B")]
		[Cpp2IlInjected.Address(RVA = "0x125C690", Offset = "0x125B090", VA = "0x18125C690")]
		public void SetColor(Color color)
		{
			//Discarded unreachable code: IL_005f
			Image image = Image;
			TextMeshProUGUI textComponent = TfName.TextComponent;
			string item = default(string);
			bool flag = ((List<T>)(object)_colorForBlackText).Contains((T)item);
			int num = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
			if (!flag)
			{
				float colorBrightnessThreshold = _colorBrightnessThreshold;
				Color color2 = default(Color);
				if ((object)color2 == null)
				{
					int num2 = 0;
					UIGameColors gameColors2 = UiRoot.Instance._gameColors;
				}
			}
			int num3 = 0;
			UIGameColors gameColors3 = UiRoot.Instance._gameColors;
		}

		[Cpp2IlInjected.Token(Token = "0x600128C")]
		[Cpp2IlInjected.Address(RVA = "0x125C570", Offset = "0x125AF70", VA = "0x18125C570")]
		private void RefreshLayout()
		{
			//Discarded unreachable code: IL_0035
			//IL_0013: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num);
			if ((object)base.transform.parent != null)
			{
			}
			if ((object)base.transform.parent.parent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600128D")]
		[Cpp2IlInjected.Address(RVA = "0x125C210", Offset = "0x125AC10", VA = "0x18125C210")]
		public bool IsColorDark(Color color)
		{
			string item = default(string);
			bool flag = ((List<T>)(object)_colorForBlackText).Contains((T)item);
			int num = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
			if (flag)
			{
				return true;
			}
			float colorBrightnessThreshold = _colorBrightnessThreshold;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600128E")]
		[Cpp2IlInjected.Address(RVA = "0x125CE10", Offset = "0x125B810", VA = "0x18125CE10")]
		public SelectedFilterItem()
		{
		}
	}
}
