// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9169896C-AC8D-4E7D-94E5-67FA4DC2F2E8")]
    [NativeTypeName("struct IUIAnimationManager : IUnknown")]
    public unsafe partial struct IUIAnimationManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, uint>)(lpVtbl[1]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, uint>)(lpVtbl[2]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAnimationVariable([NativeTypeName("DOUBLE")] double initialValue, [NativeTypeName("IUIAnimationVariable **")] IUIAnimationVariable** variable)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, double, IUIAnimationVariable**, int>)(lpVtbl[3]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), initialValue, variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ScheduleTransition([NativeTypeName("IUIAnimationVariable *")] IUIAnimationVariable* variable, [NativeTypeName("IUIAnimationTransition *")] IUIAnimationTransition* transition, [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, IUIAnimationVariable*, IUIAnimationTransition*, double, int>)(lpVtbl[4]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), variable, transition, timeNow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStoryboard([NativeTypeName("IUIAnimationStoryboard **")] IUIAnimationStoryboard** storyboard)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, IUIAnimationStoryboard**, int>)(lpVtbl[5]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FinishAllStoryboards([NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, double, int>)(lpVtbl[6]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), completionDeadline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AbandonAllStoryboards()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, int>)(lpVtbl[7]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow, [NativeTypeName("UI_ANIMATION_UPDATE_RESULT *")] UI_ANIMATION_UPDATE_RESULT* updateResult = null)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, double, UI_ANIMATION_UPDATE_RESULT*, int>)(lpVtbl[8]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), timeNow, updateResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVariableFromTag([NativeTypeName("IUnknown *")] IUnknown* @object, [NativeTypeName("UINT32")] uint id, [NativeTypeName("IUIAnimationVariable **")] IUIAnimationVariable** variable)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, IUnknown*, uint, IUIAnimationVariable**, int>)(lpVtbl[9]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), @object, id, variable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStoryboardFromTag([NativeTypeName("IUnknown *")] IUnknown* @object, [NativeTypeName("UINT32")] uint id, [NativeTypeName("IUIAnimationStoryboard **")] IUIAnimationStoryboard** storyboard)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, IUnknown*, uint, IUIAnimationStoryboard**, int>)(lpVtbl[10]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), @object, id, storyboard);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("UI_ANIMATION_MANAGER_STATUS *")] UI_ANIMATION_MANAGER_STATUS* status)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, UI_ANIMATION_MANAGER_STATUS*, int>)(lpVtbl[11]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAnimationMode(UI_ANIMATION_MODE mode)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, UI_ANIMATION_MODE, int>)(lpVtbl[12]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, int>)(lpVtbl[13]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, int>)(lpVtbl[14]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetManagerEventHandler([NativeTypeName("IUIAnimationManagerEventHandler *")] IUIAnimationManagerEventHandler* handler)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, IUIAnimationManagerEventHandler*, int>)(lpVtbl[15]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCancelPriorityComparison([NativeTypeName("IUIAnimationPriorityComparison *")] IUIAnimationPriorityComparison* comparison)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, IUIAnimationPriorityComparison*, int>)(lpVtbl[16]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrimPriorityComparison([NativeTypeName("IUIAnimationPriorityComparison *")] IUIAnimationPriorityComparison* comparison)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, IUIAnimationPriorityComparison*, int>)(lpVtbl[17]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompressPriorityComparison([NativeTypeName("IUIAnimationPriorityComparison *")] IUIAnimationPriorityComparison* comparison)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, IUIAnimationPriorityComparison*, int>)(lpVtbl[18]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetConcludePriorityComparison([NativeTypeName("IUIAnimationPriorityComparison *")] IUIAnimationPriorityComparison* comparison)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, IUIAnimationPriorityComparison*, int>)(lpVtbl[19]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), comparison);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultLongestAcceptableDelay([NativeTypeName("UI_ANIMATION_SECONDS")] double delay)
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, double, int>)(lpVtbl[20]))((IUIAnimationManager*)Unsafe.AsPointer(ref this), delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged[Stdcall]<IUIAnimationManager*, int>)(lpVtbl[21]))((IUIAnimationManager*)Unsafe.AsPointer(ref this));
        }
    }
}
