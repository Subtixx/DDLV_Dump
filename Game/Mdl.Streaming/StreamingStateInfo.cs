using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x2000813")]
	internal class StreamingStateInfo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4002D1A")]
		public static StreamingStateInfo Instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D1B")]
		private int CurrentlyStreamingCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002D1C")]
		[SerializeField]
		private float MaxWaitTime = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D1D")]
		private int[] debugFrameStreamCount = new int[120];

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D1E")]
		private int debugFrameStreamCountIndex;

		[Cpp2IlInjected.Token(Token = "0x17000528")]
		public int InProgressCount
		{
			[Cpp2IlInjected.Token(Token = "0x6002438")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return CurrentlyStreamingCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002439")]
		[Cpp2IlInjected.Address(RVA = "0x1064100", Offset = "0x1062B00", VA = "0x181064100")]
		private void Awake()
		{
			Instance = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600243A")]
		[Cpp2IlInjected.Address(RVA = "0x10642D0", Offset = "0x1062CD0", VA = "0x1810642D0")]
		[AsyncStateMachine(typeof(_003CWaitForCullingGroupStreamingManagersDrained_003Ed__8))]
		public Task WaitForCullingGroupStreamingManagersDrained()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600243B")]
		[Cpp2IlInjected.Address(RVA = "0x1064170", Offset = "0x1062B70", VA = "0x181064170")]
		internal void StartLoadingBoost()
		{
			//Discarded unreachable code: IL_0031
			CullingGroupStreamingManager[] components = GetComponents<CullingGroupStreamingManager>();
			int num = 0;
			DistanceCullingManager instance = DistanceCullingManager.Instance;
			int length = components.Length;
			if (num < length)
			{
				components[num].StartBoostLoadLimit();
				num++;
			}
			instance.StartBoostLoadLimit();
		}

		[Cpp2IlInjected.Token(Token = "0x600243C")]
		[Cpp2IlInjected.Address(RVA = "0x1064230", Offset = "0x1062C30", VA = "0x181064230")]
		internal void StopLoadingBoost()
		{
			//Discarded unreachable code: IL_0025
			CullingGroupStreamingManager[] components = GetComponents<CullingGroupStreamingManager>();
			int num = 0;
			int length = components.Length;
			if (num < length)
			{
				components[num].StopBoostLoadLimit();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600243D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_STREAMING_STATE_INFO_ONSCREEN")]
		private void Onscreen(string key, int value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600243E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_STREAMING_STATE_INFO_ONSCREEN")]
		private void Onscreen(string key, float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600243F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_STREAMING_STATE_INFO_ONSCREEN")]
		private void Onscreen(string key, string value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002440")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_STREAMING_STATE_INFO_ONSCREEN")]
		private void ClearOnscreen()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002441")]
		[Cpp2IlInjected.Address(RVA = "0x1064160", Offset = "0x1062B60", VA = "0x181064160")]
		internal void IncrementStreaming(StreamableAssetRef streamableAssetRef)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002442")]
		[Cpp2IlInjected.Address(RVA = "0x1064150", Offset = "0x1062B50", VA = "0x181064150")]
		internal void DecrementStreaming(StreamableAssetRef streamableAssetRef)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002443")]
		[Cpp2IlInjected.Address(RVA = "0x10643D0", Offset = "0x1062DD0", VA = "0x1810643D0")]
		public StreamingStateInfo()
		{
		}
	}
}
