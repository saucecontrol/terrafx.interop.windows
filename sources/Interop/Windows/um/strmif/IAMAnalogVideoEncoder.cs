// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6E133B0-30AC-11D0-A18C-00A0C9118956")]
    [NativeTypeName("struct IAMAnalogVideoEncoder : IUnknown")]
    public unsafe partial struct IAMAnalogVideoEncoder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, uint>)(lpVtbl[1]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, uint>)(lpVtbl[2]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, int*, int>)(lpVtbl[3]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TVFormat([NativeTypeName("long")] int lAnalogVideoStandard)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, int, int>)(lpVtbl[4]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, int*, int>)(lpVtbl[5]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), plAnalogVideoStandard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CopyProtection([NativeTypeName("long")] int lVideoCopyProtection)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, int, int>)(lpVtbl[6]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lVideoCopyProtection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CopyProtection([NativeTypeName("long *")] int* lVideoCopyProtection)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, int*, int>)(lpVtbl[7]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lVideoCopyProtection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CCEnable([NativeTypeName("long")] int lCCEnable)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, int, int>)(lpVtbl[8]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lCCEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CCEnable([NativeTypeName("long *")] int* lCCEnable)
        {
            return ((delegate* unmanaged[Stdcall]<IAMAnalogVideoEncoder*, int*, int>)(lpVtbl[9]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lCCEnable);
        }
    }
}
