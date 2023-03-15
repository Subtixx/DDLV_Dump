using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007C6")]
	public static class TaskCoroutineExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600228A")]
		[Cpp2IlInjected.Address(RVA = "0x106F740", Offset = "0x106E140", VA = "0x18106F740")]
		[IteratorStateMachine(typeof(_003CAsIEnumerator_003Ed__0))]
		public static IEnumerator AsIEnumerator(this Task task)
		{
			int _003C_003E1__state = default(int);
			_003CAsIEnumerator_003Ed__0 _003CAsIEnumerator_003Ed__ = new _003CAsIEnumerator_003Ed__0(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CAsIEnumerator_003Ed__.task = task;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600228B")]
		[Cpp2IlInjected.Address(RVA = "0x106F880", Offset = "0x106E280", VA = "0x18106F880")]
		[AsyncStateMachine(typeof(_003CStartCoroutineAsync_003Ed__1))]
		public static Task StartCoroutineAsync(this MonoBehaviour monoBehaviour, IEnumerator coroutine, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600228C")]
		[Cpp2IlInjected.Address(RVA = "0x106F7B0", Offset = "0x106E1B0", VA = "0x18106F7B0")]
		[IteratorStateMachine(typeof(_003CCoroutine_003Ed__2))]
		private static IEnumerator Coroutine(IEnumerator coroutine, Action p)
		{
			int _003C_003E1__state = default(int);
			_003CCoroutine_003Ed__2 _003CCoroutine_003Ed__ = new _003CCoroutine_003Ed__2(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCoroutine_003Ed__.coroutine = coroutine;
			_003CCoroutine_003Ed__.p = p;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600228D")]
		[Cpp2IlInjected.Address(RVA = "0x106F840", Offset = "0x106E240", VA = "0x18106F840")]
		public static bool IsCompletedSuccessfully(this Task task)
		{
			//Discarded unreachable code: IL_0017
			bool isCompleted = task.IsCompleted;
			if (!isCompleted)
			{
				return isCompleted;
			}
			return task.Status == TaskStatus.RanToCompletion;
		}
	}
}
