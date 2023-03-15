using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public class ActiveScrollRectHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0x87BA60", Offset = "0x87A460", VA = "0x18087BA60", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x87BB00", Offset = "0x87A500", VA = "0x18087BB00", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ActiveScrollRectHandler()
		{
		}
	}
}
