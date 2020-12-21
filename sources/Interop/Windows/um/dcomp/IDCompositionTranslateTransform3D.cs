// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("91636D4B-9BA1-4532-AAF7-E3344994D788")]
    [NativeTypeName("struct IDCompositionTranslateTransform3D : IDCompositionTransform3D")]
    public unsafe partial struct IDCompositionTranslateTransform3D
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, uint>)(lpVtbl[1]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, uint>)(lpVtbl[2]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, float, int>)(lpVtbl[3]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, float, int>)(lpVtbl[5]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ(float offsetZ)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, float, int>)(lpVtbl[7]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
