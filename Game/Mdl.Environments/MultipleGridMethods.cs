using System;
using Cpp2IlInjected;
using Definitions.Grid;
using Mdl.Grid;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x20006AB")]
	internal static class MultipleGridMethods
	{
		[Cpp2IlInjected.Token(Token = "0x6001D9A")]
		[Cpp2IlInjected.Address(RVA = "0xF003E0", Offset = "0xEFEDE0", VA = "0x180F003E0")]
		public unsafe static GridScript GetCurrentGrid(GridScript[] orderedByHeightGrids, Vector3 position, out bool voidGrid)
		{
			//IL_00a9: Expected O, but got I4
			//IL_00a9: Expected O, but got I4
			int num = 0;
			GridScript gridScript;
			if (orderedByHeightGrids != null)
			{
				int num2 = 0;
				int length = orderedByHeightGrids.Length;
				if (num2 < length)
				{
					gridScript = orderedByHeightGrids[num2];
					Transform gridOrigin = gridScript.GridOrigin;
					Transform gridOrigin2 = gridScript.GridOrigin;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					GridData gridData = gridScript.GridData;
					int num3 = 0;
					GridData gridData2 = gridScript.GridData;
					int num4 = 0;
					float z2 = position.z;
					bool flag = default(bool);
					if (flag)
					{
						Transform gridOrigin3 = gridScript.GridOrigin;
						float y = position.y;
						Transform gridOrigin4 = gridScript.GridOrigin;
						Vector3 vector2 = default(Vector3);
						float y2 = vector2.y;
						int allowInvalid = 0;
						GridPosition gridPosition = gridScript.GetGridPosition(in *(Vector3*)position, 1, (byte)allowInvalid != 0);
						GridData gridData3 = gridScript.GridData;
						GridFloorType gridFloorType = default(GridFloorType);
						int num5 = (int)gridFloorType;
						bool flag2 = default(bool);
						if (!flag2)
						{
							goto IL_00b8;
						}
						int num6 = 0;
						if ((UnityEngine.Object)num2 == (UnityEngine.Object)num6)
						{
							Transform gridOrigin5 = gridScript.GridOrigin;
						}
					}
					num2++;
					goto IL_00b8;
				}
			}
			int num7 = 0;
			throw new NullReferenceException();
			IL_00b8:
			return gridScript;
		}
	}
}
