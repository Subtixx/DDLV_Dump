using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002B9")]
	public sealed class SceneItemData : IMessage<SceneItemData>, IMessage, IEquatable<SceneItemData>, IDeepCloneable<SceneItemData>, IMessageFieldAccessor, IItemData, IHasGlotID
	{
		[Cpp2IlInjected.Token(Token = "0x4000BC7")]
		private static readonly MessageParser<SceneItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000BC8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000BC9")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000BCA")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000BCB")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000BCC")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BCD")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000BCE")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BCF")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000BD0")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BD1")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000BD2")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BD3")]
		public const int SceneTypeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000BD4")]
		private SceneType sceneType_;

		[Cpp2IlInjected.Token(Token = "0x4000BD5")]
		public const int SceneNameFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000BD6")]
		private string sceneName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BD7")]
		public const int CameraConfigFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000BD8")]
		private string cameraConfig_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BD9")]
		public const int EditCameraConfigFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000BDA")]
		private string editCameraConfig_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BDB")]
		public const int ComplexitySettingsFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000BDC")]
		private string complexitySettings_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BDD")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000BDE")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x17000660")]
		[DebuggerNonUserCode]
		public static MessageParser<SceneItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001C88")]
			[Cpp2IlInjected.Address(RVA = "0x2DB53E0", Offset = "0x2DB3DE0", VA = "0x182DB53E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000661")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001C89")]
			[Cpp2IlInjected.Address(RVA = "0x2DB52B0", Offset = "0x2DB3CB0", VA = "0x182DB52B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000662")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001C8A")]
			[Cpp2IlInjected.Address(RVA = "0x2DB5440", Offset = "0x2DB3E40", VA = "0x182DB5440", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000663")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001C8F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C90")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000664")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001C91")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C92")]
			[Cpp2IlInjected.Address(RVA = "0x2DB5780", Offset = "0x2DB4180", VA = "0x182DB5780")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000665")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001C93")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C94")]
			[Cpp2IlInjected.Address(RVA = "0x2DB5630", Offset = "0x2DB4030", VA = "0x182DB5630")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000666")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001C95")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C96")]
			[Cpp2IlInjected.Address(RVA = "0x2DB5710", Offset = "0x2DB4110", VA = "0x182DB5710")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000667")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001C97")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C98")]
			[Cpp2IlInjected.Address(RVA = "0x2DB57F0", Offset = "0x2DB41F0", VA = "0x182DB57F0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000668")]
		[DebuggerNonUserCode]
		public SceneType SceneType
		{
			[Cpp2IlInjected.Token(Token = "0x6001C99")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return sceneType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C9A")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				sceneType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000669")]
		[DebuggerNonUserCode]
		public string SceneName
		{
			[Cpp2IlInjected.Token(Token = "0x6001C9B")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return sceneName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C9C")]
			[Cpp2IlInjected.Address(RVA = "0x2DB5860", Offset = "0x2DB4260", VA = "0x182DB5860")]
			set
			{
				string text = (sceneName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066A")]
		[DebuggerNonUserCode]
		public string CameraConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6001C9D")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return cameraConfig_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C9E")]
			[Cpp2IlInjected.Address(RVA = "0x2DB5550", Offset = "0x2DB3F50", VA = "0x182DB5550")]
			set
			{
				string text = (cameraConfig_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066B")]
		[DebuggerNonUserCode]
		public string EditCameraConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6001C9F")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return editCameraConfig_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2DB56A0", Offset = "0x2DB40A0", VA = "0x182DB56A0")]
			set
			{
				string text = (editCameraConfig_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066C")]
		[DebuggerNonUserCode]
		public string ComplexitySettings
		{
			[Cpp2IlInjected.Token(Token = "0x6001CA1")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return complexitySettings_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CA2")]
			[Cpp2IlInjected.Address(RVA = "0x2DB55C0", Offset = "0x2DB3FC0", VA = "0x182DB55C0")]
			set
			{
				string text = (complexitySettings_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066D")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001CA3")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CA4")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066E")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB0")]
			[Cpp2IlInjected.Address(RVA = "0x2DB5380", Offset = "0x2DB3D80", VA = "0x182DB5380", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C8B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB51E0", Offset = "0x2DB3BE0", VA = "0x182DB51E0")]
		[DebuggerNonUserCode]
		public SceneItemData()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C8C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnConstruction()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001C8D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5010", Offset = "0x2DB3A10", VA = "0x182DB5010")]
		[DebuggerNonUserCode]
		public SceneItemData(SceneItemData other)
		{
			OnConstruction();
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			SceneType sceneType = (sceneType_ = other.sceneType_);
			string text5 = (sceneName_ = other.sceneName_);
			string text6 = (cameraConfig_ = other.cameraConfig_);
			string text7 = (editCameraConfig_ = other.editCameraConfig_);
			string text8 = (complexitySettings_ = other.complexitySettings_);
			uint num2 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C8E")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3ED0", Offset = "0x2DB28D0", VA = "0x182DB3ED0", Slot = "10")]
		[DebuggerNonUserCode]
		public SceneItemData Clone()
		{
			return new SceneItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3F30", Offset = "0x2DB2930", VA = "0x182DB3F30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(SceneItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4 && sceneType_ == (flag4 ? SceneType.Village : SceneType.Main))
								{
									string text5 = sceneName_;
									bool flag5 = default(bool);
									if (!flag5)
									{
										string text6 = cameraConfig_;
										bool flag6 = default(bool);
										if (!flag6)
										{
											string text7 = editCameraConfig_;
											bool flag7 = default(bool);
											if (!flag7)
											{
												string text8 = complexitySettings_;
												bool flag8 = default(bool);
												if (!flag8 && glotID_ == (flag8 ? 1u : 0u))
												{
													return object.Equals(_unknownFields, other);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2DB40A0", Offset = "0x2DB2AA0", VA = "0x182DB40A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SceneItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									SceneType sceneType = other.sceneType_;
									if (sceneType_ == sceneType)
									{
										string text5 = other.sceneName_;
										if (!(sceneName_ != text5))
										{
											string text6 = other.cameraConfig_;
											if (!(cameraConfig_ != text6))
											{
												string text7 = other.editCameraConfig_;
												if (!(editCameraConfig_ != text7))
												{
													string text8 = other.complexitySettings_;
													if (!(complexitySettings_ != text8))
													{
														uint num2 = other.glotID_;
														if (glotID_ == num2)
														{
															UnknownFieldSet unknownFields = other._unknownFields;
															return object.Equals(_unknownFields, unknownFields);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA7")]
		[Cpp2IlInjected.Address(RVA = "0x2DB43A0", Offset = "0x2DB2DA0", VA = "0x182DB43A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0107
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			if (sceneType_ != 0)
			{
			}
			string text5 = sceneName_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			string text6 = cameraConfig_;
			if (text6.m_stringLength != 0)
			{
				int hashCode6 = text6.GetHashCode();
			}
			string text7 = editCameraConfig_;
			if (text7.m_stringLength != 0)
			{
				int hashCode7 = text7.GetHashCode();
			}
			string text8 = complexitySettings_;
			if (text8.m_stringLength != 0)
			{
				int hashCode8 = text8.GetHashCode();
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4C30", Offset = "0x2DB3630", VA = "0x182DB4C30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4C90", Offset = "0x2DB3690", VA = "0x182DB4C90", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_013a
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (sceneType_ != 0)
			{
			}
			if (sceneName_.m_stringLength != 0)
			{
				string value6 = sceneName_;
				output.WriteString(value6);
			}
			if (cameraConfig_.m_stringLength != 0)
			{
				string value7 = cameraConfig_;
				output.WriteString(value7);
			}
			if (editCameraConfig_.m_stringLength != 0)
			{
				string value8 = editCameraConfig_;
				output.WriteString(value8);
			}
			if (complexitySettings_.m_stringLength != 0)
			{
				string value9 = complexitySettings_;
				output.WriteString(value9);
			}
			if (glotID_ != 0)
			{
				uint value10 = glotID_;
				output.WriteUInt32(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3A40", Offset = "0x2DB2440", VA = "0x182DB3A40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01a1
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			SceneType sceneType = sceneType_;
			if (sceneType != 0)
			{
				int num8 = CodedOutputStream.ComputeEnumSize((int)sceneType);
				num8++;
				num2 += num8;
			}
			string text5 = sceneName_;
			if (text5.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text5);
				num9++;
				num2 += num9;
			}
			string text6 = cameraConfig_;
			if (text6.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text6);
				num10++;
				num2 += num10;
			}
			string text7 = editCameraConfig_;
			if (text7.m_stringLength != 0)
			{
				int num11 = CodedOutputStream.ComputeStringSize(text7);
				num11++;
				num2 += num11;
			}
			string text8 = complexitySettings_;
			if (text8.m_stringLength != 0)
			{
				int num12 = CodedOutputStream.ComputeStringSize(text8);
				num12++;
				num2 += num12;
			}
			uint num13 = glotID_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeUInt32Size(num13);
				num14 += 2;
				num2 += num14;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				num2 += num15;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4560", Offset = "0x2DB2F60", VA = "0x182DB4560", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SceneItemData other)
		{
			//Discarded unreachable code: IL_012b
			if (other != null)
			{
				int num = other.iD_;
				if (num != 0)
				{
					iD_ = num;
				}
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				string text2 = other.displayName_;
				if (text2.m_stringLength != 0)
				{
					DisplayName = text2;
				}
				string text3 = other.iconAddress_;
				if (text3.m_stringLength != 0)
				{
					IconAddress = text3;
				}
				string text4 = other.prefabAddress_;
				if (text4.m_stringLength != 0)
				{
					PrefabAddress = text4;
				}
				SceneType sceneType = other.sceneType_;
				if (sceneType != 0)
				{
					sceneType_ = sceneType;
				}
				string text5 = other.sceneName_;
				if (text5.m_stringLength != 0)
				{
					SceneName = text5;
				}
				string text6 = other.cameraConfig_;
				if (text6.m_stringLength != 0)
				{
					CameraConfig = text6;
				}
				string text7 = other.editCameraConfig_;
				if (text7.m_stringLength != 0)
				{
					EditCameraConfig = text7;
				}
				string text8 = other.complexitySettings_;
				if (text8.m_stringLength != 0)
				{
					ComplexitySettings = text8;
				}
				uint num2 = other.glotID_;
				if (num2 != 0)
				{
					glotID_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAC")]
		[Cpp2IlInjected.Address(RVA = "0x2DB46B0", Offset = "0x2DB30B0", VA = "0x182DB46B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0138
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 66)
				{
					if (num == 74)
					{
						string text2 = (EditCameraConfig = input.ReadString());
					}
					string text4 = default(string);
					if (num == 82)
					{
						text4 = (ComplexitySettings = input.ReadString());
					}
					if ((long)text4 != 7992)
					{
						goto IL_0121;
					}
					int num2 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 48)
				{
					num3 = (int)(sceneType_ = (SceneType)input.ReadInt32());
				}
				string text6 = default(string);
				if (num3 == 58)
				{
					text6 = (SceneName = input.ReadString());
				}
				if ((long)text6 != 66)
				{
					goto IL_0121;
				}
				string text8 = (CameraConfig = input.ReadString());
			}
			string text14 = default(string);
			if ((int)num > 18)
			{
				string text10 = default(string);
				if (num == 26)
				{
					text10 = (DisplayName = input.ReadString());
				}
				string text12 = default(string);
				if ((long)text10 == 34)
				{
					text12 = (IconAddress = input.ReadString());
				}
				if ((long)text12 != 42)
				{
					goto IL_0121;
				}
				text14 = (PrefabAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text14 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text16 = (Name = input.ReadString());
			}
			goto IL_0121;
			IL_0121:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAD")]
		[Cpp2IlInjected.Address(RVA = "0x2DB41D0", Offset = "0x2DB2BD0", VA = "0x182DB41D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
				uint num2 = glotID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAE")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4890", Offset = "0x2DB3290", VA = "0x182DB4890", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0029, IL_0031, IL_0032, IL_0033, IL_0034, IL_0045, IL_004b, IL_0051, IL_0057, IL_005d, IL_0063, IL_0069, IL_006f, IL_0075, IL_007b
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0044: Expected I4, but got O
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CAF")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3D30", Offset = "0x2DB2730", VA = "0x182DB3D30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019
			//IL_0010: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			if (fieldNumber - 1 <= 9)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB1")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3ED0", Offset = "0x2DB28D0", VA = "0x182DB3ED0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			SceneItemData sceneItemData = new SceneItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4F00", Offset = "0x2DB3900", VA = "0x182DB4F00")]
		static SceneItemData()
		{
			Func<SceneItemData> func = default(Func<SceneItemData>);
			_parser = (MessageParser<SceneItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
