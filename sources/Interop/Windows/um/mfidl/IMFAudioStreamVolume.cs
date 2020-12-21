// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("76B1BBDB-4EC8-4F36-B106-70A9316DF593")]
    [NativeTypeName("struct IMFAudioStreamVolume : IUnknown")]
    public unsafe partial struct IMFAudioStreamVolume
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioStreamVolume*, Guid*, void**, int>)(lpVtbl[0]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioStreamVolume*, uint>)(lpVtbl[1]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioStreamVolume*, uint>)(lpVtbl[2]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioStreamVolume*, uint*, int>)(lpVtbl[3]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("const float")] float fLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioStreamVolume*, uint, float, int>)(lpVtbl[4]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), dwIndex, fLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("float *")] float* pfLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioStreamVolume*, uint, float*, int>)(lpVtbl[5]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), dwIndex, pfLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("const float *")] float* pfVolumes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioStreamVolume*, uint, float*, int>)(lpVtbl[6]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("float *")] float* pfVolumes)
        {
            return ((delegate* unmanaged[Stdcall]<IMFAudioStreamVolume*, uint, float*, int>)(lpVtbl[7]))((IMFAudioStreamVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
        }
    }
}
