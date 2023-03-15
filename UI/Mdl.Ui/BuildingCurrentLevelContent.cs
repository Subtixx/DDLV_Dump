using System;
using System.Collections;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200029D")]
	[RequiredAllNotNull]
	public class BuildingCurrentLevelContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000BCA")]
		[SerializeField]
		private RectTransform _upgradeInfoContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000BCB")]
		[SerializeField]
		private BuildingCurrentStatItem _upgradeInfoItemPrefab;

		[Cpp2IlInjected.Token(Token = "0x6001071")]
		[Cpp2IlInjected.Address(RVA = "0xA68000", Offset = "0xA66A00", VA = "0x180A68000")]
		internal void RefreshDisplay(UpgradeData currentUpgradeInfo, UpgradeData nextUpgradeInfo)
		{
			//Discarded unreachable code: IL_03c8, IL_03ce, IL_03e0
			GameObject gameObject = default(GameObject);
			BenefitsGardenData benefitsGardenData = default(BenefitsGardenData);
			BenefitsGardenData benefitsGardenData2 = default(BenefitsGardenData);
			BuildingCurrentStatItem buildingCurrentStatItem = default(BuildingCurrentStatItem);
			BenefitsGardenData benefitsGardenData3 = default(BenefitsGardenData);
			string text = default(string);
			BenefitsGardenData benefitsGardenData4 = default(BenefitsGardenData);
			string text2 = default(string);
			BenefitsKitchenData benefitsKitchenData = default(BenefitsKitchenData);
			BenefitsKitchenData benefitsKitchenData2 = default(BenefitsKitchenData);
			BuildingCurrentStatItem buildingCurrentStatItem2 = default(BuildingCurrentStatItem);
			BenefitsKitchenData benefitsKitchenData3 = default(BenefitsKitchenData);
			string text4 = default(string);
			BenefitsKitchenData benefitsKitchenData4 = default(BenefitsKitchenData);
			string text5 = default(string);
			bool active = default(bool);
			BenefitsKitchenData benefitsKitchenData5 = default(BenefitsKitchenData);
			BenefitsKitchenData benefitsKitchenData6 = default(BenefitsKitchenData);
			BuildingCurrentStatItem buildingCurrentStatItem3 = default(BuildingCurrentStatItem);
			BenefitsKitchenData benefitsKitchenData7 = default(BenefitsKitchenData);
			string text7 = default(string);
			BenefitsKitchenData benefitsKitchenData8 = default(BenefitsKitchenData);
			string text10 = default(string);
			BenefitsGardeningData benefitsGardeningData = default(BenefitsGardeningData);
			BenefitsGardeningData benefitsGardeningData2 = default(BenefitsGardeningData);
			BuildingCurrentStatItem buildingCurrentStatItem4 = default(BuildingCurrentStatItem);
			BenefitsGardeningData benefitsGardeningData3 = default(BenefitsGardeningData);
			string text12 = default(string);
			BenefitsGardeningData benefitsGardeningData4 = default(BenefitsGardeningData);
			string text13 = default(string);
			bool active2 = default(bool);
			BenefitsGardeningData benefitsGardeningData5 = default(BenefitsGardeningData);
			BenefitsGardeningData benefitsGardeningData6 = default(BenefitsGardeningData);
			BuildingCurrentStatItem buildingCurrentStatItem5 = default(BuildingCurrentStatItem);
			string text15 = default(string);
			string text16 = default(string);
			bool active3 = default(bool);
			BenefitsGardeningData benefitsGardeningData7 = default(BenefitsGardeningData);
			BenefitsGardeningData benefitsGardeningData8 = default(BenefitsGardeningData);
			BuildingCurrentStatItem buildingCurrentStatItem6 = default(BuildingCurrentStatItem);
			BenefitsGardeningData benefitsGardeningData9 = default(BenefitsGardeningData);
			string text18 = default(string);
			BenefitsFishingData benefitsFishingData = default(BenefitsFishingData);
			BenefitsFishingData benefitsFishingData2 = default(BenefitsFishingData);
			BuildingCurrentStatItem buildingCurrentStatItem7 = default(BuildingCurrentStatItem);
			BenefitsFishingData benefitsFishingData3 = default(BenefitsFishingData);
			string text21 = default(string);
			BenefitsFishingData benefitsFishingData4 = default(BenefitsFishingData);
			string text22 = default(string);
			bool active4 = default(bool);
			BenefitsFishingData benefitsFishingData5 = default(BenefitsFishingData);
			BenefitsFishingData benefitsFishingData6 = default(BenefitsFishingData);
			BuildingCurrentStatItem buildingCurrentStatItem8 = default(BuildingCurrentStatItem);
			BenefitsFishingData benefitsFishingData7 = default(BenefitsFishingData);
			string text24 = default(string);
			BenefitsFishingData benefitsFishingData8 = default(BenefitsFishingData);
			string text25 = default(string);
			bool active5 = default(bool);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = _upgradeInfoContent.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					UnityEngine.Object.Destroy(gameObject);
				}
				if ((object)gameObject == null)
				{
					continue;
				}
				if (0 != 1 || benefitsGardenData.numberOfSlots_ == benefitsGardenData2.numberOfSlots_)
				{
					return;
				}
				buildingCurrentStatItem._tfLabel.StringID = "menu.building_number_of_slots_label";
				TextBase tfCurrent = buildingCurrentStatItem._tfCurrent;
				int numberOfSlots_ = benefitsGardenData3.numberOfSlots_;
				tfCurrent.Text = text;
				int numberOfSlots_2 = benefitsGardenData4.numberOfSlots_;
				string text3 = "+" + text2;
				if (benefitsKitchenData.numberOfSlots_ != benefitsKitchenData2.numberOfSlots_)
				{
					TextBase tfCurrent2 = buildingCurrentStatItem._tfCurrent;
					buildingCurrentStatItem2._tfLabel.StringID = "menu.building_number_of_slots_label";
					TextBase tfCurrent3 = buildingCurrentStatItem2._tfCurrent;
					int numberOfSlots_3 = benefitsKitchenData3.numberOfSlots_;
					tfCurrent3.Text = text4;
					TextBase tfDifference = buildingCurrentStatItem2._tfDifference;
					int numberOfSlots_4 = benefitsKitchenData4.numberOfSlots_;
					string text6 = "+" + text5;
					tfDifference.Text = "";
					buildingCurrentStatItem2._mcDifference.SetActive(active);
				}
				if (benefitsKitchenData5.refreshCost_ == benefitsKitchenData6.refreshCost_)
				{
					return;
				}
				TextBase tfCurrent4 = buildingCurrentStatItem._tfCurrent;
				buildingCurrentStatItem3._tfLabel.StringID = "menu.building_refresh_cost_label";
				TextBase tfCurrent5 = buildingCurrentStatItem3._tfCurrent;
				int refreshCost_ = benefitsKitchenData7.refreshCost_;
				string text9 = (tfCurrent5.Text = text7 + "%");
				TextBase tfDifference2 = buildingCurrentStatItem3._tfDifference;
				int refreshCost_2 = benefitsKitchenData8.refreshCost_;
				string text11 = text10 + "%";
				if (benefitsGardeningData.numberOfSlots_ != benefitsGardeningData2.numberOfSlots_)
				{
					TextBase tfCurrent6 = buildingCurrentStatItem3._tfCurrent;
					buildingCurrentStatItem4._tfLabel.StringID = "menu.building_number_of_slots_label";
					TextBase tfCurrent7 = buildingCurrentStatItem4._tfCurrent;
					int numberOfSlots_5 = benefitsGardeningData3.numberOfSlots_;
					tfCurrent7.Text = text12;
					TextBase tfDifference3 = buildingCurrentStatItem4._tfDifference;
					int numberOfSlots_6 = benefitsGardeningData4.numberOfSlots_;
					string text14 = "+" + text13;
					tfDifference3.Text = "";
					buildingCurrentStatItem4._mcDifference.SetActive(active2);
				}
				if (benefitsGardeningData5.sellCap_ != benefitsGardeningData6.sellCap_)
				{
					TextBase tfCurrent8 = buildingCurrentStatItem3._tfCurrent;
					buildingCurrentStatItem5._tfLabel.StringID = "menu.building_goofy_fund_label";
					buildingCurrentStatItem5._tfCurrent.Text = text15;
					TextBase tfDifference4 = buildingCurrentStatItem5._tfDifference;
					string text17 = "+" + text16;
					tfDifference4.Text = "";
					buildingCurrentStatItem5._mcDifference.SetActive(active3);
				}
				if (benefitsGardeningData7.refreshCost_ != benefitsGardeningData8.refreshCost_)
				{
					TextBase tfCurrent9 = buildingCurrentStatItem3._tfCurrent;
					buildingCurrentStatItem6._tfLabel.StringID = "menu.building_refresh_cost_label";
					TextBase tfCurrent10 = buildingCurrentStatItem6._tfCurrent;
					int refreshCost_3 = benefitsGardeningData9.refreshCost_;
					string text20 = (tfCurrent10.Text = text18 + "%");
					TextBase tfDifference5 = buildingCurrentStatItem6._tfDifference;
					if (benefitsFishingData.fishCap_ != benefitsFishingData2.fishCap_)
					{
						TextBase tfCurrent11 = buildingCurrentStatItem6._tfCurrent;
						buildingCurrentStatItem7._tfLabel.StringID = "menu.building_fish_cap_label";
						TextBase tfCurrent12 = buildingCurrentStatItem7._tfCurrent;
						int fishCap_ = benefitsFishingData3.fishCap_;
						tfCurrent12.Text = text21;
						TextBase tfDifference6 = buildingCurrentStatItem7._tfDifference;
						int fishCap_2 = benefitsFishingData4.fishCap_;
						string text23 = "+" + text22;
						tfDifference6.Text = "";
						buildingCurrentStatItem7._mcDifference.SetActive(active4);
					}
					if (benefitsFishingData5.fishPerHour_ != benefitsFishingData6.fishPerHour_)
					{
						TextBase tfCurrent13 = buildingCurrentStatItem6._tfCurrent;
						buildingCurrentStatItem8._tfLabel.StringID = "menu.building_fish_per_hour_label";
						TextBase tfCurrent14 = buildingCurrentStatItem8._tfCurrent;
						int fishPerHour_ = benefitsFishingData7.fishPerHour_;
						tfCurrent14.Text = text24;
						TextBase tfDifference7 = buildingCurrentStatItem8._tfDifference;
						int fishPerHour_2 = benefitsFishingData8.fishPerHour_;
						string text26 = "+" + text25;
						tfDifference7.Text = "";
						buildingCurrentStatItem8._mcDifference.SetActive(active5);
					}
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001072")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public BuildingCurrentLevelContent()
		{
		}
	}
}
