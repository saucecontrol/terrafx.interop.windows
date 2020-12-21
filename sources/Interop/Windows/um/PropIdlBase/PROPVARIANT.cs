// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPVARIANT
    {
        [NativeTypeName("tagPROPVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/PropIdlBase.h:295:3)")]
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

        public unsafe ref LARGE_INTEGER hVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.hVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->hVal;
#endif
            }
        }

        public unsafe ref ULARGE_INTEGER uhVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.uhVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->uhVal;
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

        public unsafe ref FILETIME filetime
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.filetime, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->filetime;
#endif
            }
        }

        public unsafe ref Guid* puuid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->puuid;
            }
        }

        public unsafe ref CLIPDATA* pclipdata
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pclipdata;
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

        public unsafe ref BSTRBLOB bstrblobVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.bstrblobVal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->bstrblobVal;
#endif
            }
        }

        public unsafe ref BLOB blob
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.blob, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->blob;
#endif
            }
        }

        public unsafe ref sbyte* pszVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pszVal;
            }
        }

        public unsafe ref ushort* pwszVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pwszVal;
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

        public unsafe ref IStream* pStream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pStream;
            }
        }

        public unsafe ref IStorage* pStorage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pStorage;
            }
        }

        public unsafe ref VERSIONEDSTREAM* pVersionedStream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pVersionedStream;
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

        public unsafe ref CAC cac
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cac, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cac;
#endif
            }
        }

        public unsafe ref CAUB caub
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caub, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->caub;
#endif
            }
        }

        public unsafe ref CAI cai
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cai, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cai;
#endif
            }
        }

        public unsafe ref CAUI caui
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caui, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->caui;
#endif
            }
        }

        public unsafe ref CAL cal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cal, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cal;
#endif
            }
        }

        public unsafe ref CAUL caul
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caul, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->caul;
#endif
            }
        }

        public unsafe ref CAH cah
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cah, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cah;
#endif
            }
        }

        public unsafe ref CAUH cauh
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cauh, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cauh;
#endif
            }
        }

        public unsafe ref CAFLT caflt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caflt, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->caflt;
#endif
            }
        }

        public unsafe ref CADBL cadbl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cadbl, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cadbl;
#endif
            }
        }

        public unsafe ref CABOOL cabool
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cabool, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cabool;
#endif
            }
        }

        public unsafe ref CASCODE cascode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cascode, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cascode;
#endif
            }
        }

        public unsafe ref CACY cacy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cacy, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cacy;
#endif
            }
        }

        public unsafe ref CADATE cadate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cadate, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cadate;
#endif
            }
        }

        public unsafe ref CAFILETIME cafiletime
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cafiletime, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cafiletime;
#endif
            }
        }

        public unsafe ref CACLSID cauuid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cauuid, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cauuid;
#endif
            }
        }

        public unsafe ref CACLIPDATA caclipdata
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caclipdata, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->caclipdata;
#endif
            }
        }

        public unsafe ref CABSTR cabstr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cabstr, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cabstr;
#endif
            }
        }

        public unsafe ref CABSTRBLOB cabstrblob
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cabstrblob, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->cabstrblob;
#endif
            }
        }

        public unsafe ref CALPSTR calpstr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.calpstr, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->calpstr;
#endif
            }
        }

        public unsafe ref CALPWSTR calpwstr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.calpwstr, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->calpwstr;
#endif
            }
        }

        public unsafe ref CAPROPVARIANT capropvar
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.capropvar, 1));
#else
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->capropvar;
#endif
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

        public unsafe ref ushort* puiVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->puiVal;
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

        public unsafe ref uint* pulVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pulVal;
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

        public unsafe ref DECIMAL* pdecVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pdecVal;
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

        public unsafe ref PROPVARIANT* pvarVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous.Anonymous.Anonymous))->pvarVal;
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
            [NativeTypeName("tagPROPVARIANT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/PropIdlBase.h:297:1)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            public DECIMAL decVal;

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("VARTYPE")]
                public ushort vt;

                [NativeTypeName("PROPVAR_PAD1")]
                public ushort wReserved1;

                [NativeTypeName("PROPVAR_PAD2")]
                public ushort wReserved2;

                [NativeTypeName("PROPVAR_PAD3")]
                public ushort wReserved3;

                [NativeTypeName("tagPROPVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/PropIdlBase.h:303:43)")]
                public _Anonymous_e__Union Anonymous;

                [StructLayout(LayoutKind.Explicit)]
                public unsafe partial struct _Anonymous_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("CHAR")]
                    public sbyte cVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UCHAR")]
                    public byte bVal;

                    [FieldOffset(0)]
                    [NativeTypeName("SHORT")]
                    public short iVal;

                    [FieldOffset(0)]
                    [NativeTypeName("USHORT")]
                    public ushort uiVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LONG")]
                    public int lVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONG")]
                    public uint ulVal;

                    [FieldOffset(0)]
                    [NativeTypeName("INT")]
                    public int intVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UINT")]
                    public uint uintVal;

                    [FieldOffset(0)]
                    public LARGE_INTEGER hVal;

                    [FieldOffset(0)]
                    public ULARGE_INTEGER uhVal;

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
                    public FILETIME filetime;

                    [FieldOffset(0)]
                    [NativeTypeName("CLSID *")]
                    public Guid* puuid;

                    [FieldOffset(0)]
                    [NativeTypeName("CLIPDATA *")]
                    public CLIPDATA* pclipdata;

                    [FieldOffset(0)]
                    [NativeTypeName("BSTR")]
                    public ushort* bstrVal;

                    [FieldOffset(0)]
                    public BSTRBLOB bstrblobVal;

                    [FieldOffset(0)]
                    public BLOB blob;

                    [FieldOffset(0)]
                    [NativeTypeName("LPSTR")]
                    public sbyte* pszVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LPWSTR")]
                    public ushort* pwszVal;

                    [FieldOffset(0)]
                    [NativeTypeName("IUnknown *")]
                    public IUnknown* punkVal;

                    [FieldOffset(0)]
                    [NativeTypeName("IDispatch *")]
                    public IDispatch* pdispVal;

                    [FieldOffset(0)]
                    [NativeTypeName("IStream *")]
                    public IStream* pStream;

                    [FieldOffset(0)]
                    [NativeTypeName("IStorage *")]
                    public IStorage* pStorage;

                    [FieldOffset(0)]
                    [NativeTypeName("LPVERSIONEDSTREAM")]
                    public VERSIONEDSTREAM* pVersionedStream;

                    [FieldOffset(0)]
                    [NativeTypeName("LPSAFEARRAY")]
                    public SAFEARRAY* parray;

                    [FieldOffset(0)]
                    public CAC cac;

                    [FieldOffset(0)]
                    public CAUB caub;

                    [FieldOffset(0)]
                    public CAI cai;

                    [FieldOffset(0)]
                    public CAUI caui;

                    [FieldOffset(0)]
                    public CAL cal;

                    [FieldOffset(0)]
                    public CAUL caul;

                    [FieldOffset(0)]
                    public CAH cah;

                    [FieldOffset(0)]
                    public CAUH cauh;

                    [FieldOffset(0)]
                    public CAFLT caflt;

                    [FieldOffset(0)]
                    public CADBL cadbl;

                    [FieldOffset(0)]
                    public CABOOL cabool;

                    [FieldOffset(0)]
                    public CASCODE cascode;

                    [FieldOffset(0)]
                    public CACY cacy;

                    [FieldOffset(0)]
                    public CADATE cadate;

                    [FieldOffset(0)]
                    public CAFILETIME cafiletime;

                    [FieldOffset(0)]
                    public CACLSID cauuid;

                    [FieldOffset(0)]
                    public CACLIPDATA caclipdata;

                    [FieldOffset(0)]
                    public CABSTR cabstr;

                    [FieldOffset(0)]
                    public CABSTRBLOB cabstrblob;

                    [FieldOffset(0)]
                    public CALPSTR calpstr;

                    [FieldOffset(0)]
                    public CALPWSTR calpwstr;

                    [FieldOffset(0)]
                    public CAPROPVARIANT capropvar;

                    [FieldOffset(0)]
                    [NativeTypeName("CHAR *")]
                    public sbyte* pcVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UCHAR *")]
                    public byte* pbVal;

                    [FieldOffset(0)]
                    [NativeTypeName("SHORT *")]
                    public short* piVal;

                    [FieldOffset(0)]
                    [NativeTypeName("USHORT *")]
                    public ushort* puiVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LONG *")]
                    public int* plVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONG *")]
                    public uint* pulVal;

                    [FieldOffset(0)]
                    [NativeTypeName("INT *")]
                    public int* pintVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UINT *")]
                    public uint* puintVal;

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
                    [NativeTypeName("DECIMAL *")]
                    public DECIMAL* pdecVal;

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
                    [NativeTypeName("LPSAFEARRAY *")]
                    public SAFEARRAY** pparray;

                    [FieldOffset(0)]
                    [NativeTypeName("PROPVARIANT *")]
                    public PROPVARIANT* pvarVal;
                }
            }
        }
    }
}
