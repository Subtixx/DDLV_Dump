using System;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200078F")]
	public class OpenExpansionMenuPlayerTaskData : OpenMenuPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x6002196")]
		[Cpp2IlInjected.Address(RVA = "0xF057E0", Offset = "0xF041E0", VA = "0x180F057E0", Slot = "4")]
		public override object[] GetParameters()
		{
			//Discarded unreachable code: IL_009e
			GameObject gameObject = default(GameObject);
			Action<int> action;
			object[] array;
			while (true)
			{
				int count = ((RepeatedField<T>)(object)SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.floors_).Count;
				int handle = base.gameObject.scene.m_Handle;
				int _003CActiveFloorIndex_003Ek__BackingField = gameObject.GetComponent<PlayerHouseEnvironment>().ActiveFloorIndex;
				action = (Action<int>)(object)new Action<T>(GetComponent<PlayerHouseElevator>().ChooseFloor);
				array = new object[3];
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				if (array == null || array != null)
				{
					array[1] = array;
					if (action == null || array != null)
					{
						break;
					}
				}
			}
			array[2] = action;
			return array;
		}

		[Cpp2IlInjected.Token(Token = "0x6002197")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public OpenExpansionMenuPlayerTaskData()
		{
		}
	}
}
