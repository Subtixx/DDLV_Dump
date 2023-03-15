using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class DebugDragHitZone : MonoBehaviour, IDragHandler, IEventSystemHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public Transform TargetTransform;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x112A790", Offset = "0x1129190", VA = "0x18112A790", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_001d
			Transform targetTransform = TargetTransform;
			Vector2 _003Cposition_003Ek__BackingField = eventData.position;
			float y = eventData.position.y;
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugDragHitZone()
		{
		}
	}
}
