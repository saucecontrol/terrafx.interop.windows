// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("06B64F9E-7FDA-11D2-B4F2-00C04F797396")]
    [NativeTypeName("struct IEnumSpObjectTokens : IUnknown")]
    public unsafe partial struct IEnumSpObjectTokens
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSpObjectTokens*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSpObjectTokens*, uint>)(lpVtbl[1]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSpObjectTokens*, uint>)(lpVtbl[2]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("ISpObjectToken **")] ISpObjectToken** pelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSpObjectTokens*, uint, ISpObjectToken**, uint*, int>)(lpVtbl[3]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), celt, pelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSpObjectTokens*, uint, int>)(lpVtbl[4]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSpObjectTokens*, int>)(lpVtbl[5]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumSpObjectTokens **")] IEnumSpObjectTokens** ppEnum)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSpObjectTokens*, IEnumSpObjectTokens**, int>)(lpVtbl[6]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("ULONG")] uint Index, [NativeTypeName("ISpObjectToken **")] ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSpObjectTokens*, uint, ISpObjectToken**, int>)(lpVtbl[7]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), Index, ppToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("ULONG *")] uint* pCount)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumSpObjectTokens*, uint*, int>)(lpVtbl[8]))((IEnumSpObjectTokens*)Unsafe.AsPointer(ref this), pCount);
        }
    }
}
