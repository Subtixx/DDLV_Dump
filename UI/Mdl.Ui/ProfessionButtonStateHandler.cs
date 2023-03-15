using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000605")]
	public class ProfessionButtonStateHandler : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002172")]
		[SerializeField]
		private ProfessionButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002173")]
		[SerializeField]
		private GameObject _highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002174")]
		[SerializeField]
		private GameObject _selected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002175")]
		[SerializeField]
		public GameObject _selectHover;

		[Cpp2IlInjected.Token(Token = "0x600277B")]
		[Cpp2IlInjected.Address(RVA = "0xE1B670", Offset = "0xE1A070", VA = "0x180E1B670")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0065
			UnityEvent onClicked = button.OnClicked;
			UnityAction call = OnClick;
			onClicked.AddListener(call);
			UnityEvent onHighlighted = button.OnHighlighted;
			UnityAction call2 = OnHighlight;
			onHighlighted.AddListener(call2);
			UnityEvent onDehighlighted = button.OnDehighlighted;
			UnityAction call3 = OnRemoveHighlight;
			onDehighlighted.AddListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x600277C")]
		[Cpp2IlInjected.Address(RVA = "0xE1B520", Offset = "0xE19F20", VA = "0x180E1B520")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0065
			UnityEvent onClicked = button.OnClicked;
			UnityAction call = OnClick;
			onClicked.RemoveListener(call);
			UnityEvent onHighlighted = button.OnHighlighted;
			UnityAction call2 = OnHighlight;
			onHighlighted.RemoveListener(call2);
			UnityEvent onDehighlighted = button.OnDehighlighted;
			UnityAction call3 = OnRemoveHighlight;
			onDehighlighted.RemoveListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x600277D")]
		[Cpp2IlInjected.Address(RVA = "0xE1B3B0", Offset = "0xE19DB0", VA = "0x180E1B3B0")]
		private void OnClick()
		{
			//Discarded unreachable code: IL_009b
			//IL_006c: Expected O, but got I4
			int num;
			AK.Wwise.Event[] sFXS;
			AK.Wwise.Event @event;
			do
			{
				ProfessionButton professionButton = button;
				GameObject selected = _selected;
				int active = 0;
				selected.SetActive((byte)active != 0);
				GameObject highlight = _highlight;
				int active2 = 0;
				highlight.SetActive((byte)active2 != 0);
				GameObject selectHover = _selectHover;
				num = 0;
				selectHover.SetActive((byte)num != 0);
				sFXS = button.SFXS;
				@event = sFXS[0];
			}
			while (@event == null);
			AK.Wwise.Event event2 = sFXS[1];
			uint num2 = @event.Post((GameObject)num);
			button.IsSelected = true;
			_selected.SetActive(value: true);
			ProfessionButton professionButton2 = button;
			_selectHover.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600277E")]
		[Cpp2IlInjected.Address(RVA = "0xE1B7C0", Offset = "0xE1A1C0", VA = "0x180E1B7C0")]
		private void OnHighlight()
		{
			//Discarded unreachable code: IL_0052
			ProfessionButton professionButton = button;
			GameObject selected = _selected;
			int active = 0;
			selected.SetActive((byte)active != 0);
			GameObject highlight = _highlight;
			int active2 = 0;
			highlight.SetActive((byte)active2 != 0);
			GameObject selectHover = _selectHover;
			int active3 = 0;
			selectHover.SetActive((byte)active3 != 0);
			ProfessionButton professionButton2 = button;
			_selectHover.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600277F")]
		[Cpp2IlInjected.Address(RVA = "0xE1B850", Offset = "0xE1A250", VA = "0x180E1B850")]
		private void OnRemoveHighlight()
		{
			//Discarded unreachable code: IL_005a
			ProfessionButton professionButton = button;
			GameObject selected = _selected;
			int active = 0;
			selected.SetActive((byte)active != 0);
			GameObject highlight = _highlight;
			int active2 = 0;
			highlight.SetActive((byte)active2 != 0);
			GameObject selectHover = _selectHover;
			int active3 = 0;
			selectHover.SetActive((byte)active3 != 0);
			ProfessionButton professionButton2 = button;
			GameObject selectHover2 = _selectHover;
			int active4 = 0;
			selectHover2.SetActive((byte)active4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002780")]
		[Cpp2IlInjected.Address(RVA = "0xE1B8E0", Offset = "0xE1A2E0", VA = "0x180E1B8E0")]
		public void RemoveSelection()
		{
			//Discarded unreachable code: IL_0052
			ProfessionButton professionButton = button;
			int num = ((professionButton.IsSelected = false) ? 1 : 0);
			ProfessionButton professionButton2 = button;
			GameObject selected = _selected;
			int active = 0;
			selected.SetActive((byte)active != 0);
			GameObject highlight = _highlight;
			int active2 = 0;
			highlight.SetActive((byte)active2 != 0);
			GameObject selectHover = _selectHover;
			int active3 = 0;
			selectHover.SetActive((byte)active3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002781")]
		[Cpp2IlInjected.Address(RVA = "0xE1B350", Offset = "0xE19D50", VA = "0x180E1B350")]
		public void ClearState()
		{
			//Discarded unreachable code: IL_003e
			ProfessionButton professionButton = button;
			GameObject selected = _selected;
			int active = 0;
			selected.SetActive((byte)active != 0);
			GameObject highlight = _highlight;
			int active2 = 0;
			highlight.SetActive((byte)active2 != 0);
			GameObject selectHover = _selectHover;
			int active3 = 0;
			selectHover.SetActive((byte)active3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002782")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ProfessionButtonStateHandler()
		{
		}
	}
}
