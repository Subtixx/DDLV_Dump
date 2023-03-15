using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Rewired;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000011")]
public class Input : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum Mode
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		pc,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		touch,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		both
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class Button
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum Status
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			down,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			pressed,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			up,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			released
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Status status;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public float Time;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Button()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class Axis
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float Time;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0370", Offset = "0x3DBED70", VA = "0x183DC0370")]
		public Axis(string name, float value, float time)
		{
			this.name = name;
			Value = value;
			Time = time;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static Mode mode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Mode _mode = Mode.both;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static List<Button> CurrentButtons;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static Button[] ButtonsPool;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static float time;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static int CurrentButtonPoolIndex;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static List<Axis> Axes;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static int NumberOfSimultaneousButtons;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static List<string> ButtonsDown;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static List<string> ButtonsHold;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static List<string> ButtonsUp;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static int lastFrameUpdated;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static IDictionary<string, float> MobileAxes;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[field: Cpp2IlInjected.Token(Token = "0x400005A")]
	public static bool InteractingWithTextField
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2F156B0", Offset = "0x2F140B0", VA = "0x182F156B0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2F15B90", Offset = "0x2F14590", VA = "0x182F15B90")]
		set;
	} = (byte)(int)new List<T>() != 0;


	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[field: Cpp2IlInjected.Token(Token = "0x400005B")]
	public static bool InteractingWithScrollingUI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2F15650", Offset = "0x2F14050", VA = "0x182F15650")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2F15B30", Offset = "0x2F14530", VA = "0x182F15B30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool mousePresent
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x282A700", Offset = "0x2829100", VA = "0x18282A700")]
		get
		{
			int num = 0;
			return UnityEngine.Input.mousePresent;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Vector2 mousePosition
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x27FF170", Offset = "0x27FDB70", VA = "0x1827FF170")]
		get
		{
			Vector3 vector = UnityEngine.Input.mousePosition;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool anyKeyDown
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2F157D0", Offset = "0x2F141D0", VA = "0x182F157D0")]
		get
		{
			//Discarded unreachable code: IL_0051
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			IEnumerable<Controller> controllers = (IEnumerable<Controller>)players.GetPlayer(playerId).controllers.get_Controllers();
			Func<Controller, bool> _003C_003E9__20_ = _003C_003Ec._003C_003E9__20_0;
			if (_003C_003E9__20_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Controller c)
				{
					Guid deviceInstanceGuid = c.deviceInstanceGuid;
					throw new NullReferenceException();
				};
			}
			if (((IEnumerable<>)controllers).Any<Controller>((Func<, >)(object)_003C_003E9__20_))
			{
			}
			int num2 = 0;
			return UnityEngine.Input.anyKeyDown;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool anyKey
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2F159C0", Offset = "0x2F143C0", VA = "0x182F159C0")]
		get
		{
			//Discarded unreachable code: IL_0017
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			return players.GetPlayer(playerId).GetAnyButton();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static AccelerationEvent[] accelerationEvents
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2F15790", Offset = "0x2F14190", VA = "0x182F15790")]
		get
		{
			int num = 0;
			return UnityEngine.Input.accelerationEvents;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static int accelerationEventCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2F15780", Offset = "0x2F14180", VA = "0x182F15780")]
		get
		{
			int num = 0;
			return UnityEngine.Input.accelerationEventCount;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static Vector3 acceleration
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2F157A0", Offset = "0x2F141A0", VA = "0x182F157A0")]
		get
		{
			float z = UnityEngine.Input.acceleration.z;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private static Player RewiredPlayer
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2F15710", Offset = "0x2F14110", VA = "0x182F15710")]
		get
		{
			//Discarded unreachable code: IL_0012
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			return players.GetPlayer(playerId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static int touchCount
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2F15A70", Offset = "0x2F14470", VA = "0x182F15A70")]
		get
		{
			//Discarded unreachable code: IL_000d
			int num = 0;
			return ReInput.touch.touchCount;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Touch[] touches
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2F15AD0", Offset = "0x2F144D0", VA = "0x182F15AD0")]
		get
		{
			//Discarded unreachable code: IL_000d
			int num = 0;
			return ReInput.touch.touches;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2F12A50", Offset = "0x2F11450", VA = "0x182F12A50")]
	public static AccelerationEvent GetAccelerationEvent(int index)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2F146A0", Offset = "0x2F130A0", VA = "0x182F146A0")]
	public static bool HasGameController()
	{
		//Discarded unreachable code: IL_0010
		int num = 0;
		return ReInput.controllers.joystickCount > 0;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2F13C00", Offset = "0x2F12600", VA = "0x182F13C00")]
	public static string[] GetJoystickNames()
	{
		//Discarded unreachable code: IL_000d
		int num = 0;
		return ReInput.controllers.GetJoystickNames();
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2F15390", Offset = "0x2F13D90", VA = "0x182F15390")]
	public static void ResetInputAxes()
	{
		int num = 0;
		UnityEngine.Input.ResetInputAxes();
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2F13270", Offset = "0x2F11C70", VA = "0x182F13270")]
	public static bool GetButtonDown(string Button)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetButtonDown(Button);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2F13350", Offset = "0x2F11D50", VA = "0x182F13350")]
	public static bool GetButtonDown(int actionId)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetButtonDown(actionId);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2F13B20", Offset = "0x2F12520", VA = "0x182F13B20")]
	public static bool GetButton(string Button)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetButton(Button);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2F13A40", Offset = "0x2F12440", VA = "0x182F13A40")]
	public static bool GetButton(int actionId)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetButton(actionId);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2F13960", Offset = "0x2F12360", VA = "0x182F13960")]
	public static bool GetButtonUp(string Button)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetButtonUp(Button);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2F13880", Offset = "0x2F12280", VA = "0x182F13880")]
	public static bool GetButtonUp(int actionId)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetButtonUp(actionId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2F144E0", Offset = "0x2F12EE0", VA = "0x182F144E0")]
	public static bool GetMouseButton(int button)
	{
		int num = 0;
		Guid deviceInstanceGuid = ((Controller)ReInput.controllers.Mouse).deviceInstanceGuid;
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F142C0", Offset = "0x2F12CC0", VA = "0x182F142C0")]
	public static bool GetMouseButtonDown(int button)
	{
		int num = 0;
		Guid deviceInstanceGuid = ((Controller)ReInput.controllers.Mouse).deviceInstanceGuid;
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F143D0", Offset = "0x2F12DD0", VA = "0x182F143D0")]
	public static bool GetMouseButtonUp(int button)
	{
		int num = 0;
		Guid deviceInstanceGuid = ((Controller)ReInput.controllers.Mouse).deviceInstanceGuid;
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2F140A0", Offset = "0x2F12AA0", VA = "0x182F140A0")]
	public static bool GetKey(string key)
	{
		int num = 0;
		ReInput.PlayerHelper players = ReInput.players;
		int playerId = 0;
		Player player = players.GetPlayer(playerId);
		if (player != null)
		{
			return player.GetButton(key);
		}
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2F13C60", Offset = "0x2F12660", VA = "0x182F13C60")]
	public static bool GetKeyDown(string key)
	{
		int num = 0;
		ReInput.PlayerHelper players = ReInput.players;
		int playerId = 0;
		Player player = players.GetPlayer(playerId);
		if (player != null)
		{
			return player.GetButtonDown(key);
		}
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2F13F90", Offset = "0x2F12990", VA = "0x182F13F90")]
	public static bool GetKeyUp(string key)
	{
		int num = 0;
		ReInput.PlayerHelper players = ReInput.players;
		int playerId = 0;
		Player player = players.GetPlayer(playerId);
		if (player != null)
		{
			return player.GetButtonUp(key);
		}
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2F141B0", Offset = "0x2F12BB0", VA = "0x182F141B0")]
	public static bool GetKey(KeyCode key)
	{
		//Discarded unreachable code: IL_0011
		int num = 0;
		Keyboard keyboard = ReInput.controllers.Keyboard;
		bool result = default(bool);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2F13D70", Offset = "0x2F12770", VA = "0x182F13D70")]
	public static bool GetKeyDown(KeyCode key)
	{
		//Discarded unreachable code: IL_0011
		int num = 0;
		Keyboard keyboard = ReInput.controllers.Keyboard;
		bool result = default(bool);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2F13E80", Offset = "0x2F12880", VA = "0x182F13E80")]
	public static bool GetKeyUp(KeyCode key)
	{
		//Discarded unreachable code: IL_0011
		int num = 0;
		Keyboard keyboard = ReInput.controllers.Keyboard;
		bool result = default(bool);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2F13020", Offset = "0x2F11A20", VA = "0x182F13020")]
	public static float GetAxis(string axis)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetAxis(axis);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2F12D80", Offset = "0x2F11780", VA = "0x182F12D80")]
	public static float GetAxisRaw(string axis)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetAxisRaw(axis);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2F12F40", Offset = "0x2F11940", VA = "0x182F12F40")]
	public static float GetAxis(int actionId)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetAxis(actionId);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2F12E60", Offset = "0x2F11860", VA = "0x182F12E60")]
	public static float GetAxisRaw(int actionId)
	{
		//Discarded unreachable code: IL_000e
		int num = 0;
		return RewiredPlayer.GetAxisRaw(actionId);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2F145F0", Offset = "0x2F12FF0", VA = "0x182F145F0")]
	public static Touch GetTouch(int index)
	{
		int num = 0;
		ReInput.UnityTouch touch = ReInput.touch;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F154F0", Offset = "0x2F13EF0", VA = "0x182F154F0")]
	public void Start()
	{
		Initialize();
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2F129D0", Offset = "0x2F113D0", VA = "0x182F129D0")]
	private void FixedUpdate()
	{
		//Discarded unreachable code: IL_000d
		int num = 0;
		time = Time.time;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2F14950", Offset = "0x2F13350", VA = "0x182F14950")]
	private void LateUpdate()
	{
		int num = 0;
		ClearUpsAndEvolveDownToPressedOld();
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2F14710", Offset = "0x2F13110", VA = "0x182F14710")]
	public void Initialize()
	{
		//Discarded unreachable code: IL_005e
		//IL_000f: Expected I4, but got O
		//IL_0019: Expected I4, but got O
		//IL_0023: Expected I4, but got O
		while (true)
		{
			InteractingWithTextField = (byte)(int)new Button[NumberOfSimultaneousButtons] != 0;
			InteractingWithTextField = (byte)(int)new List<T>() != 0;
			InteractingWithTextField = (byte)(int)new List<T>() != 0;
			Mode mode = _mode;
			int num = 0;
			Input.mode = mode;
			Button[] buttonsPool = ButtonsPool;
			if (num < buttonsPool.Length)
			{
				Button[] buttonsPool2 = ButtonsPool;
				Button button = new Button();
				if (button == null || button != null)
				{
					throw new IndexOutOfRangeException();
				}
				continue;
			}
			break;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2F123C0", Offset = "0x2F10DC0", VA = "0x182F123C0")]
	public static void Autoconfigure()
	{
		//IL_0014: Expected O, but got I4
		//IL_002b: Expected O, but got I4
		GameObject gameObject = GameObject.Find("GenericFunctionsInstance");
		int num = 0;
		if (gameObject == (UnityEngine.Object)num)
		{
			GameObject gameObject2 = GameObject.Find("InputManager");
		}
		int num2 = 0;
		if (!(gameObject == (UnityEngine.Object)num2))
		{
			if (!gameObject.GetComponent<Input>())
			{
				Input input = gameObject.AddComponent<Input>();
			}
			return;
		}
		new GameObject().name = "InputManager";
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2F13430", Offset = "0x2F11E30", VA = "0x182F13430")]
	public unsafe static bool GetButtonMobileOld(string name, Button.Status status)
	{
		//Discarded unreachable code: IL_002b
		int num = 0;
		List<Button> currentButtons = CurrentButtons;
		List<Button> currentButtons2 = CurrentButtons;
		Button[] buttonsPool = ButtonsPool;
		num++;
		List<Button> currentButtons3 = CurrentButtons;
		return (IntPtr)"{il2cpp field on {'constant30' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x18}" == (IntPtr)(void*)(int)status;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2F14B80", Offset = "0x2F13580", VA = "0x182F14B80")]
	public static void PressButtonMobileOld(string name, Button.Status status)
	{
		//Discarded unreachable code: IL_00d7
		switch (status)
		{
		case Button.Status.up:
		{
			int num = 0;
			List<Button> currentButtons = CurrentButtons;
			List<Button> currentButtons2 = CurrentButtons;
			Button[] buttonsPool = ButtonsPool;
			List<Button> currentButtons3 = CurrentButtons;
			List<Button> currentButtons4 = CurrentButtons;
			num++;
			break;
		}
		case Button.Status.down:
			break;
		default:
			return;
		}
		Button[] buttonsPool2 = ButtonsPool;
		int currentButtonPoolIndex = CurrentButtonPoolIndex;
		buttonsPool2[currentButtonPoolIndex].name = name;
		Button[] buttonsPool3 = ButtonsPool;
		int currentButtonPoolIndex2 = CurrentButtonPoolIndex;
		Button button = buttonsPool3[currentButtonPoolIndex2];
		int currentButtonPoolIndex3 = (int)(button.status = Button.Status.down);
		Button[] buttonsPool4 = ButtonsPool;
		int currentButtonPoolIndex4 = CurrentButtonPoolIndex;
		Button button2 = buttonsPool4[currentButtonPoolIndex4];
		float num2 = (button2.Time = time);
		Button[] buttonsPool5 = ButtonsPool;
		List<Button> currentButtons5 = CurrentButtons;
		int currentButtonPoolIndex5 = CurrentButtonPoolIndex;
		Button item = buttonsPool5[currentButtonPoolIndex5];
		((List<T>)(object)currentButtons5).Add((T)item);
		int numberOfSimultaneousButtons = NumberOfSimultaneousButtons;
		CurrentButtonPoolIndex = currentButtonPoolIndex3;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2F12550", Offset = "0x2F10F50", VA = "0x182F12550")]
	public static void AxisUpdateMobileOld(string name, float value)
	{
		//Discarded unreachable code: IL_001f
		int num = 0;
		List<Axis> axes = Axes;
		float num2 = Time.time;
		Axis item = new Axis(name, value, num2);
		((List<T>)(object)axes).Add((T)item);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2F12640", Offset = "0x2F11040", VA = "0x182F12640")]
	public static void ClearUpsAndEvolveDownToPressedOld()
	{
		//Discarded unreachable code: IL_0061
		int num = 0;
		List<Button> currentButtons = CurrentButtons;
		List<Button> currentButtons2 = CurrentButtons;
		float num2 = time;
		List<Button> currentButtons3 = CurrentButtons;
		List<Button> currentButtons4 = CurrentButtons;
		List<Button> currentButtons5 = CurrentButtons;
		num++;
		((List<T>)(object)CurrentButtons).RemoveAt(num);
		num++;
		List<Axis> axes = Axes;
		List<Axis> axes2 = Axes;
		float num3 = time;
		((List<T>)(object)Axes).RemoveAt(num);
		num++;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2F149A0", Offset = "0x2F133A0", VA = "0x182F149A0")]
	public void OnDrawGizmosSelected()
	{
		int num = 0;
		if (!Application.isPlaying)
		{
			int num2 = 0;
			Autoconfigure();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2F13100", Offset = "0x2F11B00", VA = "0x182F13100")]
	public static bool GetButtonDownMobile(string name)
	{
		//Discarded unreachable code: IL_0018
		if (((List<T>)(object)ButtonsDown).Contains((T)name))
		{
			int num = 0;
			int frameCount = Time.frameCount;
			return true;
		}
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2F135A0", Offset = "0x2F11FA0", VA = "0x182F135A0")]
	public static bool GetButtonMobile(string name)
	{
		//Discarded unreachable code: IL_0018
		if (((List<T>)(object)ButtonsHold).Contains((T)name))
		{
			int num = 0;
			int frameCount = Time.frameCount;
			return true;
		}
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2F13710", Offset = "0x2F12110", VA = "0x182F13710")]
	public static bool GetButtonUpMobile(string name)
	{
		//Discarded unreachable code: IL_0018
		if (((List<T>)(object)ButtonsUp).Contains((T)name))
		{
			int num = 0;
			int frameCount = Time.frameCount;
			return true;
		}
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2F12A80", Offset = "0x2F11480", VA = "0x182F12A80")]
	public static float GetAxisMobileOld(string axis)
	{
		//Discarded unreachable code: IL_0025
		int num = 0;
		List<Axis> axes = Axes;
		List<Axis> axes2 = Axes;
		Button[] buttonsPool = ButtonsPool;
		num++;
		List<Axis> axes3 = Axes;
		return time;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2F14A00", Offset = "0x2F13400", VA = "0x182F14A00")]
	public static void PressButtonDownMobile(string buttonName)
	{
		//Discarded unreachable code: IL_0040
		int num = 0;
		int frameCount = Time.frameCount;
		((List<T>)(object)ButtonsDown).Clear();
		((List<T>)(object)ButtonsUp).Clear();
		((List<T>)(object)ButtonsHold).Clear();
		int num2 = 0;
		frameCount = (lastFrameUpdated = Time.frameCount);
		((List<T>)(object)ButtonsDown).Add((T)buttonName);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2F14F00", Offset = "0x2F13900", VA = "0x182F14F00")]
	public static void PressButtonMobile(string buttonName)
	{
		//Discarded unreachable code: IL_0040
		int num = 0;
		int frameCount = Time.frameCount;
		((List<T>)(object)ButtonsDown).Clear();
		((List<T>)(object)ButtonsUp).Clear();
		((List<T>)(object)ButtonsHold).Clear();
		int num2 = 0;
		frameCount = (lastFrameUpdated = Time.frameCount);
		((List<T>)(object)ButtonsHold).Add((T)buttonName);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2F15080", Offset = "0x2F13A80", VA = "0x182F15080")]
	public static void PressButtonUpMobile(string buttonName)
	{
		//Discarded unreachable code: IL_0040
		int num = 0;
		int frameCount = Time.frameCount;
		((List<T>)(object)ButtonsDown).Clear();
		((List<T>)(object)ButtonsUp).Clear();
		((List<T>)(object)ButtonsHold).Clear();
		int num2 = 0;
		frameCount = (lastFrameUpdated = Time.frameCount);
		((List<T>)(object)ButtonsUp).Add((T)buttonName);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2F12BF0", Offset = "0x2F115F0", VA = "0x182F12BF0")]
	public static float GetAxisMobile(string axisName)
	{
		//IL_0026: Expected F4, but got O
		IDictionary<string, float> mobileAxes = MobileAxes;
		IDictionary<string, float> mobileAxes2 = MobileAxes;
		int num = 0;
		uint num2 = default(uint);
		if (num < (int)num2)
		{
			num += num;
			if (num == (int)num2)
			{
				int num3 = 0;
				throw new NullReferenceException();
			}
			num++;
		}
		return (float)((IDictionary<TKey, TValue>)mobileAxes2)[(TKey)axisName];
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2F153A0", Offset = "0x2F13DA0", VA = "0x182F153A0")]
	public static void SetAxisMobile(string Name, float value)
	{
		//Discarded unreachable code: IL_0013
		IDictionary<string, float> mobileAxes = MobileAxes;
		RegisterAxisMobile(Name);
		IDictionary<string, float> mobileAxes2 = MobileAxes;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2F15200", Offset = "0x2F13C00", VA = "0x182F15200")]
	public static void RegisterAxisMobile(string Name)
	{
		//Discarded unreachable code: IL_0019
		//IL_000a: Expected I4, but got O
		InteractingWithTextField = (byte)(int)new Dictionary<TKey, TValue>() != 0;
		IDictionary<string, float> mobileAxes = MobileAxes;
		IDictionary<string, float> mobileAxes2 = MobileAxes;
		int num = 0;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2F15640", Offset = "0x2F14040", VA = "0x182F15640")]
	public Input()
	{
	}//IL_0009: Expected I4, but got I8


	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2F15500", Offset = "0x2F13F00", VA = "0x182F15500")]
	static Input()
	{
		//IL_000a: Expected I4, but got O
		//IL_0014: Expected I4, but got O
		//IL_001e: Expected I4, but got O
		/*Error: Unexpected end of block*/;
	}
}
