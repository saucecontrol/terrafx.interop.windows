// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFA0AE8E-7E1C-44D2-AE68-FC4C148A6354")]
    [NativeTypeName("struct IMFImageSharingEngine : IUnknown")]
    public unsafe partial struct IMFImageSharingEngine
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFImageSharingEngine*, Guid*, void**, int>)(lpVtbl[0]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFImageSharingEngine*, uint>)(lpVtbl[1]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFImageSharingEngine*, uint>)(lpVtbl[2]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("IUnknown *")] IUnknown* pStream)
        {
            return ((delegate* unmanaged[Stdcall]<IMFImageSharingEngine*, IUnknown*, int>)(lpVtbl[3]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), pStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("DEVICE_INFO *")] DEVICE_INFO* pDevice)
        {
            return ((delegate* unmanaged[Stdcall]<IMFImageSharingEngine*, DEVICE_INFO*, int>)(lpVtbl[4]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), pDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged[Stdcall]<IMFImageSharingEngine*, int>)(lpVtbl[5]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
        }
    }
}
