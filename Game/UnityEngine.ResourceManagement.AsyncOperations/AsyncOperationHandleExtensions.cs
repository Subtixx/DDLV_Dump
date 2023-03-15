using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public static class AsyncOperationHandleExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA45F00", Offset = "0xA44900", VA = "0x180A45F00")]
		public static AsyncOperationHandleAwaiter GetAwaiter(this AsyncOperationHandle resourceRequest)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEA10", VA = "0x1807F0010")]
		public unsafe static AsyncOperationHandleAwaiter<> GetAwaiter<T>(this AsyncOperationHandle<> P_0)
		{
			//IL_000b: Expected O, but got I4
			//IL_0006: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			((AsyncOperationHandle<>*)(IntPtr)P_0)->m_InternalOp = (AsyncOperationBase<TObject>)num2;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA45E90", Offset = "0xA44890", VA = "0x180A45E90")]
		public static AsyncOperationHandleAwaiter ConfigureUnityContext(this AsyncOperationHandle resourceRequest, bool useUnityContext)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF40", Offset = "0x7EE940", VA = "0x1807EFF40")]
		public static AsyncOperationHandleAwaiter<T> ConfigureUnityContext<T>(this AsyncOperationHandle<T> resourceRequest, bool useUnityContext)
		{
			int num = 0;
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA45F40", Offset = "0xA44940", VA = "0x180A45F40")]
		[IteratorStateMachine(typeof(_003CWhenAll_003Ed__4))]
		public static IEnumerator WhenAll(IEnumerable<AsyncOperationHandle> asyncOperations)
		{
			int _003C_003E1__state = default(int);
			_003CWhenAll_003Ed__4 _003CWhenAll_003Ed__ = new _003CWhenAll_003Ed__4(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWhenAll_003Ed__.asyncOperations = asyncOperations;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0060", Offset = "0x7EEA60", VA = "0x1807F0060")]
		[IteratorStateMachine(typeof(_003CWhenAll_003Ed__5<>))]
		public static IEnumerator WhenAll<T>(IEnumerable<AsyncOperationHandle<T>> asyncOperations)
		{
			throw new NullReferenceException();
		}
	}
}
