using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200057A")]
	public class InventoryDragAndDrop : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DE4")]
		[SerializeField]
		private RectTransform _rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DE5")]
		[SerializeField]
		private UnityEvent _onDragStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DE6")]
		[SerializeField]
		private UnityEvent _onDragStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DE7")]
		[SerializeField]
		private UnityEvent _onDragTaskDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001DE8")]
		[SerializeField]
		private UnityEvent _onDragDropFailed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001DE9")]
		public AK.Wwise.Event grabItemSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001DEA")]
		public AK.Wwise.Event releaseItemSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001DEE")]
		public int actionID = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001DF3")]
		private AsyncAtlassedIcon _dragTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001DF4")]
		private Vector2 _startPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001DF5")]
		private bool _isGamepadConnected;

		[Cpp2IlInjected.Token(Token = "0x1700058C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4001DEB")]
		internal int RewiredAxisX
		{
			[Cpp2IlInjected.Token(Token = "0x60023CF")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60023D0")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set;
		} = -1;


		[Cpp2IlInjected.Token(Token = "0x1700058D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x54"), Cpp2IlInjected.Token(Token = "0x4001DEC")]
		internal int RewiredAxisY
		{
			[Cpp2IlInjected.Token(Token = "0x60023D1")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60023D2")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700058E")]
		internal ShortcutDefinition ShortcutHoldKey
		{
			[Cpp2IlInjected.Token(Token = "0x60023D3")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CShortcutHoldKey_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60023D4")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			set
			{
				_003CShortcutHoldKey_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700058F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x64"), Cpp2IlInjected.Token(Token = "0x4001DEF")]
		public bool IsDragging
		{
			[Cpp2IlInjected.Token(Token = "0x60023D5")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60023D6")]
			[Cpp2IlInjected.Address(RVA = "0xD2B640", Offset = "0xD2A040", VA = "0x180D2B640")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000590")]
		public bool IsJoystickDragging
		{
			[Cpp2IlInjected.Token(Token = "0x60023D7")]
			[Cpp2IlInjected.Address(RVA = "0xD2B620", Offset = "0xD2A020", VA = "0x180D2B620")]
			get
			{
				if (!IsDragging)
				{
					int num = 0;
				}
				return _isGamepadConnected;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000591")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x68"), Cpp2IlInjected.Token(Token = "0x4001DF0")]
		public int DragTargetIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60023D8")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60023D9")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000592")]
		public ContainerInventory DragTargetContainerInventory
		{
			[Cpp2IlInjected.Token(Token = "0x60023DA")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CDragTargetContainerInventory_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60023DB")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			private set
			{
				_003CDragTargetContainerInventory_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000593")]
		public Storage DragTargetStorage
		{
			[Cpp2IlInjected.Token(Token = "0x60023DC")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003CDragTargetStorage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60023DD")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			private set
			{
				_003CDragTargetStorage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000594")]
		public RectTransform DragTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60023DE")]
			[Cpp2IlInjected.Address(RVA = "0xD2B520", Offset = "0xD29F20", VA = "0x180D2B520")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_0028: Expected O, but got I4
				AsyncAtlassedIcon dragTarget = _dragTarget;
				int num = 0;
				if (dragTarget != (UnityEngine.Object)num)
				{
					GameObject gameObject = _dragTarget.gameObject;
					int num2 = 0;
					if (gameObject != (UnityEngine.Object)num2 && (object)_dragTarget.transform == null)
					{
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023DF")]
		[Cpp2IlInjected.Address(RVA = "0xD2AA90", Offset = "0xD29490", VA = "0x180D2AA90")]
		public void StartDrag(BackpackSlotInventoryItem item, int index, ContainerInventory inventory)
		{
			DragTargetContainerInventory = inventory;
			StartDrag(item, index);
		}

		[Cpp2IlInjected.Token(Token = "0x60023E0")]
		[Cpp2IlInjected.Address(RVA = "0xD2AA20", Offset = "0xD29420", VA = "0x180D2AA20")]
		public void StartDrag(BackpackSlotInventoryItem item, int index, Storage inventory)
		{
			//IL_0014: Expected O, but got I4
			DragTargetStorage = inventory;
			if ((object)inventory != null)
			{
			}
			int num = 0;
			DragTargetContainerInventory = (ContainerInventory)num;
			StartDrag(item, index);
		}

		[Cpp2IlInjected.Token(Token = "0x60023E1")]
		[Cpp2IlInjected.Address(RVA = "0xD2A550", Offset = "0xD28F50", VA = "0x180D2A550")]
		public unsafe void StartDrag(BackpackSlotInventoryItem item, int index)
		{
			//Discarded unreachable code: IL_013a
			//IL_0009: Expected O, but got I4
			//IL_007f: Expected F4, but got I4
			//IL_007a: Expected native int or pointer, but got O
			int num = 0;
			if (item == (UnityEngine.Object)num)
			{
				return;
			}
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = (_isGamepadConnected = instance.IsControllerConnected((byte)useKeyboardAsController != 0));
			DragTargetIndex = index;
			if (!IsDragging)
			{
				AK.Wwise.Event @event = grabItemSfx;
				if (@event != null)
				{
					GameObject gameObject = base.gameObject;
					uint num3 = @event.Post(gameObject);
				}
			}
			int num4 = 0;
			IsDragging = true;
			Vector2 vector = (_startPosition = Vector2.zero);
			((Vector2*)(IntPtr)_startPosition)->y = 0f;
			bool flag2 = default(bool);
			if (flag2)
			{
				GameObject obj = default(GameObject);
				UnityEngine.Object.Destroy(obj);
			}
			AsyncAtlassedIcon mc_icon = ((BackpackInventoryItem)item).mc_icon;
			RectTransform rect = _rect;
			AsyncAtlassedIcon asyncAtlassedIcon = (_dragTarget = UnityEngine.Object.Instantiate(mc_icon, rect));
			string _003CKey_003Ek__BackingField = ((BackpackInventoryItem)item).mc_icon.Key;
			RectTransform rectTransform = default(RectTransform);
			Transform transform = rectTransform.GetComponent<RectTransform>().GetComponent<RectTransform>().transform;
			Transform transform2 = ((BackpackInventoryItem)item).mc_icon.transform;
			Vector3 vector2 = default(Vector3);
			float z = vector2.z;
			Transform transform3 = transform.transform;
			RawImage rawImage = default(RawImage);
			int num5 = ((rawImage.raycastTarget = false) ? 1 : 0);
			RectTransform component = rawImage.GetComponent<RectTransform>();
			if (_isGamepadConnected)
			{
				Transform transform4 = component.transform;
				Transform transform5 = item.transform;
				Vector3 vector3 = default(Vector3);
				float z2 = vector3.z;
			}
			_onDragStart?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60023E2")]
		[Cpp2IlInjected.Address(RVA = "0xD2AD60", Offset = "0xD29760", VA = "0x180D2AD60")]
		public void StopDrag(int itemIndex, ContainerInventory inventory)
		{
			//Discarded unreachable code: IL_0086
			if (!IsDragging)
			{
				return;
			}
			AK.Wwise.Event @event = releaseItemSfx;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			int num2 = DragTargetIndex;
			if (num2 != itemIndex || DragTargetContainerInventory != inventory)
			{
				if ((long)DragTargetContainerInventory == 0)
				{
					Task task = DragTargetStorage.MoveTo(inventory, num2, itemIndex);
				}
				int num3 = 0;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				int num4 = 0;
				IMenu top = menuStack.Top;
				int num5 = 0;
				int num6 = 0;
				CancellationToken ct = default(CancellationToken);
				MoveInContainerInventoryTask(itemIndex, inventory, ct).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023E3")]
		[Cpp2IlInjected.Address(RVA = "0xD2AAF0", Offset = "0xD294F0", VA = "0x180D2AAF0")]
		public void StopDrag(int itemIndex, Storage inventory)
		{
			//Discarded unreachable code: IL_00cf
			if (!IsDragging)
			{
				return;
			}
			AK.Wwise.Event @event = releaseItemSfx;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			if (DragTargetIndex == itemIndex && !(DragTargetStorage != inventory))
			{
				return;
			}
			if (DragTargetContainerInventory != null)
			{
				ContainerInventory containerInventory = inventory._containerInventory;
				if (containerInventory != null || inventory._keyhole != containerInventory)
				{
					int num2 = 0;
					MenuStack menuStack = UiRoot.Instance._menuStack;
					int num3 = 0;
					IMenu top = menuStack.Top;
					int num4 = 0;
					int num5 = 0;
					CancellationToken ct = default(CancellationToken);
					Task task = MoveInContainerInventoryTask(itemIndex, containerInventory, ct);
				}
			}
			if (inventory._containerInventory == null)
			{
				Keyhole keyhole = inventory._keyhole;
				if (keyhole == null)
				{
					return;
				}
				Storage storage = DragTargetStorage;
				int originSlotIndex = DragTargetIndex;
				Task task2 = storage.MoveTo(keyhole, originSlotIndex, itemIndex);
			}
			Storage storage2 = DragTargetStorage;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60023E4")]
		[Cpp2IlInjected.Address(RVA = "0xD2A410", Offset = "0xD28E10", VA = "0x180D2A410")]
		[AsyncStateMachine(typeof(_003CMoveInContainerInventoryTask_003Ed__48))]
		private Task MoveInContainerInventoryTask(int itemIndex, ContainerInventory inventory, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60023E5")]
		[Cpp2IlInjected.Address(RVA = "0xD2AF20", Offset = "0xD29920", VA = "0x180D2AF20")]
		private void Update()
		{
			//IL_006c: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_0151: Expected O, but got I4
			if (!IsDragging)
			{
				return;
			}
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			if (_isGamepadConnected == flag)
			{
				if (!Input.GetMouseButton(0))
				{
					bool button = Input.GetButton(actionID);
					if (!button)
					{
						if (_isGamepadConnected != button)
						{
							RectTransform dragTarget = DragTarget;
							int num2 = 0;
							if (dragTarget != (UnityEngine.Object)num2)
							{
								MenuNavigation componentInParent = GetComponentInParent<MenuNavigation>();
								int num3 = 0;
								if (componentInParent != (UnityEngine.Object)num3)
								{
									ISupportsFocusNavigation focusedElement = componentInParent.FocusNavigation._focusedElement;
									int num4 = 0;
									int num5 = 0;
									RectTransform dragTarget2 = DragTarget;
									bool flag2 = default(bool);
									Transform transform = default(Transform);
									if (flag2 && transform.GetComponent<BackpackSlotInventoryItem>().OnDrop())
									{
										goto IL_00ca;
									}
								}
								_onDragDropFailed?.Invoke();
							}
						}
						goto IL_00ca;
					}
					float axis = Input.GetAxis(RewiredAxisX);
					float axis2 = Input.GetAxis(RewiredAxisY);
					int num6 = 0;
					Transform transform2 = UiRoot.Instance._menuStack.transform;
					Transform transform3 = _dragTarget.transform;
					int num7 = 0;
					Transform transform4 = UiRoot.Instance._menuStack.transform;
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
					Transform transform5 = _dragTarget.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
				}
				int num8 = 0;
				int num9 = 0;
				Vector2 mousePosition = Input.mousePosition;
				Transform transform6 = default(Transform);
				transform6.position = (Vector3)num8;
				throw new NullReferenceException();
			}
			goto IL_00ca;
			IL_00ca:
			Kill();
		}

		[Cpp2IlInjected.Token(Token = "0x60023E6")]
		[Cpp2IlInjected.Address(RVA = "0xD2A350", Offset = "0xD28D50", VA = "0x180D2A350")]
		public void Kill()
		{
			//Discarded unreachable code: IL_003d
			//IL_002b: Expected O, but got I8
			if (IsDragging)
			{
				AsyncAtlassedIcon dragTarget = _dragTarget;
				IsDragging = false;
				UnityEngine.Object.Destroy(dragTarget.gameObject);
				_dragTarget = (AsyncAtlassedIcon)0;
				_onDragStop?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023E7")]
		[Cpp2IlInjected.Address(RVA = "0xD2B500", Offset = "0xD29F00", VA = "0x180D2B500")]
		public InventoryDragAndDrop()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_0019: Expected I4, but got I8

	}
}
