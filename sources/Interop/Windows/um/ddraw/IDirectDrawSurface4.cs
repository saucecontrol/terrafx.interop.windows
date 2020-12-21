// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDrawSurface4 : IUnknown")]
    public unsafe partial struct IDirectDrawSurface4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint>)(lpVtbl[1]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint>)(lpVtbl[2]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, IDirectDrawSurface4*, int>)(lpVtbl[3]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, RECT*, int>)(lpVtbl[4]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, RECT*, IDirectDrawSurface4*, RECT*, uint, DDBLTFX*, int>)(lpVtbl[5]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDBLTBATCH*, uint, uint, int>)(lpVtbl[6]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, uint, IDirectDrawSurface4*, RECT*, uint, int>)(lpVtbl[7]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, IDirectDrawSurface4*, int>)(lpVtbl[8]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
#if !NETSTANDARD2_0
        public int EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK2")] delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int> param1)
#else
        public int EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK2")] delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int> param1)
#endif
        {
#if !NETSTANDARD2_0
            return ((delegate* unmanaged<IDirectDrawSurface4*, void*, delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int>, int>)(lpVtbl[9]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
#else
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, void*, delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int>, int>)(lpVtbl[9]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
#if !NETSTANDARD2_0
        public int EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK2")] delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int> param2)
#else
        public int EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK2")] delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int> param2)
#endif
        {
#if !NETSTANDARD2_0
            return ((delegate* unmanaged<IDirectDrawSurface4*, uint, void*, delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int>, int>)(lpVtbl[10]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2);
#else
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, void*, delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, int>, int>)(lpVtbl[10]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flip([NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, IDirectDrawSurface4*, uint, int>)(lpVtbl[11]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttachedSurface([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDSCAPS2*, IDirectDrawSurface4**, int>)(lpVtbl[12]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBltStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, int>)(lpVtbl[13]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDSCAPS2*, int>)(lpVtbl[14]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, IDirectDrawClipper**, int>)(lpVtbl[15]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, DDCOLORKEY*, int>)(lpVtbl[16]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("HDC *")] IntPtr* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, IntPtr*, int>)(lpVtbl[17]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlipStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, int>)(lpVtbl[18]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, int*, int*, int>)(lpVtbl[19]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, IDirectDrawPalette**, int>)(lpVtbl[20]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDPIXELFORMAT*, int>)(lpVtbl[21]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDSURFACEDESC2*, int>)(lpVtbl[22]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, IDirectDraw*, DDSURFACEDESC2*, int>)(lpVtbl[23]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsLost()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, int>)(lpVtbl[24]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("HANDLE")] IntPtr param3)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, RECT*, DDSURFACEDESC2*, uint, IntPtr, int>)(lpVtbl[25]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("HDC")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, IntPtr, int>)(lpVtbl[26]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Restore()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, int>)(lpVtbl[27]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, IDirectDrawClipper*, int>)(lpVtbl[28]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, DDCOLORKEY*, int>)(lpVtbl[29]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, int, int, int>)(lpVtbl[30]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, IDirectDrawPalette*, int>)(lpVtbl[31]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock([NativeTypeName("LPRECT")] RECT* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, RECT*, int>)(lpVtbl[32]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, RECT*, IDirectDrawSurface4*, RECT*, uint, DDOVERLAYFX*, int>)(lpVtbl[33]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, int>)(lpVtbl[34]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, IDirectDrawSurface4*, int>)(lpVtbl[35]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDDInterface([NativeTypeName("LPVOID *")] void** param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, void**, int>)(lpVtbl[36]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PageLock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, int>)(lpVtbl[37]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PageUnlock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint, int>)(lpVtbl[38]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, DDSURFACEDESC2*, uint, int>)(lpVtbl[39]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, Guid*, void*, uint, uint, int>)(lpVtbl[40]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, Guid*, void*, uint*, int>)(lpVtbl[41]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] Guid* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, Guid*, int>)(lpVtbl[42]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUniquenessValue([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, uint*, int>)(lpVtbl[43]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChangeUniquenessValue()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface4*, int>)(lpVtbl[44]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
        }
    }
}
