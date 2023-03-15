using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public interface IProfiler
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BeginSample(string name);

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EndSample();

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EmitFrameMetaData<T>(Guid id, int tag, List<T> data) where T : struct;

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EmitFrameMetaData(Guid id, int tag, Array data);

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BeginThreadProfiling(string threadGroupName, string threadName);

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EndThreadProfiling();

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Info(string msg);

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Warning(string msg);
	}
}
