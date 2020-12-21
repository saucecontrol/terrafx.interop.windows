// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000020-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IMultiQI : IUnknown")]
    public unsafe partial struct IMultiQI
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMultiQI*, Guid*, void**, int>)(lpVtbl[0]))((IMultiQI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMultiQI*, uint>)(lpVtbl[1]))((IMultiQI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMultiQI*, uint>)(lpVtbl[2]))((IMultiQI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryMultipleInterfaces([NativeTypeName("ULONG")] uint cMQIs, [NativeTypeName("MULTI_QI *")] MULTI_QI* pMQIs)
        {
            return ((delegate* unmanaged[Stdcall]<IMultiQI*, uint, MULTI_QI*, int>)(lpVtbl[3]))((IMultiQI*)Unsafe.AsPointer(ref this), cMQIs, pMQIs);
        }
    }
}
