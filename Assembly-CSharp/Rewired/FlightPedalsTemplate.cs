using System;
using Cpp2IlInjected;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public static readonly Guid typeGuid;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public const int elementId_leftPedal = 0;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public const int elementId_rightPedal = 1;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public const int elementId_slide = 2;

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1E92160", Offset = "0x1E90B60", VA = "0x181E92160", Slot = "12")]
			get
			{
				int id = 0;
				return GetElement<IControllerTemplateAxis>(id);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1E921A0", Offset = "0x1E90BA0", VA = "0x181E921A0", Slot = "13")]
			get
			{
				return GetElement<IControllerTemplateAxis>(1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		IControllerTemplateAxis IFlightPedalsTemplate.slide
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x1E921E0", Offset = "0x1E90BE0", VA = "0x181E921E0", Slot = "14")]
			get
			{
				return GetElement<IControllerTemplateAxis>(2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1E92290", Offset = "0x1E90C90", VA = "0x181E92290")]
		public FlightPedalsTemplate(object payload)
			: base(payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1E92220", Offset = "0x1E90C20", VA = "0x181E92220")]
		static FlightPedalsTemplate()
		{
			int num = 0;
		}
	}
}
