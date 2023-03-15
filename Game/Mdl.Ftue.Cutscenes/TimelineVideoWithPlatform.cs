using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.Video;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x2000602")]
	public class TimelineVideoWithPlatform : VideoScriptPlayableAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400245D")]
		[SerializeField]
		public List<FMVVideoClipForPlatforms> platformVideosMap;

		[Cpp2IlInjected.Token(Token = "0x6001A94")]
		[Cpp2IlInjected.Address(RVA = "0x13D20E0", Offset = "0x13D0AE0", VA = "0x1813D20E0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			//IL_0015: Expected I4, but got O
			//IL_001c: Expected I4, but got O
			//IL_0023: Expected F8, but got O
			//IL_002a: Expected F8, but got O
			TimelineVideoWithPlatformPlayableBehaviour timelineVideoWithPlatformPlayableBehaviour = default(TimelineVideoWithPlatformPlayableBehaviour);
			VideoPlayer videoPlayer = default(VideoPlayer);
			timelineVideoWithPlatformPlayableBehaviour.videoPlayer = videoPlayer;
			timelineVideoWithPlatformPlayableBehaviour.videoClip = (VideoClip)(object)videoPlayer;
			timelineVideoWithPlatformPlayableBehaviour.mute = (byte)(int)videoPlayer != 0;
			timelineVideoWithPlatformPlayableBehaviour.loop = (byte)(int)videoPlayer != 0;
			timelineVideoWithPlatformPlayableBehaviour.preloadTime = (double)videoPlayer;
			timelineVideoWithPlatformPlayableBehaviour.clipInTime = (double)videoPlayer;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A95")]
		[Cpp2IlInjected.Address(RVA = "0x13D2270", Offset = "0x13D0C70", VA = "0x1813D2270")]
		private void SetVideoForPlatform()
		{
			//Discarded unreachable code: IL_0022, IL_0028
			//IL_0021: Expected O, but got I4
			List<FMVVideoClipForPlatforms> list = platformVideosMap;
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				int platform = (int)Application.platform;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				videoClip = (VideoClip)platform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A96")]
		[Cpp2IlInjected.Address(RVA = "0x13D23C0", Offset = "0x13D0DC0", VA = "0x1813D23C0")]
		public TimelineVideoWithPlatform()
		{
		}
	}
}
