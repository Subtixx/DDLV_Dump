using System;
using Cpp2IlInjected;
using DG.Tweening;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200036C")]
	[ExecuteInEditMode]
	[RequiredAllNotNull]
	public class CategoryListLayout : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001097")]
		private Vector3 _base;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001098")]
		[SerializeField]
		private ScrollRect _scrollRectView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001099")]
		[SerializeField]
		private RectTransform _circleCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400109A")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400109B")]
		[SerializeField]
		private Button _btnNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400109C")]
		[SerializeField]
		private Button _btnPrevious;

		[Cpp2IlInjected.Token(Token = "0x170003CB")]
		public RectTransform Content
		{
			[Cpp2IlInjected.Token(Token = "0x60015E3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _content;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015E4")]
		[Cpp2IlInjected.Address(RVA = "0xFF72A0", Offset = "0xFF5CA0", VA = "0x180FF72A0")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_00dd
			//IL_001c: Expected native int or pointer, but got O
			RectTransform circleCenter = _circleCenter;
			ScrollRect scrollRectView = _scrollRectView;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)_base)->z = z;
			ScrollRect.ScrollRectEvent onValueChanged = scrollRectView.m_OnValueChanged;
			UnityAction<Vector2> unityAction = (UnityAction<Vector2>)(object)new UnityAction<T0>(OnScrollHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = _btnNext.m_OnClick;
			UnityAction call = OnNextClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnPrevious.m_OnClick;
			UnityAction call2 = OnPrevoiusClickHandler;
			onClick2.AddListener(call2);
			GameObject gameObject = _btnNext.gameObject;
			ScrollRect scrollRectView2 = _scrollRectView;
			int active = 0;
			float verticalNormalizedPosition = scrollRectView2.verticalNormalizedPosition;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _btnPrevious.gameObject;
			ScrollRect scrollRectView3 = _scrollRectView;
			int active2 = 0;
			float verticalNormalizedPosition2 = scrollRectView3.verticalNormalizedPosition;
			gameObject2.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60015E5")]
		[Cpp2IlInjected.Address(RVA = "0xFF6FB0", Offset = "0xFF59B0", VA = "0x180FF6FB0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0065
			ScrollRect.ScrollRectEvent onValueChanged = _scrollRectView.m_OnValueChanged;
			UnityAction<Vector2> unityAction = (UnityAction<Vector2>)(object)new UnityAction<T0>(OnScrollHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = _btnNext.m_OnClick;
			UnityAction call = OnNextClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnPrevious.m_OnClick;
			UnityAction call2 = OnPrevoiusClickHandler;
			onClick2.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x60015E6")]
		[Cpp2IlInjected.Address(RVA = "0xFF7190", Offset = "0xFF5B90", VA = "0x180FF7190")]
		private void OnPrevoiusClickHandler()
		{
			int snapping = 0;
			Tweener tweener = _scrollRectView.DOVerticalNormalizedPos(1f, 0.1f, (byte)snapping != 0).SetEase(Ease.OutBack);
		}

		[Cpp2IlInjected.Token(Token = "0x60015E7")]
		[Cpp2IlInjected.Address(RVA = "0xFF7130", Offset = "0xFF5B30", VA = "0x180FF7130")]
		private void OnNextClickHandler()
		{
			//IL_0018: Expected F4, but got I4
			int snapping = 0;
			ScrollRect scrollRectView = _scrollRectView;
			int num = 0;
			Tweener tweener = scrollRectView.DOVerticalNormalizedPos(num, 0.1f, (byte)snapping != 0).SetEase(Ease.OutBack);
		}

		[Cpp2IlInjected.Token(Token = "0x60015E8")]
		[Cpp2IlInjected.Address(RVA = "0xFF7200", Offset = "0xFF5C00", VA = "0x180FF7200")]
		private void OnScrollHandler(Vector2 arg0)
		{
			//Discarded unreachable code: IL_004e
			GameObject gameObject = _btnNext.gameObject;
			ScrollRect scrollRectView = _scrollRectView;
			int active = 0;
			float verticalNormalizedPosition = scrollRectView.verticalNormalizedPosition;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _btnPrevious.gameObject;
			ScrollRect scrollRectView2 = _scrollRectView;
			int active2 = 0;
			float verticalNormalizedPosition2 = scrollRectView2.verticalNormalizedPosition;
			gameObject2.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60015E9")]
		[Cpp2IlInjected.Address(RVA = "0xFF6F00", Offset = "0xFF5900", VA = "0x180FF6F00")]
		public void ForceAlign()
		{
			//Discarded unreachable code: IL_0059
			int num = 0;
			Vector2 zero = Vector2.zero;
			GameObject gameObject = _btnNext.gameObject;
			ScrollRect scrollRectView = _scrollRectView;
			int active = 0;
			float verticalNormalizedPosition = scrollRectView.verticalNormalizedPosition;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _btnPrevious.gameObject;
			ScrollRect scrollRectView2 = _scrollRectView;
			int active2 = 0;
			float verticalNormalizedPosition2 = scrollRectView2.verticalNormalizedPosition;
			gameObject2.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60015EA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CategoryListLayout()
		{
		}
	}
}
