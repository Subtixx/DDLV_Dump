using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Video;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x2000604")]
	public class VideoPlayerClear : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400245E")]
		public VideoPlayer videoplayerToClear;

		[Cpp2IlInjected.Token(Token = "0x6001A9A")]
		[Cpp2IlInjected.Address(RVA = "0xD46640", Offset = "0xD45040", VA = "0x180D46640")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0067
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			VideoPlayer videoPlayer = videoplayerToClear;
			if ((object)videoPlayer != null)
			{
				RenderTexture targetTexture = videoPlayer.targetTexture;
			}
			int num = 0;
			int num2 = 0;
			if (!((Object)num == (Object)num2))
			{
				int num3 = 0;
				RenderTexture active = RenderTexture.GetActive();
				RenderTexture.SetActive(videoplayerToClear.targetTexture);
				int num4 = 0;
				videoplayerToClear.targetTexture.Release();
				GameObject gameObject = videoplayerToClear.gameObject;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A9B")]
		[Cpp2IlInjected.Address(RVA = "0xD46640", Offset = "0xD45040", VA = "0x180D46640")]
		private void ClearVideo()
		{
			//Discarded unreachable code: IL_0067
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			VideoPlayer videoPlayer = videoplayerToClear;
			if ((object)videoPlayer != null)
			{
				RenderTexture targetTexture = videoPlayer.targetTexture;
			}
			int num = 0;
			int num2 = 0;
			if (!((Object)num == (Object)num2))
			{
				int num3 = 0;
				RenderTexture active = RenderTexture.GetActive();
				RenderTexture.SetActive(videoplayerToClear.targetTexture);
				int num4 = 0;
				videoplayerToClear.targetTexture.Release();
				GameObject gameObject = videoplayerToClear.gameObject;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A9C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public VideoPlayerClear()
		{
		}
	}
}
