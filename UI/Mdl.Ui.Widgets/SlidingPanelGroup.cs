using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009C5")]
	public class SlidingPanelGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003996")]
		public List<SlidingPanel> panels = (List<SlidingPanel>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003D25")]
		[Cpp2IlInjected.Address(RVA = "0x15F6250", Offset = "0x15F4C50", VA = "0x1815F6250")]
		public void Show(bool andOpen)
		{
			//Discarded unreachable code: IL_000c
			List<SlidingPanel> list = panels;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D26")]
		[Cpp2IlInjected.Address(RVA = "0x15F6070", Offset = "0x15F4A70", VA = "0x1815F6070")]
		public void Hide()
		{
			//Discarded unreachable code: IL_000c
			List<SlidingPanel> list = panels;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D27")]
		[Cpp2IlInjected.Address(RVA = "0x15F6160", Offset = "0x15F4B60", VA = "0x1815F6160")]
		public void Open()
		{
			List<SlidingPanel> list = panels;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D28")]
		[Cpp2IlInjected.Address(RVA = "0x15F5F80", Offset = "0x15F4980", VA = "0x1815F5F80")]
		public void Close()
		{
			//Discarded unreachable code: IL_000c
			List<SlidingPanel> list = panels;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D29")]
		[Cpp2IlInjected.Address(RVA = "0x15F6360", Offset = "0x15F4D60", VA = "0x1815F6360")]
		public SlidingPanelGroup()
		{
		}
	}
}
