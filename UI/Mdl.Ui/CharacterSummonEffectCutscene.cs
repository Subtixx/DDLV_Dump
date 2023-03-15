using Cpp2IlInjected;
using Mdl.Characters;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002E5")]
	public class CharacterSummonEffectCutscene : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000DF6")]
		private Material[] _materialsOriginal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000DF7")]
		private Material[] _materialsTemp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000DF8")]
		private Transform _container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000DF9")]
		private Character _character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000DFA")]
		private float _opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000DFB")]
		public Material MatFadeIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000DFC")]
		public GameObject VfxFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000DFD")]
		public GameObject VfxFlash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000DFE")]
		public GameObject VfxFadeIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000DFF")]
		public ParticleSystem ParticleFadeIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000E00")]
		[Space]
		public float FadeIn_DelayBeforeStart = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000E01")]
		public float FadeIn_Duration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000E02")]
		public float FadeIn_Shader_Opacity_ValueStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000E03")]
		public float FadeIn_Shader_Opacity_ValueEnd = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000E04")]
		public float FadeIn_Shader_Opacity_DelayBeforeStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000E05")]
		public float FadeIn_Shader_Opacity_Duration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000E06")]
		public eEaseType FadeIn_Shader_Opacity_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000E07")]
		[Space]
		public float Focus_DelayBeforeStart = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000E08")]
		public float Focus_Duration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000E09")]
		[Space]
		public float Flash_DelayBeforeStart = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000E0A")]
		public float Flash_Duration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000E0B")]
		private int _vfxCnt = 3;

		[Cpp2IlInjected.Token(Token = "0x17000339")]
		public float Opacity
		{
			[Cpp2IlInjected.Token(Token = "0x60012A2")]
			[Cpp2IlInjected.Address(RVA = "0xA82BB0", Offset = "0xA815B0", VA = "0x180A82BB0")]
			get
			{
				return _opacity;
			}
			[Cpp2IlInjected.Token(Token = "0x60012A3")]
			[Cpp2IlInjected.Address(RVA = "0xFFAFD0", Offset = "0xFF99D0", VA = "0x180FFAFD0")]
			set
			{
				//Discarded unreachable code: IL_0034
				Material[] materialsTemp = _materialsTemp;
				int num = 0;
				int length = materialsTemp.Length;
				if (num < length)
				{
					Material material = materialsTemp[num];
					_opacity = value;
					material.SetFloat("_Opacity", value);
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012A4")]
		[Cpp2IlInjected.Address(RVA = "0xFFAEA0", Offset = "0xFF98A0", VA = "0x180FFAEA0")]
		public void Setup(Character character)
		{
			//Discarded unreachable code: IL_002c
			_character = character;
			Transform transform = base.transform;
			float z = Vector3.zero.z;
			Transform transform2 = base.transform;
			float z2 = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60012A5")]
		[Cpp2IlInjected.Address(RVA = "0xFFAC80", Offset = "0xFF9680", VA = "0x180FFAC80")]
		public void PlayForCutscene()
		{
			//Discarded unreachable code: IL_007d
			base.gameObject.SetActive(value: true);
			float fadeIn_DelayBeforeStart = FadeIn_DelayBeforeStart;
			var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnFadeInStart)
			};
			TweenMax tweenMax = TweenMax.To(this, fadeIn_DelayBeforeStart, vars, int.MinValue, this);
			var vars2 = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnFocusStart)
			};
			TweenMax tweenMax2 = TweenMax.To(this, fadeIn_DelayBeforeStart, vars2, int.MinValue, this);
			var vars3 = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnFlashStart)
			};
			TweenMax tweenMax3 = TweenMax.To(this, fadeIn_DelayBeforeStart, vars3, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x60012A6")]
		[Cpp2IlInjected.Address(RVA = "0xFFA340", Offset = "0xFF8D40", VA = "0x180FFA340")]
		private void OnFadeInStart(ITween tween, object param)
		{
			//Discarded unreachable code: IL_01b3
			SkinnedMeshRenderer componentInChildren;
			Material[] array2;
			while (true)
			{
				componentInChildren = _character.GetComponentInChildren<SkinnedMeshRenderer>();
				ParticleSystem.MainModule main = ParticleFadeIn.main;
				Material[] array = (_materialsOriginal = ((Renderer)componentInChildren).GetMaterialArray());
				array2 = new Material[((Renderer)componentInChildren).GetMaterialArray().Length];
				Material[] materialArray = ((Renderer)componentInChildren).GetMaterialArray();
				int num = 0;
				int num2 = 0;
				int length = materialArray.Length;
				if (num >= length)
				{
					break;
				}
				Material matFadeIn = MatFadeIn;
				Material material = materialArray[num2];
				Material material2 = new Material(matFadeIn);
				Texture texture = (material2.mainTexture = material.mainTexture);
				if ((object)texture != null)
				{
					array2[0] = material2;
					num2++;
					break;
				}
			}
			_materialsTemp = array2;
			((Renderer)componentInChildren).SetMaterialArray(array2);
			VfxFadeIn.SetActive(value: true);
			Transform transform = VfxFadeIn.transform;
			Transform _003Ctransform_003Ek__BackingField = _character.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform2 = VfxFadeIn.transform;
			float z2 = Vector3.one.z;
			Transform transform3 = VfxFadeIn.transform;
			float z3 = Vector3.zero.z;
			_character.gameObject.SetActive(value: true);
			float fadeIn_Shader_Opacity_ValueStart = FadeIn_Shader_Opacity_ValueStart;
			Material[] materialsTemp = _materialsTemp;
			int num3 = 0;
			int num4 = 0;
			int length2 = materialsTemp.Length;
			if (num4 < length2)
			{
				Material material3 = materialsTemp[num3];
				_opacity = fadeIn_Shader_Opacity_ValueStart;
				material3.SetFloat("_Opacity", fadeIn_Shader_Opacity_ValueStart);
				num3++;
			}
			float fadeIn_Shader_Opacity_DelayBeforeStart = FadeIn_Shader_Opacity_DelayBeforeStart;
			TweenDelegate tweenDelegate = OnShaderOpacityEnded;
			_003C_003Ef__AnonymousType8<float, float, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType8<float, float, eEaseType, TweenDelegate>);
			TweenMax tweenMax = TweenMax.To(this, fadeIn_Shader_Opacity_DelayBeforeStart, vars, int.MinValue, this);
			var vars2 = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnVfxFinished)
			};
			TweenMax tweenMax2 = TweenMax.To(this, fadeIn_Shader_Opacity_DelayBeforeStart, vars2, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x60012A7")]
		[Cpp2IlInjected.Address(RVA = "0xFFAB90", Offset = "0xFF9590", VA = "0x180FFAB90")]
		private void OnShaderOpacityEnded(ITween tween, object param)
		{
			//Discarded unreachable code: IL_001b
			SkinnedMeshRenderer componentInChildren = _character.GetComponentInChildren<SkinnedMeshRenderer>();
			Material[] materialsOriginal = _materialsOriginal;
			((Renderer)componentInChildren).SetMaterialArray(materialsOriginal);
		}

		[Cpp2IlInjected.Token(Token = "0x60012A8")]
		[Cpp2IlInjected.Address(RVA = "0xFFAA60", Offset = "0xFF9460", VA = "0x180FFAA60")]
		private void OnFocusStart(ITween tween, object param)
		{
			//Discarded unreachable code: IL_0035
			VfxFocus.SetActive(value: true);
			float focus_Duration = Focus_Duration;
			var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnVfxFinished)
			};
			TweenMax tweenMax = TweenMax.To(this, focus_Duration, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x60012A9")]
		[Cpp2IlInjected.Address(RVA = "0xFFA930", Offset = "0xFF9330", VA = "0x180FFA930")]
		private void OnFlashStart(ITween tween, object param)
		{
			//Discarded unreachable code: IL_0035
			VfxFlash.SetActive(value: true);
			float flash_Duration = Flash_Duration;
			var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnVfxFinished)
			};
			TweenMax tweenMax = TweenMax.To(this, flash_Duration, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x60012AA")]
		[Cpp2IlInjected.Address(RVA = "0xFFABF0", Offset = "0xFF95F0", VA = "0x180FFABF0")]
		private void OnVfxFinished(ITween tween, object param)
		{
			//IL_0010: Expected O, but got I4
			GameObject gameObject = base.gameObject;
			int num = 0;
			if (gameObject != (Object)num)
			{
				CleanUp();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012AB")]
		[Cpp2IlInjected.Address(RVA = "0xFFA330", Offset = "0xFF8D30", VA = "0x180FFA330")]
		private void OnDisable()
		{
			CleanUp();
		}

		[Cpp2IlInjected.Token(Token = "0x60012AC")]
		[Cpp2IlInjected.Address(RVA = "0xFFA210", Offset = "0xFF8C10", VA = "0x180FFA210")]
		private void CleanUp()
		{
			//Discarded unreachable code: IL_0070
			//IL_0010: Expected O, but got I4
			Character character = _character;
			int num = 0;
			if (character != (Object)num)
			{
				SkinnedMeshRenderer componentInChildren = _character.GetComponentInChildren<SkinnedMeshRenderer>();
				Material[] materialsOriginal = _materialsOriginal;
				((Renderer)componentInChildren).SetMaterialArray(materialsOriginal);
			}
			GameObject vfxFadeIn = VfxFadeIn;
			int active = 0;
			vfxFadeIn.SetActive((byte)active != 0);
			GameObject vfxFocus = VfxFocus;
			int active2 = 0;
			vfxFocus.SetActive((byte)active2 != 0);
			GameObject vfxFlash = VfxFlash;
			int active3 = 0;
			vfxFlash.SetActive((byte)active3 != 0);
			TweenMax.KillAllByCancelationToken(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60012AD")]
		[Cpp2IlInjected.Address(RVA = "0xFFAF70", Offset = "0xFF9970", VA = "0x180FFAF70")]
		public CharacterSummonEffectCutscene()
		{
		}//IL_0061: Expected I4, but got I8

	}
}
