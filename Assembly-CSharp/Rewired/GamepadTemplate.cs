using System;
using Cpp2IlInjected;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly Guid typeGuid;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const int elementId_leftStickX = 0;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const int elementId_leftStickY = 1;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const int elementId_rightStickX = 2;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const int elementId_rightStickY = 3;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const int elementId_actionBottomRow1 = 4;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int elementId_a = 4;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const int elementId_actionBottomRow2 = 5;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const int elementId_b = 5;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const int elementId_actionBottomRow3 = 6;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const int elementId_c = 6;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public const int elementId_actionTopRow1 = 7;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public const int elementId_x = 7;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const int elementId_actionTopRow2 = 8;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int elementId_y = 8;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public const int elementId_actionTopRow3 = 9;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const int elementId_z = 9;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public const int elementId_leftShoulder1 = 10;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public const int elementId_leftBumper = 10;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public const int elementId_leftShoulder2 = 11;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public const int elementId_leftTrigger = 11;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public const int elementId_rightShoulder1 = 12;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public const int elementId_rightBumper = 12;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public const int elementId_rightShoulder2 = 13;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public const int elementId_rightTrigger = 13;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const int elementId_center1 = 14;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public const int elementId_back = 14;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public const int elementId_center2 = 15;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public const int elementId_start = 15;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const int elementId_center3 = 16;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public const int elementId_guide = 16;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public const int elementId_leftStickButton = 17;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public const int elementId_rightStickButton = 18;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public const int elementId_dPadUp = 19;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public const int elementId_dPadRight = 20;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public const int elementId_dPadDown = 21;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public const int elementId_dPadLeft = 22;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public const int elementId_leftStick = 23;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public const int elementId_rightStick = 24;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public const int elementId_dPad = 25;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x1E92F90", Offset = "0x1E91990", VA = "0x181E92F90", Slot = "12")]
			get
			{
				return GetElement<IControllerTemplateButton>(4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		IControllerTemplateButton IGamepadTemplate.a
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x1E92F50", Offset = "0x1E91950", VA = "0x181E92F50", Slot = "13")]
			get
			{
				return GetElement<IControllerTemplateButton>(4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x1E92FD0", Offset = "0x1E919D0", VA = "0x181E92FD0", Slot = "14")]
			get
			{
				return GetElement<IControllerTemplateButton>(5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		IControllerTemplateButton IGamepadTemplate.b
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x1E93110", Offset = "0x1E91B10", VA = "0x181E93110", Slot = "15")]
			get
			{
				return GetElement<IControllerTemplateButton>(5);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x1E93010", Offset = "0x1E91A10", VA = "0x181E93010", Slot = "16")]
			get
			{
				return GetElement<IControllerTemplateButton>(6);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		IControllerTemplateButton IGamepadTemplate.c
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x1E93190", Offset = "0x1E91B90", VA = "0x181E93190", Slot = "17")]
			get
			{
				return GetElement<IControllerTemplateButton>(6);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		IControllerTemplateButton IGamepadTemplate.actionTopRow1
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x1E93050", Offset = "0x1E91A50", VA = "0x181E93050", Slot = "18")]
			get
			{
				return GetElement<IControllerTemplateButton>(7);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		IControllerTemplateButton IGamepadTemplate.x
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x1E935D0", Offset = "0x1E91FD0", VA = "0x181E935D0", Slot = "19")]
			get
			{
				return GetElement<IControllerTemplateButton>(7);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		IControllerTemplateButton IGamepadTemplate.actionTopRow2
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x1E93090", Offset = "0x1E91A90", VA = "0x181E93090", Slot = "20")]
			get
			{
				return GetElement<IControllerTemplateButton>(8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		IControllerTemplateButton IGamepadTemplate.y
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x1E93610", Offset = "0x1E92010", VA = "0x181E93610", Slot = "21")]
			get
			{
				return GetElement<IControllerTemplateButton>(8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		IControllerTemplateButton IGamepadTemplate.actionTopRow3
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x1E930D0", Offset = "0x1E91AD0", VA = "0x181E930D0", Slot = "22")]
			get
			{
				return GetElement<IControllerTemplateButton>(9);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		IControllerTemplateButton IGamepadTemplate.z
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x1E93650", Offset = "0x1E92050", VA = "0x181E93650", Slot = "23")]
			get
			{
				return GetElement<IControllerTemplateButton>(9);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		IControllerTemplateButton IGamepadTemplate.leftShoulder1
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x1E93350", Offset = "0x1E91D50", VA = "0x181E93350", Slot = "24")]
			get
			{
				return GetElement<IControllerTemplateButton>(10);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		IControllerTemplateButton IGamepadTemplate.leftBumper
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x1E93310", Offset = "0x1E91D10", VA = "0x181E93310", Slot = "25")]
			get
			{
				return GetElement<IControllerTemplateButton>(10);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x1E93390", Offset = "0x1E91D90", VA = "0x181E93390", Slot = "26")]
			get
			{
				return GetElement<IControllerTemplateAxis>(11);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		IControllerTemplateAxis IGamepadTemplate.leftTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x1E93410", Offset = "0x1E91E10", VA = "0x181E93410", Slot = "27")]
			get
			{
				return GetElement<IControllerTemplateAxis>(11);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		IControllerTemplateButton IGamepadTemplate.rightShoulder1
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x1E93490", Offset = "0x1E91E90", VA = "0x181E93490", Slot = "28")]
			get
			{
				return GetElement<IControllerTemplateButton>(12);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		IControllerTemplateButton IGamepadTemplate.rightBumper
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x1E93450", Offset = "0x1E91E50", VA = "0x181E93450", Slot = "29")]
			get
			{
				return GetElement<IControllerTemplateButton>(12);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x1E934D0", Offset = "0x1E91ED0", VA = "0x181E934D0", Slot = "30")]
			get
			{
				return GetElement<IControllerTemplateAxis>(13);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		IControllerTemplateAxis IGamepadTemplate.rightTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x1E93550", Offset = "0x1E91F50", VA = "0x181E93550", Slot = "31")]
			get
			{
				return GetElement<IControllerTemplateAxis>(13);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		IControllerTemplateButton IGamepadTemplate.center1
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x1E931D0", Offset = "0x1E91BD0", VA = "0x181E931D0", Slot = "32")]
			get
			{
				return GetElement<IControllerTemplateButton>(14);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		IControllerTemplateButton IGamepadTemplate.back
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1E93150", Offset = "0x1E91B50", VA = "0x181E93150", Slot = "33")]
			get
			{
				return GetElement<IControllerTemplateButton>(14);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		IControllerTemplateButton IGamepadTemplate.center2
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x1E93210", Offset = "0x1E91C10", VA = "0x181E93210", Slot = "34")]
			get
			{
				return GetElement<IControllerTemplateButton>(15);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		IControllerTemplateButton IGamepadTemplate.start
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x1E93590", Offset = "0x1E91F90", VA = "0x181E93590", Slot = "35")]
			get
			{
				return GetElement<IControllerTemplateButton>(15);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		IControllerTemplateButton IGamepadTemplate.center3
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x1E93250", Offset = "0x1E91C50", VA = "0x181E93250", Slot = "36")]
			get
			{
				return GetElement<IControllerTemplateButton>(16);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		IControllerTemplateButton IGamepadTemplate.guide
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x1E932D0", Offset = "0x1E91CD0", VA = "0x181E932D0", Slot = "37")]
			get
			{
				return GetElement<IControllerTemplateButton>(16);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		IControllerTemplateThumbStick IGamepadTemplate.leftStick
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x1E933D0", Offset = "0x1E91DD0", VA = "0x181E933D0", Slot = "38")]
			get
			{
				return GetElement<IControllerTemplateThumbStick>(23);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		IControllerTemplateThumbStick IGamepadTemplate.rightStick
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x1E93510", Offset = "0x1E91F10", VA = "0x181E93510", Slot = "39")]
			get
			{
				return GetElement<IControllerTemplateThumbStick>(24);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		IControllerTemplateDPad IGamepadTemplate.dPad
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x1E93290", Offset = "0x1E91C90", VA = "0x181E93290", Slot = "40")]
			get
			{
				return GetElement<IControllerTemplateDPad>(25);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1E92290", Offset = "0x1E90C90", VA = "0x181E92290")]
		public GamepadTemplate(object payload)
			: base(payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1E93690", Offset = "0x1E92090", VA = "0x181E93690")]
		static GamepadTemplate()
		{
			int num = 0;
		}
	}
}
