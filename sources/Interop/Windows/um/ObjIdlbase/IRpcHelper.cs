// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000149-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IRpcHelper : IUnknown")]
    public unsafe partial struct IRpcHelper
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IRpcHelper*, Guid*, void**, int>)(lpVtbl[0]))((IRpcHelper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IRpcHelper*, uint>)(lpVtbl[1]))((IRpcHelper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IRpcHelper*, uint>)(lpVtbl[2]))((IRpcHelper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDCOMProtocolVersion([NativeTypeName("DWORD *")] uint* pComVersion)
        {
            return ((delegate* unmanaged[Stdcall]<IRpcHelper*, uint*, int>)(lpVtbl[3]))((IRpcHelper*)Unsafe.AsPointer(ref this), pComVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIIDFromOBJREF([NativeTypeName("void *")] void* pObjRef, [NativeTypeName("IID **")] Guid** piid)
        {
            return ((delegate* unmanaged[Stdcall]<IRpcHelper*, void*, Guid**, int>)(lpVtbl[4]))((IRpcHelper*)Unsafe.AsPointer(ref this), pObjRef, piid);
        }
    }
}
