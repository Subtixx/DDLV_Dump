using System;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000722")]
	public class CancellationTokenProvider : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002968")]
		private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002969")]
		private CancellationTokenSource activeCancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x17000480")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6001FA6")]
			[Cpp2IlInjected.Address(RVA = "0xE1E410", Offset = "0xE1CE10", VA = "0x180E1E410")]
			get
			{
				//Discarded unreachable code: IL_000c
				return cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000481")]
		public CancellationToken ActiveCancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6001FA7")]
			[Cpp2IlInjected.Address(RVA = "0x12D7ED0", Offset = "0x12D68D0", VA = "0x1812D7ED0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return activeCancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA8")]
		[Cpp2IlInjected.Address(RVA = "0x12D7DA0", Offset = "0x12D67A0", VA = "0x1812D7DA0")]
		private void OnDisable()
		{
			//IL_0025: Expected O, but got I8
			CancellationTokenSource cancellationTokenSource = activeCancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				activeCancellationTokenSource.Dispose();
				activeCancellationTokenSource = (CancellationTokenSource)0;
			}
			CancellationTokenSource cancellationTokenSource2 = (activeCancellationTokenSource = new CancellationTokenSource());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA9")]
		[Cpp2IlInjected.Address(RVA = "0x12D7D10", Offset = "0x12D6710", VA = "0x1812D7D10")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_004b
			//IL_0025: Expected O, but got I8
			//IL_004a: Expected O, but got I8
			CancellationTokenSource cancellationTokenSource = activeCancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				activeCancellationTokenSource.Dispose();
				activeCancellationTokenSource = (CancellationTokenSource)0;
			}
			CancellationTokenSource cancellationTokenSource2 = this.cancellationTokenSource;
			if (cancellationTokenSource2 != null)
			{
				cancellationTokenSource2.Cancel();
				this.cancellationTokenSource.Dispose();
				this.cancellationTokenSource = (CancellationTokenSource)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAA")]
		[Cpp2IlInjected.Address(RVA = "0x12D7C10", Offset = "0x12D6610", VA = "0x1812D7C10")]
		public void ForceCancelAndRenew()
		{
			//IL_0025: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			CancellationTokenSource cancellationTokenSource = activeCancellationTokenSource;
			int num = 0;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				activeCancellationTokenSource.Dispose();
				activeCancellationTokenSource = (CancellationTokenSource)num;
			}
			CancellationTokenSource cancellationTokenSource2 = this.cancellationTokenSource;
			if (cancellationTokenSource2 != null)
			{
				cancellationTokenSource2.Cancel();
				this.cancellationTokenSource.Dispose();
				this.cancellationTokenSource = (CancellationTokenSource)num;
			}
			CancellationTokenSource cancellationTokenSource3 = (this.cancellationTokenSource = new CancellationTokenSource());
			CancellationTokenSource cancellationTokenSource4 = (activeCancellationTokenSource = new CancellationTokenSource());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAB")]
		[Cpp2IlInjected.Address(RVA = "0x12D7BC0", Offset = "0x12D65C0", VA = "0x1812D7BC0")]
		private static void Cancel(ref CancellationTokenSource source)
		{
		}//Discarded unreachable code: IL_0001


		[Cpp2IlInjected.Token(Token = "0x6001FAC")]
		[Cpp2IlInjected.Address(RVA = "0x12D7E40", Offset = "0x12D6840", VA = "0x1812D7E40")]
		public CancellationTokenProvider()
		{
		}
	}
}
