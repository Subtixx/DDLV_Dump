using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009B5")]
	public static class TutorialUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6003CCF")]
		[Cpp2IlInjected.Address(RVA = "0x17F6B20", Offset = "0x17F5520", VA = "0x1817F6B20")]
		public static void Anchor(RectTransform anchor, TutorialWidgetAnchor anchorType)
		{
			//Discarded unreachable code: IL_0018
			if (anchorType == TutorialWidgetAnchor.Top || anchorType == TutorialWidgetAnchor.Top || anchorType == TutorialWidgetAnchor.Top || anchorType == TutorialWidgetAnchor.Top || anchorType == TutorialWidgetAnchor.Bottom)
			{
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD0")]
		[Cpp2IlInjected.Address(RVA = "0x17F68C0", Offset = "0x17F52C0", VA = "0x1817F68C0")]
		public static void AnchorWithRotation(RectTransform anchor, TutorialWidgetAnchor anchorType)
		{
			if (anchorType != 0)
			{
				if (anchorType != 0 && anchorType != 0)
				{
					switch (anchorType)
					{
					}
				}
				return;
			}
			int num = 0;
			float z = Vector3.zero.z;
			throw new NullReferenceException();
		}
	}
}
