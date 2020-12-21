// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B67DFA8-E3DD-4E61-B640-46C2F3D739DC")]
    [NativeTypeName("struct IDCompositionArithmeticCompositeEffect : IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionArithmeticCompositeEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint>)(lpVtbl[1]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint>)(lpVtbl[2]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCoefficients([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* coefficients)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, D2D_VECTOR_4F*, int>)(lpVtbl[4]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), coefficients);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClampOutput([NativeTypeName("BOOL")] int clampoutput)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, int, int>)(lpVtbl[5]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), clampoutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient1(float Coeffcient1)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[6]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coeffcient1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient1([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient2(float Coefficient2)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[8]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient2([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient3(float Coefficient3)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[10]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient3([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient4(float Coefficient4)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, float, int>)(lpVtbl[12]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), Coefficient4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCoefficient4([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionArithmeticCompositeEffect*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionArithmeticCompositeEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
