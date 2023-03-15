using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010F1")]
	public sealed class Decal : IDecal, IEquatable<IDecal>, IMessage<Decal>, IMessage, IEquatable<Decal>, IDeepCloneable<Decal>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40045E2")]
		private static readonly MessageParser<Decal> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40045E3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40045E4")]
		public const int DecalItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40045E5")]
		private int decalItem_;

		[Cpp2IlInjected.Token(Token = "0x40045E6")]
		public const int ColorFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40045E7")]
		private string color_ = "";

		[Cpp2IlInjected.Token(Token = "0x40045E8")]
		public const int PositionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40045E9")]
		private Vector3 position_;

		[Cpp2IlInjected.Token(Token = "0x40045EA")]
		public const int RotationFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40045EB")]
		private Vector3 rotation_;

		[Cpp2IlInjected.Token(Token = "0x40045EC")]
		public const int SizeFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40045ED")]
		private float size_;

		[Cpp2IlInjected.Token(Token = "0x40045EE")]
		public const int FlippedFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40045EF")]
		private bool flipped_;

		[Cpp2IlInjected.Token(Token = "0x40045F0")]
		public const int CutoutFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x40045F1")]
		private bool cutout_;

		[Cpp2IlInjected.Token(Token = "0x40045F2")]
		public const int SeeThroughFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
		[Cpp2IlInjected.Token(Token = "0x40045F3")]
		private bool seeThrough_;

		[Cpp2IlInjected.Token(Token = "0x40045F4")]
		public const int UVSpaceFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
		[Cpp2IlInjected.Token(Token = "0x40045F5")]
		private bool uVSpace_;

		[Cpp2IlInjected.Token(Token = "0x40045F6")]
		public const int RepeatFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40045F7")]
		private bool repeat_;

		[Cpp2IlInjected.Token(Token = "0x17001813")]
		Item IDecal.DecalItem
		{
			[Cpp2IlInjected.Token(Token = "0x60089F1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "4")]
			get
			{
				int num = decalItem_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001814")]
		IVector3 IDecal.Position
		{
			[Cpp2IlInjected.Token(Token = "0x60089F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "6")]
			get
			{
				Vector3 vector = position_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001815")]
		IVector3 IDecal.Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60089F3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "7")]
			get
			{
				Vector3 vector = rotation_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001816")]
		[DebuggerNonUserCode]
		public static MessageParser<Decal> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60089F5")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FAE0", Offset = "0x1A1E4E0", VA = "0x181A1FAE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001817")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60089F6")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FA10", Offset = "0x1A1E410", VA = "0x181A1FA10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001818")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60089F7")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FB60", Offset = "0x1A1E560", VA = "0x181A1FB60", Slot = "19")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001819")]
		[DebuggerNonUserCode]
		public int DecalItem
		{
			[Cpp2IlInjected.Token(Token = "0x60089FB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return decalItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x60089FC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				decalItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181A")]
		[DebuggerNonUserCode]
		public string Color
		{
			[Cpp2IlInjected.Token(Token = "0x60089FD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "5")]
			get
			{
				return color_;
			}
			[Cpp2IlInjected.Token(Token = "0x60089FE")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FC70", Offset = "0x1A1E670", VA = "0x181A1FC70")]
			set
			{
				string text = (color_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181B")]
		[DebuggerNonUserCode]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x60089FF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return position_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A00")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				position_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181C")]
		[DebuggerNonUserCode]
		public Vector3 Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6008A01")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return rotation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A02")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				rotation_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181D")]
		[DebuggerNonUserCode]
		public float Size
		{
			[Cpp2IlInjected.Token(Token = "0x6008A03")]
			[Cpp2IlInjected.Address(RVA = "0xA82BB0", Offset = "0xA815B0", VA = "0x180A82BB0", Slot = "8")]
			get
			{
				return size_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A04")]
			[Cpp2IlInjected.Address(RVA = "0xA82CD0", Offset = "0xA816D0", VA = "0x180A82CD0")]
			set
			{
				size_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181E")]
		[DebuggerNonUserCode]
		public bool Flipped
		{
			[Cpp2IlInjected.Token(Token = "0x6008A05")]
			[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0", Slot = "9")]
			get
			{
				return flipped_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A06")]
			[Cpp2IlInjected.Address(RVA = "0xA15800", Offset = "0xA14200", VA = "0x180A15800")]
			set
			{
				flipped_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700181F")]
		[DebuggerNonUserCode]
		public bool Cutout
		{
			[Cpp2IlInjected.Token(Token = "0x6008A07")]
			[Cpp2IlInjected.Address(RVA = "0xBBB1C0", Offset = "0xBB9BC0", VA = "0x180BBB1C0", Slot = "10")]
			get
			{
				return cutout_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A08")]
			[Cpp2IlInjected.Address(RVA = "0xBBB230", Offset = "0xBB9C30", VA = "0x180BBB230")]
			set
			{
				cutout_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001820")]
		[DebuggerNonUserCode]
		public bool SeeThrough
		{
			[Cpp2IlInjected.Token(Token = "0x6008A09")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FB40", Offset = "0x1A1E540", VA = "0x181A1FB40", Slot = "11")]
			get
			{
				return seeThrough_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A0A")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FCE0", Offset = "0x1A1E6E0", VA = "0x181A1FCE0")]
			set
			{
				seeThrough_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001821")]
		[DebuggerNonUserCode]
		public bool UVSpace
		{
			[Cpp2IlInjected.Token(Token = "0x6008A0B")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FB50", Offset = "0x1A1E550", VA = "0x181A1FB50", Slot = "12")]
			get
			{
				return uVSpace_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A0C")]
			[Cpp2IlInjected.Address(RVA = "0x1A1FCF0", Offset = "0x1A1E6F0", VA = "0x181A1FCF0")]
			set
			{
				uVSpace_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001822")]
		[DebuggerNonUserCode]
		public bool Repeat
		{
			[Cpp2IlInjected.Token(Token = "0x6008A0D")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620", Slot = "13")]
			get
			{
				return repeat_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A0E")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				repeat_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089F4")]
		[Cpp2IlInjected.Address(RVA = "0x1A1E490", Offset = "0x1A1CE90", VA = "0x181A1E490", Slot = "14")]
		public bool Equals(IDecal other)
		{
			//Discarded unreachable code: IL_008b
			if (decalItem_ != 0)
			{
				int num = 0;
				string text = color_;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				bool flag = default(bool);
				if (flag)
				{
					Vector3 vector = position_;
					bool flag2 = default(bool);
					if (flag2)
					{
						Vector3 vector2 = rotation_;
						bool flag3 = default(bool);
						if (flag3)
						{
							float num3 = size_;
							uint num4 = default(uint);
							if (num < (int)num4)
							{
								num += num;
								num++;
							}
							bool flag4 = default(bool);
							if (flag4 && flipped_ && cutout_ && seeThrough_ && uVSpace_)
							{
								return repeat_;
							}
						}
					}
				}
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089F8")]
		[Cpp2IlInjected.Address(RVA = "0x1A1F9C0", Offset = "0x1A1E3C0", VA = "0x181A1F9C0")]
		[DebuggerNonUserCode]
		public Decal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60089F9")]
		[Cpp2IlInjected.Address(RVA = "0x1A1F8B0", Offset = "0x1A1E2B0", VA = "0x181A1F8B0")]
		[DebuggerNonUserCode]
		public Decal(Decal other)
		{
			//IL_0049: Expected O, but got I4
			int num = (decalItem_ = other.decalItem_);
			string text = (color_ = other.color_);
			Vector3 vector = other.position_;
			int num2 = 0;
			if (vector != null)
			{
				Vector3 vector2 = vector.Clone();
			}
			position_ = (Vector3)num2;
			Vector3 vector3 = other.rotation_;
			Vector3 vector4 = default(Vector3);
			if (vector3 != null)
			{
				vector4 = vector3.Clone();
			}
			rotation_ = vector4;
			float num3 = (size_ = other.size_);
			bool flag = (flipped_ = other.flipped_);
			bool flag2 = (cutout_ = other.cutout_);
			bool flag3 = (seeThrough_ = other.seeThrough_);
			bool flag4 = (uVSpace_ = other.uVSpace_);
			bool flag5 = (repeat_ = other.repeat_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A1E350", Offset = "0x1A1CD50", VA = "0x181A1E350", Slot = "21")]
		[DebuggerNonUserCode]
		public Decal Clone()
		{
			//Discarded unreachable code: IL_00e0
			//IL_004b: Expected O, but got I4
			Decal decal = new Decal();
			decal.color_ = "";
			int num = (decal.decalItem_ = decalItem_);
			string text = (decal.color_ = color_);
			Vector3 vector = position_;
			int num2 = 0;
			if (vector != null)
			{
				Vector3 vector2 = vector.Clone();
			}
			decal.position_ = (Vector3)num2;
			Vector3 vector3 = rotation_;
			Vector3 vector4 = default(Vector3);
			if (vector3 != null)
			{
				vector4 = vector3.Clone();
			}
			decal.rotation_ = vector4;
			float num3 = (decal.size_ = size_);
			bool flag = (decal.flipped_ = flipped_);
			bool flag2 = (decal.cutout_ = cutout_);
			bool flag3 = (decal.seeThrough_ = seeThrough_);
			bool flag4 = (decal.uVSpace_ = uVSpace_);
			bool flag5 = (decal.repeat_ = repeat_);
			UnknownFieldSet unknownFieldSet = (decal._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return decal;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A0F")]
		[Cpp2IlInjected.Address(RVA = "0x1A1E910", Offset = "0x1A1D310", VA = "0x181A1E910", Slot = "0")]
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
				if ((IntPtr)decalItem_ == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle)
				{
					string text = color_;
					bool flag = default(bool);
					sbyte b = default(sbyte);
					if (!flag && object.Equals(position_, other) && object.Equals(rotation_, other) && (flipped_ ? 1u : 0u) == (uint)b && (cutout_ ? 1u : 0u) == (uint)b && (seeThrough_ ? 1u : 0u) == (uint)b && (uVSpace_ ? 1u : 0u) == (uint)b && (repeat_ ? 1u : 0u) == (uint)b)
					{
						UnknownFieldSet unknownFields = _unknownFields;
						bool result = default(bool);
						return result;
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A10")]
		[Cpp2IlInjected.Address(RVA = "0x1A1E7C0", Offset = "0x1A1D1C0", VA = "0x181A1E7C0", Slot = "20")]
		[DebuggerNonUserCode]
		public bool Equals(Decal other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.decalItem_;
				if (decalItem_ == num)
				{
					string text = other.color_;
					if (!(color_ != text))
					{
						Vector3 objB = other.position_;
						if (object.Equals(position_, objB))
						{
							Vector3 objB2 = other.rotation_;
							if (object.Equals(rotation_, objB2))
							{
								bool flag = other.flipped_;
								if (flipped_ == flag)
								{
									bool flag2 = other.cutout_;
									if (cutout_ == flag2)
									{
										bool flag3 = other.seeThrough_;
										if (seeThrough_ == flag3)
										{
											bool flag4 = other.uVSpace_;
											if (uVSpace_ == flag4)
											{
												bool flag5 = other.repeat_;
												if (repeat_ == flag5)
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A11")]
		[Cpp2IlInjected.Address(RVA = "0x1A1EC40", Offset = "0x1A1D640", VA = "0x181A1EC40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00a7
			//IL_0060: Expected O, but got F4
			if (decalItem_ != 0)
			{
			}
			string text = color_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			Vector3 vector = position_;
			if (vector != null)
			{
				int hashCode2 = vector.GetHashCode();
			}
			Vector3 vector2 = rotation_;
			if (vector2 != null)
			{
				int hashCode3 = vector2.GetHashCode();
			}
			if (vector2 != null)
			{
				int hashCode4 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)0f);
			}
			if (flipped_)
			{
			}
			if (cutout_)
			{
			}
			if (seeThrough_)
			{
			}
			if (uVSpace_)
			{
			}
			if (repeat_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A12")]
		[Cpp2IlInjected.Address(RVA = "0x1A1F540", Offset = "0x1A1DF40", VA = "0x181A1F540", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008A13")]
		[Cpp2IlInjected.Address(RVA = "0x1A1F5A0", Offset = "0x1A1DFA0", VA = "0x181A1F5A0", Slot = "17")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_010c
			if (decalItem_ != 0)
			{
				int value = decalItem_;
				output.WriteInt32(value);
			}
			if (color_.m_stringLength != 0)
			{
				string value2 = color_;
				output.WriteString(value2);
			}
			if ((long)position_ != 0)
			{
				Vector3 value3 = position_;
				output.WriteMessage(value3);
			}
			if ((long)rotation_ != 0)
			{
				Vector3 value4 = rotation_;
				output.WriteMessage(value4);
			}
			if (output != null)
			{
				float value5 = size_;
				output.WriteFloat(value5);
			}
			if (flipped_)
			{
				bool value6 = flipped_;
				output.WriteBool(value6);
			}
			if (cutout_)
			{
				bool value7 = cutout_;
				output.WriteBool(value7);
			}
			if (seeThrough_)
			{
				bool value8 = seeThrough_;
				output.WriteBool(value8);
			}
			if (uVSpace_)
			{
				bool value9 = uVSpace_;
				output.WriteBool(value9);
			}
			if (repeat_)
			{
				bool value10 = repeat_;
				output.WriteBool(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008A14")]
		[Cpp2IlInjected.Address(RVA = "0x1A1E090", Offset = "0x1A1CA90", VA = "0x181A1E090", Slot = "18")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_009a
			int num = decalItem_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = color_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			Vector3 vector = position_;
			if (vector != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(vector);
				num5++;
				num2 += num5;
			}
			Vector3 vector2 = rotation_;
			if (vector2 != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(vector2);
				num6++;
				num2 += num6;
			}
			num2 += 5;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A15")]
		[Cpp2IlInjected.Address(RVA = "0x1A1F050", Offset = "0x1A1DA50", VA = "0x181A1F050", Slot = "15")]
		[DebuggerNonUserCode]
		public void MergeFrom(Decal other)
		{
			//Discarded unreachable code: IL_0142
			if (other == null)
			{
				return;
			}
			int num = other.decalItem_;
			if (num != 0)
			{
				decalItem_ = num;
			}
			string text = other.color_;
			if (text.m_stringLength != 0)
			{
				Color = text;
			}
			if ((long)other.position_ != 0)
			{
				Vector3 vector2 = default(Vector3);
				if (position_ == null)
				{
					Vector3 vector = (position_ = new Vector3());
					vector2 = position_;
				}
				Vector3 other2 = other.position_;
				vector2.MergeFrom(other2);
			}
			Vector3 vector4 = default(Vector3);
			if ((long)other.rotation_ != 0)
			{
				if (rotation_ == null)
				{
					Vector3 vector3 = (rotation_ = new Vector3());
					vector4 = rotation_;
				}
				Vector3 other3 = other.rotation_;
				vector4.MergeFrom(other3);
			}
			float num2 = other.size_;
			if (vector4 != null)
			{
				size_ = num2;
			}
			bool flag = other.flipped_;
			if (flag)
			{
				flipped_ = flag;
			}
			bool flag2 = other.cutout_;
			if (flag2)
			{
				cutout_ = flag2;
			}
			bool flag3 = other.seeThrough_;
			if (flag3)
			{
				seeThrough_ = flag3;
			}
			bool flag4 = other.uVSpace_;
			if (flag4)
			{
				uVSpace_ = flag4;
			}
			bool flag5 = other.repeat_;
			if (flag5)
			{
				repeat_ = flag5;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6008A16")]
		[Cpp2IlInjected.Address(RVA = "0x1A1EE50", Offset = "0x1A1D850", VA = "0x181A1EE50", Slot = "16")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0149
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 45)
			{
				if ((int)num > 56)
				{
					if (num == 64)
					{
						bool flag = (seeThrough_ = input.ReadBool());
					}
					bool flag2 = default(bool);
					if (num == 72)
					{
						flag2 = (uVSpace_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_0132;
					}
					bool flag3 = (repeat_ = input.ReadBool());
				}
				bool flag4 = default(bool);
				if (num == 48)
				{
					flag4 = (flipped_ = input.ReadBool());
				}
				if (!flag4)
				{
					goto IL_0132;
				}
				bool flag5 = (cutout_ = input.ReadBool());
			}
			Vector3 vector2 = default(Vector3);
			if ((int)num > 18)
			{
				Vector3 vector = default(Vector3);
				if (num == 26)
				{
					Vector3 builder = default(Vector3);
					if (position_ == null)
					{
						vector = (position_ = new Vector3());
						builder = position_;
					}
					input.ReadMessage(builder);
				}
				if ((long)vector == 34)
				{
					Vector3 builder2 = default(Vector3);
					if (rotation_ == null)
					{
						vector2 = (rotation_ = new Vector3());
						builder2 = rotation_;
					}
					input.ReadMessage(builder2);
				}
				if ((long)vector2 != 45)
				{
					goto IL_0132;
				}
				float num2 = (size_ = input.ReadFloat());
			}
			int num3 = default(int);
			if ((long)vector2 == 8)
			{
				num3 = (decalItem_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text2 = (Color = input.ReadString());
			}
			goto IL_0132;
			IL_0132:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008A17")]
		[Cpp2IlInjected.Address(RVA = "0x1A1EAA0", Offset = "0x1A1D4A0", VA = "0x181A1EAA0", Slot = "22")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
			{
				int num = decalItem_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A18")]
		[Cpp2IlInjected.Address(RVA = "0x1A1F1F0", Offset = "0x1A1DBF0", VA = "0x181A1F1F0", Slot = "23")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_0021, IL_0029, IL_0031, IL_0039, IL_0041, IL_0049, IL_0051, IL_0057, IL_005d, IL_0063
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			//IL_0028: Expected F4, but got I4
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				decalItem_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A19")]
		[Cpp2IlInjected.Address(RVA = "0x1A1E210", Offset = "0x1A1CC10", VA = "0x181A1E210", Slot = "24")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 9)
			{
				decalItem_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A1A")]
		[Cpp2IlInjected.Address(RVA = "0x1A1F7A0", Offset = "0x1A1E1A0", VA = "0x181A1F7A0")]
		static Decal()
		{
			Func<Decal> func = default(Func<Decal>);
			_parser = (MessageParser<Decal>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
