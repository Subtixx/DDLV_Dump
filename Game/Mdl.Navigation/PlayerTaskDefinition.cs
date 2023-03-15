using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C8F")]
	[CreateAssetMenu]
	public class PlayerTaskDefinition : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004643")]
		[SerializeField]
		private string _taskId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004644")]
		public PlayerTaskType PlayerTaskType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4004645")]
		public bool NeedConfirmation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4004646")]
		public bool CanQueueMultipleInstances = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x4004647")]
		public bool NeedColliderGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
		[Cpp2IlInjected.Token(Token = "0x4004648")]
		public bool NeedLineOfSight = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004649")]
		public GameObject Action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400464A")]
		public InteractPreviewData InteractPreviewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400464B")]
		[SerializeField]
		internal BaseHoldBehaviour HoldBehaviour;

		[Cpp2IlInjected.Token(Token = "0x170007CB")]
		public string TaskId
		{
			[Cpp2IlInjected.Token(Token = "0x6003A0F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _taskId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A10")]
		[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "3")]
		public override string ToString()
		{
			return _taskId;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A11")]
		[Cpp2IlInjected.Address(RVA = "0xCAEA90", Offset = "0xCAD490", VA = "0x180CAEA90")]
		public PlayerTaskDefinition()
		{
		}
	}
}
