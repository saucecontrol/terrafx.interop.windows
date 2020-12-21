// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VARIANT
    {
        [NativeTypeName("tagVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:470:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref ushort vt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.vt, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous))->vt;
#endif
            }
        }

        public unsafe ref ushort wReserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved1, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous))->wReserved1;
#endif
            }
        }

        public unsafe ref ushort wReserved2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved2, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous))->wReserved2;
#endif
            }
        }

        public unsafe ref ushort wReserved3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved3, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous))->wReserved3;
#endif
            }
        }

        public unsafe ref long llVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.llVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->llVal;
#endif
            }
        }

        public unsafe ref int lVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.lVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->lVal;
#endif
            }
        }

        public unsafe ref byte bVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.bVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->bVal;
#endif
            }
        }

        public unsafe ref short iVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.iVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->iVal;
#endif
            }
        }

        public unsafe ref float fltVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.fltVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->fltVal;
#endif
            }
        }

        public unsafe ref double dblVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.dblVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->dblVal;
#endif
            }
        }

        public unsafe ref short boolVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.boolVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->boolVal;
#endif
            }
        }

        public unsafe ref short __OBSOLETE__VARIANT_BOOL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.__OBSOLETE__VARIANT_BOOL, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->__OBSOLETE__VARIANT_BOOL;
#endif
            }
        }

        public unsafe ref int scode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.scode, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->scode;
#endif
            }
        }

        public unsafe ref CY cyVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cyVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cyVal;
#endif
            }
        }

        public unsafe ref double date
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.date, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->date;
#endif
            }
        }

        public unsafe ref ushort* bstrVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->bstrVal;
            }
        }

        public unsafe ref IUnknown* punkVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->punkVal;
            }
        }

        public unsafe ref IDispatch* pdispVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pdispVal;
            }
        }

        public unsafe ref SAFEARRAY* parray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->parray;
            }
        }

        public unsafe ref byte* pbVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pbVal;
            }
        }

        public unsafe ref short* piVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->piVal;
            }
        }

        public unsafe ref int* plVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->plVal;
            }
        }

        public unsafe ref long* pllVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pllVal;
            }
        }

        public unsafe ref float* pfltVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pfltVal;
            }
        }

        public unsafe ref double* pdblVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pdblVal;
            }
        }

        public unsafe ref short* pboolVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pboolVal;
            }
        }

        public unsafe ref short* __OBSOLETE__VARIANT_PBOOL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->__OBSOLETE__VARIANT_PBOOL;
            }
        }

        public unsafe ref int* pscode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pscode;
            }
        }

        public unsafe ref CY* pcyVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pcyVal;
            }
        }

        public unsafe ref double* pdate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pdate;
            }
        }

        public unsafe ref ushort** pbstrVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pbstrVal;
            }
        }

        public unsafe ref IUnknown** ppunkVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->ppunkVal;
            }
        }

        public unsafe ref IDispatch** ppdispVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->ppdispVal;
            }
        }

        public unsafe ref SAFEARRAY** pparray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pparray;
            }
        }

        public unsafe ref VARIANT* pvarVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pvarVal;
            }
        }

        public unsafe ref void* byref
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->byref;
            }
        }

        public unsafe ref sbyte cVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cVal;
#endif
            }
        }

        public unsafe ref ushort uiVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.uiVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->uiVal;
#endif
            }
        }

        public unsafe ref uint ulVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.ulVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->ulVal;
#endif
            }
        }

        public unsafe ref ulong ullVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.ullVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->ullVal;
#endif
            }
        }

        public unsafe ref int intVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.intVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->intVal;
#endif
            }
        }

        public unsafe ref uint uintVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.uintVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->uintVal;
#endif
            }
        }

        public unsafe ref DECIMAL* pdecVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pdecVal;
            }
        }

        public unsafe ref sbyte* pcVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pcVal;
            }
        }

        public unsafe ref ushort* puiVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->puiVal;
            }
        }

        public unsafe ref uint* pulVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pulVal;
            }
        }

        public unsafe ref ulong* pullVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pullVal;
            }
        }

        public unsafe ref int* pintVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pintVal;
            }
        }

        public unsafe ref uint* puintVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->puintVal;
            }
        }

        public unsafe ref void* pvRecord
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous.Anonymous))->pvRecord;
            }
        }

        public unsafe ref IRecordInfo* pRecInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous.Anonymous))->pRecInfo;
            }
        }

        public unsafe ref DECIMAL decVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.decVal, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->decVal;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("tagVARIANT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:472:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            public DECIMAL decVal;

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("VARTYPE")]
                public ushort vt;

                [NativeTypeName("WORD")]
                public ushort wReserved1;

                [NativeTypeName("WORD")]
                public ushort wReserved2;

                [NativeTypeName("WORD")]
                public ushort wReserved3;

                [NativeTypeName("tagVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:478:13)")]
                public _Anonymous_e__Union Anonymous;

                [StructLayout(LayoutKind.Explicit)]
                public unsafe partial struct _Anonymous_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("LONGLONG")]
                    public long llVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LONG")]
                    public int lVal;

                    [FieldOffset(0)]
                    [NativeTypeName("BYTE")]
                    public byte bVal;

                    [FieldOffset(0)]
                    [NativeTypeName("SHORT")]
                    public short iVal;

                    [FieldOffset(0)]
                    [NativeTypeName("FLOAT")]
                    public float fltVal;

                    [FieldOffset(0)]
                    [NativeTypeName("DOUBLE")]
                    public double dblVal;

                    [FieldOffset(0)]
                    [NativeTypeName("VARIANT_BOOL")]
                    public short boolVal;

                    [FieldOffset(0)]
                    [NativeTypeName("VARIANT_BOOL")]
                    public short __OBSOLETE__VARIANT_BOOL;

                    [FieldOffset(0)]
                    [NativeTypeName("SCODE")]
                    public int scode;

                    [FieldOffset(0)]
                    public CY cyVal;

                    [FieldOffset(0)]
                    [NativeTypeName("DATE")]
                    public double date;

                    [FieldOffset(0)]
                    [NativeTypeName("BSTR")]
                    public ushort* bstrVal;

                    [FieldOffset(0)]
                    [NativeTypeName("IUnknown *")]
                    public IUnknown* punkVal;

                    [FieldOffset(0)]
                    [NativeTypeName("IDispatch *")]
                    public IDispatch* pdispVal;

                    [FieldOffset(0)]
                    [NativeTypeName("SAFEARRAY *")]
                    public SAFEARRAY* parray;

                    [FieldOffset(0)]
                    [NativeTypeName("BYTE *")]
                    public byte* pbVal;

                    [FieldOffset(0)]
                    [NativeTypeName("SHORT *")]
                    public short* piVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LONG *")]
                    public int* plVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LONGLONG *")]
                    public long* pllVal;

                    [FieldOffset(0)]
                    [NativeTypeName("FLOAT *")]
                    public float* pfltVal;

                    [FieldOffset(0)]
                    [NativeTypeName("DOUBLE *")]
                    public double* pdblVal;

                    [FieldOffset(0)]
                    [NativeTypeName("VARIANT_BOOL *")]
                    public short* pboolVal;

                    [FieldOffset(0)]
                    [NativeTypeName("VARIANT_BOOL *")]
                    public short* __OBSOLETE__VARIANT_PBOOL;

                    [FieldOffset(0)]
                    [NativeTypeName("SCODE *")]
                    public int* pscode;

                    [FieldOffset(0)]
                    [NativeTypeName("CY *")]
                    public CY* pcyVal;

                    [FieldOffset(0)]
                    [NativeTypeName("DATE *")]
                    public double* pdate;

                    [FieldOffset(0)]
                    [NativeTypeName("BSTR *")]
                    public ushort** pbstrVal;

                    [FieldOffset(0)]
                    [NativeTypeName("IUnknown **")]
                    public IUnknown** ppunkVal;

                    [FieldOffset(0)]
                    [NativeTypeName("IDispatch **")]
                    public IDispatch** ppdispVal;

                    [FieldOffset(0)]
                    [NativeTypeName("SAFEARRAY **")]
                    public SAFEARRAY** pparray;

                    [FieldOffset(0)]
                    [NativeTypeName("VARIANT *")]
                    public VARIANT* pvarVal;

                    [FieldOffset(0)]
                    [NativeTypeName("PVOID")]
                    public void* byref;

                    [FieldOffset(0)]
                    [NativeTypeName("CHAR")]
                    public sbyte cVal;

                    [FieldOffset(0)]
                    [NativeTypeName("USHORT")]
                    public ushort uiVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONG")]
                    public uint ulVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONGLONG")]
                    public ulong ullVal;

                    [FieldOffset(0)]
                    [NativeTypeName("INT")]
                    public int intVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UINT")]
                    public uint uintVal;

                    [FieldOffset(0)]
                    [NativeTypeName("DECIMAL *")]
                    public DECIMAL* pdecVal;

                    [FieldOffset(0)]
                    [NativeTypeName("CHAR *")]
                    public sbyte* pcVal;

                    [FieldOffset(0)]
                    [NativeTypeName("USHORT *")]
                    public ushort* puiVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONG *")]
                    public uint* pulVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONGLONG *")]
                    public ulong* pullVal;

                    [FieldOffset(0)]
                    [NativeTypeName("INT *")]
                    public int* pintVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UINT *")]
                    public uint* puintVal;

                    [FieldOffset(0)]
                    [NativeTypeName("tagVARIANT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:525:17)")]
                    public _Anonymous_e__Struct Anonymous;

                    public unsafe partial struct _Anonymous_e__Struct
                    {
                        [NativeTypeName("PVOID")]
                        public void* pvRecord;

                        [NativeTypeName("IRecordInfo *")]
                        public IRecordInfo* pRecInfo;
                    }
                }
            }
        }
    }
}
