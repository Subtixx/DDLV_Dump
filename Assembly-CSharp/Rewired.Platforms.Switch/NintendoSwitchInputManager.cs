using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.Switch
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RequireComponent(typeof(InputManager))]
	[AddComponentMenu("Rewired/Nintendo Switch Input Manager")]
	public sealed class NintendoSwitchInputManager : MonoBehaviour, IExternalInputManager
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class UserData : IKeyedData<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			[SerializeField]
			private int _allowedNpadStyles = -1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			[SerializeField]
			private int _joyConGripStyle = 1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			[SerializeField]
			private bool _adjustIMUsForGripStyle = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			[SerializeField]
			private int _handheldActivationMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			[SerializeField]
			private bool _assignJoysticksByNpadId = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			[SerializeField]
			private bool _useVibrationThread;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			[SerializeField]
			private NpadSettings_Internal _npadNo1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			[SerializeField]
			private NpadSettings_Internal _npadNo2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			[SerializeField]
			private NpadSettings_Internal _npadNo3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			[SerializeField]
			private NpadSettings_Internal _npadNo4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			[SerializeField]
			private NpadSettings_Internal _npadNo5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			[SerializeField]
			private NpadSettings_Internal _npadNo6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			[SerializeField]
			private NpadSettings_Internal _npadNo7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			[SerializeField]
			private NpadSettings_Internal _npadNo8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			[SerializeField]
			private NpadSettings_Internal _npadHandheld;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			[SerializeField]
			private DebugPadSettings_Internal _debugPad;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			private Dictionary<int, object[]> __delegates;

			[Cpp2IlInjected.Token(Token = "0x17000202")]
			public int allowedNpadStyles
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get
				{
					return _allowedNpadStyles;
				}
				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set
				{
					_allowedNpadStyles = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000203")]
			public int joyConGripStyle
			{
				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get
				{
					return _joyConGripStyle;
				}
				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set
				{
					_joyConGripStyle = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000204")]
			public bool adjustIMUsForGripStyle
			{
				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
				get
				{
					return _adjustIMUsForGripStyle;
				}
				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
				set
				{
					_adjustIMUsForGripStyle = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000205")]
			public int handheldActivationMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
				get
				{
					return _handheldActivationMode;
				}
				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
				set
				{
					_handheldActivationMode = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000206")]
			public bool assignJoysticksByNpadId
			{
				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
				get
				{
					return _assignJoysticksByNpadId;
				}
				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
				set
				{
					_assignJoysticksByNpadId = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000207")]
			public bool useVibrationThread
			{
				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0xBA1880", Offset = "0xBA0280", VA = "0x180BA1880")]
				get
				{
					return _useVibrationThread;
				}
				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0xBA18C0", Offset = "0xBA02C0", VA = "0x180BA18C0")]
				set
				{
					_useVibrationThread = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000208")]
			private NpadSettings_Internal npadNo1
			{
				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				get
				{
					return _npadNo1;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000209")]
			private NpadSettings_Internal npadNo2
			{
				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				get
				{
					return _npadNo2;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700020A")]
			private NpadSettings_Internal npadNo3
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				get
				{
					return _npadNo3;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700020B")]
			private NpadSettings_Internal npadNo4
			{
				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
				get
				{
					return _npadNo4;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700020C")]
			private NpadSettings_Internal npadNo5
			{
				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
				get
				{
					return _npadNo5;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700020D")]
			private NpadSettings_Internal npadNo6
			{
				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
				get
				{
					return _npadNo6;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700020E")]
			private NpadSettings_Internal npadNo7
			{
				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
				get
				{
					return _npadNo7;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700020F")]
			private NpadSettings_Internal npadNo8
			{
				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
				get
				{
					return _npadNo8;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000210")]
			private NpadSettings_Internal npadHandheld
			{
				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
				get
				{
					return _npadHandheld;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000211")]
			public DebugPadSettings_Internal debugPad
			{
				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
				get
				{
					return _debugPad;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000212")]
			private Dictionary<int, object[]> delegates
			{
				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x1EAA960", Offset = "0x1EA9360", VA = "0x181EAA960")]
				get
				{
					//Discarded unreachable code: IL_005f, IL_007a, IL_0082, IL_009f, IL_00a7, IL_00b7, IL_00d2, IL_00da, IL_00f7, IL_00ff, IL_010f, IL_012a, IL_0132, IL_014f, IL_0157, IL_0167, IL_0182, IL_018a, IL_01a7, IL_01af, IL_01bf, IL_01da, IL_01e2, IL_01f2, IL_020d, IL_0215, IL_0225, IL_0240, IL_0248, IL_0258, IL_0273, IL_027b, IL_028b, IL_02a6, IL_02ae, IL_02be, IL_02d9, IL_02e1, IL_02f1, IL_030c, IL_0314, IL_0324, IL_033f, IL_0347, IL_0357, IL_0372, IL_037a, IL_038a, IL_03a5, IL_03ad, IL_03bd, IL_03d8, IL_03e0, IL_03fd, IL_0405, IL_0415, IL_041e
					Dictionary<int, object[]> _delegates;
					while (true)
					{
						_delegates = __delegates;
						if (_delegates != null)
						{
							break;
						}
						Dictionary<int, object[]> dictionary = (Dictionary<int, object[]>)(object)new Dictionary<TKey, TValue>();
						object[] array = new object[2];
						Func<int> func = (Func<int>)(object)(Func<TResult>)(() => _allowedNpadStyles);
						if (func == null || func != null)
						{
							array[0] = func;
							Action<int> action = (Action<int>)(object)(Action<T>)delegate(int x)
							{
								_allowedNpadStyles = x;
							};
							if (action == null || action != null)
							{
								array[1] = action;
								throw new NullReferenceException();
							}
						}
					}
					return _delegates;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x20BE660", Offset = "0x20BD060", VA = "0x1820BE660", Slot = "4")]
			bool IKeyedData<int>.TryGetValue<T>(int key, out T value)
			{
				Dictionary<int, object[]> dictionary = (Dictionary<int, object[]>)(object)this.get_delegates();
				bool flag = default(bool);
				ulong num = default(ulong);
				if (flag && num != 0)
				{
					return true;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x20BE770", Offset = "0x20BD170", VA = "0x1820BE770", Slot = "5")]
			bool IKeyedData<int>.TrySetValue<T>(int key, T value)
			{
				Dictionary<int, object[]> dictionary = (Dictionary<int, object[]>)(object)this.get_delegates();
				bool flag = default(bool);
				ulong num = default(ulong);
				if (flag && num != 0)
				{
					return true;
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x1EAA6C0", Offset = "0x1EA90C0", VA = "0x181EAA6C0")]
			public UserData()
			{
				//IL_0010: Expected I4, but got I8
				//IL_0019: Expected I4, but got I8
				//IL_003e: Expected I4, but got I8
				//IL_0047: Expected I4, but got I8
				//IL_0065: Expected I4, but got I8
				//IL_006e: Expected I4, but got I8
				//IL_008c: Expected I4, but got I8
				//IL_0095: Expected I4, but got I8
				//IL_00b3: Expected I4, but got I8
				//IL_00bc: Expected I4, but got I8
				//IL_00dc: Expected I4, but got I8
				//IL_00e6: Expected I4, but got I8
				//IL_0107: Expected I4, but got I8
				//IL_0111: Expected I4, but got I8
				//IL_0132: Expected I4, but got I8
				//IL_013c: Expected I4, but got I8
				//IL_015d: Expected I4, but got I8
				//IL_0167: Expected I4, but got I8
				//IL_0188: Expected I4, but got I8
				//IL_0192: Expected I4, but got I8
				//IL_01a4: Expected I4, but got I8
				NpadSettings_Internal npadSettings_Internal = default(NpadSettings_Internal);
				npadSettings_Internal._isAllowed = true;
				npadSettings_Internal._joyConAssignmentMode = -1;
				npadSettings_Internal._rewiredPlayerId = 0;
				_npadNo1 = npadSettings_Internal;
				NpadSettings_Internal npadSettings_Internal2 = default(NpadSettings_Internal);
				npadSettings_Internal2._isAllowed = true;
				npadSettings_Internal2._joyConAssignmentMode = -1;
				npadSettings_Internal2._rewiredPlayerId = 1;
				_npadNo2 = npadSettings_Internal2;
				NpadSettings_Internal npadSettings_Internal3 = default(NpadSettings_Internal);
				npadSettings_Internal3._isAllowed = true;
				npadSettings_Internal3._joyConAssignmentMode = -1;
				npadSettings_Internal3._rewiredPlayerId = 2;
				_npadNo3 = npadSettings_Internal3;
				NpadSettings_Internal npadSettings_Internal4 = default(NpadSettings_Internal);
				npadSettings_Internal4._isAllowed = true;
				npadSettings_Internal4._joyConAssignmentMode = -1;
				npadSettings_Internal4._rewiredPlayerId = 3;
				_npadNo4 = npadSettings_Internal4;
				NpadSettings_Internal npadSettings_Internal5 = default(NpadSettings_Internal);
				npadSettings_Internal5._isAllowed = true;
				npadSettings_Internal5._joyConAssignmentMode = -1;
				npadSettings_Internal5._rewiredPlayerId = 4;
				_npadNo5 = npadSettings_Internal5;
				NpadSettings_Internal npadSettings_Internal6 = default(NpadSettings_Internal);
				npadSettings_Internal6._isAllowed = true;
				npadSettings_Internal6._joyConAssignmentMode = -1;
				npadSettings_Internal6._rewiredPlayerId = 5;
				_npadNo6 = npadSettings_Internal6;
				NpadSettings_Internal npadSettings_Internal7 = default(NpadSettings_Internal);
				npadSettings_Internal7._isAllowed = true;
				npadSettings_Internal7._joyConAssignmentMode = -1;
				npadSettings_Internal7._rewiredPlayerId = 6;
				_npadNo7 = npadSettings_Internal7;
				NpadSettings_Internal npadSettings_Internal8 = default(NpadSettings_Internal);
				npadSettings_Internal8._isAllowed = true;
				npadSettings_Internal8._joyConAssignmentMode = -1;
				npadSettings_Internal8._rewiredPlayerId = 7;
				_npadNo8 = npadSettings_Internal8;
				NpadSettings_Internal npadSettings_Internal9 = default(NpadSettings_Internal);
				npadSettings_Internal9._isAllowed = true;
				npadSettings_Internal9._joyConAssignmentMode = -1;
				npadSettings_Internal9._rewiredPlayerId = 0;
				_npadHandheld = npadSettings_Internal9;
				DebugPadSettings_Internal debugPadSettings_Internal = default(DebugPadSettings_Internal);
				debugPadSettings_Internal._rewiredPlayerId = 0;
				_debugPad = debugPadSettings_Internal;
				base._002Ector();
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private sealed class NpadSettings_Internal : IKeyedData<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			[SerializeField]
			[Tooltip("Determines whether this Npad id is allowed to be used by the system.")]
			private bool _isAllowed = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			[SerializeField]
			[Tooltip("The Rewired Player Id assigned to this Npad id.")]
			private int _rewiredPlayerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			[SerializeField]
			[Tooltip("Determines how Joy-Cons should be handled.\n\nUnmodified: Joy-Con assignment mode will be left at the system default.\nDual: Joy-Cons pairs are handled as a single controller.\nSingle: Joy-Cons are handled as individual controllers.")]
			private int _joyConAssignmentMode = -1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private Dictionary<int, object[]> __delegates;

			[Cpp2IlInjected.Token(Token = "0x17000213")]
			private bool isAllowed
			{
				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get
				{
					return _isAllowed;
				}
				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				set
				{
					_isAllowed = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000214")]
			private int rewiredPlayerId
			{
				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get
				{
					return _rewiredPlayerId;
				}
				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set
				{
					_rewiredPlayerId = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000215")]
			private int joyConAssignmentMode
			{
				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get
				{
					return _joyConAssignmentMode;
				}
				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set
				{
					_joyConAssignmentMode = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000216")]
			private Dictionary<int, object[]> delegates
			{
				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x1E95CE0", Offset = "0x1E946E0", VA = "0x181E95CE0")]
				get
				{
					//Discarded unreachable code: IL_005f, IL_007a, IL_0082, IL_009f, IL_00a7, IL_00b7, IL_00d2, IL_00da, IL_00f7, IL_00ff, IL_010f, IL_0118
					Dictionary<int, object[]> _delegates;
					while (true)
					{
						_delegates = __delegates;
						if (_delegates != null)
						{
							break;
						}
						Dictionary<int, object[]> dictionary = (Dictionary<int, object[]>)(object)new Dictionary<TKey, TValue>();
						object[] array = new object[2];
						Func<bool> func = (Func<bool>)(object)(Func<TResult>)(() => _isAllowed);
						if (func == null || func != null)
						{
							array[0] = func;
							Action<bool> action = (Action<bool>)(object)(Action<T>)delegate(bool x)
							{
								_isAllowed = x;
							};
							if (action == null || action != null)
							{
								array[1] = action;
								throw new NullReferenceException();
							}
						}
					}
					return _delegates;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x1E95CB0", Offset = "0x1E946B0", VA = "0x181E95CB0")]
			internal NpadSettings_Internal(int playerId)
			{
				//IL_0017: Expected I4, but got I8
				_rewiredPlayerId = playerId;
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x20BD3B0", Offset = "0x20BBDB0", VA = "0x1820BD3B0", Slot = "4")]
			bool IKeyedData<int>.TryGetValue<T>(int key, out T value)
			{
				Dictionary<int, object[]> dictionary = (Dictionary<int, object[]>)(object)this.get_delegates();
				bool flag = default(bool);
				ulong num = default(ulong);
				if (flag && num != 0)
				{
					return true;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x20BD4C0", Offset = "0x20BBEC0", VA = "0x1820BD4C0", Slot = "5")]
			bool IKeyedData<int>.TrySetValue<T>(int key, T value)
			{
				Dictionary<int, object[]> dictionary = (Dictionary<int, object[]>)(object)this.get_delegates();
				bool flag = default(bool);
				ulong num = default(ulong);
				if (flag && num != 0)
				{
					return true;
				}
				throw new NullReferenceException();
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private sealed class DebugPadSettings_Internal : IKeyedData<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			[SerializeField]
			[Tooltip("Determines whether the Debug Pad will be enabled.")]
			private bool _enabled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			[SerializeField]
			[Tooltip("The Rewired Player Id to which the Debug Pad will be assigned.")]
			private int _rewiredPlayerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			private Dictionary<int, object[]> __delegates;

			[Cpp2IlInjected.Token(Token = "0x17000217")]
			private int rewiredPlayerId
			{
				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get
				{
					return _rewiredPlayerId;
				}
				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set
				{
					_rewiredPlayerId = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000218")]
			private bool enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get
				{
					return _enabled;
				}
				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				set
				{
					_enabled = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000219")]
			private Dictionary<int, object[]> delegates
			{
				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x1E912B0", Offset = "0x1E8FCB0", VA = "0x181E912B0")]
				get
				{
					//Discarded unreachable code: IL_005f, IL_007a, IL_0082, IL_009f, IL_00a7, IL_00b7, IL_00c0
					Dictionary<int, object[]> _delegates;
					while (true)
					{
						_delegates = __delegates;
						if (_delegates != null)
						{
							break;
						}
						Dictionary<int, object[]> dictionary = (Dictionary<int, object[]>)(object)new Dictionary<TKey, TValue>();
						object[] array = new object[2];
						Func<bool> func = (Func<bool>)(object)(Func<TResult>)(() => _enabled);
						if (func == null || func != null)
						{
							array[0] = func;
							Action<bool> action = (Action<bool>)(object)(Action<T>)delegate(bool x)
							{
								_enabled = x;
							};
							if (action == null || action != null)
							{
								array[1] = action;
								throw new NullReferenceException();
							}
						}
					}
					return _delegates;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x1E91280", Offset = "0x1E8FC80", VA = "0x181E91280")]
			internal DebugPadSettings_Internal(int playerId)
			{
				_rewiredPlayerId = playerId;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x20B8570", Offset = "0x20B6F70", VA = "0x1820B8570", Slot = "4")]
			bool IKeyedData<int>.TryGetValue<T>(int key, out T value)
			{
				Dictionary<int, object[]> dictionary = (Dictionary<int, object[]>)(object)this.get_delegates();
				bool flag = default(bool);
				ulong num = default(ulong);
				if (flag && num != 0)
				{
					return true;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x20B8680", Offset = "0x20B7080", VA = "0x1820B8680", Slot = "5")]
			bool IKeyedData<int>.TrySetValue<T>(int key, T value)
			{
				Dictionary<int, object[]> dictionary = (Dictionary<int, object[]>)(object)this.get_delegates();
				bool flag = default(bool);
				ulong num = default(ulong);
				if (flag && num != 0)
				{
					return true;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		private UserData _userData = new UserData();

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "4")]
		object IExternalInputManager.Initialize(Platform platform, object configVars)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		void IExternalInputManager.Deinitialize()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1E95C40", Offset = "0x1E94640", VA = "0x181E95C40")]
		public NintendoSwitchInputManager()
		{
		}
	}
}
