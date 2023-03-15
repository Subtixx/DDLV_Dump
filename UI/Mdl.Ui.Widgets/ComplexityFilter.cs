using System;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000987")]
	public class ComplexityFilter : Filter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003854")]
		public Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003855")]
		private int? id;

		[Cpp2IlInjected.Token(Token = "0x1700082B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003853")]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x6003BE6")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003BE7")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700082C")]
		public override int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003BE9")]
			[Cpp2IlInjected.Address(RVA = "0x14A3210", Offset = "0x14A1C10", VA = "0x1814A3210", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0023
				//IL_000d: Expected O, but got I4
				//IL_0020: Expected O, but got I8
				Complexity complexity = Complexity;
				string text = ((Enum)complexity).ToString();
				Complexity complexity2 = complexity;
				int hashCode = text.GetHashCode();
				ulong num = default(ulong);
				id = (int?)(object)num;
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082D")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003BEA")]
			[Cpp2IlInjected.Address(RVA = "0x14A3330", Offset = "0x14A1D30", VA = "0x1814A3330", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				//IL_000b: Expected O, but got I4
				return ((Enum)Complexity).ToString();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003BEB")]
			[Cpp2IlInjected.Address(RVA = "0x14A3120", Offset = "0x14A1B20", VA = "0x1814A3120", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_0028
				//IL_000d: Expected O, but got I4
				Complexity complexity = Complexity;
				string text = ((Enum)complexity).ToString();
				Complexity complexity2 = complexity;
				string text2 = text.ToLower();
				return UIUtil.Loc("menu.catalog_trait_" + text2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700082F")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003BEC")]
			[Cpp2IlInjected.Address(RVA = "0x12953B0", Offset = "0x1293DB0", VA = "0x1812953B0", Slot = "8")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BE8")]
		[Cpp2IlInjected.Address(RVA = "0x14A3090", Offset = "0x14A1A90", VA = "0x1814A3090")]
		public ComplexityFilter(Complexity complexity, int order = 0)
		{
			((BattlePassReward)(object)this)._002Ector();
			Complexity = complexity;
			base.Order = order;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BED")]
		[Cpp2IlInjected.Address(RVA = "0x14A3020", Offset = "0x14A1A20", VA = "0x1814A3020", Slot = "9")]
		public unsafe override bool Retains(object item)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IHasTraits).TypeHandle == null)
			{
				return (byte)(int)typeof(IHasTraits).TypeHandle != 0;
			}
			return (IntPtr)typeof(IHasTraits).TypeHandle == (IntPtr)(void*)(int)Complexity;
		}
	}
}
