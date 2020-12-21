// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RadialControllerInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D577EFF-4CEE-11E6-B535-001BDC06AB3B")]
    [NativeTypeName("struct IRadialControllerIndependentInputSourceInterop : IInspectable")]
    public unsafe partial struct IRadialControllerIndependentInputSourceInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IRadialControllerIndependentInputSourceInterop*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IRadialControllerIndependentInputSourceInterop*, uint>)(lpVtbl[1]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IRadialControllerIndependentInputSourceInterop*, uint>)(lpVtbl[2]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged[Stdcall]<IRadialControllerIndependentInputSourceInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged[Stdcall]<IRadialControllerIndependentInputSourceInterop*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IRadialControllerIndependentInputSourceInterop*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateForWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IRadialControllerIndependentInputSourceInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), hwnd, riid, ppv);
        }
    }
}
