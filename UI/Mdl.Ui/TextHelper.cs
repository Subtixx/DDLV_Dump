using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001FF")]
	[RequireComponent(typeof(TextBase))]
	public class TextHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000278")]
		public TextBase TextBase
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC7")]
			[Cpp2IlInjected.Address(RVA = "0x17EC660", Offset = "0x17EB060", VA = "0x1817EC660")]
			get
			{
				return GetComponent<TextBase>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC8")]
		[Cpp2IlInjected.Address(RVA = "0x17EC420", Offset = "0x17EAE20", VA = "0x1817EC420")]
		public unsafe void Refresh(GameObject textProvider)
		{
			//Discarded unreachable code: IL_0055
			//IL_001d: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			int num = 0;
			bool flag = Enum.TryParse<TextType>(base.gameObject.name, out *(TextType*)num);
			int num2 = 0;
			if (textProvider == (UnityEngine.Object)num2)
			{
				return;
			}
			TextBase component = GetComponent<TextBase>();
			int num3 = 0;
			if (component != (UnityEngine.Object)num3 && textProvider.TryGetComponent<IHasText>(out *(IHasText*)num))
			{
				TextBase textBase = TextBase;
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TextHelper()
		{
		}
	}
}
