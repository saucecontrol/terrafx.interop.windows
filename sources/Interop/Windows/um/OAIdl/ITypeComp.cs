// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020403-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeComp : IUnknown")]
    public unsafe partial struct ITypeComp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ITypeComp*, Guid*, void**, int>)(lpVtbl[0]))((ITypeComp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ITypeComp*, uint>)(lpVtbl[1]))((ITypeComp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ITypeComp*, uint>)(lpVtbl[2]))((ITypeComp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Bind([NativeTypeName("LPOLESTR")] ushort* szName, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("DESCKIND *")] DESCKIND* pDescKind, [NativeTypeName("BINDPTR *")] BINDPTR* pBindPtr)
        {
            return ((delegate* unmanaged[Stdcall]<ITypeComp*, ushort*, uint, ushort, ITypeInfo**, DESCKIND*, BINDPTR*, int>)(lpVtbl[3]))((ITypeComp*)Unsafe.AsPointer(ref this), szName, lHashVal, wFlags, ppTInfo, pDescKind, pBindPtr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BindType([NativeTypeName("LPOLESTR")] ushort* szName, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return ((delegate* unmanaged[Stdcall]<ITypeComp*, ushort*, uint, ITypeInfo**, ITypeComp**, int>)(lpVtbl[4]))((ITypeComp*)Unsafe.AsPointer(ref this), szName, lHashVal, ppTInfo, ppTComp);
        }
    }
}
