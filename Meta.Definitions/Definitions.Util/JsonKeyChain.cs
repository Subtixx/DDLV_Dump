using System;
using Cpp2IlInjected;
using Gameloft.FileSystem.Abstraction;
using Newtonsoft.Json.Linq;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	public class JsonKeyChain : IKeyChain
	{
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public static string FileName = "keychain.json";

		[Cpp2IlInjected.Token(Token = "0x1700034B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40005FE")]
		private IFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6000DA1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40005FF")]
		private string Path
		{
			[Cpp2IlInjected.Token(Token = "0x6000DA2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA3")]
		[Cpp2IlInjected.Address(RVA = "0x2738BA0", Offset = "0x27375A0", VA = "0x182738BA0")]
		public JsonKeyChain(IFileSystem fs, string path)
		{
			FileSystem = fs;
			Path = path;
			Create();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA4")]
		[Cpp2IlInjected.Address(RVA = "0x2738580", Offset = "0x2736F80", VA = "0x182738580")]
		private void Create()
		{
			if (Load() == null)
			{
				IFileSystem self = FileSystem;
				string path = Path;
				self.WriteAllText(path, "{}");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA5")]
		[Cpp2IlInjected.Address(RVA = "0x27386C0", Offset = "0x27370C0", VA = "0x1827386C0")]
		private bool Exists()
		{
			return Load() != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA6")]
		[Cpp2IlInjected.Address(RVA = "0x2738770", Offset = "0x2737170", VA = "0x182738770")]
		private JObject Load()
		{
			//Discarded unreachable code: IL_0041
			IFileSystem fileSystem = FileSystem;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if ((object)typeof(IReadOnlyFileSystem).TypeHandle != null)
			{
				IFileSystem self = FileSystem;
				string path = Path;
				string json = self.ReadAllText(path);
				int num3 = 0;
				return JObject.Parse(json);
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA7")]
		[Cpp2IlInjected.Address(RVA = "0x27388A0", Offset = "0x27372A0", VA = "0x1827388A0")]
		private void Save(JObject newKeyChain)
		{
			//Discarded unreachable code: IL_001e
			IFileSystem self = FileSystem;
			string path = Path;
			string text = newKeyChain.ToString();
			self.WriteAllText(path, text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA8")]
		[Cpp2IlInjected.Address(RVA = "0x27386E0", Offset = "0x27370E0", VA = "0x1827386E0", Slot = "4")]
		public string Get(string key)
		{
			if (Load() != null)
			{
				uint num = num + 20;
				num += num;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA9")]
		[Cpp2IlInjected.Address(RVA = "0x2738940", Offset = "0x2737340", VA = "0x182738940", Slot = "5")]
		public string Set(string key, string value)
		{
			Create();
			JObject jObject = Load();
			uint num = num + 20;
			num += num;
			JToken jToken2 = (jObject[key] = value);
			IFileSystem self = FileSystem;
			string path = Path;
			string text = jObject.ToString();
			self.WriteAllText(path, text);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAA")]
		[Cpp2IlInjected.Address(RVA = "0x2738AA0", Offset = "0x27374A0", VA = "0x182738AA0", Slot = "6")]
		public bool TryGet(string key, out string value)
		{
			while (Load() == null)
			{
			}
			uint num = num + 20;
			num += num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAB")]
		[Cpp2IlInjected.Address(RVA = "0x2738610", Offset = "0x2737010", VA = "0x182738610", Slot = "7")]
		public void Delete(string key)
		{
			JObject jObject = Load();
			if (jObject != null)
			{
				bool flag = jObject.Remove(key);
				IFileSystem self = FileSystem;
				string path = Path;
				string text = jObject.ToString();
				self.WriteAllText(path, text);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAC")]
		[Cpp2IlInjected.Address(RVA = "0x2738B50", Offset = "0x2737550", VA = "0x182738B50")]
		static JsonKeyChain()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
