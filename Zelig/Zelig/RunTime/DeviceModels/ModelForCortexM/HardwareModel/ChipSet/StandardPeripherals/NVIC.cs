//
// Copyright (c) Microsoft Corporation.    All rights reserved.
//

namespace Microsoft.DeviceModels.Chipset.CortexM
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.Zelig.Runtime;

    //--//

    // TODO: put right addresses, and fix code generation for LLVM that does not understand the attribute's constants
    //[MemoryMappedPeripheral(Base = 0x40D00000U, Length = 0x000000D0U)]
    public class NVIC
    {
        //
        // Access Methods
        //

        public static extern NVIC Instance
        {
            [SingletonFactory()]
            [MethodImpl(MethodImplOptions.InternalCall)]
            get;
        }
    }
}