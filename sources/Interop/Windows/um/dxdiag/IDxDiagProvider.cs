// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9C6B4CB0-23F8-49CC-A3ED-45A55000A6D2")]
    public unsafe partial struct IDxDiagProvider
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxDiagProvider*, Guid*, void**, int>)(lpVtbl[0]))((IDxDiagProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxDiagProvider*, uint>)(lpVtbl[1]))((IDxDiagProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxDiagProvider*, uint>)(lpVtbl[2]))((IDxDiagProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("DXDIAG_INIT_PARAMS *")] DXDIAG_INIT_PARAMS* pParams)
        {
            return ((delegate* stdcall<IDxDiagProvider*, DXDIAG_INIT_PARAMS*, int>)(lpVtbl[3]))((IDxDiagProvider*)Unsafe.AsPointer(ref this), pParams);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRootContainer([NativeTypeName("IDxDiagContainer **")] IDxDiagContainer** ppInstance)
        {
            return ((delegate* stdcall<IDxDiagProvider*, IDxDiagContainer**, int>)(lpVtbl[4]))((IDxDiagProvider*)Unsafe.AsPointer(ref this), ppInstance);
        }
    }
}
