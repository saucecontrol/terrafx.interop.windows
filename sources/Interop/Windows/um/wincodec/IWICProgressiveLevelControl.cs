// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
    [NativeTypeName("struct IWICProgressiveLevelControl : IUnknown")]
    public unsafe partial struct IWICProgressiveLevelControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, Guid*, void**, int>)(lpVtbl[0]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint>)(lpVtbl[1]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint>)(lpVtbl[2]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLevelCount([NativeTypeName("UINT *")] uint* pcLevels)
        {
            return ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint*, int>)(lpVtbl[3]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pcLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLevel([NativeTypeName("UINT *")] uint* pnLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint*, int>)(lpVtbl[4]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pnLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLevel([NativeTypeName("UINT")] uint nLevel)
        {
            return ((delegate* unmanaged[Stdcall]<IWICProgressiveLevelControl*, uint, int>)(lpVtbl[5]))((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), nLevel);
        }
    }
}
