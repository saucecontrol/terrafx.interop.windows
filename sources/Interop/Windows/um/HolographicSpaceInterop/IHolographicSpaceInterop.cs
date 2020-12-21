// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HolographicSpaceInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C4EE536-6A98-4B86-A170-587013D6FD4B")]
    [NativeTypeName("struct IHolographicSpaceInterop : IInspectable")]
    public unsafe partial struct IHolographicSpaceInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IHolographicSpaceInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IHolographicSpaceInterop*, uint>)(lpVtbl[1]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IHolographicSpaceInterop*, uint>)(lpVtbl[2]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged[Stdcall]<IHolographicSpaceInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged[Stdcall]<IHolographicSpaceInterop*, IntPtr*, int>)(lpVtbl[4]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IHolographicSpaceInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateForWindow([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** holographicSpace)
        {
            return ((delegate* unmanaged[Stdcall]<IHolographicSpaceInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), window, riid, holographicSpace);
        }
    }
}
