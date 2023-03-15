using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Localization.Formatter;
using Mdl.Ui;
using UnityEngine;
using UnityEngine.Events;

[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HudNewItem : MonoBehaviour, IHasText, IHasSpriteURI
{
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public const float ShowDelayTime = 0.025f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[SerializeField]
	private TextBase _tfUnlockTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	[SerializeField]
	private TextBase _tfItemTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[SerializeField]
	private Transform _animatedContent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private string _itemTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private string _iconAdress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private IItemData _data;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public UnityEvent OnDisplayRefresh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private HudGainItemNotif _parent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private float _delay;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public IItemData Data
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
		get
		{
			return _data;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1308CC0", Offset = "0x13076C0", VA = "0x181308CC0")]
	public void Setup(IItemData itemData, HudGainItemNotif parent, int itemOnScreen = 0)
	{
		//Discarded unreachable code: IL_014e
		//IL_0077: Expected O, but got I4
		//IL_00c3: Expected F4, but got I4
		//IL_00e1: Expected F4, but got I4
		_parent = parent;
		float delay = default(float);
		_delay = delay;
		if (itemData != null)
		{
			_itemTitle = "menu.furniture_item_unlock_title";
			_iconAdress = "menu.furniture_item_unlock_title";
		}
		_data = itemData;
		if (itemData != null)
		{
			if (itemData == null)
			{
				if (itemData == null)
				{
					if (itemData == null)
					{
						goto IL_005d;
					}
					TextBase tfUnlockTitle = _tfUnlockTitle;
				}
				TextBase tfUnlockTitle2 = _tfUnlockTitle;
			}
			_tfUnlockTitle.StringID = "menu.furniture_item_unlock_title";
		}
		goto IL_005d;
		IL_005d:
		string itemTitle = _itemTitle;
		TextBase tfItemTitle = _tfItemTitle;
		int num = 0;
		string text2 = (tfItemTitle.Text = LocalizationManager.FromStringID(itemTitle, (IResolver)num));
		GameObject gameObject = _tfItemTitle.gameObject;
		string itemTitle2 = _itemTitle;
		bool active = (object)gameObject == null;
		gameObject.SetActive(active);
		Transform animatedContent = _animatedContent;
		CanvasGroup canvasGroup = _canvasGroup;
		int num2 = 0;
		canvasGroup.alpha = num2;
		int num3 = 0;
		Transform animatedContent2 = _animatedContent;
		int num4 = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> t = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(animatedContent2, (float)num4, 0.4f, (byte)num3 != 0)).SetEase(Ease.OutBack);
		float delay2 = _delay;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetDelay(delay2).Play();
		TweenerCore<float, float, FloatOptions> t2 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_canvasGroup, 1f, 0.2f)).SetEase(Ease.Linear);
		float delay3 = _delay;
		TweenerCore<float, float, FloatOptions> tweenerCore2 = t2.SetDelay(delay3).Play();
		OnDisplayRefresh?.Invoke();
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1308AF0", Offset = "0x13074F0", VA = "0x181308AF0")]
	public Tween AnimateOut(float delay = 0f)
	{
		//IL_006c: Expected F4, but got I4
		int num = 0;
		Sequence sequence = DOTween.Sequence();
		int num2 = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> t = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(_animatedContent, -100f, 0.15f, (byte)num2 != 0)).SetEase(Ease.InCirc);
		TweenCallback action = onAnimationOutComplete;
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = t.OnComplete(action).SetDelay(delay);
		Sequence sequence2 = sequence.Join(t2);
		CanvasGroup canvasGroup = _canvasGroup;
		int num3 = 0;
		TweenerCore<float, float, FloatOptions> t3 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(canvasGroup, (float)num3, 0.15f)).SetEase(Ease.Linear).SetDelay(delay);
		Sequence sequence3 = sequence.Join(t3);
		Sequence sequence4 = sequence.Play();
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1309020", Offset = "0x1307A20", VA = "0x181309020")]
	private void onAnimationOutComplete()
	{
		//Discarded unreachable code: IL_000d
		_parent.RemoveNotificationItem(this);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "5")]
	public string GetURI(SpriteType spriteType)
	{
		return _iconAdress;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0xAF3730", Offset = "0xAF2130", VA = "0x180AF3730", Slot = "4")]
	public string GetText(TextType textType)
	{
		//IL_0010: Expected O, but got I4
		string itemTitle = _itemTitle;
		int num = 0;
		return LocalizationManager.FromStringID(itemTitle, (IResolver)num);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public HudNewItem()
	{
	}
}
