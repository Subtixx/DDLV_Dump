using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Mdl.Platform;
using Mdl.Systems;
using Meta.Util;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DeviceManager
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class GraphicsQualityProfile : ProfileGroup
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1196130", Offset = "0x1194B30", VA = "0x181196130")]
		public GraphicsQualityProfile(string name)
			: base(name)
		{
			//IL_0084: Expected I4, but got O
			DeviceManager singleton = _singleton;
			ParseableProfileGroup _003CProcessorCount_003Ek__BackingField = singleton.ProcessorCount;
			ParseableProfileGroup _003CGraphicsDevice_003Ek__BackingField = singleton.GraphicsDevice;
			ParseableProfileGroup _003CProcessorFrequency_003Ek__BackingField = singleton.ProcessorFrequency;
			ParseableProfileGroup _003CGraphicsMemory_003Ek__BackingField = singleton.GraphicsMemory;
			ParseableProfileGroup _003CSystemMemory_003Ek__BackingField = singleton.SystemMemory;
			ParseableProfileGroup _003CProcessorType_003Ek__BackingField = singleton.ProcessorType;
			if (((ProfileGroup)_003CProcessorCount_003Ek__BackingField).profileEnum != ProfileEnum.Unknown)
			{
			}
			if (((ProfileGroup)_003CProcessorFrequency_003Ek__BackingField).profileEnum != ProfileEnum.Unknown)
			{
			}
			if (((ProfileGroup)_003CGraphicsMemory_003Ek__BackingField).profileEnum != ProfileEnum.Unknown)
			{
			}
			if (((ProfileGroup)_003CSystemMemory_003Ek__BackingField).profileEnum != ProfileEnum.Unknown)
			{
			}
			if (((ProfileGroup)_003CProcessorType_003Ek__BackingField).profileEnum != ProfileEnum.Unknown)
			{
			}
			ProfileEnum profileEnum = ((ProfileGroup)_003CGraphicsDevice_003Ek__BackingField).profileEnum;
			if (profileEnum == ProfileEnum.Unknown)
			{
				base.profileEnum = (ProfileEnum)_003CProcessorCount_003Ek__BackingField;
				return;
			}
			int num = (int)profileEnum;
			base.profileEnum = ProfileEnum.UltraLow;
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum Specs
	{
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		DeviceModel,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		GraphicsDeviceVendor,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		GraphicsDeviceName,
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		GraphicsDeviceVersion,
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		GraphicsShaderLevel,
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		SystemMemorySize,
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		GraphicsMemorySize,
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		ProcessorType,
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		ProcessorFrequency,
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		ProcessorCount,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		GpuVariantSeries,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		GpuVariantSeriesId,
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		GpuVariantSeriesSuffix,
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		GpuVariantModel,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		GpuVariantModelMajorPrefix,
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		GpuVariantModelMajorNumber,
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		GpuVariantModelMajorSuffix,
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		GpuVariantModelMinorPrefix,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		GpuVariantModelMinorNumber,
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		GpuVariantModelMinorSuffix,
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		CpuVariantSeries,
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		CpuVariantSeriesId,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		CpuVariantModel,
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		CpuVariantModelMajorPrefix,
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		CpuVariantModelMajorNumber,
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		CpuVariantModelMajorSuffix,
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		CpuVariantModelMinorPrefix,
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		CpuVariantModelMinorNumber,
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		CpuVariantModelMinorSuffix,
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class UnionValue<T1, T2>
	{
		[Cpp2IlInjected.Token(Token = "0x17000064")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x4000247")]
		public T1 t1
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x4000248")]
		public T2 t2
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x4000249")]
		public Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x383D130", Offset = "0x383BB30", VA = "0x18383D130")]
		public UnionValue(T1 t)
		{
			((UnionValue<, >)(object)this).t1 = t;
			Type type = default(Type);
			((UnionValue<, >)(object)this).Type = type;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x383D080", Offset = "0x383BA80", VA = "0x18383D080")]
		public UnionValue(T2 t)
		{
			((UnionValue<, >)(object)this).t2 = t;
			Type type = default(Type);
			((UnionValue<, >)(object)this).Type = type;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x383D350", Offset = "0x383BD50", VA = "0x18383D350")]
		public static implicit operator UnionValue<T1, T2>(T1 t)
		{
			return new UnionValue<T1, T2>(t);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x383D280", Offset = "0x383BC80", VA = "0x18383D280")]
		public static implicit operator UnionValue<T1, T2>(T2 t)
		{
			return new UnionValue<T1, T2>(t);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x383CFA0", Offset = "0x383B9A0", VA = "0x18383CFA0")]
		public void GetValue(out T1 t)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x383CF60", Offset = "0x383B960", VA = "0x18383CF60")]
		public void GetValue(out T2 t)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class UnionArray<T1, T2>
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public T1[] ArrayT1
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public T2[] ArrayT2
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x400024C")]
		public Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x383CCD0", Offset = "0x383B6D0", VA = "0x18383CCD0")]
		public UnionArray(T1[] da)
		{
			((UnionArray<, >)(object)this).ArrayT1 = da;
			Type type = default(Type);
			((UnionArray<, >)(object)this).Type = type;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x383C650", Offset = "0x383B050", VA = "0x18383C650")]
		public UnionArray(T2[] da)
		{
			((UnionArray<, >)(object)this).ArrayT2 = da;
			Type type = default(Type);
			((UnionArray<, >)(object)this).Type = type;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x383C9F0", Offset = "0x383B3F0", VA = "0x18383C9F0")]
		public UnionArray(T1 t)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x383CB00", Offset = "0x383B500", VA = "0x18383CB00")]
		public UnionArray(T2 t)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x383C5D0", Offset = "0x383AFD0", VA = "0x18383C5D0")]
		public void GetValue(out T1[] t)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x383C610", Offset = "0x383B010", VA = "0x18383C610")]
		public void GetValue(out T2[] t)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class UnionList<T1, T2>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x400024D")]
		public List<T1> ListT1
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x400024E")]
		public List<T2> ListT2
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x400024F")]
		public Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x383CEB0", Offset = "0x383B8B0", VA = "0x18383CEB0")]
		public UnionList(List<T1> l)
		{
			((UnionList<, >)(object)this).ListT1 = l;
			Type type = default(Type);
			((UnionList<, >)(object)this).Type = type;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x383CE00", Offset = "0x383B800", VA = "0x18383CE00")]
		public UnionList(List<T2> l)
		{
			((UnionList<, >)(object)this).ListT2 = l;
			Type type = default(Type);
			((UnionList<, >)(object)this).Type = type;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x383CD80", Offset = "0x383B780", VA = "0x18383CD80")]
		public unsafe void GetValue(out List<T1> t)
		{
			//IL_000e: Expected O, but got Ref
			List<> list = (List<>)(object)(((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref t))._items = (T[])(object)this.get_ListT1());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x383CDC0", Offset = "0x383B7C0", VA = "0x18383CDC0")]
		public unsafe void GetValue(out List<T2> t)
		{
			//IL_000e: Expected O, but got Ref
			List<> list = (List<>)(object)(((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref t))._items = (T[])(object)this.get_ListT2());
			throw new NullReferenceException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class SpecValueType
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000250")]
		public Specs Spec
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public UnionValue<int, string> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CValue_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1197390", Offset = "0x1195D90", VA = "0x181197390")]
			get
			{
				UnionValue<int, string> unionValue = Value;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1197320", Offset = "0x1195D20", VA = "0x181197320")]
		public SpecValueType(Specs s, int v)
		{
			//IL_0015: Expected O, but got I4
			Spec = s;
			UnionValue<, > unionValue = (UnionValue<, >)(object)(Value = (UnionValue<int, string>)(object)UnionValue<T1, T2>.op_Implicit((T1)v));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x11972B0", Offset = "0x1195CB0", VA = "0x1811972B0")]
		public SpecValueType(Specs s, string v)
		{
			Spec = s;
			UnionValue<, > unionValue = (UnionValue<, >)(object)(Value = (UnionValue<int, string>)(object)UnionValue<T1, T2>.op_Implicit((T2)v));
			/*Error: Unexpected end of block*/;
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class Rule
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class Constraint : ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x2000062")]
			public enum Operator
			{
				[Cpp2IlInjected.Token(Token = "0x400025A")]
				Ignore,
				[Cpp2IlInjected.Token(Token = "0x400025B")]
				Always,
				[Cpp2IlInjected.Token(Token = "0x400025C")]
				Never,
				[Cpp2IlInjected.Token(Token = "0x400025D")]
				Equal,
				[Cpp2IlInjected.Token(Token = "0x400025E")]
				EqualList,
				[Cpp2IlInjected.Token(Token = "0x400025F")]
				NotEqual,
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				NotEqualList,
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				Contain,
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				ContainList,
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				NotContain,
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				NotContainList,
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				Less,
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				LessEqual,
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				Greater,
				[Cpp2IlInjected.Token(Token = "0x4000268")]
				GreaterEqual
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			public class ValueArray : UnionArray<int, string>
			{
				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x19444B0", Offset = "0x1942EB0", VA = "0x1819444B0")]
				public ValueArray(int[] da)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x1944410", Offset = "0x1942E10", VA = "0x181944410")]
				public ValueArray(string[] da)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x1944460", Offset = "0x1942E60", VA = "0x181944460")]
				public ValueArray(int t)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x19443C0", Offset = "0x1942DC0", VA = "0x1819443C0")]
				public ValueArray(string t)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			[SerializeField]
			private string spec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			[SerializeField]
			private string op;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			[SerializeField]
			private string[] values;

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public Specs Spec
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				[CompilerGenerated]
				get
				{
					return default(Specs);
				}
				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public Operator Op
			{
				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
				[CompilerGenerated]
				get
				{
					return default(Operator);
				}
				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public ValueArray Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x12C3480", Offset = "0x12C1E80", VA = "0x1812C3480")]
			public Constraint(Specs s, Operator o, int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x12C33F0", Offset = "0x12C1DF0", VA = "0x1812C33F0")]
			public Constraint(Specs s, Operator o, string v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x12C3360", Offset = "0x12C1D60", VA = "0x1812C3360")]
			public Constraint(Specs s, Operator o, int[] v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x12C32D0", Offset = "0x12C1CD0", VA = "0x1812C32D0")]
			public Constraint(Specs s, Operator o, string[] v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x12C1990", Offset = "0x12C0390", VA = "0x1812C1990")]
			private Result Execute(string[] sl)
			{
				return default(Result);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x12C2700", Offset = "0x12C1100", VA = "0x1812C2700")]
			private Result Execute(int[] vl)
			{
				return default(Result);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x12C1D80", Offset = "0x12C0780", VA = "0x1812C1D80")]
			public Result Execute()
			{
				return default(Result);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x12C2F70", Offset = "0x12C1970", VA = "0x1812C2F70", Slot = "4")]
			public void OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x12C29E0", Offset = "0x12C13E0", VA = "0x1812C29E0", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public enum Result
		{
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			False,
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			True,
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			Ignore,
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			Error
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		[SerializeField]
		private List<Constraint> constraints;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private List<Constraint> ConstraintList
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get
			{
				return constraints;
			}
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			set
			{
				constraints = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public Rule(List<Constraint> cl)
		{
			constraints = cl;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1195C00", VA = "0x181197200")]
		public Rule(Constraint c)
		{
			//Discarded unreachable code: IL_0020
			List<Constraint> list = (constraints = (List<Constraint>)(object)new List<T>());
			((List<T>)(object)constraints).Add((T)c);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x1197140", Offset = "0x1195B40", VA = "0x181197140")]
		public bool Execute()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ProfileGroup
	{
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public static readonly string[] ProfileEnumString = Enum.GetNames(typeof(ProfileEnum));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		protected ProfileEnum profileEnum = ProfileEnum.Unknown;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000274")]
		protected string profileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		} = "";


		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public ProfileEnum Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get
			{
				return profileEnum;
			}
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			protected set
			{
				profileEnum = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string ProfileStr
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x11970B0", Offset = "0x1195AB0", VA = "0x1811970B0")]
			get
			{
				//Discarded unreachable code: IL_0015
				string[] profileEnumString = ProfileEnumString;
				ProfileEnum profileEnum = this.profileEnum;
				return profileEnumString[(int)profileEnum];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1197030", Offset = "0x1195A30", VA = "0x181197030")]
		public ProfileGroup(string name)
		{
			//IL_000a: Expected I4, but got I8
			profileName = name;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1196F70", Offset = "0x1195970", VA = "0x181196F70")]
		static ProfileGroup()
		{
			/*Error: Unexpected end of block*/;
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class ParseableProfileGroupSerializationFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		[SerializeField]
		private List<ParseableProfileGroup.ExecutionGroupL1> execution;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x11966A0", Offset = "0x11950A0", VA = "0x1811966A0")]
		public ParseableProfileGroup Create(string name)
		{
			List<ParseableProfileGroup.ExecutionGroupL1> list = execution;
			Func<ParseableProfileGroup.ExecutionGroupL1, ParseableProfileGroup.ExecutionGroup> _003C_003E9__1_ = _003C_003Ec._003C_003E9__1_0;
			if (_003C_003E9__1_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ParseableProfileGroup.ExecutionGroupL1 x) => null);
			}
			List<ParseableProfileGroup.ExecutionGroup> _003CExecutionGroupList_003Ek__BackingField = (List<ParseableProfileGroup.ExecutionGroup>)(object)Enumerable.ToList<ParseableProfileGroup.ExecutionGroup>(Enumerable.Select<ParseableProfileGroup.ExecutionGroupL1, ParseableProfileGroup.ExecutionGroup>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__1_));
			ParseableProfileGroup parseableProfileGroup = new ParseableProfileGroup(name);
			parseableProfileGroup.ExecutionGroupList = _003CExecutionGroupList_003Ek__BackingField;
			parseableProfileGroup.Execute();
			return parseableProfileGroup;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ParseableProfileGroupSerializationFactory()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ParseableProfileGroup : ProfileGroup
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public class RuleToProfile : ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			[SerializeField]
			private Rule rule;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400027A")]
			[SerializeField]
			private string profile;

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public Rule R
			{
				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public ProfileEnum P
			{
				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
				[CompilerGenerated]
				get
				{
					return default(ProfileEnum);
				}
				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x12C59A0", Offset = "0x12C43A0", VA = "0x1812C59A0")]
			public RuleToProfile(Rule r, ProfileEnum p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x12C5910", Offset = "0x12C4310", VA = "0x1812C5910")]
			public RuleToProfile(Rule.Constraint c, ProfileEnum p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x12C5800", Offset = "0x12C4200", VA = "0x1812C5800")]
			public RuleToProfile(Rule.Constraint c1, Rule.Constraint c2, ProfileEnum p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x12C5700", Offset = "0x12C4100", VA = "0x1812C5700", Slot = "4")]
			public void OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x12C5580", Offset = "0x12C3F80", VA = "0x1812C5580", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public class ExecutionGroupL1 : ExecutionGroup, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			[SerializeField]
			public List<Rule> rules;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400027D")]
			[SerializeField]
			public List<ExecutionGroupL2> group;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400027E")]
			[SerializeField]
			public List<RuleToProfile> unit;

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected ExecutionGroupL1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x12C3750", Offset = "0x12C2150", VA = "0x1812C3750", Slot = "4")]
			public void OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x12C3510", Offset = "0x12C1F10", VA = "0x1812C3510", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public class ExecutionGroupL2 : ExecutionGroup, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000282")]
			[SerializeField]
			public List<Rule> rules;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000283")]
			[SerializeField]
			public List<ExecutionGroupL3> group;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000284")]
			[SerializeField]
			public List<RuleToProfile> unit;

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected ExecutionGroupL2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x12C3C50", Offset = "0x12C2650", VA = "0x1812C3C50", Slot = "4")]
			public void OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x12C3A10", Offset = "0x12C2410", VA = "0x1812C3A10", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public class ExecutionGroupL3 : ExecutionGroup, ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			[SerializeField]
			public List<Rule> rules;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			[SerializeField]
			public List<RuleToProfile> unit;

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected ExecutionGroupL3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x12C3FD0", Offset = "0x12C29D0", VA = "0x1812C3FD0", Slot = "4")]
			public void OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x12C3F10", Offset = "0x12C2910", VA = "0x1812C3F10", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public class ExecutionGroup
		{
			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public List<Rule> RuleList
			{
				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public UnionList<ExecutionGroup, RuleToProfile> ExecutionGroupList
			{
				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected ExecutionGroup()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x12C4570", Offset = "0x12C2F70", VA = "0x1812C4570")]
			public ExecutionGroup(List<ExecutionGroup> eg)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x12C44D0", Offset = "0x12C2ED0", VA = "0x1812C44D0")]
			public ExecutionGroup(List<Rule> rl, List<ExecutionGroup> eg)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x12C4600", Offset = "0x12C3000", VA = "0x1812C4600")]
			public ExecutionGroup(List<RuleToProfile> el)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x12C4430", Offset = "0x12C2E30", VA = "0x1812C4430")]
			public ExecutionGroup(List<Rule> rl, List<RuleToProfile> el)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x12C40D0", Offset = "0x12C2AD0", VA = "0x1812C40D0")]
			public bool Execute(ref RuleToProfile result)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public List<ExecutionGroup> ExecutionGroupList
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CExecutionGroupList_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			protected set
			{
				_003CExecutionGroupList_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1196EC0", Offset = "0x11958C0", VA = "0x181196EC0")]
		public ParseableProfileGroup(string name)
			: base(name)
		{
			List<ExecutionGroup> list = (ExecutionGroupList = (List<ExecutionGroup>)(object)new List<T>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1196DA0", Offset = "0x11957A0", VA = "0x181196DA0")]
		public ParseableProfileGroup(string name, List<RuleToProfile> el)
			: base(name)
		{
			//Discarded unreachable code: IL_0030
			List<ExecutionGroup> list = (ExecutionGroupList = (List<ExecutionGroup>)(object)new List<T>());
			List<ExecutionGroup> list2 = ExecutionGroupList;
			ExecutionGroup item = new ExecutionGroup((List<>)(object)el);
			((List<T>)(object)list2).Add((T)item);
			Execute();
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1196D10", Offset = "0x1195710", VA = "0x181196D10")]
		public ParseableProfileGroup(string name, List<ExecutionGroup> egl)
			: base(name)
		{
			ExecutionGroupList = egl;
			Execute();
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1196870", Offset = "0x1195270", VA = "0x181196870")]
		public void Execute()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum GpuVariantSeriesEnum
	{
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		Adreno,
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		AMD,
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		Apple,
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		Intel,
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		Mali,
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		NVIDIA
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public enum CpuVariantSeriesEnum
	{
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		AMD,
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		Intel
	}

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static DeviceManager _singleton;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public ParseableProfileGroup SystemMemory
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
		[CompilerGenerated]
		get
		{
			return _003CSystemMemory_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
		[CompilerGenerated]
		private set
		{
			_003CSystemMemory_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ParseableProfileGroup GraphicsMemory
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
		[CompilerGenerated]
		get
		{
			return _003CGraphicsMemory_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
		[CompilerGenerated]
		private set
		{
			_003CGraphicsMemory_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ParseableProfileGroup ProcessorType
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
		[CompilerGenerated]
		get
		{
			return _003CProcessorType_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
		[CompilerGenerated]
		private set
		{
			_003CProcessorType_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public ParseableProfileGroup ProcessorFrequency
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
		[CompilerGenerated]
		get
		{
			return _003CProcessorFrequency_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
		[CompilerGenerated]
		private set
		{
			_003CProcessorFrequency_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public ParseableProfileGroup ProcessorCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
		[CompilerGenerated]
		get
		{
			return _003CProcessorCount_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
		[CompilerGenerated]
		private set
		{
			_003CProcessorCount_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public ParseableProfileGroup GraphicsDevice
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
		[CompilerGenerated]
		get
		{
			return _003CGraphicsDevice_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
		[CompilerGenerated]
		private set
		{
			_003CGraphicsDevice_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public GraphicsQualityProfile GraphicsQuality
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
		[CompilerGenerated]
		get
		{
			return _003CGraphicsQuality_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
		[CompilerGenerated]
		private set
		{
			_003CGraphicsQuality_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static DeviceManager Singleton
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x162EAB0", Offset = "0x162D4B0", VA = "0x18162EAB0")]
		get
		{
			return _singleton;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4000212")]
	public SpecValueType[] SpecValueTypeMap
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[field: Cpp2IlInjected.Token(Token = "0x4000213")]
	public static bool Ready
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x162EA50", Offset = "0x162D450", VA = "0x18162EA50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x162EB10", Offset = "0x162D510", VA = "0x18162EB10")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4000214")]
	public GpuVariantSeriesEnum GpuVariantSeriesId
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string GpuVariantSeries
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
		[CompilerGenerated]
		get
		{
			return _003CGpuVariantSeries_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
		[CompilerGenerated]
		private set
		{
			_003CGpuVariantSeries_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string GpuVariantSeriesSuffix
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
		[CompilerGenerated]
		get
		{
			return _003CGpuVariantSeriesSuffix_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
		[CompilerGenerated]
		private set
		{
			_003CGpuVariantSeriesSuffix_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public string GpuVariantModel
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
		[CompilerGenerated]
		get
		{
			return _003CGpuVariantModel_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
		[CompilerGenerated]
		private set
		{
			_003CGpuVariantModel_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public string GpuVariantModelMajorPrefix
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
		[CompilerGenerated]
		get
		{
			return _003CGpuVariantModelMajorPrefix_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
		[CompilerGenerated]
		private set
		{
			_003CGpuVariantModelMajorPrefix_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x78"), Cpp2IlInjected.Token(Token = "0x4000219")]
	public int GpuVariantModelMajorNumber
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string GpuVariantModelMajorSuffix
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
		[CompilerGenerated]
		get
		{
			return _003CGpuVariantModelMajorSuffix_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
		[CompilerGenerated]
		private set
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public string GpuVariantModelMinorPrefix
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
		[CompilerGenerated]
		get
		{
			return _003CGpuVariantModelMinorPrefix_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7DB490", Offset = "0x7D9E90", VA = "0x1807DB490")]
		[CompilerGenerated]
		private set
		{
			_003CGpuVariantModelMinorPrefix_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x90"), Cpp2IlInjected.Token(Token = "0x400021C")]
	public int GpuVariantModelMinorNumber
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x725190", Offset = "0x723B90", VA = "0x180725190")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x725370", Offset = "0x723D70", VA = "0x180725370")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string GpuVariantModelMinorSuffix
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
		[CompilerGenerated]
		get
		{
			return _003CGpuVariantModelMinorSuffix_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
		[CompilerGenerated]
		private set
		{
			_003CGpuVariantModelMinorSuffix_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0xA0"), Cpp2IlInjected.Token(Token = "0x400021E")]
	public CpuVariantSeriesEnum CpuVariantSeriesId
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x975DB0", Offset = "0x9747B0", VA = "0x180975DB0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x974F80", VA = "0x180976580")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string CpuVariantSeries
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
		[CompilerGenerated]
		get
		{
			return _003CCpuVariantSeries_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA5ACE0", Offset = "0xA596E0", VA = "0x180A5ACE0")]
		[CompilerGenerated]
		private set
		{
			_003CCpuVariantSeries_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string CpuVariantModel
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
		[CompilerGenerated]
		get
		{
			return _003CCpuVariantModel_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
		[CompilerGenerated]
		private set
		{
			_003CCpuVariantModel_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string CpuVariantModelMajorPrefix
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
		[CompilerGenerated]
		get
		{
			return _003CCpuVariantModelMajorPrefix_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9766B0", Offset = "0x9750B0", VA = "0x1809766B0")]
		[CompilerGenerated]
		private set
		{
			_003CCpuVariantModelMajorPrefix_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0xC0"), Cpp2IlInjected.Token(Token = "0x4000222")]
	public int CpuVariantModelMajorNumber
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x148A150", Offset = "0x1488B50", VA = "0x18148A150")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x148A410", Offset = "0x1488E10", VA = "0x18148A410")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string CpuVariantModelMajorSuffix
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x738F90", Offset = "0x737990", VA = "0x180738F90")]
		[CompilerGenerated]
		get
		{
			return _003CCpuVariantModelMajorSuffix_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x11049F0", Offset = "0x11033F0", VA = "0x1811049F0")]
		[CompilerGenerated]
		private set
		{
			_003CCpuVariantModelMajorSuffix_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string CpuVariantModelMinorPrefix
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x88B0D0", Offset = "0x889AD0", VA = "0x18088B0D0")]
		[CompilerGenerated]
		get
		{
			return _003CCpuVariantModelMinorPrefix_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x976600", Offset = "0x975000", VA = "0x180976600")]
		[CompilerGenerated]
		private set
		{
			_003CCpuVariantModelMinorPrefix_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0xD8"), Cpp2IlInjected.Token(Token = "0x4000225")]
	public int CpuVariantModelMinorNumber
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1406560", Offset = "0x1404F60", VA = "0x181406560")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x14066E0", Offset = "0x14050E0", VA = "0x1814066E0")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public string CpuVariantModelMinorSuffix
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
		[CompilerGenerated]
		get
		{
			return _003CCpuVariantModelMinorSuffix_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
		[CompilerGenerated]
		private set
		{
			_003CCpuVariantModelMinorSuffix_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0xE8"), Cpp2IlInjected.Token(Token = "0x4000227")]
	public int NumLowMemoryCounter
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xFF9FC0", Offset = "0xFF89C0", VA = "0x180FF9FC0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xFFA200", Offset = "0xFF8C00", VA = "0x180FFA200")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1629E30", Offset = "0x1628830", VA = "0x181629E30")]
	private List<ParseableProfileGroup.RuleToProfile> CreateSystemMemoryExecutionList()
	{
		//Discarded unreachable code: IL_00d8
		List<ParseableProfileGroup.RuleToProfile> list = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
		Rule.Constraint c = new Rule.Constraint(Specs.SystemMemorySize, Rule.Constraint.Operator.Less, 4500);
		int num = 0;
		ParseableProfileGroup.RuleToProfile item = new ParseableProfileGroup.RuleToProfile(c, ProfileEnum.UltraLow);
		((List<T>)(object)list).Add((T)item);
		ParseableProfileGroup.RuleToProfile item2 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.SystemMemorySize, Rule.Constraint.Operator.Less, 5500), ProfileEnum.VeryLow);
		((List<T>)(object)list).Add((T)item2);
		ParseableProfileGroup.RuleToProfile item3 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.SystemMemorySize, Rule.Constraint.Operator.Less, 6500), ProfileEnum.Low);
		((List<T>)(object)list).Add((T)item3);
		ParseableProfileGroup.RuleToProfile item4 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.SystemMemorySize, Rule.Constraint.Operator.Less, 8500), ProfileEnum.Medium);
		((List<T>)(object)list).Add((T)item4);
		ParseableProfileGroup.RuleToProfile item5 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.SystemMemorySize, Rule.Constraint.Operator.Less, 16000), ProfileEnum.High);
		((List<T>)(object)list).Add((T)item5);
		ParseableProfileGroup.RuleToProfile item6 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.SystemMemorySize, Rule.Constraint.Operator.Less, 32000), ProfileEnum.VeryHigh);
		((List<T>)(object)list).Add((T)item6);
		int v = default(int);
		Rule.Constraint c2 = new Rule.Constraint(Specs.SystemMemorySize, Rule.Constraint.Operator.Always, v);
		v = 0;
		ParseableProfileGroup.RuleToProfile item7 = new ParseableProfileGroup.RuleToProfile(c2, ProfileEnum.UltraHigh);
		((List<T>)(object)list).Add((T)item7);
		return list;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x16284A0", Offset = "0x1626EA0", VA = "0x1816284A0")]
	private List<ParseableProfileGroup.RuleToProfile> CreateGraphicsMemoryExecutionList()
	{
		//Discarded unreachable code: IL_00d8
		List<ParseableProfileGroup.RuleToProfile> list = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
		Rule.Constraint c = new Rule.Constraint(Specs.GraphicsMemorySize, Rule.Constraint.Operator.Less, 2500);
		int num = 0;
		ParseableProfileGroup.RuleToProfile item = new ParseableProfileGroup.RuleToProfile(c, ProfileEnum.UltraLow);
		((List<T>)(object)list).Add((T)item);
		ParseableProfileGroup.RuleToProfile item2 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GraphicsMemorySize, Rule.Constraint.Operator.Less, 3000), ProfileEnum.VeryLow);
		((List<T>)(object)list).Add((T)item2);
		ParseableProfileGroup.RuleToProfile item3 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GraphicsMemorySize, Rule.Constraint.Operator.Less, 3500), ProfileEnum.Low);
		((List<T>)(object)list).Add((T)item3);
		ParseableProfileGroup.RuleToProfile item4 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GraphicsMemorySize, Rule.Constraint.Operator.Less, 4000), ProfileEnum.Medium);
		((List<T>)(object)list).Add((T)item4);
		ParseableProfileGroup.RuleToProfile item5 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GraphicsMemorySize, Rule.Constraint.Operator.Less, 6000), ProfileEnum.High);
		((List<T>)(object)list).Add((T)item5);
		ParseableProfileGroup.RuleToProfile item6 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GraphicsMemorySize, Rule.Constraint.Operator.Less, 8000), ProfileEnum.VeryHigh);
		((List<T>)(object)list).Add((T)item6);
		int v = default(int);
		Rule.Constraint c2 = new Rule.Constraint(Specs.GraphicsMemorySize, Rule.Constraint.Operator.Always, v);
		v = 0;
		ParseableProfileGroup.RuleToProfile item7 = new ParseableProfileGroup.RuleToProfile(c2, ProfileEnum.UltraHigh);
		((List<T>)(object)list).Add((T)item7);
		return list;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1628E20", Offset = "0x1627820", VA = "0x181628E20")]
	private static List<ParseableProfileGroup.ExecutionGroup> CreateProcessorTypeExecutionList()
	{
		//Discarded unreachable code: IL_020b
		//IL_001c: Expected O, but got I4
		List<ParseableProfileGroup.ExecutionGroup> list;
		List<Rule> list2;
		CpuVariantSeriesEnum cpuVariantSeriesEnum = default(CpuVariantSeriesEnum);
		List<ParseableProfileGroup.ExecutionGroup> list3;
		Rule.Constraint c2 = default(Rule.Constraint);
		Rule.Constraint c3 = default(Rule.Constraint);
		Rule.Constraint c4 = default(Rule.Constraint);
		List<ParseableProfileGroup.RuleToProfile> list6;
		List<Rule> list7;
		string[] array2;
		while (true)
		{
			list = (List<ParseableProfileGroup.ExecutionGroup>)(object)new List<T>();
			list2 = (List<Rule>)(object)new List<T>();
			string name = Enum.GetName(typeof(CpuVariantSeriesEnum), cpuVariantSeriesEnum);
			Rule.Constraint c = new Rule.Constraint(Specs.CpuVariantSeriesId, Rule.Constraint.Operator.Equal, name);
			int num = 0;
			Rule item = new Rule(c);
			((List<T>)(object)list2).Add((T)item);
			list3 = (List<ParseableProfileGroup.ExecutionGroup>)(object)new List<T>();
			List<ParseableProfileGroup.RuleToProfile> list4 = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
			List<Rule> list5 = (List<Rule>)(object)new List<T>();
			string[] array = new string[0];
			if ("I" != null && array == null)
			{
				continue;
			}
			array[0] = "I";
			if ("i" != null && "i" == null)
			{
				continue;
			}
			array[1] = "i";
			Rule item2 = new Rule(c2);
			((List<T>)(object)list5).Add((T)item2);
			ParseableProfileGroup.RuleToProfile item3 = new ParseableProfileGroup.RuleToProfile(c3, c4, ProfileEnum.VeryLow);
			((List<T>)(object)list4).Add((T)item3);
			Rule.Constraint c5 = new Rule.Constraint(Specs.CpuVariantModelMajorNumber, Rule.Constraint.Operator.Less, 4);
			int num2 = 0;
			ParseableProfileGroup.RuleToProfile item4 = new ParseableProfileGroup.RuleToProfile(c5, ProfileEnum.Low);
			((List<T>)(object)list4).Add((T)item4);
			ParseableProfileGroup.RuleToProfile item5 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.CpuVariantModelMajorNumber, Rule.Constraint.Operator.Less, 6), ProfileEnum.Medium);
			((List<T>)(object)list4).Add((T)item5);
			ParseableProfileGroup.RuleToProfile item6 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.CpuVariantModelMajorNumber, Rule.Constraint.Operator.Less, 8), ProfileEnum.High);
			((List<T>)(object)list4).Add((T)item6);
			ParseableProfileGroup.RuleToProfile item7 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.CpuVariantModelMajorNumber, Rule.Constraint.Operator.Less, 10), ProfileEnum.UltraHigh);
			((List<T>)(object)list4).Add((T)item7);
			ParseableProfileGroup.ExecutionGroup item8 = new ParseableProfileGroup.ExecutionGroup((List<>)(object)list5, (List<>)(object)list4);
			((List<T>)(object)list3).Add((T)item8);
			list6 = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
			list7 = (List<Rule>)(object)new List<T>();
			array2 = new string[0];
			if ("E" == null || array2 != null)
			{
				array2[0] = "E";
				if ("e" == null || "e" != null)
				{
					break;
				}
			}
		}
		array2[1] = "e";
		Rule.Constraint c6 = default(Rule.Constraint);
		Rule item9 = new Rule(c6);
		((List<T>)(object)list7).Add((T)item9);
		Rule.Constraint c7 = default(Rule.Constraint);
		ParseableProfileGroup.RuleToProfile item10 = new ParseableProfileGroup.RuleToProfile(c7, ProfileEnum.High);
		((List<T>)(object)list6).Add((T)item10);
		Rule.Constraint c8 = default(Rule.Constraint);
		ParseableProfileGroup.RuleToProfile item11 = new ParseableProfileGroup.RuleToProfile(c8, ProfileEnum.VeryHigh);
		((List<T>)(object)list6).Add((T)item11);
		Rule.Constraint c9 = default(Rule.Constraint);
		ParseableProfileGroup.RuleToProfile item12 = new ParseableProfileGroup.RuleToProfile(c9, ProfileEnum.UltraHigh);
		((List<T>)(object)list6).Add((T)item12);
		ParseableProfileGroup.ExecutionGroup item13 = new ParseableProfileGroup.ExecutionGroup((List<>)(object)list7, (List<>)(object)list6);
		((List<T>)(object)list3).Add((T)item13);
		ParseableProfileGroup.ExecutionGroup item14 = new ParseableProfileGroup.ExecutionGroup((List<>)(object)list2, (List<>)(object)list3);
		((List<T>)(object)list).Add((T)item14);
		return list;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1628AF0", Offset = "0x16274F0", VA = "0x181628AF0")]
	private List<ParseableProfileGroup.RuleToProfile> CreateProcessorFrequencyExecutionList()
	{
		//Discarded unreachable code: IL_00d8
		List<ParseableProfileGroup.RuleToProfile> list = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
		Rule.Constraint c = new Rule.Constraint(Specs.ProcessorFrequency, Rule.Constraint.Operator.Less, 1000);
		int num = 0;
		ParseableProfileGroup.RuleToProfile item = new ParseableProfileGroup.RuleToProfile(c, ProfileEnum.UltraLow);
		((List<T>)(object)list).Add((T)item);
		ParseableProfileGroup.RuleToProfile item2 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorFrequency, Rule.Constraint.Operator.Less, 1500), ProfileEnum.VeryLow);
		((List<T>)(object)list).Add((T)item2);
		ParseableProfileGroup.RuleToProfile item3 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorFrequency, Rule.Constraint.Operator.Less, 2000), ProfileEnum.Low);
		((List<T>)(object)list).Add((T)item3);
		ParseableProfileGroup.RuleToProfile item4 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorFrequency, Rule.Constraint.Operator.Less, 2500), ProfileEnum.Medium);
		((List<T>)(object)list).Add((T)item4);
		ParseableProfileGroup.RuleToProfile item5 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorFrequency, Rule.Constraint.Operator.Less, 3000), ProfileEnum.High);
		((List<T>)(object)list).Add((T)item5);
		ParseableProfileGroup.RuleToProfile item6 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorFrequency, Rule.Constraint.Operator.Less, 3500), ProfileEnum.VeryHigh);
		((List<T>)(object)list).Add((T)item6);
		int v = default(int);
		Rule.Constraint c2 = new Rule.Constraint(Specs.ProcessorFrequency, Rule.Constraint.Operator.Always, v);
		v = 0;
		ParseableProfileGroup.RuleToProfile item7 = new ParseableProfileGroup.RuleToProfile(c2, ProfileEnum.UltraHigh);
		((List<T>)(object)list).Add((T)item7);
		return list;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x16287D0", Offset = "0x16271D0", VA = "0x1816287D0")]
	private List<ParseableProfileGroup.RuleToProfile> CreateProcessorCountExecutionList()
	{
		//Discarded unreachable code: IL_00c6
		List<ParseableProfileGroup.RuleToProfile> list = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
		Rule.Constraint c = new Rule.Constraint(Specs.ProcessorCount, Rule.Constraint.Operator.Equal, 1);
		int num = 0;
		ParseableProfileGroup.RuleToProfile item = new ParseableProfileGroup.RuleToProfile(c, ProfileEnum.UltraLow);
		((List<T>)(object)list).Add((T)item);
		ParseableProfileGroup.RuleToProfile item2 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorCount, Rule.Constraint.Operator.Equal, 2), ProfileEnum.VeryLow);
		((List<T>)(object)list).Add((T)item2);
		ParseableProfileGroup.RuleToProfile item3 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorCount, Rule.Constraint.Operator.LessEqual, 4), ProfileEnum.Low);
		((List<T>)(object)list).Add((T)item3);
		ParseableProfileGroup.RuleToProfile item4 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorCount, Rule.Constraint.Operator.LessEqual, 6), ProfileEnum.Medium);
		((List<T>)(object)list).Add((T)item4);
		ParseableProfileGroup.RuleToProfile item5 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorCount, Rule.Constraint.Operator.LessEqual, 8), ProfileEnum.High);
		((List<T>)(object)list).Add((T)item5);
		ParseableProfileGroup.RuleToProfile item6 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.ProcessorCount, Rule.Constraint.Operator.LessEqual, 16), ProfileEnum.VeryHigh);
		((List<T>)(object)list).Add((T)item6);
		int v = default(int);
		Rule.Constraint c2 = new Rule.Constraint(Specs.ProcessorCount, Rule.Constraint.Operator.Always, v);
		v = 0;
		ParseableProfileGroup.RuleToProfile item7 = new ParseableProfileGroup.RuleToProfile(c2, ProfileEnum.UltraHigh);
		((List<T>)(object)list).Add((T)item7);
		return list;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1626190", Offset = "0x1624B90", VA = "0x181626190")]
	private static List<ParseableProfileGroup.ExecutionGroup> CreateGraphicsDeviceExecutionList()
	{
		//IL_001c: Expected O, but got I4
		//IL_0173: Expected I4, but got I8
		//IL_0182: Expected I4, but got I8
		//IL_0205: Expected O, but got I4
		//IL_035d: Expected O, but got I4
		List<ParseableProfileGroup.ExecutionGroup> list = (List<ParseableProfileGroup.ExecutionGroup>)(object)new List<T>();
		List<Rule> list2 = (List<Rule>)(object)new List<T>();
		GpuVariantSeriesEnum gpuVariantSeriesEnum = default(GpuVariantSeriesEnum);
		string name = Enum.GetName(typeof(GpuVariantSeriesEnum), gpuVariantSeriesEnum);
		Rule.Constraint c = new Rule.Constraint(Specs.GpuVariantSeriesId, Rule.Constraint.Operator.Equal, name);
		int num = 0;
		Rule item = new Rule(c);
		((List<T>)(object)list2).Add((T)item);
		List<ParseableProfileGroup.RuleToProfile> list3 = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
		int v = default(int);
		Rule.Constraint c2 = new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Equal, v);
		v = 0;
		ParseableProfileGroup.RuleToProfile item2 = new ParseableProfileGroup.RuleToProfile(c2, ProfileEnum.Unknown);
		((List<T>)(object)list3).Add((T)item2);
		int[] array = new int[0];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		ParseableProfileGroup.RuleToProfile item3 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.EqualList, array), ProfileEnum.UltraLow);
		((List<T>)(object)list3).Add((T)item3);
		int[] array2 = new int[0];
		RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		ParseableProfileGroup.RuleToProfile item4 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.EqualList, array2), ProfileEnum.VeryLow);
		((List<T>)(object)list3).Add((T)item4);
		int[] array3 = new int[0];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		ParseableProfileGroup.RuleToProfile item5 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.EqualList, array3), ProfileEnum.Low);
		((List<T>)(object)list3).Add((T)item5);
		int[] array4 = new int[0];
		RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		ParseableProfileGroup.RuleToProfile item6 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.EqualList, array4), ProfileEnum.Medium);
		((List<T>)(object)list3).Add((T)item6);
		int[] array5 = new int[0];
		RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		ParseableProfileGroup.RuleToProfile item7 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.EqualList, array5), ProfileEnum.High);
		((List<T>)(object)list3).Add((T)item7);
		int[] array6 = new int[0];
		int length = array6.Length;
		array6[0] = 800;
		array6[0] = 850;
		ParseableProfileGroup.RuleToProfile item8 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.EqualList, array6), ProfileEnum.VeryHigh);
		((List<T>)(object)list3).Add((T)item8);
		ParseableProfileGroup.RuleToProfile item9 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.GreaterEqual, 850), ProfileEnum.VeryHigh);
		((List<T>)(object)list3).Add((T)item9);
		ParseableProfileGroup.RuleToProfile item10 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.GreaterEqual, 1000), ProfileEnum.UltraHigh);
		((List<T>)(object)list3).Add((T)item10);
		ParseableProfileGroup.ExecutionGroup item11 = new ParseableProfileGroup.ExecutionGroup((List<>)(object)list2, (List<>)(object)list3);
		((List<T>)(object)list).Add((T)item11);
		List<Rule> list4 = (List<Rule>)(object)new List<T>();
		GpuVariantSeriesEnum gpuVariantSeriesEnum2 = default(GpuVariantSeriesEnum);
		string name2 = Enum.GetName(typeof(GpuVariantSeriesEnum), gpuVariantSeriesEnum2);
		Rule item12 = new Rule(new Rule.Constraint(Specs.GpuVariantSeriesId, Rule.Constraint.Operator.Equal, name2));
		((List<T>)(object)list4).Add((T)item12);
		List<ParseableProfileGroup.ExecutionGroup> list5 = (List<ParseableProfileGroup.ExecutionGroup>)(object)new List<T>();
		List<ParseableProfileGroup.RuleToProfile> list6 = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
		List<Rule> list7 = (List<Rule>)(object)new List<T>();
		Rule item13 = new Rule(new Rule.Constraint(Specs.GpuVariantModelMajorPrefix, Rule.Constraint.Operator.Equal, "A"));
		((List<T>)(object)list7).Add((T)item13);
		int v2 = default(int);
		Rule.Constraint c3 = new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Equal, v2);
		v2 = 0;
		ParseableProfileGroup.RuleToProfile item14 = new ParseableProfileGroup.RuleToProfile(c3, ProfileEnum.Unknown);
		((List<T>)(object)list6).Add((T)item14);
		ParseableProfileGroup.RuleToProfile item15 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.LessEqual, 9), ProfileEnum.VeryLow);
		((List<T>)(object)list6).Add((T)item15);
		ParseableProfileGroup.RuleToProfile item16 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.LessEqual, 10), ProfileEnum.Low);
		((List<T>)(object)list6).Add((T)item16);
		ParseableProfileGroup.RuleToProfile item17 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.LessEqual, 11), ProfileEnum.Medium);
		((List<T>)(object)list6).Add((T)item17);
		ParseableProfileGroup.RuleToProfile item18 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.LessEqual, 12), ProfileEnum.High);
		((List<T>)(object)list6).Add((T)item18);
		ParseableProfileGroup.RuleToProfile item19 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Greater, 12), ProfileEnum.VeryHigh);
		((List<T>)(object)list6).Add((T)item19);
		ParseableProfileGroup.RuleToProfile item20 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Greater, 13), ProfileEnum.UltraHigh);
		((List<T>)(object)list6).Add((T)item20);
		ParseableProfileGroup.ExecutionGroup item21 = new ParseableProfileGroup.ExecutionGroup((List<>)(object)list7, (List<>)(object)list6);
		((List<T>)(object)list5).Add((T)item21);
		ParseableProfileGroup.ExecutionGroup item22 = new ParseableProfileGroup.ExecutionGroup((List<>)(object)list4, (List<>)(object)list5);
		((List<T>)(object)list).Add((T)item22);
		List<Rule> list8 = (List<Rule>)(object)new List<T>();
		GpuVariantSeriesEnum gpuVariantSeriesEnum3 = default(GpuVariantSeriesEnum);
		string name3 = Enum.GetName(typeof(GpuVariantSeriesEnum), gpuVariantSeriesEnum3);
		Rule item23 = new Rule(new Rule.Constraint(Specs.GpuVariantSeriesId, Rule.Constraint.Operator.Equal, name3));
		((List<T>)(object)list8).Add((T)item23);
		List<ParseableProfileGroup.ExecutionGroup> list9 = (List<ParseableProfileGroup.ExecutionGroup>)(object)new List<T>();
		List<ParseableProfileGroup.RuleToProfile> list10 = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
		List<Rule> list11 = (List<Rule>)(object)new List<T>();
		Rule item24 = new Rule(new Rule.Constraint(Specs.GpuVariantModelMajorPrefix, Rule.Constraint.Operator.Equal, "T"));
		((List<T>)(object)list11).Add((T)item24);
		int v3 = default(int);
		Rule.Constraint c4 = new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Equal, v3);
		v3 = 0;
		ParseableProfileGroup.RuleToProfile item25 = new ParseableProfileGroup.RuleToProfile(c4, ProfileEnum.Unknown);
		((List<T>)(object)list10).Add((T)item25);
		ParseableProfileGroup.RuleToProfile item26 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.LessEqual, 9), ProfileEnum.VeryLow);
		((List<T>)(object)list10).Add((T)item26);
		ParseableProfileGroup.RuleToProfile item27 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.LessEqual, 10), ProfileEnum.Low);
		((List<T>)(object)list10).Add((T)item27);
		ParseableProfileGroup.RuleToProfile item28 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.LessEqual, 11), ProfileEnum.Medium);
		((List<T>)(object)list10).Add((T)item28);
		ParseableProfileGroup.RuleToProfile item29 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.LessEqual, 12), ProfileEnum.High);
		((List<T>)(object)list10).Add((T)item29);
		ParseableProfileGroup.RuleToProfile item30 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Greater, 12), ProfileEnum.VeryHigh);
		((List<T>)(object)list10).Add((T)item30);
		ParseableProfileGroup.RuleToProfile item31 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Greater, 13), ProfileEnum.UltraHigh);
		((List<T>)(object)list10).Add((T)item31);
		ParseableProfileGroup.ExecutionGroup item32 = new ParseableProfileGroup.ExecutionGroup((List<>)(object)list11, (List<>)(object)list10);
		((List<T>)(object)list9).Add((T)item32);
		List<ParseableProfileGroup.RuleToProfile> list12 = (List<ParseableProfileGroup.RuleToProfile>)(object)new List<T>();
		List<Rule> list13 = (List<Rule>)(object)new List<T>();
		Rule item33 = new Rule(new Rule.Constraint(Specs.GpuVariantModelMajorPrefix, Rule.Constraint.Operator.Equal, "G"));
		((List<T>)(object)list13).Add((T)item33);
		int v4 = default(int);
		Rule.Constraint c5 = new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Equal, v4);
		v4 = 0;
		ParseableProfileGroup.RuleToProfile item34 = new ParseableProfileGroup.RuleToProfile(c5, ProfileEnum.Unknown);
		((List<T>)(object)list12).Add((T)item34);
		ParseableProfileGroup.RuleToProfile item35 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Less, 40), ProfileEnum.VeryLow);
		((List<T>)(object)list12).Add((T)item35);
		ParseableProfileGroup.RuleToProfile item36 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Less, 60), ProfileEnum.Low);
		((List<T>)(object)list12).Add((T)item36);
		ParseableProfileGroup.RuleToProfile item37 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Less, 77), ProfileEnum.Medium);
		((List<T>)(object)list12).Add((T)item37);
		ParseableProfileGroup.RuleToProfile item38 = new ParseableProfileGroup.RuleToProfile(new Rule.Constraint(Specs.GpuVariantModelMajorNumber, Rule.Constraint.Operator.Less, 80), ProfileEnum.High);
		((List<T>)(object)list12).Add((T)item38);
		ParseableProfileGroup.ExecutionGroup item39 = new ParseableProfileGroup.ExecutionGroup((List<>)(object)list13, (List<>)(object)list12);
		((List<T>)(object)list9).Add((T)item39);
		ParseableProfileGroup.ExecutionGroup item40 = new ParseableProfileGroup.ExecutionGroup((List<>)(object)list8, (List<>)(object)list9);
		((List<T>)(object)list).Add((T)item40);
		List<Rule> list14 = (List<Rule>)(object)new List<T>();
		Type typeFromHandle = typeof(GpuVariantSeriesEnum);
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x162A210", Offset = "0x1628C10", VA = "0x18162A210")]
	public static bool FromJsonOverwrite(string json, ParseableProfileGroupSerializationFactory ppg)
	{
		do
		{
			int num = 0;
		}
		while (json == null);
		JsonUtility.FromJsonOverwrite(json, ppg);
		Debug.LogError("ParseableProfileGroup.FromJson: parsing json string failed");
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1627EE0", Offset = "0x16268E0", VA = "0x181627EE0")]
	public static ParseableProfileGroup CreateGraphicsDevice(bool create)
	{
		//Discarded unreachable code: IL_00bf, IL_00f4, IL_00fa, IL_0100
		if (!create)
		{
			IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			if ((object)typeof(FileSystem).TypeHandle != null)
			{
				string json = FileSystem.Data.ReadAllText("GraphicDeviceSettings.json");
				int num = 0;
				if (DebugSettings.Settings.logDeviceInfo_)
				{
				}
				ParseableProfileGroupSerializationFactory parseableProfileGroupSerializationFactory = new ParseableProfileGroupSerializationFactory();
				if (FromJsonOverwrite(json, parseableProfileGroupSerializationFactory))
				{
					ParseableProfileGroup parseableProfileGroup = parseableProfileGroupSerializationFactory.Create("GraphicsDevice");
					Debug.LogWarning("Exception in Executing CreateGraphicsDevice");
					Debug.LogWarning("Exception in Executing CreateGraphicsDevice");
				}
			}
			IFileSystem _003CData_003Ek__BackingField2 = FileSystem.Data;
			if ((object)typeof(FileSystem).TypeHandle != null)
			{
				string json2 = FileSystem.Data.ReadAllText("GraphicDeviceSettingsBackup.json");
				int num2 = 0;
				if (DebugSettings.Settings.logDeviceInfo_)
				{
				}
				ParseableProfileGroupSerializationFactory parseableProfileGroupSerializationFactory2 = new ParseableProfileGroupSerializationFactory();
				if (FromJsonOverwrite(json2, parseableProfileGroupSerializationFactory2))
				{
					Debug.LogWarning("GraphicsDevice FromJson: loading GraphicDeviceSettingsBackup.json");
					return parseableProfileGroupSerializationFactory2.Create("GraphicsDevice");
				}
			}
			Debug.LogWarning("GraphicsDevice created from code");
		}
		int num3 = 0;
		List<ParseableProfileGroup.ExecutionGroup> list = (List<ParseableProfileGroup.ExecutionGroup>)(object)DeviceManager.CreateGraphicsDeviceExecutionList();
		return new ParseableProfileGroup("GraphicsDevice", (List<>)(object)list);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x16297F0", Offset = "0x16281F0", VA = "0x1816297F0")]
	public static ParseableProfileGroup CreateProcessorType(bool create)
	{
		//Discarded unreachable code: IL_00bf, IL_00f4, IL_00fa, IL_0100
		if (!create)
		{
			IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
			if ((object)typeof(FileSystem).TypeHandle != null)
			{
				string json = FileSystem.Data.ReadAllText("ProcessorTypeSettings.json");
				int num = 0;
				if (DebugSettings.Settings.logDeviceInfo_)
				{
				}
				ParseableProfileGroupSerializationFactory parseableProfileGroupSerializationFactory = new ParseableProfileGroupSerializationFactory();
				if (FromJsonOverwrite(json, parseableProfileGroupSerializationFactory))
				{
					ParseableProfileGroup parseableProfileGroup = parseableProfileGroupSerializationFactory.Create("ProcessorType");
					Debug.LogWarning("Exception in Executing CreateProcessorType\n");
					Debug.LogWarning("Exception in Executing CreateProcessorType\n");
				}
			}
			IFileSystem _003CData_003Ek__BackingField2 = FileSystem.Data;
			if ((object)typeof(FileSystem).TypeHandle != null)
			{
				string json2 = FileSystem.Data.ReadAllText("ProcessorTypeSettingsBackup.json");
				int num2 = 0;
				if (DebugSettings.Settings.logDeviceInfo_)
				{
				}
				ParseableProfileGroupSerializationFactory parseableProfileGroupSerializationFactory2 = new ParseableProfileGroupSerializationFactory();
				if (FromJsonOverwrite(json2, parseableProfileGroupSerializationFactory2))
				{
					Debug.LogWarning("ProcessorType FromJson: loading ProcessorTypeSettingsBackup.json");
					return parseableProfileGroupSerializationFactory2.Create("ProcessorType");
				}
			}
			Debug.LogWarning("ProcessorType created from code");
		}
		int num3 = 0;
		List<ParseableProfileGroup.ExecutionGroup> list = (List<ParseableProfileGroup.ExecutionGroup>)(object)DeviceManager.CreateProcessorTypeExecutionList();
		return new ParseableProfileGroup("ProcessorType", (List<>)(object)list);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x162A690", Offset = "0x1629090", VA = "0x18162A690")]
	public void InitProfiles()
	{
		List<ParseableProfileGroup.RuleToProfile> list = (List<ParseableProfileGroup.RuleToProfile>)(object)this.CreateSystemMemoryExecutionList();
		ParseableProfileGroup parseableProfileGroup = (SystemMemory = new ParseableProfileGroup("SystemMemory", (List<>)(object)list));
		List<ParseableProfileGroup.RuleToProfile> list2 = (List<ParseableProfileGroup.RuleToProfile>)(object)this.CreateGraphicsMemoryExecutionList();
		ParseableProfileGroup parseableProfileGroup2 = (GraphicsMemory = new ParseableProfileGroup("GraphicsMemory", (List<>)(object)list2));
		ParseableProfileGroup parseableProfileGroup3 = (ProcessorType = CreateProcessorType(create: false));
		List<ParseableProfileGroup.RuleToProfile> list3 = (List<ParseableProfileGroup.RuleToProfile>)(object)this.CreateProcessorFrequencyExecutionList();
		ParseableProfileGroup parseableProfileGroup4 = (ProcessorFrequency = new ParseableProfileGroup("ProcessorFrequency", (List<>)(object)list3));
		List<ParseableProfileGroup.RuleToProfile> list4 = (List<ParseableProfileGroup.RuleToProfile>)(object)this.CreateProcessorCountExecutionList();
		ParseableProfileGroup parseableProfileGroup5 = (ProcessorCount = new ParseableProfileGroup("ProcessorCount", (List<>)(object)list4));
		ParseableProfileGroup parseableProfileGroup6 = (GraphicsDevice = CreateGraphicsDevice(create: false));
		GraphicsQualityProfile graphicsQualityProfile = (GraphicsQuality = new GraphicsQualityProfile("GraphicsQuality"));
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x1629DB0", Offset = "0x16287B0", VA = "0x181629DB0")]
	public static void CreateSingleton()
	{
		_singleton = new DeviceManager();
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x162D860", Offset = "0x162C260", VA = "0x18162D860")]
	public DeviceManager()
	{
		//Discarded unreachable code: IL_045c
		SpecValueType[] array;
		SpecValueType specValueType = default(SpecValueType);
		SpecValueType specValueType2 = default(SpecValueType);
		SpecValueType specValueType4 = default(SpecValueType);
		SpecValueType specValueType5 = default(SpecValueType);
		SpecValueType specValueType6 = default(SpecValueType);
		SpecValueType specValueType7 = default(SpecValueType);
		SpecValueType specValueType8 = default(SpecValueType);
		SpecValueType specValueType9 = default(SpecValueType);
		SpecValueType specValueType10 = default(SpecValueType);
		SpecValueType specValueType11 = default(SpecValueType);
		SpecValueType specValueType16 = default(SpecValueType);
		SpecValueType specValueType19 = default(SpecValueType);
		SpecValueType specValueType25 = default(SpecValueType);
		SpecValueType specValueType28 = default(SpecValueType);
		SpecValueType specValueType30;
		while (true)
		{
			GpuVariantSeries = "";
			GpuVariantSeriesSuffix = "";
			GpuVariantModel = "";
			GpuVariantModelMajorPrefix = "";
			GpuVariantModelMajorSuffix = "";
			GpuVariantModelMinorPrefix = "";
			GpuVariantModelMinorSuffix = "";
			CpuVariantSeries = "";
			CpuVariantModel = "";
			CpuVariantModelMajorPrefix = "";
			CpuVariantModelMajorSuffix = "";
			CpuVariantModelMinorPrefix = "";
			CpuVariantModelMinorSuffix = "";
			base._002Ector();
			ParseGpuVariant();
			ParseCpuVariant();
			array = new SpecValueType[30];
			int num = 0;
			if (specValueType != null && specValueType == null)
			{
				continue;
			}
			array[0] = specValueType;
			int num2 = 0;
			if (specValueType2 != null && specValueType2 == null)
			{
				continue;
			}
			array[1] = specValueType2;
			int num3 = 0;
			string graphicsDeviceName = Mdl.Platform.SystemInfo.graphicsDeviceName;
			SpecValueType specValueType3 = new SpecValueType(Specs.GraphicsDeviceName, graphicsDeviceName);
			if (specValueType3 != null && specValueType3 == null)
			{
				continue;
			}
			array[2] = specValueType3;
			int num4 = 0;
			if (specValueType4 != null && specValueType4 == null)
			{
				continue;
			}
			array[3] = specValueType4;
			int num5 = 0;
			if (specValueType5 != null && specValueType5 == null)
			{
				continue;
			}
			array[4] = specValueType5;
			int num6 = 0;
			if (specValueType6 != null && specValueType6 == null)
			{
				continue;
			}
			array[5] = specValueType6;
			int num7 = 0;
			if (specValueType7 != null && specValueType7 == null)
			{
				continue;
			}
			array[6] = specValueType7;
			int num8 = 0;
			if (specValueType8 != null && specValueType8 == null)
			{
				continue;
			}
			array[7] = specValueType8;
			int num9 = 0;
			if (specValueType9 != null && specValueType9 == null)
			{
				continue;
			}
			array[8] = specValueType9;
			int num10 = 0;
			if (specValueType10 != null && specValueType10 == null)
			{
				continue;
			}
			array[9] = specValueType10;
			if (specValueType11 != null && specValueType11 == null)
			{
				continue;
			}
			array[10] = specValueType11;
			Type typeFromHandle = typeof(GpuVariantSeriesEnum);
			string name = Enum.GetName(typeFromHandle, typeFromHandle);
			SpecValueType specValueType12 = new SpecValueType(Specs.GpuVariantSeriesId, name);
			if (specValueType12 != null && specValueType12 == null)
			{
				continue;
			}
			array[11] = specValueType12;
			SpecValueType specValueType13 = new SpecValueType(Specs.GpuVariantSeriesSuffix, name);
			if (specValueType13 != null && specValueType13 == null)
			{
				continue;
			}
			array[12] = specValueType13;
			SpecValueType specValueType14 = new SpecValueType(Specs.GpuVariantModel, name);
			if (specValueType14 != null && specValueType14 == null)
			{
				continue;
			}
			array[13] = specValueType14;
			SpecValueType specValueType15 = new SpecValueType(Specs.GpuVariantModelMajorPrefix, name);
			if (specValueType15 != null && specValueType15 == null)
			{
				continue;
			}
			array[14] = specValueType15;
			if (specValueType16 != null && specValueType16 == null)
			{
				continue;
			}
			array[15] = specValueType16;
			SpecValueType specValueType17 = new SpecValueType(Specs.GpuVariantModelMajorSuffix, name);
			if (specValueType17 != null && specValueType17 == null)
			{
				continue;
			}
			array[16] = specValueType17;
			SpecValueType specValueType18 = new SpecValueType(Specs.GpuVariantModelMinorPrefix, name);
			if (specValueType18 != null && specValueType18 == null)
			{
				continue;
			}
			array[17] = specValueType18;
			if (specValueType19 != null && specValueType19 == null)
			{
				continue;
			}
			array[18] = specValueType19;
			SpecValueType specValueType20 = new SpecValueType(Specs.GpuVariantModelMinorSuffix, name);
			if (specValueType20 != null && specValueType20 == null)
			{
				continue;
			}
			array[19] = specValueType20;
			SpecValueType specValueType21 = new SpecValueType(Specs.CpuVariantSeries, name);
			if (specValueType21 != null && specValueType21 == null)
			{
				continue;
			}
			array[20] = specValueType21;
			Type typeFromHandle2 = typeof(CpuVariantSeriesEnum);
			string name2 = Enum.GetName(typeFromHandle2, typeFromHandle2);
			SpecValueType specValueType22 = new SpecValueType(Specs.CpuVariantSeriesId, name2);
			if (specValueType22 != null && specValueType22 == null)
			{
				continue;
			}
			array[21] = specValueType22;
			SpecValueType specValueType23 = new SpecValueType(Specs.CpuVariantModel, name2);
			if (specValueType23 != null && specValueType23 == null)
			{
				continue;
			}
			array[22] = specValueType23;
			SpecValueType specValueType24 = new SpecValueType(Specs.CpuVariantModelMajorPrefix, name2);
			if (specValueType24 != null && specValueType24 == null)
			{
				continue;
			}
			array[23] = specValueType24;
			if (specValueType25 != null && specValueType25 == null)
			{
				continue;
			}
			array[24] = specValueType25;
			SpecValueType specValueType26 = new SpecValueType(Specs.CpuVariantModelMajorSuffix, name2);
			if (specValueType26 != null && specValueType26 == null)
			{
				continue;
			}
			array[25] = specValueType26;
			SpecValueType specValueType27 = new SpecValueType(Specs.CpuVariantModelMinorPrefix, name2);
			if (specValueType27 != null && specValueType27 == null)
			{
				continue;
			}
			array[26] = specValueType27;
			if (specValueType28 != null && specValueType28 == null)
			{
				continue;
			}
			array[27] = specValueType28;
			SpecValueType specValueType29 = new SpecValueType(Specs.CpuVariantModelMinorSuffix, name2);
			if (specValueType29 == null || specValueType29 != null)
			{
				array[28] = specValueType29;
				specValueType30 = new SpecValueType(Specs.Error, "-- Error --");
				if (specValueType30 == null || specValueType30 != null)
				{
					break;
				}
			}
		}
		array[29] = specValueType30;
		array[29] = (SpecValueType)(object)array;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x162A590", Offset = "0x1628F90", VA = "0x18162A590")]
	public string GetTypeValueString(Specs s)
	{
		UnionValue<int, string> _003CValue_003Ek__BackingField = SpecValueTypeMap[(int)s].Value;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x162A490", Offset = "0x1628E90", VA = "0x18162A490")]
	public int GetTypeValueInt(Specs s)
	{
		UnionValue<int, string> _003CValue_003Ek__BackingField = SpecValueTypeMap[(int)s].Value;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x162D7C0", Offset = "0x162C1C0", VA = "0x18162D7C0")]
	[RuntimeInitializeOnLoadMethod]
	private static void ReloadDeviceManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x162C390", Offset = "0x162AD90", VA = "0x18162C390")]
	private unsafe void ParseGpuVariant()
	{
		//Discarded unreachable code: IL_0488
		//IL_00e5: Expected I4, but got O
		//IL_018e: Expected I4, but got O
		//IL_0249: Expected I4, but got I8
		//IL_02d7: Expected I4, but got I8
		//IL_02e0: Expected I4, but got I8
		//IL_02e9: Expected I4, but got I8
		//IL_02f2: Expected I4, but got I8
		//IL_02fb: Expected I4, but got I8
		//IL_03f3: Expected O, but got I4
		//IL_0464: Expected O, but got I4
		//IL_047b: Expected O, but got I4
		bool flag = default(bool);
		bool flag2 = default(bool);
		string text = default(string);
		string text2 = default(string);
		object[] array10;
		int num20;
		while (true)
		{
			int num = (int)(GpuVariantSeriesId = GpuVariantSeriesEnum.Unknown);
			GpuVariantSeriesSuffix = "--";
			GpuVariantModelMajorPrefix = "--";
			GpuVariantModelMajorSuffix = "--";
			GpuVariantModelMinorPrefix = "--";
			GpuVariantModelMinorSuffix = "--";
			int num2 = 0;
			char[] array = Mdl.Platform.SystemInfo.graphicsDeviceName.ToCharArray();
			int length = array.Length;
			if (length != 0)
			{
				char c = array[0];
				int[] array2 = new int[3];
				int[] array3 = new int[3];
				int num3 = 0;
				if (((long)(int)c < (long)(IntPtr)this && char.IsDigit(array[(uint)c])) || num3 == 0)
				{
					while (c <= c)
					{
					}
				}
				c = (char)(c - c);
				char c2 = (char)(c + 1);
				if (num3 == 0)
				{
					c2 = c;
				}
				c = c2;
				if ((long)(int)c2 >= (long)(IntPtr)this || char.IsDigit(array[(uint)c]))
				{
				}
				c = (char)(c - c2);
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				((int*)num5)->m_value = (int)"--";
				int num7 = 0;
				GpuVariantModelMajorNumber = (flag ? 1 : 0);
				int num8 = 0;
				GpuVariantModelMajorSuffix = "--";
			}
			if (length > 1)
			{
				char c3 = array[0];
				int[] array4 = new int[3];
				int[] array5 = new int[3];
				int num9 = 0;
				if (((long)(int)c3 < (long)(IntPtr)this && char.IsDigit(array[(uint)c3])) || num9 == 0)
				{
					while (c3 <= c3)
					{
					}
				}
				c3 = (char)(c3 - c3);
				char c4 = (char)(c3 + 1);
				if (num9 == 0)
				{
					c4 = c3;
				}
				c3 = c4;
				if ((long)(int)c4 >= (long)(IntPtr)this || char.IsDigit(array[(uint)c3]))
				{
				}
				c3 = (char)(c3 - c4);
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				((int*)num11)->m_value = (int)"--";
				int num13 = 0;
				GpuVariantModelMinorNumber = (flag2 ? 1 : 0);
				int num14 = 0;
				GpuVariantModelMinorSuffix = "--";
			}
			int num15 = 0;
			int num16 = 0;
			GpuVariantSeries = text;
			int num17 = 0;
			GpuVariantModel = text2;
			string text3 = GpuVariantSeries;
			if (!text3.StartsWith("Adreno"))
			{
				if (!text3.StartsWith("AMD"))
				{
					if (!text3.StartsWith("Apple"))
					{
						if (!text3.StartsWith("Intel(R)"))
						{
							if (!text3.StartsWith("Mali"))
							{
								if (!GpuVariantSeries.StartsWith("NVIDIA"))
								{
									goto IL_02fb;
								}
								string text4 = GpuVariantSeries;
								GpuVariantSeriesId = GpuVariantSeriesEnum.NVIDIA;
								if (!text4.Contains(" RTX"))
								{
									if (!GpuVariantSeries.Contains(" GTX"))
									{
										if (!GpuVariantSeries.Contains(" GT"))
										{
											goto IL_02fb;
										}
										GpuVariantSeriesSuffix = "GT";
										string text5 = (GpuVariantSeries = GpuVariantSeries.Replace(" GT", " "));
									}
									GpuVariantSeriesSuffix = "GTX";
									string text6 = GpuVariantSeries;
								}
								GpuVariantSeriesSuffix = "RTX";
								string text7 = GpuVariantSeries;
							}
							GpuVariantSeriesId = GpuVariantSeriesEnum.Mali;
						}
						GpuVariantSeriesId = GpuVariantSeriesEnum.Intel;
					}
					GpuVariantSeriesId = GpuVariantSeriesEnum.Apple;
				}
				GpuVariantSeriesId = GpuVariantSeriesEnum.AMD;
			}
			GpuVariantSeriesId = GpuVariantSeriesEnum.Adreno;
			goto IL_02fb;
			IL_02fb:
			object[] array6 = new object[1];
			int num18 = 0;
			string graphicsDeviceName = Mdl.Platform.SystemInfo.graphicsDeviceName;
			if (graphicsDeviceName != null && graphicsDeviceName == null)
			{
				continue;
			}
			array6[0] = graphicsDeviceName;
			GameLog.Info("|GraphicsDeviceName: {0}|\n", array6);
			object[] array7 = new object[2];
			string text8 = GpuVariantSeries;
			if (text8 != null && array7 == null)
			{
				continue;
			}
			array7[0] = text8;
			if (text8 != null && array7 == null)
			{
				continue;
			}
			array7[1] = text8;
			GameLog.Info("GpuVariantSeries: {0} / {1}\n", array7);
			object[] array8 = new object[1];
			string text9 = GpuVariantModel;
			if (text9 != null && array8 == null)
			{
				continue;
			}
			array8[0] = text9;
			GameLog.Info("GpuVariantModel: {0}\n", array8);
			object[] array9 = new object[3];
			string text10 = GpuVariantModelMajorPrefix;
			if (text10 != null && array9 == null)
			{
				continue;
			}
			array9[0] = text10;
			int num19 = GpuVariantModelMajorNumber;
			if (num19 != 0 && num19 == 0)
			{
				continue;
			}
			array9[1] = num19;
			string text11 = GpuVariantModelMajorSuffix;
			if (text11 != null && num19 == 0)
			{
				continue;
			}
			array9[2] = text11;
			GameLog.Info("GpuVariantModelMajorPrefix: {0} / {1} / {2}\n", array9);
			array10 = new object[3];
			string text12 = GpuVariantModelMinorPrefix;
			if (text12 != null && array10 == null)
			{
				continue;
			}
			array10[0] = text12;
			num20 = GpuVariantModelMinorNumber;
			if (num20 == 0 || num20 != 0)
			{
				array10[1] = num20;
				if (num20 == 0 || num20 != 0)
				{
					break;
				}
			}
		}
		array10[2] = num20;
		GameLog.Info("GpuVariantModelMinorPrefix: {0} / {1} / {2}\n", array10);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x162B1E0", Offset = "0x1629BE0", VA = "0x18162B1E0")]
	private unsafe void ParseCpuVariant()
	{
		//Discarded unreachable code: IL_02d3
		//IL_00cf: Expected I4, but got O
		//IL_0188: Expected I4, but got O
		//IL_019a: Expected I8, but got O
		//IL_01a8: Expected I4, but got I8
		char[] array = default(char[]);
		bool flag = default(bool);
		char c5 = default(char);
		ulong num16 = default(ulong);
		char c3 = default(char);
		bool flag2 = default(bool);
		object[] array10;
		while (true)
		{
			int num = (int)(CpuVariantSeriesId = CpuVariantSeriesEnum.Unknown);
			CpuVariantModelMajorPrefix = "--";
			CpuVariantModelMajorSuffix = "--";
			CpuVariantModelMinorPrefix = "--";
			CpuVariantModelMinorSuffix = "--";
			int num2 = 0;
			int length = array.Length;
			if (length != 0)
			{
				char c = array[0];
				int[] array2 = new int[3];
				int[] array3 = new int[3];
				int num3 = 0;
				if (((long)(int)c < (long)(IntPtr)this && char.IsDigit(array[(uint)c])) || num3 == 0)
				{
					while (c <= c)
					{
					}
				}
				c = (char)(c - c);
				char c2 = (char)(c + 1);
				if (num3 == 0)
				{
					c2 = c;
				}
				c = c2;
				if ((long)(int)c2 >= (long)(IntPtr)this || char.IsDigit(array[(uint)c]))
				{
				}
				c = (char)(c - c2);
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				((int*)num5)->m_value = (int)"--";
				int num7 = 0;
				CpuVariantModelMajorNumber = (flag ? 1 : 0);
				int num8 = 0;
				CpuVariantModelMajorSuffix = "--";
			}
			int num9 = 0;
			if (length > 1)
			{
				c3 = array[0];
				int[] array4 = new int[3];
				int[] array5 = new int[3];
				int num10 = 0;
				if ((c3 < num9 && char.IsDigit(array[(uint)c3])) || num10 == 0)
				{
					while (c3 <= c3)
					{
					}
				}
				c3 = (char)(c3 - c3);
				char c4 = (char)(c3 + 1);
				if (num10 == 0)
				{
					c4 = c3;
				}
				c3 = c4;
				if (c4 < num9)
				{
					c5 = array[(uint)c3];
					if (!char.IsDigit(c5))
					{
					}
				}
				c3 = (char)(c3 - c4);
				num9 -= c3;
				int num11 = 0;
				int num12 = 0;
				int num13 = 0;
				((int*)num10)->m_value = (int)"--";
				int num14 = 0;
				int num15 = 0;
				((ulong*)num16)->m_value = (ulong)(long)"--";
				c3 = (char)(c3 - c5);
				c3 = (char)((ulong)(int)c3 + num16);
			}
			int num17 = 0;
			int num18 = 0;
			c5 = c3;
			int num19 = 0;
			if (flag2)
			{
			}
			object[] array6 = new object[1];
			int num20 = 0;
			if (array6 != null && array6 == null)
			{
				continue;
			}
			array6[0] = array6;
			GameLog.Info("|ProcessorType: {0}|\n", array6);
			object[] array7 = new object[1];
			if (array6 != null && array7 == null)
			{
				continue;
			}
			array7[0] = array6;
			GameLog.Info("CpuVariantSeries: {0}\n", array7);
			object[] array8 = new object[1];
			if (array6 != null && array8 == null)
			{
				continue;
			}
			array8[0] = array6;
			GameLog.Info("CpuVariantModel: {0}\n", array8);
			object[] array9 = new object[3];
			if (array6 != null && array9 == null)
			{
				continue;
			}
			array9[0] = array6;
			if (array9 != null && array9 == null)
			{
				continue;
			}
			array9[1] = array9;
			if (array9 != null && array9 == null)
			{
				continue;
			}
			array9[2] = array9;
			GameLog.Info("CpuVariantModelMajor: {0} / {1} / {2}\n", array9);
			array10 = new object[3];
			if (array10 != null && (array10 == null || array10 != null))
			{
				array10[1] = array10;
				if (array10 != null)
				{
					break;
				}
			}
		}
		GameLog.Info("CpuVariantModelMinor: {0} / {1} / {2}\n", array10);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x162A8A0", Offset = "0x16292A0", VA = "0x18162A8A0")]
	private static void ParseCodenameSet(char[] c, int startIndex, int length, out int[] startIndexArray, out int[] lengthArray, int maxArrayLength)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x162AEE0", Offset = "0x16298E0", VA = "0x18162AEE0")]
	private static void ParseCodename(char[] c, int startIndex, int length, out int[] startIndexArray, out int[] lengthArray)
	{
		//Discarded unreachable code: IL_0050
		//IL_000e: Expected I4, but got O
		int[] array = new int[3];
		System.Runtime.CompilerServices.Unsafe.As<int[], int>(ref startIndexArray).m_value = (int)array;
		int[] array2 = new int[3];
		int num = 0;
		if (char.IsDigit(c[startIndex]) || num == 0)
		{
			while (startIndex <= startIndex)
			{
			}
		}
		int num2 = startIndex + 1;
		ulong num3 = default(ulong);
		if (num3 == 0)
		{
			num2 = startIndex;
		}
		if (!char.IsDigit(c[startIndex]))
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x162A310", Offset = "0x1628D10", VA = "0x18162A310")]
	private static string GetPrefix(char[] c, int[] startIndexArray, int[] lengthArray)
	{
		//Discarded unreachable code: IL_001c
		if (lengthArray[0] > 0)
		{
			int num = startIndexArray[0];
			int num2 = 0;
			string result = default(string);
			return result;
		}
		return "--";
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x162A290", Offset = "0x1628C90", VA = "0x18162A290")]
	private static int GetNumber(char[] c, int[] startIndexArray, int[] lengthArray)
	{
		int num = startIndexArray[0];
		int num2 = lengthArray[0];
		int num3 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x162A3D0", Offset = "0x1628DD0", VA = "0x18162A3D0")]
	private static string GetSuffix(char[] c, int[] startIndexArray, int[] lengthArray)
	{
		//Discarded unreachable code: IL_001c
		if (lengthArray[1] > 0)
		{
			int num = startIndexArray[1];
			int num2 = 0;
			string result = default(string);
			return result;
		}
		return "--";
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x162A160", Offset = "0x1628B60", VA = "0x18162A160")]
	public void Execute()
	{
		InitProfiles();
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	static DeviceManager()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
