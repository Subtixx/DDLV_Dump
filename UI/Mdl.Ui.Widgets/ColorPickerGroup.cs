using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000970")]
	public class ColorPickerGroup : ColorPicker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40037FF")]
		public TabsContainer tabsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003800")]
		public List<ColorPicker> colorPickers = (List<ColorPicker>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000811")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003B5C")]
			[Cpp2IlInjected.Address(RVA = "0x1150E20", Offset = "0x114F820", VA = "0x181150E20", Slot = "4")]
			get
			{
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003B5D")]
			[Cpp2IlInjected.Address(RVA = "0x1150EC0", Offset = "0x114F8C0", VA = "0x181150EC0", Slot = "5")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B5E")]
		[Cpp2IlInjected.Address(RVA = "0x1150B10", Offset = "0x114F510", VA = "0x181150B10")]
		private void Start()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003B5F")]
		[Cpp2IlInjected.Address(RVA = "0x1150A00", Offset = "0x114F400", VA = "0x181150A00")]
		private void OnPickerColorChanged(Color color)
		{
			if (base.OnColorChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B60")]
		[Cpp2IlInjected.Address(RVA = "0x1150A30", Offset = "0x114F430", VA = "0x181150A30")]
		private void SelectTab(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003B61")]
		[Cpp2IlInjected.Address(RVA = "0x1150D90", Offset = "0x114F790", VA = "0x181150D90")]
		public ColorPickerGroup()
		{
			Color white = Color.white;
			((MonoBehaviour)this)._002Ector();
		}
	}
}
