using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x200023D")]
	public abstract class BaseItemFilter : IItemFilter
	{
		[Cpp2IlInjected.Token(Token = "0x6001574")]
		[Cpp2IlInjected.Address(RVA = "0x26EF1F0", Offset = "0x26EDBF0", VA = "0x1826EF1F0", Slot = "4")]
		public void Filter(ItemDatabase itemDb, List<ItemWithState> list)
		{
			if ((object)typeof(IInvertFilter).TypeHandle != null && (object)typeof(IInvertFilter).TypeHandle != null)
			{
				this.DoFilter(itemDb, (List<>)(object)list);
			}
			else
			{
				this.DoFilter(itemDb, (List<>)(object)list);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001575")]
		[Cpp2IlInjected.Address(RVA = "0x26EF140", Offset = "0x26EDB40", VA = "0x1826EF140", Slot = "5")]
		public void FilterOut(ItemDatabase itemDb, List<ItemWithState> list)
		{
			if ((object)typeof(IInvertFilter).TypeHandle != null && (object)typeof(IInvertFilter).TypeHandle != null)
			{
				this.DoFilter(itemDb, (List<>)(object)list);
			}
			else
			{
				this.DoFilter(itemDb, (List<>)(object)list);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001576")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void DoFilter(ItemDatabase itemDb, List<ItemWithState> list);

		[Cpp2IlInjected.Token(Token = "0x6001577")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void DoFilterOut(ItemDatabase itemDb, List<ItemWithState> list);

		[Cpp2IlInjected.Token(Token = "0x6001578")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected BaseItemFilter()
		{
		}
	}
}
