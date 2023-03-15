using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Items;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009F1")]
	public class UpgradeWishWell : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40036C4")]
		[SerializeField]
		private GameObject model;

		[Cpp2IlInjected.Token(Token = "0x6002E84")]
		[Cpp2IlInjected.Address(RVA = "0xD3F1A0", Offset = "0xD3DBA0", VA = "0x180D3F1A0")]
		private void Start()
		{
			Refresh(forceRefresh: true).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E85")]
		[Cpp2IlInjected.Address(RVA = "0xD3ED20", Offset = "0xD3D720", VA = "0x180D3ED20")]
		private void OnAchievementSetUpdated(Item achID, bool milestonePassed)
		{
			int forceRefresh = 0;
			Refresh((byte)forceRefresh != 0).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E86")]
		[Cpp2IlInjected.Address(RVA = "0xD3ED90", Offset = "0xD3D790", VA = "0x180D3ED90")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0045
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.AchievementSetUpdated value = OnAchievementSetUpdated;
					_003CDispatcher_003Ek__BackingField.OnAchievementSetUpdated -= value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E87")]
		[Cpp2IlInjected.Address(RVA = "0xD3F080", Offset = "0xD3DA80", VA = "0x180D3F080")]
		[AsyncStateMachine(typeof(_003CRefresh_003Ed__4))]
		private Task Refresh(bool forceRefresh = false)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E88")]
		[Cpp2IlInjected.Address(RVA = "0xD3EF50", Offset = "0xD3D950", VA = "0x180D3EF50")]
		[AsyncStateMachine(typeof(_003CRefreshModel_003Ed__5))]
		private Task RefreshModel(UpgradeData upgradeInfo)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E89")]
		[Cpp2IlInjected.Address(RVA = "0xD3EA00", Offset = "0xD3D400", VA = "0x180D3EA00")]
		private UpgradeData GetUpgradeLevelInfo()
		{
			int achievementPercent = SystemRoot.Instance.MetaClient.profile.player_.GetAchievementsCompletePercentage();
			ItemScript componentInParent = GetComponentInParent<ItemScript>();
			if ((object)componentInParent != null)
			{
				Item item = componentInParent.Item;
				if ((object)componentInParent.Item == null)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Item item2 = componentInParent.Item;
					BuildingItemData buildingItemData = default(BuildingItemData);
					if (buildingItemData != null)
					{
						RepeatedField<UpgradeData> upgradeInfo = (RepeatedField<UpgradeData>)(object)buildingItemData.get_UpgradeInfo();
						if (upgradeInfo != null && ((RepeatedField<T>)(object)upgradeInfo).Count > 0)
						{
							Func<UpgradeData, bool> func = (Func<UpgradeData, bool>)(object)(Func<T, TResult>)delegate(UpgradeData x)
							{
								//Discarded unreachable code: IL_0014
								int num2 = achievementPercent;
								return x.level_ <= num2;
							};
							return Enumerable.LastOrDefault<UpgradeData>((IEnumerable<>)(object)upgradeInfo, (Func<, >)(object)func);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E8A")]
		[Cpp2IlInjected.Address(RVA = "0xD3E6D0", Offset = "0xD3D0D0", VA = "0x180D3E6D0")]
		private bool CanUpgrade()
		{
			ItemScript componentInParent = GetComponentInParent<ItemScript>();
			if ((object)componentInParent != null)
			{
				Item item = componentInParent.Item;
				if ((object)componentInParent.Item == null)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Item item2 = componentInParent.Item;
					BuildingItemData buildingItemData = default(BuildingItemData);
					if (buildingItemData != null)
					{
						RepeatedField<UpgradeData> upgradeInfo = (RepeatedField<UpgradeData>)(object)buildingItemData.get_UpgradeInfo();
						if (upgradeInfo != null && ((RepeatedField<T>)(object)upgradeInfo).Count > 0)
						{
							Func<UpgradeData, int> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
							if (_003C_003E9__7_ == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.level_);
							}
							int num = Enumerable.Max<UpgradeData>((IEnumerable<>)(object)upgradeInfo, (Func<, >)(object)_003C_003E9__7_);
							Client client = default(Client);
							int achievementsCompletePercentage = client.profile.player_.GetAchievementsCompletePercentage();
							return num > achievementsCompletePercentage;
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E8B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public UpgradeWishWell()
		{
		}
	}
}
