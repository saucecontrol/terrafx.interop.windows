// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C1D867D-C290-41C8-AE7E-34A98702E9A5")]
    [NativeTypeName("struct ID2D1PrintControl : IUnknown")]
    public unsafe partial struct ID2D1PrintControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, uint>)(lpVtbl[1]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, uint>)(lpVtbl[2]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPage([NativeTypeName("ID2D1CommandList *")] ID2D1CommandList* commandList, D2D_SIZE_F pageSize, [NativeTypeName("IStream *")] IStream* pagePrintTicketStream, [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, D2D_SIZE_F, IStream*, ulong*, ulong*, int>)(lpVtbl[3]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this), commandList, pageSize, pagePrintTicketStream, tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, int>)(lpVtbl[4]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
        }
    }
}
