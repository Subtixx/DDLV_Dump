using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Meta.Customization;
using Meta.Util;
using Rewired;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FB0")]
	public static class ProfileTransferUtil
	{
		[Cpp2IlInjected.Token(Token = "0x40040AD")]
		public static HttpClient httpClient;

		[Cpp2IlInjected.Token(Token = "0x6007F2F")]
		[Cpp2IlInjected.Address(RVA = "0x1473A50", Offset = "0x1472450", VA = "0x181473A50")]
		public static string GetAvatarCode(string url)
		{
			//Discarded unreachable code: IL_004b
			if (!string.IsNullOrEmpty(url))
			{
				char[] array = new char[1];
				array[0] = '/';
				string text = ((IEnumerable<>)(object)url.Split(array)).Last<string>();
				char[] array2 = new char[1];
				array2[0] = '.';
				return Enumerable.First<string>((IEnumerable<>)(object)text.Split(array2));
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6007F30")]
		[Cpp2IlInjected.Address(RVA = "0x1473FA0", Offset = "0x14729A0", VA = "0x181473FA0")]
		[AsyncStateMachine(typeof(_003CUpload_003Ed__2))]
		public static Task<string> Upload(Profile profile, bool encrypt)
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F31")]
		[Cpp2IlInjected.Address(RVA = "0x1473B80", Offset = "0x1472580", VA = "0x181473B80")]
		private static string GetAvatarData(Profile profile)
		{
			if (profile != null)
			{
				ProfilePlayer player_ = profile.player_;
				if (player_ != null)
				{
					AvatarTransferData avatarTransferData = new AvatarTransferData();
					Avatar avatar = (avatarTransferData.femaleAvatar_ = player_.femaleAvatar_);
					Avatar avatar2 = (avatarTransferData.maleAvatar_ = player_.maleAvatar_);
					bool avatarIsMale_ = player_.avatarIsMale_;
					MapField<int, DesignMap> femaleClothingDesigns_ = avatarTransferData.femaleClothingDesigns_;
					avatarTransferData.avatarIsMale_ = avatarIsMale_;
					int num = (avatarTransferData.nextClothingDesignID_ = player_.nextClothingDesignID_);
					MapField<int, DesignMap> femaleClothingDesigns_2 = player_.femaleClothingDesigns_;
					((MapField<TKey, TValue>)(object)femaleClothingDesigns_).Add((IDictionary<, >)(object)femaleClothingDesigns_2);
					MapField<int, DesignMap> maleClothingDesigns_ = avatarTransferData.maleClothingDesigns_;
					MapField<int, DesignMap> maleClothingDesigns_2 = player_.maleClothingDesigns_;
					((MapField<TKey, TValue>)(object)maleClothingDesigns_).Add((IDictionary<, >)(object)maleClothingDesigns_2);
					IControllerTemplateButton stickBaseButton = ((IHOTASTemplate)(object)avatarTransferData).stickBaseButton12;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F32")]
		[Cpp2IlInjected.Address(RVA = "0x1473E50", Offset = "0x1472850", VA = "0x181473E50")]
		[AsyncStateMachine(typeof(_003CUploadData_003Ed__4))]
		private static Task<bool> UploadData(string url, string avatarData, bool encrypt)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F33")]
		[Cpp2IlInjected.Address(RVA = "0x1473930", Offset = "0x1472330", VA = "0x181473930")]
		[AsyncStateMachine(typeof(_003CDownload_003Ed__5))]
		public static Task<byte[]> Download(string avatarCode)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<byte[]>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F34")]
		[Cpp2IlInjected.Address(RVA = "0x1473C90", Offset = "0x1472690", VA = "0x181473C90")]
		public static AvatarTransferData GetAvatarTransferData(ByteString avatarData)
		{
			//Discarded unreachable code: IL_0046, IL_004c, IL_0052, IL_0058
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(avatarData == (ByteString)num) && avatarData.Length != 0)
			{
				byte[] bytes = avatarData.ToByteArray();
				int num2 = 0;
				string @string = Encoding.ASCII.GetString(bytes);
				int num3 = 0;
				string text = ProfileUtil.GetSecurity().DecryptToString(bytes);
				AvatarTransferData result = default(AvatarTransferData);
				return result;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007F35")]
		[Cpp2IlInjected.Address(RVA = "0x14740F0", Offset = "0x1472AF0", VA = "0x1814740F0")]
		static ProfileTransferUtil()
		{
			HttpClient httpClient = new HttpClient();
			/*Error: Unexpected end of block*/;
		}
	}
}
