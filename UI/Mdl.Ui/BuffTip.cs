using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000574")]
	[RequiredAllNotNull]
	public class BuffTip : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DCD")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DCE")]
		internal BuffTipModel Model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DCF")]
		public UnityEvent OnRefreshDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DD0")]
		private List<BuffItem> _buffItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001DD1")]
		[SerializeField]
		private BuffItem _buffItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001DD2")]
		[SerializeField]
		private RectTransform _buffContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001DD3")]
		[SerializeField]
		private SetSizeBasedOnChild _setSizeBasedOnChild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001DD4")]
		[SerializeField]
		private RectTransform _buffBg;

		[Cpp2IlInjected.Token(Token = "0x60023B6")]
		[Cpp2IlInjected.Address(RVA = "0xA678B0", Offset = "0xA662B0", VA = "0x180A678B0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected F4, but got I4
			CanvasGroup canvasGroup = _canvasGroup;
			int num = 0;
			canvasGroup.alpha = num;
		}

		[Cpp2IlInjected.Token(Token = "0x60023B7")]
		[Cpp2IlInjected.Address(RVA = "0xA678E0", Offset = "0xA662E0", VA = "0x180A678E0")]
		public void RefreshDisplay()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60023B8")]
		[Cpp2IlInjected.Address(RVA = "0xA67EE0", Offset = "0xA668E0", VA = "0x180A67EE0")]
		[IteratorStateMachine(typeof(_003CWaitThenAdjustSize_003Ed__10))]
		private IEnumerator WaitThenAdjustSize()
		{
			int _003C_003E1__state = default(int);
			_003CWaitThenAdjustSize_003Ed__10 _003CWaitThenAdjustSize_003Ed__ = new _003CWaitThenAdjustSize_003Ed__10(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitThenAdjustSize_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023B9")]
		[Cpp2IlInjected.Address(RVA = "0xA67F50", Offset = "0xA66950", VA = "0x180A67F50")]
		public BuffTip()
		{
			//IL_0007: Expected O, but got I4
			//IL_0007: Expected O, but got I4
			int num2 = default(int);
			int num = default(int);
			BuffTipModel model = new BuffTipModel((List<>)num, (List<>)num2);
			num2 = 0;
			num = 0;
			Model = model;
			_buffItems = (List<BuffItem>)(object)new List<T>();
			base._002Ector();
		}
	}
}
