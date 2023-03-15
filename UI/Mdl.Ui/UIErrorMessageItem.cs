using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000246")]
	public class UIErrorMessageItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A24")]
		public TextBase Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A25")]
		public Image Background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000A26")]
		[SerializeField]
		public CanvasGroup canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000A27")]
		[SerializeField]
		private RectTransform RectT;

		[Cpp2IlInjected.Token(Token = "0x6000E61")]
		[Cpp2IlInjected.Address(RVA = "0xC956C0", Offset = "0xC940C0", VA = "0x180C956C0")]
		internal void Show(float duration)
		{
			//Discarded unreachable code: IL_00f9
			RectTransform component = Label.GetComponent<RectTransform>();
			LayoutRebuilder.ForceRebuildLayoutImmediate(component);
			LayoutElement component2 = GetComponent<LayoutElement>();
			Vector2 sizeDelta = component.sizeDelta;
			component2.preferredWidth = duration;
			LayoutElement component3 = GetComponent<LayoutElement>();
			Vector2 sizeDelta2 = component.sizeDelta;
			component3.preferredHeight = duration;
			TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(canvasGroup, 1f, 0.2f)).SetEase(Ease.InCirc).Play();
			RectTransform rectTransform = Label.RectTransform;
			RectTransform rectTransform2 = Label.RectTransform;
			RectTransform rectTransform3 = Label.RectTransform;
			RectTransform rectTransform4 = Label.RectTransform;
			RectTransform rectTransform5 = Label.RectTransform;
			Vector3 localPosition = rectTransform2.localPosition;
			RectTransform rectTransform6 = Label.RectTransform;
			Vector3 localPosition2 = rectTransform2.localPosition;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.SetEase(Ease.OutCirc).Play();
			int _003C_003E1__state = default(int);
			_003CHide_003Ed__5 _003CHide_003Ed__ = new _003CHide_003Ed__5(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CHide_003Ed__._003C_003E4__this = this;
			_003CHide_003Ed__.duration = duration;
			Coroutine coroutine = StartCoroutine(_003CHide_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E62")]
		[Cpp2IlInjected.Address(RVA = "0xC95640", Offset = "0xC94040", VA = "0x180C95640")]
		[IteratorStateMachine(typeof(_003CHide_003Ed__5))]
		private IEnumerator Hide(float duration)
		{
			int _003C_003E1__state = default(int);
			_003CHide_003Ed__5 _003CHide_003Ed__ = new _003CHide_003Ed__5(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CHide_003Ed__._003C_003E4__this = this;
			_003CHide_003Ed__.duration = duration;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E63")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public UIErrorMessageItem()
		{
		}
	}
}
