using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005DC")]
	public class TimelineRemoveGridObject : MonoBehaviour, ITimelineCutsceneCleanUp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023CF")]
		[SerializeField]
		[ItemID]
		private int itemIDToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40023D0")]
		public bool triggerRequired = true;

		[Cpp2IlInjected.Token(Token = "0x6001A09")]
		[Cpp2IlInjected.Address(RVA = "0x13D00F0", Offset = "0x13CEAF0", VA = "0x1813D00F0")]
		public void RemoveGridObject()
		{
			//Discarded unreachable code: IL_002d
			//IL_001b: Expected I4, but got O
			//IL_002a: Expected O, but got I4
			(IGrid, GridObject) tuple = default((IGrid, GridObject));
			if ((object)tuple != null)
			{
				RemoveFromGrid.Types.Request request = new RemoveFromGrid.Types.Request();
				int num = 0;
				num += num;
				num++;
				request.gridID_ = (uint)(int)request;
				request.gridObjectID_ = 0u;
				Client client = default(Client);
				Task<RemoveFromGrid.Types.Response> task = (Task<RemoveFromGrid.Types.Response>)(object)client.RemoveFromGrid(request, (CancellationToken)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A0A")]
		[Cpp2IlInjected.Address(RVA = "0x13CFA60", Offset = "0x13CE460", VA = "0x1813CFA60")]
		private (IGrid, GridObject) FindObjectInGrid()
		{
			//Discarded unreachable code: IL_009a, IL_00a0, IL_00a6, IL_00b2, IL_00b8
			//IL_0038: Expected I4, but got O
			bool flag = default(bool);
			GardenData gardenData = default(GardenData);
			GardenData gardenData2 = default(GardenData);
			Func<GardenData.Types.GardeningSlot, bool> cpp2il__autoParamName__idx_ = default(Func<GardenData.Types.GardeningSlot, bool>);
			int num6 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				IEnumerable<IGrid> allGrids = (IEnumerable<IGrid>)SystemRoot.Instance.MetaClient.profile.world_.gridCollection_.get_AllGrids();
				if (allGrids != null)
				{
					List<GridObject> list = (List<GridObject>)(object)new List<T>((int)allGrids);
					if (flag)
					{
						if (1u != 0 && gardenData != null && ((IEnumerable<>)(object)gardenData2.slots_).Any<GardenData.Types.GardeningSlot>((Func<, >)(object)cpp2il__autoParamName__idx_))
						{
							int num4 = 0;
							num3++;
						}
						int num5 = 0;
						num3++;
					}
					num3++;
					if (num3 != 0)
					{
						break;
					}
					while (num3 == 0)
					{
					}
				}
				num6++;
				if (allGrids != null)
				{
				}
				if (num3 == 0)
				{
					if (num6 != 0)
					{
					}
					int num7 = 0;
					int num8 = 0;
					int num9 = 0;
					throw new NullReferenceException();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A0B")]
		[Cpp2IlInjected.Address(RVA = "0x13CF890", Offset = "0x13CE290", VA = "0x1813CF890", Slot = "4")]
		public void EndCutsceneCleanup()
		{
			//Discarded unreachable code: IL_003b
			//IL_0028: Expected I4, but got O
			//IL_0038: Expected O, but got I4
			(IGrid, GridObject) tuple = default((IGrid, GridObject));
			(IGrid, GridObject) tuple2 = default((IGrid, GridObject));
			if (triggerRequired && (object)tuple != null && (object)tuple2 != null)
			{
				RemoveFromGrid.Types.Request request = new RemoveFromGrid.Types.Request();
				int num = 0;
				num += num;
				num++;
				request.gridID_ = (uint)(int)request;
				request.gridObjectID_ = 0u;
				Client client = default(Client);
				Task<RemoveFromGrid.Types.Response> task = (Task<RemoveFromGrid.Types.Response>)(object)client.RemoveFromGrid(request, (CancellationToken)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A0C")]
		[Cpp2IlInjected.Address(RVA = "0x13CD770", Offset = "0x13CC170", VA = "0x1813CD770")]
		public TimelineRemoveGridObject()
		{
		}
	}
}
