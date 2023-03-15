using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using glPlayFab;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001D8")]
	public class LoadingProgressBar : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		[SerializeField]
		private float _expectedLoadingTime = 30f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		[SerializeField]
		private float _startFadeTime = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		[SerializeField]
		private float _endFadeTime = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		private Slider _slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private float _elapsedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		private bool _animatingToEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		private Sequence _sequence;

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x132ED40", Offset = "0x132D740", VA = "0x18132ED40")]
		private void Awake()
		{
			Slider slider = (_slider = GetComponent<Slider>());
			CanvasGroup canvasGroup = (_canvasGroup = GetComponent<CanvasGroup>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x132EDC0", Offset = "0x132D7C0", VA = "0x18132EDC0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00aa
			//IL_0022: Expected F4, but got I4
			//IL_008f: Expected O, but got I4
			CanvasGroup canvasGroup = _canvasGroup;
			_elapsedTime = 0f;
			_animatingToEnd = false;
			int num = 0;
			canvasGroup.alpha = num;
			Sequence sequence = _sequence;
			if (sequence != null)
			{
				int complete = 0;
				sequence.Kill((byte)complete != 0);
			}
			int num2 = 0;
			Sequence sequence2 = (_sequence = DOTween.Sequence());
			float startFadeTime = _startFadeTime;
			CanvasGroup canvasGroup2 = _canvasGroup;
			Sequence sequence3 = _sequence;
			TweenerCore<float, float, FloatOptions> t = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(canvasGroup2, 1f, startFadeTime);
			Sequence sequence4 = sequence3.Append(t);
			Startup componentInParent = GetComponentInParent<Startup>();
			int num3 = 0;
			if (componentInParent != (UnityEngine.Object)num3)
			{
				Func<Task> func = (componentInParent.BeforeCompletion = (Func<Task>)(object)new Func<TResult>(AnimateToEndTask));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x132F0C0", Offset = "0x132DAC0", VA = "0x18132F0C0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0028
			if (!_animatingToEnd)
			{
				int num = 0;
				float deltaTime = UnityEngine.Time.deltaTime;
				Slider slider = _slider;
				_elapsedTime = deltaTime;
				string contentType = ((IOpenIdAPI)slider).ContentType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x132EC40", Offset = "0x132D640", VA = "0x18132EC40")]
		[AsyncStateMachine(typeof(_003CAnimateToEndTask_003Ed__11))]
		public Task AnimateToEndTask()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x132F140", Offset = "0x132DB40", VA = "0x18132F140")]
		public LoadingProgressBar()
		{
		}
	}
}
