// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C02216F6-8C67-4B5B-9D00-D008E73E0064")]
    [NativeTypeName("struct IAudioMeterInformation : IUnknown")]
    public unsafe partial struct IAudioMeterInformation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioMeterInformation*, Guid*, void**, int>)(lpVtbl[0]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioMeterInformation*, uint>)(lpVtbl[1]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioMeterInformation*, uint>)(lpVtbl[2]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPeakValue([NativeTypeName("float *")] float* pfPeak)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioMeterInformation*, float*, int>)(lpVtbl[3]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), pfPeak);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMeteringChannelCount([NativeTypeName("UINT *")] uint* pnChannelCount)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioMeterInformation*, uint*, int>)(lpVtbl[4]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), pnChannelCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelsPeakValues([NativeTypeName("UINT32")] uint u32ChannelCount, [NativeTypeName("float *")] float* afPeakValues)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioMeterInformation*, uint, float*, int>)(lpVtbl[5]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), u32ChannelCount, afPeakValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryHardwareSupport([NativeTypeName("DWORD *")] uint* pdwHardwareSupportMask)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioMeterInformation*, uint*, int>)(lpVtbl[6]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), pdwHardwareSupportMask);
        }
    }
}
