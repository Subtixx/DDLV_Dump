using Cpp2IlInjected;
using Gameloft.Tracking.Pipeline.Standard.Serialization.Binary;
using Gameloft.Tracking.Serialization;
using Gameloft.Tracking.Serialization.Json;

namespace Gameloft.Tracking.Pipeline.Standard.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class FormattersFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private SerializationFormat format;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D9890", Offset = "0x8D8290", VA = "0x1808D9890")]
		public FormattersFactory(SerializationFormat format)
		{
			this.format = format;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28C19F0", Offset = "0x28C03F0", VA = "0x1828C19F0", Slot = "4")]
		public TrackerFormatter Create()
		{
			SerializationFormat serializationFormat = format;
			if (serializationFormat == SerializationFormat.Json)
			{
				JsonFormatter jsonFormatter = new JsonFormatter();
			}
			if (serializationFormat == SerializationFormat.Binary)
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
