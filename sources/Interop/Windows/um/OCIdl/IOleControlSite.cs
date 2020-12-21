// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B289-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IOleControlSite : IUnknown")]
    public unsafe partial struct IOleControlSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, Guid*, void**, int>)(lpVtbl[0]))((IOleControlSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, uint>)(lpVtbl[1]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, uint>)(lpVtbl[2]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnControlInfoChanged()
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, int>)(lpVtbl[3]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockInPlaceActive([NativeTypeName("BOOL")] int fLock)
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, int, int>)(lpVtbl[4]))((IOleControlSite*)Unsafe.AsPointer(ref this), fLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtendedControl([NativeTypeName("IDispatch **")] IDispatch** ppDisp)
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, IDispatch**, int>)(lpVtbl[5]))((IOleControlSite*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TransformCoords([NativeTypeName("POINTL *")] POINTL* pPtlHimetric, [NativeTypeName("POINTF *")] POINTF* pPtfContainer, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, POINTL*, POINTF*, uint, int>)(lpVtbl[6]))((IOleControlSite*)Unsafe.AsPointer(ref this), pPtlHimetric, pPtfContainer, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAccelerator([NativeTypeName("MSG *")] MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, MSG*, uint, int>)(lpVtbl[7]))((IOleControlSite*)Unsafe.AsPointer(ref this), pMsg, grfModifiers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnFocus([NativeTypeName("BOOL")] int fGotFocus)
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, int, int>)(lpVtbl[8]))((IOleControlSite*)Unsafe.AsPointer(ref this), fGotFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowPropertyFrame()
        {
            return ((delegate* unmanaged[Stdcall]<IOleControlSite*, int>)(lpVtbl[9]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }
    }
}
