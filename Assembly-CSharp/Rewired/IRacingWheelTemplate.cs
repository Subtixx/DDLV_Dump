using Cpp2IlInjected;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface IRacingWheelTemplate : IControllerTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		IControllerTemplateAxis wheel
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		IControllerTemplateAxis accelerator
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		IControllerTemplateAxis brake
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		IControllerTemplateAxis clutch
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		IControllerTemplateButton shiftDown
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		IControllerTemplateButton shiftUp
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		IControllerTemplateButton wheelButton1
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		IControllerTemplateButton wheelButton2
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		IControllerTemplateButton wheelButton3
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		IControllerTemplateButton wheelButton4
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		IControllerTemplateButton wheelButton5
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		IControllerTemplateButton wheelButton6
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		IControllerTemplateButton wheelButton7
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		IControllerTemplateButton wheelButton8
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		IControllerTemplateButton wheelButton9
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		IControllerTemplateButton wheelButton10
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		IControllerTemplateButton consoleButton1
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		IControllerTemplateButton consoleButton2
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		IControllerTemplateButton consoleButton3
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		IControllerTemplateButton consoleButton4
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		IControllerTemplateButton consoleButton5
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IControllerTemplateButton consoleButton6
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		IControllerTemplateButton consoleButton7
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		IControllerTemplateButton consoleButton8
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		IControllerTemplateButton consoleButton9
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		IControllerTemplateButton consoleButton10
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		IControllerTemplateButton shifter1
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		IControllerTemplateButton shifter2
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		IControllerTemplateButton shifter3
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		IControllerTemplateButton shifter4
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		IControllerTemplateButton shifter5
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		IControllerTemplateButton shifter6
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		IControllerTemplateButton shifter7
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		IControllerTemplateButton shifter8
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		IControllerTemplateButton shifter9
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		IControllerTemplateButton shifter10
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		IControllerTemplateButton reverseGear
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		IControllerTemplateButton select
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		IControllerTemplateButton start
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		IControllerTemplateButton systemButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		IControllerTemplateButton horn
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "40")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		IControllerTemplateDPad dPad
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
		}
	}
}
