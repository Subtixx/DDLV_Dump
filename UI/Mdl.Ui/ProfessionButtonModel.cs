using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000602")]
	public class ProfessionButtonModel : CustomButtonModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400216F")]
		private ProfessionButton _professionButton;

		[Cpp2IlInjected.Token(Token = "0x170005FA")]
		public ProfessionItemData ProfessionItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600276C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CProfessionItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600276D")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CProfessionItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600276E")]
		[Cpp2IlInjected.Address(RVA = "0xE1B1A0", Offset = "0xE19BA0", VA = "0x180E1B1A0", Slot = "4")]
		public override void Init(CustomButton button)
		{
			if ((object)button == null)
			{
			}
			int num = 0;
			_professionButton = (ProfessionButton)button;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600276F")]
		[Cpp2IlInjected.Address(RVA = "0xE1B220", Offset = "0xE19C20", VA = "0x180E1B220", Slot = "6")]
		public override void Release()
		{
			//IL_0009: Expected O, but got I8
			_professionButton = (ProfessionButton)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002770")]
		[Cpp2IlInjected.Address(RVA = "0xE1B260", Offset = "0xE19C60", VA = "0x180E1B260", Slot = "5")]
		public override void UpdateDisplay()
		{
			//Discarded unreachable code: IL_0083
			//IL_001b: Expected O, but got I4
			if ((long)ProfessionItemData != 0)
			{
				ProfessionButton professionButton = _professionButton;
				int num = 0;
				if (!(professionButton == (UnityEngine.Object)num))
				{
					ImageHelper dynamicIcon = _professionButton.View.DynamicIcon;
					ProfessionItemData professionItemData = ProfessionItemData;
					AsyncAtlassedIcon asyncAtlassedIcon = dynamicIcon.AsyncAtlassedIcon;
					string iconAddress_ = professionItemData.iconAddress_;
					bool flag = asyncAtlassedIcon.SetIcon(iconAddress_);
					ButtonViewDefault view = _professionButton.View;
					ProfessionItemData professionItemData2 = ProfessionItemData;
					TextBase label = view.Label;
					string text = (label.StringID = professionItemData2.displayName_);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002771")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public ProfessionButtonModel()
		{
			((MarshalByRefObject)(object)this)._002Ector();
		}
	}
}
