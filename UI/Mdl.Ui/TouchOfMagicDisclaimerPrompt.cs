using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000511")]
	[RequiredAllNotNull]
	public class TouchOfMagicDisclaimerPrompt : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000512")]
		public class TOMDisclaimerPromptParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001B61")]
			public Action OnAcceptButton;

			[Cpp2IlInjected.Token(Token = "0x6002108")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public TOMDisclaimerPromptParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001B5D")]
		private TOMDisclaimerPromptParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001B5E")]
		[SerializeField]
		private float _buttonDelay = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001B5F")]
		[SerializeField]
		private Button _btnAccept;

		[Cpp2IlInjected.Token(Token = "0x4001B60")]
		public static readonly string TOM_DISCLAIMER_AGREED = "ToMDisclaimerAgreed";

		[Cpp2IlInjected.Token(Token = "0x60020FF")]
		[Cpp2IlInjected.Address(RVA = "0x17F2C20", Offset = "0x17F1620", VA = "0x1817F2C20", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0021
			Button.ButtonClickedEvent onClick = _btnAccept.m_OnClick;
			UnityAction call = OnAcceptButton;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002100")]
		[Cpp2IlInjected.Address(RVA = "0x17F2D40", Offset = "0x17F1740", VA = "0x1817F2D40", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0021
			Button.ButtonClickedEvent onClick = _btnAccept.m_OnClick;
			UnityAction call = OnAcceptButton;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002101")]
		[Cpp2IlInjected.Address(RVA = "0x17F2AE0", Offset = "0x17F14E0", VA = "0x1817F2AE0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0035
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					int num2 = 0;
					_param = (TOMDisclaimerPromptParam)param;
				}
			}
			int _003C_003E1__state = default(int);
			_003CShowAcceptButtonWithDelay_003Ed__11 _003CShowAcceptButtonWithDelay_003Ed__ = new _003CShowAcceptButtonWithDelay_003Ed__11(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowAcceptButtonWithDelay_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CShowAcceptButtonWithDelay_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002102")]
		[Cpp2IlInjected.Address(RVA = "0x17F2A30", Offset = "0x17F1430", VA = "0x1817F2A30", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_004a
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigationElement component = _btnAccept.GetComponent<FocusNavigationElement>();
				base.MenuNavigation?.FocusNavigation?.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002103")]
		[Cpp2IlInjected.Address(RVA = "0x17F2900", Offset = "0x17F1300", VA = "0x1817F2900")]
		private void OnAcceptButton()
		{
			//Discarded unreachable code: IL_0042
			if (_btnAccept.gameObject.activeInHierarchy)
			{
				PopSelf();
				_param?.OnAcceptButton?.Invoke();
				IDesignerHost activeDesigner = ((IDesignerEventService)BaseUiRoot.Instance).ActiveDesigner;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002104")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002105")]
		[Cpp2IlInjected.Address(RVA = "0x17F2CD0", Offset = "0x17F16D0", VA = "0x1817F2CD0")]
		[IteratorStateMachine(typeof(_003CShowAcceptButtonWithDelay_003Ed__11))]
		private IEnumerator ShowAcceptButtonWithDelay()
		{
			int _003C_003E1__state = default(int);
			_003CShowAcceptButtonWithDelay_003Ed__11 _003CShowAcceptButtonWithDelay_003Ed__ = new _003CShowAcceptButtonWithDelay_003Ed__11(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowAcceptButtonWithDelay_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002106")]
		[Cpp2IlInjected.Address(RVA = "0x17F2E40", Offset = "0x17F1840", VA = "0x1817F2E40")]
		public TouchOfMagicDisclaimerPrompt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002107")]
		[Cpp2IlInjected.Address(RVA = "0x17F2DF0", Offset = "0x17F17F0", VA = "0x1817F2DF0")]
		static TouchOfMagicDisclaimerPrompt()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
