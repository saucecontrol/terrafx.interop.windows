// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86892-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IEnumPins : IUnknown")]
    public unsafe partial struct IEnumPins
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumPins*, Guid*, void**, int>)(lpVtbl[0]))((IEnumPins*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumPins*, uint>)(lpVtbl[1]))((IEnumPins*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumPins*, uint>)(lpVtbl[2]))((IEnumPins*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cPins, [NativeTypeName("IPin **")] IPin** ppPins, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumPins*, uint, IPin**, uint*, int>)(lpVtbl[3]))((IEnumPins*)Unsafe.AsPointer(ref this), cPins, ppPins, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cPins)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumPins*, uint, int>)(lpVtbl[4]))((IEnumPins*)Unsafe.AsPointer(ref this), cPins);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumPins*, int>)(lpVtbl[5]))((IEnumPins*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumPins **")] IEnumPins** ppEnum)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumPins*, IEnumPins**, int>)(lpVtbl[6]))((IEnumPins*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
