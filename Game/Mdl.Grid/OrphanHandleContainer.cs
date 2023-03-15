using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200048D")]
	internal class OrphanHandleContainer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CD4")]
		private readonly List<AsyncOperationHandle<GameObject>> _orphanHandles = (List<AsyncOperationHandle<GameObject>>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CD5")]
		private readonly HashSet<GameObject> _orphans = (HashSet<GameObject>)(object)new HashSet<T>();

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public AsyncOperationHandle<GameObject> this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600143B")]
			[Cpp2IlInjected.Address(RVA = "0xF0B080", Offset = "0xF09A80", VA = "0x180F0B080")]
			get
			{
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600143C")]
		[Cpp2IlInjected.Address(RVA = "0xF0AC10", Offset = "0xF09610", VA = "0x180F0AC10")]
		public int FindIndex(Predicate<AsyncOperationHandle<GameObject>> match)
		{
			//Discarded unreachable code: IL_000d
			return ((List<T>)(object)_orphanHandles).FindIndex((Predicate<>)(object)match);
		}

		[Cpp2IlInjected.Token(Token = "0x600143D")]
		[Cpp2IlInjected.Address(RVA = "0xF0AAD0", Offset = "0xF094D0", VA = "0x180F0AAD0")]
		public unsafe int FindIndex(GameObject go)
		{
			HashSet<GameObject> orphans = _orphans;
			GameObject item = go;
			if (!((HashSet<T>)(object)orphans).Contains((T)item))
			{
				return -1;
			}
			Predicate<AsyncOperationHandle<GameObject>> predicate = (Predicate<AsyncOperationHandle<GameObject>>)(object)(Predicate<T>)delegate(AsyncOperationHandle<GameObject> x)
			{
				GameObject result = (GameObject)((AsyncOperationHandle<TObject>*)x)->Result;
				GameObject gameObject = go;
				return result == gameObject;
			};
			int num = ((List<T>)(object)_orphanHandles).FindIndex((Predicate<>)(object)predicate);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600143E")]
		[Cpp2IlInjected.Address(RVA = "0xF0A960", Offset = "0xF09360", VA = "0x180F0A960")]
		public unsafe void Add(AsyncOperationHandle<GameObject> handle)
		{
			if (((AsyncOperationHandle<TObject>*)handle)->IsDone)
			{
				List<AsyncOperationHandle<GameObject>> orphanHandles = _orphanHandles;
				HashSet<GameObject> orphans = _orphans;
				GameObject result = (GameObject)((AsyncOperationHandle<TObject>*)handle)->Result;
				bool flag = ((HashSet<T>)(object)orphans).Add((T)result);
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("An optimization made in OrphanHandleContainer needs the operation handle to be done in order to work. If this can no longer be guaranteed, then the optimization needs to be removed or reworked");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600143F")]
		[Cpp2IlInjected.Address(RVA = "0xF0AC70", Offset = "0xF09670", VA = "0x180F0AC70")]
		public AsyncOperationHandle<GameObject> RemoveAt(int index)
		{
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			int num2 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001440")]
		[Cpp2IlInjected.Address(RVA = "0xF0ADA0", Offset = "0xF097A0", VA = "0x180F0ADA0")]
		public void Remove(GameObject gameObject)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001441")]
		[Cpp2IlInjected.Address(RVA = "0xF0AA80", Offset = "0xF09480", VA = "0x180F0AA80")]
		public void Clear()
		{
			//Discarded unreachable code: IL_000c
			((List<T>)(object)_orphanHandles).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6001442")]
		[Cpp2IlInjected.Address(RVA = "0xF0AFC0", Offset = "0xF099C0", VA = "0x180F0AFC0")]
		public OrphanHandleContainer()
		{
		}
	}
}
