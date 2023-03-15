using System;
using System.Xml.Schema;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	public class AnimatedButton : ButtonTmPro
	{
		[Cpp2IlInjected.Token(Token = "0x2000186")]
		public delegate void Clicked(AnimatedButton button);

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public GameObject FullBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public SpriteAtlasImage bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public SpriteAtlasImage AlternateBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public bool ShowSelected = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		[SerializeField]
		private GameObject Decoration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		[SerializeField]
		protected GameObject SelectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		[SerializeField]
		private GameObject SelectedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public Clicked OnClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private float _oY;

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public bool isSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0x87E190", Offset = "0x87CB90", VA = "0x18087E190")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x600097A")]
			[Cpp2IlInjected.Address(RVA = "0x87E1A0", Offset = "0x87CBA0", VA = "0x18087E1A0")]
			set
			{
				_isSelected = value;
				Type listValueType = ((System.Xml.Schema.DatatypeImplementation)(object)this).ListValueType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x87DD80", Offset = "0x87C780", VA = "0x18087DD80")]
		public void Init()
		{
			//Discarded unreachable code: IL_0064
			//IL_0010: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			Button button = this.button;
			int num = 0;
			if (button != (UnityEngine.Object)num)
			{
				Button.ButtonClickedEvent onClick = this.button.m_OnClick;
				UnityAction call = Click;
				onClick.AddListener(call);
			}
			RectTransform animatedContent = AnimatedContent;
			int num2 = 0;
			if (animatedContent != (UnityEngine.Object)num2)
			{
				RectTransform animatedContent2 = AnimatedContent;
				Vector3 vector = default(Vector3);
				float num3 = (_oY = vector.y);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x87DD40", Offset = "0x87C740", VA = "0x18087DD40")]
		protected void Click()
		{
			RemoveHighlight();
			OnClicked?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x87DEC0", Offset = "0x87C8C0", VA = "0x18087DEC0", Slot = "17")]
		protected virtual void RefreshSelected()
		{
			//Discarded unreachable code: IL_00b6
			//IL_0010: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			int num2;
			while (true)
			{
				GameObject selectedIcon = SelectedIcon;
				int num = 0;
				bool flag = selectedIcon != (UnityEngine.Object)num;
				num2 = 0;
				if (flag)
				{
					GameObject selectedIcon2 = SelectedIcon;
					if ((_isSelected ? 1 : 0) != num2)
					{
					}
					bool active = num2 != 0;
					selectedIcon2.SetActive(active);
				}
				GameObject selectedBg = SelectedBg;
				int num3 = 0;
				if (!(selectedBg != (UnityEngine.Object)num3))
				{
					break;
				}
				GameObject selectedBg2 = SelectedBg;
				if ((_isSelected ? 1 : 0) != num2)
				{
					bool active2 = ShowSelected;
					selectedBg2.SetActive(active2);
					break;
				}
			}
			GameObject fullBg = FullBg;
			int num4 = 0;
			if (fullBg != (UnityEngine.Object)num4)
			{
				GameObject fullBg2 = FullBg;
				if ((ShowSelected ? 1 : 0) == num2)
				{
				}
				bool active3 = _isSelected;
				fullBg2.SetActive(active3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0x87DBF0", Offset = "0x87C5F0", VA = "0x18087DBF0", Slot = "18")]
		public virtual void AddHighlight()
		{
			//Discarded unreachable code: IL_006f
			//IL_0010: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			RectTransform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oY = _oY;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)AnimatedContent, oY, 0.2f, (byte)num3 != 0)).Play();
			}
			GameObject decoration = Decoration;
			int num4 = 0;
			if (decoration != (UnityEngine.Object)num4)
			{
				Decoration.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x87E040", Offset = "0x87CA40", VA = "0x18087E040", Slot = "19")]
		public virtual void RemoveHighlight()
		{
			//Discarded unreachable code: IL_0073
			//IL_0040: Expected F4, but got I4
			//IL_005b: Expected O, but got I4
			if ((bool)AnimatedContent)
			{
				RectTransform animatedContent = AnimatedContent;
				int complete = 0;
				int num = DOTween.Kill(animatedContent, (byte)complete != 0);
				float oY = _oY;
				int num2 = 0;
				RectTransform animatedContent2 = AnimatedContent;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)animatedContent2, oY, (float)num3, (byte)num2 != 0)).Play();
			}
			GameObject decoration = Decoration;
			int num4 = 0;
			if (decoration != (UnityEngine.Object)num4)
			{
				GameObject decoration2 = Decoration;
				int active = 0;
				decoration2.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x87E180", Offset = "0x87CB80", VA = "0x18087E180")]
		public AnimatedButton()
		{
		}
	}
}
