// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000123-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICBitmapLock : IUnknown")]
    public unsafe partial struct IWICBitmapLock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint>)(lpVtbl[1]))((IWICBitmapLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint>)(lpVtbl[2]))((IWICBitmapLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapLock*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStride([NativeTypeName("UINT *")] uint* pcbStride)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, int>)(lpVtbl[4]))((IWICBitmapLock*)Unsafe.AsPointer(ref this), pcbStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataPointer([NativeTypeName("UINT *")] uint* pcbBufferSize, [NativeTypeName("WICInProcPointer *")] byte** ppbData)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, byte**, int>)(lpVtbl[5]))((IWICBitmapLock*)Unsafe.AsPointer(ref this), pcbBufferSize, ppbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, int>)(lpVtbl[6]))((IWICBitmapLock*)Unsafe.AsPointer(ref this), pPixelFormat);
        }
    }
}
