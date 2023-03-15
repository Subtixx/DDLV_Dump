using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Activities;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Grid;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009AE")]
	internal class GardenStall : GridObjectStateUser
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400356D")]
		[SerializeField]
		private List<GameObject> _levelLayoutPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400356E")]
		[SerializeField]
		private Transform _layoutParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400356F")]
		private int _currentLevel = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003570")]
		private GameObject _currentLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003571")]
		private GardenStallFakeSlot[] gardenStallFakeSlots;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003572")]
		private GardenStallFakeSlot[,] slotsByPositions;

		[Cpp2IlInjected.Token(Token = "0x1700067E")]
		public Vector2Int GardenSize
		{
			[Cpp2IlInjected.Token(Token = "0x6002D53")]
			[Cpp2IlInjected.Address(RVA = "0x8C4AA0", Offset = "0x8C34A0", VA = "0x1808C4AA0")]
			get
			{
				if (slotsByPositions == null)
				{
					CreateSlotsByPositions();
					GardenStallFakeSlot[,] array = slotsByPositions;
				}
				int num = 0;
				GardenStallFakeSlot[,] array2 = slotsByPositions;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D52")]
		[Cpp2IlInjected.Address(RVA = "0x8C4530", Offset = "0x8C2F30", VA = "0x1808C4530", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_0179
			//IL_0060: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			GridState state_ = gridObject.state_;
			if (state_ == null)
			{
				return;
			}
			GardenStallData gardenStallData = state_.GardenStallData;
			if (gardenStallData == null || (long)gardenStallData.upgradeState_ == 0)
			{
				return;
			}
			int level_ = gridObject.state_.GardenStallData.upgradeState_.level_;
			int num = 0;
			if (level_ != _currentLevel)
			{
				UnityEngine.Object.Destroy(_currentLayout);
				_currentLayout = (GameObject)num;
				slotsByPositions = (GardenStallFakeSlot[,])num;
				int val = ((List<>)(object)_levelLayoutPrefab)._size - 1;
				val = Math.Min(level_, val);
				int num2 = Math.Max(0, val);
				_currentLevel = level_;
				List<GameObject> levelLayoutPrefab = _levelLayoutPrefab;
				int num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				int num4 = 0;
				if ((UnityEngine.Object)num3 != (UnityEngine.Object)num4)
				{
					List<GameObject> levelLayoutPrefab2 = _levelLayoutPrefab;
					int num5 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					if ((object)_layoutParent == null)
					{
						Transform transform = base.transform;
					}
					GameObject currentLayout = default(GameObject);
					_currentLayout = currentLayout;
				}
				GameObject currentLayout2 = _currentLayout;
				int num6 = 0;
				if (!(currentLayout2 != (UnityEngine.Object)num6))
				{
					GardenStallFakeSlot[] array = new GardenStallFakeSlot[0];
				}
				GardenStallFakeSlot[] array2 = (gardenStallFakeSlots = _currentLayout.GetComponentsInChildren<GardenStallFakeSlot>());
			}
			int count = ((RepeatedField<T>)(object)gridObject.state_.GardenStallData.slots_).Count;
			int length = gardenStallFakeSlots.Length;
			int num7 = Math.Min(count, length);
			if (num < num7)
			{
				GardenStallFakeSlot gardenStallFakeSlot = gardenStallFakeSlots[num];
				GardenStallData.Types.GardenStallSlot gardenStallSlot = (GardenStallData.Types.GardenStallSlot)((RepeatedField<T>)(object)gridObject.state_.GardenStallData.slots_)[num];
				int num8 = 0;
				int num9 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D54")]
		[Cpp2IlInjected.Address(RVA = "0x8C44A0", Offset = "0x8C2EA0", VA = "0x1808C44A0")]
		public GardenStallFakeSlot GetSlotForPosition(int x, int y)
		{
			//Discarded unreachable code: IL_0028
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected I4, but got Unknown
			GardenStallFakeSlot[,] array = slotsByPositions;
			if (array == null)
			{
				CreateSlotsByPositions();
				GardenStallFakeSlot[,] array2 = slotsByPositions;
			}
			int num = x * this;
			num += y;
			return array[num];
		}

		[Cpp2IlInjected.Token(Token = "0x6002D55")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EA0", Offset = "0x8C28A0", VA = "0x1808C3EA0")]
		private void CreateSlotsByPositions()
		{
			//Discarded unreachable code: IL_00f5, IL_00fb, IL_0101, IL_0107
			//IL_00da: Invalid comparison between I4 and F4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			GardenStallFakeSlot[] array = gardenStallFakeSlots;
			Func<GardenStallFakeSlot, float> _003C_003E9__10_ = _003C_003Ec._003C_003E9__10_0;
			if (_003C_003E9__10_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GardenStallFakeSlot x)
				{
					Transform transform2 = x.transform;
					throw new NullReferenceException();
				};
			}
			int num4 = Enumerable.Count<IGrouping<float, GardenStallFakeSlot>>(Enumerable.GroupBy<GardenStallFakeSlot, float>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__10_));
			GardenStallFakeSlot[] array2 = gardenStallFakeSlots;
			num4 = array2.Length;
			bool flag = (byte)((flag ? 1u : 0u) + (uint)num4) != 0;
			Transform transform = array2[0].transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = Vector3.zero.z;
			uint num5 = default(uint);
			IEnumerable<GardenStallFakeSlot> enumerable = (IEnumerable<GardenStallFakeSlot>)Enumerable.Skip<GardenStallFakeSlot>((IEnumerable<>)(object)gardenStallFakeSlots, (int)num5);
			float z3 = default(float);
			if (enumerable != null)
			{
				uint num6 = default(uint);
				if (num3 < (int)num6)
				{
					num3 += num3;
					if (num3 == (int)num6)
					{
						goto IL_00a8;
					}
					num3++;
				}
				Vector3 vector2 = default(Vector3);
				z3 = vector2.z;
				goto IL_00a8;
			}
			goto IL_00b2;
			IL_00a8:
			z3 += 4.37E-43f;
			goto IL_00b2;
			IL_00b2:
			int num7 = 0;
			if (enumerable != null)
			{
			}
			if (num4 == 1)
			{
			}
			float z4 = default(float);
			if (!flag)
			{
				Vector3 vector3 = default(Vector3);
				z4 = vector3.z;
			}
			int num8 = 0;
			if (num7 < (flag ? 1 : 0))
			{
				if (!((float)num8 <= z4))
				{
				}
				Vector3 vector4 = default(Vector3);
				float z5 = vector4.z;
				Vector3 vector5 = default(Vector3);
				float z6 = vector5.z;
				num7++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D56")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A90", Offset = "0x8C3490", VA = "0x1808C4A90")]
		public GardenStall()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
