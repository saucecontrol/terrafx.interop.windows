// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ACA16614-5D3D-11D2-960E-00C04F8EE628")]
    [NativeTypeName("struct ISpNotifyTranslator : ISpNotifySink")]
    public unsafe partial struct ISpNotifyTranslator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, Guid*, void**, int>)(lpVtbl[0]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, uint>)(lpVtbl[1]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, uint>)(lpVtbl[2]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Notify()
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, int>)(lpVtbl[3]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitWindowMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, IntPtr, uint, nuint, nint, int>)(lpVtbl[4]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
#if !NETSTANDARD2_0
        public int InitCallback([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<nuint, nint, void>* pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
#else
        public int InitCallback([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged[Stdcall]<nuint, nint, void>* pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
#endif
        {
#if !NETSTANDARD2_0
            return ((delegate* unmanaged<ISpNotifyTranslator*, delegate* unmanaged<nuint, nint, void>*, nuint, nint, int>)(lpVtbl[5]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
#else
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, delegate* unmanaged[Stdcall]<nuint, nint, void>*, nuint, nint, int>)(lpVtbl[5]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitSpNotifyCallback([NativeTypeName("ISpNotifyCallback *")] ISpNotifyCallback* pSpCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, ISpNotifyCallback*, nuint, nint, int>)(lpVtbl[6]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitWin32Event([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("BOOL")] int fCloseHandleOnRelease)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, IntPtr, int, int>)(lpVtbl[7]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), hEvent, fCloseHandleOnRelease);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Wait([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, uint, int>)(lpVtbl[8]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr GetEventHandle()
        {
            return ((delegate* unmanaged[Stdcall]<ISpNotifyTranslator*, IntPtr>)(lpVtbl[9]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this));
        }
    }
}
