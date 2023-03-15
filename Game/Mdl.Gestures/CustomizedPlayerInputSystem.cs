using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Systems;
using Meta.Online;
using Meta.Util;
using Rewired;
using UnityEngine;

namespace Mdl.Gestures
{
	[Cpp2IlInjected.Token(Token = "0x2000539")]
	public class CustomizedPlayerInputSystem : Mdl.Systems.System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002066")]
		[SerializeField]
		private float GlobalDeadZone = 0.333f;

		[Cpp2IlInjected.Token(Token = "0x4002067")]
		public static readonly Dictionary<KeyboardLayout, string> KeyboardLayoutMap;

		[Cpp2IlInjected.Token(Token = "0x170002F6")]
		private static GameSettings Settings
		{
			[Cpp2IlInjected.Token(Token = "0x60016E2")]
			[Cpp2IlInjected.Address(RVA = "0x11106E0", Offset = "0x110F0E0", VA = "0x1811106E0")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
					if (metaClient != null)
					{
						return metaClient.GameSettings;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F7")]
		public Vector2 MouseScaling
		{
			[Cpp2IlInjected.Token(Token = "0x60016E3")]
			[Cpp2IlInjected.Address(RVA = "0x11105F0", Offset = "0x110EFF0", VA = "0x1811105F0")]
			get
			{
				int num = 0;
				GameSettingsData data = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
				int num2 = 0;
				GameSettingsData data2 = (GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016E4")]
		[Cpp2IlInjected.Address(RVA = "0x110FBD0", Offset = "0x110E5D0", VA = "0x18110FBD0")]
		public void ApplyGlobalDeadZone()
		{
			//Discarded unreachable code: IL_0042, IL_0048
			int num = 0;
			int num2 = 0;
			IList<Joystick> joysticks = (IList<Joystick>)ReInput.controllers.get_Joysticks();
			if ((long)num >= (long)(IntPtr)joysticks)
			{
				return;
			}
			int num3 = 0;
			if (ReInput.controllers.get_Joysticks() != null)
			{
				CalibrationMap calibrationMap = default(CalibrationMap);
				IList<AxisCalibration> iSZGfmIMgVldulgoWLsxmbwcafR = calibrationMap.ISZGfmIMgVldulgoWLsxmbwcafR;
				if (calibrationMap != null)
				{
					float globalDeadZone = GlobalDeadZone;
				}
				if (calibrationMap == null)
				{
				}
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x60016E5")]
		[Cpp2IlInjected.Address(RVA = "0x110FE00", Offset = "0x110E800", VA = "0x18110FE00")]
		public static void ApplyKeyboardLayout()
		{
			//Discarded unreachable code: IL_00f0, IL_00f6, IL_00fc, IL_0102, IL_0108, IL_010e, IL_0114, IL_011a, IL_0120, IL_0126
			//IL_0084: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			KeyboardLayout desiredLayout = ((GameSettingsData)((BaseStorage<DataType>)(object)Settings).Data).keyboardLayout_;
			int num3 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			Dictionary<KeyboardLayout, string>.KeyCollection keys = (Dictionary<KeyboardLayout, string>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)KeyboardLayoutMap).get_Keys();
			bool flag = default(bool);
			if (flag)
			{
				KeyboardLayout keyboardLayout = KeyboardLayout.Querty;
				Dictionary<KeyboardLayout, string> keyboardLayoutMap = KeyboardLayoutMap;
				KeyboardLayout keyboardLayout2 = keyboardLayout;
				string layoutTag = (string)((Dictionary<TKey, TValue>)(object)keyboardLayoutMap)[(TKey)keyboardLayout2];
				List<ControllerMapLayoutManager.RuleSet> ruleSets = player.controllers.maps.ltlEFBArWBqyrigVsdijTohTLHP._ruleSets;
				Predicate<ControllerMapLayoutManager.RuleSet> predicate = (Predicate<ControllerMapLayoutManager.RuleSet>)(object)(Predicate<T>)delegate(ControllerMapLayoutManager.RuleSet item)
				{
					//Discarded unreachable code: IL_0014
					string b = layoutTag;
					return string.Equals(item._tag, b);
				};
				List<ControllerMapLayoutManager.RuleSet> list = (List<ControllerMapLayoutManager.RuleSet>)(object)((List<T>)(object)ruleSets).FindAll((Predicate<>)(object)predicate);
				Action<ControllerMapLayoutManager.RuleSet> action = (Action<ControllerMapLayoutManager.RuleSet>)(object)(Action<T>)delegate(ControllerMapLayoutManager.RuleSet item)
				{
					//Discarded unreachable code: IL_0020
					KeyboardLayout keyboardLayout3 = keyboardLayout;
					bool flag2 = (item._enabled = desiredLayout == keyboardLayout3);
				};
				((List<T>)(object)list).ForEach((Action<>)(object)action);
			}
			player.controllers.maps.ltlEFBArWBqyrigVsdijTohTLHP.Apply();
		}

		[Cpp2IlInjected.Token(Token = "0x60016E6")]
		[Cpp2IlInjected.Address(RVA = "0x1110270", Offset = "0x110EC70", VA = "0x181110270")]
		private void OnSettingsLoaded(object sender, EventArgs args)
		{
			ApplyGlobalDeadZone();
			int num = 0;
			ApplyKeyboardLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x60016E7")]
		[Cpp2IlInjected.Address(RVA = "0x11102D0", Offset = "0x110ECD0", VA = "0x1811102D0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_002a
			int num = 0;
			GameSettings settings = Settings;
			EventHandler value = OnSettingsLoaded;
			settings.OnLoaded += value;
			ApplyGlobalDeadZone();
			int num2 = 0;
			ApplyKeyboardLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x60016E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016E9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016EA")]
		[Cpp2IlInjected.Address(RVA = "0x1110410", Offset = "0x110EE10", VA = "0x181110410", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			if (Settings != null)
			{
				int num2 = 0;
				GameSettings settings = Settings;
				EventHandler value = OnSettingsLoaded;
				settings.OnLoaded -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016EB")]
		[Cpp2IlInjected.Address(RVA = "0x11105E0", Offset = "0x110EFE0", VA = "0x1811105E0")]
		public CustomizedPlayerInputSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60016EC")]
		[Cpp2IlInjected.Address(RVA = "0x1110500", Offset = "0x110EF00", VA = "0x181110500")]
		static CustomizedPlayerInputSystem()
		{
			//Discarded unreachable code: IL_000c, IL_0012
			Dictionary<KeyboardLayout, string> dictionary = (Dictionary<KeyboardLayout, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}
	}
}
