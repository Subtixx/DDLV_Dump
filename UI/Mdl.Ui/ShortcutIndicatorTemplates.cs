using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	public class ShortcutIndicatorTemplates : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400086A")]
		public List<ShortcutIndicatorTemplate> DefaultShortcutIndicatorTemplates;

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x15ECA90", Offset = "0x15EB490", VA = "0x1815ECA90")]
		public ShortcutIndicatorTemplate GetDefaultGamepadKeyIndicatorTemplate(ShortcutIndicator.VisualType visualType)
		{
			//Discarded unreachable code: IL_002b
			List<ShortcutIndicatorTemplate> defaultShortcutIndicatorTemplates = DefaultShortcutIndicatorTemplates;
			Func<ShortcutIndicatorTemplate, bool> func = (Func<ShortcutIndicatorTemplate, bool>)(object)(Func<T, TResult>)delegate(ShortcutIndicatorTemplate x)
			{
				//Discarded unreachable code: IL_0011
				ShortcutIndicator.VisualType visualType2 = visualType;
				return x.VisualType == visualType2;
			};
			return Enumerable.FirstOrDefault<ShortcutIndicatorTemplate>((IEnumerable<>)defaultShortcutIndicatorTemplates, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShortcutIndicatorTemplates()
		{
		}
	}
}
