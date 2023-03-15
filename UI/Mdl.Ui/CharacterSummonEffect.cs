using System;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002E4")]
	[RequiredAllNotNull]
	public class CharacterSummonEffect : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000DD5")]
		private Material[] _materialsOriginal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000DD6")]
		private Material[] _materialsTemp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000DD7")]
		private Action _callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000DD8")]
		private Transform _container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000DD9")]
		private Character _character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000DDA")]
		private MapCameraTransform _positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000DDB")]
		private float _opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000DDC")]
		public Material MatFadeIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000DDD")]
		public GameObject VfxFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000DDE")]
		public GameObject VfxFlash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000DDF")]
		public GameObject VfxSpiral;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000DE0")]
		public GameObject VfxWishingWell;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000DE1")]
		public GameObject VfxFireworks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000DE2")]
		public GameObject VfxFadeIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000DE3")]
		public ParticleSystem ParticleFadeIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000DE4")]
		[Space]
		public float WishingWell_DelayBeforeStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000DE5")]
		public float WishingWell_Duration = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000DE6")]
		[Space]
		public float Fireworks_DelayBeforeStart = 6.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000DE7")]
		public float Fireworks_Duration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000DE8")]
		[Space]
		public float Spiral_DelayBeforeStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000DE9")]
		public float Spiral_Duration = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000DEA")]
		[Space]
		public float FadeIn_DelayBeforeStart = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000DEB")]
		public float FadeIn_Duration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000DEC")]
		public float FadeIn_Shader_Opacity_ValueStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000DED")]
		public float FadeIn_Shader_Opacity_ValueEnd = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000DEE")]
		public float FadeIn_Shader_Opacity_DelayBeforeStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000DEF")]
		public float FadeIn_Shader_Opacity_Duration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000DF0")]
		public eEaseType FadeIn_Shader_Opacity_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000DF1")]
		[Space]
		public float Focus_DelayBeforeStart = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000DF2")]
		public float Focus_Duration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000DF3")]
		[Space]
		public float Flash_DelayBeforeStart = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000DF4")]
		public float Flash_Duration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000DF5")]
		private int _vfxCnt = 6;

		[Cpp2IlInjected.Token(Token = "0x17000337")]
		public float Opacity
		{
			[Cpp2IlInjected.Token(Token = "0x600128F")]
			[Cpp2IlInjected.Address(RVA = "0xEFF3E0", Offset = "0xEFDDE0", VA = "0x180EFF3E0")]
			get
			{
				return _opacity;
			}
			[Cpp2IlInjected.Token(Token = "0x6001290")]
			[Cpp2IlInjected.Address(RVA = "0xFFCC40", Offset = "0xFFB640", VA = "0x180FFCC40")]
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

		[Cpp2IlInjected.Token(Token = "0x17000338")]
		public bool IsDone
		{
			[Cpp2IlInjected.Token(Token = "0x6001292")]
			[Cpp2IlInjected.Address(RVA = "0xFFCC30", Offset = "0xFFB630", VA = "0x180FFCC30")]
			get
			{
				return _vfxCnt <= 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001291")]
		[Cpp2IlInjected.Address(RVA = "0xFFCA40", Offset = "0xFFB440", VA = "0x180FFCA40")]
		public void Setup(Transform container, Character character, MapCameraTransform positions)
		{
			//Discarded unreachable code: IL_0060
			_container = container;
			_character = character;
			_positions = positions;
			Transform transform = base.transform;
			Transform transform3 = (transform.parentInternal = _character.CharacterVisualNodes.Chest.transform);
			Transform transform4 = base.transform;
			float z = Vector3.zero.z;
			Transform transform5 = base.transform;
			float z2 = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6001293")]
		[Cpp2IlInjected.Address(RVA = "0xFFC3C0", Offset = "0xFFADC0", VA = "0x180FFC3C0")]
		public void Play(Action callback)
		{
			//Discarded unreachable code: IL_0109
			_callback = callback;
			base.gameObject.SetActive(value: true);
			Transform transform = base.transform;
			Transform transform2 = (transform.parentInternal = _container);
			float spiral_DelayBeforeStart = Spiral_DelayBeforeStart;
			var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnSpiralStart)
			};
			int num = 0;
			TweenMax tweenMax = TweenMax.To(this, spiral_DelayBeforeStart, vars, int.MinValue, this);
			var vars2 = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnWishingWellStart)
			};
			TweenMax tweenMax2 = TweenMax.To(this, spiral_DelayBeforeStart, vars2, int.MinValue, this);
			var vars3 = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnFireworksStart)
			};
			TweenMax tweenMax3 = TweenMax.To(this, spiral_DelayBeforeStart, vars3, int.MinValue, this);
			var vars4 = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnFadeInStart)
			};
			TweenMax tweenMax4 = TweenMax.To(this, spiral_DelayBeforeStart, vars4, int.MinValue, this);
			var vars5 = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnFocusStart)
			};
			TweenMax tweenMax5 = TweenMax.To(this, spiral_DelayBeforeStart, vars5, int.MinValue, this);
			var vars6 = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnFlashStart)
			};
			TweenMax tweenMax6 = TweenMax.To(this, spiral_DelayBeforeStart, vars6, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001294")]
		[Cpp2IlInjected.Address(RVA = "0xFFB080", Offset = "0xFF9A80", VA = "0x180FFB080")]
		public void Cancel()
		{
			//IL_0009: Expected O, but got I8
			//IL_0012: Expected I4, but got I8
			_callback = (Action)0;
			_vfxCnt = 0;
			CleanUp();
		}

		[Cpp2IlInjected.Token(Token = "0x6001295")]
		[Cpp2IlInjected.Address(RVA = "0xFFC110", Offset = "0xFFAB10", VA = "0x180FFC110")]
		private void OnWishingWellStart(ITween tween, object param)
		{
			//Discarded unreachable code: IL_00bc
			//IL_0015: Expected O, but got I4
			Transform wishingWellPos = _positions._wishingWellPos;
			int num = 0;
			if (wishingWellPos != (UnityEngine.Object)num)
			{
				VfxWishingWell.SetActive(value: true);
				Transform transform = VfxWishingWell.transform;
				Transform transform2 = (transform.parentInternal = _positions._wishingWellPos);
				Transform transform3 = VfxWishingWell.transform;
				float z = Vector3.zero.z;
				Transform transform4 = VfxWishingWell.transform;
				float z2 = Vector3.one.z;
				Transform transform5 = VfxWishingWell.transform;
				float z3 = Vector3.zero.z;
			}
			float wishingWell_Duration = WishingWell_Duration;
			var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnVfxFinished)
			};
			TweenMax tweenMax = TweenMax.To(this, wishingWell_Duration, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001296")]
		[Cpp2IlInjected.Address(RVA = "0xFFB8C0", Offset = "0xFFA2C0", VA = "0x180FFB8C0")]
		private void OnFireworksStart(ITween tween, object param)
		{
			//Discarded unreachable code: IL_00bc
			//IL_0015: Expected O, but got I4
			Transform wishingWellPos = _positions._wishingWellPos;
			int num = 0;
			if (wishingWellPos != (UnityEngine.Object)num)
			{
				VfxFireworks.SetActive(value: true);
				Transform transform = VfxFireworks.transform;
				Transform transform2 = (transform.parentInternal = _positions._wishingWellPos);
				Transform transform3 = VfxFireworks.transform;
				float z = Vector3.zero.z;
				Transform transform4 = VfxFireworks.transform;
				float z2 = Vector3.one.z;
				Transform transform5 = VfxFireworks.transform;
				float z3 = Vector3.zero.z;
			}
			float fireworks_Duration = Fireworks_Duration;
			var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnVfxFinished)
			};
			TweenMax tweenMax = TweenMax.To(this, fireworks_Duration, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001297")]
		[Cpp2IlInjected.Address(RVA = "0xFFBDE0", Offset = "0xFFA7E0", VA = "0x180FFBDE0")]
		private void OnSpiralStart(ITween tween, object param)
		{
			//Discarded unreachable code: IL_00b1
			VfxSpiral.SetActive(value: true);
			Transform transform = VfxSpiral.transform;
			Transform transform2 = (transform.parentInternal = _character.transform.parent);
			Transform transform3 = VfxSpiral.transform;
			Transform newCharacterSpawningTransform = _positions.NewCharacterSpawningTransform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform4 = VfxSpiral.transform;
			float z2 = Vector3.one.z;
			Transform transform5 = VfxSpiral.transform;
			float z3 = Vector3.zero.z;
			float spiral_Duration = Spiral_Duration;
			var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
			{
				OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(OnVfxFinished)
			};
			TweenMax tweenMax = TweenMax.To(this, spiral_Duration, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001298")]
		[Cpp2IlInjected.Address(RVA = "0xFFB370", Offset = "0xFF9D70", VA = "0x180FFB370")]
		private void OnFadeInStart(ITween tween, object param)
		{
			//Discarded unreachable code: IL_017b
			SetupCharacterMaterials();
			VfxFadeIn.SetActive(value: true);
			Transform transform = VfxFadeIn.transform;
			Transform transform2 = (transform.parentInternal = _character.transform.parent);
			Transform transform3 = VfxFadeIn.transform;
			Transform newCharacterSpawningTransform = _positions.NewCharacterSpawningTransform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform4 = VfxFadeIn.transform;
			float z2 = Vector3.one.z;
			Transform transform5 = VfxFadeIn.transform;
			float z3 = Vector3.zero.z;
			_character.gameObject.SetActive(value: true);
			Transform transform6 = _character.gameObject.transform;
			Transform newCharacterSpawningTransform2 = _positions.NewCharacterSpawningTransform;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			Transform transform7 = _character.gameObject.transform;
			Transform newCharacterSpawningTransform3 = _positions.NewCharacterSpawningTransform;
			float fadeIn_Shader_Opacity_ValueStart = FadeIn_Shader_Opacity_ValueStart;
			Material[] materialsTemp = _materialsTemp;
			int num = 0;
			int num2 = 0;
			int length = materialsTemp.Length;
			if (num2 < length)
			{
				Material material = materialsTemp[num];
				_opacity = fadeIn_Shader_Opacity_ValueStart;
				material.SetFloat("_Opacity", fadeIn_Shader_Opacity_ValueStart);
				num++;
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

		[Cpp2IlInjected.Token(Token = "0x6001299")]
		[Cpp2IlInjected.Address(RVA = "0xFFBDD0", Offset = "0xFFA7D0", VA = "0x180FFBDD0")]
		private void OnShaderOpacityEnded(ITween tween, object param)
		{
			RestoreCharacterMaterials();
		}

		[Cpp2IlInjected.Token(Token = "0x600129A")]
		[Cpp2IlInjected.Address(RVA = "0xFFBCA0", Offset = "0xFFA6A0", VA = "0x180FFBCA0")]
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

		[Cpp2IlInjected.Token(Token = "0x600129B")]
		[Cpp2IlInjected.Address(RVA = "0xFFBB70", Offset = "0xFFA570", VA = "0x180FFBB70")]
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

		[Cpp2IlInjected.Token(Token = "0x600129C")]
		[Cpp2IlInjected.Address(RVA = "0xFFC080", Offset = "0xFFAA80", VA = "0x180FFC080")]
		private void OnVfxFinished(ITween tween, object param)
		{
			//IL_0010: Expected O, but got I4
			GameObject gameObject = base.gameObject;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				CleanUp();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600129D")]
		[Cpp2IlInjected.Address(RVA = "0xFFB170", Offset = "0xFF9B70", VA = "0x180FFB170")]
		private void CleanUp()
		{
			//Discarded unreachable code: IL_00a9
			//IL_0016: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0072: Expected O, but got I4
			RestoreCharacterMaterials();
			GameObject vfxWishingWell = VfxWishingWell;
			int num = 0;
			if (vfxWishingWell != (UnityEngine.Object)num && VfxWishingWell.activeSelf)
			{
				UnityEngine.Object.Destroy(VfxWishingWell);
			}
			GameObject vfxSpiral = VfxSpiral;
			int num2 = 0;
			if (vfxSpiral != (UnityEngine.Object)num2 && VfxSpiral.activeSelf)
			{
				UnityEngine.Object.Destroy(VfxSpiral);
			}
			GameObject vfxFadeIn = VfxFadeIn;
			int num3 = 0;
			if (vfxFadeIn != (UnityEngine.Object)num3 && VfxFadeIn.activeSelf)
			{
				UnityEngine.Object.Destroy(VfxFadeIn);
			}
			TweenMax.KillAllByCancelationToken(this);
			_callback?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600129E")]
		[Cpp2IlInjected.Address(RVA = "0xFFB0C0", Offset = "0xFF9AC0", VA = "0x180FFB0C0")]
		public void CleanFireworks()
		{
			//Discarded unreachable code: IL_002d
			//IL_0010: Expected O, but got I4
			GameObject vfxFireworks = VfxFireworks;
			int num = 0;
			if (vfxFireworks != (UnityEngine.Object)num && VfxFireworks.activeSelf)
			{
				UnityEngine.Object.Destroy(VfxFireworks);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600129F")]
		[Cpp2IlInjected.Address(RVA = "0xFFC800", Offset = "0xFFB200", VA = "0x180FFC800")]
		private void SetupCharacterMaterials()
		{
			//Discarded unreachable code: IL_008a
			SkinnedMeshRenderer componentInChildren;
			Material[] array2;
			Material material2 = default(Material);
			while (true)
			{
				componentInChildren = _character.GetComponentInChildren<SkinnedMeshRenderer>();
				ParticleSystem.MainModule main = ParticleFadeIn.main;
				Material[] array = (_materialsOriginal = ((Renderer)componentInChildren).GetMaterialArray());
				array2 = new Material[((Renderer)componentInChildren).GetMaterialArray().Length];
				Material[] materialArray = ((Renderer)componentInChildren).GetMaterialArray();
				int num = 0;
				int length = materialArray.Length;
				if (num >= length)
				{
					break;
				}
				Material material = new Material(MatFadeIn);
				Texture texture = (material.mainTexture = material2.mainTexture);
				if ((object)texture != null)
				{
					num++;
					break;
				}
			}
			_materialsTemp = array2;
			((Renderer)componentInChildren).SetMaterialArray(array2);
		}

		[Cpp2IlInjected.Token(Token = "0x60012A0")]
		[Cpp2IlInjected.Address(RVA = "0xFFC780", Offset = "0xFFB180", VA = "0x180FFC780")]
		private void RestoreCharacterMaterials()
		{
			//Discarded unreachable code: IL_002f
			//IL_002e: Expected O, but got I8
			if ((long)_materialsOriginal != 0)
			{
				SkinnedMeshRenderer componentInChildren = _character.GetComponentInChildren<SkinnedMeshRenderer>();
				Material[] materialsOriginal = _materialsOriginal;
				((Renderer)componentInChildren).SetMaterialArray(materialsOriginal);
				_materialsOriginal = (Material[])0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012A1")]
		[Cpp2IlInjected.Address(RVA = "0xFFCBA0", Offset = "0xFFB5A0", VA = "0x180FFCBA0")]
		public CharacterSummonEffect()
		{
		}//IL_008d: Expected I4, but got I8

	}
}
