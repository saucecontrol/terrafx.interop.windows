// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMC_TAGGED_REQUEST
    {
        [NativeTypeName("DWORD")]
        public uint dwTaggedRequestChoice;

        [NativeTypeName("_CMC_TAGGED_REQUEST::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:5231:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref CMC_TAGGED_CERT_REQUEST* pTaggedCertRequest
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pTaggedCertRequest;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PCMC_TAGGED_CERT_REQUEST")]
            public CMC_TAGGED_CERT_REQUEST* pTaggedCertRequest;
        }
    }
}
