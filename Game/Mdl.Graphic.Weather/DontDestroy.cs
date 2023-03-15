using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x200052E")]
	public class DontDestroy : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60016B9")]
		[Cpp2IlInjected.Address(RVA = "0x19CFDE0", Offset = "0x19CE7E0", VA = "0x1819CFDE0")]
		private void Awake()
		{
			Object.DontDestroyOnLoad(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60016BA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DontDestroy()
		{
		}
	}
}
