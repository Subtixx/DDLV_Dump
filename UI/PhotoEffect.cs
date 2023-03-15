using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Ui.Photo;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PhotoEffect : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public List<PhotoEffectData> listPhotoEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private PhotoLensRenderer photoLensRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public float lensAnimationTime = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public float animationTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool shouldAnimateLens;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public PhotoEffectData currentEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public PhotoFrame photoFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool usePostProcessing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private UniversalAdditionalCameraData camera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public float photoEffectAnimationTime = 0.5f;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private int PhotoEffectAnimationTimeMs
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9BFD70", Offset = "0x9BE770", VA = "0x1809BFD70")]
		get
		{
			float num = photoEffectAnimationTime;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x9BF610", Offset = "0x9BE010", VA = "0x1809BF610")]
	private void Start()
	{
		//Discarded unreachable code: IL_00a6
		//IL_007e: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		ScriptableRenderer obj = default(ScriptableRenderer);
		bool flag = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			if (num2 == 0)
			{
				break;
			}
			int num6 = 0;
			if (num2 == 0)
			{
				break;
			}
			int num7 = 0;
			FieldInfo[] fields = typeof(ScriptableRenderer).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			int num8 = 0;
			if (num8 < fields.Length)
			{
				FieldInfo fieldInfo = fields[num8];
				if (fieldInfo.Name != null)
				{
					object value = fieldInfo.GetValue(obj);
					int num9 = 0;
					int num10 = 0;
					if (flag)
					{
						if (num2 == 0)
						{
						}
						int num11 = 0;
						int num12 = 0;
						if (!((UnityEngine.Object)num2 != (UnityEngine.Object)num12))
						{
							continue;
						}
						photoLensRenderer = (PhotoLensRenderer)num2;
					}
				}
				num8++;
			}
			int num13 = 0;
			bool renderPostProcessing = Camera.main.GetComponent<UniversalAdditionalCameraData>().m_RenderPostProcessing;
			return;
		}
		throw new InvalidCastException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x9BF5F0", Offset = "0x9BDFF0", VA = "0x1809BF5F0")]
	private void OnDestroy()
	{
		//Discarded unreachable code: IL_0016
		UniversalAdditionalCameraData universalAdditionalCameraData = camera;
		bool flag = (universalAdditionalCameraData.m_RenderPostProcessing = usePostProcessing);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x9BFC10", Offset = "0x9BE610", VA = "0x1809BFC10")]
	[AsyncStateMachine(typeof(_003CchangePhotoEffect_003Ed__14))]
	public Task changePhotoEffect(int index, PhotoModeImageFormat format, Transform parent, Vector2 frameSize, bool isClose, CancellationToken ct)
	{
		int num = 0;
		Task result = default(Task);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x9BFA60", Offset = "0x9BE460", VA = "0x1809BFA60")]
	private void Update()
	{
		//Discarded unreachable code: IL_0094
		//IL_003d: Expected O, but got I4
		if (!shouldAnimateLens)
		{
			return;
		}
		if (!(lensAnimationTime >= animationTime))
		{
			animationTime = 0f;
			shouldAnimateLens = false;
			return;
		}
		PhotoEffectData photoEffectData = currentEffect;
		int num = 0;
		if (photoEffectData != (UnityEngine.Object)num)
		{
			PhotoLensEffect photoLens = photoLensRenderer.photoLens;
			float value = default(float);
			photoLens.material.SetFloat("_Strength_1", value);
			float value2 = default(float);
			photoLens.material.SetFloat("_Strength_2", value2);
			photoLens.material.SetFloat("_Strength_3", value2);
			int num2 = 0;
			float num3 = (animationTime = Time.deltaTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x9BFBF0", Offset = "0x9BE5F0", VA = "0x1809BFBF0")]
	public PhotoEffect()
	{
	}
}
