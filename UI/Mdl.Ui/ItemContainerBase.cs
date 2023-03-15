using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	public abstract class ItemContainerBase : IItemContainer, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event ItemDataDelegate OnItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE5")]
			[Cpp2IlInjected.Address(RVA = "0xD341E0", Offset = "0xD32BE0", VA = "0x180D341E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
				ItemDataDelegate onItemData = this.OnItemData;
				Delegate @delegate = Delegate.Combine(onItemData, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemData)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE6")]
			[Cpp2IlInjected.Address(RVA = "0xD34320", Offset = "0xD32D20", VA = "0x180D34320", Slot = "5")]
			[CompilerGenerated]
			remove
			{
				ItemDataDelegate onItemData = this.OnItemData;
				Delegate @delegate = Delegate.Remove(onItemData, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemData)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event ItemActivatedDelegate OnItemActivated
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE7")]
			[Cpp2IlInjected.Address(RVA = "0xD34140", Offset = "0xD32B40", VA = "0x180D34140", Slot = "6")]
			[CompilerGenerated]
			add
			{
				ItemActivatedDelegate onItemActivated = this.OnItemActivated;
				Delegate @delegate = Delegate.Combine(onItemActivated, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemActivated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE8")]
			[Cpp2IlInjected.Address(RVA = "0xD34280", Offset = "0xD32C80", VA = "0x180D34280", Slot = "7")]
			[CompilerGenerated]
			remove
			{
				ItemActivatedDelegate onItemActivated = this.OnItemActivated;
				Delegate @delegate = Delegate.Remove(onItemActivated, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemActivated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void InitItems(int itemCount, int initialSelectionIndex);

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract void SetFocus(FocusNavigation focusNavigation);

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0xD34120", Offset = "0xD32B20", VA = "0x180D34120")]
		protected void RaiseOnItemData(GameObject displayObject, int itemIndex, bool selected)
		{
			this.OnItemData?.Invoke(displayObject, itemIndex, selected);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0xD34100", Offset = "0xD32B00", VA = "0x180D34100")]
		protected void RaiseItemActivated(GameObject displayObject, int itemIndex)
		{
			this.OnItemActivated?.Invoke(displayObject, itemIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected ItemContainerBase()
		{
		}
	}
}
