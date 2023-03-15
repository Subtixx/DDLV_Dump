using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Mdl.Navigation;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using NodeCanvas.DialogueTrees;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200069B")]
	public class UnlockArea : MonoBehaviour, IPlayerTaskData, IPlayerTaskProvider
	{
		[Cpp2IlInjected.Token(Token = "0x200069C")]
		public delegate void AreaUnlocked(bool isCastleArea, VillageAreaType areaType, Transform position);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002720")]
		public PlayerTaskDefinition TaskDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002721")]
		[SerializeField]
		private DialogueTree _dialogue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002722")]
		[ItemID]
		[SerializeField]
		private int _employeeCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002723")]
		[SerializeField]
		private Transform _employeePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002724")]
		[SerializeField]
		private bool _unlockCastle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002725")]
		[SerializeField]
		private VillageAreaType _areaType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002726")]
		[SerializeField]
		[ItemID]
		private int _interactionAllowedCondition;

		[Cpp2IlInjected.Token(Token = "0x17000415")]
		public DialogueTree Dialogue
		{
			[Cpp2IlInjected.Token(Token = "0x6001D3E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _dialogue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000416")]
		public Item EmployeeCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6001D3F")]
			[Cpp2IlInjected.Address(RVA = "0xD38660", Offset = "0xD37060", VA = "0x180D38660")]
			get
			{
				long num = Convert.ToInt64((uint)_employeeCharacter);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000417")]
		public VillageAreaType AreaType
		{
			[Cpp2IlInjected.Token(Token = "0x6001D40")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return _areaType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000418")]
		public Vector3 EmployeePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001D41")]
			[Cpp2IlInjected.Address(RVA = "0xD386C0", Offset = "0xD370C0", VA = "0x180D386C0")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000419")]
		public bool UnlockCastle
		{
			[Cpp2IlInjected.Token(Token = "0x6001D42")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get
			{
				return _unlockCastle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041A")]
		public Item InteractionAllowedCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6001D45")]
			[Cpp2IlInjected.Address(RVA = "0xD38700", Offset = "0xD37100", VA = "0x180D38700")]
			get
			{
				long num = Convert.ToInt64((uint)_interactionAllowedCondition);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000044")]
		public event AreaUnlocked OnAreaUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6001D43")]
			[Cpp2IlInjected.Address(RVA = "0xD385C0", Offset = "0xD36FC0", VA = "0x180D385C0")]
			[CompilerGenerated]
			add
			{
				AreaUnlocked onAreaUnlocked = this.OnAreaUnlocked;
				Delegate @delegate = Delegate.Combine(onAreaUnlocked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAreaUnlocked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001D44")]
			[Cpp2IlInjected.Address(RVA = "0xD38760", Offset = "0xD37160", VA = "0x180D38760")]
			[CompilerGenerated]
			remove
			{
				AreaUnlocked onAreaUnlocked = this.OnAreaUnlocked;
				Delegate @delegate = Delegate.Remove(onAreaUnlocked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAreaUnlocked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D46")]
		[Cpp2IlInjected.Address(RVA = "0xD38560", Offset = "0xD36F60", VA = "0x180D38560")]
		public void UnlockAreaStart()
		{
			if (this.OnAreaUnlocked != null)
			{
				VillageAreaType areaType = _areaType;
				Transform transform = base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D47")]
		[Cpp2IlInjected.Address(RVA = "0xD38370", Offset = "0xD36D70", VA = "0x180D38370")]
		private bool InteractionAllowed()
		{
			int num = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client client = _003CInstance_003Ek__BackingField.Client;
				if ((object)client != null && client.MetaClient == null)
				{
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				Client client2 = _003CInstance_003Ek__BackingField2.Client;
				if ((object)client2 != null && client2.MetaClient == null)
				{
				}
			}
			int interactionAllowedCondition = _interactionAllowedCondition;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D48")]
		[Cpp2IlInjected.Address(RVA = "0xD38300", Offset = "0xD36D00", VA = "0x180D38300", Slot = "4")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__25))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__25(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D49")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public UnlockArea()
		{
		}
	}
}
