using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Federation.Client;
using Gameloft.GdidService.Model;

namespace Gameloft.GdidService
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class AssignGlobalIdRequest : GdidApiRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string Source
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CSource_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CSource_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000011")]
		public DeviceTypes? DeviceType
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string DeviceVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CDeviceVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CDeviceVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string Idfa
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CIdfa_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CIdfa_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string Idfv
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CIdfv_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CIdfv_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string Hdidfv
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CHdidfv_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CHdidfv_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CClientId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CClientId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string GlobalDeviceId
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CGlobalDeviceId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CGlobalDeviceId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Gaid
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CGaid_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			set
			{
				_003CGaid_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AssignGlobalIdRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4131770", Offset = "0x4130170", VA = "0x184131770")]
		public RequestOptions ToRequestOptions(IReadableConfiguration readableConfiguration)
		{
			//IL_02ae: Expected O, but got I4
			while (ClientUtils.IsValid(Source))
			{
				RequestOptions requestOptions = new RequestOptions();
				string[] array = new string[0];
				string[] array2 = new string[1];
				if ("text/_*" == null || array2 != null)
				{
					array2[0] = "text/_*";
					int num = 0;
					int length = array.Length;
					if (num < length)
					{
						Multimap<string, string> _003CHeaderParameters_003Ek__BackingField = requestOptions.HeaderParameters;
						string value = array[num];
						((Multimap<TKey, TValue>)(object)_003CHeaderParameters_003Ek__BackingField).Add((TKey)"Content-Type", (TValue)value);
						num++;
					}
					int length2 = array2.Length;
					if (num < length2)
					{
						Multimap<string, string> _003CHeaderParameters_003Ek__BackingField2 = requestOptions.HeaderParameters;
						string value2 = array2[num];
						((Multimap<TKey, TValue>)(object)_003CHeaderParameters_003Ek__BackingField2).Add((TKey)"Accept", (TValue)value2);
						num++;
					}
					Multimap<string, string> _003CQueryParameters_003Ek__BackingField = requestOptions.QueryParameters;
					string text = Source;
					Multimap<string, string> multimap = (Multimap<string, string>)(object)ClientUtils.ParameterToMultiMap("", "source", (object)text);
					((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField).Add((Multimap<, >)(object)multimap);
					if (ClientUtils.IsValid(DeviceType))
					{
						DeviceTypes? deviceTypes = DeviceType;
						Multimap<string, string> _003CQueryParameters_003Ek__BackingField2 = requestOptions.QueryParameters;
						Multimap<string, string> multimap2 = (Multimap<string, string>)(object)ClientUtils.ParameterToMultiMap("", "device_type", (object)deviceTypes);
						((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField2).Add((Multimap<, >)(object)multimap2);
					}
					if (ClientUtils.IsValid(DeviceVersion))
					{
						Multimap<string, string> _003CQueryParameters_003Ek__BackingField3 = requestOptions.QueryParameters;
						string text2 = DeviceVersion;
						Multimap<string, string> multimap3 = (Multimap<string, string>)(object)ClientUtils.ParameterToMultiMap("", "device_version", (object)text2);
						((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField3).Add((Multimap<, >)(object)multimap3);
					}
					if (ClientUtils.IsValid(Idfa))
					{
						Multimap<string, string> _003CQueryParameters_003Ek__BackingField4 = requestOptions.QueryParameters;
						string text3 = Idfa;
						Multimap<string, string> multimap4 = (Multimap<string, string>)(object)ClientUtils.ParameterToMultiMap("", "idfa", (object)text3);
						((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField4).Add((Multimap<, >)(object)multimap4);
					}
					if (ClientUtils.IsValid(Idfv))
					{
						Multimap<string, string> _003CQueryParameters_003Ek__BackingField5 = requestOptions.QueryParameters;
						string text4 = Idfv;
						Multimap<string, string> multimap5 = (Multimap<string, string>)(object)ClientUtils.ParameterToMultiMap("", "idfv", (object)text4);
						((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField5).Add((Multimap<, >)(object)multimap5);
					}
					if (ClientUtils.IsValid(Hdidfv))
					{
						Multimap<string, string> _003CQueryParameters_003Ek__BackingField6 = requestOptions.QueryParameters;
						string text5 = Hdidfv;
						Multimap<string, string> multimap6 = (Multimap<string, string>)(object)ClientUtils.ParameterToMultiMap("", "hdidfv", (object)text5);
						((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField6).Add((Multimap<, >)(object)multimap6);
					}
					if (ClientUtils.IsValid(ClientId))
					{
						Multimap<string, string> _003CQueryParameters_003Ek__BackingField7 = requestOptions.QueryParameters;
						string text6 = ClientId;
						Multimap<string, string> multimap7 = (Multimap<string, string>)(object)ClientUtils.ParameterToMultiMap("", "client_id", (object)text6);
						((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField7).Add((Multimap<, >)(object)multimap7);
					}
					if (ClientUtils.IsValid(GlobalDeviceId))
					{
						Multimap<string, string> _003CQueryParameters_003Ek__BackingField8 = requestOptions.QueryParameters;
						string text7 = GlobalDeviceId;
						Multimap<string, string> multimap8 = (Multimap<string, string>)(object)ClientUtils.ParameterToMultiMap("", "global_device_id", (object)text7);
						((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField8).Add((Multimap<, >)(object)multimap8);
					}
					if (ClientUtils.IsValid(Gaid))
					{
						Multimap<string, string> _003CQueryParameters_003Ek__BackingField9 = requestOptions.QueryParameters;
						string text8 = Gaid;
						Multimap<string, string> multimap9 = (Multimap<string, string>)(object)ClientUtils.ParameterToMultiMap("", "gaid", (object)text8);
						((Multimap<TKey, TValue>)(object)_003CQueryParameters_003Ek__BackingField9).Add((Multimap<, >)(object)multimap9);
					}
					return requestOptions;
				}
			}
			int num2 = default(int);
			ApiException ex = new ApiException(400, "Missing required parameter 'Source' for AssignGlobalIdRequest", num2);
			int num3 = 0;
			num2 = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
