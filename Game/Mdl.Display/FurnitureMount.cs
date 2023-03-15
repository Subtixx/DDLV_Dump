using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Display
{
	[Cpp2IlInjected.Token(Token = "0x200081F")]
	public class FurnitureMount : ItemSupport
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D5A")]
		public bool AlignWithGrid;

		[Cpp2IlInjected.Token(Token = "0x4002D5B")]
		public const float TileSize = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x4002D5C")]
		public const float TileHalfSize = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x6002468")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "6")]
		public override bool HasOffsetFromRoot(Item attachedItem)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002469")]
		[Cpp2IlInjected.Address(RVA = "0x8BC380", Offset = "0x8BAD80", VA = "0x1808BC380", Slot = "7")]
		public override Renderer GetVisualRenderer()
		{
			return GetComponentInChildren<Renderer>();
		}

		[Cpp2IlInjected.Token(Token = "0x600246A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAA0", Offset = "0x8BA4A0", VA = "0x1808BBAA0", Slot = "5")]
		protected override Task DoAttachObject(GameObject objToAttach)
		{
			//Discarded unreachable code: IL_012e
			//IL_009b: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_00f2: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if ((AlignWithGrid ? 1 : 0) != num2)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = base.Item;
				IItemData itemData = default(IItemData);
				bool flag = default(bool);
				if (itemData != null && itemData != null && flag)
				{
					bool flag2 = default(bool);
					if (!flag2)
					{
						Transform transform = objToAttach.transform;
						Transform transform2 = objToAttach.transform;
						bool flag3 = default(bool);
						if (!flag3)
						{
							goto IL_0107;
						}
						Transform transform3 = objToAttach.transform;
						Transform transform4 = base.gameObject.transform;
					}
					Transform transform5 = objToAttach.transform;
					Renderer visualRenderer = GetVisualRenderer();
					Transform transform6 = objToAttach.transform;
					Transform transform7 = objToAttach.transform;
					bool flag4 = default(bool);
					if (flag4)
					{
						int num3 = 0;
						if (transform6 != (Object)num3)
						{
							GameObject gameObject = transform6.gameObject;
							int num4 = 0;
							GameObject gameObject2 = default(GameObject);
							if (gameObject != (Object)num4 && gameObject2 != objToAttach)
							{
								int active = 0;
								GameObject gameObject3 = default(GameObject);
								gameObject3.SetActive((byte)active != 0);
								Transform transform8 = visualRenderer.transform;
								int num5 = 0;
								Vector3 vector = default(Vector3);
								float z = vector.z;
								Vector3 forward = Vector3.forward;
								transform8.localScale = (Vector3)num5;
								Transform transform9 = objToAttach.transform;
								Transform transform10 = base.gameObject.transform;
							}
						}
					}
				}
			}
			goto IL_0107;
			IL_0107:
			Transform transform11 = objToAttach.transform;
			Transform transform13 = (transform11.parent = base.gameObject.transform);
			int num6 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600246B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public FurnitureMount()
		{
		}
	}
}
