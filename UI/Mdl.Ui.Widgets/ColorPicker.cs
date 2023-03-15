using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200096E")]
	public class ColorPicker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200096F")]
		public delegate void ColorChanged(Color color);

		[Cpp2IlInjected.Token(Token = "0x17000810")]
		public virtual Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003B54")]
			[Cpp2IlInjected.Address(RVA = "0xC4B5B0", Offset = "0xC49FB0", VA = "0x180C4B5B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6003B55")]
			[Cpp2IlInjected.Address(RVA = "0x11510D0", Offset = "0x114FAD0", VA = "0x1811510D0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007D")]
		public event ColorChanged OnColorChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6003B52")]
			[Cpp2IlInjected.Address(RVA = "0x1150F90", Offset = "0x114F990", VA = "0x181150F90")]
			[CompilerGenerated]
			add
			{
				ColorChanged onColorChanged = this.OnColorChanged;
				Delegate @delegate = Delegate.Combine(onColorChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onColorChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003B53")]
			[Cpp2IlInjected.Address(RVA = "0x1151030", Offset = "0x114FA30", VA = "0x181151030")]
			[CompilerGenerated]
			remove
			{
				ColorChanged onColorChanged = this.OnColorChanged;
				Delegate @delegate = Delegate.Remove(onColorChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onColorChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B56")]
		[Cpp2IlInjected.Address(RVA = "0x1150A00", Offset = "0x114F400", VA = "0x181150A00")]
		protected void RaiseColorChanged(Color color)
		{
			if (this.OnColorChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B57")]
		[Cpp2IlInjected.Address(RVA = "0x1150F60", Offset = "0x114F960", VA = "0x181150F60")]
		public ColorPicker()
		{
			Color white = Color.white;
			base._002Ector();
		}
	}
}
