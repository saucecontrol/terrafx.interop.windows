// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868BD-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IPinInfo : IDispatch")]
    public unsafe partial struct IPinInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPinInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, uint>)(lpVtbl[1]))((IPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, uint>)(lpVtbl[2]))((IPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, uint*, int>)(lpVtbl[3]))((IPinInfo*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IPinInfo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IPinInfo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IPinInfo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Pin([NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, IUnknown**, int>)(lpVtbl[7]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ConnectedTo([NativeTypeName("IDispatch **")] IDispatch** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, IDispatch**, int>)(lpVtbl[8]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ConnectionMediaType([NativeTypeName("IDispatch **")] IDispatch** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, IDispatch**, int>)(lpVtbl[9]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FilterInfo([NativeTypeName("IDispatch **")] IDispatch** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, IDispatch**, int>)(lpVtbl[10]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, ushort**, int>)(lpVtbl[11]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Direction([NativeTypeName("LONG *")] int* ppDirection)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, int*, int>)(lpVtbl[12]))((IPinInfo*)Unsafe.AsPointer(ref this), ppDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PinID([NativeTypeName("BSTR *")] ushort** strPinID)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, ushort**, int>)(lpVtbl[13]))((IPinInfo*)Unsafe.AsPointer(ref this), strPinID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediaTypes([NativeTypeName("IDispatch **")] IDispatch** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, IDispatch**, int>)(lpVtbl[14]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IUnknown *")] IUnknown* pPin)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, IUnknown*, int>)(lpVtbl[15]))((IPinInfo*)Unsafe.AsPointer(ref this), pPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectDirect([NativeTypeName("IUnknown *")] IUnknown* pPin)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, IUnknown*, int>)(lpVtbl[16]))((IPinInfo*)Unsafe.AsPointer(ref this), pPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectWithType([NativeTypeName("IUnknown *")] IUnknown* pPin, [NativeTypeName("IDispatch *")] IDispatch* pMediaType)
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, IUnknown*, IDispatch*, int>)(lpVtbl[17]))((IPinInfo*)Unsafe.AsPointer(ref this), pPin, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disconnect()
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, int>)(lpVtbl[18]))((IPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Render()
        {
            return ((delegate* unmanaged[Stdcall]<IPinInfo*, int>)(lpVtbl[19]))((IPinInfo*)Unsafe.AsPointer(ref this));
        }
    }
}
