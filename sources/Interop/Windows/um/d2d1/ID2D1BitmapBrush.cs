// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906AA-12E2-11DC-9FED-001143A055F9")]
    [NativeTypeName("struct ID2D1BitmapBrush : ID2D1Brush")]
    public unsafe partial struct ID2D1BitmapBrush
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>)(lpVtbl[1]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>)(lpVtbl[2]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, float, void>)(lpVtbl[4]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), opacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, float>)(lpVtbl[6]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[7]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetExtendModeX(D2D1_EXTEND_MODE extendModeX)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, D2D1_EXTEND_MODE, void>)(lpVtbl[8]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), extendModeX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetExtendModeY(D2D1_EXTEND_MODE extendModeY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, D2D1_EXTEND_MODE, void>)(lpVtbl[9]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), extendModeY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, D2D1_BITMAP_INTERPOLATION_MODE, void>)(lpVtbl[10]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Bitmap*, void>)(lpVtbl[11]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, D2D1_EXTEND_MODE>)(lpVtbl[12]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, D2D1_EXTEND_MODE>)(lpVtbl[13]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, D2D1_BITMAP_INTERPOLATION_MODE>)(lpVtbl[14]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetBitmap([NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Bitmap**, void>)(lpVtbl[15]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), bitmap);
        }
    }
}
