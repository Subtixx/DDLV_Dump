using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200070A")]
	public class ShopTabGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002880")]
		public RectTransform Container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002881")]
		public GameObject SelectedTabIndicator;

		[Cpp2IlInjected.Token(Token = "0x6002CD1")]
		[Cpp2IlInjected.Address(RVA = "0x143C9D0", Offset = "0x143B3D0", VA = "0x18143C9D0")]
		public void OnTabClicked(int tabIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD2")]
		[Cpp2IlInjected.Address(RVA = "0x143C9E0", Offset = "0x143B3E0", VA = "0x18143C9E0")]
		public void RefreshDisplay(ShopMenu.ShopMenuTabs selectedTab, bool isDataUpToDate = true)
		{
			//Discarded unreachable code: IL_009d, IL_00b7, IL_00bc, IL_00c2, IL_00df, IL_00e5, IL_00f7
			//IL_003e: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			int num = 0;
			Container.RebuildLayout();
			IEnumerator enumerator = Container.GetEnumerator();
			bool flag = default(bool);
			ShopTabButton shopTabButton = default(ShopTabButton);
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				flag = shopTabButton != (UnityEngine.Object)num4;
				while (!flag)
				{
				}
				bool flag3 = (shopTabButton.IsSelected = selectedTab == shopTabButton.Tab);
				while (!shopTabButton._isSelected)
				{
				}
			}
			if (flag)
			{
			}
			int num5 = 0;
			if (shopTabButton != (UnityEngine.Object)num5)
			{
				Transform transform = SelectedTabIndicator.transform;
				if ((object)transform != null)
				{
				}
				if ((object)shopTabButton.McIcon.transform != null)
				{
				}
				int num6 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShopTabGroup()
		{
		}
	}
}
