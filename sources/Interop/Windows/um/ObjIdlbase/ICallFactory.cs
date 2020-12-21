// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1C733A30-2A1C-11CE-ADE5-00AA0044773D")]
    [NativeTypeName("struct ICallFactory : IUnknown")]
    public unsafe partial struct ICallFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ICallFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICallFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ICallFactory*, uint>)(lpVtbl[1]))((ICallFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ICallFactory*, uint>)(lpVtbl[2]))((ICallFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCall([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* pCtrlUnk, [NativeTypeName("const IID &")] Guid* riid2, [NativeTypeName("IUnknown **")] IUnknown** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<ICallFactory*, Guid*, IUnknown*, Guid*, IUnknown**, int>)(lpVtbl[3]))((ICallFactory*)Unsafe.AsPointer(ref this), riid, pCtrlUnk, riid2, ppv);
        }
    }
}
