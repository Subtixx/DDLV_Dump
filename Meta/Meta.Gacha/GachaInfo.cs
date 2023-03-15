using System.Collections.Generic;
using Cpp2IlInjected;

namespace Meta.Gacha
{
	[Cpp2IlInjected.Token(Token = "0x200109B")]
	public class GachaInfo
	{
		[Cpp2IlInjected.Token(Token = "0x200109C")]
		public class PullInfo
		{
			[Cpp2IlInjected.Token(Token = "0x200109D")]
			public class TableInfo
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4004486")]
				public string Description;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4004487")]
				public double Rate;

				[Cpp2IlInjected.Token(Token = "0x60086D3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public TableInfo()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4004484")]
			public int Pulls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4004485")]
			public List<TableInfo> TableInfos = (List<TableInfo>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x60086D2")]
			[Cpp2IlInjected.Address(RVA = "0x99BE70", Offset = "0x99A870", VA = "0x18099BE70")]
			public PullInfo()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004483")]
		public List<PullInfo> Pulls = (List<PullInfo>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60086D1")]
		[Cpp2IlInjected.Address(RVA = "0x180BE50", Offset = "0x180A850", VA = "0x18180BE50")]
		public GachaInfo()
		{
		}
	}
}
