using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Activities;
using Mdl.Graphic;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004D2")]
	[RequiredAllNotNull]
	public class FishingMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001965")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001966")]
		[SerializeField]
		private TextBase _tfWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001967")]
		[SerializeField]
		private RectTransform _mcNewRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001968")]
		[SerializeField]
		private RectTransform _contentSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001969")]
		[SerializeField]
		private CanvasGroup _contentSliderCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400196A")]
		[SerializeField]
		private RectTransform _mcInfoContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400196B")]
		[SerializeField]
		private BaseButton _btnContinue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400196C")]
		[SerializeField]
		private GameObject _successVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400196D")]
		[SerializeField]
		private GameObject _starsVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400196E")]
		[SerializeField]
		private float _successScreenshake;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400196F")]
		[SerializeField]
		private float _successFOVModification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001970")]
		private GameObject fish;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001971")]
		private Vector3 _contentInitPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001972")]
		private CancellationTokenSource spawnResultCTS = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x6001F78")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F79")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7A")]
		[Cpp2IlInjected.Address(RVA = "0x165D3A0", Offset = "0x165BDA0", VA = "0x18165D3A0", Slot = "25")]
		public unsafe override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0047
			//IL_0041: Expected native int or pointer, but got O
			base.OnPush(stack, param);
			int num = 0;
			UiRoot.Instance.UpdateCursorBehaviorForUI();
			GameObject gameObject = _contentSlider.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			RectTransform contentSlider = _contentSlider;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)_contentInitPos)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7B")]
		[Cpp2IlInjected.Address(RVA = "0x165CC10", Offset = "0x165B610", VA = "0x18165CC10", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0018, IL_001f, IL_0023, IL_0033, IL_003d, IL_0041, IL_004f, IL_0067, IL_006c, IL_0077, IL_0086, IL_008f, IL_00ae, IL_010a
			base.OnFocusIn();
			_contentSlider.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7C")]
		[Cpp2IlInjected.Address(RVA = "0x165D430", Offset = "0x165BE30", VA = "0x18165D430", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__18))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__18 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__18(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7D")]
		[Cpp2IlInjected.Address(RVA = "0x165D340", Offset = "0x165BD40", VA = "0x18165D340", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0012
			base.OnPop();
			PostProcessManager.Instance.SetDof(DOFDistance.DEFAULT);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7E")]
		[Cpp2IlInjected.Address(RVA = "0x165CAE0", Offset = "0x165B4E0", VA = "0x18165CAE0")]
		private (Transform, RewardBounds) FindRewardTransformAndBounds()
		{
			int num = 0;
			RewardBounds component = Camera.main.GetComponentInChildren<CameraRelativeRewardPosition>().RewardTransform.GetComponent<RewardBounds>();
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F7F")]
		[Cpp2IlInjected.Address(RVA = "0x165D4B0", Offset = "0x165BEB0", VA = "0x18165D4B0")]
		[AsyncStateMachine(typeof(_003CSpawnResult_003Ed__21))]
		private Task SpawnResult(Item resultItem, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F80")]
		[Cpp2IlInjected.Address(RVA = "0x165D650", Offset = "0x165C050", VA = "0x18165D650")]
		public void onKeepClickHandler()
		{
			//IL_0025: Expected O, but got I4
			PopSelf();
			MenuParam menuParam = _menuParam;
			if (menuParam != null)
			{
				Action<int> answerAction = menuParam.AnswerAction;
				if (answerAction != null)
				{
					int num = 0;
					answerAction((T)num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F81")]
		[Cpp2IlInjected.Address(RVA = "0x165D6C0", Offset = "0x165C0C0", VA = "0x18165D6C0")]
		private void onReleaseClickHandler()
		{
			//IL_0023: Expected O, but got I4
			PopSelf();
			((Action<T>)(object)_menuParam?.AnswerAction)?.Invoke((T)1);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F82")]
		[Cpp2IlInjected.Address(RVA = "0x165CB90", Offset = "0x165B590", VA = "0x18165CB90", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//IL_0025: Expected O, but got I4
			PopSelf();
			MenuParam menuParam2 = _menuParam;
			if (menuParam2 != null)
			{
				Action<int> answerAction = menuParam2.AnswerAction;
				if (answerAction != null)
				{
					int num = 0;
					answerAction((T)num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F83")]
		[Cpp2IlInjected.Address(RVA = "0x165D5E0", Offset = "0x165BFE0", VA = "0x18165D5E0")]
		public FishingMenu()
		{
		}
	}
}
