using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C85")]
	[RequireComponent(typeof(Rigidbody), typeof(PlayerTaskCollider))]
	public class PlayerTaskActivator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004620")]
		[SerializeField]
		private float _activationDelay = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4004621")]
		[SerializeField]
		private float _minDotProduct = 0.8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004622")]
		private Coroutine coroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004623")]
		private PlayerTaskCollider playerTaskCollider;

		[Cpp2IlInjected.Token(Token = "0x60039E7")]
		[Cpp2IlInjected.Address(RVA = "0xCAE800", Offset = "0xCAD200", VA = "0x180CAE800")]
		private void Start()
		{
			PlayerTaskCollider playerTaskCollider = (this.playerTaskCollider = GetComponent<PlayerTaskCollider>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039E8")]
		[Cpp2IlInjected.Address(RVA = "0xCAE420", Offset = "0xCACE20", VA = "0x180CAE420")]
		private void OnTriggerEnter(Collider other)
		{
			//Discarded unreachable code: IL_0067
			GameObject gameObject = other.gameObject;
			GameObject _003CgameObject_003Ek__BackingField = SystemRoot.Instance._avatar.gameObject;
			if (gameObject == _003CgameObject_003Ek__BackingField)
			{
				PlayerTaskCollider _003C_003E4__this = playerTaskCollider;
				PlayerTaskCollider._003CGetAllTasks_003Ed__11 _003CGetAllTasks_003Ed__ = new PlayerTaskCollider._003CGetAllTasks_003Ed__11(-2);
				_003CGetAllTasks_003Ed__._003C_003E4__this = _003C_003E4__this;
				if (Enumerable.Any<PlayerTaskDefinition>((IEnumerable<>)(object)_003CGetAllTasks_003Ed__))
				{
					int _003C_003E1__state = default(int);
					_003CShouldQueueTask_003Ed__7 _003CShouldQueueTask_003Ed__ = new _003CShouldQueueTask_003Ed__7(_003C_003E1__state);
					_003C_003E1__state = 0;
					_003CShouldQueueTask_003Ed__._003C_003E4__this = this;
					Coroutine coroutine = (this.coroutine = StartCoroutine(_003CShouldQueueTask_003Ed__));
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039E9")]
		[Cpp2IlInjected.Address(RVA = "0xCAE640", Offset = "0xCAD040", VA = "0x180CAE640")]
		private void OnTriggerExit(Collider other)
		{
			//Discarded unreachable code: IL_003d
			//IL_003c: Expected O, but got I8
			GameObject gameObject = other.gameObject;
			GameObject _003CgameObject_003Ek__BackingField = SystemRoot.Instance._avatar.gameObject;
			if (gameObject == _003CgameObject_003Ek__BackingField)
			{
				Coroutine coroutine = this.coroutine;
				if (coroutine != null)
				{
					StopCoroutine(coroutine);
				}
				this.coroutine = (Coroutine)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039EA")]
		[Cpp2IlInjected.Address(RVA = "0xCAE790", Offset = "0xCAD190", VA = "0x180CAE790")]
		[IteratorStateMachine(typeof(_003CShouldQueueTask_003Ed__7))]
		private IEnumerator ShouldQueueTask()
		{
			int _003C_003E1__state = default(int);
			_003CShouldQueueTask_003Ed__7 _003CShouldQueueTask_003Ed__ = new _003CShouldQueueTask_003Ed__7(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CShouldQueueTask_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039EB")]
		[Cpp2IlInjected.Address(RVA = "0xCAE850", Offset = "0xCAD250", VA = "0x180CAE850")]
		public PlayerTaskActivator()
		{
		}
	}
}
