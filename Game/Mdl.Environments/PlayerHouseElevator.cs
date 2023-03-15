using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000664")]
	internal class PlayerHouseElevator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002614")]
		[SerializeField]
		private PlayerTaskDefinition _switchFloorTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002615")]
		public Transform SwitchFloorDestination;

		[Cpp2IlInjected.Token(Token = "0x6001C6F")]
		[Cpp2IlInjected.Address(RVA = "0x14BD720", Offset = "0x14BC120", VA = "0x1814BD720")]
		public void ChooseFloor(int floorIndex)
		{
			//Discarded unreachable code: IL_004f
			IPlayerTaskData[] components = GetComponents<IPlayerTaskData>();
			EnterPlayerHouseFloorTaskData enterPlayerHouseFloorTaskData = new EnterPlayerHouseFloorTaskData();
			enterPlayerHouseFloorTaskData.FloorIndex = floorIndex;
			IEnumerable<EnterPlayerHouseFloorTaskData> enumerable = (IEnumerable<EnterPlayerHouseFloorTaskData>)MoreLinq.Yield<EnterPlayerHouseFloorTaskData>(enterPlayerHouseFloorTaskData);
			IPlayerTaskData[] array = Enumerable.Concat<IPlayerTaskData>((IEnumerable<>)(object)components, (IEnumerable<>)enumerable).ToArray<IPlayerTaskData>();
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C70")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PlayerHouseElevator()
		{
		}
	}
}
