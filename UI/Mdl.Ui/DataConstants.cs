using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200020C")]
	public class DataConstants : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000905")]
		public const int DRAG_DISTANCE = 40;

		[Cpp2IlInjected.Token(Token = "0x4000906")]
		public static readonly string[] GAMEPAD_AXIS_NAMES;

		[Cpp2IlInjected.Token(Token = "0x6000D03")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DataConstants()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D04")]
		[Cpp2IlInjected.Address(RVA = "0x1127A00", Offset = "0x1126400", VA = "0x181127A00")]
		static DataConstants()
		{
			string[] array;
			while (true)
			{
				array = new string[6];
				if ("LT" != null && "LT" == null)
				{
					continue;
				}
				array[0] = "LT";
				if ("RT" != null && "RT" == null)
				{
					continue;
				}
				array[1] = "RT";
				if ("Left Stick X" != null && "Left Stick X" == null)
				{
					continue;
				}
				array[2] = "Left Stick X";
				if ("Left Stick Y" != null && "Left Stick Y" == null)
				{
					continue;
				}
				array[3] = "Left Stick Y";
				if ("Right Stick X" == null || "Right Stick X" != null)
				{
					array[4] = "Right Stick X";
					if ("UI Right Stick Y" == null || "UI Right Stick Y" != null)
					{
						break;
					}
				}
			}
			array[5] = "UI Right Stick Y";
			throw new NullReferenceException();
		}
	}
}
