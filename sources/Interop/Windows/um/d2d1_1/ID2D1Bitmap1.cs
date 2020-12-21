// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A898A84C-3873-4588-B08B-EBBF978DF041")]
    [NativeTypeName("struct ID2D1Bitmap1 : ID2D1Bitmap")]
    public unsafe partial struct ID2D1Bitmap1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, uint>)(lpVtbl[1]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, uint>)(lpVtbl[2]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, D2D_SIZE_F*, D2D_SIZE_F*>)(lpVtbl[4]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, D2D_SIZE_U*, D2D_SIZE_U*>)(lpVtbl[5]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)(lpVtbl[6]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, float*, float*, void>)(lpVtbl[7]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyFromBitmap([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int>)(lpVtbl[8]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, bitmap, srcRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyFromRenderTarget([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1RenderTarget *")] ID2D1RenderTarget* renderTarget, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int>)(lpVtbl[9]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, renderTarget, srcRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyFromMemory([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, D2D_RECT_U*, void*, uint, int>)(lpVtbl[10]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dstRect, srcData, pitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetColorContext([NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1ColorContext**, void>)(lpVtbl[11]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_BITMAP_OPTIONS GetOptions()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, D2D1_BITMAP_OPTIONS>)(lpVtbl[12]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurface([NativeTypeName("IDXGISurface **")] IDXGISurface** dxgiSurface)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, IDXGISurface**, int>)(lpVtbl[13]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dxgiSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Map(D2D1_MAP_OPTIONS options, [NativeTypeName("D2D1_MAPPED_RECT *")] D2D1_MAPPED_RECT* mappedRect)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, D2D1_MAP_OPTIONS, D2D1_MAPPED_RECT*, int>)(lpVtbl[14]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), options, mappedRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, int>)(lpVtbl[15]))((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }
    }
}
