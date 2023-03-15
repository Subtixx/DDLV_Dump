using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private class ControllerAssignmentSaveInfo
		{
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			public class PlayerInfo
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public int id;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000210")]
				public bool hasKeyboard;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x4000211")]
				public bool hasMouse;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				public JoystickInfo[] joysticks;

				[Cpp2IlInjected.Token(Token = "0x17000228")]
				public int joystickCount
				{
					[Cpp2IlInjected.Token(Token = "0x600035E")]
					[Cpp2IlInjected.Address(RVA = "0x1935240", Offset = "0x1933C40", VA = "0x181935240")]
					get
					{
						return default(int);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x1E96BA0", Offset = "0x1E955A0", VA = "0x181E96BA0")]
				public int IndexOfJoystick(int joystickId)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x1E96B30", Offset = "0x1E95530", VA = "0x181E96B30")]
				public bool ContainsJoystick(int joystickId)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public PlayerInfo()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000029")]
			public class JoystickInfo
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000213")]
				public Guid instanceGuid;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000214")]
				public string hardwareIdentifier;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000215")]
				public int id;

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public JoystickInfo()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public PlayerInfo[] players;

			[Cpp2IlInjected.Token(Token = "0x17000227")]
			public int playerCount
			{
				[Cpp2IlInjected.Token(Token = "0x6000359")]
				[Cpp2IlInjected.Address(RVA = "0x1E907C0", Offset = "0x1E8F1C0", VA = "0x181E907C0")]
				get
				{
					PlayerInfo[] array;
					do
					{
						array = players;
					}
					while (array == null);
					return array.Length;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ControllerAssignmentSaveInfo()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x1E906A0", Offset = "0x1E8F0A0", VA = "0x181E906A0")]
			public ControllerAssignmentSaveInfo(int playerCount)
			{
				//Discarded unreachable code: IL_0033
				while (true)
				{
					base._002Ector();
					PlayerInfo[] array = (players = new PlayerInfo[playerCount]);
					int num = 0;
					if (playerCount > 0)
					{
						PlayerInfo playerInfo = new PlayerInfo();
						int num2 = 0;
						if (playerInfo == null || playerInfo != null)
						{
							num += 4;
							num++;
							break;
						}
						continue;
					}
					break;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x1E90630", Offset = "0x1E8F030", VA = "0x181E90630")]
			public int IndexOfPlayer(int playerId)
			{
				//Discarded unreachable code: IL_002e
				PlayerInfo[] array = players;
				int num = 0;
				if (array != null)
				{
				}
				int num2 = 0;
				if (num < num2)
				{
					PlayerInfo playerInfo = array[num];
					if (playerInfo == null || playerInfo.id != playerId)
					{
						num++;
					}
				}
				return -1;
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x1E905C0", Offset = "0x1E8EFC0", VA = "0x181E905C0")]
			public bool ContainsPlayer(int playerId)
			{
				//Discarded unreachable code: IL_002e
				PlayerInfo[] array = players;
				int num = 0;
				if (array != null)
				{
				}
				int num2 = 0;
				if (num < num2)
				{
					PlayerInfo playerInfo = array[num];
					if (playerInfo == null || playerInfo.id != playerId)
					{
						num++;
					}
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private class JoystickAssignmentHistoryInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public readonly Joystick joystick;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public readonly int oldJoystickId;

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x1E95780", Offset = "0x1E94180", VA = "0x181E95780")]
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
				if (joystick != null)
				{
					this.joystick = joystick;
					this.oldJoystickId = oldJoystickId;
					return;
				}
				ArgumentNullException ex = new ArgumentNullException("joystick");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private const string thisScriptName = "UserDataStore_PlayerPrefs";

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private const string logPrefix = "Rewired: ";

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private const int controllerMapPPKeyVersion_original = 0;

		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private const int controllerMapPPKeyVersion = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
		private bool isEnabled = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		[Tooltip("Should saved data be loaded on start?")]
		private bool loadDataOnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
		private bool loadJoystickAssignments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
		private bool loadKeyboardAssignments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		[Tooltip("Should Player Mouse assignments be saved and loaded?")]
		private bool loadMouseAssignments = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		[Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
		private string playerPrefsKeyPrefix = "RewiredSaveData";

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private bool allowImpreciseJoystickAssignmentMatching = true;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private bool deferredJoystickAssignmentLoadPending;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private bool wasJoystickEverDetected;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private List<int> __allActionIds;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private string __allActionIdsString;

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public bool IsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return isEnabled;
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				isEnabled = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public bool LoadDataOnStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return loadDataOnStart;
			}
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			set
			{
				loadDataOnStart = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public bool LoadJoystickAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get
			{
				return loadJoystickAssignments;
			}
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
			set
			{
				loadJoystickAssignments = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public bool LoadKeyboardAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0A0", Offset = "0x63AAA0", VA = "0x18063C0A0")]
			get
			{
				return loadKeyboardAssignments;
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x63C270", Offset = "0x63AC70", VA = "0x18063C270")]
			set
			{
				loadKeyboardAssignments = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public bool LoadMouseAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return loadMouseAssignments;
			}
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				loadMouseAssignments = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public string PlayerPrefsKeyPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return playerPrefsKeyPrefix;
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				playerPrefsKeyPrefix = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		private string playerPrefsKey_controllerAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1EAA670", Offset = "0x1EA9070", VA = "0x181EAA670")]
			get
			{
				string arg = playerPrefsKeyPrefix;
				return string.Format("{0}_{1}", arg, "ControllerAssignments");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		private bool loadControllerAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x1EAA650", Offset = "0x1EA9050", VA = "0x181EAA650")]
			get
			{
				if (!loadKeyboardAssignments && !loadMouseAssignments)
				{
					return loadJoystickAssignments;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		private List<int> allActionIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x1EAA400", Offset = "0x1EA8E00", VA = "0x181EAA400")]
			get
			{
				//Discarded unreachable code: IL_0072
				//IL_004d: Expected O, but got I4
				List<int> list = default(List<int>);
				int num2;
				if (__allActionIds == null)
				{
					list = (List<int>)(object)new List<T>();
					int num = 0;
					IList<InputAction> actions = (IList<InputAction>)ReInput.mapping.get_Actions();
					num2 = 0;
					uint num3 = default(uint);
					if (num2 < (int)num3)
					{
						num2 += num2;
						if (num2 == (int)num3)
						{
							goto IL_0051;
						}
						num2++;
					}
					if (num2 < num2)
					{
						uint num4 = default(uint);
						if (num2 < (int)num4)
						{
							num2 += num2;
							if (num2 == (int)num4)
							{
								goto IL_005d;
							}
							num2++;
						}
						((List<T>)(object)list).Add((T)num2);
						num2++;
						goto IL_0051;
					}
					goto IL_0069;
				}
				goto IL_0070;
				IL_0051:
				num2 += num2;
				num2 += 312;
				goto IL_005d;
				IL_0070:
				return list;
				IL_005d:
				num2 += num2;
				num2 += 312;
				goto IL_0069;
				IL_0069:
				__allActionIds = list;
				goto IL_0070;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		private string allActionIdsString
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x1EAA2B0", Offset = "0x1EA8CB0", VA = "0x181EAA2B0")]
			get
			{
				if (string.IsNullOrEmpty(__allActionIdsString))
				{
					StringBuilder stringBuilder = new StringBuilder();
					List<int> list = (List<int>)(object)this.get_allActionIds();
					int num = 0;
					if (num > 0)
					{
						StringBuilder stringBuilder2 = stringBuilder.Append(",");
					}
					num++;
					return __allActionIdsString = stringBuilder.ToString();
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9F20", Offset = "0x1EA8920", VA = "0x181EA9F20", Slot = "10")]
		public override void Save()
		{
			if (isEnabled)
			{
				SaveAll();
			}
			else
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8B10", Offset = "0x1EA7510", VA = "0x181EA8B10", Slot = "11")]
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (isEnabled)
			{
				if (controllerType == ControllerType.Joystick)
				{
					SaveJoystickCalibrationData(playerId);
				}
				int num = 0;
				PlayerPrefs.Save();
				int num2 = 0;
				PlayerPrefs.Save();
			}
			Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8BE0", Offset = "0x1EA75E0", VA = "0x181EA8BE0", Slot = "12")]
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
			if (isEnabled)
			{
				if (controllerType == ControllerType.Joystick)
				{
					SaveJoystickCalibrationData(controllerId);
				}
				int num = 0;
				PlayerPrefs.Save();
			}
			else
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9E30", Offset = "0x1EA8830", VA = "0x181EA9E30", Slot = "13")]
		public override void SavePlayerData(int playerId)
		{
			//Discarded unreachable code: IL_0032
			if (isEnabled)
			{
				int num = 0;
				Player player = ReInput.players.GetPlayer(playerId);
				SavePlayerDataNow(player);
				int num2 = 0;
				PlayerPrefs.Save();
			}
			else
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9530", Offset = "0x1EA7F30", VA = "0x181EA9530", Slot = "14")]
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
			//Discarded unreachable code: IL_0067
			if (isEnabled)
			{
				int num = 0;
				Player player = ReInput.players.GetPlayer(playerId);
				if (player != null)
				{
					int num2 = 0;
					InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
					if (inputBehavior != null)
					{
						int id = inputBehavior._id;
						string inputBehaviorPlayerPrefsKey = GetInputBehaviorPlayerPrefsKey(player, id);
						string value = inputBehavior.ToXmlString();
						PlayerPrefs.SetString(inputBehaviorPlayerPrefsKey, value);
						int num3 = 0;
						PlayerPrefs.Save();
					}
				}
			}
			else
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7E50", Offset = "0x1EA6850", VA = "0x181EA7E50", Slot = "5")]
		public override void Load()
		{
			if (isEnabled)
			{
				int num = LoadAll();
			}
			else
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1EA58E0", Offset = "0x1EA42E0", VA = "0x181EA58E0", Slot = "6")]
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (isEnabled)
			{
				RefreshLayoutManager(playerId);
				if (controllerType != ControllerType.Joystick)
				{
					return;
				}
				int num = LoadJoystickCalibrationData(playerId);
			}
			Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA59B0", Offset = "0x1EA43B0", VA = "0x181EA59B0", Slot = "7")]
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
			if (isEnabled)
			{
				if (controllerType == ControllerType.Joystick)
				{
					int num = LoadJoystickCalibrationData(controllerId);
				}
			}
			else
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7D60", Offset = "0x1EA6760", VA = "0x181EA7D60", Slot = "8")]
		public override void LoadPlayerData(int playerId)
		{
			//Discarded unreachable code: IL_002c
			if (isEnabled)
			{
				int num = 0;
				Player player = ReInput.players.GetPlayer(playerId);
				int num2 = LoadPlayerDataNow(player);
			}
			else
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1EA6200", Offset = "0x1EA4C00", VA = "0x181EA6200", Slot = "9")]
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
			//Discarded unreachable code: IL_0045
			if (isEnabled)
			{
				int num = 0;
				Player player = ReInput.players.GetPlayer(playerId);
				if (player != null)
				{
					int num2 = 0;
					InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
					if (inputBehavior != null)
					{
						int num3 = LoadInputBehaviorNow(player, inputBehavior);
					}
				}
			}
			else
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7FF0", Offset = "0x1EA69F0", VA = "0x181EA7FF0", Slot = "17")]
		protected override void OnInitialize()
		{
			//Discarded unreachable code: IL_0049
			if (!loadDataOnStart)
			{
				return;
			}
			Load();
			if (loadKeyboardAssignments || loadMouseAssignments || loadJoystickAssignments)
			{
				int num = 0;
				if (ReInput.controllers.joystickCount > 0)
				{
					wasJoystickEverDetected = true;
					bool flag = SaveControllerAssignments();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7ED0", Offset = "0x1EA68D0", VA = "0x181EA7ED0", Slot = "18")]
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
			//Discarded unreachable code: IL_007f
			//IL_0055: Expected I4, but got I8
			if (!isEnabled || args.ODiTVfklXHDoeIfdJEahPbsrzhzs != ControllerType.Joystick)
			{
				return;
			}
			int oAqYXyYxxoyErUWWGBOiLsNcUok = args.OAqYXyYxxoyErUWWGBOiLsNcUok;
			int num = LoadJoystickData(oAqYXyYxxoyErUWWGBOiLsNcUok);
			if (loadDataOnStart)
			{
				if (!loadJoystickAssignments)
				{
					goto IL_0077;
				}
				if (!wasJoystickEverDetected)
				{
					_003CLoadJoystickAssignmentsDeferred_003Ed__80 _003CLoadJoystickAssignmentsDeferred_003Ed__ = default(_003CLoadJoystickAssignmentsDeferred_003Ed__80);
					((IDisposable)_003CLoadJoystickAssignmentsDeferred_003Ed__).Dispose();
					_003CLoadJoystickAssignmentsDeferred_003Ed__._003C_003E4__this = this;
					_003CLoadJoystickAssignmentsDeferred_003Ed__._003C_003E1__state = 0;
					Coroutine coroutine = StartCoroutine(_003CLoadJoystickAssignmentsDeferred_003Ed__);
				}
			}
			if (loadJoystickAssignments && !deferredJoystickAssignmentLoadPending)
			{
				bool flag = SaveControllerAssignments();
			}
			goto IL_0077;
			IL_0077:
			wasJoystickEverDetected = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7FC0", Offset = "0x1EA69C0", VA = "0x181EA7FC0", Slot = "21")]
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
			//Discarded unreachable code: IL_0022
			if (isEnabled && args.ODiTVfklXHDoeIfdJEahPbsrzhzs == ControllerType.Joystick)
			{
				int oAqYXyYxxoyErUWWGBOiLsNcUok = args.OAqYXyYxxoyErUWWGBOiLsNcUok;
				SaveJoystickData(oAqYXyYxxoyErUWWGBOiLsNcUok);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7FA0", Offset = "0x1EA69A0", VA = "0x181EA7FA0", Slot = "19")]
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
			if (isEnabled && (loadKeyboardAssignments || loadMouseAssignments || loadJoystickAssignments))
			{
				bool flag = SaveControllerAssignments();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8C90", Offset = "0x1EA7690", VA = "0x181EA8C90", Slot = "15")]
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
			//Discarded unreachable code: IL_001f
			if (controllerMap != null)
			{
				int num = 0;
				Player player = ReInput.players.GetPlayer(playerId);
				if (player != null)
				{
					SaveControllerMap(player, controllerMap);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5A60", Offset = "0x1EA4460", VA = "0x181EA5A60", Slot = "16")]
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			int num = 0;
			if (ReInput.players.GetPlayer(playerId) != null)
			{
				byte d = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
				Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
				ControllerMap result = default(ControllerMap);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5490", Offset = "0x1EA3E90", VA = "0x181EA5490")]
		private int LoadAll()
		{
			//Discarded unreachable code: IL_0098
			//IL_0060: Expected O, but got I4
			int num = 0;
			if ((loadKeyboardAssignments ? 1 : 0) != num || (loadMouseAssignments ? 1 : 0) != num || (loadJoystickAssignments ? 1 : 0) != num)
			{
				bool flag = LoadControllerAssignmentsNow();
			}
			int num2 = 0;
			IList<Player> allPlayers = (IList<Player>)ReInput.players.get_AllPlayers();
			uint num3 = default(uint);
			if (num < (int)num3)
			{
				num += num;
				if (num == (int)num3)
				{
					goto IL_006b;
				}
				num++;
			}
			int num5 = default(int);
			if (num < num)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_0079;
					}
					num++;
				}
				num5 = LoadPlayerDataNow((Player)num);
				num += num5;
				num++;
				goto IL_006b;
			}
			goto IL_0087;
			IL_0087:
			int num6 = LoadAllJoystickCalibrationData();
			return num6 + num;
			IL_006b:
			num += num;
			num5 += 312;
			goto IL_0079;
			IL_0079:
			num += num;
			num5 += 312;
			goto IL_0087;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7A60", Offset = "0x1EA6460", VA = "0x181EA7A60")]
		private int LoadPlayerDataNow(int playerId)
		{
			//Discarded unreachable code: IL_0016
			int num = 0;
			Player player = ReInput.players.GetPlayer(playerId);
			return LoadPlayerDataNow(player);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7AE0", Offset = "0x1EA64E0", VA = "0x181EA7AE0")]
		private int LoadPlayerDataNow(Player player)
		{
			//Discarded unreachable code: IL_00a0, IL_00a6
			int num = 0;
			int num2;
			IList<Joystick> joysticks;
			int id4 = default(int);
			int num6 = default(int);
			if (player != null)
			{
				int id = player.id;
				num2 = LoadInputBehaviors(id);
				int id2 = player.id;
				int controllerId = 0;
				int controllerType = 0;
				int num3 = LoadControllerMaps(id2, (ControllerType)controllerType, controllerId);
				num2 += num3;
				int id3 = player.id;
				int controllerId2 = 0;
				int num4 = LoadControllerMaps(id3, ControllerType.Mouse, controllerId2);
				num2 += num4;
				joysticks = (IList<Joystick>)player.controllers.get_Joysticks();
				if (joysticks != null)
				{
					uint num5 = default(uint);
					if (num < (int)num5)
					{
						num += num;
						if (num == (int)num5)
						{
							goto IL_0085;
						}
						num++;
					}
					id4 = player.id;
					num2 += num6;
					goto IL_0085;
				}
				goto IL_0096;
			}
			goto IL_009e;
			IL_009e:
			return 0;
			IL_0085:
			id4 += id4;
			num6 += 312;
			goto IL_0096;
			IL_0096:
			if (joysticks != null)
			{
			}
			int num7 = num2;
			goto IL_009e;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5230", Offset = "0x1EA3C30", VA = "0x181EA5230")]
		private int LoadAllJoystickCalibrationData()
		{
			//Discarded unreachable code: IL_008a
			//IL_0040: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			IList<Joystick> joysticks = (IList<Joystick>)ReInput.controllers.get_Joysticks();
			uint num3 = default(uint);
			if (num < (int)num3)
			{
				num += num;
				if (num == (int)num3)
				{
					goto IL_0058;
				}
				num++;
			}
			int num5 = default(int);
			if ((long)num < (long)(IntPtr)joysticks)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_005f;
					}
					num++;
				}
				if (num != 0)
				{
					string joystickCalibrationMapPlayerPrefsKey = GetJoystickCalibrationMapPlayerPrefsKey((Joystick)num);
					if (PlayerPrefs.HasKey(joystickCalibrationMapPlayerPrefsKey))
					{
						num5 = 0;
						string @string = PlayerPrefs.GetString(joystickCalibrationMapPlayerPrefsKey);
						goto IL_0058;
					}
					goto IL_0066;
				}
				goto IL_0080;
			}
			goto IL_0088;
			IL_0058:
			num5 += num5;
			goto IL_005f;
			IL_0080:
			num += num;
			num++;
			goto IL_0088;
			IL_0066:
			string empty = string.Empty;
			bool flag = default(bool);
			bool flag2 = flag;
			num += (flag2 ? 1 : 0);
			num++;
			goto IL_0080;
			IL_0088:
			return num;
			IL_005f:
			num5 += num5;
			goto IL_0066;
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7450", Offset = "0x1EA5E50", VA = "0x181EA7450")]
		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			if (joystick != null)
			{
				string joystickCalibrationMapPlayerPrefsKey = GetJoystickCalibrationMapPlayerPrefsKey(joystick);
				if (PlayerPrefs.HasKey(joystickCalibrationMapPlayerPrefsKey))
				{
					string @string = PlayerPrefs.GetString(joystickCalibrationMapPlayerPrefsKey);
				}
				string empty = string.Empty;
				if (joystick.ImportCalibrationMapFromXmlString(empty))
				{
					return 1;
				}
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7350", Offset = "0x1EA5D50", VA = "0x181EA7350")]
		private int LoadJoystickCalibrationData(int joystickId)
		{
			//Discarded unreachable code: IL_003d
			int num = 0;
			Joystick joystick = ReInput.controllers.GetJoystick(joystickId);
			if (joystick != null)
			{
				string joystickCalibrationMapPlayerPrefsKey = GetJoystickCalibrationMapPlayerPrefsKey(joystick);
				if (PlayerPrefs.HasKey(joystickCalibrationMapPlayerPrefsKey))
				{
					string @string = PlayerPrefs.GetString(joystickCalibrationMapPlayerPrefsKey);
				}
				string empty = string.Empty;
				bool flag = joystick.ImportCalibrationMapFromXmlString(empty);
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1EA74F0", Offset = "0x1EA5EF0", VA = "0x181EA74F0")]
		private int LoadJoystickData(int joystickId)
		{
			//Discarded unreachable code: IL_0083
			int num = 0;
			int num2 = 0;
			IList<Player> allPlayers = (IList<Player>)ReInput.players.get_AllPlayers();
			uint num3 = default(uint);
			if (num < (int)num3)
			{
				num += num;
				if (num == (int)num3)
				{
					goto IL_004b;
				}
				num++;
			}
			int num6 = default(int);
			if ((long)num < (long)(IntPtr)allPlayers)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_005c;
					}
					num++;
				}
				bool flag = default(bool);
				if (flag)
				{
					int num5 = default(int);
					num += num5;
					RefreshLayoutManager(num6);
				}
				num++;
				goto IL_004b;
			}
			goto IL_006d;
			IL_005c:
			num6 += num6;
			num6 += 312;
			goto IL_006d;
			IL_004b:
			num6 += num6;
			num6 += 312;
			goto IL_005c;
			IL_006d:
			num6 = joystickId;
			int num7 = LoadJoystickCalibrationData(num6);
			return num7 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5860", Offset = "0x1EA4260", VA = "0x181EA5860")]
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			int num = 0;
			int num2 = LoadControllerMaps(playerId, controllerType, controllerId);
			RefreshLayoutManager(playerId);
			if (controllerType == ControllerType.Joystick)
			{
				int num3 = LoadJoystickCalibrationData(playerId);
				num3 += num2;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5840", Offset = "0x1EA4240", VA = "0x181EA5840")]
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			if (controllerType == ControllerType.Joystick)
			{
				return LoadJoystickCalibrationData(controllerId);
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5CB0", Offset = "0x1EA46B0", VA = "0x181EA5CB0")]
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			int num = 0;
			int num2 = 0;
			Player player = ReInput.players.GetPlayer(playerId);
			if (player != null)
			{
				int num3 = 0;
				ReInput.ControllerHelper controllers = ReInput.controllers;
				Controller controller = default(Controller);
				if (controller != null)
				{
					int num4 = 0;
					IList<InputMapCategory> mapCategories = (IList<InputMapCategory>)ReInput.mapping.get_MapCategories();
					if ((long)num < (long)(IntPtr)mapCategories)
					{
						uint num5 = default(uint);
						if (num < (int)num5)
						{
							num += num;
							if (num == (int)num5)
							{
								goto IL_00ba;
							}
							num++;
						}
						int num6 = 0;
						ReInput.MappingHelper mapping = ReInput.mapping;
						ControllerType type = controller.type;
						int num7 = 0;
						IList<InputLayout> list = default(IList<InputLayout>);
						if ((long)num7 < (long)(IntPtr)list)
						{
							ControllerIdentifier hqIhxyZybqkejspuuoUXDPYHCsYd = controller.HqIhxyZybqkejspuuoUXDPYHCsYd;
							byte d = controller.HqIhxyZybqkejspuuoUXDPYHCsYd.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
							Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controller.HqIhxyZybqkejspuuoUXDPYHCsYd.gjIwAQzDxzoikMpsmpvjOOHYbHh;
							ControllerMap controllerMap = default(ControllerMap);
							if (controllerMap != null)
							{
								player.controllers.maps.AddMap(controller, controllerMap);
								num++;
							}
							num7++;
							goto IL_00ba;
						}
						goto IL_00be;
					}
					goto IL_00c2;
				}
			}
			throw new NullReferenceException();
			IL_00ba:
			player = (Player)(object)((object)player + (object)player);
			goto IL_00be;
			IL_00c2:
			return num;
			IL_00be:
			num++;
			goto IL_00c2;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5B40", Offset = "0x1EA4540", VA = "0x181EA5B40")]
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			if (player != null)
			{
				int num = 0;
				byte d = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
				Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
				string key = default(string);
				if (!PlayerPrefs.HasKey(key))
				{
				}
				string @string = PlayerPrefs.GetString(key);
				if (@string == null && ControllerMap.CreateFromXml(controllerIdentifier.ODiTVfklXHDoeIfdJEahPbsrzhzs, @string) != null)
				{
					byte d2 = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
					Guid gjIwAQzDxzoikMpsmpvjOOHYbHh2 = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
					byte d3 = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
					Guid gjIwAQzDxzoikMpsmpvjOOHYbHh3 = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1EA6360", Offset = "0x1EA4D60", VA = "0x181EA6360")]
		private int LoadInputBehaviors(int playerId)
		{
			//IL_0064: Expected O, but got I4
			int num = 0;
			Player player = ReInput.players.GetPlayer(playerId);
			int num2;
			int num6 = default(int);
			if (player != null)
			{
				num2 = 0;
				int num3 = 0;
				ReInput.MappingHelper mapping = ReInput.mapping;
				int id = player.id;
				IList<InputBehavior> inputBehaviors = (IList<InputBehavior>)mapping.GetInputBehaviors(id);
				uint num4 = default(uint);
				if (num2 < (int)num4)
				{
					num2 += num2;
					if (num2 == (int)num4)
					{
						goto IL_006f;
					}
					num2++;
				}
				if ((long)num2 < (long)(IntPtr)inputBehaviors)
				{
					uint num5 = default(uint);
					if (num2 < (int)num5)
					{
						num2 += num2;
						if (num2 == (int)num5)
						{
							goto IL_007d;
						}
						num2++;
					}
					num6 = LoadInputBehaviorNow(player, (InputBehavior)num2);
					num2 += num6;
					num2++;
					goto IL_006f;
				}
				goto IL_008b;
			}
			throw new NullReferenceException();
			IL_008b:
			return num2;
			IL_006f:
			player = (Player)(object)((object)player + (object)player);
			num6 += 312;
			goto IL_007d;
			IL_007d:
			player = (Player)(object)((object)player + (object)player);
			num6 += 312;
			goto IL_008b;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x1EA6000", Offset = "0x1EA4A00", VA = "0x181EA6000")]
		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			int num = 0;
			Player player = ReInput.players.GetPlayer(playerId);
			if (player != null)
			{
				int num2 = 0;
				InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
				if (inputBehavior != null)
				{
					return LoadInputBehaviorNow(player, inputBehavior);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x1EA60F0", Offset = "0x1EA4AF0", VA = "0x181EA60F0")]
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			if (player != null && inputBehavior != null)
			{
				int id = inputBehavior._id;
				string inputBehaviorPlayerPrefsKey = GetInputBehaviorPlayerPrefsKey(player, id);
				if (PlayerPrefs.HasKey(inputBehaviorPlayerPrefsKey))
				{
					string @string = PlayerPrefs.GetString(inputBehaviorPlayerPrefsKey);
				}
				string empty = string.Empty;
				if (empty != null)
				{
					string empty2 = string.Empty;
					if (!string.Equals(empty, empty2) && inputBehavior.ImportXmlString(empty))
					{
						return 1;
					}
				}
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x1EA57D0", Offset = "0x1EA41D0", VA = "0x181EA57D0")]
		private bool LoadControllerAssignmentsNow()
		{
			ControllerAssignmentSaveInfo controllerAssignmentSaveInfo = LoadControllerAssignmentData();
			if (controllerAssignmentSaveInfo != null)
			{
				if (loadKeyboardAssignments || loadMouseAssignments)
				{
					bool flag = LoadKeyboardAndMouseAssignmentsNow(controllerAssignmentSaveInfo);
				}
				if (loadJoystickAssignments)
				{
					bool flag2 = LoadJoystickAssignmentsNow(controllerAssignmentSaveInfo);
				}
			}
			int num = 0;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7730", Offset = "0x1EA6130", VA = "0x181EA7730")]
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			//Discarded unreachable code: IL_00ce, IL_00d4, IL_00da, IL_00e0, IL_00e6, IL_00ec, IL_00f2, IL_00f8, IL_00fe, IL_0104, IL_010a, IL_0110
			int num = 0;
			if (data == null && LoadControllerAssignmentData() == null)
			{
				int num2 = 0;
			}
			int num3 = 0;
			IList<Player> allPlayers = (IList<Player>)ReInput.players.get_AllPlayers();
			ControllerAssignmentSaveInfo.PlayerInfo[] players = default(ControllerAssignmentSaveInfo.PlayerInfo[]);
			int length = default(int);
			if (allPlayers != null)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_004d;
					}
					num++;
				}
				players = data.players;
				if (players != null)
				{
					length = players.Length;
					goto IL_004d;
				}
				goto IL_005e;
			}
			goto IL_00c4;
			IL_004d:
			int num5 = num5 + num5;
			length += 312;
			goto IL_005e;
			IL_005e:
			ControllerAssignmentSaveInfo.PlayerInfo playerInfo = default(ControllerAssignmentSaveInfo.PlayerInfo);
			if (num < num)
			{
				playerInfo = players[num];
				if (playerInfo == null || playerInfo.id != num5)
				{
					num++;
				}
			}
			while (playerInfo.id == num5)
			{
			}
			int playerId = default(int);
			int num6 = data.IndexOfPlayer(playerId);
			ControllerAssignmentSaveInfo.PlayerInfo playerInfo2 = players[num6];
			if (loadKeyboardAssignments)
			{
				bool hasKeyboard = playerInfo2.hasKeyboard;
			}
			while (!loadMouseAssignments)
			{
			}
			bool hasMouse = playerInfo2.hasMouse;
			goto IL_00c4;
			IL_00c4:
			if (allPlayers != null)
			{
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1EA6600", Offset = "0x1EA5000", VA = "0x181EA6600")]
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			//Discarded unreachable code: IL_0286, IL_028c, IL_0292, IL_029e, IL_02a4, IL_02aa, IL_02c2, IL_02c8, IL_02ce, IL_02d4, IL_02da, IL_02e0, IL_02e6, IL_02ec, IL_02f8, IL_02fe, IL_0304, IL_030a, IL_0316, IL_031c, IL_0322, IL_0328, IL_032e, IL_0334, IL_033a, IL_0340, IL_0346, IL_034c, IL_0352, IL_035e, IL_0364, IL_036a, IL_0370, IL_0376, IL_037c
			//IL_0202: Expected O, but got I4
			//IL_0239: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if (ReInput.controllers.joystickCount != 0)
			{
				if (data != null || LoadControllerAssignmentData() == null)
				{
				}
				int num5 = 0;
				IList<Player> allPlayers = (IList<Player>)ReInput.players.get_AllPlayers();
				uint num6 = default(uint);
				if (allPlayers != null && num < (int)num6)
				{
					num += num;
					if (num != (int)num6)
					{
						num++;
					}
				}
				int num7 = 0;
				if (allPlayers != null)
				{
				}
				if (num != 0)
				{
					throw new IndexOutOfRangeException();
				}
				List<JoystickAssignmentHistoryInfo> list = (List<JoystickAssignmentHistoryInfo>)(object)new List<T>();
				int num8 = 0;
				IList<Player> allPlayers2 = (IList<Player>)ReInput.players.get_AllPlayers();
				if (allPlayers2 != null)
				{
					ControllerAssignmentSaveInfo.PlayerInfo[] players = data.players;
					if (players != null)
					{
					}
					ControllerAssignmentSaveInfo.PlayerInfo playerInfo = default(ControllerAssignmentSaveInfo.PlayerInfo);
					int num9 = default(int);
					if (num7 < num7)
					{
						playerInfo = players[num7];
						if (playerInfo == null || playerInfo.id != num9)
						{
							num7++;
						}
					}
					while (playerInfo.id == num9)
					{
					}
					int num10 = default(int);
					ControllerAssignmentSaveInfo.PlayerInfo playerInfo2 = players[num10];
					if (playerInfo2.joysticks != null)
					{
					}
					if (num7 < num7)
					{
						ControllerAssignmentSaveInfo.JoystickInfo joystickInfo = playerInfo2.joysticks[num7];
						if (joystickInfo != null)
						{
							_003C_003Ec__DisplayClass78_0 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass78_0);
							Joystick joystick = default(Joystick);
							CS_0024_003C_003E8__locals0.joystick = joystick;
							Predicate<JoystickAssignmentHistoryInfo> predicate = (Predicate<JoystickAssignmentHistoryInfo>)(object)(Predicate<T>)delegate(JoystickAssignmentHistoryInfo x)
							{
								//Discarded unreachable code: IL_0011
								Joystick joystick3 = CS_0024_003C_003E8__locals0.joystick;
								return x.joystick == joystick3;
							};
							JoystickAssignmentHistoryInfo joystickAssignmentHistoryInfo = default(JoystickAssignmentHistoryInfo);
							if (joystickAssignmentHistoryInfo == null)
							{
								int id = joystickInfo.id;
								if (predicate == null)
								{
									ArgumentNullException ex = new ArgumentNullException("joystick");
									throw new NullReferenceException();
								}
								JoystickAssignmentHistoryInfo joystickAssignmentHistoryInfo2 = default(JoystickAssignmentHistoryInfo);
								joystickAssignmentHistoryInfo2.joystick = (Joystick)(object)predicate;
								joystickAssignmentHistoryInfo2.oldJoystickId = id;
							}
						}
						num7++;
					}
				}
				int num11 = 0;
				if (allPlayers2 != null)
				{
				}
				if (num != 0)
				{
					throw new IndexOutOfRangeException();
				}
				int num12 = 0;
				IList<Player> allPlayers3 = (IList<Player>)ReInput.players.get_AllPlayers();
				if (allPlayers3 != null)
				{
					ControllerAssignmentSaveInfo.PlayerInfo[] players2 = data.players;
					if (players2 != null)
					{
					}
					ControllerAssignmentSaveInfo.PlayerInfo playerInfo3 = default(ControllerAssignmentSaveInfo.PlayerInfo);
					int num13 = default(int);
					if (num11 < num11)
					{
						playerInfo3 = players2[num11];
						if (playerInfo3 == null || playerInfo3.id != num13)
						{
							num11++;
						}
					}
					while (playerInfo3.id == num13)
					{
					}
					int num14 = default(int);
					ControllerAssignmentSaveInfo.PlayerInfo playerInfo4 = players2[num14];
					if (playerInfo4.joysticks != null)
					{
					}
					if (num11 < num11)
					{
						_003C_003Ec__DisplayClass78_1 CS_0024_003C_003E8__locals1 = default(_003C_003Ec__DisplayClass78_1);
						ControllerAssignmentSaveInfo.JoystickInfo joystickInfo2 = (CS_0024_003C_003E8__locals1.joystickInfo = playerInfo4.joysticks[num11]);
						if ((long)CS_0024_003C_003E8__locals1.joystickInfo != 0)
						{
							Predicate<JoystickAssignmentHistoryInfo> predicate2 = (Predicate<JoystickAssignmentHistoryInfo>)(object)(Predicate<T>)delegate(JoystickAssignmentHistoryInfo x)
							{
								//Discarded unreachable code: IL_0016
								int id3 = CS_0024_003C_003E8__locals1.joystickInfo.id;
								return x.oldJoystickId == id3;
							};
							ControllerAssignmentSaveInfo.JoystickInfo joystickInfo3 = CS_0024_003C_003E8__locals1.joystickInfo;
							bool flag = default(bool);
							if (flag)
							{
								bool flag2 = default(bool);
								if (flag2)
								{
									_003C_003Ec__DisplayClass78_2 CS_0024_003C_003E8__locals2 = default(_003C_003Ec__DisplayClass78_2);
									CS_0024_003C_003E8__locals2.match = (Joystick)num3;
									Predicate<JoystickAssignmentHistoryInfo> predicate3 = (Predicate<JoystickAssignmentHistoryInfo>)(object)(Predicate<T>)delegate(JoystickAssignmentHistoryInfo x)
									{
										//Discarded unreachable code: IL_0011
										Joystick match = CS_0024_003C_003E8__locals2.match;
										return x.joystick == match;
									};
									JoystickAssignmentHistoryInfo joystickAssignmentHistoryInfo3 = default(JoystickAssignmentHistoryInfo);
									while (joystickAssignmentHistoryInfo3 != null)
									{
									}
								}
								if (num != 0)
								{
									throw new NullReferenceException();
								}
								if (num11 != 0)
								{
									int id2 = CS_0024_003C_003E8__locals1.joystickInfo.id;
									JoystickAssignmentHistoryInfo joystickAssignmentHistoryInfo4 = default(JoystickAssignmentHistoryInfo);
									joystickAssignmentHistoryInfo4.joystick = (Joystick)num11;
									joystickAssignmentHistoryInfo4.oldJoystickId = id2;
									Joystick joystick2 = joystickAssignmentHistoryInfo4.joystick;
									int num15 = 0;
								}
							}
						}
						num11++;
					}
				}
				if (allPlayers3 != null)
				{
				}
				if (num != 0)
				{
					throw new NullReferenceException();
				}
			}
			int num16 = 0;
			int num17 = 0;
			if (ReInput.configuration.autoAssignJoysticks)
			{
				int num18 = 0;
				ReInput.controllers.AutoAssignJoysticks();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5690", Offset = "0x1EA4090", VA = "0x181EA5690")]
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			string arg = playerPrefsKeyPrefix;
			if (PlayerPrefs.HasKey(string.Format("{0}_{1}", arg, "ControllerAssignments")))
			{
				string arg2 = playerPrefsKeyPrefix;
				string @string = PlayerPrefs.GetString(string.Format("{0}_{1}", arg2, "ControllerAssignments"));
				if (@string == null)
				{
					ControllerAssignmentSaveInfo controllerAssignmentSaveInfo = JsonParser.FromJson<ControllerAssignmentSaveInfo>(@string);
					if (controllerAssignmentSaveInfo != null)
					{
						ControllerAssignmentSaveInfo.PlayerInfo[] players = controllerAssignmentSaveInfo.players;
						if (players != null && players.Length == 0)
						{
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1EA6590", Offset = "0x1EA4F90", VA = "0x181EA6590")]
		[IteratorStateMachine(typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80))]
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			//IL_0016: Expected I4, but got I8
			_003CLoadJoystickAssignmentsDeferred_003Ed__80 _003CLoadJoystickAssignmentsDeferred_003Ed__ = default(_003CLoadJoystickAssignmentsDeferred_003Ed__80);
			((IDisposable)_003CLoadJoystickAssignmentsDeferred_003Ed__).Dispose();
			_003CLoadJoystickAssignmentsDeferred_003Ed__._003C_003E4__this = this;
			_003CLoadJoystickAssignmentsDeferred_003Ed__._003C_003E1__state = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8360", Offset = "0x1EA6D60", VA = "0x181EA8360")]
		private void SaveAll()
		{
			//Discarded unreachable code: IL_008a
			//IL_003c: Expected O, but got I4
			int num = 0;
			IList<Player> allPlayers = (IList<Player>)ReInput.players.get_AllPlayers();
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				if (num2 == (int)num3)
				{
					goto IL_0040;
				}
				num2++;
			}
			if ((long)num2 < (long)(IntPtr)allPlayers)
			{
				uint num4 = default(uint);
				if (num2 < (int)num4)
				{
					num2 += num2;
					if (num2 == (int)num4)
					{
						goto IL_004c;
					}
					num2++;
				}
				SavePlayerDataNow((Player)num2);
				num2++;
				goto IL_0040;
			}
			goto IL_0058;
			IL_004c:
			num2 += num2;
			num2 += 312;
			goto IL_0058;
			IL_0058:
			SaveAllJoystickCalibrationData();
			if ((loadKeyboardAssignments ? 1 : 0) != num2 || (loadMouseAssignments ? 1 : 0) != num2 || (loadJoystickAssignments ? 1 : 0) != num2)
			{
				bool flag = SaveControllerAssignments();
			}
			int num5 = 0;
			PlayerPrefs.Save();
			return;
			IL_0040:
			num2 += num2;
			num2 += 312;
			goto IL_004c;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9BA0", Offset = "0x1EA85A0", VA = "0x181EA9BA0")]
		private void SavePlayerDataNow(int playerId)
		{
			//Discarded unreachable code: IL_001d
			int num = 0;
			Player player = ReInput.players.GetPlayer(playerId);
			SavePlayerDataNow(player);
			int num2 = 0;
			PlayerPrefs.Save();
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9C30", Offset = "0x1EA8630", VA = "0x181EA9C30")]
		private void SavePlayerDataNow(Player player)
		{
			//Discarded unreachable code: IL_0058
			if (player != null)
			{
				PlayerSaveData playerSaveData = default(PlayerSaveData);
				MouseMapSaveData[] vwBVVobUNRjxmKMLKDGDTsGgjZG = playerSaveData.vwBVVobUNRjxmKMLKDGDTsGgjZG;
				MouseMapSaveData[] vwBVVobUNRjxmKMLKDGDTsGgjZG2 = playerSaveData.vwBVVobUNRjxmKMLKDGDTsGgjZG;
				int num = 0;
				if ((long)num < (long)(IntPtr)playerSaveData)
				{
					string text = playerPrefsKeyPrefix;
					string text2 = player.name;
					string text3 = default(string);
					string value = default(string);
					PlayerPrefs.SetString(string.Concat(string.Concat(text + "|playerName=" + text2, "|dataType=InputBehavior"), "|id=", text3), value);
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8140", Offset = "0x1EA6B40", VA = "0x181EA8140")]
		private void SaveAllJoystickCalibrationData()
		{
			//Discarded unreachable code: IL_006c
			//IL_0040: Expected O, but got I4
			int num = 0;
			IList<Joystick> joysticks = (IList<Joystick>)ReInput.controllers.get_Joysticks();
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				if (num2 == (int)num3)
				{
					goto IL_005d;
				}
				num2++;
			}
			if ((long)num2 >= (long)(IntPtr)joysticks)
			{
				return;
			}
			uint num4 = default(uint);
			if (num2 < (int)num4)
			{
				num2 += num2;
				if (num2 == (int)num4)
				{
					goto IL_0064;
				}
				num2++;
			}
			string text = default(string);
			if (num2 != 0)
			{
				string joystickCalibrationMapPlayerPrefsKey = GetJoystickCalibrationMapPlayerPrefsKey((Joystick)num2);
				JoystickCalibrationMapSaveData joystickCalibrationMapSaveData = default(JoystickCalibrationMapSaveData);
				text = ((CalibrationMapSaveData)joystickCalibrationMapSaveData).qEAiCAqNxotujEQgsbtQbcfYKDc.ToXmlString();
				PlayerPrefs.SetString(joystickCalibrationMapPlayerPrefsKey, text);
			}
			num2++;
			goto IL_005d;
			IL_005d:
			text += text;
			goto IL_0064;
			IL_0064:
			text += text;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA98B0", Offset = "0x1EA82B0", VA = "0x181EA98B0")]
		private void SaveJoystickCalibrationData(int joystickId)
		{
			//Discarded unreachable code: IL_0037
			int num = 0;
			Joystick joystick = ReInput.controllers.GetJoystick(joystickId);
			if (joystick != null)
			{
				JoystickCalibrationMapSaveData calibrationMapSaveData = joystick.GetCalibrationMapSaveData();
				string joystickCalibrationMapPlayerPrefsKey = GetJoystickCalibrationMapPlayerPrefsKey(joystick);
				string value = ((CalibrationMapSaveData)calibrationMapSaveData).qEAiCAqNxotujEQgsbtQbcfYKDc.ToXmlString();
				PlayerPrefs.SetString(joystickCalibrationMapPlayerPrefsKey, value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9830", Offset = "0x1EA8230", VA = "0x181EA9830")]
		private void SaveJoystickCalibrationData(Joystick joystick)
		{
			//Discarded unreachable code: IL_0027
			if (joystick != null)
			{
				JoystickCalibrationMapSaveData calibrationMapSaveData = joystick.GetCalibrationMapSaveData();
				string joystickCalibrationMapPlayerPrefsKey = GetJoystickCalibrationMapPlayerPrefsKey(joystick);
				string value = ((CalibrationMapSaveData)calibrationMapSaveData).qEAiCAqNxotujEQgsbtQbcfYKDc.ToXmlString();
				PlayerPrefs.SetString(joystickCalibrationMapPlayerPrefsKey, value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9980", Offset = "0x1EA8380", VA = "0x181EA9980")]
		private void SaveJoystickData(int joystickId)
		{
			//Discarded unreachable code: IL_006c
			int num = 0;
			IList<Player> allPlayers = (IList<Player>)ReInput.players.get_AllPlayers();
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				if (num2 == (int)num3)
				{
					goto IL_003e;
				}
				num2++;
			}
			if ((long)num2 < (long)(IntPtr)allPlayers)
			{
				uint num4 = default(uint);
				if (num2 < (int)num4)
				{
					num2 += num2;
					if (num2 == (int)num4)
					{
						goto IL_004f;
					}
					num2++;
				}
				bool flag = default(bool);
				if (flag)
				{
				}
				num2++;
				goto IL_003e;
			}
			goto IL_0060;
			IL_003e:
			int num5 = num5 + num5;
			num5 += 312;
			goto IL_004f;
			IL_004f:
			num5 += num5;
			num5 += 312;
			goto IL_0060;
			IL_0060:
			num5 = joystickId;
			SaveJoystickCalibrationData(num5);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8AB0", Offset = "0x1EA74B0", VA = "0x181EA8AB0")]
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			SaveControllerMaps(playerId, controllerType, controllerId);
			if (controllerType == ControllerType.Joystick)
			{
				SaveJoystickCalibrationData(playerId);
			}
			int num = 0;
			PlayerPrefs.Save();
			int num2 = 0;
			PlayerPrefs.Save();
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8A80", Offset = "0x1EA7480", VA = "0x181EA8A80")]
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
			if (controllerType == ControllerType.Joystick)
			{
				SaveJoystickCalibrationData(controllerId);
			}
			int num = 0;
			PlayerPrefs.Save();
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9220", Offset = "0x1EA7C20", VA = "0x181EA9220")]
		private unsafe void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
			//Discarded unreachable code: IL_002a, IL_0030
			int num = 0;
			IEnumerable<ControllerMapSaveData> allControllerMapSaveData = (IEnumerable<ControllerMapSaveData>)((PlayerSaveData*)playerSaveData)->get_AllControllerMapSaveData();
			if (allControllerMapSaveData != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0025;
					}
					num++;
				}
				ControllerMap controllerMap = default(ControllerMap);
				SaveControllerMap(player, controllerMap);
			}
			goto IL_0025;
			IL_0025:
			if (allControllerMapSaveData == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1EA90D0", Offset = "0x1EA7AD0", VA = "0x181EA90D0")]
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			//Discarded unreachable code: IL_0061
			int num = 0;
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return;
			}
			Player.ControllerHelper controllers = player.controllers;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			Player.ControllerHelper.MapHelper maps = player.controllers.maps;
			int num2 = 0;
			ControllerMapSaveData[] array = default(ControllerMapSaveData[]);
			if (array != null)
			{
				int length = array.Length;
				if (num2 < length)
				{
					ControllerMap map = array[num2].map;
					SaveControllerMap(player, map);
					num2++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8D30", Offset = "0x1EA7730", VA = "0x181EA8D30")]
		private void SaveControllerMap(Player player, ControllerMap controllerMap)
		{
			//Discarded unreachable code: IL_0180
			//IL_0075: Expected I4, but got I8
			//IL_010d: Expected I4, but got I8
			Controller controller = controllerMap.controller;
			ControllerIdentifier hqIhxyZybqkejspuuoUXDPYHCsYd = controller.HqIhxyZybqkejspuuoUXDPYHCsYd;
			byte d = controller.HqIhxyZybqkejspuuoUXDPYHCsYd.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
			Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controller.HqIhxyZybqkejspuuoUXDPYHCsYd.gjIwAQzDxzoikMpsmpvjOOHYbHh;
			int categoryId = controllerMap.categoryId;
			int layoutId = controllerMap.layoutId;
			string text = playerPrefsKeyPrefix;
			string text2 = player.name;
			string text3 = string.Concat(text + "|playerName=" + text2, "|dataType=ControllerMap");
			int num = 0;
			ulong num2 = default(ulong);
			string controllerMapPlayerPrefsKeyCommonSuffix = GetControllerMapPlayerPrefsKeyCommonSuffix(player, hqIhxyZybqkejspuuoUXDPYHCsYd, categoryId, layoutId, (int)num2);
			string key = text3 + controllerMapPlayerPrefsKeyCommonSuffix;
			string value = controllerMap.ToXmlString();
			PlayerPrefs.SetString(key, value);
			Controller controller2 = controllerMap.controller;
			ControllerIdentifier hqIhxyZybqkejspuuoUXDPYHCsYd2 = controller2.HqIhxyZybqkejspuuoUXDPYHCsYd;
			byte d2 = controller2.HqIhxyZybqkejspuuoUXDPYHCsYd.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
			Guid gjIwAQzDxzoikMpsmpvjOOHYbHh2 = controller2.HqIhxyZybqkejspuuoUXDPYHCsYd.gjIwAQzDxzoikMpsmpvjOOHYbHh;
			categoryId = controllerMap.categoryId;
			int layoutId2 = controllerMap.layoutId;
			string text4 = playerPrefsKeyPrefix;
			string text5 = player.name;
			string text6 = string.Concat(text4 + "|playerName=" + text5, "|dataType=ControllerMap_KnownActionIds");
			ulong num3 = default(ulong);
			string controllerMapPlayerPrefsKeyCommonSuffix2 = GetControllerMapPlayerPrefsKeyCommonSuffix(player, hqIhxyZybqkejspuuoUXDPYHCsYd2, categoryId, layoutId2, (int)num3);
			string key2 = text6 + controllerMapPlayerPrefsKeyCommonSuffix2;
			string _allActionIdsString = __allActionIdsString;
			if ("," != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				List<int> list = (List<int>)(object)this.get_allActionIds();
				if (num > 0)
				{
					StringBuilder stringBuilder2 = stringBuilder.Append(",");
				}
				StringBuilder stringBuilder3 = stringBuilder.Append(num);
				num++;
				string text7 = (__allActionIdsString = stringBuilder.ToString());
			}
			string _allActionIdsString2 = __allActionIdsString;
			PlayerPrefs.SetString(key2, _allActionIdsString2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1EA96C0", Offset = "0x1EA80C0", VA = "0x181EA96C0")]
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
			//Discarded unreachable code: IL_0078
			if (player == null)
			{
				return;
			}
			InputBehavior[] aaGJiiTHKrXqROGWiotZsnpmDLq = playerSaveData.AaGJiiTHKrXqROGWiotZsnpmDLq;
			int num = 0;
			int length = aaGJiiTHKrXqROGWiotZsnpmDLq.Length;
			if (num < length)
			{
				InputBehavior inputBehavior = aaGJiiTHKrXqROGWiotZsnpmDLq[num];
				if (inputBehavior != null)
				{
					int id = inputBehavior._id;
					string text = playerPrefsKeyPrefix;
					string text2 = player.name;
					string text3 = default(string);
					string key = string.Concat(string.Concat(text + "|playerName=" + text2, "|dataType=InputBehavior"), "|id=", text3);
					string value = inputBehavior.ToXmlString();
					PlayerPrefs.SetString(key, value);
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1EA93D0", Offset = "0x1EA7DD0", VA = "0x181EA93D0")]
		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
			//Discarded unreachable code: IL_0052
			int num = 0;
			Player player = ReInput.players.GetPlayer(playerId);
			if (player != null)
			{
				int num2 = 0;
				InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
				if (inputBehavior != null)
				{
					int id = inputBehavior._id;
					string inputBehaviorPlayerPrefsKey = GetInputBehaviorPlayerPrefsKey(player, id);
					string value = inputBehavior.ToXmlString();
					PlayerPrefs.SetString(inputBehaviorPlayerPrefsKey, value);
					int num3 = 0;
					PlayerPrefs.Save();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1EA94E0", Offset = "0x1EA7EE0", VA = "0x181EA94E0")]
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			if (player != null && inputBehavior != null)
			{
				int id = inputBehavior._id;
				string inputBehaviorPlayerPrefsKey = GetInputBehaviorPlayerPrefsKey(player, id);
				string value = inputBehavior.ToXmlString();
				PlayerPrefs.SetString(inputBehaviorPlayerPrefsKey, value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8550", Offset = "0x1EA6F50", VA = "0x181EA8550")]
		private bool SaveControllerAssignments()
		{
			//Discarded unreachable code: IL_009d, IL_00d3, IL_00e4, IL_00ea, IL_00f0, IL_0115, IL_0121, IL_0127, IL_012d, IL_0133, IL_0139, IL_013f, IL_0145, IL_014b, IL_0151, IL_0157, IL_015d, IL_0163, IL_0169, IL_016f, IL_0175, IL_017b
			int num = 0;
			int allPlayerCount = ReInput.players.allPlayerCount;
			ControllerAssignmentSaveInfo controllerAssignmentSaveInfo = new ControllerAssignmentSaveInfo();
			ControllerAssignmentSaveInfo.PlayerInfo[] array = (controllerAssignmentSaveInfo.players = new ControllerAssignmentSaveInfo.PlayerInfo[allPlayerCount]);
			int num2 = 0;
			if (num2 < allPlayerCount)
			{
				ControllerAssignmentSaveInfo.PlayerInfo[] players = controllerAssignmentSaveInfo.players;
				ControllerAssignmentSaveInfo.PlayerInfo playerInfo = new ControllerAssignmentSaveInfo.PlayerInfo();
				if (playerInfo != null && playerInfo == null)
				{
					goto IL_010f;
				}
				num2 += 4;
				num2++;
			}
			int num3 = 0;
			int num4 = 0;
			int allPlayerCount2 = ReInput.players.allPlayerCount;
			if (num3 < allPlayerCount2)
			{
				int num5 = 0;
				IList<Player> allPlayers = (IList<Player>)ReInput.players.get_AllPlayers();
				ControllerAssignmentSaveInfo.PlayerInfo playerInfo2 = new ControllerAssignmentSaveInfo.PlayerInfo();
				ControllerAssignmentSaveInfo.PlayerInfo[] players2 = controllerAssignmentSaveInfo.players;
				if (playerInfo2 == null || playerInfo2 != null)
				{
					throw new IndexOutOfRangeException();
				}
				throw new NullReferenceException();
			}
			string value = JsonWriter.ToJson(controllerAssignmentSaveInfo);
			string key = default(string);
			PlayerPrefs.SetString(key, value);
			int num6 = 0;
			PlayerPrefs.Save();
			goto IL_010f;
			IL_010f:
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3BD0", Offset = "0x1EA25D0", VA = "0x181EA3BD0")]
		private bool ControllerAssignmentSaveDataExists()
		{
			string arg = playerPrefsKeyPrefix;
			if (PlayerPrefs.HasKey(string.Format("{0}_{1}", arg, "ControllerAssignments")))
			{
				string arg2 = playerPrefsKeyPrefix;
				if (PlayerPrefs.GetString(string.Format("{0}_{1}", arg2, "ControllerAssignments")) == null)
				{
					return true;
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3EB0", Offset = "0x1EA28B0", VA = "0x181EA3EB0")]
		private string GetBasePlayerPrefsKey(Player player)
		{
			//Discarded unreachable code: IL_001b
			string text = playerPrefsKeyPrefix;
			string text2 = player.name;
			return text + "|playerName=" + text2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x1EA46E0", Offset = "0x1EA30E0", VA = "0x181EA46E0")]
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			//Discarded unreachable code: IL_0042
			string text = playerPrefsKeyPrefix;
			string text2 = player.name;
			string text3 = string.Concat(text + "|playerName=" + text2, "|dataType=ControllerMap");
			byte d = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
			Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
			string text4 = default(string);
			return text3 + text4;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3F20", Offset = "0x1EA2920", VA = "0x181EA3F20")]
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			//Discarded unreachable code: IL_0042
			string text = playerPrefsKeyPrefix;
			string text2 = player.name;
			string text3 = string.Concat(text + "|playerName=" + text2, "|dataType=ControllerMap_KnownActionIds");
			byte d = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
			Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
			string text4 = default(string);
			return text3 + text4;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4240", Offset = "0x1EA2C40", VA = "0x181EA4240")]
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			//Discarded unreachable code: IL_0132
			string text = default(string);
			string text5 = default(string);
			string text6 = default(string);
			string text9 = default(string);
			string text10 = default(string);
			bool flag = default(bool);
			string text12 = default(string);
			while (true)
			{
				string text2 = "" + "|kv=" + text;
				string text3 = GetControllerMapType(controllerIdentifier.ODiTVfklXHDoeIfdJEahPbsrzhzs).Name;
				string text4 = text2 + "|controllerMapType=" + text3;
				string[] array = new string[5];
				if (text4 != null && array == null)
				{
					continue;
				}
				array[0] = text4;
				if ("|categoryId=" != null && "|categoryId=" == null)
				{
					continue;
				}
				array[1] = "|categoryId=";
				if (text5 != null && text5 == null)
				{
					continue;
				}
				array[2] = text5;
				if ("|layoutId=" != null && "|layoutId=" == null)
				{
					continue;
				}
				array[3] = "|layoutId=";
				if (text6 != null && text6 == null)
				{
					continue;
				}
				array[4] = text6;
				string text7 = string.Concat(array);
				string nbrgCMYAuUfRsiFtxuiXwNSBDYWs = controllerIdentifier.nbrgCMYAuUfRsiFtxuiXwNSBDYWs;
				string text8 = text7 + "|hardwareIdentifier=" + nbrgCMYAuUfRsiFtxuiXwNSBDYWs;
				if (controllerIdentifier.ODiTVfklXHDoeIfdJEahPbsrzhzs == ControllerType.Joystick)
				{
					string text11 = string.Concat(text8 + "|hardwareGuid=" + text9, "|hardwareGuid=", text10);
					if (flag)
					{
						string nbrgCMYAuUfRsiFtxuiXwNSBDYWs2 = controllerIdentifier.nbrgCMYAuUfRsiFtxuiXwNSBDYWs;
						text12 = text11 + "|hardwareIdentifier=" + nbrgCMYAuUfRsiFtxuiXwNSBDYWs2;
					}
					if (controllerIdentifier.ODiTVfklXHDoeIfdJEahPbsrzhzs == ControllerType.Joystick)
					{
						break;
					}
				}
			}
			string text13 = default(string);
			return text12 + "|duplicate=" + text13;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x1EA5040", Offset = "0x1EA3A40", VA = "0x181EA5040")]
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			//Discarded unreachable code: IL_0052
			//IL_001e: Expected O, but got I4
			string text = playerPrefsKeyPrefix + "|dataType=CalibrationMap";
			ControllerType type = joystick.type;
			string text2 = ((Enum)type).ToString();
			ControllerType controllerType = type;
			string text3 = text + "|controllerType=" + text2;
			string hardwareIdentifier = joystick.hardwareIdentifier;
			string text4 = default(string);
			return string.Concat(text3 + "|hardwareIdentifier=" + hardwareIdentifier, "|hardwareGuid=", text4);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4EE0", Offset = "0x1EA38E0", VA = "0x181EA4EE0")]
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			//Discarded unreachable code: IL_0030
			string text = playerPrefsKeyPrefix;
			string text2 = player.name;
			string text3 = default(string);
			return string.Concat(string.Concat(text + "|playerName=" + text2, "|dataType=InputBehavior"), "|id=", text3);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4990", Offset = "0x1EA3390", VA = "0x181EA4990")]
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			int num = 0;
			byte d = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
			Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
			string key = default(string);
			if (!PlayerPrefs.HasKey(key))
			{
			}
			return PlayerPrefs.GetString(key);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4030", Offset = "0x1EA2A30", VA = "0x181EA4030")]
		private unsafe List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			//IL_0086: Expected O, but got I4
			int num = 0;
			List<int> list = (List<int>)(object)new List<T>();
			byte d = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
			Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
			string key = default(string);
			if (!PlayerPrefs.HasKey(key))
			{
				return list;
			}
			string @string = PlayerPrefs.GetString(key);
			while (@string != null)
			{
			}
			char[] array = new char[1];
			uint num2 = default(uint);
			array[0] = (char)num2;
			string[] array2 = @string.Split(array);
			int length = array2.Length;
			while (num >= length)
			{
			}
			string text = array2[num];
			if (num == 0 && int.TryParse(array2[num], out *(int*)num))
			{
				((List<T>)(object)list).Add((T)num);
			}
			num++;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1EA51B0", Offset = "0x1EA3BB0", VA = "0x181EA51B0")]
		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			string joystickCalibrationMapPlayerPrefsKey = GetJoystickCalibrationMapPlayerPrefsKey(joystick);
			if (PlayerPrefs.HasKey(joystickCalibrationMapPlayerPrefsKey))
			{
				return PlayerPrefs.GetString(joystickCalibrationMapPlayerPrefsKey);
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4FB0", Offset = "0x1EA39B0", VA = "0x181EA4FB0")]
		private string GetInputBehaviorXml(Player player, int id)
		{
			string inputBehaviorPlayerPrefsKey = GetInputBehaviorPlayerPrefsKey(player, id);
			if (PlayerPrefs.HasKey(inputBehaviorPlayerPrefsKey))
			{
				return PlayerPrefs.GetString(inputBehaviorPlayerPrefsKey);
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1EA36B0", Offset = "0x1EA20B0", VA = "0x181EA36B0")]
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
			//Discarded unreachable code: IL_00a5, IL_00ab, IL_00b1
			ControllerMap controllerMap2 = default(ControllerMap);
			bool flag = default(bool);
			bool flag2 = default(bool);
			uint num6 = default(uint);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			KeyCode keyCode = default(KeyCode);
			do
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (controllerMap == null || knownActionIds == null)
				{
					break;
				}
				int num4 = 0;
				ReInput.MappingHelper mapping = ReInput.mapping;
				int categoryId = controllerMap.categoryId;
				int layoutId = controllerMap.layoutId;
				byte d = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
				Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
				if (controllerMap2 == null)
				{
					break;
				}
				List<int> list = (List<int>)(object)new List<T>();
				List<int> list2 = (List<int>)(object)this.get_allActionIds();
				if (flag)
				{
					while (flag2)
					{
					}
				}
				int num5 = 0;
				IList<ActionElementMap> allMaps = (IList<ActionElementMap>)controllerMap2.get_AllMaps();
				if (allMaps != null)
				{
					if (num5 < (int)num6)
					{
						num5 += num5;
						if (num5 == (int)num6)
						{
							goto IL_0097;
						}
						num5++;
					}
					while (!flag3)
					{
					}
					while (flag4)
					{
					}
					int num7 = 0;
				}
				goto IL_0097;
				IL_0097:
				if (allMaps != null)
				{
				}
			}
			while (keyCode != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3CA0", Offset = "0x1EA26A0", VA = "0x181EA3CA0")]
		private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			if (joystickInfo != null)
			{
				Guid instanceGuid = joystickInfo.instanceGuid;
				Guid empty = Guid.Empty;
				if (!(instanceGuid == empty))
				{
					int num = 0;
					IList<Joystick> joysticks = (IList<Joystick>)ReInput.controllers.get_Joysticks();
					int num2 = 0;
					if ((long)num2 < (long)(IntPtr)joysticks)
					{
						Guid instanceGuid2 = joystickInfo.instanceGuid;
						bool flag = default(bool);
						if (!flag)
						{
							num2++;
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9FA0", Offset = "0x1EA89A0", VA = "0x181EA9FA0")]
		private unsafe bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			//IL_0009: Expected O, but got I4
			//IL_0009: Expected O, but got Ref
			//IL_0078: Expected O, but got Ref
			int num = 0;
			((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref matches))._items = (T[])num;
			List<Joystick> list = default(List<Joystick>);
			if (joystickInfo != null)
			{
				string hardwareIdentifier = joystickInfo.hardwareIdentifier;
				if ((object)typeof(ReInput).TypeHandle == null)
				{
					int num2 = 0;
					IList<Joystick> joysticks = (IList<Joystick>)ReInput.controllers.get_Joysticks();
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_007c;
						}
						num++;
					}
					if ((long)num < (long)(IntPtr)joysticks)
					{
						uint num4 = default(uint);
						if (num < (int)num4)
						{
							num += num;
							if (num == (int)num4)
							{
								goto IL_0083;
							}
							num++;
						}
						string hardwareIdentifier2 = joystickInfo.hardwareIdentifier;
						string a = default(string);
						if (string.Equals(a, hardwareIdentifier2, StringComparison.OrdinalIgnoreCase))
						{
							list = (List<Joystick>)(object)(((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref matches))._items = (T[])(object)new List<T>());
						}
						num++;
						goto IL_007c;
					}
				}
			}
			goto IL_008a;
			IL_007c:
			list = (List<Joystick>)(object)((object)list + (object)list);
			goto IL_0083;
			IL_008a:
			int num5 = 0;
			throw new NullReferenceException();
			IL_0083:
			list = (List<Joystick>)(object)((object)list + (object)list);
			goto IL_008a;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1EA4A50", Offset = "0x1EA3450", VA = "0x181EA4A50")]
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
		{
			//Discarded unreachable code: IL_00c4, IL_00ca, IL_00d0
			Controller controller = default(Controller);
			uint num3 = default(uint);
			ControllerType controllerType = default(ControllerType);
			int num5 = default(int);
			string text = default(string);
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				ReInput.ControllerHelper controllers = ReInput.controllers;
				byte d = controllerIdentifier.lajutzcDPrsSwSNdnEBSPcUXtaw._d;
				Guid gjIwAQzDxzoikMpsmpvjOOHYbHh = controllerIdentifier.gjIwAQzDxzoikMpsmpvjOOHYbHh;
				if (controller == null)
				{
					break;
				}
				IEnumerable<Controller> controllers2 = (IEnumerable<Controller>)player.controllers.get_Controllers();
				if (controllers2 != null)
				{
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_006d;
						}
						num++;
					}
					int num4 = (int)controllerType;
					ControllerType type = controller.type;
					while (num4 != (int)type)
					{
					}
					num5 = 0;
					if (controller.type == ControllerType.Joystick)
					{
						goto IL_006d;
					}
					goto IL_008b;
				}
				goto IL_00b1;
				IL_008b:
				string hardwareIdentifier = controller.hardwareIdentifier;
				if (text != hardwareIdentifier)
				{
					continue;
				}
				goto IL_00a3;
				IL_00b1:
				num++;
				if (controllers2 != null)
				{
				}
				if (num == 0)
				{
				}
				break;
				IL_006d:
				num5 += num5;
				int num6 = 0;
				int num7 = 0;
				while (flag)
				{
				}
				Guid empty = Guid.Empty;
				if (!flag2)
				{
					goto IL_008b;
				}
				goto IL_00a3;
				IL_00a3:
				if (controllers2 != controller)
				{
					num++;
				}
				num++;
				goto IL_00b1;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1EA80A0", Offset = "0x1EA6AA0", VA = "0x181EA80A0")]
		private void RefreshLayoutManager(int playerId)
		{
			//Discarded unreachable code: IL_0029
			int num = 0;
			ReInput.players.GetPlayer(playerId)?.controllers.maps.ltlEFBArWBqyrigVsdijTohTLHP.Apply();
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1EA47F0", Offset = "0x1EA31F0", VA = "0x181EA47F0")]
		private static Type GetControllerMapType(ControllerType controllerType)
		{
			//Discarded unreachable code: IL_0021
			Debug.LogWarning("Rewired: Unknown ControllerType " + "Rewired: Unknown ControllerType ");
			int num = 0;
			return typeof(CustomControllerMap);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1EAA250", Offset = "0x1EA8C50", VA = "0x181EAA250")]
		public UserDataStore_PlayerPrefs()
		{
		}
	}
}
