// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CE704FE7-E71E-41FB-BAA2-C4403E1182F5")]
    [NativeTypeName("struct IVMRImagePresenter : IUnknown")]
    public unsafe partial struct IVMRImagePresenter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImagePresenter*, Guid*, void**, int>)(lpVtbl[0]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImagePresenter*, uint>)(lpVtbl[1]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImagePresenter*, uint>)(lpVtbl[2]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartPresenting([NativeTypeName("DWORD_PTR")] nuint dwUserID)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImagePresenter*, nuint, int>)(lpVtbl[3]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this), dwUserID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopPresenting([NativeTypeName("DWORD_PTR")] nuint dwUserID)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImagePresenter*, nuint, int>)(lpVtbl[4]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this), dwUserID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PresentImage([NativeTypeName("DWORD_PTR")] nuint dwUserID, [NativeTypeName("VMRPRESENTATIONINFO *")] VMRPRESENTATIONINFO* lpPresInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRImagePresenter*, nuint, VMRPRESENTATIONINFO*, int>)(lpVtbl[5]))((IVMRImagePresenter*)Unsafe.AsPointer(ref this), dwUserID, lpPresInfo);
        }
    }
}
