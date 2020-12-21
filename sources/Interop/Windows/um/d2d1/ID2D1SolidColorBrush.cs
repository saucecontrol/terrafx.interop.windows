// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906A9-12E2-11DC-9FED-001143A055F9")]
    [NativeTypeName("struct ID2D1SolidColorBrush : ID2D1Brush")]
    public unsafe partial struct ID2D1SolidColorBrush
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, uint>)(lpVtbl[1]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, uint>)(lpVtbl[2]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, float, void>)(lpVtbl[4]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), opacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, float>)(lpVtbl[6]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[7]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetColor([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, DXGI_RGBA*, void>)(lpVtbl[8]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_COLOR_F")]
        public DXGI_RGBA GetColor()
        {
            DXGI_RGBA result;
            return *((delegate* unmanaged[Stdcall]<ID2D1SolidColorBrush*, DXGI_RGBA*, DXGI_RGBA*>)(lpVtbl[9]))((ID2D1SolidColorBrush*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
