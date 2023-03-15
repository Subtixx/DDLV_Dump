using Cpp2IlInjected;
using Definitions.Items;
using Mono.Security.Interface;
using TMPro;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009A9")]
	public class GenericItemTest : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40038E9")]
		public AsyncAtlassedIcon icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40038EA")]
		public TextMeshProUGUI label;

		[Cpp2IlInjected.Token(Token = "0x6003CA1")]
		[Cpp2IlInjected.Address(RVA = "0xE53A40", Offset = "0xE52440", VA = "0x180E53A40")]
		public void Init(IItemData itemData)
		{
			//Discarded unreachable code: IL_0027
			icon.Release();
			if ((object)typeof(UIUtil).TypeHandle == null)
			{
				AsyncAtlassedIcon asyncAtlassedIcon = icon;
			}
			MonoTlsSettings settings = ((ICertificateValidator)label).Settings;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GenericItemTest()
		{
		}
	}
}
