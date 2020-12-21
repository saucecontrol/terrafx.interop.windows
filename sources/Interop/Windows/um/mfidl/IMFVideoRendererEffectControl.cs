// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("604D33D7-CF23-41D5-8224-5BBBB1A87475")]
    [NativeTypeName("struct IMFVideoRendererEffectControl : IUnknown")]
    public unsafe partial struct IMFVideoRendererEffectControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoRendererEffectControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoRendererEffectControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoRendererEffectControl*, uint>)(lpVtbl[1]))((IMFVideoRendererEffectControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoRendererEffectControl*, uint>)(lpVtbl[2]))((IMFVideoRendererEffectControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnAppServiceConnectionEstablished([NativeTypeName("IUnknown *")] IUnknown* pAppServiceConnection)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoRendererEffectControl*, IUnknown*, int>)(lpVtbl[3]))((IMFVideoRendererEffectControl*)Unsafe.AsPointer(ref this), pAppServiceConnection);
        }
    }
}
