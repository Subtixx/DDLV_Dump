using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Ui;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C14")]
	internal class UseFastTravelAction : PlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400436E")]
		[SerializeField]
		private AssetReference _mapMenu;

		[Cpp2IlInjected.Token(Token = "0x6003701")]
		[Cpp2IlInjected.Address(RVA = "0xD3F210", Offset = "0xD3DC10", VA = "0x180D3F210", Slot = "5")]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0061
			AssetReference mapMenu;
			BaseUiRoot _003CInstance_003Ek__BackingField;
			object[] array;
			MapMenuParams mapMenuParams;
			do
			{
				base.CanBeResumed = false;
				mapMenu = _mapMenu;
				_003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
				array = new object[1];
				mapMenuParams = new MapMenuParams();
				mapMenuParams.ShowFastTravelDestinations = true;
			}
			while ((object)(mapMenuParams.FastTravelOrigin = task.GetTaskData<FastTravelDestination>()) == null);
			array[0] = mapMenuParams;
			int isPopup = 0;
			_003CInstance_003Ek__BackingField.OpenMenu(mapMenu, (byte)isPopup != 0, waitUntilExit: true, array).FireAndForgetTask();
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6003702")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public UseFastTravelAction()
		{
		}
	}
}
