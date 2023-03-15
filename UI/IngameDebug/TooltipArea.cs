using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public class TooltipArea : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private InspectorField drawer;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
		public void Initialize(InspectorField drawer)
		{
			this.drawer = drawer;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x17F2820", Offset = "0x17F1220", VA = "0x1817F2820", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_001f
			if (!eventData.dragging)
			{
				InspectorField inspectorField = drawer;
				inspectorField.m_inspector.OnDrawerHovered(inspectorField, eventData, isHovering: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x17F2870", Offset = "0x17F1270", VA = "0x1817F2870", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_001a
			InspectorField inspectorField = drawer;
			RuntimeInspector inspector = inspectorField.m_inspector;
			int isHovering = 0;
			inspector.OnDrawerHovered(inspectorField, eventData, (byte)isHovering != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TooltipArea()
		{
		}
	}
}
