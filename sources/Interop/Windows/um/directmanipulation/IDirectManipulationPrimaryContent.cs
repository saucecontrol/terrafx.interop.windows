// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C12851E4-1698-4625-B9B1-7CA3EC18630B")]
    [NativeTypeName("struct IDirectManipulationPrimaryContent : IUnknown")]
    public unsafe partial struct IDirectManipulationPrimaryContent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, uint>)(lpVtbl[1]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, uint>)(lpVtbl[2]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSnapInterval(DIRECTMANIPULATION_MOTION_TYPES motion, float interval, float offset)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, float, float, int>)(lpVtbl[3]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), motion, interval, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSnapPoints(DIRECTMANIPULATION_MOTION_TYPES motion, [NativeTypeName("const float *")] float* points, [NativeTypeName("DWORD")] uint pointCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, float*, uint, int>)(lpVtbl[4]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), motion, points, pointCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSnapType(DIRECTMANIPULATION_MOTION_TYPES motion, DIRECTMANIPULATION_SNAPPOINT_TYPE type)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_SNAPPOINT_TYPE, int>)(lpVtbl[5]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), motion, type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSnapCoordinate(DIRECTMANIPULATION_MOTION_TYPES motion, DIRECTMANIPULATION_SNAPPOINT_COORDINATE coordinate, float origin)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_SNAPPOINT_COORDINATE, float, int>)(lpVtbl[6]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), motion, coordinate, origin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoomBoundaries(float zoomMinimum, float zoomMaximum)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, float, float, int>)(lpVtbl[7]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), zoomMinimum, zoomMaximum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHorizontalAlignment(DIRECTMANIPULATION_HORIZONTALALIGNMENT alignment)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_HORIZONTALALIGNMENT, int>)(lpVtbl[8]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), alignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVerticalAlignment(DIRECTMANIPULATION_VERTICALALIGNMENT alignment)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_VERTICALALIGNMENT, int>)(lpVtbl[9]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), alignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInertiaEndTransform([NativeTypeName("float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, float*, uint, int>)(lpVtbl[10]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), matrix, pointCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCenterPoint([NativeTypeName("float *")] float* centerX, [NativeTypeName("float *")] float* centerY)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationPrimaryContent*, float*, float*, int>)(lpVtbl[11]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), centerX, centerY);
        }
    }
}
