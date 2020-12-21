// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("652D5C71-FE60-4A98-BE70-E5F21291E7F1")]
    [NativeTypeName("struct IDirectManipulationDeferContactService : IUnknown")]
    public unsafe partial struct IDirectManipulationDeferContactService
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDeferContactService*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDeferContactService*, uint>)(lpVtbl[1]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDeferContactService*, uint>)(lpVtbl[2]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeferContact([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint timeout)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDeferContactService*, uint, uint, int>)(lpVtbl[3]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), pointerId, timeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelContact([NativeTypeName("UINT32")] uint pointerId)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDeferContactService*, uint, int>)(lpVtbl[4]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), pointerId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelDeferral([NativeTypeName("UINT32")] uint pointerId)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationDeferContactService*, uint, int>)(lpVtbl[5]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), pointerId);
        }
    }
}
