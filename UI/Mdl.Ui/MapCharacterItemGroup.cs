using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters;
using Mdl.Items;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000626")]
	[RequiredAllNotNull]
	public class MapCharacterItemGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002243")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002244")]
		private List<MapCharacterItem> _mapCharacterItems;

		[Cpp2IlInjected.Token(Token = "0x6002826")]
		[Cpp2IlInjected.Address(RVA = "0xFB0210", Offset = "0xFAEC10", VA = "0x180FB0210")]
		public void RefreshData(Camera camera, GameObject prefabCharacterItem, Transform container, Transform position, List<MapCharacterItem> mapCharacterItems, List<ItemScript> buildings, Action<MapItem> onMapItemClicked)
		{
			//Discarded unreachable code: IL_00c6, IL_00cc, IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_00ea, IL_00f0, IL_00f6, IL_00fc
			//IL_0087: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			CharacterManager system;
			uint num4 = default(uint);
			Predicate<ItemScript> predicate = default(Predicate<ItemScript>);
			int num5 = default(int);
			ScheduleType scheduleType = default(ScheduleType);
			ItemScript itemScript = default(ItemScript);
			Meta.Character character = default(Meta.Character);
			Meta.Character character2 = default(Meta.Character);
			GameObject gameObject = default(GameObject);
			do
			{
				int num = 0;
				_camera = camera;
				system = SystemRoot.Instance.GetSystem<CharacterManager>();
				DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
				int num2 = 0;
				int num3 = 0;
				IEnumerable<CharacterManager.CharacterInstance> characterInstances = (IEnumerable<CharacterManager.CharacterInstance>)system.GetCharacterInstances((byte)num3 != 0);
				if (characterInstances != null)
				{
					_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
					if (num < (int)num4)
					{
						num += num;
						if (num == (int)num4)
						{
							goto IL_0074;
						}
						num++;
					}
					CS_0024_003C_003E8__locals0.characterInstance = (CharacterManager.CharacterInstance)(object)CS_0024_003C_003E8__locals0;
					predicate = (Predicate<ItemScript>)(object)(Predicate<T>)delegate(ItemScript x)
					{
						Item item = x.Item;
						int house = CS_0024_003C_003E8__locals0.characterInstance.Data.House;
						throw new NullReferenceException();
					};
					num5 = (int)scheduleType;
					if (num2 != 0)
					{
						goto IL_0074;
					}
					goto IL_007b;
				}
				goto IL_00b0;
				IL_0074:
				predicate += predicate;
				goto IL_007b;
				IL_007b:
				int num6 = 0;
				if (!(itemScript != (UnityEngine.Object)num6))
				{
				}
				if (num5 == 2)
				{
				}
				if (character == null || character2.InVillage)
				{
				}
				while (character2 == null)
				{
				}
				gameObject.GetComponent<MapCharacterItem>().OnMapItemClicked = (Action<MapItem>)0;
				goto IL_00b0;
				IL_00b0:
				if (characterInstances != null)
				{
				}
			}
			while ((object)system != null);
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002827")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MapCharacterItemGroup()
		{
		}
	}
}
