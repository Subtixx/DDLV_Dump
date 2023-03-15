using System;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000988")]
	public class MoodFilter : Filter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003857")]
		public Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003858")]
		private int? id;

		[Cpp2IlInjected.Token(Token = "0x17000830")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003856")]
		public Mood Mood
		{
			[Cpp2IlInjected.Token(Token = "0x6003BEE")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003BEF")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000831")]
		public override int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF1")]
			[Cpp2IlInjected.Address(RVA = "0x12954B0", Offset = "0x1293EB0", VA = "0x1812954B0", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0023
				//IL_000d: Expected O, but got I4
				//IL_0020: Expected O, but got I8
				Mood mood = Mood;
				string text = ((Enum)mood).ToString();
				Mood mood2 = mood;
				int hashCode = text.GetHashCode();
				ulong num = default(ulong);
				id = (int?)(object)num;
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000832")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF2")]
			[Cpp2IlInjected.Address(RVA = "0x12955D0", Offset = "0x1293FD0", VA = "0x1812955D0", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_000c
				//IL_000b: Expected O, but got I4
				return ((Enum)Mood).ToString();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000833")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF3")]
			[Cpp2IlInjected.Address(RVA = "0x12953C0", Offset = "0x1293DC0", VA = "0x1812953C0", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_0028
				//IL_000d: Expected O, but got I4
				Mood mood = Mood;
				string text = ((Enum)mood).ToString();
				Mood mood2 = mood;
				string text2 = text.ToLower();
				return UIUtil.Loc("menu.catalog_trait_" + text2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000834")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF4")]
			[Cpp2IlInjected.Address(RVA = "0x12953B0", Offset = "0x1293DB0", VA = "0x1812953B0", Slot = "8")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BF0")]
		[Cpp2IlInjected.Address(RVA = "0x1295320", Offset = "0x1293D20", VA = "0x181295320")]
		public MoodFilter(Mood mood, int order = 0)
		{
			((BattlePassReward)(object)this)._002Ector();
			Mood = mood;
			base.Order = order;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BF5")]
		[Cpp2IlInjected.Address(RVA = "0x12952B0", Offset = "0x1293CB0", VA = "0x1812952B0", Slot = "9")]
		public unsafe override bool Retains(object item)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IHasTraits).TypeHandle == null)
			{
				return (byte)(int)typeof(IHasTraits).TypeHandle != 0;
			}
			return (IntPtr)typeof(IHasTraits).TypeHandle == (IntPtr)(void*)(int)Mood;
		}
	}
}
