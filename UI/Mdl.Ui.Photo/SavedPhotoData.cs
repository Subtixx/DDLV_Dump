using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Mdl.Ui.Photo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000940")]
	public class SavedPhotoData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003677")]
		public int file_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003678")]
		public int gallery_max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003679")]
		public bool is_max_count_reached;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400367A")]
		public List<SavedPhoto> savedPhoto;

		[Cpp2IlInjected.Token(Token = "0x60039FA")]
		[Cpp2IlInjected.Address(RVA = "0x1255E40", Offset = "0x1254840", VA = "0x181255E40")]
		public SavedPhotoData()
		{
			is_max_count_reached = (byte)(file_version = 0) != 0;
			List<SavedPhoto> list = (savedPhoto = (List<SavedPhoto>)(object)new List<T>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039FB")]
		[Cpp2IlInjected.Address(RVA = "0x1255CF0", Offset = "0x12546F0", VA = "0x181255CF0")]
		public void UpdateDownloadURL(string path, string downloadURL, string time)
		{
			//Discarded unreachable code: IL_0012, IL_0018
			bool flag = default(bool);
			if (savedPhoto != null && flag)
			{
				while (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039FC")]
		[Cpp2IlInjected.Address(RVA = "0x1255BB0", Offset = "0x12545B0", VA = "0x181255BB0")]
		[AsyncStateMachine(typeof(_003CIsLinkAvailable_003Ed__6))]
		public Task<bool> IsLinkAvailable(string picturePath)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039FD")]
		[Cpp2IlInjected.Address(RVA = "0x1255A70", Offset = "0x1254470", VA = "0x181255A70")]
		public string GetDownloadUrl(string picturePath)
		{
			//Discarded unreachable code: IL_0017, IL_001d
			bool flag = default(bool);
			if (savedPhoto != null && flag)
			{
				while (!flag)
				{
				}
			}
			return "";
		}
	}
}
