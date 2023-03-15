using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	public class AnimatedToggleButton : ToggleButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		[SerializeField]
		private RectTransform _normalBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		[SerializeField]
		private RectTransform _highlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		[SerializeField]
		private RectTransform _selectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		[SerializeField]
		private RectTransform _selectedHighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		[SerializeField]
		private RectTransform _deco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		[SerializeField]
		private Color _highlightIconColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		[SerializeField]
		private Color _selectedIconColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		[SerializeField]
		private Color _selectedHighlightIconColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		[SerializeField]
		private Color _normalIconColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		[SerializeField]
		private bool _animateHorizontally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private float _oY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private float _oX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private bool isHighlighted;

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x87E770", Offset = "0x87D170", VA = "0x18087E770", Slot = "17")]
		public override void Start()
		{
			//Discarded unreachable code: IL_0031
			//IL_0016: Expected O, but got I4
			base.Start();
			RectTransform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				RectTransform animatedContent2 = AnimatedContent;
				RectTransform animatedContent3 = AnimatedContent;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0x87E520", Offset = "0x87CF20", VA = "0x18087E520", Slot = "18")]
		public override void RefreshSeleced()
		{
			//Discarded unreachable code: IL_0042
			base.RefreshSeleced();
			SpriteAtlasImage mcIcon = _mcIcon;
			Image image = mcIcon.Image;
			if (isHighlighted)
			{
			}
			Image image2 = mcIcon.Image;
			if (isHighlighted)
			{
			}
			Color color = (image2.color = _selectedIconColor);
			RefreshBackground();
		}

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x87E1C0", Offset = "0x87CBC0", VA = "0x18087E1C0", Slot = "19")]
		public virtual void AddHighlight()
		{
			//Discarded unreachable code: IL_00f4
			//IL_0017: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00d2: Expected O, but got I4
			RectTransform animatedContent = AnimatedContent;
			isHighlighted = true;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				RectTransform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				RectTransform animatedContent3 = AnimatedContent;
				int num3 = 0;
				if ((_animateHorizontally ? 1 : 0) == num3)
				{
					float oY = _oY;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)animatedContent3, oY, 0.2f, (byte)num3 != 0);
				}
				float oX = _oX;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX((Transform)animatedContent3, oX, 0.2f, (byte)num3 != 0)).Play();
			}
			_deco?.gameObject.SetActive(value: true);
			RefreshBackground();
			RectTransform selectedHighlightBg = _selectedHighlightBg;
			int num4 = 0;
			if (selectedHighlightBg != (Object)num4)
			{
				Image image = _mcIcon.Image;
			}
			RectTransform highlightBg = _highlightBg;
			int num5 = 0;
			if (highlightBg != (Object)num5)
			{
				Image image2 = _mcIcon.Image;
				Color color = (image2.color = _highlightIconColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0x87E5D0", Offset = "0x87CFD0", VA = "0x18087E5D0", Slot = "20")]
		public virtual void RemoveHighlight()
		{
			//Discarded unreachable code: IL_00cb
			//IL_0017: Expected O, but got I4
			//IL_0059: Expected F4, but got I4
			//IL_0070: Expected F4, but got I4
			RectTransform animatedContent = AnimatedContent;
			isHighlighted = false;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				RectTransform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				RectTransform animatedContent3 = AnimatedContent;
				int num3 = 0;
				int num4 = 0;
				if ((_animateHorizontally ? 1 : 0) == num3)
				{
					float oY = _oY;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)animatedContent3, oY, (float)num4, (byte)num3 != 0);
				}
				float oX = _oX;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX((Transform)animatedContent3, oX, (float)num4, (byte)num3 != 0)).Play();
			}
			RectTransform deco = _deco;
			if ((object)deco != null)
			{
				GameObject gameObject = deco.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			RefreshBackground();
			SpriteAtlasImage mcIcon = _mcIcon;
			Image image = mcIcon.Image;
			Image image2 = mcIcon.Image;
			Color color = (image2.color = _selectedIconColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0x87E400", Offset = "0x87CE00", VA = "0x18087E400")]
		private void RefreshBackground()
		{
			//Discarded unreachable code: IL_00aa
			int num = 0;
			RectTransform selectedBg = _selectedBg;
			if ((object)selectedBg != null)
			{
				GameObject gameObject = selectedBg.gameObject;
				bool active = (isHighlighted ? 1 : 0) == num;
				gameObject.SetActive(active);
			}
			RectTransform normalBg = _normalBg;
			if ((object)normalBg != null)
			{
				GameObject gameObject2 = normalBg.gameObject;
				bool active2 = (isHighlighted ? 1 : 0) == num;
				gameObject2.SetActive(active2);
			}
			RectTransform selectedHighlightBg = _selectedHighlightBg;
			if ((object)selectedHighlightBg != null)
			{
				GameObject gameObject3 = selectedHighlightBg.gameObject;
				bool active3 = isHighlighted;
				gameObject3.SetActive(active3);
			}
			RectTransform highlightBg = _highlightBg;
			if ((object)highlightBg != null)
			{
				GameObject gameObject4 = highlightBg.gameObject;
				bool active4 = isHighlighted;
				gameObject4.SetActive(active4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x87E850", Offset = "0x87D250", VA = "0x18087E850")]
		public AnimatedToggleButton()
		{
			Color white = Color.white;
			Color white2 = Color.white;
			Color white3 = Color.white;
			Color white4 = Color.white;
			base._002Ector();
		}
	}
}
