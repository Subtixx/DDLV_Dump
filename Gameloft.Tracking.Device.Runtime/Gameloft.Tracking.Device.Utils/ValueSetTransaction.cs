using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace Gameloft.Tracking.Device.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class ValueSetTransaction : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private ValueSet innerSet;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x40305C0", Offset = "0x402EFC0", VA = "0x1840305C0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return ((ConcurrentDictionary<TKey, TValue>)(object)innerSet.values).IsEmpty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public ValueSetTransaction(ValueSet innerSet)
		{
			this.innerSet = innerSet;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x20BEFE0", Offset = "0x20BD9E0", VA = "0x1820BEFE0")]
		public T GetAs<T>(string key, [Optional] T defaultValue)
		{
			((RenderGraphObjectPool.SharedObjectPoolBase)(object)innerSet).Clear();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x20BEFE0", Offset = "0x20BD9E0", VA = "0x1820BEFE0")]
		public ValueSet Set<T>(string key, T value)
		{
			((RenderGraphObjectPool.SharedObjectPoolBase)(object)innerSet).Clear();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4030580", Offset = "0x402EF80", VA = "0x184030580", Slot = "4")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_001d
			ValueSet valueSet = innerSet;
			if (valueSet.IsDirty)
			{
				valueSet.parent.Store();
			}
		}
	}
}
