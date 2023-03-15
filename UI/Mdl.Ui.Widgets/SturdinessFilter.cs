using System;
using Cpp2IlInjected;
using Definitions.Items;
using PlayFab.AdminModels;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000989")]
	public class SturdinessFilter : Filter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400385A")]
		public Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400385B")]
		private int? id;

		[Cpp2IlInjected.Token(Token = "0x17000835")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003859")]
		public Sturdiness Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF6")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003BF7")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000836")]
		public override int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF9")]
			[Cpp2IlInjected.Address(RVA = "0x17E3920", Offset = "0x17E2320", VA = "0x1817E3920", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0023
				//IL_000d: Expected O, but got I4
				//IL_0020: Expected O, but got I8
				Sturdiness sturdiness = Sturdiness;
				string text = ((Enum)sturdiness).ToString();
				Sturdiness sturdiness2 = sturdiness;
				int hashCode = text.GetHashCode();
				ulong num = default(ulong);
				id = (int?)(object)num;
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000837")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003BFA")]
			[Cpp2IlInjected.Address(RVA = "0x17E3A40", Offset = "0x17E2440", VA = "0x1817E3A40", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				//IL_000b: Expected O, but got I4
				return ((Enum)Sturdiness).ToString();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000838")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003BFB")]
			[Cpp2IlInjected.Address(RVA = "0x17E3830", Offset = "0x17E2230", VA = "0x1817E3830", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_0028
				//IL_000d: Expected O, but got I4
				Sturdiness sturdiness = Sturdiness;
				string text = ((Enum)sturdiness).ToString();
				Sturdiness sturdiness2 = sturdiness;
				string text2 = text.ToLower();
				return UIUtil.Loc("menu.catalog_trait_" + text2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000839")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003BFC")]
			[Cpp2IlInjected.Address(RVA = "0x12953B0", Offset = "0x1293DB0", VA = "0x1812953B0", Slot = "8")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BF8")]
		[Cpp2IlInjected.Address(RVA = "0x17E37A0", Offset = "0x17E21A0", VA = "0x1817E37A0")]
		public SturdinessFilter(Sturdiness sturdiness, int order = 0)
		{
			((RevokeInventoryItem)(object)this)._002Ector();
			Sturdiness = sturdiness;
			base.Order = order;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BFD")]
		[Cpp2IlInjected.Address(RVA = "0x17E3730", Offset = "0x17E2130", VA = "0x1817E3730", Slot = "9")]
		public unsafe override bool Retains(object item)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IHasTraits).TypeHandle == null)
			{
				return (byte)(int)typeof(IHasTraits).TypeHandle != 0;
			}
			return (IntPtr)typeof(IHasTraits).TypeHandle == (IntPtr)(void*)(int)Sturdiness;
		}
	}
}
