using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009C7")]
	[RequireComponent(typeof(SlidingPanel))]
	public class ToggledSlidingPanel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400399A")]
		public List<Button> toggleButtons = (List<Button>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400399B")]
		private SlidingPanel _slidingPanel;

		[Cpp2IlInjected.Token(Token = "0x6003D2E")]
		[Cpp2IlInjected.Address(RVA = "0x17F1F70", Offset = "0x17F0970", VA = "0x1817F1F70")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0028, IL_002e
			SlidingPanel slidingPanel = (_slidingPanel = GetComponent<SlidingPanel>());
			List<Button> list = toggleButtons;
			bool flag = default(bool);
			if (flag)
			{
				UnityAction unityAction = TogglePanel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D2F")]
		[Cpp2IlInjected.Address(RVA = "0x17F2100", Offset = "0x17F0B00", VA = "0x1817F2100")]
		private void TogglePanel()
		{
			//Discarded unreachable code: IL_0020
			SlidingPanel slidingPanel = _slidingPanel;
			int num = 0;
			if ((slidingPanel.isOpened ? 1 : 0) != num)
			{
				slidingPanel.Close();
			}
			else
			{
				slidingPanel.Open();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D30")]
		[Cpp2IlInjected.Address(RVA = "0x17F2130", Offset = "0x17F0B30", VA = "0x1817F2130")]
		public ToggledSlidingPanel()
		{
		}
	}
}
