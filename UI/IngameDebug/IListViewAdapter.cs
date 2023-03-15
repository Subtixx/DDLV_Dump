using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public interface IListViewAdapter
	{
		[Cpp2IlInjected.Token(Token = "0x17000118")]
		int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		float ItemHeight
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RecycledListItem CreateItem(Transform parent);

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetItemContent(RecycledListItem item);

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OnItemClicked(RecycledListItem item);
	}
}
