// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868B2-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMediaPosition : IDispatch")]
    public unsafe partial struct IMediaPosition
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPosition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, uint>)(lpVtbl[1]))((IMediaPosition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, uint>)(lpVtbl[2]))((IMediaPosition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, uint*, int>)(lpVtbl[3]))((IMediaPosition*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IMediaPosition*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IMediaPosition*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IMediaPosition*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Duration([NativeTypeName("REFTIME *")] double* plength)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, double*, int>)(lpVtbl[7]))((IMediaPosition*)Unsafe.AsPointer(ref this), plength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CurrentPosition([NativeTypeName("REFTIME")] double llTime)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, double, int>)(lpVtbl[8]))((IMediaPosition*)Unsafe.AsPointer(ref this), llTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentPosition([NativeTypeName("REFTIME *")] double* pllTime)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, double*, int>)(lpVtbl[9]))((IMediaPosition*)Unsafe.AsPointer(ref this), pllTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StopTime([NativeTypeName("REFTIME *")] double* pllTime)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, double*, int>)(lpVtbl[10]))((IMediaPosition*)Unsafe.AsPointer(ref this), pllTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_StopTime([NativeTypeName("REFTIME")] double llTime)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, double, int>)(lpVtbl[11]))((IMediaPosition*)Unsafe.AsPointer(ref this), llTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PrerollTime([NativeTypeName("REFTIME *")] double* pllTime)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, double*, int>)(lpVtbl[12]))((IMediaPosition*)Unsafe.AsPointer(ref this), pllTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PrerollTime([NativeTypeName("REFTIME")] double llTime)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, double, int>)(lpVtbl[13]))((IMediaPosition*)Unsafe.AsPointer(ref this), llTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Rate(double dRate)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, double, int>)(lpVtbl[14]))((IMediaPosition*)Unsafe.AsPointer(ref this), dRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rate([NativeTypeName("double *")] double* pdRate)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, double*, int>)(lpVtbl[15]))((IMediaPosition*)Unsafe.AsPointer(ref this), pdRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanSeekForward([NativeTypeName("LONG *")] int* pCanSeekForward)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, int*, int>)(lpVtbl[16]))((IMediaPosition*)Unsafe.AsPointer(ref this), pCanSeekForward);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanSeekBackward([NativeTypeName("LONG *")] int* pCanSeekBackward)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaPosition*, int*, int>)(lpVtbl[17]))((IMediaPosition*)Unsafe.AsPointer(ref this), pCanSeekBackward);
        }
    }
}
