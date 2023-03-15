using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Cpp2IlInjected;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000710")]
	public readonly struct GridArea : IEquatable<GridArea>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40023B5")]
		private readonly IReadOnlyList<int> area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40023B6")]
		public readonly int SizeX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40023B7")]
		public readonly int SizeY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023B8")]
		public readonly GridFloorType FloorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40023B9")]
		public readonly int Stride;

		[Cpp2IlInjected.Token(Token = "0x1700141F")]
		public GridLayers this[int x, int y]
		{
			[Cpp2IlInjected.Token(Token = "0x6004EC9")]
			[Cpp2IlInjected.Address(RVA = "0x2F8A990", Offset = "0x2F89390", VA = "0x182F8A990")]
			get
			{
				int num = SizeY * x;
				num += y;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001420")]
		public GridLayers this[GridPosition position]
		{
			[Cpp2IlInjected.Token(Token = "0x6004ECA")]
			[Cpp2IlInjected.Address(RVA = "0x2F8A920", Offset = "0x2F89320", VA = "0x182F8A920")]
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected I4, but got Unknown
				int x = position.X;
				x = (int)(x + position);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001421")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6004ECB")]
			[Cpp2IlInjected.Address(RVA = "0x2F8A900", Offset = "0x2F89300", VA = "0x182F8A900")]
			get
			{
				int num = 0;
				return SizeY > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECC")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A8D0", Offset = "0x2F892D0", VA = "0x182F8A8D0")]
		internal GridArea(int sizeX, int sizeY, IReadOnlyList<int> area, GridFloorType floorType, int stride)
		{
			SizeX = sizeX;
			SizeY = sizeY;
			this.area = area;
			FloorType = GridFloorType.Void;
			Stride = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECD")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A790", Offset = "0x2F89190", VA = "0x182F8A790")]
		public int GetHorizontalSizeForOrientation(GridOrientation gridOrientation)
		{
			if (gridOrientation != 0 && (gridOrientation == GridOrientation.Up || (gridOrientation != 0 && gridOrientation == GridOrientation.Right)))
			{
				return SizeY;
			}
			return SizeX;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECE")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A830", Offset = "0x2F89230", VA = "0x182F8A830")]
		public int GetVerticalSizeForOrientation(GridOrientation gridOrientation)
		{
			if (gridOrientation != 0 && (gridOrientation == GridOrientation.Up || (gridOrientation != 0 && gridOrientation == GridOrientation.Right)))
			{
				return SizeX;
			}
			return SizeY;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECF")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A7B0", Offset = "0x2F891B0", VA = "0x182F8A7B0")]
		public (int, int) GetSizeForOrientation(GridOrientation gridOrientation)
		{
			if (gridOrientation != 0 && gridOrientation != 0)
			{
				switch (gridOrientation)
				{
				}
			}
			int sizeY = SizeY;
			int sizeX = SizeX;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED0")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A590", Offset = "0x2F88F90", VA = "0x182F8A590")]
		public GridPosition GetGridLocalPosition(in GridPosition gridPosition, GridOrientation gridOrientation)
		{
			if (gridOrientation != 0)
			{
				if (gridOrientation != 0 && gridOrientation != 0 && gridOrientation == GridOrientation.Right)
				{
					int sizeX = SizeX;
				}
				int sizeY = SizeY;
			}
			int sizeY2 = SizeY;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED1")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A0F0", Offset = "0x2F88AF0", VA = "0x182F8A0F0")]
		public bool Contains(GridOrientation thisGridOrientation, GridArea otherGridArea, GridOrientation otherGridOrientation)
		{
			if (thisGridOrientation == GridOrientation.Up || thisGridOrientation == GridOrientation.Up || thisGridOrientation == GridOrientation.Up || thisGridOrientation == GridOrientation.Right)
			{
			}
			int sizeX = SizeX;
			if (otherGridOrientation == GridOrientation.Up || otherGridOrientation == GridOrientation.Up || otherGridOrientation == GridOrientation.Up || otherGridOrientation == GridOrientation.Right)
			{
			}
			int sizeX2 = otherGridArea.SizeX;
			if (sizeX < sizeX2)
			{
				int num = 0;
			}
			if (thisGridOrientation != 0 && thisGridOrientation != 0)
			{
				switch (thisGridOrientation)
				{
				}
			}
			int sizeY = SizeY;
			if (otherGridOrientation != 0 && (otherGridOrientation == GridOrientation.Up || (otherGridOrientation != 0 && otherGridOrientation == GridOrientation.Right)))
			{
				int sizeX3 = otherGridArea.SizeX;
				return sizeY >= sizeX3;
			}
			int sizeY2 = otherGridArea.SizeY;
			return sizeY >= sizeY2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED2")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A190", Offset = "0x2F88B90", VA = "0x182F8A190")]
		public bool Contains(GridPosition thisGridPosition, GridOrientation thisGridOrientation, GridPosition gridPositionToContain)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected I4, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected I4, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected I4, but got Unknown
			if (thisGridOrientation == GridOrientation.Up || thisGridOrientation == GridOrientation.Up || thisGridOrientation == GridOrientation.Up || thisGridOrientation == GridOrientation.Right)
			{
			}
			int sizeX = SizeX;
			sizeX = (int)(sizeX + thisGridPosition);
			if ((long)(IntPtr)gridPositionToContain < (long)sizeX)
			{
				if (thisGridOrientation != 0 && (thisGridOrientation == GridOrientation.Up || (thisGridOrientation != 0 && thisGridOrientation == GridOrientation.Right)))
				{
					int sizeX2 = SizeX;
					sizeX2 = (int)(sizeX2 + thisGridPosition);
					return (long)(IntPtr)gridPositionToContain < (long)sizeX2;
				}
				int sizeY = SizeY;
				sizeY = (int)(sizeY + thisGridPosition);
				return (long)(IntPtr)gridPositionToContain < (long)sizeY;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED3")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A850", Offset = "0x2F89250", VA = "0x182F8A850")]
		public bool ValidateAreaSize(AreaSize minAreaSize, AreaSize maxAreaSize, bool acceptTransposedSize = false)
		{
			if (minAreaSize != null)
			{
				int sizeX = SizeX;
				int x_ = minAreaSize.x_;
				int y_ = minAreaSize.y_;
				if (SizeY < y_ && !acceptTransposedSize)
				{
					goto IL_005d;
				}
			}
			if (maxAreaSize != null)
			{
				int sizeX2 = SizeX;
				int x_2 = maxAreaSize.x_;
				int y_2 = maxAreaSize.y_;
				if (SizeY > y_2)
				{
					if (acceptTransposedSize)
					{
						return SizeY <= x_2;
					}
					goto IL_005d;
				}
			}
			goto IL_0060;
			IL_0060:
			return true;
			IL_005d:
			int num = 0;
			goto IL_0060;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED4")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A4F0", Offset = "0x2F88EF0", VA = "0x182F8A4F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			bool result = default(bool);
			if (obj != null && obj != null)
			{
				return result;
			}
			int num = 0;
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED5")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A4D0", Offset = "0x2F88ED0", VA = "0x182F8A4D0", Slot = "4")]
		public unsafe bool Equals(GridArea other)
		{
			return this == *(GridArea*)other;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED6")]
		[Cpp2IlInjected.Address(RVA = "0x2F8AA00", Offset = "0x2F89400", VA = "0x182F8AA00")]
		public static bool operator ==(in GridArea lhs, in GridArea rhs)
		{
			int num = 0;
			bool flag = default(bool);
			if ((flag ? 1 : 0) == num)
			{
				int sizeX = rhs.SizeX;
				if (lhs.SizeX == sizeX)
				{
					int sizeY = rhs.SizeY;
					if (lhs.SizeY == sizeY && num < sizeY && sizeY == 0)
					{
						num++;
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED7")]
		[Cpp2IlInjected.Address(RVA = "0x2F8AB10", Offset = "0x2F89510", VA = "0x182F8AB10")]
		public static bool operator !=(in GridArea lhs, in GridArea rhs)
		{
			return !(lhs == rhs);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED8")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A5F0", Offset = "0x2F88FF0", VA = "0x182F8A5F0", Slot = "2")]
		public override int GetHashCode()
		{
			//IL_0028: Expected O, but got I4
			//IL_0035: Expected I8, but got I4
			int num = 0;
			num += num;
			num++;
			int num2 = 0;
			if ((long)num < (long)(IntPtr)typeof(IReadOnlyList<int>).TypeHandle)
			{
				if (num < num2)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				System.Net.Http.Headers.Token.Type type = (System.Net.Http.Headers.Token)num;
				num++;
				long num4 = 391L;
				num4 += (long)type;
				num3 += num3;
				num3 += num3;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED9")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A200", Offset = "0x2F88C00", VA = "0x182F8A200")]
		public unsafe static GridArea Create(int sizeX, int sizeY, IReadOnlyList<int> area, GridFloorType floorType, int stride = 1)
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected I4, but got Unknown
			while (floorType != 0)
			{
				if (sizeY == 0 || area == null)
				{
					continue;
				}
				int num = 0;
				if (sizeY > 0)
				{
					int num2 = 0;
					int num3 = 0;
					if ((long)(IntPtr)area > 0L)
					{
						GridLayers clearAndBlocking = GridLayersExtensions.ClearAndBlocking;
						num3++;
					}
					num++;
					num2 += area;
				}
				((int*)sizeX)->m_value = (int)floorType;
				break;
			}
			ArgumentNullException ex = new ArgumentNullException("area");
			/*Error: Unexpected end of block*/;
		}
	}
}
