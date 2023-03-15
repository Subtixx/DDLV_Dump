using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Meta.Customization;

namespace Mdl.Ui.Photo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000942")]
	public class SavedPhoto
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003683")]
		public string postedDate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003684")]
		public string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003685")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003686")]
		public int like;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003687")]
		public string downloadURL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003688")]
		public string uploadTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003689")]
		public string filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400368A")]
		public string steamFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400368B")]
		public PhotoModeImageFormat orientation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400368C")]
		public PhotoInfo photoInfo = new PhotoInfo();

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400368D")]
		public List<ItemData> clothItem = (List<ItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400368E")]
		public List<ItemData> makeupItem = (List<ItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400368F")]
		public List<ItemData> faceTypeItem = (List<ItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003690")]
		public List<ItemData> appearanceItem = (List<ItemData>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003A00")]
		[Cpp2IlInjected.Address(RVA = "0x1257180", Offset = "0x1255B80", VA = "0x181257180")]
		public SavedPhoto(SavedPhoto another)
		{
			//Discarded unreachable code: IL_0153
			string text = (postedDate = another.postedDate);
			string text2 = (displayName = another.displayName);
			string text3 = (url = another.url);
			int num = (like = another.like);
			string text4 = (downloadURL = another.downloadURL);
			string text5 = (filename = another.filename);
			string text6 = (uploadTime = another.uploadTime);
			PhotoInfo photoInfo = (this.photoInfo = new PhotoInfo(another.photoInfo));
			List<ItemData> list = clothItem;
			List<ItemData> list2 = another.clothItem;
			((List<T>)(object)list).AddRange((IEnumerable<>)list2);
			List<ItemData> list3 = makeupItem;
			List<ItemData> list4 = another.makeupItem;
			((List<T>)(object)list3).AddRange((IEnumerable<>)list4);
			List<ItemData> list5 = faceTypeItem;
			List<ItemData> list6 = another.faceTypeItem;
			((List<T>)(object)list5).AddRange((IEnumerable<>)list6);
			List<ItemData> list7 = appearanceItem;
			List<ItemData> list8 = another.appearanceItem;
			((List<T>)(object)list7).AddRange((IEnumerable<>)list8);
			string text7 = (steamFilename = another.steamFilename);
			PhotoModeImageFormat photoModeImageFormat = (orientation = another.orientation);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A01")]
		[Cpp2IlInjected.Address(RVA = "0x1257040", Offset = "0x1255A40", VA = "0x181257040")]
		public SavedPhoto()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003A02")]
		[Cpp2IlInjected.Address(RVA = "0x1256030", Offset = "0x1254A30", VA = "0x181256030")]
		public List<Item> GetClothItem()
		{
			//Discarded unreachable code: IL_0013, IL_0019, IL_001f
			List<Item> result = (List<Item>)(object)new List<T>();
			List<ItemData> list = clothItem;
			bool flag = default(bool);
			if (flag)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A03")]
		[Cpp2IlInjected.Address(RVA = "0x1256340", Offset = "0x1254D40", VA = "0x181256340")]
		public List<Item> GetMakeupItem()
		{
			//Discarded unreachable code: IL_0013, IL_0019, IL_001f
			List<Item> result = (List<Item>)(object)new List<T>();
			List<ItemData> list = makeupItem;
			bool flag = default(bool);
			if (flag)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A04")]
		[Cpp2IlInjected.Address(RVA = "0x12561D0", Offset = "0x1254BD0", VA = "0x1812561D0")]
		public Dictionary<string, int> GetFaceTypeItem()
		{
			//Discarded unreachable code: IL_0019, IL_001f, IL_0025
			Dictionary<string, int> result = (Dictionary<string, int>)(object)new Dictionary<TKey, TValue>();
			List<ItemData> list = faceTypeItem;
			bool flag = default(bool);
			if (flag)
			{
				throw new NullReferenceException();
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A05")]
		[Cpp2IlInjected.Address(RVA = "0x1255EC0", Offset = "0x12548C0", VA = "0x181255EC0")]
		public Dictionary<string, int> GetAppearanceItem()
		{
			//Discarded unreachable code: IL_0019, IL_001f, IL_0025
			Dictionary<string, int> result = (Dictionary<string, int>)(object)new Dictionary<TKey, TValue>();
			List<ItemData> list = appearanceItem;
			bool flag = default(bool);
			if (flag)
			{
				throw new NullReferenceException();
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A06")]
		[Cpp2IlInjected.Address(RVA = "0x12564E0", Offset = "0x1254EE0", VA = "0x1812564E0")]
		public unsafe void RetrieveCurrentItemList()
		{
			//Discarded unreachable code: IL_029a
			//IL_004b: Expected O, but got I4
			//IL_00bc: Expected O, but got I4
			//IL_00cf: Expected I4, but got O
			//IL_0142: Expected I4, but got I8
			//IL_0193: Expected I4, but got I8
			//IL_01c6: Expected I4, but got I8
			//IL_01f9: Expected I4, but got I8
			//IL_022c: Expected I4, but got I8
			//IL_025f: Expected I4, but got I8
			//IL_0284: Expected I4, but got I8
			AvatarWorkingCopy avatarWorkingCopy = default(AvatarWorkingCopy);
			Array values2;
			int num;
			while (true)
			{
				List<ItemData> list = clothItem;
				num = 0;
				((List<T>)(object)list).Clear();
				((List<T>)(object)clothItem).TrimExcess();
				Array values = Enum.GetValues(typeof(ClothingItemType));
				if (values == null)
				{
					continue;
				}
				if ((long)num < (long)(IntPtr)values)
				{
					int num2 = 0;
					int num3 = 0;
					if (((MapField<TKey, TValue>)(object)avatarWorkingCopy.Data.clothes_).TryGetValue((TKey)num3, out *(TValue*)num))
					{
						ItemData itemData = new ItemData();
						itemData.itemID = num;
						((List<T>)(object)clothItem).Add((T)itemData);
					}
					num++;
				}
				((List<T>)(object)makeupItem).Clear();
				((List<T>)(object)makeupItem).TrimExcess();
				values2 = Enum.GetValues(typeof(MakeupItemType));
				if (values2 != null)
				{
					break;
				}
			}
			if ((long)num < (long)(IntPtr)values2)
			{
				int num4 = 0;
				int num5 = 0;
				AvatarWorkingCopy avatarWorkingCopy2 = default(AvatarWorkingCopy);
				if (((MapField<TKey, TValue>)(object)avatarWorkingCopy2.Data.makeup_).TryGetValue((TKey)num5, out *(TValue*)num))
				{
					ItemData itemData2 = new ItemData();
					itemData2.itemID = (int)itemData2;
					((List<T>)(object)makeupItem).Add((T)itemData2);
				}
				num++;
			}
			((List<T>)(object)faceTypeItem).Clear();
			((List<T>)(object)faceTypeItem).TrimExcess();
			Array values3 = Enum.GetValues(typeof(FacePartType));
			if (values3 != null)
			{
				if ((long)num < (long)(IntPtr)values3)
				{
					int num6 = 0;
					AvatarWorkingCopy avatarWorkingCopy3 = default(AvatarWorkingCopy);
					MapField<uint, int> faceType_ = avatarWorkingCopy3.Data.faceType_;
					bool flag = default(bool);
					if (flag)
					{
						string name = (flag ? ((bool*)1) : ((bool*)null))->ToString();
						bool flag2 = flag;
						ulong num7 = default(ulong);
						ItemData item = new ItemData(name, num, -1, (uint)num7);
						((List<T>)(object)faceTypeItem).Add((T)item);
					}
					num++;
				}
				((List<T>)(object)appearanceItem).Clear();
				((List<T>)(object)appearanceItem).TrimExcess();
				List<ItemData> list2 = appearanceItem;
				int num8 = 0;
				AvatarWorkingCopy avatarWorkingCopy4 = default(AvatarWorkingCopy);
				int skinColorIndex_ = avatarWorkingCopy4.Data.skinColorIndex_;
				ulong num9 = default(ulong);
				ItemData item2 = new ItemData("SkinColor", skinColorIndex_, -1, (uint)num9);
				((List<T>)(object)list2).Add((T)item2);
				List<ItemData> list3 = appearanceItem;
				int num10 = 0;
				AvatarWorkingCopy avatarWorkingCopy5 = default(AvatarWorkingCopy);
				int eyeColor_ = avatarWorkingCopy5.Data.eyeColor_;
				ulong num11 = default(ulong);
				ItemData item3 = new ItemData("EyeColor", eyeColor_, -1, (uint)num11);
				((List<T>)(object)list3).Add((T)item3);
				List<ItemData> list4 = appearanceItem;
				int num12 = 0;
				AvatarWorkingCopy avatarWorkingCopy6 = default(AvatarWorkingCopy);
				int hairColorIndex_ = avatarWorkingCopy6.Data.hairColorIndex_;
				ulong num13 = default(ulong);
				ItemData item4 = new ItemData("HairColor", hairColorIndex_, -1, (uint)num13);
				((List<T>)(object)list4).Add((T)item4);
				List<ItemData> list5 = appearanceItem;
				int num14 = 0;
				AvatarWorkingCopy avatarWorkingCopy7 = default(AvatarWorkingCopy);
				int hairHighlightColor_ = avatarWorkingCopy7.Data.hairHighlightColor_;
				ulong num15 = default(ulong);
				ItemData item5 = new ItemData("HairHighlightColor", hairHighlightColor_, -1, (uint)num15);
				((List<T>)(object)list5).Add((T)item5);
				List<ItemData> list6 = appearanceItem;
				int num16 = 0;
				AvatarWorkingCopy avatarWorkingCopy8 = default(AvatarWorkingCopy);
				int bodyType_ = avatarWorkingCopy8.Data.bodyType_;
				ulong num17 = default(ulong);
				ItemData item6 = new ItemData("BodyType", bodyType_, -1, (uint)num17);
				((List<T>)(object)list6).Add((T)item6);
				List<ItemData> list7 = appearanceItem;
				int num18 = 0;
				ulong num19 = default(ulong);
				bool iD = default(bool);
				ItemData item7 = new ItemData("AvatarIsMale", iD ? 1 : 0, -1, (uint)num19);
				iD = bodyType_ != 0;
				((List<T>)(object)list7).Add((T)item7);
				return;
			}
			throw new InvalidCastException();
		}
	}
}
