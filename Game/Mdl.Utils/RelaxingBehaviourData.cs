using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007A4")]
	[CreateAssetMenu]
	public class RelaxingBehaviourData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B8A")]
		[SerializeField]
		private string _forceTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B8B")]
		[SerializeField]
		private string _afterTurnBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B8C")]
		[SerializeField]
		private string _startTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B8D")]
		[SerializeField]
		private string _startAnimationName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B8E")]
		[SerializeField]
		private string _loopingAnimationName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B8F")]
		[SerializeField]
		private string _endAnimationName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002B90")]
		[SerializeField]
		private AnimationClip _defaultStartClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002B91")]
		[SerializeField]
		private float avatarOrientationDotCheck = -0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4002B92")]
		public float maxWaitAnimTime = 3f;

		[Cpp2IlInjected.Token(Token = "0x170004B4")]
		public string ForceTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x60021FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _forceTrigger;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B5")]
		public string AfterTurnBool
		{
			[Cpp2IlInjected.Token(Token = "0x60021FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _afterTurnBool;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B6")]
		public string StartTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x60021FC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _startTrigger;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B7")]
		public string StartAnimationName
		{
			[Cpp2IlInjected.Token(Token = "0x60021FD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _startAnimationName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B8")]
		public string LoopingAnimationName
		{
			[Cpp2IlInjected.Token(Token = "0x60021FE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _loopingAnimationName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B9")]
		public string EndAnimationName
		{
			[Cpp2IlInjected.Token(Token = "0x60021FF")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _endAnimationName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BA")]
		public AnimationClip DefaultStartClip
		{
			[Cpp2IlInjected.Token(Token = "0x6002200")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return _defaultStartClip;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BB")]
		public float AvatarOrientationDotCheck
		{
			[Cpp2IlInjected.Token(Token = "0x6002201")]
			[Cpp2IlInjected.Address(RVA = "0xCBE930", Offset = "0xCBD330", VA = "0x180CBE930")]
			get
			{
				return avatarOrientationDotCheck;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002202")]
		[Cpp2IlInjected.Address(RVA = "0xCBE910", Offset = "0xCBD310", VA = "0x180CBE910")]
		public RelaxingBehaviourData()
		{
		}
	}
}
