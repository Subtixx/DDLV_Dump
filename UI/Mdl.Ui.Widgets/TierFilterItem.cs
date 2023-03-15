using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009AC")]
	public class TierFilterItem : FilterItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40038F2")]
		[SerializeField]
		private SpriteAtlasImage _mcIcon;

		[Cpp2IlInjected.Token(Token = "0x6003CAE")]
		[Cpp2IlInjected.Address(RVA = "0x17F0080", Offset = "0x17EEA80", VA = "0x1817F0080", Slot = "4")]
		public override void Init(Filter filter, bool showText)
		{
			//Discarded unreachable code: IL_0042
			base.Filter = filter;
			if ((object)filter == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				string imageAddress = default(string);
				_mcIcon.ImageAddress = imageAddress;
			}
			Button.ButtonClickedEvent onClick = button.m_OnClick;
			UnityAction call = base.Click;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CAF")]
		[Cpp2IlInjected.Address(RVA = "0xE26030", Offset = "0xE24A30", VA = "0x180E26030")]
		public TierFilterItem()
		{
		}
	}
}
