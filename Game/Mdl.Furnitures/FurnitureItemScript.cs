using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Items;
using UnityEngine;

namespace Mdl.Furnitures
{
	[Cpp2IlInjected.Token(Token = "0x200055C")]
	public class FurnitureItemScript : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002151")]
		public TextAsset staticDecals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002152")]
		public Color defaultTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002153")]
		public List<MeshRenderer> decalRenderers;

		[Cpp2IlInjected.Token(Token = "0x17000333")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x60017FF")]
			[Cpp2IlInjected.Address(RVA = "0x8BBA60", Offset = "0x8BA460", VA = "0x1808BBA60")]
			get
			{
				return GetComponent<ItemScript>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000334")]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001800")]
			[Cpp2IlInjected.Address(RVA = "0x8BB980", Offset = "0x8BA380", VA = "0x1808BB980")]
			get
			{
				//Discarded unreachable code: IL_0021
				//IL_0010: Expected O, but got I4
				ItemScript component = GetComponent<ItemScript>();
				int num = 0;
				if (component != (Object)num)
				{
					Item item = GetComponent<ItemScript>().Item;
				}
				return -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001801")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8F0", Offset = "0x8BA2F0", VA = "0x1808BB8F0")]
		public FurnitureItemScript()
		{
			Color white = Color.white;
			decalRenderers = (List<MeshRenderer>)(object)new List<T>();
			base._002Ector();
		}
	}
}
