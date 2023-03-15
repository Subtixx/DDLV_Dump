using System.Collections.Generic;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001ED")]
	public static class ShortcutViewHelper
	{
		[Cpp2IlInjected.Token(Token = "0x20001EE")]
		public class ShortcutActionSet
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000879")]
			[Tooltip("This is the index we use to get sprites.")]
			public int DefaultButtonId = -1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400087A")]
			[Tooltip("This is the index found on the specific platform and should be converted.")]
			public int PlatformButtonId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400087B")]
			[Tooltip("This determines which platform's image to use.")]
			public string Prefix;

			[Cpp2IlInjected.Token(Token = "0x6000C77")]
			[Cpp2IlInjected.Address(RVA = "0x10E77A0", Offset = "0x10E61A0", VA = "0x1810E77A0")]
			public ShortcutActionSet()
			{
			}//IL_0009: Expected I4, but got I8

		}

		[Cpp2IlInjected.Token(Token = "0x4000871")]
		private static List<ShortcutActionSet> winPs4Converter;

		[Cpp2IlInjected.Token(Token = "0x4000872")]
		private static List<ShortcutActionSet> winPs5Converter;

		[Cpp2IlInjected.Token(Token = "0x4000873")]
		private static List<ShortcutActionSet> winXboxConverter;

		[Cpp2IlInjected.Token(Token = "0x4000874")]
		private static List<ShortcutActionSet> winXbox360Converter;

		[Cpp2IlInjected.Token(Token = "0x4000875")]
		private static List<ShortcutActionSet> ps4Converter;

		[Cpp2IlInjected.Token(Token = "0x4000876")]
		private static List<ShortcutActionSet> ps5Converter;

		[Cpp2IlInjected.Token(Token = "0x4000877")]
		private static List<ShortcutActionSet> switchConverter;

		[Cpp2IlInjected.Token(Token = "0x4000878")]
		private static List<ShortcutActionSet> xboxConverter;

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x15F02C0", Offset = "0x15EECC0", VA = "0x1815F02C0")]
		private static List<ShortcutActionSet> GetPlatformConverter(RuntimePlatform platform)
		{
			//Discarded unreachable code: IL_001d, IL_004c, IL_0050, IL_0056, IL_005c
			//IL_0035: Expected I4, but got I8
			ulong num3 = default(ulong);
			while (true)
			{
				int num = (int)platform;
				int num2 = 0;
				if (num > 25)
				{
					if (num == 27)
					{
						return xboxConverter;
					}
					num += -32;
					if (num <= 6)
					{
						return switchConverter;
					}
				}
				else if (num - 1 <= 1)
				{
					if (InputDetectionHelper.GetController((byte)num3 != 0) == InputDetectionHelper.InputController.Xbox360)
					{
						int num4 = 0;
						if (Application.webSecurityEnabled && 0 <= 5)
						{
							return winXbox360Converter;
						}
					}
				}
				else if (num == 25)
				{
					break;
				}
			}
			return ps4Converter;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x15F0160", Offset = "0x15EEB60", VA = "0x1815F0160")]
		public static void GetConvertedIndex(RuntimePlatform platform, ref int btnIndex, ref string prefixStr)
		{
			//Discarded unreachable code: IL_001e
			int num = 0;
			List<ShortcutActionSet> list = default(List<ShortcutActionSet>);
			bool flag = default(bool);
			if (list != null && flag)
			{
				btnIndex.m_value = (flag ? 1 : 0);
				int num2 = 0;
				if (flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x15F0620", Offset = "0x15EF020", VA = "0x1815F0620")]
		static ShortcutViewHelper()
		{
			//IL_0015: Expected I4, but got I8
			//IL_001e: Expected I4, but got I8
			//IL_003f: Expected I4, but got I8
			//IL_0049: Expected I4, but got I8
			//IL_008f: Expected I4, but got I8
			//IL_0099: Expected I4, but got I8
			//IL_00be: Expected I4, but got I8
			//IL_00c8: Expected I4, but got I8
			//IL_00ed: Expected I4, but got I8
			//IL_00f7: Expected I4, but got I8
			//IL_011c: Expected I4, but got I8
			//IL_0126: Expected I4, but got I8
			//IL_014b: Expected I4, but got I8
			//IL_0155: Expected I4, but got I8
			//IL_017b: Expected I4, but got I8
			//IL_0186: Expected I4, but got I8
			//IL_01ac: Expected I4, but got I8
			//IL_01b7: Expected I4, but got I8
			//IL_01dd: Expected I4, but got I8
			//IL_01e8: Expected I4, but got I8
			//IL_020e: Expected I4, but got I8
			//IL_0219: Expected I4, but got I8
			//IL_023f: Expected I4, but got I8
			//IL_024a: Expected I4, but got I8
			//IL_0270: Expected I4, but got I8
			//IL_027b: Expected I4, but got I8
			//IL_02ad: Expected I4, but got I8
			//IL_02b7: Expected I4, but got I8
			//IL_02dd: Expected I4, but got I8
			//IL_02e8: Expected I4, but got I8
			//IL_0333: Expected I4, but got I8
			//IL_033d: Expected I4, but got I8
			//IL_0363: Expected I4, but got I8
			//IL_036d: Expected I4, but got I8
			//IL_0393: Expected I4, but got I8
			//IL_039d: Expected I4, but got I8
			//IL_03c3: Expected I4, but got I8
			//IL_03cd: Expected I4, but got I8
			//IL_03f3: Expected I4, but got I8
			//IL_03fd: Expected I4, but got I8
			//IL_0423: Expected I4, but got I8
			//IL_042d: Expected I4, but got I8
			//IL_0454: Expected I4, but got I8
			//IL_045f: Expected I4, but got I8
			//IL_0486: Expected I4, but got I8
			//IL_0491: Expected I4, but got I8
			//IL_04b8: Expected I4, but got I8
			//IL_04c3: Expected I4, but got I8
			//IL_04ea: Expected I4, but got I8
			//IL_04f5: Expected I4, but got I8
			//IL_051c: Expected I4, but got I8
			//IL_0527: Expected I4, but got I8
			//IL_054e: Expected I4, but got I8
			//IL_0559: Expected I4, but got I8
			//IL_058d: Expected I4, but got I8
			//IL_0597: Expected I4, but got I8
			//IL_05bd: Expected I4, but got I8
			//IL_05c7: Expected I4, but got I8
			//IL_05ee: Expected I4, but got I8
			//IL_05f8: Expected I4, but got I8
			//IL_061f: Expected I4, but got I8
			//IL_062a: Expected I4, but got I8
			//IL_0651: Expected I4, but got I8
			//IL_065c: Expected I4, but got I8
			//IL_0683: Expected I4, but got I8
			//IL_068e: Expected I4, but got I8
			//IL_06b5: Expected I4, but got I8
			//IL_06c0: Expected I4, but got I8
			//IL_06e7: Expected I4, but got I8
			//IL_06f2: Expected I4, but got I8
			//IL_0726: Expected I4, but got I8
			//IL_0730: Expected I4, but got I8
			//IL_0756: Expected I4, but got I8
			//IL_0760: Expected I4, but got I8
			//IL_0787: Expected I4, but got I8
			//IL_0791: Expected I4, but got I8
			//IL_07b8: Expected I4, but got I8
			//IL_07c3: Expected I4, but got I8
			//IL_07ea: Expected I4, but got I8
			//IL_07f5: Expected I4, but got I8
			//IL_081c: Expected I4, but got I8
			//IL_0827: Expected I4, but got I8
			//IL_084e: Expected I4, but got I8
			//IL_0859: Expected I4, but got I8
			//IL_0880: Expected I4, but got I8
			//IL_088b: Expected I4, but got I8
			//IL_08bf: Expected I4, but got I8
			//IL_08c9: Expected I4, but got I8
			//IL_08ef: Expected I4, but got I8
			//IL_08f9: Expected I4, but got I8
			//IL_0944: Expected I4, but got I8
			//IL_094e: Expected I4, but got I8
			//IL_0974: Expected I4, but got I8
			//IL_097e: Expected I4, but got I8
			//IL_09a4: Expected I4, but got I8
			//IL_09ae: Expected I4, but got I8
			//IL_09d4: Expected I4, but got I8
			//IL_09de: Expected I4, but got I8
			//IL_0a04: Expected I4, but got I8
			//IL_0a0e: Expected I4, but got I8
			//IL_0a35: Expected I4, but got I8
			//IL_0a3f: Expected I4, but got I8
			List<ShortcutActionSet> list = (List<ShortcutActionSet>)(object)new List<T>
			{
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 7,
					PlatformButtonId = 7,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 6,
					PlatformButtonId = 9,
					Prefix = "PlayStation4"
				}
			};
			ShortcutActionSet shortcutActionSet = new ShortcutActionSet();
			int defaultButtonId = (shortcutActionSet.DefaultButtonId = 0);
			shortcutActionSet.Prefix = "PlayStation4";
			((List<T>)(object)list).Add((T)shortcutActionSet);
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 1,
				PlatformButtonId = 1,
				Prefix = "PlayStation4"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 2,
				PlatformButtonId = 2,
				Prefix = "PlayStation4"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 3,
				PlatformButtonId = 3,
				Prefix = "PlayStation4"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 4,
				PlatformButtonId = 4,
				Prefix = "PlayStation4"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 5,
				PlatformButtonId = 5,
				Prefix = "PlayStation4"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 9,
				PlatformButtonId = 10,
				Prefix = "Xbox360"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 10,
				PlatformButtonId = 11,
				Prefix = "Xbox360"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 11,
				PlatformButtonId = 12,
				Prefix = "Xbox360"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 12,
				PlatformButtonId = 13,
				Prefix = "Xbox360"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 13,
				PlatformButtonId = 14,
				Prefix = "Xbox360"
			});
			((List<T>)(object)list).Add((T)new ShortcutActionSet
			{
				DefaultButtonId = 14,
				PlatformButtonId = 15,
				Prefix = "Xbox360"
			});
			winPs4Converter = list;
			winPs4Converter = (List<ShortcutActionSet>)(object)new List<T>
			{
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 7,
					PlatformButtonId = 7,
					Prefix = "PlayStation5"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 6,
					PlatformButtonId = 9,
					Prefix = "PlayStation5"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = defaultButtonId,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 1,
					PlatformButtonId = 1,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 2,
					PlatformButtonId = 2,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 3,
					PlatformButtonId = 3,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 4,
					PlatformButtonId = 4,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 5,
					PlatformButtonId = 5,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 7,
					PlatformButtonId = 7,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 9,
					PlatformButtonId = 11,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 10,
					PlatformButtonId = 12,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 11,
					PlatformButtonId = 13,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 12,
					PlatformButtonId = 14,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 13,
					PlatformButtonId = 15,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 14,
					PlatformButtonId = 16,
					Prefix = "Xbox360"
				}
			};
			winPs4Converter = (List<ShortcutActionSet>)(object)new List<T>
			{
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 7,
					PlatformButtonId = 7,
					Prefix = "XboxOne"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 6,
					PlatformButtonId = 6,
					Prefix = "XboxOne"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 9,
					PlatformButtonId = 8,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 10,
					PlatformButtonId = 9,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 11,
					PlatformButtonId = 10,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 12,
					PlatformButtonId = 11,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 13,
					PlatformButtonId = 12,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 14,
					PlatformButtonId = 13,
					Prefix = "Xbox360"
				}
			};
			winPs4Converter = (List<ShortcutActionSet>)(object)new List<T>
			{
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 7,
					PlatformButtonId = 7,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 6,
					PlatformButtonId = 6,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 9,
					PlatformButtonId = 8,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 10,
					PlatformButtonId = 9,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 11,
					PlatformButtonId = 10,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 12,
					PlatformButtonId = 11,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 13,
					PlatformButtonId = 12,
					Prefix = "Xbox360"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 14,
					PlatformButtonId = 13,
					Prefix = "Xbox360"
				}
			};
			List<ShortcutActionSet> list2 = (List<ShortcutActionSet>)(object)new List<T>
			{
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 7,
					PlatformButtonId = 6,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 6,
					PlatformButtonId = 7,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = defaultButtonId,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 1,
					PlatformButtonId = 1,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 2,
					PlatformButtonId = 2,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 3,
					PlatformButtonId = 3,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 4,
					PlatformButtonId = 4,
					Prefix = "PlayStation4"
				},
				(T)new ShortcutActionSet
				{
					DefaultButtonId = 5,
					PlatformButtonId = 5,
					Prefix = "PlayStation4"
				}
			};
			ShortcutActionSet shortcutActionSet2 = new ShortcutActionSet
			{
				DefaultButtonId = 9,
				PlatformButtonId = 8,
				Prefix = "Xbox360"
			};
			/*Error: Unexpected end of block*/;
		}
	}
}
