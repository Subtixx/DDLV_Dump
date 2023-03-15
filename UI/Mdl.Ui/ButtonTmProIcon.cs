using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	public class ButtonTmProIcon : ButtonTmPro
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		[SerializeField]
		private AsyncAtlassedIcon _currencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		[SerializeField]
		private List<RectTransform> _orderList = (List<RectTransform>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		internal AsyncAtlassedIcon CurrencyIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0xA6C540", Offset = "0xA6AF40", VA = "0x180A6C540")]
			get
			{
				return _currencyIcon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6C390", Offset = "0xA6AD90", VA = "0x180A6C390")]
		public void RefreshLayout()
		{
			//Discarded unreachable code: IL_000c
			List<RectTransform> orderList = _orderList;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6C490", Offset = "0xA6AE90", VA = "0x180A6C490")]
		public ButtonTmProIcon()
		{
			Color white = Color.white;
			Color white2 = Color.white;
			((BaseButton)this)._002Ector();
		}
	}
}
