using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	[Description("Branch based on character unlocked state")]
	public class CheckCharacterUnlock : MdlConditionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		[RequiredField]
		public BBParameter<ItemCharacterFiltering> character;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0xA7FCF0", Offset = "0xA7E6F0", VA = "0x180A7FCF0")]
			get
			{
				//Discarded unreachable code: IL_0039
				string itemDisplayName = FluxStatement.GetItemDisplayName(((ItemCharacterFiltering)((BBParameter<T>)(object)character).value).Item.ItemID);
				char[] array = new char[1];
				array[0] = '!';
				return ((IEnumerable<>)(object)itemDisplayName.Split(array)).Last<string>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0xA7FDE0", Offset = "0xA7E7E0", VA = "0x180A7FDE0", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0043
				string itemDisplayName = FluxStatement.GetItemDisplayName(((ItemCharacterFiltering)((BBParameter<T>)(object)character).value).Item.ItemID);
				char[] array = new char[1];
				array[0] = '!';
				return ((IEnumerable<>)(object)itemDisplayName.Split(array)).Last<string>() + " is Unlocked";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7FB60", Offset = "0xA7E560", VA = "0x180A7FB60", Slot = "15")]
		protected override bool OnCheck()
		{
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			if (profile != null)
			{
				BBParameter<ItemCharacterFiltering> bBParameter = this.character;
				ProfileWorld world_ = profile.world_;
				Item item = ((ItemCharacterFiltering)((BBParameter<T>)(object)bBParameter).value).Item;
				Character character = world_.GetCharacter(item);
				if (character != null)
				{
					bool isUnlocked = character.IsUnlocked;
					int num = 0;
				}
				return 0 == 1;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public CheckCharacterUnlock()
		{
		}
	}
}
