using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Graphic
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20004B1")]
	public struct PostProcessOverride : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60014DC")]
		[Cpp2IlInjected.Address(RVA = "0xCB70C0", Offset = "0xCB5AC0", VA = "0x180CB70C0")]
		public PostProcessOverride(VolumeProfile postProcessProfile)
		{
			//Discarded unreachable code: IL_002f
			//IL_000f: Expected O, but got I4
			PostProcessManager instance = PostProcessManager.Instance;
			int num = 0;
			bool flag = default(bool);
			if (!(postProcessProfile != (UnityEngine.Object)num) || flag)
			{
			}
			((Stack<T>)(object)instance.postProcessOverrides).Push((T)postProcessProfile);
			instance.TransitionToNewPostProcess(postProcessProfile, 0.5f);
		}

		[Cpp2IlInjected.Token(Token = "0x60014DD")]
		[Cpp2IlInjected.Address(RVA = "0xCB6FA0", Offset = "0xCB59A0", VA = "0x180CB6FA0", Slot = "4")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0039
			PostProcessManager instance = PostProcessManager.Instance;
			Stack<VolumeProfile> postProcessOverrides = instance.postProcessOverrides;
			Debug.LogWarning("PostProcessOverride Push / Pop is unbalanced");
			VolumeProfile volumeProfile = (VolumeProfile)((Stack<T>)(object)instance.postProcessOverrides).Peek();
			VolumeProfile baseProfile = instance.baseProfile;
			instance.TransitionToNewPostProcess(baseProfile, 0.5f);
		}
	}
}
