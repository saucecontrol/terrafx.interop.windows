// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4305EE5B-C4A0-4C88-9385-67124E017683")]
    [NativeTypeName("struct IDCompositionLinearTransferEffect : IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionLinearTransferEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint>)(lpVtbl[1]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint>)(lpVtbl[2]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedYIntercept(float redYIntercept)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[4]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redYIntercept);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedYIntercept([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedSlope(float redSlope)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[6]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redSlope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedSlope([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedDisable([NativeTypeName("BOOL")] int redDisable)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, int, int>)(lpVtbl[8]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreenYIntercept(float greenYIntercept)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[9]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenYIntercept);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreenYIntercept([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreenSlope(float greenSlope)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[11]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenSlope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreenSlope([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[12]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreenDisable([NativeTypeName("BOOL")] int greenDisable)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, int, int>)(lpVtbl[13]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlueYIntercept(float blueYIntercept)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[14]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueYIntercept);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlueYIntercept([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[15]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlueSlope(float blueSlope)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[16]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueSlope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlueSlope([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[17]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlueDisable([NativeTypeName("BOOL")] int blueDisable)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, int, int>)(lpVtbl[18]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaYIntercept(float alphaYIntercept)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[19]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaYIntercept);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaYIntercept([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[20]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaSlope(float alphaSlope)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[21]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaSlope);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaSlope([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[22]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlphaDisable([NativeTypeName("BOOL")] int alphaDisable)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, int, int>)(lpVtbl[23]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaDisable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clampOutput)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, int, int>)(lpVtbl[24]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), clampOutput);
        }
    }
}
