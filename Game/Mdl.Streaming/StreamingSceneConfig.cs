using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x2000812")]
	public class StreamingSceneConfig : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D19")]
		public StreamingSceneType SceneType;

		[Cpp2IlInjected.Token(Token = "0x6002437")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public StreamingSceneConfig()
		{
		}
	}
}
