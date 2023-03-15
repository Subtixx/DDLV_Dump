using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x2000210")]
	public class UnityProfiler : IProfiler
	{
		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public void BeginSample(string name)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public void EndSample()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public void EmitFrameMetaData<T>(Guid id, int tag, List<T> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public void EmitFrameMetaData(Guid id, int tag, Array data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public void BeginThreadProfiling(string threadGroupName, string threadName)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x13E3BF0", Offset = "0x13E25F0", VA = "0x1813E3BF0", Slot = "9")]
		public void EndThreadProfiling()
		{
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x13E3C00", Offset = "0x13E2600", VA = "0x1813E3C00", Slot = "10")]
		public void Info(string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x13E3C50", Offset = "0x13E2650", VA = "0x1813E3C50", Slot = "11")]
		public void Warning(string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UnityProfiler()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			BeginSample((string)num);
		}
	}
}
