using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000603")]
	public class ProfessionButton : CustomButton
	{
		[Cpp2IlInjected.Token(Token = "0x2000604")]
		public class NewHighlightEvent : UnityEvent<ProfessionButton>
		{
			[Cpp2IlInjected.Token(Token = "0x600277A")]
			[Cpp2IlInjected.Address(RVA = "0x157EAA0", Offset = "0x157D4A0", VA = "0x18157EAA0")]
			public NewHighlightEvent()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002171")]
		public NewHighlightEvent HighlightEvent = new NewHighlightEvent();

		[Cpp2IlInjected.Token(Token = "0x170005FB")]
		public TextBase Description
		{
			[Cpp2IlInjected.Token(Token = "0x6002772")]
			[Cpp2IlInjected.Address(RVA = "0x7389F0", Offset = "0x7373F0", VA = "0x1807389F0")]
			[CompilerGenerated]
			get
			{
				return _003CDescription_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002773")]
			[Cpp2IlInjected.Address(RVA = "0x739E50", Offset = "0x738850", VA = "0x180739E50")]
			[CompilerGenerated]
			set
			{
				_003CDescription_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002774")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA30", Offset = "0xE1A430", VA = "0x180E1BA30", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_0049
			int num = 0;
			if (Application.isPlaying)
			{
				UnityEvent onHighlighted = OnHighlighted;
				UnityAction call = SelectionHandler;
				onHighlighted.AddListener(call);
				UnityEvent onDehighlighted = OnDehighlighted;
				UnityAction call2 = SelectionHandler;
				onDehighlighted.AddListener(call2);
			}
			base.OnEnable();
		}

		[Cpp2IlInjected.Token(Token = "0x6002775")]
		[Cpp2IlInjected.Address(RVA = "0xE1B950", Offset = "0xE1A350", VA = "0x180E1B950", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_0049
			int num = 0;
			if (Application.isPlaying)
			{
				UnityEvent onHighlighted = OnHighlighted;
				UnityAction call = SelectionHandler;
				onHighlighted.RemoveListener(call);
				UnityEvent onDehighlighted = OnDehighlighted;
				UnityAction call2 = SelectionHandler;
				onDehighlighted.RemoveListener(call2);
			}
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x6002776")]
		[Cpp2IlInjected.Address(RVA = "0xE1BB10", Offset = "0xE1A510", VA = "0x180E1BB10", Slot = "16")]
		internal override void Release()
		{
			//Discarded unreachable code: IL_0028
			OnHighlighted.RemoveAllListeners();
			OnDehighlighted.RemoveAllListeners();
			OnClicked.RemoveAllListeners();
			base.Release();
		}

		[Cpp2IlInjected.Token(Token = "0x6002777")]
		[Cpp2IlInjected.Address(RVA = "0xE1BB80", Offset = "0xE1A580", VA = "0x180E1BB80")]
		private void SelectionHandler()
		{
			//Discarded unreachable code: IL_004e
			SpriteAtlasImage spriteAtlasImage = base.View.Background.SpriteAtlasImage;
			AssetAddress[] assetAddresses = AssetAddresses;
			bool isHighlighted = ((TemplateButton)this)._isHighlighted;
			int num = 0;
			bool flag = isHighlighted;
			if (base.Model != null)
			{
				TextBase textBase = Description;
				int num2 = 0;
				int num3 = 0;
				((UnityEvent<T0>)(object)HighlightEvent).Invoke((T0)this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002778")]
		[Cpp2IlInjected.Address(RVA = "0xE1BD20", Offset = "0xE1A720", VA = "0x180E1BD20")]
		public void UpdateDescritpion()
		{
			//Discarded unreachable code: IL_0016
			if (base.Model != null)
			{
				TextBase textBase = Description;
				int num = 0;
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002779")]
		[Cpp2IlInjected.Address(RVA = "0xE1BE10", Offset = "0xE1A810", VA = "0x180E1BE10")]
		public ProfessionButton()
		{
		}
	}
}
