using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using Gameloft.Tracking.Encryption;
using Gameloft.Tracking.Storage;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Gameloft.Tracking.Device.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeyValueStorage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IStorageSlotFileSystem storageFs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private uint[] cryptoKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, ConcurrentDictionary<string, JToken>> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private object syncObject = new object();

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000041")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ValueSet this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x402EF60", Offset = "0x402D960", VA = "0x18402EF60")]
			get
			{
				return GetValueSet(name);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x402ECF0", Offset = "0x402D6F0", VA = "0x18402ECF0")]
		public KeyValueStorage(string name, IStorageSlotFileSystem fs)
		{
			Name = name;
			if (fs != null)
			{
				storageFs = fs;
				int num = 0;
				Encoding uTF = Encoding.UTF8;
				string s = Name;
				uint num2 = default(uint);
				IEnumerable<byte> enumerable = (IEnumerable<byte>)Enumerable.Take<byte>((IEnumerable<>)(object)uTF.GetBytes(s), (int)num2);
				Func<byte, int, uint> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
				if (_003C_003E9__7_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				uint[] array = (cryptoKey = Enumerable.Select<byte, uint>((IEnumerable<>)enumerable, (Func<, , >)(object)_003C_003E9__7_).ToArray<uint>());
				Init();
				return;
			}
			ArgumentNullException ex = new ArgumentNullException("fs");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x402E1C0", Offset = "0x402CBC0", VA = "0x18402E1C0")]
		public unsafe ValueSet GetValueSet(string name)
		{
			//Discarded unreachable code: IL_0053, IL_0059
			//IL_004a: Expected O, but got I4
			int num = 0;
			object obj = syncObject;
			Monitor.Enter(obj, ref *(bool*)num);
			if (!((Dictionary<TKey, TValue>)(object)data).TryGetValue((TKey)name, out *(TValue*)num))
			{
				Dictionary<string, ConcurrentDictionary<string, JToken>> dictionary = data;
				ConcurrentDictionary<string, JToken> concurrentDictionary = (ConcurrentDictionary<string, JToken>)(object)new ConcurrentDictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			ValueSet valueSet = default(ValueSet);
			((Graphic)(object)valueSet).GraphicUpdateComplete();
			valueSet.parent = this;
			valueSet.values = (ConcurrentDictionary<string, JToken>)num;
			Monitor.Exit(obj);
			return valueSet;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x402E8D0", Offset = "0x402D2D0", VA = "0x18402E8D0")]
		internal unsafe void Store()
		{
			//Discarded unreachable code: IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6
			int num = 0;
			object obj = syncObject;
			Monitor.Enter(obj, ref *(bool*)num);
			StringWriter stringWriter = new StringWriter();
			JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter);
			JsonSerializer jsonSerializer = new JsonSerializer();
			Dictionary<string, ConcurrentDictionary<string, JToken>> value = data;
			jsonSerializer.Serialize(stringWriter, value);
			int num2 = 0;
			if (jsonTextWriter != null)
			{
			}
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			int num4 = 0;
			Encoding uTF = Encoding.UTF8;
			string s = stringWriter.ToString();
			byte[] bytes = uTF.GetBytes(s);
			int num5 = 0;
			if (num2 + num2 != 0)
			{
			}
			if (stringWriter != null)
			{
			}
			Monitor.Exit(obj);
			string message = default(string);
			Debug.LogWarning(message);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x402E360", Offset = "0x402CD60", VA = "0x18402E360")]
		private void Init()
		{
			//Discarded unreachable code: IL_00e4, IL_00ea, IL_00f0, IL_00f6
			//IL_0051: Expected O, but got I4
			int num = 0;
			IStorageSlotFileSystem storageSlotFileSystem = storageFs;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if (")" != null)
			{
				IStorageSlotFileSystem storageSlotFileSystem2 = storageFs;
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				short num4 = default(short);
				byte[] bytes = new byte[num4];
				int num5 = 0;
				uint[] array = cryptoKey;
				XXTEA.Decrypt((ArraySegment<>)num5, array);
				int num6 = 0;
				StringReader stringReader = new StringReader(Encoding.UTF8.GetString(bytes));
				JsonTextReader jsonTextReader = new JsonTextReader(stringReader);
				Dictionary<string, ConcurrentDictionary<string, JToken>> dictionary = default(Dictionary<string, ConcurrentDictionary<string, JToken>>);
				if (new JsonSerializer().Deserialize<Dictionary<string, ConcurrentDictionary<string, JToken>>>(jsonTextReader) == null)
				{
					dictionary = (Dictionary<string, ConcurrentDictionary<string, JToken>>)(object)new Dictionary<TKey, TValue>();
				}
				data = dictionary;
				dictionary = (Dictionary<string, ConcurrentDictionary<string, JToken>>)(object)((object)dictionary + (object)dictionary);
				dictionary = (Dictionary<string, ConcurrentDictionary<string, JToken>>)(object)((object)dictionary + (object)dictionary);
				if (jsonTextReader != null)
				{
				}
				if (stringReader != null)
				{
				}
				if (num != 0)
				{
				}
				string message = default(string);
				Debug.LogWarning(message);
				Dictionary<string, ConcurrentDictionary<string, JToken>> dictionary2 = (Dictionary<string, ConcurrentDictionary<string, JToken>>)(object)new Dictionary<TKey, TValue>();
				return;
			}
			string text = Name;
			Debug.Log("Kvs storage doesn't exists - create new one (name=" + text + ")");
			Dictionary<string, ConcurrentDictionary<string, JToken>> dictionary3 = (Dictionary<string, ConcurrentDictionary<string, JToken>>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}
	}
}
