using Cpp2IlInjected;
using Newtonsoft.Json.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	public class TextButton : CustomButton
	{
		[Cpp2IlInjected.Token(Token = "0x200019E")]
		internal enum Phase
		{
			[Cpp2IlInjected.Token(Token = "0x40006F7")]
			TextOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		internal Phase VisualType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public RectTransform Body;

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x17EBFC0", Offset = "0x17EA9C0", VA = "0x1817EBFC0", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_007b
			base.OnEnable();
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call = OnHighlightedHandler;
			onHighlighted.AddListener(call);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call2 = OnHighlightedHandler;
			onDehighlighted.AddListener(call2);
			UnityEvent onActivated = OnActivated;
			UnityAction call3 = OnActivatedHandler;
			onActivated.AddListener(call3);
			UnityEvent onDeactivated = OnDeactivated;
			UnityAction call4 = OnActivatedHandler;
			onDeactivated.AddListener(call4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x17EBE60", Offset = "0x17EA860", VA = "0x1817EBE60", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_007b
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call = OnHighlightedHandler;
			onHighlighted.RemoveListener(call);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call2 = OnHighlightedHandler;
			onDehighlighted.RemoveListener(call2);
			UnityEvent onActivated = OnActivated;
			UnityAction call3 = OnActivatedHandler;
			onActivated.RemoveListener(call3);
			UnityEvent onDeactivated = OnDeactivated;
			UnityAction call4 = OnActivatedHandler;
			onDeactivated.RemoveListener(call4);
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x17EC140", Offset = "0x17EAB40", VA = "0x1817EC140", Slot = "19")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0118
			//IL_0016: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0072: Expected O, but got I4
			//IL_009b: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			//IL_00fd: Expected O, but got I4
			base.RefreshDisplay();
			ButtonViewDefault view = base.View;
			int num = 0;
			if (view == (Object)num || VisualType != 0)
			{
				return;
			}
			int num2 = 0;
			TextBase label = base.View.Label;
			int num3 = 0;
			if (label != (Object)num3)
			{
				base.View.Label.SetColorRGB(7042191);
			}
			ImageHelper background = base.View.Background;
			int num4 = 0;
			if (background != (Object)num4)
			{
				ImageHelper background2 = base.View.Background;
				TextBase label2 = base.View.Label;
				int num5 = 0;
				if (label2 != (Object)num5)
				{
					base.View.Label.SetColorRGB(3885165);
				}
				ImageHelper background3 = base.View.Background;
				int num6 = 0;
				if (background3 != (Object)num6)
				{
					base.View.Background.SetColorRGB(14935807);
				}
			}
			ImageHelper background4 = base.View.Background;
			int num7 = 0;
			if (background4 != (Object)num7)
			{
				bool active = default(bool);
				base.View.Background.gameObject.SetActive(active);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x17EC120", Offset = "0x17EAB20", VA = "0x1817EC120")]
		private void OnHighlightedHandler()
		{
			object underlyingCollection = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x17EBE30", Offset = "0x17EA830", VA = "0x1817EBE30")]
		private void OnActivatedHandler()
		{
			bool flag = (base.IsInteractable = ((TemplateButton)this)._isActivated);
			object underlyingCollection = ((Newtonsoft.Json.Utilities.IWrappedCollection)this).UnderlyingCollection;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x863470", Offset = "0x861E70", VA = "0x180863470")]
		public TextButton()
		{
		}
	}
}
