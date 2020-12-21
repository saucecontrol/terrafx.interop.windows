// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("537A0825-0387-4EFA-B62F-71EB1F085A7E")]
    [NativeTypeName("struct IDirectManipulationCompositor : IUnknown")]
    public unsafe partial struct IDirectManipulationCompositor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationCompositor*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationCompositor*, uint>)(lpVtbl[1]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationCompositor*, uint>)(lpVtbl[2]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddContent([NativeTypeName("IDirectManipulationContent *")] IDirectManipulationContent* content, [NativeTypeName("IUnknown *")] IUnknown* device, [NativeTypeName("IUnknown *")] IUnknown* parentVisual, [NativeTypeName("IUnknown *")] IUnknown* childVisual)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationCompositor*, IDirectManipulationContent*, IUnknown*, IUnknown*, IUnknown*, int>)(lpVtbl[3]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this), content, device, parentVisual, childVisual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveContent([NativeTypeName("IDirectManipulationContent *")] IDirectManipulationContent* content)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationCompositor*, IDirectManipulationContent*, int>)(lpVtbl[4]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUpdateManager([NativeTypeName("IDirectManipulationUpdateManager *")] IDirectManipulationUpdateManager* updateManager)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationCompositor*, IDirectManipulationUpdateManager*, int>)(lpVtbl[5]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this), updateManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationCompositor*, int>)(lpVtbl[6]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this));
        }
    }
}
