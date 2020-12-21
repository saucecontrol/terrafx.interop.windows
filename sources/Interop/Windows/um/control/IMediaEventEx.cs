// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868C0-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMediaEventEx : IMediaEvent")]
    public unsafe partial struct IMediaEventEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEventEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, uint>)(lpVtbl[1]))((IMediaEventEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, uint>)(lpVtbl[2]))((IMediaEventEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, uint*, int>)(lpVtbl[3]))((IMediaEventEx*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IMediaEventEx*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IMediaEventEx*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IMediaEventEx*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEventHandle([NativeTypeName("OAEVENT *")] nint* hEvent)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, nint*, int>)(lpVtbl[7]))((IMediaEventEx*)Unsafe.AsPointer(ref this), hEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("long *")] int* lEventCode, [NativeTypeName("LONG_PTR *")] nint* lParam1, [NativeTypeName("LONG_PTR *")] nint* lParam2, [NativeTypeName("long")] int msTimeout)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, int*, nint*, nint*, int, int>)(lpVtbl[8]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lEventCode, lParam1, lParam2, msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForCompletion([NativeTypeName("long")] int msTimeout, [NativeTypeName("long *")] int* pEvCode)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, int, int*, int>)(lpVtbl[9]))((IMediaEventEx*)Unsafe.AsPointer(ref this), msTimeout, pEvCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelDefaultHandling([NativeTypeName("long")] int lEvCode)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, int, int>)(lpVtbl[10]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lEvCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RestoreDefaultHandling([NativeTypeName("long")] int lEvCode)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, int, int>)(lpVtbl[11]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lEvCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreeEventParams([NativeTypeName("long")] int lEvCode, [NativeTypeName("LONG_PTR")] nint lParam1, [NativeTypeName("LONG_PTR")] nint lParam2)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, int, nint, nint, int>)(lpVtbl[12]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lEvCode, lParam1, lParam2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWindow([NativeTypeName("OAHWND")] nint hwnd, [NativeTypeName("long")] int lMsg, [NativeTypeName("LONG_PTR")] nint lInstanceData)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, nint, int, nint, int>)(lpVtbl[13]))((IMediaEventEx*)Unsafe.AsPointer(ref this), hwnd, lMsg, lInstanceData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyFlags([NativeTypeName("long")] int lNoNotifyFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, int, int>)(lpVtbl[14]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lNoNotifyFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNotifyFlags([NativeTypeName("long *")] int* lplNoNotifyFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMediaEventEx*, int*, int>)(lpVtbl[15]))((IMediaEventEx*)Unsafe.AsPointer(ref this), lplNoNotifyFlags);
        }
    }
}
