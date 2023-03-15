using Cpp2IlInjected;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface IGamepadTemplate : IControllerTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		IControllerTemplateButton actionBottomRow1
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		IControllerTemplateButton a
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		IControllerTemplateButton actionBottomRow2
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IControllerTemplateButton b
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		IControllerTemplateButton actionBottomRow3
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		IControllerTemplateButton c
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		IControllerTemplateButton actionTopRow1
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		IControllerTemplateButton x
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		IControllerTemplateButton actionTopRow2
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		IControllerTemplateButton y
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IControllerTemplateButton actionTopRow3
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		IControllerTemplateButton z
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		IControllerTemplateButton leftShoulder1
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		IControllerTemplateButton leftBumper
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		IControllerTemplateAxis leftShoulder2
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		IControllerTemplateAxis leftTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		IControllerTemplateButton rightShoulder1
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		IControllerTemplateButton rightBumper
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		IControllerTemplateAxis rightShoulder2
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		IControllerTemplateAxis rightTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		IControllerTemplateButton center1
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		IControllerTemplateButton back
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		IControllerTemplateButton center2
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		IControllerTemplateButton start
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		IControllerTemplateButton center3
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		IControllerTemplateButton guide
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IControllerTemplateThumbStick leftStick
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		IControllerTemplateThumbStick rightStick
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		IControllerTemplateDPad dPad
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}
	}
}
