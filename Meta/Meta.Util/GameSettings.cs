using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Util;
using Meta.Online;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ABA")]
	public class GameSettings : BaseStorage<GameSettingsData>
	{
		[Cpp2IlInjected.Token(Token = "0x1700103C")]
		public override string Path
		{
			[Cpp2IlInjected.Token(Token = "0x6005D12")]
			[Cpp2IlInjected.Address(RVA = "0x1811EE0", Offset = "0x18108E0", VA = "0x181811EE0", Slot = "4")]
			get
			{
				return "game_settings.json";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700103D")]
		public override string DefaultDataPath
		{
			[Cpp2IlInjected.Token(Token = "0x6005D13")]
			[Cpp2IlInjected.Address(RVA = "0x1811EB0", Offset = "0x18108B0", VA = "0x181811EB0", Slot = "5")]
			get
			{
				return "Server/default_game_settings.json";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400008C")]
		public event EventHandler OnLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6005D14")]
			[Cpp2IlInjected.Address(RVA = "0x1811E10", Offset = "0x1810810", VA = "0x181811E10")]
			[CompilerGenerated]
			add
			{
				EventHandler onLoaded = this.OnLoaded;
				Delegate @delegate = Delegate.Combine(onLoaded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLoaded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005D15")]
			[Cpp2IlInjected.Address(RVA = "0x1811F10", Offset = "0x1810910", VA = "0x181811F10")]
			[CompilerGenerated]
			remove
			{
				EventHandler onLoaded = this.OnLoaded;
				Delegate @delegate = Delegate.Remove(onLoaded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLoaded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D16")]
		[Cpp2IlInjected.Address(RVA = "0x1811C00", Offset = "0x1810600", VA = "0x181811C00")]
		public Dictionary<string, string> GetLanguageChoices()
		{
			//Discarded unreachable code: IL_0022
			GameSettingsData gameSettingsData = (GameSettingsData)((BaseStorage<DataType>)(object)this).Data;
			Dictionary<string, string> dictionary = default(Dictionary<string, string>);
			if (gameSettingsData == null || gameSettingsData.GetLanguageChoices() == null)
			{
				dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			return dictionary;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D17")]
		[Cpp2IlInjected.Address(RVA = "0x1811D70", Offset = "0x1810770", VA = "0x181811D70")]
		public GameSettings()
		{
			//IL_0010: Expected O, but got I4
			((BaseStorage<DataType>)(object)this)._002Ector(FileSystem.Save, (Client)0);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D18")]
		[Cpp2IlInjected.Address(RVA = "0x1811CD0", Offset = "0x18106D0", VA = "0x181811CD0", Slot = "6")]
		protected override void PostLoad()
		{
			((BaseStorage<DataType>)(object)this).PostLoad();
			if (this.OnLoaded == null)
			{
			}
		}
	}
}
