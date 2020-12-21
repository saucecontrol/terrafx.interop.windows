// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PROVIDER_DATA
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("WINTRUST_DATA *")]
        public WINTRUST_DATA* pWintrustData;

        [NativeTypeName("BOOL")]
        public int fOpenedFile;

        [NativeTypeName("HWND")]
        public IntPtr hWndParent;

        [NativeTypeName("GUID *")]
        public Guid* pgActionID;

        [NativeTypeName("HCRYPTPROV")]
        public nuint hProv;

        [NativeTypeName("DWORD")]
        public uint dwError;

        [NativeTypeName("DWORD")]
        public uint dwRegSecuritySettings;

        [NativeTypeName("DWORD")]
        public uint dwRegPolicySettings;

        [NativeTypeName("struct _CRYPT_PROVIDER_FUNCTIONS *")]
        public CRYPT_PROVIDER_FUNCTIONS* psPfns;

        [NativeTypeName("DWORD")]
        public uint cdwTrustStepErrors;

        [NativeTypeName("DWORD *")]
        public uint* padwTrustStepErrors;

        [NativeTypeName("DWORD")]
        public uint chStores;

        [NativeTypeName("HCERTSTORE *")]
        public void** pahStores;

        [NativeTypeName("DWORD")]
        public uint dwEncoding;

        [NativeTypeName("HCRYPTMSG")]
        public void* hMsg;

        [NativeTypeName("DWORD")]
        public uint csSigners;

        [NativeTypeName("struct _CRYPT_PROVIDER_SGNR *")]
        public CRYPT_PROVIDER_SGNR* pasSigners;

        [NativeTypeName("DWORD")]
        public uint csProvPrivData;

        [NativeTypeName("struct _CRYPT_PROVIDER_PRIVDATA *")]
        public CRYPT_PROVIDER_PRIVDATA* pasProvPrivData;

        [NativeTypeName("DWORD")]
        public uint dwSubjectChoice;

        [NativeTypeName("_CRYPT_PROVIDER_DATA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/WinTrust.h:688:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref PROVDATA_SIP* pPDSip
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pPDSip;
            }
        }

        [NativeTypeName("char *")]
        public sbyte* pszUsageOID;

        [NativeTypeName("BOOL")]
        public int fRecallWithState;

        public FILETIME sftSystemTime;

        [NativeTypeName("char *")]
        public sbyte* pszCTLSignerUsageOID;

        [NativeTypeName("DWORD")]
        public uint dwProvFlags;

        [NativeTypeName("DWORD")]
        public uint dwFinalError;

        [NativeTypeName("PCERT_USAGE_MATCH")]
        public CERT_USAGE_MATCH* pRequestUsage;

        [NativeTypeName("DWORD")]
        public uint dwTrustPubSettings;

        [NativeTypeName("DWORD")]
        public uint dwUIStateFlags;

        [NativeTypeName("struct _CRYPT_PROVIDER_SIGSTATE *")]
        public CRYPT_PROVIDER_SIGSTATE* pSigState;

        [NativeTypeName("struct WINTRUST_SIGNATURE_SETTINGS_ *")]
        public WINTRUST_SIGNATURE_SETTINGS* pSigSettings;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct _PROVDATA_SIP *")]
            public PROVDATA_SIP* pPDSip;
        }
    }
}
