// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5EFF4AEF-8487-11D2-961C-00C04F8EE628")]
    [NativeTypeName("struct ISpNotifySource : IUnknown")]
    public unsafe partial struct ISpNotifySource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, Guid*, void**, int>)(lpVtbl[0]))((ISpNotifySource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, uint>)(lpVtbl[1]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, uint>)(lpVtbl[2]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifySink([NativeTypeName("ISpNotifySink *")] ISpNotifySink* pNotifySink)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWindowMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, IntPtr, uint, nuint, nint, int>)(lpVtbl[4]))((ISpNotifySource*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
#if !NETSTANDARD2_0
        public int SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<nuint, nint, void>* pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
#else
        public int SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged[Stdcall]<nuint, nint, void>* pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
#endif
        {
#if !NETSTANDARD2_0
            return ((delegate* unmanaged<ISpNotifySource*, delegate* unmanaged<nuint, nint, void>*, nuint, nint, int>)(lpVtbl[5]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
#else
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, delegate* unmanaged[Stdcall]<nuint, nint, void>*, nuint, nint, int>)(lpVtbl[5]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackInterface([NativeTypeName("ISpNotifyCallback *")] ISpNotifyCallback* pSpCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, ISpNotifyCallback*, nuint, nint, int>)(lpVtbl[6]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWin32Event()
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, int>)(lpVtbl[7]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, uint, int>)(lpVtbl[8]))((ISpNotifySource*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr GetNotifyEventHandle()
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifySource*, IntPtr>)(lpVtbl[9]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
        }
    }
}
