using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Displays;
using Definitions.Items;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x200099A")]
	public class DisplaySlotData : MonoBehaviour, IInteractible, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003506")]
		private Renderer renderer;

		[Cpp2IlInjected.Token(Token = "0x17000665")]
		public Display DisplayContainer
		{
			[Cpp2IlInjected.Token(Token = "0x6002CD8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CDisplayContainer_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CD9")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CDisplayContainer_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000666")]
		public DisplaySlot DisplaySlot
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CDisplaySlot_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CDB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CDisplaySlot_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000667")]
		public Display.InteractionSetup PositionSetup
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CPositionSetup_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CDD")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CPositionSetup_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000668")]
		public GameObject RootObject
		{
			[Cpp2IlInjected.Token(Token = "0x6002CDE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CRootObject_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CDF")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CRootObject_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000669")]
		public PlayerTaskCollider TaskCollider
		{
			[Cpp2IlInjected.Token(Token = "0x6002CE0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CTaskCollider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CE1")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CTaskCollider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066A")]
		public Renderer Renderer
		{
			[Cpp2IlInjected.Token(Token = "0x6002CE2")]
			[Cpp2IlInjected.Address(RVA = "0x19CA7F0", Offset = "0x19C91F0", VA = "0x1819CA7F0")]
			get
			{
				//IL_0010: Expected O, but got I4
				Renderer renderer = this.renderer;
				int num = 0;
				if (renderer == (UnityEngine.Object)num)
				{
					Renderer renderer2 = (this.renderer = GetComponentInChildren<Renderer>());
				}
				return this.renderer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE3")]
		[Cpp2IlInjected.Address(RVA = "0x19CA5C0", Offset = "0x19C8FC0", VA = "0x1819CA5C0", Slot = "4")]
		public void OnActivation(GameObject previousInteractible)
		{
			//Discarded unreachable code: IL_0021
			//IL_0010: Expected O, but got I4
			Display display = DisplayContainer;
			int num = 0;
			if (display != (UnityEngine.Object)num)
			{
				DisplayContainer.OnActivationFromDisplaySlot(this, previousInteractible);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE4")]
		[Cpp2IlInjected.Address(RVA = "0x19CA660", Offset = "0x19C9060", VA = "0x1819CA660", Slot = "5")]
		public void OnDeactivation(GameObject nextInteractible)
		{
			//Discarded unreachable code: IL_0021
			//IL_0010: Expected O, but got I4
			Display display = DisplayContainer;
			int num = 0;
			if (display != (UnityEngine.Object)num)
			{
				DisplayContainer.OnDeactivationFromDisplaySlot(this, nextInteractible);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE5")]
		[Cpp2IlInjected.Address(RVA = "0x19CA480", Offset = "0x19C8E80", VA = "0x1819CA480")]
		public Task Init(Display container, DisplaySlot slot, Display.InteractionSetup positionSetup)
		{
			DisplayContainer = container;
			DisplaySlot = slot;
			PositionSetup = positionSetup;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE6")]
		[Cpp2IlInjected.Address(RVA = "0x19CA700", Offset = "0x19C9100", VA = "0x1819CA700")]
		[AsyncStateMachine(typeof(_003CSetupVisual_003Ed__26))]
		private Task SetupVisual()
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE7")]
		[Cpp2IlInjected.Address(RVA = "0x19CA3D0", Offset = "0x19C8DD0", VA = "0x1819CA3D0")]
		public bool HasRootOffset()
		{
			DisplaySlot displaySlot = DisplaySlot;
			if (displaySlot != null)
			{
				ItemAmount item_ = displaySlot.item_;
				if (item_ != null)
				{
					Item item = item_.Item;
					ItemType itemType = default(ItemType);
					if (itemType == ItemType.Clothing)
					{
						Item item2 = DisplaySlot.item_.Item;
						ClothingItemType clothingItemType = default(ClothingItemType);
						return clothingItemType == ClothingItemType.AccBack;
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE8")]
		[Cpp2IlInjected.Address(RVA = "0x19CA340", Offset = "0x19C8D40", VA = "0x1819CA340")]
		public void DisableInteraction()
		{
			//Discarded unreachable code: IL_001b
			//IL_0010: Expected O, but got I4
			PlayerTaskCollider playerTaskCollider = TaskCollider;
			int num = 0;
			if (playerTaskCollider != (UnityEngine.Object)num)
			{
				PlayerTaskCollider playerTaskCollider2 = TaskCollider;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CE9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DisplaySlotData()
		{
		}
	}
}
