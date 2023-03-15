using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010DA")]
	public class AvatarWorkingCopy
	{
		[Cpp2IlInjected.Token(Token = "0x170017B0")]
		public Avatar Data
		{
			[Cpp2IlInjected.Token(Token = "0x6008898")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008899")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400455A")]
		public bool IsMale
		{
			[Cpp2IlInjected.Token(Token = "0x600889A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600889B")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x600889C")]
		[Cpp2IlInjected.Address(RVA = "0x1AB4D60", Offset = "0x1AB3760", VA = "0x181AB4D60")]
		public Item CurrentClothingItem(ClothingItemType clothingType)
		{
			Avatar avatar = Data;
			bool flag = default(bool);
			if (!flag)
			{
				return Item.Invalid;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600889D")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6370", Offset = "0x1AB4D70", VA = "0x181AB6370")]
		public bool SetClothes(Item item)
		{
			//IL_0032: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			Avatar avatar = Data;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag && flag2)
			{
				ClothingItemType clothingItemType = default(ClothingItemType);
				int num = (int)clothingItemType;
				MapField<uint, int> clothes_ = Data.clothes_;
				if (((MapField<TKey, TValue>)(object)Data.incompatibleClothes_).ContainsKey((TKey)num))
				{
					bool flag3 = ((MapField<TKey, TValue>)(object)Data.incompatibleClothes_).Remove((TKey)num);
				}
				HashSet<ClothingItemType> hashSet = default(HashSet<ClothingItemType>);
				this.RemoveIncompatibles((HashSet<>)(object)hashSet);
				this.RestoreIncompatibles((HashSet<>)(object)hashSet);
				FixWithDefaultClothingItems();
				return true;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600889E")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5900", Offset = "0x1AB4300", VA = "0x181AB5900")]
		public bool RemoveClothes(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_00e7
			//IL_0021: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_00a3: Expected O, but got I8
			//IL_00a3: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			Avatar avatar = Data;
			bool flag = default(bool);
			if (!flag)
			{
				goto IL_00e2;
			}
			bool flag2 = ((MapField<TKey, TValue>)(object)Data.clothes_).Remove((TKey)clothingType);
			HashSet<ClothingItemType> currentIncompatibilities = (HashSet<ClothingItemType>)(object)this.GetCurrentIncompatibilities();
			this.RestoreIncompatibles((HashSet<>)(object)currentIncompatibilities);
			if (!AvatarRules.IsAdequatelyDressed(Data))
			{
				if (!((MapField<TKey, TValue>)(object)Data.clothes_).ContainsKey((TKey)9))
				{
					int clothingType2 = 0;
					FixWithDefaultClothingItem((ClothingItemType)clothingType2);
					FixWithDefaultClothingItem(ClothingItemType.CloBottomInner);
				}
				if (!AvatarRules.IsAdequatelyDressed(Data))
				{
					Avatar avatar2 = Data;
					bool flag3 = default(bool);
					bool flag4 = default(bool);
					if (!flag3 && flag4)
					{
						ClothingItemType clothingItemType = default(ClothingItemType);
						int num = (int)clothingItemType;
						ulong num2 = default(ulong);
						((MapField<TKey, TValue>)(object)Data.clothes_)[(TKey)num] = (TValue)num2;
						if (((MapField<TKey, TValue>)(object)Data.incompatibleClothes_).ContainsKey((TKey)num))
						{
							bool flag5 = ((MapField<TKey, TValue>)(object)Data.incompatibleClothes_).Remove((TKey)num);
						}
						HashSet<ClothingItemType> hashSet = default(HashSet<ClothingItemType>);
						this.RemoveIncompatibles((HashSet<>)(object)hashSet);
						this.RestoreIncompatibles((HashSet<>)(object)hashSet);
						FixWithDefaultClothingItems();
					}
					goto IL_00e2;
				}
			}
			goto IL_00e5;
			IL_00e5:
			return true;
			IL_00e2:
			int num3 = 0;
			goto IL_00e5;
			[Cpp2IlInjected.Token(Token = "0x60088BB")]
			[Cpp2IlInjected.Address(RVA = "0x1AB6D10", Offset = "0x1AB5710", VA = "0x181AB6D10")]
			void FixWithDefaultClothingItem(ClothingItemType clothingType)
			{
				//IL_0013: Expected O, but got I4
				//IL_008c: Expected O, but got I4
				//IL_008c: Expected O, but got I4
				int num4 = (int)clothingType;
				if (!((MapField<TKey, TValue>)(object)Data.clothes_).ContainsKey((TKey)num4))
				{
					MapField<uint, int> clothes_ = Data.clothes_;
					AvatarRules _003CInstance_003Ek__BackingField = AvatarRules.Instance;
					DefaultAvatar defaultAvatar = _003CInstance_003Ek__BackingField.defaultAvatar;
					if (IsMale && defaultAvatar == null)
					{
						_003CInstance_003Ek__BackingField.LoadDefaultAvatar();
						DefaultAvatar defaultAvatar2 = _003CInstance_003Ek__BackingField.defaultAvatar;
					}
					if (defaultAvatar == null)
					{
						_003CInstance_003Ek__BackingField.LoadDefaultAvatar();
						DefaultAvatar defaultAvatar3 = _003CInstance_003Ek__BackingField.defaultAvatar;
					}
					Avatar female_ = defaultAvatar.female_;
					int num5 = 0;
					uint num6 = default(uint);
					if (num5 < (int)num6)
					{
						num5 += num5;
						if (num5 == (int)num6)
						{
							num4 += num4;
							throw new NullReferenceException();
						}
						num5++;
					}
					((MapField<TKey, TValue>)(object)clothes_)[(TKey)num4] = (TValue)num5;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600889F")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5BA0", Offset = "0x1AB45A0", VA = "0x181AB5BA0")]
		private void RemoveIncompatibles(HashSet<ClothingItemType> toRemove)
		{
			//Discarded unreachable code: IL_002d, IL_0033, IL_0039, IL_003f, IL_0045
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				Avatar avatar = Data;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				MapField<uint, int> incompatibleClothes_ = Data.incompatibleClothes_;
				MapField<uint, int> clothes_ = Data.clothes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088A0")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5F20", Offset = "0x1AB4920", VA = "0x181AB5F20")]
		private void RestoreIncompatibles(HashSet<ClothingItemType> incompatibilities)
		{
			//Discarded unreachable code: IL_006f, IL_0075, IL_007b, IL_0081, IL_0087, IL_008d
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				List<KeyValuePair<uint, int>> list = (List<KeyValuePair<uint, int>>)(object)Enumerable.ToList<KeyValuePair<uint, int>>(Enumerable.AsEnumerable<KeyValuePair<uint, int>>((IEnumerable<>)(object)Data.incompatibleClothes_));
				if (flag)
				{
					while (flag2)
					{
					}
					HashSet<ClothingItemType> hashSet = (HashSet<ClothingItemType>)(object)new HashSet<T>();
					Func<ClothingItemType, bool> cpp2il__autoParamName__idx_ = (Func<ClothingItemType, bool>)(object)(Func<T, TResult>)((ClothingItemType x) => Data.IsWearing(x));
					if (!((IEnumerable<>)hashSet).Any<ClothingItemType>((Func<, >)(object)cpp2il__autoParamName__idx_))
					{
						((HashSet<T>)(object)incompatibilities).UnionWith((IEnumerable<>)hashSet);
						Avatar avatar = Data;
						MapField<uint, int> clothes_ = avatar.clothes_;
						MapField<uint, int> incompatibleClothes_ = avatar.incompatibleClothes_;
						MapField<uint, int> incompatibleClothes_2 = Data.incompatibleClothes_;
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088A1")]
		[Cpp2IlInjected.Address(RVA = "0x1AB4F00", Offset = "0x1AB3900", VA = "0x181AB4F00")]
		private static HashSet<ClothingItemType> GetBaseIncompatibilities(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_0060
			//IL_001a: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			if (clothingType > ClothingItemType.CloTopOuter && clothingType == ClothingItemType.CloFullbody)
			{
				HashSet<ClothingItemType> hashSet = (HashSet<ClothingItemType>)(object)new HashSet<T>();
				int num = 0;
				bool flag = ((HashSet<T>)(object)hashSet).Add((T)num);
				bool flag2 = ((HashSet<T>)(object)hashSet).Add((T)7);
				bool flag3 = ((HashSet<T>)(object)hashSet).Add((T)1);
				bool flag4 = ((HashSet<T>)(object)hashSet).Add((T)15);
				return hashSet;
			}
			if (clothingType > ClothingItemType.CloBottomInner && clothingType != ClothingItemType.CloTopOuter)
			{
				return (HashSet<ClothingItemType>)(object)new HashSet<T>();
			}
			HashSet<ClothingItemType> hashSet2 = (HashSet<ClothingItemType>)(object)new HashSet<T>();
			bool flag5 = ((HashSet<T>)(object)hashSet2).Add((T)9);
			return hashSet2;
		}

		[Cpp2IlInjected.Token(Token = "0x60088A2")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5270", Offset = "0x1AB3C70", VA = "0x181AB5270")]
		private static void GetIncompatibilities(HashSet<ClothingItemType> incompatibilities, ClothingItemType clothingType, Item item)
		{
			//Discarded unreachable code: IL_0072
			//IL_001a: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			if (clothingType > ClothingItemType.CloTopOuter && clothingType == ClothingItemType.CloFullbody)
			{
				HashSet<ClothingItemType> hashSet = (HashSet<ClothingItemType>)(object)new HashSet<T>();
				int num = 0;
				bool flag = ((HashSet<T>)(object)hashSet).Add((T)num);
				bool flag2 = ((HashSet<T>)(object)hashSet).Add((T)7);
				bool flag3 = ((HashSet<T>)(object)hashSet).Add((T)1);
			}
			if (clothingType > ClothingItemType.CloBottomInner && clothingType != ClothingItemType.CloTopOuter)
			{
				HashSet<ClothingItemType> hashSet2 = (HashSet<ClothingItemType>)(object)new HashSet<T>();
			}
			HashSet<ClothingItemType> hashSet3 = (HashSet<ClothingItemType>)(object)new HashSet<T>();
			bool flag4 = ((HashSet<T>)(object)hashSet3).Add((T)9);
			((HashSet<T>)(object)incompatibilities).UnionWith((IEnumerable<>)hashSet3);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ClothingItemData clothingItemData = default(ClothingItemData);
			RepeatedField<ClothingItemType> incompatibleWith_ = clothingItemData.incompatibleWith_;
			((HashSet<T>)(object)incompatibilities).UnionWith((IEnumerable<>)(object)incompatibleWith_);
		}

		[Cpp2IlInjected.Token(Token = "0x60088A3")]
		[Cpp2IlInjected.Address(RVA = "0x1AB50D0", Offset = "0x1AB3AD0", VA = "0x181AB50D0")]
		private HashSet<ClothingItemType> GetCurrentIncompatibilities()
		{
			//Discarded unreachable code: IL_0018
			HashSet<ClothingItemType> result = (HashSet<ClothingItemType>)(object)new HashSet<T>();
			MapField<uint, int> clothes_ = Data.clothes_;
			bool flag = default(bool);
			if (flag)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60088A4")]
		[Cpp2IlInjected.Address(RVA = "0x1AB54A0", Offset = "0x1AB3EA0", VA = "0x181AB54A0")]
		private HashSet<ClothingItemType> GetNewIncompatibilities(ClothingItemType clothingType, Item newClothingItem)
		{
			//Discarded unreachable code: IL_0034, IL_003a, IL_0040
			HashSet<ClothingItemType> hashSet = (HashSet<ClothingItemType>)(object)new HashSet<T>();
			MapField<uint, int> clothes_ = Data.clothes_;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				HashSet<ClothingItemType> hashSet2 = (HashSet<ClothingItemType>)(object)new HashSet<T>();
				bool flag3 = default(bool);
				if (!flag3)
				{
					((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)hashSet2);
				}
			}
			return hashSet;
		}

		[Cpp2IlInjected.Token(Token = "0x60088A5")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6A90", Offset = "0x1AB5490", VA = "0x181AB6A90")]
		public bool SetMakeup(MakeupItemType makeupType, int makeupIndex)
		{
			//IL_0013: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_00c3: Expected O, but got I4
			bool flag = ((MapField<TKey, TValue>)(object)Data.makeup_).ContainsKey((TKey)makeupType);
			int num = 0;
			Item item = default(Item);
			if (flag && (IntPtr)((Makeup)((MapField<TKey, TValue>)(object)Data.makeup_)[(TKey)makeupType]).makeupItemID_ == (IntPtr)item)
			{
				int num2 = 0;
			}
			Item item2 = default(Item);
			int itemID = item2.ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Makeup makeup = new Makeup();
			makeup.makeupItemID_ = itemID;
			MakeupItemData makeupItemData = default(MakeupItemData);
			int num3 = (makeup.colorIndex1_ = makeupItemData.defaultColor1_);
			int num4 = (makeup.colorIndex2_ = makeupItemData.defaultColor2_);
			int num5 = (makeup.colorIndex3_ = makeupItemData.defaultColor3_);
			float num6 = (makeup.opacity_ = makeupItemData.defaultOpacity_);
			float num7 = (makeup.gloss_ = makeupItemData.defaultGloss_);
			((MapField<TKey, TValue>)(object)Data.makeup_)[(TKey)makeupType] = (TValue)makeup;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088A6")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6750", Offset = "0x1AB5150", VA = "0x181AB6750")]
		public bool SetMakeupColor1(MakeupItemType makeupType, int index)
		{
			//IL_0013: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)Data.makeup_).ContainsKey((TKey)makeupType))
			{
				((Makeup)((MapField<TKey, TValue>)(object)Data.makeup_)[(TKey)makeupType]).colorIndex1_ = index;
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088A7")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6820", Offset = "0x1AB5220", VA = "0x181AB6820")]
		public bool SetMakeupColor2(MakeupItemType makeupType, int index)
		{
			//IL_0013: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)Data.makeup_).ContainsKey((TKey)makeupType))
			{
				((Makeup)((MapField<TKey, TValue>)(object)Data.makeup_)[(TKey)makeupType]).colorIndex2_ = index;
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088A8")]
		[Cpp2IlInjected.Address(RVA = "0x1AB68F0", Offset = "0x1AB52F0", VA = "0x181AB68F0")]
		public bool SetMakeupColor3(MakeupItemType makeupType, int index)
		{
			//IL_0013: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)Data.makeup_).ContainsKey((TKey)makeupType))
			{
				((Makeup)((MapField<TKey, TValue>)(object)Data.makeup_)[(TKey)makeupType]).colorIndex3_ = index;
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088A9")]
		[Cpp2IlInjected.Address(RVA = "0x1AB69C0", Offset = "0x1AB53C0", VA = "0x181AB69C0")]
		public bool SetMakeupOpacity(MakeupItemType makeupType, float opacity)
		{
			//IL_0013: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)Data.makeup_).ContainsKey((TKey)makeupType))
			{
				((Makeup)((MapField<TKey, TValue>)(object)Data.makeup_)[(TKey)makeupType]).opacity_ = opacity;
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088AA")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5D40", Offset = "0x1AB4740", VA = "0x181AB5D40")]
		public bool RemoveMakeup(MakeupItemType makeupType)
		{
			//IL_0013: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)Data.makeup_).ContainsKey((TKey)makeupType))
			{
				bool flag = ((MapField<TKey, TValue>)(object)Data.makeup_).Remove((TKey)makeupType);
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088AB")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5050", Offset = "0x1AB3A50", VA = "0x181AB5050")]
		public int GetClothingCustomization(Item item)
		{
			//Discarded unreachable code: IL_000e
			MapField<int, int> clothingCustomization_ = Data.clothingCustomization_;
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x60088AC")]
		[Cpp2IlInjected.Address(RVA = "0x1AB64F0", Offset = "0x1AB4EF0", VA = "0x181AB64F0")]
		public bool SetClothingCustomization(Item item, int designId)
		{
			//Discarded unreachable code: IL_0059
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			int itemID = item.ItemID;
			if (designId != -1)
			{
				MapField<int, int> clothingCustomization_ = Data.clothingCustomization_;
				bool flag = default(bool);
				if (flag)
				{
					int num = 0;
				}
				((MapField<TKey, TValue>)(object)Data.clothingCustomization_)[(TKey)itemID] = (TValue)designId;
				return true;
			}
			MapField<int, int> clothingCustomization_2 = Data.clothingCustomization_;
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			bool flag3 = ((MapField<TKey, TValue>)(object)Data.clothingCustomization_).Remove((TKey)itemID);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60088AD")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5DF0", Offset = "0x1AB47F0", VA = "0x181AB5DF0")]
		public bool ResetClothingCustomization(Item item, int designId = -1)
		{
			//IL_002c: Expected O, but got I4
			int itemID = item.ItemID;
			MapField<int, int> clothingCustomization_ = Data.clothingCustomization_;
			bool flag = default(bool);
			if (flag && designId == -1)
			{
				bool flag2 = ((MapField<TKey, TValue>)(object)Data.clothingCustomization_).Remove((TKey)itemID);
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088AE")]
		[Cpp2IlInjected.Address(RVA = "0x1AB4E00", Offset = "0x1AB3800", VA = "0x181AB4E00")]
		public unsafe int CurrentFaceType(FacePartType facePartType)
		{
			//Discarded unreachable code: IL_001b
			//IL_0018: Expected O, but got I4
			Avatar avatar = Data;
			int num = 0;
			bool flag = ((MapField<TKey, TValue>)(object)avatar.faceType_).TryGetValue((TKey)facePartType, out *(TValue*)num);
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60088AF")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6670", Offset = "0x1AB5070", VA = "0x181AB6670")]
		public unsafe bool SetFaceType(FacePartType facePartType, int index)
		{
			//IL_0018: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			Avatar avatar = Data;
			int num = 0;
			bool flag = ((MapField<TKey, TValue>)(object)avatar.faceType_).TryGetValue((TKey)facePartType, out *(TValue*)num);
			if (num != index)
			{
				((MapField<TKey, TValue>)(object)Data.faceType_)[(TKey)facePartType] = (TValue)index;
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088B0")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5EC0", Offset = "0x1AB48C0", VA = "0x181AB5EC0")]
		public bool ResetFaceType(FacePartType facePartType)
		{
			//Discarded unreachable code: IL_0016
			//IL_0013: Expected O, but got I4
			bool flag = ((MapField<TKey, TValue>)(object)Data.faceType_).Remove((TKey)facePartType);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60088B1")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5730", Offset = "0x1AB4130", VA = "0x181AB5730")]
		public bool IsWearing(MakeupItemType makeupType)
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected O, but got I4
			return ((MapField<TKey, TValue>)(object)Data.makeup_).ContainsKey((TKey)makeupType);
		}

		[Cpp2IlInjected.Token(Token = "0x60088B2")]
		[Cpp2IlInjected.Address(RVA = "0x1AB57B0", Offset = "0x1AB41B0", VA = "0x181AB57B0")]
		public bool IsWearing(MakeupItemType makeupType, int makeupIndex)
		{
			//Discarded unreachable code: IL_0034
			//IL_0013: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			bool flag = ((MapField<TKey, TValue>)(object)Data.makeup_).ContainsKey((TKey)makeupType);
			if (!flag)
			{
				return flag;
			}
			Item item = default(Item);
			return (IntPtr)((Makeup)((MapField<TKey, TValue>)(object)Data.makeup_)[(TKey)makeupType]).makeupItemID_ == (IntPtr)item;
		}

		[Cpp2IlInjected.Token(Token = "0x60088B3")]
		[Cpp2IlInjected.Address(RVA = "0x1AB58C0", Offset = "0x1AB42C0", VA = "0x181AB58C0")]
		public bool IsWearing(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_000d
			return Data.IsWearing(clothingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60088B4")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5790", Offset = "0x1AB4190", VA = "0x181AB5790")]
		public bool IsWearing(ClothingItemType clothingType, out Item item)
		{
			//Discarded unreachable code: IL_000e
			return Data.IsWearing(clothingType, out item);
		}

		[Cpp2IlInjected.Token(Token = "0x60088B5")]
		[Cpp2IlInjected.Address(RVA = "0x1AB58E0", Offset = "0x1AB42E0", VA = "0x181AB58E0")]
		public bool IsWearing(Item item)
		{
			//Discarded unreachable code: IL_000d
			return Data.IsWearing(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60088B6")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6280", Offset = "0x1AB4C80", VA = "0x181AB6280")]
		public void RevertToDefault()
		{
			AvatarRules _003CInstance_003Ek__BackingField = AvatarRules.Instance;
			DefaultAvatar defaultAvatar = _003CInstance_003Ek__BackingField.defaultAvatar;
			if (IsMale && defaultAvatar == null)
			{
				_003CInstance_003Ek__BackingField.LoadDefaultAvatar();
				DefaultAvatar defaultAvatar2 = _003CInstance_003Ek__BackingField.defaultAvatar;
			}
			if (defaultAvatar == null)
			{
				_003CInstance_003Ek__BackingField.LoadDefaultAvatar();
				DefaultAvatar defaultAvatar3 = _003CInstance_003Ek__BackingField.defaultAvatar;
			}
			Avatar avatar = (Data = defaultAvatar.female_.Clone());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088B7")]
		[Cpp2IlInjected.Address(RVA = "0x1AB4E80", Offset = "0x1AB3880", VA = "0x181AB4E80")]
		private void FixWithDefaultClothingItems()
		{
			//Discarded unreachable code: IL_0028
			//IL_0013: Expected O, but got I4
			if (!((MapField<TKey, TValue>)(object)Data.clothes_).ContainsKey((TKey)9))
			{
				int clothingType2 = 0;
				FixWithDefaultClothingItem((ClothingItemType)clothingType2);
				FixWithDefaultClothingItem(ClothingItemType.CloBottomInner);
			}
			[Cpp2IlInjected.Token(Token = "0x60088BB")]
			[Cpp2IlInjected.Address(RVA = "0x1AB6D10", Offset = "0x1AB5710", VA = "0x181AB6D10")]
			void FixWithDefaultClothingItem(ClothingItemType clothingType)
			{
				//IL_0013: Expected O, but got I4
				//IL_008c: Expected O, but got I4
				//IL_008c: Expected O, but got I4
				int num = (int)clothingType;
				if (!((MapField<TKey, TValue>)(object)Data.clothes_).ContainsKey((TKey)num))
				{
					MapField<uint, int> clothes_ = Data.clothes_;
					AvatarRules _003CInstance_003Ek__BackingField = AvatarRules.Instance;
					DefaultAvatar defaultAvatar = _003CInstance_003Ek__BackingField.defaultAvatar;
					if (IsMale && defaultAvatar == null)
					{
						_003CInstance_003Ek__BackingField.LoadDefaultAvatar();
						DefaultAvatar defaultAvatar2 = _003CInstance_003Ek__BackingField.defaultAvatar;
					}
					if (defaultAvatar == null)
					{
						_003CInstance_003Ek__BackingField.LoadDefaultAvatar();
						DefaultAvatar defaultAvatar3 = _003CInstance_003Ek__BackingField.defaultAvatar;
					}
					Avatar female_ = defaultAvatar.female_;
					int num2 = 0;
					uint num3 = default(uint);
					if (num2 < (int)num3)
					{
						num2 += num2;
						if (num2 == (int)num3)
						{
							num += num;
							throw new NullReferenceException();
						}
						num2++;
					}
					((MapField<TKey, TValue>)(object)clothes_)[(TKey)num] = (TValue)num2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088B8")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6EF0", Offset = "0x1AB58F0", VA = "0x181AB6EF0")]
		public AvatarWorkingCopy(AvatarWorkingCopy source)
		{
			//Discarded unreachable code: IL_0028
			Avatar avatar = (Data = source.Data.Clone());
			bool flag = (IsMale = source.IsMale);
		}

		[Cpp2IlInjected.Token(Token = "0x60088B9")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6F50", Offset = "0x1AB5950", VA = "0x181AB6F50")]
		public AvatarWorkingCopy(IAvatar source, bool isMale)
		{
			//Discarded unreachable code: IL_0079
			IsMale = isMale;
			int num = 0;
			Avatar avatar = default(Avatar);
			Data = avatar;
			if (((MapField<TKey, TValue>)(object)Data.clothes_).Count == 0)
			{
				AvatarRules _003CInstance_003Ek__BackingField = AvatarRules.Instance;
				DefaultAvatar defaultAvatar = _003CInstance_003Ek__BackingField.defaultAvatar;
				if ((IsMale ? 1 : 0) != num && defaultAvatar == null)
				{
					_003CInstance_003Ek__BackingField.LoadDefaultAvatar();
					DefaultAvatar defaultAvatar2 = _003CInstance_003Ek__BackingField.defaultAvatar;
				}
				if (defaultAvatar == null)
				{
					_003CInstance_003Ek__BackingField.LoadDefaultAvatar();
					DefaultAvatar defaultAvatar3 = _003CInstance_003Ek__BackingField.defaultAvatar;
				}
				Avatar avatar2 = (Data = defaultAvatar.female_.Clone());
			}
		}
	}
}
