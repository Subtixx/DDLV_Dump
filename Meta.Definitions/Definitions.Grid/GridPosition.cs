using System;
using Cpp2IlInjected;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200070F")]
	public readonly struct GridPosition : IEquatable<GridPosition>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40023B1")]
		public readonly int X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40023B2")]
		public readonly int Y;

		[Cpp2IlInjected.Token(Token = "0x40023B3")]
		public static readonly GridPosition Up = (GridPosition)0;

		[Cpp2IlInjected.Token(Token = "0x40023B4")]
		public static readonly GridPosition Right;

		[Cpp2IlInjected.Token(Token = "0x1700141C")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6004EB4")]
			[Cpp2IlInjected.Address(RVA = "0x2F93590", Offset = "0x2F91F90", VA = "0x182F93590")]
			get
			{
				int num = 0;
				int y = Y;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700141D")]
		public float Magnitude
		{
			[Cpp2IlInjected.Token(Token = "0x6004EB7")]
			[Cpp2IlInjected.Address(RVA = "0x2F935B0", Offset = "0x2F91FB0", VA = "0x182F935B0")]
			get
			{
				int y = Y;
				int num = y * y;
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700141E")]
		public int SqrMagnitude
		{
			[Cpp2IlInjected.Token(Token = "0x6004EB8")]
			[Cpp2IlInjected.Address(RVA = "0x2F93640", Offset = "0x2F92040", VA = "0x182F93640")]
			get
			{
				int y = Y;
				int num = y * y;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB5")]
		[Cpp2IlInjected.Address(RVA = "0xF87D00", Offset = "0xF86700", VA = "0x180F87D00")]
		public GridPosition(int x, int y)
		{
			X = x;
			Y = y;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB6")]
		[Cpp2IlInjected.Address(RVA = "0x2F93180", Offset = "0x2F91B80", VA = "0x182F93180")]
		public void Deconstruct(out int x, out int y)
		{
			int num = (y.m_value = Y);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB9")]
		[Cpp2IlInjected.Address(RVA = "0x2F933D0", Offset = "0x2F91DD0", VA = "0x182F933D0")]
		public GridPosition InvertWithOrientation(GridOrientation gridOrientation)
		{
			while (true)
			{
				if (gridOrientation != 0 && gridOrientation != 0 && gridOrientation != 0 && gridOrientation == GridOrientation.Right)
				{
					/*Error: Could not find block for branch target IL_0010*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EBA")]
		[Cpp2IlInjected.Address(RVA = "0x2F93270", Offset = "0x2F91C70", VA = "0x182F93270", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6004EBB")]
		[Cpp2IlInjected.Address(RVA = "0x2F93300", Offset = "0x2F91D00", VA = "0x182F93300", Slot = "4")]
		public bool Equals(GridPosition other)
		{
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EBC")]
		[Cpp2IlInjected.Address(RVA = "0x2F93190", Offset = "0x2F91B90", VA = "0x182F93190")]
		public static float Distance(GridPosition a, GridPosition b)
		{
			GridPosition gridPosition = (GridPosition)((object)a * (object)a);
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EBD")]
		[Cpp2IlInjected.Address(RVA = "0x2F93400", Offset = "0x2F91E00", VA = "0x182F93400")]
		public static int SqrDistance(GridPosition a, GridPosition b)
		{
			GridPosition gridPosition = (GridPosition)((object)a * (object)a);
			GridPosition gridPosition2 = (GridPosition)((object)a * (object)a);
			gridPosition2 += gridPosition;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EBE")]
		[Cpp2IlInjected.Address(RVA = "0x2F93690", Offset = "0x2F92090", VA = "0x182F93690")]
		public static bool operator ==(in GridPosition lhs, in GridPosition rhs)
		{
			int num = 0;
			int y = rhs.Y;
			return lhs.Y == y;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EBF")]
		[Cpp2IlInjected.Address(RVA = "0x2F936B0", Offset = "0x2F920B0", VA = "0x182F936B0")]
		public static bool operator !=(in GridPosition lhs, in GridPosition rhs)
		{
			//Discarded unreachable code: IL_0002
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC0")]
		[Cpp2IlInjected.Address(RVA = "0x2F93380", Offset = "0x2F91D80", VA = "0x182F93380", Slot = "2")]
		public override int GetHashCode()
		{
			int y = Y;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC1")]
		[Cpp2IlInjected.Address(RVA = "0x2F93490", Offset = "0x2F91E90", VA = "0x182F93490", Slot = "3")]
		public override string ToString()
		{
			int y = Y;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC2")]
		[Cpp2IlInjected.Address(RVA = "0x2F93650", Offset = "0x2F92050", VA = "0x182F93650")]
		public static GridPosition operator +(in GridPosition lhs, in GridPosition rhs)
		{
			int y = lhs.Y;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC3")]
		[Cpp2IlInjected.Address(RVA = "0x2F93770", Offset = "0x2F92170", VA = "0x182F93770")]
		public static GridPosition operator -(in GridPosition lhs, in GridPosition rhs)
		{
			int y = lhs.Y;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC4")]
		[Cpp2IlInjected.Address(RVA = "0x2F93790", Offset = "0x2F92190", VA = "0x182F93790")]
		public static GridPosition operator -(in GridPosition lhs)
		{
			int y = lhs.Y;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC5")]
		[Cpp2IlInjected.Address(RVA = "0x2F93750", Offset = "0x2F92150", VA = "0x182F93750")]
		public static GridPosition operator *(int multiplier, in GridPosition rhs)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC6")]
		[Cpp2IlInjected.Address(RVA = "0x2F93730", Offset = "0x2F92130", VA = "0x182F93730")]
		public static GridPosition operator *(in GridPosition lhs, int multiplier)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC7")]
		[Cpp2IlInjected.Address(RVA = "0x2F93670", Offset = "0x2F92070", VA = "0x182F93670")]
		public static GridPosition operator /(in GridPosition lhs, int divider)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC8")]
		[Cpp2IlInjected.Address(RVA = "0x2F93520", Offset = "0x2F91F20", VA = "0x182F93520")]
		static GridPosition()
		{
			//IL_0006: Expected O, but got I4
			//IL_000c: Expected O, but got I8
			ulong num = default(ulong);
			Right = (GridPosition)num;
		}
	}
}
