using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Items;
using Mdl.Utils;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C0F")]
	internal class UnlockBuildingAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x60036F5")]
		[Cpp2IlInjected.Address(RVA = "0xD38800", Offset = "0xD37200", VA = "0x180D38800", Slot = "5")]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			ItemScript taskData = task.GetTaskData<ItemScript>();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = taskData.Item;
			int num = 0;
			IBuildingUnlockable buildingUnlockable = default(IBuildingUnlockable);
			Task<bool> task2 = (Task<bool>)(object)BuildingUtil.CheckUnlock(buildingUnlockable, ct, (BuildingUtil.UnlockCheckType)num, true);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60036F6")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public UnlockBuildingAction()
		{
		}
	}
}
