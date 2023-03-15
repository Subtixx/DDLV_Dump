using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.EventConveyor;
using Gameloft.Tracking.Pipeline.Standard.Serialization;
using Gameloft.Tracking.Pipeline.Standard.Service;
using Gameloft.Tracking.Pipeline.Standard.Storage;
using Gameloft.Tracking.Scheduling;
using Serilog;

namespace Gameloft.Tracking.Pipeline.Standard
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class Options
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ConveyorOptions ConveyorOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CConveyorOptions_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CConveyorOptions_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new ConveyorOptions();


		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ExtendedStorageOptions StorageOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CStorageOptions_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CStorageOptions_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new ExtendedStorageOptions();


		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000006")]
		public ExtendedServiceOptions ServiceOptions
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		} = new ExtendedServiceOptions
		{
			DataFormat = SerializationFormat.Binary
		};


		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000007")]
		public SchedulerOptions SchedulerOptions
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		} = new SchedulerOptions();


		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LoggerConfiguration LoggerConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CLoggerConfig_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CLoggerConfig_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28C3BB0", Offset = "0x28C25B0", VA = "0x1828C3BB0")]
		public Options()
		{
		}//IL_0029: Expected I4, but got I8

	}
}
