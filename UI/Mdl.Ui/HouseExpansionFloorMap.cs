using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cpp2IlInjected;
using Definitions;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000536")]
	[RequiredAllNotNull]
	public class HouseExpansionFloorMap : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C10")]
		public HouseExpansionMainRoomContent.OnRefreshRequestedDelegate OnRefreshRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001C11")]
		private HouseExpansion _houseExpansion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001C12")]
		[SerializeField]
		private HouseExpansionMainRoomContent _mainRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001C13")]
		[SerializeField]
		private HouseExpansionAdditionalRoomContent _leftRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001C14")]
		[SerializeField]
		private HouseExpansionAdditionalRoomContent _rightRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001C15")]
		[SerializeField]
		private HouseExpansionAdditionalRoomContent _topRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001C16")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.Token(Token = "0x17000543")]
		internal HouseExpansionMainRoomContent MainRoom
		{
			[Cpp2IlInjected.Token(Token = "0x60021D6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _mainRoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021D7")]
		[Cpp2IlInjected.Address(RVA = "0xAEEB20", Offset = "0xAED520", VA = "0x180AEEB20")]
		private void Start()
		{
			//IL_0030: Expected O, but got I4
			HouseExpansionMainRoomContent mainRoom = _mainRoom;
			HouseExpansionMainRoomContent.OnRefreshRequestedDelegate onRefreshRequestedDelegate = OnRefreshHandler;
			Delegate @delegate = Delegate.Combine(onRefreshRequestedDelegate, onRefreshRequestedDelegate);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				mainRoom.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)num;
				HouseExpansionAdditionalRoomContent leftRoom = _leftRoom;
				HouseExpansionMainRoomContent.OnRefreshRequestedDelegate onRefreshRequested = leftRoom.OnRefreshRequested;
				HouseExpansionMainRoomContent.OnRefreshRequestedDelegate b = OnRefreshHandler;
				Delegate delegate2 = Delegate.Combine(onRefreshRequested, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					leftRoom.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)delegate2;
					HouseExpansionAdditionalRoomContent rightRoom = _rightRoom;
					HouseExpansionMainRoomContent.OnRefreshRequestedDelegate onRefreshRequested2 = rightRoom.OnRefreshRequested;
					HouseExpansionMainRoomContent.OnRefreshRequestedDelegate b2 = OnRefreshHandler;
					Delegate delegate3 = Delegate.Combine(onRefreshRequested2, b2);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						rightRoom.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)delegate3;
						HouseExpansionAdditionalRoomContent topRoom = _topRoom;
						HouseExpansionMainRoomContent.OnRefreshRequestedDelegate onRefreshRequested3 = topRoom.OnRefreshRequested;
						HouseExpansionMainRoomContent.OnRefreshRequestedDelegate b3 = OnRefreshHandler;
						Delegate delegate4 = Delegate.Combine(onRefreshRequested3, b3);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							topRoom.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)delegate4;
							throw new NullReferenceException();
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021D8")]
		[Cpp2IlInjected.Address(RVA = "0xAEDA50", Offset = "0xAEC450", VA = "0x180AEDA50")]
		private void OnDestroy()
		{
			//IL_0030: Expected O, but got I4
			HouseExpansionMainRoomContent mainRoom = _mainRoom;
			HouseExpansionMainRoomContent.OnRefreshRequestedDelegate onRefreshRequestedDelegate = OnRefreshHandler;
			Delegate @delegate = Delegate.Remove(onRefreshRequestedDelegate, onRefreshRequestedDelegate);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				mainRoom.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)num;
				HouseExpansionAdditionalRoomContent leftRoom = _leftRoom;
				HouseExpansionMainRoomContent.OnRefreshRequestedDelegate onRefreshRequested = leftRoom.OnRefreshRequested;
				HouseExpansionMainRoomContent.OnRefreshRequestedDelegate value = OnRefreshHandler;
				Delegate delegate2 = Delegate.Remove(onRefreshRequested, value);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					leftRoom.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)delegate2;
					HouseExpansionAdditionalRoomContent rightRoom = _rightRoom;
					HouseExpansionMainRoomContent.OnRefreshRequestedDelegate onRefreshRequested2 = rightRoom.OnRefreshRequested;
					HouseExpansionMainRoomContent.OnRefreshRequestedDelegate value2 = OnRefreshHandler;
					Delegate delegate3 = Delegate.Remove(onRefreshRequested2, value2);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						rightRoom.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)delegate3;
						HouseExpansionAdditionalRoomContent topRoom = _topRoom;
						HouseExpansionMainRoomContent.OnRefreshRequestedDelegate onRefreshRequested3 = topRoom.OnRefreshRequested;
						HouseExpansionMainRoomContent.OnRefreshRequestedDelegate value3 = OnRefreshHandler;
						Delegate delegate4 = Delegate.Remove(onRefreshRequested3, value3);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							topRoom.OnRefreshRequested = (HouseExpansionMainRoomContent.OnRefreshRequestedDelegate)delegate4;
							throw new NullReferenceException();
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021D9")]
		[Cpp2IlInjected.Address(RVA = "0x998E10", Offset = "0x997810", VA = "0x180998E10")]
		private void OnRefreshHandler()
		{
			OnRefreshRequested?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60021DA")]
		[Cpp2IlInjected.Address(RVA = "0xAEDCA0", Offset = "0xAEC6A0", VA = "0x180AEDCA0")]
		internal void RefreshFloor(House.Types.Floor currentFloorMap, int currentFloorIndex)
		{
			//IL_0041: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_016a: Expected I4, but got I8
			//IL_017c: Expected I4, but got I8
			//IL_018e: Expected I4, but got I8
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			HouseExpansion.Types.InteriorExpansion interior_ = _houseExpansion.interior_;
			GridCollection gridCollection_ = SystemRoot.Instance.MetaClient.profile.world_.gridCollection_;
			MapField<int, House.Types.Room> rooms_ = currentFloorMap.rooms_;
			int num = 0;
			House.Types.Room room = (House.Types.Room)((MapField<TKey, TValue>)(object)rooms_)[(TKey)num];
			HouseExpansion houseExpansion = _houseExpansion;
			ulong num2 = default(ulong);
			if (num2 != 0)
			{
			}
			int num3 = 0;
			int num4 = houseExpansion.GetExpansionIndex((string)num3) + 1;
			HouseExpansion.Types.InteriorExpansion.Types.ExpansionData expansionData = Enumerable.ElementAtOrDefault<HouseExpansion.Types.InteriorExpansion.Types.ExpansionData>((IEnumerable<>)(object)interior_.increaseMainRoomSize_, num4);
			_mainRoom.CurrentFloorIndex = currentFloorIndex;
			MapField<int, House.Types.Room> rooms_2 = currentFloorMap.rooms_;
			HouseExpansionMainRoomContent mainRoom = _mainRoom;
			int num5 = 0;
			House.Types.Room room2 = (House.Types.Room)((MapField<TKey, TValue>)(object)rooms_2)[(TKey)num5];
			mainRoom.Refresh(room2, expansionData);
			SpriteAtlasImage mcBackground = default(SpriteAtlasImage);
			if (expansionData == null)
			{
				MapField<int, House.Types.Floor.Types.AdditionalRoomsList> boughtRooms_ = currentFloorMap.boughtRooms_;
				Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool> func = default(Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>);
				if (_003C_003Ec._003C_003E9__12_0 == null)
				{
					bool result6 = default(bool);
					func = (Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList> x) => result6));
				}
				KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>[] array = Enumerable.Where<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>((IEnumerable<>)(object)boughtRooms_, (Func<, >)(object)func).ToArray<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>();
				MapField<int, House.Types.Floor.Types.AdditionalRoomsList> boughtRooms_2 = currentFloorMap.boughtRooms_;
				Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool> func2 = default(Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>);
				if (_003C_003Ec._003C_003E9__12_1 == null)
				{
					bool result5 = default(bool);
					func2 = (Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList> x) => result5));
				}
				KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>[] array2 = Enumerable.Where<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>((IEnumerable<>)(object)boughtRooms_2, (Func<, >)(object)func2).ToArray<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>();
				MapField<int, House.Types.Floor.Types.AdditionalRoomsList> boughtRooms_3 = currentFloorMap.boughtRooms_;
				Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool> func3 = default(Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>);
				if (_003C_003Ec._003C_003E9__12_2 == null)
				{
					bool result4 = default(bool);
					func3 = (Func<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList> x) => result4));
				}
				KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>[] array3 = Enumerable.Where<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>((IEnumerable<>)(object)boughtRooms_3, (Func<, >)(object)func3).ToArray<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>();
				ulong num6 = default(ulong);
				_leftRoom.gameObject.SetActive((byte)num6 != 0);
				ulong num7 = default(ulong);
				_rightRoom.gameObject.SetActive((byte)num7 != 0);
				ulong num8 = default(ulong);
				_topRoom.gameObject.SetActive((byte)num8 != 0);
				_leftRoom.CurrentFloorIndex = currentFloorIndex;
				_rightRoom.CurrentFloorIndex = currentFloorIndex;
				_topRoom.CurrentFloorIndex = currentFloorIndex;
				HouseExpansionAdditionalRoomContent leftRoom = _leftRoom;
				if (_003C_003Ec._003C_003E9__12_3 == null)
				{
					bool result3 = default(bool);
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, House.Types.Room> x) => result3);
				}
				HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] array4 = ((IEnumerable<>)(object)interior_.additionalRooms_).ToArray<HouseExpansion.Types.InteriorExpansion.Types.ExpansionData>();
				HouseExpansionAdditionalRoomContent rightRoom = _rightRoom;
				if (_003C_003Ec._003C_003E9__12_4 == null)
				{
					bool result2 = default(bool);
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, House.Types.Room> x) => result2);
				}
				HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] array5 = ((IEnumerable<>)(object)interior_.additionalRooms_).ToArray<HouseExpansion.Types.InteriorExpansion.Types.ExpansionData>();
				HouseExpansionAdditionalRoomContent topRoom = _topRoom;
				if (_003C_003Ec._003C_003E9__12_5 == null)
				{
					bool result = default(bool);
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, House.Types.Room> x) => result);
				}
				HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] array6 = ((IEnumerable<>)(object)interior_.additionalRooms_).ToArray<HouseExpansion.Types.InteriorExpansion.Types.ExpansionData>();
				HouseExpansionMainRoomContent mainRoom2 = _mainRoom;
				int num9 = Enumerable.Count<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>((IEnumerable<>)(object)array);
				int num10 = Enumerable.Count<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>((IEnumerable<>)(object)array2);
				int num11 = Enumerable.Count<KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>>((IEnumerable<>)(object)array3);
				string text = "";
				if (num9 > 0)
				{
					text = "_left";
				}
				string text2 = text + "_right" + "_top";
				mcBackground = mainRoom2._mcBackground;
				string text4 = (mcBackground.ImageAddress = "img_room_main_door" + text2);
				return;
			}
			GameObject gameObject = mcBackground.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			int active2 = 0;
			GameObject gameObject2 = default(GameObject);
			gameObject2.SetActive((byte)active2 != 0);
			int active3 = 0;
			GameObject gameObject3 = default(GameObject);
			gameObject3.SetActive((byte)active3 != 0);
			string text5 = $"img_room_main_door_ex_{gameObject3}";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021DB")]
		[Cpp2IlInjected.Address(RVA = "0xAEE870", Offset = "0xAED270", VA = "0x180AEE870")]
		public void SetFocus(FocusNavigation focus)
		{
			//IL_005e: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			if (focus._focusedElement == null)
			{
			}
			int num = 0;
			bool flag = default(bool);
			int num2 = default(int);
			if (!_mainRoom._btnExpand.gameObject.activeInHierarchy && flag)
			{
				GameObject gameObject = default(GameObject);
				string a = gameObject.name;
				string b = _mainRoom._btnExpand.gameObject.name;
				if (string.Equals(a, b))
				{
					num2 = 0;
					int num3 = 0;
					focus.SetFocus((FocusNavigationElement)num3);
				}
			}
			if (!_mainRoom._btnExpand.gameObject.activeInHierarchy)
			{
				int num4 = 0;
				if (!((UnityEngine.Object)num2 == (UnityEngine.Object)num4))
				{
					Transform parent = base.transform;
					Transform transform = default(Transform);
					if (transform.IsChildOf(parent) || !_mainRoom._btnEdit.gameObject.activeInHierarchy)
					{
						return;
					}
				}
				FocusNavigationElement component = _mainRoom._btnEdit.GetComponent<FocusNavigationElement>();
				focus.SetFocus(component);
				return;
			}
			HouseExpansionMainRoomContent mainRoom = _mainRoom;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021DC")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HouseExpansionFloorMap()
		{
		}
	}
}
