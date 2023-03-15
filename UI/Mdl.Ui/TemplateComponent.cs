using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	public class TemplateComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private Coroutine _intervalCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public bool UseInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		[Range(0.1f, 100f)]
		public float Interval = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public Vector2 AnchoredPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public UnityEvent OnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public UnityEvent OnEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public UnityEvent OnDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public UnityEvent OnInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public UnityEvent OnActivate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public UnityEvent OnDeactivate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public UnityEvent OnRefresh;

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x17E8980", Offset = "0x17E7380", VA = "0x1817E8980")]
		private void Start()
		{
			OnStart?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x17E87A0", Offset = "0x17E71A0", VA = "0x1817E87A0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_003a
			OnEnabled?.Invoke();
			if (UseInterval)
			{
				int _003C_003E1__state = default(int);
				_003CStartCoroutine_003Ed__17 _003CStartCoroutine_003Ed__ = new _003CStartCoroutine_003Ed__17(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CStartCoroutine_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = (_intervalCoroutine = StartCoroutine(_003CStartCoroutine_003Ed__));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x17E8750", Offset = "0x17E7150", VA = "0x1817E8750")]
		private void OnDisable()
		{
			//IL_002c: Expected O, but got I8
			OnDisabled?.Invoke();
			Coroutine intervalCoroutine = _intervalCoroutine;
			if (intervalCoroutine != null)
			{
				StopCoroutine(intervalCoroutine);
				_intervalCoroutine = (Coroutine)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x17E86C0", Offset = "0x17E70C0", VA = "0x1817E86C0")]
		public void CopyFrom(GameObject target)
		{
			//Discarded unreachable code: IL_001d
			GameObjectTemplate gameObjectTemplate = new GameObjectTemplate();
			gameObjectTemplate.Save(target);
			GameObject gameObject = base.gameObject;
			gameObjectTemplate.Load(gameObject, ignoreParent: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0x17E88B0", Offset = "0x17E72B0", VA = "0x1817E88B0")]
		public void SetActive(bool active)
		{
			if (!active)
			{
			}
			OnActivate?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x1007330", Offset = "0x1005D30", VA = "0x181007330")]
		public void Refresh()
		{
			OnRefresh?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x17E8910", Offset = "0x17E7310", VA = "0x1817E8910")]
		[IteratorStateMachine(typeof(_003CStartCoroutine_003Ed__17))]
		private IEnumerator StartCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CStartCoroutine_003Ed__17 _003CStartCoroutine_003Ed__ = new _003CStartCoroutine_003Ed__17(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CStartCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(RVA = "0x17E8840", Offset = "0x17E7240", VA = "0x1817E8840")]
		public void RebuildLayout(GameObject gameObject)
		{
			//Discarded unreachable code: IL_0011
			Transform transform = gameObject.transform;
			if ((object)transform != null && (object)transform == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x17E88D0", Offset = "0x17E72D0", VA = "0x1817E88D0")]
		public void SetPosition(RectTransform rt)
		{
			//Discarded unreachable code: IL_001b
			Vector2 anchoredPosition = AnchoredPosition;
			float y = AnchoredPosition.y;
			rt.anchoredPosition = anchoredPosition;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x17E89A0", Offset = "0x17E73A0", VA = "0x1817E89A0")]
		public TemplateComponent()
		{
		}
	}
}
