using System;
using Cpp2IlInjected;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly Guid typeGuid;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public const int elementId_wheel = 0;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public const int elementId_accelerator = 1;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public const int elementId_brake = 2;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public const int elementId_clutch = 3;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public const int elementId_shiftDown = 4;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public const int elementId_shiftUp = 5;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public const int elementId_wheelButton1 = 6;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public const int elementId_wheelButton2 = 7;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public const int elementId_wheelButton3 = 8;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public const int elementId_wheelButton4 = 9;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public const int elementId_wheelButton5 = 10;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public const int elementId_wheelButton6 = 11;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public const int elementId_wheelButton7 = 12;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public const int elementId_wheelButton8 = 13;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public const int elementId_wheelButton9 = 14;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public const int elementId_wheelButton10 = 15;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public const int elementId_consoleButton1 = 16;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public const int elementId_consoleButton2 = 17;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public const int elementId_consoleButton3 = 18;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public const int elementId_consoleButton4 = 19;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public const int elementId_consoleButton5 = 20;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public const int elementId_consoleButton6 = 21;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public const int elementId_consoleButton7 = 22;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public const int elementId_consoleButton8 = 23;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public const int elementId_consoleButton9 = 24;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public const int elementId_consoleButton10 = 25;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public const int elementId_shifter1 = 26;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public const int elementId_shifter2 = 27;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public const int elementId_shifter3 = 28;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public const int elementId_shifter4 = 29;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public const int elementId_shifter5 = 30;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public const int elementId_shifter6 = 31;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public const int elementId_shifter7 = 32;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public const int elementId_shifter8 = 33;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public const int elementId_shifter9 = 34;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public const int elementId_shifter10 = 35;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public const int elementId_reverseGear = 44;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public const int elementId_select = 36;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const int elementId_start = 37;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public const int elementId_systemButton = 38;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public const int elementId_horn = 43;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public const int elementId_dPadUp = 39;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public const int elementId_dPadRight = 40;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public const int elementId_dPadDown = 41;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public const int elementId_dPadLeft = 42;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public const int elementId_dPad = 45;

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		IControllerTemplateAxis IRacingWheelTemplate.wheel
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x1E97C40", Offset = "0x1E96640", VA = "0x181E97C40", Slot = "12")]
			get
			{
				int id = 0;
				return GetElement<IControllerTemplateAxis>(id);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		IControllerTemplateAxis IRacingWheelTemplate.accelerator
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x1E97200", Offset = "0x1E95C00", VA = "0x181E97200", Slot = "13")]
			get
			{
				return GetElement<IControllerTemplateAxis>(1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		IControllerTemplateAxis IRacingWheelTemplate.brake
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x1E97240", Offset = "0x1E95C40", VA = "0x181E97240", Slot = "14")]
			get
			{
				return GetElement<IControllerTemplateAxis>(2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		IControllerTemplateAxis IRacingWheelTemplate.clutch
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1E97280", Offset = "0x1E95C80", VA = "0x181E97280", Slot = "15")]
			get
			{
				return GetElement<IControllerTemplateAxis>(3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		IControllerTemplateButton IRacingWheelTemplate.shiftDown
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1E97640", Offset = "0x1E96040", VA = "0x181E97640", Slot = "16")]
			get
			{
				return GetElement<IControllerTemplateButton>(4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		IControllerTemplateButton IRacingWheelTemplate.shiftUp
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1E97680", Offset = "0x1E96080", VA = "0x181E97680", Slot = "17")]
			get
			{
				return GetElement<IControllerTemplateButton>(5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton1
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x1E97A00", Offset = "0x1E96400", VA = "0x181E97A00", Slot = "18")]
			get
			{
				return GetElement<IControllerTemplateButton>(6);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton2
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1E97A40", Offset = "0x1E96440", VA = "0x181E97A40", Slot = "19")]
			get
			{
				return GetElement<IControllerTemplateButton>(7);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton3
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1E97A80", Offset = "0x1E96480", VA = "0x181E97A80", Slot = "20")]
			get
			{
				return GetElement<IControllerTemplateButton>(8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton4
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1E97AC0", Offset = "0x1E964C0", VA = "0x181E97AC0", Slot = "21")]
			get
			{
				return GetElement<IControllerTemplateButton>(9);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton5
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x1E97B00", Offset = "0x1E96500", VA = "0x181E97B00", Slot = "22")]
			get
			{
				return GetElement<IControllerTemplateButton>(10);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton6
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x1E97B40", Offset = "0x1E96540", VA = "0x181E97B40", Slot = "23")]
			get
			{
				return GetElement<IControllerTemplateButton>(11);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton7
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x1E97B80", Offset = "0x1E96580", VA = "0x181E97B80", Slot = "24")]
			get
			{
				return GetElement<IControllerTemplateButton>(12);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton8
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1E97BC0", Offset = "0x1E965C0", VA = "0x181E97BC0", Slot = "25")]
			get
			{
				return GetElement<IControllerTemplateButton>(13);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton9
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1E97C00", Offset = "0x1E96600", VA = "0x181E97C00", Slot = "26")]
			get
			{
				return GetElement<IControllerTemplateButton>(14);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		IControllerTemplateButton IRacingWheelTemplate.wheelButton10
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1E979C0", Offset = "0x1E963C0", VA = "0x181E979C0", Slot = "27")]
			get
			{
				return GetElement<IControllerTemplateButton>(15);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton1
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x1E97300", Offset = "0x1E95D00", VA = "0x181E97300", Slot = "28")]
			get
			{
				return GetElement<IControllerTemplateButton>(16);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton2
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1E97340", Offset = "0x1E95D40", VA = "0x181E97340", Slot = "29")]
			get
			{
				return GetElement<IControllerTemplateButton>(17);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton3
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1E97380", Offset = "0x1E95D80", VA = "0x181E97380", Slot = "30")]
			get
			{
				return GetElement<IControllerTemplateButton>(18);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton4
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1E973C0", Offset = "0x1E95DC0", VA = "0x181E973C0", Slot = "31")]
			get
			{
				return GetElement<IControllerTemplateButton>(19);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton5
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x1E97400", Offset = "0x1E95E00", VA = "0x181E97400", Slot = "32")]
			get
			{
				return GetElement<IControllerTemplateButton>(20);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton6
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x1E97440", Offset = "0x1E95E40", VA = "0x181E97440", Slot = "33")]
			get
			{
				return GetElement<IControllerTemplateButton>(21);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton7
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1E97480", Offset = "0x1E95E80", VA = "0x181E97480", Slot = "34")]
			get
			{
				return GetElement<IControllerTemplateButton>(22);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton8
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x1E974C0", Offset = "0x1E95EC0", VA = "0x181E974C0", Slot = "35")]
			get
			{
				return GetElement<IControllerTemplateButton>(23);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton9
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x1E97500", Offset = "0x1E95F00", VA = "0x181E97500", Slot = "36")]
			get
			{
				return GetElement<IControllerTemplateButton>(24);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		IControllerTemplateButton IRacingWheelTemplate.consoleButton10
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x1E972C0", Offset = "0x1E95CC0", VA = "0x181E972C0", Slot = "37")]
			get
			{
				return GetElement<IControllerTemplateButton>(25);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		IControllerTemplateButton IRacingWheelTemplate.shifter1
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1E97700", Offset = "0x1E96100", VA = "0x181E97700", Slot = "38")]
			get
			{
				return GetElement<IControllerTemplateButton>(26);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		IControllerTemplateButton IRacingWheelTemplate.shifter2
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1E97740", Offset = "0x1E96140", VA = "0x181E97740", Slot = "39")]
			get
			{
				return GetElement<IControllerTemplateButton>(27);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		IControllerTemplateButton IRacingWheelTemplate.shifter3
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1E97780", Offset = "0x1E96180", VA = "0x181E97780", Slot = "40")]
			get
			{
				return GetElement<IControllerTemplateButton>(28);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		IControllerTemplateButton IRacingWheelTemplate.shifter4
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x1E977C0", Offset = "0x1E961C0", VA = "0x181E977C0", Slot = "41")]
			get
			{
				return GetElement<IControllerTemplateButton>(29);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		IControllerTemplateButton IRacingWheelTemplate.shifter5
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x1E97800", Offset = "0x1E96200", VA = "0x181E97800", Slot = "42")]
			get
			{
				return GetElement<IControllerTemplateButton>(30);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		IControllerTemplateButton IRacingWheelTemplate.shifter6
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1E97840", Offset = "0x1E96240", VA = "0x181E97840", Slot = "43")]
			get
			{
				return GetElement<IControllerTemplateButton>(31);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		IControllerTemplateButton IRacingWheelTemplate.shifter7
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1E97880", Offset = "0x1E96280", VA = "0x181E97880", Slot = "44")]
			get
			{
				return GetElement<IControllerTemplateButton>(32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		IControllerTemplateButton IRacingWheelTemplate.shifter8
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1E978C0", Offset = "0x1E962C0", VA = "0x181E978C0", Slot = "45")]
			get
			{
				return GetElement<IControllerTemplateButton>(33);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		IControllerTemplateButton IRacingWheelTemplate.shifter9
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1E97900", Offset = "0x1E96300", VA = "0x181E97900", Slot = "46")]
			get
			{
				return GetElement<IControllerTemplateButton>(34);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		IControllerTemplateButton IRacingWheelTemplate.shifter10
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1E976C0", Offset = "0x1E960C0", VA = "0x181E976C0", Slot = "47")]
			get
			{
				return GetElement<IControllerTemplateButton>(35);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		IControllerTemplateButton IRacingWheelTemplate.reverseGear
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x1E975C0", Offset = "0x1E95FC0", VA = "0x181E975C0", Slot = "48")]
			get
			{
				return GetElement<IControllerTemplateButton>(44);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		IControllerTemplateButton IRacingWheelTemplate.select
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x1E97600", Offset = "0x1E96000", VA = "0x181E97600", Slot = "49")]
			get
			{
				return GetElement<IControllerTemplateButton>(36);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		IControllerTemplateButton IRacingWheelTemplate.start
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1E97940", Offset = "0x1E96340", VA = "0x181E97940", Slot = "50")]
			get
			{
				return GetElement<IControllerTemplateButton>(37);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		IControllerTemplateButton IRacingWheelTemplate.systemButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1E97980", Offset = "0x1E96380", VA = "0x181E97980", Slot = "51")]
			get
			{
				return GetElement<IControllerTemplateButton>(38);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		IControllerTemplateButton IRacingWheelTemplate.horn
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x1E97580", Offset = "0x1E95F80", VA = "0x181E97580", Slot = "52")]
			get
			{
				return GetElement<IControllerTemplateButton>(43);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		IControllerTemplateDPad IRacingWheelTemplate.dPad
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x1E97540", Offset = "0x1E95F40", VA = "0x181E97540", Slot = "53")]
			get
			{
				return GetElement<IControllerTemplateDPad>(45);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1E92290", Offset = "0x1E90C90", VA = "0x181E92290")]
		public RacingWheelTemplate(object payload)
			: base(payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1E97C80", Offset = "0x1E96680", VA = "0x181E97C80")]
		static RacingWheelTemplate()
		{
			int num = 0;
		}
	}
}
