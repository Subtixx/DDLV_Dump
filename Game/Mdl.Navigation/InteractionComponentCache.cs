using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Grid;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C4E")]
	internal class InteractionComponentCache : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400449E")]
		public PlayerTaskCollider taskCollider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40044A1")]
		public ColliderRedirection redirection;

		[Cpp2IlInjected.Token(Token = "0x17000792")]
		public GridObjectScript gridObjectScript
		{
			[Cpp2IlInjected.Token(Token = "0x6003871")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CgridObjectScript_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003872")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CgridObjectScript_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000793")]
		private GameObject defaultTargetObject
		{
			[Cpp2IlInjected.Token(Token = "0x6003873")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CdefaultTargetObject_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003874")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CdefaultTargetObject_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000794")]
		public GameObject targetGameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6003875")]
			[Cpp2IlInjected.Address(RVA = "0x11B96F0", Offset = "0x11B80F0", VA = "0x1811B96F0")]
			get
			{
				//Discarded unreachable code: IL_003e
				//IL_0010: Expected O, but got I4
				//IL_0028: Expected O, but got I4
				ColliderRedirection colliderRedirection = redirection;
				int num = 0;
				if (colliderRedirection != (Object)num)
				{
					GameObject gameObject = redirection.Redirection;
					int num2 = 0;
					if (gameObject != (Object)num2)
					{
						return redirection.Redirection;
					}
				}
				return defaultTargetObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000795")]
		public IPlayerInteraction playerInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x6003876")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CplayerInteraction_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003877")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CplayerInteraction_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000796")]
		public Collider collider
		{
			[Cpp2IlInjected.Token(Token = "0x6003878")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003Ccollider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003879")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003Ccollider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000797")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40044A0")]
		public bool isCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x600387A")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600387B")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600387C")]
		[Cpp2IlInjected.Address(RVA = "0x11B96E0", Offset = "0x11B80E0", VA = "0x1811B96E0")]
		public void Start()
		{
			RecacheComponents();
		}

		[Cpp2IlInjected.Token(Token = "0x600387D")]
		[Cpp2IlInjected.Address(RVA = "0x11B9530", Offset = "0x11B7F30", VA = "0x1811B9530")]
		internal void RecacheComponents()
		{
			//Discarded unreachable code: IL_0084
			GridObjectScript gridObjectScript = (this.gridObjectScript = base.gameObject.GetComponentInParent<GridObjectScript>());
			GameObject gameObject = (defaultTargetObject = base.gameObject);
			ColliderRedirection colliderRedirection = (redirection = base.gameObject.GetComponent<ColliderRedirection>());
			IPlayerInteraction playerInteraction = (this.playerInteraction = base.gameObject.GetComponent<IPlayerInteraction>());
			PlayerTaskCollider playerTaskCollider = (taskCollider = base.gameObject.GetComponent<PlayerTaskCollider>());
			Collider collider = (this.collider = base.gameObject.GetComponent<Collider>());
			GameObject gameObject2 = base.gameObject;
			bool flag = default(bool);
			isCharacter = flag;
		}

		[Cpp2IlInjected.Token(Token = "0x600387E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InteractionComponentCache()
		{
		}
	}
}
