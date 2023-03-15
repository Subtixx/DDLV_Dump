using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000405")]
	[RequiredAllNotNull]
	public class DecalGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000406")]
		public delegate void GizmoDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001407")]
		[SerializeField]
		private RectTransform _btnRotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001408")]
		[SerializeField]
		private RectTransform _btnScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001409")]
		[SerializeField]
		private ToggleButton _btnMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400140A")]
		[SerializeField]
		private ToggleButton _btnColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400140B")]
		public string shownBool = "shown";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400140C")]
		public RectTransform scaleHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400140D")]
		public RectTransform rotateHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400140F")]
		[SerializeField]
		private RectTransform _rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001410")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001411")]
		[SerializeField]
		[Nulllable]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001412")]
		private ISupportsFocusNavigation _focusedElementOrigin;

		[Cpp2IlInjected.Token(Token = "0x17000437")]
		public ToggleButton ModeBtn
		{
			[Cpp2IlInjected.Token(Token = "0x60019DA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _btnMode;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000438")]
		public ToggleButton ColorBtn
		{
			[Cpp2IlInjected.Token(Token = "0x60019DB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _btnColor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000439")]
		public Vector2 Center
		{
			[Cpp2IlInjected.Token(Token = "0x60019DC")]
			[Cpp2IlInjected.Address(RVA = "0x12AB800", Offset = "0x12AA200", VA = "0x1812AB800")]
			get
			{
				//Discarded unreachable code: IL_0009
				RectTransform rect = _rect;
				Vector2 result = default(Vector2);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043A")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x60019DD")]
			[Cpp2IlInjected.Address(RVA = "0x12AB880", Offset = "0x12AA280", VA = "0x1812AB880")]
			get
			{
				//Discarded unreachable code: IL_0009
				RectTransform rect = _rect;
				float result = default(float);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043B")]
		public float Diameter
		{
			[Cpp2IlInjected.Token(Token = "0x60019DE")]
			[Cpp2IlInjected.Address(RVA = "0x12AB840", Offset = "0x12AA240", VA = "0x1812AB840")]
			get
			{
				RectTransform rect = _rect;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x400140E")]
		public bool Shown
		{
			[Cpp2IlInjected.Token(Token = "0x60019DF")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60019E0")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event GizmoDelegate OnGizmoShown
		{
			[Cpp2IlInjected.Token(Token = "0x60019E1")]
			[Cpp2IlInjected.Address(RVA = "0x12AB760", Offset = "0x12AA160", VA = "0x1812AB760")]
			[CompilerGenerated]
			add
			{
				GizmoDelegate onGizmoShown = this.OnGizmoShown;
				Delegate @delegate = Delegate.Combine(onGizmoShown, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onGizmoShown)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60019E2")]
			[Cpp2IlInjected.Address(RVA = "0x12AB970", Offset = "0x12AA370", VA = "0x1812AB970")]
			[CompilerGenerated]
			remove
			{
				GizmoDelegate onGizmoShown = this.OnGizmoShown;
				Delegate @delegate = Delegate.Remove(onGizmoShown, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onGizmoShown)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002E")]
		public event GizmoDelegate OnGizmoHide
		{
			[Cpp2IlInjected.Token(Token = "0x60019E3")]
			[Cpp2IlInjected.Address(RVA = "0x12AB6C0", Offset = "0x12AA0C0", VA = "0x1812AB6C0")]
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
			[Cpp2IlInjected.Token(Token = "0x60019E4")]
			[Cpp2IlInjected.Address(RVA = "0x12AB8D0", Offset = "0x12AA2D0", VA = "0x1812AB8D0")]
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

		[Cpp2IlInjected.Token(Token = "0x60019E5")]
		[Cpp2IlInjected.Address(RVA = "0x12AB460", Offset = "0x12A9E60", VA = "0x1812AB460")]
		public Vector2 ScreenToLocal(Vector2 screenPos)
		{
			RectTransform rect = _rect;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60019E6")]
		[Cpp2IlInjected.Address(RVA = "0x12AB070", Offset = "0x12A9A70", VA = "0x1812AB070")]
		public bool PointIsInMoveZone(Vector2 screenPos)
		{
			if (!Shown)
			{
				int num = 0;
			}
			RectTransform rect = _rect;
			RectTransform rect2 = _rect;
			RectTransform rect3 = _rect;
			float num2 = default(float);
			float num3 = num2 * 0.5f;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019E7")]
		[Cpp2IlInjected.Address(RVA = "0x12AB2B0", Offset = "0x12A9CB0", VA = "0x1812AB2B0")]
		public bool PointIsInScaleZone(Vector2 screenPos)
		{
			//Discarded unreachable code: IL_001e
			RectTransform btnScale = _btnScale;
			if (!Shown)
			{
				int num = 0;
			}
			RectTransform btnScale2 = _btnScale;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60019E8")]
		[Cpp2IlInjected.Address(RVA = "0x12AB1D0", Offset = "0x12A9BD0", VA = "0x1812AB1D0")]
		public bool PointIsInRotateZone(Vector2 screenPos)
		{
			//Discarded unreachable code: IL_001e
			RectTransform btnRotate = _btnRotate;
			if (!Shown)
			{
				int num = 0;
			}
			RectTransform btnRotate2 = _btnRotate;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60019E9")]
		[Cpp2IlInjected.Address(RVA = "0x12AB620", Offset = "0x12AA020", VA = "0x1812AB620")]
		public void Show()
		{
			//Discarded unreachable code: IL_002b
			Shown = true;
			_content.gameObject.SetActive(value: true);
			this.OnGizmoShown?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60019EA")]
		[Cpp2IlInjected.Address(RVA = "0x12AAF60", Offset = "0x12A9960", VA = "0x1812AAF60")]
		public void Hide()
		{
			//IL_0045: Expected O, but got I4
			Shown = false;
			StopAllCoroutines();
			GameObject gameObject = _content.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			this.OnGizmoHide?.Invoke();
			FocusNavigation focusNavigation = _focusNavigation;
			int num = 0;
			if (focusNavigation != (UnityEngine.Object)num)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
				FocusNavigation focusNavigation2 = _focusNavigation;
				if (!flag)
				{
					ISupportsFocusNavigation supportsFocusNavigation = (focusNavigation2.FocusedElement = _focusedElementOrigin);
				}
				ISupportsFocusNavigation focusedElementOrigin2 = _focusedElementOrigin;
				focusNavigation2.SetFocus(focusedElementOrigin2);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019EB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		internal void SetFocus()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60019EC")]
		[Cpp2IlInjected.Address(RVA = "0x12AB390", Offset = "0x12A9D90", VA = "0x1812AB390")]
		internal void RemoveFocus()
		{
			//IL_0010: Expected O, but got I4
			FocusNavigation focusNavigation = _focusNavigation;
			int num = 0;
			if (focusNavigation != (UnityEngine.Object)num)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
				FocusNavigation focusNavigation2 = _focusNavigation;
				if (flag)
				{
					goto IL_0049;
				}
				ISupportsFocusNavigation supportsFocusNavigation = (focusNavigation2.FocusedElement = _focusedElementOrigin);
			}
			int num3 = 0;
			goto IL_0049;
			IL_0049:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019ED")]
		[Cpp2IlInjected.Address(RVA = "0x12AAE90", Offset = "0x12A9890", VA = "0x1812AAE90")]
		public void HideForSeconds(float seconds)
		{
			//Discarded unreachable code: IL_0045
			StopAllCoroutines();
			GameObject gameObject = _content.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			if (Shown)
			{
				int _003C_003E1__state = default(int);
				_003CShowAfterDelay_003Ed__41 _003CShowAfterDelay_003Ed__ = new _003CShowAfterDelay_003Ed__41(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CShowAfterDelay_003Ed__._003C_003E4__this = this;
				_003CShowAfterDelay_003Ed__.seconds = seconds;
				Coroutine coroutine = StartCoroutine(_003CShowAfterDelay_003Ed__);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019EE")]
		[Cpp2IlInjected.Address(RVA = "0x12AB5A0", Offset = "0x12A9FA0", VA = "0x1812AB5A0")]
		[IteratorStateMachine(typeof(_003CShowAfterDelay_003Ed__41))]
		private IEnumerator ShowAfterDelay(float seconds)
		{
			int _003C_003E1__state = default(int);
			_003CShowAfterDelay_003Ed__41 _003CShowAfterDelay_003Ed__ = new _003CShowAfterDelay_003Ed__41(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowAfterDelay_003Ed__._003C_003E4__this = this;
			_003CShowAfterDelay_003Ed__.seconds = seconds;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019EF")]
		[Cpp2IlInjected.Address(RVA = "0x12AB4F0", Offset = "0x12A9EF0", VA = "0x1812AB4F0")]
		public void SetPosition(Vector3 worldPos)
		{
			//Discarded unreachable code: IL_0020
			int num = 0;
			Camera main = Camera.main;
			float z = worldPos.z;
			RectTransform rect = _rect;
			RectTransform rect2 = _rect;
		}

		[Cpp2IlInjected.Token(Token = "0x60019F0")]
		[Cpp2IlInjected.Address(RVA = "0x12AAE30", Offset = "0x12A9830", VA = "0x1812AAE30")]
		public void DeselectColorToggle()
		{
			//Discarded unreachable code: IL_0011
			ToggleButton btnColor = _btnColor;
			int num = ((btnColor.IsOn = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60019F1")]
		[Cpp2IlInjected.Address(RVA = "0x12AAE60", Offset = "0x12A9860", VA = "0x1812AAE60")]
		public void DeselectModeToggle()
		{
			//Discarded unreachable code: IL_0011
			ToggleButton btnMode = _btnMode;
			int num = ((btnMode.IsOn = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60019F2")]
		[Cpp2IlInjected.Address(RVA = "0x12AB670", Offset = "0x12AA070", VA = "0x1812AB670")]
		public DecalGizmo()
		{
		}
	}
}
