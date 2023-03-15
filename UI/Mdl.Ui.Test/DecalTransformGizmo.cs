using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000920")]
	public class DecalTransformGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000921")]
		public delegate void ConfirmDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40035E6")]
		[SerializeField]
		private Button _confirm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40035E7")]
		[SerializeField]
		private RectTransform _scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40035E8")]
		[SerializeField]
		private RectTransform _rotate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40035E9")]
		public string shownBool = "shown";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40035EB")]
		private bool _shown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40035EC")]
		private RectTransform _rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40035ED")]
		private Animator _animator;

		[Cpp2IlInjected.Token(Token = "0x170007EB")]
		public Vector2 Center
		{
			[Cpp2IlInjected.Token(Token = "0x600396A")]
			[Cpp2IlInjected.Address(RVA = "0x12B7C20", Offset = "0x12B6620", VA = "0x1812B7C20")]
			get
			{
				//Discarded unreachable code: IL_0009
				RectTransform rect = _rect;
				Vector2 result = default(Vector2);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007EC")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x600396B")]
			[Cpp2IlInjected.Address(RVA = "0x12B7CA0", Offset = "0x12B66A0", VA = "0x1812B7CA0")]
			get
			{
				//Discarded unreachable code: IL_0009
				RectTransform rect = _rect;
				float result = default(float);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007ED")]
		public float Diameter
		{
			[Cpp2IlInjected.Token(Token = "0x600396C")]
			[Cpp2IlInjected.Address(RVA = "0x12B7C60", Offset = "0x12B6660", VA = "0x1812B7C60")]
			get
			{
				RectTransform rect = _rect;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000073")]
		public event ConfirmDelegate OnConfirm
		{
			[Cpp2IlInjected.Token(Token = "0x6003968")]
			[Cpp2IlInjected.Address(RVA = "0x12B7B80", Offset = "0x12B6580", VA = "0x1812B7B80")]
			[CompilerGenerated]
			add
			{
				ConfirmDelegate onConfirm = this.OnConfirm;
				Delegate @delegate = Delegate.Combine(onConfirm, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConfirm)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003969")]
			[Cpp2IlInjected.Address(RVA = "0x12B7CF0", Offset = "0x12B66F0", VA = "0x1812B7CF0")]
			[CompilerGenerated]
			remove
			{
				ConfirmDelegate onConfirm = this.OnConfirm;
				Delegate @delegate = Delegate.Remove(onConfirm, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConfirm)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600396D")]
		[Cpp2IlInjected.Address(RVA = "0x12B7A40", Offset = "0x12B6440", VA = "0x1812B7A40")]
		private void Start()
		{
			//Discarded unreachable code: IL_003d
			RectTransform rectTransform = (_rect = GetComponent<RectTransform>());
			Animator animator = (_animator = GetComponent<Animator>());
			Button.ButtonClickedEvent onClick = _confirm.m_OnClick;
			UnityAction call = Confirm;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x600396E")]
		[Cpp2IlInjected.Address(RVA = "0x12B77F0", Offset = "0x12B61F0", VA = "0x1812B77F0")]
		public Vector2 ScreenToLocal(Vector2 screenPos)
		{
			RectTransform rect = _rect;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600396F")]
		[Cpp2IlInjected.Address(RVA = "0x12B7550", Offset = "0x12B5F50", VA = "0x1812B7550")]
		public bool PointIsInMoveZone(Vector2 screenPos)
		{
			if (!_shown)
			{
				int num = 0;
			}
			Vector2 vector = ScreenToLocal(screenPos);
			RectTransform rect = _rect;
			RectTransform rect2 = _rect;
			float num2 = default(float);
			float num3 = num2 * 0.5f;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003970")]
		[Cpp2IlInjected.Address(RVA = "0x12B7710", Offset = "0x12B6110", VA = "0x1812B7710")]
		public bool PointIsInScaleZone(Vector2 screenPos)
		{
			//Discarded unreachable code: IL_001e
			RectTransform scale = _scale;
			if (!_shown)
			{
				int num = 0;
			}
			RectTransform scale2 = _scale;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003971")]
		[Cpp2IlInjected.Address(RVA = "0x12B7630", Offset = "0x12B6030", VA = "0x1812B7630")]
		public bool PointIsInRotateZone(Vector2 screenPos)
		{
			//Discarded unreachable code: IL_001e
			RectTransform rotate = _rotate;
			if (!_shown)
			{
				int num = 0;
			}
			RectTransform rotate2 = _rotate;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003972")]
		[Cpp2IlInjected.Address(RVA = "0x12B79B0", Offset = "0x12B63B0", VA = "0x1812B79B0")]
		public void Show()
		{
			//Discarded unreachable code: IL_0031
			//IL_0017: Expected O, but got I4
			Animator animator = _animator;
			_shown = true;
			int num = 0;
			if (animator != (UnityEngine.Object)num)
			{
				Animator animator2 = _animator;
				string text = shownBool;
				animator2.SetBool(text, value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003973")]
		[Cpp2IlInjected.Address(RVA = "0x12B74B0", Offset = "0x12B5EB0", VA = "0x1812B74B0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_003b
			//IL_001d: Expected O, but got I4
			_shown = false;
			StopAllCoroutines();
			Animator animator = _animator;
			int num = 0;
			if (animator != (UnityEngine.Object)num)
			{
				Animator animator2 = _animator;
				string text = shownBool;
				int value = 0;
				animator2.SetBool(text, (byte)value != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003974")]
		[Cpp2IlInjected.Address(RVA = "0x12B73A0", Offset = "0x12B5DA0", VA = "0x1812B73A0")]
		public void HideForSeconds(float seconds)
		{
			//Discarded unreachable code: IL_0063
			//IL_0016: Expected O, but got I4
			StopAllCoroutines();
			Animator animator = _animator;
			int num = 0;
			if (animator != (UnityEngine.Object)num)
			{
				Animator animator2 = _animator;
				string text = shownBool;
				int value = 0;
				animator2.SetBool(text, (byte)value != 0);
			}
			if (_shown)
			{
				int _003C_003E1__state = default(int);
				_003CShowAfterDelay_003Ed__25 _003CShowAfterDelay_003Ed__ = new _003CShowAfterDelay_003Ed__25(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CShowAfterDelay_003Ed__._003C_003E4__this = this;
				_003CShowAfterDelay_003Ed__.seconds = seconds;
				Coroutine coroutine = StartCoroutine(_003CShowAfterDelay_003Ed__);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003975")]
		[Cpp2IlInjected.Address(RVA = "0x12B7930", Offset = "0x12B6330", VA = "0x1812B7930")]
		[IteratorStateMachine(typeof(_003CShowAfterDelay_003Ed__25))]
		private IEnumerator ShowAfterDelay(float seconds)
		{
			int _003C_003E1__state = default(int);
			_003CShowAfterDelay_003Ed__25 _003CShowAfterDelay_003Ed__ = new _003CShowAfterDelay_003Ed__25(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShowAfterDelay_003Ed__._003C_003E4__this = this;
			_003CShowAfterDelay_003Ed__.seconds = seconds;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003976")]
		[Cpp2IlInjected.Address(RVA = "0x12B7880", Offset = "0x12B6280", VA = "0x1812B7880")]
		public void SetPosition(Vector3 worldPos)
		{
			//Discarded unreachable code: IL_0020
			int num = 0;
			Camera main = Camera.main;
			float z = worldPos.z;
			RectTransform rect = _rect;
			RectTransform rect2 = _rect;
		}

		[Cpp2IlInjected.Token(Token = "0x6003977")]
		[Cpp2IlInjected.Address(RVA = "0xF182E0", Offset = "0xF16CE0", VA = "0x180F182E0")]
		private void Confirm()
		{
			this.OnConfirm?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6003978")]
		[Cpp2IlInjected.Address(RVA = "0x12B7B30", Offset = "0x12B6530", VA = "0x1812B7B30")]
		public DecalTransformGizmo()
		{
		}
	}
}
