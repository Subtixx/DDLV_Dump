using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Motion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009BF")]
	public class SlidingPanel : Introducable
	{
		[Cpp2IlInjected.Token(Token = "0x20009C0")]
		public delegate void SlidingPanelEvent();

		[Cpp2IlInjected.Token(Token = "0x20009C1")]
		public enum Direction
		{
			[Cpp2IlInjected.Token(Token = "0x400397B")]
			Left,
			[Cpp2IlInjected.Token(Token = "0x400397C")]
			Right,
			[Cpp2IlInjected.Token(Token = "0x400397D")]
			Top,
			[Cpp2IlInjected.Token(Token = "0x400397E")]
			Bottom
		}

		[Cpp2IlInjected.Token(Token = "0x20009C2")]
		private enum SlidingType
		{
			[Cpp2IlInjected.Token(Token = "0x4003980")]
			Bouncing,
			[Cpp2IlInjected.Token(Token = "0x4003981")]
			None
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003963")]
		public bool showOnIntroduce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4003964")]
		public bool isHidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
		[Cpp2IlInjected.Token(Token = "0x4003965")]
		public bool isOpened;

		[Cpp2IlInjected.FieldOffset(Offset = "0x53")]
		[Cpp2IlInjected.Token(Token = "0x4003966")]
		public bool IsOpening;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4003967")]
		public bool IsClosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
		[Cpp2IlInjected.Token(Token = "0x4003968")]
		public bool IsDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003969")]
		public Direction pullInDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400396A")]
		public SlidingPanelConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400396B")]
		public OpenCloseSlidingPanel PanelButtons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400396C")]
		public AK.Wwise.Event openSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400396D")]
		public AK.Wwise.Event showAndOpenSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400396E")]
		public AK.Wwise.Event closeSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400396F")]
		public List<Button> deactivateOnHide = (List<Button>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003970")]
		public List<GameObject> hideOnHidden = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003971")]
		public List<GameObject> hideOnOpen = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003972")]
		public List<GameObject> hideOnClose = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003973")]
		public UnityEvent OnOpenContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003974")]
		public UnityEvent OnCloseContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003975")]
		[SerializeField]
		private SlidingType _slidingStyle = SlidingType.None;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003976")]
		private ClipSequence _transition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003977")]
		private RectTransform _rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003978")]
		private float _normalizedValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4003979")]
		private bool _isAwaken;

		[Cpp2IlInjected.Token(Token = "0x1700085E")]
		public bool IsOpenOrOpening
		{
			[Cpp2IlInjected.Token(Token = "0x6003D0B")]
			[Cpp2IlInjected.Address(RVA = "0x15F9220", Offset = "0x15F7C20", VA = "0x1815F9220")]
			get
			{
				do
				{
					if (IsClosing)
					{
						int num = 0;
					}
				}
				while (isOpened);
				return IsOpening;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700085F")]
		public bool IsClosed
		{
			[Cpp2IlInjected.Token(Token = "0x6003D0C")]
			[Cpp2IlInjected.Address(RVA = "0x15F9200", Offset = "0x15F7C00", VA = "0x1815F9200")]
			get
			{
				if (!IsClosing && !isOpened)
				{
					return !IsOpening;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000083")]
		public event SlidingPanelEvent OnOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6003CFF")]
			[Cpp2IlInjected.Address(RVA = "0x15F90C0", Offset = "0x15F7AC0", VA = "0x1815F90C0")]
			[CompilerGenerated]
			add
			{
				SlidingPanelEvent onOpen = this.OnOpen;
				Delegate @delegate = Delegate.Combine(onOpen, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onOpen)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D00")]
			[Cpp2IlInjected.Address(RVA = "0x15F94C0", Offset = "0x15F7EC0", VA = "0x1815F94C0")]
			[CompilerGenerated]
			remove
			{
				SlidingPanelEvent onOpen = this.OnOpen;
				Delegate @delegate = Delegate.Remove(onOpen, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onOpen)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000084")]
		public event SlidingPanelEvent OnClose
		{
			[Cpp2IlInjected.Token(Token = "0x6003D01")]
			[Cpp2IlInjected.Address(RVA = "0x15F9020", Offset = "0x15F7A20", VA = "0x1815F9020")]
			[CompilerGenerated]
			add
			{
				SlidingPanelEvent onClose = this.OnClose;
				Delegate @delegate = Delegate.Combine(onClose, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onClose)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D02")]
			[Cpp2IlInjected.Address(RVA = "0x15F9420", Offset = "0x15F7E20", VA = "0x1815F9420")]
			[CompilerGenerated]
			remove
			{
				SlidingPanelEvent onClose = this.OnClose;
				Delegate @delegate = Delegate.Remove(onClose, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onClose)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000085")]
		public event SlidingPanelEvent OnActivateOpenContent
		{
			[Cpp2IlInjected.Token(Token = "0x6003D03")]
			[Cpp2IlInjected.Address(RVA = "0x15F8EE0", Offset = "0x15F78E0", VA = "0x1815F8EE0")]
			[CompilerGenerated]
			add
			{
				SlidingPanelEvent onActivateOpenContent = this.OnActivateOpenContent;
				Delegate @delegate = Delegate.Combine(onActivateOpenContent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onActivateOpenContent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D04")]
			[Cpp2IlInjected.Address(RVA = "0x15F92E0", Offset = "0x15F7CE0", VA = "0x1815F92E0")]
			[CompilerGenerated]
			remove
			{
				SlidingPanelEvent onActivateOpenContent = this.OnActivateOpenContent;
				Delegate @delegate = Delegate.Remove(onActivateOpenContent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onActivateOpenContent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000086")]
		public event SlidingPanelEvent OnActivateCloseContent
		{
			[Cpp2IlInjected.Token(Token = "0x6003D05")]
			[Cpp2IlInjected.Address(RVA = "0x15F8E40", Offset = "0x15F7840", VA = "0x1815F8E40")]
			[CompilerGenerated]
			add
			{
				SlidingPanelEvent onActivateCloseContent = this.OnActivateCloseContent;
				Delegate @delegate = Delegate.Combine(onActivateCloseContent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onActivateCloseContent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D06")]
			[Cpp2IlInjected.Address(RVA = "0x15F9240", Offset = "0x15F7C40", VA = "0x1815F9240")]
			[CompilerGenerated]
			remove
			{
				SlidingPanelEvent onActivateCloseContent = this.OnActivateCloseContent;
				Delegate @delegate = Delegate.Remove(onActivateCloseContent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onActivateCloseContent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000087")]
		public event SlidingPanelEvent OnActivateShowContent
		{
			[Cpp2IlInjected.Token(Token = "0x6003D07")]
			[Cpp2IlInjected.Address(RVA = "0x15F8F80", Offset = "0x15F7980", VA = "0x1815F8F80")]
			[CompilerGenerated]
			add
			{
				SlidingPanelEvent onActivateShowContent = this.OnActivateShowContent;
				Delegate @delegate = Delegate.Combine(onActivateShowContent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onActivateShowContent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D08")]
			[Cpp2IlInjected.Address(RVA = "0x15F9380", Offset = "0x15F7D80", VA = "0x1815F9380")]
			[CompilerGenerated]
			remove
			{
				SlidingPanelEvent onActivateShowContent = this.OnActivateShowContent;
				Delegate @delegate = Delegate.Remove(onActivateShowContent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onActivateShowContent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000088")]
		public event SlidingPanelEvent OnOvershootFinished
		{
			[Cpp2IlInjected.Token(Token = "0x6003D09")]
			[Cpp2IlInjected.Address(RVA = "0x15F9160", Offset = "0x15F7B60", VA = "0x1815F9160")]
			[CompilerGenerated]
			add
			{
				SlidingPanelEvent onOvershootFinished = this.OnOvershootFinished;
				Delegate @delegate = Delegate.Combine(onOvershootFinished, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onOvershootFinished)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D0A")]
			[Cpp2IlInjected.Address(RVA = "0x15F9560", Offset = "0x15F7F60", VA = "0x1815F9560")]
			[CompilerGenerated]
			remove
			{
				SlidingPanelEvent onOvershootFinished = this.OnOvershootFinished;
				Delegate @delegate = Delegate.Remove(onOvershootFinished, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onOvershootFinished)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D0D")]
		[Cpp2IlInjected.Address(RVA = "0x15F63E0", Offset = "0x15F4DE0", VA = "0x1815F63E0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0087
			//IL_0049: Expected F4, but got I4
			//IL_007a: Expected F4, but got I4
			_isAwaken = true;
			bool isAwaken = _isAwaken;
			IsDone = false;
			if (!isAwaken)
			{
				return;
			}
			RectTransform rectTransform = (_rect = GetComponent<RectTransform>());
			if (!isHidden)
			{
				int num = 0;
				int num2 = 0;
				if ((isOpened ? 1 : 0) != num)
				{
					UpdatePosition(1f, num2);
					UpdateOnOpen();
				}
				else
				{
					UpdateOnClose();
				}
			}
			else
			{
				float closeOvershootAmount = config.closeOvershootAmount;
				float num3 = Size();
				int num4 = 0;
				UpdatePosition(closeOvershootAmount, num4);
				UpdateOnHidden();
				UpdateOnClose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D0E")]
		[Cpp2IlInjected.Address(RVA = "0x15F6E20", Offset = "0x15F5820", VA = "0x1815F6E20")]
		public void Init()
		{
			//Discarded unreachable code: IL_007c
			//IL_0040: Expected F4, but got I4
			//IL_006f: Expected F4, but got I4
			IsDone = false;
			if (!_isAwaken)
			{
				return;
			}
			RectTransform rectTransform = (_rect = GetComponent<RectTransform>());
			if (!isHidden)
			{
				int num = 0;
				int num2 = 0;
				if ((isOpened ? 1 : 0) != num)
				{
					UpdatePosition(1f, num2);
					UpdateOnOpen();
				}
				else
				{
					UpdateOnClose();
				}
			}
			else
			{
				float closeOvershootAmount = config.closeOvershootAmount;
				float num3 = Size();
				int num4 = 0;
				UpdatePosition(closeOvershootAmount, num4);
				UpdateOnHidden();
				UpdateOnClose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D0F")]
		[Cpp2IlInjected.Address(RVA = "0x15F8CB0", Offset = "0x15F76B0", VA = "0x1815F8CB0")]
		private void Update()
		{
			int num = 0;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D10")]
		[Cpp2IlInjected.Address(RVA = "0x15F8470", Offset = "0x15F6E70", VA = "0x1815F8470")]
		private float Size()
		{
			RectTransform rect = _rect;
			if (pullInDirection > Direction.Right)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D11")]
		[Cpp2IlInjected.Address(RVA = "0x15F7940", Offset = "0x15F6340", VA = "0x1815F7940")]
		public unsafe void Show(bool andOpen = false)
		{
			//Discarded unreachable code: IL_00d8, IL_00e5, IL_00f8, IL_0105, IL_010e, IL_0122, IL_0129, IL_0149, IL_018c, IL_0193, IL_01cc, IL_01e9, IL_023b, IL_0242, IL_0290
			//IL_004f: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			//IL_008b: Invalid comparison between F4 and I4
			//IL_009f: Expected O, but got I4
			//IL_00c1: Expected O, but got I4
			//IL_015e: Expected O, but got I4
			//IL_01a8: Expected O, but got I4
			//IL_01f6: Expected O, but got I4
			//IL_024f: Expected O, but got I4
			int num = 0;
			if ((isHidden ? 1 : 0) == num || (_isAwaken ? 1 : 0) == num || !base.enabled)
			{
				return;
			}
			List<Button> list = deactivateOnHide;
			bool flag = default(bool);
			if (flag)
			{
			}
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Tween<float>.UpdateEventHandler updateEventHandler = default(Tween<float>.UpdateEventHandler);
			if (new ClipSequence() == null)
			{
				int num5 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num5, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num5 = 0;
				Tween<float> tween = default(Tween<float>);
				((Tween<T>)(object)tween).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			}
			Tween<float> tween2 = default(Tween<float>);
			if ((long)updateEventHandler == 1)
			{
				int num6 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction2 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num6, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num6 = 0;
				EasingFunction easingFunction = EasingUtil.EasingFunction(EasingType.Linear);
				Tween<float>.UpdateEventHandler updateEventHandler2 = default(Tween<float>.UpdateEventHandler);
				((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler2);
			}
			float num7 = default(float);
			if (!(num7 <= (float)num4))
			{
				Tween<float> tween3 = default(Tween<float>);
				if (tween2 == null)
				{
					int num8 = default(int);
					Tween<float>.InterpolationFunction interpolationFunction3 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num8, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
					num8 = 0;
					Tween<float>.UpdateEventHandler updateEventHandler3 = default(Tween<float>.UpdateEventHandler);
					((Tween<T>)(object)tween3).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler3);
				}
				if ((long)tween3 == 1)
				{
					int num9 = default(int);
					Tween<float>.InterpolationFunction interpolationFunction4 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num9, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
					num9 = 0;
					EasingFunction easingFunction2 = EasingUtil.EasingFunction(EasingType.Linear);
					Tween<float> tween4 = default(Tween<float>);
					Tween<float>.UpdateEventHandler updateEventHandler4 = default(Tween<float>.UpdateEventHandler);
					((Tween<T>)(object)tween4).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler4);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D12")]
		[Cpp2IlInjected.Address(RVA = "0x15F8A60", Offset = "0x15F7460", VA = "0x1815F8A60")]
		private void UpdateOnShown()
		{
			//Discarded unreachable code: IL_0015, IL_001b
			int num = ((isHidden = false) ? 1 : 0);
			List<GameObject> list = hideOnHidden;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D13")]
		[Cpp2IlInjected.Address(RVA = "0x15F6A20", Offset = "0x15F5420", VA = "0x1815F6A20")]
		public unsafe void Hide()
		{
			//Discarded unreachable code: IL_0057, IL_0069
			//IL_0036: Expected O, but got I4
			int num = 0;
			if ((_isAwaken ? 1 : 0) != num && base.enabled)
			{
				List<Button> list = deactivateOnHide;
				bool flag = default(bool);
				if (flag)
				{
					int num2 = 0;
				}
				ClipSequence clipSequence = new ClipSequence();
				int num3 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num3, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num3 = 0;
				Tween<float> tween = default(Tween<float>);
				Tween<float>.UpdateEventHandler updateEventHandler = default(Tween<float>.UpdateEventHandler);
				((Tween<T>)(object)tween).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
				Tween<float>.FinishEventHandler finishEventHandler = default(Tween<float>.FinishEventHandler);
				((Tween<T>)(object)tween).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
				Tween<float>.FinishEventHandler finishEventHandler2 = default(Tween<float>.FinishEventHandler);
				((Tween<T>)(object)tween).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D14")]
		[Cpp2IlInjected.Address(RVA = "0x15F8740", Offset = "0x15F7140", VA = "0x1815F8740")]
		private void UpdateOnHidden()
		{
			//Discarded unreachable code: IL_0015
			isHidden = true;
			List<GameObject> list = hideOnHidden;
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D15")]
		[Cpp2IlInjected.Address(RVA = "0x15F7050", Offset = "0x15F5A50", VA = "0x1815F7050")]
		public unsafe void Open()
		{
			//Discarded unreachable code: IL_0299
			//IL_006e: Invalid comparison between F4 and I4
			//IL_0099: Expected O, but got I4
			//IL_00f0: Expected O, but got I4
			//IL_014f: Expected O, but got I4
			//IL_0199: Expected O, but got I4
			//IL_01ca: Invalid comparison between F4 and I4
			//IL_01e9: Expected O, but got I4
			//IL_0242: Expected O, but got I4
			if (isOpened || !_isAwaken)
			{
				return;
			}
			AK.Wwise.Event @event = openSfx;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
			IsOpening = true;
			ClipSequence clipSequence = (_transition = new ClipSequence());
			SlidingPanelConfig slidingPanelConfig = config;
			float num2 = Size();
			float num3 = Size();
			float openAnticAmount = config.openAnticAmount;
			int num4 = 0;
			if (!(openAnticAmount <= (float)num4) && !isHidden)
			{
				SlidingType slidingStyle = _slidingStyle;
				if (slidingStyle == SlidingType.Bouncing)
				{
					int num5 = default(int);
					Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num5, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
					num5 = 0;
					EasingFunction easingFunction = EasingUtil.EasingFunction(config.openAnticEasing);
					Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePosition);
					Tween<float> tween = default(Tween<float>);
					((Tween<T>)(object)tween).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
					Tween<float>.FinishEventHandler finishEventHandler = (Tween<float>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(UpdateOnOpen);
					((Tween<T>)(object)tween).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
				}
				if (slidingStyle == SlidingType.None)
				{
					int num6 = default(int);
					Tween<float>.InterpolationFunction interpolationFunction2 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num6, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
					num6 = 0;
					EasingFunction easingFunction2 = EasingUtil.EasingFunction(EasingType.Linear);
					Tween<float>.UpdateEventHandler updateEventHandler2 = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePosition);
					Tween<float> tween2 = default(Tween<float>);
					((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler2);
					Tween<float>.FinishEventHandler finishEventHandler2 = (Tween<float>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(UpdateOnOpen);
					((Tween<T>)(object)tween2).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler2);
				}
			}
			UpdateOnOpen();
			Tween<float>.UpdateEventHandler updateEventHandler3 = default(Tween<float>.UpdateEventHandler);
			if (_slidingStyle == SlidingType.Bouncing)
			{
				SlidingPanelConfig slidingPanelConfig2 = config;
				int num7 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction3 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num7, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num7 = 0;
				EasingFunction easingFunction3 = EasingUtil.EasingFunction(config.openEasing);
				updateEventHandler3 = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePosition);
				Tween<float> tween3 = default(Tween<float>);
				((Tween<T>)(object)tween3).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler3);
			}
			if ((long)updateEventHandler3 == 1)
			{
				SlidingPanelConfig slidingPanelConfig3 = config;
				int num8 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction4 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num8, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num8 = 0;
				EasingFunction easingFunction4 = EasingUtil.EasingFunction(EasingType.Linear);
				Tween<float>.UpdateEventHandler updateEventHandler4 = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePosition);
				Tween<float> tween4 = default(Tween<float>);
				((Tween<T>)(object)tween4).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler4);
			}
			if (!(config.openOvershootAmount > (float)num4))
			{
				IsOpening = false;
			}
			Tween<float> tween5 = default(Tween<float>);
			if (_slidingStyle == SlidingType.Bouncing)
			{
				int num9 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction5 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num9, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num9 = 0;
				EasingFunction easingFunction5 = EasingUtil.EasingFunction(config.openOvershootEasing);
				Tween<float>.UpdateEventHandler updateEventHandler5 = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePosition);
				((Tween<T>)(object)tween5).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler5);
				Tween<float>.FinishEventHandler finishEventHandler3 = (Tween<float>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(OnFinished);
				((Tween<T>)(object)tween5).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler3);
			}
			if ((long)tween5 == 1)
			{
				int num10 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction6 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num10, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num10 = 0;
				EasingFunction easingFunction6 = EasingUtil.EasingFunction(EasingType.Linear);
				Tween<float>.UpdateEventHandler updateEventHandler6 = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePosition);
				Tween<float> tween6 = default(Tween<float>);
				((Tween<T>)(object)tween6).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler6);
				Tween<float>.FinishEventHandler finishEventHandler4 = (Tween<float>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(OnFinished);
				((Tween<T>)(object)tween6).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler4);
			}
			SlidingPanelEvent onOpen = this.OnOpen;
			isOpened = true;
			onOpen?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D16")]
		[Cpp2IlInjected.Address(RVA = "0x15F8840", Offset = "0x15F7240", VA = "0x1815F8840")]
		private void UpdateOnOpen()
		{
			//Discarded unreachable code: IL_0018, IL_001e, IL_0024
			List<GameObject> list = hideOnOpen;
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D17")]
		[Cpp2IlInjected.Address(RVA = "0x15F7020", Offset = "0x15F5A20", VA = "0x1815F7020")]
		private void OnFinished()
		{
			IsOpening = false;
			this.OnOvershootFinished?.Invoke();
			IsDone = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D18")]
		[Cpp2IlInjected.Address(RVA = "0x15F64F0", Offset = "0x15F4EF0", VA = "0x1815F64F0")]
		public unsafe void Close()
		{
			//Discarded unreachable code: IL_0194
			//IL_005f: Expected O, but got I4
			//IL_00c9: Invalid comparison between F4 and I4
			//IL_00e1: Expected O, but got I4
			//IL_0125: Invalid comparison between F4 and I4
			//IL_013d: Expected O, but got I4
			if (isOpened && _isAwaken)
			{
				AK.Wwise.Event @event = closeSfx;
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
				ClipSequence clipSequence = (_transition = new ClipSequence());
				IsClosing = true;
				float num2 = Size();
				SlidingPanelConfig slidingPanelConfig = config;
				int num3 = default(int);
				Tween<float>.InterpolationFunction interpolationFunction = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num3, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
				num3 = 0;
				EasingFunction easingFunction = EasingUtil.EasingFunction(config.closeEasing);
				Tween<float>.UpdateEventHandler updateEventHandler = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePosition);
				Tween<float> tween = default(Tween<float>);
				((Tween<T>)(object)tween).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
				Tween<float>.FinishEventHandler finishEventHandler = (Tween<float>.FinishEventHandler)(object)new Tween<T>.FinishEventHandler(UpdateOnClose);
				((Tween<T>)(object)tween).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
				_transition.Append(tween);
				SlidingPanelConfig slidingPanelConfig2 = config;
				float closeOvershootAmount = slidingPanelConfig2.closeOvershootAmount;
				int num4 = 0;
				if (!(closeOvershootAmount <= (float)num4) && !isHidden)
				{
					int num5 = default(int);
					Tween<float>.InterpolationFunction interpolationFunction2 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num5, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
					num5 = 0;
					EasingFunction easingFunction2 = EasingUtil.EasingFunction(config.closeOvershootEasing);
					Tween<float>.UpdateEventHandler updateEventHandler2 = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePosition);
					Tween<float> tween2 = default(Tween<float>);
					((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler2);
					_transition.Append(tween2);
				}
				if (!(slidingPanelConfig2.closeSettleAmount <= (float)num4) && !isHidden)
				{
					int num6 = default(int);
					Tween<float>.InterpolationFunction interpolationFunction3 = (Tween<float>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num6, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float, float, float>*/)(&Mathf.Lerp));
					num6 = 0;
					EasingFunction easingFunction3 = EasingUtil.EasingFunction(config.closeSettleEasing);
					Tween<float>.UpdateEventHandler updateEventHandler3 = (Tween<float>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdatePosition);
					Tween<float> tween3 = default(Tween<float>);
					((Tween<T>)(object)tween3).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler3);
					_transition.Append(tween3);
				}
				SlidingPanelEvent onClose = this.OnClose;
				isOpened = false;
				onClose?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D19")]
		[Cpp2IlInjected.Address(RVA = "0x15F8510", Offset = "0x15F6F10", VA = "0x1815F8510")]
		private void UpdateOnClose()
		{
			//Discarded unreachable code: IL_0030, IL_0036, IL_003c
			//IL_001c: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (hideOnClose == null || !flag)
				{
					break;
				}
				int num3 = 0;
				if ((UnityEngine.Object)num2 != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					break;
				}
			}
			List<GameObject> list = hideOnOpen;
			bool flag2 = default(bool);
			if (!flag2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D1A")]
		[Cpp2IlInjected.Address(RVA = "0x15F8B80", Offset = "0x15F7580", VA = "0x1815F8B80")]
		private void UpdatePosition(float value, float progress)
		{
			//Discarded unreachable code: IL_0060
			//IL_005f: Expected O, but got I4
			Direction direction = pullInDirection;
			_normalizedValue = value;
			if (direction != 0)
			{
				if (direction != 0)
				{
					switch (direction)
					{
					case Direction.Right:
					{
						Vector2 pivot = _rect.pivot;
						break;
					}
					case Direction.Left:
						break;
					default:
						return;
					}
					Vector2 pivot2 = _rect.pivot;
				}
				Vector2 pivot3 = _rect.pivot;
			}
			RectTransform rect = _rect;
			int num = 0;
			Vector2 pivot4 = rect.pivot;
			rect.pivot = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D1B")]
		[Cpp2IlInjected.Address(RVA = "0x15F84E0", Offset = "0x15F6EE0", VA = "0x1815F84E0")]
		public void Toggle()
		{
			if (IsClosing || IsOpening)
			{
				return;
			}
			if (!isOpened)
			{
				if (isHidden)
				{
					Open();
				}
			}
			else
			{
				Close();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D1C")]
		[Cpp2IlInjected.Address(RVA = "0x15F6F20", Offset = "0x15F5920", VA = "0x1815F6F20", Slot = "4")]
		[AsyncStateMachine(typeof(_003CIntroduce_003Ed__63))]
		public override Task Introduce()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D1D")]
		[Cpp2IlInjected.Address(RVA = "0x15F8D10", Offset = "0x15F7710", VA = "0x1815F8D10")]
		public SlidingPanel()
		{
		}//IL_003d: Expected I4, but got I8

	}
}
