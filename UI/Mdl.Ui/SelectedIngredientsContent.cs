using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003C0")]
	public class SelectedIngredientsContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003C1")]
		public delegate void OnRemoveIngredientDelegate(Item removedIngredient, bool animate = true);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400125E")]
		[SerializeField]
		private SelectedIngredientItem _selectIngredientPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400125F")]
		[SerializeField]
		private CookingStation _mcCookingStation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001260")]
		public OnRemoveIngredientDelegate OnRemoveIngredient;

		[Cpp2IlInjected.Token(Token = "0x170003FD")]
		public IEnumerable<Item> SelectedIngredientList
		{
			[Cpp2IlInjected.Token(Token = "0x60017D7")]
			[Cpp2IlInjected.Address(RVA = "0x125F340", Offset = "0x125DD40", VA = "0x18125F340")]
			get
			{
				List<Item> selectedIngredients = _mcCookingStation.CookingStall.selectedIngredients;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017D8")]
		[Cpp2IlInjected.Address(RVA = "0x125F100", Offset = "0x125DB00", VA = "0x18125F100")]
		private void Start()
		{
			//Discarded unreachable code: IL_0093
			//IL_0062: Expected O, but got I4
			//IL_0082: Expected I4, but got F4
			int num = 0;
			SelectedIngredientItem selectIngredientPrefab = _selectIngredientPrefab;
			Transform parent = base.transform;
			SelectedIngredientItem selectedIngredientItem = UnityEngine.Object.Instantiate(selectIngredientPrefab, parent);
			RectTransform content = selectedIngredientItem._content;
			float z = Vector3.zero.z;
			SelectedIngredientItem.OnRemoveDelegate onRemove = selectedIngredientItem.OnRemove;
			SelectedIngredientItem.OnRemoveDelegate b = OnRemove;
			Delegate @delegate = Delegate.Combine(onRemove, b);
			int num2 = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				selectedIngredientItem.OnRemove = (SelectedIngredientItem.OnRemoveDelegate)num2;
				RectTransform content2 = selectedIngredientItem._content;
				float z2 = Vector3.one.z;
				TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.Unset).SetDelay(3.8E-44f);
				num++;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017D9")]
		[Cpp2IlInjected.Address(RVA = "0x125D800", Offset = "0x125C200", VA = "0x18125D800")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0063, IL_006f, IL_0081
			//IL_0027: Expected O, but got I4
			SelectedIngredientItem selectedIngredientItem = default(SelectedIngredientItem);
			Delegate @delegate = default(Delegate);
			while (true)
			{
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num = 0;
					if (enumerator == null)
					{
						break;
					}
					int num2 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num3 = 0;
					if (!(selectedIngredientItem != (UnityEngine.Object)num3))
					{
						continue;
					}
					SelectedIngredientItem.OnRemoveDelegate onRemove = selectedIngredientItem.OnRemove;
					SelectedIngredientItem.OnRemoveDelegate value = OnRemove;
					@delegate = Delegate.Remove(onRemove, value);
					if ((object)@delegate != null && (object)@delegate == null)
					{
						throw new InvalidCastException();
					}
					selectedIngredientItem.OnRemove = (SelectedIngredientItem.OnRemoveDelegate)@delegate;
				}
				if ((object)@delegate == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017DA")]
		[Cpp2IlInjected.Address(RVA = "0x125E230", Offset = "0x125CC30", VA = "0x18125E230")]
		public void RefreshSelected()
		{
			//Discarded unreachable code: IL_00cc, IL_00d2, IL_00e4
			//IL_009d: Expected I4, but got F4
			List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)_mcCookingStation.CookingStall.selectedIngredients);
			IEnumerator enumerator = base.transform.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			if ((object)gameObject != null)
			{
			}
			SelectedIngredientItem selectedIngredientItem = default(SelectedIngredientItem);
			RectTransform content = selectedIngredientItem._content;
			float z = Vector3.zero.z;
			SelectedIngredientItem.OnRemoveDelegate b = default(SelectedIngredientItem.OnRemoveDelegate);
			Delegate @delegate = Delegate.Combine(selectedIngredientItem.OnRemove, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				selectedIngredientItem.OnRemove = (SelectedIngredientItem.OnRemoveDelegate)@delegate;
				RectTransform content2 = selectedIngredientItem._content;
				float z2 = Vector3.one.z;
				TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.Unset).SetDelay(3.8E-44f);
				Transform transform = selectedIngredientItem.transform;
				int index = 0;
				Transform transform2 = default(Transform);
				Transform child = transform2.GetChild(index);
				bool flag = transform == child;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017DB")]
		[Cpp2IlInjected.Address(RVA = "0x125E770", Offset = "0x125D170", VA = "0x18125E770")]
		public void RemoveAllSelected()
		{
			//Discarded unreachable code: IL_00af
			//IL_0035: Expected O, but got I4
			List<SelectedIngredientItem> list = (List<SelectedIngredientItem>)(object)new List<T>();
			int num = 0;
			int childCount = base.transform.childCount;
			if (num < childCount)
			{
				SelectedIngredientItem component = base.transform.GetChild(num).GetComponent<SelectedIngredientItem>();
				int num2 = 0;
				bool flag = default(bool);
				if (component != (UnityEngine.Object)num2 && flag)
				{
					((List<T>)(object)list).Add((T)component);
				}
				num++;
				Transform transform = base.transform;
			}
			SelectedIngredientItem removedItem = Enumerable.FirstOrDefault<SelectedIngredientItem>((IEnumerable<>)list);
			int animate = 0;
			OnRemove(removedItem, (byte)animate != 0);
			int index = 0;
			((List<T>)(object)list).RemoveAt(index);
			CookingStation mcCookingStation = _mcCookingStation;
			bool canStartCooking = mcCookingStation.CookingStall.CanStartCooking;
			mcCookingStation.RefreshCookingButton(canStartCooking);
			CookingStation mcCookingStation2 = _mcCookingStation;
			Item _003CSelectedRecipe_003Ek__BackingField = mcCookingStation2.CookingStall.SelectedRecipe;
			mcCookingStation2.RefreshAutofillButton(_003CSelectedRecipe_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x60017DC")]
		[Cpp2IlInjected.Address(RVA = "0x125ED20", Offset = "0x125D720", VA = "0x18125ED20")]
		public void ResetSelected()
		{
			//Discarded unreachable code: IL_009b, IL_00a1, IL_00b3
			//IL_0088: Expected I4, but got F4
			IEnumerator enumerator = base.transform.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			if ((object)gameObject != null)
			{
			}
			int num3 = 0;
			SelectedIngredientItem selectedIngredientItem = default(SelectedIngredientItem);
			RectTransform content = selectedIngredientItem._content;
			float z = Vector3.zero.z;
			SelectedIngredientItem.OnRemoveDelegate b = default(SelectedIngredientItem.OnRemoveDelegate);
			Delegate @delegate = Delegate.Combine(selectedIngredientItem.OnRemove, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				selectedIngredientItem.OnRemove = (SelectedIngredientItem.OnRemoveDelegate)@delegate;
				RectTransform content2 = selectedIngredientItem._content;
				float z2 = Vector3.one.z;
				TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.Unset).SetDelay(3.8E-44f);
				num3++;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017DD")]
		[Cpp2IlInjected.Address(RVA = "0x125DA90", Offset = "0x125C490", VA = "0x18125DA90")]
		private unsafe void OnRemove(SelectedIngredientItem removedItem, bool animate = true)
		{
			//Discarded unreachable code: IL_0180
			//IL_0099: Expected O, but got I4
			OnRemoveIngredientDelegate onRemoveIngredient = OnRemoveIngredient;
			if (onRemoveIngredient != null)
			{
				SelectedIngredientItem selectedIngredientItem = removedItem;
				Item removedIngredient = default(Item);
				onRemoveIngredient(removedIngredient, animate);
			}
			SelectedIngredientItem selectedIngredientItem2 = removedItem;
			SelectedIngredientItem.OnRemoveDelegate onRemoveDelegate = OnRemove;
			Delegate @delegate = Delegate.Remove(onRemoveDelegate, onRemoveDelegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				selectedIngredientItem2.OnRemove = (SelectedIngredientItem.OnRemoveDelegate)@delegate;
				SelectedIngredientItem selectedIngredientItem3 = removedItem;
				RectTransform component = default(RectTransform);
				if (!animate)
				{
					UnityEngine.Object.Destroy(selectedIngredientItem3.gameObject);
					Transform transform = removedItem.transform;
					int num = 0;
					transform.parent = (Transform)num;
					SelectedIngredientItem selectIngredientPrefab = _selectIngredientPrefab;
					Transform parent = base.transform;
					SelectedIngredientItem selectedIngredientItem4 = UnityEngine.Object.Instantiate(selectIngredientPrefab, parent);
					RectTransform content = selectedIngredientItem4._content;
					float z = Vector3.one.z;
					SelectedIngredientItem.OnRemoveDelegate onRemoveDelegate2 = OnRemove;
					Delegate delegate2 = default(Delegate);
					if ((object)delegate2 != null && (object)delegate2 == null)
					{
						goto IL_0186;
					}
					selectedIngredientItem4.OnRemove = (SelectedIngredientItem.OnRemoveDelegate)delegate2;
					component = GetComponent<RectTransform>();
					LayoutRebuilder.ForceRebuildLayoutImmediate(component);
				}
				RectTransform component2 = component.GetComponent<RectTransform>();
				TweenerCore<Vector2, Vector2, VectorOptions> t = default(TweenerCore<Vector2, Vector2, VectorOptions>);
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = t.SetEase(Ease.InBack);
				TweenCallback tweenCallback = delegate
				{
					//Discarded unreachable code: IL_0011
					LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
				};
				Delegate delegate3 = default(Delegate);
				if ((object)delegate3 == null || (object)delegate3 != null)
				{
					TweenCallback tweenCallback2 = delegate
					{
						//Discarded unreachable code: IL_00ee
						//IL_0025: Expected O, but got I4
						UnityEngine.Object.Destroy(removedItem.gameObject);
						Transform transform2 = removedItem.transform;
						int num2 = 0;
						transform2.parent = (Transform)num2;
						if (base.transform.childCount < 5)
						{
							SelectedIngredientsContent selectedIngredientsContent = this;
							SelectedIngredientItem selectIngredientPrefab2 = selectedIngredientsContent._selectIngredientPrefab;
							Transform parent2 = selectedIngredientsContent.transform;
							SelectedIngredientItem selectedIngredientItem5 = UnityEngine.Object.Instantiate(selectIngredientPrefab2, parent2);
							RectTransform content2 = selectedIngredientItem5._content;
							float z2 = Vector3.zero.z;
							SelectedIngredientItem.OnRemoveDelegate onRemove = selectedIngredientItem5.OnRemove;
							SelectedIngredientsContent selectedIngredientsContent2 = this;
							SelectedIngredientItem.OnRemoveDelegate onRemoveDelegate3 = default(SelectedIngredientItem.OnRemoveDelegate);
							if ((object)selectedIngredientsContent2 == null && onRemoveDelegate3 == null)
							{
								throw new ArgumentException();
							}
							((Delegate)onRemoveDelegate3).method_ptr = (IntPtr)__ldftn(SelectedIngredientsContent.OnRemove);
							((Delegate)onRemoveDelegate3).m_target = selectedIngredientsContent2;
							((Delegate)onRemoveDelegate3).method = (IntPtr)__ldftn(SelectedIngredientsContent.OnRemove);
							Delegate delegate5 = Delegate.Combine(onRemove, onRemoveDelegate3);
							if ((object)delegate5 != null && (object)delegate5 == null)
							{
								throw new InvalidCastException();
							}
							selectedIngredientItem5.OnRemove = (SelectedIngredientItem.OnRemoveDelegate)delegate5;
							RectTransform content3 = selectedIngredientItem5._content;
							float z3 = Vector3.one.z;
							TweenerCore<Vector3, Vector3, VectorOptions> t2 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
							TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t2.SetEase(Ease.OutBack);
						}
					};
					Delegate delegate4 = default(Delegate);
					if ((object)delegate4 == null || (object)delegate4 != null)
					{
						CookingStation mcCookingStation = _mcCookingStation;
						bool canStartCooking = mcCookingStation.CookingStall.CanStartCooking;
						mcCookingStation.RefreshCookingButton(canStartCooking);
						CookingStation mcCookingStation2 = _mcCookingStation;
						Item _003CSelectedRecipe_003Ek__BackingField = mcCookingStation2.CookingStall.SelectedRecipe;
						mcCookingStation2.RefreshAutofillButton(_003CSelectedRecipe_003Ek__BackingField);
						return;
					}
				}
			}
			goto IL_0186;
			IL_0186:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017DE")]
		[Cpp2IlInjected.Address(RVA = "0x125D3C0", Offset = "0x125BDC0", VA = "0x18125D3C0")]
		public unsafe void AddIngredient(Item ingredientItem)
		{
			//Discarded unreachable code: IL_004e, IL_0054, IL_005a, IL_0066
			SelectedIngredientItem selectedIngredientItem = default(SelectedIngredientItem);
			Transform transform = default(Transform);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					if ((object)selectedIngredientItem != null)
					{
						Item item = selectedIngredientItem.Item;
					}
					Item invalid = Item.Invalid;
					while (num == 0)
					{
					}
					if (!(*(Item*)num == *(Item*)invalid))
					{
						continue;
					}
					int index = 0;
					Transform child = transform.GetChild(index);
				}
				if (!flag)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60017DF")]
		[Cpp2IlInjected.Address(RVA = "0x125DF80", Offset = "0x125C980", VA = "0x18125DF80")]
		internal void RefreshIngredientsDisplay()
		{
			//Discarded unreachable code: IL_006c, IL_0072, IL_0078, IL_007e, IL_0084, IL_008a, IL_0090, IL_0096, IL_00a8
			IEnumerator enumerator = base.transform.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				SelectedIngredientItem selectedIngredientItem = default(SelectedIngredientItem);
				if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					bool active = default(bool);
					selectedIngredientItem._btnClose.gameObject.SetActive(active);
				}
				gameObject = selectedIngredientItem._btnClose.gameObject;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
			}
			if ((object)gameObject == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017E0")]
		[Cpp2IlInjected.Address(RVA = "0x125E9F0", Offset = "0x125D3F0", VA = "0x18125E9F0")]
		internal void RemoveLastIngredient()
		{
			//Discarded unreachable code: IL_009b, IL_00a1, IL_00b3
			int num = 0;
			if ((_mcCookingStation.IsAutoFilling ? 1 : 0) != num)
			{
				return;
			}
			int childCount = base.transform.childCount;
			if (childCount > 0)
			{
				Transform transform = base.transform;
				int num2 = childCount - 1;
				childCount = num2;
				SelectedIngredientItem component = transform.GetChild(num2).GetComponent<SelectedIngredientItem>();
				bool flag = default(bool);
				while (!flag)
				{
				}
				component.OnRemoveClickHandler();
			}
			IEnumerator enumerator = base.transform.GetEnumerator();
			SelectedIngredientItem selectedIngredientItem = default(SelectedIngredientItem);
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				selectedIngredientItem.OnRefreshDisplay?.Invoke();
				selectedIngredientItem.Refresh();
			}
			if ((object)selectedIngredientItem == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017E1")]
		[Cpp2IlInjected.Address(RVA = "0x125D6D0", Offset = "0x125C0D0", VA = "0x18125D6D0")]
		internal int GetAddedIngredientsCount()
		{
			//Discarded unreachable code: IL_0034
			int childCount = base.transform.childCount;
			int result = 0;
			if (childCount > 0)
			{
				Transform transform = base.transform;
				int num = childCount - 1;
				childCount = num;
				SelectedIngredientItem component = transform.GetChild(num).GetComponent<SelectedIngredientItem>();
				bool flag = default(bool);
				while (!flag)
				{
				}
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60017E2")]
		[Cpp2IlInjected.Address(RVA = "0x125E700", Offset = "0x125D100", VA = "0x18125E700")]
		private void RefreshStationButton()
		{
			//Discarded unreachable code: IL_0035
			CookingStation mcCookingStation = _mcCookingStation;
			bool canStartCooking = mcCookingStation.CookingStall.CanStartCooking;
			mcCookingStation.RefreshCookingButton(canStartCooking);
			CookingStation mcCookingStation2 = _mcCookingStation;
			Item _003CSelectedRecipe_003Ek__BackingField = mcCookingStation2.CookingStall.SelectedRecipe;
			mcCookingStation2.RefreshAutofillButton(_003CSelectedRecipe_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x60017E3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SelectedIngredientsContent()
		{
		}
	}
}
