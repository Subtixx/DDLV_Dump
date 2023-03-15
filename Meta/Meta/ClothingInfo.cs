using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009B2")]
	public struct ClothingInfo : IEquatable<ClothingInfo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400282F")]
		public ClothingItem ClothingItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4002830")]
		public int DesignId;

		[Cpp2IlInjected.Token(Token = "0x600547E")]
		[Cpp2IlInjected.Address(RVA = "0xF87D00", Offset = "0xF86700", VA = "0x180F87D00")]
		public ClothingInfo(ClothingItem clothingItem, int designId)
		{
			ClothingItem = clothingItem;
			DesignId = designId;
		}

		[Cpp2IlInjected.Token(Token = "0x600547F")]
		[Cpp2IlInjected.Address(RVA = "0x1674930", Offset = "0x1673330", VA = "0x181674930")]
		public static bool operator ==(ClothingInfo lhs, ClothingInfo rhs)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(ClothingItem).TypeHandle == null)
			{
				return (byte)(int)typeof(ClothingItem).TypeHandle != 0;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005480")]
		[Cpp2IlInjected.Address(RVA = "0x16749B0", Offset = "0x16733B0", VA = "0x1816749B0")]
		public static bool operator !=(ClothingInfo lhs, ClothingInfo rhs)
		{
			if ((object)typeof(ClothingItem).TypeHandle == null)
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005481")]
		[Cpp2IlInjected.Address(RVA = "0x16747F0", Offset = "0x16731F0", VA = "0x1816747F0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6005482")]
		[Cpp2IlInjected.Address(RVA = "0x1674900", Offset = "0x1673300", VA = "0x181674900", Slot = "2")]
		public override int GetHashCode()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005483")]
		[Cpp2IlInjected.Address(RVA = "0x1674880", Offset = "0x1673280", VA = "0x181674880", Slot = "4")]
		public bool Equals(ClothingInfo other)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(ClothingItem).TypeHandle == null)
			{
				return (byte)(int)typeof(ClothingItem).TypeHandle != 0;
			}
			bool result = default(bool);
			return result;
		}
	}
}
