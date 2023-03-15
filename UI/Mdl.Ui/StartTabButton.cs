using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200072A")]
	public class StartTabButton : CustomButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002960")]
		public StartMenu.Phase Phase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002961")]
		[SerializeField]
		private RectTransformHelper _rectTransformHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002962")]
		[SerializeField]
		private RectTransform _highlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002963")]
		[SerializeField]
		private RectTransform _highlightedSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002964")]
		[SerializeField]
		private int _hightlightOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4002965")]
		private bool _clickReleased;

		[Cpp2IlInjected.Token(Token = "0x6002D90")]
		[Cpp2IlInjected.Address(RVA = "0x863110", Offset = "0x861B10", VA = "0x180863110", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_00bf
			base.OnEnable();
			UnityEvent onSelected = OnSelected;
			UnityAction call = UpdateVisuals;
			onSelected.AddListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = UpdateVisuals;
			onDeselected.AddListener(call2);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call3 = UpdateVisuals;
			onHighlighted.AddListener(call3);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call4 = UpdateVisuals;
			onDehighlighted.AddListener(call4);
			UnityEvent onActivated = OnActivated;
			UnityAction call5 = UpdateVisuals;
			onActivated.AddListener(call5);
			UnityEvent onDeactivated = OnDeactivated;
			UnityAction call6 = UpdateVisuals;
			onDeactivated.AddListener(call6);
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D91")]
		[Cpp2IlInjected.Address(RVA = "0x862F40", Offset = "0x861940", VA = "0x180862F40", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_00b9
			UnityEvent onSelected = OnSelected;
			UnityAction call = UpdateVisuals;
			onSelected.RemoveListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = UpdateVisuals;
			onDeselected.RemoveListener(call2);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call3 = UpdateVisuals;
			onHighlighted.RemoveListener(call3);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call4 = UpdateVisuals;
			onDehighlighted.RemoveListener(call4);
			UnityEvent onActivated = OnActivated;
			UnityAction call5 = UpdateVisuals;
			onActivated.RemoveListener(call5);
			UnityEvent onDeactivated = OnDeactivated;
			UnityAction call6 = UpdateVisuals;
			onDeactivated.RemoveListener(call6);
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D92")]
		[Cpp2IlInjected.Address(RVA = "0x863300", Offset = "0x861D00", VA = "0x180863300")]
		private void UpdateVisuals()
		{
			//Discarded unreachable code: IL_0074
			int num = 0;
			RectTransformHelper rectTransformHelper = _rectTransformHelper;
			GameObject gameObject = base.View.Background.gameObject;
			bool active = num != 0;
			gameObject.SetActive(active);
			_highlighted.gameObject.SetActive((byte)num != 0);
			GameObject gameObject2 = _highlightedSelected.gameObject;
			bool active2 = ((TemplateButton)this)._isSelected;
			gameObject2.SetActive(active2);
			base.View.Label.SetColorRGBA(994602495);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D93")]
		[Cpp2IlInjected.Address(RVA = "0x8632F0", Offset = "0x861CF0", VA = "0x1808632F0", Slot = "14")]
		public override void PostSfx(int index)
		{
			//Discarded unreachable code: IL_0008
			base.PostSfx(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D94")]
		[Cpp2IlInjected.Address(RVA = "0x863470", Offset = "0x861E70", VA = "0x180863470")]
		public StartTabButton()
		{
		}
	}
}
