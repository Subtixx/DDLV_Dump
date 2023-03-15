using Cpp2IlInjected;
using Mdl.Ui;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000616")]
	[CreateAssetMenu]
	public class MenuIsOpen : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002499")]
		public string menuName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400249A")]
		public bool isPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400249B")]
		private string currentMenuName;

		[Cpp2IlInjected.Token(Token = "0x6001AFE")]
		[Cpp2IlInjected.Address(RVA = "0xBC5EF0", Offset = "0xBC48F0", VA = "0x180BC5EF0", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_0051
			//IL_0010: Expected O, but got I8
			string text = menuName;
			menuName = (string)0;
			if (!isPopup)
			{
				BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
				BaseUiRoot.MenuChanged value = OnMenuChanged;
				_003CInstance_003Ek__BackingField.OnMenuChanged += value;
			}
			else
			{
				BaseUiRoot _003CInstance_003Ek__BackingField2 = BaseUiRoot.Instance;
				BaseUiRoot.MenuChanged value2 = OnMenuChanged;
				_003CInstance_003Ek__BackingField2.OnPopupChanged += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AFF")]
		[Cpp2IlInjected.Address(RVA = "0xBC5D10", Offset = "0xBC4710", VA = "0x180BC5D10")]
		private void OnMenuChanged(string newMenuName)
		{
			currentMenuName = newMenuName;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B00")]
		[Cpp2IlInjected.Address(RVA = "0xBC60E0", Offset = "0xBC4AE0", VA = "0x180BC60E0", Slot = "5")]
		protected override bool _IsTrue()
		{
			string b = currentMenuName;
			return string.Equals(menuName, b);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B01")]
		[Cpp2IlInjected.Address(RVA = "0xBC5D50", Offset = "0xBC4750", VA = "0x180BC5D50", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_0035
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			BaseUiRoot.MenuChanged value = OnMenuChanged;
			_003CInstance_003Ek__BackingField.OnPopupChanged -= value;
			BaseUiRoot _003CInstance_003Ek__BackingField2 = BaseUiRoot.Instance;
			BaseUiRoot.MenuChanged value2 = OnMenuChanged;
			_003CInstance_003Ek__BackingField2.OnMenuChanged -= value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B02")]
		[Cpp2IlInjected.Address(RVA = "0x8B32A0", Offset = "0x8B1CA0", VA = "0x1808B32A0")]
		public MenuIsOpen()
		{
		}
	}
}
