using System;
using System.Text;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class IdempotencyIdGenerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private string name;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		private IdempotencyIdGenerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x116DE40", Offset = "0x116C840", VA = "0x18116DE40")]
		public static IdempotencyIdGenerator Create(Guid guid, string name)
		{
			if ((object)typeof(IdempotencyIdGenerator).TypeHandle == null)
			{
				Guid empty = Guid.Empty;
				bool flag = default(bool);
				if (flag)
				{
					IdempotencyIdGenerator idempotencyIdGenerator = new IdempotencyIdGenerator();
					idempotencyIdGenerator.name = name;
					return idempotencyIdGenerator;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x116DF40", Offset = "0x116C940", VA = "0x18116DF40")]
		public unsafe static IdempotencyIdGenerator Create(string namespaceId, string name)
		{
			//IL_0024: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			int num = 0;
			if (!Guid.TryParse(namespaceId, out *(Guid*)num))
			{
				int num2 = 0;
			}
			if (!string.IsNullOrEmpty(name))
			{
				Guid empty = Guid.Empty;
				if ((Guid)num != empty)
				{
					IdempotencyIdGenerator idempotencyIdGenerator = new IdempotencyIdGenerator();
					idempotencyIdGenerator.name = name;
					idempotencyIdGenerator.guid = (Guid)num;
					return idempotencyIdGenerator;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x116E0B0", Offset = "0x116CAB0", VA = "0x18116E0B0")]
		public string GetUniqueIdempotencyId()
		{
			string text = name;
			if (text != null)
			{
				int num = 0;
				byte[] bytes = Encoding.UTF8.GetBytes(text);
				string result = default(string);
				return result;
			}
			ArgumentNullException ex = new ArgumentNullException("name");
			/*Error: Unexpected end of block*/;
		}
	}
}
