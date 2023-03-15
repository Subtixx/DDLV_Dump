using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000788")]
	internal class MickeyEars : LookAtBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6002176")]
		[Cpp2IlInjected.Address(RVA = "0xBC6720", Offset = "0xBC5120", VA = "0x180BC6720", Slot = "4")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_00de
			//IL_0063: Expected O, but got I8
			//IL_00d3: Expected O, but got I4
			Animator animator = (base.animator = GetComponentInChildren<Animator>());
			base.CacheLayerIndexes();
			int num = Animator.StringToHash(base._lookAtHorizontalParameter);
			string lookAtVerticalParameter = base._lookAtVerticalParameter;
			base.horizontalParameterID = num;
			int num2 = Animator.StringToHash(lookAtVerticalParameter);
			string lookAtCancelAnimationTrack = base._lookAtCancelAnimationTrack;
			base.verticalParameterID = num2;
			if (!string.IsNullOrEmpty(lookAtCancelAnimationTrack))
			{
				int num3 = Animator.StringToHash(base._lookAtCancelAnimationTrack);
				ulong num4 = default(ulong);
				base.cancelAnimationTrackParameterID = (int?)(object)num4;
			}
			Transform transform = (base.Origin = GetComponent<CharacterVisualNodes>().Head.transform);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			Transform transform2 = default(Transform);
			if ((object)_003CInstance_003Ek__BackingField == null || (object)_003CInstance_003Ek__BackingField._playerCamera.transform == null)
			{
				int num5 = 0;
				transform2 = Camera.main.transform;
			}
			if (base._target != transform2)
			{
				base._target = transform2;
				Transform target = base._target;
				int num6 = 0;
				if (target != (Object)num6)
				{
					base.enabled = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002177")]
		[Cpp2IlInjected.Address(RVA = "0xBBB9B0", Offset = "0xBBA3B0", VA = "0x180BBB9B0")]
		public MickeyEars()
		{
			base._lookAtLayerName = "LookAt";
			base._lookAtHorizontalParameter = "AimOrient";
			base._lookAtVerticalParameter = "AimHeight";
			base.horizontalMaxAngle = 180f;
			base.verticalMaxAngle = 45f;
			base.minDistanceToUpdate = 0.5f;
			((MonoBehaviour)this)._002Ector();
		}
	}
}
