using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Missions;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002A0")]
	[RequiredAllNotNull]
	public class BuildingLevelStatsContent : InMenuMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000BD2")]
		[SerializeField]
		private ListBase _listStats;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000BD3")]
		[SerializeField]
		private TextBase[] _listLabels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000BD4")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000BD5")]
		private RepeatedField<UpgradeData> _upgradeInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000BD6")]
		private bool constructed;

		[Cpp2IlInjected.Token(Token = "0x6001076")]
		[Cpp2IlInjected.Address(RVA = "0xA696C0", Offset = "0xA680C0", VA = "0x180A696C0")]
		internal void RefreshDisplay(UpgradeData currentUpgradeInfo, RepeatedField<UpgradeData> upgradeInfo, string Title)
		{
			//Discarded unreachable code: IL_0201
			if (!constructed)
			{
				ListBase.ListEvents onItemData = _listStats.m_OnItemData;
				UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnLevelListItemDataHandler);
				((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
				constructed = true;
			}
			_tfTitle.StringID = Title;
			_listLabels[1].StringID = "menu.building_required_player_level";
			UpgradeData.BenefitsOneofCase benefitsCase_ = currentUpgradeInfo.benefitsCase_;
			if (currentUpgradeInfo != null)
			{
				if (currentUpgradeInfo != null)
				{
					if (currentUpgradeInfo != null)
					{
						if (benefitsCase_ != (UpgradeData.BenefitsOneofCase)1)
						{
							goto IL_01e0;
						}
						_listLabels[2].StringID = "menu.building_number_of_slots_label";
						_listLabels[3].StringID = "menu.building_burning_state_duration_label";
						GameObject gameObject = _listLabels[4].gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
						TextBase[] listLabels = _listLabels;
					}
					_listLabels[2].StringID = "menu.building_number_of_slots_label";
					_listLabels[3].StringID = "menu.building_refresh_cost_label";
					GameObject gameObject2 = _listLabels[4].gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
					TextBase[] listLabels2 = _listLabels;
				}
				_listLabels[2].StringID = "menu.building_number_of_slots_label";
				_listLabels[3].StringID = "menu.building_goofy_fund_label";
				_listLabels[4].StringID = "menu.building_refresh_cost_label";
				TextBase[] listLabels3 = _listLabels;
			}
			GameObject gameObject3 = _listLabels[1].gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			_listLabels[2].StringID = "menu.building_fish_cap_label";
			_listLabels[3].StringID = "menu.building_fish_per_hour_label";
			_listLabels[4].StringID = "menu.building_energy_cost_reduction_label";
			GameObject gameObject4 = _listLabels[5].gameObject;
			int active4 = 0;
			gameObject4.SetActive((byte)active4 != 0);
			goto IL_01e0;
			IL_01e0:
			_upgradeInfo = upgradeInfo;
			ListBase listStats = _listStats;
			int num = (listStats.TotalCount = ((RepeatedField<T>)(object)upgradeInfo).Count);
		}

		[Cpp2IlInjected.Token(Token = "0x6001077")]
		[Cpp2IlInjected.Address(RVA = "0xA69430", Offset = "0xA67E30", VA = "0x180A69430")]
		private void Construct()
		{
			//Discarded unreachable code: IL_0028
			ListBase.ListEvents onItemData = _listStats.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnLevelListItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			constructed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001078")]
		[Cpp2IlInjected.Address(RVA = "0xA694F0", Offset = "0xA67EF0", VA = "0x180A694F0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0021
			ListBase.ListEvents onItemData = _listStats.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnLevelListItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6001079")]
		[Cpp2IlInjected.Address(RVA = "0xA695B0", Offset = "0xA67FB0", VA = "0x180A695B0")]
		private void OnLevelListItemDataHandler(ListBase.ListEventData arg0)
		{
			//Discarded unreachable code: IL_0058
			//IL_0015: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			BuildingLevelItem component = arg0.DisplayObject.GetComponent<BuildingLevelItem>();
			int num = 0;
			if (!(component == (Object)num))
			{
				int itemIndex = arg0.ItemIndex;
				int num2 = 0;
				if (itemIndex > 0)
				{
					UpgradeData upgradeData = (UpgradeData)((RepeatedField<T>)(object)_upgradeInfo)[itemIndex];
				}
				RepeatedField<UpgradeData> upgradeInfo = _upgradeInfo;
				int itemIndex2 = arg0.ItemIndex;
				UpgradeData upgradeData2 = (UpgradeData)((RepeatedField<T>)(object)upgradeInfo)[itemIndex2];
				component.RefreshDisplay(upgradeData2, (UpgradeData)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600107A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public BuildingLevelStatsContent()
		{
			((Mdl.Missions.SavannahWaterBlocker)(object)this)._002Ector();
		}
	}
}
