// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B28D-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IPropertyPage : IUnknown")]
    public unsafe partial struct IPropertyPage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyPage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, uint>)(lpVtbl[1]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, uint>)(lpVtbl[2]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPageSite([NativeTypeName("IPropertyPageSite *")] IPropertyPageSite* pPageSite)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, IPropertyPageSite*, int>)(lpVtbl[3]))((IPropertyPage*)Unsafe.AsPointer(ref this), pPageSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("HWND")] IntPtr hWndParent, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("BOOL")] int bModal)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, IntPtr, RECT*, int, int>)(lpVtbl[4]))((IPropertyPage*)Unsafe.AsPointer(ref this), hWndParent, pRect, bModal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, int>)(lpVtbl[5]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPageInfo([NativeTypeName("PROPPAGEINFO *")] PROPPAGEINFO* pPageInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, PROPPAGEINFO*, int>)(lpVtbl[6]))((IPropertyPage*)Unsafe.AsPointer(ref this), pPageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetObjects([NativeTypeName("ULONG")] uint cObjects, [NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, uint, IUnknown**, int>)(lpVtbl[7]))((IPropertyPage*)Unsafe.AsPointer(ref this), cObjects, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("UINT")] uint nCmdShow)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, uint, int>)(lpVtbl[8]))((IPropertyPage*)Unsafe.AsPointer(ref this), nCmdShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Move([NativeTypeName("LPCRECT")] RECT* pRect)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, RECT*, int>)(lpVtbl[9]))((IPropertyPage*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsPageDirty()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, int>)(lpVtbl[10]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Apply()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, int>)(lpVtbl[11]))((IPropertyPage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Help([NativeTypeName("LPCOLESTR")] ushort* pszHelpDir)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, ushort*, int>)(lpVtbl[12]))((IPropertyPage*)Unsafe.AsPointer(ref this), pszHelpDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAccelerator([NativeTypeName("MSG *")] MSG* pMsg)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyPage*, MSG*, int>)(lpVtbl[13]))((IPropertyPage*)Unsafe.AsPointer(ref this), pMsg);
        }
    }
}
