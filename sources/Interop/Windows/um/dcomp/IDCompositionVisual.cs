// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4D93059D-097B-4651-9A60-F0F25116E2F3")]
    [NativeTypeName("struct IDCompositionVisual : IUnknown")]
    public unsafe partial struct IDCompositionVisual
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, uint>)(lpVtbl[1]))((IDCompositionVisual*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, uint>)(lpVtbl[2]))((IDCompositionVisual*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, float, int>)(lpVtbl[3]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), offsetX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, float, int>)(lpVtbl[5]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[7]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("IDCompositionTransform *")] IDCompositionTransform* transform)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionTransform*, int>)(lpVtbl[8]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransformParent([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEffect([NativeTypeName("IDCompositionEffect *")] IDCompositionEffect* effect)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), effect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int>)(lpVtbl[11]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, DCOMPOSITION_BORDER_MODE, int>)(lpVtbl[12]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), borderMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, D2D_RECT_F*, int>)(lpVtbl[13]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), rect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClip([NativeTypeName("IDCompositionClip *")] IDCompositionClip* clip)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionClip*, int>)(lpVtbl[14]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), clip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContent([NativeTypeName("IUnknown *")] IUnknown* content)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual, [NativeTypeName("BOOL")] int insertAbove, [NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* referenceVisual)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveVisual([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), visual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllVisuals()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, int>)(lpVtbl[18]))((IDCompositionVisual*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, DCOMPOSITION_COMPOSITE_MODE, int>)(lpVtbl[19]))((IDCompositionVisual*)Unsafe.AsPointer(ref this), compositeMode);
        }
    }
}
