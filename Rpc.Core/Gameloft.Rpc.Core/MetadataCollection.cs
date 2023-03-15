using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Google.Protobuf;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class MetadataCollection
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000031")]
		public IDictionary<string, ByteString> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x38DF480", Offset = "0x38DDE80", VA = "0x1838DF480")]
		public MetadataCollection()
		{
			Dictionary<string, ByteString> dictionary = (Dictionary<string, ByteString>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
			Values = dictionary;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public MetadataCollection(IDictionary<string, ByteString> values)
		{
			Values = values;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x38DEFA0", Offset = "0x38DD9A0", VA = "0x1838DEFA0")]
		public bool ContainsKey(string key)
		{
			IDictionary<string, ByteString> dictionary = Values;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					goto IL_0021;
				}
				num++;
			}
			ByteString byteString = (ByteString)((IDictionary<TKey, TValue>)dictionary)[(TKey)key];
			goto IL_0021;
			IL_0021:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x38DED60", Offset = "0x38DD760", VA = "0x1838DED60")]
		public void Add(string key, string value)
		{
			//Discarded unreachable code: IL_000f
			IDictionary<string, ByteString> dictionary = Values;
			ByteString byteString = ByteString.CopyFromUtf8(value);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x38DEBC0", Offset = "0x38DD5C0", VA = "0x1838DEBC0")]
		public void Add(string key, bool value)
		{
			//Discarded unreachable code: IL_0014
			IDictionary<string, ByteString> dictionary = Values;
			ByteString byteString = ByteString.CopyFrom(BitConverter.GetBytes(value));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x38DEE20", Offset = "0x38DD820", VA = "0x1838DEE20")]
		public void Add(string key, int value)
		{
			//Discarded unreachable code: IL_0014
			IDictionary<string, ByteString> dictionary = Values;
			ByteString byteString = ByteString.CopyFrom(BitConverter.GetBytes(value));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x38DEB40", Offset = "0x38DD540", VA = "0x1838DEB40")]
		public void Add(string key, long value)
		{
			//Discarded unreachable code: IL_000f
			IDictionary<string, ByteString> dictionary = Values;
			ByteString byteString = ByteStringConverter.FromLong(value);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x38DEF10", Offset = "0x38DD910", VA = "0x1838DEF10")]
		public void Add(string key, DateTime value)
		{
			//Discarded unreachable code: IL_000f
			IDictionary<string, ByteString> dictionary = Values;
			long value2 = default(long);
			ByteString byteString = ByteStringConverter.FromLong(value2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x38DECB0", Offset = "0x38DD6B0", VA = "0x1838DECB0")]
		public void Add(string key, byte[] value)
		{
			//Discarded unreachable code: IL_000f
			IDictionary<string, ByteString> dictionary = Values;
			ByteString byteString = ByteString.CopyFrom(value);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x38DF060", Offset = "0x38DDA60", VA = "0x1838DF060")]
		public bool GetBoolean(string key)
		{
			//Discarded unreachable code: IL_0011
			IDictionary<string, ByteString> dictionary = Values;
			int startIndex = 0;
			byte[] value = default(byte[]);
			return BitConverter.ToBoolean(value, startIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x38DF190", Offset = "0x38DDB90", VA = "0x1838DF190")]
		public DateTime GetDateTime(string key)
		{
			//Discarded unreachable code: IL_0016
			IDictionary<string, ByteString> dictionary = Values;
			int startIndex = 0;
			byte[] value = default(byte[]);
			return DateTime.FromBinary(BitConverter.ToInt64(value, startIndex));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x38DF290", Offset = "0x38DDC90", VA = "0x1838DF290")]
		public int GetInt(string key)
		{
			//Discarded unreachable code: IL_0011
			IDictionary<string, ByteString> dictionary = Values;
			int startIndex = 0;
			byte[] value = default(byte[]);
			return BitConverter.ToInt32(value, startIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x38DF350", Offset = "0x38DDD50", VA = "0x1838DF350")]
		public long GetLong(string key)
		{
			//Discarded unreachable code: IL_0011
			IDictionary<string, ByteString> dictionary = Values;
			int startIndex = 0;
			byte[] value = default(byte[]);
			return BitConverter.ToInt64(value, startIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x38DF410", Offset = "0x38DDE10", VA = "0x1838DF410")]
		public string GetString(string key)
		{
			//Discarded unreachable code: IL_0009
			IDictionary<string, ByteString> dictionary = Values;
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x38DF120", Offset = "0x38DDB20", VA = "0x1838DF120")]
		public byte[] GetBytes(string key)
		{
			//Discarded unreachable code: IL_0009
			IDictionary<string, ByteString> dictionary = Values;
			byte[] result = default(byte[]);
			return result;
		}
	}
}
