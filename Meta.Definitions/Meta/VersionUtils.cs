using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Gameloft.Common;
using Gameloft.FileSystem.Abstraction;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class VersionUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x17C19B0", Offset = "0x17C03B0", VA = "0x1817C19B0")]
		public static Gameloft.Common.Version FromFile([Optional] string filename, [Optional] IReadOnlyFileSystem fs)
		{
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if (num == 0)
			{
			}
			Gameloft.Common.Version version = default(Gameloft.Common.Version);
			int build = version.version.build;
			string buildType = version.buildType;
			filename.m_stringLength = build;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public VersionUtils()
		{
		}
	}
}
