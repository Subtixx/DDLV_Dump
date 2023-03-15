using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Scene;
using Mdl.Audio;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AudioSurface : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private AudioSurfaceAreas currentArea;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private List<AudioSurfaceAreas> areas;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1509ED0", Offset = "0x15088D0", VA = "0x181509ED0")]
	public void Start()
	{
		//Discarded unreachable code: IL_007a
		Type typeFromHandle = typeof(AudioSurfaceAreas);
		Component[] componentsInChildren = GetComponentsInChildren(typeFromHandle);
		List<AudioSurfaceAreas> list = (areas = (List<AudioSurfaceAreas>)(object)new List<T>());
		int num = 0;
		int num2 = 0;
		int length = componentsInChildren.Length;
		if (num < length)
		{
			List<AudioSurfaceAreas> list2 = areas;
			Component component = componentsInChildren[num2];
			if ((object)component == null)
			{
			}
			int num3 = 0;
			if ((object)component == null)
			{
				throw new InvalidCastException();
			}
			num2++;
		}
		AudioManager.OnVillageTypeChanged -= AudioController_OnVillageTypeChanged;
		AudioManager.OnVillageTypeChanged += AudioController_OnVillageTypeChanged;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1509C90", Offset = "0x1508690", VA = "0x181509C90")]
	private void AudioController_OnVillageTypeChanged(VillageAreaType villageType)
	{
		//Discarded unreachable code: IL_007a
		//IL_0038: Expected O, but got I4
		//IL_004f: Expected O, but got I4
		List<AudioSurfaceAreas> list = areas;
		Func<AudioSurfaceAreas, bool> func = (Func<AudioSurfaceAreas, bool>)(object)(Func<T, TResult>)delegate(AudioSurfaceAreas x)
		{
			//Discarded unreachable code: IL_0011
			VillageAreaType villageAreaType2 = villageType;
			return x.villageAreType == villageAreaType2;
		};
		AudioSurfaceAreas audioSurfaceAreas = Enumerable.FirstOrDefault<AudioSurfaceAreas>((IEnumerable<>)list, (Func<, >)(object)func);
		int num = 0;
		if (!(audioSurfaceAreas != (UnityEngine.Object)num))
		{
			return;
		}
		AudioSurfaceAreas audioSurfaceAreas2 = currentArea;
		int num2 = 0;
		if (!(audioSurfaceAreas2 == (UnityEngine.Object)num2))
		{
			VillageAreaType villageAreaType = villageType;
			if (audioSurfaceAreas2.villageAreType == villageAreaType)
			{
				return;
			}
		}
		audioSurfaceAreas2?.DisableAudioRaycast();
		currentArea = audioSurfaceAreas;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1509E30", Offset = "0x1508830", VA = "0x181509E30")]
	private void OnDestroy()
	{
		AudioManager.OnVillageTypeChanged -= AudioController_OnVillageTypeChanged;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AudioSurface()
	{
	}
}
