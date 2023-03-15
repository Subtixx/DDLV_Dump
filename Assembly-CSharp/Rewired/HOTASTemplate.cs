using System;
using Cpp2IlInjected;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly Guid typeGuid;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public const int elementId_stickX = 0;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public const int elementId_stickY = 1;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public const int elementId_stickRotate = 2;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public const int elementId_stickMiniStick1X = 78;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public const int elementId_stickMiniStick1Y = 79;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public const int elementId_stickMiniStick1Press = 80;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public const int elementId_stickMiniStick2X = 81;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public const int elementId_stickMiniStick2Y = 82;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public const int elementId_stickMiniStick2Press = 83;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public const int elementId_stickTrigger = 3;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const int elementId_stickTriggerStage2 = 4;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public const int elementId_stickPinkyButton = 5;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public const int elementId_stickPinkyTrigger = 154;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public const int elementId_stickButton1 = 6;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public const int elementId_stickButton2 = 7;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public const int elementId_stickButton3 = 8;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public const int elementId_stickButton4 = 9;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public const int elementId_stickButton5 = 10;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public const int elementId_stickButton6 = 11;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public const int elementId_stickButton7 = 12;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public const int elementId_stickButton8 = 13;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public const int elementId_stickButton9 = 14;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public const int elementId_stickButton10 = 15;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public const int elementId_stickBaseButton1 = 18;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public const int elementId_stickBaseButton2 = 19;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public const int elementId_stickBaseButton3 = 20;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public const int elementId_stickBaseButton4 = 21;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public const int elementId_stickBaseButton5 = 22;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const int elementId_stickBaseButton6 = 23;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public const int elementId_stickBaseButton7 = 24;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public const int elementId_stickBaseButton8 = 25;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public const int elementId_stickBaseButton9 = 26;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public const int elementId_stickBaseButton10 = 27;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public const int elementId_stickBaseButton11 = 161;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public const int elementId_stickBaseButton12 = 162;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public const int elementId_stickHat1Up = 28;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public const int elementId_stickHat1UpRight = 29;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public const int elementId_stickHat1Right = 30;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public const int elementId_stickHat1DownRight = 31;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public const int elementId_stickHat1Down = 32;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public const int elementId_stickHat1DownLeft = 33;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public const int elementId_stickHat1Left = 34;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public const int elementId_stickHat1Up_Left = 35;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public const int elementId_stickHat2Up = 36;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public const int elementId_stickHat2Up_right = 37;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public const int elementId_stickHat2Right = 38;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public const int elementId_stickHat2Down_Right = 39;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public const int elementId_stickHat2Down = 40;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public const int elementId_stickHat2Down_Left = 41;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public const int elementId_stickHat2Left = 42;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public const int elementId_stickHat2Up_Left = 43;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public const int elementId_stickHat3Up = 84;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public const int elementId_stickHat3Up_Right = 85;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public const int elementId_stickHat3Right = 86;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public const int elementId_stickHat3Down_Right = 87;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public const int elementId_stickHat3Down = 88;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public const int elementId_stickHat3Down_Left = 89;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public const int elementId_stickHat3Left = 90;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public const int elementId_stickHat3Up_Left = 91;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public const int elementId_stickHat4Up = 92;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public const int elementId_stickHat4Up_Right = 93;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public const int elementId_stickHat4Right = 94;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public const int elementId_stickHat4Down_Right = 95;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public const int elementId_stickHat4Down = 96;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public const int elementId_stickHat4Down_Left = 97;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public const int elementId_stickHat4Left = 98;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public const int elementId_stickHat4Up_Left = 99;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public const int elementId_mode1 = 44;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public const int elementId_mode2 = 45;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public const int elementId_mode3 = 46;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public const int elementId_throttle1Axis = 49;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public const int elementId_throttle2Axis = 155;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public const int elementId_throttle1MinDetent = 166;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public const int elementId_throttle2MinDetent = 167;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public const int elementId_throttleButton1 = 50;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public const int elementId_throttleButton2 = 51;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public const int elementId_throttleButton3 = 52;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public const int elementId_throttleButton4 = 53;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public const int elementId_throttleButton5 = 54;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public const int elementId_throttleButton6 = 55;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public const int elementId_throttleButton7 = 56;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public const int elementId_throttleButton8 = 57;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public const int elementId_throttleButton9 = 58;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public const int elementId_throttleButton10 = 59;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public const int elementId_throttleBaseButton1 = 60;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public const int elementId_throttleBaseButton2 = 61;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public const int elementId_throttleBaseButton3 = 62;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public const int elementId_throttleBaseButton4 = 63;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public const int elementId_throttleBaseButton5 = 64;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public const int elementId_throttleBaseButton6 = 65;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public const int elementId_throttleBaseButton7 = 66;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public const int elementId_throttleBaseButton8 = 67;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public const int elementId_throttleBaseButton9 = 68;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public const int elementId_throttleBaseButton10 = 69;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public const int elementId_throttleBaseButton11 = 132;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public const int elementId_throttleBaseButton12 = 133;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public const int elementId_throttleBaseButton13 = 134;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public const int elementId_throttleBaseButton14 = 135;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public const int elementId_throttleBaseButton15 = 136;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public const int elementId_throttleSlider1 = 70;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public const int elementId_throttleSlider2 = 71;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public const int elementId_throttleSlider3 = 72;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public const int elementId_throttleSlider4 = 73;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public const int elementId_throttleDial1 = 74;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public const int elementId_throttleDial2 = 142;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public const int elementId_throttleDial3 = 143;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public const int elementId_throttleDial4 = 144;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public const int elementId_throttleMiniStickX = 75;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public const int elementId_throttleMiniStickY = 76;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public const int elementId_throttleMiniStickPress = 77;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public const int elementId_throttleWheel1Forward = 145;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public const int elementId_throttleWheel1Back = 146;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public const int elementId_throttleWheel1Press = 147;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public const int elementId_throttleWheel2Forward = 148;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public const int elementId_throttleWheel2Back = 149;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public const int elementId_throttleWheel2Press = 150;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public const int elementId_throttleWheel3Forward = 151;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public const int elementId_throttleWheel3Back = 152;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public const int elementId_throttleWheel3Press = 153;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public const int elementId_throttleHat1Up = 100;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public const int elementId_throttleHat1Up_Right = 101;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public const int elementId_throttleHat1Right = 102;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public const int elementId_throttleHat1Down_Right = 103;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public const int elementId_throttleHat1Down = 104;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public const int elementId_throttleHat1Down_Left = 105;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public const int elementId_throttleHat1Left = 106;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public const int elementId_throttleHat1Up_Left = 107;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public const int elementId_throttleHat2Up = 108;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public const int elementId_throttleHat2Up_Right = 109;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public const int elementId_throttleHat2Right = 110;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public const int elementId_throttleHat2Down_Right = 111;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public const int elementId_throttleHat2Down = 112;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public const int elementId_throttleHat2Down_Left = 113;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public const int elementId_throttleHat2Left = 114;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public const int elementId_throttleHat2Up_Left = 115;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public const int elementId_throttleHat3Up = 116;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public const int elementId_throttleHat3Up_Right = 117;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public const int elementId_throttleHat3Right = 118;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public const int elementId_throttleHat3Down_Right = 119;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public const int elementId_throttleHat3Down = 120;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public const int elementId_throttleHat3Down_Left = 121;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public const int elementId_throttleHat3Left = 122;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public const int elementId_throttleHat3Up_Left = 123;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public const int elementId_throttleHat4Up = 124;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public const int elementId_throttleHat4Up_Right = 125;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public const int elementId_throttleHat4Right = 126;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public const int elementId_throttleHat4Down_Right = 127;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public const int elementId_throttleHat4Down = 128;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public const int elementId_throttleHat4Down_Left = 129;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public const int elementId_throttleHat4Left = 130;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public const int elementId_throttleHat4Up_Left = 131;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public const int elementId_leftPedal = 168;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public const int elementId_rightPedal = 169;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public const int elementId_slidePedals = 170;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public const int elementId_stick = 171;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public const int elementId_stickMiniStick1 = 172;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public const int elementId_stickMiniStick2 = 173;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public const int elementId_stickHat1 = 174;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public const int elementId_stickHat2 = 175;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public const int elementId_stickHat3 = 176;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public const int elementId_stickHat4 = 177;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public const int elementId_throttle1 = 178;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public const int elementId_throttle2 = 179;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public const int elementId_throttleMiniStick = 180;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public const int elementId_throttleHat1 = 181;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public const int elementId_throttleHat2 = 182;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public const int elementId_throttleHat3 = 183;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public const int elementId_throttleHat4 = 184;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		IControllerTemplateButton IHOTASTemplate.stickTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x1E94740", Offset = "0x1E93140", VA = "0x181E94740", Slot = "12")]
			get
			{
				return GetElement<IControllerTemplateButton>(3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x1E94700", Offset = "0x1E93100", VA = "0x181E94700", Slot = "13")]
			get
			{
				return GetElement<IControllerTemplateButton>(4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1E94680", Offset = "0x1E93080", VA = "0x181E94680", Slot = "14")]
			get
			{
				return GetElement<IControllerTemplateButton>(5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1E946C0", Offset = "0x1E930C0", VA = "0x181E946C0", Slot = "15")]
			get
			{
				return GetElement<IControllerTemplateButton>(154);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		IControllerTemplateButton IHOTASTemplate.stickButton1
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1E942C0", Offset = "0x1E92CC0", VA = "0x181E942C0", Slot = "16")]
			get
			{
				return GetElement<IControllerTemplateButton>(6);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		IControllerTemplateButton IHOTASTemplate.stickButton2
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1E94300", Offset = "0x1E92D00", VA = "0x181E94300", Slot = "17")]
			get
			{
				return GetElement<IControllerTemplateButton>(7);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		IControllerTemplateButton IHOTASTemplate.stickButton3
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1E94340", Offset = "0x1E92D40", VA = "0x181E94340", Slot = "18")]
			get
			{
				return GetElement<IControllerTemplateButton>(8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		IControllerTemplateButton IHOTASTemplate.stickButton4
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1E94380", Offset = "0x1E92D80", VA = "0x181E94380", Slot = "19")]
			get
			{
				return GetElement<IControllerTemplateButton>(9);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		IControllerTemplateButton IHOTASTemplate.stickButton5
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1E943C0", Offset = "0x1E92DC0", VA = "0x181E943C0", Slot = "20")]
			get
			{
				return GetElement<IControllerTemplateButton>(10);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		IControllerTemplateButton IHOTASTemplate.stickButton6
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1E94400", Offset = "0x1E92E00", VA = "0x181E94400", Slot = "21")]
			get
			{
				return GetElement<IControllerTemplateButton>(11);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		IControllerTemplateButton IHOTASTemplate.stickButton7
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1E94440", Offset = "0x1E92E40", VA = "0x181E94440", Slot = "22")]
			get
			{
				return GetElement<IControllerTemplateButton>(12);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		IControllerTemplateButton IHOTASTemplate.stickButton8
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1E94480", Offset = "0x1E92E80", VA = "0x181E94480", Slot = "23")]
			get
			{
				return GetElement<IControllerTemplateButton>(13);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		IControllerTemplateButton IHOTASTemplate.stickButton9
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1E944C0", Offset = "0x1E92EC0", VA = "0x181E944C0", Slot = "24")]
			get
			{
				return GetElement<IControllerTemplateButton>(14);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		IControllerTemplateButton IHOTASTemplate.stickButton10
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1E94280", Offset = "0x1E92C80", VA = "0x181E94280", Slot = "25")]
			get
			{
				return GetElement<IControllerTemplateButton>(15);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1E94040", Offset = "0x1E92A40", VA = "0x181E94040", Slot = "26")]
			get
			{
				return GetElement<IControllerTemplateButton>(18);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1E94080", Offset = "0x1E92A80", VA = "0x181E94080", Slot = "27")]
			get
			{
				return GetElement<IControllerTemplateButton>(19);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1E940C0", Offset = "0x1E92AC0", VA = "0x181E940C0", Slot = "28")]
			get
			{
				return GetElement<IControllerTemplateButton>(20);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E94100", Offset = "0x1E92B00", VA = "0x181E94100", Slot = "29")]
			get
			{
				return GetElement<IControllerTemplateButton>(21);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1E94140", Offset = "0x1E92B40", VA = "0x181E94140", Slot = "30")]
			get
			{
				return GetElement<IControllerTemplateButton>(22);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1E94180", Offset = "0x1E92B80", VA = "0x181E94180", Slot = "31")]
			get
			{
				return GetElement<IControllerTemplateButton>(23);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1E941C0", Offset = "0x1E92BC0", VA = "0x181E941C0", Slot = "32")]
			get
			{
				return GetElement<IControllerTemplateButton>(24);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1E94200", Offset = "0x1E92C00", VA = "0x181E94200", Slot = "33")]
			get
			{
				return GetElement<IControllerTemplateButton>(25);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1E94240", Offset = "0x1E92C40", VA = "0x181E94240", Slot = "34")]
			get
			{
				return GetElement<IControllerTemplateButton>(26);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1E93F80", Offset = "0x1E92980", VA = "0x181E93F80", Slot = "35")]
			get
			{
				return GetElement<IControllerTemplateButton>(27);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1E93FC0", Offset = "0x1E929C0", VA = "0x181E93FC0", Slot = "36")]
			get
			{
				return GetElement<IControllerTemplateButton>(161);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1E94000", Offset = "0x1E92A00", VA = "0x181E94000", Slot = "37")]
			get
			{
				return GetElement<IControllerTemplateButton>(162);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		IControllerTemplateButton IHOTASTemplate.mode1
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1E93E40", Offset = "0x1E92840", VA = "0x181E93E40", Slot = "38")]
			get
			{
				return GetElement<IControllerTemplateButton>(44);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		IControllerTemplateButton IHOTASTemplate.mode2
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1E93E80", Offset = "0x1E92880", VA = "0x181E93E80", Slot = "39")]
			get
			{
				return GetElement<IControllerTemplateButton>(45);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		IControllerTemplateButton IHOTASTemplate.mode3
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1E93EC0", Offset = "0x1E928C0", VA = "0x181E93EC0", Slot = "40")]
			get
			{
				return GetElement<IControllerTemplateButton>(46);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		IControllerTemplateButton IHOTASTemplate.throttleButton1
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1E94C40", Offset = "0x1E93640", VA = "0x181E94C40", Slot = "41")]
			get
			{
				return GetElement<IControllerTemplateButton>(50);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		IControllerTemplateButton IHOTASTemplate.throttleButton2
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1E94C80", Offset = "0x1E93680", VA = "0x181E94C80", Slot = "42")]
			get
			{
				return GetElement<IControllerTemplateButton>(51);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		IControllerTemplateButton IHOTASTemplate.throttleButton3
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1E94CC0", Offset = "0x1E936C0", VA = "0x181E94CC0", Slot = "43")]
			get
			{
				return GetElement<IControllerTemplateButton>(52);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		IControllerTemplateButton IHOTASTemplate.throttleButton4
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1E94D00", Offset = "0x1E93700", VA = "0x181E94D00", Slot = "44")]
			get
			{
				return GetElement<IControllerTemplateButton>(53);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		IControllerTemplateButton IHOTASTemplate.throttleButton5
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1E94D40", Offset = "0x1E93740", VA = "0x181E94D40", Slot = "45")]
			get
			{
				return GetElement<IControllerTemplateButton>(54);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		IControllerTemplateButton IHOTASTemplate.throttleButton6
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1E94D80", Offset = "0x1E93780", VA = "0x181E94D80", Slot = "46")]
			get
			{
				return GetElement<IControllerTemplateButton>(55);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		IControllerTemplateButton IHOTASTemplate.throttleButton7
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1E94DC0", Offset = "0x1E937C0", VA = "0x181E94DC0", Slot = "47")]
			get
			{
				return GetElement<IControllerTemplateButton>(56);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		IControllerTemplateButton IHOTASTemplate.throttleButton8
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1E94E00", Offset = "0x1E93800", VA = "0x181E94E00", Slot = "48")]
			get
			{
				return GetElement<IControllerTemplateButton>(57);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		IControllerTemplateButton IHOTASTemplate.throttleButton9
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1E94E40", Offset = "0x1E93840", VA = "0x181E94E40", Slot = "49")]
			get
			{
				return GetElement<IControllerTemplateButton>(58);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		IControllerTemplateButton IHOTASTemplate.throttleButton10
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1E94C00", Offset = "0x1E93600", VA = "0x181E94C00", Slot = "50")]
			get
			{
				return GetElement<IControllerTemplateButton>(59);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1E949C0", Offset = "0x1E933C0", VA = "0x181E949C0", Slot = "51")]
			get
			{
				return GetElement<IControllerTemplateButton>(60);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1E94A00", Offset = "0x1E93400", VA = "0x181E94A00", Slot = "52")]
			get
			{
				return GetElement<IControllerTemplateButton>(61);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1E94A40", Offset = "0x1E93440", VA = "0x181E94A40", Slot = "53")]
			get
			{
				return GetElement<IControllerTemplateButton>(62);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1E94A80", Offset = "0x1E93480", VA = "0x181E94A80", Slot = "54")]
			get
			{
				return GetElement<IControllerTemplateButton>(63);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1E94AC0", Offset = "0x1E934C0", VA = "0x181E94AC0", Slot = "55")]
			get
			{
				return GetElement<IControllerTemplateButton>(64);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1E94B00", Offset = "0x1E93500", VA = "0x181E94B00", Slot = "56")]
			get
			{
				return GetElement<IControllerTemplateButton>(65);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1E94B40", Offset = "0x1E93540", VA = "0x181E94B40", Slot = "57")]
			get
			{
				return GetElement<IControllerTemplateButton>(66);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1E94B80", Offset = "0x1E93580", VA = "0x181E94B80", Slot = "58")]
			get
			{
				return GetElement<IControllerTemplateButton>(67);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1E94BC0", Offset = "0x1E935C0", VA = "0x181E94BC0", Slot = "59")]
			get
			{
				return GetElement<IControllerTemplateButton>(68);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1E94840", Offset = "0x1E93240", VA = "0x181E94840", Slot = "60")]
			get
			{
				return GetElement<IControllerTemplateButton>(69);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1E94880", Offset = "0x1E93280", VA = "0x181E94880", Slot = "61")]
			get
			{
				return GetElement<IControllerTemplateButton>(132);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1E948C0", Offset = "0x1E932C0", VA = "0x181E948C0", Slot = "62")]
			get
			{
				return GetElement<IControllerTemplateButton>(133);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1E94900", Offset = "0x1E93300", VA = "0x181E94900", Slot = "63")]
			get
			{
				return GetElement<IControllerTemplateButton>(134);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1E94940", Offset = "0x1E93340", VA = "0x181E94940", Slot = "64")]
			get
			{
				return GetElement<IControllerTemplateButton>(135);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1E94980", Offset = "0x1E93380", VA = "0x181E94980", Slot = "65")]
			get
			{
				return GetElement<IControllerTemplateButton>(136);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1E950C0", Offset = "0x1E93AC0", VA = "0x181E950C0", Slot = "66")]
			get
			{
				return GetElement<IControllerTemplateAxis>(70);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1E95100", Offset = "0x1E93B00", VA = "0x181E95100", Slot = "67")]
			get
			{
				return GetElement<IControllerTemplateAxis>(71);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1E95140", Offset = "0x1E93B40", VA = "0x181E95140", Slot = "68")]
			get
			{
				return GetElement<IControllerTemplateAxis>(72);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1E95180", Offset = "0x1E93B80", VA = "0x181E95180", Slot = "69")]
			get
			{
				return GetElement<IControllerTemplateAxis>(73);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		IControllerTemplateAxis IHOTASTemplate.throttleDial1
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1E94E80", Offset = "0x1E93880", VA = "0x181E94E80", Slot = "70")]
			get
			{
				return GetElement<IControllerTemplateAxis>(74);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		IControllerTemplateAxis IHOTASTemplate.throttleDial2
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1E94EC0", Offset = "0x1E938C0", VA = "0x181E94EC0", Slot = "71")]
			get
			{
				return GetElement<IControllerTemplateAxis>(142);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		IControllerTemplateAxis IHOTASTemplate.throttleDial3
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1E94F00", Offset = "0x1E93900", VA = "0x181E94F00", Slot = "72")]
			get
			{
				return GetElement<IControllerTemplateAxis>(143);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		IControllerTemplateAxis IHOTASTemplate.throttleDial4
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1E94F40", Offset = "0x1E93940", VA = "0x181E94F40", Slot = "73")]
			get
			{
				return GetElement<IControllerTemplateAxis>(144);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1E95200", Offset = "0x1E93C00", VA = "0x181E95200", Slot = "74")]
			get
			{
				return GetElement<IControllerTemplateButton>(145);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1E951C0", Offset = "0x1E93BC0", VA = "0x181E951C0", Slot = "75")]
			get
			{
				return GetElement<IControllerTemplateButton>(146);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1E95240", Offset = "0x1E93C40", VA = "0x181E95240", Slot = "76")]
			get
			{
				return GetElement<IControllerTemplateButton>(147);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1E952C0", Offset = "0x1E93CC0", VA = "0x181E952C0", Slot = "77")]
			get
			{
				return GetElement<IControllerTemplateButton>(148);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1E95280", Offset = "0x1E93C80", VA = "0x181E95280", Slot = "78")]
			get
			{
				return GetElement<IControllerTemplateButton>(149);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1E95300", Offset = "0x1E93D00", VA = "0x181E95300", Slot = "79")]
			get
			{
				return GetElement<IControllerTemplateButton>(150);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1E95380", Offset = "0x1E93D80", VA = "0x181E95380", Slot = "80")]
			get
			{
				return GetElement<IControllerTemplateButton>(151);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1E95340", Offset = "0x1E93D40", VA = "0x181E95340", Slot = "81")]
			get
			{
				return GetElement<IControllerTemplateButton>(152);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1E953C0", Offset = "0x1E93DC0", VA = "0x181E953C0", Slot = "82")]
			get
			{
				return GetElement<IControllerTemplateButton>(153);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		IControllerTemplateAxis IHOTASTemplate.leftPedal
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1E93E00", Offset = "0x1E92800", VA = "0x181E93E00", Slot = "83")]
			get
			{
				return GetElement<IControllerTemplateAxis>(168);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		IControllerTemplateAxis IHOTASTemplate.rightPedal
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1E93F00", Offset = "0x1E92900", VA = "0x181E93F00", Slot = "84")]
			get
			{
				return GetElement<IControllerTemplateAxis>(169);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		IControllerTemplateAxis IHOTASTemplate.slidePedals
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1E93F40", Offset = "0x1E92940", VA = "0x181E93F40", Slot = "85")]
			get
			{
				return GetElement<IControllerTemplateAxis>(170);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		IControllerTemplateStick IHOTASTemplate.stick
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1E94780", Offset = "0x1E93180", VA = "0x181E94780", Slot = "86")]
			get
			{
				return GetElement<IControllerTemplateStick>(171);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1E94600", Offset = "0x1E93000", VA = "0x181E94600", Slot = "87")]
			get
			{
				return GetElement<IControllerTemplateThumbStick>(172);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1E94640", Offset = "0x1E93040", VA = "0x181E94640", Slot = "88")]
			get
			{
				return GetElement<IControllerTemplateThumbStick>(173);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		IControllerTemplateHat IHOTASTemplate.stickHat1
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1E94500", Offset = "0x1E92F00", VA = "0x181E94500", Slot = "89")]
			get
			{
				return GetElement<IControllerTemplateHat>(174);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		IControllerTemplateHat IHOTASTemplate.stickHat2
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1E94540", Offset = "0x1E92F40", VA = "0x181E94540", Slot = "90")]
			get
			{
				return GetElement<IControllerTemplateHat>(175);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		IControllerTemplateHat IHOTASTemplate.stickHat3
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1E94580", Offset = "0x1E92F80", VA = "0x181E94580", Slot = "91")]
			get
			{
				return GetElement<IControllerTemplateHat>(176);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		IControllerTemplateHat IHOTASTemplate.stickHat4
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1E945C0", Offset = "0x1E92FC0", VA = "0x181E945C0", Slot = "92")]
			get
			{
				return GetElement<IControllerTemplateHat>(177);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		IControllerTemplateThrottle IHOTASTemplate.throttle1
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1E947C0", Offset = "0x1E931C0", VA = "0x181E947C0", Slot = "93")]
			get
			{
				return GetElement<IControllerTemplateThrottle>(178);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		IControllerTemplateThrottle IHOTASTemplate.throttle2
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1E94800", Offset = "0x1E93200", VA = "0x181E94800", Slot = "94")]
			get
			{
				return GetElement<IControllerTemplateThrottle>(179);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1E95080", Offset = "0x1E93A80", VA = "0x181E95080", Slot = "95")]
			get
			{
				return GetElement<IControllerTemplateThumbStick>(180);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		IControllerTemplateHat IHOTASTemplate.throttleHat1
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1E94F80", Offset = "0x1E93980", VA = "0x181E94F80", Slot = "96")]
			get
			{
				return GetElement<IControllerTemplateHat>(181);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		IControllerTemplateHat IHOTASTemplate.throttleHat2
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1E94FC0", Offset = "0x1E939C0", VA = "0x181E94FC0", Slot = "97")]
			get
			{
				return GetElement<IControllerTemplateHat>(182);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		IControllerTemplateHat IHOTASTemplate.throttleHat3
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1E95000", Offset = "0x1E93A00", VA = "0x181E95000", Slot = "98")]
			get
			{
				return GetElement<IControllerTemplateHat>(183);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		IControllerTemplateHat IHOTASTemplate.throttleHat4
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1E95040", Offset = "0x1E93A40", VA = "0x181E95040", Slot = "99")]
			get
			{
				return GetElement<IControllerTemplateHat>(184);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E92290", Offset = "0x1E90C90", VA = "0x181E92290")]
		public HOTASTemplate(object payload)
			: base(payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E95400", Offset = "0x1E93E00", VA = "0x181E95400")]
		static HOTASTemplate()
		{
			int num = 0;
		}
	}
}
