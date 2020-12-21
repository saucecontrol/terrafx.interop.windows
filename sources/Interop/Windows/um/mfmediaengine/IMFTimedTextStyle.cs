// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09B2455D-B834-4F01-A347-9052E21C450E")]
    [NativeTypeName("struct IMFTimedTextStyle : IUnknown")]
    public unsafe partial struct IMFTimedTextStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint>)(lpVtbl[1]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint>)(lpVtbl[2]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, ushort**, int>)(lpVtbl[3]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsExternal()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int>)(lpVtbl[4]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("LPWSTR *")] ushort** fontFamily)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, ushort**, int>)(lpVtbl[5]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontSize([NativeTypeName("double *")] double* fontSize, [NativeTypeName("MF_TIMED_TEXT_UNIT_TYPE *")] MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[6]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), fontSize, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColor([NativeTypeName("MFARGB *")] MFARGB* color)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, MFARGB*, int>)(lpVtbl[7]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor([NativeTypeName("MFARGB *")] MFARGB* bgColor)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, MFARGB*, int>)(lpVtbl[8]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), bgColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetShowBackgroundAlways([NativeTypeName("BOOL *")] int* showBackgroundAlways)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)(lpVtbl[9]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), showBackgroundAlways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontStyle([NativeTypeName("MF_TIMED_TEXT_FONT_STYLE *")] MF_TIMED_TEXT_FONT_STYLE* fontStyle)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, MF_TIMED_TEXT_FONT_STYLE*, int>)(lpVtbl[10]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), fontStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBold([NativeTypeName("BOOL *")] int* bold)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)(lpVtbl[11]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), bold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRightToLeft([NativeTypeName("BOOL *")] int* rightToLeft)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)(lpVtbl[12]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), rightToLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextAlignment([NativeTypeName("MF_TIMED_TEXT_ALIGNMENT *")] MF_TIMED_TEXT_ALIGNMENT* textAlign)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, MF_TIMED_TEXT_ALIGNMENT*, int>)(lpVtbl[13]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), textAlign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextDecoration([NativeTypeName("DWORD *")] uint* textDecoration)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint*, int>)(lpVtbl[14]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), textDecoration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextOutline([NativeTypeName("MFARGB *")] MFARGB* color, [NativeTypeName("double *")] double* thickness, [NativeTypeName("double *")] double* blurRadius, [NativeTypeName("MF_TIMED_TEXT_UNIT_TYPE *")] MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, MFARGB*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[15]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), color, thickness, blurRadius, unitType);
        }
    }
}
