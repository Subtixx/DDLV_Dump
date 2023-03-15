using System;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200098E")]
	public abstract class NetworkDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x17000E86")]
		public abstract Profile WorldProfile
		{
			[Cpp2IlInjected.Token(Token = "0x60053EB")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60053EC")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E87")]
		public abstract int LocalPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60053ED")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60053EE")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E88")]
		public abstract Profile[] PlayerProfiles
		{
			[Cpp2IlInjected.Token(Token = "0x60053EF")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60053F0")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000E89")]
		public abstract bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x60053F1")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60053F2")]
		[Cpp2IlInjected.Address(RVA = "0x13957A0", Offset = "0x13941A0", VA = "0x1813957A0")]
		public bool IsLocalPlayerIdValid()
		{
			int localPlayerId = LocalPlayerId;
			return 0 < 4;
		}

		[Cpp2IlInjected.Token(Token = "0x60053F3")]
		[Cpp2IlInjected.Address(RVA = "0x72EEF0", Offset = "0x72D8F0", VA = "0x18072EEF0")]
		public bool IsPlayerIdValid(int playerId)
		{
			int num = 0;
			return playerId < 4;
		}

		[Cpp2IlInjected.Token(Token = "0x60053F4")]
		[Cpp2IlInjected.Address(RVA = "0x1395670", Offset = "0x1394070", VA = "0x181395670")]
		internal Player GetPlayer(int playerId, ProfileEventDispatcher dispatcher, Profile defaultProfile)
		{
			if ((long)dispatcher < 4)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60053F5")]
		[Cpp2IlInjected.Address(RVA = "0x1395640", Offset = "0x1394040", VA = "0x181395640")]
		internal Player GetPlayer(Profile playerProfile, ProfileEventDispatcher dispatcher)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60053F6")]
		[Cpp2IlInjected.Address(RVA = "0x1395720", Offset = "0x1394120", VA = "0x181395720")]
		public World GetWorld(ProfileEventDispatcher dispatcher, Profile defaultProfile)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60053F7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected NetworkDataProvider()
		{
		}
	}
}
