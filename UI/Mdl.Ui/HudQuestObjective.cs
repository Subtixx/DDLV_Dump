using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Meta.Missions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000561")]
	public class HudQuestObjective : CustomElement
	{
		[Cpp2IlInjected.Token(Token = "0x2000562")]
		private enum State
		{
			[Cpp2IlInjected.Token(Token = "0x4001D51")]
			Uncompleted,
			[Cpp2IlInjected.Token(Token = "0x4001D52")]
			PlayingAnim,
			[Cpp2IlInjected.Token(Token = "0x4001D53")]
			Completed
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001D41")]
		private State state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001D42")]
		public bool HasObjective;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001D43")]
		private Coroutine _animationCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001D44")]
		public GameObject CompletedAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001D45")]
		public TextBase Progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001D46")]
		public TextBase Total;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001D47")]
		public Color CompletedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001D48")]
		public float TotalAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4001D49")]
		private int lineCount = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001D4A")]
		private Action _refreshBgLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001D4B")]
		public DescriptionInfo DescriptionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001D4C")]
		[SerializeField]
		private TMP_SpriteAsset _spriteAssetRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001D4D")]
		[SerializeField]
		private GameObject _checkmarkBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001D4E")]
		[SerializeField]
		private Image _checkmark;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001D4F")]
		[SerializeField]
		private AK.Wwise.Event _checkmarkSfx;

		[Cpp2IlInjected.Token(Token = "0x1700056D")]
		public bool IsPlayingAnim
		{
			[Cpp2IlInjected.Token(Token = "0x600231D")]
			[Cpp2IlInjected.Address(RVA = "0x130ABB0", Offset = "0x13095B0", VA = "0x18130ABB0")]
			get
			{
				return state == State.PlayingAnim;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056E")]
		public bool IsShownAsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600231E")]
			[Cpp2IlInjected.Address(RVA = "0x130ABC0", Offset = "0x13095C0", VA = "0x18130ABC0")]
			get
			{
				return state == State.Completed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600231F")]
		[Cpp2IlInjected.Address(RVA = "0x1309A80", Offset = "0x1308480", VA = "0x181309A80")]
		public void SetData(DescriptionInfo descriptionInfo, bool forceNoComplete = false, int _switchFontSize = -1)
		{
			//Discarded unreachable code: IL_0091, IL_009f, IL_00ad, IL_0108, IL_0135, IL_01ee, IL_0203, IL_021a, IL_0226, IL_0232, IL_02fd, IL_0325, IL_03b8, IL_03c1, IL_03e0
			//IL_004e: Invalid comparison between F4 and I4
			//IL_0053: Invalid comparison between F4 and I4
			//IL_0058: Invalid comparison between F4 and I4
			//IL_006c: Expected I4, but got I8
			//IL_0083: Expected F4, but got I4
			//IL_00dc: Expected I4, but got I8
			//IL_012c: Expected I4, but got I8
			//IL_0217: Expected O, but got I4
			//IL_0291: Expected O, but got I4
			//IL_033f: Expected O, but got I4
			//IL_035f: Expected O, but got I4
			//IL_03d3: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if ((descriptionInfo.Completed ? 1 : 0) == num || forceNoComplete)
			{
			}
			this.state = (State)num;
			DescriptionInfo = descriptionInfo;
			State state = this.state;
			if (descriptionInfo.HasProgress)
			{
				float? _003CCurrentAmount_003Ek__BackingField = descriptionInfo.CurrentAmount;
				float? _003CTargetAmount_003Ek__BackingField = descriptionInfo.TargetAmount;
				float num3 = default(float);
				TotalAmount = num3;
				if (state != State.Completed || !(num3 <= (float)num2))
				{
				}
				float num4 = default(float);
				if (!(num4 <= (float)num2))
				{
				}
				int maxDecimals = default(int);
				if (!(num4 <= (float)num2))
				{
					maxDecimals = 0;
				}
				uint maxDigits = default(uint);
				uint childMaxDecimals = default(uint);
				ulong num5 = default(ulong);
				string text = TextUtilities.FormatNumber(num4, (int)maxDigits, maxDecimals, (int)childMaxDecimals, (byte)num5 != 0);
				string text2 = "/" + text;
			}
			TotalAmount = num;
			Dictionary<TextType, string> dictionary = base.Texts;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002320")]
		[Cpp2IlInjected.Address(RVA = "0x1309A00", Offset = "0x1308400", VA = "0x181309A00", Slot = "8")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0034
			UndoShrink();
			base.RefreshDisplay();
			switch (state)
			{
			case State.Uncompleted:
			{
				GameObject completedAsset = CompletedAsset;
				int active = 0;
				completedAsset.SetActive((byte)active != 0);
				break;
			}
			case State.Completed:
				RefreshCompleted();
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002321")]
		[Cpp2IlInjected.Address(RVA = "0x13091D0", Offset = "0x1307BD0", VA = "0x1813091D0")]
		public void OnDisable()
		{
			//IL_0010: Expected I4, but got I8
			Coroutine animationCoroutine = _animationCoroutine;
			state = State.Uncompleted;
			if (animationCoroutine != null)
			{
				StopCoroutine(animationCoroutine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002322")]
		[Cpp2IlInjected.Address(RVA = "0x13091F0", Offset = "0x1307BF0", VA = "0x1813091F0")]
		public void PlayCompleteAnimation()
		{
			//IL_0021: Expected I4, but got I8
			//IL_015e: Expected O, but got I4
			if (base.gameObject.activeInHierarchy)
			{
				GameObject completedAsset = CompletedAsset;
				state = State.PlayingAnim;
				completedAsset.SetActive(value: true);
				_checkmarkBg.GetComponent<CanvasGroup>().alpha = 1f;
				AK.Wwise.Event checkmarkSfx = _checkmarkSfx;
				if (checkmarkSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = checkmarkSfx.Post(gameObject);
				}
				TweenerCore<Vector3, Vector3, VectorOptions> t = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(_checkmarkBg.transform, 3f, 0.15f)).SetEase(Ease.InBounce);
				TweenCallback action = AnimPart2;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.OnComplete(action).Play();
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(_checkmark.transform, 3f, 0.15f)).SetEase(Ease.InBounce).Play();
				TextMeshProUGUI textComponent = CustomButton.View.Label.TextComponent;
				Color completedColor = CompletedColor;
				TweenerCore<Color, Color, ColorOptions> tweenerCore3 = ((TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor((UnityEngine.UI.Graphic)textComponent, completedColor, 0.25f)).Play();
				TextMeshProUGUI textComponent2 = Progress.TextComponent;
				Color completedColor2 = CompletedColor;
				TweenerCore<Color, Color, ColorOptions> tweenerCore4 = ((TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor((UnityEngine.UI.Graphic)textComponent2, completedColor2, 0.25f)).Play();
				TextMeshProUGUI textComponent3 = Total.TextComponent;
				Color completedColor3 = CompletedColor;
				TweenerCore<Color, Color, ColorOptions> tweenerCore5 = ((TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor((UnityEngine.UI.Graphic)textComponent3, completedColor3, 0.25f)).Play();
				CanvasGroup component = GetComponent<CanvasGroup>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					GetComponent<CanvasGroup>().alpha = 0.5f;
				}
				GameObject gameObject2 = CustomButton.View.DynamicIcon.gameObject;
				int active = 0;
				gameObject2.SetActive((byte)active != 0);
				TextBase progress = Progress;
				if ((object)gameObject2 != null)
				{
					float totalAmount = TotalAmount;
					TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
					string text = default(string);
					textMeshProUGUI.text = text;
					throw new NullReferenceException();
				}
				progress.TextComponent.text = "";
				Total.TextComponent.text = "";
			}
			[Cpp2IlInjected.Token(Token = "0x600232A")]
			[Cpp2IlInjected.Address(RVA = "0x130A570", Offset = "0x1308F70", VA = "0x18130A570")]
			void AnimPart2()
			{
				//Discarded unreachable code: IL_0066
				TweenerCore<Vector3, Vector3, VectorOptions> t4 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(_checkmarkBg.transform, 1f, 0.15f)).SetEase(Ease.OutBounce);
				TweenCallback action3 = SwitchCheckmarkToGrey;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore10 = t4.OnComplete(action3).Play();
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore11 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(_checkmark.transform, 1f, 0.15f)).SetEase(Ease.OutBounce).Play();
			}
			[Cpp2IlInjected.Token(Token = "0x600232C")]
			[Cpp2IlInjected.Address(RVA = "0x130A6D0", Offset = "0x13090D0", VA = "0x18130A6D0")]
			void OnAnimDone()
			{
				//IL_0009: Expected I4, but got I8
				state = State.Completed;
				RefreshCompleted();
			}
			[Cpp2IlInjected.Token(Token = "0x600232B")]
			[Cpp2IlInjected.Address(RVA = "0x130A6E0", Offset = "0x13090E0", VA = "0x18130A6E0")]
			void SwitchCheckmarkToGrey()
			{
				//Discarded unreachable code: IL_00b1
				//IL_001a: Expected F4, but got I4
				//IL_0059: Expected F4, but got I4
				Transform transform = _checkmarkBg.transform;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> t2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale(transform, (float)num3, 0.15f)).SetDelay(1f);
				TweenCallback action2 = OnAnimDone;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore6 = t2.OnComplete(action2);
				CanvasGroup component2 = _checkmarkBg.GetComponent<CanvasGroup>();
				int num4 = 0;
				TweenerCore<float, float, FloatOptions> tweenerCore7 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(component2, (float)num4, 0.15f)).SetDelay(1f);
				Image checkmark = _checkmark;
				int num5 = 0;
				UIGameColors gameColors = UiRoot.Instance._gameColors;
				TweenerCore<Color, Color, ColorOptions> t3 = default(TweenerCore<Color, Color, ColorOptions>);
				TweenerCore<Color, Color, ColorOptions> tweenerCore8 = t3.SetDelay(1f);
				TweenerCore<float, float, FloatOptions> tweenerCore9 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_checkmark.GetComponent<CanvasGroup>(), 0.5f, 0.15f)).SetDelay(1f);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002323")]
		[Cpp2IlInjected.Address(RVA = "0x13098D0", Offset = "0x13082D0", VA = "0x1813098D0")]
		private void RefreshCompleted()
		{
			//Discarded unreachable code: IL_004f
			CompletedAsset.SetActive(value: true);
			Image checkmark = _checkmark;
			int num = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
			_checkmark.GetComponent<CanvasGroup>().alpha = 0.5f;
			Transform transform = _checkmarkBg.transform;
			float z = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002324")]
		[Cpp2IlInjected.Address(RVA = "0x1309700", Offset = "0x1308100", VA = "0x181309700")]
		public void PlayShrinkAnim(Action refreshBgLayout)
		{
			//Discarded unreachable code: IL_0071
			//IL_002f: Expected O, but got I4
			_refreshBgLayout = refreshBgLayout;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			int num = 0;
			int num2 = 0;
			if ((object)transform != null)
			{
			}
			int num3 = 0;
			Vector2 vector = default(Vector2);
			TweenerCore<Vector2, Vector2, VectorOptions> t = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOSizeDelta((RectTransform)num, vector, 0.3f, (byte)num3 != 0);
			TweenCallback tweenCallback = UpdateLayout;
			TweenerCore<Vector2, Vector2, VectorOptions> t2 = t.OnUpdate(tweenCallback).SetEase(Ease.OutCirc);
			TweenCallback action = OnShrinked;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t2.OnComplete(action).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6002325")]
		[Cpp2IlInjected.Address(RVA = "0x130AA50", Offset = "0x1309450", VA = "0x18130AA50")]
		public void UpdateLayout()
		{
			//Discarded unreachable code: IL_0051
			base.transform.parent.RebuildLayout();
			base.transform.parent.parent.RebuildLayout();
			base.transform.parent.parent.parent.RebuildLayout();
			_refreshBgLayout?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002326")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnShrinked()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002327")]
		[Cpp2IlInjected.Address(RVA = "0x130A900", Offset = "0x1309300", VA = "0x18130A900")]
		public void UndoShrink()
		{
			//Discarded unreachable code: IL_003f
			//IL_0016: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			int complete = 0;
			int num2 = DOTween.Kill(num, (byte)complete != 0);
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			int num3 = lineCount;
			if ((object)transform2 != null)
			{
			}
			if (num3 > 0 && (object)transform2 == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002328")]
		[Cpp2IlInjected.Address(RVA = "0x1309050", Offset = "0x1307A50", VA = "0x181309050")]
		public void KillAnim()
		{
			//Discarded unreachable code: IL_00a6
			//IL_0016: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			int complete = 0;
			int num2 = DOTween.Kill(num, (byte)complete != 0);
			UndoShrink();
			Transform targetOrId = CompletedAsset.transform;
			int complete2 = 0;
			int num3 = DOTween.Kill(targetOrId, (byte)complete2 != 0);
			TextBase progress = Progress;
			int complete3 = 0;
			int num4 = DOTween.Kill(progress, (byte)complete3 != 0);
			TextBase total = Total;
			int complete4 = 0;
			int num5 = DOTween.Kill(total, (byte)complete4 != 0);
			ButtonViewDefault view = CustomButton.View;
			int num6 = 0;
			if (view != (UnityEngine.Object)num6)
			{
				TextMeshProUGUI textComponent = CustomButton.View.Label.TextComponent;
				int complete5 = 0;
				int num7 = DOTween.Kill(textComponent, (byte)complete5 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002329")]
		[Cpp2IlInjected.Address(RVA = "0x130AB90", Offset = "0x1309590", VA = "0x18130AB90")]
		public HudQuestObjective()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
