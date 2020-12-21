// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("948C5AD3-C58D-11D0-9C0B-00C04FC99C8E")]
    [NativeTypeName("struct IXMLError : IUnknown")]
    public unsafe partial struct IXMLError
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IXMLError*, Guid*, void**, int>)(lpVtbl[0]))((IXMLError*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IXMLError*, uint>)(lpVtbl[1]))((IXMLError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IXMLError*, uint>)(lpVtbl[2]))((IXMLError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetErrorInfo([NativeTypeName("XML_ERROR *")] XML_ERROR* pErrorReturn)
        {
            return ((delegate* unmanaged[Stdcall]<IXMLError*, XML_ERROR*, int>)(lpVtbl[3]))((IXMLError*)Unsafe.AsPointer(ref this), pErrorReturn);
        }
    }
}
