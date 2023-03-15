using System;
using Cpp2IlInjected;

namespace Rewired.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class ControllerTemplateFactory
	{
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private static readonly Type[] _defaultTemplateTypes;

		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private static readonly Type[] _defaultTemplateInterfaceTypes;

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		public static Type[] templateTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x1E91220", Offset = "0x1E8FC20", VA = "0x181E91220")]
			get
			{
				return _defaultTemplateTypes;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		public static Type[] templateInterfaceTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x1E911C0", Offset = "0x1E8FBC0", VA = "0x181E911C0")]
			get
			{
				return _defaultTemplateInterfaceTypes;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x1E907D0", Offset = "0x1E8F1D0", VA = "0x181E907D0")]
		public static IControllerTemplate Create(Guid typeGuid, object payload)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			if (flag || flag2 || flag3 || flag4 || flag5 || !flag6)
			{
			}
			GamepadTemplate gamepadTemplate = new GamepadTemplate(payload);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1E90B70", Offset = "0x1E8F570", VA = "0x181E90B70")]
		static ControllerTemplateFactory()
		{
			Type[] array2;
			Type typeFromHandle12;
			while (true)
			{
				Type[] array = new Type[6];
				Type typeFromHandle = typeof(GamepadTemplate);
				if ((object)typeFromHandle != null && (object)typeFromHandle == null)
				{
					continue;
				}
				array[0] = typeFromHandle;
				Type typeFromHandle2 = typeof(RacingWheelTemplate);
				if ((object)typeFromHandle2 != null && (object)typeFromHandle2 == null)
				{
					continue;
				}
				array[1] = typeFromHandle2;
				Type typeFromHandle3 = typeof(HOTASTemplate);
				if ((object)typeFromHandle3 != null && (object)typeFromHandle3 == null)
				{
					continue;
				}
				array[2] = typeFromHandle3;
				Type typeFromHandle4 = typeof(FlightYokeTemplate);
				if ((object)typeFromHandle4 != null && (object)typeFromHandle4 == null)
				{
					continue;
				}
				array[3] = typeFromHandle4;
				Type typeFromHandle5 = typeof(FlightPedalsTemplate);
				if ((object)typeFromHandle5 != null && (object)typeFromHandle5 == null)
				{
					continue;
				}
				array[4] = typeFromHandle5;
				Type typeFromHandle6 = typeof(SixDofControllerTemplate);
				if ((object)typeFromHandle6 != null && (object)typeFromHandle6 == null)
				{
					continue;
				}
				array[5] = typeFromHandle6;
				_defaultTemplateTypes = array;
				array2 = new Type[6];
				Type typeFromHandle7 = typeof(IGamepadTemplate);
				if ((object)typeFromHandle7 != null && (object)typeFromHandle7 == null)
				{
					continue;
				}
				array2[0] = typeFromHandle7;
				Type typeFromHandle8 = typeof(IRacingWheelTemplate);
				if ((object)typeFromHandle8 != null && (object)typeFromHandle8 == null)
				{
					continue;
				}
				array2[1] = typeFromHandle8;
				Type typeFromHandle9 = typeof(IHOTASTemplate);
				if ((object)typeFromHandle9 != null && (object)typeFromHandle9 == null)
				{
					continue;
				}
				array2[2] = typeFromHandle9;
				Type typeFromHandle10 = typeof(IFlightYokeTemplate);
				if ((object)typeFromHandle10 != null && (object)typeFromHandle10 == null)
				{
					continue;
				}
				array2[3] = typeFromHandle10;
				Type typeFromHandle11 = typeof(IFlightPedalsTemplate);
				if ((object)typeFromHandle11 == null || (object)typeFromHandle11 != null)
				{
					array2[4] = typeFromHandle11;
					typeFromHandle12 = typeof(ISixDofControllerTemplate);
					if ((object)typeFromHandle12 == null || (object)typeFromHandle12 != null)
					{
						break;
					}
				}
			}
			array2[5] = typeFromHandle12;
			_defaultTemplateTypes = array2;
			throw new NullReferenceException();
		}
	}
}
