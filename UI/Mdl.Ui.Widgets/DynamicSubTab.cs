using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Motion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200097A")]
	public class DynamicSubTab : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200097B")]
		public delegate void Selected(DynamicSubTab tab);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003821")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003823")]
		public CanvasGroup group;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003824")]
		public Image selectedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003825")]
		public Image unselectedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003826")]
		public Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003827")]
		public float fadeDuration = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003828")]
		private ClipSequence fade;

		[Cpp2IlInjected.Token(Token = "0x17000818")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003B84")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B85")]
			[Cpp2IlInjected.Address(RVA = "0xF22FB0", Offset = "0xF219B0", VA = "0x180F22FB0")]
			set
			{
				//Discarded unreachable code: IL_0049
				if (value != isSelected)
				{
					isSelected = value;
					GameObject gameObject = selectedIcon.gameObject;
					bool active = isSelected;
					gameObject.SetActive(active);
					GameObject gameObject2 = unselectedIcon.gameObject;
					bool active2 = !isSelected;
					gameObject2.SetActive(active2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000819")]
		public Filter Filter
		{
			[Cpp2IlInjected.Token(Token = "0x6003B86")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CFilter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B87")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CFilter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007E")]
		public event Selected OnSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003B82")]
			[Cpp2IlInjected.Address(RVA = "0xF22E70", Offset = "0xF21870", VA = "0x180F22E70")]
			[CompilerGenerated]
			add
			{
				Selected onSelected = this.OnSelected;
				Delegate @delegate = Delegate.Combine(onSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003B83")]
			[Cpp2IlInjected.Address(RVA = "0xF22F10", Offset = "0xF21910", VA = "0x180F22F10")]
			[CompilerGenerated]
			remove
			{
				Selected onSelected = this.OnSelected;
				Delegate @delegate = Delegate.Remove(onSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B88")]
		[Cpp2IlInjected.Address(RVA = "0xF22980", Offset = "0xF21380", VA = "0x180F22980")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0021
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			UnityAction call = Select;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B89")]
		[Cpp2IlInjected.Address(RVA = "0xF22A20", Offset = "0xF21420", VA = "0x180F22A20")]
		public void Init(DynamicSubTabData data, FilterColorConfig colorConfig, int filterIndex)
		{
			//Discarded unreachable code: IL_0016
			Filter filter = default(Filter);
			Filter = filter;
			Image image = selectedIcon;
			Image image2 = unselectedIcon;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B8A")]
		[Cpp2IlInjected.Address(RVA = "0xF22B40", Offset = "0xF21540", VA = "0x180F22B40")]
		public unsafe void Show(float delay)
		{
			//Discarded unreachable code: IL_007b
			//IL_0013: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_007a: Expected F4, but got I4
			Silence clip = new Silence(delay);
			int num = default(int);
			Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num2 = 0;
			Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateFadeIn);
			Tween<float> tween = default(Tween<float>);
			((Tween<T>)(object)tween).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			ClipSequence clipSequence = (fade = new ClipSequence());
			fade.Append(clip);
			fade.Append(tween);
			CanvasGroup canvasGroup = group;
			int num3 = 0;
			canvasGroup.alpha = num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B8B")]
		[Cpp2IlInjected.Address(RVA = "0xF22D90", Offset = "0xF21790", VA = "0x180F22D90")]
		private void UpdateFadeIn(float alpha, float progress)
		{
			//Discarded unreachable code: IL_000d
			group.alpha = alpha;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B8C")]
		[Cpp2IlInjected.Address(RVA = "0xF22AB0", Offset = "0xF214B0", VA = "0x180F22AB0")]
		private void Select()
		{
			//Discarded unreachable code: IL_005e
			if (!isSelected)
			{
				isSelected = true;
				GameObject gameObject = selectedIcon.gameObject;
				bool active = isSelected;
				gameObject.SetActive(active);
				GameObject gameObject2 = unselectedIcon.gameObject;
				bool active2 = !isSelected;
				gameObject2.SetActive(active2);
				this.OnSelected?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B8D")]
		[Cpp2IlInjected.Address(RVA = "0xF22DB0", Offset = "0xF217B0", VA = "0x180F22DB0")]
		private void UpdateState()
		{
			//Discarded unreachable code: IL_0038
			GameObject gameObject = selectedIcon.gameObject;
			bool active = isSelected;
			gameObject.SetActive(active);
			GameObject gameObject2 = unselectedIcon.gameObject;
			bool active2 = !isSelected;
			gameObject2.SetActive(active2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B8E")]
		[Cpp2IlInjected.Address(RVA = "0xF22E10", Offset = "0xF21810", VA = "0x180F22E10")]
		private void Update()
		{
			ClipSequence clipSequence = fade;
			if (clipSequence != null)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				int reverse = 0;
				if (clipSequence.Play(deltaTime, (byte)reverse != 0))
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B8F")]
		[Cpp2IlInjected.Address(RVA = "0xF22E60", Offset = "0xF21860", VA = "0x180F22E60")]
		public DynamicSubTab()
		{
		}
	}
}
