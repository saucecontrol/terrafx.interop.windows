// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906AB-12E2-11DC-9FED-001143A055F9")]
    [NativeTypeName("struct ID2D1LinearGradientBrush : ID2D1Brush")]
    public unsafe partial struct ID2D1LinearGradientBrush
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, uint>)(lpVtbl[1]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, uint>)(lpVtbl[2]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, float, void>)(lpVtbl[4]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), opacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, float>)(lpVtbl[6]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[7]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetStartPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_POINT_2F, void>)(lpVtbl[8]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), startPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetEndPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F endPoint)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_POINT_2F, void>)(lpVtbl[9]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), endPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetStartPoint()
        {
            D2D_POINT_2F result;
            return *((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_POINT_2F*, D2D_POINT_2F*>)(lpVtbl[10]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetEndPoint()
        {
            D2D_POINT_2F result;
            return *((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_POINT_2F*, D2D_POINT_2F*>)(lpVtbl[11]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetGradientStopCollection([NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, ID2D1GradientStopCollection**, void>)(lpVtbl[12]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), gradientStopCollection);
        }
    }
}
