// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FB759DBA-6F4C-4C01-874E-19C8A05907F9")]
    [NativeTypeName("struct IDirectManipulationFrameInfoProvider : IUnknown")]
    public unsafe partial struct IDirectManipulationFrameInfoProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationFrameInfoProvider*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationFrameInfoProvider*, uint>)(lpVtbl[1]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationFrameInfoProvider*, uint>)(lpVtbl[2]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNextFrameInfo([NativeTypeName("ULONGLONG *")] ulong* time, [NativeTypeName("ULONGLONG *")] ulong* processTime, [NativeTypeName("ULONGLONG *")] ulong* compositionTime)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationFrameInfoProvider*, ulong*, ulong*, ulong*, int>)(lpVtbl[3]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this), time, processTime, compositionTime);
        }
    }
}
