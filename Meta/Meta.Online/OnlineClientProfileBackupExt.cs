using System;
using CloudScripts;
using Cpp2IlInjected;
using Definitions;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F9F")]
	public static class OnlineClientProfileBackupExt
	{
		[Cpp2IlInjected.Token(Token = "0x6007EE0")]
		[Cpp2IlInjected.Address(RVA = "0x13A26C0", Offset = "0x13A10C0", VA = "0x1813A26C0")]
		public static DoProfileBackup.DisplayProperties InitWith(this DoProfileBackup.DisplayProperties self, MiniProfile miniProfile)
		{
			//Discarded unreachable code: IL_0074
			string text = (self.PlayerName = miniProfile.playerName_);
			DateTime dateTime = (self.ModifiedTime = miniProfile.gameInfo_.modified_.ToDateTime());
			int num = (self.TimePlayedInMinutes = miniProfile.timePlayedInMinutes_);
			int num2 = (self.PlayerLevel = miniProfile.playerLevel_);
			int num3 = (self.PlayerXp = miniProfile.playerXp_);
			int num4 = (self.SoftCurrency = miniProfile.softCurrency_);
			int num5 = (self.HardCurrency = miniProfile.hardCurrency_);
			return self;
		}

		[Cpp2IlInjected.Token(Token = "0x6007EE1")]
		[Cpp2IlInjected.Address(RVA = "0x13A2740", Offset = "0x13A1140", VA = "0x1813A2740")]
		public static MiniProfile ToMiniProfile(this DoProfileBackup.DisplayProperties self)
		{
			//Discarded unreachable code: IL_0062
			MiniProfile miniProfile = new MiniProfile();
			string text = (miniProfile.PlayerName = self.PlayerName);
			int num = (miniProfile.timePlayedInMinutes_ = self.TimePlayedInMinutes);
			int num2 = (miniProfile.playerLevel_ = self.PlayerLevel);
			int num3 = (miniProfile.playerXp_ = self.PlayerXp);
			int num4 = (miniProfile.softCurrency_ = self.SoftCurrency);
			int num5 = (miniProfile.hardCurrency_ = self.HardCurrency);
			return miniProfile;
		}

		[Cpp2IlInjected.Token(Token = "0x6007EE2")]
		[Cpp2IlInjected.Address(RVA = "0x13A2660", Offset = "0x13A1060", VA = "0x1813A2660")]
		public static DoProfileBackup.DisplayProperties InitWith(this DoProfileBackup.DisplayProperties self, DeviceInfo deviceInfo)
		{
			//Discarded unreachable code: IL_002c
			string text = (self.DeviceID = deviceInfo.deviceID_);
			string text2 = (self.DeviceModel = deviceInfo.deviceModel_);
			string text3 = (self.DeviceName = deviceInfo.deviceName_);
			return self;
		}

		[Cpp2IlInjected.Token(Token = "0x6007EE3")]
		[Cpp2IlInjected.Address(RVA = "0x13A2620", Offset = "0x13A1020", VA = "0x1813A2620")]
		public static DoProfileBackup.Request InitWith(this DoProfileBackup.Request self, LocalProfileHolder profileHolder)
		{
			//Discarded unreachable code: IL_0010
			byte[] array = (self.FileData = profileHolder.LoadProfileToCompressedBuffer());
			return self;
		}

		[Cpp2IlInjected.Token(Token = "0x6007EE4")]
		[Cpp2IlInjected.Address(RVA = "0x13A2510", Offset = "0x13A0F10", VA = "0x1813A2510")]
		public static DoProfileBackup.Request InitWithDisplayProps(this DoProfileBackup.Request self, MiniProfile miniProfile)
		{
			//Discarded unreachable code: IL_007d
			DoProfileBackup.DisplayProperties _003CDisplayProps_003Ek__BackingField = self.DisplayProps;
			string text = (_003CDisplayProps_003Ek__BackingField.PlayerName = miniProfile.playerName_);
			DateTime dateTime = (_003CDisplayProps_003Ek__BackingField.ModifiedTime = miniProfile.gameInfo_.modified_.ToDateTime());
			int num = (_003CDisplayProps_003Ek__BackingField.TimePlayedInMinutes = miniProfile.timePlayedInMinutes_);
			int num2 = (_003CDisplayProps_003Ek__BackingField.PlayerLevel = miniProfile.playerLevel_);
			int num3 = (_003CDisplayProps_003Ek__BackingField.PlayerXp = miniProfile.playerXp_);
			int num4 = (_003CDisplayProps_003Ek__BackingField.SoftCurrency = miniProfile.softCurrency_);
			int num5 = (_003CDisplayProps_003Ek__BackingField.HardCurrency = miniProfile.hardCurrency_);
			return self;
		}

		[Cpp2IlInjected.Token(Token = "0x6007EE5")]
		[Cpp2IlInjected.Address(RVA = "0x13A25A0", Offset = "0x13A0FA0", VA = "0x1813A25A0")]
		public static DoProfileBackup.Request InitWithDisplayProps(this DoProfileBackup.Request self, DeviceInfo deviceInfos)
		{
			//Discarded unreachable code: IL_0033
			DoProfileBackup.DisplayProperties _003CDisplayProps_003Ek__BackingField = self.DisplayProps;
			string text = (_003CDisplayProps_003Ek__BackingField.DeviceID = deviceInfos.deviceID_);
			string text2 = (_003CDisplayProps_003Ek__BackingField.DeviceModel = deviceInfos.deviceModel_);
			string text3 = (_003CDisplayProps_003Ek__BackingField.DeviceName = deviceInfos.deviceName_);
			return self;
		}
	}
}
