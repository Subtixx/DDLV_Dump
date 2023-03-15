using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002B0")]
	public static class SystemInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public static string graphicsDeviceName
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0x106B450", Offset = "0x1069E50", VA = "0x18106B450")]
			get
			{
				int num = 0;
				return UnityEngine.SystemInfo.graphicsDeviceName;
			}
		}
	}
}
