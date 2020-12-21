// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000013B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumSTATPROPSETSTG : IUnknown")]
    public unsafe partial struct IEnumSTATPROPSETSTG
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSTATPROPSETSTG*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSTATPROPSETSTG*, uint>)(lpVtbl[1]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSTATPROPSETSTG*, uint>)(lpVtbl[2]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("STATPROPSETSTG *")] STATPROPSETSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSTATPROPSETSTG*, uint, STATPROPSETSTG*, uint*, int>)(lpVtbl[3]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSTATPROPSETSTG*, uint, int>)(lpVtbl[4]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSTATPROPSETSTG*, int>)(lpVtbl[5]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumSTATPROPSETSTG **")] IEnumSTATPROPSETSTG** ppenum)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSTATPROPSETSTG*, IEnumSTATPROPSETSTG**, int>)(lpVtbl[6]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
