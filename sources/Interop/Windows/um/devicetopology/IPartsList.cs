// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6DAA848C-5EB0-45CC-AEA5-998A2CDA1FFB")]
    [NativeTypeName("struct IPartsList : IUnknown")]
    public unsafe partial struct IPartsList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPartsList*, Guid*, void**, int>)(lpVtbl[0]))((IPartsList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPartsList*, uint>)(lpVtbl[1]))((IPartsList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPartsList*, uint>)(lpVtbl[2]))((IPartsList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged[Stdcall]<IPartsList*, uint*, int>)(lpVtbl[3]))((IPartsList*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPart([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IPart **")] IPart** ppPart)
        {
            return ((delegate* unmanaged[Stdcall]<IPartsList*, uint, IPart**, int>)(lpVtbl[4]))((IPartsList*)Unsafe.AsPointer(ref this), nIndex, ppPart);
        }
    }
}
