using System;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Meta.Actions;
using Meta.Missions;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AE2")]
	internal class ProfileConditionalUpdate2 : ProfileConditionalUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D86")]
		[Cpp2IlInjected.Address(RVA = "0x94E010", Offset = "0x94CA10", VA = "0x18094E010")]
		public ProfileConditionalUpdate2()
		{
			((BattlePassReward)(object)this)._002Ector();
			base.updateName = "ProfileUpdate2";
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D87")]
		[Cpp2IlInjected.Address(RVA = "0x94DB70", Offset = "0x94C570", VA = "0x18094DB70", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			base.DoApplyProfile(profile);
			long num = Convert.ToInt64(2070000805u);
			long num2 = Convert.ToInt64(31500078u);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D88")]
		[Cpp2IlInjected.Address(RVA = "0x94DC20", Offset = "0x94C620", VA = "0x18094DC20")]
		public unsafe static bool GiveMissingItemForObjective(Profile profile, Item missionItem, string stepName, Item requiredItem, bool advanceStepFallback = false)
		{
			//Discarded unreachable code: IL_00e9, IL_00ef, IL_00f5
			//IL_0068: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_0083: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			//IL_00bb: Expected O, but got I4
			//IL_00bb: Expected O, but got I4
			//IL_00d3: Expected O, but got I4
			int itemID = requiredItem.ItemID;
			int itemID2 = missionItem.ItemID;
			int num = 0;
			SlotEditor slotEditor = default(SlotEditor);
			if (slotEditor != null && slotEditor.TryGetObjective(stepName, out *(MissionObjective*)num))
			{
				ProfilePlayer player_ = profile.player_;
				int num2 = default(int);
				if (num2 == 0)
				{
					AddRemoveItemResult addRemoveItemResult = default(AddRemoveItemResult);
					if (addRemoveItemResult != 0)
					{
						int currentStepIndex_ = slotEditor.MissionSlot.currentStepIndex_;
						currentStepIndex_++;
						bool flag = slotEditor.SetCurrentStep(currentStepIndex_);
						if (flag)
						{
							string msg = $"Cannot gift {flag} so we skipped the step | {stepName} of {flag}";
							bool flag2 = slotEditor.LogSuccess(msg);
						}
						string msg2 = $"Fail to gift {addRemoveItemResult} | {stepName} of {addRemoveItemResult}";
						bool flag3 = slotEditor.LogError(msg2);
					}
					string msg3 = $"Item gifted {addRemoveItemResult} | {stepName} of {addRemoveItemResult}";
					bool flag4 = slotEditor.LogSuccess(msg3);
				}
				itemID = num2;
				string msg4 = $"Already own {itemID} | {stepName} of {num2}";
				bool flag5 = slotEditor.LogSuccess(msg4);
				string msg5 = $"Target step is not active | {stepName} of {num}";
				bool flag6 = slotEditor.LogSuccess(msg5);
			}
			if (slotEditor != null)
			{
			}
			throw new NullReferenceException();
		}
	}
}
