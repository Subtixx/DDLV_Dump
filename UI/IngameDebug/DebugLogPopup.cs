using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class DebugLogPopup : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private RectTransform popupTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private Vector2 halfSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private Image backgroundImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private CanvasGroup canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		private DebugLogManager debugManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[SerializeField]
		private Text newInfoCountText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		[SerializeField]
		private Text newWarningCountText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		[SerializeField]
		private Text newErrorCountText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[SerializeField]
		private Color alertColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		private Color alertColorWarning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		private Color alertColorError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int newInfoCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private int newWarningCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private int newErrorCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private Color normalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private bool isPopupBeingDragged;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private IEnumerator moveToPosCoroutine;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1551230", Offset = "0x154FC30", VA = "0x181551230")]
		private void Awake()
		{
			//IL_0018: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform == null || (object)transform != null)
			{
				popupTransform = (RectTransform)num;
				Image image = (backgroundImage = GetComponent<Image>());
				CanvasGroup canvasGroup = (this.canvasGroup = GetComponent<CanvasGroup>());
				Image image2 = backgroundImage;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x1551D00", Offset = "0x1550700", VA = "0x181551D00")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_0046
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected F4, but got Unknown
			//IL_001f: Expected native int or pointer, but got F4
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected F4, but got Unknown
			//IL_0028: Expected native int or pointer, but got F4
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected F4, but got Unknown
			//IL_0038: Expected O, but got F4
			//IL_0040: Expected native int or pointer, but got O
			float num = (float)(popupTransform.sizeDelta * 0.5f);
			Transform root = popupTransform.root;
			float x = ((Vector3*)(IntPtr)num)->x;
			float num2 = /*Error near IL_0025: Stack underflow*/* x;
			float num3 = default(float);
			float x2 = ((Vector3*)(IntPtr)num3)->x;
			float y = /*Error near IL_002e: Stack underflow*/* x2;
			halfSize = (Vector2)num2;
			((Vector2*)(IntPtr)halfSize)->y = y;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1551990", Offset = "0x1550390", VA = "0x181551990")]
		public unsafe void OnViewportDimensionsChanged()
		{
			//Discarded unreachable code: IL_005f
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected F4, but got Unknown
			//IL_002d: Expected native int or pointer, but got F4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected F4, but got Unknown
			//IL_0036: Expected native int or pointer, but got F4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected F4, but got Unknown
			//IL_0046: Expected O, but got F4
			//IL_0051: Expected native int or pointer, but got O
			//IL_005e: Expected O, but got I4
			if (base.gameObject.activeSelf)
			{
				float num = (float)(popupTransform.sizeDelta * 0.5f);
				Transform root = popupTransform.root;
				float x = ((Vector3*)(IntPtr)num)->x;
				float num2 = /*Error near IL_0033: Stack underflow*/* x;
				float num3 = default(float);
				float x2 = ((Vector3*)(IntPtr)num3)->x;
				float y = /*Error near IL_003c: Stack underflow*/* x2;
				halfSize = (Vector2)num2;
				int num4 = 0;
				((Vector2*)(IntPtr)halfSize)->y = y;
				OnEndDrag((PointerEventData)num4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x15514A0", Offset = "0x154FEA0", VA = "0x1815514A0")]
		public void NewInfoLogArrived()
		{
			//Discarded unreachable code: IL_0034
			string text = default(string);
			newInfoCountText.text = text;
			if (newWarningCount == 0 && newErrorCount == 0)
			{
				Image image = backgroundImage;
				Color color2 = (image.color = alertColorInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1551530", Offset = "0x154FF30", VA = "0x181551530")]
		public void NewWarningLogArrived()
		{
			//Discarded unreachable code: IL_002b
			string text = default(string);
			newWarningCountText.text = text;
			if (newErrorCount == 0)
			{
				Image image = backgroundImage;
				Color color2 = (image.color = alertColorWarning);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1551420", Offset = "0x154FE20", VA = "0x181551420")]
		public void NewErrorLogArrived()
		{
			//Discarded unreachable code: IL_0022
			string text = default(string);
			newErrorCountText.text = text;
			Image image = backgroundImage;
			Color color2 = (image.color = alertColorError);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1551A50", Offset = "0x1550450", VA = "0x181551A50")]
		private void Reset()
		{
			//Discarded unreachable code: IL_0058
			Text text = newInfoCountText;
			newErrorCount = (newInfoCount = 0);
			text.text = "0";
			newWarningCountText.text = "0";
			newErrorCountText.text = "0";
			Image image = backgroundImage;
			Color color2 = (image.color = normalColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1551390", Offset = "0x154FD90", VA = "0x181551390")]
		[IteratorStateMachine(typeof(_003CMoveToPosAnimation_003Ed__24))]
		private unsafe IEnumerator MoveToPosAnimation(Vector3 targetPos)
		{
			//IL_001e: Expected native int or pointer, but got O
			int _003C_003E1__state = default(int);
			_003CMoveToPosAnimation_003Ed__24 _003CMoveToPosAnimation_003Ed__ = new _003CMoveToPosAnimation_003Ed__24(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CMoveToPosAnimation_003Ed__._003C_003E4__this = this;
			float z = targetPos.z;
			((Vector3*)(IntPtr)_003CMoveToPosAnimation_003Ed__.targetPos)->z = z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1551960", Offset = "0x1550360", VA = "0x181551960", Slot = "4")]
		public void OnPointerClick(PointerEventData data)
		{
			//Discarded unreachable code: IL_0016
			if (!isPopupBeingDragged)
			{
				debugManager.ShowLogWindow();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x1551B20", Offset = "0x1550520", VA = "0x181551B20")]
		public void Show()
		{
			//Discarded unreachable code: IL_00b3
			//IL_00b2: Expected O, but got I4
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
			canvasGroup.alpha = 1f;
			Text text = newInfoCountText;
			newErrorCount = (newInfoCount = 0);
			text.text = "0";
			newWarningCountText.text = "0";
			newErrorCountText.text = "0";
			Image image = backgroundImage;
			Color color2 = (image.color = normalColor);
			if (base.gameObject.activeSelf)
			{
				Vector2 sizeDelta = popupTransform.sizeDelta;
				Transform root = popupTransform.root;
				int num = 0;
				OnEndDrag((PointerEventData)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1551330", Offset = "0x154FD30", VA = "0x181551330")]
		public void Hide()
		{
			//Discarded unreachable code: IL_003c
			//IL_0034: Expected F4, but got I4
			CanvasGroup canvasGroup = this.canvasGroup;
			int num = ((canvasGroup.interactable = false) ? 1 : 0);
			CanvasGroup canvasGroup2 = this.canvasGroup;
			int num2 = ((canvasGroup2.blocksRaycasts = false) ? 1 : 0);
			CanvasGroup canvasGroup3 = this.canvasGroup;
			int num3 = 0;
			canvasGroup3.alpha = num3;
			isPopupBeingDragged = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x15515B0", Offset = "0x154FFB0", VA = "0x1815515B0", Slot = "5")]
		public void OnBeginDrag(PointerEventData data)
		{
			isPopupBeingDragged = true;
			if (data == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x112A790", Offset = "0x1129190", VA = "0x18112A790", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
			//Discarded unreachable code: IL_001d
			RectTransform rectTransform = popupTransform;
			Vector2 _003Cposition_003Ek__BackingField = data.position;
			float y = data.position.y;
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x15515F0", Offset = "0x154FFF0", VA = "0x1815515F0", Slot = "7")]
		public unsafe void OnEndDrag(PointerEventData data)
		{
			//Discarded unreachable code: IL_00a7
			//IL_0085: Expected F4, but got O
			//IL_0080: Expected native int or pointer, but got O
			Rect safeArea = Screen.safeArea;
			Rect safeArea2 = Screen.safeArea;
			int num = 0;
			int width = Screen.width;
			int num2 = 0;
			int height = Screen.height;
			int num3 = 0;
			int width2 = Screen.width;
			Rect safeArea3 = Screen.safeArea;
			int num4 = 0;
			int height2 = Screen.height;
			Rect safeArea4 = Screen.safeArea;
			RectTransform rectTransform = popupTransform;
			float num5 = default(float);
			float num6 = default(float);
			if (!(num5 > num6))
			{
			}
			IEnumerator enumerator = moveToPosCoroutine;
			if (enumerator != null)
			{
				StopCoroutine(enumerator);
			}
			int _003C_003E1__state = default(int);
			_003CMoveToPosAnimation_003Ed__24 _003CMoveToPosAnimation_003Ed__ = new _003CMoveToPosAnimation_003Ed__24(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CMoveToPosAnimation_003Ed__._003C_003E4__this = this;
			((Vector3*)(IntPtr)_003CMoveToPosAnimation_003Ed__.targetPos)->z = (float)_003CMoveToPosAnimation_003Ed__;
			moveToPosCoroutine = _003CMoveToPosAnimation_003Ed__;
			IEnumerator routine = moveToPosCoroutine;
			Coroutine coroutine = StartCoroutine(routine);
			isPopupBeingDragged = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugLogPopup()
		{
		}
	}
}
