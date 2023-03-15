using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Gameloft.Common;
using Rewired;
using Rewired.Dev.Tools;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000882")]
	public class RewiredControllerManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4003260")]
		private const int ControllerReconnectionTimeInterval = 1;

		[Cpp2IlInjected.Token(Token = "0x60035BA")]
		[Cpp2IlInjected.Address(RVA = "0xE330B0", Offset = "0xE31AB0", VA = "0x180E330B0")]
		private void Awake()
		{
			LayoutManagerApply();
		}

		[Cpp2IlInjected.Token(Token = "0x60035BB")]
		[Cpp2IlInjected.Address(RVA = "0xE34A40", Offset = "0xE33440", VA = "0x180E34A40")]
		public void OnControllerConnected(ControllerStatusChangedEventArgs controller)
		{
			//Discarded unreachable code: IL_0090
			//IL_003b: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			int num = 0;
			ReInput.ControllerHelper controllers = ReInput.controllers;
			int oAqYXyYxxoyErUWWGBOiLsNcUok = controller.OAqYXyYxxoyErUWWGBOiLsNcUok;
			int playerId = 0;
			bool flag = controllers.IsJoystickAssignedToPlayer(oAqYXyYxxoyErUWWGBOiLsNcUok, playerId);
			int oAqYXyYxxoyErUWWGBOiLsNcUok2 = controller.OAqYXyYxxoyErUWWGBOiLsNcUok;
			string rxFXeRTtpDKAOGNDPEpHeMwItpAb = controller.rxFXeRTtpDKAOGNDPEpHeMwItpAb;
			Debug.Log($"OnControllerConnected {rxFXeRTtpDKAOGNDPEpHeMwItpAb}({flag}) isJoystickAssignedToPlayer={flag}");
			if (!flag)
			{
				int num2 = 0;
				ReInput.ControllerHelper controllers2 = ReInput.controllers;
				int oAqYXyYxxoyErUWWGBOiLsNcUok3 = controller.OAqYXyYxxoyErUWWGBOiLsNcUok;
				Joystick joystick = controllers2.GetJoystick(oAqYXyYxxoyErUWWGBOiLsNcUok3);
				if (joystick != null)
				{
					int num3 = 0;
					bool flag2 = ReInput.controllers.AutoAssignJoystick(joystick);
					Debug.Log($"OnControllerConnected is now assigned to player ? assignedToPlayer={flag2}");
				}
			}
			LayoutManagerApply();
		}

		[Cpp2IlInjected.Token(Token = "0x60035BC")]
		[Cpp2IlInjected.Address(RVA = "0xE34C90", Offset = "0xE33690", VA = "0x180E34C90")]
		public void OnControllerDisconnected(ControllerStatusChangedEventArgs controller)
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60035BD")]
		[Cpp2IlInjected.Address(RVA = "0xE330C0", Offset = "0xE31AC0", VA = "0x180E330C0")]
		[AsyncStateMachine(typeof(_003CControllerSyncTask_003Ed__4))]
		private Task ControllerSyncTask(ControllerStatusChangedEventArgs controller)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035BE")]
		[Cpp2IlInjected.Address(RVA = "0xE34EC0", Offset = "0xE338C0", VA = "0x180E34EC0")]
		private void UpdateActiveLayoutRules(Player player)
		{
			//Discarded unreachable code: IL_00c4
			bool flag = default(bool);
			Action<ControllerMapLayoutManager.RuleSet> action = default(Action<ControllerMapLayoutManager.RuleSet>);
			List<> list = default(List<>);
			List<> list2 = default(List<>);
			do
			{
				List<ControllerMapLayoutManager.RuleSet> ruleSets = player.controllers.maps.ltlEFBArWBqyrigVsdijTohTLHP._ruleSets;
				if (flag)
				{
				}
				int num = 0;
				bool flag2 = InputDetectionHelper.IsNintendoController();
				if (!flag2)
				{
					int num2 = 0;
					if (!flag2)
					{
						int num3 = 0;
						if (!flag2)
						{
							return;
						}
					}
					if (_003C_003Ec._003C_003E9__5_2 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ControllerMapLayoutManager.RuleSet item) => string.Equals(item._tag, "platform_playstation"));
					}
					if (_003C_003Ec._003C_003E9__5_3 == null)
					{
						action = (Action<ControllerMapLayoutManager.RuleSet>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(ControllerMapLayoutManager.RuleSet item)
						{
							//Discarded unreachable code: IL_0008
							item._enabled = true;
						});
					}
					((List<T>)(object)list).ForEach((Action<>)(object)action);
					return;
				}
				if (_003C_003Ec._003C_003E9__5_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((ControllerMapLayoutManager.RuleSet item) => string.Equals(item._tag, "platform_switch"));
				}
				list = list2;
			}
			while (_003C_003Ec._003C_003E9__5_1 != null);
			Action<ControllerMapLayoutManager.RuleSet> action2 = (Action<ControllerMapLayoutManager.RuleSet>)(object)(Action<T>)delegate(ControllerMapLayoutManager.RuleSet item)
			{
				//Discarded unreachable code: IL_0008
				item._enabled = true;
			};
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035BF")]
		[Cpp2IlInjected.Address(RVA = "0xE34860", Offset = "0xE33260", VA = "0x180E34860")]
		private void LayoutManagerApply()
		{
			//Discarded unreachable code: IL_0042
			int num = 0;
			int num2 = 0;
			int playerCount = ReInput.players.playerCount;
			if (num < playerCount)
			{
				int num3 = 0;
				IList<Player> players = (IList<Player>)ReInput.players.get_Players();
				num++;
			}
			GraphicSettingsData _003CCurrentGraphicSettingsData_003Ek__BackingField = GraphicSettings.CurrentGraphicSettingsData;
			if ((object)_003CCurrentGraphicSettingsData_003Ek__BackingField != null && _003CCurrentGraphicSettingsData_003Ek__BackingField.RewiredDisableKeyboard)
			{
				DisableKeyboard();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035C0")]
		[Cpp2IlInjected.Address(RVA = "0xE34DD0", Offset = "0xE337D0", VA = "0x180E34DD0")]
		public void ToggleDebugInformationGUI()
		{
			//Discarded unreachable code: IL_0037
			//IL_0015: Expected O, but got I4
			DebugInformation component = base.gameObject.GetComponent<DebugInformation>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				bool flag2 = (component.enabled = !component.enabled);
			}
			else
			{
				DebugInformation debugInformation = base.gameObject.AddComponent<DebugInformation>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035C1")]
		[Cpp2IlInjected.Address(RVA = "0xE343A0", Offset = "0xE32DA0", VA = "0x180E343A0")]
		public void DisableKeyboard()
		{
			//Discarded unreachable code: IL_0054, IL_005a, IL_0060, IL_0066, IL_006c, IL_0072
			int num = 0;
			Debug.Log("RewiredKeyboard is disabled.");
			int num2 = 0;
			IList<Player> players = (IList<Player>)ReInput.players.get_Players();
			int num6 = default(int);
			if (players != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0048;
					}
					num++;
				}
				Keyboard keyboard = default(Keyboard);
				int num4 = ((keyboard.enabled = false) ? 1 : 0);
				bool ebJsAuYejvRqociTxulmKyAPKrq = ((Controller)keyboard).ebJsAuYejvRqociTxulmKyAPKrq;
				int num5 = 0;
				num6 = 0;
				goto IL_0048;
			}
			goto IL_004f;
			IL_004f:
			if (players == null)
			{
			}
			return;
			IL_0048:
			num6 += num6;
			goto IL_004f;
		}

		[Cpp2IlInjected.Token(Token = "0x60035C2")]
		[Cpp2IlInjected.Address(RVA = "0xE34600", Offset = "0xE33000", VA = "0x180E34600")]
		public void DisableMouse()
		{
			//Discarded unreachable code: IL_0054, IL_005a, IL_0060, IL_0066, IL_006c, IL_0072
			int num = 0;
			Debug.Log("RewiredMouse is disabled.");
			int num2 = 0;
			IList<Player> players = (IList<Player>)ReInput.players.get_Players();
			int num6 = default(int);
			if (players != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0048;
					}
					num++;
				}
				Mouse mouse = default(Mouse);
				int num4 = ((mouse.enabled = false) ? 1 : 0);
				bool ebJsAuYejvRqociTxulmKyAPKrq = ((Controller)mouse).ebJsAuYejvRqociTxulmKyAPKrq;
				int num5 = 0;
				num6 = 0;
				goto IL_0048;
			}
			goto IL_004f;
			IL_004f:
			if (players == null)
			{
			}
			return;
			IL_0048:
			num6 += num6;
			goto IL_004f;
		}

		[Cpp2IlInjected.Token(Token = "0x60035C3")]
		[Cpp2IlInjected.Address(RVA = "0xE331C0", Offset = "0xE31BC0", VA = "0x180E331C0")]
		private void DBG_TraceEverything(string header)
		{
			//Discarded unreachable code: IL_013a, IL_0142, IL_014d, IL_0170, IL_0177, IL_017d, IL_0185, IL_018b
			//IL_02b4: Expected O, but got I4
			//IL_02b4: Expected O, but got I4
			//IL_02b4: Expected O, but got I4
			string text = default(string);
			string text3 = default(string);
			string text4 = default(string);
			string text5 = default(string);
			bool flag = default(bool);
			string text6 = default(string);
			string text7 = default(string);
			IList<Joystick> list = default(IList<Joystick>);
			bool flag2 = default(bool);
			string text9 = default(string);
			IList<ControllerMap> list2 = default(IList<ControllerMap>);
			int mapCategoryId = default(int);
			int layoutId = default(int);
			bool flag3 = default(bool);
			ActionElementMap[] array3 = default(ActionElementMap[]);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int joystickCount = ReInput.controllers.joystickCount;
				string text2 = "Rewired found " + text + " joysticks attached.";
				int num3 = 0;
				int joystickCount2 = ReInput.controllers.joystickCount;
				if (num < joystickCount2)
				{
					int num4 = 0;
					IList<Joystick> joysticks = (IList<Joystick>)ReInput.controllers.get_Joysticks();
					string[] array = new string[10];
					if ("[" != null && array == null)
					{
						continue;
					}
					array[0] = "[";
					if (text3 != null && text3 == null)
					{
						continue;
					}
					array[1] = text3;
					if ("] Joystick: " != null && "] Joystick: " == null)
					{
						continue;
					}
					array[2] = "] Joystick: ";
					if (text4 != null && text4 == null)
					{
						continue;
					}
					array[3] = text4;
					if ("\nHardware Name: " != null && "\nHardware Name: " == null)
					{
						continue;
					}
					array[4] = "\nHardware Name: ";
					if (text5 != null && text5 == null)
					{
						continue;
					}
					array[5] = text5;
					if ("\nIs Recognized: " == null || "\nIs Recognized: " != null)
					{
						array[6] = "\nIs Recognized: ";
						Guid empty = Guid.Empty;
						text5 = "No";
						if (flag)
						{
							text5 = "Yes";
						}
						if (text5 == null || flag)
						{
							throw new IndexOutOfRangeException();
						}
					}
					continue;
				}
				int num5 = 0;
				IList<Player> players = (IList<Player>)ReInput.players.get_Players();
				if (players != null)
				{
					string[] array2 = new string[5];
					if ("PlayerId = " != null && "PlayerId = " == null)
					{
						continue;
					}
					array2[0] = "PlayerId = ";
					if (text6 != null && text6 == null)
					{
						continue;
					}
					array2[1] = text6;
					if (" is assigned " != null && " is assigned " == null)
					{
						continue;
					}
					array2[2] = " is assigned ";
					if (text7 != null && text7 == null)
					{
						continue;
					}
					array2[3] = text7;
					if (" joysticks." != null && " joysticks." == null)
					{
						continue;
					}
					array2[4] = " joysticks.";
					string text8 = string.Concat(array2);
					if (list != null)
					{
						Guid empty2 = Guid.Empty;
						if (!flag2)
						{
						}
						string text10 = "Joystick: " + text9 + "\nIs Recognized: " + "Yes";
						if (list2 != null)
						{
							int num6 = 0;
							if (ReInput.mapping.GetMapCategory(mapCategoryId) != null)
							{
							}
							int num7 = 0;
							if (ReInput.mapping.GetJoystickLayout(layoutId) != null)
							{
							}
							string text11 = $"Controller Map:\n Category = {num}\nLayout = {num}\nenabled = {flag3}";
							while (num >= array3.Length)
							{
							}
							ActionElementMap actionElementMap = array3[num];
							int num8 = 0;
							ReInput.MappingHelper mapping = ReInput.mapping;
							int actionId = actionElementMap._actionId;
							InputAction action = mapping.GetAction(actionId);
							if (action != null)
							{
								string[] array4 = new string[5];
								if ("Action \"" != null && "Action \"" == null)
								{
									continue;
								}
								array4[0] = "Action \"";
								string text12 = action._name;
								if (text12 != null && "Action \"" == null)
								{
									continue;
								}
								array4[1] = text12;
								if ("\" is bound to \"" != null && "\" is bound to \"" == null)
								{
									continue;
								}
								array4[2] = "\" is bound to \"";
								string elementIdentifierName = actionElementMap.elementIdentifierName;
								if (elementIdentifierName != null && elementIdentifierName == null)
								{
									continue;
								}
								array4[3] = elementIdentifierName;
								if ("\"" != null && "\"" == null)
								{
									continue;
								}
								array4[4] = "\"";
								string text13 = string.Concat(array4);
							}
							num++;
						}
						if (list2 != null)
						{
						}
						if (num != 0)
						{
							continue;
						}
					}
					if (list != null)
					{
					}
					if (num != 0)
					{
						continue;
					}
				}
				if (players != null)
				{
				}
				if (num == 0)
				{
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035C4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public RewiredControllerManager()
		{
		}
	}
}
