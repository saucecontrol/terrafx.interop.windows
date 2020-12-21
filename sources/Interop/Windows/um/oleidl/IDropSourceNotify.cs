// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000012B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IDropSourceNotify : IUnknown")]
    public unsafe partial struct IDropSourceNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDropSourceNotify*, Guid*, void**, int>)(lpVtbl[0]))((IDropSourceNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDropSourceNotify*, uint>)(lpVtbl[1]))((IDropSourceNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDropSourceNotify*, uint>)(lpVtbl[2]))((IDropSourceNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DragEnterTarget([NativeTypeName("HWND")] IntPtr hwndTarget)
        {
            return ((delegate* unmanaged[Stdcall]<IDropSourceNotify*, IntPtr, int>)(lpVtbl[3]))((IDropSourceNotify*)Unsafe.AsPointer(ref this), hwndTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DragLeaveTarget()
        {
            return ((delegate* unmanaged[Stdcall]<IDropSourceNotify*, int>)(lpVtbl[4]))((IDropSourceNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
