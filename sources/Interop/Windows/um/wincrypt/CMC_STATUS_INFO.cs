// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMC_STATUS_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwStatus;

        [NativeTypeName("DWORD")]
        public uint cBodyList;

        [NativeTypeName("DWORD *")]
        public uint* rgdwBodyList;

        [NativeTypeName("LPWSTR")]
        public ushort* pwszStatusString;

        [NativeTypeName("DWORD")]
        public uint dwOtherInfoChoice;

        [NativeTypeName("_CMC_STATUS_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:5293:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint dwFailInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwFailInfo, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->dwFailInfo;
#endif
            }
        }

        public unsafe ref CMC_PEND_INFO* pPendInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pPendInfo;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwFailInfo;

            [FieldOffset(0)]
            [NativeTypeName("PCMC_PEND_INFO")]
            public CMC_PEND_INFO* pPendInfo;
        }
    }
}
