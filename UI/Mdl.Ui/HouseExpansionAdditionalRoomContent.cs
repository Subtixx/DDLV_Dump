using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200052A")]
	[RequiredAllNotNull]
	public class HouseExpansionAdditionalRoomContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001BD0")]
		public HouseExpansionMainRoomContent.OnRefreshRequestedDelegate OnRefreshRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001BD1")]
		[SerializeField]
		private ButtonTmProIcon _btnEdit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001BD2")]
		[SerializeField]
		private SpriteAtlasImage _mcEditIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001BD3")]
		[SerializeField]
		private House.Types.RoomSlot _roomSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001BD4")]
		[SerializeField]
		private RectTransform _mcEmptyBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001BD5")]
		[SerializeField]
		private SpriteAtlasImage _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001BD6")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001BD7")]
		[SerializeField]
		private AsyncMenu _managePopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001BD8")]
		[SerializeField]
		[Nulllable]
		private HouseExpansionMenu _houseExpansionMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001BD9")]
		[SerializeField]
		private AK.Wwise.Event _editRoomSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001BDA")]
		[SerializeField]
		private AK.Wwise.Event _addRoomSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001BDB")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001BDC")]
		private House.Types.Room _currentRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001BDD")]
		private KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>[] _boughtRooms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001BDE")]
		private HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] _additionalRooms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001BDF")]
		public int CurrentFloorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4001BE0")]
		public bool isLocked;

		[Cpp2IlInjected.Token(Token = "0x6002197")]
		[Cpp2IlInjected.Address(RVA = "0xAEB6E0", Offset = "0xAEA0E0", VA = "0x180AEB6E0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnEdit.ButtonComponent.m_OnClick;
			UnityAction call = OnManageClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002198")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9660", VA = "0x180AEAC60")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnEdit.ButtonComponent.m_OnClick;
			UnityAction call = OnManageClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002199")]
		[Cpp2IlInjected.Address(RVA = "0xAEAF00", Offset = "0xAE9900", VA = "0x180AEAF00")]
		internal unsafe void Refresh(House.Types.Room room, HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] additionalRooms, KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>[] boughtRooms)
		{
			//IL_007f: Expected O, but got I4
			//IL_00a9: Expected O, but got I4
			//IL_00bb: Expected I8, but got I4
			//IL_00e6: Expected I4, but got I8
			//IL_00fa: Expected O, but got I4
			//IL_017f: Expected I4, but got I8
			int num = 0;
			_currentRoom = room;
			_boughtRooms = boughtRooms;
			_additionalRooms = additionalRooms;
			if ((object)base.transform != null)
			{
			}
			if (room != null && boughtRooms.Length != num)
			{
				isLocked = (byte)num != 0;
				Client client = default(Client);
				GridCollection gridCollection_ = client.profile.world_.gridCollection_;
				uint floorGridID_ = room.floorGridID_;
				bool flag = gridCollection_.TryGetGrid(floorGridID_, out *(IGrid*)num);
				if (Enumerable.Count<HouseExpansion.Types.InteriorExpansion.Types.ExpansionData>((IEnumerable<>)(object)additionalRooms) > 0)
				{
					string floorGridDataPath_ = additionalRooms[num].floorGridDataPath_;
					if (num != 0)
					{
					}
					bool flag2 = string.Equals(floorGridDataPath_, (string)num);
					num++;
					int num2 = Enumerable.Count<HouseExpansion.Types.InteriorExpansion.Types.ExpansionData>((IEnumerable<>)(object)additionalRooms);
				}
				string name_ = room.name_;
				TextBase tfLabel = _tfLabel;
				int num3 = 0;
				string text2 = (tfLabel.Text = LocalizationManager.FromStringID(name_, (IResolver)num3));
				long num4 = num * 70;
				GameObject gameObject = _mcEmptyBackground.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				ulong num5 = default(ulong);
				_mcBackground.gameObject.SetActive((byte)num5 != 0);
				SpriteAtlasImage mcBackground = _mcBackground;
				int num6 = default(int);
				string text4 = (mcBackground.ImageAddress = $"img_room_side_{num6}");
				_mcEditIcon.ImageAddress = "icon_edit";
				Image component = _mcEditIcon.gameObject.GetComponent<Image>();
				Color white = Color.white;
				_btnEdit.Label.StringID = "menu.button_common_edit";
				ButtonTmProIcon btnEdit = _btnEdit;
				AK.Wwise.Event @event = (btnEdit._sfxEvent = _editRoomSFX);
				return;
			}
			_tfLabel.Text = "";
			ulong num7 = default(ulong);
			_mcEmptyBackground.gameObject.SetActive((byte)num7 != 0);
			GameObject gameObject2 = _mcBackground.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			_btnEdit.Label.StringID = "menu.house_expansion_add_room";
			ButtonTmProIcon btnEdit2 = _btnEdit;
			AK.Wwise.Event event2 = (btnEdit2._sfxEvent = _addRoomSFX);
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			RepeatedField<House.Types.Floor> floors_ = world_.playerHouse_.floors_;
			int currentFloorIndex = CurrentFloorIndex;
			House.Types.Floor floor = (House.Types.Floor)((RepeatedField<T>)(object)floors_)[currentFloorIndex];
			House.Types.RoomSlot roomSlot = _roomSlot;
			if (floor.TryGetRoom(roomSlot, out *(House.Types.Room*)num))
			{
			}
			RepeatedField<House.Types.Floor> floors_2 = world_.playerHouse_.floors_;
			int currentFloorIndex2 = CurrentFloorIndex;
			bool flag3 = (isLocked = !((House.Types.Floor)((RepeatedField<T>)(object)floors_2)[currentFloorIndex2]).PlayerLevelAllowsAddRoom(world_));
			SpriteAtlasImage mcEditIcon = _mcEditIcon;
			Image component2 = default(Image);
			if (!flag3)
			{
				mcEditIcon.ImageAddress = "icon_amount_plus";
				component2 = _mcEditIcon.gameObject.GetComponent<Image>();
				Color white2 = Color.white;
			}
			float b = ((UnityEngine.UI.Graphic)component2).m_Color.b;
			GameObject gameObject3 = default(GameObject);
			Image component3 = gameObject3.GetComponent<Image>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600219A")]
		[Cpp2IlInjected.Address(RVA = "0xAEAD10", Offset = "0xAE9710", VA = "0x180AEAD10")]
		private void OnManageClickHandler()
		{
			//Discarded unreachable code: IL_0044
			if (!isLocked)
			{
				CancellationToken cancellationToken = CancellationToken;
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			else
			{
				int num2 = 0;
				GenericAlert genericAlert = UiRoot.Instance._genericAlert;
				int skipLocManager = 0;
				int showCloseButton = 0;
				genericAlert.Alert("menu.cannot_add_room_need_upgrade", "", (byte)showCloseButton != 0, (byte)skipLocManager != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600219B")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB40", Offset = "0xAE9540", VA = "0x180AEAB40")]
		[AsyncStateMachine(typeof(_003CManageRoomTask_003Ed__21))]
		private Task ManageRoomTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600219C")]
		[Cpp2IlInjected.Address(RVA = "0xAEA930", Offset = "0xAE9330", VA = "0x180AEA930")]
		private Task<int> ManageRoomPopupTask(CancellationToken ct)
		{
			//Discarded unreachable code: IL_00cf
			TaskCompletionSource<int> tcs = (TaskCompletionSource<int>)(object)new TaskCompletionSource<TResult>();
			ManageRoomPopup.ManageRoomParam manageRoomParam = new ManageRoomPopup.ManageRoomParam();
			House.Types.RoomSlot roomSlot = (manageRoomParam.Slot = _roomSlot);
			int num = (manageRoomParam.CurrentFloorIndex = CurrentFloorIndex);
			House.Types.Room room = (manageRoomParam.CurrentRoom = _currentRoom);
			KeyValuePair<int, House.Types.Floor.Types.AdditionalRoomsList>[] array = (manageRoomParam.BoughtRooms = _boughtRooms);
			HouseExpansion.Types.InteriorExpansion.Types.ExpansionData[] array2 = (manageRoomParam.AddintionalRooms = _additionalRooms);
			Action<int> action = (manageRoomParam.AnswerAction = (Action<int>)(object)(Action<T>)delegate(int answer)
			{
				//Discarded unreachable code: IL_001f
				//IL_001d: Expected O, but got I4
				_houseExpansionMenu.UpdateBackShortcutIndicators(active: true);
				bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)answer);
			});
			GameObject gameObject = _houseExpansionMenu._backShortcutIndicator.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			int num2 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			AsyncMenu managePopup = _managePopup;
			popupStack.Push(managePopup, manageRoomParam);
			return (Task<int>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x600219D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HouseExpansionAdditionalRoomContent()
		{
		}
	}
}
