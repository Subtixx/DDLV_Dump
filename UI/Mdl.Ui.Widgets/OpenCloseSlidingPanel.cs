using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009BE")]
	[RequireComponent(typeof(SlidingPanel))]
	public class OpenCloseSlidingPanel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003958")]
		public Button toggleButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003959")]
		public Button openButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400395A")]
		public Button closeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400395B")]
		public UnityEvent OnExplicitCloseWithButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400395C")]
		private SlidingPanel _slidingPanel;

		[Cpp2IlInjected.Token(Token = "0x6003CF8")]
		[Cpp2IlInjected.Address(RVA = "0x12A58B0", Offset = "0x12A42B0", VA = "0x1812A58B0")]
		private void Awake()
		{
			SlidingPanel slidingPanel = (_slidingPanel = GetComponent<SlidingPanel>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CF9")]
		[Cpp2IlInjected.Address(RVA = "0x12A5A90", Offset = "0x12A4490", VA = "0x1812A5A90")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_007e
			Button button = toggleButton;
			if ((object)button != null)
			{
				Button.ButtonClickedEvent onClick = button.m_OnClick;
				UnityAction call = TogglePanel;
				onClick.AddListener(call);
			}
			Button button2 = openButton;
			if ((object)button2 != null)
			{
				Button.ButtonClickedEvent onClick2 = button2.m_OnClick;
				UnityAction call2 = OpenPanel;
				onClick2.AddListener(call2);
			}
			Button button3 = closeButton;
			if ((object)button3 != null)
			{
				Button.ButtonClickedEvent onClick3 = button3.m_OnClick;
				UnityAction call3 = ClosePanel;
				onClick3.AddListener(call3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFA")]
		[Cpp2IlInjected.Address(RVA = "0x12A5940", Offset = "0x12A4340", VA = "0x1812A5940")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_007e
			Button button = toggleButton;
			if ((object)button != null)
			{
				Button.ButtonClickedEvent onClick = button.m_OnClick;
				UnityAction call = TogglePanel;
				onClick.RemoveListener(call);
			}
			Button button2 = openButton;
			if ((object)button2 != null)
			{
				Button.ButtonClickedEvent onClick2 = button2.m_OnClick;
				UnityAction call2 = OpenPanel;
				onClick2.RemoveListener(call2);
			}
			Button button3 = closeButton;
			if ((object)button3 != null)
			{
				Button.ButtonClickedEvent onClick3 = button3.m_OnClick;
				UnityAction call3 = ClosePanel;
				onClick3.RemoveListener(call3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFB")]
		[Cpp2IlInjected.Address(RVA = "0x12A5BE0", Offset = "0x12A45E0", VA = "0x1812A5BE0")]
		private void OpenPanel()
		{
			//Discarded unreachable code: IL_000c
			_slidingPanel.Open();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFC")]
		[Cpp2IlInjected.Address(RVA = "0x12A5C00", Offset = "0x12A4600", VA = "0x1812A5C00")]
		public void TogglePanel()
		{
			//Discarded unreachable code: IL_0037
			bool isClosed = _slidingPanel.IsClosed;
			SlidingPanel slidingPanel = _slidingPanel;
			if (!isClosed)
			{
				slidingPanel.Close();
				OnExplicitCloseWithButton?.Invoke();
			}
			else
			{
				slidingPanel.Open();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFD")]
		[Cpp2IlInjected.Address(RVA = "0x12A5900", Offset = "0x12A4300", VA = "0x1812A5900")]
		private void ClosePanel()
		{
			//Discarded unreachable code: IL_001e
			_slidingPanel.Close();
			OnExplicitCloseWithButton?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CFE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public OpenCloseSlidingPanel()
		{
		}
	}
}
