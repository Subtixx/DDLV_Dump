using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class NumberHandlers
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		private class IntHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x1700012A")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x60004F8")]
				[Cpp2IlInjected.Address(RVA = "0xCCE5F0", Offset = "0xCCCFF0", VA = "0x180CCE5F0", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700012B")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x60004F9")]
				[Cpp2IlInjected.Address(RVA = "0xCCE5E0", Offset = "0xCCCFE0", VA = "0x180CCE5E0", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0xCCE4C0", Offset = "0xCCCEC0", VA = "0x180CCE4C0", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0xCCE540", Offset = "0xCCCF40", VA = "0x180CCE540", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0009
				object obj = default(object);
				return "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" == obj;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0xCCE410", Offset = "0xCCCE10", VA = "0x180CCE410", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(int).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0xCCE460", Offset = "0xCCCE60", VA = "0x180CCE460", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public IntHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		private class UIntHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x1700012C")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(RVA = "0xCCDB60", Offset = "0xCCC560", VA = "0x180CCDB60", Slot = "4")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700012D")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000500")]
				[Cpp2IlInjected.Address(RVA = "0xCE0950", Offset = "0xCDF350", VA = "0x180CE0950", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0xCE0830", Offset = "0xCDF230", VA = "0x180CE0830", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0xCE08B0", Offset = "0xCDF2B0", VA = "0x180CE08B0", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0009
				object obj = default(object);
				return "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" == obj;
			}

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0xCE0770", Offset = "0xCDF170", VA = "0x180CE0770", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(uint).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0xCE07C0", Offset = "0xCDF1C0", VA = "0x180CE07C0", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public UIntHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		private class LongHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x1700012E")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0xCCE7E0", Offset = "0xCCD1E0", VA = "0x180CCE7E0", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700012F")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000507")]
				[Cpp2IlInjected.Address(RVA = "0xCCE7D0", Offset = "0xCCD1D0", VA = "0x180CCE7D0", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0xCCE6B0", Offset = "0xCCD0B0", VA = "0x180CCE6B0", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xCCE730", Offset = "0xCCD130", VA = "0x180CCE730", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0009
				object obj = default(object);
				return "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" == obj;
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0xCCE600", Offset = "0xCCD000", VA = "0x180CCE600", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(long).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0xCCE650", Offset = "0xCCD050", VA = "0x180CCE650", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public LongHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		private class ULongHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x17000130")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0xCCDB60", Offset = "0xCCC560", VA = "0x180CCDB60", Slot = "4")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000131")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0xCE0B90", Offset = "0xCDF590", VA = "0x180CE0B90", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0xCE0A70", Offset = "0xCDF470", VA = "0x180CE0A70", Slot = "6")]
			public unsafe bool TryParse(string input, out object value)
			{
				ulong num = default(ulong);
				return ulong.TryParse(input, out *(ulong*)num);
			}

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0xCE0AF0", Offset = "0xCDF4F0", VA = "0x180CE0AF0", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0009
				object obj = default(object);
				return "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" == obj;
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0xCE0960", Offset = "0xCDF360", VA = "0x180CE0960", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				int num = 0;
				if (!(value >= 9.223372E+18f))
				{
				}
				return typeof(ulong).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0xCE09E0", Offset = "0xCDF3E0", VA = "0x180CE09E0", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ULongHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		private class ByteHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x17000132")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000514")]
				[Cpp2IlInjected.Address(RVA = "0xCCDB60", Offset = "0xCCC560", VA = "0x180CCDB60", Slot = "4")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000133")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000515")]
				[Cpp2IlInjected.Address(RVA = "0xCCDB50", Offset = "0xCCC550", VA = "0x180CCDB50", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0xCCDA30", Offset = "0xCCC430", VA = "0x180CCDA30", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0xCCDAB0", Offset = "0xCCC4B0", VA = "0x180CCDAB0", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0009
				object obj = default(object);
				return "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" == obj;
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0xCCD970", Offset = "0xCCC370", VA = "0x180CCD970", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(byte).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0xCCD9C0", Offset = "0xCCC3C0", VA = "0x180CCD9C0", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ByteHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		private class SByteHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x17000134")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x600051B")]
				[Cpp2IlInjected.Address(RVA = "0xCCEB40", Offset = "0xCCD540", VA = "0x180CCEB40", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000135")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0xCCEB30", Offset = "0xCCD530", VA = "0x180CCEB30", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0xCCEA10", Offset = "0xCCD410", VA = "0x180CCEA10", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0xCCEA90", Offset = "0xCCD490", VA = "0x180CCEA90", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0009
				object obj = default(object);
				return "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" == obj;
			}

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0xCCE950", Offset = "0xCCD350", VA = "0x180CCE950", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(sbyte).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0xCCE9A0", Offset = "0xCCD3A0", VA = "0x180CCE9A0", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SByteHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		private class ShortHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x17000136")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xCCED40", Offset = "0xCCD740", VA = "0x180CCED40", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000137")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0xCCED30", Offset = "0xCCD730", VA = "0x180CCED30", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xCCEC10", Offset = "0xCCD610", VA = "0x180CCEC10", Slot = "6")]
			public unsafe bool TryParse(string input, out object value)
			{
				int num = 0;
				return short.TryParse(input, out *(short*)num);
			}

			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0xCCEC90", Offset = "0xCCD690", VA = "0x180CCEC90", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0009
				object obj = default(object);
				return "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" == obj;
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0xCCEB50", Offset = "0xCCD550", VA = "0x180CCEB50", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(short).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xCCEBA0", Offset = "0xCCD5A0", VA = "0x180CCEBA0", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ShortHandler()
			{
				((ArraySegment<T>.ArraySegmentEnumerator)this).Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		private class UShortHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x17000138")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000529")]
				[Cpp2IlInjected.Address(RVA = "0xCCDB60", Offset = "0xCCC560", VA = "0x180CCDB60", Slot = "4")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000139")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0xCCDD70", Offset = "0xCCC770", VA = "0x180CCDD70", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0xCE0C60", Offset = "0xCDF660", VA = "0x180CE0C60", Slot = "6")]
			public unsafe bool TryParse(string input, out object value)
			{
				int num = 0;
				return ushort.TryParse(input, out *(ushort*)num);
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0xCE0CE0", Offset = "0xCDF6E0", VA = "0x180CE0CE0", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0009
				object obj = default(object);
				return "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" == obj;
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xCE0BA0", Offset = "0xCDF5A0", VA = "0x180CE0BA0", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(ushort).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0xCE0BF0", Offset = "0xCDF5F0", VA = "0x180CE0BF0", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public UShortHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		private class CharHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x1700013A")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000530")]
				[Cpp2IlInjected.Address(RVA = "0xCCDB60", Offset = "0xCCC560", VA = "0x180CCDB60", Slot = "4")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000531")]
				[Cpp2IlInjected.Address(RVA = "0xCCDD70", Offset = "0xCCC770", VA = "0x180CCDD70", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0xCCDC30", Offset = "0xCCC630", VA = "0x180CCDC30", Slot = "6")]
			public unsafe bool TryParse(string input, out object value)
			{
				int num = 0;
				return char.TryParse(input, out *(char*)num);
			}

			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0xCCDCD0", Offset = "0xCCC6D0", VA = "0x180CCDCD0", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0009
				object obj = default(object);
				return "{il2cpp field on {'constant8' (constant value of type Cpp2IL.Core.Analysis.ResultModels.LocalPointer)}, offset 0x0}" == obj;
			}

			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0xCCDB70", Offset = "0xCCC570", VA = "0x180CCDB70", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(char).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0xCCDBC0", Offset = "0xCCC5C0", VA = "0x180CCDBC0", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public CharHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		private class FloatHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x1700013C")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(RVA = "0xCCE010", Offset = "0xCCCA10", VA = "0x180CCE010", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013D")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0xCCE000", Offset = "0xCCCA00", VA = "0x180CCE000", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0xCCE2D0", Offset = "0xCCCCD0", VA = "0x180CCE2D0", Slot = "6")]
			public unsafe bool TryParse(string input, out object value)
			{
				int num = 0;
				return float.TryParse(input, out *(float*)num);
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0xCCE360", Offset = "0xCCCD60", VA = "0x180CCE360", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0002
				return true;
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xCCE220", Offset = "0xCCCC20", VA = "0x180CCE220", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(float).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0xCCE270", Offset = "0xCCCC70", VA = "0x180CCE270", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public FloatHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		private class DoubleHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x1700013E")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0xCCE010", Offset = "0xCCCA10", VA = "0x180CCE010", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013F")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0xCCE000", Offset = "0xCCCA00", VA = "0x180CCE000", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xCCE0D0", Offset = "0xCCCAD0", VA = "0x180CCE0D0", Slot = "6")]
			public bool TryParse(string input, out object value)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0xCCE170", Offset = "0xCCCB70", VA = "0x180CCE170", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0002
				return true;
			}

			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0xCCE020", Offset = "0xCCCA20", VA = "0x180CCE020", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				return typeof(double).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0xCCE070", Offset = "0xCCCA70", VA = "0x180CCE070", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000544")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public DoubleHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		private class DecimalHandler : INumberHandler
		{
			[Cpp2IlInjected.Token(Token = "0x17000140")]
			public float MinValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0xCCE010", Offset = "0xCCCA10", VA = "0x180CCE010", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000141")]
			public float MaxValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0xCCE000", Offset = "0xCCCA00", VA = "0x180CCE000", Slot = "5")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xCCDE90", Offset = "0xCCC890", VA = "0x180CCDE90", Slot = "6")]
			public unsafe bool TryParse(string input, out object value)
			{
				int num = 0;
				return decimal.TryParse(input, out *(decimal*)num);
			}

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xCCDF30", Offset = "0xCCC930", VA = "0x180CCDF30", Slot = "7")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				//Discarded unreachable code: IL_0002
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0xCCDD80", Offset = "0xCCC780", VA = "0x180CCDD80", Slot = "8")]
			public object ConvertFromFloat(float value)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0xCCDE00", Offset = "0xCCC800", VA = "0x180CCDE00", Slot = "9")]
			public float ConvertToFloat(object value)
			{
				//Discarded unreachable code: IL_0002
				float result = default(float);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public DecimalHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private static readonly Dictionary<Type, INumberHandler> handlers;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x12A15D0", Offset = "0x129FFD0", VA = "0x1812A15D0")]
		public static INumberHandler Get(Type type)
		{
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				Type typeFromHandle = typeof(int);
				if (!((object)type).Equals((object)typeFromHandle))
				{
					Type typeFromHandle2 = typeof(float);
					if (!((object)type).Equals((object)typeFromHandle2))
					{
						Type typeFromHandle3 = typeof(long);
						if (!((object)type).Equals((object)typeFromHandle3))
						{
							Type typeFromHandle4 = typeof(double);
							if (!((object)type).Equals((object)typeFromHandle4))
							{
								Type typeFromHandle5 = typeof(byte);
								if (!((object)type).Equals((object)typeFromHandle5))
								{
									Type typeFromHandle6 = typeof(char);
									if (!((object)type).Equals((object)typeFromHandle6))
									{
										Type typeFromHandle7 = typeof(short);
										if (!((object)type).Equals((object)typeFromHandle7))
										{
											Type typeFromHandle8 = typeof(uint);
											if (!((object)type).Equals((object)typeFromHandle8))
											{
												Type typeFromHandle9 = typeof(ulong);
												if (!((object)type).Equals((object)typeFromHandle9))
												{
													Type typeFromHandle10 = typeof(sbyte);
													if (!((object)type).Equals((object)typeFromHandle10))
													{
														Type typeFromHandle11 = typeof(ushort);
														if (!((object)type).Equals((object)typeFromHandle11))
														{
															Type typeFromHandle12 = typeof(decimal);
															if (!((object)type).Equals((object)typeFromHandle12))
															{
																goto IL_0185;
															}
															DecimalHandler decimalHandler = new DecimalHandler();
														}
														UShortHandler uShortHandler = new UShortHandler();
													}
													SByteHandler sByteHandler = new SByteHandler();
												}
												ULongHandler uLongHandler = new ULongHandler();
											}
											UIntHandler uIntHandler = new UIntHandler();
										}
										ShortHandler shortHandler = new ShortHandler();
									}
									CharHandler charHandler = new CharHandler();
								}
								ByteHandler byteHandler = new ByteHandler();
							}
							DoubleHandler doubleHandler = new DoubleHandler();
						}
						LongHandler longHandler = new LongHandler();
					}
					FloatHandler floatHandler = new FloatHandler();
				}
				IntHandler intHandler = new IntHandler();
				goto IL_0185;
			}
			throw new NullReferenceException();
			IL_0185:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public NumberHandlers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x12A1CA0", Offset = "0x12A06A0", VA = "0x1812A1CA0")]
		static NumberHandlers()
		{
			Dictionary<Type, INumberHandler> dictionary = (Dictionary<Type, INumberHandler>)(object)new Dictionary<TKey, TValue>(16);
			/*Error: Unexpected end of block*/;
		}
	}
}
