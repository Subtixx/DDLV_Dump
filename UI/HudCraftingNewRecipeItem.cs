using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Localization.Formatter;
using Mdl.Ui;
using UnityEngine;
using UnityEngine.Events;

[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HudCraftingNewRecipeItem : MonoBehaviour, IHasText, IHasSpriteURI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[SerializeField]
	private TextBase _tfUnlockTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[SerializeField]
	private TextBase _tfRecipeTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[SerializeField]
	private Transform _animatedContent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string _recipeTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private string _iconAdress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public UnityEvent OnDisplayRefresh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private HudCraftingNotif _parent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float _delay;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0xAF3740", Offset = "0xAF2140", VA = "0x180AF3740")]
	public void Setup(CraftingRecipeItemData craftingData, HudCraftingNotif parent, int itemOnScreen = 0)
	{
		//Discarded unreachable code: IL_013e
		//IL_004e: Expected O, but got I4
		//IL_009a: Expected F4, but got I4
		//IL_00b8: Expected F4, but got I4
		_parent = parent;
		float delay = default(float);
		_delay = delay;
		ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
		Item item = craftingData.result_.Item;
		IItemData itemData = default(IItemData);
		if (itemData != null)
		{
			_recipeTitle = (string)(object)itemData;
			_iconAdress = (string)(object)itemData;
		}
		string recipeTitle = _recipeTitle;
		TextBase tfRecipeTitle = _tfRecipeTitle;
		int num = 0;
		string text2 = (tfRecipeTitle.Text = LocalizationManager.FromStringID(recipeTitle, (IResolver)num));
		GameObject gameObject = _tfRecipeTitle.gameObject;
		string recipeTitle2 = _recipeTitle;
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
		TweenCallback action = onAnimationInComplete;
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = t.OnComplete(action);
		float delay2 = _delay;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t2.SetDelay(delay2).Play();
		TweenerCore<float, float, FloatOptions> t3 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_canvasGroup, 1f, 0.2f)).SetEase(Ease.Linear);
		float delay3 = _delay;
		TweenerCore<float, float, FloatOptions> tweenerCore2 = t3.SetDelay(delay3).Play();
		OnDisplayRefresh?.Invoke();
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0xAF3AD0", Offset = "0xAF24D0", VA = "0x180AF3AD0")]
	private void onAnimationInComplete()
	{
		//IL_005f: Expected F4, but got I4
		int num = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> t = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(_animatedContent, -100f, 0.15f, (byte)num != 0)).SetEase(Ease.InCirc).SetDelay(3f);
		TweenCallback action = onAnimationOutComplete;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.OnComplete(action).Play();
		CanvasGroup canvasGroup = _canvasGroup;
		int num2 = 0;
		TweenerCore<float, float, FloatOptions> tweenerCore2 = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(canvasGroup, (float)num2, 0.15f)).SetEase(Ease.Linear).SetDelay(3f).Play();
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xAF3C60", Offset = "0xAF2660", VA = "0x180AF3C60")]
	private void onAnimationOutComplete()
	{
		//Discarded unreachable code: IL_0028
		HudCraftingNotif parent = _parent;
		Transform transform = base.gameObject.transform;
		Transform transform2 = (transform.parentInternal = parent._trashBin);
		parent.ShowNotificationItem();
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "5")]
	public string GetURI(SpriteType spriteType)
	{
		return _iconAdress;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0xAF3730", Offset = "0xAF2130", VA = "0x180AF3730", Slot = "4")]
	public string GetText(TextType textType)
	{
		//IL_0010: Expected O, but got I4
		string recipeTitle = _recipeTitle;
		int num = 0;
		return LocalizationManager.FromStringID(recipeTitle, (IResolver)num);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public HudCraftingNewRecipeItem()
	{
	}
}
