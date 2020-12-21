// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CD63314F-3FBA-4A1B-812C-EF96358728E7")]
    [NativeTypeName("struct IAudioClock : IUnknown")]
    public unsafe partial struct IAudioClock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioClock*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioClock*, uint>)(lpVtbl[1]))((IAudioClock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioClock*, uint>)(lpVtbl[2]))((IAudioClock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrequency([NativeTypeName("UINT64 *")] ulong* pu64Frequency)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioClock*, ulong*, int>)(lpVtbl[3]))((IAudioClock*)Unsafe.AsPointer(ref this), pu64Frequency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPosition([NativeTypeName("UINT64 *")] ulong* pu64Position, [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioClock*, ulong*, ulong*, int>)(lpVtbl[4]))((IAudioClock*)Unsafe.AsPointer(ref this), pu64Position, pu64QPCPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioClock*, uint*, int>)(lpVtbl[5]))((IAudioClock*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }
    }
}
