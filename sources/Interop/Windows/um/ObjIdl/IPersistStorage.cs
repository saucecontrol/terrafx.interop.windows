// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010A-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IPersistStorage : IPersist")]
    public unsafe partial struct IPersistStorage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, Guid*, void**, int>)(lpVtbl[0]))((IPersistStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, uint>)(lpVtbl[1]))((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, uint>)(lpVtbl[2]))((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, Guid*, int>)(lpVtbl[3]))((IPersistStorage*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, int>)(lpVtbl[4]))((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitNew([NativeTypeName("IStorage *")] IStorage* pStg)
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, IStorage*, int>)(lpVtbl[5]))((IPersistStorage*)Unsafe.AsPointer(ref this), pStg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IStorage *")] IStorage* pStg)
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, IStorage*, int>)(lpVtbl[6]))((IPersistStorage*)Unsafe.AsPointer(ref this), pStg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IStorage *")] IStorage* pStgSave, [NativeTypeName("BOOL")] int fSameAsLoad)
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, IStorage*, int, int>)(lpVtbl[7]))((IPersistStorage*)Unsafe.AsPointer(ref this), pStgSave, fSameAsLoad);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted([NativeTypeName("IStorage *")] IStorage* pStgNew)
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, IStorage*, int>)(lpVtbl[8]))((IPersistStorage*)Unsafe.AsPointer(ref this), pStgNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HandsOffStorage()
        {
            return ((delegate* unmanaged[Stdcall]<IPersistStorage*, int>)(lpVtbl[9]))((IPersistStorage*)Unsafe.AsPointer(ref this));
        }
    }
}
