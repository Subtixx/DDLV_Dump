using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000859")]
	public static class GameObjectExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60034E4")]
		[Cpp2IlInjected.Address(RVA = "0xE456C0", Offset = "0xE440C0", VA = "0x180E456C0")]
		public static RectTransform RectTransform(this GameObject gameObject)
		{
			if ((object)gameObject.transform == null)
			{
			}
			throw new NullReferenceException();
		}
	}
}
