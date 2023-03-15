using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009C8")]
	public class Tab : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20009C9")]
		public delegate void Select();

		[Cpp2IlInjected.Token(Token = "0x20009CA")]
		public delegate void Deselect();

		[Cpp2IlInjected.Token(Token = "0x20009CB")]
		public delegate void Clicked();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400399C")]
		public Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400399D")]
		public GameObject unselected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400399E")]
		public GameObject selected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400399F")]
		public GameObject hover;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40039A0")]
		public GameObject hoverSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40039A1")]
		public SpriteAtlasImage icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40039A2")]
		public Transform AnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40039A6")]
		private float _oY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40039A7")]
		private float _oX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40039A8")]
		[SerializeField]
		public GameObject mc_greyOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40039A9")]
		public float greyOutAlpha = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40039AA")]
		public bool useDeselect = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7D")]
		[Cpp2IlInjected.Token(Token = "0x40039AB")]
		private bool _isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
		[Cpp2IlInjected.Token(Token = "0x40039AC")]
		private bool _isHover;

		[Cpp2IlInjected.Token(Token = "0x17000860")]
		public bool IsOn
		{
			[Cpp2IlInjected.Token(Token = "0x6003D37")]
			[Cpp2IlInjected.Address(RVA = "0x823D90", Offset = "0x822790", VA = "0x180823D90")]
			get
			{
				return _isOn;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D38")]
			[Cpp2IlInjected.Address(RVA = "0x17E4E70", Offset = "0x17E3870", VA = "0x1817E4E70")]
			set
			{
				_isOn = value;
				UpdateState();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000861")]
		public bool IsHover
		{
			[Cpp2IlInjected.Token(Token = "0x6003D39")]
			[Cpp2IlInjected.Address(RVA = "0x15579C0", Offset = "0x15563C0", VA = "0x1815579C0")]
			get
			{
				return _isHover;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D3A")]
			[Cpp2IlInjected.Address(RVA = "0x17E4E60", Offset = "0x17E3860", VA = "0x1817E4E60")]
			set
			{
				_isHover = value;
				UpdateState();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000089")]
		public event Select OnSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6003D31")]
			[Cpp2IlInjected.Address(RVA = "0x17E4BE0", Offset = "0x17E35E0", VA = "0x1817E4BE0")]
			[CompilerGenerated]
			add
			{
				Select onSelect = this.OnSelect;
				Delegate @delegate = Delegate.Combine(onSelect, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSelect)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D32")]
			[Cpp2IlInjected.Address(RVA = "0x17E4DC0", Offset = "0x17E37C0", VA = "0x1817E4DC0")]
			[CompilerGenerated]
			remove
			{
				Select onSelect = this.OnSelect;
				Delegate @delegate = Delegate.Remove(onSelect, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSelect)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008A")]
		public event Deselect OnDeselect
		{
			[Cpp2IlInjected.Token(Token = "0x6003D33")]
			[Cpp2IlInjected.Address(RVA = "0x17E4B40", Offset = "0x17E3540", VA = "0x1817E4B40")]
			[CompilerGenerated]
			add
			{
				Deselect onDeselect = this.OnDeselect;
				Delegate @delegate = Delegate.Combine(onDeselect, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDeselect)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D34")]
			[Cpp2IlInjected.Address(RVA = "0x17E4D20", Offset = "0x17E3720", VA = "0x1817E4D20")]
			[CompilerGenerated]
			remove
			{
				Deselect onDeselect = this.OnDeselect;
				Delegate @delegate = Delegate.Remove(onDeselect, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDeselect)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008B")]
		public event Clicked OnClicked
		{
			[Cpp2IlInjected.Token(Token = "0x6003D35")]
			[Cpp2IlInjected.Address(RVA = "0x17E4AA0", Offset = "0x17E34A0", VA = "0x1817E4AA0")]
			[CompilerGenerated]
			add
			{
				Clicked onClicked = this.OnClicked;
				Delegate @delegate = Delegate.Combine(onClicked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onClicked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003D36")]
			[Cpp2IlInjected.Address(RVA = "0x17E4C80", Offset = "0x17E3680", VA = "0x1817E4C80")]
			[CompilerGenerated]
			remove
			{
				Clicked onClicked = this.OnClicked;
				Delegate @delegate = Delegate.Remove(onClicked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onClicked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3B")]
		[Cpp2IlInjected.Address(RVA = "0x17E3F70", Offset = "0x17E2970", VA = "0x1817E3F70")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0053
			//IL_0030: Expected O, but got I4
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			UnityAction call = OnClick;
			onClick.AddListener(call);
			Transform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				Transform animatedContent2 = AnimatedContent;
				Transform animatedContent3 = AnimatedContent;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
			UpdateState();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3C")]
		[Cpp2IlInjected.Address(RVA = "0x17E4380", Offset = "0x17E2D80", VA = "0x1817E4380")]
		private void OnClick()
		{
			if (!_isOn)
			{
				goto IL_0030;
			}
			if (useDeselect)
			{
				_isOn = false;
				UpdateState();
				Deselect onDeselect = this.OnDeselect;
				if (onDeselect != null)
				{
					onDeselect();
					goto IL_0030;
				}
			}
			goto IL_004e;
			IL_004e:
			this.OnClicked?.Invoke();
			return;
			IL_0030:
			_isOn = true;
			UpdateState();
			this.OnSelect?.Invoke();
			goto IL_004e;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3D")]
		[Cpp2IlInjected.Address(RVA = "0x17E46B0", Offset = "0x17E30B0", VA = "0x1817E46B0")]
		public void ResetState()
		{
			//Discarded unreachable code: IL_00fb
			//IL_0010: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			GameObject gameObject = unselected;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				GameObject gameObject2 = unselected;
				int active = 0;
				gameObject2.SetActive((byte)active != 0);
			}
			GameObject gameObject3 = selected;
			int num2 = 0;
			if (gameObject3 != (UnityEngine.Object)num2)
			{
				GameObject gameObject4 = selected;
				int active2 = 0;
				gameObject4.SetActive((byte)active2 != 0);
			}
			GameObject gameObject5 = hover;
			int num3 = 0;
			if (gameObject5 != (UnityEngine.Object)num3)
			{
				GameObject gameObject6 = hover;
				int active3 = 0;
				gameObject6.SetActive((byte)active3 != 0);
			}
			GameObject gameObject7 = hoverSelected;
			int num4 = 0;
			if (gameObject7 != (UnityEngine.Object)num4)
			{
				GameObject gameObject8 = hoverSelected;
				int active4 = 0;
				gameObject8.SetActive((byte)active4 != 0);
			}
			Transform animatedContent = AnimatedContent;
			int num5 = 0;
			if (animatedContent != (UnityEngine.Object)num5 && !button.enabled)
			{
				Transform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num6 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				Transform animatedContent3 = AnimatedContent;
				float oX = _oX;
				float oY = _oY;
				int num7 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3E")]
		[Cpp2IlInjected.Address(RVA = "0x17E48D0", Offset = "0x17E32D0", VA = "0x1817E48D0")]
		private void UpdateState()
		{
			//Discarded unreachable code: IL_00d0
			//IL_0036: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_00a0: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			ResetState();
			if (button.enabled && _isOn && !_isHover)
			{
				GameObject gameObject = selected;
				int num = 0;
				if (!(gameObject != (UnityEngine.Object)num))
				{
				}
			}
			if (button.enabled && !_isOn && _isHover)
			{
				GameObject gameObject2 = hover;
				int num2 = 0;
				if (!(gameObject2 != (UnityEngine.Object)num2))
				{
				}
			}
			if (button.enabled && _isOn && _isHover)
			{
				GameObject gameObject3 = hoverSelected;
				int num3 = 0;
				if (!(gameObject3 != (UnityEngine.Object)num3))
				{
				}
			}
			GameObject gameObject4 = unselected;
			int num4 = 0;
			if (gameObject4 != (UnityEngine.Object)num4)
			{
				unselected?.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3F")]
		[Cpp2IlInjected.Address(RVA = "0x17E3D10", Offset = "0x17E2710", VA = "0x1817E3D10")]
		public void AnimateOnHighlightAdd(bool horizontally = true)
		{
			//Discarded unreachable code: IL_008c
			//IL_0028: Expected O, but got I4
			if (!button.enabled)
			{
				return;
			}
			Transform animatedContent = AnimatedContent;
			_isHover = true;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				Transform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				Transform animatedContent3 = AnimatedContent;
				int num3 = 0;
				if (!horizontally)
				{
					float oY = _oY;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(animatedContent3, oY, 0.2f, (byte)num3 != 0);
				}
				float oX = _oX;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(animatedContent3, oX, 0.2f, (byte)num3 != 0)).Play();
			}
			UpdateState();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D40")]
		[Cpp2IlInjected.Address(RVA = "0x17E3E60", Offset = "0x17E2860", VA = "0x1817E3E60")]
		public void AnimateOnHighlightRemove(bool horizontally = true)
		{
			//IL_004f: Expected F4, but got I4
			//IL_0066: Expected F4, but got I4
			Transform animatedContent = AnimatedContent;
			_isHover = false;
			if ((bool)animatedContent)
			{
				Transform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num = DOTween.Kill(animatedContent2, (byte)complete != 0);
				Transform animatedContent3 = AnimatedContent;
				int num2 = 0;
				int num3 = 0;
				if (!horizontally)
				{
					float oY = _oY;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = (TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(animatedContent3, oY, (float)num3, (byte)num2 != 0);
				}
				float oX = _oX;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveX(animatedContent3, oX, (float)num3, (byte)num2 != 0)).Play();
			}
			UpdateState();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D41")]
		[Cpp2IlInjected.Address(RVA = "0x17E4550", Offset = "0x17E2F50", VA = "0x1817E4550")]
		public void ResetOnSelectListener()
		{
			Select onSelect = this.OnSelect;
			if (onSelect != null)
			{
				Delegate[] invocationList = onSelect.GetInvocationList();
				int num = 0;
				int num2 = 0;
				int length = invocationList.Length;
				if (num < length)
				{
					if ((object)invocationList[num2] != null)
					{
					}
					Delegate @delegate = default(Delegate);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while (@delegate != this)
						{
						}
						num2++;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D42")]
		[Cpp2IlInjected.Address(RVA = "0x17E43F0", Offset = "0x17E2DF0", VA = "0x1817E43F0")]
		public void ResetOnClickListener()
		{
			Clicked onClicked = this.OnClicked;
			if (onClicked != null)
			{
				Delegate[] invocationList = onClicked.GetInvocationList();
				int num = 0;
				int num2 = 0;
				int length = invocationList.Length;
				if (num < length)
				{
					if ((object)invocationList[num2] != null)
					{
					}
					Delegate @delegate = default(Delegate);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while (@delegate != this)
						{
						}
						num2++;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D43")]
		[Cpp2IlInjected.Address(RVA = "0x17E40B0", Offset = "0x17E2AB0", VA = "0x1817E40B0")]
		public void DisableAndGreyOut()
		{
			//Discarded unreachable code: IL_0079
			//IL_0010: Expected O, but got I4
			GameObject gameObject = mc_greyOut;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				mc_greyOut.gameObject.SetActive(value: true);
			}
			CanvasGroup component = GetComponent<CanvasGroup>();
			float num3 = (component.alpha = greyOutAlpha);
			Button button = this.button;
			int num4 = ((button.enabled = false) ? 1 : 0);
			Selectable selectable = GetComponentInChildren<BaseButton>().Selectable;
			int num5 = ((selectable.interactable = false) ? 1 : 0);
			GetComponentInChildren<FocusNavigationElement>().IgnoreThis = true;
			UpdateState();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D44")]
		[Cpp2IlInjected.Address(RVA = "0x17E4210", Offset = "0x17E2C10", VA = "0x1817E4210")]
		public void EnableAndActivate()
		{
			//Discarded unreachable code: IL_0068
			//IL_0010: Expected O, but got I4
			GameObject gameObject = mc_greyOut;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				GameObject gameObject2 = mc_greyOut.gameObject;
				int active = 0;
				gameObject2.SetActive((byte)active != 0);
			}
			GetComponent<CanvasGroup>().alpha = 1f;
			button.enabled = true;
			GetComponentInChildren<BaseButton>().Selectable.interactable = true;
			GetComponentInChildren<FocusNavigationElement>().IgnoreThis = false;
			UpdateState();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D45")]
		[Cpp2IlInjected.Address(RVA = "0x17E4A80", Offset = "0x17E3480", VA = "0x1817E4A80")]
		public Tab()
		{
		}
	}
}
