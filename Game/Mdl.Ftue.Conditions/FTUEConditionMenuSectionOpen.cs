using Cpp2IlInjected;
using Mdl.Ui;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000614")]
	[CreateAssetMenu]
	public class FTUEConditionMenuSectionOpen : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002495")]
		[SerializeField]
		private string _menuSectionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002496")]
		private string _currentSectionName = "";

		[Cpp2IlInjected.Token(Token = "0x6001AF4")]
		[Cpp2IlInjected.Address(RVA = "0x136CE50", Offset = "0x136B850", VA = "0x18136CE50", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_0026
			_currentSectionName = "";
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			BaseUiRoot.MenuSection value = OnSectionChange;
			_003CInstance_003Ek__BackingField.OnMenuSectionChange += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF5")]
		[Cpp2IlInjected.Address(RVA = "0x136CD40", Offset = "0x136B740", VA = "0x18136CD40", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_001b
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			BaseUiRoot.MenuSection value = OnSectionChange;
			_003CInstance_003Ek__BackingField.OnMenuSectionChange -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF6")]
		[Cpp2IlInjected.Address(RVA = "0x136CD00", Offset = "0x136B700", VA = "0x18136CD00")]
		private void OnSectionChange(string menuSectionName)
		{
			_currentSectionName = menuSectionName;
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF7")]
		[Cpp2IlInjected.Address(RVA = "0x136CF80", Offset = "0x136B980", VA = "0x18136CF80", Slot = "5")]
		protected override bool _IsTrue()
		{
			string currentSectionName = _currentSectionName;
			return string.Equals(_menuSectionName, currentSectionName);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF8")]
		[Cpp2IlInjected.Address(RVA = "0x136CF90", Offset = "0x136B990", VA = "0x18136CF90")]
		public FTUEConditionMenuSectionOpen()
		{
		}
	}
}
