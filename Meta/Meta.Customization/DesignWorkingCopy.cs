using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf.Collections;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010EE")]
	public class DesignWorkingCopy
	{
		[Cpp2IlInjected.Token(Token = "0x1700180A")]
		public Design Data
		{
			[Cpp2IlInjected.Token(Token = "0x60089CE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60089CF")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700180B")]
		public IReadOnlyList<IDecal> Decals
		{
			[Cpp2IlInjected.Token(Token = "0x60089D0")]
			[Cpp2IlInjected.Address(RVA = "0x1A2AA80", Offset = "0x1A29480", VA = "0x181A2AA80")]
			get
			{
				RepeatedField<Decal> decals_ = Data.decals_;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700180C")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60089D1")]
			[Cpp2IlInjected.Address(RVA = "0x1A2AAA0", Offset = "0x1A294A0", VA = "0x181A2AAA0")]
			get
			{
				//Discarded unreachable code: IL_0023
				Design design = Data;
				if (((RepeatedField<T>)(object)design.decals_).Count != 0)
				{
					int num = 0;
				}
				return string.IsNullOrEmpty(design.baseColor_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089D2")]
		[Cpp2IlInjected.Address(RVA = "0x1A2AA30", Offset = "0x1A29430", VA = "0x181A2AA30")]
		public DesignWorkingCopy(DesignWorkingCopy source)
		{
			Design design = (Data = source.Data.Clone());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089D3")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A930", Offset = "0x1A29330", VA = "0x181A2A930")]
		public DesignWorkingCopy(IDesign source)
		{
			Design design = default(Design);
			Data = design;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089D4")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A9B0", Offset = "0x1A293B0", VA = "0x181A2A9B0")]
		public DesignWorkingCopy()
		{
			//Discarded unreachable code: IL_0029
			//IL_0028: Expected I4, but got I8
			Design design = (Data = new Design());
			Data.id_ = -1;
		}
	}
}
