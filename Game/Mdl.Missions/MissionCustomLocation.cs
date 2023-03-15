using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mdl.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000249")]
	public class MissionCustomLocation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001380")]
		[SerializeField]
		[GUIDName("CustomLocationList")]
		[FormerlySerializedAs("_customLocationGUID")]
		private string _customLocation = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001381")]
		public bool PreferSubGrid;

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public string CustomLocationGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _customLocation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xBC8100", Offset = "0xBC6B00", VA = "0x180BC8100")]
		public static string SaveCustomLocations(Mdl.Environments.Environment environment, string defaultLayoutDataPath)
		{
			//Discarded unreachable code: IL_0148
			//IL_00cd: Expected I4, but got O
			//IL_00d6: Expected I4, but got O
			//IL_0138: Expected I4, but got I8
			//IL_0138: Expected I4, but got I8
			MissionCustomLocation[] componentsInChildren = environment.GetComponentsInChildren<MissionCustomLocation>();
			GridScript[] componentsInChildren2 = environment.GetComponentsInChildren<GridScript>();
			Func<GridScript, bool> _003C_003E9__4_ = _003C_003Ec._003C_003E9__4_0;
			if (_003C_003E9__4_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridScript x)
				{
					if ((object)x == null)
					{
						return 0 == 0;
					}
					int num6 = 0;
					return (object)x == null;
				};
			}
			GridScript[] array = Enumerable.Where<GridScript>((IEnumerable<>)(object)componentsInChildren2, (Func<, >)(object)_003C_003E9__4_).ToArray<GridScript>();
			CustomLocationPositions customLocationPositions = new CustomLocationPositions();
			int num = 0;
			int num2 = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				MissionCustomLocation missionCustomLocation = componentsInChildren[num2];
				Transform transform = missionCustomLocation.transform;
				GridScript gridScript = default(GridScript);
				if ((object)gridScript != null)
				{
					Transform transform2 = missionCustomLocation.transform;
					int num3 = 0;
				}
				GridPosition gridPosition = default(GridPosition);
				if ((object)gridPosition == null)
				{
					string text = missionCustomLocation.gameObject.name;
					Debug.LogWarning("CustomLocation " + text + " could not be placed on a grid.");
					num2++;
				}
				CustomLocationPositions.Types.CustomLocationPosition customLocationPosition = new CustomLocationPositions.Types.CustomLocationPosition();
				string text2 = (customLocationPosition.GUID = missionCustomLocation._customLocation);
				GridPosition gridPosition2 = default(GridPosition);
				customLocationPosition.positionX_ = (int)gridPosition2;
				GridPosition gridPosition3 = default(GridPosition);
				customLocationPosition.positionY_ = (int)gridPosition3;
				bool flag = (customLocationPosition.preferSubGrid_ = missionCustomLocation.PreferSubGrid);
				bool flag2 = default(bool);
				if (!flag2 && array.Length > 1)
				{
					string text3 = (customLocationPosition.GridDataPath = gridScript.GridDataPath);
				}
				((RepeatedField<T>)(object)customLocationPositions.positions_).Add((T)customLocationPosition);
				num2++;
			}
			IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			int formatEnumAsIntegers = 0;
			int formatDefaultValues = 0;
			ulong num4 = default(ulong);
			ulong num5 = default(ulong);
			string text4 = customLocationPositions.ToJSONString((byte)formatDefaultValues != 0, (byte)num4 != 0, (byte)formatEnumAsIntegers != 0, (int)num5);
			string text5 = default(string);
			_003CData_003Ek__BackingField.WriteAllText(text5, text4);
			return text5;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0xBC8710", Offset = "0xBC7110", VA = "0x180BC8710")]
		public MissionCustomLocation()
		{
		}
	}
}
