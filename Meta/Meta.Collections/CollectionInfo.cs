using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x200110E")]
	public class CollectionInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004645")]
		private CollectionSetItemData collectionSetItemData;

		[Cpp2IlInjected.Token(Token = "0x1700185E")]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6008AFC")]
			[Cpp2IlInjected.Address(RVA = "0x1677E70", Offset = "0x1676870", VA = "0x181677E70")]
			get
			{
				//Discarded unreachable code: IL_000c
				return collectionSetItemData.iconAddress_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700185F")]
		public string CollectionName
		{
			[Cpp2IlInjected.Token(Token = "0x6008AFD")]
			[Cpp2IlInjected.Address(RVA = "0x1677DD0", Offset = "0x16767D0", VA = "0x181677DD0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return collectionSetItemData.collectionName_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001860")]
		public CollectionSubMenu Submenu
		{
			[Cpp2IlInjected.Token(Token = "0x6008AFE")]
			[Cpp2IlInjected.Address(RVA = "0x1677E90", Offset = "0x1676890", VA = "0x181677E90")]
			get
			{
				//Discarded unreachable code: IL_000c
				return collectionSetItemData.submenu_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001861")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4004646")]
		public List<GroupInfo> Groups
		{
			[Cpp2IlInjected.Token(Token = "0x6008AFF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001862")]
		public int CollectionSetID
		{
			[Cpp2IlInjected.Token(Token = "0x6008B00")]
			[Cpp2IlInjected.Address(RVA = "0x1677DF0", Offset = "0x16767F0", VA = "0x181677DF0")]
			get
			{
				CollectionSetItemData collectionSetItemData = this.collectionSetItemData;
				if (collectionSetItemData != null)
				{
					return collectionSetItemData.ID;
				}
				Item invalid = Item.Invalid;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AFA")]
		[Cpp2IlInjected.Address(RVA = "0x1677AD0", Offset = "0x16764D0", VA = "0x181677AD0")]
		public CollectionInfo(CollectionSet collectionSet)
		{
			//Discarded unreachable code: IL_00bd
			RepeatedField<CollectionSetGroup> groupData_ = collectionSet.groupData_;
			int collectionDefinitionID_ = collectionSet.collectionDefinitionID_;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			CollectionSetItemData collectionSetItemData = default(CollectionSetItemData);
			this.collectionSetItemData = collectionSetItemData;
			List<GroupInfo> list = (Groups = (List<GroupInfo>)(object)new List<T>());
			int num = 0;
			int num2 = 0;
			int count = ((RepeatedField<T>)(object)groupData_).Count;
			if (num2 < count)
			{
				if (((RepeatedField<T>)(object)this.collectionSetItemData.groups_).Count > num)
				{
					CollectionSetGroup groupData = (CollectionSetGroup)((RepeatedField<T>)(object)groupData_)[num];
					CollectionGroup group = (CollectionGroup)((RepeatedField<T>)(object)this.collectionSetItemData.groups_)[num];
					CollectionSetItemData collectionSetItemData2 = this.collectionSetItemData;
					CollectionSubMenu submenu_ = collectionSetItemData2.submenu_;
					string collectionName_ = collectionSetItemData2.collectionName_;
					string groupName = GetGroupName(group, collectionName_, submenu_);
					GroupInfo item = new GroupInfo(groupData, groupName);
					((List<T>)(object)Groups).Add((T)item);
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008AFB")]
		[Cpp2IlInjected.Address(RVA = "0x1677850", Offset = "0x1676250", VA = "0x181677850")]
		private string GetGroupName(CollectionGroup group, string defaultName, CollectionSubMenu submenu)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
