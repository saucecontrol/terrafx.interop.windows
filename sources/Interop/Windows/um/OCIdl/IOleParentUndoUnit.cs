// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A1FAF330-EF97-11CE-9BC9-00AA00608E01")]
    [NativeTypeName("struct IOleParentUndoUnit : IOleUndoUnit")]
    public unsafe partial struct IOleParentUndoUnit
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, Guid*, void**, int>)(lpVtbl[0]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, uint>)(lpVtbl[1]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, uint>)(lpVtbl[2]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Do([NativeTypeName("IOleUndoManager *")] IOleUndoManager* pUndoManager)
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, IOleUndoManager*, int>)(lpVtbl[3]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUndoManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, ushort**, int>)(lpVtbl[4]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pBstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID)
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, Guid*, int*, int>)(lpVtbl[5]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pClsid, plID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnNextAdd()
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, int>)(lpVtbl[6]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU)
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, IOleParentUndoUnit*, int>)(lpVtbl[7]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pPUU);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU, [NativeTypeName("BOOL")] int fCommit)
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, IOleParentUndoUnit*, int, int>)(lpVtbl[8]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pPUU, fCommit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Add([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, IOleUndoUnit*, int>)(lpVtbl[9]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUU);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindUnit([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, IOleUndoUnit*, int>)(lpVtbl[10]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pUU);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParentState([NativeTypeName("DWORD *")] uint* pdwState)
        {
            return ((delegate* unmanaged[Stdcall]<IOleParentUndoUnit*, uint*, int>)(lpVtbl[11]))((IOleParentUndoUnit*)Unsafe.AsPointer(ref this), pdwState);
        }
    }
}
