using System;
using Cpp2IlInjected;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly Guid typeGuid;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public const int elementId_positionX = 1;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public const int elementId_positionY = 2;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public const int elementId_positionZ = 0;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public const int elementId_rotationX = 3;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int elementId_rotationY = 5;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const int elementId_rotationZ = 4;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const int elementId_throttle1Axis = 6;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public const int elementId_throttle1MinDetent = 50;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public const int elementId_throttle2Axis = 7;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public const int elementId_throttle2MinDetent = 51;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public const int elementId_extraAxis1 = 8;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public const int elementId_extraAxis2 = 9;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public const int elementId_extraAxis3 = 10;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public const int elementId_extraAxis4 = 11;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public const int elementId_button1 = 12;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public const int elementId_button2 = 13;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public const int elementId_button3 = 14;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public const int elementId_button4 = 15;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public const int elementId_button5 = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public const int elementId_button6 = 17;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public const int elementId_button7 = 18;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public const int elementId_button8 = 19;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public const int elementId_button9 = 20;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public const int elementId_button10 = 21;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public const int elementId_button11 = 22;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public const int elementId_button12 = 23;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public const int elementId_button13 = 24;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public const int elementId_button14 = 25;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public const int elementId_button15 = 26;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public const int elementId_button16 = 27;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public const int elementId_button17 = 28;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public const int elementId_button18 = 29;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public const int elementId_button19 = 30;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public const int elementId_button20 = 31;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public const int elementId_button21 = 55;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public const int elementId_button22 = 56;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public const int elementId_button23 = 57;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public const int elementId_button24 = 58;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public const int elementId_button25 = 59;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public const int elementId_button26 = 60;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public const int elementId_button27 = 61;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public const int elementId_button28 = 62;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public const int elementId_button29 = 63;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public const int elementId_button30 = 64;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public const int elementId_button31 = 65;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public const int elementId_button32 = 66;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public const int elementId_hat1Up = 32;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public const int elementId_hat1UpRight = 33;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public const int elementId_hat1Right = 34;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public const int elementId_hat1DownRight = 35;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public const int elementId_hat1Down = 36;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public const int elementId_hat1DownLeft = 37;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public const int elementId_hat1Left = 38;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public const int elementId_hat1UpLeft = 39;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public const int elementId_hat2Up = 40;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public const int elementId_hat2UpRight = 41;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public const int elementId_hat2Right = 42;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public const int elementId_hat2DownRight = 43;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public const int elementId_hat2Down = 44;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public const int elementId_hat2DownLeft = 45;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public const int elementId_hat2Left = 46;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public const int elementId_hat2UpLeft = 47;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public const int elementId_hat1 = 48;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public const int elementId_hat2 = 49;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public const int elementId_throttle1 = 52;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public const int elementId_throttle2 = 53;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public const int elementId_stick = 54;

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1B50", Offset = "0x1EA0550", VA = "0x181EA1B50", Slot = "12")]
			get
			{
				return GetElement<IControllerTemplateAxis>(8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1B90", Offset = "0x1EA0590", VA = "0x181EA1B90", Slot = "13")]
			get
			{
				return GetElement<IControllerTemplateAxis>(9);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1BD0", Offset = "0x1EA05D0", VA = "0x181EA1BD0", Slot = "14")]
			get
			{
				return GetElement<IControllerTemplateAxis>(10);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1C10", Offset = "0x1EA0610", VA = "0x181EA1C10", Slot = "15")]
			get
			{
				return GetElement<IControllerTemplateAxis>(11);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		IControllerTemplateButton ISixDofControllerTemplate.button1
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1EA15D0", Offset = "0x1E9FFD0", VA = "0x181EA15D0", Slot = "16")]
			get
			{
				return GetElement<IControllerTemplateButton>(12);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		IControllerTemplateButton ISixDofControllerTemplate.button2
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1890", Offset = "0x1EA0290", VA = "0x181EA1890", Slot = "17")]
			get
			{
				return GetElement<IControllerTemplateButton>(13);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		IControllerTemplateButton ISixDofControllerTemplate.button3
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1990", Offset = "0x1EA0390", VA = "0x181EA1990", Slot = "18")]
			get
			{
				return GetElement<IControllerTemplateButton>(14);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		IControllerTemplateButton ISixDofControllerTemplate.button4
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x1EA19D0", Offset = "0x1EA03D0", VA = "0x181EA19D0", Slot = "19")]
			get
			{
				return GetElement<IControllerTemplateButton>(15);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		IControllerTemplateButton ISixDofControllerTemplate.button5
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1A10", Offset = "0x1EA0410", VA = "0x181EA1A10", Slot = "20")]
			get
			{
				return GetElement<IControllerTemplateButton>(16);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		IControllerTemplateButton ISixDofControllerTemplate.button6
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1A50", Offset = "0x1EA0450", VA = "0x181EA1A50", Slot = "21")]
			get
			{
				return GetElement<IControllerTemplateButton>(17);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		IControllerTemplateButton ISixDofControllerTemplate.button7
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1A90", Offset = "0x1EA0490", VA = "0x181EA1A90", Slot = "22")]
			get
			{
				return GetElement<IControllerTemplateButton>(18);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		IControllerTemplateButton ISixDofControllerTemplate.button8
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1AD0", Offset = "0x1EA04D0", VA = "0x181EA1AD0", Slot = "23")]
			get
			{
				return GetElement<IControllerTemplateButton>(19);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		IControllerTemplateButton ISixDofControllerTemplate.button9
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1B10", Offset = "0x1EA0510", VA = "0x181EA1B10", Slot = "24")]
			get
			{
				return GetElement<IControllerTemplateButton>(20);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		IControllerTemplateButton ISixDofControllerTemplate.button10
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1350", Offset = "0x1E9FD50", VA = "0x181EA1350", Slot = "25")]
			get
			{
				return GetElement<IControllerTemplateButton>(21);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		IControllerTemplateButton ISixDofControllerTemplate.button11
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1390", Offset = "0x1E9FD90", VA = "0x181EA1390", Slot = "26")]
			get
			{
				return GetElement<IControllerTemplateButton>(22);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		IControllerTemplateButton ISixDofControllerTemplate.button12
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1EA13D0", Offset = "0x1E9FDD0", VA = "0x181EA13D0", Slot = "27")]
			get
			{
				return GetElement<IControllerTemplateButton>(23);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		IControllerTemplateButton ISixDofControllerTemplate.button13
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1410", Offset = "0x1E9FE10", VA = "0x181EA1410", Slot = "28")]
			get
			{
				return GetElement<IControllerTemplateButton>(24);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		IControllerTemplateButton ISixDofControllerTemplate.button14
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1450", Offset = "0x1E9FE50", VA = "0x181EA1450", Slot = "29")]
			get
			{
				return GetElement<IControllerTemplateButton>(25);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		IControllerTemplateButton ISixDofControllerTemplate.button15
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1490", Offset = "0x1E9FE90", VA = "0x181EA1490", Slot = "30")]
			get
			{
				return GetElement<IControllerTemplateButton>(26);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		IControllerTemplateButton ISixDofControllerTemplate.button16
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1EA14D0", Offset = "0x1E9FED0", VA = "0x181EA14D0", Slot = "31")]
			get
			{
				return GetElement<IControllerTemplateButton>(27);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		IControllerTemplateButton ISixDofControllerTemplate.button17
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1510", Offset = "0x1E9FF10", VA = "0x181EA1510", Slot = "32")]
			get
			{
				return GetElement<IControllerTemplateButton>(28);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		IControllerTemplateButton ISixDofControllerTemplate.button18
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1550", Offset = "0x1E9FF50", VA = "0x181EA1550", Slot = "33")]
			get
			{
				return GetElement<IControllerTemplateButton>(29);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		IControllerTemplateButton ISixDofControllerTemplate.button19
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1590", Offset = "0x1E9FF90", VA = "0x181EA1590", Slot = "34")]
			get
			{
				return GetElement<IControllerTemplateButton>(30);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		IControllerTemplateButton ISixDofControllerTemplate.button20
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1610", Offset = "0x1EA0010", VA = "0x181EA1610", Slot = "35")]
			get
			{
				return GetElement<IControllerTemplateButton>(31);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		IControllerTemplateButton ISixDofControllerTemplate.button21
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1650", Offset = "0x1EA0050", VA = "0x181EA1650", Slot = "36")]
			get
			{
				return GetElement<IControllerTemplateButton>(55);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		IControllerTemplateButton ISixDofControllerTemplate.button22
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1690", Offset = "0x1EA0090", VA = "0x181EA1690", Slot = "37")]
			get
			{
				return GetElement<IControllerTemplateButton>(56);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		IControllerTemplateButton ISixDofControllerTemplate.button23
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1EA16D0", Offset = "0x1EA00D0", VA = "0x181EA16D0", Slot = "38")]
			get
			{
				return GetElement<IControllerTemplateButton>(57);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		IControllerTemplateButton ISixDofControllerTemplate.button24
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1710", Offset = "0x1EA0110", VA = "0x181EA1710", Slot = "39")]
			get
			{
				return GetElement<IControllerTemplateButton>(58);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		IControllerTemplateButton ISixDofControllerTemplate.button25
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1750", Offset = "0x1EA0150", VA = "0x181EA1750", Slot = "40")]
			get
			{
				return GetElement<IControllerTemplateButton>(59);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		IControllerTemplateButton ISixDofControllerTemplate.button26
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1790", Offset = "0x1EA0190", VA = "0x181EA1790", Slot = "41")]
			get
			{
				return GetElement<IControllerTemplateButton>(60);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		IControllerTemplateButton ISixDofControllerTemplate.button27
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1EA17D0", Offset = "0x1EA01D0", VA = "0x181EA17D0", Slot = "42")]
			get
			{
				return GetElement<IControllerTemplateButton>(61);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		IControllerTemplateButton ISixDofControllerTemplate.button28
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1810", Offset = "0x1EA0210", VA = "0x181EA1810", Slot = "43")]
			get
			{
				return GetElement<IControllerTemplateButton>(62);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		IControllerTemplateButton ISixDofControllerTemplate.button29
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1850", Offset = "0x1EA0250", VA = "0x181EA1850", Slot = "44")]
			get
			{
				return GetElement<IControllerTemplateButton>(63);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		IControllerTemplateButton ISixDofControllerTemplate.button30
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1EA18D0", Offset = "0x1EA02D0", VA = "0x181EA18D0", Slot = "45")]
			get
			{
				return GetElement<IControllerTemplateButton>(64);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		IControllerTemplateButton ISixDofControllerTemplate.button31
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1910", Offset = "0x1EA0310", VA = "0x181EA1910", Slot = "46")]
			get
			{
				return GetElement<IControllerTemplateButton>(65);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		IControllerTemplateButton ISixDofControllerTemplate.button32
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1950", Offset = "0x1EA0350", VA = "0x181EA1950", Slot = "47")]
			get
			{
				return GetElement<IControllerTemplateButton>(66);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		IControllerTemplateHat ISixDofControllerTemplate.hat1
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1C50", Offset = "0x1EA0650", VA = "0x181EA1C50", Slot = "48")]
			get
			{
				return GetElement<IControllerTemplateHat>(48);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		IControllerTemplateHat ISixDofControllerTemplate.hat2
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1C90", Offset = "0x1EA0690", VA = "0x181EA1C90", Slot = "49")]
			get
			{
				return GetElement<IControllerTemplateHat>(49);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1D10", Offset = "0x1EA0710", VA = "0x181EA1D10", Slot = "50")]
			get
			{
				return GetElement<IControllerTemplateThrottle>(52);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1D50", Offset = "0x1EA0750", VA = "0x181EA1D50", Slot = "51")]
			get
			{
				return GetElement<IControllerTemplateThrottle>(53);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		IControllerTemplateStick6D ISixDofControllerTemplate.stick
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1EA1CD0", Offset = "0x1EA06D0", VA = "0x181EA1CD0", Slot = "52")]
			get
			{
				return GetElement<IControllerTemplateStick6D>(54);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1E92290", Offset = "0x1E90C90", VA = "0x181E92290")]
		public SixDofControllerTemplate(object payload)
			: base(payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1D90", Offset = "0x1EA0790", VA = "0x181EA1D90")]
		static SixDofControllerTemplate()
		{
			int num = 0;
		}
	}
}
