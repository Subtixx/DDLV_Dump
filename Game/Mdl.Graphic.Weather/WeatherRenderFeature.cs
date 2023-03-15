using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004E4")]
	public class WeatherRenderFeature : ScriptableRendererFeature
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20004E5")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001E9A")]
			[Space]
			[Header("Sky prepass")]
			[Space(20f)]
			public Shader skyPrepassShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001E9B")]
			[Space]
			[Header("Fog")]
			[Space(20f)]
			public Shader fogShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001E9C")]
			public bool useCulling = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4001E9D")]
			[Min(0f)]
			[Tooltip("this is the worldSpace max height of the culling fog")]
			public float cullMaxHeight = 75f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4001E9E")]
			[Range(0f, 1f)]
			[Tooltip("Fog opacity past cullMaxDistance")]
			public float cullFarOpacity = 0.95f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001E9F")]
			public Cubemap nightDome;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001EA0")]
			public Texture2D noiseTex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001EA1")]
			public float noiseTilling = 1f;

			[Cpp2IlInjected.Token(Token = "0x600158C")]
			[Cpp2IlInjected.Address(RVA = "0xF87E30", Offset = "0xF86830", VA = "0x180F87E30")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E96")]
		public Settings settings = new Settings();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E97")]
		private FogPass fogPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E98")]
		private SkyPrepass skyPrepass;

		[Cpp2IlInjected.Token(Token = "0x4001E99")]
		public static Shader skyPrepassShader;

		[Cpp2IlInjected.Token(Token = "0x6001589")]
		[Cpp2IlInjected.Address(RVA = "0x839B40", Offset = "0x838540", VA = "0x180839B40", Slot = "5")]
		public override void Create()
		{
			FogPass fogPass = (this.fogPass = new FogPass(settings));
			SkyPrepass skyPrepass = (this.skyPrepass = new SkyPrepass(settings));
			skyPrepassShader = settings.skyPrepassShader;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600158A")]
		[Cpp2IlInjected.Address(RVA = "0x8399C0", Offset = "0x8383C0", VA = "0x1808399C0", Slot = "6")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			//Discarded unreachable code: IL_004a
			//IL_002a: Expected O, but got I4
			int postProcess = (int)WeatherController.GetPostProcess(ignoreOverride: false);
			SkyPrepass pass = skyPrepass;
			renderer.EnqueuePass(pass);
			Shader fogShader = settings.fogShader;
			int num = 0;
			if (fogShader != (UnityEngine.Object)num)
			{
				fogPass.Setup(renderer);
				FogPass pass2 = fogPass;
				renderer.EnqueuePass(pass2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600158B")]
		[Cpp2IlInjected.Address(RVA = "0x839C20", Offset = "0x838620", VA = "0x180839C20")]
		public WeatherRenderFeature()
		{
		}
	}
}
