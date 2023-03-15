using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Google.Protobuf.WellKnownTypes;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200079D")]
	public class CharacterFriendshipBar : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002C86")]
		[SerializeField]
		private TextBase _levelLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002C87")]
		[SerializeField]
		private TextBase _maxLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002C88")]
		[SerializeField]
		private RectTransform _xpProgressBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002C89")]
		[SerializeField]
		private float _filledWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4002C8A")]
		[SerializeField]
		private int _minWidth = 90;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002C8B")]
		[SerializeField]
		private RectTransform _friendshipBarHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002C8C")]
		[SerializeField]
		private CanvasGroup _friendshipBarGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002C8D")]
		[SerializeField]
		private RectTransform _rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002C8E")]
		[SerializeField]
		private TextBase _cheatLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002C8F")]
		[SerializeField]
		[Header("Animation Settings")]
		[Range(0f, 1f)]
		public float[] Thresholds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002C90")]
		[SerializeField]
		private float _animatePositionValue = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4002C91")]
		[SerializeField]
		private float _animateInDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002C92")]
		[SerializeField]
		private float _animateOutDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4002C93")]
		[SerializeField]
		private float _progressBarDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002C94")]
		[SerializeField]
		private float _onScreenDuration = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4002C95")]
		[SerializeField]
		[Header("Scale Settings")]
		private float _maxDistance = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002C96")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _minScale = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4002C97")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _maxScale = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002C98")]
		[SerializeField]
		private float _minScaleDistance = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4002C99")]
		[SerializeField]
		private float _maxScaleDistance = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002C9A")]
		public Action OnAnimationDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002C9B")]
		private CharacterQuestMarker _questMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002C9C")]
		private Character _character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002C9D")]
		private int _fromFriendship;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4002C9E")]
		private int _toFriendship;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002C9F")]
		private int _maxFriendshipLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4002CA0")]
		private bool _animateFriendship;

		[Cpp2IlInjected.Token(Token = "0x170006D5")]
		public bool IsAnimatingFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x60030B0")]
			[Cpp2IlInjected.Address(RVA = "0xFF8910", Offset = "0xFF7310", VA = "0x180FF8910")]
			get
			{
				return _animateFriendship;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030B1")]
		[Cpp2IlInjected.Address(RVA = "0xFF7680", Offset = "0xFF6080", VA = "0x180FF7680", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_01be
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected I4, but got Unknown
			//IL_0104: Expected F4, but got I4
			//IL_0121: Expected O, but got I4
			//IL_0160: Expected F4, but got I4
			//IL_018c: Expected O, but got I4
			if ((object)target != null)
			{
				int num = 0;
				if ((object)target != null)
				{
					int num2 = 0;
					CharacterQuestMarker[] componentsInChildren = UiRoot.Instance._worldCanvas.transform.GetComponentsInChildren<CharacterQuestMarker>();
					Func<CharacterQuestMarker, bool> func = (Func<CharacterQuestMarker, bool>)(object)(Func<T, TResult>)delegate(CharacterQuestMarker x)
					{
						//Discarded unreachable code: IL_002f
						//IL_0010: Expected O, but got I4
						GameObject targetObject = ((InfoGizmo)x)._targetObject;
						int num12 = 0;
						bool flag = targetObject != (UnityEngine.Object)num12;
						if (!flag)
						{
							return flag;
						}
						GameObject targetObject2 = ((InfoGizmo)x)._targetObject;
						GameObject targetObject3 = _targetObject;
						return targetObject2 == targetObject3;
					};
					CharacterQuestMarker characterQuestMarker = (_questMarker = Enumerable.FirstOrDefault<CharacterQuestMarker>(Enumerable.Where<CharacterQuestMarker>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func)));
					CharacterQuestMarker questMarker = _questMarker;
					if ((object)questMarker != null)
					{
						GameObject gameObject = questMarker.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
					}
					Character character = default(Character);
					_character = character;
					if (character != null)
					{
						int num3 = 0;
						if (character != null)
						{
							_fromFriendship = num3;
							Timestamp lastGiftDate_ = character.lastGiftDate_;
							num3 = (_toFriendship = (int)(num3 + lastGiftDate_));
							int num4 = 0;
							_animateFriendship = true;
							UiRoot.Instance.StartFriendshipAddedAnimationBlocker();
						}
					}
					Character character2 = _character;
					_fromFriendship = (_toFriendship = character2.friendship_);
					_animateFriendship = false;
					int num5 = (_maxFriendshipLevel = character2.MaxLevel);
				}
			}
			CanvasGroup friendshipBarGroup = _friendshipBarGroup;
			int num6 = 0;
			friendshipBarGroup.alpha = num6;
			RectTransform friendshipBarHolder = _friendshipBarHolder;
			int num7 = 0;
			Vector2 anchoredPosition = friendshipBarHolder.anchoredPosition;
			friendshipBarHolder.anchoredPosition = (Vector2)num7;
			float animateInDuration = _animateInDuration;
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_friendshipBarGroup, 1f, animateInDuration);
			float animateInDuration2 = _animateInDuration;
			int num8 = 0;
			RectTransform friendshipBarHolder2 = _friendshipBarHolder;
			int num9 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(friendshipBarHolder2, (float)num9, animateInDuration2, (byte)num8 != 0);
			TweenCallback tweenCallback = OnAnimateInComplete;
			int toFriendship = _toFriendship;
			TextBase cheatLabel = _cheatLabel;
			string text2 = (cheatLabel.Text = $"Friendship amount: {toFriendship}");
			GameObject gameObject2 = _cheatLabel.gameObject;
			int num10 = 0;
			UiRoot instance = UiRoot.Instance;
			uint num11 = num11 + 20;
			num11 += num11;
		}

		[Cpp2IlInjected.Token(Token = "0x60030B2")]
		[Cpp2IlInjected.Address(RVA = "0xFF8200", Offset = "0xFF6C00", VA = "0x180FF8200")]
		public void RefreshQuestMarker()
		{
			//Discarded unreachable code: IL_005c
			int num = 0;
			CharacterQuestMarker[] componentsInChildren = UiRoot.Instance._worldCanvas.transform.GetComponentsInChildren<CharacterQuestMarker>();
			Func<CharacterQuestMarker, bool> func = (Func<CharacterQuestMarker, bool>)(object)(Func<T, TResult>)delegate(CharacterQuestMarker x)
			{
				//Discarded unreachable code: IL_002f
				//IL_0010: Expected O, but got I4
				GameObject targetObject = ((InfoGizmo)x)._targetObject;
				int num2 = 0;
				bool flag = targetObject != (UnityEngine.Object)num2;
				if (!flag)
				{
					return flag;
				}
				GameObject targetObject2 = ((InfoGizmo)x)._targetObject;
				GameObject targetObject3 = _targetObject;
				return targetObject2 == targetObject3;
			};
			CharacterQuestMarker characterQuestMarker = (_questMarker = Enumerable.FirstOrDefault<CharacterQuestMarker>(Enumerable.Where<CharacterQuestMarker>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func)));
			CharacterQuestMarker questMarker = _questMarker;
			if ((object)questMarker != null)
			{
				GameObject gameObject = questMarker.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030B3")]
		[Cpp2IlInjected.Address(RVA = "0xFF74D0", Offset = "0xFF5ED0", VA = "0x180FF74D0")]
		private void AnimateIn()
		{
			//IL_0038: Expected F4, but got I4
			float animateInDuration = _animateInDuration;
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_friendshipBarGroup, 1f, animateInDuration);
			float animateInDuration2 = _animateInDuration;
			int num = 0;
			RectTransform friendshipBarHolder = _friendshipBarHolder;
			int num2 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(friendshipBarHolder, (float)num2, animateInDuration2, (byte)num != 0);
			TweenCallback tweenCallback = OnAnimateInComplete;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030B4")]
		[Cpp2IlInjected.Address(RVA = "0xFF7D80", Offset = "0xFF6780", VA = "0x180FF7D80")]
		private void OnAnimateInComplete()
		{
			if (_animateFriendship)
			{
				DOSetter<float> dOSetter = (DOSetter<float>)(object)new DOSetter<T>(RefreshFriendshipValue);
				Action action = AnimateOut;
				float onScreenDuration = _onScreenDuration;
				Coroutine coroutine = Coroutines.Delay(action, onScreenDuration);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030B5")]
		[Cpp2IlInjected.Address(RVA = "0xFF7F90", Offset = "0xFF6990", VA = "0x180FF7F90")]
		private void RefreshFriendshipValue(float friendship)
		{
			//Discarded unreachable code: IL_0093
			//IL_005a: Invalid comparison between I4 and F4
			//IL_0079: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			Character character = _character;
			int xp = Mathf.FloorToInt(friendship);
			int levelForXp = character.GetLevelForXp(xp);
			string text = default(string);
			_levelLabel.Text = text;
			int maxFriendshipLevel = _maxFriendshipLevel;
			Character character2 = _character;
			Profile profile = SystemRoot.Instance.Client.Profile;
			int friendship2 = Mathf.FloorToInt(friendship);
			float xpProgression = character2.GetXpProgression(profile, friendship2);
			if (!(0f >= friendship))
			{
			}
			RectTransform xpProgressBar = _xpProgressBar;
			int num = 0;
			Vector2 sizeDelta = xpProgressBar.sizeDelta;
			xpProgressBar.sizeDelta = (Vector2)num;
			GameObject gameObject = _maxLabel.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60030B6")]
		[Cpp2IlInjected.Address(RVA = "0xFF75A0", Offset = "0xFF5FA0", VA = "0x180FF75A0")]
		public void AnimateOut()
		{
			//IL_0018: Expected F4, but got I4
			float animateOutDuration = _animateOutDuration;
			CanvasGroup friendshipBarGroup = _friendshipBarGroup;
			int num = 0;
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(friendshipBarGroup, (float)num, animateOutDuration);
			float animatePositionValue = _animatePositionValue;
			int num2 = 0;
			float animateOutDuration2 = _animateOutDuration;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(_friendshipBarHolder, animatePositionValue, animateOutDuration2, (byte)num2 != 0);
			TweenCallback tweenCallback = OnAnimateOutComplete;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030B7")]
		[Cpp2IlInjected.Address(RVA = "0xFF7ED0", Offset = "0xFF68D0", VA = "0x180FF7ED0")]
		private void OnAnimateOutComplete()
		{
			//Discarded unreachable code: IL_0047
			CharacterQuestMarker questMarker = _questMarker;
			_animateFriendship = false;
			questMarker?.gameObject.SetActive(value: true);
			OnAnimationDone?.Invoke();
			int num = 0;
			UiRoot.Instance.StopFriendshipAddedAnimationBlocker();
			UnityEngine.Object.Destroy(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60030B8")]
		[Cpp2IlInjected.Address(RVA = "0xFF8420", Offset = "0xFF6E20", VA = "0x180FF8420")]
		private void UpdateScale()
		{
			//Discarded unreachable code: IL_007e
			//IL_0027: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = 0;
			if ((object)SystemRoot.Instance != null)
			{
			}
			int num2 = 0;
			int num3 = 0;
			if ((UnityEngine.Object)num2 != (UnityEngine.Object)num3)
			{
				int num4 = 0;
				GameObject targetObject = _targetObject;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				Transform transform2 = targetObject.transform;
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				float maxScaleDistance = _maxScaleDistance;
				float minScale = _minScale;
				float num5 = default(float);
				maxScaleDistance = num5;
				float num6 = Mathf.Lerp(_maxScale, minScale, maxScaleDistance);
				RectTransform friendshipBarHolder = _friendshipBarHolder;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030B9")]
		[Cpp2IlInjected.Address(RVA = "0xFF7BD0", Offset = "0xFF65D0", VA = "0x180FF7BD0")]
		private void KeepOnScreen()
		{
			//Discarded unreachable code: IL_0038
			int pixelHeight = SystemRoot.Instance._playerCamera.pixelHeight;
			RectTransform rect = _rect;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			RectTransform rect2 = _rect;
			RectTransform rect3 = _rect;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60030BA")]
		[Cpp2IlInjected.Address(RVA = "0xFF86D0", Offset = "0xFF70D0", VA = "0x180FF86D0", Slot = "13")]
		protected override void Update()
		{
			//Discarded unreachable code: IL_0044
			base.Update();
			int pixelHeight = SystemRoot.Instance._playerCamera.pixelHeight;
			RectTransform rect = _rect;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			RectTransform rect2 = _rect;
			RectTransform rect3 = _rect;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			UpdateScale();
		}

		[Cpp2IlInjected.Token(Token = "0x60030BB")]
		[Cpp2IlInjected.Address(RVA = "0xFF8890", Offset = "0xFF7290", VA = "0x180FF8890")]
		public CharacterFriendshipBar()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
