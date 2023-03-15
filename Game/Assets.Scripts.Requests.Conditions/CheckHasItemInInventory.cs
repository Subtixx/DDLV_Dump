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
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[Icon("Dialogue", false, "")]
	[Category("Mdl")]
	[Description("Check that the player has at least the specified amount of X item in his inventory\nBackpackOnly: Check only items in backpack (Mainly ActivityItem)")]
	public class CheckHasItemInInventory : MdlConditionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		[RequiredField]
		public BBParameter<ActivityItemFiltering> item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public BBParameter<int> quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public BBParameter<bool> backpackOnly;

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0xA80630", Offset = "0xA7F030", VA = "0x180A80630")]
			get
			{
				//Discarded unreachable code: IL_0039
				string itemDisplayName = FluxStatement.GetItemDisplayName(((ActivityItemFiltering)((BBParameter<T>)(object)item).value).Item.ItemID);
				char[] array = new char[1];
				array[0] = '!';
				return ((IEnumerable<>)(object)itemDisplayName.Split(array)).Last<string>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0xA80720", Offset = "0xA7F120", VA = "0x180A80720", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0060
				BBParameter<int> arg = quantity;
				string itemDisplayName = FluxStatement.GetItemDisplayName(((ActivityItemFiltering)((BBParameter<T>)(object)item).value).Item.ItemID);
				char[] array = new char[1];
				array[0] = '!';
				string arg2 = ((IEnumerable<>)(object)itemDisplayName.Split(array)).Last<string>();
				if (((BBParameter<T>)(object)backpackOnly).value == null)
				{
				}
				return string.Format("{0} {1} in {2}.", arg, arg2, "Backpack");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xA80320", Offset = "0xA7ED20", VA = "0x180A80320", Slot = "15")]
		protected override bool OnCheck()
		{
			//IL_0053: Expected I4, but got O
			//IL_00a1: Expected I4, but got O
			if (((BBParameter<T>)(object)backpackOnly).value == null)
			{
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				if (profile != null)
				{
					BBParameter<ActivityItemFiltering> bBParameter = this.item;
					ProfilePlayer player_ = profile.player_;
					ActivityItemFiltering value = (ActivityItemFiltering)((BBParameter<T>)(object)bBParameter).value;
					BBParameter<int> bBParameter2 = quantity;
					Item item = value.Item;
					int num = (int)((BBParameter<T>)(object)bBParameter2).value;
					bool result = default(bool);
					return result;
				}
			}
			else
			{
				Profile profile2 = SystemRoot.Instance.MetaClient.profile;
				if (profile2 != null)
				{
					ContainerInventory backpack = profile2.player_.Backpack;
					ActivityItemFiltering value2 = (ActivityItemFiltering)((BBParameter<T>)(object)this.item).value;
					BBParameter<int> bBParameter3 = quantity;
					Item item2 = value2.Item;
					int num2 = (int)((BBParameter<T>)(object)bBParameter3).value;
					bool result2 = default(bool);
					return result2;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xA805B0", Offset = "0xA7EFB0", VA = "0x180A805B0")]
		public CheckHasItemInInventory()
		{
			//IL_000d: Expected O, but got I4
			BBParameter<> bBParameter = default(BBParameter<>);
			quantity = (BBParameter<int>)(object)bBParameter;
			backpackOnly = (BBParameter<bool>)(object)BBParameter<T>.op_Implicit((T)0);
			base._002Ector();
		}
	}
}
