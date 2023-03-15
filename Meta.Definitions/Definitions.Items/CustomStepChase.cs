using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004F4")]
	public sealed class CustomStepChase : IMessage<CustomStepChase>, IMessage, IEquatable<CustomStepChase>, IDeepCloneable<CustomStepChase>, IMessageFieldAccessor, IMessageOneofAccessor, IStringTag, IItemSelectorsWithAmount, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20004F5")]
		public enum ChaseTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001A8E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001A8F")]
			TargetPrefab = 5
		}

		[Cpp2IlInjected.Token(Token = "0x20004F6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004F7")]
			public sealed class LocationCustomContainer : IMessage<LocationCustomContainer>, IMessage, IEquatable<LocationCustomContainer>, IDeepCloneable<LocationCustomContainer>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001A90")]
				private static readonly MessageParser<LocationCustomContainer> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001A91")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001A92")]
				public const int LocationFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001A93")]
				private LocationCustom location_;

				[Cpp2IlInjected.Token(Token = "0x17000FB7")]
				[DebuggerNonUserCode]
				public static MessageParser<LocationCustomContainer> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003D4C")]
					[Cpp2IlInjected.Address(RVA = "0x2947000", Offset = "0x2945A00", VA = "0x182947000")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000FB8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003D4D")]
					[Cpp2IlInjected.Address(RVA = "0x2946F80", Offset = "0x2945980", VA = "0x182946F80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000FB9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003D4E")]
					[Cpp2IlInjected.Address(RVA = "0x2947060", Offset = "0x2945A60", VA = "0x182947060", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000FBA")]
				[DebuggerNonUserCode]
				public LocationCustom Location
				{
					[Cpp2IlInjected.Token(Token = "0x6003D53")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003D54")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003D4F")]
				[Cpp2IlInjected.Address(RVA = "0x2946F10", Offset = "0x2945910", VA = "0x182946F10")]
				[DebuggerNonUserCode]
				public LocationCustomContainer()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003D50")]
				[Cpp2IlInjected.Address(RVA = "0x2946BF0", Offset = "0x29455F0", VA = "0x182946BF0")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003D51")]
				[Cpp2IlInjected.Address(RVA = "0x2946E40", Offset = "0x2945840", VA = "0x182946E40")]
				[DebuggerNonUserCode]
				public LocationCustomContainer(LocationCustomContainer other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003D52")]
				[Cpp2IlInjected.Address(RVA = "0x2946810", Offset = "0x2945210", VA = "0x182946810", Slot = "10")]
				[DebuggerNonUserCode]
				public LocationCustomContainer Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003D55")]
				[Cpp2IlInjected.Address(RVA = "0x2946910", Offset = "0x2945310", VA = "0x182946910", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003D56")]
				[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(LocationCustomContainer other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003D57")]
				[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003D58")]
				[Cpp2IlInjected.Address(RVA = "0x2946CD0", Offset = "0x29456D0", VA = "0x182946CD0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003D59")]
				[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003D5A")]
				[Cpp2IlInjected.Address(RVA = "0x2946770", Offset = "0x2945170", VA = "0x182946770", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003D5B")]
				[Cpp2IlInjected.Address(RVA = "0x2946A40", Offset = "0x2945440", VA = "0x182946A40", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(LocationCustomContainer other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003D5C")]
				[Cpp2IlInjected.Address(RVA = "0x2946B10", Offset = "0x2945510", VA = "0x182946B10", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003D5D")]
				[Cpp2IlInjected.Address(RVA = "0x29469C0", Offset = "0x29453C0", VA = "0x1829469C0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003D5E")]
				[Cpp2IlInjected.Address(RVA = "0x2946C50", Offset = "0x2945650", VA = "0x182946C50", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003D5F")]
				[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001A7E")]
		private static readonly MessageParser<CustomStepChase> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A7F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001A80")]
		public const int TargetSceneFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A81")]
		private int targetScene_;

		[Cpp2IlInjected.Token(Token = "0x4001A82")]
		public const int TargetPrefabFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001A83")]
		public const int PatrolPathFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4001A84")]
		private static readonly FieldCodec<Types.LocationCustomContainer> _repeated_patrolPath_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001A85")]
		private readonly RepeatedField<Types.LocationCustomContainer> patrolPath_ = (RepeatedField<Types.LocationCustomContainer>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001A86")]
		public const int PatrolLoopingIndexFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001A87")]
		private int patrolLoopingIndex_;

		[Cpp2IlInjected.Token(Token = "0x4001A88")]
		public const int ItemsToGiveFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4001A89")]
		private static readonly FieldCodec<AnyItemSelectorWithAmount> _repeated_itemsToGive_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001A8A")]
		private readonly RepeatedField<AnyItemSelectorWithAmount> itemsToGive_ = (RepeatedField<AnyItemSelectorWithAmount>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001A8B")]
		private object chaseType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001A8C")]
		private ChaseTypeOneofCase chaseTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17000FAC")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepChase> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003D2A")]
			[Cpp2IlInjected.Address(RVA = "0x2D4FB60", Offset = "0x2D4E560", VA = "0x182D4FB60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003D2B")]
			[Cpp2IlInjected.Address(RVA = "0x2D4FA90", Offset = "0x2D4E490", VA = "0x182D4FA90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003D2C")]
			[Cpp2IlInjected.Address(RVA = "0x2D4FC70", Offset = "0x2D4E670", VA = "0x182D4FC70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FAF")]
		[DebuggerNonUserCode]
		public int TargetScene
		{
			[Cpp2IlInjected.Token(Token = "0x6003D31")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return targetScene_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D32")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				targetScene_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB0")]
		[DebuggerNonUserCode]
		public string TargetPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6003D33")]
			[Cpp2IlInjected.Address(RVA = "0x2D4FC00", Offset = "0x2D4E600", VA = "0x182D4FC00")]
			get
			{
				if (chaseTypeCase_ == ChaseTypeOneofCase.TargetPrefab)
				{
					object obj = chaseType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				return "";
			}
			[Cpp2IlInjected.Token(Token = "0x6003D34")]
			[Cpp2IlInjected.Address(RVA = "0x2D4FD80", Offset = "0x2D4E780", VA = "0x182D4FD80")]
			set
			{
				//IL_001c: Expected I4, but got I8
				string text = (string)(chaseType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				chaseTypeCase_ = ChaseTypeOneofCase.TargetPrefab;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB1")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.LocationCustomContainer> PatrolPath
		{
			[Cpp2IlInjected.Token(Token = "0x6003D35")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return patrolPath_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB2")]
		[DebuggerNonUserCode]
		public int PatrolLoopingIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6003D36")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return patrolLoopingIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D37")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				patrolLoopingIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB3")]
		[DebuggerNonUserCode]
		public RepeatedField<AnyItemSelectorWithAmount> ItemsToGive
		{
			[Cpp2IlInjected.Token(Token = "0x6003D38")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return itemsToGive_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB4")]
		[DebuggerNonUserCode]
		public ChaseTypeOneofCase ChaseTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003D39")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return chaseTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB5")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003D48")]
			[Cpp2IlInjected.Address(RVA = "0x2D4FBC0", Offset = "0x2D4E5C0", VA = "0x182D4FBC0", Slot = "16")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FB6")]
		IEnumerable<AnyItemSelectorWithAmount> IItemSelectorsWithAmount.ItemSelectorsWithAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003D49")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "17")]
			get
			{
				RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D2D")]
		[Cpp2IlInjected.Address(RVA = "0x2D4F730", Offset = "0x2D4E130", VA = "0x182D4F730")]
		[DebuggerNonUserCode]
		public CustomStepChase()
		{
			//IL_0040: Expected I4, but got I8
			string text = (string)(chaseType_ = ProtoPreconditions.CheckNotNull("", "value"));
			chaseTypeCase_ = ChaseTypeOneofCase.TargetPrefab;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D2E")]
		[Cpp2IlInjected.Address(RVA = "0x2D4F040", Offset = "0x2D4DA40", VA = "0x182D4F040")]
		private void OnConstruction()
		{
			//IL_0020: Expected I4, but got I8
			string text = (string)(chaseType_ = ProtoPreconditions.CheckNotNull("", "value"));
			chaseTypeCase_ = ChaseTypeOneofCase.TargetPrefab;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D2F")]
		[Cpp2IlInjected.Address(RVA = "0x2D4F870", Offset = "0x2D4E270", VA = "0x182D4F870")]
		[DebuggerNonUserCode]
		public CustomStepChase(CustomStepChase other)
		{
			//IL_0040: Expected I4, but got I8
			string text = (string)(chaseType_ = ProtoPreconditions.CheckNotNull("", "value"));
			chaseTypeCase_ = ChaseTypeOneofCase.TargetPrefab;
			int num = (targetScene_ = other.targetScene_);
			RepeatedField<Types.LocationCustomContainer> repeatedField = (patrolPath_ = (RepeatedField<Types.LocationCustomContainer>)(object)((RepeatedField<T>)(object)other.patrolPath_).Clone());
			int num2 = (patrolLoopingIndex_ = other.patrolLoopingIndex_);
			RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = (itemsToGive_ = (RepeatedField<AnyItemSelectorWithAmount>)(object)((RepeatedField<T>)(object)other.itemsToGive_).Clone());
			if (other.chaseTypeCase_ == ChaseTypeOneofCase.TargetPrefab)
			{
				string text2 = (TargetPrefab = other.TargetPrefab);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D30")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E6B0", Offset = "0x2D4D0B0", VA = "0x182D4E6B0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepChase Clone()
		{
			return new CustomStepChase(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3A")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DA40", Offset = "0x1D0C440", VA = "0x181D0DA40")]
		[DebuggerNonUserCode]
		public void ClearChaseType()
		{
			//IL_0010: Expected O, but got I4
			chaseType_ = (chaseTypeCase_ = ChaseTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3B")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E850", Offset = "0x2D4D250", VA = "0x182D4E850", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				string text = default(string);
				if ((IntPtr)targetScene_ == (IntPtr)typeof(CustomStepChase).TypeHandle && !(TargetPrefab != text))
				{
					RepeatedField<Types.LocationCustomContainer> repeatedField = patrolPath_;
					bool flag = default(bool);
					if (flag && patrolLoopingIndex_ == (flag ? 1 : 0))
					{
						RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = itemsToGive_;
						bool flag2 = default(bool);
						if (flag2 && chaseTypeCase_ == (flag2 ? ((ChaseTypeOneofCase)1) : ChaseTypeOneofCase.None))
						{
							return object.Equals(_unknownFields, text);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3C")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E9A0", Offset = "0x2D4D3A0", VA = "0x182D4E9A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepChase other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.targetScene_;
				if (targetScene_ == num)
				{
					string targetPrefab = TargetPrefab;
					string targetPrefab2 = other.TargetPrefab;
					if (!(targetPrefab != targetPrefab2))
					{
						RepeatedField<Types.LocationCustomContainer> repeatedField = patrolPath_;
						RepeatedField<Types.LocationCustomContainer> repeatedField2 = other.patrolPath_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							int num2 = other.patrolLoopingIndex_;
							if (patrolLoopingIndex_ == num2)
							{
								RepeatedField<AnyItemSelectorWithAmount> repeatedField3 = itemsToGive_;
								RepeatedField<AnyItemSelectorWithAmount> repeatedField4 = other.itemsToGive_;
								if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
								{
									ChaseTypeOneofCase chaseTypeOneofCase = other.chaseTypeCase_;
									if (chaseTypeCase_ == chaseTypeOneofCase)
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3D")]
		[Cpp2IlInjected.Address(RVA = "0x2D4EBB0", Offset = "0x2D4D5B0", VA = "0x182D4EBB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0075
			int num = targetScene_;
			int num2 = 0;
			if (num != 0)
			{
			}
			if (chaseTypeCase_ == ChaseTypeOneofCase.TargetPrefab)
			{
				if (chaseTypeCase_ != ChaseTypeOneofCase.TargetPrefab)
				{
				}
				object obj = chaseType_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)patrolPath_).GetHashCode();
			if (patrolLoopingIndex_ != 0)
			{
			}
			int hashCode3 = ((RepeatedField<T>)(object)itemsToGive_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode3;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3E")]
		[Cpp2IlInjected.Address(RVA = "0x2D4F2A0", Offset = "0x2D4DCA0", VA = "0x182D4F2A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D3F")]
		[Cpp2IlInjected.Address(RVA = "0x2D4F300", Offset = "0x2D4DD00", VA = "0x182D4F300", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_008b
			if (targetScene_ != 0)
			{
				int value = targetScene_;
				output.WriteInt32(value);
			}
			if (chaseTypeCase_ == ChaseTypeOneofCase.TargetPrefab)
			{
				string targetPrefab = TargetPrefab;
				output.WriteString(targetPrefab);
			}
			RepeatedField<Types.LocationCustomContainer> repeatedField = patrolPath_;
			FieldCodec<Types.LocationCustomContainer> repeated_patrolPath_codec = _repeated_patrolPath_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_patrolPath_codec);
			if (patrolLoopingIndex_ != 0)
			{
				int value2 = patrolLoopingIndex_;
				output.WriteInt32(value2);
			}
			RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = itemsToGive_;
			FieldCodec<AnyItemSelectorWithAmount> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_itemsToGive_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D40")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E350", Offset = "0x2D4CD50", VA = "0x182D4E350", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00bd
			int num = targetScene_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			if (chaseTypeCase_ == ChaseTypeOneofCase.TargetPrefab)
			{
				if (chaseTypeCase_ != ChaseTypeOneofCase.TargetPrefab)
				{
				}
				object obj = chaseType_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2++;
				int num4 = default(int);
				num2 += num4;
			}
			RepeatedField<Types.LocationCustomContainer> repeatedField = patrolPath_;
			FieldCodec<Types.LocationCustomContainer> repeated_patrolPath_codec = _repeated_patrolPath_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_patrolPath_codec);
			int num6 = patrolLoopingIndex_;
			num2 += num5;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = itemsToGive_;
			FieldCodec<AnyItemSelectorWithAmount> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_itemsToGive_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num8;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num2 += num9;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D41")]
		[Cpp2IlInjected.Address(RVA = "0x2D4EDA0", Offset = "0x2D4D7A0", VA = "0x182D4EDA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepChase other)
		{
			//Discarded unreachable code: IL_0092
			if (other != null)
			{
				int num = other.targetScene_;
				if (num != 0)
				{
					targetScene_ = num;
				}
				RepeatedField<Types.LocationCustomContainer> repeatedField = patrolPath_;
				RepeatedField<Types.LocationCustomContainer> repeatedField2 = other.patrolPath_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num2 = other.patrolLoopingIndex_;
				if (num2 != 0)
				{
					patrolLoopingIndex_ = num2;
				}
				RepeatedField<AnyItemSelectorWithAmount> repeatedField3 = itemsToGive_;
				RepeatedField<AnyItemSelectorWithAmount> repeatedField4 = other.itemsToGive_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				if (other.chaseTypeCase_ == ChaseTypeOneofCase.TargetPrefab)
				{
					string text = (TargetPrefab = other.TargetPrefab);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D42")]
		[Cpp2IlInjected.Address(RVA = "0x2D4EE80", Offset = "0x2D4D880", VA = "0x182D4EE80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00a4
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if (num == 82)
				{
					RepeatedField<Types.LocationCustomContainer> repeatedField = patrolPath_;
					FieldCodec<Types.LocationCustomContainer> repeated_patrolPath_codec = _repeated_patrolPath_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_patrolPath_codec);
				}
				int num2 = default(int);
				if (num == 88)
				{
					num2 = (patrolLoopingIndex_ = input.ReadInt32());
				}
				if (num2 != 98)
				{
					goto IL_008d;
				}
				RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = itemsToGive_;
				FieldCodec<AnyItemSelectorWithAmount> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsToGive_codec);
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (targetScene_ = input.ReadInt32());
			}
			if (num3 == 42)
			{
				string text2 = (TargetPrefab = input.ReadString());
			}
			goto IL_008d;
			IL_008d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003D43")]
		[Cpp2IlInjected.Address(RVA = "0x2D4EAB0", Offset = "0x2D4D4B0", VA = "0x182D4EAB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = targetScene_;
			}
			if (fieldNumber == 5)
			{
				string targetPrefab = TargetPrefab;
			}
			if (this == null || this == null || (long)this == 1)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D44")]
		[Cpp2IlInjected.Address(RVA = "0x2D4F0D0", Offset = "0x2D4DAD0", VA = "0x182D4F0D0", Slot = "12")]
		[DebuggerNonUserCode]
		public unsafe void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			switch (fieldNumber)
			{
			case 1:
			{
				object obj = default(object);
				targetScene_ = (int)obj;
				return;
			}
			case 5:
				if (value == null || value != null)
				{
					return;
				}
				goto IL_0040;
			default:
				{
					if (this != null)
					{
						if (this == null || (long)this != 1)
						{
							if ((IntPtr)(void*)(int)chaseTypeCase_ == (IntPtr)typeof(string).TypeHandle)
							{
								return;
							}
						}
						else
						{
							InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						}
						break;
					}
					InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
					goto IL_0040;
				}
				IL_0040:
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D45")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E570", Offset = "0x2D4CF70", VA = "0x182D4E570", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				targetScene_ = 0;
				return;
			case 5:
			{
				int num = 0;
				TargetPrefab = "";
				return;
			}
			}
			if (this != null)
			{
				if (this != null)
				{
					while ((long)this != 1)
					{
					}
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D46")]
		[Cpp2IlInjected.Address(RVA = "0x2D4ECF0", Offset = "0x2D4D6F0", VA = "0x182D4ECF0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ChaseType"))
			{
				ChaseTypeOneofCase chaseTypeOneofCase = chaseTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D47")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E640", Offset = "0x2D4D040", VA = "0x182D4E640", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ChaseType"))
			{
				chaseType_ = (chaseTypeCase_ = ChaseTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D4A")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E710", Offset = "0x2D4D110", VA = "0x182D4E710", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_0038: Expected O, but got I4
			if (((RepeatedField<T>)(object)patrolPath_).Count != 0)
			{
				int num = patrolLoopingIndex_;
				int count = ((RepeatedField<T>)(object)patrolPath_).Count;
				int count2 = ((RepeatedField<T>)(object)patrolPath_).Count;
				string message = $"Must be from 0 to {count2}";
				context.AddInvalidMemberError(message, "PatrolLoopingIndex");
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D4B")]
		[Cpp2IlInjected.Address(RVA = "0x2D4F4A0", Offset = "0x2D4DEA0", VA = "0x182D4F4A0")]
		static CustomStepChase()
		{
			Func<CustomStepChase> func = default(Func<CustomStepChase>);
			_parser = (MessageParser<CustomStepChase>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.LocationCustomContainer> parser = Types.LocationCustomContainer._parser;
			uint num = default(uint);
			_parser = (MessageParser<CustomStepChase>)(object)FieldCodec.ForMessage<Types.LocationCustomContainer>(num, (MessageParser<>)(object)parser);
			MessageParser<AnyItemSelectorWithAmount> parser2 = AnyItemSelectorWithAmount._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<CustomStepChase>)(object)FieldCodec.ForMessage<AnyItemSelectorWithAmount>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
