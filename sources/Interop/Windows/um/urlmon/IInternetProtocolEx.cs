// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C7A98E66-1010-492C-A1C8-C809E1F75905")]
    [NativeTypeName("struct IInternetProtocolEx : IInternetProtocol")]
    public unsafe partial struct IInternetProtocolEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, uint>)(lpVtbl[1]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, uint>)(lpVtbl[2]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink, [NativeTypeName("IInternetBindInfo *")] IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] nuint dwReserved)
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, ushort*, IInternetProtocolSink*, IInternetBindInfo*, uint, nuint, int>)(lpVtbl[3]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Continue([NativeTypeName("PROTOCOLDATA *")] PROTOCOLDATA* pProtocolData)
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, PROTOCOLDATA*, int>)(lpVtbl[4]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort([NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, int, uint, int>)(lpVtbl[5]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, uint, int>)(lpVtbl[6]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, int>)(lpVtbl[7]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, int>)(lpVtbl[8]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, void*, uint, uint*, int>)(lpVtbl[9]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[10]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockRequest([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, uint, int>)(lpVtbl[11]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRequest()
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, int>)(lpVtbl[12]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartEx([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink, [NativeTypeName("IInternetBindInfo *")] IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] nuint dwReserved)
        {
            return ((delegate* unmanaged[Stdcall]<IInternetProtocolEx*, IUri*, IInternetProtocolSink*, IInternetBindInfo*, uint, nuint, int>)(lpVtbl[13]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pUri, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }
    }
}
