using System;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Systems;
using Mdl.Ui;
using Meta;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C52")]
	[CreateAssetMenu]
	internal class PlantSeedHoldBehaviour : FindAdjacentObjectHoldBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40044B1")]
		public AssetReferenceGameObject selectedSeedGizmoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40044B2")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x170007A0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x78"), Cpp2IlInjected.Token(Token = "0x40044B3")]
		public Item SeedItem
		{
			[Cpp2IlInjected.Token(Token = "0x60038A1")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60038A2")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60038A3")]
		[Cpp2IlInjected.Address(RVA = "0xF133A0", Offset = "0xF11DA0", VA = "0x180F133A0", Slot = "5")]
		public override void Init(PlayerTask initialTask)
		{
			//Discarded unreachable code: IL_00ac
			while (true)
			{
				base.Init(initialTask);
				if (!selectedSeedGizmoPrefab.RuntimeKeyIsValid())
				{
					break;
				}
				CancellationTokenSource cancellationTokenSource = (this.cancellationTokenSource = new CancellationTokenSource());
				BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				CancellationTokenSource cancellationTokenSource2 = this.cancellationTokenSource;
				GameObject _003CgameObject_003Ek__BackingField = avatar.gameObject;
				AssetReferenceGameObject infoGizmoPrefab = selectedSeedGizmoPrefab;
				CancellationToken token = cancellationTokenSource2.Token;
				object[] array = new object[2];
				Item item = SeedItem;
				if (array == null || array != null)
				{
					array[0] = array;
					InteractPreviewData interactPreviewData = InteractPreviewData;
					if ((object)interactPreviewData == null || array != null)
					{
						array[1] = interactPreviewData;
						_003CInstance_003Ek__BackingField.DisplayInfoGizmo(_003CgameObject_003Ek__BackingField, infoGizmoPrefab, token, array).FireAndForgetTask();
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038A4")]
		[Cpp2IlInjected.Address(RVA = "0xF13110", Offset = "0xF11B10", VA = "0x180F13110", Slot = "6")]
		public override bool DoUpdate(float dt)
		{
			//IL_0037: Expected O, but got I4
			PlayerTask playerTask = default(PlayerTask);
			while (true)
			{
				bool flag = base.DoUpdate(dt);
				if (flag)
				{
					ContainerInventory backpack = SystemRoot.Instance.MetaClient.profile.player_.Backpack;
					Item item = SeedItem;
					int num = 0;
					if (backpack.GetItemAmount(item, (ItemState)num) != 0)
					{
						if (playerTask.GetTaskData<PlantSeedActionSeedChoice>() == null)
						{
							break;
						}
						continue;
					}
				}
				if ((long)cancellationTokenSource != 0)
				{
				}
				return flag;
			}
			PlantSeedActionSeedChoice plantSeedActionSeedChoice = new PlantSeedActionSeedChoice();
			plantSeedActionSeedChoice.ChosenSeed = (Item)plantSeedActionSeedChoice;
			PlayerTask playerTask2 = default(PlayerTask);
			playerTask2.AddTaskData(plantSeedActionSeedChoice);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60038A5")]
		[Cpp2IlInjected.Address(RVA = "0xF13330", Offset = "0xF11D30", VA = "0x180F13330", Slot = "7")]
		public override void End()
		{
			((object)this)._002Ector();
			if ((long)cancellationTokenSource == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038A6")]
		[Cpp2IlInjected.Address(RVA = "0xA8B070", Offset = "0xA89A70", VA = "0x180A8B070")]
		public PlantSeedHoldBehaviour()
		{
		}
	}
}
