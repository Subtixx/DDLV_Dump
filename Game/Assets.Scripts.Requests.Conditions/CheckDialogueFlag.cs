using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	[Description("(Ctrl-Shift-U) Branch based on flag value: ON/OFF")]
	public class CheckDialogueFlag : MdlConditionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		[RequiredField]
		public BBParameter<ItemFlagFiltering> flag;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0xA801F0", Offset = "0xA7EBF0", VA = "0x180A801F0")]
			get
			{
				//Discarded unreachable code: IL_001b
				return FluxStatement.GetItemDisplayName(((ItemFlagFiltering)((BBParameter<T>)(object)flag).value).Item.ItemID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xA80270", Offset = "0xA7EC70", VA = "0x180A80270", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0027
				string itemDisplayName = FluxStatement.GetItemDisplayName(((ItemFlagFiltering)((BBParameter<T>)(object)flag).value).Item.ItemID);
				return "FlagIsOn\n" + itemDisplayName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xA800E0", Offset = "0xA7EAE0", VA = "0x180A800E0", Slot = "15")]
		protected override bool OnCheck()
		{
			//Discarded unreachable code: IL_0032
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			BBParameter<ItemFlagFiltering> bBParameter = flag;
			ProfileWorld world_ = profile.world_;
			Item item = ((ItemFlagFiltering)((BBParameter<T>)(object)bBParameter).value).Item;
			return world_.IsDialogueFlagOn(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public CheckDialogueFlag()
		{
		}
	}
}
