// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2A9E9EAD-364B-4B15-A7C4-A1997F78B389")]
    [NativeTypeName("struct IDCompositionScaleTransform3D : IDCompositionTransform3D")]
    public unsafe partial struct IDCompositionScaleTransform3D
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, uint>)(lpVtbl[1]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, uint>)(lpVtbl[2]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleX(float scaleX)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[3]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleY(float scaleY)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[5]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleZ(float scaleZ)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[7]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[9]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[11]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[12]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterZ(float centerZ)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[13]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[14]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
