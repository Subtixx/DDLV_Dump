using System;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200098A")]
	public class NormalityFilter : Filter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400385D")]
		public Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400385E")]
		private int? id;

		[Cpp2IlInjected.Token(Token = "0x1700083A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400385C")]
		public Normality Normality
		{
			[Cpp2IlInjected.Token(Token = "0x6003BFE")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003BFF")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700083B")]
		public override int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003C01")]
			[Cpp2IlInjected.Address(RVA = "0x129CA70", Offset = "0x129B470", VA = "0x18129CA70", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0023
				//IL_000d: Expected O, but got I4
				//IL_0020: Expected O, but got I8
				Normality normality = Normality;
				string text = ((Enum)normality).ToString();
				Normality normality2 = normality;
				int hashCode = text.GetHashCode();
				ulong num = default(ulong);
				id = (int?)(object)num;
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083C")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003C02")]
			[Cpp2IlInjected.Address(RVA = "0x129CB90", Offset = "0x129B590", VA = "0x18129CB90", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				//IL_000b: Expected O, but got I4
				return ((Enum)Normality).ToString();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083D")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003C03")]
			[Cpp2IlInjected.Address(RVA = "0x129C980", Offset = "0x129B380", VA = "0x18129C980", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_0028
				//IL_000d: Expected O, but got I4
				Normality normality = Normality;
				string text = ((Enum)normality).ToString();
				Normality normality2 = normality;
				string text2 = text.ToLower();
				return UIUtil.Loc("menu.catalog_trait_" + text2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083E")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003C04")]
			[Cpp2IlInjected.Address(RVA = "0x12953B0", Offset = "0x1293DB0", VA = "0x1812953B0", Slot = "8")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C00")]
		[Cpp2IlInjected.Address(RVA = "0x129C8F0", Offset = "0x129B2F0", VA = "0x18129C8F0")]
		public NormalityFilter(Normality normality, int order = 0)
		{
			((BattlePassReward)(object)this)._002Ector();
			Normality = normality;
			base.Order = order;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C05")]
		[Cpp2IlInjected.Address(RVA = "0x129C880", Offset = "0x129B280", VA = "0x18129C880", Slot = "9")]
		public unsafe override bool Retains(object item)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IHasTraits).TypeHandle == null)
			{
				return (byte)(int)typeof(IHasTraits).TypeHandle != 0;
			}
			return (IntPtr)typeof(IHasTraits).TypeHandle == (IntPtr)(void*)(int)Normality;
		}
	}
}
