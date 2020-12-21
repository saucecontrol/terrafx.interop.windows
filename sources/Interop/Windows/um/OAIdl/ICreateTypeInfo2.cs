// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0002040E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICreateTypeInfo2 : ICreateTypeInfo")]
    public unsafe partial struct ICreateTypeInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint>)(lpVtbl[1]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint>)(lpVtbl[2]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, Guid*, int>)(lpVtbl[3]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTypeFlags([NativeTypeName("UINT")] uint uTypeFlags)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, int>)(lpVtbl[4]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), uTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* pStrDoc)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, ushort*, int>)(lpVtbl[5]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, int>)(lpVtbl[6]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, ushort, ushort, int>)(lpVtbl[7]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddRefTypeInfo([NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)(lpVtbl[8]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, FUNCDESC*, int>)(lpVtbl[9]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pFuncDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[10]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, hRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int implTypeFlags)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, int, int>)(lpVtbl[11]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, implTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, ushort, int>)(lpVtbl[12]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), cbAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSchema([NativeTypeName("LPOLESTR")] ushort* pStrSchema)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, ushort*, int>)(lpVtbl[13]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrSchema);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, VARDESC*, int>)(lpVtbl[14]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pVarDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFuncAndParamNames([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, ushort**, uint, int>)(lpVtbl[15]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVarName([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, ushort*, int>)(lpVtbl[16]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTypeDescAlias([NativeTypeName("TYPEDESC *")] TYPEDESC* pTDescAlias)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, TYPEDESC*, int>)(lpVtbl[17]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTDescAlias);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DefineFuncAsDllEntry([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, ushort*, ushort*, int>)(lpVtbl[18]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFuncDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, ushort*, int>)(lpVtbl[19]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVarDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, ushort*, int>)(lpVtbl[20]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFuncHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[21]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVarHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[22]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMops([NativeTypeName("UINT")] uint index, [NativeTypeName("BSTR")] ushort* bstrMops)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, ushort*, int>)(lpVtbl[23]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, bstrMops);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTypeIdldesc([NativeTypeName("IDLDESC *")] IDLDESC* pIdlDesc)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, IDLDESC*, int>)(lpVtbl[24]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pIdlDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LayOut()
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, int>)(lpVtbl[25]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteFuncDesc([NativeTypeName("UINT")] uint index)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, int>)(lpVtbl[26]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteFuncDescByMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, int, INVOKEKIND, int>)(lpVtbl[27]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteVarDesc([NativeTypeName("UINT")] uint index)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, int>)(lpVtbl[28]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteVarDescByMemId([NativeTypeName("MEMBERID")] int memid)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, int, int>)(lpVtbl[29]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteImplType([NativeTypeName("UINT")] uint index)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, int>)(lpVtbl[30]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, Guid*, VARIANT*, int>)(lpVtbl[31]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[32]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, uint, Guid*, VARIANT*, int>)(lpVtbl[33]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[34]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[35]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, int>)(lpVtbl[36]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpStringContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFuncHelpStringContext([NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[37]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVarHelpStringContext([NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[38]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invalidate()
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, int>)(lpVtbl[39]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* unmanaged[Stdcall]<ICreateTypeInfo2*, ushort*, int>)(lpVtbl[40]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), szName);
        }
    }
}
