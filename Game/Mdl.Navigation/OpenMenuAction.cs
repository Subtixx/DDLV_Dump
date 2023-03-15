using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Ui;
using Mdl.Utils;
using UnityEngine.AddressableAssets;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BD7")]
	internal class OpenMenuAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x600364F")]
		[Cpp2IlInjected.Address(RVA = "0xF05DE0", Offset = "0xF047E0", VA = "0x180F05DE0", Slot = "5")]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			//Discarded unreachable code: IL_003e
			base.CanBeResumed = false;
			OpenMenuPlayerTaskData taskData = task.GetTaskData<OpenMenuPlayerTaskData>();
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			AssetReference menuToOpen = taskData.menuToOpen;
			object[] parameters = taskData.GetParameters();
			int isPopup = 0;
			_003CInstance_003Ek__BackingField.OpenMenu(menuToOpen, (byte)isPopup != 0, waitUntilExit: true, parameters).FireAndForgetTask();
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6003650")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public OpenMenuAction()
		{
		}
	}
}
