using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200079E")]
	public class CharacterMealRequest : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002CA1")]
		private CharacterRestaurantOrder _order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002CA2")]
		[SerializeField]
		[Header("Components")]
		private AsyncAtlassedIcon _mcMealIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002CA3")]
		[SerializeField]
		private StarComponent _star;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002CA4")]
		[SerializeField]
		private TextBase _textBase;

		[Cpp2IlInjected.Token(Token = "0x60030BD")]
		[Cpp2IlInjected.Address(RVA = "0xFF9000", Offset = "0xFF7A00", VA = "0x180FF9000", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_007b
			//IL_0011: Expected O, but got I4
			int num = 0;
			if ((object)typeof(ItemDatabase).TypeHandle != null)
			{
				_order = (CharacterRestaurantOrder)0;
			}
			CharacterRestaurantOrder order = _order;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item mealItem = order.MealItem;
			MealItemData mealItemData = default(MealItemData);
			if (mealItemData != null)
			{
				AsyncAtlassedIcon mcMealIcon = _mcMealIcon;
				string iconAddress_ = mealItemData.iconAddress_;
				bool flag = mcMealIcon.SetIcon(iconAddress_);
				StarComponent star = _star;
				int num2 = (star.Star = mealItemData.starRating_);
				TextBase textBase = _textBase;
				string text = (textBase.StringID = mealItemData.displayName_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030BE")]
		[Cpp2IlInjected.Address(RVA = "0xFF9210", Offset = "0xFF7C10", VA = "0x180FF9210", Slot = "15")]
		public override void Kill()
		{
			Object.Destroy(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60030BF")]
		[Cpp2IlInjected.Address(RVA = "0x87D270", Offset = "0x87BC70", VA = "0x18087D270")]
		public CharacterMealRequest()
		{
		}
	}
}
