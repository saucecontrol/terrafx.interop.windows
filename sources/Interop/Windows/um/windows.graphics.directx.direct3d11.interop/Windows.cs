// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3d11", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateDirect3D11DeviceFromDXGIDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("IInspectable **")] IInspectable** graphicsDevice);

        [DllImport("d3d11", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateDirect3D11SurfaceFromDXGISurface([NativeTypeName("IDXGISurface *")] IDXGISurface* dgxiSurface, [NativeTypeName("IInspectable **")] IInspectable** graphicsSurface);

        public static readonly Guid IID_IDirect3DDxgiInterfaceAccess = new Guid(0xA9B3D012, 0x3DF2, 0x4EE3, 0xB8, 0xD1, 0x86, 0x95, 0xF4, 0x57, 0xD3, 0xC1);
    }
}
