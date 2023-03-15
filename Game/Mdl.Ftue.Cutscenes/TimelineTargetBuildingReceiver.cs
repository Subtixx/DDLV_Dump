using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Buildings;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005E1")]
	public class TimelineTargetBuildingReceiver : MonoBehaviour, INotificationReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023D7")]
		private List<GameObject> buildingsInGame = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6001A1A")]
		[Cpp2IlInjected.Address(RVA = "0x13D0D70", Offset = "0x13CF770", VA = "0x1813D0D70")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0088
			//IL_0064: Expected O, but got I4
			((List<T>)(object)buildingsInGame).Clear();
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			UpgradableBuilding[] componentsInChildren = gameObject.GetComponentsInChildren<UpgradableBuilding>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				UpgradableBuilding upgradableBuilding = componentsInChildren[num];
				ItemScript component = upgradableBuilding.GetComponent<ItemScript>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					List<GameObject> list = buildingsInGame;
					GameObject item = upgradableBuilding.gameObject;
					((List<T>)(object)list).Add((T)item);
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A1B")]
		[Cpp2IlInjected.Address(RVA = "0x13D0FD0", Offset = "0x13CF9D0", VA = "0x1813D0FD0", Slot = "4")]
		public void OnNotify(Playable origin, INotification notification, object context)
		{
			//Discarded unreachable code: IL_021b
			//IL_0047: Expected O, but got I4
			//IL_0076: Expected O, but got I8
			//IL_01cb: Expected O, but got I4
			//IL_01e2: Expected O, but got I4
			if (notification == null)
			{
			}
			int num = 0;
			TimelineTargetBuildingMarker marker = (TimelineTargetBuildingMarker)notification;
			if ((long)marker == 0)
			{
				return;
			}
			if (marker.reset)
			{
				Cutscene componentInParent = GetComponentInParent<Cutscene>();
				int num2 = 0;
				if (componentInParent != (UnityEngine.Object)num2)
				{
					Transform transform = componentInParent.transform;
					float z = Vector3.zero.z;
					Transform transform2 = componentInParent.transform;
					Quaternion identity = Quaternion.identity;
				}
			}
			GameObject obj = (GameObject)0;
			TimelineTargetBuildingMarker timelineTargetBuildingMarker = marker;
			List<GameObject> list = buildingsInGame;
			if (!timelineTargetBuildingMarker.useRandomBuilding)
			{
				Func<GameObject, bool> func = (Func<GameObject, bool>)(object)(Func<T, TResult>)delegate(GameObject x)
				{
					//Discarded unreachable code: IL_001d
					Item item4 = x.GetComponent<ItemScript>().Item;
					TimelineTargetBuildingMarker timelineTargetBuildingMarker2 = marker;
					return (IntPtr)item4 == (IntPtr)timelineTargetBuildingMarker2.buildingId;
				};
				obj = Enumerable.FirstOrDefault<GameObject>((IEnumerable<>)list, (Func<, >)(object)func);
			}
			CurseSystem curseSystem = default(CurseSystem);
			CurseSystem curseSys = curseSystem;
			Func<GameObject, bool> func2 = (Func<GameObject, bool>)(object)(Func<T, TResult>)delegate(GameObject x)
			{
				//Discarded unreachable code: IL_0015
				CurseSystem curseSystem2 = curseSys;
				Item item3 = x.GetComponent<ItemScript>().Item;
				bool result = default(bool);
				return result;
			};
			List<GameObject> list2 = (List<GameObject>)(object)Enumerable.ToList<GameObject>(Enumerable.Where<GameObject>((IEnumerable<>)list, (Func<, >)(object)func2));
			List<GameObject> list3 = default(List<GameObject>);
			if (marker.ignoreStalls)
			{
				Func<GameObject, bool> func3 = default(Func<GameObject, bool>);
				if (_003C_003Ec._003C_003E9__2_1 == null)
				{
					func3 = (Func<GameObject, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GameObject x)
					{
						//Discarded unreachable code: IL_0016
						//IL_0015: Expected O, but got I4
						Stall component3 = x.gameObject.GetComponent<Stall>();
						int num9 = 0;
						return component3 == (UnityEngine.Object)num9;
					});
				}
				list3 = (List<GameObject>)(object)Enumerable.ToList<GameObject>(Enumerable.Where<GameObject>((IEnumerable<>)list2, (Func<, >)(object)func3));
			}
			List<GameObject> list4 = default(List<GameObject>);
			if (marker.ignoreWells)
			{
				Func<GameObject, bool> func4 = default(Func<GameObject, bool>);
				if (_003C_003Ec._003C_003E9__2_2 == null)
				{
					func4 = (Func<GameObject, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GameObject x)
					{
						//Discarded unreachable code: IL_0016
						//IL_0015: Expected O, but got I4
						FastTravelDestination component2 = x.gameObject.GetComponent<FastTravelDestination>();
						int num8 = 0;
						return component2 == (UnityEngine.Object)num8;
					});
				}
				list4 = (List<GameObject>)(object)Enumerable.ToList<GameObject>(Enumerable.Where<GameObject>((IEnumerable<>)list3, (Func<, >)(object)func4));
			}
			List<int> buildingsToIgnore = marker.buildingsToIgnore;
			Func<GameObject, bool> func5 = (Func<GameObject, bool>)(object)(Func<T, TResult>)delegate(GameObject x)
			{
				//Discarded unreachable code: IL_0028
				//IL_0024: Expected O, but got I4
				List<int> buildingsToIgnore2 = marker.buildingsToIgnore;
				int itemID2 = x.GetComponent<ItemScript>().Item.ItemID;
				return !((List<T>)(object)buildingsToIgnore2).Contains((T)itemID2);
			};
			obj = ((IEnumerable<>)Enumerable.ToList<GameObject>(Enumerable.Where<GameObject>((IEnumerable<>)list4, (Func<, >)(object)func5))).RandomElement<GameObject>();
			List<GameObject> list5 = buildingsInGame;
			Predicate<GameObject> predicate = (Predicate<GameObject>)(object)(Predicate<T>)delegate(GameObject x)
			{
				//Discarded unreachable code: IL_0037
				ItemScript component = x.GetComponent<ItemScript>();
				if ((object)component != null)
				{
					Item item = component.Item;
					int num6 = 0;
					int itemID = item.ItemID;
				}
				int num7 = 0;
				Item item2 = obj.GetComponent<ItemScript>().Item;
				return (IntPtr)num7 == (IntPtr)item2;
			};
			int num3 = ((List<T>)(object)list5).RemoveAll((Predicate<>)(object)predicate);
			GameObject gameObject = obj;
			int num4 = 0;
			if (gameObject != (UnityEngine.Object)num4)
			{
				Cutscene componentInParent2 = GetComponentInParent<Cutscene>();
				int num5 = 0;
				if (componentInParent2 != (UnityEngine.Object)num5)
				{
					Transform transform3 = componentInParent2.transform;
					Transform transform4 = obj.transform;
					Vector3 vector = default(Vector3);
					float z2 = vector.z;
					Transform transform5 = componentInParent2.transform;
					Transform transform6 = obj.transform;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A1C")]
		[Cpp2IlInjected.Address(RVA = "0x13D17F0", Offset = "0x13D01F0", VA = "0x1813D17F0")]
		public TimelineTargetBuildingReceiver()
		{
		}
	}
}
