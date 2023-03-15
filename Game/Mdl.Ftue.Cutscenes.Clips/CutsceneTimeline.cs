using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Video;

namespace Mdl.Ftue.Cutscenes.Clips
{
	[Cpp2IlInjected.Token(Token = "0x200060D")]
	public class CutsceneTimeline : CutsceneClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002485")]
		[SerializeField]
		public PlayableDirector playableDirector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002486")]
		private bool cutsceneStarted;

		[Cpp2IlInjected.Token(Token = "0x6001ACD")]
		[Cpp2IlInjected.Address(RVA = "0x1113560", Offset = "0x1111F60", VA = "0x181113560")]
		private void SetupTimelineTracks()
		{
			//Discarded unreachable code: IL_0037
			if (!cutsceneStarted)
			{
				playableDirector.GetComponent<CameraBinding>()?.BindTimelineTracks();
				playableDirector.GetComponent<TimelineCharacters>()?.SetupCharacters();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACE")]
		[Cpp2IlInjected.Address(RVA = "0x11132D0", Offset = "0x1111CD0", VA = "0x1811132D0", Slot = "4")]
		public override bool Play(float elapsed)
		{
			//IL_0010: Expected O, but got I4
			PlayableDirector playableDirector = this.playableDirector;
			int num = 0;
			if (!(playableDirector == (UnityEngine.Object)num))
			{
				Transform parent = base.transform.parent;
				Type typeFromHandle = typeof(Camera);
				Component[] componentsInChildren = parent.GetComponentsInChildren(typeFromHandle);
				int num2 = 0;
				int length = componentsInChildren.Length;
				if (num2 < length)
				{
					GameObject gameObject = componentsInChildren[num2].gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					num2++;
				}
				if (!cutsceneStarted)
				{
					this.playableDirector.GetComponent<CameraBinding>()?.BindTimelineTracks();
					this.playableDirector.GetComponent<TimelineCharacters>()?.SetupCharacters();
				}
				if (this.playableDirector.state != PlayState.Playing)
				{
					if (cutsceneStarted)
					{
						cutsceneStarted = false;
						CutsceneCleanUp();
						int num3 = 0;
						goto IL_00e4;
					}
					PlayableDirector playableDirector2 = this.playableDirector;
					cutsceneStarted = true;
					playableDirector2.Play();
				}
				return true;
			}
			goto IL_00e4;
			IL_00e4:
			int num4 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACF")]
		[Cpp2IlInjected.Address(RVA = "0x11135F0", Offset = "0x1111FF0", VA = "0x1811135F0", Slot = "5")]
		public override void Stop()
		{
			//Discarded unreachable code: IL_002a
			if (this.playableDirector.state == PlayState.Playing)
			{
				PlayableDirector playableDirector = this.playableDirector;
				cutsceneStarted = false;
				playableDirector.Stop();
				CutsceneCleanUp();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD0")]
		[Cpp2IlInjected.Address(RVA = "0x1113290", Offset = "0x1111C90", VA = "0x181113290", Slot = "6")]
		public override void Pause()
		{
			//Discarded unreachable code: IL_001b
			if (playableDirector.state == PlayState.Playing)
			{
				playableDirector.Pause();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD1")]
		[Cpp2IlInjected.Address(RVA = "0x1113520", Offset = "0x1111F20", VA = "0x181113520", Slot = "7")]
		public override void Resume()
		{
			//Discarded unreachable code: IL_001b
			if (playableDirector.state != PlayState.Playing)
			{
				playableDirector.Resume();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD2")]
		[Cpp2IlInjected.Address(RVA = "0x1113190", Offset = "0x1111B90", VA = "0x181113190")]
		private void DisableCutsceneCameras()
		{
			//Discarded unreachable code: IL_004d
			Transform parent = base.transform.parent;
			Type typeFromHandle = typeof(Camera);
			Component[] componentsInChildren = parent.GetComponentsInChildren(typeFromHandle);
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				GameObject gameObject = componentsInChildren[num].gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD3")]
		[Cpp2IlInjected.Address(RVA = "0x1112D70", Offset = "0x1111770", VA = "0x181112D70")]
		private void CutsceneCleanUp()
		{
			//Discarded unreachable code: IL_0106
			//IL_0063: Expected I4, but got I8
			//IL_00b0: Expected I4, but got I8
			//IL_00e3: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			Debug.Log("CutsceneCleanUp ");
			ITimelineCutsceneCleanUp[] components = playableDirector.gameObject.GetComponents<ITimelineCutsceneCleanUp>();
			int num = 0;
			int length = components.Length;
			if (num < length)
			{
				ITimelineCutsceneCleanUp timelineCutsceneCleanUp = components[num];
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num++;
				num += num;
				num += 312;
				num++;
			}
			ulong num3 = default(ulong);
			ITimelineCutsceneCleanUp[] componentsInChildren = base.transform.parent.GetComponentsInChildren<ITimelineCutsceneCleanUp>((byte)num3 != 0);
			int length2 = componentsInChildren.Length;
			if (num < length2)
			{
				ITimelineCutsceneCleanUp timelineCutsceneCleanUp2 = componentsInChildren[num];
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
				num++;
				num += num;
				num += 312;
				num++;
			}
			ulong num5 = default(ulong);
			VideoPlayer[] componentsInChildren2 = base.transform.parent.GetComponentsInChildren<VideoPlayer>((byte)num5 != 0);
			int length3 = componentsInChildren2.Length;
			if (num < length3)
			{
				VideoPlayer videoPlayer = componentsInChildren2[num];
				if ((object)videoPlayer != null)
				{
					RenderTexture targetTexture = videoPlayer.targetTexture;
				}
				int num6 = 0;
				if (!((UnityEngine.Object)num == (UnityEngine.Object)num6))
				{
					int num7 = 0;
					RenderTexture targetTexture2 = videoPlayer.targetTexture;
					int num8 = 0;
					videoPlayer.targetTexture.Release();
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AD4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CutsceneTimeline()
		{
		}
	}
}
