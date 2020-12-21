// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("35DBF59E-E3F9-45B0-81E7-FE75F4145DC9")]
    [NativeTypeName("struct IDesktopWindowTargetInterop : IUnknown")]
    public unsafe partial struct IDesktopWindowTargetInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowTargetInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWindowTargetInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowTargetInterop*, uint>)(lpVtbl[1]))((IDesktopWindowTargetInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowTargetInterop*, uint>)(lpVtbl[2]))((IDesktopWindowTargetInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Hwnd([NativeTypeName("HWND *")] IntPtr* value)
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowTargetInterop*, IntPtr*, int>)(lpVtbl[3]))((IDesktopWindowTargetInterop*)Unsafe.AsPointer(ref this), value);
        }
    }
}
