using System.Collections;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200022C")]
	public interface IMenu : IHasAsssetGUID
	{
		[Cpp2IlInjected.Token(Token = "0x170002A3")]
		bool IsStaticMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000DBA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000DBB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002A4")]
		bool UseCanvasScalerMatchWidthOrHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000DBC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002A5")]
		float CanvasScalerMatchWidthOrHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000DBD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<Menu> Instantiate(Transform parent);

		[Cpp2IlInjected.Token(Token = "0x6000DBF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnPush(MenuStack stack, [Optional] MenuParam param);

		[Cpp2IlInjected.Token(Token = "0x6000DC0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OnPop();

		[Cpp2IlInjected.Token(Token = "0x6000DC1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OnFocusIn();

		[Cpp2IlInjected.Token(Token = "0x6000DC2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IEnumerator PreFocusOut(bool popAfterPreFocusOut);

		[Cpp2IlInjected.Token(Token = "0x6000DC3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OnFocusOut(bool popAfterFocusOut = false, bool animate = true);
	}
}
