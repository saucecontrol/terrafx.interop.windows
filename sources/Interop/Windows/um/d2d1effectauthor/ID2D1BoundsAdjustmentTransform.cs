// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90F732E2-5092-4606-A819-8651970BACCD")]
    [NativeTypeName("struct ID2D1BoundsAdjustmentTransform : ID2D1TransformNode")]
    public unsafe partial struct ID2D1BoundsAdjustmentTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, uint>)(lpVtbl[1]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, uint>)(lpVtbl[2]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, uint>)(lpVtbl[3]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetOutputBounds([NativeTypeName("const D2D1_RECT_L *")] RECT* outputBounds)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, RECT*, void>)(lpVtbl[4]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), outputBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetOutputBounds([NativeTypeName("D2D1_RECT_L *")] RECT* outputBounds)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BoundsAdjustmentTransform*, RECT*, void>)(lpVtbl[5]))((ID2D1BoundsAdjustmentTransform*)Unsafe.AsPointer(ref this), outputBounds);
        }
    }
}
