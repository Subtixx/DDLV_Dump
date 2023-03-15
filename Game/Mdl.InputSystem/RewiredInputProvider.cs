using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using Cpp2IlInjected;
using Mdl.Utils;
using Rewired;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003E2")]
	public class RewiredInputProvider : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003E3")]
		private enum MapState
		{
			[Cpp2IlInjected.Token(Token = "0x4001947")]
			Enabled,
			[Cpp2IlInjected.Token(Token = "0x4001948")]
			Disabled
		}

		[Cpp2IlInjected.Token(Token = "0x20003E4")]
		public class RewiredPlayerInputProvider : InputProvider
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001949")]
			private Player rewiredPlayer;

			[Cpp2IlInjected.Token(Token = "0x60010B8")]
			[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
			public RewiredPlayerInputProvider(Player player)
			{
				((CommonAcl._003C_003Ec__DisplayClass57_0)(object)this)._002Ector();
				rewiredPlayer = player;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60010B9")]
			[Cpp2IlInjected.Address(RVA = "0x1603F50", Offset = "0x1602950", VA = "0x181603F50", Slot = "4")]
			public override bool GetBool(string inputName)
			{
				//Discarded unreachable code: IL_000d
				return rewiredPlayer.GetButton(inputName);
			}

			[Cpp2IlInjected.Token(Token = "0x60010BA")]
			[Cpp2IlInjected.Address(RVA = "0x1603F90", Offset = "0x1602990", VA = "0x181603F90", Slot = "5")]
			public override float GetFloat(string inputName)
			{
				//Discarded unreachable code: IL_000d
				return rewiredPlayer.GetAxis(inputName);
			}

			[Cpp2IlInjected.Token(Token = "0x60010BB")]
			[Cpp2IlInjected.Address(RVA = "0x1603F70", Offset = "0x1602970", VA = "0x181603F70", Slot = "6")]
			public override float GetFloatRaw(string inputName)
			{
				//Discarded unreachable code: IL_000d
				return rewiredPlayer.GetAxisRaw(inputName);
			}

			[Cpp2IlInjected.Token(Token = "0x60010BC")]
			[Cpp2IlInjected.Address(RVA = "0x1603F30", Offset = "0x1602930", VA = "0x181603F30", Slot = "7")]
			public override Vector2 GetAxis2D(string xInputName, string yInputName)
			{
				//Discarded unreachable code: IL_000e
				return rewiredPlayer.GetAxis2D(xInputName, yInputName);
			}

			[Cpp2IlInjected.Token(Token = "0x60010BD")]
			[Cpp2IlInjected.Address(RVA = "0x1603F10", Offset = "0x1602910", VA = "0x181603F10", Slot = "8")]
			public override Vector2 GetAxis2DRaw(string xInputName, string yInputName)
			{
				//Discarded unreachable code: IL_000e
				return rewiredPlayer.GetAxis2DRaw(xInputName, yInputName);
			}

			[Cpp2IlInjected.Token(Token = "0x60010BE")]
			[Cpp2IlInjected.Address(RVA = "0x1603F00", Offset = "0x1602900", VA = "0x181603F00", Slot = "9")]
			public override void EnableMaps(params int[] maps)
			{
				RewiredInputProvider.EnableMaps(maps);
			}

			[Cpp2IlInjected.Token(Token = "0x60010BF")]
			[Cpp2IlInjected.Address(RVA = "0x1603EF0", Offset = "0x16028F0", VA = "0x181603EF0", Slot = "10")]
			public override void DisableMaps(params int[] maps)
			{
				RewiredInputProvider.DisableMaps(maps);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001942")]
		private Dictionary<Player, InputProvider> playerInputProviders = (Dictionary<Player, InputProvider>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001943")]
		private Dictionary<int, MapState> mapStates = (Dictionary<int, MapState>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001944")]
		private CallOnce bindEvents = new CallOnce();

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		private static RewiredInputProvider Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60010AE")]
			[Cpp2IlInjected.Address(RVA = "0xCC5060", Offset = "0xCC3A60", VA = "0x180CC5060")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60010AF")]
			[Cpp2IlInjected.Address(RVA = "0xCC50A0", Offset = "0xCC3AA0", VA = "0x180CC50A0")]
			[CompilerGenerated]
			set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010AD")]
		[Cpp2IlInjected.Address(RVA = "0xCC4F30", Offset = "0xCC3930", VA = "0x180CC4F30")]
		public RewiredInputProvider()
		{
			Instance = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010B0")]
		[Cpp2IlInjected.Address(RVA = "0xCC4990", Offset = "0xCC3390", VA = "0x180CC4990")]
		public unsafe static InputProvider GetPlayerInputProvider(Player player)
		{
			//Discarded unreachable code: IL_0032, IL_0037, IL_0051, IL_0062
			//IL_0017: Expected O, but got I4
			CallOnce callOnce = Instance.bindEvents;
			int num = default(int);
			Action a = new Action(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<void>*/)(&BindToControllerConnectionEvents));
			num = 0;
			callOnce.InvokeOnce(a);
			Dictionary<Player, InputProvider> dictionary = Instance.playerInputProviders;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010B1")]
		[Cpp2IlInjected.Address(RVA = "0xCC46C0", Offset = "0xCC30C0", VA = "0x180CC46C0")]
		private static void EnableMaps(params int[] maps)
		{
			//Discarded unreachable code: IL_0029, IL_002e, IL_003d, IL_004b, IL_0054, IL_0062, IL_0067, IL_006d, IL_0073, IL_0079
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (num3 < maps.Length)
			{
				int num4 = maps[num3];
				Dictionary<int, MapState> dictionary = Instance.mapStates;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010B2")]
		[Cpp2IlInjected.Address(RVA = "0xCC43F0", Offset = "0xCC2DF0", VA = "0x180CC43F0")]
		private static void DisableMaps(params int[] maps)
		{
			//Discarded unreachable code: IL_0029, IL_002e, IL_003d, IL_004b, IL_0054, IL_0062, IL_0065, IL_006a, IL_0070, IL_0076, IL_007c
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (num3 < maps.Length)
			{
				int num4 = maps[num3];
				Dictionary<int, MapState> dictionary = Instance.mapStates;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010B3")]
		[Cpp2IlInjected.Address(RVA = "0xCC3FD0", Offset = "0xCC29D0", VA = "0x180CC3FD0")]
		private unsafe static void BindToControllerConnectionEvents()
		{
			//IL_000c: Expected O, but got I4
			int num = default(int);
			Action<ControllerStatusChangedEventArgs> action = (Action<ControllerStatusChangedEventArgs>)(object)new Action<T>(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<ControllerStatusChangedEventArgs, void>*/)(&ReInput_ControllerConnectedEvent));
			num = 0;
			ReInput.add_ControllerConnectedEvent((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x60010B4")]
		[Cpp2IlInjected.Address(RVA = "0xCC4C20", Offset = "0xCC3620", VA = "0x180CC4C20")]
		private static void ReInput_ControllerConnectedEvent(ControllerStatusChangedEventArgs obj)
		{
			//Discarded unreachable code: IL_0033, IL_0039, IL_003f, IL_0045, IL_004b, IL_0051
			int num = 0;
			int num2 = 0;
			Dictionary<Player, InputProvider>.KeyCollection keys = (Dictionary<Player, InputProvider>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)Instance.playerInputProviders).get_Keys();
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<int, MapState> dictionary = Instance.mapStates;
				bool flag2 = default(bool);
				if (flag2)
				{
					Controller controller = obj.controller;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010B5")]
		[Cpp2IlInjected.Address(RVA = "0xCC42B0", Offset = "0xCC2CB0", VA = "0x180CC42B0")]
		private static string[] DebugMapNames(int[] maps)
		{
			Func<int, string> _003C_003E9__14_ = _003C_003Ec._003C_003E9__14_0;
			if (_003C_003E9__14_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int m) => DebugMapName(m));
			}
			return Enumerable.Select<int, string>((IEnumerable<>)(object)maps, (Func<, >)(object)_003C_003E9__14_).ToArray<string>();
		}

		[Cpp2IlInjected.Token(Token = "0x60010B6")]
		[Cpp2IlInjected.Address(RVA = "0xCC4070", Offset = "0xCC2A70", VA = "0x180CC4070")]
		private static string DebugMapName(int map)
		{
			//Discarded unreachable code: IL_0039, IL_003f
			int num = 0;
			int num2 = 0;
			IList<InputMapCategory> mapCategories = (IList<InputMapCategory>)ReInput.mapping.get_MapCategories();
			if (mapCategories != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0027;
					}
					num++;
				}
				num++;
			}
			goto IL_0027;
			IL_0027:
			num++;
			if (mapCategories != null)
			{
			}
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010B7")]
		[Cpp2IlInjected.Address(RVA = "0xCC4BA0", Offset = "0xCC35A0", VA = "0x180CC4BA0")]
		[Conditional("DEBUG_REWIRED_CONTROLLER_CONNECTIONS")]
		private static void Log(string message)
		{
			UnityEngine.Debug.Log("RewiredInputProvider: " + message);
		}
	}
}
