﻿using Nmars.Instructions.Abstraction;

namespace Nmars.Instructions
{
    public class Sltu : MipsInstruction
    {
        public override string Name => "Set on less than unsigned";
        public override string Description => "If $s is less than $t, $d is set to one. It gets zero otherwise.";
        public override string Operation => "if $s < $t $d = 1; advance_pc (4); else $d = 0; advance_pc (4);";
        public override string Syntax => "sltu $d, $s, $t";
        public override string Encoding => "0000 00ss ssst tttt dddd d000 0010 1011";
    }
}