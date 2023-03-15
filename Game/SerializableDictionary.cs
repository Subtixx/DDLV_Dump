using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class SerializableDictionary
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class Storage<T> : SerializableDictionaryBase.Storage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public T data;

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x188E140", Offset = "0x188CB40", VA = "0x18188E140")]
		public Storage()
		{
			//Discarded unreachable code: IL_0007
			((System.Xml.EmptyEnumerator)(object)this)._002Ector();
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class SerializableDictionary<TKey, TValue> : SerializableDictionaryBase<TKey, TValue, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x912C70", Offset = "0x911670", VA = "0x180912C70")]
	public SerializableDictionary()
	{
		//Discarded unreachable code: IL_0008
		int count = ((ICollection<T>)this).Count;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x1C35980", Offset = "0x1C34380", VA = "0x181C35980")]
	public SerializableDictionary(IDictionary<TKey, TValue> dict)
	{
		//Discarded unreachable code: IL_0008
		int count = ((ICollection<T>)this).Count;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x213D740", Offset = "0x213C140", VA = "0x18213D740")]
	protected SerializableDictionary(SerializationInfo info, StreamingContext context)
	{
	}//Discarded unreachable code: IL_0001


	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x213C1E0", Offset = "0x213ABE0", VA = "0x18213C1E0", Slot = "41")]
	protected override TValue GetValue(TValue[] storage, int i)
	{
		//Discarded unreachable code: IL_0008
		return storage[i];
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x213D230", Offset = "0x213BC30", VA = "0x18213D230", Slot = "40")]
	protected override void SetValue(TValue[] storage, int i, TValue value)
	{
		throw new NullReferenceException();
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class SerializableDictionary<TKey, TValue, TValueStorage> : SerializableDictionaryBase<TKey, TValue, TValueStorage> where TValueStorage : SerializableDictionary.Storage<TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x912C70", Offset = "0x911670", VA = "0x180912C70")]
	public SerializableDictionary()
	{
		//Discarded unreachable code: IL_0008
		ICollection<> values = ((IDictionary<TKey, TValue>)this).get_Values();
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x1C35980", Offset = "0x1C34380", VA = "0x181C35980")]
	public SerializableDictionary(IDictionary<TKey, TValue> dict)
	{
		//Discarded unreachable code: IL_0008
		ICollection<> values = ((IDictionary<TKey, TValue>)this).get_Values();
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x213D740", Offset = "0x213C140", VA = "0x18213D740")]
	protected SerializableDictionary(SerializationInfo info, StreamingContext context)
	{
	}//Discarded unreachable code: IL_0001


	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x213DA80", Offset = "0x213C480", VA = "0x18213DA80", Slot = "41")]
	protected override TValue GetValue(TValueStorage[] storage, int i)
	{
		//Discarded unreachable code: IL_0008
		return (TValue)storage[i];
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x213DAC0", Offset = "0x213C4C0", VA = "0x18213DAC0", Slot = "40")]
	protected override void SetValue(TValueStorage[] storage, int i, TValue value)
	{
		throw new NullReferenceException();
	}
}
