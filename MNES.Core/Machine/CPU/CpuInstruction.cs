﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnes.Core.Machine.CPU;

public class CpuInstruction
{
    /// <summary> Iterates through each clock cycle of a CPU instruction. </summary>
    public delegate void ProcessDelegate(MachineState state);

    public string Name { get; init; }
    public byte OpCode { get; init; }
    public int Bytes { get; init; }
    public bool Illegal { get; init; }
    public ProcessDelegate[] Process { get; init; }
}
