using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AFD")]
	internal class AddToggleStatesOnGridObjectsProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DD4")]
		[Cpp2IlInjected.Address(RVA = "0x18E6520", Offset = "0x18E4F20", VA = "0x1818E6520", Slot = "5")]
		protected unsafe override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0046, IL_004c, IL_0052, IL_0058, IL_005e, IL_0064, IL_006a, IL_0070
			//IL_003c: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			ICollection<Grid> values = (ICollection<Grid>)((MapField<TKey, TValue>)(object)profile.world_.gridCollection_.grids_).get_Values();
			if (values != null)
			{
				int num3 = 0;
				ICollection<> collection = default(ICollection<>);
				if (collection != null)
				{
					ItemType itemType = default(ItemType);
					while (itemType != ItemType.Furniture)
					{
					}
					bool flag = default(bool);
					while (!flag)
					{
					}
					ToggleInteraction toggleInteraction = default(ToggleInteraction);
					while (toggleInteraction == null)
					{
					}
					GridState gridState = default(GridState);
					((int*)num)->m_value = (int)gridState;
				}
				if (collection == null)
				{
				}
			}
			if (values == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DD5")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public AddToggleStatesOnGridObjectsProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
