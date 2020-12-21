// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACD-2F86-11D1-8E04-00C04FB9989A")]
    [NativeTypeName("struct AsyncIPipeLong : IUnknown")]
    public unsafe partial struct AsyncIPipeLong
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIPipeLong*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIPipeLong*, uint>)(lpVtbl[1]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIPipeLong*, uint>)(lpVtbl[2]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_Pull([NativeTypeName("ULONG")] uint cRequest)
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIPipeLong*, uint, int>)(lpVtbl[3]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this), cRequest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_Pull([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIPipeLong*, int*, uint*, int>)(lpVtbl[4]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this), buf, pcReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_Push([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIPipeLong*, int*, uint, int>)(lpVtbl[5]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this), buf, cSent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_Push()
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIPipeLong*, int>)(lpVtbl[6]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this));
        }
    }
}
