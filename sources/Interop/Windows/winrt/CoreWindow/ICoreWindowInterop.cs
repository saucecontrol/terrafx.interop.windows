// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45D64A29-A63E-4CB6-B498-5781D298CB4F")]
    [NativeTypeName("struct ICoreWindowInterop : IUnknown")]
    public unsafe partial struct ICoreWindowInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ICoreWindowInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ICoreWindowInterop*, uint>)(lpVtbl[1]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ICoreWindowInterop*, uint>)(lpVtbl[2]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WindowHandle([NativeTypeName("HWND *")] IntPtr* hwnd)
        {
            return ((delegate* unmanaged[Stdcall]<ICoreWindowInterop*, IntPtr*, int>)(lpVtbl[3]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_MessageHandled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged[Stdcall]<ICoreWindowInterop*, byte, int>)(lpVtbl[4]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this), value);
        }
    }
}
