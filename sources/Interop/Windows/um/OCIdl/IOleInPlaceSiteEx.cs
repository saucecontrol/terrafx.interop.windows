// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9C2CAD80-3424-11CF-B670-00AA004CD6D8")]
    [NativeTypeName("struct IOleInPlaceSiteEx : IOleInPlaceSite")]
    public unsafe partial struct IOleInPlaceSiteEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, uint>)(lpVtbl[1]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, uint>)(lpVtbl[2]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int, int>)(lpVtbl[4]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanInPlaceActivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int>)(lpVtbl[5]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int>)(lpVtbl[6]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUIActivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int>)(lpVtbl[7]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindowContext([NativeTypeName("IOleInPlaceFrame **")] IOleInPlaceFrame** ppFrame, [NativeTypeName("IOleInPlaceUIWindow **")] IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OLEINPLACEFRAMEINFO*, int>)(lpVtbl[8]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Scroll(SIZE scrollExtant)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, SIZE, int>)(lpVtbl[9]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), scrollExtant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUIDeactivate([NativeTypeName("BOOL")] int fUndoable)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int, int>)(lpVtbl[10]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fUndoable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int>)(lpVtbl[11]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardUndoState()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int>)(lpVtbl[12]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeactivateAndUndo()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int>)(lpVtbl[13]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, RECT*, int>)(lpVtbl[14]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), lprcPosRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceActivateEx([NativeTypeName("BOOL *")] int* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int*, uint, int>)(lpVtbl[15]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), pfNoRedraw, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInPlaceDeactivateEx([NativeTypeName("BOOL")] int fNoRedraw)
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int, int>)(lpVtbl[16]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this), fNoRedraw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestUIActivate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleInPlaceSiteEx*, int>)(lpVtbl[17]))((IOleInPlaceSiteEx*)Unsafe.AsPointer(ref this));
        }
    }
}
