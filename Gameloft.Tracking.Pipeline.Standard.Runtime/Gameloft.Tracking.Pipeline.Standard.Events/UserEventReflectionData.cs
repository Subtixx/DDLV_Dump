using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Pipeline.Standard.Attributes;
using Gameloft.Tracking.Utils;

namespace Gameloft.Tracking.Pipeline.Standard.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class UserEventReflectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly IReadOnlyCollection<(PropertyInfo Property, string Name)> properties;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly ConcurrentDictionary<Type, UserEventReflectionData> DataCache = (ConcurrentDictionary<Type, UserEventReflectionData>)(object)new ConcurrentDictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400003C")]
		public int TypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x400003D")]
		public uint? BatchSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAC86D0", Offset = "0xAC70D0", VA = "0x180AC86D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x400003E")]
		public EventPriority? Priority
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xF4C770", Offset = "0xF4B170", VA = "0x180F4C770")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x400003F")]
		public IReadOnlyCollection<string> SmartBatchProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000040")]
		public IReadOnlyCollection<string> EncryptProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28CD3C0", Offset = "0x28CBDC0", VA = "0x1828CD3C0")]
		private UserEventReflectionData(Type type)
		{
			//IL_0028: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			_003CType_003Ek__BackingField = type;
			BatchSizeAttribute customAttribute = type.GetCustomAttribute<BatchSizeAttribute>();
			int num = 0;
			if (customAttribute != null)
			{
				uint num2 = customAttribute.BatchSize;
			}
			BatchSize = (uint?)(object)num;
			int num3 = (TypeId = type.GetCustomAttribute<EventIdAttribute>().Id);
			PriorityAttribute customAttribute2 = type.GetCustomAttribute<PriorityAttribute>();
			if (customAttribute2 != null)
			{
				EventPriority eventPriority = customAttribute2.Priority;
			}
			Priority = (EventPriority?)(object)num;
			string[] array = (string[])(object)(SmartBatchProperties = (IReadOnlyCollection<string>)(object)GetPropertiesWithAttribute<BatchableAttribute>(type).ToArray<string>());
			string[] array2 = (string[])(object)(EncryptProperties = (IReadOnlyCollection<string>)(object)GetPropertiesWithAttribute<EncryptAttribute>(type).ToArray<string>());
			Func<PropertyInfo, (PropertyInfo, string)> func = default(Func<PropertyInfo, (PropertyInfo, string)>);
			if (_003C_003Ec._003C_003E9__19_0 == null)
			{
				func = (Func<PropertyInfo, (PropertyInfo, string)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					ShortNameAttribute shortNameAttribute = default(ShortNameAttribute);
					if (shortNameAttribute == null || shortNameAttribute.Name == null)
					{
					}
					int num4 = 0;
					throw new NullReferenceException();
				});
			}
			PropertyInfo[] array3 = default(PropertyInfo[]);
			(PropertyInfo, string)[] array4 = ((PropertyInfo, string)[])(object)(properties = (IReadOnlyCollection<(PropertyInfo Property, string Name)>)(object)Enumerable.Select<PropertyInfo, (PropertyInfo, string)>((IEnumerable<>)(object)array3, (Func<, >)(object)func).ToArray<(PropertyInfo, string)>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28CCE10", Offset = "0x28CB810", VA = "0x1828CCE10")]
		public Dictionary<string, object> CreatePropertiesDictionary(UserEvent instance)
		{
			//Discarded unreachable code: IL_0049
			IReadOnlyCollection<(PropertyInfo, string)> readOnlyCollection = properties;
			Func<(PropertyInfo, string), string> _003C_003E9__20_ = _003C_003Ec._003C_003E9__20_0;
			if (_003C_003E9__20_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			object result = default(object);
			Func<(PropertyInfo, string), object> func = (Func<(PropertyInfo, string), object>)(object)(Func<T, TResult>)(((PropertyInfo Property, string Name) p) => result);
			return (Dictionary<string, object>)(object)Enumerable.ToDictionary<(PropertyInfo, string), string, object>((IEnumerable<>)readOnlyCollection, (Func<, >)(object)_003C_003E9__20_, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x165AB70", Offset = "0x1659570", VA = "0x18165AB70")]
		[IteratorStateMachine(typeof(_003CGetPropertiesWithAttribute_003Ed__21<>))]
		private static IEnumerable<> GetPropertiesWithAttribute<T>(Type cpp2il__autoParamName__idx_0) where T : Attribute
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28CCFE0", Offset = "0x28CB9E0", VA = "0x1828CCFE0")]
		private static string GetMemberName(MemberInfo member)
		{
			//Discarded unreachable code: IL_001b
			ShortNameAttribute customAttribute;
			do
			{
				customAttribute = member.GetCustomAttribute<ShortNameAttribute>();
			}
			while (customAttribute != null && customAttribute.Name != null);
			return member.Name;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28CD050", Offset = "0x28CBA50", VA = "0x1828CD050")]
		private static object GetPropertyValue(PropertyInfo property, object obj)
		{
			//Discarded unreachable code: IL_0030
			object value = property.GetValue(obj);
			if (value != null)
			{
				int num = 0;
				Type underlyingType = Enum.GetUnderlyingType(value.GetType());
				int num2 = 0;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				object obj2 = Convert.ChangeType(value, underlyingType, invariantCulture);
			}
			return value;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28CD1C0", Offset = "0x28CBBC0", VA = "0x1828CD1C0")]
		public static UserEventReflectionData Get(Type type)
		{
			//Discarded unreachable code: IL_002e
			ConcurrentDictionary<Type, UserEventReflectionData> dataCache = DataCache;
			Func<Type, UserEventReflectionData> _003C_003E9__25_ = _003C_003Ec._003C_003E9__25_0;
			if (_003C_003E9__25_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Type t) => new UserEventReflectionData(t));
			}
			return (UserEventReflectionData)((ConcurrentDictionary<TKey, TValue>)(object)dataCache).GetOrAdd((TKey)type, (Func<, >)(object)_003C_003E9__25_);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28CD340", Offset = "0x28CBD40", VA = "0x1828CD340")]
		static UserEventReflectionData()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
