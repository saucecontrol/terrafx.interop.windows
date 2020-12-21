// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.hosting.desktopwindowxamlsource.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E3DCD8C7-3057-4692-99C3-7B7720AFDA31")]
    [NativeTypeName("struct IDesktopWindowXamlSourceNative2 : IDesktopWindowXamlSourceNative")]
    public unsafe partial struct IDesktopWindowXamlSourceNative2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative2*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative2*, uint>)(lpVtbl[1]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative2*, uint>)(lpVtbl[2]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AttachToWindow([NativeTypeName("HWND")] IntPtr parentWnd)
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative2*, IntPtr, int>)(lpVtbl[3]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this), parentWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WindowHandle([NativeTypeName("HWND *")] IntPtr* hWnd)
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative2*, IntPtr*, int>)(lpVtbl[4]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this), hWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PreTranslateMessage([NativeTypeName("const MSG *")] MSG* message, [NativeTypeName("BOOL *")] int* result)
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative2*, MSG*, int*, int>)(lpVtbl[5]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this), message, result);
        }
    }
}
