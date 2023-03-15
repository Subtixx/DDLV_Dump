using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Ui;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000617")]
	[CreateAssetMenu]
	public class MenuWasClosed : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400249C")]
		public string menuName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400249D")]
		public List<string> altMenuNames = (List<string>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400249E")]
		public bool stackMustBeEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x400249F")]
		public bool isPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40024A0")]
		private string currentMenuName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40024A1")]
		private bool wasClosed;

		[Cpp2IlInjected.Token(Token = "0x6001B03")]
		[Cpp2IlInjected.Address(RVA = "0xBC64D0", Offset = "0xBC4ED0", VA = "0x180BC64D0", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_0046
			wasClosed = false;
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

		[Cpp2IlInjected.Token(Token = "0x6001B04")]
		[Cpp2IlInjected.Address(RVA = "0xBC6290", Offset = "0xBC4C90", VA = "0x180BC6290")]
		private void OnMenuChanged(string newMenuName)
		{
			//IL_003c: Expected I4, but got I8
			if (!IsMenuName(newMenuName))
			{
				string newMenuName2 = currentMenuName;
				if (!IsMenuName(newMenuName2) || !(currentMenuName != newMenuName))
				{
					goto IL_0051;
				}
				if (!stackMustBeEmpty)
				{
					wasClosed = true;
				}
				bool flag = (wasClosed = string.IsNullOrEmpty(newMenuName));
			}
			wasClosed = false;
			goto IL_0051;
			IL_0051:
			currentMenuName = newMenuName;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B05")]
		[Cpp2IlInjected.Address(RVA = "0xBC60F0", Offset = "0xBC4AF0", VA = "0x180BC60F0")]
		private bool IsMenuName(string newMenuName)
		{
			int num = 0;
			int num2 = 0;
			string b = menuName;
			if (!string.Equals(newMenuName, b))
			{
				List<string> list = altMenuNames;
				bool flag = default(bool);
				if (flag)
				{
					while (!flag)
					{
					}
					num2++;
				}
				if (num2 + 1 != 0)
				{
				}
				int num3 = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B06")]
		[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0", Slot = "5")]
		protected override bool _IsTrue()
		{
			return wasClosed;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B07")]
		[Cpp2IlInjected.Address(RVA = "0xBC6330", Offset = "0xBC4D30", VA = "0x180BC6330", Slot = "6")]
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

		[Cpp2IlInjected.Token(Token = "0x6001B08")]
		[Cpp2IlInjected.Address(RVA = "0xBC66A0", Offset = "0xBC50A0", VA = "0x180BC66A0")]
		public MenuWasClosed()
		{
		}
	}
}
