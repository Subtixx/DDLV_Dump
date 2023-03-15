using System;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004B2")]
	public class FTUENamePanel : MonoBehaviour, IStartFTUEPanel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018AA")]
		public RectTransform AnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018AB")]
		public BaseButton NextButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40018AC")]
		public BaseButton BackButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40018AD")]
		[SerializeField]
		private InputPlayerName _inputPlayerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40018AE")]
		[SerializeField]
		private GameObject _inputPlayerNameGameObjet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40018AF")]
		[SerializeField]
		private TextBase _tfError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40018B0")]
		[NotNull]
		[SerializeField]
		private GameObject _mcBackKey;

		[Cpp2IlInjected.Token(Token = "0x170004F4")]
		public string InputName
		{
			[Cpp2IlInjected.Token(Token = "0x6001E8E")]
			[Cpp2IlInjected.Address(RVA = "0x15230E0", Offset = "0x1521AE0", VA = "0x1815230E0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _inputPlayerName.InputName;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E8F")]
			[Cpp2IlInjected.Address(RVA = "0x1523100", Offset = "0x1521B00", VA = "0x181523100")]
			set
			{
				//Discarded unreachable code: IL_000d
				_inputPlayerName.InputName = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x40018B1")]
		public bool IsInAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x6001E90")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E91")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E92")]
		[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "6")]
		public Transform GetContent()
		{
			RectTransform animatedContent = AnimatedContent;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E93")]
		[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "7")]
		public BaseButton GetBackButton()
		{
			return BackButton;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E94")]
		[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "8")]
		public BaseButton GetNextButton()
		{
			return NextButton;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E95")]
		[Cpp2IlInjected.Address(RVA = "0xE4BF10", Offset = "0xE4A910", VA = "0x180E4BF10")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0016
			GameObject gameObject = AnimatedContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E96")]
		[Cpp2IlInjected.Address(RVA = "0x1523000", Offset = "0x1521A00", VA = "0x181523000")]
		private void Start()
		{
			//Discarded unreachable code: IL_001c
			InputPlayerName inputPlayerName = _inputPlayerName;
			InputPlayerName.NameChanged value = OnNameChanged;
			inputPlayerName.OnNameChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E97")]
		[Cpp2IlInjected.Address(RVA = "0x1522B50", Offset = "0x1521550", VA = "0x181522B50")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_001c
			InputPlayerName inputPlayerName = _inputPlayerName;
			InputPlayerName.NameChanged value = OnNameChanged;
			inputPlayerName.OnNameChanged -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E98")]
		[Cpp2IlInjected.Address(RVA = "0x1522CF0", Offset = "0x15216F0", VA = "0x181522CF0", Slot = "10")]
		public void Show()
		{
			//Discarded unreachable code: IL_00e8
			_inputPlayerName.EnableInput(enable: true);
			RectTransform animatedContent = AnimatedContent;
			IsInAnimation = true;
			float z = Vector3.zero.z;
			AnimatedContent.gameObject.SetActive(value: true);
			_mcBackKey.SetActive(value: true);
			Transform transform = AnimatedContent.transform;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack).SetDelay(0.3f);
			TweenCallback tweenCallback = delegate
			{
				IsInAnimation = false;
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					FocusNavigationElement component = _inputPlayerNameGameObjet.GetComponent<FocusNavigationElement>();
					int num2 = 0;
					MenuStack menuStack = UiRoot.Instance._menuStack;
					int num3 = 0;
					IMenu top = menuStack.Top;
					int num4 = 0;
					int num5 = 0;
					MenuNavigation menuNavigation = default(MenuNavigation);
					menuNavigation.FocusNavigation.SetFocus(component);
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E99")]
		[Cpp2IlInjected.Address(RVA = "0x15229A0", Offset = "0x15213A0", VA = "0x1815229A0")]
		public void EnableInput(bool enable)
		{
			//Discarded unreachable code: IL_000d
			_inputPlayerName.EnableInput(enable);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9A")]
		[Cpp2IlInjected.Address(RVA = "0x15229C0", Offset = "0x15213C0", VA = "0x1815229C0", Slot = "11")]
		public void Hide()
		{
			//IL_0011: Expected O, but got I4
			int num = 0;
			EventSystem current = EventSystem.current;
			int num2 = 0;
			current.SetSelectedGameObject((GameObject)num2);
			GameObject mcBackKey = _mcBackKey;
			IsInAnimation = true;
			int active = 0;
			mcBackKey.SetActive((byte)active != 0);
			RectTransform animatedContent = AnimatedContent;
			float z = Vector3.zero.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.InExpo);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_001d
				GameObject gameObject = AnimatedContent.gameObject;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
				IsInAnimation = false;
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9B")]
		[Cpp2IlInjected.Address(RVA = "0x1522BE0", Offset = "0x15215E0", VA = "0x181522BE0")]
		private void OnNameChanged(string newName, bool isValid)
		{
			//Discarded unreachable code: IL_002f
			NextButton.IsActive = isValid;
			NextButton.GetComponent<FocusNavigationElement>().IgnoreThis = isValid;
			_tfError.gameObject.SetActive(isValid);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9C")]
		[Cpp2IlInjected.Address(RVA = "0x1522C80", Offset = "0x1521680", VA = "0x181522C80", Slot = "9")]
		public void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_0014
			FocusNavigationElement component = _inputPlayerNameGameObjet.GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E9D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FTUENamePanel()
		{
		}
	}
}
