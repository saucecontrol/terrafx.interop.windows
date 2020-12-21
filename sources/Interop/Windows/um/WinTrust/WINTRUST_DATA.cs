// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WINTRUST_DATA
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("LPVOID")]
        public void* pPolicyCallbackData;

        [NativeTypeName("LPVOID")]
        public void* pSIPClientData;

        [NativeTypeName("DWORD")]
        public uint dwUIChoice;

        [NativeTypeName("DWORD")]
        public uint fdwRevocationChecks;

        [NativeTypeName("DWORD")]
        public uint dwUnionChoice;

        [NativeTypeName("_WINTRUST_DATA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinTrust.h:116:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref WINTRUST_FILE_INFO* pFile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pFile;
            }
        }

        public unsafe ref WINTRUST_CATALOG_INFO* pCatalog
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pCatalog;
            }
        }

        public unsafe ref WINTRUST_BLOB_INFO* pBlob
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pBlob;
            }
        }

        public unsafe ref WINTRUST_SGNR_INFO* pSgnr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pSgnr;
            }
        }

        public unsafe ref WINTRUST_CERT_INFO* pCert
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pCert;
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwStateAction;

        [NativeTypeName("HANDLE")]
        public IntPtr hWVTStateData;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszURLReference;

        [NativeTypeName("DWORD")]
        public uint dwProvFlags;

        [NativeTypeName("DWORD")]
        public uint dwUIContext;

        [NativeTypeName("struct WINTRUST_SIGNATURE_SETTINGS_ *")]
        public WINTRUST_SIGNATURE_SETTINGS* pSignatureSettings;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct WINTRUST_FILE_INFO_ *")]
            public WINTRUST_FILE_INFO* pFile;

            [FieldOffset(0)]
            [NativeTypeName("struct WINTRUST_CATALOG_INFO_ *")]
            public WINTRUST_CATALOG_INFO* pCatalog;

            [FieldOffset(0)]
            [NativeTypeName("struct WINTRUST_BLOB_INFO_ *")]
            public WINTRUST_BLOB_INFO* pBlob;

            [FieldOffset(0)]
            [NativeTypeName("struct WINTRUST_SGNR_INFO_ *")]
            public WINTRUST_SGNR_INFO* pSgnr;

            [FieldOffset(0)]
            [NativeTypeName("struct WINTRUST_CERT_INFO_ *")]
            public WINTRUST_CERT_INFO* pCert;
        }
    }
}
