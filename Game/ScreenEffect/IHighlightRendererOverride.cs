using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace ScreenEffect
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	internal interface IHighlightRendererOverride
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GetRenderers(List<Renderer> renderers);
	}
}
