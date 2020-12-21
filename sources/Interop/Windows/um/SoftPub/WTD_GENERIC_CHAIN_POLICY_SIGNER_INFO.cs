// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO
    {
        [NativeTypeName("_WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/SoftPub.h:133:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint cbStruct
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbStruct, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->cbStruct;
#endif
            }
        }

        public unsafe ref uint cbSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbSize, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->cbSize;
#endif
            }
        }

        [NativeTypeName("PCCERT_CHAIN_CONTEXT")]
        public CERT_CHAIN_CONTEXT* pChainContext;

        [NativeTypeName("DWORD")]
        public uint dwSignerType;

        [NativeTypeName("PCMSG_SIGNER_INFO")]
        public CMSG_SIGNER_INFO* pMsgSignerInfo;

        [NativeTypeName("DWORD")]
        public uint dwError;

        [NativeTypeName("DWORD")]
        public uint cCounterSigner;

        [NativeTypeName("PWTD_GENERIC_CHAIN_POLICY_SIGNER_INFO *")]
        public WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO** rgpCounterSigner;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cbStruct;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cbSize;
        }
    }
}
