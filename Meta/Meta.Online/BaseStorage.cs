using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Newtonsoft.Json;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E86")]
	public abstract class BaseStorage<DataType> where DataType : new()
	{
		[Cpp2IlInjected.Token(Token = "0x4003AD3")]
		public static JsonSerializerSettings JsonSettings = new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		};

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003AD4")]
		protected Client client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003AD5")]
		public readonly IFileSystem FS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003AD6")]
		protected DataType data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003AD7")]
		private bool _requiresSaves;

		[Cpp2IlInjected.Token(Token = "0x1700151B")]
		public abstract string Path
		{
			[Cpp2IlInjected.Token(Token = "0x6007908")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700151C")]
		public virtual string DefaultDataPath
		{
			[Cpp2IlInjected.Token(Token = "0x6007909")]
			[Cpp2IlInjected.Address(RVA = "0x22A72E0", Offset = "0x22A5CE0", VA = "0x1822A72E0", Slot = "5")]
			get
			{
				return "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700151D")]
		public DataType Data
		{
			[Cpp2IlInjected.Token(Token = "0x600790D")]
			[Cpp2IlInjected.Address(RVA = "0x22A72B0", Offset = "0x22A5CB0", VA = "0x1822A72B0")]
			get
			{
				DataType val = ((BaseStorage<>)(object)this).data;
				if (val == null)
				{
					Load();
				}
				return val;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700151E")]
		public bool Exists
		{
			[Cpp2IlInjected.Token(Token = "0x600790E")]
			[Cpp2IlInjected.Address(RVA = "0x1CCA0E0", Offset = "0x1CC8AE0", VA = "0x181CCA0E0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600790A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		protected virtual void PostLoad()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600790B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		protected virtual void PostSave()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600790C")]
		[Cpp2IlInjected.Address(RVA = "0x22A7230", Offset = "0x22A5C30", VA = "0x1822A7230")]
		protected BaseStorage(IFileSystem fs, [Optional] Client client)
		{
			//Discarded unreachable code: IL_001c
			PostLoad();
			((BaseStorage<>)(object)this).FS = fs;
			((BaseStorage<>)(object)this).client = client;
			string path = Path;
		}

		[Cpp2IlInjected.Token(Token = "0x600790F")]
		[Cpp2IlInjected.Address(RVA = "0x22A6990", Offset = "0x22A5390", VA = "0x1822A6990")]
		protected void Load()
		{
			//Discarded unreachable code: IL_00aa
			//IL_004a: Expected O, but got I4
			IFileSystem fS = ((BaseStorage<>)(object)this).FS;
			string path = Path;
			if (path != null)
			{
				IFileSystem fS2 = ((BaseStorage<>)(object)this).FS;
				string path2 = Path;
				int num = 0;
				string text = (string)(((BaseStorage<>)(object)this).data = (DataType)fS2.ReadAllText(path2));
				int num2 = default(int);
				if (text != null && text != null)
				{
					num2 = 0;
					((BaseStorage<>)(object)this).data = (DataType)num2;
				}
				if (num2 == 0)
				{
				}
			}
			if (path == null && DefaultDataPath == null)
			{
				IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				string defaultDataPath = DefaultDataPath;
				if ((((BaseStorage<>)(object)this).data = (DataType)_003CData_003Ek__BackingField.ReadAllText(defaultDataPath)) == null)
				{
				}
			}
			if ((object)typeof(ILogger).TypeHandle == null)
			{
			}
			if ((object)typeof(ILogger).TypeHandle != null)
			{
				int num3 = 0;
				string text2 = default(string);
				if ((long)num3 < (long)(IntPtr)text2)
				{
					num3 += num3;
					num3++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007910")]
		[Cpp2IlInjected.Address(RVA = "0x22A6E70", Offset = "0x22A5870", VA = "0x1822A6E70")]
		public bool RequiresSave()
		{
			((BaseStorage<>)(object)this)._requiresSaves = true;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6007911")]
		[Cpp2IlInjected.Address(RVA = "0x22A6F60", Offset = "0x22A5960", VA = "0x1822A6F60")]
		public void Save(bool isForced)
		{
			if (isForced)
			{
				Log.Information(Path + " was saved to file system.");
				IFileSystem fS = ((BaseStorage<>)(object)this).FS;
				string path = Path;
				DataType val = ((BaseStorage<>)(object)this).data;
				string text = default(string);
				fS.WriteAllText(path, text);
				((BaseStorage<>)(object)this)._requiresSaves = false;
				PostSave();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007912")]
		[Cpp2IlInjected.Address(RVA = "0x22A6E80", Offset = "0x22A5880", VA = "0x1822A6E80")]
		public void ResetToDefault()
		{
			//Discarded unreachable code: IL_002e
			//IL_0027: Expected O, but got I4
			IFileSystem fS = ((BaseStorage<>)(object)this).FS;
			if (Path != null)
			{
				IFileSystem fS2 = ((BaseStorage<>)(object)this).FS;
				string path = Path;
				int num = 0;
				((BaseStorage<>)(object)this).data = (DataType)num;
				Load();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007913")]
		[Cpp2IlInjected.Address(RVA = "0x22A7180", Offset = "0x22A5B80", VA = "0x1822A7180")]
		static BaseStorage()
		{
			throw new NullReferenceException();
		}
	}
}
