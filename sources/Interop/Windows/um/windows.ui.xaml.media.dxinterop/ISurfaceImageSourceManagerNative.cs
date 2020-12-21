// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4C8798B7-1D88-4A0F-B59B-B93F600DE8C8")]
    [NativeTypeName("struct ISurfaceImageSourceManagerNative : IUnknown")]
    public unsafe partial struct ISurfaceImageSourceManagerNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISurfaceImageSourceManagerNative*, Guid*, void**, int>)(lpVtbl[0]))((ISurfaceImageSourceManagerNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISurfaceImageSourceManagerNative*, uint>)(lpVtbl[1]))((ISurfaceImageSourceManagerNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISurfaceImageSourceManagerNative*, uint>)(lpVtbl[2]))((ISurfaceImageSourceManagerNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FlushAllSurfacesWithDevice([NativeTypeName("IUnknown *")] IUnknown* device)
        {
            return ((delegate* unmanaged[Stdcall]<ISurfaceImageSourceManagerNative*, IUnknown*, int>)(lpVtbl[3]))((ISurfaceImageSourceManagerNative*)Unsafe.AsPointer(ref this), device);
        }
    }
}
