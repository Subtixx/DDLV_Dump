using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Grid;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007C8")]
	[RequiredAllNotNull]
	public class ManaMeditateInfo : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002DBD")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002DBE")]
		[SerializeField]
		private Image _mcPlusGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002DBF")]
		[SerializeField]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002DC0")]
		[SerializeField]
		[Header("Icon settings")]
		private float _iconHeight = 120f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4002DC1")]
		[SerializeField]
		private float _iconDistanceY = 120f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002DC2")]
		private GridEditMode _gridEditModeSystem;

		[Cpp2IlInjected.Token(Token = "0x17000701")]
		public bool IsMuted
		{
			[Cpp2IlInjected.Token(Token = "0x60031B5")]
			[Cpp2IlInjected.Address(RVA = "0xFAD4B0", Offset = "0xFABEB0", VA = "0x180FAD4B0")]
			get
			{
				//Discarded unreachable code: IL_0077
				//IL_005f: Expected O, but got I4
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				if (!instance.IsCutsceneInPlaying && !instance._throbber.ShouldBlockInput && !instance._fadeEffect.IsInTransition)
				{
					MenuStack menuStack = instance._menuStack;
					int num2 = 0;
					IMenu top = menuStack.Top;
					if (top != null)
					{
						int num3 = 0;
						if (top != null)
						{
							GridEditMode gridEditModeSystem = _gridEditModeSystem;
							int num4 = 0;
							bool flag = gridEditModeSystem != (UnityEngine.Object)num4;
							if (!flag)
							{
								return flag;
							}
							return ((Mdl.Systems.System)_gridEditModeSystem).IsStarted;
						}
					}
				}
				return true;
			}
			[Cpp2IlInjected.Token(Token = "0x60031B6")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031B7")]
		[Cpp2IlInjected.Address(RVA = "0xFAD0C0", Offset = "0xFABAC0", VA = "0x180FAD0C0", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [System.Runtime.InteropServices.Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_0029
			//IL_0010: Expected F4, but got I4
			CanvasGroup canvasGroup = _canvasGroup;
			int num = 0;
			canvasGroup.alpha = num;
			GridEditMode gridEditMode = (_gridEditModeSystem = SystemRoot.Instance.GetSystem<GridEditMode>());
			Animate();
		}

		[Cpp2IlInjected.Token(Token = "0x60031B8")]
		[Cpp2IlInjected.Address(RVA = "0xFACC90", Offset = "0xFAB690", VA = "0x180FACC90")]
		private void Animate()
		{
			//Discarded unreachable code: IL_010c
			//IL_0024: Expected O, but got I4
			//IL_00d3: Expected O, but got I4
			CanvasGroup canvasGroup = _canvasGroup;
			GridEditMode gridEditModeSystem = _gridEditModeSystem;
			int num = 0;
			bool flag = gridEditModeSystem != (UnityEngine.Object)num;
			int num2 = 0;
			if (flag)
			{
				GridEditMode gridEditModeSystem2 = _gridEditModeSystem;
			}
			canvasGroup.alpha = 1f;
			Image mcPlusGameObject = _mcPlusGameObject;
			Transform parent = base.transform;
			Image plus = UnityEngine.Object.Instantiate(mcPlusGameObject, parent);
			GameObject gameObject = plus.gameObject;
			int maxValue = 0;
			gameObject.SetActive(value: true);
			Transform transform = plus.transform;
			int num3 = 0;
			if ((object)transform != null)
			{
			}
			System.Random random = new System.Random();
			int minValue = 0;
			int num4 = random.Next(minValue, maxValue);
			int num5 = 0;
			Image image = plus;
			Color white = Color.white;
			Image image2 = plus;
			int num6 = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = ((TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(image2, (Color)num6, 0.35f)).SetDelay(0.4f).SetEase(Ease.OutCubic);
			TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = t.SetEase(Ease.OutQuint);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_001c
				UnityEngine.Object.Destroy(plus.gameObject);
				Animate();
			};
			Delegate @delegate = default(Delegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031B9")]
		[Cpp2IlInjected.Address(RVA = "0xFAD290", Offset = "0xFABC90", VA = "0x180FAD290", Slot = "17")]
		protected override void UpdatePosition()
		{
			//Discarded unreachable code: IL_00a9
			//IL_0010: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_007a: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			GameObject targetObject = _targetObject;
			int num = 0;
			if (targetObject != (UnityEngine.Object)num)
			{
				int num2 = 0;
				Camera main = Camera.main;
				int num3 = 0;
				if (main != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					Camera main2 = Camera.main;
					Transform transform = _targetObject.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					Transform transform2 = base.transform;
					RectTransform rectTransform = _rectTransform;
					int num5 = 0;
					Vector2 sizeDelta = rectTransform.sizeDelta;
					rectTransform.sizeDelta = (Vector2)num5;
					RectTransform rectTransform2 = _rectTransform;
					Vector2 anchoredPosition = rectTransform2.anchoredPosition;
					RectTransform rectTransform3 = _rectTransform;
					int num6 = 0;
					Vector2 anchoredPosition2 = rectTransform3.anchoredPosition;
					rectTransform2.anchoredPosition = (Vector2)num6;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031BA")]
		[Cpp2IlInjected.Address(RVA = "0xFAD230", Offset = "0xFABC30", VA = "0x180FAD230")]
		private void OnDisable()
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60031BB")]
		[Cpp2IlInjected.Address(RVA = "0xFAD490", Offset = "0xFABE90", VA = "0x180FAD490")]
		public ManaMeditateInfo()
		{
		}
	}
}
