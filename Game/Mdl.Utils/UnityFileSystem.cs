using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Meta.ErrorReporting;
using Meta.Util;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007D2")]
	public static class UnityFileSystem
	{
		[Cpp2IlInjected.Token(Token = "0x1400004F")]
		public static event EventHandler OnInit
		{
			[Cpp2IlInjected.Token(Token = "0x60022C2")]
			[Cpp2IlInjected.Address(RVA = "0x13E3140", Offset = "0x13E1B40", VA = "0x1813E3140")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60022C3")]
			[Cpp2IlInjected.Address(RVA = "0x13E3200", Offset = "0x13E1C00", VA = "0x1813E3200")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022C4")]
		[Cpp2IlInjected.Address(RVA = "0x13E2E80", Offset = "0x13E1880", VA = "0x1813E2E80")]
		[RuntimeInitializeOnLoadMethod]
		public static void InitFileSystem()
		{
			//Discarded unreachable code: IL_005b
			//IL_0006: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			SeriloggerWrapper seriloggerWrapper = SeriloggerWrapper.Create((IErrorReporter)0);
			int num = 0;
			IReadOnlyFileSystem streamingAssetsFileSystem = FileSystemMaker.StreamingAssetsFileSystem;
			int num2 = 0;
			if (streamingAssetsFileSystem == null)
			{
			}
			if (streamingAssetsFileSystem != null)
			{
				FileSystem.Data = (IFileSystem)streamingAssetsFileSystem;
				int num3 = 0;
				FileSystem.Data = FileSystemMaker.PersistentDataFileSystem;
				int num4 = 0;
				FileSystem.Data = FileSystemMaker.TempFileSystem;
				int num5 = 0;
				IFileSystem persistentDataFileSystem = FileSystemMaker.PersistentDataFileSystem;
				uint num6 = default(uint);
				if (num2 < (int)num6)
				{
					num2 += num2;
					num2++;
				}
				FileSystem.Data = (IFileSystem)num2;
				if (num2 == 0)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022C5")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public static bool RegisterWriteOperationDisplayer(IWritableDisplayer displayer)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public static void UnregisterWriteOperationDisplayer(IWritableDisplayer displayer)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
