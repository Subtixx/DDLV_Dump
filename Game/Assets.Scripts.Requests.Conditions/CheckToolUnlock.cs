using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Systems;
using Meta;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	[Description("Branch based on tool unlocked state")]
	public class CheckToolUnlock : MdlConditionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		[RequiredField]
		public BBParameter<ItemToolFiltering> tool;

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0xA80C00", Offset = "0xA7F600", VA = "0x180A80C00")]
			get
			{
				//Discarded unreachable code: IL_0039
				string itemDisplayName = FluxStatement.GetItemDisplayName(((ItemToolFiltering)((BBParameter<T>)(object)tool).value).Item.ItemID);
				char[] array = new char[1];
				array[0] = '!';
				return ((IEnumerable<>)(object)itemDisplayName.Split(array)).Last<string>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0xA80CF0", Offset = "0xA7F6F0", VA = "0x180A80CF0", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0043
				string itemDisplayName = FluxStatement.GetItemDisplayName(((ItemToolFiltering)((BBParameter<T>)(object)tool).value).Item.ItemID);
				char[] array = new char[1];
				array[0] = '!';
				return ((IEnumerable<>)(object)itemDisplayName.Split(array)).Last<string>() + " is Unlocked";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xA80AB0", Offset = "0xA7F4B0", VA = "0x180A80AB0", Slot = "15")]
		protected override bool OnCheck()
		{
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			if (profile != null)
			{
				BBParameter<ItemToolFiltering> bBParameter = tool;
				ProfilePlayer player_ = profile.player_;
				ItemToolFiltering value = (ItemToolFiltering)((BBParameter<T>)(object)bBParameter).value;
				bool result = default(bool);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public CheckToolUnlock()
		{
		}
	}
}
