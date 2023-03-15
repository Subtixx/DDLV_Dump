using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000967")]
	public static class SceneExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x4003419")]
		private static readonly List<GameObject> rootList;

		[Cpp2IlInjected.Token(Token = "0x6002BA8")]
		[Cpp2IlInjected.Address(RVA = "0xCC98B0", Offset = "0xCC82B0", VA = "0x180CC98B0")]
		public static GameObject GetRoot(this Scene scene)
		{
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				global::System.ThrowHelper.ThrowArgumentOutOfRangeException();
				return (GameObject)typeof(SceneExtensions).TypeHandle;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA9")]
		[Cpp2IlInjected.Address(RVA = "0xCC99B0", Offset = "0xCC83B0", VA = "0x180CC99B0")]
		static SceneExtensions()
		{
			List<GameObject> list = (List<GameObject>)(object)new List<T>();
			/*Error: Unexpected end of block*/;
		}
	}
}
