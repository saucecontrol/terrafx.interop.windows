// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("31CE832E-4484-458B-8CCA-F4D7E3DB0B52")]
    [NativeTypeName("struct IVMRSurfaceAllocator : IUnknown")]
    public unsafe partial struct IVMRSurfaceAllocator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocator*, uint>)(lpVtbl[1]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocator*, uint>)(lpVtbl[2]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AllocateSurface([NativeTypeName("DWORD_PTR")] nuint dwUserID, [NativeTypeName("VMRALLOCATIONINFO *")] VMRALLOCATIONINFO* lpAllocInfo, [NativeTypeName("DWORD *")] uint* lpdwActualBuffers, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lplpSurface)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocator*, nuint, VMRALLOCATIONINFO*, uint*, IDirectDrawSurface7**, int>)(lpVtbl[3]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), dwUserID, lpAllocInfo, lpdwActualBuffers, lplpSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreeSurface([NativeTypeName("DWORD_PTR")] nuint dwID)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocator*, nuint, int>)(lpVtbl[4]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), dwID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PrepareSurface([NativeTypeName("DWORD_PTR")] nuint dwUserID, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* lpSurface, [NativeTypeName("DWORD")] uint dwSurfaceFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocator*, nuint, IDirectDrawSurface7*, uint, int>)(lpVtbl[5]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), dwUserID, lpSurface, dwSurfaceFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseNotify([NativeTypeName("IVMRSurfaceAllocatorNotify *")] IVMRSurfaceAllocatorNotify* lpIVMRSurfAllocNotify)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRSurfaceAllocator*, IVMRSurfaceAllocatorNotify*, int>)(lpVtbl[6]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), lpIVMRSurfAllocNotify);
        }
    }
}
