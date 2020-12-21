// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C74A3ADC-B727-4500-A84A-B526721C8B8C")]
    [NativeTypeName("struct ISpeechObjectToken : IDispatch")]
    public unsafe partial struct ISpeechObjectToken
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, uint>)(lpVtbl[1]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, uint>)(lpVtbl[2]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, uint*, int>)(lpVtbl[3]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("BSTR *")] ushort** ObjectId)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ushort**, int>)(lpVtbl[7]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DataKey([NativeTypeName("ISpeechDataKey **")] ISpeechDataKey** DataKey)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ISpeechDataKey**, int>)(lpVtbl[8]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), DataKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Category([NativeTypeName("ISpeechObjectTokenCategory **")] ISpeechObjectTokenCategory** Category)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ISpeechObjectTokenCategory**, int>)(lpVtbl[9]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Category);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("long")] int Locale, [NativeTypeName("BSTR *")] ushort** Description)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, int, ushort**, int>)(lpVtbl[10]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Locale, Description);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("BSTR")] ushort* Id, [NativeTypeName("BSTR")] ushort* CategoryID = null, [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ushort*, ushort*, short, int>)(lpVtbl[11]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Id, CategoryID, CreateIfNotExist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttribute([NativeTypeName("BSTR")] ushort* AttributeName, [NativeTypeName("BSTR *")] ushort** AttributeValue)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ushort*, ushort**, int>)(lpVtbl[12]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), AttributeName, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, SpeechTokenContext ClsContext, [NativeTypeName("IUnknown **")] IUnknown** Object)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, IUnknown*, SpeechTokenContext, IUnknown**, int>)(lpVtbl[13]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), pUnkOuter, ClsContext, Object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Remove([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ushort*, int>)(lpVtbl[14]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStorageFileName([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID, [NativeTypeName("BSTR")] ushort* KeyName, [NativeTypeName("BSTR")] ushort* FileName, SpeechTokenShellFolder Folder, [NativeTypeName("BSTR *")] ushort** FilePath)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ushort*, ushort*, ushort*, SpeechTokenShellFolder, ushort**, int>)(lpVtbl[15]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID, KeyName, FileName, Folder, FilePath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveStorageFileName([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID, [NativeTypeName("BSTR")] ushort* KeyName, [NativeTypeName("VARIANT_BOOL")] short DeleteFile)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ushort*, ushort*, short, int>)(lpVtbl[16]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID, KeyName, DeleteFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsUISupported([NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, [NativeTypeName("IUnknown *")] IUnknown* Object, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ushort*, VARIANT*, IUnknown*, short*, int>)(lpVtbl[17]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), TypeOfUI, ExtraData, Object, Supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisplayUI([NativeTypeName("long")] int hWnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null, [NativeTypeName("IUnknown *")] IUnknown* Object = null)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, int, ushort*, ushort*, VARIANT*, IUnknown*, int>)(lpVtbl[18]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), hWnd, Title, TypeOfUI, ExtraData, Object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesAttributes([NativeTypeName("BSTR")] ushort* Attributes, [NativeTypeName("VARIANT_BOOL *")] short* Matches)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechObjectToken*, ushort*, short*, int>)(lpVtbl[19]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Attributes, Matches);
        }
    }
}
