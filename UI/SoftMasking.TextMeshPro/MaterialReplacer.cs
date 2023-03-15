using System;
using Cpp2IlInjected;
using UnityEngine;

namespace SoftMasking.TextMeshPro
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[GlobalMaterialReplacer]
	public class MaterialReplacer : IMaterialReplacer
	{
		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public int order
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x118BE00", Offset = "0x118A800", VA = "0x18118BE00", Slot = "4")]
			get
			{
				return 10;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x118BB00", Offset = "0x118A500", VA = "0x18118BB00", Slot = "5")]
		public Material Replace(Material material)
		{
			if ((bool)material && (bool)material.shader && material.shader.name.StartsWith("TextMeshPro/"))
			{
				string name = material.shader.name;
				Shader shader = Shader.Find("Soft Mask/" + name);
				if ((bool)shader)
				{
					Material material2 = new Material(shader);
					material2.CopyPropertiesFromMaterial(material);
					return material2;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public MaterialReplacer()
		{
		}
	}
}
