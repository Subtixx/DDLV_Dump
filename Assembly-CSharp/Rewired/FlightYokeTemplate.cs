using System;
using Cpp2IlInjected;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Guid typeGuid;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public const int elementId_rotateYoke = 0;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public const int elementId_yokeZ = 1;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public const int elementId_leftPaddle = 59;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public const int elementId_rightPaddle = 60;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public const int elementId_lever1Axis = 2;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public const int elementId_lever1MinDetent = 64;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public const int elementId_lever2Axis = 3;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public const int elementId_lever2MinDetent = 65;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public const int elementId_lever3Axis = 4;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public const int elementId_lever3MinDetent = 66;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public const int elementId_lever4Axis = 5;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public const int elementId_lever4MinDetent = 67;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public const int elementId_lever5Axis = 6;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public const int elementId_lever5MinDetent = 68;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public const int elementId_leftGripButton1 = 7;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public const int elementId_leftGripButton2 = 8;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public const int elementId_leftGripButton3 = 9;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public const int elementId_leftGripButton4 = 10;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public const int elementId_leftGripButton5 = 11;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public const int elementId_leftGripButton6 = 12;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public const int elementId_rightGripButton1 = 13;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const int elementId_rightGripButton2 = 14;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public const int elementId_rightGripButton3 = 15;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const int elementId_rightGripButton4 = 16;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public const int elementId_rightGripButton5 = 17;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public const int elementId_rightGripButton6 = 18;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public const int elementId_centerButton1 = 19;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public const int elementId_centerButton2 = 20;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public const int elementId_centerButton3 = 21;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public const int elementId_centerButton4 = 22;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public const int elementId_centerButton5 = 23;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public const int elementId_centerButton6 = 24;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public const int elementId_centerButton7 = 25;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public const int elementId_centerButton8 = 26;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public const int elementId_wheel1Up = 53;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public const int elementId_wheel1Down = 54;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public const int elementId_wheel1Press = 55;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public const int elementId_wheel2Up = 56;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public const int elementId_wheel2Down = 57;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public const int elementId_wheel2Press = 58;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public const int elementId_leftGripHatUp = 27;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int elementId_leftGripHatUpRight = 28;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public const int elementId_leftGripHatRight = 29;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public const int elementId_leftGripHatDownRight = 30;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public const int elementId_leftGripHatDown = 31;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public const int elementId_leftGripHatDownLeft = 32;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public const int elementId_leftGripHatLeft = 33;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public const int elementId_leftGripHatUpLeft = 34;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public const int elementId_rightGripHatUp = 35;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public const int elementId_rightGripHatUpRight = 36;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public const int elementId_rightGripHatRight = 37;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public const int elementId_rightGripHatDownRight = 38;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public const int elementId_rightGripHatDown = 39;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public const int elementId_rightGripHatDownLeft = 40;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public const int elementId_rightGripHatLeft = 41;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public const int elementId_rightGripHatUpLeft = 42;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public const int elementId_consoleButton1 = 43;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public const int elementId_consoleButton2 = 44;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public const int elementId_consoleButton3 = 45;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public const int elementId_consoleButton4 = 46;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public const int elementId_consoleButton5 = 47;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public const int elementId_consoleButton6 = 48;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public const int elementId_consoleButton7 = 49;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public const int elementId_consoleButton8 = 50;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public const int elementId_consoleButton9 = 51;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public const int elementId_consoleButton10 = 52;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public const int elementId_mode1 = 61;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public const int elementId_mode2 = 62;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public const int elementId_mode3 = 63;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public const int elementId_yoke = 69;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public const int elementId_lever1 = 70;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public const int elementId_lever2 = 71;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public const int elementId_lever3 = 72;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public const int elementId_lever4 = 73;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public const int elementId_lever5 = 74;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public const int elementId_leftGripHat = 75;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public const int elementId_rightGripHat = 76;

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1E928E0", Offset = "0x1E912E0", VA = "0x181E928E0", Slot = "12")]
			get
			{
				return GetElement<IControllerTemplateButton>(59);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E92CE0", Offset = "0x1E916E0", VA = "0x181E92CE0", Slot = "13")]
			get
			{
				return GetElement<IControllerTemplateButton>(60);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E92720", Offset = "0x1E91120", VA = "0x181E92720", Slot = "14")]
			get
			{
				return GetElement<IControllerTemplateButton>(7);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1E92760", Offset = "0x1E91160", VA = "0x181E92760", Slot = "15")]
			get
			{
				return GetElement<IControllerTemplateButton>(8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1E927A0", Offset = "0x1E911A0", VA = "0x181E927A0", Slot = "16")]
			get
			{
				return GetElement<IControllerTemplateButton>(9);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1E927E0", Offset = "0x1E911E0", VA = "0x181E927E0", Slot = "17")]
			get
			{
				return GetElement<IControllerTemplateButton>(10);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1E92820", Offset = "0x1E91220", VA = "0x181E92820", Slot = "18")]
			get
			{
				return GetElement<IControllerTemplateButton>(11);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1E92860", Offset = "0x1E91260", VA = "0x181E92860", Slot = "19")]
			get
			{
				return GetElement<IControllerTemplateButton>(12);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1E92B20", Offset = "0x1E91520", VA = "0x181E92B20", Slot = "20")]
			get
			{
				return GetElement<IControllerTemplateButton>(13);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1E92B60", Offset = "0x1E91560", VA = "0x181E92B60", Slot = "21")]
			get
			{
				return GetElement<IControllerTemplateButton>(14);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1E92BA0", Offset = "0x1E915A0", VA = "0x181E92BA0", Slot = "22")]
			get
			{
				return GetElement<IControllerTemplateButton>(15);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1E92BE0", Offset = "0x1E915E0", VA = "0x181E92BE0", Slot = "23")]
			get
			{
				return GetElement<IControllerTemplateButton>(16);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1E92C20", Offset = "0x1E91620", VA = "0x181E92C20", Slot = "24")]
			get
			{
				return GetElement<IControllerTemplateButton>(17);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1E92C60", Offset = "0x1E91660", VA = "0x181E92C60", Slot = "25")]
			get
			{
				return GetElement<IControllerTemplateButton>(18);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		IControllerTemplateButton IFlightYokeTemplate.centerButton1
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1E922A0", Offset = "0x1E90CA0", VA = "0x181E922A0", Slot = "26")]
			get
			{
				return GetElement<IControllerTemplateButton>(19);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		IControllerTemplateButton IFlightYokeTemplate.centerButton2
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1E922E0", Offset = "0x1E90CE0", VA = "0x181E922E0", Slot = "27")]
			get
			{
				return GetElement<IControllerTemplateButton>(20);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		IControllerTemplateButton IFlightYokeTemplate.centerButton3
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1E92320", Offset = "0x1E90D20", VA = "0x181E92320", Slot = "28")]
			get
			{
				return GetElement<IControllerTemplateButton>(21);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		IControllerTemplateButton IFlightYokeTemplate.centerButton4
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1E92360", Offset = "0x1E90D60", VA = "0x181E92360", Slot = "29")]
			get
			{
				return GetElement<IControllerTemplateButton>(22);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		IControllerTemplateButton IFlightYokeTemplate.centerButton5
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1E923A0", Offset = "0x1E90DA0", VA = "0x181E923A0", Slot = "30")]
			get
			{
				return GetElement<IControllerTemplateButton>(23);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		IControllerTemplateButton IFlightYokeTemplate.centerButton6
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1E923E0", Offset = "0x1E90DE0", VA = "0x181E923E0", Slot = "31")]
			get
			{
				return GetElement<IControllerTemplateButton>(24);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		IControllerTemplateButton IFlightYokeTemplate.centerButton7
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1E92420", Offset = "0x1E90E20", VA = "0x181E92420", Slot = "32")]
			get
			{
				return GetElement<IControllerTemplateButton>(25);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		IControllerTemplateButton IFlightYokeTemplate.centerButton8
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1E92460", Offset = "0x1E90E60", VA = "0x181E92460", Slot = "33")]
			get
			{
				return GetElement<IControllerTemplateButton>(26);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1E92DA0", Offset = "0x1E917A0", VA = "0x181E92DA0", Slot = "34")]
			get
			{
				return GetElement<IControllerTemplateButton>(53);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1E92D20", Offset = "0x1E91720", VA = "0x181E92D20", Slot = "35")]
			get
			{
				return GetElement<IControllerTemplateButton>(54);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1E92D60", Offset = "0x1E91760", VA = "0x181E92D60", Slot = "36")]
			get
			{
				return GetElement<IControllerTemplateButton>(55);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1E92E60", Offset = "0x1E91860", VA = "0x181E92E60", Slot = "37")]
			get
			{
				return GetElement<IControllerTemplateButton>(56);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1E92DE0", Offset = "0x1E917E0", VA = "0x181E92DE0", Slot = "38")]
			get
			{
				return GetElement<IControllerTemplateButton>(57);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1E92E20", Offset = "0x1E91820", VA = "0x181E92E20", Slot = "39")]
			get
			{
				return GetElement<IControllerTemplateButton>(58);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1E924E0", Offset = "0x1E90EE0", VA = "0x181E924E0", Slot = "40")]
			get
			{
				return GetElement<IControllerTemplateButton>(43);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1E92520", Offset = "0x1E90F20", VA = "0x181E92520", Slot = "41")]
			get
			{
				return GetElement<IControllerTemplateButton>(44);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1E92560", Offset = "0x1E90F60", VA = "0x181E92560", Slot = "42")]
			get
			{
				return GetElement<IControllerTemplateButton>(45);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1E925A0", Offset = "0x1E90FA0", VA = "0x181E925A0", Slot = "43")]
			get
			{
				return GetElement<IControllerTemplateButton>(46);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1E925E0", Offset = "0x1E90FE0", VA = "0x181E925E0", Slot = "44")]
			get
			{
				return GetElement<IControllerTemplateButton>(47);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1E92620", Offset = "0x1E91020", VA = "0x181E92620", Slot = "45")]
			get
			{
				return GetElement<IControllerTemplateButton>(48);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1E92660", Offset = "0x1E91060", VA = "0x181E92660", Slot = "46")]
			get
			{
				return GetElement<IControllerTemplateButton>(49);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1E926A0", Offset = "0x1E910A0", VA = "0x181E926A0", Slot = "47")]
			get
			{
				return GetElement<IControllerTemplateButton>(50);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1E926E0", Offset = "0x1E910E0", VA = "0x181E926E0", Slot = "48")]
			get
			{
				return GetElement<IControllerTemplateButton>(51);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1E924A0", Offset = "0x1E90EA0", VA = "0x181E924A0", Slot = "49")]
			get
			{
				return GetElement<IControllerTemplateButton>(52);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		IControllerTemplateButton IFlightYokeTemplate.mode1
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1E92A60", Offset = "0x1E91460", VA = "0x181E92A60", Slot = "50")]
			get
			{
				return GetElement<IControllerTemplateButton>(61);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		IControllerTemplateButton IFlightYokeTemplate.mode2
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1E92AA0", Offset = "0x1E914A0", VA = "0x181E92AA0", Slot = "51")]
			get
			{
				return GetElement<IControllerTemplateButton>(62);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		IControllerTemplateButton IFlightYokeTemplate.mode3
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1E92AE0", Offset = "0x1E914E0", VA = "0x181E92AE0", Slot = "52")]
			get
			{
				return GetElement<IControllerTemplateButton>(63);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		IControllerTemplateYoke IFlightYokeTemplate.yoke
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1E92EA0", Offset = "0x1E918A0", VA = "0x181E92EA0", Slot = "53")]
			get
			{
				return GetElement<IControllerTemplateYoke>(69);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		IControllerTemplateThrottle IFlightYokeTemplate.lever1
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x1E92920", Offset = "0x1E91320", VA = "0x181E92920", Slot = "54")]
			get
			{
				return GetElement<IControllerTemplateThrottle>(70);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		IControllerTemplateThrottle IFlightYokeTemplate.lever2
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1E92960", Offset = "0x1E91360", VA = "0x181E92960", Slot = "55")]
			get
			{
				return GetElement<IControllerTemplateThrottle>(71);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		IControllerTemplateThrottle IFlightYokeTemplate.lever3
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x1E929A0", Offset = "0x1E913A0", VA = "0x181E929A0", Slot = "56")]
			get
			{
				return GetElement<IControllerTemplateThrottle>(72);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		IControllerTemplateThrottle IFlightYokeTemplate.lever4
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1E929E0", Offset = "0x1E913E0", VA = "0x181E929E0", Slot = "57")]
			get
			{
				return GetElement<IControllerTemplateThrottle>(73);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		IControllerTemplateThrottle IFlightYokeTemplate.lever5
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x1E92A20", Offset = "0x1E91420", VA = "0x181E92A20", Slot = "58")]
			get
			{
				return GetElement<IControllerTemplateThrottle>(74);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1E928A0", Offset = "0x1E912A0", VA = "0x181E928A0", Slot = "59")]
			get
			{
				return GetElement<IControllerTemplateHat>(75);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x1E92CA0", Offset = "0x1E916A0", VA = "0x181E92CA0", Slot = "60")]
			get
			{
				return GetElement<IControllerTemplateHat>(76);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1E92290", Offset = "0x1E90C90", VA = "0x181E92290")]
		public FlightYokeTemplate(object payload)
			: base(payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1E92EE0", Offset = "0x1E918E0", VA = "0x181E92EE0")]
		static FlightYokeTemplate()
		{
			int num = 0;
		}
	}
}
