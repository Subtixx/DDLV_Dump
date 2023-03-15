using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006B0")]
	public class SettingsItemGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025D8")]
		[SerializeField]
		private Image _background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40025D9")]
		[SerializeField]
		private TemplateButton _control;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40025DA")]
		[SerializeField]
		private TextBase _label;

		[Cpp2IlInjected.Token(Token = "0x17000646")]
		public TextBase Label
		{
			[Cpp2IlInjected.Token(Token = "0x6002B1D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _label;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B1E")]
		[Cpp2IlInjected.Address(RVA = "0x126B4E0", Offset = "0x1269EE0", VA = "0x18126B4E0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0063
			UnityEvent onHighlighted = _control.OnHighlighted;
			UnityAction call = UpdateVisuals;
			onHighlighted.AddListener(call);
			UnityEvent onDehighlighted = _control.OnDehighlighted;
			UnityAction call2 = UpdateVisuals;
			onDehighlighted.AddListener(call2);
			TemplateButton control = _control;
			Image background = _background;
			bool flag = (background.enabled = control._isHighlighted);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B1F")]
		[Cpp2IlInjected.Address(RVA = "0x126B400", Offset = "0x1269E00", VA = "0x18126B400")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0041
			UnityEvent onHighlighted = _control.OnHighlighted;
			UnityAction call = UpdateVisuals;
			onHighlighted.RemoveListener(call);
			UnityEvent onDehighlighted = _control.OnDehighlighted;
			UnityAction call2 = UpdateVisuals;
			onDehighlighted.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B20")]
		[Cpp2IlInjected.Address(RVA = "0x126B5E0", Offset = "0x1269FE0", VA = "0x18126B5E0")]
		private void UpdateVisuals()
		{
			//Discarded unreachable code: IL_001d
			TemplateButton control = _control;
			Image background = _background;
			bool flag = (background.enabled = control._isHighlighted);
		}

		[Cpp2IlInjected.Token(Token = "0x6002B21")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SettingsItemGroup()
		{
		}
	}
}
