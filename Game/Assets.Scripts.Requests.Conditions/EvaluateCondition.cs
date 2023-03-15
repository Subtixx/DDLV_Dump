using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta.Online;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[Description("Branch based on condition evaluation")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	public class EvaluateCondition : MdlConditionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		[RequiredField]
		public BBParameter<ConditionItemFiltering> condition;

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x1367AA0", Offset = "0x13664A0", VA = "0x181367AA0")]
			get
			{
				//Discarded unreachable code: IL_0039
				string itemDisplayName = FluxStatement.GetItemDisplayName(((ConditionItemFiltering)((BBParameter<T>)(object)condition).value).Item.ItemID);
				char[] array = new char[1];
				array[0] = '!';
				return ((IEnumerable<>)(object)itemDisplayName.Split(array)).Last<string>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x1367B90", Offset = "0x1366590", VA = "0x181367B90", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0043
				string itemDisplayName = FluxStatement.GetItemDisplayName(((ConditionItemFiltering)((BBParameter<T>)(object)condition).value).Item.ItemID);
				char[] array = new char[1];
				array[0] = '!';
				return ((IEnumerable<>)(object)itemDisplayName.Split(array)).Last<string>() + " is True";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x13678F0", Offset = "0x13662F0", VA = "0x1813678F0", Slot = "15")]
		protected override bool OnCheck()
		{
			//Discarded unreachable code: IL_0031
			Item item = ((ConditionItemFiltering)((BBParameter<T>)(object)condition).value).Item;
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			int itemID = item.ItemID;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public EvaluateCondition()
		{
		}
	}
}
