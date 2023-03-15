using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[RequireComponent(typeof(Camera))]
	public class DraggedReferenceSourceCamera : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		public delegate Object RaycastHitProcesserDelegate(RaycastHit hit);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[SerializeField]
		private UISkin draggedReferenceSkin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[SerializeField]
		private Canvas draggedReferenceCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		[SerializeField]
		private float holdTime = 0.4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		[SerializeField]
		private LayerMask interactableObjectsMask = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		[SerializeField]
		private float raycastRange = float.MaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private bool pointerDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private float pointerDownTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private Vector2 pointerDownPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private Object hitObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private DraggedReferenceItem draggedReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private PointerEventData draggingPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public RaycastHitProcesserDelegate ProcessRaycastHit;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xF18B30", Offset = "0xF17530", VA = "0x180F18B30")]
		private void Awake()
		{
			Camera camera = (_camera = GetComponent<Camera>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xF18B80", Offset = "0xF17580", VA = "0x180F18B80")]
		private void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xF19710", Offset = "0xF18110", VA = "0x180F19710")]
		public DraggedReferenceSourceCamera()
		{
		}
	}
}
