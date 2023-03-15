using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000854")]
	public class MouseOverFocusChange : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030EF")]
		private int _objectSiblingIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030F0")]
		private Transform _objectParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030F1")]
		[SerializeField]
		private Transform _targetContainer;

		[Cpp2IlInjected.Token(Token = "0x60034BF")]
		[Cpp2IlInjected.Address(RVA = "0x1295730", Offset = "0x1294130", VA = "0x181295730", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0077
			//IL_0045: Expected O, but got I4
			int num = (_objectSiblingIndex = base.gameObject.transform.GetSiblingIndex());
			Transform transform = (_objectParent = base.gameObject.transform.parent.transform);
			Transform targetContainer = _targetContainer;
			int num2 = 0;
			if (targetContainer != (Object)num2)
			{
				Transform transform2 = base.gameObject.transform;
				Transform transform3 = (transform2.parentInternal = _targetContainer);
			}
			base.gameObject.transform.SetAsLastSibling();
		}

		[Cpp2IlInjected.Token(Token = "0x60034C0")]
		[Cpp2IlInjected.Address(RVA = "0x1295880", Offset = "0x1294280", VA = "0x181295880", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0056
			Transform objectParent = _objectParent;
			Transform transform = base.gameObject.transform;
			if (objectParent != transform)
			{
				Transform transform2 = base.gameObject.transform;
				Transform transform3 = (transform2.parentInternal = _objectParent);
			}
			Transform transform4 = base.gameObject.transform;
			int objectSiblingIndex = _objectSiblingIndex;
			transform4.SetSiblingIndex(objectSiblingIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x60034C1")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MouseOverFocusChange()
		{
		}
	}
}
