using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	public class ToggleButton : BaseButton
	{
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public delegate void OnValueChangedDelegate(bool status);

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		[SerializeField]
		protected SpriteAtlasImage _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		[SerializeField]
		protected SpriteAtlasImage _mcSelectedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		[SerializeField]
		private Material _greyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		[SerializeField]
		protected bool _isOn;

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public bool IsOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0x17F0D70", Offset = "0x17EF770", VA = "0x1817F0D70")]
			get
			{
				return _isOn;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x17F0E20", Offset = "0x17EF820", VA = "0x1817F0E20")]
			set
			{
				if (_isOn != value)
				{
					_isOn = value;
					RefreshSeleced();
					OnValueChangedDelegate onValueChanged = this.OnValueChanged;
					if (onValueChanged != null)
					{
						bool isOn = _isOn;
						onValueChanged(isOn);
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event OnValueChangedDelegate OnValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3E")]
			[Cpp2IlInjected.Address(RVA = "0x17F0C60", Offset = "0x17EF660", VA = "0x1817F0C60")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x17F0D80", Offset = "0x17EF780", VA = "0x1817F0D80")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x17F0BC0", Offset = "0x17EF5C0", VA = "0x1817F0BC0", Slot = "17")]
		public virtual void Start()
		{
			//Discarded unreachable code: IL_0021
			Button.ButtonClickedEvent onClick = base.ButtonComponent.m_OnClick;
			UnityAction call = clicked;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x17F09D0", Offset = "0x17EF3D0", VA = "0x1817F09D0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0021
			Button.ButtonClickedEvent onClick = base.ButtonComponent.m_OnClick;
			UnityAction call = clicked;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x17F0D00", Offset = "0x17EF700", VA = "0x1817F0D00")]
		private void clicked()
		{
			bool isOn = _isOn;
			bool flag = !isOn;
			if (isOn != flag)
			{
				_isOn = flag;
				RefreshSeleced();
				OnValueChangedDelegate onValueChanged = this.OnValueChanged;
				if (onValueChanged != null)
				{
					bool isOn2 = _isOn;
					onValueChanged(isOn2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x17F0A70", Offset = "0x17EF470", VA = "0x1817F0A70", Slot = "18")]
		public virtual void RefreshSeleced()
		{
			//Discarded unreachable code: IL_0083
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			SpriteAtlasImage mcIcon = _mcIcon;
			int num = 0;
			if (mcIcon != (UnityEngine.Object)num)
			{
				Material greyMaterial = _greyMaterial;
				int num2 = 0;
				if (greyMaterial != (UnityEngine.Object)num2)
				{
					Image image = _mcIcon.Image;
					if (_isOn)
					{
					}
					Material material = (image.material = _greyMaterial);
				}
			}
			SpriteAtlasImage mcSelectedIcon = _mcSelectedIcon;
			int num3 = 0;
			if (mcSelectedIcon != (UnityEngine.Object)num3)
			{
				GameObject gameObject = _mcSelectedIcon.gameObject;
				bool isOn = _isOn;
				gameObject.SetActive(isOn);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x855CC0", Offset = "0x8546C0", VA = "0x180855CC0")]
		public ToggleButton()
		{
		}
	}
}
