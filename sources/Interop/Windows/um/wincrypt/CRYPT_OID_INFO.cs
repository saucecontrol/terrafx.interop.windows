// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_OID_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszOID;

        [NativeTypeName("LPCWSTR")]
        public ushort* pwszName;

        [NativeTypeName("DWORD")]
        public uint dwGroupId;

        [NativeTypeName("_CRYPT_OID_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:6206:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint dwValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwValue, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->dwValue;
#endif
            }
        }

        public unsafe ref uint Algid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Algid, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Algid;
#endif
            }
        }

        public unsafe ref uint dwLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwLength, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->dwLength;
#endif
            }
        }

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB ExtraInfo;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwValue;

            [FieldOffset(0)]
            [NativeTypeName("ALG_ID")]
            public uint Algid;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwLength;
        }
    }
}
