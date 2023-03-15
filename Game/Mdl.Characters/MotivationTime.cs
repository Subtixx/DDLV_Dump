using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008AF")]
	internal class MotivationTime
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40030D1")]
		private int lastUpdatedFrame = int.MinValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40030D2")]
		private float lastElapsedTime = float.NaN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030D3")]
		private float deltaTime;

		[Cpp2IlInjected.Token(Token = "0x600282A")]
		[Cpp2IlInjected.Address(RVA = "0xEFD8C0", Offset = "0xEFC2C0", VA = "0x180EFD8C0")]
		public static implicit operator float(MotivationTime motivationTime)
		{
			//Discarded unreachable code: IL_0065
			int num = motivationTime.lastUpdatedFrame;
			int num2 = 0;
			int frameCount = Time.frameCount;
			if (num != frameCount)
			{
				int num3 = 0;
				float num4 = Time.deltaTime;
				int num5 = 0;
				motivationTime.deltaTime = num4;
				float time = Time.time;
				if (!float.IsNaN(motivationTime.lastElapsedTime))
				{
					motivationTime.deltaTime = time;
				}
				int num6 = 0;
				motivationTime.lastElapsedTime = time;
				int num7 = (motivationTime.lastUpdatedFrame = Time.frameCount);
			}
			return motivationTime.deltaTime;
		}

		[Cpp2IlInjected.Token(Token = "0x600282B")]
		[Cpp2IlInjected.Address(RVA = "0xEFD810", Offset = "0xEFC210", VA = "0x180EFD810")]
		private float GetUpdatedTime()
		{
			int num = lastUpdatedFrame;
			int num2 = 0;
			int frameCount = Time.frameCount;
			if (num != frameCount)
			{
				int num3 = 0;
				float num4 = Time.deltaTime;
				int num5 = 0;
				deltaTime = num4;
				float time = Time.time;
				if (!float.IsNaN(lastElapsedTime))
				{
					deltaTime = time;
				}
				int num6 = 0;
				lastElapsedTime = time;
				int num7 = (lastUpdatedFrame = Time.frameCount);
			}
			return deltaTime;
		}

		[Cpp2IlInjected.Token(Token = "0x600282C")]
		[Cpp2IlInjected.Address(RVA = "0xEFD890", Offset = "0xEFC290", VA = "0x180EFD890")]
		internal void Reset()
		{
			//IL_0010: Expected I4, but got I8
			lastUpdatedFrame = int.MinValue;
			lastElapsedTime = float.NaN;
		}

		[Cpp2IlInjected.Token(Token = "0x600282D")]
		[Cpp2IlInjected.Address(RVA = "0xEFD8A0", Offset = "0xEFC2A0", VA = "0x180EFD8A0")]
		public MotivationTime()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
