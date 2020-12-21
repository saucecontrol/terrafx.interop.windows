// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868B1-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMediaControl : IDispatch")]
    public unsafe partial struct IMediaControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, Guid*, void**, int>)(lpVtbl[0]))((IMediaControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, uint>)(lpVtbl[1]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, uint>)(lpVtbl[2]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, uint*, int>)(lpVtbl[3]))((IMediaControl*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IMediaControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IMediaControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IMediaControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Run()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, int>)(lpVtbl[7]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, int>)(lpVtbl[8]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, int>)(lpVtbl[9]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("LONG")] int msTimeout, [NativeTypeName("OAFilterState *")] int* pfs)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, int, int*, int>)(lpVtbl[10]))((IMediaControl*)Unsafe.AsPointer(ref this), msTimeout, pfs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenderFile([NativeTypeName("BSTR")] ushort* strFilename)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, ushort*, int>)(lpVtbl[11]))((IMediaControl*)Unsafe.AsPointer(ref this), strFilename);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddSourceFilter([NativeTypeName("BSTR")] ushort* strFilename, [NativeTypeName("IDispatch **")] IDispatch** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, ushort*, IDispatch**, int>)(lpVtbl[12]))((IMediaControl*)Unsafe.AsPointer(ref this), strFilename, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FilterCollection([NativeTypeName("IDispatch **")] IDispatch** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, IDispatch**, int>)(lpVtbl[13]))((IMediaControl*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RegFilterCollection([NativeTypeName("IDispatch **")] IDispatch** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, IDispatch**, int>)(lpVtbl[14]))((IMediaControl*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopWhenReady()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaControl*, int>)(lpVtbl[15]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }
    }
}
