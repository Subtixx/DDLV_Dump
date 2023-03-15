using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Online;
using Meta;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003B3")]
	public class RecipeIngredientItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400121C")]
		[SerializeField]
		private GameObject _bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400121D")]
		[SerializeField]
		private GameObject _emptyBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400121E")]
		[SerializeField]
		private GameObject _addedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400121F")]
		[SerializeField]
		private GameObject _missingBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001220")]
		[SerializeField]
		private GameObject _checkMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001221")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001222")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001223")]
		[SerializeField]
		private AsyncAtlassedIcon _mcDiscoveredIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001224")]
		[SerializeField]
		private TextBase _tfQuestionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001225")]
		[SerializeField]
		private TextBase _tfInventoryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001226")]
		[SerializeField]
		private Image _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001229")]
		[SerializeField]
		public Color TypeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400122A")]
		public Color NormalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400122B")]
		public bool IsEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x400122C")]
		public bool IsAdded;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400122D")]
		public int IngredientAddedCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400122E")]
		public bool ShouldDisplayCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400122F")]
		private int _ingredientCount;

		[Cpp2IlInjected.Token(Token = "0x170003F6")]
		public RectTransform Content
		{
			[Cpp2IlInjected.Token(Token = "0x6001788")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _content;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F7")]
		public RecipeItemData.Types.Ingredient Ingredient
		{
			[Cpp2IlInjected.Token(Token = "0x6001789")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CIngredient_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600178A")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			set
			{
				_003CIngredient_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F8")]
		public IItemData IngredientItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600178B")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003CIngredientItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600178C")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			set
			{
				_003CIngredientItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600178D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Awake()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600178E")]
		[Cpp2IlInjected.Address(RVA = "0xF372D0", Offset = "0xF35CD0", VA = "0x180F372D0")]
		public unsafe void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0273, IL_0279, IL_027f, IL_0285, IL_028b, IL_0291, IL_0297
			//IL_002f: Expected I4, but got I8
			//IL_0077: Expected I4, but got I8
			//IL_015f: Expected I4, but got I8
			ulong num2 = default(ulong);
			ulong num3 = default(ulong);
			Client client = default(Client);
			int ingredientCount = default(int);
			string text = default(string);
			ulong num4 = default(ulong);
			IEnumerable<> enumerable = default(IEnumerable<>);
			Client client2 = default(Client);
			int num5 = default(int);
			while (true)
			{
				int num = 0;
				AsyncAtlassedIcon mcDiscoveredIcon = _mcDiscoveredIcon;
				Color color = (mcDiscoveredIcon.loadedColor = NormalColor);
				GameObject checkMark = _checkMark;
				if ((IsAdded ? 1 : 0) == num)
				{
				}
				checkMark.SetActive((byte)num2 != 0);
				if ((IsEmpty ? 1 : 0) != num)
				{
					break;
				}
				IItemData itemData = IngredientItemData;
				if (itemData != null)
				{
				}
				CookingIngredientTypeTagItemData ingredientTypeTagItemData = (CookingIngredientTypeTagItemData)itemData;
				if ((IntPtr)ingredientTypeTagItemData == (IntPtr)num)
				{
					_mcIcon.gameObject.SetActive((byte)num3 != 0);
					AsyncAtlassedIcon mcIcon = _mcIcon;
					IItemData itemData2 = IngredientItemData;
					GameObject gameObject = _mcDiscoveredIcon.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					GameObject gameObject2 = _tfQuestionMark.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
					GameObject gameObject3 = _tfInventoryCount.transform.parent.gameObject;
					bool shouldDisplayCounter = ShouldDisplayCounter;
					gameObject3.SetActive(shouldDisplayCounter);
					ProfilePlayer player_ = client.Profile.player_;
					IItemData itemData3 = IngredientItemData;
					_ingredientCount = ingredientCount;
					_tfInventoryCount.Text = text;
				}
				GameObject gameObject4 = _tfQuestionMark.gameObject;
				int active3 = 0;
				gameObject4.SetActive((byte)active3 != 0);
				GameObject gameObject5 = _tfInventoryCount.transform.parent.gameObject;
				bool shouldDisplayCounter2 = ShouldDisplayCounter;
				gameObject5.SetActive(shouldDisplayCounter2);
				_mcDiscoveredIcon.gameObject.SetActive((byte)num4 != 0);
				AsyncAtlassedIcon mcDiscoveredIcon2 = _mcDiscoveredIcon;
				Color color2 = (mcDiscoveredIcon2.loadedColor = TypeColor);
				AsyncAtlassedIcon mcDiscoveredIcon3 = _mcDiscoveredIcon;
				string iconAddress_ = ingredientTypeTagItemData.iconAddress_;
				bool flag = mcDiscoveredIcon3.SetIcon(iconAddress_);
				GameObject gameObject6 = _mcIcon.gameObject;
				int active4 = 0;
				gameObject6.SetActive((byte)active4 != 0);
				Func<ICookingIngredient, bool> func = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0039
					int iD = ingredientTypeTagItemData.ID;
					if (iD != 0)
					{
						int num7 = 0;
						uint num8 = default(uint);
						if (num7 < (int)num8)
						{
							num7 += num7;
							num7++;
						}
						if (iD != 0)
						{
							Client client3 = default(Client);
							Profile profile = client3.Profile;
							ProfilePlayer player_3 = profile.player_;
							int num9 = default(int);
							return num9 > 0;
						}
					}
					int num10 = 0;
					throw new NullReferenceException();
				};
				IEnumerable<ICookingIngredient> enumerable2 = (IEnumerable<ICookingIngredient>)Enumerable.Where<ICookingIngredient>(enumerable, (Func<, >)(object)func);
				_ingredientCount = num;
				if (enumerable2 != null)
				{
					int ingredientCount2 = _ingredientCount;
					ProfilePlayer player_2 = client2.Profile.player_;
					num5 = (_ingredientCount = num5 + ingredientCount2);
				}
				int num6 = 0;
				if (enumerable2 != null)
				{
					string text2 = ((int*)null)->ToString();
					break;
				}
			}
			int active5 = 0;
			GameObject gameObject7 = default(GameObject);
			gameObject7.SetActive((byte)active5 != 0);
			Transform transform = default(Transform);
			GameObject gameObject8 = transform.parent.gameObject;
			int active6 = 0;
			gameObject8.SetActive((byte)active6 != 0);
			int active7 = 0;
			GameObject gameObject9 = default(GameObject);
			gameObject9.SetActive((byte)active7 != 0);
			int active8 = 0;
			GameObject gameObject10 = default(GameObject);
			gameObject10.SetActive((byte)active8 != 0);
			Transform transform2 = default(Transform);
			transform2.parent.RebuildLayout();
			bool flag2 = (long)"{il2cpp field on {'constant92' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0xA1}" == 0;
			bool flag3 = (long)"{il2cpp field on {'constant92' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0xA0}" == 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600178F")]
		[Cpp2IlInjected.Address(RVA = "0xF371D0", Offset = "0xF35BD0", VA = "0x180F371D0")]
		private void RefreshBg()
		{
			//Discarded unreachable code: IL_0094
			int num = 0;
			GameObject bg = _bg;
			if ((IsEmpty ? 1 : 0) != num)
			{
			}
			if ((ShouldDisplayCounter ? 1 : 0) == num)
			{
			}
			bool active = (IsAdded ? 1 : 0) == num;
			bg.SetActive(active);
			GameObject emptyBg = _emptyBg;
			bool isEmpty = IsEmpty;
			emptyBg.SetActive(isEmpty);
			GameObject missingBg = _missingBg;
			if ((ShouldDisplayCounter ? 1 : 0) == num || (IsAdded ? 1 : 0) == num)
			{
			}
			missingBg.SetActive((byte)num != 0);
			GameObject addedBg = _addedBg;
			bool active2 = default(bool);
			if ((ShouldDisplayCounter ? 1 : 0) != num && (IsAdded ? 1 : 0) != num)
			{
				active2 = (IsEmpty ? 1 : 0) == num;
			}
			addedBg.SetActive(active2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001790")]
		[Cpp2IlInjected.Address(RVA = "0xF37B50", Offset = "0xF36550", VA = "0x180F37B50")]
		public RecipeIngredientItem()
		{
			Color white = Color.white;
			base._002Ector();
		}
	}
}
