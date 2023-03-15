using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using LeoLuz;
using UnityEngine;

namespace Mdl.Ui.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x200095D")]
	public class VirtualJoystick : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200095E")]
		public delegate void OnJoystickChangeStateDelegate(bool active);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037B0")]
		[InputAxesListDropdown(false)]
		public string horizontalAxis = "Horizontal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037B1")]
		[InputAxesListDropdown(false)]
		public string verticalAxis = "Vertical";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40037B2")]
		public float sensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40037B3")]
		public float knobReturnSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40037B4")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40037B5")]
		public bool useRightClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40037B6")]
		public Transform center3DTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40037B8")]
		public RectTransform knob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40037B9")]
		public RectTransform knobAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40037BA")]
		public RectTransform knobBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40037BB")]
		public RectTransform inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40037BC")]
		public RectTransform raycastZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40037BD")]
		public GameObject blocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40037BE")]
		private Vector2 _knobStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40037BF")]
		private Vector3 _knobDefaultPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40037C0")]
		private bool _isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40037C1")]
		private Vector2 _lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40037C2")]
		private float _sqrDistance;

		[Cpp2IlInjected.Token(Token = "0x17000808")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40037B7")]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6003B06")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003B07")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400007B")]
		public event OnJoystickChangeStateDelegate OnJoystickChangeState
		{
			[Cpp2IlInjected.Token(Token = "0x6003B08")]
			[Cpp2IlInjected.Address(RVA = "0x14D7960", Offset = "0x14D6360", VA = "0x1814D7960")]
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
			[Cpp2IlInjected.Token(Token = "0x6003B09")]
			[Cpp2IlInjected.Address(RVA = "0x14D7A00", Offset = "0x14D6400", VA = "0x1814D7A00")]
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

		[Cpp2IlInjected.Token(Token = "0x6003B0A")]
		[Cpp2IlInjected.Address(RVA = "0x14D6B40", Offset = "0x14D5540", VA = "0x1814D6B40")]
		private unsafe void Awake()
		{
			//Discarded unreachable code: IL_0055
			//IL_0020: Expected O, but got I4
			//IL_0040: Expected F4, but got I4
			//IL_003b: Expected native int or pointer, but got O
			//IL_0054: Expected F4, but got I4
			//IL_004f: Expected native int or pointer, but got O
			GameObject gameObject = blocker;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			RectTransform rectTransform = knob;
			int num = 0;
			if (rectTransform != (UnityEngine.Object)num)
			{
				Vector2 anchoredPosition = knob.anchoredPosition;
				int num2 = 0;
				((Vector3*)(IntPtr)_knobDefaultPos)->z = num2;
				_knobStartPos = anchoredPosition;
				((Vector2*)(IntPtr)_knobStartPos)->y = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B0B")]
		[Cpp2IlInjected.Address(RVA = "0x14D6DA0", Offset = "0x14D57A0", VA = "0x1814D6DA0")]
		private void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003B0C")]
		[Cpp2IlInjected.Address(RVA = "0x14D6C20", Offset = "0x14D5620", VA = "0x1814D6C20")]
		private Vector2 LocalPos()
		{
			RectTransform rectTransform = inputZone;
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B0D")]
		[Cpp2IlInjected.Address(RVA = "0x14D6CE0", Offset = "0x14D56E0", VA = "0x1814D6CE0")]
		public void Release()
		{
			//Discarded unreachable code: IL_0070
			//IL_0010: Expected F4, but got I4
			//IL_0020: Expected F4, but got I4
			string text = horizontalAxis;
			int num = 0;
			Input.SetAxisMobile(text, num);
			string text2 = verticalAxis;
			int num2 = 0;
			Input.SetAxisMobile(text2, num2);
			if (IsActive)
			{
				OnJoystickChangeStateDelegate onJoystickChangeState = this.OnJoystickChangeState;
				if (onJoystickChangeState != null)
				{
					int active = 0;
					onJoystickChangeState((byte)active != 0);
				}
				GameObject gameObject = blocker;
				IsActive = false;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
			}
			_isValid = false;
			_sqrDistance = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B0E")]
		[Cpp2IlInjected.Address(RVA = "0x14D7890", Offset = "0x14D6290", VA = "0x1814D7890")]
		public unsafe VirtualJoystick()
		{
			//IL_0049: Expected F4, but got I4
			//IL_0044: Expected native int or pointer, but got O
			//IL_005f: Expected F4, but got I4
			//IL_005a: Expected native int or pointer, but got O
			int num = 0;
			sensitivity = 60f;
			knobReturnSpeed = 10f;
			Vector2 zero = Vector2.zero;
			int num2 = 0;
			_knobStartPos = zero;
			((Vector2*)(IntPtr)_knobStartPos)->y = 0f;
			Vector2 zero2 = Vector2.zero;
			((Vector3*)(IntPtr)_knobDefaultPos)->z = 0f;
			base._002Ector();
		}
	}
}
