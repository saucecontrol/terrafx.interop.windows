// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("657804FA-D6AD-4496-8A60-352752AF4F89")]
    [NativeTypeName("struct IAudioEndpointVolumeCallback : IUnknown")]
    public unsafe partial struct IAudioEndpointVolumeCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioEndpointVolumeCallback*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEndpointVolumeCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioEndpointVolumeCallback*, uint>)(lpVtbl[1]))((IAudioEndpointVolumeCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioEndpointVolumeCallback*, uint>)(lpVtbl[2]))((IAudioEndpointVolumeCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnNotify([NativeTypeName("PAUDIO_VOLUME_NOTIFICATION_DATA")] AUDIO_VOLUME_NOTIFICATION_DATA* pNotify)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioEndpointVolumeCallback*, AUDIO_VOLUME_NOTIFICATION_DATA*, int>)(lpVtbl[3]))((IAudioEndpointVolumeCallback*)Unsafe.AsPointer(ref this), pNotify);
        }
    }
}
