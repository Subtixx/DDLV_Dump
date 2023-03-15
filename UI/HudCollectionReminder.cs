using System;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.Navigation;
using Mdl.Ui;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HudCollectionReminder : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[SerializeField]
	private TextBase _reminderLabel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[SerializeField]
	private BaseButton _clickButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[SerializeField]
	private RectTransform _referenceRectTransform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private string _reminderStringID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool _isShowing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public CollectionSubMenu CollectionReminderSelectedTab = CollectionSubMenu.Memories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Vector3[] cornersArray = new Vector3[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private float previousY;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool IsShowing
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
		get
		{
			return _isShowing;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string ReminderStringID
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
		get
		{
			return _reminderStringID;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
		set
		{
			_reminderStringID = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xAF3450", Offset = "0xAF1E50", VA = "0x180AF3450")]
	public void OnEnable()
	{
		//Discarded unreachable code: IL_0026
		Button.ButtonClickedEvent onClick = _clickButton.ButtonComponent.m_OnClick;
		UnityAction call = OnClickButton;
		onClick.AddListener(call);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0xAF33A0", Offset = "0xAF1DA0", VA = "0x180AF33A0")]
	public void OnDisable()
	{
		//Discarded unreachable code: IL_0026
		Button.ButtonClickedEvent onClick = _clickButton.ButtonComponent.m_OnClick;
		UnityAction call = OnClickButton;
		onClick.RemoveListener(call);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0xAF31A0", Offset = "0xAF1BA0", VA = "0x180AF31A0")]
	private void OnClickButton()
	{
		//Discarded unreachable code: IL_0087
		//IL_007b: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		int num = 0;
		UiRoot instance = UiRoot.Instance;
		int useKeyboardAsController = 0;
		if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
		{
			CollectionMenu.CollectionMenuParam collectionMenuParam = new CollectionMenu.CollectionMenuParam();
			CollectionSubMenu collectionSubMenu = (collectionMenuParam.SelectedTab = CollectionReminderSelectedTab);
			int num2 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num3 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num4 = 0;
			IMenu bottom = menuStack.Bottom;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			CancellationToken ct = default(CancellationToken);
			redirection.RedirectTask(ct, RedirectionType.MenuCollection, collectionMenuParam, (PlayerTaskCollider)num6, (ItemFilterData)num6, (string)num6, (Action)num6, (byte)num6 != 0, (byte)num6 != 0, (byte)num6 != 0).FireAndForgetTask();
			Hide();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xAF3500", Offset = "0xAF1F00", VA = "0x180AF3500")]
	public void Show()
	{
		//Discarded unreachable code: IL_00b7
		//IL_0068: Expected O, but got I4
		//IL_009d: Expected F4, but got I4
		bool flag = string.IsNullOrEmpty(_reminderStringID);
		if (!flag)
		{
			if (_isShowing != flag)
			{
				Hide();
			}
			TextBase reminderLabel = _reminderLabel;
			_isShowing = true;
			string text = (reminderLabel.StringID = _reminderStringID);
			RectTransform component = GetComponent<RectTransform>();
			Vector2 anchoredPosition = component.anchoredPosition;
			CanvasGroup component2 = GetComponent<CanvasGroup>();
			int num = 0;
			Vector2 anchoredPosition2 = component.anchoredPosition;
			component.anchoredPosition = (Vector2)num;
			TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(component2, 1f, 0.25f)).SetEase(Ease.OutCirc).Play();
			int num2 = 0;
			int num3 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = ((TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosX(component, (float)num3, 0.25f, (byte)num2 != 0)).SetDelay(0.15f).SetEase(Ease.OutCirc).Play();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0xAF2EA0", Offset = "0xAF18A0", VA = "0x180AF2EA0")]
	public void Hide()
	{
		//Discarded unreachable code: IL_007a
		//IL_0010: Expected I4, but got I8
		//IL_003f: Expected O, but got I4
		//IL_004f: Expected F4, but got I4
		//IL_004f: Expected F4, but got I4
		//IL_006a: Expected F4, but got I4
		_isShowing = false;
		CollectionReminderSelectedTab = CollectionSubMenu.Memories;
		RectTransform component = GetComponent<RectTransform>();
		Vector2 anchoredPosition = component.anchoredPosition;
		Vector2 sizeDelta = component.sizeDelta;
		CanvasGroup component2 = GetComponent<CanvasGroup>();
		int num = 0;
		Vector2 anchoredPosition2 = component.anchoredPosition;
		component.anchoredPosition = (Vector2)num;
		int num2 = 0;
		int num3 = 0;
		TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(component2, (float)num3, (float)num2)).SetEase(Ease.OutCirc).Play();
		int num4 = 0;
		TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = t.SetDelay(num4).SetEase(Ease.OutCirc).Play();
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0xAF3040", Offset = "0xAF1A40", VA = "0x180AF3040")]
	public void LateUpdate()
	{
		//Discarded unreachable code: IL_0074
		//IL_0073: Expected F4, but got O
		if (_isShowing)
		{
			RectTransform referenceRectTransform = _referenceRectTransform;
			Vector3[] fourCornersArray = cornersArray;
			referenceRectTransform.GetLocalCorners(fourCornersArray);
			Vector3[] array = cornersArray;
			Vector3 vector = array[0];
			if (array.Length != 0)
			{
				_referenceRectTransform.GetWorldCorners(array);
				Vector3[] array2 = cornersArray;
				Transform transform = base.transform;
				Transform transform2 = base.transform;
				Vector3 vector2 = default(Vector3);
				float z = vector2.z;
				Vector3 vector3 = default(Vector3);
				float z2 = vector3.z;
				previousY = (float)vector;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0xAF36D0", Offset = "0xAF20D0", VA = "0x180AF36D0")]
	public HudCollectionReminder()
	{
	}//IL_0009: Expected I4, but got I8

}
