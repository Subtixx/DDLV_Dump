using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using glPlayFab;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002A7")]
	[RequiredAllNotNull]
	public class GardeningStallHireContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C00")]
		[SerializeField]
		private ButtonTmProIcon _btnHire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000C01")]
		[SerializeField]
		private TextBase _tfHireButtonLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000C02")]
		[SerializeField]
		private Slider _mcSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000C03")]
		[SerializeField]
		private Button _btnAddDay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000C04")]
		[SerializeField]
		private Button _btnSubtractDay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000C05")]
		[SerializeField]
		private TextBase _tfDay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000C06")]
		private bool _alreadtHired;

		[Cpp2IlInjected.Token(Token = "0x170002FE")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x60010A7")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CCancellationToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60010A8")]
			[Cpp2IlInjected.Address(RVA = "0xE48510", Offset = "0xE46F10", VA = "0x180E48510")]
			[CompilerGenerated]
			set
			{
				_003CCancellationToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010A9")]
		[Cpp2IlInjected.Address(RVA = "0xE47E10", Offset = "0xE46810", VA = "0x180E47E10")]
		private void Awake()
		{
			//Discarded unreachable code: IL_008e
			Button.ButtonClickedEvent onClick = _btnHire.ButtonComponent.m_OnClick;
			UnityAction call = OnHireClickHandler;
			onClick.AddListener(call);
			Slider.SliderEvent onValueChanged = _mcSlider.m_OnValueChanged;
			UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(OnSliderValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick2 = _btnAddDay.m_OnClick;
			UnityAction call2 = OnAddClickHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnSubtractDay.m_OnClick;
			UnityAction call3 = OnSubtractClickHandler;
			onClick3.AddListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x60010AA")]
		[Cpp2IlInjected.Address(RVA = "0xE48110", Offset = "0xE46B10", VA = "0x180E48110")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_008e
			Button.ButtonClickedEvent onClick = _btnHire.ButtonComponent.m_OnClick;
			UnityAction call = OnHireClickHandler;
			onClick.RemoveListener(call);
			Slider.SliderEvent onValueChanged = _mcSlider.m_OnValueChanged;
			UnityAction<float> unityAction = (UnityAction<float>)(object)new UnityAction<T0>(OnSliderValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick2 = _btnAddDay.m_OnClick;
			UnityAction call2 = OnAddClickHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnSubtractDay.m_OnClick;
			UnityAction call3 = OnSubtractClickHandler;
			onClick3.RemoveListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x60010AB")]
		[Cpp2IlInjected.Address(RVA = "0xE484C0", Offset = "0xE46EC0", VA = "0x180E484C0")]
		private void OnSubtractClickHandler()
		{
			//Discarded unreachable code: IL_0016
			Slider mcSlider = _mcSlider;
			float value = mcSlider.value;
			string contentType = ((IOpenIdAPI)mcSlider).ContentType;
		}

		[Cpp2IlInjected.Token(Token = "0x60010AC")]
		[Cpp2IlInjected.Address(RVA = "0xE480C0", Offset = "0xE46AC0", VA = "0x180E480C0")]
		private void OnAddClickHandler()
		{
			//Discarded unreachable code: IL_0016
			Slider mcSlider = _mcSlider;
			float value = mcSlider.value;
			string contentType = ((IOpenIdAPI)mcSlider).ContentType;
		}

		[Cpp2IlInjected.Token(Token = "0x60010AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void init()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60010AE")]
		[Cpp2IlInjected.Address(RVA = "0xE48420", Offset = "0xE46E20", VA = "0x180E48420")]
		private void OnSliderValueChanged(float arg0)
		{
			//Discarded unreachable code: IL_004e
			ButtonTmProIcon btnHire = _btnHire;
			int num = 0;
			bool flag2 = (btnHire.IsActive = (_alreadtHired ? 1 : 0) == num);
			Button btnSubtractDay = _btnSubtractDay;
			if ((object)btnSubtractDay == null)
			{
			}
			btnSubtractDay.interactable = true;
			Slider mcSlider = _mcSlider;
			Button btnAddDay = _btnAddDay;
			float maxValue = mcSlider.m_MaxValue;
			btnAddDay.interactable = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60010AF")]
		[Cpp2IlInjected.Address(RVA = "0xE482F0", Offset = "0xE46CF0", VA = "0x180E482F0")]
		private void OnHireClickHandler()
		{
			//Discarded unreachable code: IL_000e
			ButtonTmProIcon btnHire = _btnHire;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60010B0")]
		[Cpp2IlInjected.Address(RVA = "0xE47FF0", Offset = "0xE469F0", VA = "0x180E47FF0")]
		[AsyncStateMachine(typeof(_003CHireTask_003Ed__18))]
		private Task HireTask(CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60010B1")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GardeningStallHireContent()
		{
		}
	}
}
