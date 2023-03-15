using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200077C")]
	[RequireComponent(typeof(CharacterVisualNodes))]
	public class LookAtBehaviour : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AF6")]
		[SerializeField]
		private string _lookAtLayerName = "LookAt";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AF7")]
		private int lookAtLayerIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002AF8")]
		[SerializeField]
		private string _lookAtHorizontalParameter = "AimOrient";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002AF9")]
		private int horizontalParameterID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002AFA")]
		[SerializeField]
		private string _lookAtVerticalParameter = "AimHeight";

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002AFB")]
		private int verticalParameterID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002AFC")]
		[SerializeField]
		private string _lookAtCancelAnimationTrack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002AFD")]
		private int? cancelAnimationTrackParameterID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002AFE")]
		[SerializeField]
		private float horizontalMaxAngle = 180f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4002AFF")]
		[SerializeField]
		private float verticalMaxAngle = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002B00")]
		[SerializeField]
		private float minDistanceToUpdate = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002B01")]
		private Transform _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002B04")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002B05")]
		private RuntimeAnimatorController cachedAnimatorRuntimeCtrl;

		[Cpp2IlInjected.Token(Token = "0x170004A3")]
		public Transform Target
		{
			[Cpp2IlInjected.Token(Token = "0x600213F")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return _target;
			}
			[Cpp2IlInjected.Token(Token = "0x6002140")]
			[Cpp2IlInjected.Address(RVA = "0xBBBA70", Offset = "0xBBA470", VA = "0x180BBBA70")]
			set
			{
				//IL_0026: Expected O, but got I4
				if (_target != value)
				{
					_target = value;
					Transform target = _target;
					int num = 0;
					if (target != (UnityEngine.Object)num)
					{
						base.enabled = true;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x70"), Cpp2IlInjected.Token(Token = "0x4002B02")]
		public float CurrentWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6002141")]
			[Cpp2IlInjected.Address(RVA = "0xBBBA50", Offset = "0xBBA450", VA = "0x180BBBA50")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002142")]
			[Cpp2IlInjected.Address(RVA = "0xBBBA60", Offset = "0xBBA460", VA = "0x180BBBA60")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004A5")]
		protected Transform Origin
		{
			[Cpp2IlInjected.Token(Token = "0x6002143")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003COrigin_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002144")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			private set
			{
				_003COrigin_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002145")]
		[Cpp2IlInjected.Address(RVA = "0xBBB2A0", Offset = "0xBB9CA0", VA = "0x180BBB2A0")]
		private void CacheLayerIndexes()
		{
			//Discarded unreachable code: IL_0059
			RuntimeAnimatorController runtimeAnimatorController = (cachedAnimatorRuntimeCtrl = this.animator.runtimeAnimatorController);
			Animator animator = this.animator;
			string lookAtLayerName = _lookAtLayerName;
			if ((lookAtLayerIndex = animator.GetLayerIndex(lookAtLayerName)) == -1)
			{
				RuntimeAnimatorController arg = cachedAnimatorRuntimeCtrl;
				string lookAtLayerName2 = _lookAtLayerName;
				Debug.LogWarning($"Could not find layer {lookAtLayerName2} for current animator runtime controller {arg}", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002146")]
		[Cpp2IlInjected.Address(RVA = "0xBBB4B0", Offset = "0xBB9EB0", VA = "0x180BBB4B0", Slot = "4")]
		protected virtual void Start()
		{
			//IL_0063: Expected O, but got I8
			Animator animator = (this.animator = GetComponentInChildren<Animator>());
			CacheLayerIndexes();
			int num = Animator.StringToHash(_lookAtHorizontalParameter);
			string lookAtVerticalParameter = _lookAtVerticalParameter;
			horizontalParameterID = num;
			int num2 = Animator.StringToHash(lookAtVerticalParameter);
			string lookAtCancelAnimationTrack = _lookAtCancelAnimationTrack;
			verticalParameterID = num2;
			if (!string.IsNullOrEmpty(lookAtCancelAnimationTrack))
			{
				int num3 = Animator.StringToHash(_lookAtCancelAnimationTrack);
				ulong num4 = default(ulong);
				cancelAnimationTrackParameterID = (int?)(object)num4;
			}
			Transform transform = (Origin = GetComponent<CharacterVisualNodes>().Head.transform);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002147")]
		[Cpp2IlInjected.Address(RVA = "0xBBB480", Offset = "0xBB9E80", VA = "0x180BBB480")]
		private void OnDisable()
		{
			//IL_000c: Expected F4, but got I4
			//IL_000c: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			this.UpdateLookAt((Nullable<>)num, (float)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002148")]
		[Cpp2IlInjected.Address(RVA = "0xBBB380", Offset = "0xBB9D80", VA = "0x180BBB380", Slot = "5")]
		protected virtual void LateUpdate()
		{
			//Discarded unreachable code: IL_003f
			//IL_0010: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			Transform target = _target;
			int num = 0;
			if (!(target == (UnityEngine.Object)num))
			{
				Transform target2 = _target;
				int num2 = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				this.UpdateLookAt((Nullable<>)num2, 1f);
			}
			else
			{
				int num3 = ((base.enabled = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002149")]
		[Cpp2IlInjected.Address(RVA = "0xBBB5C0", Offset = "0xBB9FC0", VA = "0x180BBB5C0")]
		protected void UpdateLookAt(Vector3? target, float weight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600214A")]
		[Cpp2IlInjected.Address(RVA = "0xBBB9B0", Offset = "0xBBA3B0", VA = "0x180BBB9B0")]
		public LookAtBehaviour()
		{
		}
	}
}
