using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class VirtualInput
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes = (Dictionary<string, CrossPlatformInputManager.VirtualAxis>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons = (Dictionary<string, CrossPlatformInputManager.VirtualButton>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		protected List<string> m_AlwaysUseVirtual = (List<string>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public unsafe Vector3 virtualMousePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xF0A3C0", Offset = "0xF08DC0", VA = "0x180F0A3C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xF0A930", Offset = "0xF09330", VA = "0x180F0A930")]
			[CompilerGenerated]
			private set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)_003CvirtualMousePosition_003Ek__BackingField)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3DC76F0", Offset = "0x3DC60F0", VA = "0x183DC76F0")]
		public bool AxisExists(string name)
		{
			//Discarded unreachable code: IL_000d
			return ((Dictionary<TKey, TValue>)(object)m_VirtualAxes).ContainsKey((TKey)name);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7750", Offset = "0x3DC6150", VA = "0x183DC7750")]
		public bool ButtonExists(string name)
		{
			//Discarded unreachable code: IL_000d
			return ((Dictionary<TKey, TValue>)(object)m_VirtualButtons).ContainsKey((TKey)name);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC77B0", Offset = "0x3DC61B0", VA = "0x183DC77B0")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001e, IL_0027, IL_0040, IL_0041, IL_0060
			Dictionary<string, CrossPlatformInputManager.VirtualAxis> virtualAxes = m_VirtualAxes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC78F0", Offset = "0x3DC62F0", VA = "0x183DC78F0")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001e, IL_0027, IL_0040, IL_0041, IL_0060
			Dictionary<string, CrossPlatformInputManager.VirtualButton> virtualButtons = m_VirtualButtons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7AF0", Offset = "0x3DC64F0", VA = "0x183DC7AF0")]
		public void UnRegisterVirtualAxis(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001e, IL_001f
			Dictionary<string, CrossPlatformInputManager.VirtualAxis> virtualAxes = m_VirtualAxes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7B70", Offset = "0x3DC6570", VA = "0x183DC7B70")]
		public void UnRegisterVirtualButton(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001e, IL_001f
			Dictionary<string, CrossPlatformInputManager.VirtualButton> virtualButtons = m_VirtualButtons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7BF0", Offset = "0x3DC65F0", VA = "0x183DC7BF0")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001e
			Dictionary<string, CrossPlatformInputManager.VirtualAxis> virtualAxes = m_VirtualAxes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7A30", Offset = "0x3DC6430", VA = "0x183DC7A30")]
		public unsafe void SetVirtualMousePositionX(float f)
		{
			//IL_0013: Expected native int or pointer, but got O
			float z = virtualMousePosition.z;
			((Vector3*)(IntPtr)virtualMousePosition)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7A70", Offset = "0x3DC6470", VA = "0x183DC7A70")]
		public unsafe void SetVirtualMousePositionY(float f)
		{
			//IL_0013: Expected native int or pointer, but got O
			float z = virtualMousePosition.z;
			((Vector3*)(IntPtr)virtualMousePosition)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7AB0", Offset = "0x3DC64B0", VA = "0x183DC7AB0")]
		public unsafe void SetVirtualMousePositionZ(float f)
		{
			//IL_0013: Expected native int or pointer, but got O
			float z = virtualMousePosition.z;
			((Vector3*)(IntPtr)virtualMousePosition)->z = f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract float GetAxis(string name, bool raw);

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool GetButton(string name);

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract bool GetButtonDown(string name);

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool GetButtonUp(string name);

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void SetButtonDown(string name);

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void SetButtonUp(string name);

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void SetAxisPositive(string name);

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void SetAxisNegative(string name);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void SetAxisZero(string name);

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract void SetAxis(string name, float value);

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract Vector3 MousePosition();

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2EB0", Offset = "0x3DC18B0", VA = "0x183DC2EB0")]
		protected VirtualInput()
		{
		}
	}
}
